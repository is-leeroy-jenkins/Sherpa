// // <copyright file = "IFile.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.AccessControl;

    public interface IFile
    {
        /// <summary>
        /// The path
        /// </summary>
        IPath Path { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        string FullName { get; set; }

        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>
        /// The changed date.
        /// </value>
        DateTime ChangeDate { get; set; }

        /// <summary>
        /// Gets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has parent { get; set; } otherwise, <c>false</c>.
        /// </value>
        bool HasParent { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.p/// </value>
        DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        long Length { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        FileSecurity FileSecurity { get; set; }

        /// <summary>
        /// Transfers the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        void Transfer( DirectoryInfo folder );

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="search">The search.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified search]; otherwise, <c>false</c>.
        /// </returns>
        bool Contains( string search );

        /// <summary>
        /// Searches the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        IEnumerable<FileInfo> Search( string pattern );

        /// <summary>Returns a string that
        /// represents the current object.
        /// </summary>
        /// <returns>A string that represents
        /// the current object.
        /// </returns>
        string ToString();

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        string GetFullName();

        /// <summary>
        /// Gets the Data path.
        /// </summary>
        /// <returns></returns>
        IPath GetDataPath();

        /// <summary>
        /// Moves the specified destination.
        /// </summary>
        /// <param name="filepath">The destination.</param>
        void Move( string filepath );

        /// <summary>
        /// Copies the specified filepath.
        /// </summary>
        /// <param name="filepath">The filepath.</param>
        void Copy( string filepath );

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        void Delete();

        /// <summary>
        /// Gets the file information.
        /// </summary>
        /// <returns></returns>
        FileInfo GetFileInfo();

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        IFolder GetParentFolder();
        
        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns></returns>
        EXT GetExtension();
        
        /// <summary>
        /// Gets the base stream.
        /// </summary>
        /// <returns></returns>
        FileStream GetBaseStream();
    }
}