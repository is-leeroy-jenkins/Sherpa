namespace BudgetExecution
{
    using System.Windows.Forms;

    using Syncfusion.Windows.Forms.Tools;

    partial class PivotDataForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PivotDataForm ) );
            ToolTip = new SmallTip( );
            PivotGridPanel = new Layout( );
            PivotChart = new Syncfusion.Windows.Forms.PivotChart.PivotChart( );
            PivotGridTable = new HeaderPanel( );
            ToolStrip = new ToolStrip( );
            BindingSource = new BindingSource( components );
            Separator = new ToolSeparator( );
            ProgressBar = new System.Windows.Forms.ToolStripProgressBar( );
            Separator1 = new ToolSeparator( );
            NavigationLabel = new ToolStripLabel( );
            Separator2 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            Separator3 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            LookupSeparator = new ToolSeparator( );
            LookupButton = new ToolStripButton( );
            FitlerSeparator = new ToolSeparator( );
            FilterButton = new ToolStripButton( );
            GroupSeparator = new ToolSeparator( );
            MenuSeparator = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            CloseSeparator = new ToolSeparator( );
            MainMenuButton = new ToolStripButton( );
            Separator6 = new ToolSeparator( );
            ContextMenu = new ContextMenu( );
            Timer = new Timer( components );
            Header = new TableLayoutPanel( );
            PictureBox = new PictureBox( );
            Title = new Label( );
            TabControl = new TabControl( );
            TableTabPage = new TabPageAdv( );
            SourceTable = new HeaderPanel( );
            TableComboBox = new ComboBox( );
            TablePanel = new Layout( );
            TableListBox = new ListBox( );
            FilterTabPage = new TabPageAdv( );
            FilterTable = new TableLayoutPanel( );
            SecondTable = new HeaderPanel( );
            SecondListBoxPanel = new Layout( );
            SecondListBox = new ListBox( );
            SecondComboBox = new ComboBox( );
            FirstTable = new HeaderPanel( );
            FirstComboBox = new ComboBox( );
            FirstListBoxPanel = new Layout( );
            FirstListBox = new ListBox( );
            ThirdTable = new HeaderPanel( );
            ThirdListBoxPanel = new Layout( );
            ThirdListBox = new ListBox( );
            ThirdComboBox = new ComboBox( );
            GroupTabPage = new TabPageAdv( );
            NumericTable = new HeaderPanel( );
            NumericPanel = new Layout( );
            NumericListBox = new ListBox( );
            FieldTable = new HeaderPanel( );
            FieldPanel = new Layout( );
            FieldListBox = new ListBox( );
            CalendarTabPage = new TabPageAdv( );
            TimeSpanTable = new TableLayoutPanel( );
            SecondCalendarTable = new HeaderPanel( );
            SecondCalendarPanel = new Layout( );
            SecondCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
            FirstCalendarTable = new HeaderPanel( );
            FirstCalendarPanel = new Layout( );
            FirstCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
            GroupButton = new ToolStripButton( );
            PivotGridPanel.SuspendLayout( );
            PivotGridTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            TableTabPage.SuspendLayout( );
            SourceTable.SuspendLayout( );
            TablePanel.SuspendLayout( );
            FilterTabPage.SuspendLayout( );
            FilterTable.SuspendLayout( );
            SecondTable.SuspendLayout( );
            SecondListBoxPanel.SuspendLayout( );
            FirstTable.SuspendLayout( );
            FirstListBoxPanel.SuspendLayout( );
            ThirdTable.SuspendLayout( );
            ThirdListBoxPanel.SuspendLayout( );
            GroupTabPage.SuspendLayout( );
            NumericTable.SuspendLayout( );
            NumericPanel.SuspendLayout( );
            FieldTable.SuspendLayout( );
            FieldPanel.SuspendLayout( );
            CalendarTabPage.SuspendLayout( );
            TimeSpanTable.SuspendLayout( );
            SecondCalendarTable.SuspendLayout( );
            SecondCalendarPanel.SuspendLayout( );
            FirstCalendarTable.SuspendLayout( );
            FirstCalendarPanel.SuspendLayout( );
            SuspendLayout( );
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
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // PivotGridPanel
            // 
            PivotGridPanel.BackColor = System.Drawing.Color.Transparent;
            PivotGridPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            PivotGridPanel.BindingSource = null;
            PivotGridPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            PivotGridPanel.BorderThickness = 1;
            PivotGridPanel.Children = null;
            PivotGridPanel.Controls.Add( PivotChart );
            PivotGridPanel.DataFilter = null;
            PivotGridPanel.Dock = DockStyle.Fill;
            PivotGridPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PivotGridPanel.ForeColor = System.Drawing.Color.Transparent;
            PivotGridPanel.HoverText = null;
            PivotGridPanel.IsDerivedStyle = true;
            PivotGridPanel.Location = new System.Drawing.Point( 4, 22 );
            PivotGridPanel.Margin = new Padding( 4, 3, 4, 3 );
            PivotGridPanel.Name = "PivotGridPanel";
            PivotGridPanel.Padding = new Padding( 1 );
            PivotGridPanel.Size = new System.Drawing.Size( 990, 573 );
            PivotGridPanel.Style = MetroSet_UI.Enums.Style.Custom;
            PivotGridPanel.StyleManager = null;
            PivotGridPanel.TabIndex = 12;
            PivotGridPanel.ThemeAuthor = "Terry D. Eppler";
            PivotGridPanel.ThemeName = "Budget Execution";
            PivotGridPanel.ToolTip = null;
            // 
            // PivotChart
            // 
            PivotChart.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            PivotChart.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
            PivotChart.CustomPalette = new System.Drawing.Color[ ]
    {
    System.Drawing.Color.FromArgb(147, 208, 249),
    System.Drawing.Color.FromArgb(102, 170, 225),
    System.Drawing.Color.FromArgb(250, 163, 94),
    System.Drawing.Color.FromArgb(252, 227, 127)
    };
            PivotChart.DeferLayoutUpdate = false;
            PivotChart.ForeColor = System.Drawing.Color.DarkGray;
            PivotChart.Location = new System.Drawing.Point( 21, 18 );
            PivotChart.Margin = new Padding( 4, 3, 4, 3 );
            PivotChart.MinimumSize = new System.Drawing.Size( 350, 250 );
            PivotChart.Name = "PivotChart";
            PivotChart.ShowPivotTableFieldList = false;
            PivotChart.Size = new System.Drawing.Size( 949, 544 );
            PivotChart.Skins = Syncfusion.Windows.Forms.Chart.Skins.Midnight;
            PivotChart.TabIndex = 0;
            PivotChart.Text = "PivotChart";
            PivotChart.UpdateManager = null;
            // 
            // PivotGridTable
            // 
            PivotGridTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            PivotGridTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            PivotGridTable.ColumnCount = 1;
            PivotGridTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            PivotGridTable.Controls.Add( PivotGridPanel, 0, 1 );
            PivotGridTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PivotGridTable.ForeColor = System.Drawing.Color.DarkGray;
            PivotGridTable.Location = new System.Drawing.Point( 21, 57 );
            PivotGridTable.Margin = new Padding( 4, 3, 4, 3 );
            PivotGridTable.Name = "PivotGridTable";
            PivotGridTable.RowCount = 2;
            PivotGridTable.RowStyles.Add( new RowStyle( SizeType.Percent, 3.17725754F ) );
            PivotGridTable.RowStyles.Add( new RowStyle( SizeType.Percent, 96.82275F ) );
            PivotGridTable.Size = new System.Drawing.Size( 998, 598 );
            PivotGridTable.TabIndex = 13;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton = null;
            ToolStrip.AddColumnButton = null;
            ToolStrip.AddTableButton = null;
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BorderStyle = ToolStripBorderStyle.StaticEdge;
            ToolStrip.CalculatorButton = null;
            ToolStrip.CanOverrideStyle = true;
            ToolStrip.CaptionAlignment = CaptionAlignment.Near;
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.CaptionStyle = CaptionStyle.Top;
            ToolStrip.CaptionTextStyle = CaptionTextStyle.Plain;
            ToolStrip.ChartButton = null;
            ToolStrip.DataFilter = null;
            ToolStrip.DeleteButton = null;
            ToolStrip.DeleteColumnButton = null;
            ToolStrip.DeleteRecordButton = null;
            ToolStrip.DeleteTableButton = null;
            ToolStrip.Dock = DockStyle.Bottom;
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
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new ToolStripItem[ ] { Separator, ProgressBar, Separator1, NavigationLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator4, NextButton, Separator5, LastButton, LookupSeparator, LookupButton, FitlerSeparator, FilterButton, GroupSeparator, MenuSeparator, CloseButton, CloseSeparator, MainMenuButton, Separator6 } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 682 );
            ToolStrip.Margin = new Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            ToolStrip.Padding = new Padding( 1 );
            ToolStrip.PreviousButton = null;
            ToolStrip.ProgressBar = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SaveButton = null;
            ToolStrip.SearchCriteriaLabel = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1338, 56 );
            ToolStrip.TabIndex = 14;
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
            ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
            // 
            // Separator
            // 
            Separator.ForeColor = System.Drawing.Color.Black;
            Separator.Margin = new Padding( 5, 1, 5, 1 );
            Separator.Name = "Separator";
            Separator.Padding = new Padding( 1 );
            Separator.Size = new System.Drawing.Size( 6, 38 );
            // 
            // ProgressBar
            // 
            ProgressBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new System.Drawing.Size( 200, 37 );
            ProgressBar.Value = 50;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 38 );
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
            NavigationLabel.Margin = new Padding( 5, 1, 5, 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new Padding( 1 );
            NavigationLabel.Size = new System.Drawing.Size( 65, 38 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "        Navigation";
            NavigationLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new Padding( 5, 1, 5, 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 38 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.Transparent;
            FirstButton.BindingSource = BindingSource;
            FirstButton.DataFilter = null;
            FirstButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = null;
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new Padding( 5, 3, 5, 3 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 34 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = null;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new Padding( 5, 1, 5, 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 38 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DataFilter = null;
            PreviousButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = null;
            PreviousButton.Image = Resources.Images.PreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new Padding( 5, 3, 5, 3 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 34 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = null;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new Padding( 5, 1, 5, 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 38 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.BindingSource = BindingSource;
            NextButton.DataFilter = null;
            NextButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = null;
            NextButton.Image = Resources.Images.NextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new Padding( 5, 3, 5, 3 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 34 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new Padding( 5, 1, 5, 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 38 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.Transparent;
            LastButton.BindingSource = BindingSource;
            LastButton.DataFilter = null;
            LastButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = null;
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new Padding( 5, 3, 5, 3 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 34 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = null;
            LastButton.ToolType = ToolType.LastButton;
            // 
            // LookupSeparator
            // 
            LookupSeparator.ForeColor = System.Drawing.Color.Black;
            LookupSeparator.Margin = new Padding( 5, 1, 5, 1 );
            LookupSeparator.Name = "LookupSeparator";
            LookupSeparator.Padding = new Padding( 1 );
            LookupSeparator.Size = new System.Drawing.Size( 6, 38 );
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip = false;
            LookupButton.BackColor = System.Drawing.Color.Transparent;
            LookupButton.BindingSource = null;
            LookupButton.DataFilter = null;
            LookupButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LookupButton.Field = Field.AccountCode;
            LookupButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LookupButton.ForeColor = System.Drawing.Color.LightGray;
            LookupButton.HoverText = null;
            LookupButton.Image = Resources.Images.DataSearchButton;
            LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LookupButton.Margin = new Padding( 5, 3, 5, 3 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new Padding( 1 );
            LookupButton.Size = new System.Drawing.Size( 23, 34 );
            LookupButton.Text = "toolStripButton1";
            LookupButton.ToolTip = null;
            LookupButton.ToolType = ToolType.Ns;
            // 
            // FitlerSeparator
            // 
            FitlerSeparator.ForeColor = System.Drawing.Color.Black;
            FitlerSeparator.Margin = new Padding( 5, 1, 5, 1 );
            FitlerSeparator.Name = "FitlerSeparator";
            FitlerSeparator.Padding = new Padding( 1 );
            FitlerSeparator.Size = new System.Drawing.Size( 6, 38 );
            // 
            // FilterButton
            // 
            FilterButton.AutoToolTip = false;
            FilterButton.BackColor = System.Drawing.Color.Transparent;
            FilterButton.BindingSource = null;
            FilterButton.DataFilter = null;
            FilterButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FilterButton.Field = Field.AccountCode;
            FilterButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FilterButton.ForeColor = System.Drawing.Color.LightGray;
            FilterButton.HoverText = null;
            FilterButton.Image = Resources.Images.FilterButton;
            FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FilterButton.Margin = new Padding( 5, 3, 5, 3 );
            FilterButton.Name = "FilterButton";
            FilterButton.Padding = new Padding( 1 );
            FilterButton.Size = new System.Drawing.Size( 23, 34 );
            FilterButton.Text = "toolStripButton1";
            FilterButton.ToolTip = null;
            FilterButton.ToolType = ToolType.Ns;
            // 
            // GroupSeparator
            // 
            GroupSeparator.ForeColor = System.Drawing.Color.Black;
            GroupSeparator.Margin = new Padding( 5, 1, 5, 1 );
            GroupSeparator.Name = "GroupSeparator";
            GroupSeparator.Padding = new Padding( 1 );
            GroupSeparator.Size = new System.Drawing.Size( 6, 38 );
            // 
            // MenuSeparator
            // 
            MenuSeparator.Alignment = ToolStripItemAlignment.Right;
            MenuSeparator.ForeColor = System.Drawing.Color.Black;
            MenuSeparator.Margin = new Padding( 5, 1, 5, 1 );
            MenuSeparator.Name = "MenuSeparator";
            MenuSeparator.Padding = new Padding( 1 );
            MenuSeparator.Size = new System.Drawing.Size( 6, 38 );
            // 
            // CloseButton
            // 
            CloseButton.Alignment = ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = null;
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new Padding( 5, 3, 5, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 34 );
            CloseButton.Text = "toolStripButton1";
            CloseButton.ToolTip = null;
            CloseButton.ToolType = ToolType.Ns;
            // 
            // CloseSeparator
            // 
            CloseSeparator.Alignment = ToolStripItemAlignment.Right;
            CloseSeparator.ForeColor = System.Drawing.Color.Black;
            CloseSeparator.Margin = new Padding( 5, 1, 5, 1 );
            CloseSeparator.Name = "CloseSeparator";
            CloseSeparator.Padding = new Padding( 1 );
            CloseSeparator.Size = new System.Drawing.Size( 6, 38 );
            // 
            // MainMenuButton
            // 
            MainMenuButton.Alignment = ToolStripItemAlignment.Right;
            MainMenuButton.AutoToolTip = false;
            MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            MainMenuButton.BindingSource = null;
            MainMenuButton.DataFilter = null;
            MainMenuButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            MainMenuButton.Field = Field.AccountCode;
            MainMenuButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MainMenuButton.ForeColor = System.Drawing.Color.LightGray;
            MainMenuButton.HoverText = null;
            MainMenuButton.Image = Resources.Images.WebMenuButton;
            MainMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MainMenuButton.Margin = new Padding( 5, 3, 5, 3 );
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Padding = new Padding( 1 );
            MainMenuButton.Size = new System.Drawing.Size( 23, 34 );
            MainMenuButton.Text = "toolStripButton1";
            MainMenuButton.ToolTip = null;
            MainMenuButton.ToolType = ToolType.Ns;
            // 
            // Separator6
            // 
            Separator6.Alignment = ToolStripItemAlignment.Right;
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new Padding( 5, 1, 5, 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 38 );
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 156, 264 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // Header
            // 
            Header.ColumnCount = 2;
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 3.51270556F ) );
            Header.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 96.4873F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Controls.Add( Title, 1, 0 );
            Header.Dock = DockStyle.Top;
            Header.Location = new System.Drawing.Point( 0, 0 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 1338, 32 );
            Header.TabIndex = 15;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.EPA;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 40, 20 );
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = BindingSource;
            Title.DataFilter = null;
            Title.Dock = DockStyle.Fill;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 50, 3 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new System.Drawing.Size( 1285, 26 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = ToolTip;
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 309, 618 );
            TabControl.BindingSource = null;
            TabControl.BorderStyle = BorderStyle.None;
            TabControl.BorderWidth = 1;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( TableTabPage );
            TabControl.Controls.Add( FilterTabPage );
            TabControl.Controls.Add( GroupTabPage );
            TabControl.Controls.Add( CalendarTabPage );
            TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.ForeColor = System.Drawing.Color.LightGray;
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 100, 10 );
            TabControl.Location = new System.Drawing.Point( 1026, 45 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 309, 618 );
            TabControl.TabIndex = 45;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ToolTip = ToolTip;
            // 
            // TableTabPage
            // 
            TableTabPage.Controls.Add( SourceTable );
            TableTabPage.Image = null;
            TableTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            TableTabPage.Location = new System.Drawing.Point( 0, 9 );
            TableTabPage.Name = "TableTabPage";
            TableTabPage.ShowCloseButton = true;
            TableTabPage.Size = new System.Drawing.Size( 309, 609 );
            TableTabPage.TabIndex = 5;
            TableTabPage.ThemesEnabled = false;
            // 
            // SourceTable
            // 
            SourceTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SourceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourceTable.CaptionText = "Data Tables";
            SourceTable.ColumnCount = 1;
            SourceTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            SourceTable.Controls.Add( TableComboBox, 0, 0 );
            SourceTable.Controls.Add( TablePanel, 0, 1 );
            SourceTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SourceTable.ForeColor = System.Drawing.Color.DarkGray;
            SourceTable.Location = new System.Drawing.Point( 3, 3 );
            SourceTable.Name = "SourceTable";
            SourceTable.RowCount = 2;
            SourceTable.RowStyles.Add( new RowStyle( SizeType.Percent, 6.47986F ) );
            SourceTable.RowStyles.Add( new RowStyle( SizeType.Percent, 93.52014F ) );
            SourceTable.Size = new System.Drawing.Size( 283, 603 );
            SourceTable.TabIndex = 54;
            // 
            // TableComboBox
            // 
            TableComboBox.AllowDrop = true;
            TableComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableComboBox.BackColor = System.Drawing.Color.Transparent;
            TableComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            TableComboBox.BindingSource = null;
            TableComboBox.BorderColor = System.Drawing.Color.FromArgb( 75, 75, 75 );
            TableComboBox.CausesValidation = false;
            TableComboBox.DataFilter = null;
            TableComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            TableComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            TableComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            TableComboBox.Dock = DockStyle.Fill;
            TableComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            TableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TableComboBox.FlatStyle = FlatStyle.Flat;
            TableComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TableComboBox.FormattingEnabled = true;
            TableComboBox.HoverText = null;
            TableComboBox.IsDerivedStyle = true;
            TableComboBox.ItemHeight = 24;
            TableComboBox.Items.AddRange( new object[ ] { "Execution", "Reference", "Maintenance" } );
            TableComboBox.Location = new System.Drawing.Point( 3, 19 );
            TableComboBox.Name = "TableComboBox";
            TableComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            TableComboBox.Size = new System.Drawing.Size( 277, 30 );
            TableComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableComboBox.StyleManager = null;
            TableComboBox.TabIndex = 1;
            TableComboBox.ThemeAuthor = "Terry D. Eppler";
            TableComboBox.ThemeName = "Budget Execution";
            TableComboBox.ToolTip = ToolTip;
            // 
            // TablePanel
            // 
            TablePanel.BackColor = System.Drawing.Color.Transparent;
            TablePanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TablePanel.BindingSource = null;
            TablePanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TablePanel.BorderThickness = 1;
            TablePanel.Children = null;
            TablePanel.Controls.Add( TableListBox );
            TablePanel.DataFilter = null;
            TablePanel.Dock = DockStyle.Fill;
            TablePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TablePanel.ForeColor = System.Drawing.Color.Transparent;
            TablePanel.HoverText = null;
            TablePanel.IsDerivedStyle = true;
            TablePanel.Location = new System.Drawing.Point( 3, 57 );
            TablePanel.Name = "TablePanel";
            TablePanel.Padding = new Padding( 1 );
            TablePanel.Size = new System.Drawing.Size( 277, 543 );
            TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            TablePanel.StyleManager = null;
            TablePanel.TabIndex = 0;
            TablePanel.ThemeAuthor = "Terry D. Eppler";
            TablePanel.ThemeName = "Budget Execution";
            TablePanel.ToolTip = null;
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
            TableListBox.Location = new System.Drawing.Point( 22, 23 );
            TableListBox.Margin = new Padding( 1 );
            TableListBox.MultiSelect = false;
            TableListBox.Name = "TableListBox";
            TableListBox.Padding = new Padding( 1 );
            TableListBox.SelectedIndex = -1;
            TableListBox.SelectedItem = null;
            TableListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableListBox.SelectedItemColor = System.Drawing.Color.White;
            TableListBox.SelectedText = null;
            TableListBox.SelectedValue = null;
            TableListBox.ShowBorder = false;
            TableListBox.ShowScrollBar = true;
            TableListBox.Size = new System.Drawing.Size( 231, 482 );
            TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBox.StyleManager = null;
            TableListBox.TabIndex = 0;
            TableListBox.ThemeAuthor = "Terry D. Eppler";
            TableListBox.ThemeName = "Budget Execution";
            TableListBox.ToolTip = null;
            // 
            // FilterTabPage
            // 
            FilterTabPage.Controls.Add( FilterTable );
            FilterTabPage.Image = null;
            FilterTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            FilterTabPage.Location = new System.Drawing.Point( 0, 9 );
            FilterTabPage.Name = "FilterTabPage";
            FilterTabPage.ShowCloseButton = true;
            FilterTabPage.Size = new System.Drawing.Size( 309, 609 );
            FilterTabPage.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FilterTabPage.TabFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FilterTabPage.TabForeColor = System.Drawing.Color.DarkGray;
            FilterTabPage.TabIndex = 1;
            FilterTabPage.ThemesEnabled = false;
            // 
            // FilterTable
            // 
            FilterTable.ColumnCount = 1;
            FilterTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            FilterTable.Controls.Add( SecondTable, 0, 1 );
            FilterTable.Controls.Add( FirstTable, 0, 0 );
            FilterTable.Controls.Add( ThirdTable, 0, 2 );
            FilterTable.Dock = DockStyle.Top;
            FilterTable.Location = new System.Drawing.Point( 0, 0 );
            FilterTable.Name = "FilterTable";
            FilterTable.RowCount = 3;
            FilterTable.RowStyles.Add( new RowStyle( SizeType.Percent, 33.66337F ) );
            FilterTable.RowStyles.Add( new RowStyle( SizeType.Percent, 30.69307F ) );
            FilterTable.RowStyles.Add( new RowStyle( SizeType.Percent, 35.4785461F ) );
            FilterTable.Size = new System.Drawing.Size( 309, 606 );
            FilterTable.TabIndex = 46;
            // 
            // SecondTable
            // 
            SecondTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SecondTable.CaptionText = "Second Filter";
            SecondTable.ColumnCount = 1;
            SecondTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            SecondTable.Controls.Add( SecondListBoxPanel, 0, 1 );
            SecondTable.Controls.Add( SecondComboBox, 0, 0 );
            SecondTable.Dock = DockStyle.Fill;
            SecondTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondTable.ForeColor = System.Drawing.Color.DarkGray;
            SecondTable.Location = new System.Drawing.Point( 3, 207 );
            SecondTable.Name = "SecondTable";
            SecondTable.RowCount = 2;
            SecondTable.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            SecondTable.RowStyles.Add( new RowStyle( ) );
            SecondTable.Size = new System.Drawing.Size( 303, 180 );
            SecondTable.TabIndex = 1;
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
            SecondListBoxPanel.Dock = DockStyle.Fill;
            SecondListBoxPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            SecondListBoxPanel.HoverText = null;
            SecondListBoxPanel.IsDerivedStyle = true;
            SecondListBoxPanel.Location = new System.Drawing.Point( 3, 52 );
            SecondListBoxPanel.Name = "SecondListBoxPanel";
            SecondListBoxPanel.Padding = new Padding( 1 );
            SecondListBoxPanel.Size = new System.Drawing.Size( 297, 125 );
            SecondListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondListBoxPanel.StyleManager = null;
            SecondListBoxPanel.TabIndex = 27;
            SecondListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            SecondListBoxPanel.ThemeName = "BudgetExecution";
            SecondListBoxPanel.ToolTip = null;
            // 
            // SecondListBox
            // 
            SecondListBox.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            SecondListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SecondListBox.BindingSource = null;
            SecondListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            SecondListBox.DataFilter = null;
            SecondListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SecondListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            SecondListBox.HoverText = null;
            SecondListBox.IsDerivedStyle = true;
            SecondListBox.ItemHeight = 28;
            SecondListBox.Location = new System.Drawing.Point( 23, 18 );
            SecondListBox.Margin = new Padding( 1 );
            SecondListBox.MultiSelect = false;
            SecondListBox.Name = "SecondListBox";
            SecondListBox.Padding = new Padding( 1 );
            SecondListBox.SelectedIndex = -1;
            SecondListBox.SelectedItem = null;
            SecondListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondListBox.SelectedItemColor = System.Drawing.Color.White;
            SecondListBox.SelectedText = null;
            SecondListBox.SelectedValue = null;
            SecondListBox.ShowBorder = false;
            SecondListBox.ShowScrollBar = false;
            SecondListBox.Size = new System.Drawing.Size( 249, 90 );
            SecondListBox.Style = MetroSet_UI.Enums.Style.Custom;
            SecondListBox.StyleManager = null;
            SecondListBox.TabIndex = 0;
            SecondListBox.ThemeAuthor = "Terry D. Eppler";
            SecondListBox.ThemeName = "BudgetExecution";
            SecondListBox.ToolTip = null;
            // 
            // SecondComboBox
            // 
            SecondComboBox.AllowDrop = true;
            SecondComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondComboBox.BackColor = System.Drawing.Color.Transparent;
            SecondComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SecondComboBox.BindingSource = null;
            SecondComboBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            SecondComboBox.CausesValidation = false;
            SecondComboBox.DataFilter = null;
            SecondComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            SecondComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            SecondComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            SecondComboBox.Dock = DockStyle.Fill;
            SecondComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            SecondComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SecondComboBox.FlatStyle = FlatStyle.Flat;
            SecondComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondComboBox.FormattingEnabled = true;
            SecondComboBox.HoverText = null;
            SecondComboBox.IsDerivedStyle = true;
            SecondComboBox.ItemHeight = 24;
            SecondComboBox.Location = new System.Drawing.Point( 3, 19 );
            SecondComboBox.Name = "SecondComboBox";
            SecondComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            SecondComboBox.Size = new System.Drawing.Size( 297, 30 );
            SecondComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            SecondComboBox.StyleManager = null;
            SecondComboBox.TabIndex = 5;
            SecondComboBox.ThemeAuthor = "Terry D. Eppler";
            SecondComboBox.ThemeName = "Budget Execution";
            SecondComboBox.ToolTip = null;
            // 
            // FirstTable
            // 
            FirstTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FirstTable.CaptionText = "First Filter";
            FirstTable.ColumnCount = 1;
            FirstTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            FirstTable.Controls.Add( FirstComboBox, 0, 0 );
            FirstTable.Controls.Add( FirstListBoxPanel, 0, 1 );
            FirstTable.Dock = DockStyle.Fill;
            FirstTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstTable.ForeColor = System.Drawing.Color.DarkGray;
            FirstTable.Location = new System.Drawing.Point( 3, 3 );
            FirstTable.Name = "FirstTable";
            FirstTable.RowCount = 2;
            FirstTable.RowStyles.Add( new RowStyle( SizeType.Percent, 23.0769234F ) );
            FirstTable.RowStyles.Add( new RowStyle( SizeType.Percent, 76.92308F ) );
            FirstTable.Size = new System.Drawing.Size( 303, 198 );
            FirstTable.TabIndex = 1;
            // 
            // FirstComboBox
            // 
            FirstComboBox.AllowDrop = true;
            FirstComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstComboBox.BackColor = System.Drawing.Color.Transparent;
            FirstComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            FirstComboBox.BindingSource = null;
            FirstComboBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            FirstComboBox.CausesValidation = false;
            FirstComboBox.DataFilter = null;
            FirstComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            FirstComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            FirstComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            FirstComboBox.Dock = DockStyle.Fill;
            FirstComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            FirstComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FirstComboBox.FlatStyle = FlatStyle.Flat;
            FirstComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstComboBox.FormattingEnabled = true;
            FirstComboBox.HoverText = null;
            FirstComboBox.IsDerivedStyle = true;
            FirstComboBox.ItemHeight = 24;
            FirstComboBox.Location = new System.Drawing.Point( 3, 19 );
            FirstComboBox.Name = "FirstComboBox";
            FirstComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            FirstComboBox.Size = new System.Drawing.Size( 297, 30 );
            FirstComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            FirstComboBox.StyleManager = null;
            FirstComboBox.TabIndex = 4;
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
            FirstListBoxPanel.Dock = DockStyle.Fill;
            FirstListBoxPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            FirstListBoxPanel.HoverText = null;
            FirstListBoxPanel.IsDerivedStyle = true;
            FirstListBoxPanel.Location = new System.Drawing.Point( 3, 61 );
            FirstListBoxPanel.Name = "FirstListBoxPanel";
            FirstListBoxPanel.Padding = new Padding( 1 );
            FirstListBoxPanel.Size = new System.Drawing.Size( 297, 134 );
            FirstListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            FirstListBoxPanel.StyleManager = null;
            FirstListBoxPanel.TabIndex = 26;
            FirstListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            FirstListBoxPanel.ThemeName = "BudgetExecution";
            FirstListBoxPanel.ToolTip = null;
            // 
            // FirstListBox
            // 
            FirstListBox.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            FirstListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            FirstListBox.BindingSource = null;
            FirstListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            FirstListBox.DataFilter = null;
            FirstListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            FirstListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            FirstListBox.HoverText = null;
            FirstListBox.IsDerivedStyle = true;
            FirstListBox.ItemHeight = 28;
            FirstListBox.Location = new System.Drawing.Point( 20, 21 );
            FirstListBox.Margin = new Padding( 1 );
            FirstListBox.MultiSelect = false;
            FirstListBox.Name = "FirstListBox";
            FirstListBox.Padding = new Padding( 1 );
            FirstListBox.SelectedIndex = -1;
            FirstListBox.SelectedItem = null;
            FirstListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstListBox.SelectedItemColor = System.Drawing.Color.White;
            FirstListBox.SelectedText = null;
            FirstListBox.SelectedValue = null;
            FirstListBox.ShowBorder = false;
            FirstListBox.ShowScrollBar = false;
            FirstListBox.Size = new System.Drawing.Size( 252, 100 );
            FirstListBox.Style = MetroSet_UI.Enums.Style.Custom;
            FirstListBox.StyleManager = null;
            FirstListBox.TabIndex = 0;
            FirstListBox.ThemeAuthor = "Terry D. Eppler";
            FirstListBox.ThemeName = "BudgetExecution";
            FirstListBox.ToolTip = null;
            // 
            // ThirdTable
            // 
            ThirdTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ThirdTable.CaptionText = "Third Filter";
            ThirdTable.ColumnCount = 1;
            ThirdTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            ThirdTable.Controls.Add( ThirdListBoxPanel, 0, 1 );
            ThirdTable.Controls.Add( ThirdComboBox, 0, 0 );
            ThirdTable.Dock = DockStyle.Fill;
            ThirdTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdTable.ForeColor = System.Drawing.Color.DarkGray;
            ThirdTable.Location = new System.Drawing.Point( 3, 393 );
            ThirdTable.Name = "ThirdTable";
            ThirdTable.RowCount = 2;
            ThirdTable.RowStyles.Add( new RowStyle( SizeType.Percent, 18.666666F ) );
            ThirdTable.RowStyles.Add( new RowStyle( SizeType.Percent, 81.3333359F ) );
            ThirdTable.Size = new System.Drawing.Size( 303, 210 );
            ThirdTable.TabIndex = 1;
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
            ThirdListBoxPanel.Dock = DockStyle.Fill;
            ThirdListBoxPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            ThirdListBoxPanel.HoverText = null;
            ThirdListBoxPanel.IsDerivedStyle = true;
            ThirdListBoxPanel.Location = new System.Drawing.Point( 3, 55 );
            ThirdListBoxPanel.Name = "ThirdListBoxPanel";
            ThirdListBoxPanel.Padding = new Padding( 1 );
            ThirdListBoxPanel.Size = new System.Drawing.Size( 297, 152 );
            ThirdListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdListBoxPanel.StyleManager = null;
            ThirdListBoxPanel.TabIndex = 28;
            ThirdListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            ThirdListBoxPanel.ThemeName = "BudgetExecution";
            ThirdListBoxPanel.ToolTip = null;
            // 
            // ThirdListBox
            // 
            ThirdListBox.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            ThirdListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ThirdListBox.BindingSource = null;
            ThirdListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            ThirdListBox.DataFilter = null;
            ThirdListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ThirdListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ThirdListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ThirdListBox.HoverText = null;
            ThirdListBox.IsDerivedStyle = true;
            ThirdListBox.ItemHeight = 28;
            ThirdListBox.Location = new System.Drawing.Point( 20, 25 );
            ThirdListBox.Margin = new Padding( 1 );
            ThirdListBox.MultiSelect = false;
            ThirdListBox.Name = "ThirdListBox";
            ThirdListBox.Padding = new Padding( 1 );
            ThirdListBox.SelectedIndex = -1;
            ThirdListBox.SelectedItem = null;
            ThirdListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ThirdListBox.SelectedItemColor = System.Drawing.Color.White;
            ThirdListBox.SelectedText = null;
            ThirdListBox.SelectedValue = null;
            ThirdListBox.ShowBorder = false;
            ThirdListBox.ShowScrollBar = false;
            ThirdListBox.Size = new System.Drawing.Size( 252, 114 );
            ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdListBox.StyleManager = null;
            ThirdListBox.TabIndex = 0;
            ThirdListBox.ThemeAuthor = "Terry D. Eppler";
            ThirdListBox.ThemeName = "BudgetExecution";
            ThirdListBox.ToolTip = null;
            // 
            // ThirdComboBox
            // 
            ThirdComboBox.AllowDrop = true;
            ThirdComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ThirdComboBox.BackColor = System.Drawing.Color.Transparent;
            ThirdComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ThirdComboBox.BindingSource = null;
            ThirdComboBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ThirdComboBox.CausesValidation = false;
            ThirdComboBox.DataFilter = null;
            ThirdComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            ThirdComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            ThirdComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            ThirdComboBox.Dock = DockStyle.Fill;
            ThirdComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ThirdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ThirdComboBox.FlatStyle = FlatStyle.Flat;
            ThirdComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ThirdComboBox.FormattingEnabled = true;
            ThirdComboBox.HoverText = null;
            ThirdComboBox.IsDerivedStyle = true;
            ThirdComboBox.ItemHeight = 24;
            ThirdComboBox.Location = new System.Drawing.Point( 3, 19 );
            ThirdComboBox.Name = "ThirdComboBox";
            ThirdComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ThirdComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            ThirdComboBox.Size = new System.Drawing.Size( 297, 30 );
            ThirdComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            ThirdComboBox.StyleManager = null;
            ThirdComboBox.TabIndex = 5;
            ThirdComboBox.ThemeAuthor = "Terry D. Eppler";
            ThirdComboBox.ThemeName = "Budget Execution";
            ThirdComboBox.ToolTip = null;
            // 
            // GroupTabPage
            // 
            GroupTabPage.Controls.Add( NumericTable );
            GroupTabPage.Controls.Add( FieldTable );
            GroupTabPage.Image = null;
            GroupTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            GroupTabPage.Location = new System.Drawing.Point( 0, 9 );
            GroupTabPage.Name = "GroupTabPage";
            GroupTabPage.ShowCloseButton = true;
            GroupTabPage.Size = new System.Drawing.Size( 309, 609 );
            GroupTabPage.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            GroupTabPage.TabFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GroupTabPage.TabForeColor = System.Drawing.Color.DarkGray;
            GroupTabPage.TabIndex = 2;
            GroupTabPage.ThemesEnabled = false;
            // 
            // NumericTable
            // 
            NumericTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            NumericTable.CaptionText = "Numeric Fields";
            NumericTable.ColumnCount = 1;
            NumericTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            NumericTable.Controls.Add( NumericPanel, 0, 1 );
            NumericTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NumericTable.ForeColor = System.Drawing.Color.DarkGray;
            NumericTable.Location = new System.Drawing.Point( 15, 295 );
            NumericTable.Name = "NumericTable";
            NumericTable.RowCount = 2;
            NumericTable.RowStyles.Add( new RowStyle( SizeType.Percent, 2.71186447F ) );
            NumericTable.RowStyles.Add( new RowStyle( SizeType.Percent, 97.28814F ) );
            NumericTable.Size = new System.Drawing.Size( 275, 311 );
            NumericTable.TabIndex = 2;
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
            NumericPanel.Dock = DockStyle.Fill;
            NumericPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NumericPanel.ForeColor = System.Drawing.Color.Transparent;
            NumericPanel.HoverText = null;
            NumericPanel.IsDerivedStyle = true;
            NumericPanel.Location = new System.Drawing.Point( 3, 27 );
            NumericPanel.Name = "NumericPanel";
            NumericPanel.Padding = new Padding( 1 );
            NumericPanel.Size = new System.Drawing.Size( 269, 281 );
            NumericPanel.Style = MetroSet_UI.Enums.Style.Custom;
            NumericPanel.StyleManager = null;
            NumericPanel.TabIndex = 6;
            NumericPanel.ThemeAuthor = "Terry D. Eppler";
            NumericPanel.ThemeName = "BudgetExecution";
            NumericPanel.ToolTip = null;
            // 
            // NumericListBox
            // 
            NumericListBox.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            NumericListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            NumericListBox.BindingSource = null;
            NumericListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            NumericListBox.DataFilter = null;
            NumericListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            NumericListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NumericListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            NumericListBox.HoveredItemColor = System.Drawing.Color.White;
            NumericListBox.HoverText = null;
            NumericListBox.IsDerivedStyle = true;
            NumericListBox.ItemHeight = 28;
            NumericListBox.Location = new System.Drawing.Point( 18, 22 );
            NumericListBox.Margin = new Padding( 1 );
            NumericListBox.MultiSelect = true;
            NumericListBox.Name = "NumericListBox";
            NumericListBox.Padding = new Padding( 1 );
            NumericListBox.SelectedIndex = -1;
            NumericListBox.SelectedItem = null;
            NumericListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            NumericListBox.SelectedItemColor = System.Drawing.Color.White;
            NumericListBox.SelectedText = null;
            NumericListBox.SelectedValue = null;
            NumericListBox.ShowBorder = false;
            NumericListBox.ShowScrollBar = false;
            NumericListBox.Size = new System.Drawing.Size( 233, 243 );
            NumericListBox.Style = MetroSet_UI.Enums.Style.Custom;
            NumericListBox.StyleManager = null;
            NumericListBox.TabIndex = 1;
            NumericListBox.ThemeAuthor = "Terry D. Eppler";
            NumericListBox.ThemeName = "Budget Execution";
            NumericListBox.ToolTip = null;
            // 
            // FieldTable
            // 
            FieldTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FieldTable.CaptionText = "Text Fields";
            FieldTable.ColumnCount = 1;
            FieldTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            FieldTable.Controls.Add( FieldPanel, 0, 1 );
            FieldTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FieldTable.ForeColor = System.Drawing.Color.DarkGray;
            FieldTable.Location = new System.Drawing.Point( 13, 0 );
            FieldTable.Name = "FieldTable";
            FieldTable.RowCount = 2;
            FieldTable.RowStyles.Add( new RowStyle( SizeType.Percent, 3.488372F ) );
            FieldTable.RowStyles.Add( new RowStyle( SizeType.Percent, 96.51163F ) );
            FieldTable.Size = new System.Drawing.Size( 280, 274 );
            FieldTable.TabIndex = 1;
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
            FieldPanel.Dock = DockStyle.Fill;
            FieldPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FieldPanel.ForeColor = System.Drawing.Color.Transparent;
            FieldPanel.HoverText = null;
            FieldPanel.IsDerivedStyle = true;
            FieldPanel.Location = new System.Drawing.Point( 3, 28 );
            FieldPanel.Name = "FieldPanel";
            FieldPanel.Padding = new Padding( 1 );
            FieldPanel.Size = new System.Drawing.Size( 274, 243 );
            FieldPanel.Style = MetroSet_UI.Enums.Style.Custom;
            FieldPanel.StyleManager = null;
            FieldPanel.TabIndex = 4;
            FieldPanel.ThemeAuthor = "Terry D. Eppler";
            FieldPanel.ThemeName = "BudgetExecution";
            FieldPanel.ToolTip = null;
            // 
            // FieldListBox
            // 
            FieldListBox.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            FieldListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            FieldListBox.BindingSource = null;
            FieldListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            FieldListBox.DataFilter = null;
            FieldListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FieldListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FieldListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            FieldListBox.HoveredItemColor = System.Drawing.Color.White;
            FieldListBox.HoverText = null;
            FieldListBox.IsDerivedStyle = true;
            FieldListBox.ItemHeight = 28;
            FieldListBox.Location = new System.Drawing.Point( 20, 21 );
            FieldListBox.Margin = new Padding( 1 );
            FieldListBox.MultiSelect = true;
            FieldListBox.Name = "FieldListBox";
            FieldListBox.Padding = new Padding( 1 );
            FieldListBox.SelectedIndex = -1;
            FieldListBox.SelectedItem = null;
            FieldListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FieldListBox.SelectedItemColor = System.Drawing.Color.White;
            FieldListBox.SelectedText = null;
            FieldListBox.SelectedValue = null;
            FieldListBox.ShowBorder = false;
            FieldListBox.ShowScrollBar = false;
            FieldListBox.Size = new System.Drawing.Size( 233, 205 );
            FieldListBox.Style = MetroSet_UI.Enums.Style.Custom;
            FieldListBox.StyleManager = null;
            FieldListBox.TabIndex = 1;
            FieldListBox.ThemeAuthor = "Terry D. Eppler";
            FieldListBox.ThemeName = "Budget Execution";
            FieldListBox.ToolTip = null;
            // 
            // CalendarTabPage
            // 
            CalendarTabPage.Controls.Add( TimeSpanTable );
            CalendarTabPage.Image = null;
            CalendarTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            CalendarTabPage.Location = new System.Drawing.Point( 0, 9 );
            CalendarTabPage.Name = "CalendarTabPage";
            CalendarTabPage.ShowCloseButton = true;
            CalendarTabPage.Size = new System.Drawing.Size( 309, 609 );
            CalendarTabPage.TabIndex = 4;
            CalendarTabPage.ThemesEnabled = false;
            // 
            // TimeSpanTable
            // 
            TimeSpanTable.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            TimeSpanTable.ColumnCount = 1;
            TimeSpanTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            TimeSpanTable.Controls.Add( SecondCalendarTable, 0, 1 );
            TimeSpanTable.Controls.Add( FirstCalendarTable, 0, 0 );
            TimeSpanTable.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TimeSpanTable.Location = new System.Drawing.Point( 13, 3 );
            TimeSpanTable.Name = "TimeSpanTable";
            TimeSpanTable.RowCount = 2;
            TimeSpanTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            TimeSpanTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            TimeSpanTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            TimeSpanTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 20F ) );
            TimeSpanTable.Size = new System.Drawing.Size( 392, 1133 );
            TimeSpanTable.TabIndex = 0;
            // 
            // SecondCalendarTable
            // 
            SecondCalendarTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SecondCalendarTable.CaptionText = "End Date";
            SecondCalendarTable.ColumnCount = 1;
            SecondCalendarTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            SecondCalendarTable.Controls.Add( SecondCalendarPanel, 0, 1 );
            SecondCalendarTable.Dock = DockStyle.Fill;
            SecondCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendarTable.ForeColor = System.Drawing.Color.DarkGray;
            SecondCalendarTable.Location = new System.Drawing.Point( 3, 569 );
            SecondCalendarTable.Name = "SecondCalendarTable";
            SecondCalendarTable.RowCount = 2;
            SecondCalendarTable.RowStyles.Add( new RowStyle( SizeType.Percent, 4.296875F ) );
            SecondCalendarTable.RowStyles.Add( new RowStyle( SizeType.Percent, 95.703125F ) );
            SecondCalendarTable.Size = new System.Drawing.Size( 386, 561 );
            SecondCalendarTable.TabIndex = 2;
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
            SecondCalendarPanel.Dock = DockStyle.Fill;
            SecondCalendarPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendarPanel.ForeColor = System.Drawing.Color.Transparent;
            SecondCalendarPanel.HoverText = null;
            SecondCalendarPanel.IsDerivedStyle = true;
            SecondCalendarPanel.Location = new System.Drawing.Point( 3, 42 );
            SecondCalendarPanel.Name = "SecondCalendarPanel";
            SecondCalendarPanel.Padding = new Padding( 1 );
            SecondCalendarPanel.Size = new System.Drawing.Size( 380, 516 );
            SecondCalendarPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondCalendarPanel.StyleManager = null;
            SecondCalendarPanel.TabIndex = 46;
            SecondCalendarPanel.ThemeAuthor = "Terry D. Eppler";
            SecondCalendarPanel.ThemeName = "Budget Execution";
            SecondCalendarPanel.ToolTip = null;
            // 
            // SecondCalendar
            // 
            SecondCalendar.CanOverrideStyle = true;
            SecondCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            SecondCalendar.Location = new System.Drawing.Point( 16, 21 );
            SecondCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
            SecondCalendar.Name = "SecondCalendar";
            SecondCalendar.SelectedDate = new System.DateTime( 2023, 7, 31, 0, 0, 0, 0 );
            SecondCalendar.ShowToolTip = true;
            SecondCalendar.Size = new System.Drawing.Size( 238, 230 );
            SecondCalendar.Style.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            SecondCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SecondCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            SecondCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            SecondCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            SecondCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            SecondCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            SecondCalendar.TabIndex = 2;
            // 
            // FirstCalendarTable
            // 
            FirstCalendarTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            FirstCalendarTable.CaptionText = "Start Date";
            FirstCalendarTable.ColumnCount = 1;
            FirstCalendarTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            FirstCalendarTable.Controls.Add( FirstCalendarPanel, 0, 1 );
            FirstCalendarTable.Dock = DockStyle.Fill;
            FirstCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendarTable.ForeColor = System.Drawing.Color.DarkGray;
            FirstCalendarTable.Location = new System.Drawing.Point( 3, 3 );
            FirstCalendarTable.Name = "FirstCalendarTable";
            FirstCalendarTable.RowCount = 2;
            FirstCalendarTable.RowStyles.Add( new RowStyle( SizeType.Percent, 4.31372547F ) );
            FirstCalendarTable.RowStyles.Add( new RowStyle( SizeType.Percent, 95.68627F ) );
            FirstCalendarTable.Size = new System.Drawing.Size( 386, 560 );
            FirstCalendarTable.TabIndex = 1;
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
            FirstCalendarPanel.Dock = DockStyle.Fill;
            FirstCalendarPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendarPanel.ForeColor = System.Drawing.Color.Transparent;
            FirstCalendarPanel.HoverText = null;
            FirstCalendarPanel.IsDerivedStyle = true;
            FirstCalendarPanel.Location = new System.Drawing.Point( 3, 42 );
            FirstCalendarPanel.Name = "FirstCalendarPanel";
            FirstCalendarPanel.Padding = new Padding( 1 );
            FirstCalendarPanel.Size = new System.Drawing.Size( 380, 515 );
            FirstCalendarPanel.Style = MetroSet_UI.Enums.Style.Custom;
            FirstCalendarPanel.StyleManager = null;
            FirstCalendarPanel.TabIndex = 45;
            FirstCalendarPanel.ThemeAuthor = "Terry D. Eppler";
            FirstCalendarPanel.ThemeName = "Budget Execution";
            FirstCalendarPanel.ToolTip = null;
            // 
            // FirstCalendar
            // 
            FirstCalendar.CanOverrideStyle = true;
            FirstCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            FirstCalendar.Location = new System.Drawing.Point( 17, 22 );
            FirstCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
            FirstCalendar.Name = "FirstCalendar";
            FirstCalendar.SelectedDate = new System.DateTime( 2023, 7, 31, 0, 0, 0, 0 );
            FirstCalendar.ShowToolTip = true;
            FirstCalendar.Size = new System.Drawing.Size( 238, 230 );
            FirstCalendar.Style.BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FirstCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            FirstCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FirstCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            FirstCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            FirstCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            FirstCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            FirstCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            FirstCalendar.TabIndex = 1;
            // 
            // GroupButton
            // 
            GroupButton.AutoToolTip = false;
            GroupButton.BackColor = System.Drawing.Color.Transparent;
            GroupButton.BindingSource = null;
            GroupButton.DataFilter = null;
            GroupButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            GroupButton.Field = Field.AccountCode;
            GroupButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GroupButton.ForeColor = System.Drawing.Color.LightGray;
            GroupButton.HoverText = null;
            GroupButton.Image = Resources.Images.GroupButton;
            GroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            GroupButton.Margin = new Padding( 3 );
            GroupButton.Name = "GroupButton";
            GroupButton.Padding = new Padding( 1 );
            GroupButton.Size = new System.Drawing.Size( 23, 24 );
            GroupButton.Text = "toolStripButton2";
            GroupButton.ToolTip = null;
            GroupButton.ToolType = ToolType.Ns;
            // 
            // PivotDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( TabControl );
            Controls.Add( Header );
            Controls.Add( ToolStrip );
            Controls.Add( PivotGridTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.DarkGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            Margin = new Padding( 4, 3, 4, 3 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "PivotDataForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            PivotGridPanel.ResumeLayout( false );
            PivotGridTable.ResumeLayout( false );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            TableTabPage.ResumeLayout( false );
            SourceTable.ResumeLayout( false );
            TablePanel.ResumeLayout( false );
            FilterTabPage.ResumeLayout( false );
            FilterTable.ResumeLayout( false );
            SecondTable.ResumeLayout( false );
            SecondListBoxPanel.ResumeLayout( false );
            FirstTable.ResumeLayout( false );
            FirstListBoxPanel.ResumeLayout( false );
            ThirdTable.ResumeLayout( false );
            ThirdListBoxPanel.ResumeLayout( false );
            GroupTabPage.ResumeLayout( false );
            NumericTable.ResumeLayout( false );
            NumericPanel.ResumeLayout( false );
            FieldTable.ResumeLayout( false );
            FieldPanel.ResumeLayout( false );
            CalendarTabPage.ResumeLayout( false );
            TimeSpanTable.ResumeLayout( false );
            SecondCalendarTable.ResumeLayout( false );
            SecondCalendarPanel.ResumeLayout( false );
            FirstCalendarTable.ResumeLayout( false );
            FirstCalendarPanel.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public SmallTip ToolTip;
        public Layout PivotGridPanel;
        public HeaderPanel PivotGridTable;
        public ToolStrip ToolStrip;
        public ToolSeparator Separator1;
        public ToolSeparator Separator2;
        public ToolStripLabel NavigationLabel;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public ToolSeparator Separator5;
        public ToolStripButton NextButton;
        public ToolStripButton FirstButton;
        public ToolStripButton PreviousButton;
        public BindingSource BindingSource;
        public ContextMenu ContextMenu;
        public ToolStripButton LastButton;
        private Timer Timer;
        public TableLayoutPanel Header;
        public PictureBox PictureBox;
        public Label Title;
        public TabControl TabControl;
        public TabPageAdv TableTabPage;
        public HeaderPanel SourceTable;
        public ComboBox TableComboBox;
        public Layout TablePanel;
        public ListBox TableListBox;
        public TabPageAdv FilterTabPage;
        public TableLayoutPanel FilterTable;
        public HeaderPanel SecondTable;
        public Layout SecondListBoxPanel;
        public ListBox SecondListBox;
        public ComboBox SecondComboBox;
        public HeaderPanel FirstTable;
        public ComboBox FirstComboBox;
        public Layout FirstListBoxPanel;
        public ListBox FirstListBox;
        public HeaderPanel ThirdTable;
        public Layout ThirdListBoxPanel;
        public ListBox ThirdListBox;
        public ComboBox ThirdComboBox;
        public TabPageAdv GroupTabPage;
        public HeaderPanel NumericTable;
        public Layout NumericPanel;
        public ListBox NumericListBox;
        public HeaderPanel FieldTable;
        public Layout FieldPanel;
        public ListBox FieldListBox;
        public TabPageAdv CalendarTabPage;
        public TableLayoutPanel TimeSpanTable;
        public HeaderPanel SecondCalendarTable;
        public Layout SecondCalendarPanel;
        public Syncfusion.WinForms.Input.SfCalendar SecondCalendar;
        private HeaderPanel FirstCalendarTable;
        public Layout FirstCalendarPanel;
        public Syncfusion.WinForms.Input.SfCalendar FirstCalendar;
        public ToolSeparator LookupSeparator;
        private ToolStripButton LookupButton;
        public ToolSeparator FitlerSeparator;
        public ToolStripButton FilterButton;
        public ToolSeparator GroupSeparator;
        public ToolStripButton MainMenuButton;
        public ToolSeparator MenuSeparator;
        public ToolStripButton CloseButton;
        public ToolSeparator CloseSeparator;
        public ToolStripButton GroupButton;
        public ToolSeparator Separator;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
        public ToolSeparator Separator6;
        public Syncfusion.Windows.Forms.PivotChart.PivotChart PivotChart;
    }
}