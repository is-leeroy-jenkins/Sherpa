// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 12-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-10-2023
// ******************************************************************************************
// <copyright file="ChartDataForm.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
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
//   ChartDataForm.cs
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
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.WinForms.Core;
    using Syncfusion.WinForms.Core.Enums;
    using BrushInfo = Syncfusion.Drawing.BrushInfo;
    using MarkerStyle = Syncfusion.Windows.Forms.Chart.MarkerStyle;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    public partial class ChartDataForm : MetroForm
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
        /// The selected table
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
        /// The SQL command
        /// </summary>
        private string _sqlQuery;

        /// <summary>
        /// The xaxis
        /// </summary>
        private string _xaxis;

        /// <summary>
        /// The yvalues
        /// </summary>
        private IList<string> _yvalues;

        /// <summary>
        /// The chart type
        /// </summary>
        private ChartSeriesType _chartType;

        /// <summary>
        /// The stat
        /// </summary>
        private STAT _metric;

        /// <summary>
        /// The data model
        /// </summary>
        private DataBuilder _dataModel;

        /// <summary>
        /// The data table
        /// </summary>
        private DataTable _dataTable;

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
        /// Gets or sets the count.
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
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText
        {
            get
            {
                return _hoverText;
            }
            private set
            {
                _hoverText = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected row.
        /// </summary>
        /// <value>
        /// The selected row.
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
        /// Gets or sets the first category.
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
        /// Gets or sets the first value.
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
        /// Gets or sets the second category.
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
        /// Gets or sets the second value.
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
        /// Gets or sets the third category.
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
        /// Gets or sets the third value.
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
        /// Gets or sets the fourth category.
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
        /// Gets or sets the fourth value.
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
        /// Gets or sets the SQL query.
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
        /// Gets or sets the xaxis.
        /// </summary>
        /// <value>
        /// The xaxis.
        /// </value>
        public string xAxis
        {
            get
            {
                return _xaxis;
            }
            private set
            {
                _xaxis = value;
            }
        }

        /// <summary>
        /// Gets or sets the y values.
        /// </summary>
        /// <value>
        /// The y values.
        /// </value>
        public IList<string> yValues
        {
            get
            {
                return _yvalues;
            }
            private set
            {
                _yvalues = value;
            }
        }

        /// <summary>
        /// Gets or sets the data model.
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
        /// Gets or sets the data row.
        /// </summary>
        /// <value>
        /// The data row.
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
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
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
        /// Gets the Metric.
        /// </summary>
        /// <value>
        ///  STAT
        /// </value>
        public STAT Metric
        {
            get
            {
                return _metric;
            }
            private set
            {
                _metric = value;
            }
        }

        /// <summary>
        /// Gets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public ChartSeriesType ChartType
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
        /// Gets or sets the fields.
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
        /// Gets or sets the numerics.
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
        /// Gets or sets the selected columns.
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
        /// Gets or sets the selected fields.
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
        /// Gets or sets the selected numerics.
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
        /// Gets or sets the source.
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
        /// Gets or sets the provider.
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
        /// Gets or sets the data arguments.
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
        /// Gets a value indicating
        /// whether this instance is busy.
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
        /// <see cref="T:BudgetExecution.ChartDataForm" /> class.
        /// </summary>
        public ChartDataForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
            Size = new Size( 1345, 745 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1340, 740 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
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

            // Initialize Default Provider
            _provider = Provider.Access;
            _metric = STAT.Total;
            _chartType = ChartSeriesType.Column;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Event Wiring
            Load += OnLoad;
            Closing += OnClosing;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ChartDataForm" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ChartDataForm( Source source, Provider provider )
            : this( )
        {
            _source = source;
            _provider = provider;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ChartDataForm" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        public ChartDataForm( Source source, Provider provider, IDictionary<string, object> where )
            : this( )
        {
            _source = source;
            _provider = provider;
            _filter = where;
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
                MenuButton.Click += OnMainMenuButtonClicked;
                ExitButton.Click += OnExitButtonClicked;
                Timer.Tick += OnTimerTick;
                QueryTabControl.SelectedIndexChanged += OnQueryTabChanged;
                DataTabControl.SelectedIndexChanged += OnActiveTabChanged;
                TableListBox.SelectedIndexChanged += OnTableListBoxItemSelected;
                FirstComboBox.SelectedIndexChanged += OnFirstComboBoxItemSelected;
                FirstListBox.SelectedIndexChanged += OnFirstListBoxItemSelected;
                SecondComboBox.SelectedIndexChanged += OnSecondComboBoxItemSelected;
                SecondListBox.SelectedIndexChanged += OnSecondListBoxItemSelected;
                ThirdComboBox.SelectedIndexChanged += OnThirdComboBoxItemSelected;
                ThirdListBox.SelectedIndexChanged += OnThirdListBoxItemSelected;
                GroupButton.Click += OnGroupButtonClicked;
                FieldListBox.SelectedIndexChanged += OnFieldListBoxSelectedValueChanged;
                NumericListBox.SelectedIndexChanged += OnNumericListBoxSelectedValueChanged;
                ToolStripComboBox.SelectedIndexChanged += OnChartSelected;
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
                var _backColor = Color.Transparent;
                var _labels = GetLabels( );
                foreach( var lbl in _labels.Values )
                {
                    lbl.Font = _font;
                    lbl.ForeColor = _foreColor;
                    lbl.BackColor = _backColor;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the icon.
        /// </summary>
        private void InitializeIcon( )
        {
            try
            {
                PictureBox.Size = new Size( 24, 20 );
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            _statusUpdate += UpdateStatus;
        }

        /// <summary>
        /// Sets the series.
        /// </summary>
        private void InitializeSeries( ChartSeriesType type = ChartSeriesType.Column )
        {
            try
            {
                var _borderColor = Color.FromArgb( 0, 120, 212 );
                var _backColor = Color.FromArgb( 90, 90, 90 );
                var _textColor = Color.FromArgb( 106, 189, 252 );
                var _callFont = new Font( "Roboto", 7 );
                for( var i = 0; i < Chart.Series.Count; i++ )
                {
                    Chart.Series[ i ].Visible = true;
                    Chart.Series[ i ].EnableStyles = true;
                    Chart.Series[ i ].EnableAreaToolTip = false;
                    Chart.Series[ i ].Type = type;
                    Chart.Series[ i ].SmartLabels = true;
                    Chart.Series[ i ].SmartLabelsBorderColor = _borderColor;
                    Chart.Series[ i ].DrawSeriesNameInDepth = true;
                }

                SetFancyToolTips( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Initializes the chart.
        /// </summary>
        private void InitializeChart( )
        {
            try
            {
                var _blueText = Color.FromArgb( 106, 189, 252 );
                var _darkBackground = Color.FromArgb( 20, 20, 20 );
                var _black = Color.Black;
                var _white = Color.White;
                var _transparent = Color.Transparent;
                var _tipGradient = new[ ] { _blueText, _black };
                var _chartGradient = new[ ] { _blueText, _darkBackground };
                var _direction = Syncfusion.Drawing.GradientStyle.ForwardDiagonal;
                Chart.ShowToolbar = false;
                Chart.ShowScrollBars = false;
                Chart.EnableMouseRotation = true;
                Chart.Padding = new Padding( 1 );
                Chart.Margin = new Padding( 1 );
                Chart.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                Chart.AllowGapForEmptyPoints = false;
                Chart.AllowGradientPalette = true;
                Chart.AllowUserEditStyles = true;
                Chart.PrintColorMode = ChartPrintColorMode.CheckPrinter;
                Chart.CalcRegions = true;
                Chart.ChartAreaMargins = new ChartMargins( 0, 0, 0, 0 );
                Chart.DropSeriesPoints = false;
                Chart.AddRandomSeries = true;
                Chart.ChartAreaShadow = false;
                Chart.Series3D = true;
                Chart.SeriesHighlight = true;
                Chart.RealMode3D = true;
                Chart.AutoHighlight = true;
                Chart.Style3D = true;
                Chart.ShowLegend = false;
                Chart.ShowToolTips = false;
                Chart.DisplayChartContextMenu = false;
                Chart.DisplaySeriesContextMenu = false;
                Chart.SeriesHighlightIndex = -1;
                Chart.Depth = 250;
                Chart.ElementsSpacing = 10;
                Chart.Spacing = 5;
                Chart.SpacingBetweenPoints = 5;
                Chart.SpacingBetweenSeries = 10;
                Chart.ColumnFixedWidth = 20;
                Chart.ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;
                Chart.ColumnWidthMode = ChartColumnWidthMode.DefaultWidthMode;
                Chart.Palette = ChartColorPalette.Office2016;
                Chart.Skins = Skins.Office2016Black;
                Chart.Rotation = 10;
                Chart.SmoothingMode = SmoothingMode.AntiAlias;
                Chart.TextAlignment = StringAlignment.Center;
                Chart.TextPosition = ChartTextPosition.Top;
                Chart.Tilt = 3;
                Chart.RadarStyle = ChartRadarAxisStyle.Polygon;
                Chart.BackColor = _darkBackground;
                Chart.ForeColor = _blueText;
                Chart.PrimaryXAxis.Font = new Font( "Roboto", 8 );
                Chart.PrimaryXAxis.ForeColor = _white;
                Chart.PrimaryXAxis.AxisLabelPlacement = ChartPlacement.Outside;
                Chart.PrimaryXAxis.ValueType = ChartValueType.Category;
                Chart.PrimaryXAxis.TitleFont = new Font( "Roboto", 8 );
                Chart.PrimaryXAxis.TitleColor = _blueText;
                Chart.PrimaryXAxis.Title = "Records";
                Chart.PrimaryYAxis.Font = new Font( "Roboto", 8 );
                Chart.PrimaryYAxis.ForeColor = _white;
                Chart.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Outside;
                Chart.PrimaryYAxis.ValueType = ChartValueType.Double;
                Chart.PrimaryYAxis.TitleFont = new Font( "Roboto", 9 );
                Chart.PrimaryYAxis.TitleColor = _blueText;
                Chart.PrimaryYAxis.Format = "#,##0";
                Chart.Tooltip.Font = new Font( "Roboto", 8 );
                Chart.Tooltip.ForeColor = _blueText;
                Chart.Tooltip.BorderStyle = BorderStyle.FixedSingle;
                Chart.ToolBar.Border.ForeColor = _black;
                Chart.ToolBar.Orientation = ChartOrientation.Horizontal;
                Chart.ToolBar.ButtonBackColor = _darkBackground;
                Chart.ToolBar.Position = ChartDock.Bottom;
                Chart.ToolBar.ShowGrip = false;
                Chart.ToolBar.ShowBorder = false;
                Chart.ToolBar.BackColor = _darkBackground;
                Chart.Title.Font = new Font( "Roboto", 10 );
                Chart.Title.ForeColor = _blueText;
                Chart.Title.BackColor = _transparent;
                Chart.Legend.BackColor = _transparent;
                Chart.Legend.ForeColor = _blueText;
                Chart.Legend.Font = new Font( "Roboto", 7 );
                Chart.Legend.ShowBorder = false;
                Chart.Legend.ColumnsCount = 1;
                Chart.Legend.Position = ChartDock.Right;
                Chart.Legend.VisibleCheckBox = true;
                Chart.Legend.Visible = false;
                Chart.ChartArea.RealSeries3D = true;
                Chart.ChartArea.Series3D = true;
                Chart.ChartArea.AutoScale = true;
                Chart.Tooltip.BackgroundColor = new BrushInfo( _direction, _tipGradient );
                Chart.ChartArea.BackInterior = new BrushInfo( _direction, _chartGradient );
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
        /// Invokes if.
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
                    var _timer = new Timer( );
                    _timer.Interval = 1000;
                    _timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
                        {
                            _timer.Stop( );
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
        /// Populates the first ComboBox items.
        /// </summary>
        public void PopulateFirstComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( FirstComboBox.Items?.Count > 0 )
                    {
                        FirstComboBox.Items.Clear( );
                    }

                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items?.Clear( );
                    }

                    foreach( var item in _fields )
                    {
                        FirstComboBox.Items?.Add( item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the second ComboBox items.
        /// </summary>
        public void PopulateSecondComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( SecondComboBox.Items?.Count > 0 )
                    {
                        SecondComboBox.Items.Clear( );
                    }

                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    if( !string.IsNullOrEmpty( _firstValue ) )
                    {
                        foreach( var item in _fields )
                        {
                            if( !item.Equals( _firstCategory ) )
                            {
                                SecondComboBox.Items?.Add( item );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the third ComboBox items.
        /// </summary>
        public void PopulateThirdComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( ThirdComboBox.Items?.Count > 0 )
                    {
                        ThirdComboBox.Items.Clear( );
                    }

                    if( ThirdListBox.Items?.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    if( !string.IsNullOrEmpty( _firstValue )
                       && !string.IsNullOrEmpty( _secondValue ) )
                    {
                        foreach( var item in _fields )
                        {
                            if( !item.Equals( _firstCategory )
                               && !item.Equals( _secondCategory ) )
                            {
                                ThirdComboBox.Items?.Add( item );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the tool strip ComboBox items.
        /// </summary>
        public void PopulateToolStripComboBoxItems( )
        {
            try
            {
                if( ToolStripComboBox.Items?.Count > 0 )
                {
                    ToolStripComboBox.Items.Clear( );
                }

                if( ToolStripComboBox.Items?.Count > 0 )
                {
                    ToolStripComboBox.Items?.Clear( );
                }

                var _types = Enum.GetNames( typeof( ChartSeriesType ) );
                var _list = new List<string>( );
                _list.Add( ChartSeriesType.Histogram.ToString( ) );
                _list.Add( ChartSeriesType.Custom.ToString( ) );
                _list.Add( ChartSeriesType.ThreeLineBreak.ToString( ) );
                foreach( var _typ in _types )
                {
                    if( !_list.Contains( _typ ) )
                    {
                        ToolStripComboBox.Items.Add( _typ );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                    foreach( var name in _names )
                    {
                        TableListBox.Items?.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the field ListBox.
        /// </summary>
        private void PopulateFieldListBox( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items.Clear( );
                    }

                    foreach( var _item in _fields )
                    {
                        FieldListBox.Items.Add( _item );
                    }

                    FieldListBox.MultiSelect = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the numeric ListBox.
        /// </summary>
        private void PopulateNumericListBox( )
        {
            if( _numerics?.Any( ) == true )
            {
                try
                {
                    if( NumericListBox.Items.Count > 0 )
                    {
                        NumericListBox.Items.Clear( );
                    }

                    for( var i = 0; i < _numerics.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( _numerics[ i ] ) )
                        {
                            NumericListBox.Items.Add( _numerics[ i ] );
                        }
                    }

                    NumericListBox.MultiSelect = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Activates the SQL tab.
        /// </summary>
        private void ActivateSourceTab( )
        {
            try
            {
                ClearListBoxes( );
                ClearComboBoxes( );
                QueryTabControl.SelectedIndex = 0;
                SourceTabPage.TabVisible = true;
                ReadyTabPage.TabVisible = true;
                FilterTabPage.TabVisible = false;
                GroupTabPage.TabVisible = false;
                BusyTabPage.TabVisible = false;
                ToolStripComboBox.Visible = false;
                ChartLabel.Visible = false;
                PopulateExecutionTables( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the lookup tab.
        /// </summary>
        private void ActivateFilterTab( )
        {
            try
            {
                ClearFilter( );
                ClearListBoxes( );
                ClearComboBoxes( );
                QueryTabControl.SelectedIndex = 1;
                FilterTabPage.TabVisible = true;
                ReadyTabPage.TabVisible = true;
                SourceTabPage.TabVisible = false;
                GroupTabPage.TabVisible = false;
                BusyTabPage.TabVisible = false;
                ToolStripComboBox.Visible = true;
                ChartLabel.Visible = true;
                _filter?.Clear( );
                PopulateFirstComboBoxItems( );
                ResetFilterTableVisibility( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Activates the schema tab.
        /// </summary>
        private void ActivateGroupTab( )
        {
            try
            {
                ClearCollections( );
                ClearListBoxes( );
                ClearComboBoxes( );
                QueryTabControl.SelectedIndex = 2;
                SourceTabPage.TabVisible = true;
                ReadyTabPage.TabVisible = true;
                FilterTabPage.TabVisible = false;
                GroupTabPage.TabVisible = false;
                BusyTabPage.TabVisible = false;
                ToolStripComboBox.Visible = true;
                ChartLabel.Visible = true;
                PopulateFieldListBox( );
                ResetGroupTableVisibility( );
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
                QueryTabControl.SelectedIndex = 4;
                BusyTabPage.TabVisible = true;
                ReadyTabPage.TabVisible = false;
                SourceTabPage.TabVisible = false;
                FilterTabPage.TabVisible = false;
                GroupTabPage.TabVisible = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        private void BindData( )
        {
            try
            {
                if( string.IsNullOrEmpty( _sqlQuery ) )
                {
                    BeginInit( );
                    _dataModel = new DataBuilder( _source, _provider );
                    _dataTable = _dataModel.DataTable;
                    _selectedTable = _dataTable.TableName;
                    _columns = _dataModel?.ColumnNames;
                    _fields = _dataModel?.Fields;
                    _numerics = _dataModel?.Numerics;
                    BindingSource.DataSource = _dataModel.DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    EndInit( );
                }
                else
                {
                    BeginInit( );
                    _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                    _dataTable = _dataModel.DataTable;
                    _selectedTable = _dataTable.TableName;
                    _columns = _dataModel?.ColumnNames;
                    _fields = _dataModel?.Fields;
                    _numerics = _dataModel?.Numerics;
                    BindingSource.DataSource = _dataModel.DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    EndInit( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="sqlText">
        /// The SQL text.
        /// </param>
        private void BindData( string sqlText )
        {
            try
            {
                ThrowIf.NullOrEmpty( sqlText, nameof( sqlText ) );
                BeginInit( );
                _dataModel = new DataBuilder( _source, _provider, sqlText );
                _dataTable = _dataModel.DataTable;
                _columns = _dataModel?.ColumnNames;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataModel.DataTable;
                ToolStrip.BindingSource = BindingSource;
                EndInit( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="where">
        /// The where.
        /// </param>
        private void BindData( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                _filter = where;
                _sqlQuery = CreateSqlCommand( where );
                _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                _dataTable = _dataModel.DataTable;
                _selectedTable = _dataTable.TableName;
                _columns = _dataModel?.ColumnNames;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource.DataSource = _dataModel.DataTable;
                EndInit( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="cols">The cols.</param>
        /// <param name="where">The where.</param>
        private void BindData( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( cols, nameof( cols ) );
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                _sqlQuery = CreateSqlCommand( cols, where );
                _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                _dataTable = _dataModel.DataTable;
                _columns = _dataModel?.ColumnNames;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
                EndInit( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
            try
            {
                ThrowIf.Null( fields, nameof( fields ) );
                ThrowIf.Null( numerics, nameof( numerics ) );
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                _sqlQuery = CreateSqlCommand( fields, numerics, where );
                _dataModel = new DataBuilder( _source, _provider, _sqlQuery );
                _dataTable = _dataModel.DataTable;
                _columns = _dataModel?.ColumnNames;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
                EndInit( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Binds the chart.
        /// </summary>
        private void BindChart( )
        {
            try
            {
                var _current = BindingSource.GetCurrentDataRow( );
                SetSeriesPointStyles( _current, _chartType );
                UpdateSchema( _current );
                Chart.Title.Text = _dataTable.TableName.SplitPascal( );
                Chart.PrimaryXAxis.Title = GetAxisTitle( );
                Chart.Refresh( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        /// Creates the SQL text.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns>
        /// </returns>
        private string CreateSqlCommand( IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( _selectedTable ) )
            {
                try
                {
                    ThrowIf.Null( where, nameof( where ) );
                    return $"SELECT * FROM {_selectedTable} "
                        + $"WHERE {where.ToCriteria( )};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
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
        /// <returns>
        /// </returns>
        private string CreateSqlCommand( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( _selectedTable ) )
            {
                try
                {
                    ThrowIf.Null( where, nameof( where ) );
                    ThrowIf.NullOrEmpty( fields, nameof( fields ) );
                    ThrowIf.NullOrEmpty( numerics, nameof( numerics ) );
                    var _cols = string.Empty;
                    var _aggr = string.Empty;
                    foreach( var name in fields )
                    {
                        _cols += $"{name}, ";
                    }

                    foreach( var metric in numerics )
                    {
                        _aggr += $"SUM({metric}) AS {metric}, ";
                    }

                    var _groups = _cols.TrimEnd( ", ".ToCharArray( ) );
                    var _criteria = where.ToCriteria( );
                    var _values = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_values} FROM {_selectedTable} "
                        + $"WHERE {_criteria} "
                        + $"GROUP BY {_groups};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
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
        /// <returns>
        /// </returns>
        private string CreateSqlCommand( IEnumerable<string> columns,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( _selectedTable ) )
            {
                try
                {
                    ThrowIf.Null( where, nameof( where ) );
                    ThrowIf.NullOrEmpty( columns, nameof( columns ) );
                    var _cols = string.Empty;
                    foreach( var name in columns )
                    {
                        _cols += $"{name}, ";
                    }

                    var _criteria = where.ToCriteria( );
                    var _names = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_names} FROM {SelectedTable} "
                        + $"WHERE {_criteria} "
                        + $"GROUP BY {_names};";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Clears the combo boxes.
        /// </summary>
        private void ClearComboBoxes( )
        {
            try
            {
                FirstComboBox.Items.Clear( );
                SecondComboBox.Items.Clear( );
                ThirdComboBox.Items.Clear( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Clears the list boxes.
        /// </summary>
        private void ClearListBoxes( )
        {
            try
            {
                FirstListBox.Items.Clear( );
                SecondListBox.Items.Clear( );
                ThirdListBox.Items.Clear( );
                FieldListBox.Items.Clear( );
                NumericListBox.Items.Clear( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                _selectedTable = string.Empty;
                _dataModel = null;
                _dataTable = null;
                BindingSource.DataSource = null;
                ToolStrip.BindingSource.DataSource = null;
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
                _selectedTable = string.Empty;
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
                    var _tag = _lbl.Tag.ToString( );
                    if( _tag?.Equals( nameof( Field ) ) == true )
                    {
                        _lbl.Text = string.Empty;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        /// Updates the label text.
        /// </summary>
        private void UpdateMetrics( )
        {
            try
            {
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    ClearLabels( );
                    var _table = _selectedTable?.SplitPascal( ) ?? string.Empty;
                    var _rows = _dataTable.Rows?.Count.ToString( "#,###" ) ?? "0";
                    var _cols = _dataTable.Columns?.Count;
                    var _criteria = _filter.Keys?.Count;
                    var _names = _dataModel.Fields?.Count ?? 0;
                    var _numbers = _dataModel.Numerics?.Count ?? 0;
                    var _selectedCols = SelectedFields?.Count ?? 0;
                    var _selectedNums = SelectedNumerics?.Count ?? 0;
                    Label1.Text = $"Data Records:  {_rows}";
                    Label2.Text = $"Data Columns:  {_cols}";
                    Label3.Text = $"Total Fields:  {_names}";
                    Label4.Text = $"Total Measures:  {_numbers}";
                    Label5.Text = $"Active Filters:  {_criteria}";
                    Label6.Text = $"Selected Fields:  {_selectedCols} of {_names}";
                    Label7.Text = $"Selected Measures:  {_selectedNums} of {_numbers}";
                }
                else
                {
                    var _labels = GetLabels( );
                    foreach( var lbl in _labels.Values )
                    {
                        var _tag = lbl.Tag.ToString( );
                        if( _tag?.Equals( nameof( Field ) ) == true )
                        {
                            lbl.Text = string.Empty;
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                    ?.Where( l => l.Value.Tag.ToString( ) == nameof( Field ) )
                    ?.Select( l => l.Value )
                    ?.ToArray( );

                var _colNames = _data.Keys
                    ?.Where( n => n.Contains( "Name" ) != true )
                    ?.Take( _labels.Length )
                    ?.ToArray( );

                var _colValues = _data.Values
                    ?.Take( _labels.Length )
                    ?.ToArray( );

                var _names = _colNames.ToArray( );
                for( var i = 0; i < _names.Length; i++ )
                {
                    var _name = _names[ i ];
                    var _n = _name.SplitPascal( )
                        ?.Replace( "Code", "" );

                    _labels[ i ].Text = $"{_n} = {row[ _name ]}";
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        /// Resets the filter row visibility.
        /// </summary>
        private void ResetFilterTableVisibility( )
        {
            try
            {
                if( FirstTable?.Visible == false )
                {
                    FirstTable.Visible = true;
                }

                if( SecondTable?.Visible == true )
                {
                    SecondTable.Visible = false;
                }

                if( ThirdTable?.Visible == true )
                {
                    ThirdTable.Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Resets the group row visibility.
        /// </summary>
        private void ResetGroupTableVisibility( )
        {
            try
            {
                if( FieldTable?.Visible == false )
                {
                    FieldTable.Visible = true;
                }

                if( NumericTable?.Visible == true )
                {
                    NumericTable.Visible = false;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the type of the chart.
        /// </summary>
        /// <param name="type">The type.</param>
        private void SetChartType( string type )
        {
            if( !string.IsNullOrEmpty( type ) )
            {
                try
                {
                    var _types = Enum.GetNames( typeof( ChartSeriesType ) );
                    if( _types?.Contains( type ) == true )
                    {
                        _chartType =
                            (ChartSeriesType)Enum.Parse( typeof( ChartSeriesType ), type );

                        var _message = "The Chart Type has been changed!";
                        SendNotification( _message );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the measure.
        /// </summary>
        /// <param name="stat">The stat.</param>
        private void SetMetric( string stat )
        {
            if( !string.IsNullOrEmpty( stat ) )
            {
                try
                {
                    var _measures = Enum.GetNames( typeof( STAT ) );
                    if( _measures?.Contains( stat ) == true )
                    {
                        _metric = (STAT)Enum.Parse( typeof( STAT ), stat );
                        var _message = "The Chart Statistics have been changed!";
                        SendNotification( _message );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the points.
        /// </summary>
        private void SetPiePoints( )
        {
            try
            {
                if( Chart.Series[ 0 ].Points.Count > 0 )
                {
                    Chart.Series[ 0 ].Points.Clear( );
                }

                var _rows = DataTable.AsEnumerable( );
                var _cnt = (double)_rows.Count( );
                var _points = new List<ChartPoint>( );
                var _data = _rows
                    ?.Select( r => r.Field<double>( "Amount" ) )
                    ?.ToArray( );

                for( var i = 0d; i < _cnt; i++ )
                {
                    var _pt = new ChartPoint( i, _data[ (int)i ] );
                    Chart.Series[ 0 ].Points.Add( _pt );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the active tab.
        /// </summary>
        private void SetActiveQueryTab( )
        {
            try
            {
                switch( QueryTabControl.SelectedIndex )
                {
                    case 0:
                    {
                        ActivateSourceTab( );
                        break;
                    }
                    case 1:
                    {
                        ActivateFilterTab( );
                        break;
                    }
                    case 2:
                    {
                        ActivateGroupTab( );
                        break;
                    }
                    default:
                    {
                        ActivateSourceTab( );
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
        /// Sets the active data tab.
        /// </summary>
        private void SetActiveDataTab( )
        {
            try
            {
                switch( DataTabControl.SelectedIndex )
                {
                    case 0:
                    {
                        ReadyTabPage.TabVisible = true;
                        BusyTabPage.TabVisible = false;
                        break;
                    }
                    case 1:
                    {
                        BusyTabPage.TabVisible = true;
                        ReadyTabPage.TabVisible = false;
                        break;
                    }
                    default:
                    {
                        ReadyTabPage.TabVisible = true;
                        BusyTabPage.TabVisible = false;
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
        /// Sets the series style.
        /// </summary>
        [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
        private void SetSeriesPointStyles( DataTable table,
            ChartSeriesType type = ChartSeriesType.Column )
        {
            try
            {
                ThrowIf.Null( table, nameof( table ) );
                var _borderColor = Color.FromArgb( 0, 120, 212 );
                var _backColor = Color.Black;
                var _textColor = Color.FromArgb( 106, 189, 252 );
                var _callFont = new Font( "Roboto", 8 );
                var _nums = Numerics.ToArray( );
                var _dataRows = table.AsEnumerable( );
                var _index = 0d;
                for( var i = 0; i < table.Rows.Count; i++ )
                {
                    var _doubles = new List<double>( );
                    var _row = table.Rows[ i ];
                    var _series = new ChartSeries( );
                    var _columnName = _nums[ 0 ];
                    var _value = double.Parse( _row[ _columnName ].ToString( ) );
                    _series.Name = _columnName;
                    _series.Text = _series.Name;
                    if( _value > 0 )
                    {
                        _doubles.Add( _value );
                        var _cp = new ChartPoint( _index, _value );
                        _series.Points.Add( _cp );
                    }

                    _series.YAxis.TickColor = _textColor;
                    _series.XAxis.TickColor = _textColor;
                    _series.Visible = true;
                    _series.EnableStyles = true;
                    _series.Type = type;
                    _series.DrawSeriesNameInDepth = true;
                    _series.Style.DisplayText = true;
                    _series.Style.DrawTextShape = true;
                    _series.Style.TextColor = Color.White;
                    _series.Style.Font.Size = 9;
                    _series.Style.Font.Facename = "Roboto";
                    _series.Style.Symbol.Shape = ChartSymbolShape.Circle;
                    _series.Style.TextOffset = 20f;
                    _series.FancyToolTip.Style = MarkerStyle.Rectangle;
                    _series.FancyToolTip.Angle = 45;
                    _series.FancyToolTip.Spacing = 10f;
                    _series.FancyToolTip.Border.ForeColor = _borderColor;
                    _series.FancyToolTip.Border.BackColor = Color.Transparent;
                    _series.FancyToolTip.ForeColor = Color.White;
                    _series.FancyToolTip.BackColor = _backColor;
                    _series.FancyToolTip.Symbol = ChartSymbolShape.Arrow;
                    _series.FancyToolTip.Visible = true;
                    _series.PointsToolTipFormat = "{4}";
                    _series.SeriesToolTipFormat = "#,##0";
                    Chart.Series.Add( _series );
                    _index++;
                }

                var _cols = _fields
                    ?.Take( 4 )
                    ?.ToArray( );

                var _title = string.Empty;
                foreach( var col in _cols )
                {
                    if( col.Contains( "Code" ) )
                    {
                        var _split = col.SplitPascal( );
                        var _name = _split.Replace( "Code", "" );
                        _title += $"{_name} ";
                    }
                }

                Chart.PrimaryXAxis.Title = _title;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the series style.
        /// </summary>
        [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
        private void SetSeriesPointStyles( DataRow row,
            ChartSeriesType type = ChartSeriesType.Column )
        {
            try
            {
                ThrowIf.Null( row, nameof( row ) );
                Chart.Series?.Clear( );
                var _borderColor = Color.FromArgb( 0, 120, 212 );
                var _backColor = Color.Black;
                var _textColor = Color.FromArgb( 106, 189, 252 );
                var _callFont = new Font( "Roboto", 8 );
                var _nums = _numerics.ToArray( );
                for( var i = 0; i < _nums.Length; i++ )
                {
                    var _doubles = new List<double>( );
                    var _series = new ChartSeries( );
                    var _columnName = _nums[ i ];
                    var _index = double.Parse( i.ToString( ) );
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
                    _series.PointsToolTipFormat = "{4}";
                    _series.Style.DisplayText = true;
                    _series.Style.DrawTextShape = true;
                    _series.Style.TextColor = Color.White;
                    _series.Style.Font.Size = 9;
                    _series.Style.Font.Facename = "Roboto";
                    _series.Style.Symbol.Shape = ChartSymbolShape.Circle;
                    _series.Style.TextOffset = 20f;
                    _series.FancyToolTip.Style = MarkerStyle.SmoothRectangle;
                    _series.FancyToolTip.Angle = 45;
                    _series.FancyToolTip.Spacing = 10f;
                    _series.FancyToolTip.Border.ForeColor = _borderColor;
                    _series.FancyToolTip.Border.BackColor = Color.Transparent;
                    _series.FancyToolTip.ForeColor = Color.White;
                    _series.FancyToolTip.BackColor = _backColor;
                    _series.FancyToolTip.Symbol = ChartSymbolShape.Arrow;
                    _series.FancyToolTip.Visible = true;
                    Chart.Series.Add( _series );
                }

                Chart.Refresh( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the fancy tool tips.
        /// </summary>
        private void SetFancyToolTips( )
        {
            try
            {
                var _borderColor = Color.FromArgb( 0, 120, 212 );
                var _backColor = Color.FromArgb( 90, 90, 90 );
                var _textColor = Color.FromArgb( 106, 189, 252 );
                var _callFont = new Font( "Roboto", 7 );
                Chart.Series[ 0 ].FancyToolTip.BackColor = _backColor;
                Chart.Series[ 0 ].FancyToolTip.Border.ForeColor = _borderColor;
                Chart.Series[ 0 ].FancyToolTip.Border.BackColor = Color.Transparent;
                Chart.Series[ 0 ].FancyToolTip.ForeColor = _textColor;
                Chart.Series[ 0 ].FancyToolTip.Font = _callFont;
                Chart.Series[ 0 ].FancyToolTip.Symbol = ChartSymbolShape.Arrow;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the axis title.
        /// </summary>
        /// <returns></returns>
        private string GetAxisTitle( )
        {
            try
            {
                var _title = string.Empty;
                foreach( var _item in _filter.Values )
                {
                    _title += " " + _item;
                }

                return _title;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
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
                ThrowIf.NullOrEmpty( text, nameof( text ) );
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
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                var _message = new SplashMessage( text );
                _message.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        public new void Close( )
        {
            try
            {
                Opacity = 0;
                if( _seconds != 0 )
                {
                    var _timer = new Timer( );
                    _timer.Interval = 1000;
                    _timer.Tick += ( sender, args ) =>
                    {
                        _time--;
                        if( _time == _seconds )
                        {
                            _timer.Stop( );
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeToolStrip( );
                InitializeTimers( );
                InitializeLabels( );
                InitializeChart( );
                InitializeSeries( );
                _filter = new Dictionary<string, object>( );
                _selectedColumns = new List<string>( );
                _selectedFields = new List<string>( );
                _selectedNumerics = new List<string>( );
                _dataArgs = new DataArgs( );
                NumericListBox.MultiSelect = true;
                FieldListBox.MultiSelect = true;
                Text = string.Empty;
                ToolStrip.Visible = true;
                QueryTabControl.SelectedIndex = 0;
                SourceTabPage.TabVisible = true;
                FilterTabPage.TabVisible = false;
                GroupTabPage.TabVisible = false;
                BusyTabPage.TabVisible = false;
                ClearLabels( );
                PopulateToolStripComboBoxItems( );
                PopulateExecutionTables( );
                UpdateStatus( );
                SetActiveQueryTab( );
                Chart.Title.Text = "Select a Data Table";
                FadeIn( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [active tab changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnQueryTabChanged( object sender, EventArgs e )
        {
            try
            {
                SetActiveQueryTab( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [row ListBox item selected].
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
                    _source = (Source)Enum.Parse( typeof( Source ), _selectedTable );
                    BindData( );
                    BindChart( );
                    QueryTabControl.SelectedIndex = 1;
                    SetActiveQueryTab( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [first ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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
                    FirstListBox.Items.Clear( );
                    _firstCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _firstCategory ) )
                    {
                        var _data = _dataModel.DataElements[ _firstCategory ];
                        foreach( var item in _data )
                        {
                            FirstListBox.Items?.Add( item );
                        }
                    }

                    SecondTable.Visible = false;
                    ThirdTable.Visible = false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [first ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFirstListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( _filter.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    _firstValue = _listBox.SelectedValue?.ToString( );
                    _filter[ FirstCategory ] = FirstValue;
                    PopulateSecondComboBoxItems( );
                    if( SecondTable.Visible == false )
                    {
                        SecondTable.Visible = true;
                    }

                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }

                    if( _filter?.Any( ) == true
                       && GroupButton.Visible == false )
                    {
                        GroupButton.Visible = true;
                        GroupSeparator.Visible = true;
                    }

                    _sqlQuery = CreateSqlCommand( _filter );
                    BindData( _sqlQuery );
                    UpdateMetrics( );
                    BindChart( );
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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
                        foreach( var item in _data )
                        {
                            SecondListBox.Items?.Add( item );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [second ListBox item selected].
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
                    _filter[ _firstCategory ] = _firstValue;
                    _filter[ _secondCategory ] = _secondValue;
                    PopulateThirdComboBoxItems( );
                    if( ThirdTable.Visible == false )
                    {
                        ThirdTable.Visible = true;
                    }

                    _sqlQuery = CreateSqlCommand( _filter );
                    BindData( _sqlQuery );
                    UpdateMetrics( );
                    BindChart( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [third ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnThirdComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    _sqlQuery = string.Empty;
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
                            foreach( var item in _data )
                            {
                                ThirdListBox.Items?.Add( item );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
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

                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items.Clear( );
                    }

                    _thirdValue = _listBox.SelectedValue?.ToString( );
                    _filter[ _firstCategory ] = _firstValue;
                    _filter[ _secondCategory ] = _secondValue;
                    _filter[ _thirdCategory ] = _thirdValue;
                    _sqlQuery = CreateSqlCommand( _filter );
                    BindData( _sqlQuery );
                    UpdateMetrics( );
                    BindChart( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [exit button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnExitButtonClicked( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
                Application.Exit( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMainMenuButtonClicked( object sender, EventArgs e )
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
        /// Called when [binding source changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBindingSourceChanged( object sender, EventArgs e )
        {
            try
            {
                var _current = BindingSource.GetCurrentDataRow( );
                SetSeriesPointStyles( _current, _chartType );
                var _position = BindingSource.Position;
                Chart.Refresh( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [chart selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnChartSelected( object sender, EventArgs e )
        {
            try
            {
                var _selectedItem = ToolStripComboBox.ComboBox.SelectedItem.ToString( );
                _chartType = 
                    (ChartSeriesType)Enum.Parse( typeof( ChartSeriesType ), _selectedItem );

                BindChart( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [field ListBox selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFieldListBoxSelectedValueChanged( object sender )
        {
            try
            {
                _sqlQuery = string.Empty;
                var _selectedItem = FieldListBox.SelectedItem.ToString( );
                PopulateNumericListBox( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    _selectedFields.Add( _selectedItem );
                    _selectedColumns.Add( _selectedItem );
                }

                if( NumericTable.Visible == false )
                {
                    NumericTable.Visible = true;
                }

                if( _selectedFields.Count >= 2
                   && _selectedNumerics.Count >= 1 )
                {
                    BindData( _selectedFields, _selectedNumerics, _filter );
                    UpdateMetrics( );
                }
                else
                {
                    BindData( _fields, _numerics, _filter );
                    UpdateMetrics( );
                }

                if( Chart.Visible == false )
                {
                    Chart.Visible = true;
                    SchemaTable.Visible = true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [numeric ListBox selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnNumericListBoxSelectedValueChanged( object sender )
        {
            try
            {
                _selectedNumerics.Clear( );
                var _selectedItem = NumericListBox.SelectedValue.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    _selectedNumerics.Add( _selectedItem );
                }

                BindData( _selectedFields, _selectedNumerics, _filter );
                UpdateMetrics( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                ClearCollections( );
                ClearSelections( );
                ClearComboBoxes( );
                ClearListBoxes( );
                UpdateMetrics( );
                ActivateSourceTab( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [group button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnGroupButtonClicked( object sender, EventArgs e )
        {
            try
            {
                ActivateGroupTab( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [remove filters button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRemoveFiltersButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    ClearData( );
                    ClearCollections( );
                    ClearSelections( );
                    ClearListBoxes( );
                    ClearComboBoxes( );
                    BindData( );
                    QueryTabControl.SelectedIndex = 1;
                    UpdateMetrics( );
                    if( Chart.Visible == true )
                    {
                        Chart.Visible = false;
                        SchemaTable.Visible = false;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( Owner?.Visible == false )
                {
                    var _mainForm = (MainForm)Program.Windows[ nameof( MainForm ) ];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
                    Close( );
                }
                else
                {
                    var _mainForm = new MainForm( );
                    _mainForm.Show( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        /// <param name="sender"> </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnClosing( object sender, EventArgs e )
        {
            try
            {
                ClearSelections( );
                ClearCollections( );
                FadeOut( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
                var _current = BindingSource.GetCurrentDataRow( );
                SetSeriesPointStyles( _current );
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
                var _current = BindingSource.GetCurrentDataRow( );
                SetSeriesPointStyles( _current );
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
                var _current = BindingSource.GetCurrentDataRow( );
                SetSeriesPointStyles( _current );
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
                var _current = BindingSource.GetCurrentDataRow( );
                SetSeriesPointStyles( _current );
                UpdateSchema( _current );
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
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}