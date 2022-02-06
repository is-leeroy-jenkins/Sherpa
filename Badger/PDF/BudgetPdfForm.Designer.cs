// // <copyright file = "BudgetPdfForm.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
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
            this.DocumentView = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.SuspendLayout();
            // 
            // DocumentView
            // 
            this.DocumentView.AutoScroll = true;
            this.DocumentView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.DocumentView.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.DocumentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentView.EnableContextMenu = true;
            this.DocumentView.HorizontalScrollOffset = 0;
            this.DocumentView.IsTextSearchEnabled = true;
            this.DocumentView.IsTextSelectionEnabled = true;
            this.DocumentView.Location = new System.Drawing.Point(0, 0);
            messageBoxSettings1.EnableNotification = true;
            this.DocumentView.MessageBoxSettings = messageBoxSettings1;
            this.DocumentView.MinimumZoomPercentage = 50;
            this.DocumentView.Name = "DocumentView";
            this.DocumentView.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.DocumentView.PrinterSettings = pdfViewerPrinterSettings1;
            this.DocumentView.ReferencePath = "C:\\Users\\terry\\source\\repos\\BudgetExecution\\Etc\\doc\\RMDS\\";
            this.DocumentView.ScrollDisplacementValue = 0;
            this.DocumentView.ShowHorizontalScrollBar = true;
            this.DocumentView.ShowVerticalScrollBar = true;
            this.DocumentView.Size = new System.Drawing.Size(1208, 764);
            this.DocumentView.SpaceBetweenPages = 8;
            this.DocumentView.TabIndex = 0;
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.DocumentView.TextSearchSettings = textSearchSettings1;
            this.DocumentView.ThemeName = "Office2016Black";
            this.DocumentView.VerticalScrollOffset = 0;
            this.DocumentView.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black;
            this.DocumentView.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // BudgetPdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1208, 764);
            this.Controls.Add(this.DocumentView);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "BudgetPdfForm";
            this.ShowIcon = false;
            this.Text = "Budget Execution";
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView DocumentView;
    }
}