namespace BudgetExecution
{
    partial class GeoMapper
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GeoMapper ) );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            Separator1 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            NavigationLabel = new ToolStripLabel( );
            Separator2 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            ToolTip = new SmallTip( );
            Separator3 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            Separator6 = new ToolSeparator( );
            DataSpacer = new ToolStripLabel( );
            DataLabel = new ToolStripLabel( );
            Separator7 = new ToolSeparator( );
            FilterButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            Separator9 = new ToolSeparator( );
            FileSysSpacer = new ToolStripLabel( );
            FileSysLabel = new ToolStripLabel( );
            Separator10 = new ToolSeparator( );
            BrowseButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            SaveButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            ApplicationSpacer = new ToolStripLabel( );
            Separator13 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            Separator15 = new ToolSeparator( );
            ApplicationLabel = new ToolStripLabel( );
            Timer = new System.Windows.Forms.Timer( components );
            ContextMenu = new ContextMenu( );
            Map = new GMap.NET.WindowsForms.GMapControl( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ToolStripTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.02550626F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.9744949F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 1, 1 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1331, 24 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 20, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 29, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1299, 18 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Geo Map";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 1;
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Controls.Add( ToolStrip, 0, 0 );
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point( 1, 687 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1331, 45 );
            ToolStripTable.TabIndex = 1;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, StatusLabel, NavigationLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator4, NextButton, Separator5, LastButton, Separator6, DataSpacer, DataLabel, Separator7, FilterButton, Separator8, RefreshButton, Separator9, FileSysSpacer, FileSysLabel, Separator10, BrowseButton, Separator11, SaveButton, Separator12, ApplicationSpacer, Separator13, CloseButton, Separator14, MenuButton, Separator15, ApplicationLabel } );
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
            ToolStrip.Size = new System.Drawing.Size( 1329, 43 );
            ToolStrip.TabIndex = 0;
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
            Separator1.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 25 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.Transparent;
            StatusLabel.BindingSource = null;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 66, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date And Time";
            StatusLabel.ToolTip = null;
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
            NavigationLabel.Size = new System.Drawing.Size( 69, 25 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "         Navigation:";
            NavigationLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FirstButton.BindingSource = BindingSource;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Filter = null;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FirstButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FirstButton.HoverText = "First Location";
            FirstButton.Image = Resources.Images.ToolStripImages.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 25 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = ToolTip;
            FirstButton.ToolType = ToolType.FirstButton;
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
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 25 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Filter = null;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PreviousButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            PreviousButton.HoverText = "Previous Location";
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
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 25 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            NextButton.BindingSource = BindingSource;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Filter = null;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F );
            NextButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            NextButton.HoverText = "Next Location";
            NextButton.Image = Resources.Images.ToolStripImages.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 25 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            LastButton.BindingSource = BindingSource;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Filter = null;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LastButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            LastButton.HoverText = "Last Location";
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
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // DataSpacer
            // 
            DataSpacer.BackColor = System.Drawing.Color.Transparent;
            DataSpacer.BindingSource = null;
            DataSpacer.DataFilter = null;
            DataSpacer.Field = Field.AccountCode;
            DataSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F );
            DataSpacer.ForeColor = System.Drawing.Color.Transparent;
            DataSpacer.HoverText = null;
            DataSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            DataSpacer.Name = "DataSpacer";
            DataSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            DataSpacer.Size = new System.Drawing.Size( 67, 25 );
            DataSpacer.Tag = "";
            DataSpacer.Text = "toolStripLabel1";
            DataSpacer.ToolTip = null;
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
            DataLabel.Size = new System.Drawing.Size( 44, 25 );
            DataLabel.Tag = "";
            DataLabel.Text = "        Data:";
            DataLabel.ToolTip = null;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FilterButton
            // 
            FilterButton.AutoToolTip = false;
            FilterButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FilterButton.BindingSource = BindingSource;
            FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FilterButton.Field = Field.AccountCode;
            FilterButton.Filter = null;
            FilterButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FilterButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FilterButton.HoverText = "Filter Locations";
            FilterButton.Image = Resources.Images.ToolStripImages.FilterButton;
            FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FilterButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FilterButton.Name = "FilterButton";
            FilterButton.Padding = new System.Windows.Forms.Padding( 1 );
            FilterButton.Size = new System.Drawing.Size( 23, 25 );
            FilterButton.Text = "toolStripButton4";
            FilterButton.ToolTip = null;
            FilterButton.ToolType = ToolType.FilterButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 25 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            RefreshButton.BindingSource = BindingSource;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Field = Field.AccountCode;
            RefreshButton.Filter = null;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RefreshButton.HoverText = "Reset Filters";
            RefreshButton.Image = Resources.Images.ToolStripImages.WebRefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.Size = new System.Drawing.Size( 23, 25 );
            RefreshButton.Text = "toolStripButton5";
            RefreshButton.ToolTip = ToolTip;
            RefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FileSysSpacer
            // 
            FileSysSpacer.BackColor = System.Drawing.Color.Transparent;
            FileSysSpacer.BindingSource = null;
            FileSysSpacer.DataFilter = null;
            FileSysSpacer.Field = Field.AccountCode;
            FileSysSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F );
            FileSysSpacer.ForeColor = System.Drawing.Color.Transparent;
            FileSysSpacer.HoverText = null;
            FileSysSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            FileSysSpacer.Name = "FileSysSpacer";
            FileSysSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            FileSysSpacer.Size = new System.Drawing.Size( 67, 25 );
            FileSysSpacer.Tag = "";
            FileSysSpacer.Text = "toolStripLabel4";
            FileSysSpacer.ToolTip = null;
            // 
            // FileSysLabel
            // 
            FileSysLabel.BackColor = System.Drawing.Color.Transparent;
            FileSysLabel.BindingSource = null;
            FileSysLabel.DataFilter = null;
            FileSysLabel.Field = Field.AccountCode;
            FileSysLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            FileSysLabel.ForeColor = System.Drawing.Color.Black;
            FileSysLabel.HoverText = null;
            FileSysLabel.Margin = new System.Windows.Forms.Padding( 1 );
            FileSysLabel.Name = "FileSysLabel";
            FileSysLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FileSysLabel.Size = new System.Drawing.Size( 57, 25 );
            FileSysLabel.Tag = "";
            FileSysLabel.Text = "         File Sys:";
            FileSysLabel.ToolTip = null;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 25 );
            // 
            // BrowseButton
            // 
            BrowseButton.AutoToolTip = false;
            BrowseButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            BrowseButton.BindingSource = BindingSource;
            BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BrowseButton.Field = Field.AccountCode;
            BrowseButton.Filter = null;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.HoverText = "Browse File System";
            BrowseButton.Image = Resources.Images.ToolStripImages.BrowseButton;
            BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BrowseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.Size = new System.Drawing.Size( 23, 25 );
            BrowseButton.Text = "toolStripButton6";
            BrowseButton.ToolTip = ToolTip;
            BrowseButton.ToolType = ToolType.BrowseButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SaveButton
            // 
            SaveButton.AutoToolTip = false;
            SaveButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            SaveButton.BindingSource = BindingSource;
            SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveButton.Field = Field.AccountCode;
            SaveButton.Filter = null;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SaveButton.HoverText = "Save Changes";
            SaveButton.Image = Resources.Images.ToolStripImages.SaveButton;
            SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.Size = new System.Drawing.Size( 23, 25 );
            SaveButton.Text = "toolStripButton7";
            SaveButton.ToolTip = ToolTip;
            SaveButton.ToolType = ToolType.SaveButton;
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ApplicationSpacer
            // 
            ApplicationSpacer.BackColor = System.Drawing.Color.Transparent;
            ApplicationSpacer.BindingSource = null;
            ApplicationSpacer.DataFilter = null;
            ApplicationSpacer.Field = Field.AccountCode;
            ApplicationSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F );
            ApplicationSpacer.ForeColor = System.Drawing.Color.Transparent;
            ApplicationSpacer.HoverText = null;
            ApplicationSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationSpacer.Name = "ApplicationSpacer";
            ApplicationSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationSpacer.Size = new System.Drawing.Size( 67, 25 );
            ApplicationSpacer.Tag = "";
            ApplicationSpacer.Text = "toolStripLabel6";
            ApplicationSpacer.ToolTip = null;
            // 
            // Separator13
            // 
            Separator13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 25 );
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            CloseButton.BindingSource = BindingSource;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Filter = null;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverText = null;
            CloseButton.Image = Resources.Images.ToolStripImages.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 25 );
            CloseButton.Text = "toolStripButton8";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.CloseButton;
            // 
            // Separator14
            // 
            Separator14.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding( 1 );
            Separator14.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            MenuButton.BindingSource = BindingSource;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Filter = null;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            MenuButton.HoverText = "Return to Menu";
            MenuButton.Image = Resources.Images.ToolStripImages.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 25 );
            MenuButton.Text = "toolStripButton9";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // Separator15
            // 
            Separator15.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator15.ForeColor = System.Drawing.Color.Black;
            Separator15.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator15.Name = "Separator15";
            Separator15.Padding = new System.Windows.Forms.Padding( 1 );
            Separator15.Size = new System.Drawing.Size( 6, 25 );
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
            ApplicationLabel.HoverText = "Close Application";
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 43, 25 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "         App:";
            ApplicationLabel.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
            // 
            // ContextMenu
            // 
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.DropShadowEnabled = false;
            ContextMenu.Font = new System.Drawing.Font( "Roboto", 9F );
            ContextMenu.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ContextMenu.MetroColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.Name = "ContextMenu";
            ContextMenu.Size = new System.Drawing.Size( 126, 180 );
            ContextMenu.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Office2016Black;
            ContextMenu.ThemeName = "Office2016Black";
            ContextMenu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 77, 77, 77 );
            ContextMenu.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ContextMenu.ThemeStyle.HoverBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ContextMenu.ThemeStyle.HoverForeColor = System.Drawing.Color.White;
            ContextMenu.ThemeStyle.PressedBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
            ContextMenu.ThemeStyle.PressedForeColor = System.Drawing.Color.Black;
            // 
            // Map
            // 
            Map.Bearing = 0F;
            Map.CanDragMap = true;
            Map.Dock = System.Windows.Forms.DockStyle.Fill;
            Map.EmptyTileColor = System.Drawing.Color.Navy;
            Map.GrayScaleMode = false;
            Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            Map.LevelsKeepInMemory = 5;
            Map.Location = new System.Drawing.Point( 1, 25 );
            Map.MarkersEnabled = true;
            Map.MaxZoom = 2;
            Map.MinZoom = 2;
            Map.MouseWheelZoomEnabled = true;
            Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            Map.Name = "Map";
            Map.NegativeMode = false;
            Map.Padding = new System.Windows.Forms.Padding( 1 );
            Map.PolygonsEnabled = true;
            Map.RetryLoadTile = 0;
            Map.RoutesEnabled = true;
            Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb( 33, 65, 105, 225 );
            Map.ShowTileGridLines = false;
            Map.Size = new System.Drawing.Size( 1331, 662 );
            Map.TabIndex = 2;
            Map.Zoom = 0D;
            // 
            // GeoMapper
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1333, 733 );
            ControlBox = false;
            Controls.Add( Map );
            Controls.Add( ToolStripTable );
            Controls.Add( HeaderTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 8.25F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1340, 740 );
            Name = "GeoMapper";
            Padding = new System.Windows.Forms.Padding( 1 );
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.PictureBox PictureBox;
        private Label Title;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
        public ToolStrip ToolStrip;
        public ToolSeparator Separator15;
        public ToolStripLabel DataLabel;
        public ToolStripLabel FileSysSpacer;
        public ToolStripLabel FileSysLabel;
        public ToolStripLabel ApplicationSpacer;
        public ToolStripLabel ApplicationLabel;
        public ToolSeparator Separator1;
        public ToolStripLabel NavigationLabel;
        public ToolStripButton FirstButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolSeparator Separator5;
        public ToolSeparator Separator6;
        public ToolStripLabel StatusLabel;
        public ToolSeparator Separator2;
        public ToolSeparator Separator4;
        public ToolSeparator Separator3;
        public ToolStripButton LastButton;
        public ToolStripLabel DataSpacer;
        public ToolSeparator Separator7;
        public ToolStripButton FilterButton;
        public ToolSeparator Separator8;
        public ToolStripButton RefreshButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton SaveButton;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator11;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolStripButton CloseButton;
        public ToolStripButton MenuButton;
        public ToolSeparator Separator14;
        public ContextMenu ContextMenu;
        private GMap.NET.WindowsForms.GMapControl Map;
    }
}