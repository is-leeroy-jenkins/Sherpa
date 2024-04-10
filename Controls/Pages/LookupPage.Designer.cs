namespace BudgetExecution
{


    partial class LookupPage
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( LookupPage ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv( );
            DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            ColumnTable = new HeaderPanel( );
            ColumnPanel = new BackPanel( );
            ColumnListBox = new ListBox( );
            ToolTip = new SmallTip( );
            ProviderTable = new HeaderPanel( );
            ProviderPanel = new BackPanel( );
            SqlCeRadioButton = new RadioButton( );
            SQLiteRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SqlServerRadioButton = new RadioButton( );
            ValueTable = new HeaderPanel( );
            ValuePanel = new BackPanel( );
            ValueListBox = new ListBox( );
            SourceTable = new HeaderPanel( );
            TablePanel = new BackPanel( );
            TableListBox = new ListBox( );
            BusyTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            SelectButton = new Button( );
            RefreshButton = new Button( );
            CloseButton = new Button( );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            DataTab.SuspendLayout( );
            ColumnTable.SuspendLayout( );
            ColumnPanel.SuspendLayout( );
            ProviderTable.SuspendLayout( );
            ProviderPanel.SuspendLayout( );
            ValueTable.SuspendLayout( );
            ValuePanel.SuspendLayout( );
            SourceTable.SuspendLayout( );
            TablePanel.SuspendLayout( );
            SuspendLayout( );
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 1330, 517 );
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( DataTab );
            TabControl.Controls.Add( BusyTab );
            TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.FocusOnTabClick = false;
            TabControl.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 158, 23 );
            TabControl.Location = new System.Drawing.Point( 0, 0 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 1330, 517 );
            TabControl.TabIndex = 8;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            // 
            // DataTab
            // 
            DataTab.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataTab.Controls.Add( ColumnTable );
            DataTab.Controls.Add( ProviderTable );
            DataTab.Controls.Add( ValueTable );
            DataTab.Controls.Add( SourceTable );
            DataTab.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DataTab.ForeColor = System.Drawing.Color.LightSteelBlue;
            DataTab.Image = null;
            DataTab.ImageSize = new System.Drawing.Size( 12, 12 );
            DataTab.Location = new System.Drawing.Point( 0, 22 );
            DataTab.Name = "DataTab";
            DataTab.ShowCloseButton = true;
            DataTab.Size = new System.Drawing.Size( 1330, 495 );
            DataTab.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataTab.TabForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DataTab.TabIndex = 2;
            DataTab.Text = "  Look Up";
            DataTab.ThemesEnabled = false;
            // 
            // ColumnTable
            // 
            ColumnTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ColumnTable.CaptionText = "Columns";
            ColumnTable.ColumnCount = 1;
            ColumnTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ColumnTable.Controls.Add( ColumnPanel, 0, 1 );
            ColumnTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ColumnTable.ForeColor = System.Drawing.Color.DarkGray;
            ColumnTable.Location = new System.Drawing.Point( 191, 278 );
            ColumnTable.Name = "ColumnTable";
            ColumnTable.RowCount = 2;
            ColumnTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 8.465609F ) );
            ColumnTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 91.53439F ) );
            ColumnTable.Size = new System.Drawing.Size( 412, 205 );
            ColumnTable.TabIndex = 16;
            // 
            // ColumnPanel
            // 
            ColumnPanel.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ColumnPanel.BackColor = System.Drawing.Color.Transparent;
            ColumnPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnPanel.BindingSource = null;
            ColumnPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ColumnPanel.BorderThickness = 1;
            ColumnPanel.Children = null;
            ColumnPanel.Controls.Add( ColumnListBox );
            ColumnPanel.DataFilter = null;
            ColumnPanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ColumnPanel.ForeColor = System.Drawing.Color.Transparent;
            ColumnPanel.HoverText = null;
            ColumnPanel.IsDerivedStyle = true;
            ColumnPanel.Location = new System.Drawing.Point( 3, 35 );
            ColumnPanel.Name = "ColumnPanel";
            ColumnPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ColumnPanel.Size = new System.Drawing.Size( 406, 167 );
            ColumnPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ColumnPanel.StyleManager = null;
            ColumnPanel.TabIndex = 8;
            ColumnPanel.ThemeAuthor = "Terry D. Eppler";
            ColumnPanel.ThemeName = "BudgetExecution";
            ColumnPanel.ToolTip = null;
            // 
            // ColumnListBox
            // 
            ColumnListBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ColumnListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ColumnListBox.BindingSource = null;
            ColumnListBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            ColumnListBox.DataFilter = null;
            ColumnListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnListBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ColumnListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ColumnListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ColumnListBox.HoverText = null;
            ColumnListBox.IsDerivedStyle = true;
            ColumnListBox.ItemHeight = 30;
            ColumnListBox.Location = new System.Drawing.Point( 16, 13 );
            ColumnListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ColumnListBox.MultiSelect = false;
            ColumnListBox.Name = "ColumnListBox";
            ColumnListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ColumnListBox.SelectedIndex = -1;
            ColumnListBox.SelectedItem = null;
            ColumnListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ColumnListBox.SelectedItemColor = System.Drawing.Color.White;
            ColumnListBox.SelectedText = null;
            ColumnListBox.SelectedValue = null;
            ColumnListBox.ShowBorder = false;
            ColumnListBox.ShowScrollBar = false;
            ColumnListBox.Size = new System.Drawing.Size( 375, 141 );
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
            // ProviderTable
            // 
            ProviderTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ProviderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ProviderTable.CaptionText = "Databases";
            ProviderTable.ColumnCount = 1;
            ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ProviderTable.Controls.Add( ProviderPanel, 0, 1 );
            ProviderTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ProviderTable.ForeColor = System.Drawing.Color.DarkGray;
            ProviderTable.Location = new System.Drawing.Point( 191, 41 );
            ProviderTable.Name = "ProviderTable";
            ProviderTable.RowCount = 2;
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 7.9365077F ) );
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 92.06349F ) );
            ProviderTable.Size = new System.Drawing.Size( 412, 205 );
            ProviderTable.TabIndex = 15;
            // 
            // ProviderPanel
            // 
            ProviderPanel.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ProviderPanel.BackColor = System.Drawing.Color.Transparent;
            ProviderPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ProviderPanel.BindingSource = null;
            ProviderPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ProviderPanel.BorderThickness = 1;
            ProviderPanel.Children = null;
            ProviderPanel.Controls.Add( SqlCeRadioButton );
            ProviderPanel.Controls.Add( SQLiteRadioButton );
            ProviderPanel.Controls.Add( AccessRadioButton );
            ProviderPanel.Controls.Add( SqlServerRadioButton );
            ProviderPanel.DataFilter = null;
            ProviderPanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ProviderPanel.ForeColor = System.Drawing.Color.Transparent;
            ProviderPanel.HoverText = null;
            ProviderPanel.IsDerivedStyle = true;
            ProviderPanel.Location = new System.Drawing.Point( 3, 34 );
            ProviderPanel.Name = "ProviderPanel";
            ProviderPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ProviderPanel.Size = new System.Drawing.Size( 406, 168 );
            ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ProviderPanel.StyleManager = null;
            ProviderPanel.TabIndex = 5;
            ProviderPanel.ThemeAuthor = "Terry D. Eppler";
            ProviderPanel.ThemeName = "BudgetExecution";
            ProviderPanel.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            SqlCeRadioButton.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            SqlCeRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlCeRadioButton.Group = 0;
            SqlCeRadioButton.HoverText = null;
            SqlCeRadioButton.IsDerivedStyle = true;
            SqlCeRadioButton.Location = new System.Drawing.Point( 146, 124 );
            SqlCeRadioButton.Name = "SqlCeRadioButton";
            SqlCeRadioButton.Result = null;
            SqlCeRadioButton.Size = new System.Drawing.Size( 140, 17 );
            SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlCeRadioButton.StyleManager = null;
            SqlCeRadioButton.TabIndex = 4;
            SqlCeRadioButton.Tag = "SqlCe";
            SqlCeRadioButton.Text = "    SQL Compact";
            SqlCeRadioButton.ThemeAuthor = "Narwin";
            SqlCeRadioButton.ThemeName = "MetroDark";
            SqlCeRadioButton.ToolTip = ToolTip;
            // 
            // SQLiteRadioButton
            // 
            SQLiteRadioButton.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            SQLiteRadioButton.BackColor = System.Drawing.Color.Transparent;
            SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            SQLiteRadioButton.Checked = false;
            SQLiteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SQLiteRadioButton.Group = 0;
            SQLiteRadioButton.HoverText = null;
            SQLiteRadioButton.IsDerivedStyle = true;
            SQLiteRadioButton.Location = new System.Drawing.Point( 146, 22 );
            SQLiteRadioButton.Name = "SQLiteRadioButton";
            SQLiteRadioButton.Result = null;
            SQLiteRadioButton.Size = new System.Drawing.Size( 118, 17 );
            SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SQLiteRadioButton.StyleManager = null;
            SQLiteRadioButton.TabIndex = 1;
            SQLiteRadioButton.Tag = "SQLite";
            SQLiteRadioButton.Text = "    SQLite";
            SQLiteRadioButton.ThemeAuthor = "Narwin";
            SQLiteRadioButton.ThemeName = "MetroDark";
            SQLiteRadioButton.ToolTip = ToolTip;
            // 
            // AccessRadioButton
            // 
            AccessRadioButton.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            AccessRadioButton.BackColor = System.Drawing.Color.Transparent;
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            AccessRadioButton.Group = 0;
            AccessRadioButton.HoverText = null;
            AccessRadioButton.IsDerivedStyle = true;
            AccessRadioButton.Location = new System.Drawing.Point( 146, 86 );
            AccessRadioButton.Name = "AccessRadioButton";
            AccessRadioButton.Result = null;
            AccessRadioButton.Size = new System.Drawing.Size( 140, 17 );
            AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            AccessRadioButton.StyleManager = null;
            AccessRadioButton.TabIndex = 3;
            AccessRadioButton.Tag = "Access";
            AccessRadioButton.Text = "    MS Access";
            AccessRadioButton.ThemeAuthor = "Narwin";
            AccessRadioButton.ThemeName = "MetroDark";
            AccessRadioButton.ToolTip = ToolTip;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            SqlServerRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlServerRadioButton.Group = 0;
            SqlServerRadioButton.HoverText = null;
            SqlServerRadioButton.IsDerivedStyle = true;
            SqlServerRadioButton.Location = new System.Drawing.Point( 146, 54 );
            SqlServerRadioButton.Name = "SqlServerRadioButton";
            SqlServerRadioButton.Result = null;
            SqlServerRadioButton.Size = new System.Drawing.Size( 140, 17 );
            SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlServerRadioButton.StyleManager = null;
            SqlServerRadioButton.TabIndex = 2;
            SqlServerRadioButton.Tag = "SqlServer";
            SqlServerRadioButton.Text = "    SQL Server";
            SqlServerRadioButton.ThemeAuthor = "Narwin";
            SqlServerRadioButton.ThemeName = "MetroDark";
            SqlServerRadioButton.ToolTip = ToolTip;
            // 
            // ValueTable
            // 
            ValueTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValueTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ValueTable.CaptionText = "Values ";
            ValueTable.ColumnCount = 1;
            ValueTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ValueTable.Controls.Add( ValuePanel, 0, 1 );
            ValueTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ValueTable.ForeColor = System.Drawing.Color.DarkGray;
            ValueTable.Location = new System.Drawing.Point( 715, 275 );
            ValueTable.Name = "ValueTable";
            ValueTable.RowCount = 2;
            ValueTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 8.465609F ) );
            ValueTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 91.53439F ) );
            ValueTable.Size = new System.Drawing.Size( 412, 205 );
            ValueTable.TabIndex = 14;
            // 
            // ValuePanel
            // 
            ValuePanel.BackColor = System.Drawing.Color.Transparent;
            ValuePanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValuePanel.BindingSource = null;
            ValuePanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ValuePanel.BorderThickness = 1;
            ValuePanel.Children = null;
            ValuePanel.Controls.Add( ValueListBox );
            ValuePanel.DataFilter = null;
            ValuePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ValuePanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ValuePanel.ForeColor = System.Drawing.Color.Transparent;
            ValuePanel.HoverText = null;
            ValuePanel.IsDerivedStyle = true;
            ValuePanel.Location = new System.Drawing.Point( 3, 35 );
            ValuePanel.Name = "ValuePanel";
            ValuePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ValuePanel.Size = new System.Drawing.Size( 406, 167 );
            ValuePanel.Style = MetroSet_UI.Enums.Style.Custom;
            ValuePanel.StyleManager = null;
            ValuePanel.TabIndex = 9;
            ValuePanel.ThemeAuthor = "Terry D. Eppler";
            ValuePanel.ThemeName = "BudgetExecution";
            ValuePanel.ToolTip = null;
            // 
            // ValueListBox
            // 
            ValueListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ValueListBox.BindingSource = null;
            ValueListBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            ValueListBox.DataFilter = null;
            ValueListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValueListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValueListBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ValueListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ValueListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ValueListBox.HoverText = null;
            ValueListBox.IsDerivedStyle = true;
            ValueListBox.ItemHeight = 30;
            ValueListBox.Location = new System.Drawing.Point( 15, 13 );
            ValueListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ValueListBox.MultiSelect = false;
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ValueListBox.SelectedIndex = -1;
            ValueListBox.SelectedItem = null;
            ValueListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ValueListBox.SelectedItemColor = System.Drawing.Color.White;
            ValueListBox.SelectedText = null;
            ValueListBox.SelectedValue = null;
            ValueListBox.ShowBorder = false;
            ValueListBox.ShowScrollBar = false;
            ValueListBox.Size = new System.Drawing.Size( 375, 141 );
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
            SourceTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SourceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourceTable.CaptionText = "Tables";
            SourceTable.ColumnCount = 1;
            SourceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SourceTable.Controls.Add( TablePanel, 0, 1 );
            SourceTable.Font = new System.Drawing.Font( "Roboto", 9F );
            SourceTable.ForeColor = System.Drawing.Color.DarkGray;
            SourceTable.Location = new System.Drawing.Point( 712, 41 );
            SourceTable.Name = "SourceTable";
            SourceTable.RowCount = 2;
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 7.075472F ) );
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 92.92453F ) );
            SourceTable.Size = new System.Drawing.Size( 412, 205 );
            SourceTable.TabIndex = 13;
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
            TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TablePanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TablePanel.ForeColor = System.Drawing.Color.Transparent;
            TablePanel.HoverText = null;
            TablePanel.IsDerivedStyle = true;
            TablePanel.Location = new System.Drawing.Point( 3, 32 );
            TablePanel.Name = "TablePanel";
            TablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            TablePanel.Size = new System.Drawing.Size( 406, 170 );
            TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            TablePanel.StyleManager = null;
            TablePanel.TabIndex = 7;
            TablePanel.ThemeAuthor = "Terry D. Eppler";
            TablePanel.ThemeName = "BudgetExecution";
            TablePanel.ToolTip = null;
            // 
            // TableListBox
            // 
            TableListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            TableListBox.BindingSource = null;
            TableListBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TableListBox.DataFilter = null;
            TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            TableListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            TableListBox.HoverText = null;
            TableListBox.IsDerivedStyle = true;
            TableListBox.ItemHeight = 30;
            TableListBox.Location = new System.Drawing.Point( 15, 15 );
            TableListBox.Margin = new System.Windows.Forms.Padding( 1 );
            TableListBox.MultiSelect = false;
            TableListBox.Name = "TableListBox";
            TableListBox.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBox.SelectedIndex = -1;
            TableListBox.SelectedItem = null;
            TableListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableListBox.SelectedItemColor = System.Drawing.Color.White;
            TableListBox.SelectedText = null;
            TableListBox.SelectedValue = null;
            TableListBox.ShowBorder = false;
            TableListBox.ShowScrollBar = false;
            TableListBox.Size = new System.Drawing.Size( 375, 141 );
            TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBox.StyleManager = null;
            TableListBox.TabIndex = 1;
            TableListBox.Text = "Tables";
            TableListBox.ThemeAuthor = "Terry D. Eppler";
            TableListBox.ThemeName = "BudgetExecution";
            TableListBox.ToolTip = ToolTip;
            // 
            // BusyTab
            // 
            BusyTab.Image = null;
            BusyTab.ImageSize = new System.Drawing.Size( 16, 16 );
            BusyTab.Location = new System.Drawing.Point( 0, 22 );
            BusyTab.Name = "BusyTab";
            BusyTab.ShowCloseButton = true;
            BusyTab.Size = new System.Drawing.Size( 1330, 495 );
            BusyTab.TabIndex = 3;
            BusyTab.ThemesEnabled = false;
            // 
            // SelectButton
            // 
            SelectButton.BackColor = System.Drawing.Color.Transparent;
            SelectButton.BindingSource = null;
            SelectButton.DataFilter = null;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SelectButton.HoverText = "Not Yet Implemented!";
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 614, 581 );
            SelectButton.Margin = new System.Windows.Forms.Padding( 0 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 90, 30 );
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
            RefreshButton.BindingSource = null;
            RefreshButton.DataFilter = null;
            RefreshButton.DisabledBackColor = System.Drawing.Color.Transparent;
            RefreshButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            RefreshButton.DisabledForeColor = System.Drawing.Color.Transparent;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RefreshButton.HoverBorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RefreshButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            RefreshButton.HoverText = "Not Yet Implemented!";
            RefreshButton.HoverTextColor = System.Drawing.Color.White;
            RefreshButton.IsDerivedStyle = true;
            RefreshButton.Location = new System.Drawing.Point( 191, 581 );
            RefreshButton.Margin = new System.Windows.Forms.Padding( 0 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            RefreshButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            RefreshButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            RefreshButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            RefreshButton.PressTextColor = System.Drawing.Color.White;
            RefreshButton.Size = new System.Drawing.Size( 90, 30 );
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
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = "Close Window";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 1037, 581 );
            CloseButton.Margin = new System.Windows.Forms.Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "BudgetExecution";
            CloseButton.ToolTip = ToolTip;
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // LookupPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F );
            ClientSize = new System.Drawing.Size( 1330, 638 );
            ControlBox = false;
            Controls.Add( SelectButton );
            Controls.Add( TabControl );
            Controls.Add( RefreshButton );
            Controls.Add( CloseButton );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1340, 648 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1320, 628 );
            Name = "LookupPage";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            DataTab.ResumeLayout( false );
            ColumnTable.ResumeLayout( false );
            ColumnPanel.ResumeLayout( false );
            ProviderTable.ResumeLayout( false );
            ProviderPanel.ResumeLayout( false );
            ValueTable.ResumeLayout( false );
            ValuePanel.ResumeLayout( false );
            SourceTable.ResumeLayout( false );
            TablePanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public RadioButton AccessRadioButton;
        public RadioButton SqlServerRadioButton;
        public RadioButton SQLiteRadioButton;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button RefreshButton;
        public Button CloseButton;
        public Button SelectButton;
        public ListBox ValueListBox;
        public ListBox ColumnListBox;
        public ListBox TableListBox;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv DataTab;
        public BackPanel ProviderPanel;
        public BackPanel ValuePanel;
        public BackPanel ColumnPanel;
        public BackPanel TablePanel;
        public HeaderPanel ColumnTable;
        public HeaderPanel ProviderTable;
        public HeaderPanel ValueTable;
        public HeaderPanel SourceTable;
        public RadioButton SqlCeRadioButton;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTab;
        public System.Windows.Forms.Timer Timer;
    }
}