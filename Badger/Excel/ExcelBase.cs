// <copyright file = "ExcelForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using OfficeOpenXml;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.XlsIO;
    using Color = System.Drawing.Color;
    using DataTable = System.Data.DataTable;

    /// <summary>
    /// 
    /// </summary>
    public abstract class SpreadsheetBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelForm"/> class.
        /// </summary>
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public virtual string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public virtual string ConnectionString { get; set; }

        /// <summary>
        /// Gets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        public virtual OleDbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets or sets the data command.
        /// </summary>
        /// <value>
        /// The data command.
        /// </value>
        public virtual OleDbCommand DataCommand { get; set; }

        /// <summary>
        /// Gets or sets the data adapter.
        /// </summary>
        /// <value>
        /// The data adapter.
        /// </value>
        public virtual OleDbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets the excel package.
        /// </summary>
        /// <value>
        /// The excel package.
        /// </value>
        public virtual ExcelPackage ExcelPackage { get; set; }

        /// <summary>
        /// Gets or sets the ext.
        /// </summary>
        /// <value>
        /// The ext.
        /// </value>
        public virtual EXT Ext { get; set; }

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        public virtual void SetFilePath( string filePath )
        {
            if( Verify.IsInput( filePath )
                && File.Exists( filePath ) )
            {
                try
                {
                    FilePath = Path.GetFileName( filePath );
                }
                catch( Exception e )
                {
                    Console.WriteLine( e );
                    throw;
                }
            }
        }

        /// <summary>
        /// Sets the name of the file.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        public virtual void SetFileName( string filePath )
        {
            if( Verify.IsInput( filePath )
                && File.Exists( filePath ) )
            {
                try
                {
                    FilePath = Path.GetFileNameWithoutExtension( filePath );
                }
                catch( Exception e )
                {
                    Console.WriteLine( e );
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <returns></returns>
        public virtual EXT GetFileExtension( string filePath )
        {
            try
            {
                var _path = Path.GetExtension( filePath );

                if( _path != null )
                {
                    var _extension = (EXT)Enum.Parse( typeof( EXT ), _path );

                    return Enum.IsDefined( typeof( EXT ), _extension )
                        ? _extension
                        : default( EXT );
                }

                return default( EXT );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( EXT );
            }
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="filePath">The filePath.</param>
        /// <returns></returns>
        public virtual string GetConnectionString( string extension, string filePath )
        {
            if( Verify.IsInput( extension )
                && Verify.IsInput( filePath ) )
            {
                try
                {
                    ConnectionString = extension?.ToUpper() switch
                    {
                        ".XLS" => @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                            + filePath
                            + ";Extended Properties=\"Excel 8.0;HDR=YES;\"",
                        ".Report" => @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                            + filePath
                            + ";Extended Properties=\"Excel 12.0;HDR=YES;\"",
                        _ => ConnectionString
                    };

                    return Verify.IsInput( ConnectionString )
                        ? ConnectionString
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the excel form.
        /// </summary>
        /// <param name="spreadSheet">The spreadSheet.</param>
        /// <param name="dataTable">The dataTable.</param>
        public virtual void SetExcelForm( Spreadsheet spreadSheet, DataTable dataTable )
        {
            if( spreadSheet != null
                && dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    spreadSheet.Workbook.ActiveSheet.ListObjects.Clear();
                    spreadSheet.Workbook.ActiveSheet.UsedRange.Clear( true );
                    spreadSheet.Workbook.ActiveSheet.StandardWidth = 12.5f;
                    var name = spreadSheet.Workbook.Worksheets[ 0 ].Name;
                    var sheet = spreadSheet.Workbook.ActiveSheet;
                    spreadSheet.ActiveSheet.ImportDataTable( dataTable, true, 1, 1 );
                    var range = sheet.UsedRange;
                    var table = sheet.ListObjects.Create( name, range );
                    table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium2;
                    spreadSheet.ActiveGrid.InvalidateCells();
                    spreadSheet.SetZoomFactor( "Sheet1", 110 );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the excel form.
        /// </summary>
        /// <param name="spreadSheet">The spreadSheet.</param>
        /// <param name="dataGrid">The dataGrid.</param>
        public virtual void SetExcelForm( Spreadsheet spreadSheet, DataGridView dataGrid )
        {
            if( spreadSheet != null
                && dataGrid?.DataSource != null )
            {
                try
                {
                    spreadSheet.Workbook.ActiveSheet.ListObjects.Clear();
                    spreadSheet.Workbook.ActiveSheet.StandardWidth = 12.5f;
                    var name = spreadSheet.Workbook.Worksheets[ 0 ].Name;
                    var sheet = spreadSheet.Workbook.ActiveSheet;

                    spreadSheet.ActiveSheet.ImportDataGridView( dataGrid, 1, 1, true,
                        false );

                    var range = sheet.UsedRange;
                    var table = sheet.ListObjects.Create( name, range );
                    table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium2;
                    spreadSheet.ActiveGrid.InvalidateCells();
                    spreadSheet.SetZoomFactor( "Sheet1", 110 );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void AddComment( Grid grid, string text )
        {
            if( Validate.Grid( grid )
                && Verify.IsInput( text ) )
            {
                try
                {
                    using var _range = grid?.GetRange();
                    var _excelComment = _range?.AddComment( text, "Budget" );

                    if( _excelComment != null )
                    {
                        _excelComment.From.Row = _range.Start.Row;
                        _excelComment.From.Column = _range.Start.Column;
                        _excelComment.To.Row = _range.End.Row;
                        _excelComment.To.Column = _range.End.Column;
                        _excelComment.BackgroundColor = BudgetColor.FormDark;
                        _excelComment.Font.FontName = "Consolas";
                        _excelComment.Font.Size = 8;
                        _excelComment.Font.Color = Color.Black;
                        _excelComment.Text = text;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the caption text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetCaptionText( Grid grid )
        {
            if( Validate.Grid( grid ) )
            {
                try
                {
                    using var _sheet = grid.GetWorksheet();
                    var _row = grid.GetRange().Start.Row;
                    var _column = grid.GetRange().Start.Column;
                    _sheet.Cells[ _row, _column ].Value = "Account";
                    _sheet.Cells[ _row, _column + 1 ].Value = "SuperfundSite";
                    _sheet.Cells[ _row, _column + 2 ].Value = "Travel";
                    _sheet.Cells[ _row, _column  + 3 ].Value = "Expenses";
                    _sheet.Cells[ _row, _column  + 4 ].Value = "Contracts";
                    _sheet.Cells[ _row, _column  + 5 ].Value = "Grants";
                    _sheet.Cells[ _row, _column  + 6 ].Value = "Total";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void SetText( Grid grid, IEnumerable<string> text )
        {
            if( Validate.Grid( grid )
                && text?.Any() == true 
                && grid.GetRange().Any() )
            {
                try
                {
                    foreach( var cell in grid.GetRange() )
                    {
                        foreach( var caption in text )
                        {
                            if( cell != null
                                && Verify.IsInput( caption ) )
                            {
                                cell.Value = caption;
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
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}