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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using Action = System.Action;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public partial class DataViewForm : MetroForm
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
            get
            {
                return _busy;
            }
            private set
            {
                _busy = value;
            }
        }

        public DataViewForm( )
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
        }

        /// <summary>
        /// Invokes if needed.
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
                SelectedTable = string.Empty;
                DataGrid.DataSource = null;
                BindingSource.DataSource = null;
                DataModel = null;
                DataTable = null;
                UpdateLabelText( );
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
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
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
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks()
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
                ExitButton.Click += OnExitButtonClicked;
                MenuButton.Click += OnMainMenuButtonClicked;
                RemoveFiltersButton.Click += OnRemoveFilterButtonClicked;
                RefreshDataButton.Click += OnRefreshDataButtonClicked;
                GroupButton.Click += OnGroupButtonClicked;
                CalendarButton.Click += OnCalendarButtonClicked;
                FirstCalendar.SelectionChanged += OnStartDateSelected;
                SecondCalendar.SelectionChanged += OnEndDateSelected;
                EditSqlButton.Click += OnSqlButtonClick;
                EditRecordButton.Click += OnEditRecordButtonClicked;
                EditColumnButton.Click += OnEditColumnButtonClicked;
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
            _statusUpdate += UpdateStatusLabel;
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
            if( Fields?.Any( ) == true )
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
            if( Fields?.Any( ) == true )
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

                    if( !string.IsNullOrEmpty( FirstValue ) )
                    {
                        foreach( var _item in Fields )
                        {
                            if( !_item.Equals( FirstCategory ) )
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
            if( Fields?.Any( ) == true )
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

                    if( !string.IsNullOrEmpty( FirstValue )
                       && !string.IsNullOrEmpty( SecondValue ) )
                    {
                        foreach( var _item in Fields )
                        {
                            if( !_item.Equals( FirstCategory )
                               && !_item.Equals( SecondCategory ) )
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
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items?.Clear( );
                    }

                    foreach( var _item in Fields )
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
            if( Numerics?.Any( ) == true )
            {
                try
                {
                    if( NumericListBox.Items.Count > 0 )
                    {
                        NumericListBox.Items?.Clear( );
                    }

                    for( var _i = 0; _i < Numerics.Count; _i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ _i ] ) )
                        {
                            NumericListBox?.Items?.Add( Numerics[ _i ] );
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
                DataArgs.Provider = Provider;
                DataArgs.Source = Source;
                DataArgs.Filter = FormFilter;
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                if( !string.IsNullOrEmpty( ThirdValue )
                   || ThirdTable.Visible )
                {
                    ThirdComboBox.Items?.Clear( );
                    ThirdListBox.Items?.Clear( );
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    ThirdTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( SecondValue )
                   || SecondTable.Visible )
                {
                    SecondComboBox.Items?.Clear( );
                    SecondListBox.Items?.Clear( );
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    SecondTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( FirstValue )
                   || FirstTable.Visible )
                {
                    FirstComboBox.Items?.Clear( );
                    FirstListBox.Items?.Clear( );
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
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
                if( FormFilter?.Any( ) == true )
                {
                    FormFilter.Clear( );
                }

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
        /// Sets the form icon.
        /// </summary>
        private void SetFormIcon( )
        {
            try
            {
                var _path = ConfigurationManager.AppSettings[ "Providers" ];
                if( !string.IsNullOrEmpty( _path ) )
                {
                    var _files = Directory.GetFiles( _path );
                    if( _files?.Any( ) == true )
                    {
                        var _extension = Provider.ToString( );
                        var _file = _files
                            ?.Where( f => f.Contains( _extension ) )
                            ?.First( );

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
        /// Sets the icon.
        /// </summary>
        /// <param name="type">The type.</param>
        private void SetIcon( ToolType type )
        {
            try
            {
                var _path = ConfigurationManager.AppSettings[ "Dialogs" ];
                if( !string.IsNullOrEmpty( _path ) )
                {
                    var _files = Directory.GetFiles( _path );
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
        private void UpdateStatusLabel( )
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
        private void UpdateLabelText( )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    var _table = SelectedTable?.SplitPascal( ) ?? string.Empty;
                    var _records = DataTable.Rows.Count.ToString( "#,###" ) ?? "0";
                    var _fields = Fields?.Count ?? 0;
                    var _numerics = Numerics?.Count ?? 0;
                    var _selectedFields = SelectedFields?.Count ?? 0;
                    var _selectedNumerics = SelectedNumerics?.Count ?? 0;
                    Title.Text = $"{_table} ";
                    FirstGridLabel.Text = $"Data Provider: {Provider}";
                    SecondGridLabel.Text = $"Records: {_records}";
                    ThirdGridLabel.Text = $"Total Fields: {_fields}";
                    FourthGridLabel.Text = $"Total Measures: {_numerics}";
                    FieldsTable.CaptionText = $"Selected Fields: {_selectedFields}";
                    NumericsTable.CaptionText = $"Selected Measures: {_selectedNumerics}";
                    FirstCalendarTable.CaptionText = $"Start Date: {FirstCalendar.SelectedDate}";
                    SecondCalendarTable.CaptionText = $"End Date: {SecondCalendar.SelectedDate}";
                }
                else
                {
                    Title.Text = $"{Provider} Database ";
                    FirstGridLabel.Text = $"Provider:  {Provider}";
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
                FormFilter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                DataArgs = new DataArgs( );
                if( !string.IsNullOrEmpty( SelectedTable ) )
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
                else if( string.IsNullOrEmpty( SelectedTable ) )
                {
                    SelectionTabControl.SelectedIndex = 0;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    GroupTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    TableComboBox.SelectionStart = 0;
                }

                UpdateLabelText( );
                UpdateStatusLabel( );
                FadeIn( );
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
                    FormFilter.Clear( );
                    ToolStrip.Visible = true;
                    var _title = _listBox.SelectedValue?.ToString( );
                    SelectedTable = _title?.Replace( " ", "" );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
                    }

                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataModel.DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    SelectionTabControl.SelectedIndex = 1;
                    UpdateLabelText( );
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
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    FirstListBox.Items?.Clear( );
                    FirstCategory = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( FirstCategory ) )
                    {
                        DataModel = new DataBuilder( Source, Provider );
                        var _data = DataModel.DataElements[ FirstCategory ];
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
                    if( FormFilter.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FirstValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
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

                    BindData( FormFilter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( FormFilter );
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
                    if( FormFilter.Keys?.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    PopulateThirdComboBoxItems( );
                    if( ThirdTable.Visible == false )
                    {
                        ThirdTable.Visible = true;
                    }

                    BindData( FormFilter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( FormFilter );
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
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    if( FieldListBox.Items.Count > 0 )
                    {
                        FieldListBox.Items?.Clear( );
                    }

                    ThirdValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    BindData( FormFilter );
                    UpdateLabelText( );
                    SqlQuery = CreateSqlText( FormFilter );
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
        private void OnTestButtonClicked( object sender, EventArgs e )
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
        private void OnExitButtonClicked( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
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
        /// Called when [remove filter button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRemoveFilterButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    ClearSelections( );
                    ClearCollections( );
                    DataGrid.DataSource = null;
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    SelectionTabControl.SelectedIndex = 1;
                    PopulateFirstComboBoxItems( );
                    UpdateLabelText( );
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
                    SelectedFields.Add( _selectedItem );
                    SelectedColumns.Add( _selectedItem );
                }

                SqlQuery = CreateSqlText( SelectedColumns, FormFilter );
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
                    SelectedNumerics.Add( _selectedItem );
                }

                SqlQuery = CreateSqlText( SelectedFields, SelectedNumerics, FormFilter );
                BindData( SelectedFields, SelectedNumerics, FormFilter );
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
        private void OnGroupButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( FormFilter.Count > 0 )
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
        private void OnCalendarButtonClicked( object sender, EventArgs e )
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
        private void OnEditRecordButtonClicked( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    SetIcon( _button.ToolType );
                    var _dialog = new EditWindow( Source, Provider );
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
        private void OnEditColumnButtonClicked( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    SetIcon( _button.ToolType );
                    var _dialog = new SchemaWindow( _button.ToolType, BindingSource );
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
            if( !string.IsNullOrEmpty( SqlQuery )
               && sender is ToolStripButton _button )
            {
                try
                {
                    SetIcon( _button.ToolType );
                    var _dialog = new SqlWindow( );
                    _dialog.BindingSource = BindingSource;
                    _dialog.Editor.Text = SqlQuery;
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
        private void OnRefreshDataButtonClicked( object sender, EventArgs e )
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
                        Provider = (Provider)Enum.Parse( typeof( Provider ), _name );
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