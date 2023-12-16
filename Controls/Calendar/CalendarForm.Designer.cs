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
    sealed partial class CalendarForm
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
            var dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( CalendarForm ) );
            PictureBox = new Picture( );
            Title = new Label( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            ToolStrip = new ToolStrip( );
            Separator11 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            Spacer = new ToolStripLabel( );
            DataLabel = new ToolStripLabel( );
            Separator1 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            Separator2 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            Separator3 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            Separator6 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            CloseButton = new ToolStripButton( );
            NavigationLabel = new ToolStripLabel( );
            NavigationSeparator = new ToolSeparator( );
            TimeSpanInformation = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            TableButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            Separator13 = new ToolSeparator( );
            ChartButton = new ToolStripButton( );
            ChartSeparator = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            StripSeparator = new ToolSeparator( );
            Separator12 = new ToolSeparator( );
            Separator7 = new ToolSeparator( );
            FirstCalendarTable = new HeaderPanel( );
            FirstCalendarPanel = new BackPanel( );
            FirstCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
            SecondCalendarTable = new HeaderPanel( );
            SecondCalendarPanel = new BackPanel( );
            SecondCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
            ChartTable = new HeaderPanel( );
            TabControl = new TabControl( );
            ChartTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            ChartLayout = new BackPanel( );
            Chart = new Chart( );
            DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            GridPanel = new BackPanel( );
            DataGrid = new DataGrid( );
            BusyTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            Loader = new System.Windows.Forms.PictureBox( );
            TimeTableLayout = new BackPanel( );
            TimeSpanTable = new System.Windows.Forms.TableLayoutPanel( );
            Label11 = new Label( );
            Label3 = new Label( );
            Label2 = new Label( );
            Label1 = new Label( );
            Label4 = new Label( );
            Label5 = new Label( );
            Label6 = new Label( );
            Label7 = new Label( );
            Label8 = new Label( );
            Label9 = new Label( );
            Label12 = new Label( );
            Label10 = new Label( );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ToolStrip.SuspendLayout( );
            FirstCalendarTable.SuspendLayout( );
            FirstCalendarPanel.SuspendLayout( );
            SecondCalendarTable.SuspendLayout( );
            SecondCalendarPanel.SuspendLayout( );
            ChartTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            ChartTab.SuspendLayout( );
            ChartLayout.SuspendLayout( );
            DataTab.SuspendLayout( );
            GridPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)DataGrid ).BeginInit( );
            BusyTab.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Loader ).BeginInit( );
            TimeTableLayout.SuspendLayout( );
            TimeSpanTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.CalendarTile;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 32, 31 );
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
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F );
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
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
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
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F );
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
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F );
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator11, StatusLabel, Spacer, DataLabel, Separator1, FirstButton, Separator2, PreviousButton, Separator3, NextButton, Separator4, LastButton, Separator5, Separator6, RefreshButton, CloseButton, NavigationLabel, NavigationSeparator, TimeSpanInformation, TableButton, Separator8, Separator13, ChartButton, ChartSeparator, MenuButton } );
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
            ToolStrip.RefreshButton = null;
            ToolStrip.SaveButton = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1338, 46 );
            ToolStrip.TabIndex = 4;
            ToolStrip.TextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb( 28, 28, 28 );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 28 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.Transparent;
            StatusLabel.BindingSource = BindingSource;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 65, 28 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date and Time";
            StatusLabel.ToolTip = ToolTip;
            // 
            // Spacer
            // 
            Spacer.BackColor = System.Drawing.Color.Transparent;
            Spacer.BindingSource = null;
            Spacer.DataFilter = null;
            Spacer.Field = Field.AccountCode;
            Spacer.Font = new System.Drawing.Font( "Roboto", 8F );
            Spacer.ForeColor = System.Drawing.Color.Transparent;
            Spacer.HoverText = null;
            Spacer.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Spacer.Name = "Spacer";
            Spacer.Padding = new System.Windows.Forms.Padding( 1 );
            Spacer.Size = new System.Drawing.Size( 188, 28 );
            Spacer.Tag = "";
            Spacer.Text = "                               Navigation:          ";
            Spacer.ToolTip = null;
            // 
            // DataLabel
            // 
            DataLabel.BackColor = System.Drawing.Color.Transparent;
            DataLabel.BindingSource = null;
            DataLabel.DataFilter = null;
            DataLabel.Field = Field.AccountCode;
            DataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            DataLabel.ForeColor = System.Drawing.Color.Black;
            DataLabel.HoverText = null;
            DataLabel.Margin = new System.Windows.Forms.Padding( 1 );
            DataLabel.Name = "DataLabel";
            DataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            DataLabel.Size = new System.Drawing.Size( 100, 28 );
            DataLabel.Tag = "";
            DataLabel.Text = "                           Data:         ";
            DataLabel.ToolTip = null;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 28 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.Transparent;
            FirstButton.BindingSource = BindingSource;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Filter = null;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = "First Date";
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 28 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = ToolTip;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 28 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Filter = null;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Date";
            PreviousButton.Image = Resources.Images.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 28 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = ToolTip;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 28 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.BindingSource = BindingSource;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Filter = null;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Date";
            NextButton.Image = Resources.Images.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 28 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 28 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.Transparent;
            LastButton.BindingSource = BindingSource;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Filter = null;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = "Last Date";
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 28 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = ToolTip;
            LastButton.ToolType = ToolType.LastButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Separator6
            // 
            Separator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 28 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.Transparent;
            RefreshButton.BindingSource = BindingSource;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Field = Field.AccountCode;
            RefreshButton.Filter = null;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            RefreshButton.HoverText = "Refresh Data";
            RefreshButton.Image = Resources.Images.RefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.Size = new System.Drawing.Size( 23, 28 );
            RefreshButton.Text = "toolStripButton1";
            RefreshButton.ToolTip = ToolTip;
            RefreshButton.ToolType = ToolType.Ns;
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = BindingSource;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Filter = null;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = "Close Application";
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 28 );
            CloseButton.Text = "toolStripButton2";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.Ns;
            // 
            // NavigationLabel
            // 
            NavigationLabel.BackColor = System.Drawing.Color.Transparent;
            NavigationLabel.BindingSource = null;
            NavigationLabel.DataFilter = null;
            NavigationLabel.Field = Field.AccountCode;
            NavigationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            NavigationLabel.ForeColor = System.Drawing.Color.Black;
            NavigationLabel.HoverText = null;
            NavigationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            NavigationLabel.Size = new System.Drawing.Size( 133, 28 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "                               Navigation:          ";
            NavigationLabel.ToolTip = null;
            // 
            // NavigationSeparator
            // 
            NavigationSeparator.ForeColor = System.Drawing.Color.Black;
            NavigationSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            NavigationSeparator.Name = "NavigationSeparator";
            NavigationSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            NavigationSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // TimeSpanInformation
            // 
            TimeSpanInformation.BackColor = System.Drawing.Color.Transparent;
            TimeSpanInformation.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TimeSpanInformation.ForeColor = System.Drawing.Color.Black;
            TimeSpanInformation.Name = "TimeSpanInformation";
            TimeSpanInformation.Size = new System.Drawing.Size( 0, 27 );
            // 
            // TableButton
            // 
            TableButton.AutoToolTip = false;
            TableButton.BackColor = System.Drawing.Color.Transparent;
            TableButton.BindingSource = BindingSource;
            TableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            TableButton.Field = Field.AccountCode;
            TableButton.Filter = null;
            TableButton.Font = new System.Drawing.Font( "Roboto", 9F );
            TableButton.ForeColor = System.Drawing.Color.LightGray;
            TableButton.HoverText = "View Data";
            TableButton.Image = Resources.Images.TableButton;
            TableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            TableButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            TableButton.Name = "TableButton";
            TableButton.Padding = new System.Windows.Forms.Padding( 1 );
            TableButton.Size = new System.Drawing.Size( 23, 28 );
            TableButton.Text = "toolStripButton1";
            TableButton.ToolTip = ToolTip;
            TableButton.ToolType = ToolType.Ns;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Separator13
            // 
            Separator13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ChartButton
            // 
            ChartButton.AutoToolTip = false;
            ChartButton.BackColor = System.Drawing.Color.Transparent;
            ChartButton.BindingSource = BindingSource;
            ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ChartButton.Field = Field.AccountCode;
            ChartButton.Filter = null;
            ChartButton.Font = new System.Drawing.Font( "Roboto", 9F );
            ChartButton.ForeColor = System.Drawing.Color.LightGray;
            ChartButton.HoverText = "Visualization";
            ChartButton.Image = Resources.Images.ChartButton;
            ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ChartButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ChartButton.Name = "ChartButton";
            ChartButton.Padding = new System.Windows.Forms.Padding( 1 );
            ChartButton.Size = new System.Drawing.Size( 23, 28 );
            ChartButton.Text = "toolStripButton2";
            ChartButton.ToolTip = ToolTip;
            ChartButton.ToolType = ToolType.Ns;
            // 
            // ChartSeparator
            // 
            ChartSeparator.ForeColor = System.Drawing.Color.Black;
            ChartSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            ChartSeparator.Name = "ChartSeparator";
            ChartSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BindingSource = BindingSource;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Filter = null;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = "Main Menu";
            MenuButton.Image = Resources.Images.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 24 );
            MenuButton.Text = "toolStripButton1";
            MenuButton.ToolTip = null;
            MenuButton.ToolType = ToolType.Ns;
            // 
            // StripSeparator
            // 
            StripSeparator.ForeColor = System.Drawing.Color.Black;
            StripSeparator.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            StripSeparator.Name = "StripSeparator";
            StripSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            StripSeparator.Size = new System.Drawing.Size( 6, 46 );
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 46 );
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 46 );
            // 
            // FirstCalendarTable
            // 
            FirstCalendarTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FirstCalendarTable.CaptionText = "First Date";
            FirstCalendarTable.ColumnCount = 1;
            FirstCalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FirstCalendarTable.Controls.Add( FirstCalendarPanel, 0, 1 );
            FirstCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F );
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
            FirstCalendarPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendarPanel.BindingSource = null;
            FirstCalendarPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            FirstCalendarPanel.BorderThickness = 1;
            FirstCalendarPanel.Children = null;
            FirstCalendarPanel.Controls.Add( FirstCalendar );
            FirstCalendarPanel.DataFilter = null;
            FirstCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            FirstCalendarPanel.Font = new System.Drawing.Font( "Roboto", 8F );
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
            FirstCalendar.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            FirstCalendar.CanOverrideStyle = true;
            FirstCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            FirstCalendar.Location = new System.Drawing.Point( 16, 18 );
            FirstCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
            FirstCalendar.Name = "FirstCalendar";
            FirstCalendar.SelectedDate = new System.DateTime( 2023, 7, 24, 0, 0, 0, 0 );
            FirstCalendar.ShowToolTip = true;
            FirstCalendar.Size = new System.Drawing.Size( 364, 216 );
            FirstCalendar.Style.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F );
            FirstCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F );
            FirstCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold );
            FirstCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold );
            FirstCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F );
            FirstCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F );
            FirstCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F );
            FirstCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold );
            FirstCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
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
            SecondCalendarTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SecondCalendarTable.CaptionText = "Second Date";
            SecondCalendarTable.ColumnCount = 1;
            SecondCalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SecondCalendarTable.Controls.Add( SecondCalendarPanel, 0, 1 );
            SecondCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F );
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
            SecondCalendarPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendarPanel.BindingSource = null;
            SecondCalendarPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            SecondCalendarPanel.BorderThickness = 1;
            SecondCalendarPanel.Children = null;
            SecondCalendarPanel.Controls.Add( SecondCalendar );
            SecondCalendarPanel.DataFilter = null;
            SecondCalendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondCalendarPanel.Font = new System.Drawing.Font( "Roboto", 8F );
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
            SecondCalendar.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            SecondCalendar.CanOverrideStyle = true;
            SecondCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            SecondCalendar.Location = new System.Drawing.Point( 16, 15 );
            SecondCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
            SecondCalendar.Name = "SecondCalendar";
            SecondCalendar.SelectedDate = new System.DateTime( 2023, 7, 24, 0, 0, 0, 0 );
            SecondCalendar.ShowToolTip = true;
            SecondCalendar.Size = new System.Drawing.Size( 378, 223 );
            SecondCalendar.Style.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F );
            SecondCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F );
            SecondCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold );
            SecondCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold );
            SecondCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F );
            SecondCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F );
            SecondCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F );
            SecondCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold );
            SecondCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
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
            ChartTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ChartTable.CaptionText = "Time Delta";
            ChartTable.ColumnCount = 1;
            ChartTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ChartTable.Controls.Add( TabControl, 0, 1 );
            ChartTable.Controls.Add( TimeTableLayout, 0, 2 );
            ChartTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ChartTable.ForeColor = System.Drawing.Color.DarkGray;
            ChartTable.Location = new System.Drawing.Point( 589, 52 );
            ChartTable.Name = "ChartTable";
            ChartTable.RowCount = 3;
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 0.392817169F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 99.6071854F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 104F ) );
            ChartTable.Size = new System.Drawing.Size( 737, 592 );
            ChartTable.TabIndex = 7;
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 731, 464 );
            TabControl.BindingSource = null;
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( ChartTab );
            TabControl.Controls.Add( DataTab );
            TabControl.Controls.Add( BusyTab );
            TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 9F );
            TabControl.ForeColor = System.Drawing.Color.LightGray;
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 100, 1 );
            TabControl.Location = new System.Drawing.Point( 3, 20 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 731, 464 );
            TabControl.TabIndex = 0;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.DarkGray;
            TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ToolTip = ToolTip;
            // 
            // ChartTab
            // 
            ChartTab.Controls.Add( ChartLayout );
            ChartTab.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ChartTab.Image = null;
            ChartTab.ImageSize = new System.Drawing.Size( 16, 16 );
            ChartTab.Location = new System.Drawing.Point( 0, 0 );
            ChartTab.Name = "ChartTab";
            ChartTab.ShowCloseButton = true;
            ChartTab.Size = new System.Drawing.Size( 731, 464 );
            ChartTab.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartTab.TabForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ChartTab.TabIndex = 2;
            ChartTab.ThemesEnabled = false;
            // 
            // ChartLayout
            // 
            ChartLayout.BackColor = System.Drawing.Color.Transparent;
            ChartLayout.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartLayout.BindingSource = null;
            ChartLayout.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ChartLayout.BorderThickness = 1;
            ChartLayout.Children = null;
            ChartLayout.Controls.Add( Chart );
            ChartLayout.DataFilter = null;
            ChartLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartLayout.Font = new System.Drawing.Font( "Roboto", 8F );
            ChartLayout.ForeColor = System.Drawing.Color.Transparent;
            ChartLayout.HoverText = null;
            ChartLayout.IsDerivedStyle = true;
            ChartLayout.Location = new System.Drawing.Point( 0, 0 );
            ChartLayout.Name = "ChartLayout";
            ChartLayout.Padding = new System.Windows.Forms.Padding( 1 );
            ChartLayout.Size = new System.Drawing.Size( 731, 464 );
            ChartLayout.Style = MetroSet_UI.Enums.Style.Custom;
            ChartLayout.StyleManager = null;
            ChartLayout.TabIndex = 0;
            ChartLayout.ThemeAuthor = "Terry D. Eppler";
            ChartLayout.ThemeName = "Budget Execution";
            ChartLayout.ToolTip = null;
            // 
            // Chart
            // 
            Chart.AllowGapForEmptyPoints = false;
            Chart.AllowGradientPalette = true;
            Chart.AllowUserEditStyles = true;
            Chart.AutoHighlight = true;
            Chart.ChartArea.AutoScale = true;
            Chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            Chart.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Chart.ChartArea.CursorLocation = new System.Drawing.Point( 0, 0 );
            Chart.ChartArea.CursorReDraw = false;
            Chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins( 3, 3, 3, 3 );
            Chart.ColumnDrawMode = Syncfusion.Windows.Forms.Chart.ChartColumnDrawMode.ClusteredMode;
            Chart.CustomPalette = new System.Drawing.Color[ ]
    {
    System.Drawing.Color.FromArgb(0, 120, 212),
    System.Drawing.Color.SlateGray,
    System.Drawing.Color.Olive,
    System.Drawing.Color.Maroon
    };
            Chart.Depth = 250F;
            Chart.DisplayChartContextMenu = false;
            Chart.DisplaySeriesContextMenu = false;
            Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            Chart.EnableMouseRotation = true;
            Chart.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Chart.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Chart.IsWindowLess = false;
            // 
            // 
            // 
            Chart.Legend.Font = new System.Drawing.Font( "Roboto", 9F );
            Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            Chart.Legend.ItemsShadowColor = System.Drawing.Color.Transparent;
            Chart.Legend.ItemsSize = new System.Drawing.Size( 12, 12 );
            Chart.Legend.Location = new System.Drawing.Point( 619, 60 );
            Chart.Legend.ShowItemsShadow = true;
            Chart.Legend.ShowSymbol = true;
            Chart.Legend.VisibleCheckBox = true;
            Chart.Localize = null;
            Chart.Location = new System.Drawing.Point( 1, 1 );
            Chart.Margin = new System.Windows.Forms.Padding( 1 );
            Chart.MouseAction = Syncfusion.Windows.Forms.Chart.ChartMouseAction.Panning;
            Chart.Name = "Chart";
            Chart.Padding = new System.Windows.Forms.Padding( 1 );
            Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            Chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            Chart.PrimaryXAxis.Margin = true;
            Chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            Chart.PrimaryYAxis.Margin = true;
            Chart.RealMode3D = true;
            Chart.Rotation = 0.1F;
            Chart.Series3D = true;
            Chart.SeriesHighlight = true;
            Chart.ShowScrollBars = false;
            Chart.ShowToolbar = true;
            Chart.Size = new System.Drawing.Size( 729, 462 );
            Chart.Skins = Syncfusion.Windows.Forms.Chart.Skins.Office2016Black;
            Chart.Spacing = 5F;
            Chart.SpacingBetweenPoints = 5F;
            Chart.Style3D = true;
            Chart.TabIndex = 0;
            Chart.Text = "Chart";
            Chart.Tilt = 5F;
            // 
            // 
            // 
            Chart.Title.Font = new System.Drawing.Font( "Roboto", 10F );
            Chart.Title.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Chart.Title.Name = "Default";
            Chart.Titles.Add( Chart.Title );
            Chart.ToolBar.ButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Chart.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            Chart.ToolBar.ShowBorder = false;
            Chart.ToolBar.ShowGrip = false;
            Chart.ToolBar.Visible = true;
            Chart.VisualTheme = "";
            // 
            // DataTab
            // 
            DataTab.Controls.Add( GridPanel );
            DataTab.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DataTab.Image = null;
            DataTab.ImageSize = new System.Drawing.Size( 16, 16 );
            DataTab.Location = new System.Drawing.Point( 0, 0 );
            DataTab.Name = "DataTab";
            DataTab.ShowCloseButton = true;
            DataTab.Size = new System.Drawing.Size( 731, 464 );
            DataTab.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataTab.TabForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DataTab.TabIndex = 1;
            DataTab.ThemesEnabled = false;
            // 
            // GridPanel
            // 
            GridPanel.BackColor = System.Drawing.Color.Transparent;
            GridPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            GridPanel.BindingSource = null;
            GridPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            GridPanel.BorderThickness = 1;
            GridPanel.Children = null;
            GridPanel.Controls.Add( DataGrid );
            GridPanel.DataFilter = null;
            GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            GridPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            GridPanel.ForeColor = System.Drawing.Color.Transparent;
            GridPanel.HoverText = null;
            GridPanel.IsDerivedStyle = true;
            GridPanel.Location = new System.Drawing.Point( 0, 0 );
            GridPanel.Name = "GridPanel";
            GridPanel.Padding = new System.Windows.Forms.Padding( 1 );
            GridPanel.Size = new System.Drawing.Size( 731, 464 );
            GridPanel.Style = MetroSet_UI.Enums.Style.Custom;
            GridPanel.StyleManager = null;
            GridPanel.TabIndex = 0;
            GridPanel.ThemeAuthor = "Terry D. Eppler";
            GridPanel.ThemeName = "Budget Execution";
            GridPanel.ToolTip = null;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb( 50, 50, 50 );
            dataGridViewCellStyle1.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            DataGrid.BackgroundColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            DataGrid.BindingSource = BindingSource;
            DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font( "Roboto", 9F );
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.DataFilter = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            dataGridViewCellStyle3.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.EnableHeadersVisualStyles = false;
            DataGrid.Font = new System.Drawing.Font( "Roboto", 8F );
            DataGrid.GridColor = System.Drawing.Color.FromArgb( 141, 139, 138 );
            DataGrid.HoverText = null;
            DataGrid.Location = new System.Drawing.Point( 15, 16 );
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb( 50, 50, 50 );
            dataGridViewCellStyle4.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            dataGridViewCellStyle5.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new System.Drawing.Size( 697, 422 );
            DataGrid.TabIndex = 1;
            DataGrid.ToolTip = null;
            // 
            // BusyTab
            // 
            BusyTab.Controls.Add( Loader );
            BusyTab.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BusyTab.Image = null;
            BusyTab.ImageSize = new System.Drawing.Size( 16, 16 );
            BusyTab.Location = new System.Drawing.Point( 0, 0 );
            BusyTab.Name = "BusyTab";
            BusyTab.ShowCloseButton = true;
            BusyTab.Size = new System.Drawing.Size( 731, 464 );
            BusyTab.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BusyTab.TabForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BusyTab.TabIndex = 3;
            BusyTab.ThemesEnabled = false;
            // 
            // Loader
            // 
            Loader.Dock = System.Windows.Forms.DockStyle.Fill;
            Loader.Image = Resources.Images.Loading;
            Loader.Location = new System.Drawing.Point( 0, 0 );
            Loader.Name = "Loader";
            Loader.Size = new System.Drawing.Size( 731, 464 );
            Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Loader.TabIndex = 0;
            Loader.TabStop = false;
            // 
            // TimeTableLayout
            // 
            TimeTableLayout.BackColor = System.Drawing.Color.Transparent;
            TimeTableLayout.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TimeTableLayout.BindingSource = null;
            TimeTableLayout.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TimeTableLayout.BorderThickness = 1;
            TimeTableLayout.Children = null;
            TimeTableLayout.Controls.Add( TimeSpanTable );
            TimeTableLayout.DataFilter = null;
            TimeTableLayout.Font = new System.Drawing.Font( "Roboto", 8F );
            TimeTableLayout.ForeColor = System.Drawing.Color.Transparent;
            TimeTableLayout.HoverText = null;
            TimeTableLayout.IsDerivedStyle = true;
            TimeTableLayout.Location = new System.Drawing.Point( 3, 490 );
            TimeTableLayout.Name = "TimeTableLayout";
            TimeTableLayout.Padding = new System.Windows.Forms.Padding( 1 );
            TimeTableLayout.Size = new System.Drawing.Size( 731, 99 );
            TimeTableLayout.Style = MetroSet_UI.Enums.Style.Custom;
            TimeTableLayout.StyleManager = null;
            TimeTableLayout.TabIndex = 1;
            TimeTableLayout.ThemeAuthor = "Terry D. Eppler";
            TimeTableLayout.ThemeName = "Budget Execution";
            TimeTableLayout.ToolTip = null;
            // 
            // TimeSpanTable
            // 
            TimeSpanTable.ColumnCount = 4;
            TimeSpanTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            TimeSpanTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            TimeSpanTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            TimeSpanTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            TimeSpanTable.Controls.Add( Label11, 2, 2 );
            TimeSpanTable.Controls.Add( Label3, 2, 0 );
            TimeSpanTable.Controls.Add( Label2, 1, 0 );
            TimeSpanTable.Controls.Add( Label1, 0, 0 );
            TimeSpanTable.Controls.Add( Label4, 3, 0 );
            TimeSpanTable.Controls.Add( Label5, 0, 1 );
            TimeSpanTable.Controls.Add( Label6, 1, 1 );
            TimeSpanTable.Controls.Add( Label7, 2, 1 );
            TimeSpanTable.Controls.Add( Label8, 3, 1 );
            TimeSpanTable.Controls.Add( Label9, 0, 2 );
            TimeSpanTable.Controls.Add( Label12, 3, 2 );
            TimeSpanTable.Controls.Add( Label10, 1, 2 );
            TimeSpanTable.Dock = System.Windows.Forms.DockStyle.Fill;
            TimeSpanTable.Location = new System.Drawing.Point( 1, 1 );
            TimeSpanTable.Name = "TimeSpanTable";
            TimeSpanTable.RowCount = 3;
            TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 31F ) );
            TimeSpanTable.Size = new System.Drawing.Size( 729, 97 );
            TimeSpanTable.TabIndex = 2;
            // 
            // Label11
            // 
            Label11.BindingSource = null;
            Label11.DataFilter = null;
            Label11.Dock = System.Windows.Forms.DockStyle.Fill;
            Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label11.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label11.HoverText = null;
            Label11.IsDerivedStyle = true;
            Label11.Location = new System.Drawing.Point( 367, 69 );
            Label11.Margin = new System.Windows.Forms.Padding( 3 );
            Label11.Name = "Label11";
            Label11.Padding = new System.Windows.Forms.Padding( 1 );
            Label11.Size = new System.Drawing.Size( 176, 25 );
            Label11.Style = MetroSet_UI.Enums.Style.Custom;
            Label11.StyleManager = null;
            Label11.TabIndex = 10;
            Label11.Text = "Text";
            Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label11.ThemeAuthor = "Terry D. Eppler";
            Label11.ThemeName = "Budget Execution";
            Label11.ToolTip = null;
            // 
            // Label3
            // 
            Label3.BindingSource = null;
            Label3.DataFilter = null;
            Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label3.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label3.HoverText = null;
            Label3.IsDerivedStyle = true;
            Label3.Location = new System.Drawing.Point( 367, 3 );
            Label3.Margin = new System.Windows.Forms.Padding( 3 );
            Label3.Name = "Label3";
            Label3.Padding = new System.Windows.Forms.Padding( 1 );
            Label3.Size = new System.Drawing.Size( 176, 27 );
            Label3.Style = MetroSet_UI.Enums.Style.Custom;
            Label3.StyleManager = null;
            Label3.TabIndex = 2;
            Label3.Text = "Text";
            Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label3.ThemeAuthor = "Terry D. Eppler";
            Label3.ThemeName = "Budget Execution";
            Label3.ToolTip = null;
            // 
            // Label2
            // 
            Label2.BindingSource = null;
            Label2.DataFilter = null;
            Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label2.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label2.HoverText = null;
            Label2.IsDerivedStyle = true;
            Label2.Location = new System.Drawing.Point( 185, 3 );
            Label2.Margin = new System.Windows.Forms.Padding( 3 );
            Label2.Name = "Label2";
            Label2.Padding = new System.Windows.Forms.Padding( 1 );
            Label2.Size = new System.Drawing.Size( 176, 27 );
            Label2.Style = MetroSet_UI.Enums.Style.Custom;
            Label2.StyleManager = null;
            Label2.TabIndex = 1;
            Label2.Text = "Text";
            Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label2.ThemeAuthor = "Terry D. Eppler";
            Label2.ThemeName = "Budget Execution";
            Label2.ToolTip = null;
            // 
            // Label1
            // 
            Label1.BindingSource = null;
            Label1.DataFilter = null;
            Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label1.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label1.HoverText = null;
            Label1.IsDerivedStyle = true;
            Label1.Location = new System.Drawing.Point( 3, 3 );
            Label1.Margin = new System.Windows.Forms.Padding( 3 );
            Label1.Name = "Label1";
            Label1.Padding = new System.Windows.Forms.Padding( 1 );
            Label1.Size = new System.Drawing.Size( 176, 27 );
            Label1.Style = MetroSet_UI.Enums.Style.Custom;
            Label1.StyleManager = null;
            Label1.TabIndex = 0;
            Label1.Text = "Text";
            Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label1.ThemeAuthor = "Terry D. Eppler";
            Label1.ThemeName = "Budget Execution";
            Label1.ToolTip = null;
            // 
            // Label4
            // 
            Label4.BindingSource = null;
            Label4.DataFilter = null;
            Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label4.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label4.HoverText = null;
            Label4.IsDerivedStyle = true;
            Label4.Location = new System.Drawing.Point( 549, 3 );
            Label4.Margin = new System.Windows.Forms.Padding( 3 );
            Label4.Name = "Label4";
            Label4.Padding = new System.Windows.Forms.Padding( 1 );
            Label4.Size = new System.Drawing.Size( 177, 27 );
            Label4.Style = MetroSet_UI.Enums.Style.Custom;
            Label4.StyleManager = null;
            Label4.TabIndex = 3;
            Label4.Text = "Text";
            Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label4.ThemeAuthor = "Terry D. Eppler";
            Label4.ThemeName = "Budget Execution";
            Label4.ToolTip = null;
            // 
            // Label5
            // 
            Label5.BindingSource = null;
            Label5.DataFilter = null;
            Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label5.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label5.HoverText = null;
            Label5.IsDerivedStyle = true;
            Label5.Location = new System.Drawing.Point( 3, 36 );
            Label5.Margin = new System.Windows.Forms.Padding( 3 );
            Label5.Name = "Label5";
            Label5.Padding = new System.Windows.Forms.Padding( 1 );
            Label5.Size = new System.Drawing.Size( 176, 27 );
            Label5.Style = MetroSet_UI.Enums.Style.Custom;
            Label5.StyleManager = null;
            Label5.TabIndex = 4;
            Label5.Text = "Text";
            Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label5.ThemeAuthor = "Terry D. Eppler";
            Label5.ThemeName = "Budget Execution";
            Label5.ToolTip = null;
            // 
            // Label6
            // 
            Label6.BindingSource = null;
            Label6.DataFilter = null;
            Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label6.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label6.HoverText = null;
            Label6.IsDerivedStyle = true;
            Label6.Location = new System.Drawing.Point( 185, 36 );
            Label6.Margin = new System.Windows.Forms.Padding( 3 );
            Label6.Name = "Label6";
            Label6.Padding = new System.Windows.Forms.Padding( 1 );
            Label6.Size = new System.Drawing.Size( 176, 27 );
            Label6.Style = MetroSet_UI.Enums.Style.Custom;
            Label6.StyleManager = null;
            Label6.TabIndex = 5;
            Label6.Text = "Text";
            Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label6.ThemeAuthor = "Terry D. Eppler";
            Label6.ThemeName = "Budget Execution";
            Label6.ToolTip = null;
            // 
            // Label7
            // 
            Label7.BindingSource = null;
            Label7.DataFilter = null;
            Label7.Dock = System.Windows.Forms.DockStyle.Fill;
            Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label7.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label7.HoverText = null;
            Label7.IsDerivedStyle = true;
            Label7.Location = new System.Drawing.Point( 367, 36 );
            Label7.Margin = new System.Windows.Forms.Padding( 3 );
            Label7.Name = "Label7";
            Label7.Padding = new System.Windows.Forms.Padding( 1 );
            Label7.Size = new System.Drawing.Size( 176, 27 );
            Label7.Style = MetroSet_UI.Enums.Style.Custom;
            Label7.StyleManager = null;
            Label7.TabIndex = 6;
            Label7.Text = "Text";
            Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label7.ThemeAuthor = "Terry D. Eppler";
            Label7.ThemeName = "Budget Execution";
            Label7.ToolTip = null;
            // 
            // Label8
            // 
            Label8.BindingSource = null;
            Label8.DataFilter = null;
            Label8.Dock = System.Windows.Forms.DockStyle.Fill;
            Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label8.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label8.HoverText = null;
            Label8.IsDerivedStyle = true;
            Label8.Location = new System.Drawing.Point( 549, 36 );
            Label8.Margin = new System.Windows.Forms.Padding( 3 );
            Label8.Name = "Label8";
            Label8.Padding = new System.Windows.Forms.Padding( 1 );
            Label8.Size = new System.Drawing.Size( 177, 27 );
            Label8.Style = MetroSet_UI.Enums.Style.Custom;
            Label8.StyleManager = null;
            Label8.TabIndex = 7;
            Label8.Text = "Text";
            Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label8.ThemeAuthor = "Terry D. Eppler";
            Label8.ThemeName = "Budget Execution";
            Label8.ToolTip = null;
            // 
            // Label9
            // 
            Label9.BindingSource = null;
            Label9.DataFilter = null;
            Label9.Dock = System.Windows.Forms.DockStyle.Fill;
            Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label9.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label9.HoverText = null;
            Label9.IsDerivedStyle = true;
            Label9.Location = new System.Drawing.Point( 3, 69 );
            Label9.Margin = new System.Windows.Forms.Padding( 3 );
            Label9.Name = "Label9";
            Label9.Padding = new System.Windows.Forms.Padding( 1 );
            Label9.Size = new System.Drawing.Size( 176, 25 );
            Label9.Style = MetroSet_UI.Enums.Style.Custom;
            Label9.StyleManager = null;
            Label9.TabIndex = 8;
            Label9.Text = "Text";
            Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label9.ThemeAuthor = "Terry D. Eppler";
            Label9.ThemeName = "Budget Execution";
            Label9.ToolTip = null;
            // 
            // Label12
            // 
            Label12.BindingSource = null;
            Label12.DataFilter = null;
            Label12.Dock = System.Windows.Forms.DockStyle.Fill;
            Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label12.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label12.HoverText = null;
            Label12.IsDerivedStyle = true;
            Label12.Location = new System.Drawing.Point( 549, 69 );
            Label12.Margin = new System.Windows.Forms.Padding( 3 );
            Label12.Name = "Label12";
            Label12.Padding = new System.Windows.Forms.Padding( 1 );
            Label12.Size = new System.Drawing.Size( 177, 25 );
            Label12.Style = MetroSet_UI.Enums.Style.Custom;
            Label12.StyleManager = null;
            Label12.TabIndex = 11;
            Label12.Text = "Text";
            Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label12.ThemeAuthor = "Terry D. Eppler";
            Label12.ThemeName = "Budget Execution";
            Label12.ToolTip = null;
            // 
            // Label10
            // 
            Label10.BindingSource = null;
            Label10.DataFilter = null;
            Label10.Dock = System.Windows.Forms.DockStyle.Fill;
            Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Label10.Font = new System.Drawing.Font( "Roboto", 8.25F );
            Label10.HoverText = null;
            Label10.IsDerivedStyle = true;
            Label10.Location = new System.Drawing.Point( 185, 69 );
            Label10.Margin = new System.Windows.Forms.Padding( 3 );
            Label10.Name = "Label10";
            Label10.Padding = new System.Windows.Forms.Padding( 1 );
            Label10.Size = new System.Drawing.Size( 176, 25 );
            Label10.Style = MetroSet_UI.Enums.Style.Custom;
            Label10.StyleManager = null;
            Label10.TabIndex = 9;
            Label10.Text = "Text";
            Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            Label10.ThemeAuthor = "Terry D. Eppler";
            Label10.ThemeName = "Budget Execution";
            Label10.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( ChartTable );
            Controls.Add( SecondCalendarTable );
            Controls.Add( FirstCalendarTable );
            Controls.Add( ToolStrip );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.LightGray;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "CalendarForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            FirstCalendarTable.ResumeLayout( false );
            FirstCalendarPanel.ResumeLayout( false );
            SecondCalendarTable.ResumeLayout( false );
            SecondCalendarPanel.ResumeLayout( false );
            ChartTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            ChartTab.ResumeLayout( false );
            ChartLayout.ResumeLayout( false );
            DataTab.ResumeLayout( false );
            GridPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)DataGrid ).EndInit( );
            BusyTab.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)Loader ).EndInit( );
            TimeTableLayout.ResumeLayout( false );
            TimeSpanTable.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public Picture PictureBox;
        public Label Title;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        public ToolStrip ToolStrip;
        public ToolStripButton FirstButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        private ToolSeparator toolSeparator4;
        public ToolStripButton LastButton;
        private ToolSeparator toolSeparator6;
        public ToolStripButton CloseButton;
        private ToolSeparator toolSeparator7;
        public ToolStripButton MenuButton;
        public HeaderPanel FirstCalendarTable;
        public BackPanel FirstCalendarPanel;
        public HeaderPanel SecondCalendarTable;
        public BackPanel SecondCalendarPanel;
        public Syncfusion.WinForms.Input.SfCalendar FirstCalendar;
        public Syncfusion.WinForms.Input.SfCalendar SecondCalendar;
        private HeaderPanel ChartTable;
        private BackPanel ChartLayout;
        public ToolStripButton RefreshButton;
        public ToolSeparator Separator7;
        public ToolSeparator Separator1;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public ToolSeparator Separator5;
        public ToolSeparator Separator6;
        public ToolSeparator NavigationSeparator;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt TimeSpanInformation;
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv DataTab;
        public BackPanel GridPanel;
        public DataGrid DataGrid;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv ChartTab;
        private System.Windows.Forms.TableLayoutPanel TimeSpanTable;
        public Label Label12;
        public Label Label11;
        public Label Label10;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public Label Label4;
        public Label Label5;
        public Label Label6;
        public Label Label7;
        public Label Label8;
        public Label Label9;
        public ToolStripButton TableButton;
        public ToolStripButton ChartButton;
        public ToolSeparator ChartSeparator;
        public ToolSeparator Separator8;
        public BackPanel TimeTableLayout;
        public System.Windows.Forms.Timer Timer;
        public ToolSeparator Separator11;
        public ToolStripLabel StatusLabel;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolSeparator StripSeparator;
        public Chart Chart;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTab;
        public System.Windows.Forms.PictureBox Loader;
        public ToolStripLabel Spacer;
        public ToolStripLabel DataLabel;
        public ToolStripLabel NavigationLabel;
    }
}