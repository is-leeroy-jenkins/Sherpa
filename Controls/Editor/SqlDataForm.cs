// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        03-23-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Budget Execution is a small Federal Budget, Finance, and Accounting data management
//    application for analysts with the US Environmental Protection Agency (US EPA).
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   SqlDataForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;
    using Syncfusion.Windows.Forms.Tools;
    using static System.Configuration.ConfigurationManager;
    using static System.IO.Directory;
    using static System.IO.Path;
    using Syncfusion.Drawing;
    using Action = System.Action;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "RedundantCheckBeforeAssignment" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    public partial class SqlDataForm : EditBase
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
        /// The count
        /// </summary>
        private int _count;

        /// <summary>
        /// The hover text
        /// </summary>
        private string _hoverText;

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
        /// The command of the SQL command
        /// </summary>
        private string _selectedCommand;

        /// <summary>
        /// The text of the SQL command
        /// </summary>
        private string _selectedQuery;

        /// <summary>
        /// A list of commands of type string
        /// </summary>
        private IList<string> _commands;

        /// <summary>
        /// The statements
        /// </summary>
        private IDictionary<string, object> _statements;

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get
            {
                return _count;
            }
            private set
            {
                _count = value;
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
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        return _busy;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        return _busy;
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlDataForm"/>
        /// class.
        /// </summary>
        /// <inheritdoc/>
        public SqlDataForm( )
        {
            InitializeComponent( );
            RegisterCallbacks( );
            InitializeDelegates( );

            // Form Properties
            Size = new Size( 1340, 740 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1330, 730 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            SizeGripStyle = SizeGripStyle.Auto;
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
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
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Default Provider
            _provider = Provider.Access;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Budget Collections
            _filter = new Dictionary<string, object>( );
            _selectedColumns = new List<string>( );
            _selectedFields = new List<string>( );
            _selectedNumerics = new List<string>( );
            _dataArgs = new DataArgs( );

            // Form Even Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlDataForm" />
        /// class.
        /// </summary>
        /// <param name="provider"> The provider. </param>
        public SqlDataForm( Provider provider )
            : this( )
        {
            // Provider
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                TabControl.SelectedIndexChanged += OnActiveTabChanged;
                AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
                SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlCeRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
                CommandComboBox.SelectedIndexChanged += OnCommandComboBoxItemSelected;
                QueryListBox.SelectedValueChanged += OnQueryListBoxItemSelected;
                RefreshButton.Click += OnRefreshButtonClick;
                SaveButton.Click += OnSaveButtonClick;
                GoButton.Click += OnGoButtonClick;
                CloseButton.Click += OnCloseButtonClick;
                EditSqlButton.Click += OnEditSqlButtonClick;
                EditDataButton.Click += OnEditDataButtonClick;
                TableButton.Click += OnTableButtonClick;
                LookupButton.Click += OnLookupButtonClick;
                MenuButton.Click += OnMenuButtonClick;
                ClientButton.Click += OnClientButtonClick;
                TableListBox.SelectedIndexChanged += OnTableListBoxSelectionChanged;
                ColumnListBox.SelectedIndexChanged += OnColumnListBoxSelectionChanged;
                BrowserButton.Click += OnBrowserButtonClicked;
                Timer.Tick += OnTimerTick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
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
        /// Initializes the PictureBox.
        /// </summary>
        private void InitializePictureBox( )
        {
            try
            {
                PictureBox.Size = new Size( 20, 18 );
                PictureBox.Padding = new Padding( 1 );
                PictureBox.Margin = new Padding( 1 );
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tool strip.
        /// </summary>
        private void InitializeToolStrip( )
        {
            try
            {
                ToolStrip.Margin = new Padding( 1, 1, 1, 3 );
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.Office12Mode = true;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ShowCaption = true;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
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
        /// Initializes the buttons.
        /// </summary>
        private void InitializeRadioButtons( )
        {
            try
            {
                switch( _provider )
                {
                    case Provider.SQLite:
                    {
                        SQLiteRadioButton.Checked = true;
                        SQLiteRadioButton.CheckState = CheckState.Checked;
                        ClientButton.Visible = true;
                        ClientSeparator.Visible = true;
                        break;
                    }
                    case Provider.Access:
                    {
                        AccessRadioButton.Checked = true;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        ClientButton.Visible = true;
                        ClientSeparator.Visible = true;
                        break;
                    }
                    case Provider.SqlServer:
                    {
                        SqlServerRadioButton.Checked = true;
                        SqlServerRadioButton.CheckState = CheckState.Checked;
                        ClientButton.Visible = false;
                        ClientSeparator.Visible = false;
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        SqlCeRadioButton.Checked = true;
                        SqlCeRadioButton.CheckState = CheckState.Checked;
                        ClientButton.Visible = true;
                        ClientSeparator.Visible = true;
                        break;
                    }
                    default:
                    {
                        AccessRadioButton.Checked = true;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        ClientButton.Visible = true;
                        ClientSeparator.Visible = true;
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
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Title.Font = new Font( "Roboto", 9 );
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
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
                Timer.Interval = 80;
                Timer.Tick += OnTimerTick;
                Timer.Enabled = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIf( Action action )
        {
            try
            {
                ThrowIf.Null( action, nameof( action ) );
                if( InvokeRequired )
                {
                    BeginInvoke( action );
                }
                else
                {
                    action.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                TableListBox.SelectedItem = string.Empty;
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Select( r => r.Field<string>( "TableName" ) )
                    ?.Distinct( )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[ _i ];
                    TableListBox.Items?.Add( _name );
                }

                if( TableListBox.Items?.Count > 0 )
                {
                    SourceTable.CaptionText = $"Tables: {TableListBox.Items.Count}";
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the data type ComboBox items.
        /// </summary>
        /// <param name="dataTypes">
        /// The data types.
        /// </param>
        public void PopulateDataTypeComboBoxItems( IEnumerable<string> dataTypes )
        {
            try
            {
                ThrowIf.Null( dataTypes, nameof( dataTypes ) );
                DataTypeComboBox.Items?.Clear( );
                DataTypeComboBox.SelectedText = string.Empty;
                var _types = _dataTypes.ToArray( );
                for( var _i = 0; _i < _types?.Length; _i++ )
                {
                    if( !string.IsNullOrEmpty( _types[ _i ] ) )
                    {
                        DataTypeComboBox.Items.Add( _types[ _i ] );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the table ComboBox items.
        /// </summary>
        public void PopulateTableComboBoxItems( )
        {
            try
            {
                TableNameComboBox.Items?.Clear( );
                TableNameComboBox.SelectedItem = string.Empty;
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Select( r => r.Field<string>( "TableName" ) )
                    ?.Distinct( )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[ _i ];
                    TableNameComboBox.Items.Add( _name );
                }
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
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _dateTime = DateTime.Now;
                var _dateString = _dateTime.ToShortDateString( );
                var _timeString = _dateTime.ToLongTimeString( );
                StatusLabel.Text = _dateString + "  " + _timeString;
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

                    Opacity += 0.01d;
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
                    }

                    Opacity -= 0.01d;
                };

                _timer.Start( );
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
        /// Activates the SQL tab.
        /// </summary>
        private void ActivateSqlTab( )
        {
            try
            {
                SqlTab.TabVisible = true;
                LookupTab.TabVisible = false;
                DataTab.TabVisible = false;
                SchemaTab.TabVisible = false;
                BusyTab.TabVisible = false;
                Title.Text = GetTitleText( ) + "| SQL Editor";
                Title.TextAlign = ContentAlignment.TopLeft;
                _commands = CreateCommandList( _provider );
                PopulateSqlComboBox( _commands );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the lookup tab.
        /// </summary>
        private void ActivateLookupTab( )
        {
            try
            {
                LookupTab.TabVisible = true;
                SqlTab.TabVisible = false;
                DataTab.TabVisible = false;
                SchemaTab.TabVisible = false;
                BusyTab.TabVisible = false;
                PopulateTableListBoxItems( );
                Title.Text = GetTitleText( ) + "| Data Look-Up";
                TableListBox.SelectedValue = string.Empty;
                ColumnListBox.SelectedValue = string.Empty;
                ValueListBox.SelectedValue = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the data tab.
        /// </summary>
        private void ActivateDataTab( )
        {
            try
            {
                DataTab.TabVisible = true;
                SqlTab.TabVisible = false;
                LookupTab.TabVisible = false;
                SchemaTab.TabVisible = false;
                BusyTab.TabVisible = false;
                Title.Text = GetTitleText( )
                    + $"| {_source.ToString( ).SplitPascal( )} Data Table";

                PopulateTableListBoxItems( );
                _commands = CreateCommandList( _provider );
                PopulateSqlComboBox( _commands );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the schema tab.
        /// </summary>
        private void ActivateSchemaTab( )
        {
            try
            {
                SchemaTab.TabVisible = true;
                SqlTab.TabVisible = false;
                LookupTab.TabVisible = false;
                DataTab.TabVisible = false;
                BusyTab.TabVisible = false;
                PopulateTableComboBoxItems( );
                _dataTypes = GetDataTypes( _provider );
                PopulateDataTypeComboBoxItems( _dataTypes );
                Title.Text = GetTitleText( ) + "| SQL Editor";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the busy tab.
        /// </summary>
        private void ActivateBusyTab( )
        {
            try
            {
                BusyTab.TabVisible = true;
                SqlTab.TabVisible = false;
                LookupTab.TabVisible = false;
                DataTab.TabVisible = false;
                SchemaTab.TabVisible = false;
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
                QueryListBox.Items?.Clear( );
                ColumnListBox.Items?.Clear( );
                ValueListBox.Items?.Clear( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the combo boxes.
        /// </summary>
        private void ClearComboBoxes( )
        {
            try
            {
                CommandComboBox.Items?.Clear( );
                TableNameComboBox.Items?.Clear( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the label text.
        /// </summary>
        private void ClearLabels( )
        {
            if( _labels?.Any( ) == true )
            {
                try
                {
                    foreach( var _lbl in _labels.Values )
                    {
                        _lbl.Text = string.Empty;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                ClearComboBoxes( );
                ClearListBoxes( );
                _dataModel = null;
                _dataTable = null;
                BindingSource.DataSource = null;
                DataGrid.DataSource = null;
                ToolStrip.BindingSource.DataSource = null;
                TabControl.SelectedIndex = 0;
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
                if( _selectedColumns?.Any( ) == true )
                {
                    _selectedColumns.Clear( );
                }

                if( _selectedFields?.Any( ) == true )
                {
                    _selectedFields.Clear( );
                }

                if( _selectedNumerics?.Any( ) == true )
                {
                    _selectedNumerics.Clear( );
                }

                if( _commands?.Any( ) == true )
                {
                    _commands.Clear( );
                }

                if( _statements?.Any( ) == true )
                {
                    _statements.Clear( );
                }
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
                _selectedCommand = string.Empty;
                _selectedQuery = string.Empty;
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
                        break;
                    }
                    case Provider.SQLite:
                    {
                        _provider = Provider.SQLite;
                        SQLiteRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        _provider = Provider.SqlCe;
                        SqlCeRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    case Provider.SqlServer:
                    {
                        _provider = Provider.SqlServer;
                        SqlServerRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    default:
                    {
                        _provider = Provider.Access;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
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
        /// Gets the title text.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        private string GetTitleText( )
        {
            try
            {
                return _provider switch
                {
                    Provider.Access => "MS Access ",
                    Provider.SQLite => "SQLite ",
                    Provider.SqlServer => "SQL Server (Local DB) ",
                    Provider.SqlCe => "SQL Server Compact ",
                    _ => "MS Access "
                };
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Sets the active tab controls.
        /// </summary>
        private void SetActiveTab( )
        {
            switch( TabControl.SelectedIndex )
            {
                case 0:
                {
                    ActivateSqlTab( );
                    break;
                }
                case 1:
                {
                    ActivateLookupTab( );
                    break;
                }
                case 2:
                {
                    ActivateDataTab( );
                    break;
                }
                case 3:
                {
                    ActivateSchemaTab( );
                    break;
                }
                case 4:
                {
                    ActivateBusyTab( );
                    break;
                }
            }
        }

        /// <summary>
        /// Sets the form icon.
        /// </summary>
        private void SetFormIcon( )
        {
            try
            {
                var _filePath = AppSettings[ "ProviderImages" ];
                if( !string.IsNullOrEmpty( _filePath ) )
                {
                    var _files = GetFiles( _filePath );
                    if( _files?.Any( ) == true )
                    {
                        var _name = _provider.ToString( );
                        var _file = _files
                            ?.Where( f => f.Contains( _name ) )
                            ?.First( );

                        if( !string.IsNullOrEmpty( _file )
                           && File.Exists( _file ) )
                        {
                            var _img = Image.FromFile( _file );
                            PictureBox.Image = _img;
                        }
                    }
                }
            }
            catch( Exception _ex )
            {
                PictureBox.Image?.Dispose( );
                Fail( _ex );
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
                    return $"SELECT {_names} FROM {_selectedTable} "
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
                ThrowIf.Null( fields, nameof( fields ) );
                ThrowIf.Null( numerics, nameof( numerics ) );
                ThrowIf.Empty( where, nameof( where ) );
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
        /// Binds the data.
        /// </summary>
        private void GetData( )
        {
            try
            {
                if( string.IsNullOrEmpty( _sqlQuery ) )
                {
                    BeginInit( );
                    _dataModel = new DataBuilder( _source, _provider );
                    _dataTable = _dataModel?.DataTable;
                    _fields = _dataModel?.Fields;
                    _numerics = _dataModel?.Numerics;
                    BindingSource.DataSource = _dataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
                    ToolStrip.BindingSource = BindingSource;
                    EndInit( );
                }
                else
                {
                    BeginInit( );
                    _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                    _dataTable = _dataModel?.DataTable;
                    _fields = _dataModel?.Fields;
                    _numerics = _dataModel?.Numerics;
                    BindingSource.DataSource = _dataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
                    ToolStrip.BindingSource = BindingSource;
                    EndInit( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="where">
        /// The where.
        /// </param>
        private void GetData( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                var _sql = CreateSqlText( where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                DataGrid.DataSource = BindingSource;
                DataGrid.PascalizeHeaders( );
                DataGrid.FormatColumns( );
                ToolStrip.BindingSource = BindingSource;
                EndInit( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="cols">The cols.</param>
        /// <param name="where">The where.</param>
        private void GetData( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( cols, nameof( cols ) );
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                var _sql = CreateSqlText( cols, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                DataGrid.DataSource = BindingSource;
                DataGrid.PascalizeHeaders( );
                DataGrid.FormatColumns( );
                ToolStrip.BindingSource = BindingSource;
                EndInit( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        private void GetData( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( fields, nameof( fields ) );
                ThrowIf.Null( numerics, nameof( numerics ) );
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                var _sql = CreateSqlText( fields, numerics, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                DataGrid.DataSource = BindingSource;
                DataGrid.PascalizeHeaders( );
                DataGrid.FormatColumns( );
                ToolStrip.BindingSource = BindingSource;
                EndInit( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Captures the state.
        /// </summary>
        private void CaptureState( )
        {
            try
            {
                _dataArgs.Provider = _provider;
                _dataArgs.Source = _source;
                _dataArgs.Filter = _filter;
                _dataArgs.SelectedTable = _selectedTable;
                _dataArgs.SelectedFields = _selectedFields;
                _dataArgs.SelectedNumerics = _selectedNumerics;
                _dataArgs.SqlQuery = _sqlQuery;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the command list.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <returns>
        /// IList
        /// </returns>
        private IList<string> CreateCommandList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _prefix = AppSettings[ "PathPrefix" ];
                    var _dbpath = AppSettings[ "DatabaseDirectory" ];
                    var _filePath = _prefix + _dbpath + @$"\{provider}\DataModels\";
                    var _names = GetDirectories( _filePath );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = CreateDirectory( _names[ _i ] ).Name;
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
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <returns>
        /// IList
        /// </returns>
        private IList<string> CreateQueryList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _prefix = AppSettings[ "PathPrefix" ];
                    var _dbpath = AppSettings[ "DatabaseDirectory" ];
                    var _filePath = _prefix + _dbpath + @$"\{provider}\DataModels\";
                    var _names = GetDirectories( _filePath );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = CreateDirectory( _names[ _i ] ).Name;
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
        /// Gets the labels.
        /// </summary>
        /// <returns>
        /// Dictionary
        /// </returns>
        private IDictionary<string, Label> GetLabels( )
        {
            try
            {
                _labels = new Dictionary<string, Label>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( Label ) )
                    {
                        _labels.Add( _control.Name, _control as Label );
                    }
                }

                return _labels?.Any( ) == true
                    ? _labels
                    : default( IDictionary<string, Label> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, Label> );
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
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                var _form = (MainForm)Program.Windows[ "MainForm" ];
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.TopMost = true;
                _form.Visible = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the SQL ComboBox.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        private void PopulateSqlComboBox( IList<string> list )
        {
            try
            {
                ThrowIf.Null( list, nameof( list ) );
                var _names = Enum.GetNames( typeof( Command ) );
                CommandComboBox.Items?.Clear( );
                QueryListBox.Items?.Clear( );
                for( var _i = 0; _i < list.Count; _i++ )
                {
                    if( _names.Contains( list[ _i ] )
                       && list[ _i ].Equals( $"{Command.CREATEDATABASE}" ) )
                    {
                        CommandComboBox.Items.Add( "CREATE DATABASE" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.CREATETABLE}" ) )
                    {
                        CommandComboBox.Items.Add( "CREATE TABLE" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.ALTERTABLE}" ) )
                    {
                        CommandComboBox.Items.Add( "ALTER TABLE" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.CREATEVIEW}" ) )
                    {
                        CommandComboBox.Items.Add( "CREATE VIEW" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.SELECTALL}" ) )
                    {
                        CommandComboBox.Items.Add( "SELECT ALL" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.DELETE}" ) )
                    {
                        CommandComboBox.Items.Add( "DELETE" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.INSERT}" ) )
                    {
                        CommandComboBox.Items.Add( "INSERT" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.UPDATE}" ) )
                    {
                        CommandComboBox.Items.Add( "UPDATE" );
                    }
                    else if( _names.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{Command.SELECT}" ) )
                    {
                        CommandComboBox.Items.Add( "SELECT" );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Runs the client application.
        /// </summary>
        private void RunSqlClient( )
        {
            try
            {
                switch( _provider )
                {
                    case Provider.Access:
                    {
                        DataMinion.RunAccess( );
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        DataMinion.RunSqlCe( );
                        break;
                    }
                    case Provider.SQLite:
                    {
                        DataMinion.RunSQLite( );
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeEditor( );
                InitializeToolStrip( );
                InitializeRadioButtons( );
                SetFormIcon( );
                InitializeLabels( );
                InitializeTimer( );
                _tabPages = GetTabPages( );
                _panels = GetPanels( );
                _radioButtons = GetRadioButtons( );
                _listBoxes = GetListBoxes( );
                _labels = GetLabels( );
                TabControl.SelectedIndex = 0;
                Opacity = 0;
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
        /// <param name="sender">
        /// The sender.
        /// </param>
        private void OnRadioButtonChecked( object sender )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _tag = _button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        SetProvider( _tag );
                        _commands = CreateCommandList( _provider );
                        PopulateSqlComboBox( _commands );
                        _dataTypes = GetDataTypes( _provider );
                        PopulateDataTypeComboBoxItems( _dataTypes );
                        Title.Text = GetTitleText( );
                        SetFormIcon( );
                    }

                    if( _button.CheckState == CheckState.Unchecked )
                    {
                        _button.CheckState = CheckState.Checked;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [command ComboBox item selected].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCommandComboBoxItemSelected( object sender, EventArgs e )
        {
            try
            {
                var _comboBox = sender as ComboBox;
                var _prefix = AppSettings[ "PathPrefix" ];
                var _dbpath = AppSettings[ "DatabaseDirectory" ];
                _selectedCommand = string.Empty;
                var _selection = _comboBox?.SelectedItem?.ToString( );
                QueryListBox.Items?.Clear( );
                if( _selection?.Contains( " " ) == true )
                {
                    _selectedCommand = _selection.Replace( " ", "" );
                    var _filePath = _prefix + _dbpath + @$"\{_provider}\DataModels\{_selectedCommand}";
                    var _files = GetFiles( _filePath );
                    for( var _i = 0; _i < _files.Length; _i++ )
                    {
                        var _item = GetFileNameWithoutExtension( _files[ _i ] );
                        var _caption = _item?.SplitPascal( );
                        QueryListBox.Items?.Add( _caption );
                    }
                }
                else
                {
                    _selectedCommand = _comboBox?.SelectedItem?.ToString( );
                    var _filePath = _prefix + _dbpath + @$"\{_provider}\DataModels\{_selectedCommand}";
                    var _names = GetFiles( _filePath );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _item = GetFileNameWithoutExtension( _names[ _i ] );
                        var _caption = _item?.SplitPascal( );
                        QueryListBox.Items?.Add( _caption );
                    }
                }

                if( TabControl.SelectedIndex != 0 )
                {
                    TabControl.SelectedIndex = 0;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [ListBox item selected].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        private void OnQueryListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox
               && !string.IsNullOrEmpty( _listBox.SelectedText ) )
            {
                try
                {
                    var _prefix = AppSettings[ "PathPrefix" ];
                    var _dbpath = AppSettings[ "DatabaseDirectory" ];
                    Editor.Text = string.Empty;
                    _selectedQuery = _listBox.SelectedItem?.ToString( );
                    if( _selectedQuery?.Contains( " " ) == true
                       || _selectedCommand?.Contains( " " ) == true )
                    {
                        var _command = _selectedCommand?.Replace( " ", "" );
                        var _query = _selectedQuery?.Replace( " ", "" );
                        var _filePath = _prefix + _dbpath
                            + @$"\{_provider}\DataModels\{_command}\{_query}.sql";

                        using var _stream = File.OpenRead( _filePath );
                        using var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                    else
                    {
                        var _filePath = _prefix + _dbpath
                            + @$"\{_provider}\DataModels\{_selectedCommand}\{_selectedQuery}.sql";

                        using var _stream = File.OpenRead( _filePath );
                        using var _reader = new StreamReader( _stream );
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

        /// <summary> Called when [refresh button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRefreshButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
                ClearData( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
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
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClick( object sender, EventArgs e )
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
        /// Called when [edit SQL button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnEditSqlButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [edit data button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnEditDataButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 3;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [lookup button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLookupButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 2;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [go button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnGoButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [table button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnTableButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [active tab changed].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnActiveTabChanged( object sender, EventArgs e )
        {
            try
            {
                SetActiveTab( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [save button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSaveButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _message = "THIS IS NOT IMPLEMENTED!";
                SendNotification( _message );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMenuButtonClick( object sender, EventArgs e )
        {
            try
            {
                Close( );
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [client button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClientButtonClick( object sender, EventArgs e )
        {
            RunSqlClient( );
        }

        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        public void OnTableListBoxSelectionChanged( object sender )
        {
            try
            {
                _filter?.Clear( );
                ColumnListBox.Items?.Clear( );
                ValueListBox.Items?.Clear( );
                ColumnTable.CaptionText = string.Empty;
                ValueTable.CaptionText = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    _source = (Source)Enum.Parse( typeof( Source ), _value );
                    _dataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = _dataModel.DataTable;
                    var _dataColumns = _dataModel.DataColumns;
                    foreach( var _col in _dataColumns )
                    {
                        ColumnListBox.Items?.Add( _col.ColumnName );
                    }

                    if( ColumnListBox.Items?.Count > 0 )
                    {
                        ColumnTable.CaptionText = $"Columns:  {ColumnListBox.Items.Count}";
                    }

                    ValueTable.CaptionText = "Values:  ";
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        public void OnColumnListBoxSelectionChanged( object sender )
        {
            try
            {
                ValueListBox.Items?.Clear( );
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = _dataModel.DataElements;
                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var _item in _series[ _column ] )
                    {
                        ValueListBox.Items?.Add( _item );
                    }
                }

                if( ValueListBox.Items?.Count > 0 )
                {
                    ValueTable.CaptionText = $"Values: {ValueListBox.Items.Count}";
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
        /// Called when [file dialog button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBrowserButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _dialog = new FileDialog( );
                _dialog.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnFormClosing( object sender, EventArgs e )
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

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnActivated( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}