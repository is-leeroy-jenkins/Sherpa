namespace BudgetExecution
{
    partial class PivotChartForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PivotChartForm ) );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            Timer = new System.Windows.Forms.Timer( components );
            ToolTip = new SmallTip( );
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
            FilterButton = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            LastSeparator = new ToolSeparator( );
            ApplicationLabel = new ToolStripLabel( );
            ComboBox = new ToolStripDropDown( );
            FirstSeparator = new ToolSeparator( );
            ChartHeaderTable = new HeaderPanel( );
            PivotLayout = new BackPanel( );
            TabControl = new TabControl( );
            DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            AreaTable = new System.Windows.Forms.TableLayoutPanel( );
            ChartAreaPanel = new BackPanel( );
            PivotChart = new Syncfusion.Windows.Forms.PivotChart.PivotChart( );
            ChartSubTablePanel = new BackPanel( );
            ChartSubTable = new System.Windows.Forms.TableLayoutPanel( );
            SqlHeader = new Label( );
            MetricsTable = new System.Windows.Forms.TableLayoutPanel( );
            MetricLabel17 = new Label( );
            MetricLabel16 = new Label( );
            MetricLabel18 = new Label( );
            MetricLabel20 = new Label( );
            MetricLabel19 = new Label( );
            MetricLabel3 = new Label( );
            MetricLabel1 = new Label( );
            MetricLabel2 = new Label( );
            MetricLabel4 = new Label( );
            MetricLabel5 = new Label( );
            MetricLabel6 = new Label( );
            MetricLabel7 = new Label( );
            MetricLabel8 = new Label( );
            MetricLabel9 = new Label( );
            MetricLabel10 = new Label( );
            MetricLabel11 = new Label( );
            MetricLabel12 = new Label( );
            MetricLabel13 = new Label( );
            MetricLabel14 = new Label( );
            MetricLabel15 = new Label( );
            BusyTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            Loader = new System.Windows.Forms.PictureBox( );
            SourcePanel = new HeaderPanel( );
            TableListBoxLayout = new BackPanel( );
            TableListBox = new ListBox( );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ContextMenu = new ContextMenu( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ToolStrip.SuspendLayout( );
            ChartHeaderTable.SuspendLayout( );
            PivotLayout.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            DataTab.SuspendLayout( );
            AreaTable.SuspendLayout( );
            ChartAreaPanel.SuspendLayout( );
            ChartSubTablePanel.SuspendLayout( );
            ChartSubTable.SuspendLayout( );
            MetricsTable.SuspendLayout( );
            BusyTab.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Loader ).BeginInit( );
            SourcePanel.SuspendLayout( );
            TableListBoxLayout.SuspendLayout( );
            ToolStripTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.54110622F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.45889F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1338, 29 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.Application;
            PictureBox.InitialImage = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 28, 20 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
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
            Title.Location = new System.Drawing.Point( 37, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1298, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Pivot Chart Form";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, StatusLabel, NavigationLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator5, NextButton, Separator4, LastButton, Separator6, SystemLabel, Separator7, BrowseButton, Separator8, SaveButton, Separator9, Separator10, CloseButton, Separator11, MenuButton, FilterLabel, Separator12, RefreshButton, Separator13, FilterButton, Separator14, LastSeparator, ApplicationLabel, ComboBox } );
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
            ToolStrip.Size = new System.Drawing.Size( 1336, 43 );
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
            StatusLabel.Size = new System.Drawing.Size( 50, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date & Time";
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
            FirstButton.BindingSource = BindingSource;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Filter = null;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = "First Record";
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 25 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = ToolTip;
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
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Filter = null;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Record";
            PreviousButton.Image = Resources.Images.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 25 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = ToolTip;
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
            NextButton.BindingSource = BindingSource;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Filter = null;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Record";
            NextButton.Image = Resources.Images.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 25 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = ToolTip;
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
            LastButton.Field = Field.AccountCode;
            LastButton.Filter = null;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = "Last Record";
            LastButton.Image = Resources.Images.LastButton;
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
            BrowseButton.Field = Field.AccountCode;
            BrowseButton.Filter = null;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            BrowseButton.HoverText = "Browse System";
            BrowseButton.Image = Resources.Images.BrowseButton;
            BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BrowseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.Size = new System.Drawing.Size( 23, 25 );
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
            SaveButton.Field = Field.AccountCode;
            SaveButton.Filter = null;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.LightGray;
            SaveButton.HoverText = "Save Changes";
            SaveButton.Image = Resources.Images.SaveButton;
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
            CloseButton.Field = Field.AccountCode;
            CloseButton.Filter = null;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = "Exit";
            CloseButton.Image = Resources.Images.WebCloseButton;
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
            MenuButton.Field = Field.AccountCode;
            MenuButton.Filter = null;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = "Main Menu";
            MenuButton.Image = Resources.Images.WebMenuButton;
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
            FilterLabel.Size = new System.Drawing.Size( 60, 25 );
            FilterLabel.Tag = "";
            FilterLabel.Text = "                Data:";
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
            RefreshButton.Field = Field.AccountCode;
            RefreshButton.Filter = null;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            RefreshButton.HoverText = "Reset Filters";
            RefreshButton.Image = Resources.Images.WebRefreshButton;
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
            // FilterButton
            // 
            FilterButton.AutoToolTip = false;
            FilterButton.BackColor = System.Drawing.Color.Transparent;
            FilterButton.BindingSource = BindingSource;
            FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FilterButton.Field = Field.AccountCode;
            FilterButton.Filter = null;
            FilterButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FilterButton.ForeColor = System.Drawing.Color.LightGray;
            FilterButton.HoverText = "Lookup";
            FilterButton.Image = Resources.Images.FilterButton;
            FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FilterButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FilterButton.Name = "FilterButton";
            FilterButton.Padding = new System.Windows.Forms.Padding( 1 );
            FilterButton.Size = new System.Drawing.Size( 23, 25 );
            FilterButton.Text = "toolStripButton10";
            FilterButton.ToolTip = ToolTip;
            FilterButton.ToolType = ToolType.FilterButton;
            // 
            // Separator14
            // 
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding( 1 );
            Separator14.Size = new System.Drawing.Size( 6, 25 );
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
            // ComboBox
            // 
            ComboBox.AllowDrop = true;
            ComboBox.BindingSource = BindingSource;
            ComboBox.DataFilter = null;
            ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ComboBox.Font = new System.Drawing.Font( "Roboto", 8F );
            ComboBox.ForeColor = System.Drawing.Color.FromArgb( 218, 218, 218 );
            ComboBox.HoverText = "Select Chart ";
            ComboBox.Margin = new System.Windows.Forms.Padding( 1 );
            ComboBox.MaxDropDownItems = 100;
            ComboBox.MaxLength = 32767;
            ComboBox.Name = "ComboBox";
            ComboBox.Padding = new System.Windows.Forms.Padding( 1 );
            ComboBox.Size = new System.Drawing.Size( 150, 25 );
            ComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            ComboBox.ToolTip = ToolTip;
            ComboBox.ToolTipText = "Make Selection";
            // 
            // FirstSeparator
            // 
            FirstSeparator.ForeColor = System.Drawing.Color.Black;
            FirstSeparator.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstSeparator.Name = "FirstSeparator";
            FirstSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            FirstSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ChartHeaderTable
            // 
            ChartHeaderTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartHeaderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ChartHeaderTable.CaptionText = "Data Visualization";
            ChartHeaderTable.ColumnCount = 1;
            ChartHeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartHeaderTable.Controls.Add( PivotLayout, 0, 1 );
            ChartHeaderTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ChartHeaderTable.ForeColor = System.Drawing.Color.DarkGray;
            ChartHeaderTable.Location = new System.Drawing.Point( 12, 35 );
            ChartHeaderTable.Name = "ChartHeaderTable";
            ChartHeaderTable.RowCount = 2;
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            ChartHeaderTable.Size = new System.Drawing.Size( 1069, 647 );
            ChartHeaderTable.TabIndex = 50;
            // 
            // PivotLayout
            // 
            PivotLayout.BackColor = System.Drawing.Color.Transparent;
            PivotLayout.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            PivotLayout.BindingSource = null;
            PivotLayout.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            PivotLayout.BorderThickness = 1;
            PivotLayout.Children = null;
            PivotLayout.Controls.Add( TabControl );
            PivotLayout.DataFilter = null;
            PivotLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            PivotLayout.Font = new System.Drawing.Font( "Roboto", 8F );
            PivotLayout.ForeColor = System.Drawing.Color.Transparent;
            PivotLayout.HoverText = null;
            PivotLayout.IsDerivedStyle = true;
            PivotLayout.Location = new System.Drawing.Point( 3, 26 );
            PivotLayout.Name = "PivotLayout";
            PivotLayout.Padding = new System.Windows.Forms.Padding( 1 );
            PivotLayout.Size = new System.Drawing.Size( 1063, 618 );
            PivotLayout.Style = MetroSet_UI.Enums.Style.Custom;
            PivotLayout.StyleManager = null;
            PivotLayout.TabIndex = 53;
            PivotLayout.ThemeAuthor = "Terry D. Eppler";
            PivotLayout.ThemeName = "Budget Execution";
            PivotLayout.ToolTip = null;
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 1061, 616 );
            TabControl.BindingSource = null;
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( DataTab );
            TabControl.Controls.Add( BusyTab );
            TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 9F );
            TabControl.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 100, 30 );
            TabControl.Location = new System.Drawing.Point( 1, 1 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 1061, 616 );
            TabControl.TabIndex = 52;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ToolTip = null;
            // 
            // DataTab
            // 
            DataTab.Controls.Add( AreaTable );
            DataTab.Image = null;
            DataTab.ImageSize = new System.Drawing.Size( 16, 16 );
            DataTab.Location = new System.Drawing.Point( 0, 29 );
            DataTab.Name = "DataTab";
            DataTab.ShowCloseButton = true;
            DataTab.Size = new System.Drawing.Size( 1061, 587 );
            DataTab.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataTab.TabForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DataTab.TabIndex = 1;
            DataTab.ThemesEnabled = false;
            // 
            // AreaTable
            // 
            AreaTable.ColumnCount = 1;
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            AreaTable.Controls.Add( ChartAreaPanel, 0, 0 );
            AreaTable.Controls.Add( ChartSubTablePanel, 0, 1 );
            AreaTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AreaTable.Location = new System.Drawing.Point( 12, 12 );
            AreaTable.Name = "AreaTable";
            AreaTable.RowCount = 2;
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 80.71066F ) );
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 19.289341F ) );
            AreaTable.Size = new System.Drawing.Size( 1046, 572 );
            AreaTable.TabIndex = 6;
            // 
            // ChartAreaPanel
            // 
            ChartAreaPanel.BackColor = System.Drawing.Color.Transparent;
            ChartAreaPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartAreaPanel.BindingSource = null;
            ChartAreaPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ChartAreaPanel.BorderThickness = 1;
            ChartAreaPanel.Children = null;
            ChartAreaPanel.Controls.Add( PivotChart );
            ChartAreaPanel.DataFilter = null;
            ChartAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartAreaPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            ChartAreaPanel.ForeColor = System.Drawing.Color.Transparent;
            ChartAreaPanel.HoverText = null;
            ChartAreaPanel.IsDerivedStyle = true;
            ChartAreaPanel.Location = new System.Drawing.Point( 3, 3 );
            ChartAreaPanel.Name = "ChartAreaPanel";
            ChartAreaPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartAreaPanel.Size = new System.Drawing.Size( 1040, 455 );
            ChartAreaPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ChartAreaPanel.StyleManager = null;
            ChartAreaPanel.TabIndex = 7;
            ChartAreaPanel.ThemeAuthor = "Terry D. Eppler";
            ChartAreaPanel.ThemeName = "Budget Execution";
            ChartAreaPanel.ToolTip = null;
            // 
            // PivotChart
            // 
            PivotChart.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            PivotChart.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
            PivotChart.CustomPalette = new System.Drawing.Color[ ]
    {
    System.Drawing.Color.SteelBlue,
    System.Drawing.Color.SlateGray,
    System.Drawing.Color.Yellow,
    System.Drawing.Color.Red
    };
            PivotChart.DeferLayoutUpdate = false;
            PivotChart.Dock = System.Windows.Forms.DockStyle.Fill;
            PivotChart.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            PivotChart.Location = new System.Drawing.Point( 1, 1 );
            PivotChart.MinimumSize = new System.Drawing.Size( 300, 250 );
            PivotChart.Name = "PivotChart";
            PivotChart.ShowPivotTableFieldList = false;
            PivotChart.Size = new System.Drawing.Size( 1038, 453 );
            PivotChart.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            PivotChart.TabIndex = 0;
            PivotChart.Text = "pivotChart1";
            PivotChart.UpdateManager = null;
            // 
            // ChartSubTablePanel
            // 
            ChartSubTablePanel.BackColor = System.Drawing.Color.Transparent;
            ChartSubTablePanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartSubTablePanel.BindingSource = null;
            ChartSubTablePanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ChartSubTablePanel.BorderThickness = 1;
            ChartSubTablePanel.Children = null;
            ChartSubTablePanel.Controls.Add( ChartSubTable );
            ChartSubTablePanel.Controls.Add( MetricsTable );
            ChartSubTablePanel.DataFilter = null;
            ChartSubTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartSubTablePanel.Font = new System.Drawing.Font( "Roboto", 8F );
            ChartSubTablePanel.ForeColor = System.Drawing.Color.Transparent;
            ChartSubTablePanel.HoverText = null;
            ChartSubTablePanel.IsDerivedStyle = true;
            ChartSubTablePanel.Location = new System.Drawing.Point( 3, 464 );
            ChartSubTablePanel.Name = "ChartSubTablePanel";
            ChartSubTablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSubTablePanel.Size = new System.Drawing.Size( 1040, 105 );
            ChartSubTablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            ChartSubTablePanel.StyleManager = null;
            ChartSubTablePanel.TabIndex = 1;
            ChartSubTablePanel.ThemeAuthor = "Terry D. Eppler";
            ChartSubTablePanel.ThemeName = "Budget Execution";
            ChartSubTablePanel.ToolTip = null;
            // 
            // ChartSubTable
            // 
            ChartSubTable.ColumnCount = 1;
            ChartSubTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartSubTable.Controls.Add( SqlHeader, 0, 0 );
            ChartSubTable.Location = new System.Drawing.Point( 788, 4 );
            ChartSubTable.Name = "ChartSubTable";
            ChartSubTable.RowCount = 2;
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 73F ) );
            ChartSubTable.Size = new System.Drawing.Size( 248, 97 );
            ChartSubTable.TabIndex = 5;
            // 
            // SqlHeader
            // 
            SqlHeader.BindingSource = null;
            SqlHeader.DataFilter = null;
            SqlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            SqlHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SqlHeader.Font = new System.Drawing.Font( "Roboto", 6.75F );
            SqlHeader.HoverText = null;
            SqlHeader.IsDerivedStyle = true;
            SqlHeader.Location = new System.Drawing.Point( 3, 3 );
            SqlHeader.Margin = new System.Windows.Forms.Padding( 3 );
            SqlHeader.Name = "SqlHeader";
            SqlHeader.Padding = new System.Windows.Forms.Padding( 1 );
            SqlHeader.Size = new System.Drawing.Size( 242, 18 );
            SqlHeader.Style = MetroSet_UI.Enums.Style.Custom;
            SqlHeader.StyleManager = null;
            SqlHeader.TabIndex = 2;
            SqlHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SqlHeader.ThemeAuthor = "Terry D. Eppler";
            SqlHeader.ThemeName = "Budget Execution";
            SqlHeader.ToolTip = null;
            // 
            // MetricsTable
            // 
            MetricsTable.ColumnCount = 5;
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            MetricsTable.Controls.Add( MetricLabel17, 0, 3 );
            MetricsTable.Controls.Add( MetricLabel16, 0, 3 );
            MetricsTable.Controls.Add( MetricLabel18, 0, 3 );
            MetricsTable.Controls.Add( MetricLabel20, 0, 3 );
            MetricsTable.Controls.Add( MetricLabel19, 0, 3 );
            MetricsTable.Controls.Add( MetricLabel3, 2, 0 );
            MetricsTable.Controls.Add( MetricLabel1, 0, 0 );
            MetricsTable.Controls.Add( MetricLabel2, 1, 0 );
            MetricsTable.Controls.Add( MetricLabel4, 3, 0 );
            MetricsTable.Controls.Add( MetricLabel5, 4, 0 );
            MetricsTable.Controls.Add( MetricLabel6, 0, 1 );
            MetricsTable.Controls.Add( MetricLabel7, 1, 1 );
            MetricsTable.Controls.Add( MetricLabel8, 2, 1 );
            MetricsTable.Controls.Add( MetricLabel9, 3, 1 );
            MetricsTable.Controls.Add( MetricLabel10, 4, 1 );
            MetricsTable.Controls.Add( MetricLabel11, 0, 2 );
            MetricsTable.Controls.Add( MetricLabel12, 1, 2 );
            MetricsTable.Controls.Add( MetricLabel13, 2, 2 );
            MetricsTable.Controls.Add( MetricLabel14, 3, 2 );
            MetricsTable.Controls.Add( MetricLabel15, 4, 2 );
            MetricsTable.Location = new System.Drawing.Point( 1, 4 );
            MetricsTable.Name = "MetricsTable";
            MetricsTable.RowCount = 4;
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 25F ) );
            MetricsTable.Size = new System.Drawing.Size( 781, 97 );
            MetricsTable.TabIndex = 4;
            // 
            // MetricLabel17
            // 
            MetricLabel17.BindingSource = null;
            MetricLabel17.DataFilter = null;
            MetricLabel17.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel17.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel17.HoverText = null;
            MetricLabel17.IsDerivedStyle = true;
            MetricLabel17.Location = new System.Drawing.Point( 159, 75 );
            MetricLabel17.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel17.Name = "MetricLabel17";
            MetricLabel17.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel17.Size = new System.Drawing.Size( 150, 19 );
            MetricLabel17.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel17.StyleManager = null;
            MetricLabel17.TabIndex = 60;
            MetricLabel17.Tag = "STAT";
            MetricLabel17.Text = "Text";
            MetricLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel17.ThemeAuthor = "Terry D. Eppler";
            MetricLabel17.ThemeName = "Budget Execution";
            MetricLabel17.ToolTip = null;
            // 
            // MetricLabel16
            // 
            MetricLabel16.BindingSource = null;
            MetricLabel16.DataFilter = null;
            MetricLabel16.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel16.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel16.HoverText = null;
            MetricLabel16.IsDerivedStyle = true;
            MetricLabel16.Location = new System.Drawing.Point( 3, 75 );
            MetricLabel16.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel16.Name = "MetricLabel16";
            MetricLabel16.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel16.Size = new System.Drawing.Size( 150, 19 );
            MetricLabel16.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel16.StyleManager = null;
            MetricLabel16.TabIndex = 59;
            MetricLabel16.Tag = "STAT";
            MetricLabel16.Text = "Text";
            MetricLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel16.ThemeAuthor = "Terry D. Eppler";
            MetricLabel16.ThemeName = "Budget Execution";
            MetricLabel16.ToolTip = null;
            // 
            // MetricLabel18
            // 
            MetricLabel18.BindingSource = null;
            MetricLabel18.DataFilter = null;
            MetricLabel18.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel18.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel18.HoverText = null;
            MetricLabel18.IsDerivedStyle = true;
            MetricLabel18.Location = new System.Drawing.Point( 315, 75 );
            MetricLabel18.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel18.Name = "MetricLabel18";
            MetricLabel18.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel18.Size = new System.Drawing.Size( 150, 19 );
            MetricLabel18.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel18.StyleManager = null;
            MetricLabel18.TabIndex = 58;
            MetricLabel18.Tag = "STAT";
            MetricLabel18.Text = "Text";
            MetricLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel18.ThemeAuthor = "Terry D. Eppler";
            MetricLabel18.ThemeName = "Budget Execution";
            MetricLabel18.ToolTip = null;
            // 
            // MetricLabel20
            // 
            MetricLabel20.BindingSource = null;
            MetricLabel20.DataFilter = null;
            MetricLabel20.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel20.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel20.HoverText = null;
            MetricLabel20.IsDerivedStyle = true;
            MetricLabel20.Location = new System.Drawing.Point( 627, 75 );
            MetricLabel20.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel20.Name = "MetricLabel20";
            MetricLabel20.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel20.Size = new System.Drawing.Size( 151, 19 );
            MetricLabel20.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel20.StyleManager = null;
            MetricLabel20.TabIndex = 57;
            MetricLabel20.Tag = "STAT";
            MetricLabel20.Text = "Text";
            MetricLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel20.ThemeAuthor = "Terry D. Eppler";
            MetricLabel20.ThemeName = "Budget Execution";
            MetricLabel20.ToolTip = null;
            // 
            // MetricLabel19
            // 
            MetricLabel19.BindingSource = null;
            MetricLabel19.DataFilter = null;
            MetricLabel19.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel19.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel19.HoverText = null;
            MetricLabel19.IsDerivedStyle = true;
            MetricLabel19.Location = new System.Drawing.Point( 471, 75 );
            MetricLabel19.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel19.Name = "MetricLabel19";
            MetricLabel19.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel19.Size = new System.Drawing.Size( 150, 19 );
            MetricLabel19.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel19.StyleManager = null;
            MetricLabel19.TabIndex = 56;
            MetricLabel19.Tag = "STAT";
            MetricLabel19.Text = "Text";
            MetricLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel19.ThemeAuthor = "Terry D. Eppler";
            MetricLabel19.ThemeName = "Budget Execution";
            MetricLabel19.ToolTip = null;
            // 
            // MetricLabel3
            // 
            MetricLabel3.BindingSource = null;
            MetricLabel3.DataFilter = null;
            MetricLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel3.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel3.HoverText = null;
            MetricLabel3.IsDerivedStyle = true;
            MetricLabel3.Location = new System.Drawing.Point( 315, 3 );
            MetricLabel3.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel3.Name = "MetricLabel3";
            MetricLabel3.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel3.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel3.StyleManager = null;
            MetricLabel3.TabIndex = 43;
            MetricLabel3.Tag = "STAT";
            MetricLabel3.Text = "Text";
            MetricLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel3.ThemeAuthor = "Terry D. Eppler";
            MetricLabel3.ThemeName = "BudgetExecution";
            MetricLabel3.ToolTip = ToolTip;
            // 
            // MetricLabel1
            // 
            MetricLabel1.BindingSource = null;
            MetricLabel1.DataFilter = null;
            MetricLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel1.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel1.HoverText = null;
            MetricLabel1.IsDerivedStyle = true;
            MetricLabel1.Location = new System.Drawing.Point( 3, 3 );
            MetricLabel1.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel1.Name = "MetricLabel1";
            MetricLabel1.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel1.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel1.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel1.StyleManager = null;
            MetricLabel1.TabIndex = 33;
            MetricLabel1.Tag = "STAT";
            MetricLabel1.Text = "Text";
            MetricLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel1.ThemeAuthor = "Terry D. Eppler";
            MetricLabel1.ThemeName = "BudgetExecution";
            MetricLabel1.ToolTip = ToolTip;
            // 
            // MetricLabel2
            // 
            MetricLabel2.BindingSource = null;
            MetricLabel2.DataFilter = null;
            MetricLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel2.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel2.HoverText = null;
            MetricLabel2.IsDerivedStyle = true;
            MetricLabel2.Location = new System.Drawing.Point( 159, 3 );
            MetricLabel2.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel2.Name = "MetricLabel2";
            MetricLabel2.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel2.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel2.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel2.StyleManager = null;
            MetricLabel2.TabIndex = 44;
            MetricLabel2.Tag = "STAT";
            MetricLabel2.Text = "Text";
            MetricLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel2.ThemeAuthor = "Terry D. Eppler";
            MetricLabel2.ThemeName = "BudgetExecution";
            MetricLabel2.ToolTip = ToolTip;
            // 
            // MetricLabel4
            // 
            MetricLabel4.BindingSource = null;
            MetricLabel4.DataFilter = null;
            MetricLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel4.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel4.HoverText = null;
            MetricLabel4.IsDerivedStyle = true;
            MetricLabel4.Location = new System.Drawing.Point( 471, 3 );
            MetricLabel4.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel4.Name = "MetricLabel4";
            MetricLabel4.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel4.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel4.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel4.StyleManager = null;
            MetricLabel4.TabIndex = 44;
            MetricLabel4.Tag = "STAT";
            MetricLabel4.Text = "Text";
            MetricLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel4.ThemeAuthor = "Terry D. Eppler";
            MetricLabel4.ThemeName = "BudgetExecution";
            MetricLabel4.ToolTip = ToolTip;
            // 
            // MetricLabel5
            // 
            MetricLabel5.BindingSource = null;
            MetricLabel5.DataFilter = null;
            MetricLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel5.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel5.HoverText = null;
            MetricLabel5.IsDerivedStyle = true;
            MetricLabel5.Location = new System.Drawing.Point( 627, 3 );
            MetricLabel5.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel5.Name = "MetricLabel5";
            MetricLabel5.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel5.Size = new System.Drawing.Size( 151, 18 );
            MetricLabel5.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel5.StyleManager = null;
            MetricLabel5.TabIndex = 45;
            MetricLabel5.Tag = "STAT";
            MetricLabel5.Text = "Text";
            MetricLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel5.ThemeAuthor = "Terry D. Eppler";
            MetricLabel5.ThemeName = "Budget Execution";
            MetricLabel5.ToolTip = ToolTip;
            // 
            // MetricLabel6
            // 
            MetricLabel6.BindingSource = null;
            MetricLabel6.DataFilter = null;
            MetricLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel6.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel6.HoverText = null;
            MetricLabel6.IsDerivedStyle = true;
            MetricLabel6.Location = new System.Drawing.Point( 3, 27 );
            MetricLabel6.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel6.Name = "MetricLabel6";
            MetricLabel6.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel6.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel6.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel6.StyleManager = null;
            MetricLabel6.TabIndex = 46;
            MetricLabel6.Tag = "STAT";
            MetricLabel6.Text = "Text";
            MetricLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel6.ThemeAuthor = "Terry D. Eppler";
            MetricLabel6.ThemeName = "Budget Execution";
            MetricLabel6.ToolTip = ToolTip;
            // 
            // MetricLabel7
            // 
            MetricLabel7.BindingSource = null;
            MetricLabel7.DataFilter = null;
            MetricLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel7.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel7.HoverText = null;
            MetricLabel7.IsDerivedStyle = true;
            MetricLabel7.Location = new System.Drawing.Point( 159, 27 );
            MetricLabel7.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel7.Name = "MetricLabel7";
            MetricLabel7.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel7.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel7.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel7.StyleManager = null;
            MetricLabel7.TabIndex = 47;
            MetricLabel7.Tag = "STAT";
            MetricLabel7.Text = "Text";
            MetricLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel7.ThemeAuthor = "Terry D. Eppler";
            MetricLabel7.ThemeName = "Budget Execution";
            MetricLabel7.ToolTip = ToolTip;
            // 
            // MetricLabel8
            // 
            MetricLabel8.BindingSource = null;
            MetricLabel8.DataFilter = null;
            MetricLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel8.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel8.HoverText = null;
            MetricLabel8.IsDerivedStyle = true;
            MetricLabel8.Location = new System.Drawing.Point( 315, 27 );
            MetricLabel8.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel8.Name = "MetricLabel8";
            MetricLabel8.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel8.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel8.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel8.StyleManager = null;
            MetricLabel8.TabIndex = 48;
            MetricLabel8.Tag = "STAT";
            MetricLabel8.Text = "Text";
            MetricLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel8.ThemeAuthor = "Terry D. Eppler";
            MetricLabel8.ThemeName = "Budget Execution";
            MetricLabel8.ToolTip = ToolTip;
            // 
            // MetricLabel9
            // 
            MetricLabel9.BindingSource = null;
            MetricLabel9.DataFilter = null;
            MetricLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel9.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel9.HoverText = null;
            MetricLabel9.IsDerivedStyle = true;
            MetricLabel9.Location = new System.Drawing.Point( 471, 27 );
            MetricLabel9.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel9.Name = "MetricLabel9";
            MetricLabel9.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel9.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel9.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel9.StyleManager = null;
            MetricLabel9.TabIndex = 49;
            MetricLabel9.Tag = "STAT";
            MetricLabel9.Text = "Text";
            MetricLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel9.ThemeAuthor = "Terry D. Eppler";
            MetricLabel9.ThemeName = "Budget Execution";
            MetricLabel9.ToolTip = ToolTip;
            // 
            // MetricLabel10
            // 
            MetricLabel10.BindingSource = null;
            MetricLabel10.DataFilter = null;
            MetricLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel10.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel10.HoverText = null;
            MetricLabel10.IsDerivedStyle = true;
            MetricLabel10.Location = new System.Drawing.Point( 627, 27 );
            MetricLabel10.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel10.Name = "MetricLabel10";
            MetricLabel10.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel10.Size = new System.Drawing.Size( 151, 18 );
            MetricLabel10.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel10.StyleManager = null;
            MetricLabel10.TabIndex = 50;
            MetricLabel10.Tag = "STAT";
            MetricLabel10.Text = "Text";
            MetricLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel10.ThemeAuthor = "Terry D. Eppler";
            MetricLabel10.ThemeName = "Budget Execution";
            MetricLabel10.ToolTip = ToolTip;
            // 
            // MetricLabel11
            // 
            MetricLabel11.BindingSource = null;
            MetricLabel11.DataFilter = null;
            MetricLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel11.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel11.HoverText = null;
            MetricLabel11.IsDerivedStyle = true;
            MetricLabel11.Location = new System.Drawing.Point( 3, 51 );
            MetricLabel11.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel11.Name = "MetricLabel11";
            MetricLabel11.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel11.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel11.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel11.StyleManager = null;
            MetricLabel11.TabIndex = 51;
            MetricLabel11.Tag = "STAT";
            MetricLabel11.Text = "Text";
            MetricLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel11.ThemeAuthor = "Terry D. Eppler";
            MetricLabel11.ThemeName = "Budget Execution";
            MetricLabel11.ToolTip = null;
            // 
            // MetricLabel12
            // 
            MetricLabel12.BindingSource = null;
            MetricLabel12.DataFilter = null;
            MetricLabel12.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel12.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel12.HoverText = null;
            MetricLabel12.IsDerivedStyle = true;
            MetricLabel12.Location = new System.Drawing.Point( 159, 51 );
            MetricLabel12.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel12.Name = "MetricLabel12";
            MetricLabel12.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel12.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel12.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel12.StyleManager = null;
            MetricLabel12.TabIndex = 52;
            MetricLabel12.Tag = "STAT";
            MetricLabel12.Text = "Text";
            MetricLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel12.ThemeAuthor = "Terry D. Eppler";
            MetricLabel12.ThemeName = "Budget Execution";
            MetricLabel12.ToolTip = null;
            // 
            // MetricLabel13
            // 
            MetricLabel13.BindingSource = null;
            MetricLabel13.DataFilter = null;
            MetricLabel13.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel13.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel13.HoverText = null;
            MetricLabel13.IsDerivedStyle = true;
            MetricLabel13.Location = new System.Drawing.Point( 315, 51 );
            MetricLabel13.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel13.Name = "MetricLabel13";
            MetricLabel13.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel13.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel13.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel13.StyleManager = null;
            MetricLabel13.TabIndex = 53;
            MetricLabel13.Tag = "STAT";
            MetricLabel13.Text = "Text";
            MetricLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel13.ThemeAuthor = "Terry D. Eppler";
            MetricLabel13.ThemeName = "Budget Execution";
            MetricLabel13.ToolTip = null;
            // 
            // MetricLabel14
            // 
            MetricLabel14.BindingSource = null;
            MetricLabel14.DataFilter = null;
            MetricLabel14.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel14.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel14.HoverText = null;
            MetricLabel14.IsDerivedStyle = true;
            MetricLabel14.Location = new System.Drawing.Point( 471, 51 );
            MetricLabel14.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel14.Name = "MetricLabel14";
            MetricLabel14.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel14.Size = new System.Drawing.Size( 150, 18 );
            MetricLabel14.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel14.StyleManager = null;
            MetricLabel14.TabIndex = 54;
            MetricLabel14.Tag = "STAT";
            MetricLabel14.Text = "Text";
            MetricLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel14.ThemeAuthor = "Terry D. Eppler";
            MetricLabel14.ThemeName = "Budget Execution";
            MetricLabel14.ToolTip = null;
            // 
            // MetricLabel15
            // 
            MetricLabel15.BindingSource = null;
            MetricLabel15.DataFilter = null;
            MetricLabel15.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricLabel15.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricLabel15.HoverText = null;
            MetricLabel15.IsDerivedStyle = true;
            MetricLabel15.Location = new System.Drawing.Point( 627, 51 );
            MetricLabel15.Margin = new System.Windows.Forms.Padding( 3 );
            MetricLabel15.Name = "MetricLabel15";
            MetricLabel15.Padding = new System.Windows.Forms.Padding( 1 );
            MetricLabel15.Size = new System.Drawing.Size( 151, 18 );
            MetricLabel15.Style = MetroSet_UI.Enums.Style.Custom;
            MetricLabel15.StyleManager = null;
            MetricLabel15.TabIndex = 55;
            MetricLabel15.Tag = "STAT";
            MetricLabel15.Text = "Text";
            MetricLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MetricLabel15.ThemeAuthor = "Terry D. Eppler";
            MetricLabel15.ThemeName = "Budget Execution";
            MetricLabel15.ToolTip = null;
            // 
            // BusyTab
            // 
            BusyTab.Controls.Add( Loader );
            BusyTab.Image = null;
            BusyTab.ImageSize = new System.Drawing.Size( 16, 16 );
            BusyTab.Location = new System.Drawing.Point( 0, 29 );
            BusyTab.Name = "BusyTab";
            BusyTab.ShowCloseButton = true;
            BusyTab.Size = new System.Drawing.Size( 1061, 587 );
            BusyTab.TabIndex = 2;
            BusyTab.ThemesEnabled = false;
            // 
            // Loader
            // 
            Loader.Image = Resources.Images.Loading;
            Loader.Location = new System.Drawing.Point( 41, 0 );
            Loader.Name = "Loader";
            Loader.Size = new System.Drawing.Size( 982, 562 );
            Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Loader.TabIndex = 0;
            Loader.TabStop = false;
            // 
            // SourcePanel
            // 
            SourcePanel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SourcePanel.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourcePanel.CaptionText = "Data Tables";
            SourcePanel.ColumnCount = 1;
            SourcePanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SourcePanel.Controls.Add( TableListBoxLayout, 0, 1 );
            SourcePanel.Font = new System.Drawing.Font( "Roboto", 9F );
            SourcePanel.ForeColor = System.Drawing.Color.DarkGray;
            SourcePanel.Location = new System.Drawing.Point( 1087, 35 );
            SourcePanel.Name = "SourcePanel";
            SourcePanel.RowCount = 2;
            SourcePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            SourcePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            SourcePanel.Size = new System.Drawing.Size( 242, 643 );
            SourcePanel.TabIndex = 51;
            // 
            // TableListBoxLayout
            // 
            TableListBoxLayout.BackColor = System.Drawing.Color.Transparent;
            TableListBoxLayout.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBoxLayout.BindingSource = null;
            TableListBoxLayout.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TableListBoxLayout.BorderThickness = 1;
            TableListBoxLayout.Children = null;
            TableListBoxLayout.Controls.Add( TableListBox );
            TableListBoxLayout.DataFilter = null;
            TableListBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            TableListBoxLayout.Font = new System.Drawing.Font( "Roboto", 8F );
            TableListBoxLayout.ForeColor = System.Drawing.Color.Transparent;
            TableListBoxLayout.HoverText = null;
            TableListBoxLayout.IsDerivedStyle = true;
            TableListBoxLayout.Location = new System.Drawing.Point( 3, 26 );
            TableListBoxLayout.Name = "TableListBoxLayout";
            TableListBoxLayout.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBoxLayout.Size = new System.Drawing.Size( 236, 614 );
            TableListBoxLayout.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBoxLayout.StyleManager = null;
            TableListBoxLayout.TabIndex = 0;
            TableListBoxLayout.ThemeAuthor = "Terry D. Eppler";
            TableListBoxLayout.ThemeName = "Budget Execution";
            TableListBoxLayout.ToolTip = null;
            // 
            // TableListBox
            // 
            TableListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            TableListBox.BindingSource = null;
            TableListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            TableListBox.DataFilter = null;
            TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBox.Font = new System.Drawing.Font( "Roboto", 8F );
            TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            TableListBox.HoveredItemColor = System.Drawing.Color.White;
            TableListBox.HoverText = null;
            TableListBox.IsDerivedStyle = true;
            TableListBox.ItemHeight = 28;
            TableListBox.Location = new System.Drawing.Point( 23, 30 );
            TableListBox.Margin = new System.Windows.Forms.Padding( 1 );
            TableListBox.MultiSelect = true;
            TableListBox.Name = "TableListBox";
            TableListBox.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBox.SelectedIndex = -1;
            TableListBox.SelectedItem = null;
            TableListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableListBox.SelectedItemColor = System.Drawing.Color.White;
            TableListBox.SelectedText = null;
            TableListBox.SelectedValue = null;
            TableListBox.ShowBorder = false;
            TableListBox.ShowScrollBar = true;
            TableListBox.Size = new System.Drawing.Size( 188, 562 );
            TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBox.StyleManager = null;
            TableListBox.TabIndex = 0;
            TableListBox.ThemeAuthor = "Terry D. Eppler";
            TableListBox.ThemeName = "Budget Execution";
            TableListBox.ToolTip = null;
            // 
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 1;
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Controls.Add( ToolStrip, 0, 0 );
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point( 0, 694 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1338, 45 );
            ToolStripTable.TabIndex = 52;
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
            // PivotChartForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            ControlBox = false;
            Controls.Add( ToolStripTable );
            Controls.Add( SourcePanel );
            Controls.Add( ChartHeaderTable );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "PivotChartForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PivotChartForm";
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ChartHeaderTable.ResumeLayout( false );
            PivotLayout.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            DataTab.ResumeLayout( false );
            AreaTable.ResumeLayout( false );
            ChartAreaPanel.ResumeLayout( false );
            ChartSubTablePanel.ResumeLayout( false );
            ChartSubTable.ResumeLayout( false );
            MetricsTable.ResumeLayout( false );
            BusyTab.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)Loader ).EndInit( );
            SourcePanel.ResumeLayout( false );
            TableListBoxLayout.ResumeLayout( false );
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ResumeLayout( false );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        public System.Windows.Forms.PictureBox PictureBox;
        public Label Title;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
        public SmallTip ToolTip;
        public ToolStrip ToolStrip;
        public HeaderPanel ChartHeaderTable;
        public System.Windows.Forms.TableLayoutPanel AreaTable;
        public BackPanel ChartAreaPanel;
        public BackPanel ChartSubTablePanel;
        private System.Windows.Forms.TableLayoutPanel ChartSubTable;
        public Label SqlHeader;
        public System.Windows.Forms.TableLayoutPanel MetricsTable;
        public Label MetricLabel3;
        public Label MetricLabel1;
        public Label MetricLabel2;
        public Label MetricLabel4;
        public Label MetricLabel5;
        public Label MetricLabel6;
        public HeaderPanel SourcePanel;
        public BackPanel TableListBoxLayout;
        public ListBox TableListBox;
        public ToolSeparator Separator1;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator5;
        public ToolSeparator Separator4;
        private ToolStripButton LastButton;
        public ToolSeparator Separator6;
        private ToolStripLabel SystemLabel;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolStripButton CloseButton;
        public ToolSeparator Separator11;
        public ToolStripButton MenuButton;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolSeparator Separator14;
        public ToolStripButton FilterButton;
        public ToolStripButton SaveButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolStripButton FirstButton;
        public ToolSeparator LastSeparator;
        public ToolStripLabel NavigationLabel;
        public ToolStripLabel FilterLabel;
        public ToolStripLabel StatusLabel;
        public ToolSeparator FirstSeparator;
        private BackPanel PivotLayout;
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv DataTab;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTab;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public System.Windows.Forms.PictureBox Loader;
        public ToolStripLabel ApplicationLabel;
        public Label MetricLabel17;
        public Label MetricLabel16;
        public Label MetricLabel18;
        public Label MetricLabel20;
        public Label MetricLabel19;
        public Label MetricLabel7;
        public Label MetricLabel8;
        public Label MetricLabel9;
        public Label MetricLabel10;
        public Label MetricLabel11;
        public Label MetricLabel12;
        public Label MetricLabel13;
        public Label MetricLabel14;
        public Label MetricLabel15;
        public ContextMenu ContextMenu;
        public ToolStripDropDown ComboBox;
        public ToolStripButton RefreshButton;
        public Syncfusion.Windows.Forms.PivotChart.PivotChart PivotChart;
    }
}