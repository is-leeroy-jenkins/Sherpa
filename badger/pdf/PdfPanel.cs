// <copyright file = "PdfPanel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using Syncfusion.Windows.Forms.PdfViewer;
    using Syncfusion.Windows.PdfViewer;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl" />
    /// <seealso cref="System.IDisposable" />
    public class PdfPanel : PdfViewerControl, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the PDF
        /// </summary>
        public PdfPanel()
        {
            BackColor = ColorConfig.FormDarkBackColor;
            ForeColor = ColorConfig.ForeGray;
            EnableNotificationBar = true;
            ShowToolBar = true;
            ShowHorizontalScrollBar = true;
            ShowVerticalScrollBar = true;
            PdfFileName = DefaultFile;
        }

        /// <summary>
        /// Initializes a new instance of the PDF
        /// </summary>
        /// <param name="value">The value.</param>
        public PdfPanel( string value )
            : this()
        {
            PdfFileName = value;
            PrinterSettings.PageSize = PdfViewerPrintSize.Fit;
            PrinterSettings.ScalePercentage = 120;
            PrinterSettings.PageOrientation = PdfViewerPrintOrientation.Auto;
        }

        private string DefaultFile { get; } =
            @"C:\Users\Daddy\source\repos\Badger\guidance\FundsControlManual.pdf";

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the name of the PDF file.
        /// </summary>
        /// <value>
        /// The name of the PDF file.
        /// </value>
        public string PdfFileName { get; set; }
    }
}