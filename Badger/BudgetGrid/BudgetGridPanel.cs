// <copyright file = "BudgetGridPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

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
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.BudgetGridData" />
    /// <seealso cref="BudgetExecution.IBudgetGrid" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class BudgetGridPanel : BudgetGridData, IBudgetGrid
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGridPanel"/> class.
        /// </summary>
        public BudgetGridPanel()
        {
            // Basic Properties
            ForeColor = Color.White;
            BackColor = ColorConfig.FormDarkBackColor;
            Font = new Font( "Roboto", 8, FontStyle.Bold );
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = SizeConfig.GetSize( 700, 400 );
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Font = FontConfig.FontSizeSmall;
            Visible = true;
            Enabled = true;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;
            Model.Properties.GridLineColor = Color.FromArgb( 64, 64, 64 );

            // Style Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            GridVisualStyles = GridVisualStyles.Office2010Black;
            EnableAddNew = true;
            EnableEdit = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            AlphaBlendSelectionColor = ColorConfig.BorderYellow;
            Properties.BackgroundColor = ColorConfig.FormDarkBackColor;
            Properties.CenterHorizontal = true;
            Properties.CenterVertical = true;
            Properties.ColHeaders = true;
            Properties.RowHeaders = true;
            Properties.Buttons3D = true;

            // Table Style Properties
            TableStyle.Themed = true;
            TableStyle.WrapText = false;
            TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            TableStyle.AutoFit = AutoFitOptions.Both;
            TableStyle.Font.Facename = "consolas";
            TableStyle.Font.Size = 8;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGridPanel"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetGridPanel( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGridPanel"/> class.
        /// </summary>
        /// <param name="datagrid">The datagrid.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public BudgetGridPanel( GridDataBoundGrid datagrid )
            : this( datagrid.Size, datagrid.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetGridPanel"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetGridPanel( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Gets or sets the tool bar.
        /// </summary>
        /// <value>
        /// The tool bar.
        /// </value>
        public ToolPanel ToolBar { set; get; }

        /// <summary>
        /// Gets or sets the grid box panel.
        /// </summary>
        /// <value>
        /// The grid box panel.
        /// </value>
        public GroupBoxPanel GridBoxPanel { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        /// <summary>
        /// Sets the width of the column.
        /// </summary>
        /// <param name="columns">The columns.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public void SetColumnWidth( GridBoundColumnsCollection columns )
        {
            if( columns.Count > 0 )
            {
                try
                {
                    for( var i = 0; i < columns.Count; i++ )
                    {
                        switch( i )
                        {
                            case 0:
                            {
                                Model.ColWidths[ i ] = 40;
                                Model.RowHeights[ i ] = 30;
                                break;
                            }

                            case 1:
                            {
                                Model.ColWidths[ i ] = 40;
                                Model.RowHeights[ i ] = 22;
                                break;
                            }
                        }

                        if( i > 1 )
                        {
                            Model.ColWidths[ i ] = 90;
                            Model.RowHeights[ i ] = 22;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the grid bound dataRows columns.
        /// </summary>
        /// <param name="data">The dataRows.</param>
        public void SetGridBoundDataColumns( IEnumerable<DataRow> data )
        {
            if( data.Any() )
            {
                var _dataTable = data.CopyToDataTable();

                foreach( DataColumn _column in _dataTable.Columns )
                {
                    var _gridColumn = new GridBoundColumn
                    {
                        HeaderText = _column.Caption
                    };

                    _gridColumn.StyleInfo.Font.Bold = true;
                    _gridColumn.StyleInfo.BackColor = ColorConfig.FormDarkBackColor;
                    _gridColumn.StyleInfo.TextColor = Color.White;
                    _gridColumn.BackColor = ColorConfig.FormDarkBackColor;
                    _gridColumn.MappingName = _column.ColumnName;
                    GridBoundColumns.Add( _gridColumn );
                }

                PascalizeHeaders( data, GridBoundColumns );
                SetColumnWidth( GridBoundColumns );
            }
        }

        /// <summary>
        /// Sets the dataRows source.
        /// </summary>
        /// <param name="data">The dataRows.</param>
        /// <param name="dict"></param>
        public void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict = null )
        {
            switch( data?.Any() )
            {
                case true when dict == null:
                    try
                    {
                        SetGridBoundDataColumns( data );
                        BindingSource.DataSource = data.CopyToDataTable();
                        Binder.DataSource = BindingSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;

                case true when dict != null:
                    try
                    {
                        SetGridBoundDataColumns( data );
                        BindingSource.DataSource = data.CopyToDataTable();
                        BindingSource.Filter = GetFilterValues( dict );
                        Binder.DataSource = BindingSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }

                    break;
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingSource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( BindingSource bindingSource, IDictionary<string, object> dict = null )
        {
            if( bindingSource.DataSource != null
                && dict == null )
            {
                try
                {
                    SetGridBoundDataColumns( bindingSource.DataSource as IEnumerable<DataRow> );

                    BindingSource.DataSource = ( bindingSource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable();

                    Binder.DataSource = BindingSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
            else if( bindingSource?.DataSource != null
                && dict != null )
            {
                try
                {
                    SetGridBoundDataColumns( bindingSource.DataSource as IEnumerable<DataRow> );

                    BindingSource.DataSource = ( bindingSource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable();

                    if( Verify.IsInput( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter();
                        BindingSource.Filter = GetFilterValues( dict );
                    }

                    if( string.IsNullOrEmpty( BindingSource.Filter ) )
                    {
                        BindingSource.Filter = GetFilterValues( dict );
                    }

                    Binder.DataSource = BindingSource.DataSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="dataRows"></param>
        /// <param name="gridColumns"></param>
        public void PascalizeHeaders( IEnumerable<DataRow> dataRows, GridBoundColumnsCollection gridColumns )
        {
            if( dataRows.Any()
                && gridColumns.Count > 0 )
            {
                try
                {
                    var _dataTable = dataRows.CopyToDataTable();
                    var _columnNames = _dataTable.GetColumnNames();

                    for( var i = 0; i < gridColumns?.Count; i++ )
                    {
                        gridColumns[ i ].HeaderText = _columnNames[ i ].Contains( "Id" )
                            ? "ID"
                            : _columnNames[ i ]?.SplitPascal();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict?.Any() == true )
                {
                    try
                    {
                        var _values = string.Empty;

                        foreach( var kvp in dict )
                        {
                            _values += $"{kvp.Key} = '{kvp.Value}' AND ";
                        }

                        return _values.TrimEnd( "AND ".ToCharArray() );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return default( string );
                    }
                }

                return default( string );
            }
        }

        /// <summary>
        /// Gets the current dataRows row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentRow()
        {
            if( Binder?.DataSource != null )
            {
                try
                {
                    var _currencyManager = (CurrencyManager)BindingContext[ DataSource ];
                    var _index = Binder.CurrentPosition;
                    var _dataView = (DataView)_currencyManager.List;

                    if( _index > -1 )
                    {
                        var datarow = _dataView[ _index ].Row;
                        return datarow ?? default( DataRow );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataRow );
                }
            }

            return default( DataRow );
        }

        /// <summary>
        /// Sets the group panel.
        /// </summary>
        public void SetGridPanel()
        {
            try
            {
                var _location = new Point( Location.X - 6, Location.Y - 6 );
                var _size = new Size( Size.Width + 3, Size.Height + 66 );
                var _gridPanel = new GroupBoxPanel( _size, _location );
                _gridPanel.Border.Color = ColorConfig.BorderYellow;
                _gridPanel.Padding = new Padding( 3, 1, 3, 1 );

                if( ToolBar != null )
                {
                    _gridPanel.Controls.Add( ToolBar );
                }

                GridBoxPanel = _gridPanel;
                GridBoxPanel.Controls.Add( this );
                Dock = DockStyle.Bottom;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the toolbar.
        /// </summary>
        public void SetToolBar()
        {
            try
            {
                var _toolbar = new ToolPanel();
                GridBoxPanel?.Controls.Add( ToolBar );
                _toolbar.Dock = DockStyle.Fill;
                _toolbar.Dock = DockStyle.Bottom;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="MouseEventArgs" />
        /// instance containing the event dataRows.</param>
        public void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right
                && Binder.CurrentRowIndex <= 1 )
            {
                try
                {
                    var _configuration = new ColumnConfiguration( sender as DataGridView );
                    _configuration?.ColumnListBox?.Items?.Clear();

                    foreach( var _name in _configuration?.ColumnNames )
                    {
                        _configuration?.ColumnListBox?.Items?.Add( _name.SplitPascal(), false );
                    }

                    _configuration.Location = PointToScreen( new Point( e.X, e.Y ) );
                    _configuration.TopMost = true;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event dataRows.</param>
        [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
        public void OnCurrentChanged( object sender, EventArgs e )
        {
            try
            {
                Current = GetCurrentRow();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Models the on selection changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="GridSelectionChangedEventArgs"/> instance containing the event dataRows.</param>
        public void ModelOnSelectionChanged( object sender, GridSelectionChangedEventArgs e )
        {
            try
            {
                Current = GetCurrentRow();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}