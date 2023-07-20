﻿// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 07-18-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-20-2023
// ******************************************************************************************
// <copyright file="SqlEditor.cs" company="Terry D. Eppler">
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
//   SqlEditor.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using DocumentFormat.OpenXml.Office.CustomUI;
    using Microsoft.Office.Interop.Access;
    using System;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;
    using Syncfusion.Windows.Forms.Tools;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Control = System.Windows.Forms.Control;

    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" )]
    public partial class SqlEditor : EditBase
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
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        /// <summary>
        /// Gets or sets the database directory.
        /// </summary>
        /// <value>
        /// The database directory.
        /// </value>
        public string DatabaseDirectory { get; set; } = @"Data\Database";

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public string PathPrefix { get; set; } = @"C:\Users\terry\source\repos\BudgetExecution\";

        /// <summary>
        /// Gets or sets the selected command.
        /// </summary>
        /// <value>
        /// The selected command.
        /// </value>
        public string SelectedCommand { get; set; }

        /// <summary>
        /// Gets or sets the selected query.
        /// </summary>
        /// <value>
        /// The selected query.
        /// </value>
        public string SelectedQuery { get; set; }

        /// <summary>
        /// Gets or sets the commands.
        /// </summary>
        /// <value>
        /// The commands.
        /// </value>
        public IList<string> Commands { get; set; }

        /// <summary>
        /// Gets or sets the statements.
        /// </summary>
        /// <value>
        /// The statements.
        /// </value>
        public IDictionary<string, object> Statements { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlEditor"/> class.
        /// </summary>
        /// <inheritdoc />
        public SqlEditor( )
        {
            InitializeComponent( );

            // Form Properties
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            PictureBox.Size = new Size( 40, 20 );
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );

            // Default Provider
            Provider = Provider.Access;

            // Tags
            SQLiteRadioButton.Tag = "SQLite";
            SqlCeRadioButton.Tag = "SqlCe";
            SqlServerRadioButton.Tag = "SqlServer";
            AccessRadioButton.Tag = "Access";

            // Control Event Wiring
            TabControl.SelectedIndexChanged += OnActiveTabChanged;
            AccessRadioButton.Click += OnRadioButtonChecked;
            SQLiteRadioButton.Click += OnRadioButtonChecked;
            SqlCeRadioButton.Click += OnRadioButtonChecked;
            SqlServerRadioButton.Click += OnRadioButtonChecked;
            CommandComboBox.SelectedValueChanged += OnComboBoxItemSelected;
            QueryListBox.SelectedValueChanged += OnListBoxItemSelected;
            RefreshButton.Click += OnRefreshButtonClick;
            SaveButton.Click += OnSaveButtonClick;
            GoButton.Click += OnGoButtonClick;
            CloseButton.Click += OnCloseButtonClick;
            EditSqlButton.Click += OnEditSqlButtonClick;
            EditDataButton.Click += OnEditDataButtonClick;
            TableButton.Click += OnTableButtonClick;
            LookupButton.Click += OnLookupButtonClick;
            HomeButton.Click += OnMainMenuButtonClicked;
            TableListBox.SelectedIndexChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedIndexChanged += OnColumnListBoxSelectionChanged;

            // Form Even Wiring
            Load += OnLoad;
            Closing += OnClosing;
            MouseClick += OnRightClick;
            Shown += OnShown;
        }

        /// <summary>
        /// Sets the editor configuration.
        /// </summary>
        private void InitializeEditor( )
        {
            try
            {
                Editor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                Editor.AlwaysShowScrollers = true;
                Editor.BackColor = SystemColors.ControlLight;
                Editor.ForeColor = Color.Black;
                Editor.BackgroundColor = new BrushInfo( SystemColors.ControlLight );
                Editor.BorderStyle = BorderStyle.FixedSingle;
                Editor.CanOverrideStyle = true;
                Editor.CanApplyTheme = true;
                Editor.ColumnGuidesMeasuringFont = new Font( "Roboto", 8 );
                Editor.ContextChoiceFont = new Font( "Roboto", 8 );
                Editor.ContextChoiceForeColor = Color.Black;
                Editor.ContextChoiceBackColor = SystemColors.ControlLight;
                Editor.ContextPromptBorderColor = Color.FromArgb( 0, 120, 212 );
                Editor.ContextPromptBackgroundBrush =
                    new BrushInfo( Color.FromArgb( 233, 166, 50 ) );

                Editor.ContextTooltipBackgroundBrush =
                    new BrushInfo( Color.FromArgb( 233, 166, 50 ) );

                Editor.ContextTooltipBorderColor = Color.FromArgb( 0, 120, 212 );
                Editor.EndOfLineBackColor = SystemColors.ControlLight;
                Editor.EndOfLineForeColor = SystemColors.ControlLight;
                Editor.HighlightCurrentLine = true;
                Editor.IndentationBlockBorderColor = Color.FromArgb( 0, 120, 212 );
                Editor.IndentLineColor = Color.FromArgb( 50, 93, 129 );
                Editor.IndicatorMarginBackColor = SystemColors.ControlLight;
                Editor.CurrentLineHighlightColor = Color.FromArgb( 0, 120, 212 );
                Editor.Font = new Font( "Roboto", 12 );
                Editor.LineNumbersColor = Color.Black;
                Editor.LineNumbersFont = new Font( "Roboto", 8, FontStyle.Bold );
                Editor.ScrollVisualStyle = ScrollBarCustomDrawStyles.Office2016;
                Editor.ScrollColorScheme = Office2007ColorScheme.Black;
                Editor.SelectionTextColor = Color.FromArgb( 50, 93, 129 );
                Editor.ShowEndOfLine = false;
                Editor.Style = EditControlStyle.Office2016Black;
                Editor.TabSize = 4;
                Editor.TextAreaWidth = 400;
                Editor.WordWrap = true;
                Editor.WordWrapColumn = 100;
                Editor.Dock = DockStyle.None;
                Editor.Anchor = AnchorStyles.Top
                    | AnchorStyles.Bottom
                    | AnchorStyles.Left
                    | AnchorStyles.Right;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tool strip properties.
        /// </summary>
        private void InitializeToolStrip( )
        {
            try
            {
                ToolStrip.Margin = new Padding( 1, 1, 1, 3 );
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.Office12Mode = true;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ShowCaption = true;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        private void Notify( )
        {
            try
            {
                var _message = "THIS IS NOT IMPLEMENTED!!";
                var _notification = new Notification( _message );
                _notification.Show( );
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
                Commands?.Clear( );
                Statements?.Clear( );
                Provider = Provider.Access;
                AccessRadioButton.Checked = true;
                Commands = CreateCommandList( Provider );
                PopulateSqlComboBox( Commands );
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
        /// Sets the provider.
        /// </summary>
        /// <param name="provider">The provider.</param>
        private void SetProvider( string provider )
        {
            if( !string.IsNullOrEmpty( provider ) )
            {
                try
                {
                    var _provider = (Provider)Enum.Parse( typeof( Provider ), provider );
                    if( Enum.IsDefined( typeof( Provider ), _provider ) )
                    {
                        if( Commands?.Any( ) == true )
                        {
                            Commands.Clear( );
                        }

                        switch( _provider )
                        {
                            case Provider.Access:
                            {
                                Provider = Provider.Access;
                                AccessRadioButton.Checked = true;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                PopulateDataTypeComboBoxItems( );
                                break;
                            }
                            case Provider.SQLite:
                            {
                                Provider = Provider.SQLite;
                                SQLiteRadioButton.Checked = true;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                PopulateDataTypeComboBoxItems( );
                                break;
                            }
                            case Provider.SqlCe:
                            {
                                Provider = Provider.SqlCe;
                                SqlCeRadioButton.Checked = true;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                PopulateDataTypeComboBoxItems( );
                                break;
                            }
                            case Provider.SqlServer:
                            {
                                Provider = Provider.SqlServer;
                                SqlServerRadioButton.Checked = true;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                PopulateDataTypeComboBoxItems( );
                                break;
                            }
                            default:
                            {
                                Provider = Provider.Access;
                                AccessRadioButton.Checked = true;
                                SetProvider( Provider.ToString( ) );
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                PopulateDataTypeComboBoxItems( );
                                break;
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
        /// Sets the active tab controls.
        /// </summary>
        private void SetActiveTab( )
        {
            switch( TabControl.SelectedIndex )
            {
                case 0:
                {
                    SqlTab.TabVisible = true;
                    DataTab.TabVisible = false;
                    LookupTab.TabVisible = false;
                    SchemaTab.TabVisible = false;
                    Title.Text = "SQL Editor";
                    break;
                }
                case 1:
                {
                    DataTab.TabVisible = true;
                    LookupTab.TabVisible = false;
                    SchemaTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    Title.Text = $"{Source.ToString( ).SplitPascal( )} Data Table";
                    break;
                }
                case 2:
                {
                    DataTab.TabVisible = false;
                    LookupTab.TabVisible = true;
                    SchemaTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    PopulateTableListBoxItems( );
                    Title.Text = "Data Look-Up";
                    TableListBox.SelectedValue = string.Empty;
                    ColumnListBox.SelectedValue = string.Empty;
                    ValueListBox.SelectedValue = string.Empty;
                    break;
                }
                case 3:
                {
                    SchemaTab.TabVisible = true;
                    DataTab.TabVisible = false;
                    LookupTab.TabVisible = false;
                    SqlTab.TabVisible = false;
                    PopulateTableComboBoxItems( );
                    DataTypes = GetDataTypes( Provider );
                    PopulateDataTypeComboBoxItems( );
                    Title.Text = "Schema Editor";
                    break;
                }
            }
        }

        /// <summary>
        /// Resets the data.
        /// </summary>
        /// <param name="where">The where.</param>
        private void ResetData( IDictionary<string, object> where )
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
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
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
        /// Resets the data.
        /// </summary>
        /// <param name="cols">The cols.</param>
        /// <param name="where">The where.</param>
        private void ResetData( IEnumerable<string> cols, IDictionary<string, object> where )
        {
            if( ( where?.Any( ) == true )
               && ( cols?.Any( ) == true ) )
            {
                try
                {
                    var _sql = CreateSqlText( cols, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
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
        /// Resets the data.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        private void ResetData( IEnumerable<string> fields, IEnumerable<string> numerics,
            IDictionary<string, object> where )
        {
            if( ( where?.Any( ) == true )
               && ( fields?.Any( ) == true ) )
            {
                try
                {
                    var _sql = CreateSqlText( fields, numerics, where );
                    DataModel = new DataBuilder( Source, Provider, _sql );
                    DataTable = DataModel?.DataTable;
                    SelectedTable = DataTable?.TableName;
                    BindingSource.DataSource = DataTable;
                    DataGrid.DataSource = BindingSource;
                    DataGrid.PascalizeHeaders( );
                    DataGrid.FormatColumns( );
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
        /// Creates the SQL text.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        private string CreateSqlText( IEnumerable<string> fields, IEnumerable<string> numerics,
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
        /// Creates the command list.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private IList<string> CreateCommandList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _path = PathPrefix + DatabaseDirectory + @$"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[_i] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Creates the query list.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private IList<string> CreateQueryList( Provider provider )
        {
            try
            {
                if( Enum.IsDefined( typeof( Provider ), provider ) )
                {
                    var _path = PathPrefix + DatabaseDirectory + @$"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[_i] ).Name;
                        if( !string.IsNullOrEmpty( _folder ) )
                        {
                            _list.Add( _folder );
                        }
                    }

                    return _list?.Count > 0
                        ? _list
                        : default( IList<string> );
                }

                return default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns></returns>
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
                    foreach( Control _control in _collection )
                    {
                        _list.Add( _control );
                        _queue.Enqueue( _control.Controls );
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
        /// Gets the query text.
        /// </summary>
        /// <returns></returns>
        private string GetQueryText( )
        {
            try
            {
                return string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <returns></returns>
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
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false )
                   && ( Owner.GetType( ) == typeof( MainForm ) ) )
                {
                    Owner.Visible = true;
                    Visible = false;
                }
                else if( ( Owner != null )
                        && ( Owner.Visible == false )
                        && ( Owner.GetType( ) != typeof( MainForm ) ) )
                {
                    Owner.Close( );
                    var _mainForm = (MainForm)Program.Windows["MainForm"];
                    _mainForm.Refresh( );
                    _mainForm.Visible = true;
                    ResetData( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Populates the SQL ComboBox.
        /// </summary>
        /// <param name="list">The list.</param>
        private void PopulateSqlComboBox( IList<string> list )
        {
            if( list?.Any( ) == true )
            {
                try
                {
                    var _commands = Enum.GetNames( typeof( SQL ) );
                    CommandComboBox.Items?.Clear( );
                    QueryListBox.Items?.Clear( );
                    for( var _i = 0; _i < list.Count; _i++ )
                    {
                        if( _commands.Contains( list[_i] )
                           && list[_i].Equals( $"{SQL.CREATEDATABASE}" ) )
                        {
                            CommandComboBox.Items.Add( "CREATE DATABASE" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.CREATETABLE}" ) )
                        {
                            CommandComboBox.Items.Add( "CREATE TABLE" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.ALTERTABLE}" ) )
                        {
                            CommandComboBox.Items.Add( "ALTER TABLE" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.CREATEVIEW}" ) )
                        {
                            CommandComboBox.Items.Add( "CREATE VIEW" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.SELECTALL}" ) )
                        {
                            CommandComboBox.Items.Add( "SELECT ALL" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.DELETE}" ) )
                        {
                            CommandComboBox.Items.Add( "DELETE" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.INSERT}" ) )
                        {
                            CommandComboBox.Items.Add( "INSERT" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.UPDATE}" ) )
                        {
                            CommandComboBox.Items.Add( "UPDATE" );
                        }
                        else if( _commands.Contains( list[_i] )
                                && list[_i].Equals( $"{SQL.SELECT}" ) )
                        {
                            CommandComboBox.Items.Add( "SELECT" );
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
        /// Populates the table ComboBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items?.Clear( );
                TableListBox.SelectedItem = string.Empty;
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.Distinct( )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[_i];
                    TableListBox.Items.Add( _name );
                }

                SourceTable.CaptionText = $"Tables: {TableListBox.Items.Count}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the data type ComboBox items.
        /// </summary>
        public void PopulateDataTypeComboBoxItems( )
        {
            if( DataTypes?.Any( ) == true )
            {
                try
                {
                    DataTypeComboBox.Items?.Clear( );
                    DataTypeComboBox.SelectedText = string.Empty;
                    var _types = DataTypes.ToArray( );
                    for( var _i = 0; _i < _types?.Length; _i++ )
                    {
                        if( !string.IsNullOrEmpty( _types[_i] ) )
                        {
                            DataTypeComboBox.Items.Add( _types[_i] );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        public void PopulateTableComboBoxItems( )
        {
            try
            {
                TableNameComboBox.Items?.Clear( );
                TableNameComboBox.SelectedItem = string.Empty;
                var _model = new DataBuilder( Source.ApplicationTables, Provider.Access );
                var _data = _model.GetData( );
                var _names = _data
                    ?.Select( dr => dr.Field<string>( "TableName" ) )
                    ?.Distinct( )
                    ?.ToList( );

                for( var _i = 0; _i < _names?.Count - 1; _i++ )
                {
                    var _name = _names[_i];
                    TableNameComboBox.Items.Add( _name );
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
        public void ResetData( )
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
                TabControl.SelectedIndex = 0;
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
                InitializeEditor( );
                InitializeToolStrip( );
                SetProvider( Provider.ToString( ) );
                Commands = CreateCommandList( Provider );
                TabPages = GetTabPages( );
                Panels = GetPanels( );
                RadioButtons = GetRadioButtons( );
                ListBoxes = GetListBoxes( );
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRadioButtonChecked( object sender, EventArgs e )
        {
            if( sender is RadioButton _button )
            {
                try
                {
                    var _tag = _button.Tag?.ToString( );
                    if( !string.IsNullOrEmpty( _tag ) )
                    {
                        SetProvider( _tag );
                        DataTypes = GetDataTypes( Provider );
                    }

                    _button.Checked = true;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SelectedCommand = string.Empty;
                    var _selection = _comboBox.SelectedItem?.ToString( );
                    QueryListBox.Items?.Clear( );
                    if( _selection?.Contains( " " ) == true )
                    {
                        SelectedCommand = _selection.Replace( " ", "" );
                        var _path = PathPrefix
                            + DatabaseDirectory
                            + @$"\{Provider}\DataModels\{SelectedCommand}";

                        var _files = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _files.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _files[_i] );
                            var _caption = _item?.SplitPascal( );
                            QueryListBox.Items.Add( _caption );
                        }
                    }
                    else
                    {
                        SelectedCommand = _comboBox.SelectedItem?.ToString( );
                        var _path = PathPrefix
                            + DatabaseDirectory
                            + @$"\{Provider}\DataModels\{SelectedCommand}";

                        var _names = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _names.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _names[_i] );
                            var _caption = _item?.SplitPascal( );
                            QueryListBox.Items.Add( _caption );
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
        /// Called when [ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    Editor.Text = string.Empty;
                    SelectedQuery = _listBox.SelectedItem?.ToString( );
                    if( ( SelectedQuery?.Contains( " " ) == true )
                       || ( SelectedCommand?.Contains( " " ) == true ) )
                    {
                        var _command = SelectedCommand?.Replace( " ", "" );
                        var _query = SelectedQuery?.Replace( " ", "" );
                        var _filePath = PathPrefix
                            + DatabaseDirectory
                            + @$"\{Provider}\DataModels\{_command}\{_query}.sql";

                        var _stream = File.OpenRead( _filePath );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                    else
                    {
                        var _path = PathPrefix
                            + DatabaseDirectory
                            + @$"\{Provider}\DataModels\{SelectedCommand}\{SelectedQuery}.sql";

                        var _stream = File.OpenRead( _path );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
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
        private void OnRefreshButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
                ClearSelections( );
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
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                Program.Windows["SqlEditor"] = this;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnClosing( object sender, EventArgs e )
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
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="System.EventArgs"/>
        /// instance containing the event data.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Called when [form closed].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnFormClosed( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "SqlEditor" ) )
                {
                    Program.Windows.Remove( "SqlEditor" );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [data source button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnEditSqlButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [data source button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnEditDataButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 3;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [lookup button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLookupButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 2;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [execute button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnGoButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        private void OnTableButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 1;
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
                SetActiveTab( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [save button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSaveButtonClick( object sender, EventArgs e )
        {
            Notify( );
        }

        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnTableListBoxSelectionChanged( object sender )
        {
            try
            {
                FormFilter?.Clear( );
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
                    var _columns = DataModel.GetDataColumns( );
                    foreach( var _col in _columns )
                    {
                        ColumnListBox.Items.Add( _col.ColumnName );
                    }

                    ColumnTable.CaptionText = $"Columns:  {ColumnListBox.Items.Count}";
                    ValueTable.CaptionText = "Values:  ";
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
                    foreach( var _item in _series[_column] )
                    {
                        ValueListBox.Items.Add( _item );
                    }
                }

                ValueTable.CaptionText = $"Values: {ValueListBox.Items.Count}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        private void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}