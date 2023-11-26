//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                LookupDialog.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="LookupDialog.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    LookupDialog.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public partial class LookupDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the table prefix.
        /// </summary>
        /// <value>
        /// The table prefix.
        /// </value>
        public string TablePrefix { get; set; } = " Tables : ";

        /// <summary>
        /// Gets or sets the column prefix.
        /// </summary>
        /// <value>
        /// The column prefix.
        /// </value>
        public string ColumnPrefix { get; set; } = " Columns : ";

        /// <summary>
        /// Gets or sets the value prefix.
        /// </summary>
        /// <value>
        /// The value prefix.
        /// </value>
        public string ValuePrefix { get; set; } = " Values : ";

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

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
        /// Initializes a new instance of the
        /// <see cref="LookupDialog"/> class.
        /// </summary>
        /// <inheritdoc />
        public LookupDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1340, 674 );
            MaximumSize = new Size( 1340, 674 );
            MinimumSize = new Size( 1340, 674 );
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Panels = GetPanels( );
            RadioButtons = GetRadioButtons( );

            // Wire Events
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes the tab control.
        /// </summary>
        private void InitializeTabControl( )
        {
            try
            {
                TabControl.TabPanelBackColor = Color.FromArgb( 20, 20, 20 );
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
                SelectButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                CloseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                RefreshButton.ForeColor = Color.FromArgb( 106, 189, 252 );

                // Radio Buttons
                SqliteRadioButton.Tag = "SQLite";
                SqlServerRadioButton.Tag = "SqlServer";
                AccessRadioButton.Tag = "Access";
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
                SourceTable.CaptionText = TablePrefix + TableListBox.Items.Count;
                ColumnTable.CaptionText = ColumnPrefix;
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
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void InitializeCallbacks( )
        {
            try
            {
                CloseButton.Click += OnCloseButtonClicked;
                TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
                ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
                SelectButton.Click += OnSelectButtonClick;
                CloseButton.Click += OnCloseButtonClicked;
                RefreshButton.Click += OnClearButtonClick;
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
                Filter?.Clear( );
                DataArgs = null;
                DataTable = null;
                BindingSource.DataSource = null;
                Fields?.Clear( );
                Numerics?.Clear( );
                Columns?.Clear( );
                Dates?.Clear( );
                SelectedFields?.Clear( );
                SelectedColumns?.Clear( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _names = _model.GetData( )
                    ?.Select( r => r.Field<string>( "TableName" ) )
                    ?.Distinct( )
                    ?.ToList( );

                for( var _i = 0; _i < ( _names?.Count - 1 ); _i++ )
                {
                    var _name = _names[ _i ];
                    TableListBox.Items?.Add( _name );
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
                DataArgs.Filter = Filter;
                DataArgs.SelectedTable = TableName;
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
        /// Clears the collections.
        /// </summary>
        private void ClearCollections( )
        {
            try
            {
                if( Filter?.Any( ) == true )
                {
                    Filter.Clear( );
                }

                if( Columns?.Any( ) == true )
                {
                    Columns.Clear( );
                }

                if( Fields?.Any( ) == true )
                {
                    Fields.Clear( );
                }

                if( Numerics?.Any( ) == true )
                {
                    Numerics.Clear( );
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
                SelectedColumns?.Clear( );
                SelectedFields?.Clear( );
                SelectedNumerics?.Clear( );
                Filter?.Clear( );
                TableName = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the ListBox items.
        /// </summary>
        private void ClearListBoxItems( )
        {
            try
            {
                TableListBox?.Clear( );
                ColumnListBox?.Clear( );
                Filter?.Clear( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <returns>
        /// </returns>
        private IDictionary<string, TabPageAdv> GetTabPages( )
        {
            if( TabControl.TabPages?.Count > 0 )
            {
                try
                {
                    var _tabPages = new Dictionary<string, TabPageAdv>( );
                    foreach( var _control in GetControls( ) )
                    {
                        if( _control.GetType( ) == typeof( TabPageAdv ) )
                        {
                            _tabPages.Add( _control.Name, _control as TabPageAdv );
                        }
                    }

                    return _tabPages?.Any( ) == true
                        ? _tabPages
                        : default( IDictionary<string, TabPageAdv> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IDictionary<string, TabPageAdv> );
                }
            }

            return default( IDictionary<string, TabPageAdv> );
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        private IDictionary<string, RadioButton> GetRadioButtons( )
        {
            try
            {
                var _buttons = new Dictionary<string, RadioButton>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( RadioButton ) )
                    {
                        _buttons.Add( _control.Name, _control as RadioButton );
                    }
                }

                return _buttons?.Any( ) == true
                    ? _buttons
                    : default( IDictionary<string, RadioButton> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, RadioButton> );
            }
        }

        /// <summary>
        /// Gets the combo boxes.
        /// </summary>
        /// <returns></returns>
        private IDictionary<string, ComboBox> GetComboBoxes( )
        {
            try
            {
                var _comboBoxes = new Dictionary<string, ComboBox>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( ComboBox ) )
                    {
                        _comboBoxes.Add( _control.Name, _control as ComboBox );
                    }
                }

                return _comboBoxes?.Any( ) == true
                    ? _comboBoxes
                    : default( IDictionary<string, ComboBox> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, ComboBox> );
            }
        }

        /// <summary>
        /// Gets the panels.
        /// </summary>
        /// <returns></returns>
        private IDictionary<string, Layout> GetPanels( )
        {
            try
            {
                var _panels = new Dictionary<string, Layout>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( Layout ) )
                    {
                        _panels.Add( _control.Name, _control as Layout );
                    }
                }

                return _panels?.Any( ) == true
                    ? _panels
                    : default( IDictionary<string, Layout> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, Layout> );
            }
        }

        /// <summary>
        /// Gets the list boxes.
        /// </summary>
        /// <returns></returns>
        private IDictionary<string, ListBox> GetListBoxes( )
        {
            try
            {
                var _listBoxes = new Dictionary<string, ListBox>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control is ListBox _listBox )
                    {
                        _listBoxes.Add( _listBox.Name, _listBox );
                    }
                }

                return _listBoxes?.Any( ) == true
                    ? _listBoxes
                    : default( IDictionary<string, ListBox> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, ListBox> );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                DataArgs = new DataArgs( );
                Fields = new List<string>( );
                Columns = new List<string>( );
                Dates = new List<DateTime>( );
                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, Filter );
                BindingSource.DataSource = DataModel.DataTable;
                PopulateTableListBoxItems( );
                InitializeTabControl( );
                InitializeLabels( );
                InitializeCallbacks( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnTableListBoxSelectionChanged( object sender )
        {
            try
            {
                Filter.Clear( );
                ColumnListBox.Items?.Clear( );
                ValueListBox.Items?.Clear( );
                ColumnTable.CaptionText = string.Empty;
                ValueTable.CaptionText = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    var _columns = DataModel.DataColumns;
                    foreach( var _col in _columns )
                    {
                        ColumnListBox.Items?.Add( _col.ColumnName );
                    }

                    ColumnTable.CaptionText = ColumnPrefix + ColumnListBox.Items?.Count;
                    ValueTable.CaptionText = ValuePrefix;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnColumnListBoxSelectionChanged( object sender )
        {
            try
            {
                ValueListBox.Items?.Clear( );
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = DataModel.DataElements;
                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var _item in _series[ _column ] )
                    {
                        ValueListBox.Items?.Add( _item );
                    }
                }

                ValueTable.CaptionText = ValuePrefix + ValueListBox.Items?.Count;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
            try
            {
                ClearSelections( );
                ClearListBoxItems( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
            try
            {
                DataArgs.Provider = Provider;
                DataArgs.Source = Source;
                DataArgs.Filter = Filter;
                DataArgs.SelectedTable = TableName;
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
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnCloseButtonClicked( object sender, EventArgs e )
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
    }
}