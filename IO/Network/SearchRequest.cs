// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-20-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-20-2024
// ******************************************************************************************
// <copyright file="SearchRequest.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   SearchRequest.cs
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
    using System.Threading.Tasks;
    using Google.Apis.Customsearch.v1;
    using Google.Apis.Services;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class SearchRequest : WebSearch
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public NameValueCollection Config
        {
            get
            {
                return _config;
            }
            private set
            {
                _config = value;
            }
        }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public string Query
        {
            get
            {
                return _query;
            }
            private set
            {
                _query = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SearchRequest"/> class.
        /// </summary>
        public SearchRequest( )
        {
            _config = ConfigurationManager.AppSettings;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SearchRequest"/> class.
        /// </summary>
        /// <param name="keywords">
        /// The keywords.
        /// </param>
        public SearchRequest( string keywords )
        {
            _config = ConfigurationManager.AppSettings;
            _query = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SearchRequest"/> class.
        /// </summary>
        /// <param name="search">
        /// The search.
        /// </param>
        public SearchRequest( SearchRequest search )
        {
            _config = search.Config;
            _query = search.Query;
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <returns>
        /// List(SearchResult)
        /// </returns>
        public List<SearchResult> GetResults( )
        {
            try
            {
                var _count = 0;
                var _results = new List<SearchResult>( );
                var _initializer = new BaseClientService.Initializer( );
                _initializer.ApiKey = _config[ "ApiKey" ];
                var _customSearch = new CustomsearchService( _initializer );
                var _searchRequest = _customSearch
                    ?.Cse
                    ?.List( );

                if( _searchRequest != null )
                {
                    _searchRequest.Q = _query;
                    _searchRequest.Cx = _config[ "SearchEngineId" ];
                    _searchRequest.Start = _count;
                    var _list = _searchRequest.Execute( )
                        ?.Items
                        ?.ToList( );

                    if( _list?.Any( ) == true )
                    {
                        for( var _i = 0; _i < _list.Count; _i++ )
                        {
                            var _snippet = _list[ _i ].Snippet ?? string.Empty;
                            var _line = _list[ _i ].Link ?? string.Empty;
                            var _titles = _list[ _i ].Title ?? string.Empty;
                            var _htmlTitle = _list[ _i ].HtmlTitle ?? string.Empty;
                            var _searchResults = new SearchResult( _snippet, _line, _titles, _htmlTitle );
                            _results.Add( _searchResults );
                        }

                        return _results?.Any( ) == true
                            ? _results
                            : default( List<SearchResult> );
                    }
                    else
                    {
                        return default( List<SearchResult> );
                    }
                }
                else
                {
                    return default( List<SearchResult> );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( List<SearchResult> );
            }
        }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <returns>
        /// Task(IList(SearchResult))
        /// </returns>
        public Task<IList<SearchResult>> GetResultsAsync( )
        {
            var _async = new TaskCompletionSource<IList<SearchResult>>( );
            try
            {
                var _count = 0;
                var _results = new List<SearchResult>( );
                var _initializer = new BaseClientService.Initializer( );
                _initializer.ApiKey = _config[ "ApiKey" ];
                var _customSearch = new CustomsearchService( _initializer );
                var _searchRequest = _customSearch
                    ?.Cse
                    ?.List( );

                if( _searchRequest != null )
                {
                    _searchRequest.Q = _query;
                    _searchRequest.Cx = _config[ "SearchEngineId" ];
                    _searchRequest.Start = _count;
                    var _list = _searchRequest.Execute( )
                        ?.Items
                        ?.ToList( );

                    if( _list?.Any( ) == true )
                    {
                        for( var _i = 0; _i < _list.Count; _i++ )
                        {
                            var _snippet = _list[ _i ].Snippet ?? string.Empty;
                            var _line = _list[ _i ].Link ?? string.Empty;
                            var _titles = _list[ _i ].Title ?? string.Empty;
                            var _htmlTitle = _list[ _i ].HtmlTitle ?? string.Empty;
                            var _searchResults = new SearchResult( _snippet, _line, _titles, _htmlTitle );
                            _results.Add( _searchResults );
                        }

                        _async.SetResult( _results );
                        return _results?.Any( ) == true
                            ? _async.Task
                            : default( Task<IList<SearchResult>> );
                    }
                    else
                    {
                        return default( Task<IList<SearchResult>> );
                    }
                }
                else
                {
                    return default( Task<IList<SearchResult>> );
                }
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
                return default( Task<IList<SearchResult>> );
            }
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
            config = _config;
            query = _query;
        }
    }
}