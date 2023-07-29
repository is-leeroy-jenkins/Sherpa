namespace BudgetExecution
{


    partial class LookupDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( LookupDialog ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv( );
            LookupTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            ColumnTable = new HeaderPanel( );
            ColumnPanel = new Layout( );
            ColumnListBox = new ListBox( );
            ToolTip = new SmallTip( );
            ProviderTable = new HeaderPanel( );
            ProviderPanel = new Layout( );
            SqlCeRadioButton = new RadioButton( );
            SqliteRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SqlServerRadioButton = new RadioButton( );
            ValueTable = new HeaderPanel( );
            ValuePanel = new Layout( );
            ValueListBox = new ListBox( );
            SourceTable = new HeaderPanel( );
            TablePanel = new Layout( );
            TableListBox = new ListBox( );
            tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            groupBox7 = new Layout( );
            listBox5 = new ListBox( );
            listBox6 = new ListBox( );
            groupBox8 = new Layout( );
            visualComboBox3 = new ComboBox( );
            visualLabel3 = new Label( );
            visualLabel5 = new Label( );
            visualTextBox3 = new TextBox( );
            SelectButton = new Button( );
            RefreshButton = new Button( );
            CloseButton = new Button( );
            groupBox2 = new Layout( );
            groupBox3 = new Layout( );
            groupBox4 = new Layout( );
            groupBox9 = new Layout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) TabControl  ).BeginInit( );
            TabControl.SuspendLayout( );
            LookupTabPage.SuspendLayout( );
            ColumnTable.SuspendLayout( );
            ColumnPanel.SuspendLayout( );
            ProviderTable.SuspendLayout( );
            ProviderPanel.SuspendLayout( );
            ValueTable.SuspendLayout( );
            ValuePanel.SuspendLayout( );
            SourceTable.SuspendLayout( );
            TablePanel.SuspendLayout( );
            tabPageAdv1.SuspendLayout( );
            groupBox7.SuspendLayout( );
            groupBox8.SuspendLayout( );
            SuspendLayout( );
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 1298, 562 );
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.Controls.Add( LookupTabPage );
            TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ItemSize = new System.Drawing.Size( 158, 23 );
            TabControl.Location = new System.Drawing.Point( 0, 0 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 1298, 562 );
            TabControl.TabIndex = 8;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(   22  ,   39  ,   70   );
            TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(   22  ,   39  ,   70   );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(   22  ,   39  ,   70   );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            // 
            // LookupTabPage
            // 
            LookupTabPage.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            LookupTabPage.Controls.Add( ColumnTable );
            LookupTabPage.Controls.Add( ProviderTable );
            LookupTabPage.Controls.Add( ValueTable );
            LookupTabPage.Controls.Add( SourceTable );
            LookupTabPage.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LookupTabPage.ForeColor = System.Drawing.Color.LightSteelBlue;
            LookupTabPage.Image = null;
            LookupTabPage.ImageSize = new System.Drawing.Size( 12, 12 );
            LookupTabPage.Location = new System.Drawing.Point( 0, 22 );
            LookupTabPage.Name = "LookupTabPage";
            LookupTabPage.ShowCloseButton = true;
            LookupTabPage.Size = new System.Drawing.Size( 1298, 540 );
            LookupTabPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            LookupTabPage.TabForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            LookupTabPage.TabIndex = 2;
            LookupTabPage.Text = "  Look Up";
            LookupTabPage.ThemesEnabled = false;
            // 
            // ColumnTable
            // 
            ColumnTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ColumnTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ColumnTable.CaptionText = "Columns";
            ColumnTable.ColumnCount = 1;
            ColumnTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ColumnTable.Controls.Add( ColumnPanel, 0, 1 );
            ColumnTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ColumnTable.ForeColor = System.Drawing.Color.DarkGray;
            ColumnTable.Location = new System.Drawing.Point( 188, 295 );
            ColumnTable.Name = "ColumnTable";
            ColumnTable.RowCount = 2;
            ColumnTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 8.465609F ) );
            ColumnTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 91.53439F ) );
            ColumnTable.Size = new System.Drawing.Size( 412, 220 );
            ColumnTable.TabIndex = 16;
            // 
            // ColumnPanel
            // 
            ColumnPanel.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            ColumnPanel.BackColor = System.Drawing.Color.Transparent;
            ColumnPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ColumnPanel.BindingSource = null;
            ColumnPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ColumnPanel.BorderThickness = 1;
            ColumnPanel.Children = null;
            ColumnPanel.Controls.Add( ColumnListBox );
            ColumnPanel.DataFilter = null;
            ColumnPanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ColumnPanel.ForeColor = System.Drawing.Color.Transparent;
            ColumnPanel.HoverText = null;
            ColumnPanel.IsDerivedStyle = true;
            ColumnPanel.Location = new System.Drawing.Point( 3, 36 );
            ColumnPanel.Name = "ColumnPanel";
            ColumnPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ColumnPanel.Size = new System.Drawing.Size( 406, 181 );
            ColumnPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ColumnPanel.StyleManager = null;
            ColumnPanel.TabIndex = 8;
            ColumnPanel.ThemeAuthor = "Terry D. Eppler";
            ColumnPanel.ThemeName = "BudgetExecution";
            ColumnPanel.ToolTip = null;
            // 
            // ColumnListBox
            // 
            ColumnListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            ColumnListBox.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            ColumnListBox.BindingSource = null;
            ColumnListBox.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            ColumnListBox.DataFilter = null;
            ColumnListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ColumnListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ColumnListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ColumnListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ColumnListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ColumnListBox.HoverText = null;
            ColumnListBox.IsDerivedStyle = true;
            ColumnListBox.ItemHeight = 30;
            ColumnListBox.Location = new System.Drawing.Point( 16, 14 );
            ColumnListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ColumnListBox.MultiSelect = false;
            ColumnListBox.Name = "ColumnListBox";
            ColumnListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ColumnListBox.SelectedIndex = -1;
            ColumnListBox.SelectedItem = null;
            ColumnListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ColumnListBox.SelectedItemColor = System.Drawing.Color.White;
            ColumnListBox.SelectedText = null;
            ColumnListBox.SelectedValue = null;
            ColumnListBox.ShowBorder = false;
            ColumnListBox.ShowScrollBar = false;
            ColumnListBox.Size = new System.Drawing.Size( 375, 153 );
            ColumnListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ColumnListBox.StyleManager = null;
            ColumnListBox.TabIndex = 2;
            ColumnListBox.Text = "listBox1";
            ColumnListBox.ThemeAuthor = "Terry D. Eppler";
            ColumnListBox.ThemeName = "BudgetExecution";
            ColumnListBox.ToolTip = ToolTip;
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
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // ProviderTable
            // 
            ProviderTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ProviderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ProviderTable.CaptionText = "Databases";
            ProviderTable.ColumnCount = 1;
            ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ProviderTable.Controls.Add( ProviderPanel, 0, 1 );
            ProviderTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ProviderTable.ForeColor = System.Drawing.Color.DarkGray;
            ProviderTable.Location = new System.Drawing.Point( 191, 44 );
            ProviderTable.Name = "ProviderTable";
            ProviderTable.RowCount = 2;
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 7.9365077F ) );
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 92.06349F ) );
            ProviderTable.Size = new System.Drawing.Size( 412, 220 );
            ProviderTable.TabIndex = 15;
            // 
            // ProviderPanel
            // 
            ProviderPanel.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            ProviderPanel.BackColor = System.Drawing.Color.Transparent;
            ProviderPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ProviderPanel.BindingSource = null;
            ProviderPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ProviderPanel.BorderThickness = 1;
            ProviderPanel.Children = null;
            ProviderPanel.Controls.Add( SqlCeRadioButton );
            ProviderPanel.Controls.Add( SqliteRadioButton );
            ProviderPanel.Controls.Add( AccessRadioButton );
            ProviderPanel.Controls.Add( SqlServerRadioButton );
            ProviderPanel.DataFilter = null;
            ProviderPanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ProviderPanel.ForeColor = System.Drawing.Color.Transparent;
            ProviderPanel.HoverText = null;
            ProviderPanel.IsDerivedStyle = true;
            ProviderPanel.Location = new System.Drawing.Point( 3, 35 );
            ProviderPanel.Name = "ProviderPanel";
            ProviderPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ProviderPanel.Size = new System.Drawing.Size( 406, 182 );
            ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ProviderPanel.StyleManager = null;
            ProviderPanel.TabIndex = 5;
            ProviderPanel.ThemeAuthor = "Terry D. Eppler";
            ProviderPanel.ThemeName = "BudgetExecution";
            ProviderPanel.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            SqlCeRadioButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SqlCeRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   85  ,   85  ,   85   );
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlCeRadioButton.Group = 0;
            SqlCeRadioButton.HoverText = null;
            SqlCeRadioButton.IsDerivedStyle = true;
            SqlCeRadioButton.Location = new System.Drawing.Point( 146, 133 );
            SqlCeRadioButton.Name = "SqlCeRadioButton";
            SqlCeRadioButton.Result = null;
            SqlCeRadioButton.Size = new System.Drawing.Size( 140, 17 );
            SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlCeRadioButton.StyleManager = null;
            SqlCeRadioButton.TabIndex = 4;
            SqlCeRadioButton.Text = "    SQL Compact";
            SqlCeRadioButton.ThemeAuthor = "Narwin";
            SqlCeRadioButton.ThemeName = "MetroDark";
            SqlCeRadioButton.ToolTip = ToolTip;
            // 
            // SqliteRadioButton
            // 
            SqliteRadioButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SqliteRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqliteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            SqliteRadioButton.BorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
            SqliteRadioButton.Checked = false;
            SqliteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqliteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqliteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   85  ,   85  ,   85   );
            SqliteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqliteRadioButton.Group = 0;
            SqliteRadioButton.HoverText = null;
            SqliteRadioButton.IsDerivedStyle = true;
            SqliteRadioButton.Location = new System.Drawing.Point( 146, 24 );
            SqliteRadioButton.Name = "SqliteRadioButton";
            SqliteRadioButton.Result = null;
            SqliteRadioButton.Size = new System.Drawing.Size( 118, 17 );
            SqliteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqliteRadioButton.StyleManager = null;
            SqliteRadioButton.TabIndex = 1;
            SqliteRadioButton.Text = "    SQLite";
            SqliteRadioButton.ThemeAuthor = "Narwin";
            SqliteRadioButton.ThemeName = "MetroDark";
            SqliteRadioButton.ToolTip = ToolTip;
            // 
            // AccessRadioButton
            // 
            AccessRadioButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            AccessRadioButton.BackColor = System.Drawing.Color.Transparent;
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   85  ,   85  ,   85   );
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            AccessRadioButton.Group = 0;
            AccessRadioButton.HoverText = null;
            AccessRadioButton.IsDerivedStyle = true;
            AccessRadioButton.Location = new System.Drawing.Point( 146, 92 );
            AccessRadioButton.Name = "AccessRadioButton";
            AccessRadioButton.Result = null;
            AccessRadioButton.Size = new System.Drawing.Size( 140, 17 );
            AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            AccessRadioButton.StyleManager = null;
            AccessRadioButton.TabIndex = 3;
            AccessRadioButton.Text = "    MS Access";
            AccessRadioButton.ThemeAuthor = "Narwin";
            AccessRadioButton.ThemeName = "MetroDark";
            AccessRadioButton.ToolTip = ToolTip;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SqlServerRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   85  ,   85  ,   85   );
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlServerRadioButton.Group = 0;
            SqlServerRadioButton.HoverText = null;
            SqlServerRadioButton.IsDerivedStyle = true;
            SqlServerRadioButton.Location = new System.Drawing.Point( 146, 58 );
            SqlServerRadioButton.Name = "SqlServerRadioButton";
            SqlServerRadioButton.Result = null;
            SqlServerRadioButton.Size = new System.Drawing.Size( 140, 17 );
            SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlServerRadioButton.StyleManager = null;
            SqlServerRadioButton.TabIndex = 2;
            SqlServerRadioButton.Text = "    SQL Server";
            SqlServerRadioButton.ThemeAuthor = "Narwin";
            SqlServerRadioButton.ThemeName = "MetroDark";
            SqlServerRadioButton.ToolTip = ToolTip;
            // 
            // ValueTable
            // 
            ValueTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ValueTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ValueTable.CaptionText = "Values ";
            ValueTable.ColumnCount = 1;
            ValueTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ValueTable.Controls.Add( ValuePanel, 0, 1 );
            ValueTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ValueTable.ForeColor = System.Drawing.Color.DarkGray;
            ValueTable.Location = new System.Drawing.Point( 712, 295 );
            ValueTable.Name = "ValueTable";
            ValueTable.RowCount = 2;
            ValueTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 8.465609F ) );
            ValueTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 91.53439F ) );
            ValueTable.Size = new System.Drawing.Size( 412, 220 );
            ValueTable.TabIndex = 14;
            // 
            // ValuePanel
            // 
            ValuePanel.BackColor = System.Drawing.Color.Transparent;
            ValuePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ValuePanel.BindingSource = null;
            ValuePanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ValuePanel.BorderThickness = 1;
            ValuePanel.Children = null;
            ValuePanel.Controls.Add( ValueListBox );
            ValuePanel.DataFilter = null;
            ValuePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ValuePanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ValuePanel.ForeColor = System.Drawing.Color.Transparent;
            ValuePanel.HoverText = null;
            ValuePanel.IsDerivedStyle = true;
            ValuePanel.Location = new System.Drawing.Point( 3, 36 );
            ValuePanel.Name = "ValuePanel";
            ValuePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ValuePanel.Size = new System.Drawing.Size( 406, 181 );
            ValuePanel.Style = MetroSet_UI.Enums.Style.Custom;
            ValuePanel.StyleManager = null;
            ValuePanel.TabIndex = 9;
            ValuePanel.ThemeAuthor = "Terry D. Eppler";
            ValuePanel.ThemeName = "BudgetExecution";
            ValuePanel.ToolTip = null;
            // 
            // ValueListBox
            // 
            ValueListBox.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            ValueListBox.BindingSource = null;
            ValueListBox.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            ValueListBox.DataFilter = null;
            ValueListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ValueListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ValueListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ValueListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ValueListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ValueListBox.HoverText = null;
            ValueListBox.IsDerivedStyle = true;
            ValueListBox.ItemHeight = 30;
            ValueListBox.Location = new System.Drawing.Point( 15, 14 );
            ValueListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ValueListBox.MultiSelect = false;
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ValueListBox.SelectedIndex = -1;
            ValueListBox.SelectedItem = null;
            ValueListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ValueListBox.SelectedItemColor = System.Drawing.Color.White;
            ValueListBox.SelectedText = null;
            ValueListBox.SelectedValue = null;
            ValueListBox.ShowBorder = false;
            ValueListBox.ShowScrollBar = false;
            ValueListBox.Size = new System.Drawing.Size( 375, 151 );
            ValueListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ValueListBox.StyleManager = null;
            ValueListBox.TabIndex = 2;
            ValueListBox.Text = "listBox1";
            ValueListBox.ThemeAuthor = "Terry D. Eppler";
            ValueListBox.ThemeName = "BudgetExecution";
            ValueListBox.ToolTip = ToolTip;
            // 
            // SourceTable
            // 
            SourceTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SourceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourceTable.CaptionText = "Tables";
            SourceTable.ColumnCount = 1;
            SourceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SourceTable.Controls.Add( TablePanel, 0, 1 );
            SourceTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SourceTable.ForeColor = System.Drawing.Color.DarkGray;
            SourceTable.Location = new System.Drawing.Point( 712, 44 );
            SourceTable.Name = "SourceTable";
            SourceTable.RowCount = 2;
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 7.075472F ) );
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 92.92453F ) );
            SourceTable.Size = new System.Drawing.Size( 412, 220 );
            SourceTable.TabIndex = 13;
            // 
            // TablePanel
            // 
            TablePanel.BackColor = System.Drawing.Color.Transparent;
            TablePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TablePanel.BindingSource = null;
            TablePanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            TablePanel.BorderThickness = 1;
            TablePanel.Children = null;
            TablePanel.Controls.Add( TableListBox );
            TablePanel.DataFilter = null;
            TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TablePanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TablePanel.ForeColor = System.Drawing.Color.Transparent;
            TablePanel.HoverText = null;
            TablePanel.IsDerivedStyle = true;
            TablePanel.Location = new System.Drawing.Point( 3, 33 );
            TablePanel.Name = "TablePanel";
            TablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            TablePanel.Size = new System.Drawing.Size( 406, 184 );
            TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            TablePanel.StyleManager = null;
            TablePanel.TabIndex = 7;
            TablePanel.ThemeAuthor = "Terry D. Eppler";
            TablePanel.ThemeName = "BudgetExecution";
            TablePanel.ToolTip = null;
            // 
            // TableListBox
            // 
            TableListBox.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            TableListBox.BindingSource = null;
            TableListBox.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            TableListBox.DataFilter = null;
            TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TableListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            TableListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            TableListBox.HoverText = null;
            TableListBox.IsDerivedStyle = true;
            TableListBox.ItemHeight = 30;
            TableListBox.Location = new System.Drawing.Point( 15, 16 );
            TableListBox.Margin = new System.Windows.Forms.Padding( 1 );
            TableListBox.MultiSelect = false;
            TableListBox.Name = "TableListBox";
            TableListBox.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBox.SelectedIndex = -1;
            TableListBox.SelectedItem = null;
            TableListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            TableListBox.SelectedItemColor = System.Drawing.Color.White;
            TableListBox.SelectedText = null;
            TableListBox.SelectedValue = null;
            TableListBox.ShowBorder = false;
            TableListBox.ShowScrollBar = false;
            TableListBox.Size = new System.Drawing.Size( 375, 151 );
            TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBox.StyleManager = null;
            TableListBox.TabIndex = 1;
            TableListBox.Text = "Tables";
            TableListBox.ThemeAuthor = "Terry D. Eppler";
            TableListBox.ThemeName = "BudgetExecution";
            TableListBox.ToolTip = ToolTip;
            // 
            // tabPageAdv1
            // 
            tabPageAdv1.Controls.Add( groupBox7 );
            tabPageAdv1.Controls.Add( groupBox8 );
            tabPageAdv1.Image = null;
            tabPageAdv1.ImageSize = new System.Drawing.Size( 16, 16 );
            tabPageAdv1.Location = new System.Drawing.Point( 0, 0 );
            tabPageAdv1.Name = "tabPageAdv1";
            tabPageAdv1.ShowCloseButton = true;
            tabPageAdv1.Size = new System.Drawing.Size( 200, 100 );
            tabPageAdv1.TabFont = null;
            tabPageAdv1.TabIndex = 0;
            tabPageAdv1.ThemesEnabled = false;
            // 
            // groupBox7
            // 
            groupBox7.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            groupBox7.BackColor = System.Drawing.Color.Transparent;
            groupBox7.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            groupBox7.BindingSource = null;
            groupBox7.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            groupBox7.BorderThickness = 1;
            groupBox7.Children = null;
            groupBox7.Controls.Add( listBox5 );
            groupBox7.Controls.Add( listBox6 );
            groupBox7.DataFilter = null;
            groupBox7.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            groupBox7.ForeColor = System.Drawing.Color.Transparent;
            groupBox7.HoverText = null;
            groupBox7.IsDerivedStyle = true;
            groupBox7.Location = new System.Drawing.Point( 438, 58 );
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding( 1 );
            groupBox7.Size = new System.Drawing.Size( 377, 191 );
            groupBox7.Style = MetroSet_UI.Enums.Style.Custom;
            groupBox7.StyleManager = null;
            groupBox7.TabIndex = 6;
            groupBox7.ThemeAuthor = "Terry D. Eppler";
            groupBox7.ThemeName = "BudgetExecution";
            groupBox7.ToolTip = null;
            // 
            // listBox5
            // 
            listBox5.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            listBox5.BackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            listBox5.BindingSource = null;
            listBox5.BorderColor = System.Drawing.Color.FromArgb(   50  ,   50  ,   50   );
            listBox5.DataFilter = null;
            listBox5.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            listBox5.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            listBox5.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            listBox5.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            listBox5.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            listBox5.HoverText = null;
            listBox5.IsDerivedStyle = true;
            listBox5.ItemHeight = 30;
            listBox5.Location = new System.Drawing.Point( 15, 37 );
            listBox5.Margin = new System.Windows.Forms.Padding( 1 );
            listBox5.MultiSelect = false;
            listBox5.Name = "listBox5";
            listBox5.Padding = new System.Windows.Forms.Padding( 1 );
            listBox5.SelectedIndex = -1;
            listBox5.SelectedItem = null;
            listBox5.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            listBox5.SelectedItemColor = System.Drawing.Color.White;
            listBox5.SelectedText = null;
            listBox5.SelectedValue = null;
            listBox5.ShowBorder = false;
            listBox5.ShowScrollBar = false;
            listBox5.Size = new System.Drawing.Size( 348, 131 );
            listBox5.Style = MetroSet_UI.Enums.Style.Custom;
            listBox5.StyleManager = null;
            listBox5.TabIndex = 2;
            listBox5.Text = "listBox3";
            listBox5.ThemeAuthor = "Terry D. Eppler";
            listBox5.ThemeName = "BudgetExecution";
            listBox5.ToolTip = ToolTip;
            // 
            // listBox6
            // 
            listBox6.Anchor =   System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Right  ;
            listBox6.BackColor = System.Drawing.Color.FromArgb(   15  ,   15  ,   15   );
            listBox6.BindingSource = null;
            listBox6.BorderColor = System.Drawing.Color.FromArgb(   50  ,   50  ,   50   );
            listBox6.DataFilter = null;
            listBox6.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            listBox6.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            listBox6.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            listBox6.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            listBox6.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            listBox6.HoverText = null;
            listBox6.IsDerivedStyle = true;
            listBox6.ItemHeight = 30;
            listBox6.Location = new System.Drawing.Point( 15, 37 );
            listBox6.Margin = new System.Windows.Forms.Padding( 1 );
            listBox6.MultiSelect = false;
            listBox6.Name = "listBox6";
            listBox6.Padding = new System.Windows.Forms.Padding( 1 );
            listBox6.SelectedIndex = -1;
            listBox6.SelectedItem = null;
            listBox6.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            listBox6.SelectedItemColor = System.Drawing.Color.White;
            listBox6.SelectedText = null;
            listBox6.SelectedValue = null;
            listBox6.ShowBorder = false;
            listBox6.ShowScrollBar = false;
            listBox6.Size = new System.Drawing.Size( 348, 131 );
            listBox6.Style = MetroSet_UI.Enums.Style.Custom;
            listBox6.StyleManager = null;
            listBox6.TabIndex = 1;
            listBox6.Text = "listBox4";
            listBox6.ThemeAuthor = "Terry D. Eppler";
            listBox6.ThemeName = "BudgetExecution";
            listBox6.ToolTip = ToolTip;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = System.Drawing.Color.Transparent;
            groupBox8.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            groupBox8.BindingSource = null;
            groupBox8.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            groupBox8.BorderThickness = 1;
            groupBox8.Children = null;
            groupBox8.Controls.Add( visualComboBox3 );
            groupBox8.Controls.Add( visualLabel3 );
            groupBox8.Controls.Add( visualLabel5 );
            groupBox8.Controls.Add( visualTextBox3 );
            groupBox8.DataFilter = null;
            groupBox8.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            groupBox8.ForeColor = System.Drawing.Color.Transparent;
            groupBox8.HoverText = null;
            groupBox8.IsDerivedStyle = true;
            groupBox8.Location = new System.Drawing.Point( 25, 293 );
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new System.Windows.Forms.Padding( 1 );
            groupBox8.Size = new System.Drawing.Size( 790, 186 );
            groupBox8.Style = MetroSet_UI.Enums.Style.Custom;
            groupBox8.StyleManager = null;
            groupBox8.TabIndex = 5;
            groupBox8.ThemeAuthor = "Terry D. Eppler";
            groupBox8.ThemeName = "BudgetExecution";
            groupBox8.ToolTip = null;
            // 
            // visualComboBox3
            // 
            visualComboBox3.AllowDrop = true;
            visualComboBox3.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            visualComboBox3.BackColor = System.Drawing.Color.Transparent;
            visualComboBox3.BackgroundColor = System.Drawing.Color.FromArgb(   238  ,   238  ,   238   );
            visualComboBox3.BindingSource = null;
            visualComboBox3.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            visualComboBox3.CausesValidation = false;
            visualComboBox3.DataFilter = null;
            visualComboBox3.DisabledBackColor = System.Drawing.Color.Transparent;
            visualComboBox3.DisabledBorderColor = System.Drawing.Color.Transparent;
            visualComboBox3.DisabledForeColor = System.Drawing.Color.Transparent;
            visualComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            visualComboBox3.DropDownHeight = 100;
            visualComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            visualComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            visualComboBox3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            visualComboBox3.FormattingEnabled = true;
            visualComboBox3.HoverText = null;
            visualComboBox3.IntegralHeight = false;
            visualComboBox3.IsDerivedStyle = true;
            visualComboBox3.ItemHeight = 24;
            visualComboBox3.Location = new System.Drawing.Point( 92, 85 );
            visualComboBox3.Name = "visualComboBox3";
            visualComboBox3.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            visualComboBox3.SelectedItemForeColor = System.Drawing.Color.White;
            visualComboBox3.Size = new System.Drawing.Size( 221, 30 );
            visualComboBox3.Style = MetroSet_UI.Enums.Style.Custom;
            visualComboBox3.StyleManager = null;
            visualComboBox3.TabIndex = 4;
            visualComboBox3.ThemeAuthor = "Terry D. Eppler";
            visualComboBox3.ThemeName = "BudgetExecution";
            visualComboBox3.ToolTip = null;
            // 
            // visualLabel3
            // 
            visualLabel3.BindingSource = null;
            visualLabel3.DataFilter = null;
            visualLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            visualLabel3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            visualLabel3.HoverText = null;
            visualLabel3.IsDerivedStyle = true;
            visualLabel3.Location = new System.Drawing.Point( 92, 53 );
            visualLabel3.Margin = new System.Windows.Forms.Padding( 3 );
            visualLabel3.Name = "visualLabel3";
            visualLabel3.Padding = new System.Windows.Forms.Padding( 1 );
            visualLabel3.Size = new System.Drawing.Size( 177, 21 );
            visualLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            visualLabel3.StyleManager = null;
            visualLabel3.TabIndex = 3;
            visualLabel3.Text = "Select  Existing Column";
            visualLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            visualLabel3.ThemeAuthor = "Terry D. Eppler";
            visualLabel3.ThemeName = "BudgetExecution";
            visualLabel3.ToolTip = null;
            // 
            // visualLabel5
            // 
            visualLabel5.BindingSource = null;
            visualLabel5.DataFilter = null;
            visualLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            visualLabel5.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            visualLabel5.HoverText = null;
            visualLabel5.IsDerivedStyle = true;
            visualLabel5.Location = new System.Drawing.Point( 419, 53 );
            visualLabel5.Margin = new System.Windows.Forms.Padding( 3 );
            visualLabel5.Name = "visualLabel5";
            visualLabel5.Padding = new System.Windows.Forms.Padding( 1 );
            visualLabel5.Size = new System.Drawing.Size( 120, 21 );
            visualLabel5.Style = MetroSet_UI.Enums.Style.Custom;
            visualLabel5.StyleManager = null;
            visualLabel5.TabIndex = 2;
            visualLabel5.Text = "Enter New Name";
            visualLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            visualLabel5.ThemeAuthor = "Terry D. Eppler";
            visualLabel5.ThemeName = "BudgetExecution";
            visualLabel5.ToolTip = null;
            // 
            // visualTextBox3
            // 
            visualTextBox3.AutoCompleteCustomSource = null;
            visualTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            visualTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            visualTextBox3.BindingSource = null;
            visualTextBox3.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            visualTextBox3.DataFilter = null;
            visualTextBox3.DisabledBackColor = System.Drawing.Color.Transparent;
            visualTextBox3.DisabledBorderColor = System.Drawing.Color.Transparent;
            visualTextBox3.DisabledForeColor = System.Drawing.Color.Transparent;
            visualTextBox3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            visualTextBox3.HoverColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            visualTextBox3.HoverText = null;
            visualTextBox3.Image = null;
            visualTextBox3.IsDerivedStyle = true;
            visualTextBox3.Lines = null;
            visualTextBox3.Location = new System.Drawing.Point( 419, 85 );
            visualTextBox3.MaxLength = 32767;
            visualTextBox3.Multiline = false;
            visualTextBox3.Name = "visualTextBox3";
            visualTextBox3.ReadOnly = false;
            visualTextBox3.SelectionLength = 0;
            visualTextBox3.Size = new System.Drawing.Size( 278, 23 );
            visualTextBox3.Style = MetroSet_UI.Enums.Style.Custom;
            visualTextBox3.StyleManager = null;
            visualTextBox3.TabIndex = 1;
            visualTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            visualTextBox3.ThemeAuthor = "Terry D. Eppler";
            visualTextBox3.ThemeName = "BudgetExecution";
            visualTextBox3.ToolTip = null;
            visualTextBox3.UseSystemPasswordChar = false;
            visualTextBox3.WatermarkText = "";
            // 
            // SelectButton
            // 
            SelectButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            SelectButton.BackColor = System.Drawing.Color.Transparent;
            SelectButton.BindingSource = null;
            SelectButton.DataFilter = null;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            SelectButton.HoverText = "Not Yet Implemented!";
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 625, 600 );
            SelectButton.Margin = new System.Windows.Forms.Padding( 0 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            SelectButton.NormalTextColor = System.Drawing.Color.DarkGray;
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 78, 28 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 7;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "BudgetExecution";
            SelectButton.ToolTip = ToolTip;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            RefreshButton.BindingSource = null;
            RefreshButton.DataFilter = null;
            RefreshButton.DisabledBackColor = System.Drawing.Color.Transparent;
            RefreshButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            RefreshButton.DisabledForeColor = System.Drawing.Color.Transparent;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            RefreshButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            RefreshButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            RefreshButton.HoverText = "Not Yet Implemented!";
            RefreshButton.HoverTextColor = System.Drawing.Color.White;
            RefreshButton.IsDerivedStyle = true;
            RefreshButton.Location = new System.Drawing.Point( 96, 600 );
            RefreshButton.Margin = new System.Windows.Forms.Padding( 0 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            RefreshButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            RefreshButton.NormalTextColor = System.Drawing.Color.DarkGray;
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            RefreshButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            RefreshButton.PressTextColor = System.Drawing.Color.White;
            RefreshButton.Size = new System.Drawing.Size( 78, 28 );
            RefreshButton.Style = MetroSet_UI.Enums.Style.Custom;
            RefreshButton.StyleManager = null;
            RefreshButton.TabIndex = 5;
            RefreshButton.Text = "Clear";
            RefreshButton.ThemeAuthor = "Terry D. Eppler";
            RefreshButton.ThemeName = "BudgetExecution";
            RefreshButton.ToolTip = ToolTip;
            // 
            // CloseButton
            // 
            CloseButton.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            CloseButton.HoverText = "Close Window";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 1108, 600 );
            CloseButton.Margin = new System.Windows.Forms.Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CloseButton.NormalTextColor = System.Drawing.Color.DarkGray;
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 78, 28 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "BudgetExecution";
            CloseButton.ToolTip = ToolTip;
            // 
            // groupBox2
            // 
            groupBox2.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            groupBox2.BindingSource = null;
            groupBox2.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            groupBox2.BorderThickness = 1;
            groupBox2.Children = null;
            groupBox2.DataFilter = null;
            groupBox2.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            groupBox2.ForeColor = System.Drawing.Color.Transparent;
            groupBox2.HoverText = null;
            groupBox2.IsDerivedStyle = true;
            groupBox2.Location = new System.Drawing.Point( 1, 1 );
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding( 1 );
            groupBox2.Size = new System.Drawing.Size( 250, 150 );
            groupBox2.Style = MetroSet_UI.Enums.Style.Custom;
            groupBox2.StyleManager = null;
            groupBox2.TabIndex = 0;
            groupBox2.ThemeAuthor = "Terry D. Eppler";
            groupBox2.ThemeName = "BudgetExecution";
            groupBox2.ToolTip = null;
            // 
            // groupBox3
            // 
            groupBox3.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            groupBox3.BackColor = System.Drawing.Color.Transparent;
            groupBox3.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            groupBox3.BindingSource = null;
            groupBox3.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            groupBox3.BorderThickness = 1;
            groupBox3.Children = null;
            groupBox3.DataFilter = null;
            groupBox3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            groupBox3.ForeColor = System.Drawing.Color.Transparent;
            groupBox3.HoverText = null;
            groupBox3.IsDerivedStyle = true;
            groupBox3.Location = new System.Drawing.Point( 1, 1 );
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding( 1 );
            groupBox3.Size = new System.Drawing.Size( 250, 150 );
            groupBox3.Style = MetroSet_UI.Enums.Style.Custom;
            groupBox3.StyleManager = null;
            groupBox3.TabIndex = 0;
            groupBox3.ThemeAuthor = "Terry D. Eppler";
            groupBox3.ThemeName = "BudgetExecution";
            groupBox3.ToolTip = null;
            // 
            // groupBox4
            // 
            groupBox4.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            groupBox4.BackColor = System.Drawing.Color.Transparent;
            groupBox4.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            groupBox4.BindingSource = null;
            groupBox4.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            groupBox4.BorderThickness = 1;
            groupBox4.Children = null;
            groupBox4.DataFilter = null;
            groupBox4.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            groupBox4.ForeColor = System.Drawing.Color.Transparent;
            groupBox4.HoverText = null;
            groupBox4.IsDerivedStyle = true;
            groupBox4.Location = new System.Drawing.Point( 1, 1 );
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding( 1 );
            groupBox4.Size = new System.Drawing.Size( 250, 150 );
            groupBox4.Style = MetroSet_UI.Enums.Style.Custom;
            groupBox4.StyleManager = null;
            groupBox4.TabIndex = 0;
            groupBox4.ThemeAuthor = "Terry D. Eppler";
            groupBox4.ThemeName = "BudgetExecution";
            groupBox4.ToolTip = null;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = System.Drawing.Color.Transparent;
            groupBox9.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            groupBox9.BindingSource = null;
            groupBox9.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            groupBox9.BorderThickness = 1;
            groupBox9.Children = null;
            groupBox9.DataFilter = null;
            groupBox9.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            groupBox9.ForeColor = System.Drawing.Color.Transparent;
            groupBox9.HoverText = null;
            groupBox9.IsDerivedStyle = true;
            groupBox9.Location = new System.Drawing.Point( 1, 1 );
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new System.Windows.Forms.Padding( 1 );
            groupBox9.Size = new System.Drawing.Size( 250, 150 );
            groupBox9.Style = MetroSet_UI.Enums.Style.Custom;
            groupBox9.StyleManager = null;
            groupBox9.TabIndex = 0;
            groupBox9.ThemeAuthor = "Terry D. Eppler";
            groupBox9.ThemeName = "BudgetExecution";
            groupBox9.ToolTip = null;
            // 
            // LookupDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClientSize = new System.Drawing.Size( 1298, 681 );
            ControlBox = false;
            Controls.Add( SelectButton );
            Controls.Add( TabControl );
            Controls.Add( RefreshButton );
            Controls.Add( CloseButton );
            ForeColor = System.Drawing.Color.LightSteelBlue;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximumSize = new System.Drawing.Size( 1310, 693 );
            MinimumSize = new System.Drawing.Size( 1310, 691 );
            Name = "LookupDialog";
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) TabControl  ).EndInit( );
            TabControl.ResumeLayout( false );
            LookupTabPage.ResumeLayout( false );
            ColumnTable.ResumeLayout( false );
            ColumnPanel.ResumeLayout( false );
            ProviderTable.ResumeLayout( false );
            ProviderPanel.ResumeLayout( false );
            ValueTable.ResumeLayout( false );
            ValuePanel.ResumeLayout( false );
            SourceTable.ResumeLayout( false );
            TablePanel.ResumeLayout( false );
            tabPageAdv1.ResumeLayout( false );
            groupBox7.ResumeLayout( false );
            groupBox8.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public RadioButton AccessRadioButton;
        public RadioButton SqlServerRadioButton;
        public RadioButton SqliteRadioButton;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button RefreshButton;
        public Button CloseButton;
        public Button SelectButton;
        public Layout groupBox2;
        public Layout groupBox3;
        public Layout groupBox4;
        public ListBox ValueListBox;
        public ListBox ColumnListBox;
        public ListBox TableListBox;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv LookupTabPage;
        public Layout groupBox7;
        public ListBox listBox5;
        public ListBox listBox6;
        public Layout groupBox8;
        public BudgetExecution.ComboBox visualComboBox3;
        public BudgetExecution.Label visualLabel3;
        public BudgetExecution.Label visualLabel5;
        public BudgetExecution.TextBox visualTextBox3;
        public Layout groupBox9;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        public Layout ProviderPanel;
        public Layout ValuePanel;
        public Layout ColumnPanel;
        public Layout TablePanel;
        public HeaderPanel ColumnTable;
        public HeaderPanel ProviderTable;
        public HeaderPanel ValueTable;
        public HeaderPanel SourceTable;
        public RadioButton SqlCeRadioButton;
    }
}