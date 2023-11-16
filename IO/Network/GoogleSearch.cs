// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-16-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="GoogleSearch.cs" company="Terry D. Eppler">
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
//   GoogleSearch.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Google.Apis.Customsearch.v1;
    using Google.Apis.Services;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class GoogleSearch
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public NameValueCollection Config { get; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public string Query { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GoogleSearch"/> class.
        /// </summary>
        public GoogleSearch( )
        {
            Config = ConfigurationManager.AppSettings;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GoogleSearch"/> class.
        /// </summary>
        /// <param name="keywords">
        /// The keywords.
        /// </param>
        public GoogleSearch( string keywords )
        {
            Config = ConfigurationManager.AppSettings;
            Query = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="GoogleSearch"/> class.
        /// </summary>
        /// <param name="search">
        /// The search.
        /// </param>
        public GoogleSearch( GoogleSearch search )
        {
            Config = search.Config;
            Query = search.Query;
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <returns>
        /// </returns>
        public List<GoogleResult> GetResults( )
        {
            if( !string.IsNullOrEmpty( Query ) 
               && Config?.Count > 0 )
            {
                try
                {
                    var _count = 0;
                    var _data = new List<GoogleResult>( );
                    var _init = new BaseClientService.Initializer( );
                    _init.ApiKey = Config[ "ApiKey" ];
                    var _search = new CustomsearchService( _init );
                    var _request = _search
                        ?.Cse
                        ?.List( );

                    _request.Q = Query;
                    _request.Cx = Config[ "SearchEngineId" ];
                    _request.Start = _count;
                    var _list = _request.Execute( )
                        ?.Items
                        ?.ToList( );

                    for( var _i = 0; _i < _list.Count; _i++ )
                    {
                        var _results = new GoogleResult( );
                        _results.Content = _list[ _i ].Snippet;
                        _results.Link = _list[ _i ].Link;
                        _results.Title = _list[ _i ].Title;
                        _results.Name = _list[ _i ].HtmlTitle;
                        _data.Add( _results );
                    }

                    return _data?.Any( ) == true
                        ? _data
                        : default( List<GoogleResult> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( List<GoogleResult> );
                }
            }

            return default( List<GoogleResult> );
        }

        /// <summary>
        /// Deconstructs the specified configuration.
        /// </summary>
        /// <param name="config">
        /// The configuration.
        /// </param>
        /// <param name="query">
        /// The query.
        /// </param>
        public void Deconstruct( out NameValueCollection config, out string query )
        {
            config = Config;
            query = Query;
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}