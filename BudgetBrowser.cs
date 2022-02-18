// <copyright file = "BudgetDialog.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;
    using static System.Environment;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DialogBase" />
    public class BudgetBrowser : DialogBase
    {
        /// <summary>
        /// Gets or sets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public string CurrentDirectory { get; set; } = Environment.CurrentDirectory;

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetBrowser"/> class.
        /// </summary>
        public BudgetBrowser()
        {
            CustomStartLocation = GetFolderPath( SpecialFolder.MyDocuments );
            SelectLocation = CustomStartLocation;
            Style = FolderBrowserStyles.BrowseForEverything;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetBrowser"/> class.
        /// </summary>
        /// <param name="directoryPath">The directory path.</param>
        public BudgetBrowser( string directoryPath )
        {
            CustomStartLocation = directoryPath;
            SelectLocation = CustomStartLocation;
            Style = FolderBrowserStyles.BrowseForEverything;
        }
    }
}
