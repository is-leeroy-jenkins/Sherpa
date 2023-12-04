namespace BudgetExecution
{
    partial class PivotGridForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PivotGridForm ) );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            toolSeparator1 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            toolStripLabel1 = new ToolStripLabel( );
            toolStripLabel3 = new ToolStripLabel( );
            toolSeparator2 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            toolSeparator3 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            toolSeparator4 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            toolSeparator5 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            toolSeparator6 = new ToolSeparator( );
            toolStripLabel5 = new ToolStripLabel( );
            toolStripLabel4 = new ToolStripLabel( );
            toolSeparator7 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            toolSeparator15 = new ToolSeparator( );
            SaveButton = new ToolStripButton( );
            toolSeparator9 = new ToolSeparator( );
            ExportButton = new ToolStripButton( );
            toolSeparator10 = new ToolSeparator( );
            toolStripLabel6 = new ToolStripLabel( );
            toolSeparator12 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            toolSeparator13 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            toolSeparator14 = new ToolSeparator( );
            toolStripLabel7 = new ToolStripLabel( );
            toolSeparator8 = new ToolSeparator( );
            ChartHeaderTable = new HeaderPanel( );
            PivotLayout = new BackPanel( );
            TabControl = new TabControl( );
            PivotTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            AreaTable = new System.Windows.Forms.TableLayoutPanel( );
            PivotPanel = new BackPanel( );
            Chart = new Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl( components );
            ChartSubTablePanel = new BackPanel( );
            ChartSubTable = new System.Windows.Forms.TableLayoutPanel( );
            CommandLabel = new Label( );
            MetricsTable = new System.Windows.Forms.TableLayoutPanel( );
            MetricsLabel3 = new Label( );
            MetricsLabel1 = new Label( );
            MetricsLabel2 = new Label( );
            MetricsLabel5 = new Label( );
            MetricsLabel6 = new Label( );
            MetricsLabel7 = new Label( );
            MetricsLabel4 = new Label( );
            MetricsLabel8 = new Label( );
            MetricsLabel9 = new Label( );
            MetricsLabel10 = new Label( );
            MetricsLabel11 = new Label( );
            MetricsLabel12 = new Label( );
            BusyTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            Loader = new System.Windows.Forms.PictureBox( );
            SourcePanel = new HeaderPanel( );
            TableListBoxLayout = new BackPanel( );
            TableListBox = new ListBox( );
            Timer = new System.Windows.Forms.Timer( components );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ToolStripTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ChartHeaderTable.SuspendLayout( );
            PivotLayout.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            PivotTab.SuspendLayout( );
            AreaTable.SuspendLayout( );
            PivotPanel.SuspendLayout( );
            ChartSubTablePanel.SuspendLayout( );
            ChartSubTable.SuspendLayout( );
            MetricsTable.SuspendLayout( );
            BusyTab.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Loader ).BeginInit( );
            SourcePanel.SuspendLayout( );
            TableListBoxLayout.SuspendLayout( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.09267569F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.9073257F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1338, 24 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.App;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 22, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 31, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1304, 18 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
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
            ToolStripTable.Location = new System.Drawing.Point( 0, 694 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1338, 45 );
            ToolStripTable.TabIndex = 1;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { toolSeparator1, StatusLabel, toolStripLabel1, toolStripLabel3, toolSeparator2, FirstButton, toolSeparator3, PreviousButton, toolSeparator4, NextButton, toolSeparator5, LastButton, toolSeparator6, toolStripLabel5, toolStripLabel4, toolSeparator7, RefreshButton, toolSeparator15, SaveButton, toolSeparator9, ExportButton, toolSeparator10, toolStripLabel6, toolSeparator12, CloseButton, toolSeparator13, MenuButton, toolSeparator14, toolStripLabel7 } );
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
            ToolStrip.Text = " ";
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
            // toolSeparator1
            // 
            toolSeparator1.ForeColor = System.Drawing.Color.Black;
            toolSeparator1.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator1.Name = "toolSeparator1";
            toolSeparator1.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator1.Size = new System.Drawing.Size( 6, 25 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.Transparent;
            StatusLabel.BindingSource = null;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 85, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date and Time:";
            StatusLabel.ToolTip = null;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel1.BindingSource = null;
            toolStripLabel1.DataFilter = null;
            toolStripLabel1.Field = Field.AccountCode;
            toolStripLabel1.Font = new System.Drawing.Font( "Roboto", 8F );
            toolStripLabel1.ForeColor = System.Drawing.Color.Transparent;
            toolStripLabel1.HoverText = null;
            toolStripLabel1.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel1.Size = new System.Drawing.Size( 85, 25 );
            toolStripLabel1.Tag = "";
            toolStripLabel1.Text = "toolStripLabel1";
            toolStripLabel1.ToolTip = null;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel3.BindingSource = null;
            toolStripLabel3.DataFilter = null;
            toolStripLabel3.Field = Field.AccountCode;
            toolStripLabel3.Font = new System.Drawing.Font( "Roboto", 8F );
            toolStripLabel3.ForeColor = System.Drawing.Color.Black;
            toolStripLabel3.HoverText = null;
            toolStripLabel3.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel3.Size = new System.Drawing.Size( 98, 25 );
            toolStripLabel3.Tag = "";
            toolStripLabel3.Text = "           Navigation:";
            toolStripLabel3.ToolTip = null;
            // 
            // toolSeparator2
            // 
            toolSeparator2.ForeColor = System.Drawing.Color.Black;
            toolSeparator2.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator2.Name = "toolSeparator2";
            toolSeparator2.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator2.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FirstButton.BindingSource = BindingSource;
            FirstButton.DataFilter = null;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FirstButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FirstButton.HoverText = null;
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
            // toolSeparator3
            // 
            toolSeparator3.ForeColor = System.Drawing.Color.Black;
            toolSeparator3.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator3.Name = "toolSeparator3";
            toolSeparator3.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator3.Size = new System.Drawing.Size( 6, 25 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DataFilter = null;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PreviousButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            PreviousButton.HoverText = null;
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
            // toolSeparator4
            // 
            toolSeparator4.ForeColor = System.Drawing.Color.Black;
            toolSeparator4.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator4.Name = "toolSeparator4";
            toolSeparator4.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator4.Size = new System.Drawing.Size( 6, 25 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            NextButton.BindingSource = BindingSource;
            NextButton.DataFilter = null;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F );
            NextButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            NextButton.HoverText = null;
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
            // toolSeparator5
            // 
            toolSeparator5.ForeColor = System.Drawing.Color.Black;
            toolSeparator5.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator5.Name = "toolSeparator5";
            toolSeparator5.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator5.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            LastButton.BindingSource = BindingSource;
            LastButton.DataFilter = null;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LastButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            LastButton.HoverText = null;
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
            // toolSeparator6
            // 
            toolSeparator6.ForeColor = System.Drawing.Color.Black;
            toolSeparator6.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator6.Name = "toolSeparator6";
            toolSeparator6.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel5.BindingSource = null;
            toolStripLabel5.DataFilter = null;
            toolStripLabel5.Field = Field.AccountCode;
            toolStripLabel5.Font = new System.Drawing.Font( "Roboto", 8F );
            toolStripLabel5.ForeColor = System.Drawing.Color.Transparent;
            toolStripLabel5.HoverText = null;
            toolStripLabel5.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel5.Size = new System.Drawing.Size( 85, 25 );
            toolStripLabel5.Tag = "";
            toolStripLabel5.Text = "toolStripLabel5";
            toolStripLabel5.ToolTip = null;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel4.BindingSource = null;
            toolStripLabel4.DataFilter = null;
            toolStripLabel4.Field = Field.AccountCode;
            toolStripLabel4.Font = new System.Drawing.Font( "Roboto", 8F );
            toolStripLabel4.ForeColor = System.Drawing.Color.Black;
            toolStripLabel4.HoverText = null;
            toolStripLabel4.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel4.Size = new System.Drawing.Size( 65, 25 );
            toolStripLabel4.Tag = "";
            toolStripLabel4.Text = "          Data:";
            toolStripLabel4.ToolTip = null;
            // 
            // toolSeparator7
            // 
            toolSeparator7.ForeColor = System.Drawing.Color.Black;
            toolSeparator7.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator7.Name = "toolSeparator7";
            toolSeparator7.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator7.Size = new System.Drawing.Size( 6, 25 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            RefreshButton.BindingSource = BindingSource;
            RefreshButton.DataFilter = null;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Field = Field.AccountCode;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RefreshButton.HoverText = null;
            RefreshButton.Image = Resources.Images.WebRefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.Size = new System.Drawing.Size( 23, 25 );
            RefreshButton.Text = "toolStripButton5";
            RefreshButton.ToolTip = ToolTip;
            RefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // toolSeparator15
            // 
            toolSeparator15.ForeColor = System.Drawing.Color.Black;
            toolSeparator15.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator15.Name = "toolSeparator15";
            toolSeparator15.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator15.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SaveButton
            // 
            SaveButton.AutoToolTip = false;
            SaveButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            SaveButton.BindingSource = BindingSource;
            SaveButton.DataFilter = null;
            SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveButton.Field = Field.AccountCode;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SaveButton.HoverText = null;
            SaveButton.Image = Resources.Images.SaveButton;
            SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.Size = new System.Drawing.Size( 23, 25 );
            SaveButton.Text = "toolStripButton10";
            SaveButton.ToolTip = ToolTip;
            SaveButton.ToolType = ToolType.SaveButton;
            // 
            // toolSeparator9
            // 
            toolSeparator9.ForeColor = System.Drawing.Color.Black;
            toolSeparator9.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator9.Name = "toolSeparator9";
            toolSeparator9.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator9.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ExportButton
            // 
            ExportButton.AutoToolTip = false;
            ExportButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ExportButton.BindingSource = BindingSource;
            ExportButton.DataFilter = null;
            ExportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ExportButton.Field = Field.AccountCode;
            ExportButton.Font = new System.Drawing.Font( "Roboto", 9F );
            ExportButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ExportButton.HoverText = null;
            ExportButton.Image = Resources.Images.ExcelExportButton;
            ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ExportButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ExportButton.Name = "ExportButton";
            ExportButton.Padding = new System.Windows.Forms.Padding( 1 );
            ExportButton.Size = new System.Drawing.Size( 23, 25 );
            ExportButton.ToolTip = ToolTip;
            ExportButton.ToolType = ToolType.ExcelExportButton;
            // 
            // toolSeparator10
            // 
            toolSeparator10.ForeColor = System.Drawing.Color.Black;
            toolSeparator10.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator10.Name = "toolSeparator10";
            toolSeparator10.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator10.Size = new System.Drawing.Size( 6, 25 );
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel6.BindingSource = null;
            toolStripLabel6.DataFilter = null;
            toolStripLabel6.Field = Field.AccountCode;
            toolStripLabel6.Font = new System.Drawing.Font( "Roboto", 8F );
            toolStripLabel6.ForeColor = System.Drawing.Color.Transparent;
            toolStripLabel6.HoverText = null;
            toolStripLabel6.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel6.Size = new System.Drawing.Size( 85, 25 );
            toolStripLabel6.Tag = "";
            toolStripLabel6.Text = "toolStripLabel6";
            toolStripLabel6.ToolTip = null;
            // 
            // toolSeparator12
            // 
            toolSeparator12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolSeparator12.ForeColor = System.Drawing.Color.Black;
            toolSeparator12.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator12.Name = "toolSeparator12";
            toolSeparator12.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator12.Size = new System.Drawing.Size( 6, 25 );
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            CloseButton.BindingSource = BindingSource;
            CloseButton.DataFilter = null;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverText = null;
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 25 );
            CloseButton.Text = "toolStripButton8";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.CloseButton;
            // 
            // toolSeparator13
            // 
            toolSeparator13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolSeparator13.ForeColor = System.Drawing.Color.Black;
            toolSeparator13.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator13.Name = "toolSeparator13";
            toolSeparator13.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator13.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            MenuButton.BindingSource = BindingSource;
            MenuButton.DataFilter = null;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            MenuButton.HoverText = null;
            MenuButton.Image = Resources.Images.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 25 );
            MenuButton.Text = "toolStripButton9";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // toolSeparator14
            // 
            toolSeparator14.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolSeparator14.ForeColor = System.Drawing.Color.Black;
            toolSeparator14.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator14.Name = "toolSeparator14";
            toolSeparator14.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator14.Size = new System.Drawing.Size( 6, 25 );
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripLabel7.BackColor = System.Drawing.Color.Transparent;
            toolStripLabel7.BindingSource = null;
            toolStripLabel7.DataFilter = null;
            toolStripLabel7.Field = Field.AccountCode;
            toolStripLabel7.Font = new System.Drawing.Font( "Roboto", 8F );
            toolStripLabel7.ForeColor = System.Drawing.Color.Black;
            toolStripLabel7.HoverText = null;
            toolStripLabel7.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel7.Size = new System.Drawing.Size( 98, 25 );
            toolStripLabel7.Tag = "";
            toolStripLabel7.Text = "          Application:";
            toolStripLabel7.ToolTip = null;
            // 
            // toolSeparator8
            // 
            toolSeparator8.ForeColor = System.Drawing.Color.Black;
            toolSeparator8.Margin = new System.Windows.Forms.Padding( 1 );
            toolSeparator8.Name = "toolSeparator8";
            toolSeparator8.Padding = new System.Windows.Forms.Padding( 1 );
            toolSeparator8.Size = new System.Drawing.Size( 6, 25 );
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
            ChartHeaderTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ChartHeaderTable.Location = new System.Drawing.Point( 3, 30 );
            ChartHeaderTable.Name = "ChartHeaderTable";
            ChartHeaderTable.RowCount = 2;
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            ChartHeaderTable.Size = new System.Drawing.Size( 1044, 647 );
            ChartHeaderTable.TabIndex = 51;
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
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 1036, 616 );
            TabControl.BindingSource = null;
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( PivotTab );
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
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ToolTip = null;
            // 
            // PivotTab
            // 
            PivotTab.Controls.Add( AreaTable );
            PivotTab.Image = null;
            PivotTab.ImageSize = new System.Drawing.Size( 16, 16 );
            PivotTab.Location = new System.Drawing.Point( 0, 29 );
            PivotTab.Name = "PivotTab";
            PivotTab.ShowCloseButton = true;
            PivotTab.Size = new System.Drawing.Size( 1036, 587 );
            PivotTab.TabIndex = 1;
            PivotTab.ThemesEnabled = false;
            // 
            // AreaTable
            // 
            AreaTable.ColumnCount = 1;
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            AreaTable.Controls.Add( PivotPanel, 0, 0 );
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
            // PivotPanel
            // 
            PivotPanel.BackColor = System.Drawing.Color.Transparent;
            PivotPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            PivotPanel.BindingSource = null;
            PivotPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            PivotPanel.BorderThickness = 1;
            PivotPanel.Children = null;
            PivotPanel.Controls.Add( Chart );
            PivotPanel.DataFilter = null;
            PivotPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            PivotPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            PivotPanel.ForeColor = System.Drawing.Color.Transparent;
            PivotPanel.HoverText = null;
            PivotPanel.IsDerivedStyle = true;
            PivotPanel.Location = new System.Drawing.Point( 3, 3 );
            PivotPanel.Name = "PivotPanel";
            PivotPanel.Padding = new System.Windows.Forms.Padding( 1 );
            PivotPanel.Size = new System.Drawing.Size( 986, 455 );
            PivotPanel.Style = MetroSet_UI.Enums.Style.Custom;
            PivotPanel.StyleManager = null;
            PivotPanel.TabIndex = 7;
            PivotPanel.ThemeAuthor = "Terry D. Eppler";
            PivotPanel.ThemeName = "Budget Execution";
            PivotPanel.ToolTip = null;
            // 
            // Chart
            // 
            Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            Chart.EditManager = null;
            Chart.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016Black;
            Chart.Location = new System.Drawing.Point( 1, 1 );
            Chart.Name = "Chart";
            Chart.Size = new System.Drawing.Size( 984, 453 );
            Chart.TabIndex = 0;
            Chart.Text = "pivotGridControl1";
            Chart.ThemeName = "Office2016Black";
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
            ChartSubTablePanel.Font = new System.Drawing.Font( "Roboto", 8F );
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
            ChartSubTable.Controls.Add( CommandLabel, 0, 1 );
            ChartSubTable.Location = new System.Drawing.Point( 517, 4 );
            ChartSubTable.Name = "ChartSubTable";
            ChartSubTable.RowCount = 2;
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 72F ) );
            ChartSubTable.Size = new System.Drawing.Size( 465, 97 );
            ChartSubTable.TabIndex = 5;
            // 
            // CommandLabel
            // 
            CommandLabel.BindingSource = null;
            CommandLabel.DataFilter = null;
            CommandLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            CommandLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CommandLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            CommandLabel.HoverText = null;
            CommandLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            CommandLabel.IsDerivedStyle = true;
            CommandLabel.Location = new System.Drawing.Point( 3, 28 );
            CommandLabel.Margin = new System.Windows.Forms.Padding( 3 );
            CommandLabel.Name = "CommandLabel";
            CommandLabel.Padding = new System.Windows.Forms.Padding( 1 );
            CommandLabel.Size = new System.Drawing.Size( 459, 66 );
            CommandLabel.Style = MetroSet_UI.Enums.Style.Custom;
            CommandLabel.StyleManager = null;
            CommandLabel.TabIndex = 3;
            CommandLabel.Text = "label1";
            CommandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            CommandLabel.ThemeAuthor = "Terry D. Eppler";
            CommandLabel.ThemeName = "Budget Execution";
            CommandLabel.ToolTip = null;
            // 
            // MetricsTable
            // 
            MetricsTable.ColumnCount = 4;
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.88889F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 32.22222F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.88889F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 139F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            MetricsTable.Controls.Add( MetricsLabel3, 2, 0 );
            MetricsTable.Controls.Add( MetricsLabel1, 0, 0 );
            MetricsTable.Controls.Add( MetricsLabel2, 1, 0 );
            MetricsTable.Controls.Add( MetricsLabel5, 0, 1 );
            MetricsTable.Controls.Add( MetricsLabel6, 1, 1 );
            MetricsTable.Controls.Add( MetricsLabel7, 2, 1 );
            MetricsTable.Controls.Add( MetricsLabel4, 3, 0 );
            MetricsTable.Controls.Add( MetricsLabel8, 3, 1 );
            MetricsTable.Controls.Add( MetricsLabel9, 0, 2 );
            MetricsTable.Controls.Add( MetricsLabel10, 1, 2 );
            MetricsTable.Controls.Add( MetricsLabel11, 2, 2 );
            MetricsTable.Controls.Add( MetricsLabel12, 3, 2 );
            MetricsTable.Location = new System.Drawing.Point( 1, 4 );
            MetricsTable.Name = "MetricsTable";
            MetricsTable.RowCount = 3;
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 51.47059F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 48.52941F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 28F ) );
            MetricsTable.Size = new System.Drawing.Size( 500, 97 );
            MetricsTable.TabIndex = 4;
            // 
            // MetricsLabel3
            // 
            MetricsLabel3.BindingSource = null;
            MetricsLabel3.DataFilter = null;
            MetricsLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel3.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel3.HoverText = null;
            MetricsLabel3.IsDerivedStyle = true;
            MetricsLabel3.Location = new System.Drawing.Point( 241, 3 );
            MetricsLabel3.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel3.Name = "MetricsLabel3";
            MetricsLabel3.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel3.Size = new System.Drawing.Size( 116, 29 );
            MetricsLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel3.StyleManager = null;
            MetricsLabel3.TabIndex = 43;
            MetricsLabel3.Text = "Source";
            MetricsLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel3.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel3.ThemeName = "BudgetExecution";
            MetricsLabel3.ToolTip = null;
            // 
            // MetricsLabel1
            // 
            MetricsLabel1.BindingSource = null;
            MetricsLabel1.DataFilter = null;
            MetricsLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel1.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel1.HoverText = null;
            MetricsLabel1.IsDerivedStyle = true;
            MetricsLabel1.Location = new System.Drawing.Point( 3, 3 );
            MetricsLabel1.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel1.Name = "MetricsLabel1";
            MetricsLabel1.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel1.Size = new System.Drawing.Size( 116, 29 );
            MetricsLabel1.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel1.StyleManager = null;
            MetricsLabel1.TabIndex = 33;
            MetricsLabel1.Text = "Source";
            MetricsLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel1.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel1.ThemeName = "BudgetExecution";
            MetricsLabel1.ToolTip = null;
            // 
            // MetricsLabel2
            // 
            MetricsLabel2.BindingSource = null;
            MetricsLabel2.DataFilter = null;
            MetricsLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel2.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel2.HoverText = null;
            MetricsLabel2.IsDerivedStyle = true;
            MetricsLabel2.Location = new System.Drawing.Point( 125, 3 );
            MetricsLabel2.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel2.Name = "MetricsLabel2";
            MetricsLabel2.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel2.Size = new System.Drawing.Size( 110, 29 );
            MetricsLabel2.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel2.StyleManager = null;
            MetricsLabel2.TabIndex = 44;
            MetricsLabel2.Text = "Source";
            MetricsLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel2.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel2.ThemeName = "BudgetExecution";
            MetricsLabel2.ToolTip = null;
            // 
            // MetricsLabel5
            // 
            MetricsLabel5.BindingSource = null;
            MetricsLabel5.DataFilter = null;
            MetricsLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel5.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel5.HoverText = null;
            MetricsLabel5.IsDerivedStyle = true;
            MetricsLabel5.Location = new System.Drawing.Point( 3, 38 );
            MetricsLabel5.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel5.Name = "MetricsLabel5";
            MetricsLabel5.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel5.Size = new System.Drawing.Size( 116, 27 );
            MetricsLabel5.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel5.StyleManager = null;
            MetricsLabel5.TabIndex = 44;
            MetricsLabel5.Text = "Source";
            MetricsLabel5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel5.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel5.ThemeName = "BudgetExecution";
            MetricsLabel5.ToolTip = null;
            // 
            // MetricsLabel6
            // 
            MetricsLabel6.BindingSource = null;
            MetricsLabel6.DataFilter = null;
            MetricsLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel6.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel6.HoverText = null;
            MetricsLabel6.IsDerivedStyle = true;
            MetricsLabel6.Location = new System.Drawing.Point( 125, 38 );
            MetricsLabel6.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel6.Name = "MetricsLabel6";
            MetricsLabel6.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel6.Size = new System.Drawing.Size( 110, 27 );
            MetricsLabel6.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel6.StyleManager = null;
            MetricsLabel6.TabIndex = 45;
            MetricsLabel6.Text = "label2";
            MetricsLabel6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel6.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel6.ThemeName = "Budget Execution";
            MetricsLabel6.ToolTip = null;
            // 
            // MetricsLabel7
            // 
            MetricsLabel7.BindingSource = null;
            MetricsLabel7.DataFilter = null;
            MetricsLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel7.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel7.HoverText = null;
            MetricsLabel7.IsDerivedStyle = true;
            MetricsLabel7.Location = new System.Drawing.Point( 241, 38 );
            MetricsLabel7.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel7.Name = "MetricsLabel7";
            MetricsLabel7.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel7.Size = new System.Drawing.Size( 116, 27 );
            MetricsLabel7.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel7.StyleManager = null;
            MetricsLabel7.TabIndex = 46;
            MetricsLabel7.Text = "label3";
            MetricsLabel7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel7.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel7.ThemeName = "Budget Execution";
            MetricsLabel7.ToolTip = null;
            // 
            // MetricsLabel4
            // 
            MetricsLabel4.BindingSource = null;
            MetricsLabel4.DataFilter = null;
            MetricsLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel4.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            MetricsLabel4.HoverText = null;
            MetricsLabel4.IsDerivedStyle = true;
            MetricsLabel4.Location = new System.Drawing.Point( 363, 3 );
            MetricsLabel4.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel4.Name = "MetricsLabel4";
            MetricsLabel4.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel4.Size = new System.Drawing.Size( 134, 29 );
            MetricsLabel4.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel4.StyleManager = null;
            MetricsLabel4.TabIndex = 47;
            MetricsLabel4.Text = "Source";
            MetricsLabel4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel4.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel4.ThemeName = "Budget Execution";
            MetricsLabel4.ToolTip = null;
            // 
            // MetricsLabel8
            // 
            MetricsLabel8.BindingSource = null;
            MetricsLabel8.DataFilter = null;
            MetricsLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel8.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel8.HoverText = null;
            MetricsLabel8.IsDerivedStyle = true;
            MetricsLabel8.Location = new System.Drawing.Point( 363, 38 );
            MetricsLabel8.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel8.Name = "MetricsLabel8";
            MetricsLabel8.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel8.Size = new System.Drawing.Size( 134, 27 );
            MetricsLabel8.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel8.StyleManager = null;
            MetricsLabel8.TabIndex = 48;
            MetricsLabel8.Text = "Source";
            MetricsLabel8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel8.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel8.ThemeName = "Budget Execution";
            MetricsLabel8.ToolTip = null;
            // 
            // MetricsLabel9
            // 
            MetricsLabel9.BindingSource = null;
            MetricsLabel9.DataFilter = null;
            MetricsLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel9.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel9.HoverText = null;
            MetricsLabel9.IsDerivedStyle = true;
            MetricsLabel9.Location = new System.Drawing.Point( 3, 71 );
            MetricsLabel9.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel9.Name = "MetricsLabel9";
            MetricsLabel9.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel9.Size = new System.Drawing.Size( 116, 23 );
            MetricsLabel9.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel9.StyleManager = null;
            MetricsLabel9.TabIndex = 49;
            MetricsLabel9.Text = "Source";
            MetricsLabel9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel9.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel9.ThemeName = "Budget Execution";
            MetricsLabel9.ToolTip = null;
            // 
            // MetricsLabel10
            // 
            MetricsLabel10.BindingSource = null;
            MetricsLabel10.DataFilter = null;
            MetricsLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel10.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel10.HoverText = null;
            MetricsLabel10.IsDerivedStyle = true;
            MetricsLabel10.Location = new System.Drawing.Point( 125, 71 );
            MetricsLabel10.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel10.Name = "MetricsLabel10";
            MetricsLabel10.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel10.Size = new System.Drawing.Size( 110, 23 );
            MetricsLabel10.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel10.StyleManager = null;
            MetricsLabel10.TabIndex = 50;
            MetricsLabel10.Text = "Source";
            MetricsLabel10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel10.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel10.ThemeName = "Budget Execution";
            MetricsLabel10.ToolTip = null;
            // 
            // MetricsLabel11
            // 
            MetricsLabel11.BindingSource = null;
            MetricsLabel11.DataFilter = null;
            MetricsLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel11.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel11.HoverText = null;
            MetricsLabel11.IsDerivedStyle = true;
            MetricsLabel11.Location = new System.Drawing.Point( 241, 71 );
            MetricsLabel11.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel11.Name = "MetricsLabel11";
            MetricsLabel11.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel11.Size = new System.Drawing.Size( 116, 23 );
            MetricsLabel11.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel11.StyleManager = null;
            MetricsLabel11.TabIndex = 51;
            MetricsLabel11.Text = "Source";
            MetricsLabel11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel11.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel11.ThemeName = "Budget Execution";
            MetricsLabel11.ToolTip = null;
            // 
            // MetricsLabel12
            // 
            MetricsLabel12.BindingSource = null;
            MetricsLabel12.DataFilter = null;
            MetricsLabel12.Dock = System.Windows.Forms.DockStyle.Fill;
            MetricsLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MetricsLabel12.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MetricsLabel12.HoverText = null;
            MetricsLabel12.IsDerivedStyle = true;
            MetricsLabel12.Location = new System.Drawing.Point( 363, 71 );
            MetricsLabel12.Margin = new System.Windows.Forms.Padding( 3 );
            MetricsLabel12.Name = "MetricsLabel12";
            MetricsLabel12.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel12.Size = new System.Drawing.Size( 134, 23 );
            MetricsLabel12.Style = MetroSet_UI.Enums.Style.Custom;
            MetricsLabel12.StyleManager = null;
            MetricsLabel12.TabIndex = 52;
            MetricsLabel12.Text = "Source";
            MetricsLabel12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            MetricsLabel12.ThemeAuthor = "Terry D. Eppler";
            MetricsLabel12.ThemeName = "Budget Execution";
            MetricsLabel12.ToolTip = null;
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
            SourcePanel.Font = new System.Drawing.Font( "Roboto", 9F );
            SourcePanel.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SourcePanel.Location = new System.Drawing.Point( 1065, 30 );
            SourcePanel.Name = "SourcePanel";
            SourcePanel.RowCount = 2;
            SourcePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            SourcePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            SourcePanel.Size = new System.Drawing.Size( 242, 643 );
            SourcePanel.TabIndex = 52;
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
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
            // 
            // PivotGridForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            ControlBox = false;
            Controls.Add( SourcePanel );
            Controls.Add( ChartHeaderTable );
            Controls.Add( ToolStripTable );
            Controls.Add( HeaderTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "PivotGridForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " ";
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ChartHeaderTable.ResumeLayout( false );
            PivotLayout.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            PivotTab.ResumeLayout( false );
            AreaTable.ResumeLayout( false );
            PivotPanel.ResumeLayout( false );
            ChartSubTablePanel.ResumeLayout( false );
            ChartSubTable.ResumeLayout( false );
            MetricsTable.ResumeLayout( false );
            BusyTab.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)Loader ).EndInit( );
            SourcePanel.ResumeLayout( false );
            TableListBoxLayout.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public ToolStrip ToolStrip;
        private ToolSeparator toolSeparator1;
        public ToolStripLabel StatusLabel;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel3;
        private ToolSeparator toolSeparator2;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        private ToolSeparator toolSeparator3;
        private ToolSeparator toolSeparator4;
        private ToolSeparator toolSeparator5;
        private ToolSeparator toolSeparator6;
        private ToolStripLabel toolStripLabel5;
        private ToolStripLabel toolStripLabel4;
        private ToolSeparator toolSeparator7;
        private ToolSeparator toolSeparator15;
        private ToolSeparator toolSeparator9;
        private ToolSeparator toolSeparator10;
        private ToolStripLabel toolStripLabel6;
        private ToolSeparator toolSeparator12;
        private ToolSeparator toolSeparator13;
        private ToolSeparator toolSeparator14;
        private ToolStripLabel toolStripLabel7;
        private ToolSeparator toolSeparator8;
        public HeaderPanel ChartHeaderTable;
        private BackPanel PivotLayout;
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv PivotTab;
        public System.Windows.Forms.TableLayoutPanel AreaTable;
        public BackPanel PivotPanel;
        public BackPanel ChartSubTablePanel;
        private System.Windows.Forms.TableLayoutPanel ChartSubTable;
        public System.Windows.Forms.TableLayoutPanel MetricsTable;
        public Label MetricsLabel3;
        public Label MetricsLabel1;
        public Label MetricsLabel2;
        public Label MetricsLabel5;
        public Label MetricsLabel6;
        public Label MetricsLabel7;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTab;
        public System.Windows.Forms.PictureBox Loader;
        public HeaderPanel SourcePanel;
        public BackPanel TableListBoxLayout;
        public ListBox TableListBox;
        private Label Title;
        public Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl Chart;
        public Label MetricsLabel4;
        public Label MetricsLabel8;
        public Label MetricsLabel9;
        public Label MetricsLabel10;
        public Label MetricsLabel11;
        public Label MetricsLabel12;
        private Label CommandLabel;
        public System.Windows.Forms.Timer Timer;
        public ToolStripButton MenuButton;
        public ToolStripButton CloseButton;
        public ToolStripButton ExportButton;
        public ToolStripButton SaveButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton LastButton;
        public ToolStripButton NextButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton FirstButton;
    }
}