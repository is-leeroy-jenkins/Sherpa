// <copyright file = "IPath.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPath
    {
        /// <summary>
        /// Gets or sets the full nae.
        /// </summary>
        /// <value>
        /// The full nae.
        /// </value>
        string FullName { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the path root.
        /// </summary>
        /// <value>
        /// The path root.
        /// </value>
        string PathRoot { get; set; }

        /// <summary>
        /// Gets or sets the input.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        string Input { get; set; }

        /// <summary>Returns a string that
        /// represents the current object.
        /// </summary>
        /// <returns>A string that represents
        /// the current object.
        /// </returns>
        string ToString();

        /// <summary>
        /// Changes the extension.
        /// </summary>
        /// <param name="ext">The ext.</param>
        /// <returns></returns>
        string ChangeExtension( string ext );
    }
}
