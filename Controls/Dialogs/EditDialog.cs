//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                EditDialog.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="EditDialog.cs" company="Terry D. Eppler">
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
//    EditDialog.cs
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
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.EditBase"/>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public partial class EditDialog : EditBase
    {
        /// <summary> Gets or sets the current. </summary>
        /// <value> The current. </value>
        public DataRow Current { get; set; }

        /// <summary> Gets or sets the frames. </summary>
        /// <value> The frames. </value>
        public IEnumerable<Frame> Frames { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditDialog"/>
        /// class.
        /// </summary>
        public EditDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1340, 674 );
            MaximumSize = new Size( 1340, 674 );
            MinimumSize = new Size( 1340, 674 );
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            TabPage.TabFont = new Font( "Roboto", 8, FontStyle.Regular );
            TabPage.TabForeColor = Color.FromArgb( 0, 120, 212 );
            SelectButton.Text = "Save";
            CloseButton.Text = "Exit";
            Frames = GetFrames( );
            TabPages = GetTabPages( );

            // Form Event Wiring
            Load += OnLoad;
            MouseClick += OnRightClick;

            // Control Event Wiring
            CloseButton.Click += OnCloseButtonClicked;
            TabPage.MouseClick += OnRightClick;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditDialog"/>
        /// class.
        /// </summary>
        /// <param name="tool"> Type of the tool. </param>
        /// <param name="bindingSource"> The binding source. </param>
        public EditDialog( ToolType tool, BindingSource bindingSource )
            : this( )
        {
            Tool = tool;
            BindingSource = bindingSource;
            DataTable = BindingSource.GetDataTable( );
            Source = (Source) Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider );
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditDialog"/>
        /// class.
        /// </summary>
        /// <param name="tool"> Type of the tool. </param>
        /// <param name="dataModel"> The data model. </param>
        public EditDialog( ToolType tool, DataBuilder dataModel )
            : this( )
        {
            Tool = tool;
            DataModel = dataModel;
            Provider = dataModel.Provider;
            Source = dataModel.Source;
            CommandType = dataModel.SqlStatement.CommandType;
            BindingSource.DataSource = dataModel.DataTable;
            DataTable = dataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditDialog"/>
        /// class.
        /// </summary>
        /// <param name="tool"> Type of the tool. </param>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public EditDialog( ToolType tool, Source source, Provider provider = Provider.Access )
            : this( )
        {
            Tool = tool;
            Provider = provider;
            Source = source;
            DataModel = new DataBuilder( source, provider );
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
            Current = BindingSource.GetCurrentDataRow( );
            Fields = DataModel?.Fields;
            Numerics = DataModel?.Numerics;
        }

        /// <summary> Sets the frame visibility. </summary>
        public void SetFrameVisibility( )
        {
            if( Frames?.Any( ) == true )
            {
                try
                {
                    var _cols = Columns.ToArray( );
                    var _frames = Frames.ToArray( );
                    for( var _i = 0; _i < _frames.Length; _i++ )
                    {
                        var _frame = _frames[ _i ];
                        if( _frame.Index >= _cols.Length )
                        {
                            _frame.Visible = false;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Gets the tab pages. </summary>
        /// <returns> </returns>
        public IDictionary<string, TabPageAdv> GetTabPages( )
        {
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _tabPages = new Dictionary<string, TabPageAdv>( );
                    foreach( TabPageAdv _tabpage in TabControl.TabPages )
                    {
                        if( _tabpage != null )
                        {
                            _tabPages.Add( _tabpage.Name, _tabpage );
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

        /// <summary> Gets the frames. </summary>
        /// <returns> </returns>
        public IEnumerable<Frame> GetFrames( )
        {
            try
            {
                var _frames = new List<Frame>( );
                for( var _i = 0; _i < FrameTable.Controls.Count; _i++ )
                {
                    var _control = FrameTable.Controls[ _i ];
                    if( _control.GetType( ) == typeof( Frame ) )
                    {
                        if( _control is Frame _frame )
                        {
                            _frame.BindingSource = BindingSource;
                            _frames.Add( _frame );
                        }
                    }
                }

                return _frames?.Any( ) == true
                    ? _frames.OrderBy( f => f.Index ).ToArray( )
                    : default( IEnumerable<Frame> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<Frame> );
            }
        }

        /// <summary> Sets the active tab. </summary>
        private void SetActiveTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), Tool ) )
            {
                try
                {
                    switch( Tool )
                    {
                        case ToolType.CopyButton:

                        {
                            ActiveTab = TabPage;
                            break;
                        }

                        case ToolType.AddRecordButton:

                        {
                            ActiveTab = TabPage;
                            break;
                        }

                        case ToolType.AddButton:

                        {
                            ActiveTab = TabPage;
                            break;
                        }

                        case ToolType.EditRecordButton:

                        {
                            ActiveTab = TabPage;
                            break;
                        }

                        case ToolType.DeleteRecordButton:

                        {
                            ActiveTab = TabPage;
                            SelectButton.Text = "Delete";
                            break;
                        }

                        default:

                        {
                            ActiveTab = TabPage;
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

        /// <summary> Sets the frame dock style. </summary>
        private void SetFrameDockStyle( )
        {
            if( Frames?.Any( ) == true )
            {
                try
                {
                    foreach( var _frame in Frames )
                    {
                        _frame.Dock = DockStyle.Fill;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Sets the table location. </summary>
        private void SetTableLocation( )
        {
            if( ( FrameTable != null )
               && ( Columns?.Any( ) == true ) )
            {
                try
                {
                    var _cols = Columns.ToArray( );
                    switch( _cols.Length )
                    {
                        case >= 43:
                        case < 43 and >= 35:

                            FrameTable.Location = new Point( 12, 25 );
                            break;
                        case < 35 and >= 28:
                        case < 28 and >= 21:
                        case < 21 and >= 14:
                        case < 14 and > 7:
                        case <= 7:

                            FrameTable.Location = new Point( 12, 81 );
                            break;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Binds the record data. </summary>
        private void BindRecord( )
        {
            if( ( Current != null )
               && ( Frames?.Any( ) == true )
               && ( Columns?.Any( ) == true ) )
            {
                try
                {
                    var _items = Current.ItemArray;
                    var _frames = Frames.OrderBy( f => f.Index ).ToArray( );
                    var _cols = Columns.ToArray( );
                    for( var _i = 0; _i < _cols.Length; _i++ )
                    {
                        _frames[ _i ].Label.Text = _cols[ _i ].SplitPascal( );
                        var _text = _items[ _i ]?.ToString( );
                        if( ( Numerics?.Contains( _cols[ _i ] ) == true )
                           && !string.IsNullOrEmpty( _text ) )
                        {
                            var _value = double.Parse( _text );
                            _frames[ _i ].TextBox.Font = new Font( "Roboto", 8 );
                            _frames[ _i ].TextBox.Text = _value.ToString( "N2" );
                            _frames[ _i ].TextBox.TextAlign = HorizontalAlignment.Right;
                        }
                        else
                        {
                            _frames[ _i ].TextBox.Font = new Font( "Roboto", 8 );
                            _frames[ _i ].TextBox.Text = _items[ _i ]?.ToString( );
                            _frames[ _i ].TextBox.TextAlign = HorizontalAlignment.Left;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Sets the frame colors. </summary>
        private void SetFrameColors( )
        {
            if( Frames?.Any( ) == true )
            {
                foreach( var _frame in Frames )
                {
                    _frame.Label.ForeColor = Color.LightSteelBlue;
                    _frame.TextBox.ForeColor = Color.DarkGray;
                    _frame.TextBox.BorderColor = Color.FromArgb( 50, 93, 129 );
                    _frame.TextBox.HoverColor = Color.FromArgb( 0, 120, 212 );
                }
            }
        }

        /// <summary> Wires up frame events. </summary>
        private void WireUpFrameEvents( )
        {
            if( Frames?.Any( ) == true )
            {
                foreach( var _frame in Frames )
                {
                    _frame.TextBox.MouseClick += OnContentClick;
                }
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
                SetActiveTab( );
                SetTableLocation( );
                SetFrameColors( );
                SetFrameDockStyle( );
                BindRecord( );
                SetFrameVisibility( );
                WireUpFrameEvents( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [content click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnContentClick( object sender, MouseEventArgs e )
        {
            if( sender is TextBox _currentCell
               && ( e.Button == MouseButtons.Left )
               && !string.IsNullOrEmpty( _currentCell.Text ) )
            {
                try
                {
                    var _value = _currentCell.Text;
                    if( !string.IsNullOrEmpty( _value )
                       && ( _value.Length > 25 ) )
                    {
                        var _editDialog = new TextDialog( _value );
                        _editDialog.ShowDialog( this );
                    }
                    else if( !string.IsNullOrEmpty( _value )
                            && ( _value.Length >= 6 )
                            && ( _value.Length <= 9 )
                            && ( _value.Substring( 0, 3 ) == "000" ) )
                    {
                        var _code = _value.Substring( 4, 2 );
                        var _dialog = new ProgramProjectDialog( _code );
                        _dialog.ShowDialog( this );
                    }
                    else if( decimal.TryParse( _value, out var _decimal ) )
                    {
                        var _double = Convert.ToDouble( _decimal );
                        var _calculator = new CalculationForm( _double );
                        _calculator.ShowDialog( this );
                    }
                    else if( double.TryParse( _value, out var _double ) )
                    {
                        var _calculator = new CalculationForm( _double );
                        _calculator.ShowDialog( this );
                    }
                    else if( DateTime.TryParse( _value, out var _dateTime ) )
                    {
                        var _form = new CalendarDialog( _dateTime );
                        _form.ShowDialog( this );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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