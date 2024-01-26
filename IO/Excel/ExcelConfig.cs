// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        11-22-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    BudgetExecution is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ExcelConfig.cs.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;
    using static System.IO.Path;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "RedundantCheckBeforeAssignment" ) ]
    public abstract class ExcelConfig : BasicReport
    {
        /// <summary>
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        public OleDbConnection DataConnection
        {
            get
            {
                return _dataConnection;
            }
            
            private protected set
            {
                _dataConnection = value;
            }
        }

        /// <summary>
        /// Gets or sets the data command.
        /// </summary>
        /// <value>
        /// The data command.
        /// </value>
        public OleDbCommand DataCommand
        {
            get
            {
                return _dataCommand;
            }
            
            private protected set
            {
                _dataCommand = value;
            }
        }

        /// <summary>
        /// Gets or sets the data adapter.
        /// </summary>
        /// <value>
        /// The data adapter.
        /// </value>
        public OleDbDataAdapter DataAdapter
        {
            get
            {
                return _dataAdapter;
            }
            
            private protected set
            {
                _dataAdapter = value;
            }
        }

        /// <summary>
        /// Gets or sets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        public FileInfo FileInfo
        {
            get
            {
                return _fileInfo;
            }
            
            private protected set
            {
                _fileInfo = value;
            }
        }

        /// <summary>
        /// Gets or sets the application.
        /// </summary>
        /// <value>
        /// The application.
        /// </value>
        public ExcelPackage Application
        {
            get
            {
                return _excelPackage;
            }
            
            private protected set
            {
                _excelPackage = value;
            }
        }

        /// <summary>
        /// Gets or sets the workbook.
        /// </summary>
        /// <value>
        /// The workbook.
        /// </value>
        public ExcelWorkbook ExcelWorkbook
        {
            get
            {
                return _excelWorkbook;
            }
            
            private protected set
            {
                _excelWorkbook = value;
            }
        }

        /// <summary>
        /// Gets or sets the worksheet.
        /// </summary>
        /// <value>
        /// The worksheet.
        /// </value>
        public ExcelWorksheet Worksheet
        {
            get
            {
                return _excelWorksheet;
            }
            
            private protected set
            {
                _excelWorksheet = value;
            }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public IList<ExcelComment> Comments
        {
            get
            {
                return _comments;
            }
            
            private protected set
            {
                _comments = value;
            }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public DataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            
            private protected set
            {
                _dataTable = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int Index
        {
            get
            {
                return _rowIndex;
            }
            
            private protected set
            {
                _rowIndex = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath
        {
            get
            {
                return _filePath;
            }
            
            private protected set
            {
                _filePath = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        {
            get
            {
                return _fileName;
            }
            
            private protected set
            {
                _fileName = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        public void SetFilePath( string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                _filePath = File.Exists( filePath )
                    ? filePath
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Sets the name of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void SetFileName( string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                _fileName = File.Exists( filePath )
                    ? GetFileNameWithoutExtension( filePath )
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public string GetConnectionString( string extension, string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( extension, nameof( extension ) );
                ThrowIf.NotExists( filePath, nameof( filePath ) );
                switch( extension?.ToUpper( ) )
                {
                    case ".XLS":
                    {
                        return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                            + filePath
                            + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
                    }
                    case ".XLSX":
                    {
                        return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                            + filePath
                            + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                    }
                    default:
                    {
                        return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                            + filePath
                            + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="excelRange"> </param>
        /// <param name="text">The text.</param>
        public void AddComment( ExcelRange excelRange, string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row - 1;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.Start.Row - 1;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn,
                    _endRow, _endColumn ];

                var _comment = _excelRange.AddComment( text, "Budget" );
                _comment.From.Row = _excelRange.Start.Row;
                _comment.From.Column = _excelRange.Start.Column;
                _comment.To.Row = _excelRange.End.Row;
                _comment.To.Column = _excelRange.End.Column;
                _comment.BackgroundColor = Color.FromArgb( 15, 15, 15 );
                _comment.Font.FontName = "Roboto";
                _comment.Font.Size = 9;
                _comment.Font.Color = Color.White;
                _comment.Text = text;
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
        /// Sets the header row format.
        /// </summary>
        /// <param name="excelRange">The excel range.</param>
        private protected void SetHeaderRowFormat( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _header = excelRange.Start.Row - 1;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.Start.Row - 1;
                var _endColumn = excelRange.End.Column;
                _headerRange = _excelWorksheet.Cells[ _header, _startColumn, _endRow, _endColumn ];
                _headerRange.Style.Font.Name = "Roboto";
                _headerRange.Style.Font.Size = 10;
                _headerRange.Style.Font.Bold = false;
                _headerRange.Style.Font.Italic = false;
                _headerRange.Style.Font.Color.SetColor( _fontColor );
                _headerRange.EntireRow.CustomHeight = true;
                _headerRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                _headerRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                _headerRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                _headerRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _headerRange.Style.Fill.BackgroundColor.SetColor( _secondaryBackColor );
            }
            catch( Exception _ex )
            {
                if( _headerRange != null )
                {
                    _headerRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the footer row format.
        /// </summary>
        /// <param name="excelRange">The excel range.</param>
        private protected void SetFooterRowFormat( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _footer = excelRange.End.Row + 1;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row + 1;
                var _endColumn = excelRange.End.Column;
                _footerRange = _excelWorksheet.Cells[ _footer, _startColumn, _endRow, _endColumn ];
                _footerRange.Style.Border.Bottom.Style = ExcelBorderStyle.Double;
            }
            catch( Exception _ex )
            {
                if( _footerRange != null )
                {
                    _footerRange = null;
                }

                Fail( _ex );
            }
        }
    }
}