//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                DataView.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DataView.cs" company="Terry D. Eppler">
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
//    DataView.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Data;
    using Syncfusion.WinForms.DataGrid;
    using Syncfusion.WinForms.DataGrid.Enums;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.DataViewBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class DataView : SfDataGrid
    {
        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public IDictionary<string, object> Filter { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataView" />
        /// class.
        /// </summary>
        public DataView( )
        {
            // Control Properties
            Size = new Size( 600, 300 );
            BackColor = Color.FromArgb( 45, 45, 45 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            AllowEditing = true;
            AllowFiltering = true;
            AllowDeleting = true;
            AllowGrouping = true;
            AllowSorting = true;
            AllowDraggingColumns = true;
            AllowResizingColumns = true;
            AllowSelectionOnMouseDown = true;
            Style.Border3DStyle = Border3DStyle.Flat;
            Style.BorderColor = Color.FromArgb( 100, 100, 100 );
            Style.BorderSides = Border3DSide.All;
            Style.BorderStyle = BorderStyle.FixedSingle;
            NavigationMode = NavigationMode.Row;
            SelectionMode = GridSelectionMode.Single;
            SelectionUnit = SelectionUnit.Row;
            PasteOption = PasteOptions.PasteData;
            PreviewRowHeight = 28;
            RowHeaderWidth = 28;
            RowHeight = 28;
            SummaryCalculationUnit = SummaryCalculationUnit.SelectedRows;
            SummaryCalculationMode = CalculationMode.Default;

            // Cell Style
            Style.CellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            Style.CellStyle.TextColor = Color.FromArgb( 106, 189, 252 );
            Style.CurrentCellStyle.BackColor = Color.FromArgb( 100, 100, 100 ); 
            Style.CurrentCellStyle.TextColor = Color.White;

            // CheckBox Style
            Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb( 0, 120, 212 );
            Style.CheckBoxStyle.UncheckedBackColor = Color.FromArgb( 100, 100, 100 ); 
            Style.CheckBoxStyle.CheckedBorderColor = Color.Lime;
            Style.CheckBoxStyle.UncheckedBackColor = Color.FromArgb( 50, 93, 129 );

            // Header Style
            Style.HeaderStyle.BackColor = Color.FromArgb( 50, 93, 129 );
            Style.HeaderStyle.TextColor = Color.FromArgb( 106, 189, 252 );
            Style.HeaderStyle.HoverTextColor = Color.White;
            Style.HeaderStyle.HoverBackColor = Color.FromArgb( 0, 120, 212 );

            // Selection Style
            Style.SelectionStyle.BackColor = Color.SteelBlue;
            Style.SelectionStyle.TextColor = Color.White;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataView" />
        /// class.
        /// </summary>
        /// <param name="dataTable"> The data table. </param>
        public DataView( DataTable dataTable )
            : this( )
        {
            DataTable = dataTable;
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