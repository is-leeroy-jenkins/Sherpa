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
            ContextMenu = new ContextMenu( );
            ToolStrip = new ToolStrip( );
            ChartTable = new HeaderPanel( );
            AreaTable = new System.Windows.Forms.TableLayoutPanel( );
            ChartAreaPanel = new Layout( );
            PivotChart = new PivotChart( );
            ChartSubTablePanel = new Layout( );
            ChartSubTable = new System.Windows.Forms.TableLayoutPanel( );
            SqlHeader = new Label( );
            MetricsTable = new System.Windows.Forms.TableLayoutPanel( );
            ThirdDataLabel = new Label( );
            FirstDataLabel = new Label( );
            SecondDataLabel = new Label( );
            FourthDataLabel = new Label( );
            FifthDataLabel = new Label( );
            SixthDataLabel = new Label( );
            SourcePanel = new HeaderPanel( );
            TableListBoxLayout = new Layout( );
            TableListBox = new ListBox( );
            Separator1 = new ToolSeparator( );
            ProgressBar = new System.Windows.Forms.ToolStripProgressBar( );
            Separator2 = new ToolSeparator( );
            toolStripButton1 = new ToolStripButton( );
            toolStripButton2 = new ToolStripButton( );
            toolStripButton3 = new ToolStripButton( );
            toolStripButton4 = new ToolStripButton( );
            Separator3 = new ToolSeparator( );
            Separator4 = new ToolSeparator( );
            Separator5 = new ToolSeparator( );
            Separator6 = new ToolSeparator( );
            toolStripLabel1 = new ToolStripLabel( );
            Separator7 = new ToolSeparator( );
            toolStripButton5 = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            toolStripButton6 = new ToolStripButton( );
            Separator9 = new ToolSeparator( );
            Separator10 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            toolStripLabel2 = new ToolStripLabel( );
            Separator12 = new ToolSeparator( );
            toolStripButton9 = new ToolStripButton( );
            Separator13 = new ToolSeparator( );
            toolStripButton10 = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ToolStrip.SuspendLayout( );
            ChartTable.SuspendLayout( );
            AreaTable.SuspendLayout( );
            ChartAreaPanel.SuspendLayout( );
            ChartSubTablePanel.SuspendLayout( );
            ChartSubTable.SuspendLayout( );
            MetricsTable.SuspendLayout( );
            SourcePanel.SuspendLayout( );
            TableListBoxLayout.SuspendLayout( );
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
            PictureBox.Size = new System.Drawing.Size( 22, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 37, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 165, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "label1";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 140, 220 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Budget Execution";
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, ProgressBar, Separator2, toolStripButton1, Separator3, toolStripButton2, Separator5, toolStripButton3, Separator4, toolStripButton4, Separator6, toolStripLabel1, Separator7, toolStripButton5, Separator8, toolStripButton6, Separator9, Separator10, CloseButton, Separator11, MenuButton, toolStripLabel2, Separator12, toolStripButton9, Separator13, toolStripButton10, Separator14 } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 689 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
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
            ToolStrip.Size = new System.Drawing.Size( 1338, 50 );
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
            // ChartTable
            // 
            ChartTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ChartTable.CaptionText = "Data Visualization";
            ChartTable.ColumnCount = 1;
            ChartTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartTable.Controls.Add( AreaTable, 0, 1 );
            ChartTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartTable.ForeColor = System.Drawing.Color.DarkGray;
            ChartTable.Location = new System.Drawing.Point( 12, 35 );
            ChartTable.Name = "ChartTable";
            ChartTable.RowCount = 2;
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            ChartTable.Size = new System.Drawing.Size( 1069, 651 );
            ChartTable.TabIndex = 50;
            // 
            // AreaTable
            // 
            AreaTable.ColumnCount = 1;
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            AreaTable.Controls.Add( ChartAreaPanel, 0, 0 );
            AreaTable.Controls.Add( ChartSubTablePanel, 0, 1 );
            AreaTable.Dock = System.Windows.Forms.DockStyle.Fill;
            AreaTable.Location = new System.Drawing.Point( 3, 27 );
            AreaTable.Name = "AreaTable";
            AreaTable.RowCount = 2;
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 84.46602F ) );
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 15.53398F ) );
            AreaTable.Size = new System.Drawing.Size( 1063, 621 );
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
            ChartAreaPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartAreaPanel.ForeColor = System.Drawing.Color.Transparent;
            ChartAreaPanel.HoverText = null;
            ChartAreaPanel.IsDerivedStyle = true;
            ChartAreaPanel.Location = new System.Drawing.Point( 3, 3 );
            ChartAreaPanel.Name = "ChartAreaPanel";
            ChartAreaPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartAreaPanel.Size = new System.Drawing.Size( 1057, 518 );
            ChartAreaPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ChartAreaPanel.StyleManager = null;
            ChartAreaPanel.TabIndex = 7;
            ChartAreaPanel.ThemeAuthor = "Terry D. Eppler";
            ChartAreaPanel.ThemeName = "Budget Execution";
            ChartAreaPanel.ToolTip = null;
            // 
            // PivotChart
            // 
            PivotChart.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            PivotChart.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
            PivotChart.CustomPalette = new System.Drawing.Color[ ]
    {
    System.Drawing.Color.FromArgb(147, 208, 249),
    System.Drawing.Color.FromArgb(102, 170, 225),
    System.Drawing.Color.FromArgb(250, 163, 94),
    System.Drawing.Color.FromArgb(252, 227, 127)
    };
            PivotChart.DeferLayoutUpdate = false;
            PivotChart.Dock = System.Windows.Forms.DockStyle.Fill;
            PivotChart.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            PivotChart.Location = new System.Drawing.Point( 1, 1 );
            PivotChart.MinimumSize = new System.Drawing.Size( 300, 250 );
            PivotChart.Name = "PivotChart";
            PivotChart.ShowPivotTableFieldList = false;
            PivotChart.Size = new System.Drawing.Size( 1055, 516 );
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
            ChartSubTablePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartSubTablePanel.ForeColor = System.Drawing.Color.Transparent;
            ChartSubTablePanel.HoverText = null;
            ChartSubTablePanel.IsDerivedStyle = true;
            ChartSubTablePanel.Location = new System.Drawing.Point( 3, 527 );
            ChartSubTablePanel.Name = "ChartSubTablePanel";
            ChartSubTablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSubTablePanel.Size = new System.Drawing.Size( 1057, 91 );
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
            ChartSubTable.Location = new System.Drawing.Point( 531, 20 );
            ChartSubTable.Name = "ChartSubTable";
            ChartSubTable.RowCount = 2;
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 13F ) );
            ChartSubTable.Size = new System.Drawing.Size( 512, 42 );
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
            SqlHeader.Size = new System.Drawing.Size( 506, 23 );
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
            MetricsTable.Location = new System.Drawing.Point( 15, 20 );
            MetricsTable.Name = "MetricsTable";
            MetricsTable.RowCount = 2;
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            MetricsTable.Size = new System.Drawing.Size( 510, 42 );
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
            ThirdDataLabel.Location = new System.Drawing.Point( 247, 3 );
            ThirdDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            ThirdDataLabel.Name = "ThirdDataLabel";
            ThirdDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ThirdDataLabel.Size = new System.Drawing.Size( 119, 15 );
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
            FirstDataLabel.Size = new System.Drawing.Size( 119, 15 );
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
            SecondDataLabel.Location = new System.Drawing.Point( 128, 3 );
            SecondDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SecondDataLabel.Name = "SecondDataLabel";
            SecondDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SecondDataLabel.Size = new System.Drawing.Size( 113, 15 );
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
            FourthDataLabel.Location = new System.Drawing.Point( 3, 24 );
            FourthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FourthDataLabel.Name = "FourthDataLabel";
            FourthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FourthDataLabel.Size = new System.Drawing.Size( 119, 15 );
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
            FifthDataLabel.Location = new System.Drawing.Point( 128, 24 );
            FifthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FifthDataLabel.Name = "FifthDataLabel";
            FifthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FifthDataLabel.Size = new System.Drawing.Size( 113, 15 );
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
            SixthDataLabel.Location = new System.Drawing.Point( 247, 24 );
            SixthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SixthDataLabel.Name = "SixthDataLabel";
            SixthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SixthDataLabel.Size = new System.Drawing.Size( 119, 15 );
            SixthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SixthDataLabel.StyleManager = null;
            SixthDataLabel.TabIndex = 46;
            SixthDataLabel.Text = "label3";
            SixthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SixthDataLabel.ThemeAuthor = "Terry D. Eppler";
            SixthDataLabel.ThemeName = "Budget Execution";
            SixthDataLabel.ToolTip = null;
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
            SourcePanel.Size = new System.Drawing.Size( 242, 647 );
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
            TableListBoxLayout.Size = new System.Drawing.Size( 236, 618 );
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
            TableListBox.Location = new System.Drawing.Point( 23, 19 );
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
            TableListBox.Size = new System.Drawing.Size( 188, 579 );
            TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBox.StyleManager = null;
            TableListBox.TabIndex = 0;
            TableListBox.ThemeAuthor = "Terry D. Eppler";
            TableListBox.ThemeName = "Budget Execution";
            TableListBox.ToolTip = null;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 30 );
            // 
            // ProgressBar
            // 
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new System.Drawing.Size( 200, 29 );
            ProgressBar.Value = 50;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 30 );
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoToolTip = false;
            toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            toolStripButton1.BindingSource = null;
            toolStripButton1.DataFilter = null;
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Field = Field.AccountCode;
            toolStripButton1.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton1.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton1.HoverText = null;
            toolStripButton1.Image = Resources.Images.FirstButton;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton1.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTip = null;
            toolStripButton1.ToolType = ToolType.Ns;
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoToolTip = false;
            toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            toolStripButton2.BindingSource = null;
            toolStripButton2.DataFilter = null;
            toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton2.Field = Field.AccountCode;
            toolStripButton2.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton2.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton2.HoverText = null;
            toolStripButton2.Image = Resources.Images.PreviousButton;
            toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton2.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton2.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTip = null;
            toolStripButton2.ToolType = ToolType.Ns;
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoToolTip = false;
            toolStripButton3.BackColor = System.Drawing.Color.Transparent;
            toolStripButton3.BindingSource = null;
            toolStripButton3.DataFilter = null;
            toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton3.Field = Field.AccountCode;
            toolStripButton3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton3.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton3.HoverText = null;
            toolStripButton3.Image = Resources.Images.NextButton;
            toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton3.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton3.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTip = null;
            toolStripButton3.ToolType = ToolType.Ns;
            // 
            // toolStripButton4
            // 
            toolStripButton4.AutoToolTip = false;
            toolStripButton4.BackColor = System.Drawing.Color.Transparent;
            toolStripButton4.BindingSource = null;
            toolStripButton4.DataFilter = null;
            toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton4.Field = Field.AccountCode;
            toolStripButton4.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton4.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton4.HoverText = null;
            toolStripButton4.Image = Resources.Images.LastButton;
            toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton4.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton4.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.ToolTip = null;
            toolStripButton4.ToolType = ToolType.Ns;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 30 );
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 30 );
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 30 );
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 30 );
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            toolStripLabel1.BindingSource = null;
            toolStripLabel1.DataFilter = null;
            toolStripLabel1.Field = Field.AccountCode;
            toolStripLabel1.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            toolStripLabel1.HoverText = null;
            toolStripLabel1.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel1.Size = new System.Drawing.Size( 109, 30 );
            toolStripLabel1.Tag = "";
            toolStripLabel1.Text = "        toolStripLabel1";
            toolStripLabel1.ToolTip = null;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 30 );
            // 
            // toolStripButton5
            // 
            toolStripButton5.AutoToolTip = false;
            toolStripButton5.BackColor = System.Drawing.Color.Transparent;
            toolStripButton5.BindingSource = null;
            toolStripButton5.DataFilter = null;
            toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton5.Field = Field.AccountCode;
            toolStripButton5.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton5.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton5.HoverText = null;
            toolStripButton5.Image = (System.Drawing.Image)resources.GetObject( "toolStripButton5.Image" );
            toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton5.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton5.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.ToolTip = null;
            toolStripButton5.ToolType = ToolType.Ns;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 30 );
            // 
            // toolStripButton6
            // 
            toolStripButton6.AutoToolTip = false;
            toolStripButton6.BackColor = System.Drawing.Color.Transparent;
            toolStripButton6.BindingSource = null;
            toolStripButton6.DataFilter = null;
            toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton6.Field = Field.AccountCode;
            toolStripButton6.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton6.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton6.HoverText = null;
            toolStripButton6.Image = (System.Drawing.Image)resources.GetObject( "toolStripButton6.Image" );
            toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton6.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton6.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton6.Text = "toolStripButton6";
            toolStripButton6.ToolTip = null;
            toolStripButton6.ToolType = ToolType.Ns;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 30 );
            // 
            // Separator10
            // 
            Separator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 30 );
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
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 26 );
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
            Separator11.Size = new System.Drawing.Size( 6, 30 );
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
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 26 );
            MenuButton.Text = "toolStripButton8";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            toolStripLabel2.BindingSource = null;
            toolStripLabel2.DataFilter = null;
            toolStripLabel2.Field = Field.AccountCode;
            toolStripLabel2.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripLabel2.ForeColor = System.Drawing.Color.Black;
            toolStripLabel2.HoverText = null;
            toolStripLabel2.Margin = new System.Windows.Forms.Padding( 1 );
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripLabel2.Size = new System.Drawing.Size( 109, 30 );
            toolStripLabel2.Tag = "";
            toolStripLabel2.Text = "        toolStripLabel2";
            toolStripLabel2.ToolTip = null;
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 30 );
            // 
            // toolStripButton9
            // 
            toolStripButton9.AutoToolTip = false;
            toolStripButton9.BackColor = System.Drawing.Color.Transparent;
            toolStripButton9.BindingSource = null;
            toolStripButton9.DataFilter = null;
            toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton9.Field = Field.AccountCode;
            toolStripButton9.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton9.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton9.HoverText = null;
            toolStripButton9.Image = (System.Drawing.Image)resources.GetObject( "toolStripButton9.Image" );
            toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton9.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton9.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton9.Text = "toolStripButton9";
            toolStripButton9.ToolTip = null;
            toolStripButton9.ToolType = ToolType.Ns;
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 30 );
            // 
            // toolStripButton10
            // 
            toolStripButton10.AutoToolTip = false;
            toolStripButton10.BackColor = System.Drawing.Color.Transparent;
            toolStripButton10.BindingSource = null;
            toolStripButton10.DataFilter = null;
            toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton10.Field = Field.AccountCode;
            toolStripButton10.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            toolStripButton10.ForeColor = System.Drawing.Color.LightGray;
            toolStripButton10.HoverText = null;
            toolStripButton10.Image = (System.Drawing.Image)resources.GetObject( "toolStripButton10.Image" );
            toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton10.Margin = new System.Windows.Forms.Padding( 5, 3, 5, 3 );
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Padding = new System.Windows.Forms.Padding( 1 );
            toolStripButton10.Size = new System.Drawing.Size( 23, 26 );
            toolStripButton10.Text = "toolStripButton10";
            toolStripButton10.ToolTip = null;
            toolStripButton10.ToolType = ToolType.Ns;
            // 
            // Separator14
            // 
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding( 1 );
            Separator14.Size = new System.Drawing.Size( 6, 30 );
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
            Controls.Add( SourcePanel );
            Controls.Add( ChartTable );
            Controls.Add( ToolStrip );
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
            ChartTable.ResumeLayout( false );
            AreaTable.ResumeLayout( false );
            ChartAreaPanel.ResumeLayout( false );
            ChartSubTablePanel.ResumeLayout( false );
            ChartSubTable.ResumeLayout( false );
            MetricsTable.ResumeLayout( false );
            SourcePanel.ResumeLayout( false );
            TableListBoxLayout.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        public System.Windows.Forms.PictureBox PictureBox;
        public Label Title;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
        public SmallTip ToolTip;
        public ContextMenu ContextMenu;
        public ToolStrip ToolStrip;
        public HeaderPanel ChartTable;
        public System.Windows.Forms.TableLayoutPanel AreaTable;
        public Layout ChartAreaPanel;
        private PivotChart PivotChart;
        public Layout ChartSubTablePanel;
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
        public Layout TableListBoxLayout;
        public ListBox TableListBox;
        public ToolSeparator Separator1;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
        public ToolSeparator Separator2;
        private ToolStripButton toolStripButton1;
        public ToolSeparator Separator3;
        private ToolStripButton toolStripButton2;
        public ToolSeparator Separator5;
        private ToolStripButton toolStripButton3;
        public ToolSeparator Separator4;
        private ToolStripButton toolStripButton4;
        public ToolSeparator Separator6;
        private ToolStripLabel toolStripLabel1;
        public ToolSeparator Separator7;
        private ToolStripButton toolStripButton5;
        public ToolSeparator Separator8;
        private ToolStripButton toolStripButton6;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolStripButton CloseButton;
        public ToolSeparator Separator11;
        public ToolStripButton MenuButton;
        private ToolStripLabel toolStripLabel2;
        public ToolSeparator Separator12;
        private ToolStripButton toolStripButton9;
        public ToolSeparator Separator13;
        private ToolStripButton toolStripButton10;
        public ToolSeparator Separator14;
    }
}