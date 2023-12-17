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

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.EditBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public partial class LookupWindow : EditBase
    {
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

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
        /// Initializes a new instance of the
        /// <see cref="LookupWindow"/> class.
        /// </summary>
        /// <inheritdoc />
        public LookupWindow( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks();

            // Basic Properties
            Size = new Size( 1349, 730 );
            MaximumSize = new Size( 1349, 730 );
            MinimumSize = new Size( 1349, 730 );
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
                SqliteRadioButton.Tag = nameof( SQLite );
                SqlServerRadioButton.Tag = nameof( SqlServer );
                AccessRadioButton.Tag = nameof( Access );
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
        private void RegisterCallbacks()
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
                SelectedTable = string.Empty;
                BindingSource.DataSource = null;
                DataModel = null;
                DataTable = null;
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
                if( Filter?.Any( ) == true )
                {
                    Filter.Clear( );
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                ThirdCategory = string.Empty;
                ThirdValue = string.Empty;
                SecondCategory = string.Empty;
                SecondValue = string.Empty;
                FirstCategory = string.Empty;
                FirstValue = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the ListBox items.
        /// </summary>
        private void ClearListBoxes( )
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                RegisterCallbacks();
                InitializeTabControl( );
                InitializeLabels( );
                InitializeButtons( );
                DataArgs = new DataArgs( );
                Fields = new List<string>( );
                Columns = new List<string>( );
                Dates = new List<DateTime>( );
                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, Filter );
                BindingSource.DataSource = DataModel.DataTable;
                PopulateTableListBoxItems( );
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
                ClearListBoxes( );
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