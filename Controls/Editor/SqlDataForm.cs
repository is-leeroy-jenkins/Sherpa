//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                SqlDataForm.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SqlDataForm.cs" company="Terry D. Eppler">
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
//    SqlDataForm.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;
    using Syncfusion.Windows.Forms.Tools;
    using static System.Configuration.ConfigurationManager;
    using static System.IO.Directory;
    using static System.IO.Path;
    using CheckState = MetroSet_UI.Enums.CheckState;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;
    using FontStyle = System.Drawing.FontStyle;
    using Image = System.Drawing.Image;
    using Size = System.Drawing.Size;
    using SystemColors = System.Drawing.SystemColors;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    public partial class SqlDataForm : EditBase
    {
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private System.Action _statusUpdate;

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value>
        /// The seconds.
        /// </value>
        public int Seconds { get; set; }

        /// <summary>
        /// Gets or sets the first category.
        /// </summary>
        /// <value>
        /// The first category.
        /// </value>
        public string FirstCategory { get; set; }

        /// <summary>
        /// Gets or sets the first value.
        /// </summary>
        /// <value>
        /// The first value.
        /// </value>
        public string FirstValue { get; set; }

        /// <summary>
        /// Gets or sets the second category.
        /// </summary>
        /// <value>
        /// The second category.
        /// </value>
        public string SecondCategory { get; set; }

        /// <summary>
        /// Gets or sets the second value.
        /// </summary>
        /// <value>
        /// The second value.
        /// </value>
        public string SecondValue { get; set; }

        /// <summary>
        /// Gets or sets the third category.
        /// </summary>
        /// <value>
        /// The third category.
        /// </value>
        public string ThirdCategory { get; set; }

        /// <summary>
        /// Gets or sets the third value.
        /// </summary>
        /// <value>
        /// The third value.
        /// </value>
        public string ThirdValue { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        /// <summary>
        /// Gets or sets the selected command.
        /// </summary>
        /// <value>
        /// The selected command.
        /// </value>
        public string SelectedCommand { get; set; }

        /// <summary>
        /// Gets or sets the selected query.
        /// </summary>
        /// <value>
        /// The selected query.
        /// </value>
        public string SelectedQuery { get; set; }

        /// <summary>
        /// Gets or sets the commands.
        /// </summary>
        /// <value>
        /// The commands.
        /// </value>
        public IList<string> Commands { get; set; }

        /// <summary>
        /// Gets or sets the statements.
        /// </summary>
        /// <value>
        /// The statements.
        /// </value>
        public IDictionary<string, object> Statements { get; set; }

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
            get { return _busy; }
            private set { _busy = value; }
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
            InitializeCallbacks( );
            InitializeDelegates( );

            // Form Properties
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            SizeGripStyle = SizeGripStyle.Hide;
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Default Provider
            Provider = Provider.Access;

            // Timer Properties
            Time = 0;
            Seconds = 5;

            // Form Even Wiring
            Load += OnLoad;
            Closing += OnClosing;
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
            Provider = provider;
        }

        /// <summary> Displays the control to the user. </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = 10;
                    Timer.Tick += ( sender, args ) =>
                    {
                        Time++;
                        if( Time == Seconds )
                        {
                            Timer.Stop( );
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
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
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
                var _types = DataTypes.ToArray( );
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
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
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
                _statusUpdate += UpdateStatusLabel;
            }
            catch( Exception _ex )
            {
                Console.WriteLine( _ex );
                throw;
            }
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void InitializeCallbacks( )
        {
            try
            {
                TabControl.SelectedIndexChanged += OnActiveTabChanged;
                AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
                SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlCeRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
                CommandComboBox.SelectedIndexChanged += OnCommandComboBoxItemSelected;
                QueryListBox.SelectedValueChanged += OnListBoxItemSelected;
                RefreshButton.Click += OnRefreshButtonClick;
                SaveButton.Click += OnSaveButtonClick;
                GoButton.Click += OnGoButtonClick;
                CloseButton.Click += OnCloseButtonClick;
                EditSqlButton.Click += OnEditSqlButtonClick;
                EditDataButton.Click += OnEditDataButtonClick;
                TableButton.Click += OnTableButtonClick;
                LookupButton.Click += OnLookupButtonClick;
                MainMenuButton.Click += OnMainMenuButtonClicked;
                ClientButton.Click += OnClientButtonClick;
                TableListBox.SelectedIndexChanged += OnTableListBoxSelectionChanged;
                ColumnListBox.SelectedIndexChanged += OnColumnListBoxSelectionChanged;
                Timer.Tick += OnTimerTick;
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
                switch( Provider )
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
                Title.Font = new Font( "Roboto", 10 );
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timers.
        /// </summary>
        private void InitializeTimers( )
        {
            try
            {
                Timer.Enabled = true;
                Timer.Interval = 500;
                Timer.Start( );
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
            _busy = true;
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private void EndInit( )
        {
            _busy = false;
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatusLabel( )
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
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIf( System.Action action )
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

        /// <summary>
        /// Fades in the Form
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
        /// Fades in the Form
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
        /// Clears the label text.
        /// </summary>
        private void ClearLabels( )
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
                SelectedTable = string.Empty;
                BindingSource.DataSource = null;
                DataModel = null;
                DataTable = null;
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
                if( Filter?.Any( ) == true )
                {
                    Filter.Clear( );
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
                if( SelectedColumns?.Any( ) == true )
                {
                    SelectedColumns.Clear( );
                }

                if( SelectedFields?.Any( ) == true )
                {
                    SelectedFields.Clear( );
                }

                if( SelectedNumerics?.Any( ) == true )
                {
                    SelectedNumerics.Clear( );
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
                ThirdCategory = string.Empty;
                ThirdValue = string.Empty;
                SecondCategory = string.Empty;
                SecondValue = string.Empty;
                FirstCategory = string.Empty;
                FirstValue = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        private void SetProvider( string provider )
        {
            try
            {
                ThrowIf.NullOrEmpty( provider, "provider" );
                var _provider = (Provider)Enum.Parse( typeof( Provider ), provider );
                if( Enum.IsDefined( typeof( Provider ), _provider ) )
                {
                    Provider = _provider switch
                    {
                        Provider.Access => Provider.Access,
                        Provider.SQLite => Provider.SQLite,
                        Provider.SqlCe => Provider.SqlCe,
                        Provider.SqlServer => Provider.SqlServer,
                        _ => Provider.Access
                    };
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
                return Provider switch
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
                    // SQL Tab
                    SqlTab.TabVisible = true;
                    DataTab.TabVisible = false;
                    LookupTab.TabVisible = false;
                    SchemaTab.TabVisible = false;
                    BusyTab.TabVisible = false;
                    Title.Text = GetTitleText( ) + "| SQL Editor";
                    Title.TextAlign = ContentAlignment.TopLeft;
                    Commands = CreateCommandList( Provider );
                    PopulateSqlComboBox( Commands );
                    break;
                }
                case 1:
                {
                    // Data Tab
                    DataTab.TabVisible = true;
                    LookupTab.TabVisible = false;
                    SchemaTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    BusyTab.TabVisible = false;
                    Title.Text = GetTitleText( )
                        + $"| {Source.ToString( ).SplitPascal( )} Data Table";

                    PopulateTableListBoxItems( );
                    Commands = CreateCommandList( Provider );
                    PopulateSqlComboBox( Commands );
                    break;
                }
                case 2:
                {
                    // Lookup Tab
                    LookupTab.TabVisible = true;
                    DataTab.TabVisible = false;
                    SchemaTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    BusyTab.TabVisible = false;
                    PopulateTableListBoxItems( );
                    Title.Text = GetTitleText( ) + "| Data Look-Up";
                    TableListBox.SelectedValue = string.Empty;
                    ColumnListBox.SelectedValue = string.Empty;
                    ValueListBox.SelectedValue = string.Empty;
                    break;
                }
                case 3:
                {
                    // Schema Tab
                    SchemaTab.TabVisible = true;
                    DataTab.TabVisible = false;
                    LookupTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    BusyTab.TabVisible = false;
                    PopulateTableComboBoxItems( );
                    DataTypes = GetDataTypes( Provider );
                    PopulateDataTypeComboBoxItems( DataTypes );
                    Title.Text = GetTitleText( ) + "| Schema Editor";
                    break;
                }
                case 4:
                {
                    // Busy Tab
                    BusyTab.TabVisible = true;
                    SchemaTab.TabVisible = false;
                    DataTab.TabVisible = false;
                    LookupTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    break;
                }
            }
        }

        /// <summary> Sets the form icon. </summary>
        private void SetFormIcon( )
        {
            try
            {
                var _path = AppSettings[ "Providers" ];
                if( !string.IsNullOrEmpty( _path ) )
                {
                    var _files = GetFiles( _path );
                    if( _files?.Any( ) == true )
                    {
                        var _name = Provider.ToString( );
                        var _file = _files?.Where( f => f.Contains( _name ) )?.First( );
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
            if( where?.Any( ) == true )
            {
                try
                {
                    return $"SELECT * FROM {Source} " + $"WHERE {where.ToCriteria( )};";
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
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> columns,
            IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && columns?.Any( ) == true
               && !string.IsNullOrEmpty( SelectedTable ) )
            {
                try
                {
                    var _cols = string.Empty;
                    foreach( var _name in columns )
                    {
                        _cols += $"{_name}, ";
                    }

                    var _criteria = where.ToCriteria( );
                    var _names = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_names} FROM {SelectedTable} " + $"WHERE {_criteria} "
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
            if( where?.Any( ) == true
               && fields?.Any( ) == true
               && numerics?.Any( ) == true )
            {
                try
                {
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
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_columns} "
                        + "FROM {Source} "
                        + $"WHERE {_criteria} "
                        + $"GROUP BY {_groups};";
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
        /// Binds the data.
        /// </summary>
        /// <param name="where">The where.</param>
        private void BindData( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel?.Fields;
                    Numerics = DataModel?.Numerics;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="cols">The cols.</param>
        /// <param name="where">The where.</param>
        private void BindData( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && cols?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( cols, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel?.Fields;
                    Numerics = DataModel?.Numerics;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        private void BindData( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && fields?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlText( fields, numerics, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel?.Fields;
                    Numerics = DataModel?.Numerics;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                    var _path = _prefix + _dbpath + @$"\{provider}\DataModels\";
                    var _names = GetDirectories( _path );
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
                    var _path = _prefix + _dbpath + @$"\{provider}\DataModels\";
                    var _names = GetDirectories( _path );
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
                var _commands = Enum.GetNames( typeof( SQL ) );
                CommandComboBox.Items?.Clear( );
                QueryListBox.Items?.Clear( );
                for( var _i = 0; _i < list.Count; _i++ )
                {
                    if( _commands.Contains( list[ _i ] )
                       && list[ _i ].Equals( $"{SQL.CREATEDATABASE}" ) )
                    {
                        CommandComboBox.Items.Add( "CREATE DATABASE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.CREATETABLE}" ) )
                    {
                        CommandComboBox.Items.Add( "CREATE TABLE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.ALTERTABLE}" ) )
                    {
                        CommandComboBox.Items.Add( "ALTER TABLE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.CREATEVIEW}" ) )
                    {
                        CommandComboBox.Items.Add( "CREATE VIEW" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.SELECTALL}" ) )
                    {
                        CommandComboBox.Items.Add( "SELECT ALL" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.DELETE}" ) )
                    {
                        CommandComboBox.Items.Add( "DELETE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.INSERT}" ) )
                    {
                        CommandComboBox.Items.Add( "INSERT" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.UPDATE}" ) )
                    {
                        CommandComboBox.Items.Add( "UPDATE" );
                    }
                    else if( _commands.Contains( list[ _i ] )
                            && list[ _i ].Equals( $"{SQL.SELECT}" ) )
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
        private void RunClient( )
        {
            try
            {
                switch( Provider )
                {
                    case Provider.Access:
                    {
                        Minion.RunAccess( );
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        Minion.RunSqlCe( );
                        break;
                    }
                    case Provider.SQLite:
                    {
                        Minion.RunSQLite( );
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
                InitializeTimers( );
                TabPages = GetTabPages( );
                Panels = GetPanels( );
                RadioButtons = GetRadioButtons( );
                ListBoxes = GetListBoxes( );
                TabControl.SelectedIndex = 0;
                SetActiveTab( );
                FadeIn( );
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
                        DataTypes = GetDataTypes( Provider );
                        Commands = CreateCommandList( Provider );
                        PopulateSqlComboBox( Commands );
                        PopulateDataTypeComboBoxItems( DataTypes );
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
                SelectedCommand = string.Empty;
                var _selection = _comboBox?.SelectedItem?.ToString( );
                QueryListBox.Items?.Clear( );
                if( _selection?.Contains( " " ) == true )
                {
                    SelectedCommand = _selection.Replace( " ", "" );
                    var _path = _prefix + _dbpath + @$"\{Provider}\DataModels\{SelectedCommand}";
                    var _files = GetFiles( _path );
                    for( var _i = 0; _i < _files.Length; _i++ )
                    {
                        var _item = GetFileNameWithoutExtension( _files[ _i ] );
                        var _caption = _item?.SplitPascal( );
                        QueryListBox.Items?.Add( _caption );
                    }
                }
                else
                {
                    SelectedCommand = _comboBox?.SelectedItem?.ToString( );
                    var _path = _prefix + _dbpath + @$"\{Provider}\DataModels\{SelectedCommand}";
                    var _names = GetFiles( _path );
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
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox
               && !string.IsNullOrEmpty( _listBox.SelectedText ) )
            {
                try
                {
                    var _prefix = AppSettings[ "PathPrefix" ];
                    var _dbpath = AppSettings[ "DatabaseDirectory" ];
                    Editor.Text = string.Empty;
                    SelectedQuery = _listBox.SelectedItem?.ToString( );
                    if( SelectedQuery?.Contains( " " ) == true
                       || SelectedCommand?.Contains( " " ) == true )
                    {
                        var _command = SelectedCommand?.Replace( " ", "" );
                        var _query = SelectedQuery?.Replace( " ", "" );
                        var _filePath = _prefix + _dbpath
                            + @$"\{Provider}\DataModels\{_command}\{_query}.sql";

                        using var _stream = File.OpenRead( _filePath );
                        using var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                    else
                    {
                        var _path = _prefix + _dbpath
                            + @$"\{Provider}\DataModels\{SelectedCommand}\{SelectedQuery}.sql";

                        using var _stream = File.OpenRead( _path );
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
                ClearSelections( );
                ClearCollections( );
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
                FadeOut( );
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [form closed].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnFormClosed( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "SqlDataForm" ) )
                {
                    Program.Windows.Remove( "SqlDataForm" );
                }
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
        private void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
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
            RunClient( );
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
                Filter?.Clear( );
                ColumnListBox.Items?.Clear( );
                ValueListBox.Items?.Clear( );
                ColumnTable.CaptionText = string.Empty;
                ValueTable.CaptionText = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    var _columns = DataModel.DataColumns;
                    foreach( var _col in _columns )
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
                var _series = DataModel.DataElements;
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
            InvokeIf( _statusUpdate );
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnClosing( object sender, EventArgs e )
        {
            try
            {
                ClearSelections( );
                ClearCollections( );
                PictureBox.Image?.Dispose( );
                if( DataModel != null )
                {
                    DataModel = null;
                }

                if( DataModel != null )
                {
                    DataTable = null;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}