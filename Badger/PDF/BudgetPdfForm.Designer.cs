// <copyright file = "BudgetPdfForm.Designer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{

    partial class BudgetPdfForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPdfForm));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.DocumentViewer = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.SuspendLayout();
            // 
            // DocumentViewer
            // 
            this.DocumentViewer.AutoScroll = true;
            this.DocumentViewer.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.DocumentViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DocumentViewer.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.DocumentViewer.EnableContextMenu = true;
            this.DocumentViewer.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentViewer.HorizontalScrollOffset = 0;
            this.DocumentViewer.IsTextSearchEnabled = true;
            this.DocumentViewer.IsTextSelectionEnabled = true;
            this.DocumentViewer.Location = new System.Drawing.Point(63, 70);
            messageBoxSettings1.EnableNotification = true;
            this.DocumentViewer.MessageBoxSettings = messageBoxSettings1;
            this.DocumentViewer.MinimumZoomPercentage = 50;
            this.DocumentViewer.Name = "DocumentViewer";
            this.DocumentViewer.PageBorderThickness = 2;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.DocumentViewer.PrinterSettings = pdfViewerPrinterSettings1;
            this.DocumentViewer.ReferencePath = "C:\\Users\\terry\\source\\repos\\BudgetExecution\\Etc\\doc\\RMDS\\";
            this.DocumentViewer.ScrollDisplacementValue = 0;
            this.DocumentViewer.ShowHorizontalScrollBar = true;
            this.DocumentViewer.ShowVerticalScrollBar = true;
            this.DocumentViewer.Size = new System.Drawing.Size(799, 465);
            this.DocumentViewer.SpaceBetweenPages = 8;
            this.DocumentViewer.TabIndex = 0;
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.DocumentViewer.TextSearchSettings = textSearchSettings1;
            this.DocumentViewer.ThemeName = "Office2016Black";
            this.DocumentViewer.VerticalScrollOffset = 0;
            this.DocumentViewer.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black;
            this.DocumentViewer.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // BudgetPdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(915, 657);
            this.Controls.Add(this.DocumentViewer);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "BudgetPdfForm";
            this.ShowIcon = false;
            this.Text = "Budget Execution";
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView DocumentViewer;
    }
}