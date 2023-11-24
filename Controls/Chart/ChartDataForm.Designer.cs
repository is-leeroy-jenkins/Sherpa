﻿namespace BudgetExecution
{


    partial class ChartDataForm
    {

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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ChartDataForm ) );
            GridTable = new System.Windows.Forms.TableLayoutPanel( );
            LabelTable = new System.Windows.Forms.TableLayoutPanel( );
            AreaTable = new System.Windows.Forms.TableLayoutPanel( );
            ChartPanel = new Layout( );
            Chart = new Chart( );
            ChartSubTablePanel = new Layout( );
            ChartSubTable = new System.Windows.Forms.TableLayoutPanel( );
            SqlTextLabel = new Label( );
            MetricsTable = new System.Windows.Forms.TableLayoutPanel( );
            SixthDataLabel = new Label( );
            ThirdDataLabel = new Label( );
            FirstDataLabel = new Label( );
            SecondDataLabel = new Label( );
            FourthDataLabel = new Label( );
            FifthDataLabel = new Label( );
            SeventhDataLabel = new Label( );
            EighthDataLabel = new Label( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            ToolStrip = new ToolStrip( );
            FirstButton = new ToolStripButton( );
            StripSeparator = new ToolSeparator( );
            ProgressBar = new System.Windows.Forms.ToolStripProgressBar( );
            TextBoxSeparator = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            NavigationLabelSeparator = new ToolSeparator( );
            FirstSeparator = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            PreviousSeparator = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            NextSeparator = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            EditSqlSeparator = new ToolSeparator( );
            FilterLabel = new ToolStripLabel( );
            FilterLabelSeparator = new ToolSeparator( );
            RefreshDataButton = new ToolStripButton( );
            NavigationSeparator = new ToolSeparator( );
            RemoveFiltersButton = new ToolStripButton( );
            FilterSeparator = new ToolSeparator( );
            GroupButton = new ToolStripButton( );
            RemoveFiltersSeparator = new ToolSeparator( );
            ChartSpacerLabel = new ToolStripLabel( );
            ChartSpacer = new ToolSeparator( );
            ChartSeriesComboBox = new ToolStripDropDown( );
            ChartSeriesSeparator = new ToolSeparator( );
            MetricsLabel = new ToolStripLabel( );
            MetricsPreSeparator = new ToolSeparator( );
            MetricsComboBox = new ToolStripDropDown( );
            MetricsPostSeparator = new ToolSeparator( );
            ApplicationLabel = new ToolStripLabel( );
            MenuButton = new ToolStripButton( );
            MenuSeparator = new ToolSeparator( );
            ExitButton = new ToolStripButton( );
            ExitSeparator = new ToolSeparator( );
            LastSeparator = new ToolSeparator( );
            FunctionLabel = new ToolStripLabel( );
            LabelSeparator = new ToolSeparator( );
            ChartSeriesLabel = new ToolStripLabel( );
            DropDownSeparator = new ToolSeparator( );
            ExcelSeparator = new ToolSeparator( );
            RefreshDataSeparator = new ToolSeparator( );
            GroupSeparator = new ToolSeparator( );
            ContextMenu = new ContextMenu( );
            TabControl = new TabControl( );
            TableTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            FilterTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            ThirdTable = new HeaderPanel( );
            ThirdComboBox = new ComboBox( );
            ThirdListBoxPanel = new Layout( );
            ThirdListBox = new ListBox( );
            FirstTable = new HeaderPanel( );
            FirstComboBox = new ComboBox( );
            FirstListBoxPanel = new Layout( );
            FirstListBox = new ListBox( );
            SecondTable = new HeaderPanel( );
            SecondListBoxPanel = new Layout( );
            SecondListBox = new ListBox( );
            SecondComboBox = new ComboBox( );
            GroupTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            NumericTable = new HeaderPanel( );
            NumericPanel = new Layout( );
            NumericListBox = new ListBox( );
            FieldTable = new HeaderPanel( );
            FieldPanel = new Layout( );
            FieldListBox = new ListBox( );
            SourcePanel = new HeaderPanel( );
            TableListBoxPanel = new Layout( );
            TableListBox = new ListBox( );
            ChartTable = new HeaderPanel( );
            ChartHeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Timer = new System.Windows.Forms.Timer( components );
            AreaTable.SuspendLayout( );
            ChartPanel.SuspendLayout( );
            ChartSubTablePanel.SuspendLayout( );
            ChartSubTable.SuspendLayout( );
            MetricsTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            FilterTabPage.SuspendLayout( );
            ThirdTable.SuspendLayout( );
            ThirdListBoxPanel.SuspendLayout( );
            FirstTable.SuspendLayout( );
            FirstListBoxPanel.SuspendLayout( );
            SecondTable.SuspendLayout( );
            SecondListBoxPanel.SuspendLayout( );
            GroupTabPage.SuspendLayout( );
            NumericTable.SuspendLayout( );
            NumericPanel.SuspendLayout( );
            FieldTable.SuspendLayout( );
            FieldPanel.SuspendLayout( );
            SourcePanel.SuspendLayout( );
            TableListBoxPanel.SuspendLayout( );
            ChartTable.SuspendLayout( );
            ChartHeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            SuspendLayout( );
            // 
            // GridTable
            // 
            GridTable.Location = new System.Drawing.Point( 0, 0 );
            GridTable.Name = "GridTable";
            GridTable.Size = new System.Drawing.Size( 200, 100 );
            GridTable.TabIndex = 0;
            // 
            // LabelTable
            // 
            LabelTable.ColumnCount = 4;
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 71.65533F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 28.34467F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 120F ) );
            LabelTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 411F ) );
            LabelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelTable.Location = new System.Drawing.Point( 3, 3 );
            LabelTable.Name = "LabelTable";
            LabelTable.RowCount = 1;
            LabelTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            LabelTable.Size = new System.Drawing.Size( 194, 26 );
            LabelTable.TabIndex = 1;
            // 
            // AreaTable
            // 
            AreaTable.ColumnCount = 1;
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            AreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            AreaTable.Controls.Add( ChartPanel, 0, 0 );
            AreaTable.Controls.Add( ChartSubTablePanel, 0, 1 );
            AreaTable.Dock = System.Windows.Forms.DockStyle.Fill;
            AreaTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AreaTable.Location = new System.Drawing.Point( 3, 26 );
            AreaTable.Name = "AreaTable";
            AreaTable.RowCount = 2;
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 84.46602F ) );
            AreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 15.53398F ) );
            AreaTable.Size = new System.Drawing.Size( 1063, 618 );
            AreaTable.TabIndex = 6;
            // 
            // ChartPanel
            // 
            ChartPanel.BackColor = System.Drawing.Color.Transparent;
            ChartPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartPanel.BindingSource = null;
            ChartPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ChartPanel.BorderThickness = 1;
            ChartPanel.Children = null;
            ChartPanel.Controls.Add( Chart );
            ChartPanel.DataFilter = null;
            ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ChartPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartPanel.ForeColor = System.Drawing.Color.Transparent;
            ChartPanel.HoverText = null;
            ChartPanel.IsDerivedStyle = true;
            ChartPanel.Location = new System.Drawing.Point( 3, 3 );
            ChartPanel.Name = "ChartPanel";
            ChartPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartPanel.Size = new System.Drawing.Size( 1057, 516 );
            ChartPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ChartPanel.StyleManager = null;
            ChartPanel.TabIndex = 7;
            ChartPanel.ThemeAuthor = "Terry D. Eppler";
            ChartPanel.ThemeName = "Budget Execution";
            ChartPanel.ToolTip = null;
            // 
            // Chart
            // 
            Chart.AllowGradientPalette = true;
            Chart.AllowUserEditStyles = true;
            Chart.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            Chart.AutoHighlight = true;
            Chart.ChartArea.AutoScale = true;
            Chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            Chart.ChartArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Chart.ChartArea.CursorLocation = new System.Drawing.Point( 0, 0 );
            Chart.ChartArea.CursorReDraw = false;
            Chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins( 3, 3, 3, 3 );
            Chart.Depth = 250F;
            Chart.DisplayChartContextMenu = false;
            Chart.DisplaySeriesContextMenu = false;
            Chart.EnableMouseRotation = true;
            Chart.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Chart.IsWindowLess = false;
            // 
            // 
            // 
            Chart.Legend.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Chart.Legend.ItemsAlignment = System.Drawing.StringAlignment.Center;
            Chart.Legend.ItemsShadowColor = System.Drawing.Color.Transparent;
            Chart.Legend.ItemsSize = new System.Drawing.Size( 10, 10 );
            Chart.Legend.Location = new System.Drawing.Point( 927, 60 );
            Chart.Legend.ShowItemsShadow = true;
            Chart.Legend.ShowSymbol = true;
            Chart.Legend.VisibleCheckBox = true;
            Chart.Localize = null;
            Chart.Location = new System.Drawing.Point( 15, 18 );
            Chart.Name = "Chart";
            Chart.Padding = new System.Windows.Forms.Padding( 1 );
            Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
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
            Chart.Size = new System.Drawing.Size( 1031, 481 );
            Chart.Spacing = 5F;
            Chart.SpacingBetweenPoints = 5F;
            Chart.Style3D = true;
            Chart.TabIndex = 0;
            Chart.Text = "The Chart Title";
            Chart.Tilt = 5F;
            // 
            // 
            // 
            Chart.Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Chart.Title.Name = "Default";
            Chart.Titles.Add( Chart.Title );
            Chart.ToolBar.ButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Chart.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            Chart.ToolBar.ShowBorder = false;
            Chart.ToolBar.ShowGrip = false;
            Chart.ToolBar.Visible = true;
            Chart.VisualTheme = "";
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
            ChartSubTablePanel.Location = new System.Drawing.Point( 3, 525 );
            ChartSubTablePanel.Name = "ChartSubTablePanel";
            ChartSubTablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSubTablePanel.Size = new System.Drawing.Size( 1057, 90 );
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
            ChartSubTable.Controls.Add( SqlTextLabel, 0, 0 );
            ChartSubTable.Location = new System.Drawing.Point( 531, 20 );
            ChartSubTable.Name = "ChartSubTable";
            ChartSubTable.RowCount = 1;
            ChartSubTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartSubTable.Size = new System.Drawing.Size( 512, 42 );
            ChartSubTable.TabIndex = 5;
            // 
            // SqlTextLabel
            // 
            SqlTextLabel.BindingSource = null;
            SqlTextLabel.DataFilter = null;
            SqlTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            SqlTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SqlTextLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlTextLabel.HoverText = null;
            SqlTextLabel.IsDerivedStyle = true;
            SqlTextLabel.Location = new System.Drawing.Point( 3, 3 );
            SqlTextLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SqlTextLabel.Name = "SqlTextLabel";
            SqlTextLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SqlTextLabel.Size = new System.Drawing.Size( 506, 36 );
            SqlTextLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SqlTextLabel.StyleManager = null;
            SqlTextLabel.TabIndex = 2;
            SqlTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            SqlTextLabel.ThemeAuthor = "Terry D. Eppler";
            SqlTextLabel.ThemeName = "Budget Execution";
            SqlTextLabel.ToolTip = null;
            // 
            // MetricsTable
            // 
            MetricsTable.ColumnCount = 4;
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.88889F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 32.22222F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 33.88889F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 139F ) );
            MetricsTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            MetricsTable.Controls.Add( SixthDataLabel, 0, 1 );
            MetricsTable.Controls.Add( ThirdDataLabel, 2, 0 );
            MetricsTable.Controls.Add( FirstDataLabel, 0, 0 );
            MetricsTable.Controls.Add( SecondDataLabel, 1, 0 );
            MetricsTable.Controls.Add( FourthDataLabel, 3, 0 );
            MetricsTable.Controls.Add( FifthDataLabel, 0, 1 );
            MetricsTable.Controls.Add( SeventhDataLabel, 1, 1 );
            MetricsTable.Controls.Add( EighthDataLabel, 2, 1 );
            MetricsTable.Location = new System.Drawing.Point( 15, 20 );
            MetricsTable.Name = "MetricsTable";
            MetricsTable.RowCount = 2;
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            MetricsTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            MetricsTable.Size = new System.Drawing.Size( 510, 42 );
            MetricsTable.TabIndex = 4;
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
            SixthDataLabel.Location = new System.Drawing.Point( 128, 24 );
            SixthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SixthDataLabel.Name = "SixthDataLabel";
            SixthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SixthDataLabel.Size = new System.Drawing.Size( 113, 15 );
            SixthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SixthDataLabel.StyleManager = null;
            SixthDataLabel.TabIndex = 48;
            SixthDataLabel.Text = "Source";
            SixthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SixthDataLabel.ThemeAuthor = "Terry D. Eppler";
            SixthDataLabel.ThemeName = "Budget Execution";
            SixthDataLabel.ToolTip = null;
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
            FourthDataLabel.Location = new System.Drawing.Point( 372, 3 );
            FourthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FourthDataLabel.Name = "FourthDataLabel";
            FourthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FourthDataLabel.Size = new System.Drawing.Size( 135, 15 );
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
            FifthDataLabel.Location = new System.Drawing.Point( 3, 24 );
            FifthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FifthDataLabel.Name = "FifthDataLabel";
            FifthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FifthDataLabel.Size = new System.Drawing.Size( 119, 15 );
            FifthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FifthDataLabel.StyleManager = null;
            FifthDataLabel.TabIndex = 45;
            FifthDataLabel.Text = "Source";
            FifthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            FifthDataLabel.ThemeAuthor = "Terry D. Eppler";
            FifthDataLabel.ThemeName = "Budget Execution";
            FifthDataLabel.ToolTip = null;
            // 
            // SeventhDataLabel
            // 
            SeventhDataLabel.BindingSource = null;
            SeventhDataLabel.DataFilter = null;
            SeventhDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            SeventhDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SeventhDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SeventhDataLabel.HoverText = null;
            SeventhDataLabel.IsDerivedStyle = true;
            SeventhDataLabel.Location = new System.Drawing.Point( 247, 24 );
            SeventhDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SeventhDataLabel.Name = "SeventhDataLabel";
            SeventhDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SeventhDataLabel.Size = new System.Drawing.Size( 119, 15 );
            SeventhDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SeventhDataLabel.StyleManager = null;
            SeventhDataLabel.TabIndex = 46;
            SeventhDataLabel.Text = "Source";
            SeventhDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SeventhDataLabel.ThemeAuthor = "Terry D. Eppler";
            SeventhDataLabel.ThemeName = "Budget Execution";
            SeventhDataLabel.ToolTip = null;
            // 
            // EighthDataLabel
            // 
            EighthDataLabel.BindingSource = null;
            EighthDataLabel.DataFilter = null;
            EighthDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            EighthDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EighthDataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            EighthDataLabel.HoverText = null;
            EighthDataLabel.IsDerivedStyle = true;
            EighthDataLabel.Location = new System.Drawing.Point( 372, 24 );
            EighthDataLabel.Margin = new System.Windows.Forms.Padding( 3 );
            EighthDataLabel.Name = "EighthDataLabel";
            EighthDataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            EighthDataLabel.Size = new System.Drawing.Size( 135, 15 );
            EighthDataLabel.Style = MetroSet_UI.Enums.Style.Custom;
            EighthDataLabel.StyleManager = null;
            EighthDataLabel.TabIndex = 47;
            EighthDataLabel.Text = "Source";
            EighthDataLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            EighthDataLabel.ThemeAuthor = "Terry D. Eppler";
            EighthDataLabel.ThemeName = "Budget Execution";
            EighthDataLabel.ToolTip = null;
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
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            ToolStrip.FirstButton = FirstButton;
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 16, 16 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { StripSeparator, ProgressBar, TextBoxSeparator, StatusLabel, NavigationLabelSeparator, FirstButton, FirstSeparator, PreviousButton, PreviousSeparator, NextButton, NextSeparator, LastButton, EditSqlSeparator, FilterLabel, FilterLabelSeparator, RefreshDataButton, NavigationSeparator, RemoveFiltersButton, FilterSeparator, GroupButton, RemoveFiltersSeparator, ChartSpacerLabel, ChartSpacer, ChartSeriesComboBox, ChartSeriesSeparator, MetricsLabel, MetricsPreSeparator, MetricsComboBox, ApplicationLabel, ExitButton, MenuSeparator, MenuButton, ExitSeparator } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = LastButton;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 685 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = NextButton;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            ToolStrip.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStrip.PreviousButton = PreviousButton;
            ToolStrip.ProgressBar = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SaveButton = null;
            ToolStrip.SearchCriteriaLabel = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1338, 54 );
            ToolStrip.TabIndex = 42;
            ToolStrip.Text = " ";
            ToolStrip.TextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb( 28, 28, 28 );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
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
            FirstButton.HoverText = "First Record";
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 36 );
            FirstButton.ToolTip = null;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // StripSeparator
            // 
            StripSeparator.ForeColor = System.Drawing.Color.Black;
            StripSeparator.Margin = new System.Windows.Forms.Padding( 5, 1, 3, 1 );
            StripSeparator.Name = "StripSeparator";
            StripSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            StripSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // ProgressBar
            // 
            ProgressBar.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ProgressBar.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Padding = new System.Windows.Forms.Padding( 0, 1, 0, 1 );
            ProgressBar.Size = new System.Drawing.Size( 125, 36 );
            ProgressBar.Value = 50;
            // 
            // TextBoxSeparator
            // 
            TextBoxSeparator.ForeColor = System.Drawing.Color.Black;
            TextBoxSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            TextBoxSeparator.Name = "TextBoxSeparator";
            TextBoxSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            TextBoxSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            StatusLabel.BindingSource = BindingSource;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 67, 36 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "         Navigation";
            StatusLabel.ToolTip = ToolTip;
            // 
            // NavigationLabelSeparator
            // 
            NavigationLabelSeparator.ForeColor = System.Drawing.Color.Black;
            NavigationLabelSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            NavigationLabelSeparator.Name = "NavigationLabelSeparator";
            NavigationLabelSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            NavigationLabelSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // FirstSeparator
            // 
            FirstSeparator.ForeColor = System.Drawing.Color.Black;
            FirstSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FirstSeparator.Name = "FirstSeparator";
            FirstSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FirstSeparator.Size = new System.Drawing.Size( 6, 36 );
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
            PreviousButton.HoverText = "Previous Button";
            PreviousButton.Image = Resources.Images.PreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 36 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = null;
            PreviousButton.ToolType = ToolType.Ns;
            // 
            // PreviousSeparator
            // 
            PreviousSeparator.ForeColor = System.Drawing.Color.Black;
            PreviousSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            PreviousSeparator.Name = "PreviousSeparator";
            PreviousSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            PreviousSeparator.Size = new System.Drawing.Size( 6, 36 );
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
            NextButton.HoverText = "Next Record";
            NextButton.Image = Resources.Images.NextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 36 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = null;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // NextSeparator
            // 
            NextSeparator.ForeColor = System.Drawing.Color.Black;
            NextSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            NextSeparator.Name = "NextSeparator";
            NextSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            NextSeparator.Size = new System.Drawing.Size( 6, 36 );
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
            LastButton.HoverText = "Last Record";
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 36 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = null;
            LastButton.ToolType = ToolType.LastButton;
            // 
            // EditSqlSeparator
            // 
            EditSqlSeparator.ForeColor = System.Drawing.Color.Black;
            EditSqlSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            EditSqlSeparator.Name = "EditSqlSeparator";
            EditSqlSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            EditSqlSeparator.Size = new System.Drawing.Size( 6, 36 );
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
            FilterLabel.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FilterLabel.Size = new System.Drawing.Size( 58, 36 );
            FilterLabel.Tag = "";
            FilterLabel.Text = "            Filters:";
            FilterLabel.ToolTip = null;
            // 
            // FilterLabelSeparator
            // 
            FilterLabelSeparator.ForeColor = System.Drawing.Color.Black;
            FilterLabelSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FilterLabelSeparator.Name = "FilterLabelSeparator";
            FilterLabelSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FilterLabelSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // RefreshDataButton
            // 
            RefreshDataButton.AutoToolTip = false;
            RefreshDataButton.BackColor = System.Drawing.Color.Transparent;
            RefreshDataButton.BindingSource = BindingSource;
            RefreshDataButton.DataFilter = null;
            RefreshDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshDataButton.Field = Field.AccountCode;
            RefreshDataButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            RefreshDataButton.ForeColor = System.Drawing.Color.LightGray;
            RefreshDataButton.HoverText = "Reset Data Filters";
            RefreshDataButton.Image = Resources.Images.RefreshDataButton;
            RefreshDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshDataButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshDataButton.Name = "RefreshDataButton";
            RefreshDataButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshDataButton.Size = new System.Drawing.Size( 23, 36 );
            RefreshDataButton.Text = "toolStripButton1";
            RefreshDataButton.ToolTip = ToolTip;
            RefreshDataButton.ToolType = ToolType.RefreshDataButton;
            // 
            // NavigationSeparator
            // 
            NavigationSeparator.ForeColor = System.Drawing.Color.Black;
            NavigationSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            NavigationSeparator.Name = "NavigationSeparator";
            NavigationSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            NavigationSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // RemoveFiltersButton
            // 
            RemoveFiltersButton.AutoToolTip = false;
            RemoveFiltersButton.BackColor = System.Drawing.Color.Transparent;
            RemoveFiltersButton.BindingSource = BindingSource;
            RemoveFiltersButton.DataFilter = null;
            RemoveFiltersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RemoveFiltersButton.Field = Field.AccountCode;
            RemoveFiltersButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            RemoveFiltersButton.ForeColor = System.Drawing.Color.LightGray;
            RemoveFiltersButton.HoverText = "Reset Table Filters";
            RemoveFiltersButton.Image = Resources.Images.FilterButton;
            RemoveFiltersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RemoveFiltersButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RemoveFiltersButton.Name = "RemoveFiltersButton";
            RemoveFiltersButton.Padding = new System.Windows.Forms.Padding( 1 );
            RemoveFiltersButton.Size = new System.Drawing.Size( 23, 36 );
            RemoveFiltersButton.Text = "toolStripButton1";
            RemoveFiltersButton.ToolTip = ToolTip;
            RemoveFiltersButton.ToolType = ToolType.RemoveFiltersButton;
            // 
            // FilterSeparator
            // 
            FilterSeparator.ForeColor = System.Drawing.Color.Black;
            FilterSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FilterSeparator.Name = "FilterSeparator";
            FilterSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            FilterSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // GroupButton
            // 
            GroupButton.AutoToolTip = false;
            GroupButton.BackColor = System.Drawing.Color.Transparent;
            GroupButton.BindingSource = BindingSource;
            GroupButton.DataFilter = null;
            GroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            GroupButton.Field = Field.AccountCode;
            GroupButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GroupButton.ForeColor = System.Drawing.Color.LightGray;
            GroupButton.HoverText = "Aggregate Column";
            GroupButton.Image = Resources.Images.GroupButton;
            GroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            GroupButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            GroupButton.Name = "GroupButton";
            GroupButton.Padding = new System.Windows.Forms.Padding( 1 );
            GroupButton.Size = new System.Drawing.Size( 23, 36 );
            GroupButton.Text = "toolStripButton1";
            GroupButton.ToolTip = ToolTip;
            GroupButton.ToolType = ToolType.GroupButton;
            // 
            // RemoveFiltersSeparator
            // 
            RemoveFiltersSeparator.ForeColor = System.Drawing.Color.Black;
            RemoveFiltersSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            RemoveFiltersSeparator.Name = "RemoveFiltersSeparator";
            RemoveFiltersSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            RemoveFiltersSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // ChartSpacerLabel
            // 
            ChartSpacerLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ChartSpacerLabel.BindingSource = null;
            ChartSpacerLabel.DataFilter = null;
            ChartSpacerLabel.Field = Field.AccountCode;
            ChartSpacerLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartSpacerLabel.ForeColor = System.Drawing.Color.Black;
            ChartSpacerLabel.HoverText = null;
            ChartSpacerLabel.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            ChartSpacerLabel.Name = "ChartSpacerLabel";
            ChartSpacerLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSpacerLabel.Size = new System.Drawing.Size( 58, 36 );
            ChartSpacerLabel.Tag = "";
            ChartSpacerLabel.Text = "            Charts";
            ChartSpacerLabel.ToolTip = null;
            // 
            // ChartSpacer
            // 
            ChartSpacer.ForeColor = System.Drawing.Color.Black;
            ChartSpacer.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ChartSpacer.Name = "ChartSpacer";
            ChartSpacer.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            ChartSpacer.Size = new System.Drawing.Size( 6, 36 );
            // 
            // ChartSeriesComboBox
            // 
            ChartSeriesComboBox.AllowDrop = true;
            ChartSeriesComboBox.BindingSource = BindingSource;
            ChartSeriesComboBox.DataFilter = null;
            ChartSeriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ChartSeriesComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartSeriesComboBox.ForeColor = System.Drawing.Color.FromArgb( 218, 218, 218 );
            ChartSeriesComboBox.HoverText = "Select Chart Type";
            ChartSeriesComboBox.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ChartSeriesComboBox.MaxDropDownItems = 100;
            ChartSeriesComboBox.MaxLength = 32767;
            ChartSeriesComboBox.Name = "ChartSeriesComboBox";
            ChartSeriesComboBox.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSeriesComboBox.Size = new System.Drawing.Size( 150, 36 );
            ChartSeriesComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            ChartSeriesComboBox.ToolTip = ToolTip;
            ChartSeriesComboBox.ToolTipText = "Make Selection";
            // 
            // ChartSeriesSeparator
            // 
            ChartSeriesSeparator.ForeColor = System.Drawing.Color.Black;
            ChartSeriesSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            ChartSeriesSeparator.Name = "ChartSeriesSeparator";
            ChartSeriesSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            ChartSeriesSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // MetricsLabel
            // 
            MetricsLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            MetricsLabel.BindingSource = null;
            MetricsLabel.DataFilter = null;
            MetricsLabel.Field = Field.AccountCode;
            MetricsLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MetricsLabel.ForeColor = System.Drawing.Color.Black;
            MetricsLabel.HoverText = null;
            MetricsLabel.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MetricsLabel.Name = "MetricsLabel";
            MetricsLabel.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsLabel.Size = new System.Drawing.Size( 62, 36 );
            MetricsLabel.Tag = "";
            MetricsLabel.Text = "            Metrics";
            MetricsLabel.ToolTip = null;
            // 
            // MetricsPreSeparator
            // 
            MetricsPreSeparator.ForeColor = System.Drawing.Color.Black;
            MetricsPreSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MetricsPreSeparator.Name = "MetricsPreSeparator";
            MetricsPreSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MetricsPreSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // MetricsComboBox
            // 
            MetricsComboBox.AllowDrop = true;
            MetricsComboBox.BindingSource = BindingSource;
            MetricsComboBox.DataFilter = null;
            MetricsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MetricsComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MetricsComboBox.ForeColor = System.Drawing.Color.FromArgb( 218, 218, 218 );
            MetricsComboBox.HoverText = "Choose Metric";
            MetricsComboBox.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MetricsComboBox.MaxDropDownItems = 100;
            MetricsComboBox.MaxLength = 32767;
            MetricsComboBox.Name = "MetricsComboBox";
            MetricsComboBox.Padding = new System.Windows.Forms.Padding( 1 );
            MetricsComboBox.Size = new System.Drawing.Size( 125, 36 );
            MetricsComboBox.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            MetricsComboBox.Tag = "";
            MetricsComboBox.ToolTip = ToolTip;
            MetricsComboBox.ToolTipText = "Choose Metric";
            // 
            // MetricsPostSeparator
            // 
            MetricsPostSeparator.ForeColor = System.Drawing.Color.Black;
            MetricsPostSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MetricsPostSeparator.Name = "MetricsPostSeparator";
            MetricsPostSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MetricsPostSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // ApplicationLabel
            // 
            ApplicationLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ApplicationLabel.BindingSource = null;
            ApplicationLabel.DataFilter = null;
            ApplicationLabel.Field = Field.AccountCode;
            ApplicationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ApplicationLabel.ForeColor = System.Drawing.Color.Black;
            ApplicationLabel.HoverText = null;
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 10, 1, 3, 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 78, 36 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "            Application:";
            ApplicationLabel.ToolTip = null;
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
            MenuButton.Image = Resources.Images.HomeButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 36 );
            MenuButton.Text = "toolStripButton2";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // MenuSeparator
            // 
            MenuSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuSeparator.ForeColor = System.Drawing.Color.Black;
            MenuSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MenuSeparator.Name = "MenuSeparator";
            MenuSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            MenuSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // ExitButton
            // 
            ExitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ExitButton.AutoToolTip = false;
            ExitButton.BackColor = System.Drawing.Color.Transparent;
            ExitButton.BindingSource = BindingSource;
            ExitButton.DataFilter = null;
            ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ExitButton.Field = Field.AccountCode;
            ExitButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ExitButton.ForeColor = System.Drawing.Color.LightGray;
            ExitButton.HoverText = "Exit Application";
            ExitButton.Image = Resources.Images.ShutdownButton;
            ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ExitButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ExitButton.Name = "ExitButton";
            ExitButton.Padding = new System.Windows.Forms.Padding( 1 );
            ExitButton.Size = new System.Drawing.Size( 23, 36 );
            ExitButton.Text = "toolStripButton1";
            ExitButton.ToolTip = ToolTip;
            ExitButton.ToolType = ToolType.ExitButton;
            // 
            // ExitSeparator
            // 
            ExitSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ExitSeparator.ForeColor = System.Drawing.Color.Black;
            ExitSeparator.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            ExitSeparator.Name = "ExitSeparator";
            ExitSeparator.Padding = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            ExitSeparator.Size = new System.Drawing.Size( 6, 36 );
            // 
            // LastSeparator
            // 
            LastSeparator.ForeColor = System.Drawing.Color.Black;
            LastSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            LastSeparator.Name = "LastSeparator";
            LastSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            LastSeparator.Size = new System.Drawing.Size( 6, 30 );
            // 
            // FunctionLabel
            // 
            FunctionLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FunctionLabel.BindingSource = null;
            FunctionLabel.DataFilter = null;
            FunctionLabel.Field = Field.AccountCode;
            FunctionLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FunctionLabel.ForeColor = System.Drawing.Color.Black;
            FunctionLabel.HoverText = null;
            FunctionLabel.Margin = new System.Windows.Forms.Padding( 1 );
            FunctionLabel.Name = "FunctionLabel";
            FunctionLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FunctionLabel.Size = new System.Drawing.Size( 57, 28 );
            FunctionLabel.Tag = "";
            FunctionLabel.Text = "    Functions:";
            FunctionLabel.ToolTip = null;
            // 
            // LabelSeparator
            // 
            LabelSeparator.ForeColor = System.Drawing.Color.Black;
            LabelSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            LabelSeparator.Name = "LabelSeparator";
            LabelSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            LabelSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ChartSeriesLabel
            // 
            ChartSeriesLabel.BackColor = System.Drawing.Color.Transparent;
            ChartSeriesLabel.BindingSource = null;
            ChartSeriesLabel.DataFilter = null;
            ChartSeriesLabel.Field = Field.AccountCode;
            ChartSeriesLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartSeriesLabel.ForeColor = System.Drawing.Color.Black;
            ChartSeriesLabel.HoverText = null;
            ChartSeriesLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ChartSeriesLabel.Name = "ChartSeriesLabel";
            ChartSeriesLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ChartSeriesLabel.Size = new System.Drawing.Size( 60, 28 );
            ChartSeriesLabel.Tag = "";
            ChartSeriesLabel.Text = "             Charts";
            ChartSeriesLabel.ToolTip = null;
            // 
            // DropDownSeparator
            // 
            DropDownSeparator.ForeColor = System.Drawing.Color.Black;
            DropDownSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            DropDownSeparator.Name = "DropDownSeparator";
            DropDownSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            DropDownSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ExcelSeparator
            // 
            ExcelSeparator.ForeColor = System.Drawing.Color.Black;
            ExcelSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            ExcelSeparator.Name = "ExcelSeparator";
            ExcelSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            ExcelSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // RefreshDataSeparator
            // 
            RefreshDataSeparator.ForeColor = System.Drawing.Color.Black;
            RefreshDataSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            RefreshDataSeparator.Name = "RefreshDataSeparator";
            RefreshDataSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshDataSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // GroupSeparator
            // 
            GroupSeparator.ForeColor = System.Drawing.Color.Black;
            GroupSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            GroupSeparator.Name = "GroupSeparator";
            GroupSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            GroupSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 156, 264 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry D. Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 254, 684 );
            TabControl.BindingSource = null;
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( TableTabPage );
            TabControl.Controls.Add( FilterTabPage );
            TabControl.Controls.Add( GroupTabPage );
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.ForeColor = System.Drawing.Color.LightGray;
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 100, 30 );
            TabControl.Location = new System.Drawing.Point( 1084, 4 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 254, 684 );
            TabControl.TabIndex = 48;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.DarkGray;
            TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ToolTip = null;
            // 
            // TableTabPage
            // 
            TableTabPage.Image = null;
            TableTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            TableTabPage.Location = new System.Drawing.Point( 0, 29 );
            TableTabPage.Name = "TableTabPage";
            TableTabPage.ShowCloseButton = true;
            TableTabPage.Size = new System.Drawing.Size( 254, 655 );
            TableTabPage.TabIndex = 4;
            TableTabPage.ThemesEnabled = false;
            // 
            // FilterTabPage
            // 
            FilterTabPage.Controls.Add( ThirdTable );
            FilterTabPage.Controls.Add( FirstTable );
            FilterTabPage.Controls.Add( SecondTable );
            FilterTabPage.Image = null;
            FilterTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            FilterTabPage.Location = new System.Drawing.Point( 0, 29 );
            FilterTabPage.Name = "FilterTabPage";
            FilterTabPage.ShowCloseButton = true;
            FilterTabPage.Size = new System.Drawing.Size( 254, 655 );
            FilterTabPage.TabIndex = 5;
            FilterTabPage.ThemesEnabled = false;
            // 
            // ThirdTable
            // 
            ThirdTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ThirdTable.CaptionText = "Third Filter";
            ThirdTable.ColumnCount = 1;
            ThirdTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ThirdTable.Controls.Add( ThirdComboBox, 0, 0 );
            ThirdTable.Controls.Add( ThirdListBoxPanel, 0, 1 );
            ThirdTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdTable.ForeColor = System.Drawing.Color.DarkGray;
            ThirdTable.Location = new System.Drawing.Point( 3, 440 );
            ThirdTable.Name = "ThirdTable";
            ThirdTable.RowCount = 2;
            ThirdTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 19.2513371F ) );
            ThirdTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 80.7486649F ) );
            ThirdTable.Size = new System.Drawing.Size( 242, 211 );
            ThirdTable.TabIndex = 51;
            // 
            // ThirdComboBox
            // 
            ThirdComboBox.AllowDrop = true;
            ThirdComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ThirdComboBox.BackColor = System.Drawing.Color.Transparent;
            ThirdComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ThirdComboBox.BindingSource = null;
            ThirdComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            ThirdComboBox.CausesValidation = false;
            ThirdComboBox.DataFilter = null;
            ThirdComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            ThirdComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            ThirdComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            ThirdComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            ThirdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            ThirdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ThirdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ThirdComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdComboBox.FormattingEnabled = true;
            ThirdComboBox.HoverText = null;
            ThirdComboBox.IsDerivedStyle = true;
            ThirdComboBox.ItemHeight = 24;
            ThirdComboBox.Location = new System.Drawing.Point( 3, 19 );
            ThirdComboBox.Name = "ThirdComboBox";
            ThirdComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ThirdComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            ThirdComboBox.Size = new System.Drawing.Size( 236, 30 );
            ThirdComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdComboBox.StyleManager = null;
            ThirdComboBox.TabIndex = 0;
            ThirdComboBox.ThemeAuthor = "Terry D. Eppler";
            ThirdComboBox.ThemeName = "Budget Execution";
            ThirdComboBox.ToolTip = null;
            // 
            // ThirdListBoxPanel
            // 
            ThirdListBoxPanel.BackColor = System.Drawing.Color.Transparent;
            ThirdListBoxPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdListBoxPanel.BindingSource = null;
            ThirdListBoxPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ThirdListBoxPanel.BorderThickness = 1;
            ThirdListBoxPanel.Children = null;
            ThirdListBoxPanel.Controls.Add( ThirdListBox );
            ThirdListBoxPanel.DataFilter = null;
            ThirdListBoxPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            ThirdListBoxPanel.HoverText = null;
            ThirdListBoxPanel.IsDerivedStyle = true;
            ThirdListBoxPanel.Location = new System.Drawing.Point( 3, 56 );
            ThirdListBoxPanel.Name = "ThirdListBoxPanel";
            ThirdListBoxPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ThirdListBoxPanel.Size = new System.Drawing.Size( 233, 152 );
            ThirdListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdListBoxPanel.StyleManager = null;
            ThirdListBoxPanel.TabIndex = 1;
            ThirdListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            ThirdListBoxPanel.ThemeName = "Budget Execution";
            ThirdListBoxPanel.ToolTip = null;
            // 
            // ThirdListBox
            // 
            ThirdListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ThirdListBox.BindingSource = null;
            ThirdListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            ThirdListBox.DataFilter = null;
            ThirdListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            ThirdListBox.HoveredItemColor = System.Drawing.Color.White;
            ThirdListBox.HoverText = null;
            ThirdListBox.IsDerivedStyle = true;
            ThirdListBox.ItemHeight = 28;
            ThirdListBox.Location = new System.Drawing.Point( 17, 17 );
            ThirdListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ThirdListBox.MultiSelect = true;
            ThirdListBox.Name = "ThirdListBox";
            ThirdListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ThirdListBox.SelectedIndex = -1;
            ThirdListBox.SelectedItem = null;
            ThirdListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ThirdListBox.SelectedItemColor = System.Drawing.Color.White;
            ThirdListBox.SelectedText = null;
            ThirdListBox.SelectedValue = null;
            ThirdListBox.ShowBorder = false;
            ThirdListBox.ShowScrollBar = true;
            ThirdListBox.Size = new System.Drawing.Size( 199, 118 );
            ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdListBox.StyleManager = null;
            ThirdListBox.TabIndex = 0;
            ThirdListBox.ThemeAuthor = "Terry D. Eppler";
            ThirdListBox.ThemeName = "Budget Execution";
            ThirdListBox.ToolTip = null;
            // 
            // FirstTable
            // 
            FirstTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FirstTable.CaptionText = "First Filter";
            FirstTable.ColumnCount = 1;
            FirstTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FirstTable.Controls.Add( FirstComboBox, 0, 0 );
            FirstTable.Controls.Add( FirstListBoxPanel, 0, 1 );
            FirstTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstTable.ForeColor = System.Drawing.Color.DarkGray;
            FirstTable.Location = new System.Drawing.Point( 3, 3 );
            FirstTable.Name = "FirstTable";
            FirstTable.RowCount = 2;
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 22.2222214F ) );
            FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 77.77778F ) );
            FirstTable.Size = new System.Drawing.Size( 242, 223 );
            FirstTable.TabIndex = 49;
            // 
            // FirstComboBox
            // 
            FirstComboBox.AllowDrop = true;
            FirstComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstComboBox.BackColor = System.Drawing.Color.Transparent;
            FirstComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            FirstComboBox.BindingSource = null;
            FirstComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            FirstComboBox.CausesValidation = false;
            FirstComboBox.DataFilter = null;
            FirstComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            FirstComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            FirstComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            FirstComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            FirstComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            FirstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FirstComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FirstComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstComboBox.FormattingEnabled = true;
            FirstComboBox.HoverText = null;
            FirstComboBox.IsDerivedStyle = true;
            FirstComboBox.ItemHeight = 24;
            FirstComboBox.Location = new System.Drawing.Point( 3, 29 );
            FirstComboBox.Name = "FirstComboBox";
            FirstComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            FirstComboBox.Size = new System.Drawing.Size( 236, 30 );
            FirstComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            FirstComboBox.StyleManager = null;
            FirstComboBox.TabIndex = 0;
            FirstComboBox.ThemeAuthor = "Terry D. Eppler";
            FirstComboBox.ThemeName = "Budget Execution";
            FirstComboBox.ToolTip = null;
            // 
            // FirstListBoxPanel
            // 
            FirstListBoxPanel.BackColor = System.Drawing.Color.Transparent;
            FirstListBoxPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstListBoxPanel.BindingSource = null;
            FirstListBoxPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            FirstListBoxPanel.BorderThickness = 1;
            FirstListBoxPanel.Children = null;
            FirstListBoxPanel.Controls.Add( FirstListBox );
            FirstListBoxPanel.DataFilter = null;
            FirstListBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            FirstListBoxPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            FirstListBoxPanel.HoverText = null;
            FirstListBoxPanel.IsDerivedStyle = true;
            FirstListBoxPanel.Location = new System.Drawing.Point( 3, 65 );
            FirstListBoxPanel.Name = "FirstListBoxPanel";
            FirstListBoxPanel.Padding = new System.Windows.Forms.Padding( 1 );
            FirstListBoxPanel.Size = new System.Drawing.Size( 236, 155 );
            FirstListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            FirstListBoxPanel.StyleManager = null;
            FirstListBoxPanel.TabIndex = 1;
            FirstListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            FirstListBoxPanel.ThemeName = "Budget Execution";
            FirstListBoxPanel.ToolTip = null;
            // 
            // FirstListBox
            // 
            FirstListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            FirstListBox.BindingSource = null;
            FirstListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            FirstListBox.DataFilter = null;
            FirstListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            FirstListBox.HoveredItemColor = System.Drawing.Color.White;
            FirstListBox.HoverText = null;
            FirstListBox.IsDerivedStyle = true;
            FirstListBox.ItemHeight = 28;
            FirstListBox.Location = new System.Drawing.Point( 17, 15 );
            FirstListBox.Margin = new System.Windows.Forms.Padding( 1 );
            FirstListBox.MultiSelect = true;
            FirstListBox.Name = "FirstListBox";
            FirstListBox.Padding = new System.Windows.Forms.Padding( 1 );
            FirstListBox.SelectedIndex = -1;
            FirstListBox.SelectedItem = null;
            FirstListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstListBox.SelectedItemColor = System.Drawing.Color.White;
            FirstListBox.SelectedText = null;
            FirstListBox.SelectedValue = null;
            FirstListBox.ShowBorder = false;
            FirstListBox.ShowScrollBar = true;
            FirstListBox.Size = new System.Drawing.Size( 199, 125 );
            FirstListBox.Style = MetroSet_UI.Enums.Style.Custom;
            FirstListBox.StyleManager = null;
            FirstListBox.TabIndex = 0;
            FirstListBox.ThemeAuthor = "Terry D. Eppler";
            FirstListBox.ThemeName = "Budget Execution";
            FirstListBox.ToolTip = null;
            // 
            // SecondTable
            // 
            SecondTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SecondTable.CaptionText = "Second Filter";
            SecondTable.ColumnCount = 1;
            SecondTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            SecondTable.Controls.Add( SecondListBoxPanel, 0, 1 );
            SecondTable.Controls.Add( SecondComboBox, 0, 0 );
            SecondTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondTable.ForeColor = System.Drawing.Color.DarkGray;
            SecondTable.Location = new System.Drawing.Point( 3, 229 );
            SecondTable.Name = "SecondTable";
            SecondTable.RowCount = 2;
            SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 37F ) );
            SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 28F ) );
            SecondTable.Size = new System.Drawing.Size( 242, 205 );
            SecondTable.TabIndex = 50;
            // 
            // SecondListBoxPanel
            // 
            SecondListBoxPanel.BackColor = System.Drawing.Color.Transparent;
            SecondListBoxPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondListBoxPanel.BindingSource = null;
            SecondListBoxPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            SecondListBoxPanel.BorderThickness = 1;
            SecondListBoxPanel.Children = null;
            SecondListBoxPanel.Controls.Add( SecondListBox );
            SecondListBoxPanel.DataFilter = null;
            SecondListBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondListBoxPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            SecondListBoxPanel.HoverText = null;
            SecondListBoxPanel.IsDerivedStyle = true;
            SecondListBoxPanel.Location = new System.Drawing.Point( 3, 56 );
            SecondListBoxPanel.Name = "SecondListBoxPanel";
            SecondListBoxPanel.Padding = new System.Windows.Forms.Padding( 1 );
            SecondListBoxPanel.Size = new System.Drawing.Size( 236, 146 );
            SecondListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondListBoxPanel.StyleManager = null;
            SecondListBoxPanel.TabIndex = 47;
            SecondListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            SecondListBoxPanel.ThemeName = "Budget Execution";
            SecondListBoxPanel.ToolTip = null;
            // 
            // SecondListBox
            // 
            SecondListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SecondListBox.BindingSource = null;
            SecondListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            SecondListBox.DataFilter = null;
            SecondListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SecondListBox.HoveredItemColor = System.Drawing.Color.White;
            SecondListBox.HoverText = null;
            SecondListBox.IsDerivedStyle = true;
            SecondListBox.ItemHeight = 28;
            SecondListBox.Location = new System.Drawing.Point( 14, 14 );
            SecondListBox.Margin = new System.Windows.Forms.Padding( 1 );
            SecondListBox.MultiSelect = true;
            SecondListBox.Name = "SecondListBox";
            SecondListBox.Padding = new System.Windows.Forms.Padding( 1 );
            SecondListBox.SelectedIndex = -1;
            SecondListBox.SelectedItem = null;
            SecondListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondListBox.SelectedItemColor = System.Drawing.Color.White;
            SecondListBox.SelectedText = null;
            SecondListBox.SelectedValue = null;
            SecondListBox.ShowBorder = false;
            SecondListBox.ShowScrollBar = true;
            SecondListBox.Size = new System.Drawing.Size( 202, 115 );
            SecondListBox.Style = MetroSet_UI.Enums.Style.Custom;
            SecondListBox.StyleManager = null;
            SecondListBox.TabIndex = 0;
            SecondListBox.ThemeAuthor = "Terry D. Eppler";
            SecondListBox.ThemeName = "Budget Execution";
            SecondListBox.ToolTip = null;
            // 
            // SecondComboBox
            // 
            SecondComboBox.AllowDrop = true;
            SecondComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondComboBox.BackColor = System.Drawing.Color.Transparent;
            SecondComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SecondComboBox.BindingSource = null;
            SecondComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            SecondComboBox.CausesValidation = false;
            SecondComboBox.DataFilter = null;
            SecondComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            SecondComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            SecondComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            SecondComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            SecondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SecondComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SecondComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondComboBox.FormattingEnabled = true;
            SecondComboBox.HoverText = null;
            SecondComboBox.IsDerivedStyle = true;
            SecondComboBox.ItemHeight = 24;
            SecondComboBox.Location = new System.Drawing.Point( 3, 19 );
            SecondComboBox.Name = "SecondComboBox";
            SecondComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            SecondComboBox.Size = new System.Drawing.Size( 236, 30 );
            SecondComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            SecondComboBox.StyleManager = null;
            SecondComboBox.TabIndex = 46;
            SecondComboBox.ThemeAuthor = "Terry D. Eppler";
            SecondComboBox.ThemeName = "Budget Execution";
            SecondComboBox.ToolTip = null;
            // 
            // GroupTabPage
            // 
            GroupTabPage.Controls.Add( NumericTable );
            GroupTabPage.Controls.Add( FieldTable );
            GroupTabPage.Image = null;
            GroupTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            GroupTabPage.Location = new System.Drawing.Point( 0, 29 );
            GroupTabPage.Name = "GroupTabPage";
            GroupTabPage.ShowCloseButton = true;
            GroupTabPage.Size = new System.Drawing.Size( 254, 655 );
            GroupTabPage.TabIndex = 3;
            GroupTabPage.ThemesEnabled = false;
            // 
            // NumericTable
            // 
            NumericTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            NumericTable.CaptionText = "Measures";
            NumericTable.ColumnCount = 1;
            NumericTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            NumericTable.Controls.Add( NumericPanel, 0, 1 );
            NumericTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NumericTable.ForeColor = System.Drawing.Color.DarkGray;
            NumericTable.Location = new System.Drawing.Point( 3, 341 );
            NumericTable.Name = "NumericTable";
            NumericTable.RowCount = 2;
            NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.80228138F ) );
            NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.1977158F ) );
            NumericTable.Size = new System.Drawing.Size( 242, 307 );
            NumericTable.TabIndex = 1;
            // 
            // NumericPanel
            // 
            NumericPanel.BackColor = System.Drawing.Color.Transparent;
            NumericPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericPanel.BindingSource = null;
            NumericPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            NumericPanel.BorderThickness = 1;
            NumericPanel.Children = null;
            NumericPanel.Controls.Add( NumericListBox );
            NumericPanel.DataFilter = null;
            NumericPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            NumericPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NumericPanel.ForeColor = System.Drawing.Color.Transparent;
            NumericPanel.HoverText = null;
            NumericPanel.IsDerivedStyle = true;
            NumericPanel.Location = new System.Drawing.Point( 3, 30 );
            NumericPanel.Name = "NumericPanel";
            NumericPanel.Padding = new System.Windows.Forms.Padding( 1 );
            NumericPanel.Size = new System.Drawing.Size( 236, 274 );
            NumericPanel.Style = MetroSet_UI.Enums.Style.Custom;
            NumericPanel.StyleManager = null;
            NumericPanel.TabIndex = 0;
            NumericPanel.ThemeAuthor = "Terry D. Eppler";
            NumericPanel.ThemeName = "Budget Execution";
            NumericPanel.ToolTip = null;
            // 
            // NumericListBox
            // 
            NumericListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            NumericListBox.BindingSource = null;
            NumericListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            NumericListBox.DataFilter = null;
            NumericListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NumericListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            NumericListBox.HoveredItemColor = System.Drawing.Color.White;
            NumericListBox.HoverText = null;
            NumericListBox.IsDerivedStyle = true;
            NumericListBox.ItemHeight = 28;
            NumericListBox.Location = new System.Drawing.Point( 24, 23 );
            NumericListBox.Margin = new System.Windows.Forms.Padding( 1 );
            NumericListBox.MultiSelect = true;
            NumericListBox.Name = "NumericListBox";
            NumericListBox.Padding = new System.Windows.Forms.Padding( 1 );
            NumericListBox.SelectedIndex = -1;
            NumericListBox.SelectedItem = null;
            NumericListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            NumericListBox.SelectedItemColor = System.Drawing.Color.White;
            NumericListBox.SelectedText = null;
            NumericListBox.SelectedValue = null;
            NumericListBox.ShowBorder = false;
            NumericListBox.ShowScrollBar = false;
            NumericListBox.Size = new System.Drawing.Size( 186, 233 );
            NumericListBox.Style = MetroSet_UI.Enums.Style.Custom;
            NumericListBox.StyleManager = null;
            NumericListBox.TabIndex = 0;
            NumericListBox.ThemeAuthor = "Terry D. Eppler";
            NumericListBox.ThemeName = "Budget Execution";
            NumericListBox.ToolTip = ToolTip;
            // 
            // FieldTable
            // 
            FieldTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FieldTable.CaptionText = "Fields";
            FieldTable.ColumnCount = 1;
            FieldTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            FieldTable.Controls.Add( FieldPanel, 0, 1 );
            FieldTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FieldTable.ForeColor = System.Drawing.Color.DarkGray;
            FieldTable.Location = new System.Drawing.Point( 3, 3 );
            FieldTable.Name = "FieldTable";
            FieldTable.RowCount = 2;
            FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.62295079F ) );
            FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.37705F ) );
            FieldTable.Size = new System.Drawing.Size( 242, 321 );
            FieldTable.TabIndex = 0;
            // 
            // FieldPanel
            // 
            FieldPanel.BackColor = System.Drawing.Color.Transparent;
            FieldPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldPanel.BindingSource = null;
            FieldPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            FieldPanel.BorderThickness = 1;
            FieldPanel.Children = null;
            FieldPanel.Controls.Add( FieldListBox );
            FieldPanel.DataFilter = null;
            FieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            FieldPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FieldPanel.ForeColor = System.Drawing.Color.Transparent;
            FieldPanel.HoverText = null;
            FieldPanel.IsDerivedStyle = true;
            FieldPanel.Location = new System.Drawing.Point( 3, 27 );
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Padding = new System.Windows.Forms.Padding( 1 );
            FieldPanel.Size = new System.Drawing.Size( 236, 291 );
            FieldPanel.Style = MetroSet_UI.Enums.Style.Custom;
            FieldPanel.StyleManager = null;
            FieldPanel.TabIndex = 0;
            FieldPanel.ThemeAuthor = "Terry D. Eppler";
            FieldPanel.ThemeName = "Budget Execution";
            FieldPanel.ToolTip = null;
            // 
            // FieldListBox
            // 
            FieldListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            FieldListBox.BindingSource = null;
            FieldListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            FieldListBox.DataFilter = null;
            FieldListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FieldListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            FieldListBox.HoveredItemColor = System.Drawing.Color.White;
            FieldListBox.HoverText = null;
            FieldListBox.IsDerivedStyle = true;
            FieldListBox.ItemHeight = 28;
            FieldListBox.Location = new System.Drawing.Point( 24, 23 );
            FieldListBox.Margin = new System.Windows.Forms.Padding( 1 );
            FieldListBox.MultiSelect = true;
            FieldListBox.Name = "FieldListBox";
            FieldListBox.Padding = new System.Windows.Forms.Padding( 1 );
            FieldListBox.SelectedIndex = -1;
            FieldListBox.SelectedItem = null;
            FieldListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FieldListBox.SelectedItemColor = System.Drawing.Color.White;
            FieldListBox.SelectedText = null;
            FieldListBox.SelectedValue = null;
            FieldListBox.ShowBorder = false;
            FieldListBox.ShowScrollBar = false;
            FieldListBox.Size = new System.Drawing.Size( 186, 246 );
            FieldListBox.Style = MetroSet_UI.Enums.Style.Custom;
            FieldListBox.StyleManager = null;
            FieldListBox.TabIndex = 0;
            FieldListBox.ThemeAuthor = "Terry D. Eppler";
            FieldListBox.ThemeName = "Budget Execution";
            FieldListBox.ToolTip = ToolTip;
            // 
            // SourcePanel
            // 
            SourcePanel.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            SourcePanel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SourcePanel.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourcePanel.CaptionText = "Data Tables";
            SourcePanel.ColumnCount = 1;
            SourcePanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SourcePanel.Controls.Add( TableListBoxPanel, 0, 1 );
            SourcePanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SourcePanel.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SourcePanel.Location = new System.Drawing.Point( 1087, 30 );
            SourcePanel.Name = "SourcePanel";
            SourcePanel.RowCount = 2;
            SourcePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            SourcePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            SourcePanel.Size = new System.Drawing.Size( 242, 647 );
            SourcePanel.TabIndex = 1;
            // 
            // TableListBoxPanel
            // 
            TableListBoxPanel.BackColor = System.Drawing.Color.Transparent;
            TableListBoxPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBoxPanel.BindingSource = null;
            TableListBoxPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TableListBoxPanel.BorderThickness = 1;
            TableListBoxPanel.Children = null;
            TableListBoxPanel.Controls.Add( TableListBox );
            TableListBoxPanel.DataFilter = null;
            TableListBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TableListBoxPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TableListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            TableListBoxPanel.HoverText = null;
            TableListBoxPanel.IsDerivedStyle = true;
            TableListBoxPanel.Location = new System.Drawing.Point( 3, 26 );
            TableListBoxPanel.Name = "TableListBoxPanel";
            TableListBoxPanel.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBoxPanel.Size = new System.Drawing.Size( 236, 618 );
            TableListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBoxPanel.StyleManager = null;
            TableListBoxPanel.TabIndex = 0;
            TableListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            TableListBoxPanel.ThemeName = "Budget Execution";
            TableListBoxPanel.ToolTip = null;
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
            // ChartTable
            // 
            ChartTable.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ChartTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ChartTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ChartTable.CaptionText = "Data Visualization";
            ChartTable.ColumnCount = 1;
            ChartTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ChartTable.Controls.Add( AreaTable, 0, 1 );
            ChartTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ChartTable.Location = new System.Drawing.Point( 12, 30 );
            ChartTable.Name = "ChartTable";
            ChartTable.RowCount = 2;
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.26582277F ) );
            ChartTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.73418F ) );
            ChartTable.Size = new System.Drawing.Size( 1069, 647 );
            ChartTable.TabIndex = 49;
            ChartTable.Paint +=  ChartTable_Paint ;
            // 
            // ChartHeaderTable
            // 
            ChartHeaderTable.ColumnCount = 4;
            ChartHeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 30.1546383F ) );
            ChartHeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 69.84536F ) );
            ChartHeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 589F ) );
            ChartHeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 551F ) );
            ChartHeaderTable.Controls.Add( PictureBox, 0, 0 );
            ChartHeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            ChartHeaderTable.Location = new System.Drawing.Point( 0, 0 );
            ChartHeaderTable.Name = "ChartHeaderTable";
            ChartHeaderTable.RowCount = 1;
            ChartHeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ChartHeaderTable.Size = new System.Drawing.Size( 1338, 27 );
            ChartHeaderTable.TabIndex = 50;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.EPA;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 26, 16 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
            // 
            // ChartDataForm
            // 
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BorderThickness = 2;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            Controls.Add( SourcePanel );
            Controls.Add( ChartHeaderTable );
            Controls.Add( ChartTable );
            Controls.Add( ToolStrip );
            Controls.Add( TabControl );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "ChartDataForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            AreaTable.ResumeLayout( false );
            ChartPanel.ResumeLayout( false );
            ChartSubTablePanel.ResumeLayout( false );
            ChartSubTable.ResumeLayout( false );
            MetricsTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            FilterTabPage.ResumeLayout( false );
            ThirdTable.ResumeLayout( false );
            ThirdListBoxPanel.ResumeLayout( false );
            FirstTable.ResumeLayout( false );
            FirstListBoxPanel.ResumeLayout( false );
            SecondTable.ResumeLayout( false );
            SecondListBoxPanel.ResumeLayout( false );
            GroupTabPage.ResumeLayout( false );
            NumericTable.ResumeLayout( false );
            NumericPanel.ResumeLayout( false );
            FieldTable.ResumeLayout( false );
            FieldPanel.ResumeLayout( false );
            SourcePanel.ResumeLayout( false );
            TableListBoxPanel.ResumeLayout( false );
            ChartTable.ResumeLayout( false );
            ChartHeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        public System.Windows.Forms.TableLayoutPanel GridTable;
        public System.Windows.Forms.TableLayoutPanel LabelTable;
        public Label SecondDataLabel;
        public Label FourthDataLabel;
        public Label FirstDataLabel;
        public Label ThirdDataLabel;
        public ToolStrip ToolStrip;
        public ToolStripButton FirstButton;
        public ToolSeparator ChartTypeSeparator;
        public ToolStripTextBox ToolStripTextBox;
        public ToolSeparator TextBoxSeparator;
        public ToolSeparator FirstSeparator;
        public ToolStripButton PreviousButton;
        public ToolSeparator PreviousSeparator;
        public ToolStripButton NextButton;
        public ToolSeparator NextSeparator;
        public ToolStripButton LastButton;
        public ToolSeparator LastSeparator;
        public ToolStripButton RemoveFiltersButton;
        public ToolSeparator RemoveFiltersSeparator;
        public ToolSeparator RefreshDataSeparator;
        public ToolSeparator GroupSeparator;
        public ToolSeparator ExcelSeparator;
        public ToolSeparator EditSqlSeparator;
        public ToolStripDropDown DropDown;
        public ToolSeparator DropDownSeparator;
        public ToolStripButton MenuButton;
        public ToolSeparator MenuSeparator;
        public ToolStripButton ExitButton;
        public System.Windows.Forms.BindingSource BindingSource;
        private System.ComponentModel.IContainer components;
        public SmallTip ToolTip;
        public ContextMenu ContextMenu;

        #endregion Windows Form Designer generated code
        public ToolStripLabel ChartSeriesLabel;
        public ToolStripLabel ChartSpacerLabel;
        public ToolSeparator LabelSeparator;
        public ToolSeparator ExitSeparator;
        public ToolSeparator NavigationSeparator;
        public TabControl TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv GroupTabPage;
        public HeaderPanel FieldTable;
        public Layout FieldPanel;
        private Layout NumericPanel;
        public HeaderPanel NumericTable;
        public ListBox NumericListBox;
        public HeaderPanel ChartTable;
        public ListBox FieldListBox;
        private ToolSeparator FilterSeparator;
        public ToolStripButton GroupButton;
        public ToolStripButton RefreshDataButton;
        public Label FifthDataLabel;
        public Label SeventhDataLabel;
        public System.Windows.Forms.TableLayoutPanel MetricsTable;
        public ToolStripLabel StatusLabel;
        public ToolSeparator NavigationLabelSeparator;
        public ToolStripLabel FilterLabel;
        public ToolSeparator FilterLabelSeparator;
        public ToolStripLabel FunctionLabel;
        public ToolStripLabel ApplicationLabel;
        private System.Windows.Forms.TableLayoutPanel ChartHeaderTable;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.TableLayoutPanel AreaTable;
        public Layout ChartPanel;
        public Layout ChartSubTablePanel;
        public Label SqlTextLabel;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv TableTabPage;
        public HeaderPanel SourcePanel;
        public Layout TableListBoxPanel;
        public ListBox TableListBox;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv FilterTabPage;
        private HeaderPanel ThirdTable;
        private ComboBox ThirdComboBox;
        public Layout ThirdListBoxPanel;
        public ListBox ThirdListBox;
        public HeaderPanel FirstTable;
        public ComboBox FirstComboBox;
        public Layout FirstListBoxPanel;
        public ListBox FirstListBox;
        public HeaderPanel SecondTable;
        public Layout SecondListBoxPanel;
        public ListBox SecondListBox;
        public ComboBox SecondComboBox;
        public ToolStripLabel MetricsLabel;
        public ToolSeparator MetricsPreSeparator;
        public ToolStripDropDown MetricsComboBox;
        public ToolSeparator MetricsPostSeparator;
        public ToolSeparator ChartSeriesSeparator;
        public ToolStripDropDown ChartSeriesComboBox;
        private System.Windows.Forms.TableLayoutPanel ChartSubTable;
        public System.Windows.Forms.Timer Timer;
        public ToolSeparator StripSeparator;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
        public ToolSeparator ChartSpacer;
        public Chart Chart;
        public Label SixthDataLabel;
        public Label EighthDataLabel;
    }
}