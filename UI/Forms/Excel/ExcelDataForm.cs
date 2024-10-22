﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-24-2023
// ******************************************************************************************
// <copyright file="ExcelDataForm.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
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
//    Contact at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ExcelDataForm.cs
// </summary>
// ******************************************************************************************

using System;

namespace Sherpa.UI.Forms.Excel
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.CellGrid.Helpers;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.XlsIO;
    using ComboBox = Sherpa.ComboBox;
    using FileDialog = Sherpa.FileDialog;
    using ListBox = Sherpa.ListBox;
    using RadioButton = Sherpa.RadioButton;
    using ToolStripButton = Sherpa.ToolStripButton;

    /// <summary>
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public partial class ExcelDataForm : MetroForm
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
        private System.Action _statusUpdate;

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
        /// The row count
        /// </summary>
        private int _rowCount;

        /// <summary>
        /// The column count
        /// </summary>
        private int _colCount;
        
        /// <summary>
        /// The selected dataTable
        /// </summary>
        private string _selectedTable;

        /// <summary>
        /// The first category
        /// </summary>
        private string _firstCategory;

        /// <summary>
        /// The file path
        /// </summary>
        private string _filePath;

        /// <summary>
        /// The file name
        /// </summary>
        private string _fileName;

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
        /// The SQL query
        /// </summary>
        private string _sqlQuery;

        /// <summary>
        /// The columns
        /// </summary>
        private IList<string> _columns;

        /// <summary>
        /// The data model
        /// </summary>
        private DataBuilder _dataModel;

        /// <summary>
        /// The data dataTable
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// The current
        /// </summary>
        private DataRow _current;

        /// <summary>
        /// The filter
        /// </summary>
        private IDictionary<string, object> _filter;

        /// <summary>
        /// The fields
        /// </summary>
        private IList<string> _fields;

        /// <summary>
        /// The numerics
        /// </summary>
        private IList<string> _numerics;

        /// <summary>
        /// The selected columns
        /// </summary>
        private IList<string> _selectedColumns;

        /// <summary>
        /// The selected fields
        /// </summary>
        private IList<string> _selectedFields;

        /// <summary>
        /// The selected numerics
        /// </summary>
        private IList<string> _selectedNumerics;

        /// <summary>
        /// The source
        /// </summary>
        private Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private Provider _provider;

        /// <summary>
        /// The data arguments
        /// </summary>
        private DataArgs _dataArgs;

        /// <summary>
        /// Gets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current
        {
            get
            {
                return _current;
            }
            private set
            {
                _current = value;
            }
        }
        
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
        /// Gets the selected dataTable.
        /// </summary>
        /// <value>
        /// The selected dataTable.
        /// </value>
        public string SelectedTable
        {
            get
            {
                return _selectedTable;
            }
            private set
            {
                _selectedTable = value;
            }
        }
        
        /// <summary>
        /// Gets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery
        {
            get
            {
                return _sqlQuery;
            }
            private set
            {
                _sqlQuery = value;
            }
        }

        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IList<string> Columns
        {
            get
            {
                return _columns;
            }
            private set
            {
                _columns = value;
            }
        }

        /// <summary>
        /// Gets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel
        {
            get
            {
                return _dataModel;
            }
            private set
            {
                _dataModel = value;
            }
        }

        /// <summary>
        /// Gets the data dataTable.
        /// </summary>
        /// <value>
        /// The data dataTable.
        /// </value>
        public DataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            private set
            {
                _dataTable = value;
            }
        }

        /// <summary>
        /// Gets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> Filter
        {
            get
            {
                return _filter;
            }
            private set
            {
                _filter = value;
            }
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields
        {
            get
            {
                return _fields;
            }
            private set
            {
                _fields = value;
            }
        }

        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics
        {
            get
            {
                return _numerics;
            }
            private set
            {
                _numerics = value;
            }
        }

        /// <summary>
        /// Gets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns
        {
            get
            {
                return _selectedColumns;
            }
            private set
            {
                _selectedColumns = value;
            }
        }

        /// <summary>
        /// Gets the selected fields.
        /// </summary>
        /// <value>
        /// The selected fields.
        /// </value>
        public IList<string> SelectedFields
        {
            get
            {
                return _selectedFields;
            }
            private set
            {
                _selectedFields = value;
            }
        }

        /// <summary>
        /// Gets the selected numerics.
        /// </summary>
        /// <value>
        /// The selected numerics.
        /// </value>
        public IList<string> SelectedNumerics
        {
            get
            {
                return _selectedNumerics;
            }
            private set
            {
                _selectedNumerics = value;
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

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.UI.Forms.Excel.ExcelDataForm"/>
        /// class.
        /// </summary>
        public ExcelDataForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Form Properties
            MaximumSize = new Size( 1920, 1080 );
            MinimumSize = new Size( 1330, 730 );
            Size = new Size( 1340, 740 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            SizeGripStyle = SizeGripStyle.Auto;
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 3;
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

            // Data Attributes
            _filter = new Dictionary<string, object>( );
            _fields = new List<string>( );
            _columns = new List<string>( );
            _numerics = new List<string>( );
            _selectedColumns = new List<string>( );
            _selectedFields = new List<string>( );
            _selectedNumerics = new List<string>( );
            _dataArgs = new DataArgs( );

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Ribbon Properties
            Ribbon.Spreadsheet = Spreadsheet;
            TabControl.SelectedIndex = 0;

            // Default Provider
            _provider = Provider.Access;

            // Event Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.UI.Forms.Excel.ExcelDataForm"/>
        /// class.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        public ExcelDataForm( string filePath )
            : this( )
        {
            _filePath = filePath;
            _fileName = Path.GetFileNameWithoutExtension( filePath );
            Header.Text = _fileName;
            Spreadsheet.Open( filePath );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.UI.Forms.Excel.ExcelDataForm"/>
        /// class.
        /// </summary>
        /// <param name="bindingSource">
        /// The binding source.
        /// </param>
        public ExcelDataForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource.DataSource = (DataTable)bindingSource.DataSource;
            _dataTable = (DataTable)bindingSource.DataSource;
            _selectedTable = ( (DataTable)bindingSource.DataSource ).TableName;
            _source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
            Header.Text = $"{SelectedTable.SplitPascal( )} ";
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.UI.Forms.Excel.ExcelDataForm"/>
        /// class.
        /// </summary>
        /// <param name="dataTable"> The data dataTable. </param>
        public ExcelDataForm( DataTable dataTable )
            : this( )
        {
            _dataTable = dataTable;
            BindingSource.DataSource = dataTable;
            _selectedTable = dataTable.TableName;
            _source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            Header.Text = $"{dataTable.TableName.SplitPascal( )} ";
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                Spreadsheet.WorkbookLoaded += OnWorkBookLoaded;
                Header.MouseClick += OnRightClick;
                LookupButton.Click += OnLookupButtonClicked;
                CloseButton.Click += OnCloseButtonClick;
                BrowseButton.Click += OnBrowserButtonClick;
                MenuButton.Click += OnMenuButtonClicked;
                ExportButton.Click += OnExcelButtonClicked;
                TabControl.SelectedIndexChanged += OnActiveTabChanged;
                Timer.Tick += OnTimerTick;
                TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
                FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
                FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
                SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
                SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
                ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
                ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
                ExecutionRadioButton.CheckedChanged += OnTableRadioButtonSelected;
                ReferenceRadioButton.CheckedChanged += OnTableRadioButtonSelected;
                MaintenanceRadioButton.CheckedChanged += OnTableRadioButtonSelected;
                SqliteRadioButton.CheckedChanged += OnProviderRadioButtonSelected;
                SqlCeRadioButton.CheckedChanged += OnProviderRadioButtonSelected;
                SqlServerRadioButton.CheckedChanged += OnProviderRadioButtonSelected;
                AccessRadioButton.CheckedChanged += OnProviderRadioButtonSelected;
                ExportButton.Click += OnExportButtonClick;
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
        /// Initializes the tool strip.
        /// </summary>
        private void InitializeToolStrip( )
        {
            try
            {
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.Office12Mode = true;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
                ToolStripTextBox.TextBox.ForeColor = Color.White;
                ToolStripTextBox.TextBox.Font = new Font( "Roboto", 9 );
                ToolStripTextBox.TextBox.Size = new Size( 180, 25 );
                ToolStripTextBox.TextBox.ForeColor = Color.White;
                ToolStripTextBox.TextBox.Text = "     < Enter Keywords >     ";
                ToolStripTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
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
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
        {
            try
            {
                // Timer Properties
                Timer.Interval = 80;
                Timer.Tick += OnTimerTick;
                Timer.Enabled = true;
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
                Header.ForeColor = Color.FromArgb( 106, 189, 252 );
                Header.Font = new Font( "Roboto", 10 );
                Header.TextAlign = ContentAlignment.TopCenter;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the dataTable.
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
        /// Initializes the dataTable.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        private void InitializeTable( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    Spreadsheet?.SetActiveSheet( "Sheet1" );
                    Spreadsheet?.RenameSheet( "Sheet1", "Data" );
                    Spreadsheet?.SetZoomFactor( "Data", 100 );
                    Spreadsheet?.ActiveSheet?.ImportDataTable( dataTable, true, 1, 1 );
                    Spreadsheet?.SetGridLinesVisibility( false );
                    var _activeSheet = Spreadsheet?.Workbook?.ActiveSheet;
                    var _usedRange = _activeSheet?.UsedRange;
                    var _table = _activeSheet?.ListObjects?.Create( dataTable.TableName, _usedRange );
                    _usedRange.CellStyle.Font.FontName = "Roboto";
                    _usedRange.CellStyle.Font.Size = 9;
                    _usedRange.CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    _usedRange.CellStyle.VerticalAlignment = ExcelVAlign.VAlignBottom;
                    var _topRow = _activeSheet?.Range[ 1, 1, 1, 60 ];
                    _rowCount = _dataTable.Rows.Count;
                    _colCount = _dataTable.Columns.Count;
                    ToolStripTextBox.Text = $"  Rows: {_rowCount}  Columns: {_colCount}";
                    _topRow?.FreezePanes( );
                    _table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium16;
                    var _title = dataTable?.TableName.SplitPascal( );
                    Spreadsheet?.ActiveGrid?.InvalidateCells( );
                    Header.Text = $"{_title} Data Table";
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
        /// <param name="dataTable"> The data dataTable. </param>
        private void InitializeWorksheet( DataTable dataTable )
        {
            try
            {
                ThrowIf.Null( dataTable, nameof( dataTable ) );
                _rowCount = dataTable.Rows.Count;
                _colCount = dataTable.Columns.Count;
                Spreadsheet.DisplayAlerts = false;
                Spreadsheet.Font = new Font( "Roboto", 9 );
                Spreadsheet.AllowCellContextMenu = true;
                Spreadsheet.CanApplyTheme = true;
                Spreadsheet.CanOverrideStyle = true;
                Spreadsheet.Margin = new Padding( 1 );
                Spreadsheet.Padding = new Padding( 1 );
                Spreadsheet.ForeColor = Color.Black;
                Spreadsheet.DefaultColumnCount = _rowCount;
                Spreadsheet.DefaultRowCount = _colCount;
                Spreadsheet.AllowZooming = true;
                Spreadsheet.AllowFiltering = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the worksheet properties.
        /// </summary>
        private void InitializeWorksheet( )
        {
            try
            {
                var _sheet = Spreadsheet?.Workbook?.ActiveSheet;
                _rowCount = _sheet.Rows.Length;
                _colCount = _sheet.Columns.Length;
                Spreadsheet.DisplayAlerts = false;
                Spreadsheet.Font = new Font( "Roboto", 9 );
                Spreadsheet.AllowCellContextMenu = true;
                Spreadsheet.CanApplyTheme = true;
                Spreadsheet.CanOverrideStyle = true;
                Spreadsheet.Margin = new Padding( 1 );
                Spreadsheet.Padding = new Padding( 1 );
                Spreadsheet.ForeColor = Color.Black;
                Spreadsheet.AllowZooming = true;
                Spreadsheet.AllowFiltering = true;
                Spreadsheet.DefaultColumnCount = _colCount;
                Spreadsheet.DefaultRowCount = _rowCount;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the ribbon.
        /// </summary>
        private void InitializeRibbon( )
        {
            try
            {
                Ribbon.Size = new Size( 1338, 128 );
                Ribbon.Spreadsheet = Spreadsheet;
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
        /// Clears the data.
        /// </summary>
        public void ClearData( )
        {
            try
            {
                _dataModel = null;
                _dataTable = null;
                BindingSource.DataSource = null;
                ToolStrip.BindingSource.DataSource = null;
                ClearCollections( );
                ClearSelections( );
                Spreadsheet.ActiveSheet?.ClearData( );
                TabControl.SelectedIndex = 0;
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
                _fourthCategory = string.Empty;
                _fourthValue = string.Empty;
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
        /// Clears the collections.
        /// </summary>
        private void ClearCollections( )
        {
            try
            {
                if( _filter?.Any( ) == true )
                {
                    _filter.Clear( );
                }

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
                FirstComboBox.Items?.Clear( );
                SecondComboBox.Items?.Clear( );
                ThirdComboBox.Items?.Clear( );
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
                TableListBox.Items?.Clear( );
                FirstListBox.Items?.Clear( );
                SecondListBox.Items?.Clear( );
                ThirdListBox.Items?.Clear( );
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
                    : default( IEnumerable<Control> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<Control> );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public void InvokeIf( System.Action action )
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
        /// Notifies this instance.
        /// </summary>
        private void SendMessage( string message )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                var _notify = new SplashMessage( message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SendNotification( string text )
        {
            try
            {
                ThrowIf.Null( text, nameof( text ) );
                var _notification = new Notification( text );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the worksheet properties.
        /// </summary>
        private void SetWorksheetConfiguration( )
        {
            try
            {
                if( _dataTable != null )
                {
                    InitializeWorksheet( _dataTable );
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
        /// Sets the dataTable configuration.
        /// </summary>
        private void SetTableConfiguration( )
        {
            try
            {
                if( _dataTable != null )
                {
                    InitializeTable( _dataTable );
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
        /// Sets the active grid configuration.
        /// </summary>
        private void SetActiveGridConfiguration( )
        {
            try
            {
                if( _dataTable != null )
                {
                    SetGridProperties( _dataTable );
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
        /// <param name="dataTable">
        /// The data dataTable.
        /// </param>
        private void SetGridProperties( DataTable dataTable )
        {
            if( dataTable != null )
            {
                try
                {
                    _rowCount = dataTable.Rows.Count;
                    _colCount = dataTable.Columns.Count;
                    var _blue = Color.FromArgb( 17, 69, 97 );

                    //Spreadsheet.ActiveGrid.ContextMenuStrip = FormMenu;
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
                    Spreadsheet.ActiveGrid.Font = new Font( "Roboto", 9 );
                    Spreadsheet.ActiveGrid.ForeColor = Color.Black;
                    Spreadsheet.ActiveGrid.ColumnCount = _rowCount;
                    Spreadsheet.ActiveGrid.RowCount = _colCount;
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

                //Spreadsheet.ActiveGrid.ContextMenuStrip = FormMenu;
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
                Spreadsheet.ActiveGrid.Font = new Font( "Roboto", 9 );
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
        /// Shows the filter dialog.
        /// </summary>
        private void ShowFilterPage( )
        {
            try
            {
                var _group = new FilterPage( );
                _group.ShowDialog( this );
                _provider = _group.DataArgs.Provider;
                _source = _group.DataArgs.Source;
                _selectedTable = _group.DataArgs.SelectedTable ?? string.Empty;
                _filter = _group.DataArgs.Filter ?? default( IDictionary<string, object> );
                _sqlQuery = _group.DataArgs.SqlQuery ?? string.Empty;
                _selectedColumns = _group.DataArgs.SelectedColumns ?? default( IList<string> );
                _selectedFields = _group.DataArgs.SelectedFields ?? default( IList<string> );
                _selectedNumerics = _group.DataArgs.SelectedNumerics ?? default( IList<string> );
                _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                _dataTable = _dataModel?.DataTable;
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
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                var _form = (MainForm)Program.Windows[ nameof( MainForm ) ];
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
        /// Populates the execution tables.
        /// </summary>
        private void PopulateExecutionTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.OrderBy( r => r.Field<string>( "Title" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                if( _names?.Any( ) == true )
                {
                    foreach( var _name in _names )
                    {
                        TableListBox.Items?.Add( _name );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the reference tables.
        /// </summary>
        private void PopulateReferenceTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "REFERENCE" ) )
                    ?.OrderBy( r => r.Field<string>( "Title" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                if( _names?.Any( ) == true )
                {
                    foreach( var _name in _names )
                    {
                        TableListBox.Items?.Add( _name );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the maintenance tables.
        /// </summary>
        private void PopulateMaintenanceTables( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "MAINTENANCE" ) )
                    ?.OrderBy( r => r.Field<string>( "Title" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                if( _names?.Any( ) == true )
                {
                    foreach( var _name in _names )
                    {
                        TableListBox.Items?.Add( _name );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the second ComboBox items.
        /// </summary>
        private void PopulateSecondListBoxItems( )
        {
            if( _columns?.Any( ) == true )
            {
                try
                {
                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    foreach( var _column in Columns )
                    {
                        FirstListBox.Items.Add( _column );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Populates the third ListBox items.
        /// </summary>
        private void PopulateThirdListBoxItems( )
        {
            if( _columns?.Any( ) == true )
            {
                try
                {
                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    foreach( var _column in _columns )
                    {
                        FirstListBox.Items.Add( _column );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Populates the first ComboBox items.
        /// </summary>
        private void PopulateFirstComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( FirstComboBox.Items?.Count > 0 )
                    {
                        FirstComboBox.Items?.Clear( );
                    }

                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items?.Clear( );
                    }

                    foreach( var _item in _fields )
                    {
                        FirstComboBox.Items?.Add( _item );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Populates the second ComboBox items.
        /// </summary>
        private void PopulateSecondComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( SecondComboBox.Items?.Count > 0 )
                    {
                        SecondComboBox.Items?.Clear( );
                    }

                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    if( !string.IsNullOrEmpty( _firstValue ) )
                    {
                        for( var _i = 0; _i < _fields.Count; _i++ )
                        {
                            var _item = _fields[ _i ];
                            if( !_item.Equals( _firstCategory ) )
                            {
                                SecondComboBox.Items?.Add( _item );
                            }
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
        /// Populates the third ComboBox items.
        /// </summary>
        private void PopulateThirdComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( ThirdComboBox.Items?.Count > 0 )
                    {
                        ThirdComboBox.Items?.Clear( );
                    }

                    if( ThirdListBox.Items?.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    if( !string.IsNullOrEmpty( _firstValue )
                       && !string.IsNullOrEmpty( _secondValue ) )
                    {
                        for( var _index = 0; _index < _fields.Count; _index++ )
                        {
                            var _item = _fields[ _index ];
                            if( !_item.Equals( _firstCategory )
                               && !_item.Equals( _secondCategory ) )
                            {
                                ThirdComboBox.Items?.Add( _item );
                            }
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
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _dateTime = DateTime.Now;
                var _dateString = _dateTime.ToShortDateString( );
                var _timeString = _dateTime.ToLongTimeString( );
                StatusLabel.Text = _dateString + " - " + _timeString;
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
                switch( TabControl.SelectedIndex )
                {
                    // Data Tab
                    case 0:
                    {
                        ClearSelections( );
                        ClearCollections( );
                        ActivateDataTab( );
                        break;
                    }

                    // Query Tab
                    case 1:
                    {
                        PopulateExecutionTables( );
                        ActivateQueryTab( );
                        break;
                    }

                    // Busy Tab
                    case 2:
                    {
                        ClearSelections( );
                        ClearCollections( );
                        ActivateBusyTab( );
                        break;
                    }

                    // Default Case
                    default:
                    {
                        ClearSelections( );
                        ClearCollections( );
                        DataTab.TabVisible = true;
                        QueryTab.TabVisible = false;
                        BusyTab.TabVisible = false;
                        ExportButton.Visible = false;
                        ExcelSeparator.Visible = false;
                        LookupButton.Visible = false;
                        LookupSeparator.Visible = false;
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
        /// Activates the data tab.
        /// </summary>
        private void ActivateDataTab( )
        {
            try
            {
                DataTab.TabVisible = true;
                QueryTab.TabVisible = false;
                BusyTab.TabVisible = false;
                ExportButton.Visible = false;
                ExcelSeparator.Visible = false;
                LookupButton.Visible = true;
                LookupSeparator.Visible = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the lookup tab.
        /// </summary>
        private void ActivateQueryTab( )
        {
            try
            {
                QueryTab.TabVisible = true;
                DataTab.TabVisible = false;
                BusyTab.TabVisible = false;
                ExportButton.Visible = true;
                ExcelSeparator.Visible = true;
                LookupButton.Visible = false;
                LookupSeparator.Visible = false;
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
                QueryTab.TabVisible = false;
                DataTab.TabVisible = false;
                ExportButton.Visible = false;
                ExcelSeparator.Visible = false;
                LookupButton.Visible = false;
                LookupSeparator.Visible = false;
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
        private string CreateSqlCommand( IDictionary<string, object> where )
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
        private string CreateSqlCommand( IEnumerable<string> columns,
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
        private string CreateSqlCommand( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( fields, nameof( fields ) );
                ThrowIf.Null( numerics, nameof( numerics ) );
                ThrowIf.Null( where, nameof( where ) );
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
        /// Creates the excel report.
        /// </summary>
        private void CreateExcelReport( )
        {
            try
            {
                if( _dataTable == null )
                {
                    var _message = "    The Data Table is null!";
                    SendMessage( _message );
                }
                else if( _dataModel.Numerics == null )
                {
                    var _message = "    The data is not alpha-numeric";
                    SendMessage( _message );
                }
                else
                {
                    var _report = new ExcelReport( _dataTable );
                    _report.SaveDialog( );
                    var _message = "    The Excel File has been created!";
                    SendNotification( _message );
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
        private void GetData( )
        {
            try
            {
                _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                _dataTable = _dataModel?.DataTable;
                _selectedTable = _dataTable?.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
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
                var _sql = CreateSqlCommand( where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _selectedTable = _dataTable?.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
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
                ThrowIf.Null( where, nameof( where ) );
                ThrowIf.Null( cols, nameof( cols ) );
                var _sql = CreateSqlCommand( cols, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                _selectedTable = _dataTable?.TableName;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
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
                ThrowIf.Null( where, nameof( where ) );
                ThrowIf.Null( fields, nameof( fields ) );
                var _sql = CreateSqlCommand( fields, numerics, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                _selectedTable = _dataTable?.TableName;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeTimer( );
                InitializeToolStrip( );
                InitializeLabels( );
                InitializePictureBox( );
                InitializeRibbon( );
                FilterSeparator.Visible = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [cell enter].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
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
        /// Called when [right click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
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
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLookupButtonClicked( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 1;
                SetActiveTab( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [upload button clicked].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnBrowserButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( sender is ToolStripButton _button
                   && ( _button.ToolType == ToolType.BrowseButton ) )
                {
                    var _dialog = new FileDialog( );
                    _dialog.ShowDialog( );
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
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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
        /// Called when [exit button click].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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
        /// <param name="sender"> The sender. </param>
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
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMenuButtonClicked( object sender, EventArgs e )
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
        /// Called when [active tab changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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
        /// Called when [lookup button clicked].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnExcelButtonClicked( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
                SetActiveTab( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [dataTable ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnTableListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    ClearCollections( );
                    ToolStrip.Visible = true;
                    var _title = _listBox.SelectedValue?.ToString( );
                    _selectedTable = _title?.Replace( " ", "" );
                    _source = (Source)Enum.Parse( typeof( Source ), _selectedTable );
                    _dataModel = new DataBuilder( _source, _provider );
                    _dataTable = _dataModel.DataTable;
                    BindingSource.DataSource = _dataModel.DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    _columns = _dataModel.ColumnNames;
                    _fields = _dataModel.Fields;
                    _numerics = _dataModel.Numerics;
                    PopulateFirstComboBoxItems( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [first ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e"> </param>
        private void OnFirstComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    _firstCategory = string.Empty;
                    _firstValue = string.Empty;
                    _secondCategory = string.Empty;
                    _secondValue = string.Empty;
                    _thirdCategory = string.Empty;
                    _thirdValue = string.Empty;
                    FirstListBox.Items?.Clear( );
                    _firstCategory = _comboBox.SelectedItem?.ToString( );
                    ClearListBoxes( );
                    if( !string.IsNullOrEmpty( _firstCategory ) )
                    {
                        _dataModel = new DataBuilder( _source, _provider );
                        var _data = _dataModel.DataElements[ _firstCategory ];
                        foreach( var _item in _data )
                        {
                            FirstListBox.Items?.Add( _item );
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
        /// Called when [second ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( _filter.Keys.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    _firstValue = _listBox.SelectedValue?.ToString( );
                    _filter.Add( _firstCategory, _firstValue );
                    PopulateSecondComboBoxItems( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [second ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e"> </param>
        private void OnSecondComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    _sqlQuery = string.Empty;
                    _secondCategory = string.Empty;
                    _secondValue = string.Empty;
                    _thirdCategory = string.Empty;
                    _thirdValue = string.Empty;
                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    _secondCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _secondCategory ) )
                    {
                        var _data = _dataModel.DataElements[ _secondCategory ];
                        foreach( var _item in _data )
                        {
                            SecondListBox.Items?.Add( _item );
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
        /// Called when [third ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnSecondListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( _filter.Keys?.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    _secondValue = _listBox.SelectedValue?.ToString( );
                    _filter.Add( _firstCategory, _firstValue );
                    _filter.Add( _secondCategory, _secondValue );
                    PopulateThirdComboBoxItems( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [third ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e"> </param>
        private void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    _thirdCategory = string.Empty;
                    _thirdValue = string.Empty;
                    if( ThirdListBox.Items?.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    _thirdCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _thirdCategory ) )
                    {
                        var _data = _dataModel?.DataElements[ _thirdCategory ];
                        if( _data?.Any( ) == true )
                        {
                            foreach( var _item in _data )
                            {
                                ThirdListBox.Items?.Add( _item );
                            }
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
        /// Called when [third ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnThirdListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( _filter.Keys.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    if( ThirdListBox.Items.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    _thirdValue = _listBox.SelectedValue?.ToString( );
                    _filter.Add( _firstCategory, _firstValue );
                    _filter.Add( _secondCategory, _secondValue );
                    _filter.Add( _thirdCategory, _thirdValue );
                    TabControl.SelectedIndex = 0;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [dataTable RadioButton selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnTableRadioButtonSelected( object sender )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    ClearListBoxes( );
                    switch( _button.Tag )
                    {
                        case "EXECUTION":
                        {
                            PopulateExecutionTables( );
                            break;
                        }
                        case "REFERENCE":
                        {
                            PopulateReferenceTables( );
                            break;
                        }
                        case "MAINTENANCE":
                        {
                            PopulateMaintenanceTables( );
                            break;
                        }
                        default:
                        {
                            PopulateExecutionTables( );
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
        /// Called when [provider RadioButton selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnProviderRadioButtonSelected( object sender )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    ClearListBoxes( );
                    _provider = _button.Tag switch
                    {
                        "SQLite" => Provider.SQLite,
                        "Access" => Provider.Access,
                        "SqlServer" => Provider.SqlServer,
                        "SqlCe" => Provider.SqlCe,
                        _ => Provider.Access
                    };
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
        /// Called when [export button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnExportButtonClick( object sender, EventArgs e )
        {
            try
            {
                CreateExcelReport( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}