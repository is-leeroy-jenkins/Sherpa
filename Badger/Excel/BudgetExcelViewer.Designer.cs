// // <copyright file = "BudgetExcelViewer.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{

    partial class BudgetExcelViewer
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            this.sRibbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.Spreadsheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            ((System.ComponentModel.ISupportInitialize)(this.sRibbon)).BeginInit();
            this.sRibbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // sRibbon
            // 
            this.sRibbon.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.sRibbon.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRibbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.sRibbon.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRibbon.HideMenuButtonToolTip = true;
            this.sRibbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.sRibbon.Location = new System.Drawing.Point(0, 0);
            this.sRibbon.MenuButtonFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sRibbon.MenuButtonText = "FILE";
            this.sRibbon.MenuButtonWidth = 56;
            this.sRibbon.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.sRibbon.Name = "sRibbon";
            this.sRibbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.DarkGray;
            this.sRibbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // sRibbon.OfficeMenu
            // 
            this.sRibbon.OfficeMenu.Name = "OfficeMenu";
            this.sRibbon.OfficeMenu.ShowItemToolTips = true;
            this.sRibbon.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.sRibbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sRibbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.sRibbon.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.sRibbon.ShowQuickItemsDropDownButton = false;
            this.sRibbon.ShowRibbonDisplayOptionButton = false;
            this.sRibbon.Size = new System.Drawing.Size(1208, 155);
            this.sRibbon.Spreadsheet = null;
            this.sRibbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.sRibbon.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.sRibbon.TabIndex = 0;
            this.sRibbon.Text = "spreadsheetRibbon1";
            this.sRibbon.ThemeName = "Default";
            this.sRibbon.TitleColor = System.Drawing.Color.White;
            this.sRibbon.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Spreadsheet
            // 
            this.Spreadsheet.AllowCellContextMenu = true;
            this.Spreadsheet.AllowExtendRowColumnCount = true;
            this.Spreadsheet.AllowFiltering = false;
            this.Spreadsheet.AllowFormulaRangeSelection = true;
            this.Spreadsheet.AllowTabItemContextMenu = true;
            this.Spreadsheet.AllowZooming = true;
            this.Spreadsheet.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.Spreadsheet.CopyPaste = spreadsheetCopyPaste1;
            this.Spreadsheet.DefaultColumnCount = 101;
            this.Spreadsheet.DefaultRowCount = 101;
            this.Spreadsheet.DisplayAlerts = true;
            this.Spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spreadsheet.FileName = "Book2";
            this.Spreadsheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.Spreadsheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.Spreadsheet.IsCustomTabItemContextMenuEnabled = false;
            this.Spreadsheet.Location = new System.Drawing.Point(0, 155);
            this.Spreadsheet.Name = "Spreadsheet";
            this.Spreadsheet.SelectedTabIndex = 0;
            this.Spreadsheet.SelectedTabItem = null;
            this.Spreadsheet.ShowBusyIndicator = true;
            this.Spreadsheet.Size = new System.Drawing.Size(1208, 609);
            this.Spreadsheet.TabIndex = 1;
            this.Spreadsheet.TabItemContextMenu = null;
            this.Spreadsheet.Text = "spreadsheet1";
            this.Spreadsheet.ThemeName = "Default";
            // 
            // BudgetExcelViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionBarHeight = 30;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1208, 764);
            this.Controls.Add(this.Spreadsheet);
            this.Controls.Add(this.sRibbon);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "BudgetExcelViewer";
            this.ShowIcon = false;
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.sRibbon)).EndInit();
            this.sRibbon.ResumeLayout(false);
            this.sRibbon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon sRibbon;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet Spreadsheet;
    }
}