// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-28-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-28-2024
// ******************************************************************************************
// <copyright file="PartFactory.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   PartFactory.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Diagnostics.CodeAnalysis;
    using OfficeOpenXml;
    using OfficeOpenXml.Drawing.Chart;
    using OfficeOpenXml.Drawing.Chart.Style;
    using OfficeOpenXml.Export.ToDataTable;
    using OfficeOpenXml.Style;
    using OfficeOpenXml.Table;
    using OfficeOpenXml.Table.PivotTable;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "HeapView.ObjectAllocation.Evident" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "RedundantCheckBeforeAssignment" ) ]
    [ SuppressMessage( "ReSharper", "RedundantAssignment" ) ]
    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    public class PartFactory : Workbook
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PartFactory"/> class.
        /// </summary>
        public PartFactory( )
        {
        }

        /// <summary>
        /// Creates the excel table.
        /// </summary>
        private protected ExcelTable CreateExcelTable( DataTable dataTable )
        {
            try
            {
                ThrowIf.Null( dataTable, nameof( dataTable ) );
                _dataRange = (ExcelRange)_dataWorksheet.Cells[ "A2" ]
                    ?.LoadFromDataTable( dataTable, true, TableStyles.Light1 );

                _dataRange.Style.Font.Name = "Roboto";
                _dataRange.Style.Font.Size = 8;
                _dataRange.Style.Font.Bold = false;
                _dataRange.Style.Font.Italic = false;
                _dataRange.EntireRow.CustomHeight = true;
                _dataRange.Style.Font.Color.SetColor( _fontColor );
                _dataRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                _dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                _excelTable = _dataWorksheet.Tables.GetFromRange( _dataRange );
                _excelTable.TableStyle = TableStyles.Light1;
                _excelTable.ShowHeader = true;
                FormatFooter( _dataRange );
                return _excelTable;
            }
            catch( Exception _ex )
            {
                if( _dataRange != null )
                {
                    _dataRange = null;
                }

                Fail( _ex );
                return default( ExcelTable );
            }
        }

        /// <summary>
        /// Creates the data table.
        /// </summary>
        /// <param name="startRow">The start row.</param>
        /// <param name="startColumn"> </param>
        /// <param name="endRow">The end row.</param>
        /// <param name="endColumn"> </param>
        /// <returns>
        /// DataTable
        /// </returns>
        private protected DataTable CreateDataTable( int startRow, int startColumn, 
            int endRow, int endColumn )
        {
            try
            {
                var _table = new DataTable( );
                _dataRange = _dataWorksheet.Cells[ startRow, startColumn, endRow, endColumn ];
                var _options = ToDataTableOptions.Create( );
                _options.DataTableName = _fileName ?? string.Empty;
                _options.AlwaysAllowNull = true;
                _options.ColumnNameParsingStrategy = NameParsingStrategy.RemoveSpace;
                _options.ExcelErrorParsingStrategy =
                    ExcelErrorParsingStrategy.HandleExcelErrorsAsBlankCells;

                _table = _dataRange?.ToDataTable( _options );
                return _table?.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                if( _dataRange != null )
                {
                    _dataRange = null;
                }

                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Creates the pivot table.
        /// </summary>
        /// <param name="excelRange">The data range.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="rowField"> </param>
        /// <param name="dataField"> </param>
        /// <returns>
        /// ExcelPivotTable
        /// </returns>
        private protected ExcelPivotTable CreatePivotTable( ExcelRange excelRange, string tableName, 
            string rowField, string dataField )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                ThrowIf.NullOrEmpty( tableName, nameof( tableName ) );
                ThrowIf.NullOrEmpty( rowField, nameof( rowField ) );
                ThrowIf.NullOrEmpty( dataField, nameof( dataField ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                var _anchor = _pivotWorksheet.Cells[ _startRow, _startColumn ];
                _pivotWorksheet = _excelWorkbook.Worksheets.Add( "Pivot" );
                _pivotRange = _pivotWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _pivotTable = _pivotWorksheet.PivotTables.Add( _anchor, excelRange, tableName );
                _pivotTable.RowFields.Add( _pivotTable.Fields[ rowField ] );
                var _dataField = _pivotTable.DataFields.Add( _pivotTable.Fields[ dataField ] );
                _dataField.Format = "#,##0";
                _pivotTable.DataOnRows = true;
                return _pivotTable;
            }
            catch( Exception _ex )
            {
                if( _pivotWorksheet != null )
                {
                    _pivotWorksheet = null;
                }

                if( _pivotTable != null )
                {
                    _pivotTable = null;
                }

                if( _pivotRange != null )
                {
                    _pivotRange = null;
                }

                Fail( _ex );
                return default( ExcelPivotTable );
            }
        }

        /// <summary>
        /// Creates the pie chart.
        /// </summary>
        /// <param name="excelRange">The data range.</param>
        /// <param name="chartName">Name of the table.</param>
        /// <param name="row"> </param>
        /// <param name="column"> </param>
        /// <returns>
        /// ExcelPieChart
        /// </returns>
        private protected ExcelPieChart CreatePieChart( ExcelRange excelRange, string chartName,
            string row, string column )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                ThrowIf.NullOrEmpty( chartName, nameof( chartName ) );
                ThrowIf.NullOrEmpty( row, nameof( row ) );
                ThrowIf.NullOrEmpty( column, nameof( column ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                var _anchor = _pivotWorksheet.Cells[ _startRow, _startColumn ];
                _chartWorksheet = _excelWorkbook.Worksheets.Add( "Chart" );
                _chartRange = _chartWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _pivotTable = _chartWorksheet.PivotTables.Add( _anchor, _chartRange, chartName );
                _pivotTable.RowFields.Add( _pivotTable.Fields[ row ] );
                var _dataField = _pivotTable.DataFields.Add( _pivotTable.Fields[ column ] );
                _dataField.Format = "#,##0";
                _pivotTable.DataOnRows = true;
                _pieChart = _chartWorksheet.Drawings
                    ?.AddPieChart( "Chart", ePieChartType.PieExploded3D, _pivotTable );

                _pieChart.SetPosition( 1, 0, 4, 0 );
                _pieChart.SetSize( 800, 600 );
                _pieChart.Legend.Remove( );
                _pieChart.Series[ 0 ].DataLabel.ShowCategory = true;
                _pieChart.Series[ 0 ].DataLabel.Position = eLabelPosition.OutEnd;
                _pieChart.StyleManager.SetChartStyle( ePresetChartStyle.Pie3dChartStyle6 );
                return _pieChart;
            }
            catch( Exception _ex )
            {
                if( _chartWorksheet != null )
                {
                    _chartWorksheet = null;
                }

                if( _pivotTable != null )
                {
                    _pivotTable = null;
                }

                if( _chartRange != null )
                {
                    _chartRange = null;
                }

                Fail( _ex );
                return default( ExcelPieChart );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="excelRange"> </param>
        /// <param name="text">The text.</param>
        public void CreateComment( ExcelRange excelRange, string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.Start.Row;
                var _endColumn = excelRange.End.Column;
                _commentRange =
                    _dataWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];

                var _comment = _commentRange.AddComment( text, "Budget" );
                _comment.From.Row = _commentRange.Start.Row;
                _comment.From.Column = _commentRange.Start.Column;
                _comment.To.Row = _commentRange.End.Row;
                _comment.To.Column = _commentRange.End.Column;
                _comment.BackgroundColor = Color.FromArgb( 40, 40, 40 );
                _comment.Font.FontName = "Roboto";
                _comment.Font.Size = 8;
                _comment.Font.Color = Color.FromArgb( 106, 189, 252 );
                _comment.Text = text;
            }
            catch( Exception _ex )
            {
                if( _commentRange != null )
                {
                    _commentRange = null;
                }

                Fail( _ex );
            }
        }
    }
}