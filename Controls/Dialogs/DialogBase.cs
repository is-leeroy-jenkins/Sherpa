namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using static System.Configuration.ConfigurationManager;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using static System.Environment;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class DialogBase : MetroForm
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private protected object _path;

        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private protected Action _statusUpdate;

        /// <summary>
        /// The time
        /// </summary>
        private protected int _time;

        /// <summary>
        /// The count
        /// </summary>
        private protected int _count;

        /// <summary>
        /// The seconds
        /// </summary>
        private protected int _seconds;

        /// <summary>
        /// The data
        /// </summary>
        private protected string _data;

        /// <summary>
        /// The selected path
        /// </summary>
        private protected string _selectedPath;

        /// <summary>
        /// The selected file
        /// </summary>
        private protected string _selectedFile;

        /// <summary>
        /// The initial directory
        /// </summary>
        private protected string _initialDirectory;

        /// <summary>
        /// The file extension
        /// </summary>
        private protected string _fileExtension;

        /// <summary>
        /// The extension
        /// </summary>
        private protected EXT _extension;

        /// <summary>
        /// The file paths
        /// </summary>
        private protected IList<string> _filePaths;

        /// <summary>
        /// The initial dir paths
        /// </summary>
        private protected IList<string> _searchPaths;

        /// <summary>
        /// The radio buttons
        /// </summary>
        private protected IList<RadioButton> _radioButtons;

        /// <summary>
        /// The image
        /// </summary>
        private protected Bitmap _image;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DialogBase" /> class.
        /// </summary>
        protected DialogBase( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DialogBase" /> class.
        /// </summary>
        /// <param name="extension">The extension.</param>
        protected DialogBase( EXT extension ) 
            : this( )
        {
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        private protected Image GetImage( )
        {
            if( !string.IsNullOrEmpty( _fileExtension ) )
            {
                try
                {
                    var _filePath = AppSettings[ "ExtensionImages" ];
                    if( _filePath != null )
                    {
                        var _files = Directory.GetFiles( _filePath );
                        if( _files?.Any( ) == true )
                        {
                            var _ext = _fileExtension.TrimStart( '.' ).ToUpper( );
                            var _file = _files
                                ?.Where( f => f.Contains( _ext ) )
                                ?.First( );

                            var _stream = File.Open( _file, FileMode.Open );
                            var _img = Image.FromStream( _stream );
                            return new Bitmap( _img, 18, 18 );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Gets the ListView paths.
        /// </summary>
        /// <returns></returns>
        private protected void CreateListViewFilePaths( )
        {
            try
            {
                _filePaths?.Clear( );
                var _pattern = "*." + _fileExtension;
                for( var _i = 0; _i < _searchPaths.Count; _i++ )
                {
                    var _dirPath = _searchPaths[ _i ];
                    var _parent = Directory.CreateDirectory( _dirPath );
                    var _folders = _parent.GetDirectories( )
                        ?.Where( s => s.Name.Contains( "My" ) == false )
                        ?.Select( s => s.FullName )
                        ?.ToList( );
                    
                    var _topLevelFiles = _parent.GetFiles( _pattern, SearchOption.TopDirectoryOnly )
                        ?.Select( f => f.FullName )
                        ?.ToArray( );
                    
                    _filePaths.AddRange( _topLevelFiles );
                    for( int _k = 0; _k < _folders.Count; _k++ )
                    {
                        var _folder = Directory.CreateDirectory( _folders[ _k ] );
                        var _lowerLevelFiles = _folder.GetFiles( _pattern, SearchOption.AllDirectories )
                            ?.Select( s => s.FullName )
                            ?.ToArray( );
                        
                        _filePaths.AddRange( _lowerLevelFiles );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the file paths.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetFilePaths( )
        {
            try
            {
                var _list = new List<string>( );
                var _pattern = "*" + _fileExtension;
                for( var _i = 0; _i < _searchPaths.Count; _i++ )
                {
                    var _dirPath = _searchPaths[ _i ];
                    var _parent = Directory.CreateDirectory( _dirPath );
                    var _folders = _parent.GetDirectories( )
                        ?.Where( s => s.Name.StartsWith( "My" ) == false )
                        ?.Select( s => s.FullName )
                        ?.ToList( );

                    var _files = _parent.GetFiles( _pattern, SearchOption.TopDirectoryOnly )
                        ?.Select( f => f.FullName )
                        ?.ToArray( );

                    _list.AddRange( _files );
                    for( int _k = 0; _k < _folders.Count; _k++ )
                    {
                        var _folder = Directory.CreateDirectory( _folders[ _k ] );
                        var _items = _folder.GetFiles( _pattern, SearchOption.AllDirectories )
                            ?.Select( s => s.FullName )
                            ?.ToArray( );

                        _list.AddRange( _items );
                    }
                }
                
                return _list;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the initial dir paths.
        /// </summary>
        /// <returns>
        /// IList(string)
        /// </returns>
        private protected IList<string> CreateInitialDirectoryPaths( )
        {
            try
            {
                var _current = CurrentDirectory;
                var _list = new List<string>
                {
                    GetFolderPath( SpecialFolder.DesktopDirectory ),
                    GetFolderPath( SpecialFolder.Personal ),
                    GetFolderPath( SpecialFolder.Recent ),
                    Environment.CurrentDirectory,
                    @"C:\Users\terry\source\repos\BudgetExecution\Resources\Documents",
                    _current
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Clears the radio buttons.
        /// </summary>
        private protected void ClearRadioButtons( )
        {
            try
            {
                foreach( var _radioButton in _radioButtons )
                {
                    _radioButton.CheckedChanged += null;
                    _radioButton.CheckState = CheckState.Unchecked;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        private protected void InvokeIf( Action action )
        {
            if( InvokeRequired )
            {
                BeginInvoke( action );
            }
            else
            {
                action.Invoke( );
            }
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected IEnumerable<Control> GetControls( )
        {
            var _list = new List<Control>( );
            var _queue = new Queue( );
            try
            {
                _queue.Enqueue( Controls );
                while( _queue.Count > 0 )
                {
                    var _collection = (Control.ControlCollection)_queue.Dequeue( );
                    if( _collection?.Count > 0 )
                    {
                        foreach( Control _control in _collection )
                        {
                            _list.Add( _control );
                            _queue.Enqueue( _control.Controls );
                        }
                    }
                }

                return _list?.Any( ) == true
                    ? _list.ToArray( )
                    : default( Control[ ] );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Control[ ] );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            _image?.Dispose( );
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
