// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 2-7-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-7-2024
// ******************************************************************************************
// <copyright file="PivotGridForm.cs" company="Terry D. Eppler">
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
//   PivotGridForm.cs
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
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using Action = System.Action;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Form" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public partial class PivotGridForm : MetroForm
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
        private string _sqlCommand;

        /// <summary>
        /// The xaxis
        /// </summary>
        private string _xaxis;

        /// <summary>
        /// The yvalues
        /// </summary>
        private IList<string> _yvalues;

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
        public string SqlCommand
        {
            get
            {
                return _sqlCommand;
            }
            private set
            {
                _sqlCommand = value;
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
        /// <see cref="T:BudgetExecution.PivotGridForm" /> class.
        /// </summary>
        public PivotGridForm( )
        {
            InitializeComponent( );

            // Basic Properties
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
                    if( _tag?.Equals( "STAT" ) == true )
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
                PivotGrid.GridVisualStyles = GridVisualStyles.Office2016Black;
                PivotGrid.CanOverrideStyle = true;
                PivotGrid.CanApplyTheme = true;
                PivotGrid.Font = _font;
                PivotGrid.ForeColor = _lightBlue;
                PivotGrid.ShowCalculationsAsColumns = true;
                PivotGrid.ShowSubTotals = true;

                // Dialog Style Properties
                PivotGrid.ThemeStyle.ComputationInfoDialogStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.ComputationInfoDialogStyle.ForeColor = _lightBlue;
                PivotGrid.ThemeStyle.ComputationInfoDialogStyle.BorderColor = _borderBlue;

                // Edit Menu Style Properties
                PivotGrid.ThemeStyle.EditMenuStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.EditMenuStyle.ForeColor = _lightBlue;
                PivotGrid.ThemeStyle.EditMenuStyle.BorderColor = _borderBlue;

                // Header Cell Style Properties
                PivotGrid.ThemeStyle.HeaderCellStyle.HoverBackColor = _gray;
                PivotGrid.ThemeStyle.HeaderCellStyle.HoverTextColor = Color.White;
                PivotGrid.ThemeStyle.HeaderCellStyle.PressedBackColor = _borderBlue;
                PivotGrid.ThemeStyle.HeaderCellStyle.PressedTextColor = _lightBlue;

                // Value Cell Style Properties
                PivotGrid.ThemeStyle.ValueCellStyle.Font = _font;
                PivotGrid.ThemeStyle.ValueCellStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.ValueCellStyle.TextColor = _lightBlue;

                // Summary Cell Style Properties
                PivotGrid.ThemeStyle.SummaryCellStyle.Font = _font;
                PivotGrid.ThemeStyle.SummaryCellStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.SummaryCellStyle.TextColor = _lightBlue;

                // Expander Style Properties

                // Filter DropDown Style Properties
                PivotGrid.ThemeStyle.FilterDropDownStyle.ForeColor = _lightBlue;
                PivotGrid.ThemeStyle.FilterDropDownStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.FilterDropDownStyle.BorderColor = _borderBlue;

                // GroupBar Item Style Properties
                PivotGrid.ThemeStyle.GroupBarItemStyle.ForeColor = _lightBlue;
                PivotGrid.ThemeStyle.GroupBarItemStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.GroupBarItemStyle.Font = _font;
                PivotGrid.ThemeStyle.GroupBarItemStyle.SortIconColor = _borderBlue;

                // GroupBar Style Properties
                PivotGrid.ThemeStyle.GroupBarStyle.FilterAreaBackColor = Color.FromArgb( 55, 55, 55 );
                PivotGrid.ThemeStyle.GroupBarStyle.BackColor = _gray;

                // PivotValueChooser Style Properties
                PivotGrid.ThemeStyle.PivotValueChooserStyle.ForeColor = _lightBlue;
                PivotGrid.ThemeStyle.PivotValueChooserStyle.BackColor = _gray;
                PivotGrid.ThemeStyle.PivotValueChooserStyle.BorderColor = _borderBlue;
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
            _statusUpdate += UpdateStatusLabel;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                MenuButton.Click += OnMainMenuButtonClicked;
                CloseButton.Click += OnExitButtonClicked;
                Timer.Tick += OnTimerTick;
                TabControl.SelectedIndexChanged += OnActiveTabChanged;
                TableListBox.SelectedIndexChanged += OnTableListBoxItemSelected;
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
                _selectedTable = string.Empty; 
                _dataModel = null;
                _dataTable = null;
                TabControl.SelectedIndex = 0;
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
                    ?.OrderBy( r => r.Field<string>( nameof( Title ) ) )
                    ?.Select( r => r.Field<string>( nameof( Title ) ) )
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
        /// Binds the data.
        /// </summary>
        private void GetData( )
        {
            try
            {
                _dataModel = new DataBuilder( _source, _provider );
                _dataTable = _dataModel.DataTable;
                _selectedTable = _dataTable.TableName;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
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
        private void GetData( string sqlText )
        {
            try
            {
                ThrowIf.Null( sqlText, nameof( sqlText ) );
                _dataModel = new DataBuilder( _source, _provider, sqlText );
                _dataTable = _dataModel.DataTable;
                BindingSource.DataSource = _dataModel.DataTable;
                ToolStrip.BindingSource = BindingSource;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
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
        private void GetData( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                _filter = where;
                _sqlCommand = CreateSqlText( where );
                _dataModel = new DataBuilder( _source, _provider, _sqlCommand );
                _dataTable = _dataModel.DataTable;
                _selectedTable = _dataTable.TableName;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource.DataSource = _dataModel.DataTable;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
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
                _sqlCommand = CreateSqlText( cols, where );
                _dataModel = new DataBuilder( _source, _provider, _sqlCommand );
                _dataTable = _dataModel.DataTable;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
                _fields = _dataModel.Fields;
                _numerics = _dataModel.Numerics;
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
                _sqlCommand = CreateSqlText( fields, numerics, where );
                _dataModel = new DataBuilder( _source, _provider, _sqlCommand );
                _dataTable = _dataModel.DataTable;
                BindingSource.DataSource = _dataTable;
                ToolStrip.BindingSource = BindingSource;
                _fields = _dataModel.Fields;
                _numerics = _dataModel.Numerics;
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
                _dataArgs.SqlQuery = _sqlCommand;
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
        private string CreateSqlText( IDictionary<string, object> where )
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
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics,
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
                    var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_columns} FROM {_selectedTable} "
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
        private string CreateSqlText( IEnumerable<string> columns,
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
                    return $"SELECT {_names} FROM {_selectedTable} "
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
                if( _filter.Keys.Count > 0 )
                {
                    _filter.Clear( );
                }

                _fourthCategory = string.Empty;
                _fourthValue = string.Empty;
                _thirdCategory = string.Empty;
                _thirdValue = string.Empty;
                _secondCategory = string.Empty;
                _secondValue = string.Empty;
                _firstCategory = string.Empty;
                _firstValue = string.Empty;
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
            catch( Exception ex )
            {
                Fail( ex );
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
                var _timeString = _dateTime.ToLongTimeString( );
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
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    var _rows = _dataTable.Rows?.Count.ToString( "#,###" ) ?? "0";
                    var _filters = _filter.Keys?.Count;
                    var _cols = _dataModel.Fields?.Count ?? 0;
                    var _nums = _dataModel.Numerics?.Count ?? 0;
                    var _selectedCols = _selectedFields?.Count ?? 0;
                    var _selectedNums = _selectedNumerics?.Count ?? 0;
                    MetricLabel1.Text = $"Data Records:  {_rows}";
                    MetricLabel2.Text = $"Total Fields:  {_cols}";
                    MetricLabel3.Text = $"Total Measures:  {_nums}";
                    MetricLabel4.Text = $"Active Filters:  {_filters}";
                    MetricLabel5.Text = $"Selected Fields:  {_selectedCols}";
                    MetricLabel6.Text = $"Selected Measures:  {_selectedNums}";
                    CommandLabel1.Text = _dataModel?.SqlStatement?.CommandText ?? string.Empty;
                }
                else
                {
                    MetricLabel1.Text = "Data Records: 0.0";
                    MetricLabel2.Text = "Total Fields: 0.0";
                    MetricLabel3.Text = "Total Measures: 0.0";
                    MetricLabel4.Text = "Active Filters: 0.0";
                    MetricLabel5.Text = "Selected Fields: 0.0";
                    MetricLabel6.Text = "Selected Measures: 0.0";
                    CommandLabel1.Text = string.Empty;
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
        /// Sets the active tab.
        /// </summary>
        private void SetActiveTab( )
        {
            try
            {
                switch( TabControl.SelectedIndex )
                {
                    case 0:
                    {
                        PopulateExecutionTables( );
                        break;
                    }
                    case 1:
                    {
                        break;
                    }
                    case 2:
                    {
                        ClearCollections( );
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
                InitializePivotGrid( );
                InitializeToolStrip( );
                InitializeTimers( );
                InitializeLabels( );
                _filter = new Dictionary<string, object>( );
                _selectedColumns = new List<string>( );
                _selectedFields = new List<string>( );
                _selectedNumerics = new List<string>( );
                _dataArgs = new DataArgs( );
                Text = string.Empty;
                ToolStrip.Visible = true;
                TabControl.SelectedIndex = 0;
                PopulateExecutionTables( );
                UpdateStatusLabel( );
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
                    UpdateLabelText( );
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
        /// Called when [refresh data button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRefreshButtonClicked( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
                _selectedTable = string.Empty;
                BindingSource.DataSource = null;
                ClearCollections( );
                ClearSelections( );
                ClearComboBoxes( );
                ClearListBoxes( );
                UpdateLabelText( );
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
                TabControl.SelectedIndex = 2;
                SetActiveTab( );
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
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    ClearCollections( );
                    ClearSelections( );
                    ClearListBoxes( );
                    ClearComboBoxes( );
                    GetData( );
                    TabControl.SelectedIndex = 1;
                    UpdateLabelText( );
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
                    //ContextMenu.Show( this, e.Location );
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