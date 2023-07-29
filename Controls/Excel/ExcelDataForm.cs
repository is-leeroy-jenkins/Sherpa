//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ExcelDataForm.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ExcelDataForm.cs" company="Terry D. Eppler">
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
//    ExcelDataForm.cs
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
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.XlsIO;
    using System.Collections;

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
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

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
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        public ExcelDataForm( )
        {
            InitializeComponent( );

            // Form Properties
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

            // Header Properties
            Header.ForeColor = Color.FromArgb( 106, 189, 252 );
            Header.Font = new Font( "Roboto", 11 );
            Header.TextAlign = ContentAlignment.TopLeft;

            // Picture Properties
            PictureBox.Size = new Size( 40, 18 );
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Event Wiring
            Spreadsheet.WorkbookLoaded += OnWorkBookLoaded;
            Header.MouseClick += OnRightClick;
            RemoveFiltersButton.Click += OnRemoveFilterButtonClick;
            LookupButton.Click += OnLookupButtonClicked;
            CloseButton.Click += OnCloseButtonClick;
            UploadButton.Click += OnUploadButtonClick;
            MenuButton.Click += OnMenuButtonClick;
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ExcelDataForm( string filePath )
            : this( )
        {
            FilePath = filePath;
            FileName = Path.GetFileName( filePath );
            Spreadsheet.Open( filePath );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelDataForm" /> class.
        /// </summary>
        /// <param name="fileStream">The file stream.</param>
        public ExcelDataForm( Stream fileStream )
            : this( )
        {
            Spreadsheet.Open( fileStream );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelDataForm" /> class.
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
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelDataForm" /> class.
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
        /// Gets the controls.
        /// </summary>
        /// <returns></returns>
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
                    foreach( Control _control in _collection )
                    {
                        _list.Add( _control );
                        _queue.Enqueue( _control.Controls );
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
        /// Notifies this instance.
        /// </summary>
        private void Notify( )
        {
            try
            {
                var _message = "THIS IS NOT YET IMPLEMENTED!!";
                var _notify = new SplashMessage( _message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void InitToolStrip( )
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
        /// Sets the table configuration.
        /// </summary>
        private void SetTableConfiguration( )
        {
            try
            {
                if( DataTable != null )
                {
                    InitializeTable( DataTable );
                }
                else
                {
                    InitializeTable( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the table properties.
        /// </summary>
        private void InitializeTable( )
        {
            try
            {
                Spreadsheet?.SetActiveSheet( "Sheet1" );
                Spreadsheet?.RenameSheet( "Sheet1", "Data" );
                Spreadsheet?.SetZoomFactor( "Data", 100 );
                Spreadsheet?.SetGridLinesVisibility( false );
                var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                ToolStripTextBox.Text = $"  Rows: {_activeSheet.Rows.Length} "
                    + $"Columns: {_activeSheet.Columns.Length}";

                Spreadsheet?.ActiveGrid?.InvalidateCells( );
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
        private void InitializeTable( DataTable table )
        {
            if( table?.Rows?.Count > 0 )
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
        private void SetWorksheetConfiguration( )
        {
            try
            {
                if( DataTable != null )
                {
                    InitializeWorksheet( DataTable );
                }
                else
                {
                    InitializeWorksheet( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the worksheet properties.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        private void InitializeWorksheet( DataTable dataTable )
        {
            if( dataTable != null )
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
                    RowCount = dataTable.Rows.Count;
                    ColCount = dataTable.Columns.Count;
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
        }

        /// <summary>
        /// Sets the worksheet properties.
        /// </summary>
        private void InitializeWorksheet( )
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
                Spreadsheet.AllowZooming = true;
                Spreadsheet.AllowFiltering = true;
                var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                RowCount = _activeSheet.Rows.Length;
                ColCount = _activeSheet.Columns.Length;
                Spreadsheet.DefaultColumnCount = ColCount;
                Spreadsheet.DefaultRowCount = RowCount;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the active grid properties.
        /// </summary>
        private void SetActiveGridConfiguration( )
        {
            try
            {
                if( DataTable != null )
                {
                    SetGridProperties( DataTable );
                }
                else
                {
                    SetGridProperties( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the grid properties.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        private void SetGridProperties( DataTable dataTable )
        {
            if( dataTable != null )
            {
                try
                {
                    RowCount = dataTable.Rows.Count;
                    ColCount = dataTable.Columns.Count;
                    var _blue = Color.FromArgb( 17, 69, 97 );
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

                    Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBackGround = _blue;
                    Spreadsheet.ActiveGrid.MetroColorTable.ArrowPushed = Color.Green;
                    Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBorderColor = Color.Green;
                    Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormalBorderColor =
                        Color.LightSteelBlue;

                    Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormal = _blue;
                    Spreadsheet.ActiveGrid.MetroColorTable.ThumbPushed = _blue;
                    Spreadsheet.ActiveGrid.Font = new Font( "Roboto", 10 );
                    Spreadsheet.ActiveGrid.ForeColor = Color.Black;
                    Spreadsheet.ActiveGrid.ColumnCount = RowCount;
                    Spreadsheet.ActiveGrid.RowCount = ColCount;
                    Spreadsheet.ActiveGrid.DefaultColumnWidth = 120;
                    Spreadsheet.ActiveGrid.DefaultRowHeight = 22;
                    Spreadsheet.ActiveGrid.CurrentCellActivated += OnCellEnter;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the grid properties.
        /// </summary>
        private void SetGridProperties( )
        {
            try
            {
                var _blue = Color.FromArgb( 17, 69, 97 );
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

                Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBackGround = _blue;
                Spreadsheet.ActiveGrid.MetroColorTable.ArrowPushed = Color.Green;
                Spreadsheet.ActiveGrid.MetroColorTable.ArrowNormalBorderColor = Color.Green;
                Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormalBorderColor =
                    Color.LightSteelBlue;

                Spreadsheet.ActiveGrid.MetroColorTable.ThumbNormal = _blue;
                Spreadsheet.ActiveGrid.MetroColorTable.ThumbPushed = _blue;
                Spreadsheet.ActiveGrid.Font = new Font( "Roboto", 10 );
                Spreadsheet.ActiveGrid.ForeColor = Color.Black;
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
                var _dialog = new FilterDialog( );
                _dialog.ShowDialog( this );
                Provider = _dialog.Provider;
                Source = _dialog.Source;
                SelectedTable = _dialog?.SelectedTable;
                DataModel = new DataBuilder( Source, Provider );
                DataTable = DataModel?.DataTable;
                SetTableConfiguration( );
                SetWorksheetConfiguration( );
                SetActiveGridConfiguration( );
                Refresh( );
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
                Provider = _group.Provider;
                Source = _group.Source;
                SelectedTable = _group?.SelectedTable ?? string.Empty;
                FormFilter = _group?.FormFilter ?? default( IDictionary<string, object> );
                SqlQuery = _group?.SqlQuery;
                DataModel = _group?.DataModel;
                SelectedColumns = _group?.SelectedColumns ?? default( IList<string> );
                SelectedFields = _group?.SelectedFields ?? default( IList<string> );
                SelectedNumerics = _group?.SelectedNumerics ?? default( IList<string> );
                DataTable = DataModel?.DataTable;
                SetTableConfiguration( );
                SetWorksheetConfiguration( );
                SetActiveGridConfiguration( );
                Refresh( );
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
                if( Owner?.Visible == false 
                   && Owner.GetType( ) == typeof( MainForm ) )
                {
                    var _form = (MainForm)Program.Windows[ nameof( MainForm ) ];
                    _form.Refresh( );
                    _form.Visible = true;
                    Close( );
                }
                else
                {
                    var _mainForm = new MainForm( );
                    _mainForm.Show( );
                    Close( );
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 106, 189, 252 );
                Header.Font = new Font( "Roboto", 11 );
                Header.TextAlign = ContentAlignment.TopLeft;
                Ribbon.Spreadsheet = Spreadsheet;
                InitToolStrip( );
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
                SetTableConfiguration( );
                SetActiveGridConfiguration( );
                SetWorksheetConfiguration( );
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
        /// Called when [filter button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
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
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnRemoveFilterButtonClick( object sender, EventArgs e )
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnMenuButtonClick( object sender, EventArgs e )
        {
            OpenMainForm( );
        }

        /// <summary>
        /// Called when [upload button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnUploadButtonClick( object sender, EventArgs e )
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