﻿// ******************************************************************************************
//     Assembly:             Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        03-23-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Sherpa is a small Federal Budget, Finance, and Accounting data management
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
//   ChartDataForm.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;
    using Action = System.Action;
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
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    public partial class ChartDataForm : MetroForm
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
        private protected int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private protected int _seconds;

        /// <summary>
        /// The count
        /// </summary>
        private protected int _count;

        /// <summary>
        /// The hover text
        /// </summary>
        private protected string _hoverText;

        /// <summary>
        /// The selected table
        /// </summary>
        private protected string _selectedTable;

        /// <summary>
        /// The first category
        /// </summary>
        private protected string _firstCategory;

        /// <summary>
        /// The first value
        /// </summary>
        private protected string _firstValue;

        /// <summary>
        /// The second category
        /// </summary>
        private protected string _secondCategory;

        /// <summary>
        /// The second value
        /// </summary>
        private protected string _secondValue;

        /// <summary>
        /// The third category
        /// </summary>
        private protected string _thirdCategory;

        /// <summary>
        /// The third value
        /// </summary>
        private protected string _thirdValue;

        /// <summary>
        /// The fourth category
        /// </summary>
        private protected string _fourthCategory;

        /// <summary>
        /// The fourth value
        /// </summary>
        private protected string _fourthValue;

        /// <summary>
        /// The SQL command
        /// </summary>
        private protected string _sqlQuery;

        /// <summary>
        /// The xaxis
        /// </summary>
        private protected string _xaxis;

        /// <summary>
        /// The yvalues
        /// </summary>
        private protected IList<string> _yvalues;

        /// <summary>
        /// The chart type
        /// </summary>
        private protected ChartSeriesType _chartType;

        /// <summary>
        /// The stat
        /// </summary>
        private protected STAT _metric;

        /// <summary>
        /// The data model
        /// </summary>
        private protected DataBuilder _dataModel;

        /// <summary>
        /// The data table
        /// </summary>
        private protected DataTable _dataTable;

        /// <summary>
        /// The filter
        /// </summary>
        private protected IDictionary<string, object> _filter;

        /// <summary>
        /// The fields
        /// </summary>
        private protected IList<string> _fields;

        /// <summary>
        /// The columns
        /// </summary>
        private protected IList<string> _columns;

        /// <summary>
        /// The numerics
        /// </summary>
        private protected IList<string> _numerics;

        /// <summary>
        /// The selected columns
        /// </summary>
        private protected IList<string> _selectedColumns;

        /// <summary>
        /// The selected fields
        /// </summary>
        private protected IList<string> _selectedFields;

        /// <summary>
        /// The selected numerics
        /// </summary>
        private protected IList<string> _selectedNumerics;

        /// <summary>
        /// The source
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private protected Provider _provider;

        /// <summary>
        /// The data arguments
        /// </summary>
        private protected DataArgs _dataArgs;

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
            private protected set
            {
                _count = value;
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
            private protected set
            {
                _selectedTable = value;
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
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
            private protected set
            {
                _provider = value;
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ChartDataForm" /> class.
        /// </summary>
        public ChartDataForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
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

            // Default Provider
            _provider = Provider.Access;
            _metric = STAT.Total;
            _chartType = ChartSeriesType.Column;

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

            // Event Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ChartDataForm" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ChartDataForm( Source source, Provider provider )
            : this( )
        {
            _source = source;
            _provider = provider;
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
                MenuButton.Click += OnMenuButtonClicked;
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
                ChartHeaderTable.MouseClick += OnRightClick;
                ChartHeaderPanel.MouseClick += OnRightClick;
                SourcePanel.MouseClick += OnRightClick;
                ExportButton.Click += OnExportButtonClick;
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
                foreach( var _label in _labels.Values )
                {
                    _label.Font = _font;
                    _label.ForeColor = _foreColor;
                    _label.BackColor = _backColor;
                }
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
        /// Initializes the chart.
        /// </summary>
        private void InitializeChart( )
        {
            try
            {
                var _colors = new[ ]
                {
                    Color.FromArgb( 0, 120, 212 ),
                    Color.SlateGray,
                    Color.Yellow,
                    Color.DarkGreen,
                    Color.Maroon,
                    Color.Olive
                };

                Chart.CustomPalette = _colors;
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
                    Chart.Series[ i ].Style.Font.Size = _callFont.Size;
                    Chart.Series[ i ].Style.Font.Facename = _callFont.Name;
                    Chart.Series[ i ].Style.DisplayText = true;
                    Chart.Series[ i ].Style.TextColor = _textColor;
                }

                SetFancyToolTips( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        /// Invokes if.
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
                foreach( var _type in _types )
                {
                    if( !_list.Contains( _type ) )
                    {
                        ToolStripComboBox.Items.Add( _type );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
        private void GetData( )
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
                    BindingSource.DataSource = _dataTable;
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
                    BindingSource.DataSource = _dataTable;
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
        private void GetData( string sqlText )
        {
            try
            {
                ThrowIf.Null( sqlText, nameof( sqlText ) );
                BeginInit( );
                _dataModel = new DataBuilder( _source, _provider, sqlText );
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
        /// <param name="where">
        /// The where.
        /// </param>
        private void GetData( IDictionary<string, object> where )
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
        private void GetData( IEnumerable<string> cols, IDictionary<string, object> where )
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
        private void GetData( IEnumerable<string> fields, IEnumerable<string> numerics,
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
                var _current = _dataModel.Record;
                UpdateSchema( _current );
                SetSeriesPointStyles( _current, _chartType );
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
                    ThrowIf.Empty( where, nameof( where ) );
                    ThrowIf.Empty( fields, nameof( fields ) );
                    ThrowIf.Empty( numerics, nameof( numerics ) );
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
                    ThrowIf.Empty( where, nameof( where ) );
                    ThrowIf.Empty( columns, nameof( columns ) );
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
                Chart.Series?.Clear( );
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
                var _white = Color.White;
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
                    _series.Style.TextColor = _white;
                    _series.Style.Font.Size = 9;
                    _series.Style.Font.Facename = "Roboto";
                    _series.Style.Symbol.Shape = ChartSymbolShape.Circle;
                    _series.Style.TextOffset = 20f;
                    _series.FancyToolTip.Style = MarkerStyle.SmoothRectangle;
                    _series.FancyToolTip.Angle = 45;
                    _series.FancyToolTip.Spacing = 10f;
                    _series.FancyToolTip.Border.ForeColor = _borderColor;
                    _series.FancyToolTip.Border.BackColor = Color.Transparent;
                    _series.FancyToolTip.ForeColor = _white;
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
        /// Sets the form icon.
        /// </summary>
        private void SetFormIcon( )
        {
            try
            {
                var _filePath = ConfigurationManager.AppSettings[ "ProviderImages" ];
                if( !string.IsNullOrEmpty( _filePath ) )
                {
                    var _files = Directory.GetFiles( _filePath );
                    if( _files?.Any( ) == true )
                    {
                        var _extension = _provider.ToString( );
                        var _file = _files
                            ?.Where( f => f.Contains( _extension ) )
                            ?.First( );

                        if( !string.IsNullOrEmpty( _file )
                           && File.Exists( _file ) )
                        {
                            var _image = Image.FromFile( _file );
                            PictureBox.Image = _image;
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
                InitializeTimer( );
                InitializeLabels( );
                InitializeSeries( );
                InitializeChart( );
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
                    GetData( );
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
                    _firstValue = _listBox.SelectedValue?.ToString( );
                    _filter[ _firstCategory ] = _firstValue;
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
                    GetData( );
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
                    GetData( _sqlQuery );
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
                    GetData( _sqlQuery );
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
        private void OnMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                base.Close( );
                OpenMainForm( );
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
                var _current = BindingSource.GetCurrentRow( );
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
                    GetData( _selectedFields, _selectedNumerics, _filter );
                    UpdateMetrics( );
                }
                else
                {
                    GetData( _fields, _numerics, _filter );
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

                GetData( _selectedFields, _selectedNumerics, _filter );
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
                    GetData( );
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
            try
            {
                InvokeIf( _statusUpdate );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                var _current = BindingSource.GetCurrentRow( );
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
                var _current = BindingSource.GetCurrentRow( );
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
                var _current = BindingSource.GetCurrentRow( );
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
                var _current = BindingSource.GetCurrentRow( );
                SetSeriesPointStyles( _current );
                UpdateSchema( _current );
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}