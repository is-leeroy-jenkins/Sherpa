// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        11-28-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    BudgetExecution is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ChartDataForm.cs.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;
    using Action = System.Action;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;
    using FontStyle = System.Drawing.FontStyle;
    using Size = System.Drawing.Size;

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
    public partial class ChartDataForm : MetroForm
    {
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

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
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

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
        /// Gets or sets the fourth category.
        /// </summary>
        /// <value>
        /// The fourth category.
        /// </value>
        public string FourthCategory { get; set; }

        /// <summary>
        /// Gets or sets the fourth value.
        /// </summary>
        /// <value>
        /// The fourth value.
        /// </value>
        public string FourthValue { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the x axis.
        /// </summary>
        /// <value>
        /// The x axis.
        /// </value>
        public string xAxis { get; set; }

        /// <summary>
        /// Gets or sets the y values.
        /// </summary>
        /// <value>
        /// The y values.
        /// </value>
        public IList<string> yValues { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> Filter { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }

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
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public STAT Metric { get; set; }

        /// <summary>
        /// Gets or sets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public ChartSeriesType ChartType { get; set; }

        /// <summary>
        /// Gets or sets the data arguments.
        /// </summary>
        /// <value>
        /// The data arguments.
        /// </value>
        public DataArgs DataArgs { get; set; }

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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ChartDataForm" /> class.
        /// </summary>
        public ChartDataForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            InitializeCallbacks( );

            // Basic Properties
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

            // Initialize Default Provider
            Provider = Provider.Access;
            Metric = STAT.Total;
            ChartType = ChartSeriesType.Column;

            // Timer Properties
            Time = 0;
            Seconds = 5;
            Load += OnLoad;
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
            Source = source;
            Provider = provider;
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
            Source = source;
            Provider = provider;
            Filter = where;
        }

        /// <summary>
        /// Sets the title properties.
        /// </summary>
        private protected void InitializeTitle( )
        {
            try
            {
                Chart.Titles[ 0 ].Font = new Font( "Roboto", 10, FontStyle.Bold );
                Chart.Titles[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                Chart.Titles[ 0 ].ForeColor = Color.FromArgb( 106, 189, 252 );
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
                var _headerFont = new Font( "Roboto", 9 );
                var _metricFont = new Font( "Roboto", 7 );
                var _sqlFont = new Font( "Roboto", 8 );
                var _foreColor = Color.FromArgb( 106, 189, 252 );
                var _backColor = Color.Transparent;
                HeaderLabel1.Font = _headerFont;
                HeaderLabel1.ForeColor = _foreColor;
                HeaderLabel1.BackColor = _backColor;
                HeaderLabel2.Font = _headerFont;
                HeaderLabel2.ForeColor = _foreColor;
                HeaderLabel2.BackColor = _backColor;
                HeaderLabel3.Font = _headerFont;
                HeaderLabel3.ForeColor = _foreColor;
                HeaderLabel3.BackColor = _backColor;
                MetricsLabel1.Font = _metricFont;
                MetricsLabel1.ForeColor = _foreColor;
                MetricsLabel2.Font = _metricFont;
                MetricsLabel2.ForeColor = _foreColor;
                MetricsLabel3.Font = _metricFont;
                MetricsLabel3.ForeColor = _foreColor;
                MetricsLabel4.Font = _metricFont;
                MetricsLabel4.ForeColor = _foreColor;
                MetricsLabel5.Font = _metricFont;
                MetricsLabel5.ForeColor = _foreColor;
                MetricsLabel6.Font = _metricFont;
                MetricsLabel6.ForeColor = _foreColor;
                MetricsLabel7.Font = _metricFont;
                MetricsLabel7.ForeColor = _foreColor;
                MetricsLabel8.Font = _metricFont;
                MetricsLabel8.ForeColor = _foreColor;
                MetricsLabel9.Font = _metricFont;
                MetricsLabel9.ForeColor = _foreColor;
                MetricsLabel10.Font = _metricFont;
                MetricsLabel10.ForeColor = _foreColor;
                MetricsLabel11.Font = _metricFont;
                MetricsLabel11.ForeColor = _foreColor;
                MetricsLabel12.Font = _metricFont;
                MetricsLabel12.ForeColor = _foreColor;
                SqlTextHeader.Font = _sqlFont;
                SqlTextHeader.ForeColor = _foreColor;
                SqlText.Font = _sqlFont;
                SqlText.ForeColor = _foreColor;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tool tips.
        /// </summary>
        private void InitializeToolTips( )
        {
            try
            {
                Chart.Tooltip.BackgroundColor = new BrushInfo( Color.FromArgb( 90, 90, 90 ) );
                Chart.Tooltip.Font = new Font( "Roboto Condensed", 8 );
                Chart.Tooltip.BorderStyle = BorderStyle.FixedSingle;
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
        /// Initializes the buttons.
        /// </summary>
        private void InitializePalette( )
        {
            try
            {
                var _steelBlue = Color.SteelBlue;
                var _slateGray = Color.LightSlateGray;
                var _yellow = Color.Yellow;
                var _maroon = Color.Maroon;
                var _green = Color.DarkOliveGreen;
                var _colors = new[ ]
                {
                    _steelBlue,
                    _slateGray,
                    _yellow,
                    _maroon,
                    _green
                };

                Chart.CustomPalette = _colors;
                Chart.Palette = ChartColorPalette.Custom;
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
            _statusUpdate += UpdateStatusLabel;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void InitializeCallbacks( )
        {
            try
            {
                MenuButton.Click += OnMainMenuButtonClicked;
                ExitButton.Click += OnExitButtonClicked;
                Timer.Tick += OnTimerTick;
                QueryTabControl.SelectedIndexChanged += OnActiveTabChanged;
                TableListBox.SelectedIndexChanged += OnTableListBoxItemSelected;
                FirstComboBox.SelectedIndexChanged += OnFirstComboBoxItemSelected;
                FirstListBox.SelectedIndexChanged += OnFirstListBoxItemSelected;
                SecondComboBox.SelectedIndexChanged += OnSecondComboBoxItemSelected;
                SecondListBox.SelectedIndexChanged += OnSecondListBoxItemSelected;
                ThirdComboBox.SelectedIndexChanged += OnThirdComboBoxItemSelected;
                ThirdListBox.SelectedIndexChanged += OnThirdListBoxItemSelected;
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
        /// <param name="action">The action.</param>
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
        /// Displays the control to the user.
        /// </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
                {
                    var _timer = new Timer( );
                    _timer.Interval = 1000;
                    _timer.Tick += ( sender, args ) =>
                    {
                        Time++;
                        if( Time == Seconds )
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
            if( Fields?.Any( ) == true )
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

                    foreach( var item in Fields )
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
            if( Fields?.Any( ) == true )
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

                    if( !string.IsNullOrEmpty( FirstValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory ) )
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
            if( Fields?.Any( ) == true )
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

                    if( !string.IsNullOrEmpty( FirstValue )
                       && !string.IsNullOrEmpty( SecondValue ) )
                    {
                        foreach( var item in Fields )
                        {
                            if( !item.Equals( FirstCategory )
                               && !item.Equals( SecondCategory ) )
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
        /// Clears the data.
        /// </summary>
        public void ClearData( )
        {
            try
            {
                ClearSelections( );
                ClearCollections( );
                ClearComboBoxes( );
                ClearListBoxes( );
                SelectedTable = string.Empty;
                DataModel = null;
                DataTable = null;
                QueryTabControl.SelectedIndex = 0;
                UpdateLabelText( );
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
        /// Populates the tool bar drop down items.
        /// </summary>
        private void PopulateToolBarDropDownItems( )
        {
            try
            {
                SeriesComboBox.Items.Clear( );
                var _names = Enum.GetNames( typeof( ChartSeriesType ) );
                for( var i = 0; i < _names.Length; i++ )
                {
                    var _chart = _names[ i ];
                    SeriesComboBox.Items.Add( _chart );
                }

                MetricsComboBox.Items.Clear( );
                var _metrics = Enum.GetNames( typeof( STAT ) );
                for( var i = 0; i < _metrics.Length; i++ )
                {
                    var _measure = _metrics[ i ];
                    MetricsComboBox.Items.Add( _measure );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                var _names = _data?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )
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
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items.Clear( );
                    }

                    foreach( var _item in Fields )
                    {
                        FieldListBox.Items.Add( _item );
                    }
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
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    if( NumericListBox.Items.Count > 0 )
                    {
                        NumericListBox.Items.Clear( );
                    }

                    for( var i = 0; i < Numerics.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ i ] ) )
                        {
                            NumericListBox.Items.Add( Numerics[ i ] );
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
        /// Binds the data.
        /// </summary>
        private void BindData( )
        {
            try
            {
                DataModel = new DataBuilder( Source, Provider, SqlQuery );
                DataTable = DataModel.DataTable;
                SelectedTable = DataTable.TableName;
                BindingSource.DataSource = DataModel.DataTable;
                ToolStrip.BindingSource = BindingSource;
                Fields = DataModel?.Fields;
                Numerics = DataModel?.Numerics;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="sqlText">The SQL text.</param>
        private void BindData( string sqlText )
        {
            try
            {
                ThrowIf.NullOrEmpty( sqlText, nameof( sqlText ) );
                SqlQuery = sqlText;
                DataModel = new DataBuilder( Source, Provider, sqlText );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataModel.DataTable;
                ToolStrip.BindingSource = BindingSource;
                Fields = DataModel?.Fields;
                Numerics = DataModel?.Numerics;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        /// <param name="where">The where.</param>
        private void BindData( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                Filter = where;
                SqlQuery = CreateSqlText( where );
                DataModel = new DataBuilder( Source, Provider, SqlQuery );
                DataTable = DataModel.DataTable;
                SelectedTable = DataTable.TableName;
                BindingSource.DataSource = DataTable;
                ToolStrip.BindingSource.DataSource = DataModel.DataTable;
                Fields = DataModel?.Fields;
                Numerics = DataModel?.Numerics;
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
                SqlQuery = CreateSqlText( cols, where );
                DataModel = new DataBuilder( Source, Provider, SqlQuery );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataTable;
                ToolStrip.BindingSource = BindingSource;
                Fields = DataModel.Fields;
                Numerics = DataModel.Numerics;
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
                SqlQuery = CreateSqlText( fields, numerics, where );
                DataModel = new DataBuilder( Source, Provider, SqlQuery );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataTable;
                ToolStrip.BindingSource = BindingSource;
                Fields = DataModel.Fields;
                Numerics = DataModel.Numerics;
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
                if( SelectedFields?.Any( ) == true
                   && SelectedNumerics?.Any( ) == true )
                {
                    Chart.Refresh( );
                }
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
                DataArgs.Provider = Provider;
                DataArgs.Source = Source;
                DataArgs.Filter = Filter;
                DataArgs.SelectedTable = SelectedTable;
                DataArgs.SelectedFields = SelectedFields;
                DataArgs.SelectedNumerics = SelectedNumerics;
                DataArgs.SqlQuery = SqlQuery;
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
            if( !string.IsNullOrEmpty( SelectedTable )
               && where?.Any( ) == true )
            {
                try
                {
                    return $"SELECT * FROM {SelectedTable} "
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
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( SelectedTable )
               && where?.Any( ) == true
               && fields?.Any( ) == true
               && numerics?.Any( ) == true )
            {
                try
                {
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
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_columns} FROM {SelectedTable} "
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
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> columns,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( SelectedTable )
               && where?.Any( ) == true
               && columns?.Any( ) == true )
            {
                try
                {
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                if( Filter.Keys.Count > 0 )
                {
                    Filter.Clear( );
                }

                FourthCategory = string.Empty;
                FourthValue = string.Empty;
                ThirdCategory = string.Empty;
                ThirdValue = string.Empty;
                SecondCategory = string.Empty;
                SecondValue = string.Empty;
                FirstCategory = string.Empty;
                FirstValue = string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
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
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the active tab.
        /// </summary>
        private void SetActiveTab( )
        {
            switch( QueryTabControl.SelectedIndex )
            {
                case 0:
                {
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    PopulateExecutionTables( );
                    break;
                }
                case 1:
                {
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    PopulateFirstComboBoxItems( );
                    ResetFilterTableVisibility( );
                    break;
                }
                case 2:
                {
                    GroupTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    FilterTabPage.TabVisible = false;
                    PopulateFieldListBox( );
                    ResetGroupTableVisibility( );
                    break;
                }
            }
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
                var _timeString = _dateTime.ToShortTimeString( );
                StatusLabel.Text = _dateString + "  " + _timeString;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the label text.
        /// </summary>
        private void UpdateLabelText( )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    var _table = SelectedTable?.SplitPascal( ) ?? string.Empty;
                    var _records = DataTable.Rows?.Count.ToString( "#,###" ) ?? "0";
                    var _filters = Filter.Keys?.Count;
                    var _fields = Fields?.Count ?? 0;
                    var _numerics = Numerics?.Count ?? 0;
                    var _selectedFields = SelectedFields?.Count ?? 0;
                    var _selectedNumerics = SelectedNumerics?.Count ?? 0;
                    MetricsLabel1.Text = $"Data Records:  {_records}";
                    MetricsLabel2.Text = $"Total Fields:  {_fields}";
                    MetricsLabel3.Text = $"Total Measures:  {_numerics}";
                    MetricsLabel4.Text = $"Active Filters:  {_filters}";
                    MetricsLabel5.Text = $"Selected Fields:  {_selectedFields}";
                    MetricsLabel7.Text = $"Selected Measures:  {_selectedNumerics}";
                }
                else
                {
                    MetricsLabel1.Text = "Data Records: 0.0";
                    MetricsLabel2.Text = "Total Fields: 0.0";
                    MetricsLabel3.Text = "Total Measures: 0.0";
                    MetricsLabel4.Text = "Active Filters: 0.0";
                    MetricsLabel5.Text = "Selected Fields: 0.0";
                    MetricsLabel7.Text = "Selected Measures: 0.0";
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
        /// Resets the filter table visibility.
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
        /// Resets the group table visibility.
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
                        ChartType =
                            (ChartSeriesType)Enum.Parse( typeof( ChartSeriesType ), type );
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
                        Metric = (STAT)Enum.Parse( typeof( STAT ), stat );
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
                var _count = (double)_rows.Count( );
                var _points = new List<ChartPoint>( );
                var _data = _rows
                    ?.Select( r => r.Field<double>( "Amount" ) )
                    ?.ToArray( );

                for( var i = 0d; i < _count; i++ )
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
        /// Sets the series.
        /// </summary>
        /// <param name="field">The field.</param>
        private void SetSeries( string field )
        {
            try
            {
                if( Chart.Series.Count > 0 )
                {
                    Chart.Series.Clear( );
                }

                var _borderColor = Color.FromArgb( 0, 120, 212 );
                var _textColor = Color.FromArgb( 106, 189, 252 );
                var _font = new Font( "Roboto", 8 );
                var _rows = DataTable.AsEnumerable( );
                var _count = (double)_rows.Count( );
                var _binding = new ChartDataBindModel( );
                _binding.DataSource = DataTable;
                _binding.XName = field;
                _binding.YNames = SelectedNumerics.ToArray( );
                foreach( var _num in SelectedNumerics )
                {
                    var _data = _rows
                        ?.Select( r => r.Field<double>( _num ) )
                        ?.ToArray( );

                    var _series = new ChartSeries( );
                    _series.Name = _num;
                    _series.SeriesModel = _binding;
                    _series.Visible = true;
                    _series.EnableStyles = true;
                    _series.Type = ChartSeriesType.Column;
                    _series.SmartLabels = true;
                    _series.SmartLabelsBorderColor = _borderColor;
                    _series.DrawSeriesNameInDepth = true;
                    _series.ConfigItems.ColumnItem.ColumnType = ChartColumnType.Box;
                    _series.Style.DisplayText = true;
                    _series.Style.Border.Width = 1;
                    _series.Style.Border.Color = _borderColor;
                    _series.Style.Font.Size = _font.Size;
                    _series.Style.Font.Facename = _font.Name;
                    _series.Style.TextColor = _textColor;
                    _series.Style.Callout.Font.Facename = _font.Name;
                    _series.Style.Callout.Font.Size = _font.Size;
                    _series.Style.Callout.TextColor = _textColor;
                    _series.Style.Callout.Color = Color.Transparent;
                    _series.Style.Callout.Position = LabelPosition.Top;
                    _series.Style.Callout.Enable = true;
                    _series.ActualXAxis.Font = _font;
                    _series.ActualXAxis.ForeColor = _borderColor;
                    _series.ActualXAxis.AutoSize = true;
                    _series.ActualXAxis.AxisLabelPlacement = ChartPlacement.Outside;
                    _series.ActualXAxis.ShowAxisLabelTooltip = true;
                    _series.ActualXAxis.ValueType = ChartValueType.Category;
                    _series.ActualYAxis.Font = _font;
                    _series.ActualYAxis.ForeColor = _borderColor;
                    _series.ActualYAxis.AutoSize = true;
                    _series.ActualYAxis.AxisLabelPlacement = ChartPlacement.Outside;
                    _series.ActualYAxis.ShowAxisLabelTooltip = true;
                    _series.ActualYAxis.ValueType = ChartValueType.Double;
                    for( var i = 0d; i < _count; i++ )
                    {
                        var _pt = new ChartPoint( i, _data );
                        _series.Points.Add( _pt );
                        _series.Style.Callout.Text = $"{i}-{_num} - {_data[ (int)i ]:N0}";
                    }

                    Chart.Series.Add( _series );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                InitializePalette( );
                InitializeTitle( );
                InitializeLabels( );
                InitializeToolTips( );
                Filter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                DataArgs = new DataArgs( );
                NumericListBox.MultiSelect = true;
                FieldListBox.MultiSelect = true;
                Text = string.Empty;
                ToolStrip.Visible = true;
                QueryTabControl.SelectedIndex = 0;
                TableTabPage.TabVisible = true;
                FilterTabPage.TabVisible = false;
                GroupTabPage.TabVisible = false;
                Busy.TabVisible = false;
                PopulateExecutionTables( );
                UpdateStatusLabel( );
                Timer.Start( );
                PopulateToolBarDropDownItems( );
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
                SetActiveTab( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                    Filter.Clear( );
                    var _title = _listBox.SelectedValue?.ToString( );
                    SelectedTable = _title?.Replace( " ", "" );
                    Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataModel.DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    QueryTabControl.SelectedIndex = 1;
                    PopulateFirstComboBoxItems( );
                    ResetFilterTableVisibility( );
                    BindData( );
                    UpdateLabelText( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
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
                    SqlQuery = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( SecondListBox.Items?.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    SecondCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( SecondCategory ) )
                    {
                        var _data = DataModel.DataElements[ SecondCategory ];
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
                    if( Filter.Keys?.Count > 0 )
                    {
                        Filter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue?.ToString( );
                    Filter.Add( FirstCategory, FirstValue );
                    Filter.Add( SecondCategory, SecondValue );
                    PopulateThirdComboBoxItems( );
                    if( ThirdTable.Visible == false )
                    {
                        ThirdTable.Visible = true;
                    }

                    BindData( Filter );
                    SqlQuery = CreateSqlText( Filter );
                    SqlTextHeader.Text = SqlQuery;
                    UpdateLabelText( );
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
                    SqlQuery = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    if( ThirdListBox.Items?.Count > 0 )
                    {
                        ThirdListBox.Items?.Clear( );
                    }

                    ThirdCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( ThirdCategory ) )
                    {
                        var _data = DataModel?.DataElements[ ThirdCategory ];
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
                    if( Filter.Keys.Count > 0 )
                    {
                        Filter.Clear( );
                    }

                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items.Clear( );
                    }

                    ThirdValue = _listBox.SelectedValue?.ToString( );
                    Filter.Add( FirstCategory, FirstValue );
                    Filter.Add( SecondCategory, SecondValue );
                    Filter.Add( ThirdCategory, ThirdValue );
                    BindData( Filter );
                    SqlQuery = CreateSqlText( Filter );
                    SqlTextHeader.Text = SqlQuery;
                    UpdateLabelText( );
                    QueryTabControl.SelectedIndex = 2;
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
            if( sender is BindingSource bindingSource )
            {
                try
                {
                    var _position = bindingSource.CurrencyManager.Position;
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
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    FirstListBox.Items.Clear( );
                    FirstCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( FirstCategory ) )
                    {
                        var _data = DataModel.DataElements[ FirstCategory ];
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
                    if( Filter.Count > 0 )
                    {
                        Filter.Clear( );
                    }

                    FirstValue = _listBox.SelectedValue?.ToString( );
                    Filter.Add( FirstCategory, FirstValue );
                    PopulateSecondComboBoxItems( );
                    if( SecondTable.Visible == false )
                    {
                        SecondTable.Visible = true;
                    }

                    if( ThirdTable.Visible == true )
                    {
                        ThirdTable.Visible = false;
                    }

                    if( GroupButton.Visible == false )
                    {
                        GroupButton.Visible = true;
                        GroupSeparator.Visible = true;
                    }

                    BindData( Filter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( Filter );
                    SqlText.Text = SqlQuery;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                SqlTextHeader.Text = string.Empty;
                var _selectedItem = FieldListBox.SelectedItem.ToString( );
                PopulateNumericListBox( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedFields.Add( _selectedItem );
                    SelectedColumns.Add( _selectedItem );
                }

                if( NumericTable.Visible == false )
                {
                    NumericTable.Visible = true;
                }

                if( SelectedFields.Count >= 2
                   && SelectedNumerics.Count >= 1 )
                {
                    BindData( SelectedFields, SelectedNumerics, Filter );
                    SqlQuery = CreateSqlText( SelectedFields, SelectedNumerics, Filter );
                    SqlTextHeader.Text = SqlQuery;
                    UpdateLabelText( );
                }
                else
                {
                    BindData( Fields, Numerics, Filter );
                    SqlQuery = CreateSqlText( Fields, Numerics, Filter );
                    SqlTextHeader.Text = SqlQuery;
                    UpdateLabelText( );
                }

                if( Chart.Visible == false )
                {
                    Chart.Visible = true;
                    SqlTextHeader.Visible = true;
                    MetricsTable.Visible = true;
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
                SelectedNumerics.Clear( );
                SqlTextHeader.Text = string.Empty;
                var _selectedItem = NumericListBox.SelectedValue.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    SelectedNumerics.Add( _selectedItem );
                }

                BindData( SelectedFields, SelectedNumerics, Filter );
                SqlQuery = CreateSqlText( SelectedFields, SelectedNumerics, Filter );
                SqlTextHeader.Text = SqlQuery;
                UpdateLabelText( );
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
        private void OnRefreshDataButtonClicked( object sender, EventArgs e )
        {
            try
            {
                SelectedTable = string.Empty;
                BindingSource.DataSource = null;
                ClearCollections( );
                ClearSelections( );
                ClearComboBoxes( );
                ClearListBoxes( );
                UpdateLabelText( );
                QueryTabControl.SelectedIndex = 0;
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
                QueryTabControl.SelectedIndex = 2;
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
                    SqlQuery = string.Empty;
                    ClearCollections( );
                    ClearSelections( );
                    ClearListBoxes( );
                    ClearComboBoxes( );
                    BindData( );
                    QueryTabControl.SelectedIndex = 1;
                    UpdateLabelText( );
                    if( Chart.Visible == true )
                    {
                        Chart.Visible = false;
                        SqlTextHeader.Visible = false;
                        MetricsTable.Visible = false;
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
                    var _mainForm = (MainForm)Program.Windows[ "MainForm" ];
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
        /// Called when [chart type selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnChartTypeSelected( object sender, EventArgs e )
        {
            try
            {
                var _selectedItem = SeriesComboBox.ComboBox.SelectedItem;
                var _selection = _selectedItem.ToString( );
                var _names = Enum.GetNames( typeof( ChartSeriesType ) );
                var _message = $"Chart Type Changed To {_selection}";
                var _notify = new Notification( _message );
                if( !string.IsNullOrEmpty( _selection )
                   && _names.Contains( _selection ) )
                {
                    ChartType =
                        (ChartSeriesType)Enum.Parse( typeof( ChartSeriesType ), _selection );

                    _notify.Show( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [metric selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMetricSelected( object sender, EventArgs e )
        {
            try
            {
                var _selectedItem = MetricsComboBox.ComboBox.SelectedItem;
                var _selection = _selectedItem.ToString( );
                var _names = Enum.GetNames( typeof( STAT ) );
                var _message = $"Selected Metric Changed To {_selection}";
                var _notify = new Notification( _message );
                if( !string.IsNullOrEmpty( _selection )
                   && _names.Contains( _selection ) )
                {
                    Metric = (STAT)Enum.Parse( typeof( STAT ), _selection );
                    _notify.Show( );
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