// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DictionaryExtensions.cs" company="Terry D. Eppler">
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
//   DictionaryExtensions.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class DictionaryExtensions
    {
        /// <summary> Adds the or update. </summary>
        /// <typeparam name="TKey"> The type of the key. </typeparam>
        /// <typeparam name="TValue"> The type of the value. </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="key"> The key. </param>
        /// <param name="value"> The value. </param>
        /// <returns> </returns>
        public static TValue AddOrUpdate<TKey, TValue>( this IDictionary<TKey, TValue> dict,
                                                        TKey key, TValue value )
        {
            if( !dict.ContainsKey( key ) )
            {
                try
                {
                    dict.Add( new KeyValuePair<TKey, TValue>( key, value ) );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( TValue );
                }
            }
            else
            {
                dict[ key ] = value;
            }

            return dict[ key ];
        }

        /// <summary> Predicates the specified logic. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static string ToCriteria( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _criteria = "";
                    if( dict.HasPrimaryKey( ) )
                    {
                        var _key = dict.GetPrimaryKey( );
                        if( !string.IsNullOrEmpty( _key.Key )
                           & int.Parse( _key.Value.ToString( ) ) > -1 )
                        {
                            foreach( var _kvp in dict )
                            {
                                _criteria += $"{_kvp.Key} = '{_kvp.Value}' AND ";
                            }

                            var _sql = _criteria.TrimEnd( " AND ".ToCharArray( ) );
                            _sql += $" WHERE {_key.Key} = {int.Parse( _key.Value.ToString( ) )};";
                            return !string.IsNullOrEmpty( _sql )
                                ? _sql
                                : string.Empty;
                        }
                    }
                    else if( !dict.HasPrimaryKey( ) )
                    {
                        foreach( var _kvp in dict )
                        {
                            _criteria += $"{_kvp.Key} = '{_kvp.Value}' AND ";
                        }

                        var _sql = _criteria.TrimEnd( " AND ".ToCharArray( ) );
                        return !string.IsNullOrEmpty( _sql )
                            ? _sql
                            : string.Empty;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Converts to sorteddictionary. </summary>
        /// <typeparam name="TKey"> The type of the key. </typeparam>
        /// <typeparam name="TValue"> The type of the value. </typeparam>
        /// <param name="nvc"> The this. </param>
        /// <returns> </returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> nvc )
        {
            try
            {
                return new SortedDictionary<TKey, TValue>( nvc );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( SortedDictionary<TKey, TValue> );
            }
        }

        /// <summary> Converts to bindinglist. </summary>
        /// <param name="nvc"> The NVC. </param>
        /// <returns> </returns>
        public static BindingList<KeyValuePair<string, object>> ToBindingList(
            this IDictionary<string, object> nvc )
        {
            try
            {
                var _bindingList = new BindingList<KeyValuePair<string, object>>( );
                foreach( var _kvp in nvc )
                {
                    _bindingList.Add( _kvp );
                }

                return _bindingList?.Any( ) == true
                    ? _bindingList
                    : default( BindingList<KeyValuePair<string, object>> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( BindingList<KeyValuePair<string, object>> );
            }
        }

        /// <summary> Converts to sorted dictionary. </summary>
        /// <typeparam name="TKey"> The type of the key. </typeparam>
        /// <typeparam name="TValue"> The type of the value. </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(
            this IDictionary<TKey, TValue> dict )
        {
            try
            {
                return new SortedList<TKey, TValue>( dict );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( SortedList<TKey, TValue> );
            }
        }

        /// <summary> Converts to sql db parameters. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="provider"> The provider. </param>
        /// <returns> </returns>
        public static IEnumerable<DbParameter> ToSqlDbParameters(
            this IDictionary<string, object> dict, Provider provider )
        {
            if( ( dict?.Keys?.Count > 0 )
               && Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    var _columns = dict.Keys.ToArray( );
                    var _values = dict.Values.ToArray( );
                    switch( provider )
                    {
                        case Provider.SQLite:

                        {
                            var _sqlite = new List<SQLiteParameter>( );
                            for( var _i = 0; _i < _columns.Length; _i++ )
                            {
                                var _parameter = new SQLiteParameter
                                {
                                    SourceColumn = _columns[ _i ],
                                    Value = _values[ _i ]
                                };

                                _sqlite.Add( _parameter );
                            }

                            return _sqlite.Any( )
                                ? _sqlite.ToArray( )
                                : default( List<DbParameter> );
                        }

                        case Provider.SqlCe:

                        {
                            var _sqlce = new List<SqlCeParameter>( );
                            for( var _i = 0; _i < _columns.Length; _i++ )
                            {
                                var _parameter = new SqlCeParameter
                                {
                                    SourceColumn = _columns[ _i ],
                                    Value = _values[ _i ]
                                };

                                _sqlce.Add( _parameter );
                            }

                            return _sqlce.Any( )
                                ? _sqlce.ToArray( )
                                : default( List<DbParameter> );
                        }

                        case Provider.OleDb:
                        case Provider.Excel:
                        case Provider.Access:

                        {
                            var _oledb = new List<OleDbParameter>( );
                            for( var _i = 0; _i < _columns.Length; _i++ )
                            {
                                var _parameter = new OleDbParameter
                                {
                                    SourceColumn = _columns[ _i ],
                                    Value = _values[ _i ]
                                };

                                _oledb.Add( _parameter );
                            }

                            return _oledb.Any( )
                                ? _oledb.ToArray( )
                                : default( List<DbParameter> );
                        }

                        case Provider.SqlServer:

                        {
                            var _sqlserver = new List<SqlParameter>( );
                            for( var _i = 0; _i < _columns.Length; _i++ )
                            {
                                var _parameter = new SqlParameter
                                {
                                    SourceColumn = _columns[ _i ],
                                    Value = _values[ _i ]
                                };

                                _sqlserver.Add( _parameter );
                            }

                            return _sqlserver?.Any( ) == true
                                ? _sqlserver.ToArray( )
                                : default( List<DbParameter> );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( List<DbParameter> );
                }

                return default( List<DbParameter> );
            }

            return default( List<DbParameter> );
        }

        /// <summary> Determines whether [has a primary key]. </summary>
        /// <param name="dict"> The row. </param>
        /// <returns>
        /// <c> true </c>
        /// if [has primary key] [the specified row]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public static bool HasPrimaryKey( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _array = dict.Keys?.ToArray( );
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    var _count = 0;
                    for( var _i = 1; _i < _array.Length; _i++ )
                    {
                        var _name = _array[ _i ];
                        if( _names.Contains( _name ) )
                        {
                            _count++;
                        }
                    }

                    return _count > 0;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( bool );
                }
            }

            return false;
        }

        /// <summary> Gets the primary key. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static KeyValuePair<string, object> GetPrimaryKey(
            this IDictionary<string, object> dict )
        {
            if( ( dict?.Any( ) == true )
               && dict.HasPrimaryKey( ) )
            {
                try
                {
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    foreach( var _kvp in dict )
                    {
                        if( _names.Contains( _kvp.Key ) )
                        {
                            return new KeyValuePair<string, object>( _kvp.Key, _kvp.Value );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( KeyValuePair<string, object> );
                }
            }

            return default( KeyValuePair<string, object> );
        }

        /// <summary> Converts to Key bindinglist. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static BindingList<string> ToKeyBindingList<T>(
            this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<string>( );
                    foreach( var _kvp in dict )
                    {
                        _list.Add( _kvp.Key );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( BindingList<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( BindingList<string> );
                }
            }

            return default( BindingList<string> );
        }

        /// <summary> Converts to value bindinglist. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static BindingList<object> ToValueBindingList<T>(
            this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<object>( );
                    foreach( var _kvp in dict )
                    {
                        _list.Add( _kvp.Value );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( BindingList<object> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( BindingList<object> );
                }
            }

            return default( BindingList<object> );
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}