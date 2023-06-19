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

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class TriggerBuilder
    {
        /// <summary> Gets the foreign key triggers. </summary>
        /// <param name="dt"> The dt. </param>
        /// <returns> </returns>
        public static IList<TriggerSchema> GetForeignKeyTriggers( TableSchema dt )
        {
            IList<TriggerSchema> _result = new List<TriggerSchema>( );
            foreach( var _fks in dt.ForeignKeys )
            {
                _result.Add( GenerateInsertTrigger( _fks ) );
                _result.Add( GenerateUpdateTrigger( _fks ) );
                _result.Add( GenerateDeleteTrigger( _fks ) );
            }

            return _result;
        }

        /// <summary> Generates the insert trigger. </summary>
        /// <param name="foreignKey"> The FKS. </param>
        /// <returns> </returns>
        public static TriggerSchema GenerateInsertTrigger( ForeignKeySchema foreignKey )
        {
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

            _schema.Body = "SELECT RAISE(ROLLBACK, 'insert on table " + foreignKey.TableName + " violates foreign key constraint " + _schema.Name + "')" + " WHERE" + _columnName + " (SELECT " + foreignKey.ForeignColumnName + " FROM " + foreignKey.ForeignTableName + " WHERE " + foreignKey.ForeignColumnName + " = NEW." + foreignKey.ColumnName + ") IS NULL; ";
            return _schema;
        }

        /// <summary> Generates the update trigger. </summary>
        /// <param name="foreignKey"> The FKS. </param>
        /// <returns> </returns>
        public static TriggerSchema GenerateUpdateTrigger( ForeignKeySchema foreignKey )
        {
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

            _schema.Body = "SELECT RAISE(ROLLBACK, 'update on table " + foreignKey.TableName + " violates foreign key constraint " + _schemaName + "')" + " WHERE" + _empty + " (SELECT " + foreignKey.ForeignColumnName + " FROM " + foreignKey.ForeignTableName + " WHERE " + foreignKey.ForeignColumnName + " = NEW." + foreignKey.ColumnName + ") IS NULL; ";
            return _schema;
        }

        /// <summary> Generates the delete trigger. </summary>
        /// <param name="foreignKey"> The FKS. </param>
        /// <returns> </returns>
        public static TriggerSchema GenerateDeleteTrigger( ForeignKeySchema foreignKey )
        {
            var _schema = new TriggerSchema
            {
                Name = MakeTriggerName( foreignKey, "fkd" ),
                Type = TriggerType.Before,
                Event = TriggerEvent.Delete,
                Table = foreignKey.ForeignTableName
            };

            var _schemaName = _schema.Name;
            _schema.Body = !foreignKey.CascadeOnDelete
                ? "SELECT RAISE(ROLLBACK, 'delete on table " + foreignKey.ForeignTableName + " violates foreign key constraint " + _schemaName + "')" + " WHERE (SELECT " + foreignKey.ColumnName + " FROM " + foreignKey.TableName + " WHERE " + foreignKey.ColumnName + " = OLD." + foreignKey.ForeignColumnName + ") IS NOT NULL; "
                : "DELETE FROM [" + foreignKey.TableName + "] WHERE " + foreignKey.ColumnName + " = OLD." + foreignKey.ForeignColumnName + "; ";

            return _schema;
        }

        /// <summary> Makes the name of the trigger. </summary>
        /// <param name="foreignKey"> The FKS. </param>
        /// <param name="prefix"> The prefix. </param>
        /// <returns> </returns>
        private static string MakeTriggerName( ForeignKeySchema foreignKey, string prefix )
        {
            return prefix + "" + foreignKey.TableName + "" + foreignKey.ColumnName + "" + foreignKey.ForeignTableName + "" + foreignKey.ForeignColumnName;
        }
    }
}