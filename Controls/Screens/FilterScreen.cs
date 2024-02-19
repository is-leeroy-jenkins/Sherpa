// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 2-13-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-13-2024
// ******************************************************************************************
// <copyright file="FilterScreen.cs" company="Terry D. Eppler">
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
//   FilterScreen.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    public partial class FilterScreen : MetroForm
    {
        private ToolType _toolType;

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
        /// Gets the hover text.
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
        /// Gets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public ToolType ToolType
        {
            get
            {
                return _toolType;
            }
            private set
            {
                _toolType = value;
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
        /// <see cref="T:BudgetExecution.FilterDialog" /> class.
        /// </summary>
        public FilterScreen( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1349, 730 );
            MaximumSize = new Size( 1349, 730 );
            MinimumSize = new Size( 1339, 720 );
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.None;
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
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ControlBox = false;

            // Event Wiring
            Load += OnLoad;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FilterDialog" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public FilterScreen( Source source, Provider provider = Provider.Access )
            : this( )
        {
            Source = source;
            Provider = provider;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            SelectedTable = DataTable.TableName;
            BindingSource.DataSource = DataModel.DataTable;
            Fields = DataModel.Fields;
            Numerics = DataModel.Numerics;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FilterDialog" /> class.
        /// </summary>
        /// <param name="bindingSource">
        /// The binding source.
        /// </param>
        public FilterScreen( BindingSource bindingSource )
            : this( )
        {
            DataTable = (DataTable)bindingSource.DataSource;
            SelectedTable = DataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), SelectedTable );
            Provider = Provider.Access;
            DataModel = new DataBuilder( Source, Provider );
            BindingSource.DataSource = DataModel.DataTable;
            Fields = DataModel.Fields;
            Numerics = DataModel.Numerics;
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                SourceHeader.ForeColor = Color.FromArgb( 106, 189, 252 );
                FilterHeader.ForeColor = Color.FromArgb( 106, 189, 252 );
                GroupHeader.ForeColor = Color.FromArgb( 106, 189, 252 );
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
                SQLiteRadioButton.HoverText = "SQLite Provider";
                AccessRadioButton.Tag = nameof( Access );
                AccessRadioButton.HoverText = "MS Access Provider";
                AccessRadioButton.Checked = true;
                SqlCeRadioButton.Tag = nameof( SqlCe );
                SqlCeRadioButton.HoverText = "SQL Compact Provider";
                SqlServerRadioButton.Tag = nameof( SqlServer );
                SqlServerRadioButton.HoverText = "Sql Server Provider";
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
            try
            {
                TabControl.TabIndexChanged += OnActiveTabChanged;
                TableListBox.SelectedValueChanged += OnTableListBoxItemSelected;
                FirstComboBox.SelectedValueChanged += OnFirstComboBoxItemSelected;
                FirstListBox.SelectedValueChanged += OnFirstListBoxItemSelected;
                SecondComboBox.SelectedValueChanged += OnSecondComboBoxItemSelected;
                SecondListBox.SelectedValueChanged += OnSecondListBoxItemSelected;
                ThirdComboBox.SelectedValueChanged += OnThirdComboBoxItemSelected;
                ThirdListBox.SelectedValueChanged += OnThirdListBoxItemSelected;
                FourthComboBox.SelectedValueChanged += OnFourthComboBoxItemSelected;
                FourthListBox.SelectedValueChanged += OnFourthListBoxItemSelected;
                ClearButton.Click += OnClearButtonClick;
                SelectButton.Click += OnSelectButtonClick;
                GroupButton.Click += OnGroupButtonClick;
                CloseButton.Click += OnCloseButtonClick;
                AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
                SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlCeRadioButton.CheckedChanged += OnRadioButtonChecked;
                NumericListBox.SelectedValueChanged += OnNumericListBoxSelectedValueChanged;
                FieldListBox.SelectedValueChanged += OnFieldListBoxSelectedValueChanged;
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
        /// Binds the data.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        private void BindData( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true )
            {
                try
                {
                    ThrowIf.Null( where, nameof( where ) );
                    BeginInit( );
                    _dataModel = new DataBuilder( _source, _provider, where );
                    _dataTable = _dataModel.DataTable;
                    _fields = _dataModel.Fields;
                    _numerics = _dataModel.Numerics;
                    BindingSource.DataSource = _dataModel.DataTable;
                    EndInit( );
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
            try
            {
                ThrowIf.Null( cols, nameof( cols ) );
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                var _sql = CreateSqlText( cols, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel?.DataTable;
                _selectedTable = _dataTable?.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
                EndInit( );
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
        private void BindData( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( fields, nameof( fields ) );
                ThrowIf.Null( numerics, nameof( numerics ) );
                ThrowIf.Null( where, nameof( where ) );
                BeginInit( );
                var _sql = CreateSqlText( fields, numerics, where );
                _dataModel = new DataBuilder( _source, _provider, _sql );
                _dataTable = _dataModel.DataTable;
                _selectedTable = _dataTable.TableName;
                _fields = _dataModel?.Fields;
                _numerics = _dataModel?.Numerics;
                BindingSource.DataSource = _dataTable;
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
                _sqlQuery = string.Empty;
                ClearButton.Visible = !ClearButton.Visible;
                GroupButton.Visible = !GroupButton.Visible;
                SelectButton.Visible = !SelectButton.Visible;
                _selectedTable = string.Empty;
                TabControl.SelectedTab = TableTabPage;
                if( _filter.Keys.Count > 0 )
                {
                    _filter.Clear( );
                }

                if( !string.IsNullOrEmpty( _fourthValue )
                   || FourthTable.Visible )
                {
                    FourthComboBox.Items?.Clear( );
                    FourthListBox.Items?.Clear( );
                    _fourthCategory = string.Empty;
                    _fourthValue = string.Empty;
                    ThirdTable.Visible = false;
                }

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
                    FirstTable.Visible = true;
                }
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
        /// Creates the SQL text.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                return $"SELECT * FROM {_source}" + $" WHERE {where.ToCriteria( )}";
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
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                ThrowIf.NullOrEmpty( fields, nameof( fields ) );
                ThrowIf.NullOrEmpty( numerics, nameof( numerics ) );
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
                return $"SELECT {_names} FROM {_source} "
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
        /// Creates the SQL text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> columns,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( _selectedTable ) )
            {
                try
                {
                    ThrowIf.Null( where, nameof( where ) );
                    ThrowIf.NullOrEmpty( columns, nameof( columns ) );
                    var _cols = string.Empty;
                    foreach( var _name in columns )
                    {
                        _cols += $"{_name}, ";
                    }

                    var _criteria = where.ToCriteria( );
                    var _names = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT {_names} FROM {_selectedTable} "
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
        /// Populates the second ComboBox items.
        /// </summary>
        private void PopulateSecondComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( _firstValue ) )
                    {
                        foreach( var _item in _fields )
                        {
                            if( !_item.Equals( _firstCategory ) )
                            {
                                SecondComboBox.Items.Add( _item );
                            }
                        }
                    }
                    else
                    {
                        foreach( var _item in Fields )
                        {
                            SecondComboBox.Items.Add( _item );
                        }
                    }

                    SecondComboBox.SelectedIndex = -1;
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
                    if( !string.IsNullOrEmpty( _firstValue )
                       && !string.IsNullOrEmpty( _secondValue ) )
                    {
                        ThirdComboBox.Items?.Clear( );
                        foreach( var _item in _fields )
                        {
                            if( !_item.Equals( _firstCategory )
                               && !_item.Equals( _secondCategory ) )
                            {
                                ThirdComboBox.Items.Add( _item );
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
        /// Populates the fourth ComboBox items.
        /// </summary>
        private void PopulateFourthComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( _firstValue )
                       && !string.IsNullOrEmpty( _secondValue )
                       && !string.IsNullOrEmpty( _thirdValue ) )
                    {
                        FourthComboBox.Items?.Clear( );
                        foreach( var _item in _fields )
                        {
                            if( !_item.Equals( _firstCategory )
                               && !_item.Equals( _secondCategory )
                               && !_item.Equals( _thirdCategory ) )
                            {
                                FourthComboBox.Items.Add( _item );
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
        /// Populates the first ComboBox items.
        /// </summary>
        private void PopulateFirstComboBoxItems( )
        {
            if( _fields?.Any( ) == true )
            {
                try
                {
                    foreach( var _item in _fields )
                    {
                        FirstComboBox.Items.Add( _item );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        private void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                ReferenceListBox.Items?.Clear( );
                MaintenanceListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[ _i ];
                    TableListBox.Items?.Add( _name );
                }

                var _references = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "REFERENCE" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _references?.Count - 1; _i++ )
                {
                    var _name = _references[ _i ];
                    ReferenceListBox.Items?.Add( _name );
                }

                var _mx = _data?.Where( r => r.Field<string>( "Model" ).Equals( "MAINTENANCE" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _mx?.Count - 1; _i++ )
                {
                    var _name = _mx[ _i ];
                    MaintenanceListBox.Items?.Add( _name );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <returns></returns>
        private Provider GetProvider( )
        {
            try
            {
                if( SQLiteRadioButton.Checked == true )
                {
                    _provider = Provider.SQLite;
                }
                else if( SqlServerRadioButton.Checked == true )
                {
                    _provider = Provider.SqlServer;
                }
                else if( AccessRadioButton.Checked == true )
                {
                    _provider = Provider.Access;
                }
                else if( SqlCeRadioButton.Checked == true )
                {
                    _provider = Provider.SqlCe;
                }
                else
                {
                    _provider = Provider.Access;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return Provider.Access;
            }

            return Provider.Access;
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
                        FieldListBox.Items?.Add( _item );
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
                            NumericListBox.Items?.Add( _numerics[ _i ] );
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
        /// Updates the header text.
        /// </summary>
        private void UpdateHeaderText( )
        {
            try
            {
                if( !string.IsNullOrEmpty( _selectedTable ) )
                {
                    var _table = _selectedTable?.SplitPascal( ) ?? string.Empty;
                    SourceHeader.Text = $"{_provider} Data Sources ";
                    FilterHeader.Text = $"Data Filters : {_table}";
                    GroupHeader.Text = $"Aggregate Columns : {_table} ";
                }
                else
                {
                    SourceHeader.Text = "Data Sources";
                    FilterHeader.Text = "Select Filters";
                    GroupHeader.Text = "Aggregate Columns";
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
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                RegisterCallbacks( );
                InitializeRadioButtons( );
                InitializeLabels( );
                _sqlQuery = string.Empty;
                _filter = new Dictionary<string, object>( );
                _selectedColumns = new List<string>( );
                _selectedFields = new List<string>( );
                _selectedNumerics = new List<string>( );
                _dataArgs = new DataArgs( );
                if( _selectedTable != null )
                {
                    TabControl.SelectedTab = FilterTabPage;
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    _provider = _dataModel.Provider;
                    _source = _dataModel.Source;
                    _fields = _dataModel.Fields;
                    _numerics = _dataModel.Numerics;
                    PopulateFirstComboBoxItems( );
                }
                else
                {
                    TabControl.SelectedTab = TableTabPage;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    PopulateTableListBoxItems( );
                    AccessRadioButton.Checked = true;
                    _provider = Provider.Access;
                }
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
                    if( _filter.Keys.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    _selectedTable = _listBox.SelectedValue?.ToString( );
                    if( !string.IsNullOrEmpty( _selectedTable ) )
                    {
                        var _table = SelectedTable.Replace( " ", "" );
                        BindingSource.DataSource = null;
                        _source = (Source)Enum.Parse( typeof( Source ), _table );
                        _dataModel = new DataBuilder( _source, _provider );
                        _dataTable = _dataModel.DataTable;
                        _fields = _dataModel.Fields;
                        _numerics = _dataModel.Numerics;
                        BindingSource.DataSource = _dataModel.DataTable;
                        PopulateFirstComboBoxItems( );
                        TabControl.SelectedIndex = 1;
                    }
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
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    if( FirstListBox.Items?.Count > 0 )
                    {
                        FirstListBox.Items?.Clear( );
                    }

                    var _filter = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FirstCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var _item in _data )
                        {
                            FirstListBox?.Items?.Add( _item );
                        }

                        ClearButton.Visible = true;
                        GroupButton.Visible = true;
                        SelectButton.Visible = true;
                    }
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
                    if( Filter.Keys.Count > 0 )
                    {
                        Filter.Clear( );
                    }

                    FirstValue = _listBox.SelectedValue?.ToString( );
                    Filter.Add( FirstCategory, FirstValue );
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
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    if( SecondListBox.Items.Count > 0 )
                    {
                        SecondListBox.Items?.Clear( );
                    }

                    var _filter = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        SecondCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var _item in _data )
                        {
                            SecondListBox.Items?.Add( _item );
                        }

                        ClearButton.Visible = true;
                        GroupButton.Visible = true;
                        SelectButton.Visible = true;
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
                    if( Filter.Keys?.Count > 0 )
                    {
                        Filter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue?.ToString( );
                    Filter.Add( FirstCategory, FirstValue );
                    Filter.Add( SecondCategory, SecondValue );
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
                    _fourthCategory = string.Empty;
                    _fourthValue = string.Empty;
                    var _selection = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _selection ) )
                    {
                        ThirdListBox.Items?.Clear( );
                        _thirdCategory = _selection;
                        var _data = _dataModel.DataElements[ _selection ];
                        foreach( var _item in _data )
                        {
                            ThirdListBox.Items?.Add( _item );
                        }

                        ClearButton.Visible = true;
                        GroupButton.Visible = true;
                        SelectButton.Visible = true;
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

                    _thirdValue = _listBox.SelectedValue?.ToString( );
                    _filter.Add( _firstCategory, _firstValue );
                    _filter.Add( _secondCategory, _secondValue );
                    _filter.Add( _thirdCategory, _thirdValue );
                    _sqlQuery = $"SELECT * FROM {_selectedFields} " 
                        + $"WHERE {_filter.ToCriteria( )};";

                    PopulateFourthComboBoxItems( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [fourth ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFourthComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    _sqlQuery = string.Empty;
                    _fourthCategory = string.Empty;
                    _fourthValue = string.Empty;
                    var _selection = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _selection ) )
                    {
                        FourthListBox.Items?.Clear( );
                        _fourthCategory = _selection;
                        var _data = _dataModel.DataElements[ _selection ];
                        foreach( var _item in _data )
                        {
                            FourthListBox.Items?.Add( _item );
                        }

                        ClearButton.Visible = true;
                        GroupButton.Visible = true;
                        SelectButton.Visible = true;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [fourth ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnFourthListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    if( _filter.Keys.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    _fourthValue = _listBox.SelectedValue?.ToString( );
                    _filter.Add( _firstCategory, _firstValue );
                    _filter.Add( _secondCategory, _secondValue );
                    _filter.Add( _thirdCategory, _thirdValue );
                    _filter.Add( _fourthCategory, _fourthValue );
                    _sqlQuery = $"SELECT * FROM {_source} " + $"WHERE {_filter.ToCriteria( )};";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [clear button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnClearButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    if( _filter?.Any( ) == true )
                    {
                        ClearSelections( );
                        ClearCollections( );
                        PopulateFirstComboBoxItems( );
                        SqlTextBox.Text = string.Empty;
                        TabControl.SelectedIndex = 1;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [select button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    _sqlQuery = CreateSqlText( _selectedFields, _selectedNumerics, _filter );
                    SqlTextBox.Text = _sqlQuery;
                    CaptureState( );
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [group button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnGroupButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    TabControl.SelectedIndex = 2;
                    PopulateFieldListBox( );
                    PopulateNumericListBox( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    ClearSelections( );
                    BindingSource.DataSource = null;
                    _dataTable = null;
                    _dataModel = null;
                    if( Owner?.Visible == false )
                    {
                        Owner.Visible = true;
                    }

                    Close( );
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

                _sqlQuery = CreateSqlText( _selectedColumns, _filter );
                SqlTextBox.Text = _sqlQuery;
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

                _sqlQuery = CreateSqlText( _selectedFields, _selectedNumerics, _filter );
                SqlTextBox.Text = SqlQuery;
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
                    //ContextMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [RadioButton checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnRadioButtonChecked( object sender )
        {
            if( sender is RadioButton _radio
               && _radio.Tag != null )
            {
                try
                {
                    var _tag = _radio.Tag.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        _provider = (Provider)Enum.Parse( typeof( Provider ), _tag );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                switch( TabControl.SelectedIndex )
                {
                    case 0:
                    {
                        ProviderTable.Visible = true;
                        TableTabPage.TabVisible = true;
                        FilterTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ClearButton.Visible = false;
                        GroupButton.Visible = false;
                        SelectButton.Visible = false;
                        UpdateHeaderText( );
                        break;
                    }
                    case 1:
                    {
                        ProviderTable.Visible = false;
                        FilterTabPage.TabVisible = true;
                        TableTabPage.TabVisible = false;
                        GroupTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ClearButton.Visible = false;
                        GroupButton.Visible = false;
                        SelectButton.Visible = false;
                        UpdateHeaderText( );
                        break;
                    }
                    case 2:
                    {
                        ProviderTable.Visible = false;
                        GroupTabPage.TabVisible = true;
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        CalendarTabPage.TabVisible = false;
                        ClearButton.Visible = true;
                        GroupButton.Visible = true;
                        SelectButton.Visible = true;
                        UpdateHeaderText( );
                        PopulateFieldListBox( );
                        PopulateNumericListBox( );
                        break;
                    }
                    case 3:
                    {
                        ProviderTable.Visible = false;
                        CalendarTabPage.TabVisible = true;
                        GroupTabPage.TabVisible = false;
                        TableTabPage.TabVisible = false;
                        FilterTabPage.TabVisible = false;
                        ClearButton.Visible = true;
                        GroupButton.Visible = true;
                        SelectButton.Visible = true;
                        UpdateHeaderText( );
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