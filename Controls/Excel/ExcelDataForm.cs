// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-08-2023
// ******************************************************************************************
// <copyright file="ExcelDataForm.cs" company="Terry D. Eppler">
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
//   ExcelDataForm.cs
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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public partial class ExcelDataForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        /// <value>
        /// The row count.
        /// </value>
        public int RowCount { get; set; }

        /// <summary>
        /// Gets or sets the col count.
        /// </summary>
        /// <value>
        /// The col count.
        /// </value>
        public int ColCount { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns { get; set; }

        /// <summary>
        /// Gets or sets the selected fields.
        /// </summary>
        /// <value>
        /// The selected fields.
        /// </value>
        public IList<string> SelectedFields { get; set; }

        /// <summary>
        /// Gets or sets the selected numerics.
        /// </summary>
        /// <value>
        /// The selected numerics.
        /// </value>
        public IList<string> SelectedNumerics { get; set; }

        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public SpreadsheetGridModel Model { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        public ExcelDataForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Auto;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Ribbon Properties
            Ribbon.Spreadsheet = Spreadsheet;
            PictureBox.Size = new Size( 40, 18 );
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Event Wiring
            RemoveFiltersButton.Click += null;
            TableButton.Click += null;
            LookupButton.Click += null;
            UploadButton.Click += null;
            MenuButton.Click += null;
            RemoveFiltersButton.Click += null;
            Spreadsheet.WorkbookLoaded += OnWorkBookLoaded;
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClose;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ExcelDataForm( string filePath )
            : this( )
        {
            Spreadsheet.Open( filePath );
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        public ExcelDataForm( Stream fileStream )
            : this( )
        {
            Spreadsheet.Open( fileStream );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ExcelDataForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource.DataSource = (DataTable)bindingSource.DataSource;
            DataTable = (DataTable)bindingSource.DataSource;
            SelectedTable = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
            Header.Text = $"{SelectedTable.SplitPascal( )} ";
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ExcelDataForm( DataTable dataTable )
            : this( )
        {
            DataTable = dataTable;
            BindingSource.DataSource = dataTable;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Header.Text = $"{DataTable.TableName.SplitPascal( )} ";
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 0, 120, 212 );
                Header.Font = new Font( "Roboto", 12, FontStyle.Bold );
                Header.TextAlign = ContentAlignment.TopCenter;
                Header.MouseClick += OnRightClick;
                RemoveFiltersButton.Click += OnRemoveFilterButtonClicked;
                LookupButton.Click += OnLookupButtonClicked;
                MenuButton.Click += OnMainMenuButtonClicked;
                UploadButton.Click += OnUploadButtonClicked;
                BackButton.Click += OnBackButtonClicked;
                Ribbon.Spreadsheet = Spreadsheet;
                SetToolStripProperties( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void SetToolStripProperties( )
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
                ToolStripTextBox.Size = new Size( 190, 28 );
                ToolStripTextBox.Font = new Font( "Roboto", 8 );
                ToolStripTextBox.ForeColor = Color.White;
                ToolStripTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
                ToolStripTextBox.Text = DateTime.Today.ToShortDateString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the table properties.
        /// </summary>
        /// <param name="table">The table.</param>
        private void SetTableProperties( DataTable table )
        {
            if( ( table != null )
               && ( table?.Rows?.Count > 0 ) )
            {
                try
                {
                    Spreadsheet?.SetActiveSheet( "Sheet1" );
                    Spreadsheet?.RenameSheet( "Sheet1", "Data" );
                    Spreadsheet?.SetZoomFactor( "Data", 100 );
                    Spreadsheet?.ActiveSheet?.ImportDataTable( table, true, 1, 1 );
                    Spreadsheet?.SetGridLinesVisibility( false );
                    var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                    var _usedRange = _activeSheet?.UsedRange;
                    var _table = _activeSheet?.ListObjects?.Create( table.TableName, _usedRange );
                    _usedRange.CellStyle.Font.FontName = "Roboto";
                    _usedRange.CellStyle.Font.Size = 10;
                    _usedRange.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    _usedRange.CellStyle.VerticalAlignment = ExcelVAlign.VAlignBottom;
                    var _topRow = _activeSheet?.Range[ 1, 1, 1, 60 ];
                    RowCount = DataTable.Rows.Count;
                    ColCount = DataTable.Columns.Count;
                    ToolStripTextBox.Text = $"  Rows: {RowCount}  Columns: {ColCount}";
                    _topRow?.FreezePanes( );
                    _table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium16;
                    Spreadsheet?.ActiveGrid?.InvalidateCells( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the worksheet properties.
        /// </summary>
        private void SetWorksheetProperties( )
        {
            try
            {
                Spreadsheet.DisplayAlerts = false;
                Spreadsheet.Font = new Font( "Roboto", 10 );
                Spreadsheet.AllowCellContextMenu = true;
                Spreadsheet.CanApplyTheme = true;
                Spreadsheet.CanOverrideStyle = true;
                Spreadsheet.Margin = new Padding( 1 );
                Spreadsheet.Padding = new Padding( 1 );
                Spreadsheet.ForeColor = Color.Black;
                Spreadsheet.DefaultColumnCount = RowCount;
                Spreadsheet.DefaultRowCount = ColCount;
                Spreadsheet.AllowZooming = true;
                Spreadsheet.AllowFiltering = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the active grid properties.
        /// </summary>
        private void SetActiveGridProperties( )
        {
            try
            {
                Spreadsheet.ActiveGrid.ContextMenuStrip = ContextMenu;
                Spreadsheet.ActiveGrid.FrozenRows = 3;
                Spreadsheet.ActiveGrid.AllowSelection = true;
                Spreadsheet.ActiveGrid.CanOverrideStyle = true;
                Spreadsheet.ActiveGrid.CanApplyTheme = true;
                Spreadsheet.ActiveGrid.BackColor = SystemColors.GradientInactiveCaption;
                Spreadsheet.ActiveGrid.MetroScrollBars = true;
                Spreadsheet.ActiveGrid.MetroColorTable = new MetroColorTable( );
                Spreadsheet.ActiveGrid.MetroColorTable.ScrollerBackground =
                    SystemColors.ControlDarkDark;

                Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBackGround =
                    Color.FromArgb( 17, 69, 97 );

                Spreadsheet.ActiveGrid.MetroColorTable.ArrowPushed = Color.Green;
                Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBorderColor = Color.Green;
                Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormalBorderColor =
                    Color.LightSteelBlue;

                Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormal = Color.FromArgb( 17, 69, 97 );
                Spreadsheet.ActiveGrid.MetroColorTable.ThumbPushed = Color.FromArgb( 17, 69, 97 );
                Spreadsheet.ActiveGrid.Font = new Font( "Roboto", 10 );
                Spreadsheet.ActiveGrid.ForeColor = Color.Black;
                Spreadsheet.ActiveGrid.ColumnCount = ColCount;
                Spreadsheet.ActiveGrid.RowCount = RowCount;
                Spreadsheet.ActiveGrid.DefaultColumnWidth = 120;
                Spreadsheet.ActiveGrid.DefaultRowHeight = 22;
                Spreadsheet.ActiveGrid.CurrentCellActivated += OnCellEnter;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the table dialog.
        /// </summary>
        private void ShowTableDialog( )
        {
            try
            {
                var _group = new FilterDialog( );
                _group.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the filter dialog.
        /// </summary>
        private void ShowFilterDialog( )
        {
            try
            {
                var _group = new FilterDialog( BindingSource );
                _group.ShowDialog( this );
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
                SelectedTable = string.Empty;
                DataModel = null;
                DataTable = null;
                Spreadsheet.ActiveSheet.ClearData( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false )
                   && ( Owner.GetType( ) == typeof( MainForm ) ) )
                {
                    Owner.Visible = true;
                    Visible = false;
                }
                else if( ( Owner != null )
                        && ( Owner.Visible == false )
                        && ( Owner.GetType( ) != typeof( MainForm ) ) )
                {
                    Owner.Close( );
                    var _mainForm = (MainForm)Program.Windows[ "MainForm" ];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
                    ClearData( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the data grid form.
        /// </summary>
        private void OpenDataGridForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "DataGridForm" ) )
                {
                    var _dataGridForm = (DataGridForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( DataGridForm ) )
                        ?.First( );

                    _dataGridForm.Owner = this;
                    _dataGridForm.ClearData( );
                    _dataGridForm.Refresh( );
                    _dataGridForm.Visible = true;
                    Visible = false;
                }
                else if( !Program.Windows.ContainsKey( "DataGridForm" )
                        && Program.Windows.ContainsKey( "MainForm" ) )
                {
                    var _mainForm = (MainForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( MainForm ) )
                        ?.First( );

                    var _dataGridForm = new DataGridForm( BindingSource );
                    _dataGridForm.Owner = _mainForm;
                    _dataGridForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the chart data form.
        /// </summary>
        private void OpenChartDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "ChartDataForm" ) )
                {
                    var _chartDataForm = (ChartDataForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( ChartDataForm ) )
                        ?.First( );

                    _chartDataForm.Owner = this;
                    _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Refresh( );
                    _chartDataForm.Visible = true;
                    Visible = false;
                }
                else if( !Program.Windows.ContainsKey( "ChartDataForm" )
                        && Program.Windows.ContainsKey( "MainForm" ) )
                {
                    var _mainForm = (MainForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( MainForm ) )
                        ?.First( );

                    var _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Owner = _mainForm;
                    _chartDataForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [work book loaded].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnWorkBookLoaded( object sender, EventArgs e )
        {
            try
            {
                SetTableProperties( DataTable );
                SetActiveGridProperties( );
                SetWorksheetProperties( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [cell enter].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/> instance containing the event data.
        /// </param>
        [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
        public void OnCellEnter( object sender, CurrentCellActivatedEventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( Spreadsheet.CurrentCellValue )
                   && ( e.ActivationTrigger == ActivationTrigger.Mouse ) )
                {
                    var _value = Spreadsheet.CurrentCellRange.DisplayText;
                    if( !string.IsNullOrEmpty( _value )
                       && ( _value.Length > 25 ) )
                    {
                        var _editDialog = new TextDialog( _value );
                        _editDialog.ShowDialog( );
                        Spreadsheet.ActiveGrid.SetCellValue( Spreadsheet.CurrentCellRange,
                            _editDialog.Editor.Text );
                    }
                    else if( !string.IsNullOrEmpty( _value )
                            && ( _value.Length >= 6 )
                            && ( _value.Length <= 9 )
                            && ( _value.Substring( 0, 3 ) == "000" ) )
                    {
                        var _code = _value.Substring( 4, 2 );
                        var _dialog = new ProgramProjectDialog( _code );
                        _dialog.ShowDialog( );
                    }
                    else if( decimal.TryParse( _value, out var _decimal ) )
                    {
                        var _double = Convert.ToDouble( _decimal );
                        var _calculator = new CalculationForm( _double );
                        _calculator.ShowDialog( );
                        Spreadsheet.ActiveGrid.SetCellValue( Spreadsheet.CurrentCellRange,
                            _calculator.Calculator.Value.ToString( ) );
                    }
                    else if( double.TryParse( _value, out var _double ) )
                    {
                        var _calculator = new CalculationForm( _double );
                        _calculator.ShowDialog( );
                        Spreadsheet.ActiveGrid.SetCellValue( Spreadsheet.CurrentCellRange,
                            _calculator.Calculator.Value.ToString( ) );
                    }
                    else if( DateTime.TryParse( _value, out var _dateTime ) )
                    {
                        var _form = new CalendarDialog( _dateTime );
                        _form.ShowDialog( );
                        Spreadsheet.ActiveGrid.SetCellValue( Spreadsheet.CurrentCellRange,
                            _form.Calendar.SelectedDate.ToString( ) );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [table button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTableButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( BindingSource.DataSource != null )
                {
                    OpenDataGridForm( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false ) )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Visible = false;
                }
                else
                {
                    var _mainForm = (MainForm)Program.Windows[ "MainForm" ];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
                    ClearData( );
                    Owner = _mainForm;
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [exit button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnExitButtonClick( object sender, EventArgs e )
        {
            try
            {
                Application.Exit( );
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                Program.Windows[ "ExcelDataForm" ] = this;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClose( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "ExcelDataForm" ) )
                {
                    Program.Windows.Remove( "ExcelDataForm" );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [filter button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnFilterButtonClick( object sender, EventArgs e )
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
        /// Called when [group button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnGroupButtonClick( object sender, EventArgs e )
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
        /// Called when [chart button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnChartButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( BindingSource.DataSource != null )
                {
                    OpenChartDataForm( );
                    Visible = false;
                }
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
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        public void OnRightClick( object sender, MouseEventArgs e )
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
        /// Called when [lookup button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLookupButtonClicked( object sender, EventArgs e )
        {
            try
            {
                ShowTableDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [remove filter button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnRemoveFilterButtonClicked( object sender, EventArgs e )
        {
            try
            {
                ShowFilterDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false )
                   && ( Owner.GetType( ) == typeof( MainForm ) ) )
                {
                    Owner.Visible = true;
                }
                else if( ( Owner != null )
                        && ( Owner.Visible == false )
                        && ( Owner.GetType( ) != typeof( MainForm ) ) )
                {
                    Owner.Close( );
                    var _mainForm = Program.Windows[ "Main" ];
                    _mainForm.Visible = true;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [upload button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnUploadButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && ( _button.ToolType == ToolType.UploadButton ) )
                {
                    var _dialog = new LoadingForm( Status.Waiting );
                    _dialog.ShowDialog( this );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}