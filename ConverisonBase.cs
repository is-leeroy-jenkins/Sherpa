//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ConverisonBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ConverisonBase.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    ConverisonBase.cs
//  </summary>
//  ******************************************************************************************

using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using log4net;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class ConverisonBase : IDisposable
    {
        /// <summary>
        /// The cancelled
        /// </summary>
        private protected bool _cancelled;

        /// <summary>
        /// The keys
        /// </summary>
        private protected readonly Regex _keys =
            new Regex( @"(([a-zA-ZäöüÄÖÜß0-9\.]|(\s+))+)(\(\-\))?" );

        /// <summary>
        /// The log
        /// </summary>
        private protected readonly ILog _log = LogManager.GetLogger( typeof( SqlServerConverter ) );

        /// <summary>
        /// The value
        /// </summary>
        private protected readonly Regex _value = new Regex( @"\(N(\'.*\')\)" );

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        private protected bool _isActive;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is disposed;
        /// otherwise, <c>false</c>.
        /// </value>
        private protected bool _isDisposed;

        /// <summary>
        /// Cancels the conversion.
        /// </summary>
        public void CancelConversion( )
        {
            _cancelled = true;
        }

        /// <summary>
        /// Checks the cancelled.
        /// </summary>
        /// <exception cref="ApplicationException">
        /// User cancelled the conversion
        /// </exception>
        private protected void CheckCancelled( )
        {
            var _message = "User Cancelled the Conversion";
            if( _cancelled )
            {
                var _ex = new DataException( _message );
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adjusts the default value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private protected string AdjustDefaultColumnValue( string value )
        {
            try
            {
                ThrowIf.NullOrEmpty( value, nameof( value ) );
                if( string.IsNullOrEmpty( value ) )
                {
                    return value;
                }

                var _match = _value.Match( value );
                return _match.Success
                    ? _match.Groups[ 1 ].Value
                    : value;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Fixes the default value string.
        /// </summary>
        /// <param name="value">
        /// The column default.
        /// </param>
        /// <returns></returns>
        private protected string CorrectDefaultColumnValue( string value )
        {
            try
            {
                ThrowIf.NullOrEmpty( value, nameof( value ) );
                var _replaced = false;
                var _res = value.Trim( );
                var _first = -1;
                var _last = -1;
                for( var _i = 0; _i < _res.Length; _i++ )
                {
                    if( _res[ _i ] == '\''
                       && _first == -1 )
                    {
                        _first = _i;
                    }

                    if( _res[ _i ] == '\''
                       && _first != -1
                       && _i > _last )
                    {
                        _last = _i;
                    }
                }

                if( _first != -1
                   && _last > _first )
                {
                    return _res.Substring( _first, _last - _first + 1 );
                }

                var _builder = new StringBuilder( );
                for( var _i = 0; _i < _res.Length; _i++ )
                {
                    if( _res[ _i ] != '('
                       && _res[ _i ] != ')' )
                    {
                        _builder.Append( _res[ _i ] );
                        _replaced = true;
                    }
                }

                return _replaced
                    ? "(" + _builder + ")"
                    : _builder.ToString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Validates the type of the data.
        /// </summary>
        /// <param name="dataType">Type of the data.
        /// </param>
        /// <exception cref="ApplicationException">
        /// Validation failed for Data type [" + dataType + "]
        /// </exception>
        private protected void VerifySqlServerType( string dataType )
        {
            try
            {
                ThrowIf.NullOrEmpty( dataType, nameof( dataType ) );
                var _type = dataType.ToUpper( );
                var _types = Enum.GetNames( typeof( SqlServer ) );
                if( _types.Contains( _type ) )
                {
                }
                else
                {
                    var _message = @$"Validation Failed For [ {dataType} ]";
                    throw new ApplicationException( _message );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Builds the SQL server table query.
        /// </summary>
        /// <param name="table">The ts.</param>
        /// <returns></returns>
        private string CreateSqlServerTableQuery( TableSchema table )
        {
            var _builder = new StringBuilder( );
            _builder.Append( "SELECT " );
            for( var _i = 0; _i < table.Columns.Count; _i++ )
            {
                _builder.Append( "[" + table.Columns[ _i ].ColumnName + "]" );
                if( _i < table.Columns.Count - 1 )
                {
                    _builder.Append( ", " );
                }
            }

            var _sql = " FROM " + table.TableSchemaName + "." + "[" + table.TableName + "]";

            _builder.Append( _sql );

            return _builder?.ToString( );
        }

        /// <summary>
        /// Casts the value for column.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="column">The column schema.</param>
        /// <returns>
        /// </returns>
        private object CastValueForColumn( object value, ColumnSchema column )
        {
            if( value is DBNull )
            {
                return null;
            }

            var _dbType = Enum.Parse( typeof( DbType ), column.ColumnType );
            switch( _dbType )
            {
                case DbType.Int32:
                {
                    switch( value )
                    {
                        case short _s:
                        {
                            return (int)_s;
                        }
                        case byte _b:
                        {
                            return (int)_b;
                        }
                        case long _l:
                        {
                            return (int)_l;
                        }
                        case decimal _val1:
                        {
                            return (int)_val1;
                        }
                    }

                    break;
                }
                case DbType.Int16:
                {
                    switch( value )
                    {
                        case int _i:
                        {
                            return (short)_i;
                        }
                        case byte _b:
                        {
                            return (short)_b;
                        }
                        case long _l:
                        {
                            return (short)_l;
                        }
                        case decimal _val1:
                        {
                            return (short)_val1;
                        }
                    }

                    break;
                }
                case DbType.Int64:
                {
                    switch( value )
                    {
                        case int _i:
                        {
                            return (long)_i;
                        }
                        case short _s:
                        {
                            return (long)_s;
                        }
                        case byte _b:
                        {
                            return (long)_b;
                        }
                        case decimal _val1:
                        {
                            return (long)_val1;
                        }
                    }

                    break;
                }
                case DbType.Single:
                {
                    switch( value )
                    {
                        case double _d:
                        {
                            return (float)_d;
                        }
                        case decimal _val1:
                        {
                            return (float)_val1;
                        }
                    }

                    break;
                }
                case DbType.Double:
                {
                    switch( value )
                    {
                        case float _f:
                        {
                            return (double)_f;
                        }
                        case double _d:
                        {
                            return _d;
                        }
                        case decimal _val1:
                        {
                            return (double)_val1;
                        }
                    }

                    break;
                }
                case DbType.String:
                {
                    if( value is Guid _guid )
                    {
                        return _guid.ToString( );
                    }

                    break;
                }
                case DbType.Guid:
                {
                    switch( value )
                    {
                        case string _s:
                        {
                            return ParseStringAsGuid( _s );
                        }
                        case byte[ ] _bytes:
                        {
                            return ParseBlobAsGuid( _bytes );
                        }
                    }

                    break;
                }

                case DbType.Binary:
                case DbType.Boolean:
                case DbType.DateTime:
                {
                    break;
                }
                default:
                {
                    _log.Error( "argument exception - illegal database type" );
                    throw new ArgumentException( "Illegal database type ["
                        + Enum.GetName( typeof( DbType ), _dbType ) + "]" );
                }
            }

            return value;
        }

        /// <summary>
        /// Parses the BLOB as unique identifier.
        /// </summary>
        /// <param name="blob">The BLOB.</param>
        /// <returns></returns>
        private Guid ParseBlobAsGuid( IEnumerable<byte> blob )
        {
            var _data = blob.ToArray( );
            switch( blob.Count( ) )
            {
                case 16:
                {
                    _data = new byte[ 16 ];
                    for( var _i = 0; _i < 16; _i++ )
                    {
                        _data[ _i ] = blob.ToArray( )[ _i ];
                    }

                    break;
                }
                case 17:
                {
                    _data = new byte[ 16 ];
                    for( var _i = 0; _i < blob.Count( ); _i++ )
                    {
                        _data[ _i ] = blob.ToArray( )[ _i ];
                    }

                    break;
                }
            }

            return new Guid( _data );
        }

        /// <summary>
        /// Parses the string as unique identifier.
        /// </summary>
        /// <param name="text">The string.</param>
        /// <returns></returns>
        private Guid ParseStringAsGuid( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                return new Guid( text );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return Guid.Empty;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs application-defined tasks associated
        /// with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose( )
        {
            Dispose( true );
            GC.SuppressFinalize( this );
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c>
        /// to release both managed and
        /// unmanaged resources; <c>false</c>
        /// to release only unmanaged resources.
        /// </param>
        private protected void Dispose( bool disposing )
        {
            if( disposing )
            {
                Dispose( );
                _isDisposed = true;
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}