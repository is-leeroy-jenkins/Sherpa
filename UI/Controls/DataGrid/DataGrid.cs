//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                DataGrid.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DataGrid.cs" company="Terry D. Eppler">
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
//    DataGrid.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:System.Windows.Forms.DataGridView"/>
    /// <seealso cref="T:Sherpa.IDataGrid"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public class DataGrid : DataGridView
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.DataGrid"/>
        /// class.
        /// </summary>
        public DataGrid( )
        {
            EnableHeadersVisualStyles = false;
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 8 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 906, 527 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            BackColor = Color.FromArgb( 45, 45, 45 );
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            BackgroundColor = Color.FromArgb( 45, 45, 45 );
            GridColor = Color.FromArgb( 141, 139, 138 );
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            AllowUserToOrderColumns = true;
            AllowUserToResizeColumns = true;
            AllowUserToResizeRows = true;
            MultiSelect = false;

            // Default Cell Style
            DefaultCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            DefaultCellStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            DefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
            DefaultCellStyle.SelectionForeColor = Color.White;
            DefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );

            // Column SeriesConfiguration
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ColumnHeadersHeight = 22;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );

            // Row SeriesConfiguration
            RowHeadersWidth = 20;
            RowTemplate.Height = 22;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersDefaultCellStyle.BackColor = Color.FromArgb( 50, 50, 50 );
            RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );
            RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 17, 53, 84 );
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            RowsDefaultCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            RowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
            RowsDefaultCellStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
            RowsDefaultCellStyle.SelectionForeColor = Color.White;
            RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb( 50, 50, 50 );
            AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            AlternatingRowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
            AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 26, 79, 125 );
            AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Wire Events
            ColumnHeaderMouseClick += OnColumnHeaderClick;
            CellContentClick += OnCellContentClick;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the see cref="T:Sherpa.DataGrid" /> class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        public DataGrid( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.DataGrid"/>
        /// class.
        /// </summary>
        /// <param name="dataGrid"> The data grid. </param>
        public DataGrid( Control dataGrid )
            : this( dataGrid.Size, dataGrid.Location )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.DataGrid"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        /// <param name="parent"> The parent. </param>
        public DataGrid( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
        }

        /// <summary> Gets the filter values. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict?.Any( ) == true )
                {
                    try
                    {
                        var _vals = string.Empty;
                        foreach( var _kvp in dict )
                        {
                            _vals += $"{_kvp.Key} = '{_kvp.Value}' AND ";
                        }

                        return _vals.Trim( ).Substring( 0, _vals.Length - 4 );
                    }
                    catch( Exception _ex )
                    {
                        Fail( _ex );
                        return default( string );
                    }
                }

                return default( string );
            }
        }

        /// <summary> Gets the current data row. </summary>
        /// <returns> </returns>
        public DataRow GetCurrentDataRow( )
        {
            if( BindingSource?.DataSource != null )
            {
                try
                {
                    var _dataRow = BindingSource?.Current as DataRow;
                    return _dataRow?.ItemArray?.Length > 0
                        ? _dataRow
                        : default( DataRow );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DataRow );
                }
            }

            return default( DataRow );
        }

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="DataGridViewCellMouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnColumnHeaderClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    var _columnConfig = new ColumnConfiguration( this );
                    _columnConfig.Location = PointToScreen( new Point( e.X, e.Y ) );
                    _columnConfig.ColumnListBox?.Items?.Clear( );
                    for( var _i = 0; _i < Columns.Count; _i++ )
                    {
                        var _c = Columns[ _i ];
                        _columnConfig.ColumnListBox?.Items.Add( _c.HeaderText, _c.Visible );
                        _columnConfig.TopMost = true;
                        _columnConfig?.Show( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Called when [cell enter]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="DataGridViewCellEventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            if( !string.IsNullOrEmpty( CurrentCell.Value.ToString( ) ) )
            {
                try
                {
                    if( CurrentCell.ValueType == typeof( string ) )
                    {
                        var _value = CurrentCell.Value.ToString( );
                        if( _value?.Length > 25 )
                        {
                            var _editDialog = new TextDialog( _value );
                            _editDialog.ShowDialog( );
                            CurrentCell.Value = _editDialog.Editor.Text;
                        }
                        else if( _value?.Length is >= 6 and <= 9
                                && ( _value?.Substring( 0, 3 ) == "000" ) )
                        {
                            var _code = _value.Substring( 4, 2 );
                            var _dialog = new ProgramProjectDialog( _code );
                            _dialog.ShowDialog( );
                        }
                    }
                    else if( CurrentCell.ValueType == typeof( double ) )
                    {
                        var _double = double.Parse( CurrentCell.Value.ToString( ) );
                        var _form = new CalculationForm( _double );
                        _form.ShowDialog( );
                        CurrentCell.Value = _form.Calculator.Value.ToString( );
                    }
                    else if( CurrentCell.ValueType == typeof( decimal ) )
                    {
                        var _cellValue = double.Parse( CurrentCell.Value.ToString( ) );
                        var _form = new CalculationForm( _cellValue );
                        _form.ShowDialog( );
                        CurrentCell.Value = _form.Calculator.Value.ToString( );
                    }
                    else if( CurrentCell.ValueType == typeof( DateOnly ) )
                    {
                        var _cellValue = DateTime.Parse( CurrentCell.Value.ToString( ) );
                        var _form = new CalendarDialog( _cellValue );
                        _form.ShowDialog( );
                        CurrentCell.Value = _form.Calendar.SelectedDate.ToString( );
                    }
                    else if( CurrentCell.ValueType == typeof( DateTime ) )
                    {
                        var _cellValue = DateTime.Parse( CurrentCell.Value.ToString( ) );
                        var _form = new CalendarDialog( _cellValue );
                        _form.ShowDialog( );
                        CurrentCell.Value = _form.Calendar.SelectedDate.ToString( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}