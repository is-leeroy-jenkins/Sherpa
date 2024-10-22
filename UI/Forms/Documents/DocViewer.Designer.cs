﻿namespace Sherpa
{
    partial class DocViewer
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
            var messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings( );
            var pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( DocViewer ) );
            var textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings( );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            Separator1 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            NavigationLabel = new ToolStripLabel( );
            Separator2 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            Separator3 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            Separator6 = new ToolSeparator( );
            SystemLabel = new ToolStripLabel( );
            Separator7 = new ToolSeparator( );
            BrowseButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            SaveButton = new ToolStripButton( );
            Separator9 = new ToolSeparator( );
            Separator10 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            FilterLabel = new ToolStripLabel( );
            Separator12 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            Separator13 = new ToolSeparator( );
            LastSeparator = new ToolSeparator( );
            TextBox = new ToolStripTextBox( );
            Separator14 = new ToolSeparator( );
            LookupButton = new ToolStripButton( );
            Separator16 = new ToolSeparator( );
            MenuLabel = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            ApplicationLabel = new ToolStripLabel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            HeaderPanel = new System.Windows.Forms.TableLayoutPanel( );
            Title = new Label( );
            ControlBox = new ControlBox( );
            Timer = new System.Windows.Forms.Timer( components );
            GuidancePanel = new HeaderPanel( );
            TableListBoxLayout = new BackPanel( );
            ButtonPanel = new System.Windows.Forms.FlowLayoutPanel( );
            DocumentTable = new HeaderPanel( );
            PdfViewer = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl( );
            ContextMenu = new ContextMenu( );
            ToolStripTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            HeaderPanel.SuspendLayout( );
            GuidancePanel.SuspendLayout( );
            TableListBoxLayout.SuspendLayout( );
            DocumentTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 1;
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Controls.Add( ToolStrip, 0, 0 );
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point( 1, 685 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1326, 45 );
            ToolStripTable.TabIndex = 53;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton = null;
            ToolStrip.AddColumnButton = null;
            ToolStrip.AddTableButton = null;
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BindingSource = null;
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
            ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, StatusLabel, NavigationLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator5, NextButton, Separator4, LastButton, Separator6, SystemLabel, Separator7, BrowseButton, Separator8, SaveButton, Separator9, Separator10, CloseButton, Separator11, MenuButton, FilterLabel, Separator12, RefreshButton, Separator13, LastSeparator, TextBox, Separator14, LookupButton, Separator16, MenuLabel } );
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 1, 1 );
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
            ToolStrip.Size = new System.Drawing.Size( 1324, 43 );
            ToolStrip.TabIndex = 2;
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
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 25 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            StatusLabel.BindingSource = null;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 88, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date & Time                   ";
            StatusLabel.ToolTip = null;
            // 
            // NavigationLabel
            // 
            NavigationLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            NavigationLabel.BindingSource = null;
            NavigationLabel.DataFilter = null;
            NavigationLabel.Field = Field.AccountCode;
            NavigationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            NavigationLabel.ForeColor = System.Drawing.Color.Black;
            NavigationLabel.HoverText = null;
            NavigationLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            NavigationLabel.Size = new System.Drawing.Size( 83, 25 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "                Navigation:";
            NavigationLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.Transparent;
            FirstButton.BindingSource = null;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = "First Record";
            FirstButton.Image = Resources.Images.ToolStripImages.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 25 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = null;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 25 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.BindingSource = null;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Record";
            PreviousButton.Image = Resources.Images.ToolStripImages.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 25 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = null;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 25 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.BindingSource = null;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Record";
            NextButton.Image = Resources.Images.ToolStripImages.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 25 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = null;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.Transparent;
            LastButton.BindingSource = BindingSource;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = "Last Record";
            LastButton.Image = Resources.Images.ToolStripImages.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 25 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = ToolTip;
            LastButton.ToolType = ToolType.LastButton;
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
            ToolTip.ThemeName = "Sherpa";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SystemLabel
            // 
            SystemLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            SystemLabel.BindingSource = null;
            SystemLabel.DataFilter = null;
            SystemLabel.Field = Field.AccountCode;
            SystemLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            SystemLabel.ForeColor = System.Drawing.Color.Black;
            SystemLabel.HoverText = null;
            SystemLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SystemLabel.Name = "SystemLabel";
            SystemLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SystemLabel.Size = new System.Drawing.Size( 71, 25 );
            SystemLabel.Tag = "";
            SystemLabel.Text = "                File Sys:";
            SystemLabel.ToolTip = null;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 25 );
            // 
            // BrowseButton
            // 
            BrowseButton.AutoToolTip = false;
            BrowseButton.BackColor = System.Drawing.Color.Transparent;
            BrowseButton.BindingSource = BindingSource;
            BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            BrowseButton.HoverText = "Browse System";
            BrowseButton.Image = Resources.Images.ToolStripImages.BrowseButton;
            BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BrowseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.Size = new System.Drawing.Size( 23, 25 );
            BrowseButton.Tag = "pdf";
            BrowseButton.Text = "toolStripButton5";
            BrowseButton.ToolTip = ToolTip;
            BrowseButton.ToolType = ToolType.BrowseButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SaveButton
            // 
            SaveButton.AutoToolTip = false;
            SaveButton.BackColor = System.Drawing.Color.Transparent;
            SaveButton.BindingSource = BindingSource;
            SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.LightGray;
            SaveButton.HoverText = "Save Changes";
            SaveButton.Image = Resources.Images.ToolStripImages.SaveButton;
            SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.Size = new System.Drawing.Size( 23, 25 );
            SaveButton.Text = "toolStripButton6";
            SaveButton.ToolTip = ToolTip;
            SaveButton.ToolType = ToolType.SaveButton;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 25 );
            // 
            // Separator10
            // 
            Separator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 25 );
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = BindingSource;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = "Exit";
            CloseButton.Image = Resources.Images.ToolStripImages.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 25 );
            CloseButton.Text = "toolStripButton7";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.CloseButton;
            // 
            // Separator11
            // 
            Separator11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BindingSource = BindingSource;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = "Main Menu";
            MenuButton.Image = Resources.Images.ToolStripImages.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 25 );
            MenuButton.Text = "toolStripButton8";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // FilterLabel
            // 
            FilterLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FilterLabel.BindingSource = null;
            FilterLabel.DataFilter = null;
            FilterLabel.Field = Field.AccountCode;
            FilterLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            FilterLabel.ForeColor = System.Drawing.Color.Black;
            FilterLabel.HoverText = null;
            FilterLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FilterLabel.Size = new System.Drawing.Size( 82, 25 );
            FilterLabel.Tag = "";
            FilterLabel.Text = "                           Data:";
            FilterLabel.ToolTip = null;
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 25 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.Transparent;
            RefreshButton.BindingSource = BindingSource;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            RefreshButton.HoverText = "Reset Filters";
            RefreshButton.Image = Resources.Images.ToolStripImages.WebRefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.Size = new System.Drawing.Size( 23, 25 );
            RefreshButton.Text = "toolStripButton9";
            RefreshButton.ToolTip = ToolTip;
            RefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LastSeparator
            // 
            LastSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            LastSeparator.ForeColor = System.Drawing.Color.Black;
            LastSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            LastSeparator.Name = "LastSeparator";
            LastSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            LastSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // TextBox
            // 
            TextBox.BackColor = System.Drawing.Color.Black;
            TextBox.BindingSource = BindingSource;
            TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TextBox.Field = Field.AccountCode;
            TextBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            TextBox.HoverText = "Enter Keywords";
            TextBox.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            TextBox.Name = "TextBox";
            TextBox.Padding = new System.Windows.Forms.Padding( 1 );
            TextBox.Size = new System.Drawing.Size( 150, 25 );
            TextBox.Tag = "";
            TextBox.Text = "Enter Keywords";
            TextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBox.ToolTip = ToolTip;
            // 
            // Separator14
            // 
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding( 1 );
            Separator14.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip = false;
            LookupButton.BackColor = System.Drawing.Color.Transparent;
            LookupButton.BindingSource = BindingSource;
            LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LookupButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LookupButton.ForeColor = System.Drawing.Color.LightGray;
            LookupButton.HoverText = "Begin Search";
            LookupButton.Image = Resources.Images.ToolStripImages.GoButton;
            LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LookupButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new System.Windows.Forms.Padding( 1 );
            LookupButton.Size = new System.Drawing.Size( 23, 25 );
            LookupButton.Text = "toolStripButton10";
            LookupButton.ToolTip = ToolTip;
            LookupButton.ToolType = ToolType.LookupButton;
            // 
            // Separator16
            // 
            Separator16.ForeColor = System.Drawing.Color.Black;
            Separator16.Margin = new System.Windows.Forms.Padding( 1 );
            Separator16.Name = "Separator16";
            Separator16.Padding = new System.Windows.Forms.Padding( 1 );
            Separator16.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuLabel
            // 
            MenuLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuLabel.BackColor = System.Drawing.Color.Transparent;
            MenuLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            MenuLabel.ForeColor = System.Drawing.Color.Black;
            MenuLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new System.Drawing.Size( 80, 25 );
            MenuLabel.Text = "                     Menu:    ";
            MenuLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ApplicationLabel
            // 
            ApplicationLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ApplicationLabel.BackColor = System.Drawing.Color.Transparent;
            ApplicationLabel.BindingSource = null;
            ApplicationLabel.DataFilter = null;
            ApplicationLabel.Field = Field.AccountCode;
            ApplicationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            ApplicationLabel.ForeColor = System.Drawing.Color.Black;
            ApplicationLabel.HoverText = null;
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 41, 25 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "        App:";
            ApplicationLabel.ToolTip = null;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.Location = new System.Drawing.Point( 1, 1 );
            PictureBox.Margin = new System.Windows.Forms.Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 20, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 54;
            PictureBox.TabStop = false;
            // 
            // HeaderPanel
            // 
            HeaderPanel.ColumnCount = 3;
            HeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.99401188F ) );
            HeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.00599F ) );
            HeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 148F ) );
            HeaderPanel.Controls.Add( PictureBox, 0, 0 );
            HeaderPanel.Controls.Add( Title, 1, 0 );
            HeaderPanel.Controls.Add( ControlBox, 2, 0 );
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point( 1, 1 );
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RowCount = 1;
            HeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderPanel.Size = new System.Drawing.Size( 1326, 36 );
            HeaderPanel.TabIndex = 55;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 38, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1136, 30 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 55;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Sherpa";
            Title.ToolTip = null;
            // 
            // ControlBox
            // 
            ControlBox.CloseHoverBackColor = System.Drawing.Color.FromArgb( 183, 40, 40 );
            ControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            ControlBox.CloseNormalForeColor = System.Drawing.Color.FromArgb( 35, 35, 35 );
            ControlBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            ControlBox.Font = new System.Drawing.Font( "Roboto", 9F );
            ControlBox.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ControlBox.IsDerivedStyle = true;
            ControlBox.Location = new System.Drawing.Point( 1225, 1 );
            ControlBox.Margin = new System.Windows.Forms.Padding( 1 );
            ControlBox.MaximizeBox = true;
            ControlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ControlBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            ControlBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ControlBox.MinimizeBox = true;
            ControlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ControlBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            ControlBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ControlBox.Name = "ControlBox";
            ControlBox.Padding = new System.Windows.Forms.Padding( 1 );
            ControlBox.Size = new System.Drawing.Size( 100, 25 );
            ControlBox.Style = MetroSet_UI.Enums.Style.Custom;
            ControlBox.StyleManager = null;
            ControlBox.TabIndex = 56;
            ControlBox.ThemeAuthor = "Terry Eppler";
            ControlBox.ThemeName = "Dark";
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // GuidancePanel
            // 
            GuidancePanel.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Right ;
            GuidancePanel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            GuidancePanel.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            GuidancePanel.CaptionText = "Guidance";
            GuidancePanel.ColumnCount = 1;
            GuidancePanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            GuidancePanel.Controls.Add( TableListBoxLayout, 0, 1 );
            GuidancePanel.Font = new System.Drawing.Font( "Roboto", 9F );
            GuidancePanel.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            GuidancePanel.Location = new System.Drawing.Point( 1039, 43 );
            GuidancePanel.Name = "GuidancePanel";
            GuidancePanel.RowCount = 2;
            GuidancePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.40625F ) );
            GuidancePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.59375F ) );
            GuidancePanel.Size = new System.Drawing.Size( 288, 639 );
            GuidancePanel.TabIndex = 57;
            // 
            // TableListBoxLayout
            // 
            TableListBoxLayout.BackColor = System.Drawing.Color.Transparent;
            TableListBoxLayout.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBoxLayout.BindingSource = null;
            TableListBoxLayout.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TableListBoxLayout.BorderThickness = 1;
            TableListBoxLayout.Children = null;
            TableListBoxLayout.Controls.Add( ButtonPanel );
            TableListBoxLayout.DataFilter = null;
            TableListBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            TableListBoxLayout.Font = new System.Drawing.Font( "Roboto", 8F );
            TableListBoxLayout.ForeColor = System.Drawing.Color.Transparent;
            TableListBoxLayout.HoverText = null;
            TableListBoxLayout.IsDerivedStyle = true;
            TableListBoxLayout.Location = new System.Drawing.Point( 3, 27 );
            TableListBoxLayout.Name = "TableListBoxLayout";
            TableListBoxLayout.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBoxLayout.Size = new System.Drawing.Size( 282, 609 );
            TableListBoxLayout.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBoxLayout.StyleManager = null;
            TableListBoxLayout.TabIndex = 0;
            TableListBoxLayout.ThemeAuthor = "Terry D. Eppler";
            TableListBoxLayout.ThemeName = "Sherpa";
            TableListBoxLayout.ToolTip = null;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ButtonPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ButtonPanel.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ButtonPanel.Location = new System.Drawing.Point( 1, 1 );
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size( 280, 607 );
            ButtonPanel.TabIndex = 0;
            // 
            // DocumentTable
            // 
            DocumentTable.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left ;
            DocumentTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DocumentTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            DocumentTable.CaptionText = "Document Viewer";
            DocumentTable.ColumnCount = 1;
            DocumentTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            DocumentTable.Controls.Add( PdfViewer, 0, 1 );
            DocumentTable.Font = new System.Drawing.Font( "Roboto", 9F );
            DocumentTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DocumentTable.Location = new System.Drawing.Point( 4, 43 );
            DocumentTable.Name = "DocumentTable";
            DocumentTable.RowCount = 2;
            DocumentTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.275917F ) );
            DocumentTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.72408F ) );
            DocumentTable.Size = new System.Drawing.Size( 1029, 639 );
            DocumentTable.TabIndex = 58;
            // 
            // PdfViewer
            // 
            PdfViewer.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left ;
            PdfViewer.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            PdfViewer.EnableContextMenu = true;
            PdfViewer.EnableNotificationBar = true;
            PdfViewer.HorizontalScrollOffset = 0;
            PdfViewer.IsBookmarkEnabled = true;
            PdfViewer.IsTextSearchEnabled = true;
            PdfViewer.IsTextSelectionEnabled = true;
            PdfViewer.Location = new System.Drawing.Point( 3, 26 );
            messageBoxSettings1.EnableNotification = true;
            PdfViewer.MessageBoxSettings = messageBoxSettings1;
            PdfViewer.MinimumZoomPercentage = 50;
            PdfViewer.Name = "PdfViewer";
            PdfViewer.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.Copies = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = (System.Drawing.PointF)resources.GetObject( "pdfViewerPrinterSettings1.PrintLocation" );
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            PdfViewer.PrinterSettings = pdfViewerPrinterSettings1;
            PdfViewer.ReferencePath = null;
            PdfViewer.ScrollDisplacementValue = 0;
            PdfViewer.ShowHorizontalScrollBar = true;
            PdfViewer.ShowToolBar = true;
            PdfViewer.ShowVerticalScrollBar = true;
            PdfViewer.Size = new System.Drawing.Size( 1023, 610 );
            PdfViewer.SpaceBetweenPages = 8;
            PdfViewer.TabIndex = 0;
            PdfViewer.Text = "pdfViewerControl1";
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb( 127, 255, 171, 64 );
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb( 127, 254, 255, 0 );
            PdfViewer.TextSearchSettings = textSearchSettings1;
            PdfViewer.ThemeName = "Office2016Black";
            PdfViewer.VerticalScrollOffset = 0;
            PdfViewer.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Black;
            PdfViewer.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // ContextMenu
            // 
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 10, 10, 10 );
            ContextMenu.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.ShowCheckMargin = true;
            ContextMenu.Size = new System.Drawing.Size( 180, 454 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Dark;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "MetroLite";
            // 
            // DocViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 3;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1328, 731 );
            Controls.Add( HeaderPanel );
            Controls.Add( DocumentTable );
            Controls.Add( GuidancePanel );
            Controls.Add( ToolStripTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1920, 1080 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1330, 730 );
            Name = "DocViewer";
            Padding = new System.Windows.Forms.Padding( 1 );
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DocViewer";
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            HeaderPanel.ResumeLayout( false );
            GuidancePanel.ResumeLayout( false );
            TableListBoxLayout.ResumeLayout( false );
            DocumentTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public ToolStrip ToolStrip;
        public ToolSeparator Separator1;
        public ToolStripLabel StatusLabel;
        public ToolStripLabel NavigationLabel;
        public ToolSeparator Separator2;
        public ToolStripButton FirstButton;
        public ToolSeparator Separator3;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator5;
        public ToolStripButton NextButton;
        public ToolSeparator Separator4;
        private ToolStripButton LastButton;
        public ToolSeparator Separator6;
        private ToolStripLabel SystemLabel;
        public ToolSeparator Separator7;
        public ToolStripButton BrowseButton;
        public ToolSeparator Separator8;
        public ToolStripButton SaveButton;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolStripButton CloseButton;
        public ToolSeparator Separator11;
        public ToolStripButton MenuButton;
        public ToolStripLabel FilterLabel;
        public ToolSeparator Separator12;
        public ToolStripButton RefreshButton;
        public ToolSeparator Separator13;
        public ToolStripButton LookupButton;
        public ToolSeparator Separator14;
        public ToolSeparator LastSeparator;
        public ToolStripLabel ApplicationLabel;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.TableLayoutPanel HeaderPanel;
        public Label Title;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
        public HeaderPanel GuidancePanel;
        public BackPanel TableListBoxLayout;
        private HeaderPanel DocumentTable;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl PdfViewer;
        public ToolStripTextBox TextBox;
        public ToolSeparator Separator16;
        public System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt MenuLabel;
        public ControlBox ControlBox;
        public ContextMenu ContextMenu;
    }
}