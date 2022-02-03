﻿// <copyright file = "BudgetDataGrid.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.DataGridView" />
    /// <seealso/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class BudgetDataGrid : GridBase, IDataGrid
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }
        
        public override NameValueCollection AppSetting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public override Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetDataGrid" />
        /// class.
        /// </summary>
        public BudgetDataGrid()
        {
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8, FontStyle.Bold );
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Size = SizeConfig.GetSize( 1400, 800 );
            Anchor = ControlConfig.GetAnchorStyle();
            EnableHeadersVisualStyles = false;
            BackColor = ColorConfig.FormBackColorDark;
            BorderStyle = BorderStyle.FixedSingle;
            BackgroundColor = BackColor;

            // Column Configuration
            AllowUserToOrderColumns = true;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            ColumnHeadersHeight = 35;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 11, FontStyle.Bold );
            RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Row Configuration
            RowHeadersWidth = 26;
            RowHeadersDefaultCellStyle.BackColor = ColorConfig.ForeColorGray;
            RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 10, FontStyle.Bold );
            RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            RowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            RowsDefaultCellStyle.Font = new Font( "Roboto", 10 );
            RowsDefaultCellStyle.ForeColor = Color.Black;
            RowsDefaultCellStyle.SelectionBackColor = SystemColors.ControlLight;
            RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            // Epilog
            Visible = true;
            Enabled = true;
            ColumnHeaderMouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetDataGrid" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetDataGrid( Size size, Point location )
            : this()
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDataGrid"/> class.
        /// </summary>
        /// <param name="dataGrid">The dataGrid.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public BudgetDataGrid( DataGridView dataGrid )
            : this( dataGrid.Size, dataGrid.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetDataGrid" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetDataGrid( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
        }
        
        /// <summary>
        /// Sets the column configuration.
        /// </summary>
        public void SetColumnConfiguration()
        {
            try
            {
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font( "Roboto", 11, FontStyle.Bold ),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    BackColor = Color.SteelBlue
                };
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the row configuration.
        /// </summary>
        public void SetRowConfiguration()
        {
            try
            {
                RowHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.BottomCenter,
                    ForeColor = Color.Black,
                    Font = new Font( "Roboto", 10, FontStyle.Bold ),
                    BackColor = ColorConfig.ForeColorGray
                };

                RowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.BottomCenter,
                    SelectionForeColor = Color.Black,
                    SelectionBackColor = SystemColors.ControlLight,
                    ForeColor = Color.Black,
                    Font = new Font( "Roboto", 10 ),
                    BackColor = Color.LightSteelBlue
                };
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( IEnumerable<DataRow> dataRows, IDictionary<string, object> dict )
        {
            if( Verify.IsInput( dataRows )
                && dict?.Any() == true )
            {
                try
                {
                    if( Verify.IsInput( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter();
                    }

                    BindingSource.DataSource = dataRows.CopyToDataTable();
                    BindingSource.Filter = GetFilterValues( dict );
                    DataSource = BindingSource;
                    PascalizeHeaders( dataRows );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingSource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( BindingSource bindingSource, IDictionary<string, object> dict )
        {
            if( bindingSource?.DataSource != null
                && dict?.Any() == true )
            {
                try
                {
                    if( Verify.IsInput( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter();
                    }

                    BindingSource.DataSource = ( bindingSource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable();

                    BindingSource.Filter = GetFilterValues( dict );
                    DataSource = BindingSource;
                    PascalizeHeaders( BindingSource.DataSource as IEnumerable<DataRow> );
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
        /// <param name="dataRows">The data.</param>
        public void PascalizeHeaders( IEnumerable<DataRow> dataRows )
        {
            if( Verify.IsInput( dataRows ) )
            {
                try
                {
                    if( dataRows?.CopyToDataTable()?.Columns?.Count > 0 )
                    {
                        foreach( DataColumn column in dataRows.CopyToDataTable().Columns )
                        {
                            foreach( DataGridViewColumn gridcol in Columns )
                            {
                                gridcol.HeaderText = column.Caption;
                            }
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
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict != null )
                {
                    try
                    {
                        var _vals = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            _vals += $"{_kvp.Key} = '{_kvp.Value}' AND ";
                        }

                        return _vals.Trim().Substring( 0, _vals.Length - 4 );
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
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentDataRow()
        {
            try
            {
                using var _message = new Message( "Not Yet Implemented." );
                _message?.ShowDialog();
                return default( DataRow );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataRow );
            }
        }
        
        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DataGridViewCellMouseEventArgs" /> instance containing the event data.</param>
        public void OnRightClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    using var _columnConfiguration = new ColumnConfiguration( this );

                    foreach( DataGridViewColumn c in Columns )
                    {
                        _columnConfiguration.ColumnListBox.Items.Add( c.HeaderText, c.Visible );
                    }

                    _columnConfiguration.ColumnListBox.Items.Clear();
                    _columnConfiguration.Location = PointToScreen( new Point( e.X, e.Y ) );
                    _columnConfiguration.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}