namespace Sherpa
{


    partial class SchemaPage
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SchemaPage ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv( );
            DataTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            ProviderTable = new HeaderPanel( );
            ProviderPanel = new BackPanel( );
            SqlCeRadioButton = new RadioButton( );
            ToolTip = new SmallTip( );
            SQLiteRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SqlServerRadioButton = new RadioButton( );
            SchemaTable = new HeaderPanel( );
            SchemaLayout = new BackPanel( );
            DeleteColumnButton = new Button( );
            AddColumnButton = new Button( );
            SelectDataTypeLable = new Label( );
            AddColumnLabel = new Label( );
            AddColumnTextBox = new TextBox( );
            DataTypeComboBox = new ComboBox( );
            SourceTable = new HeaderPanel( );
            TablePanel = new BackPanel( );
            AddTableLabel = new Label( );
            DeleteTableButton = new Button( );
            AddTableButton = new Button( );
            SelectTableLabel = new Label( );
            TableNameComboBox = new ComboBox( );
            TableNameTextBox = new TextBox( );
            BusyTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            LoadingPanel = new BackPanel( );
            Loader = new Picture( );
            SelectButton = new Button( );
            ClearButton = new Button( );
            CloseButton = new Button( );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            DataTab.SuspendLayout( );
            ProviderTable.SuspendLayout( );
            ProviderPanel.SuspendLayout( );
            SchemaTable.SuspendLayout( );
            SchemaLayout.SuspendLayout( );
            SourceTable.SuspendLayout( );
            TablePanel.SuspendLayout( );
            BusyTab.SuspendLayout( );
            LoadingPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Loader ).BeginInit( );
            SuspendLayout( );
            // 
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 9F );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 1318, 503 );
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( DataTab );
            TabControl.Controls.Add( BusyTab );
            TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.FocusOnTabClick = false;
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 158, 23 );
            TabControl.Location = new System.Drawing.Point( 0, 0 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 1318, 503 );
            TabControl.TabIndex = 8;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb( 15, 15, 15 );
            TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 9F );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            // 
            // DataTab
            // 
            DataTab.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataTab.Controls.Add( ProviderTable );
            DataTab.Controls.Add( SchemaTable );
            DataTab.Controls.Add( SourceTable );
            DataTab.ForeColor = System.Drawing.Color.LightSteelBlue;
            DataTab.Image = null;
            DataTab.ImageSize = new System.Drawing.Size( 16, 16 );
            DataTab.Location = new System.Drawing.Point( 0, 22 );
            DataTab.Name = "DataTab";
            DataTab.ShowCloseButton = true;
            DataTab.Size = new System.Drawing.Size( 1318, 481 );
            DataTab.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataTab.TabForeColor = System.Drawing.Color.LightGray;
            DataTab.TabIndex = 3;
            DataTab.ThemesEnabled = false;
            // 
            // ProviderTable
            // 
            ProviderTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ProviderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ProviderTable.CaptionText = "Providers";
            ProviderTable.ColumnCount = 1;
            ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ProviderTable.Controls.Add( ProviderPanel, 0, 1 );
            ProviderTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ProviderTable.ForeColor = System.Drawing.Color.DarkGray;
            ProviderTable.Location = new System.Drawing.Point( 38, 144 );
            ProviderTable.Name = "ProviderTable";
            ProviderTable.RowCount = 2;
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 5.52147245F ) );
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 94.47853F ) );
            ProviderTable.Size = new System.Drawing.Size( 375, 214 );
            ProviderTable.TabIndex = 15;
            // 
            // ProviderPanel
            // 
            ProviderPanel.BackColor = System.Drawing.Color.Transparent;
            ProviderPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ProviderPanel.BindingSource = null;
            ProviderPanel.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            ProviderPanel.BorderThickness = 1;
            ProviderPanel.Children = null;
            ProviderPanel.Controls.Add( SqlCeRadioButton );
            ProviderPanel.Controls.Add( SQLiteRadioButton );
            ProviderPanel.Controls.Add( AccessRadioButton );
            ProviderPanel.Controls.Add( SqlServerRadioButton );
            ProviderPanel.DataFilter = null;
            ProviderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ProviderPanel.Font = new System.Drawing.Font( "Roboto", 9F );
            ProviderPanel.ForeColor = System.Drawing.Color.Transparent;
            ProviderPanel.HoverText = null;
            ProviderPanel.IsDerivedStyle = true;
            ProviderPanel.Location = new System.Drawing.Point( 3, 29 );
            ProviderPanel.Name = "ProviderPanel";
            ProviderPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ProviderPanel.Size = new System.Drawing.Size( 369, 182 );
            ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ProviderPanel.StyleManager = null;
            ProviderPanel.TabIndex = 7;
            ProviderPanel.ThemeAuthor = "Terry D. Eppler";
            ProviderPanel.ThemeName = "Sherpa";
            ProviderPanel.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            SqlCeRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlCeRadioButton.Group = 0;
            SqlCeRadioButton.HoverText = null;
            SqlCeRadioButton.IsDerivedStyle = true;
            SqlCeRadioButton.Location = new System.Drawing.Point( 112, 145 );
            SqlCeRadioButton.Name = "SqlCeRadioButton";
            SqlCeRadioButton.Result = null;
            SqlCeRadioButton.Size = new System.Drawing.Size( 186, 17 );
            SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlCeRadioButton.StyleManager = null;
            SqlCeRadioButton.TabIndex = 4;
            SqlCeRadioButton.Tag = "SqlCe";
            SqlCeRadioButton.Text = "    SQL Compact  ( *.sdf )";
            SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlCeRadioButton.ThemeName = "Sherpa";
            SqlCeRadioButton.ToolTip = ToolTip;
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
            ToolTip.ThemeName = "Sherpa";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // SQLiteRadioButton
            // 
            SQLiteRadioButton.BackColor = System.Drawing.Color.Transparent;
            SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SQLiteRadioButton.Checked = false;
            SQLiteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SQLiteRadioButton.Group = 0;
            SQLiteRadioButton.HoverText = null;
            SQLiteRadioButton.IsDerivedStyle = true;
            SQLiteRadioButton.Location = new System.Drawing.Point( 112, 14 );
            SQLiteRadioButton.Name = "SQLiteRadioButton";
            SQLiteRadioButton.Result = null;
            SQLiteRadioButton.Size = new System.Drawing.Size( 186, 17 );
            SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SQLiteRadioButton.StyleManager = null;
            SQLiteRadioButton.TabIndex = 1;
            SQLiteRadioButton.Tag = "SQLite";
            SQLiteRadioButton.Text = "    SQLite  ( *.db )";
            SQLiteRadioButton.ThemeAuthor = "Narwin";
            SQLiteRadioButton.ThemeName = "MetroDark";
            SQLiteRadioButton.ToolTip = ToolTip;
            // 
            // AccessRadioButton
            // 
            AccessRadioButton.BackColor = System.Drawing.Color.Transparent;
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            AccessRadioButton.Group = 0;
            AccessRadioButton.HoverText = null;
            AccessRadioButton.IsDerivedStyle = true;
            AccessRadioButton.Location = new System.Drawing.Point( 112, 102 );
            AccessRadioButton.Name = "AccessRadioButton";
            AccessRadioButton.Result = null;
            AccessRadioButton.Size = new System.Drawing.Size( 186, 17 );
            AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            AccessRadioButton.StyleManager = null;
            AccessRadioButton.TabIndex = 3;
            AccessRadioButton.Tag = "Access";
            AccessRadioButton.Text = "    MS Access  ( *.accdb )";
            AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
            AccessRadioButton.ThemeName = "Sherpa";
            AccessRadioButton.ToolTip = ToolTip;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.BackColor = System.Drawing.Color.Transparent;
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 85, 85, 85 );
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlServerRadioButton.Group = 0;
            SqlServerRadioButton.HoverText = null;
            SqlServerRadioButton.IsDerivedStyle = true;
            SqlServerRadioButton.Location = new System.Drawing.Point( 112, 56 );
            SqlServerRadioButton.Name = "SqlServerRadioButton";
            SqlServerRadioButton.Result = null;
            SqlServerRadioButton.Size = new System.Drawing.Size( 186, 17 );
            SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlServerRadioButton.StyleManager = null;
            SqlServerRadioButton.TabIndex = 2;
            SqlServerRadioButton.Tag = "SqlServer";
            SqlServerRadioButton.Text = "    SQL Server  ( *.mdf )";
            SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlServerRadioButton.ThemeName = "Sherpa";
            SqlServerRadioButton.ToolTip = ToolTip;
            // 
            // SchemaTable
            // 
            SchemaTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SchemaTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SchemaTable.CaptionText = "Column";
            SchemaTable.ColumnCount = 1;
            SchemaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SchemaTable.Controls.Add( SchemaLayout, 0, 1 );
            SchemaTable.Font = new System.Drawing.Font( "Roboto", 9F );
            SchemaTable.ForeColor = System.Drawing.Color.DarkGray;
            SchemaTable.Location = new System.Drawing.Point( 896, 144 );
            SchemaTable.Name = "SchemaTable";
            SchemaTable.RowCount = 2;
            SchemaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 5.15021467F ) );
            SchemaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 94.8497849F ) );
            SchemaTable.Size = new System.Drawing.Size( 385, 214 );
            SchemaTable.TabIndex = 14;
            // 
            // SchemaLayout
            // 
            SchemaLayout.BackColor = System.Drawing.Color.Transparent;
            SchemaLayout.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SchemaLayout.BindingSource = null;
            SchemaLayout.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            SchemaLayout.BorderThickness = 1;
            SchemaLayout.Children = null;
            SchemaLayout.Controls.Add( DeleteColumnButton );
            SchemaLayout.Controls.Add( AddColumnButton );
            SchemaLayout.Controls.Add( SelectDataTypeLable );
            SchemaLayout.Controls.Add( AddColumnLabel );
            SchemaLayout.Controls.Add( AddColumnTextBox );
            SchemaLayout.Controls.Add( DataTypeComboBox );
            SchemaLayout.DataFilter = null;
            SchemaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            SchemaLayout.Font = new System.Drawing.Font( "Roboto", 9F );
            SchemaLayout.ForeColor = System.Drawing.Color.Transparent;
            SchemaLayout.HoverText = null;
            SchemaLayout.IsDerivedStyle = true;
            SchemaLayout.Location = new System.Drawing.Point( 3, 29 );
            SchemaLayout.Name = "SchemaLayout";
            SchemaLayout.Padding = new System.Windows.Forms.Padding( 1 );
            SchemaLayout.Size = new System.Drawing.Size( 379, 182 );
            SchemaLayout.Style = MetroSet_UI.Enums.Style.Custom;
            SchemaLayout.StyleManager = null;
            SchemaLayout.TabIndex = 11;
            SchemaLayout.ThemeAuthor = "Terry D. Eppler";
            SchemaLayout.ThemeName = "Sherpa";
            SchemaLayout.ToolTip = null;
            // 
            // DeleteColumnButton
            // 
            DeleteColumnButton.BackColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.BindingSource = null;
            DeleteColumnButton.DataFilter = null;
            DeleteColumnButton.DisabledBackColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.DisabledForeColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DeleteColumnButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteColumnButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            DeleteColumnButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            DeleteColumnButton.HoverText = "Delete Data Column";
            DeleteColumnButton.HoverTextColor = System.Drawing.Color.White;
            DeleteColumnButton.IsDerivedStyle = true;
            DeleteColumnButton.Location = new System.Drawing.Point( 277, 37 );
            DeleteColumnButton.Margin = new System.Windows.Forms.Padding( 0 );
            DeleteColumnButton.Name = "DeleteColumnButton";
            DeleteColumnButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            DeleteColumnButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            DeleteColumnButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DeleteColumnButton.Padding = new System.Windows.Forms.Padding( 1 );
            DeleteColumnButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteColumnButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteColumnButton.PressTextColor = System.Drawing.Color.White;
            DeleteColumnButton.Size = new System.Drawing.Size( 78, 26 );
            DeleteColumnButton.Style = MetroSet_UI.Enums.Style.Custom;
            DeleteColumnButton.StyleManager = null;
            DeleteColumnButton.TabIndex = 19;
            DeleteColumnButton.Text = "Delete";
            DeleteColumnButton.ThemeAuthor = "Terry D. Eppler";
            DeleteColumnButton.ThemeName = "Sherpa";
            DeleteColumnButton.ToolTip = null;
            // 
            // AddColumnButton
            // 
            AddColumnButton.BackColor = System.Drawing.Color.Transparent;
            AddColumnButton.BindingSource = null;
            AddColumnButton.DataFilter = null;
            AddColumnButton.DisabledBackColor = System.Drawing.Color.Transparent;
            AddColumnButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddColumnButton.DisabledForeColor = System.Drawing.Color.Transparent;
            AddColumnButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddColumnButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddColumnButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddColumnButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            AddColumnButton.HoverText = "Add Data Column";
            AddColumnButton.HoverTextColor = System.Drawing.Color.White;
            AddColumnButton.IsDerivedStyle = true;
            AddColumnButton.Location = new System.Drawing.Point( 277, 118 );
            AddColumnButton.Margin = new System.Windows.Forms.Padding( 0 );
            AddColumnButton.Name = "AddColumnButton";
            AddColumnButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            AddColumnButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            AddColumnButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AddColumnButton.Padding = new System.Windows.Forms.Padding( 1 );
            AddColumnButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddColumnButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddColumnButton.PressTextColor = System.Drawing.Color.White;
            AddColumnButton.Size = new System.Drawing.Size( 78, 26 );
            AddColumnButton.Style = MetroSet_UI.Enums.Style.Custom;
            AddColumnButton.StyleManager = null;
            AddColumnButton.TabIndex = 18;
            AddColumnButton.Text = "Add";
            AddColumnButton.ThemeAuthor = "Terry D. Eppler";
            AddColumnButton.ThemeName = "Sherpa";
            AddColumnButton.ToolTip = null;
            // 
            // SelectDataTypeLable
            // 
            SelectDataTypeLable.BindingSource = null;
            SelectDataTypeLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SelectDataTypeLable.Font = new System.Drawing.Font( "Roboto", 8F );
            SelectDataTypeLable.HoverText = null;
            SelectDataTypeLable.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectDataTypeLable.IsDerivedStyle = true;
            SelectDataTypeLable.Location = new System.Drawing.Point( 26, 7 );
            SelectDataTypeLable.Margin = new System.Windows.Forms.Padding( 3 );
            SelectDataTypeLable.Name = "SelectDataTypeLable";
            SelectDataTypeLable.Padding = new System.Windows.Forms.Padding( 1 );
            SelectDataTypeLable.Size = new System.Drawing.Size( 233, 24 );
            SelectDataTypeLable.Style = MetroSet_UI.Enums.Style.Custom;
            SelectDataTypeLable.StyleManager = null;
            SelectDataTypeLable.TabIndex = 13;
            SelectDataTypeLable.Text = "Select Data Type";
            SelectDataTypeLable.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectDataTypeLable.ThemeAuthor = "Terry D. Eppler";
            SelectDataTypeLable.ThemeName = "Sherpa";
            SelectDataTypeLable.ToolTip = null;
            // 
            // AddColumnLabel
            // 
            AddColumnLabel.BindingSource = null;
            AddColumnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddColumnLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            AddColumnLabel.HoverText = null;
            AddColumnLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddColumnLabel.IsDerivedStyle = true;
            AddColumnLabel.Location = new System.Drawing.Point( 26, 83 );
            AddColumnLabel.Margin = new System.Windows.Forms.Padding( 3 );
            AddColumnLabel.Name = "AddColumnLabel";
            AddColumnLabel.Padding = new System.Windows.Forms.Padding( 1 );
            AddColumnLabel.Size = new System.Drawing.Size( 202, 23 );
            AddColumnLabel.Style = MetroSet_UI.Enums.Style.Custom;
            AddColumnLabel.StyleManager = null;
            AddColumnLabel.TabIndex = 12;
            AddColumnLabel.Text = "Enter New Column Name";
            AddColumnLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddColumnLabel.ThemeAuthor = "Terry D. Eppler";
            AddColumnLabel.ThemeName = "Sherpa";
            AddColumnLabel.ToolTip = null;
            // 
            // AddColumnTextBox
            // 
            AddColumnTextBox.AutoCompleteCustomSource = null;
            AddColumnTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            AddColumnTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            AddColumnTextBox.BindingSource = null;
            AddColumnTextBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            AddColumnTextBox.DataFilter = null;
            AddColumnTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            AddColumnTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddColumnTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            AddColumnTextBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddColumnTextBox.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddColumnTextBox.HoverText = "Enter Column Name";
            AddColumnTextBox.Image = null;
            AddColumnTextBox.IsDerivedStyle = true;
            AddColumnTextBox.Lines = null;
            AddColumnTextBox.Location = new System.Drawing.Point( 26, 112 );
            AddColumnTextBox.MaxLength = 32767;
            AddColumnTextBox.Multiline = false;
            AddColumnTextBox.Name = "AddColumnTextBox";
            AddColumnTextBox.ReadOnly = false;
            AddColumnTextBox.SelectionLength = 0;
            AddColumnTextBox.Size = new System.Drawing.Size( 221, 30 );
            AddColumnTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            AddColumnTextBox.StyleManager = null;
            AddColumnTextBox.TabIndex = 6;
            AddColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            AddColumnTextBox.ThemeAuthor = "Terry D. Eppler";
            AddColumnTextBox.ThemeName = "Sherpa";
            AddColumnTextBox.ToolTip = ToolTip;
            AddColumnTextBox.UseSystemPasswordChar = false;
            AddColumnTextBox.WatermarkText = "";
            // 
            // DataTypeComboBox
            // 
            DataTypeComboBox.AllowDrop = true;
            DataTypeComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DataTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            DataTypeComboBox.BindingSource = null;
            DataTypeComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            DataTypeComboBox.CausesValidation = false;
            DataTypeComboBox.DataFilter = null;
            DataTypeComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            DataTypeComboBox.DropDownHeight = 100;
            DataTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DataTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DataTypeComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DataTypeComboBox.FormattingEnabled = true;
            DataTypeComboBox.HoverText = null;
            DataTypeComboBox.IntegralHeight = false;
            DataTypeComboBox.IsDerivedStyle = true;
            DataTypeComboBox.ItemHeight = 24;
            DataTypeComboBox.Location = new System.Drawing.Point( 26, 37 );
            DataTypeComboBox.Name = "DataTypeComboBox";
            DataTypeComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DataTypeComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            DataTypeComboBox.Size = new System.Drawing.Size( 221, 30 );
            DataTypeComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            DataTypeComboBox.StyleManager = null;
            DataTypeComboBox.TabIndex = 11;
            DataTypeComboBox.ThemeAuthor = "Terry D. Eppler";
            DataTypeComboBox.ThemeName = "Sherpa";
            DataTypeComboBox.ToolTip = ToolTip;
            // 
            // SourceTable
            // 
            SourceTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SourceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourceTable.CaptionText = "Table";
            SourceTable.ColumnCount = 1;
            SourceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SourceTable.Controls.Add( TablePanel, 0, 1 );
            SourceTable.Font = new System.Drawing.Font( "Roboto", 9F );
            SourceTable.ForeColor = System.Drawing.Color.DarkGray;
            SourceTable.Location = new System.Drawing.Point( 442, 144 );
            SourceTable.Name = "SourceTable";
            SourceTable.RowCount = 2;
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 6.179775F ) );
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 93.82022F ) );
            SourceTable.Size = new System.Drawing.Size( 426, 214 );
            SourceTable.TabIndex = 13;
            // 
            // TablePanel
            // 
            TablePanel.BackColor = System.Drawing.Color.Transparent;
            TablePanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TablePanel.BindingSource = null;
            TablePanel.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TablePanel.BorderThickness = 1;
            TablePanel.Children = null;
            TablePanel.Controls.Add( AddTableLabel );
            TablePanel.Controls.Add( DeleteTableButton );
            TablePanel.Controls.Add( AddTableButton );
            TablePanel.Controls.Add( SelectTableLabel );
            TablePanel.Controls.Add( TableNameComboBox );
            TablePanel.Controls.Add( TableNameTextBox );
            TablePanel.DataFilter = null;
            TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TablePanel.Font = new System.Drawing.Font( "Roboto", 9F );
            TablePanel.ForeColor = System.Drawing.Color.Transparent;
            TablePanel.HoverText = null;
            TablePanel.IsDerivedStyle = true;
            TablePanel.Location = new System.Drawing.Point( 3, 31 );
            TablePanel.Name = "TablePanel";
            TablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            TablePanel.Size = new System.Drawing.Size( 420, 180 );
            TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            TablePanel.StyleManager = null;
            TablePanel.TabIndex = 10;
            TablePanel.ThemeAuthor = "Terry D. Eppler";
            TablePanel.ThemeName = "Sherpa";
            TablePanel.ToolTip = null;
            // 
            // AddTableLabel
            // 
            AddTableLabel.BindingSource = null;
            AddTableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddTableLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            AddTableLabel.HoverText = null;
            AddTableLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddTableLabel.IsDerivedStyle = true;
            AddTableLabel.Location = new System.Drawing.Point( 26, 83 );
            AddTableLabel.Margin = new System.Windows.Forms.Padding( 3 );
            AddTableLabel.Name = "AddTableLabel";
            AddTableLabel.Padding = new System.Windows.Forms.Padding( 1 );
            AddTableLabel.Size = new System.Drawing.Size( 202, 23 );
            AddTableLabel.Style = MetroSet_UI.Enums.Style.Custom;
            AddTableLabel.StyleManager = null;
            AddTableLabel.TabIndex = 18;
            AddTableLabel.Text = "Enter New Table Name";
            AddTableLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddTableLabel.ThemeAuthor = "Terry D. Eppler";
            AddTableLabel.ThemeName = "Sherpa";
            AddTableLabel.ToolTip = null;
            // 
            // DeleteTableButton
            // 
            DeleteTableButton.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            DeleteTableButton.BackColor = System.Drawing.Color.Transparent;
            DeleteTableButton.BindingSource = null;
            DeleteTableButton.DataFilter = null;
            DeleteTableButton.DisabledBackColor = System.Drawing.Color.Transparent;
            DeleteTableButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            DeleteTableButton.DisabledForeColor = System.Drawing.Color.Transparent;
            DeleteTableButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DeleteTableButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            DeleteTableButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            DeleteTableButton.HoverText = "Delete Data Table";
            DeleteTableButton.HoverTextColor = System.Drawing.Color.White;
            DeleteTableButton.IsDerivedStyle = true;
            DeleteTableButton.Location = new System.Drawing.Point( 319, 35 );
            DeleteTableButton.Margin = new System.Windows.Forms.Padding( 0 );
            DeleteTableButton.Name = "DeleteTableButton";
            DeleteTableButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            DeleteTableButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            DeleteTableButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DeleteTableButton.Padding = new System.Windows.Forms.Padding( 1 );
            DeleteTableButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.PressTextColor = System.Drawing.Color.White;
            DeleteTableButton.Size = new System.Drawing.Size( 78, 26 );
            DeleteTableButton.Style = MetroSet_UI.Enums.Style.Custom;
            DeleteTableButton.StyleManager = null;
            DeleteTableButton.TabIndex = 17;
            DeleteTableButton.Text = "Delete";
            DeleteTableButton.ThemeAuthor = "Terry D. Eppler";
            DeleteTableButton.ThemeName = "Sherpa";
            DeleteTableButton.ToolTip = null;
            // 
            // AddTableButton
            // 
            AddTableButton.BackColor = System.Drawing.Color.Transparent;
            AddTableButton.BindingSource = null;
            AddTableButton.DataFilter = null;
            AddTableButton.DisabledBackColor = System.Drawing.Color.Transparent;
            AddTableButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddTableButton.DisabledForeColor = System.Drawing.Color.Transparent;
            AddTableButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddTableButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddTableButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddTableButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            AddTableButton.HoverText = "Add Data Table";
            AddTableButton.HoverTextColor = System.Drawing.Color.White;
            AddTableButton.IsDerivedStyle = true;
            AddTableButton.Location = new System.Drawing.Point( 319, 116 );
            AddTableButton.Margin = new System.Windows.Forms.Padding( 0 );
            AddTableButton.Name = "AddTableButton";
            AddTableButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            AddTableButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            AddTableButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AddTableButton.Padding = new System.Windows.Forms.Padding( 1 );
            AddTableButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddTableButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddTableButton.PressTextColor = System.Drawing.Color.White;
            AddTableButton.Size = new System.Drawing.Size( 78, 26 );
            AddTableButton.Style = MetroSet_UI.Enums.Style.Custom;
            AddTableButton.StyleManager = null;
            AddTableButton.TabIndex = 15;
            AddTableButton.Text = "Add";
            AddTableButton.ThemeAuthor = "Terry D. Eppler";
            AddTableButton.ThemeName = "Sherpa";
            AddTableButton.ToolTip = null;
            // 
            // SelectTableLabel
            // 
            SelectTableLabel.BindingSource = null;
            SelectTableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SelectTableLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            SelectTableLabel.HoverText = null;
            SelectTableLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectTableLabel.IsDerivedStyle = true;
            SelectTableLabel.Location = new System.Drawing.Point( 25, 7 );
            SelectTableLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SelectTableLabel.Name = "SelectTableLabel";
            SelectTableLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SelectTableLabel.Size = new System.Drawing.Size( 233, 24 );
            SelectTableLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SelectTableLabel.StyleManager = null;
            SelectTableLabel.TabIndex = 14;
            SelectTableLabel.Text = "Select Data Table";
            SelectTableLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectTableLabel.ThemeAuthor = "Terry D. Eppler";
            SelectTableLabel.ThemeName = "Sherpa";
            SelectTableLabel.ToolTip = null;
            // 
            // TableNameComboBox
            // 
            TableNameComboBox.AllowDrop = true;
            TableNameComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableNameComboBox.BackColor = System.Drawing.Color.Transparent;
            TableNameComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            TableNameComboBox.BindingSource = null;
            TableNameComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TableNameComboBox.CausesValidation = false;
            TableNameComboBox.DataFilter = null;
            TableNameComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            TableNameComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            TableNameComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            TableNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            TableNameComboBox.DropDownHeight = 100;
            TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TableNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TableNameComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TableNameComboBox.FormattingEnabled = true;
            TableNameComboBox.HoverText = null;
            TableNameComboBox.IntegralHeight = false;
            TableNameComboBox.IsDerivedStyle = true;
            TableNameComboBox.ItemHeight = 24;
            TableNameComboBox.Location = new System.Drawing.Point( 26, 37 );
            TableNameComboBox.Name = "TableNameComboBox";
            TableNameComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableNameComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            TableNameComboBox.Size = new System.Drawing.Size( 264, 30 );
            TableNameComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableNameComboBox.StyleManager = null;
            TableNameComboBox.TabIndex = 12;
            TableNameComboBox.ThemeAuthor = "Terry D. Eppler";
            TableNameComboBox.ThemeName = "Sherpa";
            TableNameComboBox.ToolTip = ToolTip;
            // 
            // TableNameTextBox
            // 
            TableNameTextBox.AutoCompleteCustomSource = null;
            TableNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            TableNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            TableNameTextBox.BindingSource = null;
            TableNameTextBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TableNameTextBox.DataFilter = null;
            TableNameTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            TableNameTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            TableNameTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            TableNameTextBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TableNameTextBox.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            TableNameTextBox.HoverText = "New Column Name";
            TableNameTextBox.Image = null;
            TableNameTextBox.IsDerivedStyle = true;
            TableNameTextBox.Lines = null;
            TableNameTextBox.Location = new System.Drawing.Point( 26, 112 );
            TableNameTextBox.MaxLength = 32767;
            TableNameTextBox.Multiline = false;
            TableNameTextBox.Name = "TableNameTextBox";
            TableNameTextBox.ReadOnly = false;
            TableNameTextBox.SelectionLength = 0;
            TableNameTextBox.Size = new System.Drawing.Size( 264, 30 );
            TableNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableNameTextBox.StyleManager = null;
            TableNameTextBox.TabIndex = 7;
            TableNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            TableNameTextBox.ThemeAuthor = "Terry D. Eppler";
            TableNameTextBox.ThemeName = "Sherpa";
            TableNameTextBox.ToolTip = ToolTip;
            TableNameTextBox.UseSystemPasswordChar = false;
            TableNameTextBox.WatermarkText = "";
            // 
            // BusyTab
            // 
            BusyTab.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BusyTab.Controls.Add( LoadingPanel );
            BusyTab.Image = null;
            BusyTab.ImageSize = new System.Drawing.Size( 16, 16 );
            BusyTab.Location = new System.Drawing.Point( 0, 22 );
            BusyTab.Name = "BusyTab";
            BusyTab.ShowCloseButton = true;
            BusyTab.Size = new System.Drawing.Size( 1318, 481 );
            BusyTab.TabIndex = 4;
            BusyTab.ThemesEnabled = false;
            // 
            // LoadingPanel
            // 
            LoadingPanel.BackColor = System.Drawing.Color.Transparent;
            LoadingPanel.BackgroundColor = System.Drawing.SystemColors.Desktop;
            LoadingPanel.BindingSource = null;
            LoadingPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            LoadingPanel.BorderThickness = 1;
            LoadingPanel.Children = null;
            LoadingPanel.Controls.Add( Loader );
            LoadingPanel.DataFilter = null;
            LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            LoadingPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            LoadingPanel.ForeColor = System.Drawing.Color.Transparent;
            LoadingPanel.HoverText = null;
            LoadingPanel.IsDerivedStyle = true;
            LoadingPanel.Location = new System.Drawing.Point( 0, 0 );
            LoadingPanel.Name = "LoadingPanel";
            LoadingPanel.Padding = new System.Windows.Forms.Padding( 1 );
            LoadingPanel.Size = new System.Drawing.Size( 1318, 481 );
            LoadingPanel.Style = MetroSet_UI.Enums.Style.Custom;
            LoadingPanel.StyleManager = null;
            LoadingPanel.TabIndex = 1;
            LoadingPanel.ThemeAuthor = "Terry D. Eppler";
            LoadingPanel.ThemeName = "Sherpa";
            LoadingPanel.ToolTip = null;
            // 
            // Loader
            // 
            Loader.BackColor = System.Drawing.Color.Transparent;
            Loader.BindingSource = null;
            Loader.DataFilter = null;
            Loader.HoverText = null;
            Loader.Image = Resources.Images.LoaderImages.Waiting;
            Loader.ImageList = null;
            Loader.Location = new System.Drawing.Point( 399, 52 );
            Loader.Name = "Loader";
            Loader.Padding = new System.Windows.Forms.Padding( 1 );
            Loader.Size = new System.Drawing.Size( 517, 354 );
            Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Loader.TabIndex = 0;
            Loader.TabStop = false;
            Loader.ToolTip = null;
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
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SelectButton.HoverText = "Not Yet Implemented!";
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 153, 547 );
            SelectButton.Margin = new System.Windows.Forms.Padding( 0 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 90, 28 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 7;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Sherpa";
            SelectButton.ToolTip = ToolTip;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = System.Drawing.Color.Transparent;
            ClearButton.BindingSource = null;
            ClearButton.DataFilter = null;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            ClearButton.HoverText = "Not Yet Implemented!";
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 613, 547 );
            ClearButton.Margin = new System.Windows.Forms.Padding( 0 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ClearButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 90, 28 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Sherpa";
            ClearButton.ToolTip = ToolTip;
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
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = "Exit Edit Mode";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 1112, 547 );
            CloseButton.Margin = new System.Windows.Forms.Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 28 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Sherpa";
            CloseButton.ToolTip = ToolTip;
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // SchemaPage
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
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1318, 626 );
            ControlBox = false;
            Controls.Add( SelectButton );
            Controls.Add( TabControl );
            Controls.Add( ClearButton );
            Controls.Add( CloseButton );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1340, 648 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1320, 628 );
            Name = "SchemaPage";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            DataTab.ResumeLayout( false );
            ProviderTable.ResumeLayout( false );
            ProviderPanel.ResumeLayout( false );
            SchemaTable.ResumeLayout( false );
            SchemaLayout.ResumeLayout( false );
            SourceTable.ResumeLayout( false );
            TablePanel.ResumeLayout( false );
            BusyTab.ResumeLayout( false );
            LoadingPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)Loader ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public Button ClearButton;
        public Button CloseButton;
        public Button SelectButton;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv DataTab;
        public TextBox AddColumnTextBox;
        public TextBox TableNameTextBox;
        public ComboBox DataTypeComboBox;
        private BackPanel ProviderPanel;
        public RadioButton SQLiteRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SqlServerRadioButton;
        private BackPanel SchemaLayout;
        public ComboBox TableNameComboBox;
        private Label SelectDataTypeLable;
        private Label AddColumnLabel;
        public Button DeleteTableButton;
        public Button AddTableButton;
        private Label SelectTableLabel;
        private Label AddTableLabel;
        public Button DeleteColumnButton;
        public Button AddColumnButton;
        public RadioButton SqlCeRadioButton;
        public HeaderPanel ProviderTable;
        public HeaderPanel SchemaTable;
        public HeaderPanel SourceTable;
        public BackPanel TablePanel;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTab;
        public Picture Loader;
        private BackPanel LoadingPanel;
        public System.Windows.Forms.Timer Timer;
    }
}