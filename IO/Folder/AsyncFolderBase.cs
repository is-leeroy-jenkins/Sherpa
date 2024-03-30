// ****************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 20-03-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        20-03-2024
// ****************************************************************************************
// <copyright file="AsyncFolderBase.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for analysts in the
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
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
//     EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//     OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
//     AND NON-INFRINGEMENT.  IN NO EVENT SHALL THE AUTHORS
//     OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//     TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//  AsyncFolderBase.cs
// </summary>
// ****************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Security.AccessControl;
    using System.Threading.Tasks;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AsyncFolderBase : DataFile
    {
        /// <summary>
        /// The folder exists
        /// </summary>
        private protected bool _folderExists;

        /// <summary>
        /// The sub files
        /// </summary>
        private protected bool _hasSubFiles;

        /// <summary>
        /// The sub folders
        /// </summary>
        private protected bool _hasSubFolders;

        /// <summary>
        /// The folder name
        /// </summary>
        private protected string _folderName;

        /// <summary>
        /// The parent name
        /// </summary>
        private protected string _parentName;

        /// <summary>
        /// The parent folder
        /// </summary>
        private protected DirectoryInfo _parentFolder;

        /// <summary>
        /// The security
        /// </summary>
        private protected DirectorySecurity _folderSecurity;

        /// <summary>
        /// Gets the special folders.
        /// </summary>
        /// <returns>
        /// </returns>
        public Task<IList<string>> GetSpecialFolderNamesAsync( )
        {
            var _async = new TaskCompletionSource<IList<string>>( );
            try
            {
                var _folders = Enum.GetNames( typeof( Environment.SpecialFolder ) );
                return _folders?.Any( ) == true
                    ? _async.Task
                    : default( Task<IList<string>> );
            }
            catch( IOException _ex )
            {
                Fail( _ex );
                return default( Task<IList<string>> );
            }
        }

        /// <summary>
        /// Gets the sub file data.
        /// </summary>
        /// <returns>
        /// Dictionary
        /// </returns>
        public Task<IDictionary<string, FileInfo>> GetSubFileDataAsync( )
        {
            if( _hasSubFiles )
            {
                var _async = new TaskCompletionSource<IDictionary<string, FileInfo>>( );
                try
                {
                    var _data = new Dictionary<string, FileInfo>( );
                    var _paths = Directory.GetFiles( _input );
                    foreach( var _path in _paths )
                    {
                        if( File.Exists( _path ) )
                        {
                            var _name = Path.GetFileNameWithoutExtension( _path );
                            var _subFile = new FileInfo( _path );
                            _data.Add( _name, _subFile );
                        }
                    }

                    return _data?.Any( ) == true
                        ? _async.Task
                        : default( Task<IDictionary<string, FileInfo>> );
                }
                catch( IOException _ex )
                {
                    Fail( _ex );
                    return default( Task<IDictionary<string, FileInfo>> );
                }
            }

            return default( Task<IDictionary<string, FileInfo>> );
        }

        /// <summary>
        /// Gets the subdirectory data.
        /// </summary>
        /// <returns>
        /// </returns>
        public Task<IDictionary<string, DirectoryInfo>> GetSubDirectoryDataAsync( )
        {
            if( _hasSubFolders )
            {
                var _async = new TaskCompletionSource<IDictionary<string, DirectoryInfo>>( );
                try
                {
                    var _data = new Dictionary<string, DirectoryInfo>( );
                    var _subFolders = Directory.GetDirectories( _input );
                    foreach( var _path in _subFolders )
                    {
                        if( Directory.Exists( _path ) )
                        {
                            var _name = Path.GetDirectoryName( _path );
                            var _directory = new DirectoryInfo( _path );
                            if( _name != null )
                            {
                                _data.Add( _name, _directory );
                            }
                        }
                    }

                    return _data?.Any( ) != true
                        ? _async.Task
                        : default( Task<IDictionary<string, DirectoryInfo>> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Task<IDictionary<string, DirectoryInfo>> );
                }
            }

            return default( Task<IDictionary<string, DirectoryInfo>> );
        }

        /// <summary>
        /// Walks the paths.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected IEnumerable<string> WalkPaths( )
        {
            if( _hasSubFiles )
            {
                try
                {
                    var _list = new List<string>( );
                    var _paths = Directory.GetFiles( _input );
                    foreach( var _file in _paths )
                    {
                        var _first = Directory.GetFiles( _file )
                            ?.Where( f => File.Exists( f ) )
                            ?.Select( f => Path.GetFullPath( f ) )
                            ?.ToList( );

                        _list.AddRange( _first );
                        var _folders = Directory.GetDirectories( _file );
                        foreach( var _folder in _folders )
                        {
                            if( !_folder.Contains( "My " ) )
                            {
                                var _second = Directory.GetFiles( _folder )
                                    ?.Where( s => File.Exists( s ) )
                                    ?.Select( s => Path.GetFullPath( s ) )
                                    ?.ToList( );

                                _list.AddRange( _second );
                                var _subfolders = Directory.GetDirectories( _folder );
                                for( var _i = 0; _i < _subfolders.Length; _i++ )
                                {
                                    var _path = _subfolders[ _i ];
                                    var _last = Directory.GetFiles( _path )
                                        ?.Where( l => File.Exists( l ) )
                                        ?.Select( l => Path.GetFullPath( l ) )
                                        ?.ToList( );

                                    _list.AddRange( _last );
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( IEnumerable<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }
    }
}