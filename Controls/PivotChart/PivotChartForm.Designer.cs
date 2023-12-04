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
            NavigationSeparator = new ToolSeparator( );
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
            LookupButton = new ToolStripButton( );
            Separator13 = new ToolSeparator( );
            FilterButton = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            LastSeparator = new ToolSeparator( );
            FirstSeparator = new ToolSeparator( );
            ChartHeaderTable = new HeaderPanel( );
            PivotLayout = new BackPanel( );
            TabControl = new TabControl( );
            DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            AreaTable = new System.Windows.Forms.TableLayoutPanel( );
            ChartAreaPanel = new BackPanel( );
            Chart = new PivotChart( );
            ChartSubTablePanel = new BackPanel( );
            ChartSubTable = new System.Windows.Forms.TableLayoutPanel( );
            SqlHeader = new Label( );
            MetricsTable = new System.Windows.Forms.TableLayoutPanel( );
            ThirdDataLabel = new Label( );
            FirstDataLabel = new Label( );
            SecondDataLabel = new Label( );
            FourthDataLabel = new Label( );
            FifthDataLabel = new Label( );
            SixthDataLabel = new Label( );
            BusyTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            Loader = new System.Windows.Forms.PictureBox( );
            SourcePanel = new HeaderPanel( );
            TableListBoxLayout = new BackPanel( );
            TableListBox = new ListBox( );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ApplicationLabel = new ToolStripLabel( );
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
            PictureBox.Image = Resources.Images.App;
            PictureBox.InitialImage = Resources.Images.App;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 26, 20 );
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
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, StatusLabel, NavigationSeparator, NavigationLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator5, NextButton, Separator4, LastButton, Separator6, SystemLabel, Separator7, BrowseButton, Separator8, SaveButton, Separator9, Separator10, CloseButton, Separator11, MenuButton, FilterLabel, Separator12, LookupButton, Separator13, FilterButton, Separator14, LastSeparator, ApplicationLabel } );
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 1, 1 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
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
            Separator1.Size = new System.Drawing.Size( 6, 23 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            StatusLabel.BindingSource = null;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 50, 23 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date & Time";
            StatusLabel.ToolTip = null;
            // 
            // NavigationSeparator
            // 
            NavigationSeparator.ForeColor = System.Drawing.Color.Black;
            NavigationSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            NavigationSeparator.Name = "NavigationSeparator";
            NavigationSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            NavigationSeparator.Size = new System.Drawing.Size( 6, 23 );
            // 
            // NavigationLabel
            // 
            NavigationLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            NavigationLabel.BindingSource = null;
            NavigationLabel.DataFilter = null;
            NavigationLabel.Field = Field.AccountCode;
            NavigationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NavigationLabel.ForeColor = System.Drawing.Color.Black;
            NavigationLabel.HoverText = null;
            NavigationLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            NavigationLabel.Size = new System.Drawing.Size( 83, 23 );
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
            Separator2.Size = new System.Drawing.Size( 6, 23 );
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
            FirstButton.HoverText = null;
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator3.Size = new System.Drawing.Size( 6, 23 );
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
            PreviousButton.HoverText = null;
            PreviousButton.Image = Resources.Images.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator5.Size = new System.Drawing.Size( 6, 23 );
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
            NextButton.HoverText = null;
            NextButton.Image = Resources.Images.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator4.Size = new System.Drawing.Size( 6, 23 );
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
            LastButton.HoverText = null;
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator6.Size = new System.Drawing.Size( 6, 23 );
            // 
            // SystemLabel
            // 
            SystemLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            SystemLabel.BindingSource = null;
            SystemLabel.DataFilter = null;
            SystemLabel.Field = Field.AccountCode;
            SystemLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SystemLabel.ForeColor = System.Drawing.Color.Black;
            SystemLabel.HoverText = null;
            SystemLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SystemLabel.Name = "SystemLabel";
            SystemLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SystemLabel.Size = new System.Drawing.Size( 71, 23 );
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
            Separator7.Size = new System.Drawing.Size( 6, 23 );
            // 
            // BrowseButton
            // 
            BrowseButton.AutoToolTip = false;
            BrowseButton.BackColor = System.Drawing.Color.Transparent;
            BrowseButton.BindingSource = BindingSource;
            BrowseButton.DataFilter = null;
            BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BrowseButton.Field = Field.AccountCode;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BrowseButton.ForeColor = System.Drawing.Color.LightGray;
            BrowseButton.HoverText = null;
            BrowseButton.Image = Resources.Images.BrowseButton;
            BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BrowseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator8.Size = new System.Drawing.Size( 6, 23 );
            // 
            // SaveButton
            // 
            SaveButton.AutoToolTip = false;
            SaveButton.BackColor = System.Drawing.Color.Transparent;
            SaveButton.BindingSource = BindingSource;
            SaveButton.DataFilter = null;
            SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveButton.Field = Field.AccountCode;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SaveButton.ForeColor = System.Drawing.Color.LightGray;
            SaveButton.HoverText = null;
            SaveButton.Image = Resources.Images.SaveButton;
            SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator9.Size = new System.Drawing.Size( 6, 23 );
            // 
            // Separator10
            // 
            Separator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 23 );
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
            CloseButton.HoverText = null;
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator11.Size = new System.Drawing.Size( 6, 23 );
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
            MenuButton.HoverText = null;
            MenuButton.Image = Resources.Images.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 23 );
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
            FilterLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FilterLabel.ForeColor = System.Drawing.Color.Black;
            FilterLabel.HoverText = null;
            FilterLabel.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FilterLabel.Size = new System.Drawing.Size( 60, 23 );
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
            Separator12.Size = new System.Drawing.Size( 6, 23 );
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip = false;
            LookupButton.BackColor = System.Drawing.Color.Transparent;
            LookupButton.BindingSource = BindingSource;
            LookupButton.DataFilter = null;
            LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LookupButton.Field = Field.AccountCode;
            LookupButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LookupButton.ForeColor = System.Drawing.Color.LightGray;
            LookupButton.HoverText = null;
            LookupButton.Image = Resources.Images.WebRefreshButton;
            LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LookupButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new System.Windows.Forms.Padding( 1 );
            LookupButton.Size = new System.Drawing.Size( 23, 23 );
            LookupButton.Text = "toolStripButton9";
            LookupButton.ToolTip = ToolTip;
            LookupButton.ToolType = ToolType.LookupButton;
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 23 );
            // 
            // FilterButton
            // 
            FilterButton.AutoToolTip = false;
            FilterButton.BackColor = System.Drawing.Color.Transparent;
            FilterButton.BindingSource = BindingSource;
            FilterButton.DataFilter = null;
            FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FilterButton.Field = Field.AccountCode;
            FilterButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FilterButton.ForeColor = System.Drawing.Color.LightGray;
            FilterButton.HoverText = null;
            FilterButton.Image = Resources.Images.FilterButton;
            FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FilterButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FilterButton.Name = "FilterButton";
            FilterButton.Padding = new System.Windows.Forms.Padding( 1 );
            FilterButton.Size = new System.Drawing.Size( 23, 23 );
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
            Separator14.Size = new System.Drawing.Size( 6, 23 );
            // 
            // LastSeparator
            // 
            LastSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            LastSeparator.ForeColor = System.Drawing.Color.Black;
            LastSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            LastSeparator.Name = "LastSeparator";
            LastSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            LastSeparator.Size = new System.Drawing.Size( 6, 23 );
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
            ChartHeaderTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartHeaderTable.ForeColor = System.Drawing.Color.DarkGray;
            ChartHeaderTable.Location = new System.Drawing.Point( 37, 35 );
            ChartHeaderTable.Name = "ChartHeaderTable";
            ChartHeaderTable.RowCount = 2;
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            ChartHeaderTable.Size = new System.Drawing.Size( 1044, 647 );
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
            PivotLayout.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PivotLayout.ForeColor = System.Drawing.Color.Transparent;
            PivotLayout.HoverText = null;
            PivotLayout.IsDerivedStyle = true;
            PivotLayout.Location = new System.Drawing.Point( 3, 26 );
            PivotLayout.Name = "PivotLayout";
            PivotLayout.Padding = new System.Windows.Forms.Padding( 1 );
            PivotLayout.Size = new System.Drawing.Size( 1038, 618 );
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
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 1036, 616 );
            TabControl.BindingSource = null;
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( DataTab );
            TabControl.Controls.Add( BusyTab );
            TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 100, 30 );
            TabControl.Location = new System.Drawing.Point( 1, 1 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 1036, 616 );
            TabControl.TabIndex = 52;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            DataTab.Size = new System.Drawing.Size( 1036, 587 );
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
            AreaTable.Location = new System.Drawing.Point( 41, 12 );
            AreaTable.Name = "AreaTable";
            AreaTable.RowCount = 2;
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 80.71066F ) );
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 19.289341F ) );
            AreaTable.Size = new System.Drawing.Size( 992, 572 );
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
            ChartAreaPanel.Controls.Add( Chart );
            ChartAreaPanel.DataFilter = null;
            ChartAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartAreaPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartAreaPanel.ForeColor = System.Drawing.Color.Transparent;
            ChartAreaPanel.HoverText = null;
            ChartAreaPanel.IsDerivedStyle = true;
            ChartAreaPanel.Location = new System.Drawing.Point( 3, 3 );
            ChartAreaPanel.Name = "ChartAreaPanel";
            ChartAreaPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartAreaPanel.Size = new System.Drawing.Size( 986, 455 );
            ChartAreaPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ChartAreaPanel.StyleManager = null;
            ChartAreaPanel.TabIndex = 7;
            ChartAreaPanel.ThemeAuthor = "Terry D. Eppler";
            ChartAreaPanel.ThemeName = "Budget Execution";
            ChartAreaPanel.ToolTip = null;
            // 
            // Chart
            // 
            Chart.AllowDrillDown = true;
            Chart.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Chart.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
            Chart.CustomPalette = new System.Drawing.Color[ ]
    {
    System.Drawing.Color.FromArgb(147, 208, 249),
    System.Drawing.Color.FromArgb(102, 170, 225),
    System.Drawing.Color.FromArgb(250, 163, 94),
    System.Drawing.Color.FromArgb(252, 227, 127)
    };
            Chart.DeferLayoutUpdate = false;
            Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            Chart.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Chart.Location = new System.Drawing.Point( 1, 1 );
            Chart.MinimumSize = new System.Drawing.Size( 300, 250 );
            Chart.Name = "Chart";
            Chart.ShowPivotTableFieldList = true;
            Chart.Size = new System.Drawing.Size( 984, 453 );
            Chart.TabIndex = 0;
            Chart.Text = "pivotChart1";
            Chart.UpdateManager = null;
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
            ChartSubTablePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartSubTablePanel.ForeColor = System.Drawing.Color.Transparent;
            ChartSubTablePanel.HoverText = null;
            ChartSubTablePanel.IsDerivedStyle = true;
            ChartSubTablePanel.Location = new System.Drawing.Point( 3, 464 );
            ChartSubTablePanel.Name = "ChartSubTablePanel";
            ChartSubTablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSubTablePanel.Size = new System.Drawing.Size( 986, 105 );
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
            ChartSubTable.Location = new System.Drawing.Point( 517, 4 );
            ChartSubTable.Name = "ChartSubTable";
            ChartSubTable.RowCount = 2;
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 72F ) );
            ChartSubTable.Size = new System.Drawing.Size( 465, 97 );
            ChartSubTable.TabIndex = 5;
            // 
            // SqlHeader
            // 
            SqlHeader.BindingSource = null;
            SqlHeader.DataFilter = null;
            SqlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            SqlHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SqlHeader.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlHeader.HoverText = null;
            SqlHeader.IsDerivedStyle = true;
            SqlHeader.Location = new System.Drawing.Point( 3, 3 );
            SqlHeader.Margin = new System.Windows.Forms.Padding( 3 );
            SqlHeader.Name = "SqlHeader";
            SqlHeader.Padding = new System.Windows.Forms.Padding( 1 );
            SqlHeader.Size = new System.Drawing.Size( 459, 19 );
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
            MetricsTable.ColumnCount = 4;
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.88889F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 32.22222F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.88889F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 139F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            MetricsTable.Controls.Add( ThirdDataLabel, 2, 0 );
            MetricsTable.Controls.Add( FirstDataLabel, 0, 0 );
            MetricsTable.Controls.Add( SecondDataLabel, 1, 0 );
            MetricsTable.Controls.Add( FourthDataLabel, 0, 1 );
            MetricsTable.Controls.Add( FifthDataLabel, 1, 1 );
            MetricsTable.Controls.Add( SixthDataLabel, 2, 1 );
            MetricsTable.Location = new System.Drawing.Point( 1, 4 );
            MetricsTable.Name = "MetricsTable";
            MetricsTable.RowCount = 3;
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 51.47059F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 48.52941F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 28F ) );
            MetricsTable.Size = new System.Drawing.Size( 500, 97 );
            MetricsTable.TabIndex = 4;
            // 
            // ThirdDataLabel
            // 
            ThirdDataLabel.BindingSource = null;
            ThirdDataLabel.DataFilter = null;
            ThirdDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            ThirdDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ThirdDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdDataLabel.HoverText = null;
            ThirdDataLabel.IsDerivedStyle = true;
            ThirdDataLabel.Location = new System.Drawing.Point( 241, 3 );
            ThirdDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            ThirdDataLabel.Name = "ThirdDataLabel";
            ThirdDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ThirdDataLabel.Size = new System.Drawing.Size( 116, 29 );
            ThirdDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdDataLabel.StyleManager = null;
            ThirdDataLabel.TabIndex = 43;
            ThirdDataLabel.Text = "Source";
            ThirdDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            ThirdDataLabel.ThemeAuthor = "Terry D. Eppler";
            ThirdDataLabel.ThemeName = "BudgetExecution";
            ThirdDataLabel.ToolTip = null;
            // 
            // FirstDataLabel
            // 
            FirstDataLabel.BindingSource = null;
            FirstDataLabel.DataFilter = null;
            FirstDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            FirstDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FirstDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstDataLabel.HoverText = null;
            FirstDataLabel.IsDerivedStyle = true;
            FirstDataLabel.Location = new System.Drawing.Point( 3, 3 );
            FirstDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FirstDataLabel.Name = "FirstDataLabel";
            FirstDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FirstDataLabel.Size = new System.Drawing.Size( 116, 29 );
            FirstDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FirstDataLabel.StyleManager = null;
            FirstDataLabel.TabIndex = 33;
            FirstDataLabel.Text = "Source";
            FirstDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            FirstDataLabel.ThemeAuthor = "Terry D. Eppler";
            FirstDataLabel.ThemeName = "BudgetExecution";
            FirstDataLabel.ToolTip = null;
            // 
            // SecondDataLabel
            // 
            SecondDataLabel.BindingSource = null;
            SecondDataLabel.DataFilter = null;
            SecondDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SecondDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondDataLabel.HoverText = null;
            SecondDataLabel.IsDerivedStyle = true;
            SecondDataLabel.Location = new System.Drawing.Point( 125, 3 );
            SecondDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SecondDataLabel.Name = "SecondDataLabel";
            SecondDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SecondDataLabel.Size = new System.Drawing.Size( 110, 29 );
            SecondDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondDataLabel.StyleManager = null;
            SecondDataLabel.TabIndex = 44;
            SecondDataLabel.Text = "Source";
            SecondDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SecondDataLabel.ThemeAuthor = "Terry D. Eppler";
            SecondDataLabel.ThemeName = "BudgetExecution";
            SecondDataLabel.ToolTip = null;
            // 
            // FourthDataLabel
            // 
            FourthDataLabel.BindingSource = null;
            FourthDataLabel.DataFilter = null;
            FourthDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            FourthDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FourthDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FourthDataLabel.HoverText = null;
            FourthDataLabel.IsDerivedStyle = true;
            FourthDataLabel.Location = new System.Drawing.Point( 3, 38 );
            FourthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FourthDataLabel.Name = "FourthDataLabel";
            FourthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FourthDataLabel.Size = new System.Drawing.Size( 116, 27 );
            FourthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FourthDataLabel.StyleManager = null;
            FourthDataLabel.TabIndex = 44;
            FourthDataLabel.Text = "Source";
            FourthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            FourthDataLabel.ThemeAuthor = "Terry D. Eppler";
            FourthDataLabel.ThemeName = "BudgetExecution";
            FourthDataLabel.ToolTip = null;
            // 
            // FifthDataLabel
            // 
            FifthDataLabel.BindingSource = null;
            FifthDataLabel.DataFilter = null;
            FifthDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            FifthDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FifthDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FifthDataLabel.HoverText = null;
            FifthDataLabel.IsDerivedStyle = true;
            FifthDataLabel.Location = new System.Drawing.Point( 125, 38 );
            FifthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FifthDataLabel.Name = "FifthDataLabel";
            FifthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FifthDataLabel.Size = new System.Drawing.Size( 110, 27 );
            FifthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FifthDataLabel.StyleManager = null;
            FifthDataLabel.TabIndex = 45;
            FifthDataLabel.Text = "label2";
            FifthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            FifthDataLabel.ThemeAuthor = "Terry D. Eppler";
            FifthDataLabel.ThemeName = "Budget Execution";
            FifthDataLabel.ToolTip = null;
            // 
            // SixthDataLabel
            // 
            SixthDataLabel.BindingSource = null;
            SixthDataLabel.DataFilter = null;
            SixthDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            SixthDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SixthDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SixthDataLabel.HoverText = null;
            SixthDataLabel.IsDerivedStyle = true;
            SixthDataLabel.Location = new System.Drawing.Point( 241, 38 );
            SixthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SixthDataLabel.Name = "SixthDataLabel";
            SixthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SixthDataLabel.Size = new System.Drawing.Size( 116, 27 );
            SixthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SixthDataLabel.StyleManager = null;
            SixthDataLabel.TabIndex = 46;
            SixthDataLabel.Text = "label3";
            SixthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SixthDataLabel.ThemeAuthor = "Terry D. Eppler";
            SixthDataLabel.ThemeName = "Budget Execution";
            SixthDataLabel.ToolTip = null;
            // 
            // BusyTab
            // 
            BusyTab.Controls.Add( Loader );
            BusyTab.Image = null;
            BusyTab.ImageSize = new System.Drawing.Size( 16, 16 );
            BusyTab.Location = new System.Drawing.Point( 0, 29 );
            BusyTab.Name = "BusyTab";
            BusyTab.ShowCloseButton = true;
            BusyTab.Size = new System.Drawing.Size( 1036, 587 );
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
            SourcePanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            TableListBoxLayout.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            TableListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            // ApplicationLabel
            // 
            ApplicationLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ApplicationLabel.BackColor = System.Drawing.Color.Transparent;
            ApplicationLabel.BindingSource = null;
            ApplicationLabel.DataFilter = null;
            ApplicationLabel.Field = Field.AccountCode;
            ApplicationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ApplicationLabel.ForeColor = System.Drawing.Color.Black;
            ApplicationLabel.HoverText = null;
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 41, 23 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "        App:";
            ApplicationLabel.ToolTip = null;
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
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            ControlBox = false;
            Controls.Add( ToolStripTable );
            Controls.Add( SourcePanel );
            Controls.Add( ChartHeaderTable );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
        public Label ThirdDataLabel;
        public Label FirstDataLabel;
        public Label SecondDataLabel;
        public Label FourthDataLabel;
        public Label FifthDataLabel;
        public Label SixthDataLabel;
        public HeaderPanel SourcePanel;
        public BackPanel TableListBoxLayout;
        public ListBox TableListBox;
        public ToolSeparator Separator1;
        public ToolSeparator Separator2;
        private ToolStripButton toolStripButton1;
        public ToolSeparator Separator3;
        private ToolStripButton toolStripButton2;
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
        private ToolStripButton LookupButton;
        public ToolSeparator Separator13;
        public ToolSeparator Separator14;
        public ToolStripButton FilterButton;
        public ToolStripButton SaveButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolStripButton FirstButton;
        public ToolSeparator LastSeparator;
        public ToolSeparator NavigationSeparator;
        public ToolStripLabel NavigationLabel;
        public ToolStripLabel FilterLabel;
        public ToolStripLabel StatusLabel;
        public ToolSeparator FirstSeparator;
        private BackPanel PivotLayout;
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv DataTab;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTab;
        public PivotChart Chart;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public System.Windows.Forms.PictureBox Loader;
        public ToolStripLabel ApplicationLabel;
    }
}