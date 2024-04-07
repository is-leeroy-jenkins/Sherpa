// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 2-25-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-25-2024
// ******************************************************************************************
// <copyright file="SchemaPage.cs" company="Terry D. Eppler">
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
//   SchemaPage.cs
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
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <inheritdoc/>
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.EditBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public partial class SchemaPage : EditBase
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private object _path;

        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private protected Action _statusUpdate;

        /// <summary>
        /// The time
        /// </summary>
        private protected int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private protected int _seconds;

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
        ///  
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _selectedType;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _columnName;

        /// <summary>
        /// Gets or sets the type of the selected.
        /// </summary>
        /// <value>
        /// The type of the selected.
        /// </value>
        public string SelectedType
        {
            get
            {
                return _selectedType;
            }
            private protected set
            {
                _selectedType = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the column.
        /// </summary>
        /// <value>
        /// The name of the column.
        /// </value>
        public string ColumnName
        {
            get
            {
                return _columnName;
            }
            private protected set
            {
                _columnName = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SchemaLayout"/>
        /// class.
        /// </summary>
        public SchemaPage( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
            Size = new Size( 1330, 638 );
            MaximumSize = new Size( 1340, 648 );
            MinimumSize = new Size( 1320, 628 );
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
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ControlBox = false;

            // Populate Controls
            _tabPages = GetTabPages( );
            _panels = GetPanels( );
            _listBoxes = GetListBoxes( );
            _radioButtons = GetRadioButtons( );
            _comboBoxes = GetComboBoxes( );

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Default Provider
            _provider = Provider.Access;

            // Budget Attributes
            _filter = new Dictionary<string, object>( );
            _fields = new List<string>( );
            _columns = new List<string>( );
            _numerics = new List<string>( );
            _selectedColumns = new List<string>( );
            _selectedFields = new List<string>( );
            _selectedNumerics = new List<string>( );
            _dataArgs = new DataArgs( );

            // Wire Events
            Load += OnLoad;
            Activated += OnActivated;
            FormClosing += OnFormClosing;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SchemaLayout"/>
        /// class.
        /// </summary>
        /// <param name="tool"> Type of the tool. </param>
        public SchemaPage( ToolType tool )
            : this( )
        {
            _toolType = tool;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SchemaLayout"/>
        /// class.
        ///
        /// 
        /// </summary>
        /// <param name="tool"> Type of the tool. </param>
        /// <param name="bindingSource"> The binding source. </param>
        public SchemaPage( ToolType tool, BindingSource bindingSource )
            : this( tool )
        {
            _dataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = _dataTable;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                AccessRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlServerRadioButton.CheckedChanged += OnRadioButtonChecked;
                SQLiteRadioButton.CheckedChanged += OnRadioButtonChecked;
                SqlCeRadioButton.CheckedChanged += OnRadioButtonChecked;
                CloseButton.Click += OnCloseButtonClick;
                DataTab.MouseClick += OnRightClick;
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
                DataTab.TabFont = new Font( "Roboto", 8, FontStyle.Regular );
                DataTab.TabForeColor = Color.FromArgb( 106, 189, 252 );
                TabControl.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the text boxes.
        /// </summary>
        private void InitializeTextBoxes( )
        {
            try
            {
                TableNameTextBox.Font = new Font( "Roboto", 8, FontStyle.Regular );
                TableNameTextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                // Command Buttons
                var _lightBlue = Color.FromArgb( 106, 189, 252 );
                DeleteColumnButton.ForeColor = _lightBlue;
                AddColumnButton.ForeColor = _lightBlue;
                AddTableButton.ForeColor = _lightBlue;
                DeleteTableButton.ForeColor = _lightBlue;
                SelectButton.ForeColor = _lightBlue;
                CloseButton.ForeColor = _lightBlue;
                ClearButton.ForeColor = _lightBlue;
                CloseButton.Text = "Close";
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
                // Radio Button Properties
                var _lightBlue = Color.FromArgb( 106, 189, 252 );
                SQLiteRadioButton.Tag = "SQLite";
                SQLiteRadioButton.Text = "SQLite";
                SQLiteRadioButton.ForeColor = _lightBlue;
                SQLiteRadioButton.HoverText = "SQLite Provider";
                SQLiteRadioButton.Checked = false;
                AccessRadioButton.Tag = "Access";
                AccessRadioButton.Text = "MS Access";
                AccessRadioButton.ForeColor = _lightBlue;
                AccessRadioButton.HoverText = "MS Access Provider";
                AccessRadioButton.Checked = true;
                SqlCeRadioButton.Tag = "SqlCe";
                SqlCeRadioButton.Text = "SQL Compact";
                SqlCeRadioButton.ForeColor = _lightBlue;
                SqlCeRadioButton.HoverText = "SQL Compact Provider";
                SqlCeRadioButton.Checked = false;
                SqlServerRadioButton.Tag = "SqlServer";
                SqlServerRadioButton.Text = "MS SQL Server";
                SqlServerRadioButton.ForeColor = _lightBlue;
                SqlServerRadioButton.HoverText = "Sql Server Provider";
                SqlServerRadioButton.Checked = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        private void InitializeComboBoxes( )
        {
            try
            {
                DataTypeComboBox.BackgroundColor = Color.FromArgb( 40, 40, 40 );
                TableNameComboBox.BackgroundColor = Color.FromArgb( 40, 40, 40 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
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
        /// Initializes the delegates.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += UpdateLabels;
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
        /// Populates the table ComboBox items.
        /// </summary>
        private void PopulateTableComboBoxItems( )
        {
            try
            {
                TableNameComboBox.Items?.Clear( );
                TableNameComboBox.SelectedItem = string.Empty;
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Where( dr => dr.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[ _i ];
                    TableNameComboBox.Items.Add( _name );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the data type ComboBox items.
        /// </summary>
        public void PopulateDataTypeComboBoxItems( IEnumerable<string> dataTypes )
        {
            try
            {
                ThrowIf.Null( dataTypes, nameof( dataTypes ) );
                DataTypeComboBox.Items?.Clear( );
                DataTypeComboBox.SelectedText = string.Empty;
                var _types = dataTypes.ToArray( );
                for( var _i = 0; _i < _types?.Length; _i++ )
                {
                    if( !string.IsNullOrEmpty( _types[ _i ] ) )
                    {
                        DataTypeComboBox.Items.Add( _types[ _i ] );
                    }
                }
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
            if( Enum.IsDefined( typeof( ToolType ), _toolType ) )
            {
                try
                {
                    switch( _toolType )
                    {
                        case ToolType.DeleteDatabaseButton:
                        case ToolType.DeleteTableButton:
                        case ToolType.DeleteColumnButton:
                        case ToolType.EditColumnButton:
                        case ToolType.AddTableButton:
                        case ToolType.AddDatabaseButton:
                        {
                            ActiveTab = DataTab;
                            break;
                        }
                        default:
                        {
                            ActiveTab = DataTab;
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
        /// Sets the provider.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        private void SetProvider( string provider )
        {
            try
            {
                ThrowIf.Null( provider, nameof( provider ) );
                _provider = (Provider)Enum.Parse( typeof( Provider ), provider );
                switch( _provider )
                {
                    case Provider.Access:
                    {
                        _provider = Provider.Access;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    case Provider.SQLite:
                    {
                        _provider = Provider.SQLite;
                        SQLiteRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        _provider = Provider.SqlCe;
                        SqlCeRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    case Provider.SqlServer:
                    {
                        _provider = Provider.SqlServer;
                        SqlServerRadioButton.CheckState = CheckState.Checked;
                        AccessRadioButton.CheckState = CheckState.Unchecked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        break;
                    }
                    default:
                    {
                        _provider = Provider.Access;
                        AccessRadioButton.CheckState = CheckState.Checked;
                        SqlCeRadioButton.CheckState = CheckState.Unchecked;
                        SQLiteRadioButton.CheckState = CheckState.Unchecked;
                        SqlServerRadioButton.CheckState = CheckState.Unchecked;
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
        /// Clears the controls.
        /// </summary>
        private void ClearControls( )
        {
            try
            {
                TableNameComboBox.Items?.Clear( );
                TableNameTextBox.Text = string.Empty;
                DataTypeComboBox.Items?.Clear( );
                AddColumnTextBox.Text = string.Empty;
                SQLiteRadioButton.CheckState = CheckState.Unchecked;
                AccessRadioButton.CheckState = CheckState.Unchecked;
                SqlCeRadioButton.CheckState = CheckState.Unchecked;
                SqlServerRadioButton.CheckState = CheckState.Unchecked;
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
                _columns?.Clear( );
                _fields?.Clear( );
                _numerics?.Clear( );
                _selectedColumns?.Clear( );
                _selectedFields?.Clear( );
                _selectedNumerics?.Clear( );
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
        /// Updates the labels.
        /// </summary>
        private void UpdateLabels( )
        {
            try
            {
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
                Opacity = 0;
                InitializeRadioButtons( );
                InitializeButtons( );
                InitializeTabControl( );
                InitializeComboBoxes( );
                RegisterCallbacks( );
                PopulateTableComboBoxItems( );
                _dataTypes = GetDataTypes( _provider );
                PopulateDataTypeComboBoxItems( _dataTypes );
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [RadioButton checked].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        private void OnRadioButtonChecked( object sender )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _tag = _button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        SetProvider( _tag );
                        _dataTypes = GetDataTypes( _provider );
                        PopulateDataTypeComboBoxItems( _dataTypes );
                    }
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
        /// i
        /// nstance containing the event data.</param>
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

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
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
    }
}