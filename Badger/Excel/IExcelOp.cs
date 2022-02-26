// <copyright file = "IExcelOp.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.IO;
    using OfficeOpenXml;

    /// <summary>
    /// Defines the <see cref = "IExcelOp"/>
    /// </summary>
    public interface IExcelOp
    {
        /// <summary>
        /// The ConnectionString
        /// </summary>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        string GetConnectionString();

        /// <summary>
        /// The GetFile
        /// </summary>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        string GetFilePath();

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <returns>
        /// </returns>
        string GetFileName();

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns>
        /// </returns>
        EXT GetExtension();

        /// <summary>
        /// Gets the file stream.
        /// </summary>
        /// <param name = "filePath" >
        /// The filePath.
        /// </param>
        /// <returns>
        /// </returns>
        FileInfo GetFileStream( string filePath );

        /// <summary>
        /// The GetApplication
        /// </summary>
        /// <returns>
        /// </returns>
        ExcelPackage GetApplication();

        /// <summary>
        /// The GetWorkbook
        /// </summary>
        /// <dict name = "excel" >
        /// </dict>
        /// <dict name = "filePath" >
        /// The filePath <see cref = "string"/>
        /// </dict>
        /// <returns>
        /// The <see cref = "BudgetWorkbook"/>
        /// </returns>
        ExcelWorkbook GetWorkbook();

        /// <summary>
        /// Gets the excel workSheet.
        /// </summary>
        /// <returns>
        /// </returns>
        ExcelWorksheet GetExcelWorksheet( FundCode fundCode );

        /// <summary>
        /// The SaveWorkBook
        /// </summary>
        /// <dict name = "wb" >
        /// The wb <see cref = "BudgetWorkbook"/>
        /// </dict>
        void SaveWorkBook();
    }
}
