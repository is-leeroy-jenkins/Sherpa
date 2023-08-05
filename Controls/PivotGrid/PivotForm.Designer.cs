namespace BudgetExecution
{
    using System.Windows.Forms;

    using Syncfusion.Windows.Forms.Tools;

    partial class PivotForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PivotForm ) );
            ListBoxPanel = new Layout( );
            ToolTip = new SmallTip( );
            PivotGridPanel = new Layout( );
            PivotChart = new Syncfusion.Windows.Forms.PivotChart.PivotChart( );
            PivotGridTable = new HeaderPanel( );
            headerPanel1 = new HeaderPanel( );
            ToolStrip = new ToolStrip( );
            BindingSource = new BindingSource( components );
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
            ContextMenu = new ContextMenu( );
            Timer = new Timer( components );
            Header = new TableLayoutPanel( );
            PictureBox = new PictureBox( );
            Title = new Label( );
            PivotGridPanel.SuspendLayout( );
            PivotGridTable.SuspendLayout( );
            headerPanel1.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            SuspendLayout( );
            // 
            // ListBoxPanel
            // 
            ListBoxPanel.BackColor = System.Drawing.Color.Transparent;
            ListBoxPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ListBoxPanel.BindingSource = null;
            ListBoxPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ListBoxPanel.BorderThickness = 1;
            ListBoxPanel.Children = null;
            ListBoxPanel.DataFilter = null;
            ListBoxPanel.Dock = DockStyle.Fill;
            ListBoxPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            ListBoxPanel.HoverText = null;
            ListBoxPanel.IsDerivedStyle = true;
            ListBoxPanel.Location = new System.Drawing.Point( 4, 19 );
            ListBoxPanel.Margin = new Padding( 4, 3, 4, 3 );
            ListBoxPanel.Name = "ListBoxPanel";
            ListBoxPanel.Padding = new Padding( 1 );
            ListBoxPanel.Size = new System.Drawing.Size( 255, 522 );
            ListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ListBoxPanel.StyleManager = null;
            ListBoxPanel.TabIndex = 10;
            ListBoxPanel.Text = "layout1";
            ListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            ListBoxPanel.ThemeName = "Budget Execution";
            ListBoxPanel.ToolTip = null;
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
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // PivotGridPanel
            // 
            PivotGridPanel.BackColor = System.Drawing.Color.Transparent;
            PivotGridPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PivotGridPanel.BindingSource = null;
            PivotGridPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            PivotGridPanel.BorderThickness = 1;
            PivotGridPanel.Children = null;
            PivotGridPanel.Controls.Add( PivotChart );
            PivotGridPanel.DataFilter = null;
            PivotGridPanel.Dock = DockStyle.Fill;
            PivotGridPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PivotGridPanel.ForeColor = System.Drawing.Color.Transparent;
            PivotGridPanel.HoverText = null;
            PivotGridPanel.IsDerivedStyle = true;
            PivotGridPanel.Location = new System.Drawing.Point( 4, 21 );
            PivotGridPanel.Margin = new Padding( 4, 3, 4, 3 );
            PivotGridPanel.Name = "PivotGridPanel";
            PivotGridPanel.Padding = new Padding( 1 );
            PivotGridPanel.Size = new System.Drawing.Size( 990, 520 );
            PivotGridPanel.Style = MetroSet_UI.Enums.Style.Custom;
            PivotGridPanel.StyleManager = null;
            PivotGridPanel.TabIndex = 12;
            PivotGridPanel.ThemeAuthor = "Terry D. Eppler";
            PivotGridPanel.ThemeName = "Budget Execution";
            PivotGridPanel.ToolTip = null;
            // 
            // PivotChart
            // 
            PivotChart.Anchor =     AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right  ;
            PivotChart.ChartTypes = Syncfusion.Windows.Forms.PivotChart.PivotChartTypes.Column;
            PivotChart.CustomPalette = new System.Drawing.Color[ ] { System.Drawing.Color.FromArgb(   147  ,   208  ,   249   ), System.Drawing.Color.FromArgb(   102  ,   170  ,   225   ), System.Drawing.Color.FromArgb(   250  ,   163  ,   94   ), System.Drawing.Color.FromArgb(   252  ,   227  ,   127   ) };
            PivotChart.DeferLayoutUpdate = false;
            PivotChart.ForeColor = System.Drawing.Color.DarkGray;
            PivotChart.Location = new System.Drawing.Point( 21, 18 );
            PivotChart.Margin = new Padding( 4, 3, 4, 3 );
            PivotChart.MinimumSize = new System.Drawing.Size( 350, 250 );
            PivotChart.Name = "PivotChart";
            PivotChart.ShowPivotTableFieldList = false;
            PivotChart.Size = new System.Drawing.Size( 949, 481 );
            PivotChart.Skins = Syncfusion.Windows.Forms.Chart.Skins.Midnight;
            PivotChart.TabIndex = 0;
            PivotChart.Text = "PivotChart";
            PivotChart.UpdateManager = null;
            // 
            // PivotGridTable
            // 
            PivotGridTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            PivotGridTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            PivotGridTable.ColumnCount = 1;
            PivotGridTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            PivotGridTable.Controls.Add( PivotGridPanel, 0, 1 );
            PivotGridTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PivotGridTable.ForeColor = System.Drawing.Color.DarkGray;
            PivotGridTable.Location = new System.Drawing.Point( 29, 69 );
            PivotGridTable.Margin = new Padding( 4, 3, 4, 3 );
            PivotGridTable.Name = "PivotGridTable";
            PivotGridTable.RowCount = 2;
            PivotGridTable.RowStyles.Add( new RowStyle( SizeType.Percent, 3.38078284F ) );
            PivotGridTable.RowStyles.Add( new RowStyle( SizeType.Percent, 96.61922F ) );
            PivotGridTable.Size = new System.Drawing.Size( 998, 544 );
            PivotGridTable.TabIndex = 13;
            // 
            // headerPanel1
            // 
            headerPanel1.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            headerPanel1.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            headerPanel1.ColumnCount = 1;
            headerPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            headerPanel1.Controls.Add( ListBoxPanel, 0, 1 );
            headerPanel1.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            headerPanel1.ForeColor = System.Drawing.Color.DarkGray;
            headerPanel1.Location = new System.Drawing.Point( 1031, 69 );
            headerPanel1.Margin = new Padding( 4, 3, 4, 3 );
            headerPanel1.Name = "headerPanel1";
            headerPanel1.RowCount = 2;
            headerPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 3.024911F ) );
            headerPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 96.97509F ) );
            headerPanel1.Size = new System.Drawing.Size( 263, 544 );
            headerPanel1.TabIndex = 0;
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
            ToolStrip.Items.AddRange( new ToolStripItem[ ] { Separator1, NavigationLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator4, NextButton, Separator5, LastButton } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 692 );
            ToolStrip.Margin = new Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
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
            ToolStrip.Size = new System.Drawing.Size( 1338, 46 );
            ToolStrip.TabIndex = 14;
            ToolStrip.Text = "toolStrip1";
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
            ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 28 );
            // 
            // NavigationLabel
            // 
            NavigationLabel.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            NavigationLabel.BindingSource = null;
            NavigationLabel.DataFilter = null;
            NavigationLabel.Field = Field.AccountCode;
            NavigationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NavigationLabel.ForeColor = System.Drawing.Color.Black;
            NavigationLabel.HoverText = null;
            NavigationLabel.Margin = new Padding( 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new Padding( 1 );
            NavigationLabel.Size = new System.Drawing.Size( 49, 28 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "Navigation";
            NavigationLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 28 );
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
            FirstButton.Margin = new Padding( 3 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 24 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = null;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 28 );
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
            PreviousButton.Margin = new Padding( 3 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 24 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = null;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 28 );
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
            NextButton.Margin = new Padding( 3 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 24 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 28 );
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
            LastButton.Margin = new Padding( 3 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 24 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = null;
            LastButton.ToolType = ToolType.LastButton;
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
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
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = ToolTip;
            // 
            // PivotForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( Header );
            Controls.Add( ToolStrip );
            Controls.Add( headerPanel1 );
            Controls.Add( PivotGridTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.DarkGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            Margin = new Padding( 4, 3, 4, 3 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "PivotForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            PivotGridPanel.ResumeLayout( false );
            PivotGridTable.ResumeLayout( false );
            headerPanel1.ResumeLayout( false );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public SmallTip ToolTip;
        public Layout ListBoxPanel;
        public Layout PivotGridPanel;
        public HeaderPanel PivotGridTable;
        public HeaderPanel headerPanel1;
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
        public Syncfusion.Windows.Forms.PivotChart.PivotChart PivotChart;
        private Timer Timer;
        public TableLayoutPanel Header;
        public PictureBox PictureBox;
        public Label Title;
    }
}