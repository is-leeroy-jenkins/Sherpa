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
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using DocumentFormat.OpenXml.Packaging;
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
        /// Initializes a new instance of the <see cref="PartFactory"/> class.
        /// </summary>
        public PartFactory( )
        {
        }

        /// <summary>
        /// Creates the excel document.
        /// </summary>
        /// <returns></returns>
        public void CreatPivotTable( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the excel table.
        /// </summary>
        private protected void CreateExcelTable( DataTable dataTable )
        {
            try
            {
                ThrowIf.Null( dataTable, nameof( dataTable ) );
                _excelRange = (ExcelRange)_excelWorksheet.Cells[ "A2" ]
                    ?.LoadFromDataTable( dataTable, true, TableStyles.Light1 );

                _excelRange.Style.Font.Name = "Roboto";
                _excelRange.Style.Font.Size = 8;
                _excelRange.Style.Font.Bold = false;
                _excelRange.Style.Font.Italic = false;
                _excelRange.EntireRow.CustomHeight = true;
                _excelRange.Style.Font.Color.SetColor( _fontColor );
                _excelRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                _excelRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                _excelTable = _excelWorksheet.Tables.GetFromRange( _excelRange );
                _excelTable.TableStyle = TableStyles.Light1;
                _excelTable.ShowHeader = true;
                FormatFooter( _excelRange );
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the excel document.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="filePath">Name of the file.</param>
        /// <returns></returns>
        public bool CreateDocument( DataSet dataSet, string filePath )
        {
            try
            {
                return false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Writes the excel file.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="spreadSheet">The spreadsheet.</param>
        public void WriteFile( DataSet dataSet, SpreadsheetDocument spreadSheet )
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
        /// Creates the pivot data.
        /// </summary>
        /// <param name="dataRange">The data range.</param>
        /// <returns></returns>
        private protected ExcelPivotTable CreatePivotData( ExcelRangeBase dataRange )
        {
            var _pivotsheet = _excelWorkbook.Worksheets.Add( "PVT" );
            _pivotTable = _pivotsheet.PivotTables.Add( _pivotsheet.Cells[ "A2" ], dataRange, "PerCountry" );
            _pivotTable.RowFields.Add( _pivotTable.Fields[ "Country" ] );
            var _dataField = _pivotTable.DataFields.Add( _pivotTable.Fields[ "OrderValue" ] );
            _dataField.Format = "#,##0";
            _pivotTable.DataOnRows = true;
            var _chart = _pivotsheet.Drawings.AddPieChart( "PivotChart", ePieChartType.PieExploded3D, _pivotTable );
            _chart.SetPosition( 1, 0, 4, 0 );
            _chart.SetSize( 800, 600 );
            _chart.Legend.Remove( );
            _chart.Series[ 0 ].DataLabel.ShowCategory = true;
            _chart.Series[ 0 ].DataLabel.Position = eLabelPosition.OutEnd;
            _chart.StyleManager.SetChartStyle( ePresetChartStyle.Pie3dChartStyle6 );
            return _pivotTable;
        }

        /// <summary>
        /// Creates the data table.
        /// </summary>
        /// <param name="startRow">The start row.</param>
        /// <param name="endrow">The end row.</param>
        /// <returns>
        /// DataTable
        /// </returns>
        private protected DataTable CreateDataTable( int startRow, int endrow )
        {
            try
            {
                var _table = new DataTable( );
                var _range = _excelWorksheet.Cells[ startRow, endrow ] as ExcelRangeBase;
                var _options = ToDataTableOptions.Create( );
                _table = _range?.ToDataTable( _options );
                return _table?.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }
    }
}