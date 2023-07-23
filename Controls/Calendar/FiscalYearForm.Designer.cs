// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="FiscalYearForm.Designer.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the 
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  $CURRENT_YEAR$  Terry Eppler
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FiscalYearForm.Designer.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    sealed partial class FiscalYearForm
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
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea( );
            var legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend( );
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( FiscalYearForm ) );
            PictureBox = new Picture( );
            Title = new Label( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ContextMenu = new ContextMenu( );
            ToolTip = new SmallTip( );
            ToolStrip = new ToolStrip( );
            FirstSpacer = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            toolSeparator1 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            toolSeparator2 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            toolSeparator3 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            toolSeparator4 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            toolSeparator5 = new ToolSeparator( );
            toolSeparator6 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            toolSeparator7 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            FirstCalendarTable = new HeaderPanel( );
            FirstCalendarPanel = new Layout( );
            FirstCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
            SecondCalendarTable = new HeaderPanel( );
            SecondCalendarPanel = new Layout( );
            SecondCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
            ChartTable = new HeaderPanel( );
            ChartLayout = new Layout( );
            chart2 = new Chart( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ToolStrip.SuspendLayout( );
            FirstCalendarTable.SuspendLayout( );
            FirstCalendarPanel.SuspendLayout( );
            SecondCalendarTable.SuspendLayout( );
            SecondCalendarPanel.SuspendLayout( );
            ChartTable.SuspendLayout( );
            ChartLayout.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) chart2  ).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.EPA;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 41, 22 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 50, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1285, 31 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Budget Fiscal Year";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 3.51270556F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 96.4873F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1338, 37 );
            HeaderTable.TabIndex = 2;
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 156, 264 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(   5  ,   5  ,   5   );
            ToolTip.BindingSource = null;
            ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            ToolTip.ForeColor = System.Drawing.Color.White;
            ToolTip.InitialDelay = 500;
            ToolTip.IsDerivedStyle = true;
            ToolTip.Name = null;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            ToolTip.StyleManager = null;
            ToolTip.ThemeAuthor = "Terry D. Eppler";
            ToolTip.ThemeName = "Budget Execution";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton = null;
            ToolStrip.AddColumnButton = null;
            ToolStrip.AddTableButton = null;
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            ToolStrip.CalculatorButton = null;
            ToolStrip.CanOverrideStyle = true;
            ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            ToolStrip.ChartButton = null;
            ToolStrip.DataFilter = null;
            ToolStrip.DeleteButton = null;
            ToolStrip.DeleteColumnButton = null;
            ToolStrip.DeleteRecordButton = null;
            ToolStrip.DeleteTableButton = null;
            ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStrip.DropDown = null;
            ToolStrip.EditButton = null;
            ToolStrip.EditColumnButton = null;
            ToolStrip.EditRecordButton = null;
            ToolStrip.EditSqlButton = null;
            ToolStrip.ExcelButton = null;
            ToolStrip.FilterDataButton = null;
            ToolStrip.FirstButton = null;
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { FirstSpacer, toolSeparator1, FirstButton, toolSeparator2, PreviousButton, toolSeparator3, NextButton, toolSeparator4, LastButton, toolSeparator5, toolSeparator6, CloseButton, toolSeparator7, MenuButton } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 692 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            ToolStrip.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStrip.PreviousButton = null;
            ToolStrip.ProgressBar = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SaveButton = null;
            ToolStrip.SearchCriteriaLabel = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1338, 46 );
            ToolStrip.TabIndex = 4;
            ToolStrip.TextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(   28  ,   28  ,   28   );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // FirstSpacer
            // 
            FirstSpacer.BackColor = System.Drawing.Color.Transparent;
            FirstSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstSpacer.ForeColor = System.Drawing.Color.Black;
            FirstSpacer.Name = "FirstSpacer";
            FirstSpacer.Size = new System.Drawing.Size( 201, 27 );
            FirstSpacer.Text = "                                                 Text Block for Date Time";
            // 
            // toolSeparator1
            // 
            toolSeparator1.ForeColor = System.Drawing.Color.Black;
            toolSeparator1.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator1.Name = "toolSeparator1";
            toolSeparator1.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator1.Size = new System.Drawing.Size( 6, 28 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.Transparent;
            FirstButton.BindingSource = BindingSource;
            FirstButton.DataFilter = null;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = "First Date";
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 3 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 24 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = ToolTip;
            FirstButton.ToolType = ToolType.Ns;
            // 
            // toolSeparator2
            // 
            toolSeparator2.ForeColor = System.Drawing.Color.Black;
            toolSeparator2.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator2.Name = "toolSeparator2";
            toolSeparator2.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator2.Size = new System.Drawing.Size( 6, 28 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DataFilter = null;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Date";
            PreviousButton.Image = Resources.Images.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 3 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 24 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = ToolTip;
            PreviousButton.ToolType = ToolType.Ns;
            // 
            // toolSeparator3
            // 
            toolSeparator3.ForeColor = System.Drawing.Color.Black;
            toolSeparator3.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator3.Name = "toolSeparator3";
            toolSeparator3.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator3.Size = new System.Drawing.Size( 6, 28 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.BindingSource = BindingSource;
            NextButton.DataFilter = null;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Date";
            NextButton.Image = Resources.Images.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 3 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 24 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.Ns;
            // 
            // toolSeparator4
            // 
            toolSeparator4.ForeColor = System.Drawing.Color.Black;
            toolSeparator4.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator4.Name = "toolSeparator4";
            toolSeparator4.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator4.Size = new System.Drawing.Size( 6, 28 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.Transparent;
            LastButton.BindingSource = BindingSource;
            LastButton.DataFilter = null;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = "Last Date";
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 3 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 24 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = ToolTip;
            LastButton.ToolType = ToolType.Ns;
            // 
            // toolSeparator5
            // 
            toolSeparator5.ForeColor = System.Drawing.Color.Black;
            toolSeparator5.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator5.Name = "toolSeparator5";
            toolSeparator5.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator5.Size = new System.Drawing.Size( 6, 28 );
            // 
            // toolSeparator6
            // 
            toolSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolSeparator6.ForeColor = System.Drawing.Color.Black;
            toolSeparator6.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator6.Name = "toolSeparator6";
            toolSeparator6.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator6.Size = new System.Drawing.Size( 6, 28 );
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = BindingSource;
            CloseButton.DataFilter = null;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = "Close Application";
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 24 );
            CloseButton.Text = "toolStripButton2";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.Ns;
            // 
            // toolSeparator7
            // 
            toolSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolSeparator7.ForeColor = System.Drawing.Color.Black;
            toolSeparator7.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator7.Name = "toolSeparator7";
            toolSeparator7.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator7.Size = new System.Drawing.Size( 6, 28 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BindingSource = BindingSource;
            MenuButton.DataFilter = null;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = "Main Menu";
            MenuButton.Image = Resources.Images.WebHomeButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 3 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 24 );
            MenuButton.Text = "toolStripButton1";
            MenuButton.ToolTip = null;
            MenuButton.ToolType = ToolType.Ns;
            // 
            // FirstCalendarTable
            // 
            FirstCalendarTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FirstCalendarTable.CaptionText = "First Date";
            FirstCalendarTable.ColumnCount = 1;
            FirstCalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FirstCalendarTable.Controls.Add( FirstCalendarPanel, 0, 1 );
            FirstCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendarTable.ForeColor = System.Drawing.Color.DarkGray;
            FirstCalendarTable.Location = new System.Drawing.Point( 62, 55 );
            FirstCalendarTable.Name = "FirstCalendarTable";
            FirstCalendarTable.RowCount = 2;
            FirstCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.255639F ) );
            FirstCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.74436F ) );
            FirstCalendarTable.Size = new System.Drawing.Size( 409, 279 );
            FirstCalendarTable.TabIndex = 5;
            // 
            // FirstCalendarPanel
            // 
            FirstCalendarPanel.BackColor = System.Drawing.Color.Transparent;
            FirstCalendarPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendarPanel.BindingSource = null;
            FirstCalendarPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            FirstCalendarPanel.BorderThickness = 1;
            FirstCalendarPanel.Children = null;
            FirstCalendarPanel.Controls.Add( FirstCalendar );
            FirstCalendarPanel.DataFilter = null;
            FirstCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            FirstCalendarPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendarPanel.ForeColor = System.Drawing.Color.Transparent;
            FirstCalendarPanel.HoverText = null;
            FirstCalendarPanel.IsDerivedStyle = true;
            FirstCalendarPanel.Location = new System.Drawing.Point( 3, 24 );
            FirstCalendarPanel.Name = "FirstCalendarPanel";
            FirstCalendarPanel.Padding = new System.Windows.Forms.Padding( 1 );
            FirstCalendarPanel.Size = new System.Drawing.Size( 403, 252 );
            FirstCalendarPanel.Style = MetroSet_UI.Enums.Style.Custom;
            FirstCalendarPanel.StyleManager = null;
            FirstCalendarPanel.TabIndex = 0;
            FirstCalendarPanel.ThemeAuthor = "Terry D. Eppler";
            FirstCalendarPanel.ThemeName = "Budget Execution";
            FirstCalendarPanel.ToolTip = null;
            // 
            // FirstCalendar
            // 
            FirstCalendar.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            FirstCalendar.CanOverrideStyle = true;
            FirstCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            FirstCalendar.Location = new System.Drawing.Point( 16, 18 );
            FirstCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
            FirstCalendar.Name = "FirstCalendar";
            FirstCalendar.ShowToolTip = true;
            FirstCalendar.Size = new System.Drawing.Size( 364, 216 );
            FirstCalendar.Style.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            FirstCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            FirstCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            FirstCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            FirstCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            FirstCalendar.TabIndex = 1;
            // 
            // SecondCalendarTable
            // 
            SecondCalendarTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SecondCalendarTable.CaptionText = "Second Date";
            SecondCalendarTable.ColumnCount = 1;
            SecondCalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SecondCalendarTable.Controls.Add( SecondCalendarPanel, 0, 1 );
            SecondCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendarTable.ForeColor = System.Drawing.Color.DarkGray;
            SecondCalendarTable.Location = new System.Drawing.Point( 62, 363 );
            SecondCalendarTable.Name = "SecondCalendarTable";
            SecondCalendarTable.RowCount = 2;
            SecondCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.58964133F ) );
            SecondCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.41036F ) );
            SecondCalendarTable.Size = new System.Drawing.Size( 413, 284 );
            SecondCalendarTable.TabIndex = 6;
            // 
            // SecondCalendarPanel
            // 
            SecondCalendarPanel.BackColor = System.Drawing.Color.Transparent;
            SecondCalendarPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendarPanel.BindingSource = null;
            SecondCalendarPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            SecondCalendarPanel.BorderThickness = 1;
            SecondCalendarPanel.Children = null;
            SecondCalendarPanel.Controls.Add( SecondCalendar );
            SecondCalendarPanel.DataFilter = null;
            SecondCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondCalendarPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendarPanel.ForeColor = System.Drawing.Color.Transparent;
            SecondCalendarPanel.HoverText = null;
            SecondCalendarPanel.IsDerivedStyle = true;
            SecondCalendarPanel.Location = new System.Drawing.Point( 3, 25 );
            SecondCalendarPanel.Name = "SecondCalendarPanel";
            SecondCalendarPanel.Padding = new System.Windows.Forms.Padding( 1 );
            SecondCalendarPanel.Size = new System.Drawing.Size( 407, 256 );
            SecondCalendarPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondCalendarPanel.StyleManager = null;
            SecondCalendarPanel.TabIndex = 0;
            SecondCalendarPanel.ThemeAuthor = "Terry D. Eppler";
            SecondCalendarPanel.ThemeName = "Budget Execution";
            SecondCalendarPanel.ToolTip = null;
            // 
            // SecondCalendar
            // 
            SecondCalendar.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SecondCalendar.CanOverrideStyle = true;
            SecondCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            SecondCalendar.Location = new System.Drawing.Point( 16, 15 );
            SecondCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
            SecondCalendar.Name = "SecondCalendar";
            SecondCalendar.ShowToolTip = true;
            SecondCalendar.Size = new System.Drawing.Size( 378, 223 );
            SecondCalendar.Style.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SecondCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            SecondCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            SecondCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            SecondCalendar.TabIndex = 1;
            // 
            // ChartTable
            // 
            ChartTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ChartTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ChartTable.CaptionText = "Time Series Analysis";
            ChartTable.ColumnCount = 1;
            ChartTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartTable.Controls.Add( ChartLayout, 0, 1 );
            ChartTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartTable.ForeColor = System.Drawing.Color.DarkGray;
            ChartTable.Location = new System.Drawing.Point( 589, 55 );
            ChartTable.Name = "ChartTable";
            ChartTable.RowCount = 2;
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.38888884F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.6111145F ) );
            ChartTable.Size = new System.Drawing.Size( 709, 592 );
            ChartTable.TabIndex = 7;
            // 
            // ChartLayout
            // 
            ChartLayout.BackColor = System.Drawing.Color.Transparent;
            ChartLayout.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ChartLayout.BindingSource = null;
            ChartLayout.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ChartLayout.BorderThickness = 1;
            ChartLayout.Children = null;
            ChartLayout.Controls.Add( chart2 );
            ChartLayout.DataFilter = null;
            ChartLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartLayout.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartLayout.ForeColor = System.Drawing.Color.Transparent;
            ChartLayout.HoverText = null;
            ChartLayout.IsDerivedStyle = true;
            ChartLayout.Location = new System.Drawing.Point( 3, 27 );
            ChartLayout.Name = "ChartLayout";
            ChartLayout.Padding = new System.Windows.Forms.Padding( 1 );
            ChartLayout.Size = new System.Drawing.Size( 703, 562 );
            ChartLayout.Style = MetroSet_UI.Enums.Style.Custom;
            ChartLayout.StyleManager = null;
            ChartLayout.TabIndex = 0;
            ChartLayout.ThemeAuthor = "Terry D. Eppler";
            ChartLayout.ThemeName = "Budget Execution";
            ChartLayout.ToolTip = null;
            // 
            // chart2
            // 
            chart2.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.BackSecondaryColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.BindingSource = null;
            chart2.BorderlineColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.BorderSkin.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.BorderSkin.PageColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chartArea1.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add( chartArea1 );
            chart2.Data = null;
            chart2.DataTable = null;
            legend1.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            legend1.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            legend1.ForeColor = System.Drawing.Color.DarkGray;
            legend1.HeaderSeparatorColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            legend1.TitleSeparatorColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            chart2.Legends.Add( legend1 );
            chart2.Location = new System.Drawing.Point( 36, 15 );
            chart2.Name = "chart2";
            chart2.PaletteCustomColors = new System.Drawing.Color[ ] { System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ), System.Drawing.Color.FromArgb(   180  ,   0  ,   120  ,   202   ), System.Drawing.Color.Maroon, System.Drawing.Color.FromArgb(   255  ,   65  ,   84   ), System.Drawing.Color.FromArgb(   0  ,   64  ,   0   ), System.Drawing.Color.FromArgb(   150  ,   0  ,   64  ,   0   ) };
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add( series1 );
            chart2.Size = new System.Drawing.Size( 635, 529 );
            chart2.TabIndex = 0;
            chart2.Text = "chart2";
            // 
            // FiscalYearForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( ChartTable );
            Controls.Add( SecondCalendarTable );
            Controls.Add( FirstCalendarTable );
            Controls.Add( ToolStrip );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "FiscalYearForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            FirstCalendarTable.ResumeLayout( false );
            FirstCalendarPanel.ResumeLayout( false );
            SecondCalendarTable.ResumeLayout( false );
            SecondCalendarPanel.ResumeLayout( false );
            ChartTable.ResumeLayout( false );
            ChartLayout.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) chart2  ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public Picture PictureBox;
        public Label Title;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        public System.Windows.Forms.BindingSource BindingSource;
        public ContextMenu ContextMenu;
        public SmallTip ToolTip;
        public ToolStrip ToolStrip;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt FirstSpacer;
        private ToolSeparator toolSeparator1;
        public ToolStripButton FirstButton;
        private ToolSeparator toolSeparator2;
        public ToolStripButton PreviousButton;
        private ToolSeparator toolSeparator3;
        public ToolStripButton NextButton;
        private ToolSeparator toolSeparator4;
        public ToolStripButton LastButton;
        private ToolSeparator toolSeparator5;
        private ToolSeparator toolSeparator6;
        public ToolStripButton CloseButton;
        private ToolSeparator toolSeparator7;
        public ToolStripButton MenuButton;
        public HeaderPanel FirstCalendarTable;
        public Layout FirstCalendarPanel;
        public HeaderPanel SecondCalendarTable;
        public Layout SecondCalendarPanel;
        public Syncfusion.WinForms.Input.SfCalendar FirstCalendar;
        public Syncfusion.WinForms.Input.SfCalendar SecondCalendar;
        private HeaderPanel ChartTable;
        private Layout ChartLayout;
        private Chart chart1;
        public Chart Chart;
        private Chart chart2;
    }
}