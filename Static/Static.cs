// ************************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              19-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        14-11-2023
// ************************************************************************************************
// <copyright file="Static.cs.cs" company="Terry D. Eppler">
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Eppler, Terry.cs
// </summary>
// ************************************************************************************************
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class Static
    {
        /// <summary> Gets the type of the SQL. </summary>
        /// <param name="type"> The type. </param>
        /// <returns>
        /// string
        /// </returns>
        public static string GetSqlType( this Type type )
        {
            try
            {
                type = Nullable.GetUnderlyingType( type ) ?? type;
                switch( type.Name )
                {
                    case nameof( String ):
                    case nameof( Boolean ):
                    {
                        return "Text";
                    }
                    case nameof( DateTime ):
                    {
                        return "Date";
                    }
                    case nameof( Int32 ):
                    {
                        return nameof( Double );
                    }
                    case nameof( Decimal ):
                    {
                        return "Currency";
                    }
                    default:
                    {
                        return type.Name;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="connection"> The connection. </param>
        /// <param name="sql"> The SQL. </param>
        /// <returns>
        /// IDbCommand
        /// </returns>
        /// <exception cref="System.ArgumentNullException">
        /// connection
        /// </exception>
        public static IDbCommand CreateCommand( this IDbConnection connection, string sql )
        {
            try
            {
                ThrowIf.Null( sql, nameof( sql ) );
                var _command = connection.CreateCommand( );
                _command.CommandText = sql;
                return !string.IsNullOrEmpty( _command?.CommandText )
                    ? _command
                    : default( IDbCommand );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDbCommand );
            }
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="connection"> The connection. </param>
        /// <param name="sql"> The SQL. </param>
        /// <returns>
        /// int
        /// </returns>
        public static int ExecuteNonQuery( this IDbConnection connection, string sql )
        {
            try
            {
                ThrowIf.Null( sql, nameof( sql ) );
                using var _command = connection?.CreateCommand( sql );
                return _command?.ExecuteNonQuery( ) ?? 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }

        /// <summary>
        /// Converts to log string.
        /// </summary>
        /// <param name="ex"> The ex. </param>
        /// <param name="message"> The message. </param>
        /// <returns>
        /// string
        /// </returns>
        public static string ToLogString( this Exception ex, string message )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                var _stringBuilder = new StringBuilder( );
                _stringBuilder.Append( message );
                _stringBuilder.Append( Environment.NewLine );
                var _exception = ex;
                _stringBuilder.Append( "Exception:" );
                _stringBuilder.Append( Environment.NewLine );
                while( _exception != null )
                {
                    _stringBuilder.Append( _exception.Message );
                    _stringBuilder.Append( Environment.NewLine );
                    _exception = _exception.InnerException;
                }

                if( ex.Data != null )
                {
                    foreach( var _i in ex.Data )
                    {
                        _stringBuilder.Append( "Data :" );
                        _stringBuilder.Append( _i );
                        _stringBuilder.Append( Environment.NewLine );
                    }
                }

                if( ex.StackTrace != null )
                {
                    _stringBuilder.Append( "StackTrace:" );
                    _stringBuilder.Append( Environment.NewLine );
                    _stringBuilder.Append( ex.StackTrace );
                    _stringBuilder.Append( Environment.NewLine );
                }

                if( ex.Source != null )
                {
                    _stringBuilder.Append( "ErrorSource:" );
                    _stringBuilder.Append( Environment.NewLine );
                    _stringBuilder.Append( ex.Source );
                    _stringBuilder.Append( Environment.NewLine );
                }

                if( ex.TargetSite != null )
                {
                    _stringBuilder.Append( "TargetSite:" );
                    _stringBuilder.Append( Environment.NewLine );
                    _stringBuilder.Append( ex.TargetSite );
                    _stringBuilder.Append( Environment.NewLine );
                }

                var _baseException = ex.GetBaseException( );
                if( _baseException != null )
                {
                    _stringBuilder.Append( "BaseException:" );
                    _stringBuilder.Append( Environment.NewLine );
                    _stringBuilder.Append( ex.GetBaseException( ) );
                }

                return _stringBuilder.ToString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <param name="nvm"> The NVM. </param>
        /// <returns>
        /// </returns>
        public static IDictionary<string, object> ToDictionary( this NameValueCollection nvm )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>( );
                if( nvm != null )
                {
                    foreach( var _key in nvm.AllKeys )
                    {
                        _dictionary.Add( _key, nvm[ _key ] );
                    }
                }

                return _dictionary;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}