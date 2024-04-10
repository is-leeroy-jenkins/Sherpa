// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 12-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-10-2023
// ******************************************************************************************
// <copyright file="DataViewForm.cs" company="Terry D. Eppler">
//    This is a tiny web browser used in Federal Budget, Finance, and Accounting application
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
//   DataViewForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
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
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "RedundantNameQualifier" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    public partial class DataViewForm : MetroForm
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
        /// The SQL command
        /// </summary>
        private string _sqlQuery;

        /// <summary>
        /// The yvalues
        /// </summary>
        private IList<string> _columns;

        /// <summary>
        /// The data model
        /// </summary>
        private DataBuilder _dataModel;

        /// <summary>
        /// The data table
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
        /// Gets or sets the current.
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
        /// Gets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
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
        /// Gets the SQL command.
        /// </summary>
        /// <value>
        /// The SQL command.
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
        /// Gets the data table.
        /// </summary>
        /// <value>
        /// The data table.
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
        /// <see cref="T:BudgetExecution.DataViewForm" /> class.
        /// </summary>
        public DataViewForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

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

            // Initialize Default Provider
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

            // Form Event Wiring
            Load += OnLoad;
            Activated += OnActivated;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
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
        /// Clears the data.
        /// </summary>
        public void ClearData( )
        {
            try
            {
                ClearSelections( );
                ClearCollections( );
                _selectedTable = string.Empty;
                DataGrid.DataSource = null;
                BindingSource.DataSource = null;
                _dataModel = null;
                _dataTable = null;
                UpdateLabels( );
                SelectionTabControl.SelectedIndex = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tab control.
        /// </summary>
        private void InitializeTabControl( )
        {
            try
            {
                SelectionTabControl.ActiveTabForeColor = Color.FromArgb( 20, 20, 20 );
                TableTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
                FilterTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
                GroupTabPage.TabForeColor = Color.FromArgb( 20, 20, 20 );
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
                FirstGridLabel.Font = new Font( "Roboto", 8 );
                FirstGridLabel.ForeColor = Color.FromArgb( 106, 189, 252 );
                SecondGridLabel.Font = new Font( "Roboto", 8 );
                SecondGridLabel.ForeColor = Color.FromArgb( 106, 189, 252 );
                SecondGridLabel.Text = string.Empty;
                ThirdGridLabel.Font = new Font( "Roboto", 8 );
                ThirdGridLabel.ForeColor = Color.FromArgb( 106, 189, 252 );
                ThirdGridLabel.Text = string.Empty;
                FourthGridLabel.Font = new Font( "Roboto", 8 );
                FourthGridLabel.ForeColor = Color.FromArgb( 106, 189, 252 );
                FourthGridLabel.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the title.
        /// </summary>
        private void InitializeTitle( )
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
        /// Initializes the radio buttons.
        /// </summary>
        private void InitializeRadioButtons( )
        {
            try
            {
                SQLiteRadioButton.Tag = nameof( SQLite );
                SQLiteRadioButton.Text = nameof( SQLite );
                SQLiteRadioButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SQLiteRadioButton.HoverText = "SQLite Provider";
                AccessRadioButton.Tag = nameof( Access );
                AccessRadioButton.Text = nameof( Access );
                AccessRadioButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                AccessRadioButton.HoverText = "MS Access Provider";
                AccessRadioButton.Checked = true;
                SqlCeRadioButton.Tag = nameof( SqlCe );
                SqlCeRadioButton.Text = "SQL CE";
                SqlCeRadioButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SqlCeRadioButton.HoverText = "SQL Compact Provider";
                SqlServerRadioButton.Tag = nameof( SqlServer );
                SqlServerRadioButton.Text = "MS SQL";
                SqlServerRadioButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SqlServerRadioButton.HoverText = "Sql Server Provider";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the layouts.
        /// </summary>
        private void InitializeLayouts( )
        {
            try
            {
                FirstTable.Visible = false;
                SecondTable.Visible = false;
                ThirdTable.Visible = false;
            }
            catch( Exception _ex )
            {
                Console.WriteLine( _ex );
                throw;
            }
        }

        /// <summary>
        /// Initializes the PictureBox.
        /// </summary>
        private void InitializePictureBox( )
        {
            try
            {
                PictureBox.Size = new Size( 18, 18 );
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
                Timer.Enabled = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            // Control Event Wiring
            try
            {
                ExitButton.Click += null;
                MenuButton.Click += null;
                EditSqlButton.Click += null;
                EditRecordButton.Click += null;
                RefreshDataButton.Click += null;
                RemoveFiltersButton.Click += null;
                GroupButton.Click += null;
                CalendarButton.Click += null;
                SelectionTabControl.SelectedIndexChanged += OnActiveTabChanged;
                TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
                FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
                FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
                SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
                SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
                ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
                ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
                FieldListBox.SelectedValueChanged += OnFieldListBoxSelectedValueChanged;
                NumericListBox.SelectedValueChanged += OnNumericListBoxSelectedValueChanged;
                TableComboBox.SelectedValueChanged += OnTableComboBoxItemSelected;
                AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
                SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlCeRadioButton.CheckedChanged += OnRadioButtonChecked;
                ExitButton.Click += OnExitButtonClick;
                MenuButton.Click += OnMenuButtonClick;
                RemoveFiltersButton.Click += OnRemoveFilterButtonClick;
                RefreshDataButton.Click += OnRefreshDataButtonClick;
                GroupButton.Click += OnGroupButtonClick;
                CalendarButton.Click += OnCalendarButtonClick;
                FirstCalendar.SelectionChanged += OnStartDateSelected;
                SecondCalendar.SelectionChanged += OnEndDateSelected;
                EditSqlButton.Click += OnSqlButtonClick;
                EditRecordButton.Click += OnEditRecordButtonClick;
                EditColumnButton.Click += OnEditColumnButtonClick;
                Timer.Tick += OnTimerTick;
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
                    if( _collection != null )
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
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<RadioButton> GetRadioButtons( )
        {
            try
            {
                var _buttons = new List<RadioButton>
                {
                    SQLiteRadioButton,
                    AccessRadioButton,
                    SqlCeRadioButton,
                    SqlServerRadioButton
                };

                return _buttons?.Any( ) == true
                    ? _buttons
                    : default( IEnumerable<RadioButton> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<RadioButton> );
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

                    foreach( var _item in Fields )
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
                        for( var _index = 0; _index < _fields.Count; _index++ )
                        {
                            var _item = _fields[ _index ];
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
                        FieldListBox.Items?.Clear( );
                    }

                    foreach( var _item in _fields )
                    {
                        FieldListBox?.Items?.Add( _item );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
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
                        NumericListBox.Items?.Clear( );
                    }

                    for( var _i = 0; _i < _numerics.Count; _i++ )
                    {
                        if( !string.IsNullOrEmpty( _numerics[ _i ] ) )
                        {
                            NumericListBox?.Items?.Add( _numerics[ _i ] );
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
                    ?.OrderBy( r => r.Field<string>( nameof( Title ) ) )
                    ?.Select( r => r.Field<string>( nameof( Title ) ) )?.ToList( );

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
                    ?.OrderBy( r => r.Field<string>( nameof( Title ) ) )
                    ?.Select( r => r.Field<string>( nameof( Title ) ) )?.ToList( );

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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                if( !string.IsNullOrEmpty( _thirdValue )
                   || ThirdTable.Visible )
                {
                    ThirdComboBox.Items?.Clear( );
                    ThirdListBox.Items?.Clear( );
                    _thirdCategory = string.Empty;
                    _thirdValue = string.Empty;
                    ThirdTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( _secondValue )
                   || SecondTable.Visible )
                {
                    SecondComboBox.Items?.Clear( );
                    SecondListBox.Items?.Clear( );
                    _secondCategory = string.Empty;
                    _secondValue = string.Empty;
                    SecondTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( _firstValue )
                   || FirstTable.Visible )
                {
                    FirstComboBox.Items?.Clear( );
                    FirstListBox.Items?.Clear( );
                    _firstCategory = string.Empty;
                    _firstValue = string.Empty;
                    PopulateFirstComboBoxItems( );
                    FirstTable.Visible = true;
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
                FieldListBox.Items?.Clear( );
                NumericListBox.Items?.Clear( );
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
                    ThrowIf.Empty( columns, nameof( columns ) );
                    var _cols = string.Empty;
                    foreach( var _name in columns )
                    {
                        _cols += $"{_name}, ";
                    }

                    var _criteria = where.ToCriteria( );
                    var _names = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_names} FROM {_selectedTable} " + $"WHERE {_criteria} "
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
                ThrowIf.Null( where, nameof( where ) );
                ThrowIf.Empty( fields, nameof( fields ) );
                ThrowIf.Empty( numerics, nameof( numerics ) );
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

        /// <summary>
        /// Gets the data.
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
                    BindingSource.DataSource = _dataModel?.DataTable;
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
                    BindingSource.DataSource = _dataModel?.DataTable;
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
        /// <param name="where">The where.</param>
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
                DataGrid.DataSource = BindingSource;
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
                ThrowIf.Empty( where, nameof( where ) );
                ThrowIf.Empty( cols, nameof( cols ) );
                var _sql = CreateSqlCommand( cols, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _selectedTable = _dataTable?.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                DataGrid.DataSource = BindingSource;
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
            if( where?.Any( ) == true
               && fields?.Any( ) == true )
            {
                try
                {
                    var _sql = CreateSqlCommand( fields, numerics, where );
                    _dataModel = new DataBuilder( _source, _provider, _sql );
                    _dataTable = _dataModel?.DataTable;
                    _selectedTable = _dataTable?.TableName;
                    _fields = _dataModel?.Fields;
                    _numerics = _dataModel?.Numerics;
                    BindingSource.DataSource = _dataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
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
                            var _img = Image.FromFile( _file );
                            if( _img != null )
                            {
                                PictureBox.Image = _img;
                            }
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
        /// Sets the icon.
        /// </summary>
        /// <param name="type">The type.</param>
        private void SetIcon( ToolType type )
        {
            try
            {
                var _appSetting = ConfigurationManager.AppSettings[ "DialogImages" ];
                if( !string.IsNullOrEmpty( _appSetting ) )
                {
                    var _files = Directory.GetFiles( _appSetting );
                    if( _files?.Any( ) == true )
                    {
                        switch( type )
                        {
                            case ToolType.EditTextButton:
                            case ToolType.AddTableButton:
                            case ToolType.DeleteTableButton:
                            case ToolType.EditRecordButton:
                            case ToolType.DeleteRecordButton:
                            case ToolType.EditColumnButton:
                            case ToolType.DeleteColumnButton:
                            case ToolType.EditSqlButton:
                            case ToolType.EditButton:
                            {
                                var _tool = type.ToString( );
                                var _file = _files
                                    ?.Where( f => f.Contains( _tool ) )
                                    ?.First( );

                                if( !string.IsNullOrEmpty( _file )
                                   && File.Exists( _file ) )
                                {
                                    var _img = Image.FromFile( _file );
                                    PictureBox.Image = _img;
                                }

                                break;
                            }
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
        /// Resets the ListBox visibility.
        /// </summary>
        private void ResetListBoxVisibility( )
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
                var _dateString = _dateTime.ToLongDateString( );
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
        private void UpdateLabels( )
        {
            try
            {
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    var _table = _selectedTable?.SplitPascal( ) ?? string.Empty;
                    var _rows = _dataTable.Rows.Count.ToString( "#,###" ) ?? "0";
                    var _cols = _fields?.Count ?? 0;
                    var _vals = _numerics?.Count ?? 0;
                    var _selectedCols = _selectedFields?.Count ?? 0;
                    var _selectedVals = _selectedNumerics?.Count ?? 0;
                    Title.Text = $"{_table} ";
                    FirstGridLabel.Text = $"Data Provider: {_provider}";
                    SecondGridLabel.Text = $"Records: {_rows}";
                    ThirdGridLabel.Text = $"Total Fields: {_cols}";
                    FourthGridLabel.Text = $"Total Measures: {_vals}";
                    FieldsTable.CaptionText = $"Selected Fields: {_selectedCols}";
                    NumericsTable.CaptionText = $"Selected Measures: {_selectedVals}";
                    FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar.SelectedDate}";
                    SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar.SelectedDate}";
                }
                else
                {
                    Title.Text = $"{_provider} Database ";
                    FirstGridLabel.Text = $"Provider:  {_provider}";
                    SecondGridLabel.Text = "Total Records: 0.0";
                    ThirdGridLabel.Text = "Total Fields: 0.0";
                    FourthGridLabel.Text = "Total Measures: 0.0";
                    FieldsTable.CaptionText = "Selected Fields: 0.0";
                    NumericsTable.CaptionText = "Selected Measures: 0.0";
                    FirstCalendarTable.CaptionText = "Start Date: --";
                    SecondCalendarTable.CaptionText = "End Date: --";
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                ClearSelections( );
                InitializeRadioButtons( );
                SetFormIcon( );
                InitializeToolStrip( );
                InitializeTitle( );
                InitializeLabels( );
                InitializeTabControl( );
                InitializeLayouts( );
                InitializeTimer( );
                _filter = new Dictionary<string, object>( );
                _selectedColumns = new List<string>( );
                _selectedFields = new List<string>( );
                _selectedNumerics = new List<string>( );
                _dataArgs = new DataArgs( );
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    SelectionTabControl.SelectedIndex = 1;
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    DataLabelTable.Visible = true;
                    PopulateFirstComboBoxItems( );
                    ResetListBoxVisibility( );
                }
                else if( string.IsNullOrEmpty( _selectedTable ) )
                {
                    SelectionTabControl.SelectedIndex = 0;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    TableComboBox.SelectionStart = 0;
                }

                UpdateLabels( );
                UpdateStatus( );
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
                    _filter.Clear( );
                    ToolStrip.Visible = true;
                    var _title = _listBox.SelectedValue?.ToString( );
                    _selectedTable = _title?.Replace( " ", "" );
                    if( !string.IsNullOrEmpty( _selectedTable ) )
                    {
                        _source = (Source)Enum.Parse( typeof( Source ), _selectedTable );
                    }

                    _dataModel = new DataBuilder( _source, _provider );
                    _dataTable = _dataModel.DataTable;
                    _fields = _dataModel.Fields;
                    _numerics = _dataModel.Numerics;
                    BindingSource.DataSource = _dataModel.DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    SelectionTabControl.SelectedIndex = 1;
                    UpdateLabels( );
                    PopulateFirstComboBoxItems( );
                    ResetListBoxVisibility( );
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
                    FirstListBox.Items?.Clear( );
                    _firstCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _firstCategory ) )
                    {
                        _dataModel = new DataBuilder( _source, _provider );
                        var _data = _dataModel.DataElements[ _firstCategory ];
                        foreach( var _item in _data )
                        {
                            FirstListBox.Items?.Add( _item );
                        }
                    }

                    SecondTable.Visible = false;
                    ThirdTable.Visible = false;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
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
                    _filter.Add( _firstCategory, _firstValue );
                    PopulateSecondComboBoxItems( );
                    if( SecondTable.Visible == false )
                    {
                        SecondTable.Visible = true;
                    }

                    if( ThirdTable.Visible )
                    {
                        ThirdTable.Visible = false;
                    }

                    if( GroupButton.Visible == false )
                    {
                        GroupButton.Visible = true;
                        GroupSeparator.Visible = true;
                    }

                    GetData( _filter );
                    UpdateLabels( );
                    _sqlQuery = CreateSqlCommand( _filter );
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
                    _filter.Add( _firstCategory, _firstValue );
                    _filter.Add( _secondCategory, _secondValue );
                    PopulateThirdComboBoxItems( );
                    if( ThirdTable.Visible == false )
                    {
                        ThirdTable.Visible = true;
                    }

                    GetData( _filter );
                    UpdateLabels( );
                    _sqlQuery = CreateSqlCommand( _filter );
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

                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items?.Clear( );
                    }

                    _thirdValue = _listBox.SelectedValue?.ToString( );
                    _filter.Add( _firstCategory, _firstValue );
                    _filter.Add( _secondCategory, _secondValue );
                    _filter.Add( _thirdCategory, _thirdValue );
                    GetData( _filter );
                    UpdateLabels( );
                    _sqlQuery = CreateSqlCommand( _filter );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [test button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTestButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _program = new ProgramProjectDialog( );
                _program.ShowDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [exit button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMenuButtonClick( object sender, EventArgs e )
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
        /// Called when [remove filter button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRemoveFilterButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    ClearSelections( );
                    ClearCollections( );
                    DataGrid.DataSource = null;
                    _dataModel = new DataBuilder( _source, _provider );
                    _dataTable = _dataModel.DataTable;
                    _fields = _dataModel.Fields;
                    _numerics = _dataModel.Numerics;
                    BindingSource.DataSource = _dataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    SelectionTabControl.SelectedIndex = 1;
                    PopulateFirstComboBoxItems( );
                    UpdateLabels( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [table ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTableComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _tableComboBox )
            {
                try
                {
                    var _type = _tableComboBox.SelectedItem.ToString( );
                    switch( _type?.ToUpper( ) )
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
        /// Called when [field ListBox selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFieldListBoxSelectedValueChanged( object sender )
        {
            try
            {
                var _selectedItem = FieldListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    _selectedFields.Add( _selectedItem );
                    _selectedColumns.Add( _selectedItem );
                }

                _sqlQuery = CreateSqlCommand( _selectedColumns, _filter );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
                var _selectedItem = NumericListBox.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _selectedItem ) )
                {
                    _selectedNumerics.Add( _selectedItem );
                }

                _sqlQuery = CreateSqlCommand( _selectedFields, _selectedNumerics, _filter );
                GetData( );
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
                switch( SelectionTabControl.SelectedIndex )
                {
                    case 0:
                    {
                        TableTabPage.TabVisible = true;
                        FilterTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ProviderTable.Visible = true;
                        SetFormIcon( );
                        PopulateExecutionTables( );
                        break;
                    }
                    case 1:
                    {
                        FilterTabPage.TabVisible = true;
                        TableTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ProviderTable.Visible = false;
                        ResetListBoxVisibility( );
                        break;
                    }
                    case 2:
                    {
                        GroupTabPage.TabVisible = true;
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ProviderTable.Visible = false;
                        break;
                    }
                    case 3:
                    {
                        CalendarTabPage.TabVisible = true;
                        GroupTabPage.TabVisible = false;
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        ProviderTable.Visible = false;
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
        /// Called when [group button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnGroupButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( _filter.Count > 0 )
                {
                    SelectionTabControl.SelectedIndex = 2;
                    PopulateFieldListBox( );
                    PopulateNumericListBox( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [calendar button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCalendarButtonClick( object sender, EventArgs e )
        {
            try
            {
                SelectionTabControl.SelectedIndex = 3;
                FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar.SelectedDate}";
                SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar.SelectedDate}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [edit record button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnEditRecordButtonClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    SetIcon( _button.ToolType );
                    var _dialog = new EditPage( _source, _provider );
                    _dialog?.ShowDialog( this );
                    SetFormIcon( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [edit column button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnEditColumnButtonClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    SetIcon( _button.ToolType );
                    var _dialog = new SchemaPage( _button.ToolType, BindingSource );
                    _dialog?.ShowDialog( this );
                    SetFormIcon( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                    //FormMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [SQL button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSqlButtonClick( object sender, EventArgs e )
        {
            if( !string.IsNullOrEmpty( _sqlQuery )
               && sender is ToolStripButton _button )
            {
                try
                {
                    SetIcon( _button.ToolType );
                    var _dialog = new SqlPage( );
                    _dialog.BindingSource = BindingSource;
                    _dialog.Editor.Text = _sqlQuery;
                    _dialog.ShowDialog( this );
                    SetFormIcon( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [start date selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnStartDateSelected( object sender, EventArgs e )
        {
            try
            {
                FirstCalendarTable.CaptionText = string.Empty;
                FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar?.SelectedDate}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [end date selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnEndDateSelected( object sender, EventArgs e )
        {
            try
            {
                SecondCalendarTable.CaptionText = string.Empty;
                SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar?.SelectedDate}";
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
        private void OnRefreshDataButtonClick( object sender, EventArgs e )
        {
            try
            {
                ClearData( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [RadioButton checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnRadioButtonChecked( object sender )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _name = _button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _name ) )
                    {
                        _provider = (Provider)Enum.Parse( typeof( Provider ), _name );
                        SetFormIcon( );
                    }
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
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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