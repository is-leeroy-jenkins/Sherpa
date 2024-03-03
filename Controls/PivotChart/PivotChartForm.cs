// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 2-10-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-10-2024
// ******************************************************************************************
// <copyright file="PivotChartForm.cs" company="Terry D. Eppler">
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
//   PivotChartForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.PivotAnalysis.Base;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.PivotChart;
    using Syncfusion.Windows.Forms.Tools;
    using Action = System.Action;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "UseNullPropagation" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public partial class PivotChartForm : MetroForm
    {
        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <summary>
        /// The source
        /// </summary>
        private Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private Provider _provider;

        /// <summary>
        /// The chart type
        /// </summary>
        private PivotChartTypes _chartType;

        /// <summary>
        /// The selected dataTable
        /// </summary>
        private string _selectedTable;

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
        /// The SQL query
        /// </summary>
        private string _sqlQuery;

        /// <summary>
        /// The filter
        /// </summary>
        private IDictionary<string, object> _filter;

        /// <summary>
        /// The fields
        /// </summary>
        private IList<string> _fields;

        /// <summary>
        /// The columns
        /// </summary>
        private IList<string> _columns;

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
        /// The data arguments
        /// </summary>
        private DataArgs _dataArgs;

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
        /// Gets the time.
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
        /// Gets the seconds.
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
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source
        {
            get
            {
                return _source;
            }
            private set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider
        {
            get
            {
                return _provider;
            }
            private set
            {
                _provider = value;
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
        /// Gets the data arguments.
        /// </summary>
        /// <value>
        /// The data arguments.
        /// </value>
        public DataArgs DataArgs
        {
            get
            {
                return _dataArgs;
            }
            private set
            {
                _dataArgs = value;
            }
        }

        /// <summary>
        /// Gets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public PivotChartTypes ChartType
        {
            get
            {
                return _chartType;
            }
            private set
            {
                _chartType = value;
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.PivotChartForm" /> class.
        /// </summary>
        public PivotChartForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1340, 740 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

            // Wire Events
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                FirstButton.Click += OnFirstButtonClick;
                PreviousButton.Click += OnPreviousButtonClick;
                NextButton.Click += OnNextButtonClick;
                LastButton.Click += OnLastButtonClick;
                MenuButton.Click += OnMenuButtonClick;
                CloseButton.Click += OnCloseButtonClick;
                TabControl.SelectedIndexChanged += OnActiveTabChanged;
                TableListBox.SelectedIndexChanged += OnTableListBoxItemSelected;
                RefreshButton.Click += OnRefreshButtonClicked;
                ComboBox.SelectedIndexChanged += OnComboBoxItemSelected;
                SaveButton.Click += OnSaveButtonClick;
                BindingSource.CurrentChanged += OnBindingSourceChanged;
                Timer.Tick += OnTimerTick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the pivot grid.
        /// </summary>
        private void InitializePivotGrid( )
        {
            try
            {
                var _font = new Font( "Roboto", 9 );
                var _gray = Color.FromArgb( 45, 45, 45 );
                var _lightBlue = Color.FromArgb( 106, 189, 252 );
                var _borderBlue = Color.FromArgb( 0, 120, 212 );
                PivotChart.ShowPivotTableFieldList = false;
                PivotChart.AllowDrillDown = true;
                PivotChart.BackColor = Color.FromArgb( 20, 20, 20 );
                PivotChart.ForeColor = _lightBlue;
                PivotChart.ChartTypes = PivotChartTypes.Column;
                PivotChart.PrimaryXAxis.Title.Color = _borderBlue;
                PivotChart.PrimaryXAxis.Title.Font = _font;
                PivotChart.PrimaryYAxis.Title.Color = _borderBlue;
                PivotChart.PrimaryYAxis.Title.Font = _font;
                PivotChart.AxisFieldSection.Visible = true;
                PivotChart.LegendFieldSection.Visible = false;
                PivotChart.ValueFieldSection.Visible = true;
                PivotChart.FilterFieldSection.Visible = true;
                PivotChart.AxisFieldSection.ItemBackColor = Color.FromArgb( 50, 93, 129 );
                PivotChart.AxisFieldSection.ItemForeColor = Color.White;
                PivotChart.AxisFieldSection.BackInterior = _gray;
                PivotChart.CustomPalette = new[ ]
                {
                    Color.FromArgb( 0, 120, 212 ),
                    Color.SlateGray,
                    Color.Yellow,
                    Color.DarkGreen,
                    Color.Maroon,
                    Color.Olive
                };
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
        /// Initializes the timers.
        /// </summary>
        private void InitializeTimers( )
        {
            try
            {
                // Timer Properties
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
        /// Initializes the buttons.
        /// </summary>
        private void InitializeListBox( )
        {
            try
            {
                TableListBox.ShowScrollBar = false;
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
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
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
                var _font = new Font( "Roboto", 7 );
                var _foreColor = Color.FromArgb( 106, 189, 252 );
                var _labels = GetLabels( );
                foreach( var _label in _labels.Values )
                {
                    var _tag = _label.Tag.ToString( );
                    if( _tag.Equals( "STAT" ) )
                    {
                        _label.Font = _font;
                        _label.ForeColor = _foreColor;
                        _label.Text = string.Empty;
                    }
                    else if( _label.Name.Equals( "CommandLabel1" ) )
                    {
                        _label.Font = _font;
                        _label.ForeColor = _foreColor;
                        _label.TextAlign = ContentAlignment.BottomLeft;
                        _label.Text = string.Empty;
                    }
                    else if( _label.Name.Equals( "CommandLabel2" ) )
                    {
                        _label.Font = _font;
                        _label.ForeColor = _foreColor;
                        _label.TextAlign = ContentAlignment.TopLeft;
                        _label.Text = string.Empty;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the pivot chart.
        /// </summary>
        private void InitializePivotChart( )
        {
            try
            {
                var _palette = new List<Color>( );
                var _steelBlue = Color.SteelBlue;
                _palette.Add( _steelBlue );
                var _slateGray = Color.SlateGray;
                _palette.Add( _slateGray );
                var _green = Color.DarkGreen;
                _palette.Add( _green );
                var _yellow = Color.FromArgb( 192, 192, 0 );
                _palette.Add( _yellow );
                var _maroon = Color.Maroon;
                _palette.Add( _maroon );
                var _olive = Color.Olive;
                _palette.Add( _olive );
                PivotChart.ShowPivotTableFieldList = false;
                PivotChart.AllowDrillDown = true;
                PivotChart.BackColor = Color.FromArgb( 45, 45, 45 );
                PivotChart.ForeColor = Color.FromArgb( 106, 189, 252 );
                PivotChart.ChartTypes = PivotChartTypes.Column;
                PivotChart.PrimaryXAxis.Title.Color = Color.FromArgb( 0, 120, 212 );
                PivotChart.PrimaryXAxis.Title.Font = new Font( "Roboto", 9 );
                PivotChart.PrimaryYAxis.Title.Color = Color.FromArgb( 0, 120, 212 );
                PivotChart.PrimaryYAxis.Title.Font = new Font( "Roboto", 9 );
                PivotChart.LegendFieldSection.Visible = false;
                PivotChart.ValueFieldSection.Visible = true;
                PivotChart.FilterFieldSection.Visible = true;
                PivotChart.AxisFieldSection.ItemBackColor = Color.FromArgb( 50, 93, 129 );
                PivotChart.AxisFieldSection.ItemForeColor = Color.White;
                PivotChart.AxisFieldSection.BackInterior = Color.FromArgb( 75, 75, 75 );
                PivotChart.CustomPalette = _palette.ToArray( );
                PivotChart.Style3D = true;
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
                _busy = true;
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
                _busy = false;
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
                _dataModel = new DataBuilder( _source, _provider );
                _dataTable = _dataModel.DataTable;
                _columns = _dataModel?.ColumnNames;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                _selectedTable = _dataTable.TableName;
                BindingSource.DataSource = _dataModel.DataTable;
                ToolStrip.BindingSource = BindingSource;
                Title.Text = _dataTable.TableName.SplitPascal( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the chart.
        /// </summary>
        private void BindChart( )
        {
            try
            {
                PivotChart.ShowPivotTableFieldList = true;
                var _dataRows = DataTable?.AsEnumerable( )
                    ?.Take( 1000 );

                PivotChart.ItemSource = _dataRows?.CopyToDataTable( );
                var _row = BindingSource.GetCurrentDataRow( );
                UpdateSchema( _row );
                SetSeriesPointStyles( _row );
                var _cols = _fields.Take( 10 )
                    ?.ToArray( );

                var _numbers = _numerics.Take( 3 )
                    ?.ToArray( );

                foreach( var _name in _cols )
                {
                    if( !_name.Contains( "Name" ) )
                    {
                        var _item = new PivotItem
                        {
                            FieldMappingName = _name,
                            TotalHeader = "Total"
                        };

                        PivotChart.PivotAxis.Add( _item );
                    }
                }

                foreach( var _value in _numbers )
                {
                    var _info = new PivotComputationInfo
                    {
                        FieldName = _value,
                        Format = "#,##0",
                        SummaryType = SummaryType.DoubleTotalSum
                    };

                    PivotChart.PivotCalculations.Add( _info );
                }

                PivotChart.EnableXZooming = true;
                PivotChart.PrimaryXAxis.ZoomFactor = .7;
                PivotChart.PrimaryXAxis.Title.Text = "Fields";
                PivotChart.PrimaryYAxis.ShowAxisLabelTooltip = true;
                PivotChart.PrimaryYAxis.Title.Text = "Values";
                PivotChart.AllowDrillDown = true;
                PivotChart.Refresh( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns>
        /// </returns>
        private IEnumerable<Control> GetControls( )
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
        /// Gets the labels.
        /// </summary>
        /// <returns>
        /// Dictionary
        /// </returns>
        private IDictionary<string, Label> GetLabels( )
        {
            try
            {
                var _labels = new Dictionary<string, Label>( );
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
                    Timer.Interval = 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
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
        /// Fades the in.
        /// </summary>
        private protected virtual void FadeIn( )
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
        /// Fades the out and close.
        /// </summary>
        private protected virtual void FadeOut( )
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
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
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
        /// Clears the data.
        /// </summary>
        public void ClearData( )
        {
            try
            {
                ClearSelections( );
                ClearCollections( );
                ClearFilter( );
                _dataModel = null;
                _dataTable = null;
                _selectedTable = string.Empty;
                BindingSource.DataSource = null;
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
        /// Clears the label text.
        /// </summary>
        private void ClearLabels( )
        {
            try
            {
                var _labels = GetLabels( );
                foreach( var _lbl in _labels.Values )
                {
                    if( _lbl.Tag != null )
                    {
                        var _tag = _lbl.Tag.ToString( );
                        if( _tag.Equals( nameof( STAT ) ) )
                        {
                            _lbl.Text = string.Empty;
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
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _now = DateTime.Now;
                StatusLabel.Text = $"{_now.ToShortDateString( )} - {_now.ToLongTimeString( )}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the schema labels.
        /// </summary>
        /// <param name="row">
        /// The row.
        /// </param>
        private void UpdateSchema( DataRow row )
        {
            try
            {
                ThrowIf.Null( row, nameof( row ) );
                ClearLabels( );
                var _data = row.ToDictionary( );
                var _labels = GetLabels( )
                    ?.Where( l => l.Value?.Tag != null )
                    ?.Select( l => l.Value )
                    ?.ToArray( );

                var _colNames = _data.Keys
                    ?.Take( _labels.Length )
                    ?.ToArray( );

                var _colValues = _data.Values
                    ?.Take( _labels.Length )
                    ?.ToArray( );

                for( var _i = 0; _i < _labels.Length; _i++ )
                {
                    var _lbl = _labels[ _i ].Tag?.ToString( );
                    if( _lbl == nameof( STAT ) )
                    {
                        _labels[ _i ].Text = $"{_colNames[ _i ]} = {_colValues[ _i ]}";
                    }
                }
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
        /// Populates the ComboBox.
        /// </summary>
        private void PopulateComboBox( )
        {
            try
            {
                var _charts = Enum.GetNames( typeof( PivotChartTypes ) );
                if( ComboBox.Items.Count > 0 )
                {
                    ComboBox.Items.Clear( );
                }

                foreach( var _item in _charts )
                {
                    ComboBox.Items.Add( _item );
                }
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
        /// Sends the message.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SendMessage( string text )
        {
            try
            {
                ThrowIf.Null( text, nameof( text ) );
                var _message = new SplashMessage( text );
                _message.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the active data tab.
        /// </summary>
        private void SetActiveDataTab( )
        {
            try
            {
                switch( TabControl.SelectedIndex )
                {
                    case 0:
                    {
                        DataTab.TabVisible = true;
                        BusyTab.TabVisible = false;
                        break;
                    }
                    case 1:
                    {
                        BusyTab.TabVisible = true;
                        DataTab.TabVisible = false;
                        break;
                    }
                    default:
                    {
                        DataTab.TabVisible = true;
                        BusyTab.TabVisible = false;
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
        /// Sets the type of the chart.
        /// </summary>
        /// <param name="type">The type.</param>
        public void SetChartType( string type )
        {
            try
            {
                ThrowIf.Null( type, nameof( type ) );
                if( Enum.IsDefined( typeof( PivotChartTypes ), type ) )
                {
                    _chartType = (PivotChartTypes)Enum.Parse( typeof( PivotChartTypes ), type );
                    PivotChart.ChartTypes = _chartType;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the series point styles.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="type">The type.</param>
        private void SetSeriesPointStyles( DataRow row,
            ChartSeriesType type = ChartSeriesType.Column )
        {
            try
            {
                ThrowIf.Null( row, nameof( row ) );
                PivotChart.ChartControl.Series?.Clear( );
                var _borderColor = Color.FromArgb( 0, 120, 212 );
                var _backColor = Color.Black;
                var _textColor = Color.FromArgb( 106, 189, 252 );
                var _callFont = new Font( "Roboto", 7 );
                var _nums = _numerics.ToArray( );
                for( var _i = 0; _i < _nums.Length; _i++ )
                {
                    var _doubles = new List<double>( );
                    var _series = new ChartSeries( );
                    var _columnName = _nums[ _i ];
                    var _index = double.Parse( _i.ToString( ) );
                    var _value = double.Parse( row[ _columnName ].ToString( ) );
                    _series.Name = _columnName;
                    _series.Text = _series.Name;
                    if( _value > 1000d )
                    {
                        _doubles.Add( _value );
                        var _cp = new ChartPoint( _index, _value );
                        _series.Points.Add( _cp );
                    }

                    _series.Visible = true;
                    _series.EnableStyles = true;
                    _series.Type = type;
                    _series.DrawSeriesNameInDepth = false;
                    _series.Style.DisplayText = true;
                    _series.Style.TextColor = _textColor;
                    _series.Style.Font.Size = 8;
                    _series.Style.Font.Facename = _callFont.Name;
                    _series.Style.Symbol.Shape = ChartSymbolShape.Circle;
                    _series.Style.TextOffset = 20f;
                    _series.FancyToolTip.Style =
                        MarkerStyle.SmoothRectangle;

                    _series.FancyToolTip.Angle = 45;
                    _series.FancyToolTip.Spacing = 10f;
                    _series.FancyToolTip.Border.ForeColor = _borderColor;
                    _series.FancyToolTip.Border.BackColor = Color.Transparent;
                    _series.FancyToolTip.ForeColor = Color.White;
                    _series.FancyToolTip.BackColor = _backColor;
                    _series.FancyToolTip.Symbol = ChartSymbolShape.Arrow;
                    _series.FancyToolTip.Visible = true;
                    _series.PointsToolTipFormat = "{0} - {4}";
                    PivotChart.ChartControl.Series.Add( _series );
                }

                PivotChart.ChartControl.Refresh( );
                PivotChart.Refresh( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                RegisterCallbacks( );
                InitializeLabels( );
                InitializeToolStrip( );
                InitializeTimers( );
                InitializeListBox( );
                InitializePivotChart( );
                PopulateExecutionTables( );
                PopulateComboBox( );
                ClearLabels( );
                Title.Text = string.Empty;
                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [binding source changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBindingSourceChanged( object sender, EventArgs e )
        {
            try
            {
                _current = BindingSource.GetCurrentDataRow( );
                UpdateSchema( _current );
                PivotChart.Refresh( );
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
        private void OnMenuButtonClick( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
                OpenMainForm( );
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnComboBoxItemSelected( object sender, EventArgs e )
        {
            try
            {
                var _item = ComboBox.GetSelectedItem( );
                if( _item != null )
                {
                    var _name = _item.ToString( );
                    if( _name != null )
                    {
                        SetChartType( _name );
                        var _message = "The chart type has been change!";
                        SendNotification( _message );
                    }
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnListBoxItemSelected( object sender, EventArgs e )
        {
            try
            {
                var _item = TableListBox.SelectedItem.ToString( );
                _selectedTable = _item?.Replace( " ", "" );
                if( _selectedTable != null )
                {
                    _source = (Source)Enum.Parse( typeof( Source ), _selectedTable );
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
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
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
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            InvokeIf( _statusUpdate );
        }

        /// <summary> Called when [click]. </summary>
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
                ClearSelections( );
                ClearCollections( );
                FadeOut( );
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnTableListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    var _title = _listBox.SelectedValue?.ToString( );
                    _selectedTable = _title?.Replace( " ", "" );
                    if( _selectedTable != null )
                    {
                        _source = (Source)Enum.Parse( typeof( Source ), _selectedTable );
                        GetData( );
                        BindChart( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [first button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnFirstButtonClick( object sender, EventArgs e )
        {
            try
            {
                BindingSource?.MoveFirst( );
                _current = BindingSource.GetCurrentDataRow( );
                UpdateSchema( _current );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [previous button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnPreviousButtonClick( object sender, EventArgs e )
        {
            try
            {
                BindingSource?.MovePrevious( );
                _current = BindingSource.GetCurrentDataRow( );
                UpdateSchema( _current );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [next button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnNextButtonClick( object sender, EventArgs e )
        {
            try
            {
                BindingSource?.MoveNext( );
                _current = BindingSource.GetCurrentDataRow( );
                UpdateSchema( _current );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [last button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLastButtonClick( object sender, EventArgs e )
        {
            try
            {
                BindingSource?.MoveLast( );
                _current = BindingSource.GetCurrentDataRow( );
                UpdateSchema( _current );
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
                SetActiveDataTab( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [refresh data button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRefreshButtonClicked( object sender, EventArgs e )
        {
            try
            {
                ClearData( );
                TabControl.SelectedIndex = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [save button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSaveButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _message = "The Save Button is not yet implemented!";
                SendMessage( _message );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [browse button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBrowseButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _message = "The Save Button is not yet implemented!";
                SendMessage( _message );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}