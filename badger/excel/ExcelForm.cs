// <copyright file = "ExcelForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Windows.Forms;
    using OfficeOpenXml;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ExcelForm : MetroForm
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
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        public OleDbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets or sets the data command.
        /// </summary>
        /// <value>
        /// The data command.
        /// </value>
        public OleDbCommand DataCommand { get; set; }

        /// <summary>
        /// Gets or sets the data adapter.
        /// </summary>
        /// <value>
        /// The data adapter.
        /// </value>
        public OleDbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets the excel package.
        /// </summary>
        /// <value>
        /// The excel package.
        /// </value>
        public ExcelPackage ExcelPackage { get; set; }

        /// <summary>
        /// Gets or sets the ext.
        /// </summary>
        /// <value>
        /// The ext.
        /// </value>
        public EXT Ext { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelForm"/> class.
        /// </summary>
        public ExcelForm()
        {
            InitializeComponent();
            Size = new Size( 1073, 900 );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelForm"/> class.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        public ExcelForm( string filepath )
        {
            InitializeComponent();
            Size = new Size( 1073, 900 );
            FilePath = Path.GetFullPath( filepath );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
            Sheet.Open( filepath );
        }
        
        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        public void SetFilePath( string filepath )
        {
            if( Verify.Input( filepath )
                && File.Exists( filepath ) )
            {
                try
                {
                    FilePath = Path.GetFileName( filepath );
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
        /// <param name="filepath">The filepath.</param>
        public void SetFileName( string filepath )
        {
            if( Verify.Input( filepath )
                && File.Exists( filepath ) )
            {
                try
                {
                    FilePath = Path.GetFileNameWithoutExtension( filepath );
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
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        public virtual EXT GetFileExtension( string filepath )
        {
            try
            {
                var _path = Path.GetExtension( filepath );

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
        /// <param name="filepath">The filepath.</param>
        /// <returns></returns>
        public virtual string GetConnectionString( string extension, string filepath )
        {
            if( Verify.Input( extension )
                && Verify.Input( filepath ) )
            {
                try
                {
                    ConnectionString = extension?.ToUpper() switch
                    {
                        ".XLS" => @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                            + filepath
                            + ";Extended Properties=\"Excel 8.0;HDR=YES;\"",
                        ".Report" => @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                            + filepath
                            + ";Extended Properties=\"Excel 12.0;HDR=YES;\"",
                        _ => ConnectionString
                    };

                    return Verify.Input( ConnectionString )
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