// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 07-17-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-17-2023
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
//    Contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov

// </copyright>
// <summary>
//   SqlEditor.cs
// </summary>
// ******************************************************************************************

// </copyright>
// <summary>
//   SqlEditor.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Edit;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using CheckState = MetroSet_UI.Enums.CheckState;

    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
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
        /// Gets or sets the frames.
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        public IEnumerable<Frame> Frames { get; set; }

        /// <summary>
        /// Gets or sets the database directory.
        /// </summary>
        /// <value>
        /// The database directory.
        /// </value>
        public string DatabaseDirectory { get; set; }

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

            // Basic Properties
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
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
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );

            // Event Wiring
            AccessRadioButton.Click += OnRadioButtonChecked;
            SQLiteRadioButton.Click += OnRadioButtonChecked;
            SqlCeRadioButton.Click += OnRadioButtonChecked;
            SqlServerRadioButton.Click += OnRadioButtonChecked;
            SqlComboBox.SelectedValueChanged += OnComboBoxItemSelected;
            SqlListBox.SelectedValueChanged += OnListBoxItemSelected;
            ClearButton.Click += OnClearButtonClick;
            CloseButton.Click += OnCloseButtonClick;
            Load += OnLoad;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                AccessRadioButton.Checked = true;
                Commands = new List<string>( );
                Statements = new Dictionary<string, object>( );
                SetEditorConfiguration( );
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
                Editor.Text = string.Empty;
                Commands?.Clear( );
                Statements?.Clear( );
                Provider = Provider.Access;
                AccessRadioButton.CheckState = CheckState.Checked;
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
                        Commands.Clear( );
                        switch( _provider )
                        {
                            case Provider.Access:
                            {
                                Provider = Provider.Access;
                                AccessRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SQLite:
                            {
                                Provider = Provider.SQLite;
                                SQLiteRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SqlCe:
                            {
                                Provider = Provider.SqlCe;
                                SqlCeRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            case Provider.SqlServer:
                            {
                                Provider = Provider.SqlServer;
                                SqlServerRadioButton.CheckState = CheckState.Checked;
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
                                break;
                            }
                            default:
                            {
                                Provider = Provider.Access;
                                SetProvider( Provider.ToString( ) );
                                Commands = CreateCommandList( Provider );
                                PopulateSqlComboBox( Commands );
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
                    SqlComboBox.Items.Clear( );
                    SqlListBox.Items.Clear( );
                    for( var _i = 0; _i < list.Count; _i++ )
                    {
                        if( _commands.Contains( list[ _i ] )
                           && list[ _i ].Equals( $"{SQL.CREATEDATABASE}" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE DATABASE" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.CREATETABLE}" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE TABLE" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.ALTERTABLE}" ) )
                        {
                            SqlComboBox.Items.Add( "ALTER TABLE" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.CREATEVIEW}" ) )
                        {
                            SqlComboBox.Items.Add( "CREATE VIEW" );
                        }
                        else if( _commands.Contains( list[ _i ] )
                                && list[ _i ].Equals( $"{SQL.SELECTALL}" ) )
                        {
                            SqlComboBox.Items.Add( "SELECT ALL" );
                        }
                        else if( _commands.Contains( list[ _i ] ) )
                        {
                            SqlComboBox.Items.Add( list[ _i ] );
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
                    var _path = DatabaseDirectory + @$"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
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
                    var _path = DatabaseDirectory + @$"\{provider}\DataModels\";
                    var _names = Directory.GetDirectories( _path );
                    var _list = new List<string>( );
                    for( var _i = 0; _i < _names.Length; _i++ )
                    {
                        var _folder = Directory.CreateDirectory( _names[ _i ] ).Name;
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
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the editor configuration.
        /// </summary>
        private void SetEditorConfiguration( )
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
        /// Called when [ComboBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnComboBoxItemSelected( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    SelectedCommand = string.Empty;
                    var _selection = _comboBox.SelectedItem?.ToString( );
                    SqlListBox.Items.Clear( );
                    if( _selection?.Contains( " " ) == true )
                    {
                        SelectedCommand = _selection.Replace( " ", "" );
                        var _path = DatabaseDirectory
                            + @$"\{Provider}\DataModels\{SelectedCommand}";

                        var _files = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _files.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _files[ _i ] );
                            var _caption = _item?.SplitPascal( );
                            SqlListBox.Items.Add( _caption );
                        }
                    }
                    else
                    {
                        SelectedCommand = _comboBox.SelectedItem?.ToString( );
                        var _path = DatabaseDirectory
                            + @$"\{Provider}\DataModels\{SelectedCommand}";

                        var _names = Directory.GetFiles( _path );
                        for( var _i = 0; _i < _names.Length; _i++ )
                        {
                            var _item = Path.GetFileNameWithoutExtension( _names[ _i ] );
                            var _caption = _item?.SplitPascal( );
                            SqlListBox.Items.Add( _caption );
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
                        var _filePath = DatabaseDirectory
                            + @$"\{Provider}\DataModels\{_command}\{_query}.sql";

                        var _stream = File.OpenRead( _filePath );
                        var _reader = new StreamReader( _stream );
                        var _text = _reader.ReadToEnd( );
                        Editor.Text = _text;
                    }
                    else
                    {
                        var _path = DatabaseDirectory
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClearButtonClick( object sender, EventArgs e )
        {
            try
            {
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
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
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
                Program.Windows[ "SqlEditor" ] = this;
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
            Close( );
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
    }
}