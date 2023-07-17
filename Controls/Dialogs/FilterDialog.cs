// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="FilterDialog.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FilterDialog.cs
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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBoolCompare" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public partial class FilterDialog : MetroForm
    {
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
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

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
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

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
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public ToolType ToolType { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FilterDialog" /> class.
        /// </summary>
        public FilterDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 20, 20, 20 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            Size = new Size( 1340, 674 );

            // Header Label Properties
            SourceHeader.ForeColor = Color.FromArgb( 0, 120, 212 );
            FilterHeader.ForeColor = Color.FromArgb( 0, 120, 212 );
            GroupHeader.ForeColor = Color.FromArgb( 0, 120, 212 );

            // Event Wiring
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
            Load += OnLoad;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.FilterDialog" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public FilterDialog( Source source, Provider provider = Provider.Access )
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
        /// Initializes a new instance of the <see cref="FilterDialog"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public FilterDialog( BindingSource bindingSource )
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
        /// Populates the second ComboBox items.
        /// </summary>
        public void PopulateSecondComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue ) )
                    {
                        foreach( var _item in Fields )
                        {
                            if( !_item.Equals( FirstCategory ) )
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
        public void PopulateThirdComboBoxItems( )
        {
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue )
                       && !string.IsNullOrEmpty( SecondValue ) )
                    {
                        ThirdComboBox.Items.Clear( );
                        foreach( var _item in Fields )
                        {
                            if( !_item.Equals( FirstCategory )
                               && !_item.Equals( SecondCategory ) )
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
            if( Fields?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( FirstValue )
                       && !string.IsNullOrEmpty( SecondValue )
                       && !string.IsNullOrEmpty( ThirdValue ) )
                    {
                        FourthComboBox.Items.Clear( );
                        foreach( var _item in Fields )
                        {
                            if( !_item.Equals( FirstCategory )
                               && !_item.Equals( SecondCategory )
                               && !_item.Equals( ThirdCategory ) )
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
            if( Fields?.Any( ) == true )
            {
                try
                {
                    foreach( var _item in Fields )
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
                TableListBox.Items.Clear( );
                ReferenceListBox.Items.Clear( );
                MaintenanceListBox.Items.Clear( );
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "EXECUTION" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[ _i ];
                    TableListBox.Items.Add( _name );
                }

                var _references = _data
                    ?.Where( r => r.Field<string>( "Model" ).Equals( "REFERENCE" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _references?.Count - 1; _i++ )
                {
                    var _name = _references[ _i ];
                    ReferenceListBox.Items.Add( _name );
                }

                var _mx = _data?.Where( r => r.Field<string>( "Model" ).Equals( "MAINTENANCE" ) )
                    ?.Select( r => r.Field<string>( "Title" ) )
                    ?.ToList( );

                for( var _i = 0; _i < _mx?.Count - 1; _i++ )
                {
                    var _name = _mx[ _i ];
                    MaintenanceListBox.Items.Add( _name );
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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SqlQuery = string.Empty;
                FormFilter = new Dictionary<string, object>( );
                SelectedColumns = new List<string>( );
                SelectedFields = new List<string>( );
                SelectedNumerics = new List<string>( );
                if( SelectedTable != null )
                {
                    ClearButton.Visible = !ClearButton.Visible;
                    GroupButton.Visible = !GroupButton.Visible;
                    SelectButton.Visible = !SelectButton.Visible;
                    TabControl.SelectedTab = FilterTabPage;
                    FilterTabPage.TabVisible = true;
                    TableTabPage.TabVisible = false;
                    Provider = DataModel.Provider;
                    Source = DataModel.Source;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
                    PopulateFirstComboBoxItems( );
                }
                else
                {
                    ClearButton.Visible = !ClearButton.Visible;
                    GroupButton.Visible = !GroupButton.Visible;
                    SelectButton.Visible = !SelectButton.Visible;
                    TabControl.SelectedTab = TableTabPage;
                    TableTabPage.TabVisible = true;
                    FilterTabPage.TabVisible = false;
                    CalendarTabPage.TabVisible = false;
                    PopulateTableListBoxItems( );
                    AccessRadioButton.Checked = true;
                    Provider = Provider.Access;
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
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SelectedTable = _listBox.SelectedValue?.ToString( );
                    if( !string.IsNullOrEmpty( SelectedTable ) )
                    {
                        var _source = SelectedTable.Replace( " ", "" );
                        BindingSource.DataSource = null;
                        Source = (Source)Enum.Parse( typeof( Source ), _source );
                        DataModel = new DataBuilder( Source, Provider );
                        DataTable = DataModel.DataTable;
                        BindingSource.DataSource = DataModel.DataTable;
                        Fields = DataModel.Fields;
                        Numerics = DataModel.Numerics;
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
                        FirstListBox.Items.Clear( );
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
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FirstValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
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
                        SecondListBox.Items.Clear( );
                    }

                    var _filter = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        SecondCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var _item in _data )
                        {
                            SecondListBox.Items.Add( _item );
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
                    if( FormFilter.Keys?.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    SecondValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
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
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    var _filter = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        ThirdListBox.Items.Clear( );
                        ThirdCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var _item in _data )
                        {
                            ThirdListBox.Items.Add( _item );
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
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    ThirdValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    SqlQuery = $"SELECT * FROM {Source} " 
                        + $"WHERE {FormFilter.ToCriteria( )};";

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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFourthComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SqlQuery = string.Empty;
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    var _filter = _comboBox.SelectedItem?.ToString( );
                    if( !string.IsNullOrEmpty( _filter ) )
                    {
                        FourthListBox.Items.Clear( );
                        FourthCategory = _filter;
                        var _data = DataModel.DataElements[ _filter ];
                        foreach( var _item in _data )
                        {
                            FourthListBox.Items.Add( _item );
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
                    if( FormFilter.Keys.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    FourthValue = _listBox.SelectedValue?.ToString( );
                    FormFilter.Add( FirstCategory, FirstValue );
                    FormFilter.Add( SecondCategory, SecondValue );
                    FormFilter.Add( ThirdCategory, ThirdValue );
                    FormFilter.Add( FourthCategory, FourthValue );
                    SqlQuery = $"SELECT * FROM {Source} " 
                        + $"WHERE {FormFilter.ToCriteria( )};";
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
        /// <param name="e">The
        /// <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClearButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    if( FormFilter?.Any( ) == true )
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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    SqlQuery = GetSqlText( SelectedFields, SelectedNumerics, FormFilter );
                    SqlTextBox.Text = SqlQuery;
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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
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
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button )
            {
                try
                {
                    ClearSelections( );
                    BindingSource.DataSource = null;
                    DataTable = null;
                    DataModel = null;
                    if( ( Owner != null )
                       && ( Owner.Visible == false ) )
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
        /// Initializes the radio buttons.
        /// </summary>
        private void InitRadioButtons( )
        {
            try
            {
                SQLiteRadioButton.Tag = "SQLite";
                SQLiteRadioButton.HoverText = "SQLite Provider";
                AccessRadioButton.Tag = "Access";
                AccessRadioButton.HoverText = "MS Access Provider";
                AccessRadioButton.Checked = true;
                SqlCeRadioButton.Tag = "SqlCe";
                SqlCeRadioButton.HoverText = "SQL Compact Provider";
                SqlServerRadioButton.Tag = "SqlServer";
                SqlServerRadioButton.HoverText = "Sql Server Provider";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the RadioButton provider.
        /// </summary>
        /// <returns></returns>
        private Provider GetRadioButtonProvider( )
        {
            try
            {
                if( SQLiteRadioButton.Checked == true )
                {
                    Provider = Provider.SQLite;
                }
                else if( SqlServerRadioButton.Checked == true )
                {
                    Provider = Provider.SqlServer;
                }
                else if( AccessRadioButton.Checked == true )
                {
                    Provider = Provider.Access;
                }
                else if( SqlCeRadioButton.Checked == true )
                {
                    Provider = Provider.SqlCe;
                }
                else
                {
                    Provider = Provider.Access;
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
        /// Sets the provider RadioButton.
        /// </summary>
        /// <param name="provider">The provider.</param>
        private void SetProviderRadioButton( Provider provider )
        {
            try
            {
                switch( provider )
                {
                    case Provider.SQLite:
                    {
                        SQLiteRadioButton.Checked = true;
                        break;
                    }
                    case Provider.SqlServer:
                    {
                        SqlServerRadioButton.Checked = true;
                        break;
                    }
                    case Provider.Access:
                    {
                        AccessRadioButton.Checked = true;
                        break;
                    }
                    case Provider.SqlCe:
                    {
                        SqlCeRadioButton.Checked = true;
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                SqlQuery = string.Empty;
                ClearButton.Visible = !ClearButton.Visible;
                GroupButton.Visible = !GroupButton.Visible;
                SelectButton.Visible = !SelectButton.Visible;
                SelectedTable = string.Empty;
                TabControl.SelectedTab = TableTabPage;
                if( FormFilter.Keys.Count > 0 )
                {
                    FormFilter.Clear( );
                }

                if( !string.IsNullOrEmpty( FourthValue )
                   || FourthTable.Visible )
                {
                    FourthComboBox.Items.Clear( );
                    FourthListBox.Items.Clear( );
                    FourthCategory = string.Empty;
                    FourthValue = string.Empty;
                    ThirdTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( ThirdValue )
                   || ThirdTable.Visible )
                {
                    ThirdComboBox.Items.Clear( );
                    ThirdListBox.Items.Clear( );
                    ThirdCategory = string.Empty;
                    ThirdValue = string.Empty;
                    ThirdTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( SecondValue )
                   || SecondTable.Visible )
                {
                    SecondComboBox.Items.Clear( );
                    SecondListBox.Items.Clear( );
                    SecondCategory = string.Empty;
                    SecondValue = string.Empty;
                    SecondTable.Visible = false;
                }

                if( !string.IsNullOrEmpty( FirstValue )
                   || FirstTable.Visible )
                {
                    FirstComboBox.Items.Clear( );
                    FirstListBox.Items.Clear( );
                    FirstCategory = string.Empty;
                    FirstValue = string.Empty;
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
                    return $"SELECT * FROM {Source}" + $" WHERE {where.ToCriteria( )}";
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
        /// Gets the SQL text.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string GetSqlText( IEnumerable<string> fields, IEnumerable<string> numerics, 
            IDictionary<string, object> where )
        {
            if( ( where?.Any( ) == true )
               && ( fields?.Any( ) == true )
               && ( numerics?.Any( ) == true ) )
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
                    return $"SELECT {_columns} FROM {Source} " 
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
        /// Gets the SQL text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string GetSqlText( IEnumerable<string> columns, 
            IDictionary<string, object> where )
        {
            if( ( where?.Any( ) == true )
               && ( columns?.Any( ) == true )
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
                    return $"SELECT {_names} FROM {SelectedTable} " 
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
                        NumericListBox.Items.Clear( );
                    }

                    for( var _i = 0; _i < Numerics.Count; _i++ )
                    {
                        if( !string.IsNullOrEmpty( Numerics[ _i ] ) )
                        {
                            NumericListBox.Items.Add( Numerics[ _i ] );
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
        /// Binds the data.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        private void BindData( Source source, Provider provider, 
            IDictionary<string, object> where )
        {
            if( Enum.IsDefined( typeof( Source ), source )
               && Enum.IsDefined( typeof( Provider ), provider )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    Source = source;
                    Provider = provider;
                    DataModel = new DataBuilder( source, provider, where );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataModel.DataTable;
                    Fields = DataModel.Fields;
                    Numerics = DataModel.Numerics;
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
            if( Enum.IsDefined( typeof( Source ), Source )
               && Enum.IsDefined( typeof( Provider ), Provider )
               && ( where?.Any( ) == true )
               && ( cols?.Any( ) == true ) )
            {
                try
                {
                    var _sql = GetSqlText( cols, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
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
            if( Enum.IsDefined( typeof( Source ), Source )
               && Enum.IsDefined( typeof( Provider ), Provider )
               && ( where?.Any( ) == true )
               && ( fields?.Any( ) == true ) )
            {
                try
                {
                    var _sql = GetSqlText( fields, numerics, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
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
        /// Updates the header text.
        /// </summary>
        private void UpdateHeaderText( )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedTable ) )
                {
                    var _table = SelectedTable?.SplitPascal( ) ?? string.Empty;
                    SourceHeader.Text = $"{Provider} Data Sources ";
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

                SqlQuery = GetSqlText( SelectedColumns, FormFilter );
                SqlTextBox.Text = SqlQuery;
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

                SqlQuery = GetSqlText( SelectedFields, SelectedNumerics, FormFilter );
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
        /// <param name="e">The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
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
               && ( _radio.Tag != null ) )
            {
                try
                {
                    var _tag = _radio.Tag.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        Provider = (Provider)Enum.Parse( typeof( Provider ), _tag );
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