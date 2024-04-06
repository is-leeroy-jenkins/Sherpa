//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                SqlDialog.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SqlDialog.cs" company="Terry D. Eppler">
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
//    SqlDialog.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;
    using static System.Configuration.ConfigurationManager;
    using CheckState = MetroSet_UI.Enums.CheckState;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;
    using FontStyle = System.Drawing.FontStyle;
    using Size = System.Drawing.Size;
    using SystemColors = System.Drawing.SystemColors;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public partial class SqlPage : EditBase
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private object _path;

        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <summary>
        /// 
        /// </summary>
        private IList<Frame> _frames;

        /// <summary>
        /// 
        /// </summary>
        private string _databaseDirectory;

        /// <summary>
        /// 
        /// </summary>
        private string _selectedCommand;

        /// <summary>
        /// 
        /// </summary>
        private string _selectedQuery;

        /// <summary>
        /// 
        /// </summary>
        private IList<string> _commands;

        /// <summary>
        /// 
        /// </summary>
        private IDictionary<string, object> _statements;

        /// <summary>
        /// Gets or sets the frames.
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        public IList<Frame> Frames
        {
            get
            {
                return _frames;
            }
            private set
            {
                _frames = value;
            }
        }

        /// <summary>
        /// Gets or sets the database directory.
        /// </summary>
        /// <value>
        /// The database directory.
        /// </value>
        public string DatabaseDirectory
        {
            get
            {
                return _databaseDirectory;
            }
            private set
            {
                _databaseDirectory = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected command.
        /// </summary>
        /// <value>
        /// The selected command.
        /// </value>
        public string SelectedCommand
        {
            get
            {
                return _selectedCommand;
            }
            private set
            {
                _selectedCommand = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected query.
        /// </summary>
        /// <value>
        /// The selected query.
        /// </value>
        public string SelectedQuery
        {
            get
            {
                return _selectedQuery;
            }
            private set
            {
                _selectedQuery = value;
            }
        }

        /// <summary>
        /// Gets or sets the commands.
        /// </summary>
        /// <value>
        /// The commands.
        /// </value>
        public IList<string> Commands
        {
            get
            {
                return _commands;
            }
            private set
            {
                _commands = value;
            }
        }

        /// <summary>
        /// Gets or sets the statements.
        /// </summary>
        /// <value>
        /// The statements.
        /// </value>
        public IDictionary<string, object> Statements
        {
            get
            {
                return _statements;
            }
            private set
            {
                _statements = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlPage"/> class.
        /// </summary>
        /// <inheritdoc />
        public SqlPage( )
        {
            InitializeComponent( );
            RegisterCallbacks( );
            InitializeDelegates( );

            // Basic Properties
            Size = new Size( 1330, 638 );
            MaximumSize = new Size( 1340, 648 );
            MinimumSize = new Size( 1320, 628 );
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Hide;
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ControlBox = false;
            TabPage.TabForeColor = Color.FromArgb( 106, 189, 252 );

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Budget Properties
            _fields = new List<string>( );
            _columns = new List<string>( );
            _dates = new List<DateTime>( );
            _dataArgs = new DataArgs( );
            _commands = new List<string>( );
            _statements = new Dictionary<string, object>( );

            // Event Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlDialog" /> class.
        /// </summary>
        /// <param name="source">The binding source.</param>
        /// <param name="provider">The provider.</param>
        public SqlPage( Source source, Provider provider = Provider.Access )
            : this( )
        {
            _toolType = ToolType.EditSqlButton;
            _provider = provider;
            _source = source;
        }

        /// <summary>
        /// Initializes the editor.
        /// </summary>
        private void InitializeEditor( )
        {
            try
            {
                Editor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Editor.AlwaysShowScrollers = true;
                Editor.BackColor = SystemColors.ControlLight;
                Editor.ForeColor = Color.Black;
                Editor.BackgroundColor = new BrushInfo( SystemColors.ControlLight );
                Editor.BorderStyle = BorderStyle.FixedSingle;
                Editor.CanOverrideStyle = true;
                Editor.CanApplyTheme = true;
                Editor.ColumnGuidesMeasuringFont = new Font( "Roboto", 8 );
                Editor.ContextChoiceFont = new Font( "Roboto", 8 );
                Editor.ContextChoiceForeColor = Color.Black;
                Editor.ContextChoiceBackColor = SystemColors.ControlLight;
                Editor.ContextPromptBorderColor = Color.FromArgb( 0, 120, 212 );
                Editor.ContextPromptBackgroundBrush =
                    new BrushInfo( Color.FromArgb( 233, 166, 50 ) );

                Editor.ContextTooltipBackgroundBrush =
                    new BrushInfo( Color.FromArgb( 233, 166, 50 ) );

                Editor.ContextTooltipBorderColor = Color.FromArgb( 0, 120, 212 );
                Editor.EndOfLineBackColor = SystemColors.ControlLight;
                Editor.EndOfLineForeColor = SystemColors.ControlLight;
                Editor.HighlightCurrentLine = true;
                Editor.IndentationBlockBorderColor = Color.FromArgb( 0, 120, 212 );
                Editor.IndentLineColor = Color.FromArgb( 50, 93, 129 );
                Editor.IndicatorMarginBackColor = SystemColors.ControlLight;
                Editor.CurrentLineHighlightColor = Color.FromArgb( 0, 120, 212 );
                Editor.Font = new Font( "Roboto", 12 );
                Editor.LineNumbersColor = Color.Black;
                Editor.LineNumbersFont = new Font( "Roboto", 8, FontStyle.Bold );
                Editor.ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
                Editor.ScrollColorScheme = Office2007ColorScheme.Black;
                Editor.SelectionTextColor = Color.FromArgb( 50, 93, 129 );
                Editor.ShowEndOfLine = false;
                Editor.Style = EditControlStyle.Office2016Black;
                Editor.TabSize = 4;
                Editor.TextAreaWidth = 400;
                Editor.WordWrap = true;
                Editor.WordWrapColumn = 100;
                Editor.Dock = DockStyle.None;
                Editor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left
                    | AnchorStyles.Right;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the delegates.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += UpdateStatus;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callback.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                FourthButton.Click += OnCloseButtonClick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
        {
            try
            {
                // Timer Properties
                var _timer = new Timer( );
                _timer.Enabled = true;
                _timer.Interval = 500;
                _timer.Tick += OnTimerTick;
                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                ThirdButton.Text = "Save";
                FourthButton.Text = "Exit";
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
        public void InvokeIf( Action action )
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
        /// Begins the initialize.
        /// </summary>
        private void BeginInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private void EndInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeInAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity < 1.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity += 0.05;
                }

                form.Opacity = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeOutAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity > 0.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity -= 0.05;
                }

                form.Opacity = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void BindData( )
        {
            try
            {
                _dataModel = new DataBuilder( _source, _provider );
                _dataTable = _dataModel?.DataTable;
                _selectedTable = _dataTable?.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                _columns = _dataTable.GetColumnNames( );
                BindingSource.DataSource = _dataTable;
                _current = BindingSource.GetCurrentRow( );
                _commands = CreateCommandList( _provider );
                PopulateSqlComboBox( _commands );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        private void BindData( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                _dataModel = new DataBuilder( _source, _provider, where );
                _dataTable = _dataModel?.DataTable;
                _selectedTable = _dataTable?.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                _columns = _dataTable.GetColumnNames( );
                BindingSource.DataSource = _dataTable;
                _current = BindingSource.GetCurrentRow( );
                _commands = CreateCommandList( _provider );
                PopulateSqlComboBox( _commands );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                Editor.Text = string.Empty;
                _commands?.Clear( );
                _statements?.Clear( );
                _provider = Provider.Access;
                AccessRadioButton.CheckState = CheckState.Checked;
                _commands = CreateCommandList( Provider );
                PopulateSqlComboBox( _commands );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the filter.
        /// </summary>
        private void ClearFilter( )
        {
            try
            {
                if( _filter?.Any( ) == true )
                {
                    _filter.Clear( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the collections.
        /// </summary>
        private void ClearCollections( )
        {
            try
            {
                _columns?.Clear( );
                _fields?.Clear( );
                _numerics?.Clear( );
                _selectedColumns?.Clear( );
                _selectedFields?.Clear( );
                _selectedNumerics?.Clear( );
                _commands?.Clear( );
                _statements?.Clear( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the provider.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        private void SetProvider( string provider )
        {
            try
            {
                ThrowIf.Null( provider, nameof( provider ) );
                _commands?.Clear( );
                _provider = (Provider)Enum.Parse( typeof( Provider ), provider );
                switch( _provider )
                {
                    case Provider.Access:
                    {
                        _provider = Provider.Access;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        _commands = CreateCommandList( _provider );
                        PopulateSqlComboBox( _commands );
                        break;
                    }
                    case Provider.SQLite:
                    {
                        _provider = Provider.SQLite;
                        SQLiteRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        _commands = CreateCommandList( _provider );
                        PopulateSqlComboBox( _commands );
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        _provider = Provider.SqlCe;
                        SqlCeRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        _commands = CreateCommandList( _provider );
                        PopulateSqlComboBox( _commands );
                        break;
                    }
                    case Provider.SqlServer:
                    {
                        _provider = Provider.SqlServer;
                        SqlServerRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        _commands = CreateCommandList( _provider );
                        PopulateSqlComboBox( _commands );
                        break;
                    }
                    default:
                    {
                        _provider = Provider.Access;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        _commands = CreateCommandList( _provider );
                        PopulateSqlComboBox( _commands );
                        break;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the SQL ComboBox.
        /// </summary>
        /// <param name="list">The list.</param>
        private void PopulateSqlComboBox( IList<string> list )
        {
            try
            {
                ThrowIf.Null( list, nameof( list ) );
                _commands = Enum.GetNames( typeof( Command ) );
                SqlComboBox.Items.Clear( );
                SqlListBox.Items.Clear( );
                for( var _i = 0; _i < list.Count; _i++ )
                {
                    if( _commands.Contains( list[ _i ] )
                       && list[ _i ].Equals( $"{Command.CREATEDATABASE}" ) )
                    {
                        SqlComboBox.Items.Add( "CREATE DATABASE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.CREATETABLE}" ) )
                    {
                        SqlComboBox.Items.Add( "CREATE TABLE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.ALTERTABLE}" ) )
                    {
                        SqlComboBox.Items.Add( "ALTER TABLE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.CREATEVIEW}" ) )
                    {
                        SqlComboBox.Items.Add( "CREATE VIEW" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.SELECTALL}" ) )
                    {
                        SqlComboBox.Items.Add( "SELECT ALL" );
                    }
                    else if( _commands.Contains( list[ _i ] ) )
                    {
                        SqlComboBox.Items.Add( list[ _i ] );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the command list.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private IList<string> CreateCommandList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _prefix = AppSettings[ "PathPrefix" ];
                    var _dbpath = AppSettings[ "DatabaseDirectory" ];
                    var _filePath = _prefix + _dbpath + @$"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _filePath );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Creates the query list.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private IList<string> CreateQueryList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _prefix = AppSettings[ "PathPrefix" ];
                    var _dbpath = AppSettings[ "DatabaseDirectory" ];
                    var _filePath = _prefix + _dbpath + @$"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _filePath );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Creates the SQL text.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                return $"SELECT * FROM {_source} "
                    + $"WHERE {where.ToCriteria( )};";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Creates the SQL text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> columns,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( _selectedTable ) )
            {
                try
                {
                    ThrowIf.Null( where, nameof( where ) );
                    ThrowIf.Null( columns, nameof( columns ) );
                    var _cols = string.Empty;
                    foreach( var _name in columns )
                    {
                        _cols += $"{_name}, ";
                    }

                    var _criteria = where.ToCriteria( );
                    var _names = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_names} "
                        + $"FROM {_selectedTable} "
                        + $"WHERE {_criteria} "
                        + $"GROUP BY {_names} ;";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Creates the SQL text.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                ThrowIf.Null( fields, nameof( fields ) );
                ThrowIf.Null( numerics, nameof( numerics ) );
                var _cols = string.Empty;
                var _aggr = string.Empty;
                foreach( var _name in fields )
                {
                    _cols += $"{_name}, ";
                }

                foreach( var _metric in numerics )
                {
                    _aggr += $"SUM({_metric}) AS {_metric}, ";
                }

                var _groups = _cols.TrimEnd( ", ".ToCharArray( ) );
                var _criteria = where.ToCriteria( );
                var _names = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                return $"SELECT {_names} "
                    + $"FROM {_source} "
                    + $"WHERE {_criteria} "
                    + $"GROUP BY {_groups};";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the query text.
        /// </summary>
        /// <returns>
        /// </returns>
        private string GetQueryText( )
        {
            try
            {
                return string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _dateTime = DateTime.Now;
                var _dateString = _dateTime.ToShortDateString( );
                var _timeString = _dateTime.ToLongTimeString( );
                _timeString += _dateString + "  " + _timeString;
                EditorTable.CaptionText = "SQL Text Editor  " + _timeString;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                AccessRadioButton.Checked = true;
                AccessRadioButton.Click += OnRadioButtonChecked;
                SQLiteRadioButton.Click += OnRadioButtonChecked;
                SqlCeRadioButton.Click += OnRadioButtonChecked;
                SqlServerRadioButton.Click += OnRadioButtonChecked;
                SqlComboBox.SelectedValueChanged += OnComboBoxItemSelected;
                SqlListBox.SelectedValueChanged += OnListBoxItemSelected;
                FirstButton.Click += OnClearButtonClick;
                InitializeEditor( );
                BindData( );
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [RadioButton checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRadioButtonChecked( object sender, EventArgs e )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _tag = _button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        SetProvider( _tag );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    _selectedCommand = string.Empty;
                    var _selection = _comboBox.SelectedItem?.ToString( );
                    SqlListBox.Items.Clear( );
                    if( _selection?.Contains( " " ) == true )
                    {
                        _selectedCommand = _selection.Replace( " ", "" );
                        var _prefix = AppSettings[ "PathPrefix" ];
                        var _dbpath = AppSettings[ "DatabaseDirectory" ];
                        var _filePath = _prefix + _dbpath
                            + @$"\{_provider}\DataModels\{_selectedCommand}";

                        var _files = Directory.GetFiles( _filePath );
                        for( var _i = 0; _i < _files.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _files[ _i ] );
                            var _caption = _item?.SplitPascal( );
                            SqlListBox.Items.Add( _caption );
                        }
                    }
                    else
                    {
                        _selectedCommand = _comboBox.SelectedItem?.ToString( );
                        var _prefix = AppSettings[ "PathPrefix" ];
                        var _dbpath = AppSettings[ "DatabaseDirectory" ];
                        var _filePath = _prefix + _dbpath
                            + @$"\{_provider}\DataModels\{_selectedCommand}";

                        var _names = Directory.GetFiles( _filePath );
                        for( var _i = 0; _i < _names.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _names[ _i ] );
                            var _caption = _item?.SplitPascal( );
                            SqlListBox.Items.Add( _caption );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    Editor.Text = string.Empty;
                    _selectedQuery = _listBox.SelectedItem?.ToString( );
                    if( _selectedQuery?.Contains( " " ) == true
                       || _selectedCommand?.Contains( " " ) == true )
                    {
                        var _prefix = AppSettings[ "PathPrefix" ];
                        var _dbpath = AppSettings[ "DatabaseDirectory" ];
                        var _command = _selectedCommand?.Replace( " ", "" );
                        var _query = _selectedQuery?.Replace( " ", "" );
                        var _filePath = _prefix + _dbpath
                            + @$"\{_provider}\DataModels\{_command}\{_query}.sql";

                        var _stream = File.OpenRead( _filePath );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                    else
                    {
                        var _prefix = AppSettings[ "PathPrefix" ];
                        var _dbpath = AppSettings[ "DatabaseDirectory" ];
                        var _filePath = _prefix + _dbpath
                            + @$"\{_provider}\DataModels\{_selectedCommand}\{_selectedQuery}.sql";

                        var _stream = File.OpenRead( _filePath );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [clear button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnClearButtonClick( object sender, EventArgs e )
        {
            try
            {
                ClearSelections( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    //FormMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            try
            {
                InvokeIf( _statusUpdate );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFormClosing( object sender, EventArgs e )
        {
            try
            {
                Opacity = 1;
                FadeOutAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}