// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="TriggerBuilder.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   TriggerBuilder.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    public static class TriggerFactory
    {
        /// <summary>
        /// Gets the foreign key triggers.
        /// </summary>
        /// <param name="tableSchema"> The dt. </param>
        /// <returns>
        /// </returns>
        public static IList<TriggerSchema> GetForeignKeyTriggers( TableSchema tableSchema )
        {
            try
            {
                ThrowIf.Null( tableSchema, nameof( tableSchema ) );
                IList<TriggerSchema> _result = new List<TriggerSchema>( );
                foreach( var _foreignKey in tableSchema.ForeignKeys )
                {
                    _result.Add( CreateInsertTrigger( _foreignKey ) );
                    _result.Add( TriggerFactory.CreateUpdateTrigger( _foreignKey ) );
                    _result.Add( TriggerFactory.CreateDeleteTrigger( _foreignKey ) );
                }

                return _result;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<TriggerSchema> );
            }
        }

        /// <summary>
        /// Generates the insert trigger.
        /// </summary>
        /// <param name="foreignKey">
        /// The FKS.
        /// </param>
        /// <returns> </returns>
        public static TriggerSchema CreateInsertTrigger( ForeignKeySchema foreignKey )
        {
            try
            {
                ThrowIf.Null( foreignKey, nameof( foreignKey ) );
                var _schema = new TriggerSchema
                {
                    Name = MakeTriggerName( foreignKey, "fki" ),
                    Type = TriggerType.Before,
                    Event = TriggerEvent.Insert,
                    Table = foreignKey.TableName
                };

                var _columnName = string.Empty;
                if( foreignKey.IsNullable )
                {
                    _columnName = " NEW." + foreignKey.ColumnName + " IS NOT NULL AND";
                }

                _schema.Body = "SELECT RAISE(ROLLBACK, 'insert on table "
                    + foreignKey.TableName
                    + " violates foreign key constraint "
                    + _schema.Name
                    + "')"
                    + " WHERE"
                    + _columnName
                    + " (SELECT "
                    + foreignKey.ForeignColumnName
                    + " FROM "
                    + foreignKey.ForeignTableName
                    + " WHERE "
                    + foreignKey.ForeignColumnName
                    + " = NEW."
                    + foreignKey.ColumnName
                    + ") IS NULL; ";

                return _schema;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( TriggerSchema );
            }
        }

        /// <summary>
        /// Generates the update trigger.
        /// </summary>
        /// <param name="foreignKey">
        /// The FKS.
        /// </param>
        /// <returns>
        /// </returns>
        public static TriggerSchema CreateUpdateTrigger( ForeignKeySchema foreignKey )
        {
            try
            {
                ThrowIf.Null( foreignKey, nameof( foreignKey ) );
                var _schema = new TriggerSchema
                {
                    Name = MakeTriggerName( foreignKey, "fku" ),
                    Type = TriggerType.Before,
                    Event = TriggerEvent.Update,
                    Table = foreignKey.TableName
                };

                var _schemaName = _schema.Name;
                var _empty = string.Empty;
                if( foreignKey.IsNullable )
                {
                    _empty = " NEW." + foreignKey.ColumnName + " IS NOT NULL AND";
                }

                _schema.Body = "SELECT RAISE( ROLLBACK, 'Update on Table "
                    + foreignKey.TableName
                    + " Violates Foreign Key Constraint "
                    + _schemaName
                    + "')"
                    + " WHERE "
                    + _empty
                    + " ( SELECT "
                    + foreignKey.ForeignColumnName
                    + " FROM "
                    + foreignKey.ForeignTableName
                    + " WHERE "
                    + foreignKey.ForeignColumnName
                    + " = NEW."
                    + foreignKey.ColumnName
                    + ") IS NULL;";

                return _schema;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( TriggerSchema );
            }
        }

        /// <summary>
        /// Generates the delete trigger.
        /// </summary>
        /// <param name="foreignKey">
        /// The FKS.
        /// </param>
        /// <returns>
        /// </returns>
        public static TriggerSchema CreateDeleteTrigger( ForeignKeySchema foreignKey )
        {
            try
            {
                ThrowIf.Null( foreignKey, nameof( foreignKey ) );
                var _schema = new TriggerSchema
                {
                    Name = MakeTriggerName( foreignKey, "fkd" ),
                    Type = TriggerType.Before,
                    Event = TriggerEvent.Delete,
                    Table = foreignKey.ForeignTableName
                };

                var _schemaName = _schema.Name;
                _schema.Body = !foreignKey.CascadeOnDelete
                    ? "SELECT RAISE(ROLLBACK, 'DELETE ON TABLE "
                    + foreignKey.ForeignTableName
                    + " Violates Foreign Key Constraint "
                    + _schemaName
                    + "')"
                    + " WHERE (SELECT "
                    + foreignKey.ColumnName
                    + " FROM "
                    + foreignKey.TableName
                    + " WHERE "
                    + foreignKey.ColumnName
                    + " = OLD."
                    + foreignKey.ForeignColumnName
                    + ") IS NOT NULL; "
                    : "DELETE FROM ["
                    + foreignKey.TableName
                    + "] WHERE "
                    + foreignKey.ColumnName
                    + " = OLD."
                    + foreignKey.ForeignColumnName
                    + "; ";

                return _schema;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( TriggerSchema );
            }
        }

        /// <summary>
        /// Makes the name of the trigger.
        /// </summary>
        /// <param name="foreignKey">
        /// The FKS.
        /// </param>
        /// <param name="prefix"> The prefix. </param>
        /// <returns>
        /// </returns>
        private static string MakeTriggerName( ForeignKeySchema foreignKey, string prefix )
        {
            try
            {
                ThrowIf.Null( foreignKey, nameof( foreignKey ) );
                ThrowIf.NullOrEmpty( prefix, nameof( prefix ) );
                return prefix
                    + ""
                    + foreignKey.TableName
                    + ""
                    + foreignKey.ColumnName
                    + ""
                    + foreignKey.ForeignTableName
                    + ""
                    + foreignKey.ForeignColumnName;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        public static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}