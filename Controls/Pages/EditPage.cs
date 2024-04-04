//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                EditPanel.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="EditPanel.cs" company="Terry D. Eppler">
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
//    EditPanel.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <inheritdoc/>
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.EditBase"/>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    [ SuppressMessage( "ReSharper", "MergeCastWithTypeCheck" ) ]
    public partial class EditPage : EditBase
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
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The first category
        /// </summary>
        private string _firstCategory;

        /// <summary>
        /// The first value
        /// </summary>
        private string _firstValue;

        /// <summary>
        /// The second category
        /// </summary>
        private string _secondCategory;

        /// <summary>
        /// The second value
        /// </summary>
        private string _secondValue;

        /// <summary>
        /// The third category
        /// </summary>
        private string _thirdCategory;

        /// <summary>
        /// The third value
        /// </summary>
        private string _thirdValue;

        /// <summary>
        /// The fourth category
        /// </summary>
        private string _fourthCategory;

        /// <summary>
        /// The fourth value
        /// </summary>
        private string _fourthValue;

        /// <summary>
        /// The selected query
        /// </summary>
        private string _selectedQuery;

        /// <summary>
        /// The selected command
        /// </summary>
        private string _selectedCommand;

        /// <summary>
        /// The commands
        /// </summary>
        private IList<string> _commands;

        /// <summary>
        /// The statements
        /// </summary>
        private IDictionary<string, object> _statements;

        /// <summary>
        /// The frames
        /// </summary>
        private IList<Frame> _frames;

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public int Time
        {
            get
            {
                return _time;
            }
            private set
            {
                _time = value;
            }
        }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value>
        /// The seconds.
        /// </value>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            private set
            {
                _seconds = value;
            }
        }

        /// <summary>
        /// Gets the first category.
        /// </summary>
        /// <value>
        /// The first category.
        /// </value>
        public string FirstCategory
        {
            get
            {
                return _firstCategory;
            }
            private set
            {
                _firstCategory = value;
            }
        }

        /// <summary>
        /// Gets the first value.
        /// </summary>
        /// <value>
        /// The first value.
        /// </value>
        public string FirstValue
        {
            get
            {
                return _firstValue;
            }
            private set
            {
                _firstValue = value;
            }
        }

        /// <summary>
        /// Gets the second category.
        /// </summary>
        /// <value>
        /// The second category.
        /// </value>
        public string SecondCategory
        {
            get
            {
                return _secondCategory;
            }
            private set
            {
                _secondCategory = value;
            }
        }

        /// <summary>
        /// Gets the second value.
        /// </summary>
        /// <value>
        /// The second value.
        /// </value>
        public string SecondValue
        {
            get
            {
                return _secondValue;
            }
            private set
            {
                _secondValue = value;
            }
        }

        /// <summary>
        /// Gets the third category.
        /// </summary>
        /// <value>
        /// The third category.
        /// </value>
        public string ThirdCategory
        {
            get
            {
                return _thirdCategory;
            }
            private set
            {
                _thirdCategory = value;
            }
        }

        /// <summary>
        /// Gets the third value.
        /// </summary>
        /// <value>
        /// The third value.
        /// </value>
        public string ThirdValue
        {
            get
            {
                return _thirdValue;
            }
            private set
            {
                _thirdValue = value;
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
        /// Gets the fourth category.
        /// </summary>
        /// <value>
        /// The fourth category.
        /// </value>
        public string FourthCategory
        {
            get
            {
                return _fourthCategory;
            }
            private set
            {
                _fourthCategory = value;
            }
        }

        /// <summary>
        /// Gets the fourth value.
        /// </summary>
        /// <value>
        /// The fourth value.
        /// </value>
        public string FourthValue
        {
            get
            {
                return _fourthValue;
            }
            private set
            {
                _fourthValue = value;
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
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// </value>
        public bool IsBusy
        {
            get
            {
                return _busy;
            }
            private set
            {
                _busy = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditPanel"/>
        /// class.
        /// </summary>
        public EditPage( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

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
            _frames = GetFrames( );
            _tabPages = GetTabPages( );

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Budget Attributes
            _filter = new Dictionary<string, object>( );
            _fields = new List<string>( );
            _columns = new List<string>( );
            _numerics = new List<string>( );
            _selectedColumns = new List<string>( );
            _selectedFields = new List<string>( );
            _selectedNumerics = new List<string>( );
            _dataArgs = new DataArgs( );

            // Form Event Wiring
            Load += OnLoad;
            Shown += OnShown;
            MouseClick += OnRightClick;
            Closing += OnClose;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditPanel"/>
        /// class.
        /// </summary>
        /// <param name="bindingSource">
        /// The binding source.
        /// </param>
        public EditPage( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
            _current = bindingSource.GetCurrentRow( );
            _provider = Provider.Access;
            _source = (Source)Enum.Parse( typeof( Source ), _selectedTable );
            _dataModel = new DataBuilder( _source, _provider );
            _dataTable = _dataModel.DataTable;
            _columns = _dataModel.ColumnNames;
            _fields = _dataModel?.Fields;
            _numerics = _dataModel?.Numerics;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditPanel"/>
        /// class.
        /// </summary>
        /// <param name="dataModel">
        /// The data model.
        /// </param>
        public EditPage( DataBuilder dataModel )
            : this( )
        {
            _dataModel = dataModel;
            _provider = dataModel.Provider;
            _source = dataModel.Source;
            _commandType = dataModel.SqlStatement.CommandType;
            BindingSource.DataSource = dataModel.DataTable;
            _dataTable = dataModel.DataTable;
            _columns = dataModel.DataTable.GetColumnNames( );
            _current = dataModel.Record;
            _fields = dataModel?.Fields;
            _numerics = dataModel?.Numerics;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditPanel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> </param>
        public EditPage( Source source, Provider provider, IDictionary<string, object> where )
            : this( )
        {
            _provider = provider;
            _source = source;
            _filter = where;
            _dataModel = new DataBuilder( source, provider );
            _dataTable = _dataModel.DataTable;
            _commandType = _dataModel.SqlStatement.CommandType;
            BindingSource.DataSource = _dataModel.DataTable;
            _columns = _dataTable.GetColumnNames( );
            _current = BindingSource.GetCurrentRow( );
            _fields = _dataModel?.Fields;
            _numerics = _dataModel?.Numerics;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditPanel" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public EditPage( Source source, Provider provider = Provider.Access )
            : this( )
        {
            _provider = provider;
            _source = source;
            _dataModel = new DataBuilder( source, provider );
            _dataTable = _dataModel.DataTable;
            _commandType = _dataModel.SqlStatement.CommandType;
            BindingSource.DataSource = _dataTable;
            _columns = _dataTable.GetColumnNames( );
            _current = BindingSource.GetCurrentRow( );
            _fields = _dataModel?.Fields;
            _numerics = _dataModel?.Numerics;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            // Control Event Wiring
            try
            {
                CloseButton.Click += OnCloseButtonClick;
                DataTab.MouseClick += OnRightClick;
                RefreshButton.Click += OnClearButtonClicked;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tab control.
        /// </summary>
        private void InitializeTabControl( )
        {
            try
            {
                TabControl.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
                DataTab.TabFont = new Font( "Roboto", 8, FontStyle.Regular );
                DataTab.TabForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                SelectButton.Text = "Save";
                CloseButton.Text = "Close";
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
                _statusUpdate += UpdateLabels;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( _seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = _seconds * 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
                        {
                            Timer.Stop( );
                            FadeIn( );
                        }
                    };
                }

                base.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new void ShowDialog( )
        {
            try
            {
                Opacity = 0;
                if( _seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = _seconds * 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
                        {
                            Timer.Stop( );
                            FadeIn( );
                        }
                    };
                }

                base.ShowDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
        /// Fades the in.
        /// </summary>
        private void FadeIn( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 1d )
                    {
                        _timer.Stop( );
                    }

                    Opacity += 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out.
        /// </summary>
        private void FadeOut( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 0d )
                    {
                        _timer.Stop( );
                        Close( );
                    }

                    Opacity -= 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the frame visibility.
        /// </summary>
        public void SetFrameVisibility( )
        {
            if( _frames?.Any( ) == true )
            {
                try
                {
                    var _cols = _columns.ToArray( );
                    var _controls = _frames.ToArray( );
                    for( var _i = 0; _i < _controls.Length; _i++ )
                    {
                        var _frame = _controls[ _i ];
                        if( _frame.Index >= _cols.Length )
                        {
                            _frame.Visible = false;
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
        /// Gets the frames.
        /// </summary>
        /// <returns>
        /// </returns>
        private IList<Frame> GetFrames( )
        {
            try
            {
                _frames = new List<Frame>( );
                for( var _i = 0; _i < FrameTable.Controls.Count; _i++ )
                {
                    var _control = FrameTable.Controls[ _i ];
                    if( _control.GetType( ) == typeof( Frame ) )
                    {
                        if( _control is Frame )
                        {
                            _frames.Add( _control as Frame );
                        }
                    }
                }

                return _frames?.Any( ) == true
                    ? _frames.OrderBy( f => f.Index )?.ToArray( )
                    : default( IList<Frame> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<Frame> );
            }
        }

        /// <summary>
        /// Wires up frame events.
        /// </summary>
        private void RegisterFrameEvents( )
        {
            try
            {
                if( _frames?.Any( ) == true )
                {
                    foreach( var _frame in _frames )
                    {
                        _frame.TextBox.MouseClick += OnContentClick;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the active tab.
        /// </summary>
        private void SetActiveTab( )
        {
            try
            {
                switch( Tool )
                {
                    case ToolType.CopyButton:
                    {
                        ActiveTab = DataTab;
                        break;
                    }
                    case ToolType.AddRecordButton:
                    {
                        ActiveTab = DataTab;
                        break;
                    }
                    case ToolType.AddButton:
                    {
                        ActiveTab = DataTab;
                        break;
                    }
                    case ToolType.EditRecordButton:
                    {
                        ActiveTab = DataTab;
                        break;
                    }
                    case ToolType.DeleteRecordButton:
                    {
                        ActiveTab = DataTab;
                        SelectButton.Text = "Delete";
                        break;
                    }
                    default:
                    {
                        ActiveTab = DataTab;
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
        /// Sets the frame dock style.
        /// </summary>
        private void SetFrameDockStyle( )
        {
            if( _frames?.Any( ) == true )
            {
                try
                {
                    foreach( var _frame in _frames )
                    {
                        _frame.Dock = DockStyle.Fill;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the table location.
        /// </summary>
        private void SetTableLocation( )
        {
            if( FrameTable != null
               && _columns?.Any( ) == true )
            {
                try
                {
                    var _cols = _columns.ToArray( );
                    switch( _cols.Length )
                    {
                        case >= 43:
                        case < 43 and >= 35:
                        {
                            FrameTable.Location = new Point( 12, 25 );
                            break;
                        }
                        case < 35 and >= 28:
                        case < 28 and >= 21:
                        case < 21 and >= 14:
                        case < 14 and > 7:
                        case <= 7:
                        {
                            FrameTable.Location = new Point( 12, 81 );
                            break;
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
        /// Binds the record.
        /// </summary>
        private void BindRecord( )
        {
            if( _current != null
               && _frames?.Any( ) == true
               && _columns?.Any( ) == true )
            {
                try
                {
                    var _items = _current.ItemArray;
                    var _controls = _frames.OrderBy( f => f.Index ).ToArray( );
                    var _cols = _columns.ToArray( );
                    for( var _i = 0; _i < _cols.Length; _i++ )
                    {
                        _controls[ _i ].Label.Text = _cols[ _i ].SplitPascal( );
                        var _text = _items[ _i ]?.ToString( );
                        if( _numerics?.Contains( _cols[ _i ] ) == true
                           && !string.IsNullOrEmpty( _text ) )
                        {
                            var _value = double.Parse( _text );
                            _controls[ _i ].TextBox.Font = new Font( "Roboto", 8 );
                            _controls[ _i ].TextBox.Text = _value.ToString( "N2" );
                            _controls[ _i ].TextBox.TextAlign = HorizontalAlignment.Right;
                        }
                        else
                        {
                            _controls[ _i ].TextBox.Font = new Font( "Roboto", 8 );
                            _controls[ _i ].TextBox.Text = _items[ _i ]?.ToString( );
                            _controls[ _i ].TextBox.TextAlign = HorizontalAlignment.Left;
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
        /// Sets the frame colors.
        /// </summary>
        private void SetFrameColors( )
        {
            if( _frames?.Any( ) == true )
            {
                foreach( var _frame in _frames )
                {
                    _frame.Label.ForeColor = Color.FromArgb( 106, 189, 252 );
                    _frame.TextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                    _frame.TextBox.BorderColor = Color.FromArgb( 50, 93, 129 );
                    _frame.TextBox.HoverColor = Color.FromArgb( 0, 120, 212 );
                }
            }
        }

        /// <summary>
        /// Clears the combo boxes.
        /// </summary>
        private void ClearComboBoxes( )
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
        /// Clears the list boxes.
        /// </summary>
        private void ClearListBoxes( )
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
        /// Clears the data.
        /// </summary>
        public void ClearData( )
        {
            try
            {
                ClearSelections( );
                ClearCollections( );
                ClearFilter( );
                BindingSource.DataSource = null;
                _dataModel = null;
                _dataTable = null;
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                _thirdCategory = string.Empty;
                _thirdValue = string.Empty;
                _secondCategory = string.Empty;
                _secondValue = string.Empty;
                _firstCategory = string.Empty;
                _firstValue = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the label text.
        /// </summary>
        private void UpdateLabels( )
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                _frames = GetFrames( );
                _tabPages = GetTabPages( );
                SetActiveTab( );
                SetTableLocation( );
                SetFrameColors( );
                SetFrameDockStyle( );
                BindRecord( );
                SetFrameVisibility( );
                RegisterFrameEvents( );
                InitializeTabControl( );
                InitializeButtons( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [content click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnContentClick( object sender, MouseEventArgs e )
        {
            if( sender is TextBox _currentCell
               && e.Button == MouseButtons.Left
               && !string.IsNullOrEmpty( _currentCell.Text ) )
            {
                try
                {
                    var _value = _currentCell.Text;
                    if( !string.IsNullOrEmpty( _value )
                       && _value.Length > 25 )
                    {
                        var _editDialog = new TextDialog( _value );
                        _editDialog.ShowDialog( this );
                    }
                    else if( !string.IsNullOrEmpty( _value )
                            && _value.Length >= 6
                            && _value.Length <= 9
                            && _value.Substring( 0, 3 ) == "000" )
                    {
                        var _code = _value.Substring( 4, 2 );
                        var _dialog = new ProgramProjectDialog( _code );
                        _dialog.ShowDialog( this );
                    }
                    else if( decimal.TryParse( _value, out var _decimal ) )
                    {
                        var _double = Convert.ToDouble( _decimal );
                        var _calculator = new CalculationForm( _double );
                        _calculator.ShowDialog( this );
                    }
                    else if( double.TryParse( _value, out var _double ) )
                    {
                        var _calculator = new CalculationForm( _double );
                        _calculator.ShowDialog( this );
                    }
                    else if( DateTime.TryParse( _value, out var _dateTime ) )
                    {
                        var _form = new CalendarDialog( _dateTime );
                        _form.ShowDialog( this );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                    //ContextMenu.Show( this, e.Location );
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
        /// Called when [clear button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnClearButtonClicked( object sender, EventArgs e )
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

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        public void OnClose( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}