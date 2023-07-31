// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class FilterDialog
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
        var config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( FilterDialog ) );
        FirstPanel = new Layout( );
        FirstListBox = new ListBox( );
        FirstComboBox = new ComboBox( );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        ThirdComboBox = new ComboBox( );
        ThirdPanel = new Layout( );
        ThirdListBox = new ListBox( );
        ToolTip = new SmallTip( );
        TabControl = new TabControl( );
        TableTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        SourceHeader = new Label( );
        MaintenanceTable = new HeaderPanel( );
        MaintenancePanel = new Layout( );
        MaintenanceListBox = new ListBox( );
        ReferenceTable = new HeaderPanel( );
        ReferencePanel = new Layout( );
        ReferenceListBox = new ListBox( );
        SourceTable = new HeaderPanel( );
        TablePanel = new Layout( );
        TableListBox = new ListBox( );
        ProviderTable = new HeaderPanel( );
        ProviderPanel = new Layout( );
        SqlCeRadioButton = new RadioButton( );
        AccessRadioButton = new RadioButton( );
        SqlServerRadioButton = new RadioButton( );
        SQLiteRadioButton = new RadioButton( );
        FilterTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        FilterHeader = new Label( );
        FourthTable = new HeaderPanel( );
        FourthPanel = new Layout( );
        FourthListBox = new ListBox( );
        FourthComboBox = new ComboBox( );
        ThirdTable = new HeaderPanel( );
        SecondTable = new HeaderPanel( );
        SecondPanel = new Layout( );
        SecondListBox = new ListBox( );
        SecondComboBox = new ComboBox( );
        FirstTable = new HeaderPanel( );
        GroupTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        GroupHeader = new Label( );
        SqlTable = new HeaderPanel( );
        SqlPanel = new Layout( );
        SqlTextBox = new TextBox( );
        NumericTable = new HeaderPanel( );
        NumericPanel = new Layout( );
        NumericListBox = new ListBox( );
        FieldTable = new HeaderPanel( );
        FieldPanel = new Layout( );
        FieldListBox = new ListBox( );
        CalendarTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        TimeSpanPanel = new Layout( );
        TimeSpanTable = new HeaderPanel( );
        TimeSpanLabel = new Label( );
        FirstLabel = new Label( );
        SecondLabel = new Label( );
        ThirdLabel = new Label( );
        FourthLabel = new Label( );
        FifthLable = new Label( );
        TimeSpanHeader = new Label( );
        StartDatePanel = new Layout( );
        FirstCalendarTable = new HeaderPanel( );
        FirstCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
        FirstCalendarLabel = new Label( );
        EndDatePanel = new Layout( );
        SecondCalendarTable = new HeaderPanel( );
        SeondCalendar = new Syncfusion.WinForms.Input.SfCalendar( );
        SecondCalendarLabel = new Label( );
        SqlTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        EditorTable = new HeaderPanel( );
        EditorPanel = new Layout( );
        SqlEditor = new Editor( );
        SqlCommandTable = new System.Windows.Forms.TableLayoutPanel( );
        SqlStatementTable = new HeaderPanel( );
        TextPanel = new Layout( );
        CommandQueryListBox = new ListBox( );
        CommandTable = new HeaderPanel( );
        CommandPanel = new Layout( );
        CommandQueryComboBox = new ComboBox( );
        ContextMenu = new ContextMenu( );
        CloseButton = new Button( );
        SelectButton = new Button( );
        GroupButton = new Button( );
        ClearButton = new Button( );
        FirstPanel.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        ThirdPanel.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) TabControl  ).BeginInit( );
        TabControl.SuspendLayout( );
        TableTabPage.SuspendLayout( );
        MaintenanceTable.SuspendLayout( );
        MaintenancePanel.SuspendLayout( );
        ReferenceTable.SuspendLayout( );
        ReferencePanel.SuspendLayout( );
        SourceTable.SuspendLayout( );
        TablePanel.SuspendLayout( );
        ProviderTable.SuspendLayout( );
        ProviderPanel.SuspendLayout( );
        FilterTabPage.SuspendLayout( );
        FourthTable.SuspendLayout( );
        FourthPanel.SuspendLayout( );
        ThirdTable.SuspendLayout( );
        SecondTable.SuspendLayout( );
        SecondPanel.SuspendLayout( );
        FirstTable.SuspendLayout( );
        GroupTabPage.SuspendLayout( );
        SqlTable.SuspendLayout( );
        SqlPanel.SuspendLayout( );
        NumericTable.SuspendLayout( );
        NumericPanel.SuspendLayout( );
        FieldTable.SuspendLayout( );
        FieldPanel.SuspendLayout( );
        CalendarTabPage.SuspendLayout( );
        TimeSpanPanel.SuspendLayout( );
        TimeSpanTable.SuspendLayout( );
        StartDatePanel.SuspendLayout( );
        FirstCalendarTable.SuspendLayout( );
        EndDatePanel.SuspendLayout( );
        SecondCalendarTable.SuspendLayout( );
        SqlTabPage.SuspendLayout( );
        EditorTable.SuspendLayout( );
        EditorPanel.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).BeginInit( );
        SqlCommandTable.SuspendLayout( );
        SqlStatementTable.SuspendLayout( );
        TextPanel.SuspendLayout( );
        CommandTable.SuspendLayout( );
        CommandPanel.SuspendLayout( );
        SuspendLayout( );
        // 
        // FirstPanel
        // 
        FirstPanel.BackColor = System.Drawing.Color.Transparent;
        FirstPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstPanel.BindingSource = null;
        FirstPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        FirstPanel.BorderThickness = 1;
        FirstPanel.Children = null;
        FirstPanel.Controls.Add( FirstListBox );
        FirstPanel.DataFilter = null;
        FirstPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        FirstPanel.Font = new System.Drawing.Font( "Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstPanel.ForeColor = System.Drawing.Color.Transparent;
        FirstPanel.HoverText = null;
        FirstPanel.IsDerivedStyle = true;
        FirstPanel.Location = new System.Drawing.Point( 3, 56 );
        FirstPanel.Name = "FirstPanel";
        FirstPanel.Padding = new System.Windows.Forms.Padding( 1 );
        FirstPanel.Size = new System.Drawing.Size( 242, 307 );
        FirstPanel.Style = MetroSet_UI.Enums.Style.Custom;
        FirstPanel.StyleManager = null;
        FirstPanel.TabIndex = 2;
        FirstPanel.ThemeAuthor = "Terry D. Eppler";
        FirstPanel.ThemeName = "BudgetExecution";
        FirstPanel.ToolTip = null;
        // 
        // FirstListBox
        // 
        FirstListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        FirstListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        FirstListBox.BindingSource = null;
        FirstListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        FirstListBox.DataFilter = null;
        FirstListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        FirstListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
        FirstListBox.HoverText = null;
        FirstListBox.IsDerivedStyle = true;
        FirstListBox.ItemHeight = 28;
        FirstListBox.Location = new System.Drawing.Point( 18, 19 );
        FirstListBox.Margin = new System.Windows.Forms.Padding( 1 );
        FirstListBox.MultiSelect = false;
        FirstListBox.Name = "FirstListBox";
        FirstListBox.Padding = new System.Windows.Forms.Padding( 1 );
        FirstListBox.SelectedIndex = -1;
        FirstListBox.SelectedItem = null;
        FirstListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstListBox.SelectedItemColor = System.Drawing.Color.White;
        FirstListBox.SelectedText = null;
        FirstListBox.SelectedValue = null;
        FirstListBox.ShowBorder = false;
        FirstListBox.ShowScrollBar = false;
        FirstListBox.Size = new System.Drawing.Size( 202, 264 );
        FirstListBox.Style = MetroSet_UI.Enums.Style.Custom;
        FirstListBox.StyleManager = null;
        FirstListBox.TabIndex = 0;
        FirstListBox.ThemeAuthor = "Terry D. Eppler";
        FirstListBox.ThemeName = "BudgetExecution";
        FirstListBox.ToolTip = null;
        // 
        // FirstComboBox
        // 
        FirstComboBox.AllowDrop = true;
        FirstComboBox.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstComboBox.BackColor = System.Drawing.Color.Transparent;
        FirstComboBox.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstComboBox.BindingSource = BindingSource;
        FirstComboBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        FirstComboBox.CausesValidation = false;
        FirstComboBox.DataFilter = null;
        FirstComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
        FirstComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        FirstComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
        FirstComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        FirstComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        FirstComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        FirstComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FirstComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstComboBox.FormattingEnabled = true;
        FirstComboBox.HoverText = "Select First Category";
        FirstComboBox.IsDerivedStyle = true;
        FirstComboBox.ItemHeight = 24;
        FirstComboBox.Location = new System.Drawing.Point( 3, 19 );
        FirstComboBox.MaxDropDownItems = 60;
        FirstComboBox.Name = "FirstComboBox";
        FirstComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstComboBox.SelectedItemForeColor = System.Drawing.Color.White;
        FirstComboBox.Size = new System.Drawing.Size( 242, 30 );
        FirstComboBox.Style = MetroSet_UI.Enums.Style.Custom;
        FirstComboBox.StyleManager = null;
        FirstComboBox.TabIndex = 1;
        FirstComboBox.ThemeAuthor = "Terry D. Eppler";
        FirstComboBox.ThemeName = "BudgetExecution";
        FirstComboBox.ToolTip = null;
        // 
        // ThirdComboBox
        // 
        ThirdComboBox.AllowDrop = true;
        ThirdComboBox.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ThirdComboBox.BackColor = System.Drawing.Color.Transparent;
        ThirdComboBox.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ThirdComboBox.BindingSource = BindingSource;
        ThirdComboBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        ThirdComboBox.CausesValidation = false;
        ThirdComboBox.DataFilter = null;
        ThirdComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
        ThirdComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        ThirdComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
        ThirdComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ThirdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        ThirdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        ThirdComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ThirdComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ThirdComboBox.FormattingEnabled = true;
        ThirdComboBox.HoverText = "Select Third Category";
        ThirdComboBox.IsDerivedStyle = true;
        ThirdComboBox.ItemHeight = 24;
        ThirdComboBox.Location = new System.Drawing.Point( 3, 19 );
        ThirdComboBox.MaxDropDownItems = 60;
        ThirdComboBox.Name = "ThirdComboBox";
        ThirdComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ThirdComboBox.SelectedItemForeColor = System.Drawing.Color.White;
        ThirdComboBox.Size = new System.Drawing.Size( 242, 30 );
        ThirdComboBox.Style = MetroSet_UI.Enums.Style.Custom;
        ThirdComboBox.StyleManager = null;
        ThirdComboBox.TabIndex = 1;
        ThirdComboBox.ThemeAuthor = "Terry D. Eppler";
        ThirdComboBox.ThemeName = "BudgetExecution";
        ThirdComboBox.ToolTip = null;
        // 
        // ThirdPanel
        // 
        ThirdPanel.BackColor = System.Drawing.Color.Transparent;
        ThirdPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ThirdPanel.BindingSource = null;
        ThirdPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        ThirdPanel.BorderThickness = 1;
        ThirdPanel.Children = null;
        ThirdPanel.Controls.Add( ThirdListBox );
        ThirdPanel.DataFilter = null;
        ThirdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        ThirdPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ThirdPanel.ForeColor = System.Drawing.Color.Transparent;
        ThirdPanel.HoverText = null;
        ThirdPanel.IsDerivedStyle = true;
        ThirdPanel.Location = new System.Drawing.Point( 3, 56 );
        ThirdPanel.Name = "ThirdPanel";
        ThirdPanel.Padding = new System.Windows.Forms.Padding( 1 );
        ThirdPanel.Size = new System.Drawing.Size( 242, 307 );
        ThirdPanel.Style = MetroSet_UI.Enums.Style.Custom;
        ThirdPanel.StyleManager = null;
        ThirdPanel.TabIndex = 2;
        ThirdPanel.ThemeAuthor = "Terry D. Eppler";
        ThirdPanel.ThemeName = "BudgetExecution";
        ThirdPanel.ToolTip = null;
        // 
        // ThirdListBox
        // 
        ThirdListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        ThirdListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        ThirdListBox.BindingSource = null;
        ThirdListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        ThirdListBox.DataFilter = null;
        ThirdListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ThirdListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ThirdListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ThirdListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        ThirdListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
        ThirdListBox.HoverText = null;
        ThirdListBox.IsDerivedStyle = true;
        ThirdListBox.ItemHeight = 28;
        ThirdListBox.Location = new System.Drawing.Point( 18, 19 );
        ThirdListBox.Margin = new System.Windows.Forms.Padding( 1 );
        ThirdListBox.MultiSelect = false;
        ThirdListBox.Name = "ThirdListBox";
        ThirdListBox.Padding = new System.Windows.Forms.Padding( 1 );
        ThirdListBox.SelectedIndex = -1;
        ThirdListBox.SelectedItem = null;
        ThirdListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ThirdListBox.SelectedItemColor = System.Drawing.Color.White;
        ThirdListBox.SelectedText = null;
        ThirdListBox.SelectedValue = null;
        ThirdListBox.ShowBorder = false;
        ThirdListBox.ShowScrollBar = false;
        ThirdListBox.Size = new System.Drawing.Size( 200, 264 );
        ThirdListBox.Style = MetroSet_UI.Enums.Style.Custom;
        ThirdListBox.StyleManager = null;
        ThirdListBox.TabIndex = 0;
        ThirdListBox.ThemeAuthor = "Terry D. Eppler";
        ThirdListBox.ThemeName = "BudgetExecution";
        ThirdListBox.ToolTip = null;
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
        // TabControl
        // 
        TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TabControl.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.BeforeTouchSize = new System.Drawing.Size( 1328, 544 );
        TabControl.BindingSource = null;
        TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
        TabControl.CanOverrideStyle = true;
        TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.Controls.Add( TableTabPage );
        TabControl.Controls.Add( FilterTabPage );
        TabControl.Controls.Add( GroupTabPage );
        TabControl.Controls.Add( CalendarTabPage );
        TabControl.Controls.Add( SqlTabPage );
        TabControl.Dock = System.Windows.Forms.DockStyle.Top;
        TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.FocusOnTabClick = false;
        TabControl.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TabControl.ForeColor = System.Drawing.Color.LightGray;
        TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ItemSize = new System.Drawing.Size( 100, 30 );
        TabControl.Location = new System.Drawing.Point( 0, 0 );
        TabControl.Name = "TabControl";
        TabControl.Size = new System.Drawing.Size( 1328, 544 );
        TabControl.TabIndex = 12;
        TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
        TabControl.ThemeName = "TabRendererMetro";
        TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
        TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ToolTip = null;
        // 
        // TableTabPage
        // 
        TableTabPage.Controls.Add( SourceHeader );
        TableTabPage.Controls.Add( MaintenanceTable );
        TableTabPage.Controls.Add( ReferenceTable );
        TableTabPage.Controls.Add( SourceTable );
        TableTabPage.Controls.Add( ProviderTable );
        TableTabPage.Image = null;
        TableTabPage.ImageSize = new System.Drawing.Size( 22, 20 );
        TableTabPage.Location = new System.Drawing.Point( 0, 29 );
        TableTabPage.Name = "TableTabPage";
        TableTabPage.ShowCloseButton = true;
        TableTabPage.Size = new System.Drawing.Size( 1328, 515 );
        TableTabPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TableTabPage.TabFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        TableTabPage.TabForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        TableTabPage.TabIndex = 2;
        TableTabPage.ThemesEnabled = false;
        // 
        // SourceHeader
        // 
        SourceHeader.BindingSource = null;
        SourceHeader.DataFilter = null;
        SourceHeader.Dock = System.Windows.Forms.DockStyle.Top;
        SourceHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SourceHeader.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SourceHeader.HoverText = null;
        SourceHeader.IsDerivedStyle = true;
        SourceHeader.Location = new System.Drawing.Point( 0, 0 );
        SourceHeader.Margin = new System.Windows.Forms.Padding( 3 );
        SourceHeader.Name = "SourceHeader";
        SourceHeader.Padding = new System.Windows.Forms.Padding( 1 );
        SourceHeader.Size = new System.Drawing.Size( 1328, 30 );
        SourceHeader.Style = MetroSet_UI.Enums.Style.Custom;
        SourceHeader.StyleManager = null;
        SourceHeader.TabIndex = 15;
        SourceHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        SourceHeader.ThemeAuthor = "Terry D. Eppler";
        SourceHeader.ThemeName = "Budget Execution";
        SourceHeader.ToolTip = null;
        // 
        // MaintenanceTable
        // 
        MaintenanceTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MaintenanceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        MaintenanceTable.CaptionText = "Maintenance Tables";
        MaintenanceTable.ColumnCount = 1;
        MaintenanceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        MaintenanceTable.Controls.Add( MaintenancePanel, 0, 0 );
        MaintenanceTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        MaintenanceTable.ForeColor = System.Drawing.Color.DarkGray;
        MaintenanceTable.Location = new System.Drawing.Point( 1010, 73 );
        MaintenanceTable.Name = "MaintenanceTable";
        MaintenanceTable.RowCount = 1;
        MaintenanceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        MaintenanceTable.Size = new System.Drawing.Size( 278, 357 );
        MaintenanceTable.TabIndex = 14;
        // 
        // MaintenancePanel
        // 
        MaintenancePanel.BackColor = System.Drawing.Color.Transparent;
        MaintenancePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MaintenancePanel.BindingSource = null;
        MaintenancePanel.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
        MaintenancePanel.BorderThickness = 1;
        MaintenancePanel.Children = null;
        MaintenancePanel.Controls.Add( MaintenanceListBox );
        MaintenancePanel.DataFilter = null;
        MaintenancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        MaintenancePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        MaintenancePanel.ForeColor = System.Drawing.Color.Transparent;
        MaintenancePanel.HoverText = null;
        MaintenancePanel.IsDerivedStyle = true;
        MaintenancePanel.Location = new System.Drawing.Point( 3, 19 );
        MaintenancePanel.Name = "MaintenancePanel";
        MaintenancePanel.Padding = new System.Windows.Forms.Padding( 1 );
        MaintenancePanel.Size = new System.Drawing.Size( 272, 335 );
        MaintenancePanel.Style = MetroSet_UI.Enums.Style.Custom;
        MaintenancePanel.StyleManager = null;
        MaintenancePanel.TabIndex = 2;
        MaintenancePanel.ThemeAuthor = "Terry D. Eppler";
        MaintenancePanel.ThemeName = "Budget Execution";
        MaintenancePanel.ToolTip = null;
        // 
        // MaintenanceListBox
        // 
        MaintenanceListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        MaintenanceListBox.BindingSource = null;
        MaintenanceListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        MaintenanceListBox.DataFilter = null;
        MaintenanceListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MaintenanceListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MaintenanceListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        MaintenanceListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        MaintenanceListBox.HoveredItemColor = System.Drawing.Color.White;
        MaintenanceListBox.HoverText = null;
        MaintenanceListBox.IsDerivedStyle = true;
        MaintenanceListBox.ItemHeight = 28;
        MaintenanceListBox.Location = new System.Drawing.Point( 32, 27 );
        MaintenanceListBox.Margin = new System.Windows.Forms.Padding( 1 );
        MaintenanceListBox.MultiSelect = true;
        MaintenanceListBox.Name = "MaintenanceListBox";
        MaintenanceListBox.Padding = new System.Windows.Forms.Padding( 1 );
        MaintenanceListBox.SelectedIndex = -1;
        MaintenanceListBox.SelectedItem = null;
        MaintenanceListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        MaintenanceListBox.SelectedItemColor = System.Drawing.Color.White;
        MaintenanceListBox.SelectedText = null;
        MaintenanceListBox.SelectedValue = null;
        MaintenanceListBox.ShowBorder = false;
        MaintenanceListBox.ShowScrollBar = false;
        MaintenanceListBox.Size = new System.Drawing.Size( 210, 286 );
        MaintenanceListBox.Style = MetroSet_UI.Enums.Style.Custom;
        MaintenanceListBox.StyleManager = null;
        MaintenanceListBox.TabIndex = 1;
        MaintenanceListBox.ThemeAuthor = "Terry D. Eppler";
        MaintenanceListBox.ThemeName = "Budget Execution";
        MaintenanceListBox.ToolTip = null;
        // 
        // ReferenceTable
        // 
        ReferenceTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ReferenceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ReferenceTable.CaptionText = "Reference Tables";
        ReferenceTable.ColumnCount = 1;
        ReferenceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ReferenceTable.Controls.Add( ReferencePanel, 0, 0 );
        ReferenceTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ReferenceTable.ForeColor = System.Drawing.Color.DarkGray;
        ReferenceTable.Location = new System.Drawing.Point( 676, 73 );
        ReferenceTable.Name = "ReferenceTable";
        ReferenceTable.RowCount = 1;
        ReferenceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ReferenceTable.Size = new System.Drawing.Size( 278, 357 );
        ReferenceTable.TabIndex = 13;
        // 
        // ReferencePanel
        // 
        ReferencePanel.BackColor = System.Drawing.Color.Transparent;
        ReferencePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ReferencePanel.BindingSource = null;
        ReferencePanel.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
        ReferencePanel.BorderThickness = 1;
        ReferencePanel.Children = null;
        ReferencePanel.Controls.Add( ReferenceListBox );
        ReferencePanel.DataFilter = null;
        ReferencePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        ReferencePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ReferencePanel.ForeColor = System.Drawing.Color.Transparent;
        ReferencePanel.HoverText = null;
        ReferencePanel.IsDerivedStyle = true;
        ReferencePanel.Location = new System.Drawing.Point( 3, 19 );
        ReferencePanel.Name = "ReferencePanel";
        ReferencePanel.Padding = new System.Windows.Forms.Padding( 1 );
        ReferencePanel.Size = new System.Drawing.Size( 272, 335 );
        ReferencePanel.Style = MetroSet_UI.Enums.Style.Custom;
        ReferencePanel.StyleManager = null;
        ReferencePanel.TabIndex = 2;
        ReferencePanel.ThemeAuthor = "Terry D. Eppler";
        ReferencePanel.ThemeName = "Budget Execution";
        ReferencePanel.ToolTip = null;
        // 
        // ReferenceListBox
        // 
        ReferenceListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        ReferenceListBox.BindingSource = null;
        ReferenceListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        ReferenceListBox.DataFilter = null;
        ReferenceListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ReferenceListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ReferenceListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ReferenceListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        ReferenceListBox.HoveredItemColor = System.Drawing.Color.White;
        ReferenceListBox.HoverText = null;
        ReferenceListBox.IsDerivedStyle = true;
        ReferenceListBox.ItemHeight = 28;
        ReferenceListBox.Location = new System.Drawing.Point( 32, 27 );
        ReferenceListBox.Margin = new System.Windows.Forms.Padding( 1 );
        ReferenceListBox.MultiSelect = true;
        ReferenceListBox.Name = "ReferenceListBox";
        ReferenceListBox.Padding = new System.Windows.Forms.Padding( 1 );
        ReferenceListBox.SelectedIndex = -1;
        ReferenceListBox.SelectedItem = null;
        ReferenceListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ReferenceListBox.SelectedItemColor = System.Drawing.Color.White;
        ReferenceListBox.SelectedText = null;
        ReferenceListBox.SelectedValue = null;
        ReferenceListBox.ShowBorder = false;
        ReferenceListBox.ShowScrollBar = false;
        ReferenceListBox.Size = new System.Drawing.Size( 210, 286 );
        ReferenceListBox.Style = MetroSet_UI.Enums.Style.Custom;
        ReferenceListBox.StyleManager = null;
        ReferenceListBox.TabIndex = 1;
        ReferenceListBox.ThemeAuthor = "Terry D. Eppler";
        ReferenceListBox.ThemeName = "Budget Execution";
        ReferenceListBox.ToolTip = null;
        // 
        // SourceTable
        // 
        SourceTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SourceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        SourceTable.CaptionText = "Data Tables";
        SourceTable.ColumnCount = 1;
        SourceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SourceTable.Controls.Add( TablePanel, 0, 0 );
        SourceTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SourceTable.ForeColor = System.Drawing.Color.DarkGray;
        SourceTable.Location = new System.Drawing.Point( 329, 73 );
        SourceTable.Name = "SourceTable";
        SourceTable.RowCount = 1;
        SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SourceTable.Size = new System.Drawing.Size( 278, 357 );
        SourceTable.TabIndex = 12;
        // 
        // TablePanel
        // 
        TablePanel.BackColor = System.Drawing.Color.Transparent;
        TablePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TablePanel.BindingSource = null;
        TablePanel.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
        TablePanel.BorderThickness = 1;
        TablePanel.Children = null;
        TablePanel.Controls.Add( TableListBox );
        TablePanel.DataFilter = null;
        TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        TablePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TablePanel.ForeColor = System.Drawing.Color.Transparent;
        TablePanel.HoverText = null;
        TablePanel.IsDerivedStyle = true;
        TablePanel.Location = new System.Drawing.Point( 3, 19 );
        TablePanel.Name = "TablePanel";
        TablePanel.Padding = new System.Windows.Forms.Padding( 1 );
        TablePanel.Size = new System.Drawing.Size( 272, 335 );
        TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
        TablePanel.StyleManager = null;
        TablePanel.TabIndex = 1;
        TablePanel.ThemeAuthor = "Terry D. Eppler";
        TablePanel.ThemeName = "Budget Execution";
        TablePanel.ToolTip = null;
        // 
        // TableListBox
        // 
        TableListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        TableListBox.BindingSource = null;
        TableListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        TableListBox.DataFilter = null;
        TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TableListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        TableListBox.HoveredItemColor = System.Drawing.Color.White;
        TableListBox.HoverText = null;
        TableListBox.IsDerivedStyle = true;
        TableListBox.ItemHeight = 28;
        TableListBox.Location = new System.Drawing.Point( 32, 27 );
        TableListBox.Margin = new System.Windows.Forms.Padding( 1 );
        TableListBox.MultiSelect = true;
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
        TableListBox.Size = new System.Drawing.Size( 210, 286 );
        TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
        TableListBox.StyleManager = null;
        TableListBox.TabIndex = 1;
        TableListBox.ThemeAuthor = "Terry D. Eppler";
        TableListBox.ThemeName = "Budget Execution";
        TableListBox.ToolTip = null;
        // 
        // ProviderTable
        // 
        ProviderTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ProviderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ProviderTable.CaptionText = "Data Provider";
        ProviderTable.ColumnCount = 1;
        ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProviderTable.Controls.Add( ProviderPanel, 0, 0 );
        ProviderTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProviderTable.ForeColor = System.Drawing.Color.DarkGray;
        ProviderTable.Location = new System.Drawing.Point( 34, 73 );
        ProviderTable.Name = "ProviderTable";
        ProviderTable.RowCount = 1;
        ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProviderTable.Size = new System.Drawing.Size( 250, 357 );
        ProviderTable.TabIndex = 11;
        // 
        // ProviderPanel
        // 
        ProviderPanel.BackColor = System.Drawing.Color.Transparent;
        ProviderPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ProviderPanel.BindingSource = null;
        ProviderPanel.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
        ProviderPanel.BorderThickness = 1;
        ProviderPanel.Children = null;
        ProviderPanel.Controls.Add( SqlCeRadioButton );
        ProviderPanel.Controls.Add( AccessRadioButton );
        ProviderPanel.Controls.Add( SqlServerRadioButton );
        ProviderPanel.Controls.Add( SQLiteRadioButton );
        ProviderPanel.DataFilter = null;
        ProviderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        ProviderPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProviderPanel.ForeColor = System.Drawing.Color.Transparent;
        ProviderPanel.HoverText = null;
        ProviderPanel.IsDerivedStyle = true;
        ProviderPanel.Location = new System.Drawing.Point( 3, 19 );
        ProviderPanel.Name = "ProviderPanel";
        ProviderPanel.Padding = new System.Windows.Forms.Padding( 1 );
        ProviderPanel.Size = new System.Drawing.Size( 244, 335 );
        ProviderPanel.Style = MetroSet_UI.Enums.Style.Custom;
        ProviderPanel.StyleManager = null;
        ProviderPanel.TabIndex = 2;
        ProviderPanel.ThemeAuthor = "Terry D. Eppler";
        ProviderPanel.ThemeName = "BudgetExecution";
        ProviderPanel.ToolTip = null;
        // 
        // SqlCeRadioButton
        // 
        SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlCeRadioButton.Checked = false;
        SqlCeRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlCeRadioButton.Group = 0;
        SqlCeRadioButton.HoverText = null;
        SqlCeRadioButton.IsDerivedStyle = true;
        SqlCeRadioButton.Location = new System.Drawing.Point( 78, 110 );
        SqlCeRadioButton.Name = "SqlCeRadioButton";
        SqlCeRadioButton.Result = null;
        SqlCeRadioButton.Size = new System.Drawing.Size( 125, 17 );
        SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        SqlCeRadioButton.StyleManager = null;
        SqlCeRadioButton.TabIndex = 3;
        SqlCeRadioButton.Tag = "SqlCe";
        SqlCeRadioButton.Text = "  SQL Compact";
        SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
        SqlCeRadioButton.ThemeName = "Budget Execution";
        SqlCeRadioButton.ToolTip = ToolTip;
        // 
        // AccessRadioButton
        // 
        AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        AccessRadioButton.Checked = false;
        AccessRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        AccessRadioButton.Group = 0;
        AccessRadioButton.HoverText = null;
        AccessRadioButton.IsDerivedStyle = true;
        AccessRadioButton.Location = new System.Drawing.Point( 78, 205 );
        AccessRadioButton.Name = "AccessRadioButton";
        AccessRadioButton.Result = null;
        AccessRadioButton.Size = new System.Drawing.Size( 125, 17 );
        AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        AccessRadioButton.StyleManager = null;
        AccessRadioButton.TabIndex = 2;
        AccessRadioButton.Tag = "Access";
        AccessRadioButton.Text = "  MS Access";
        AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
        AccessRadioButton.ThemeName = "Budget Execution";
        AccessRadioButton.ToolTip = ToolTip;
        // 
        // SqlServerRadioButton
        // 
        SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlServerRadioButton.Checked = false;
        SqlServerRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlServerRadioButton.Group = 0;
        SqlServerRadioButton.HoverText = null;
        SqlServerRadioButton.IsDerivedStyle = true;
        SqlServerRadioButton.Location = new System.Drawing.Point( 78, 156 );
        SqlServerRadioButton.Name = "SqlServerRadioButton";
        SqlServerRadioButton.Result = null;
        SqlServerRadioButton.Size = new System.Drawing.Size( 125, 17 );
        SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        SqlServerRadioButton.StyleManager = null;
        SqlServerRadioButton.TabIndex = 1;
        SqlServerRadioButton.Tag = "SqlServer";
        SqlServerRadioButton.Text = "  SQL Server";
        SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
        SqlServerRadioButton.ThemeName = "Budget Execution";
        SqlServerRadioButton.ToolTip = ToolTip;
        // 
        // SQLiteRadioButton
        // 
        SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SQLiteRadioButton.Checked = false;
        SQLiteRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SQLiteRadioButton.Group = 0;
        SQLiteRadioButton.HoverText = null;
        SQLiteRadioButton.IsDerivedStyle = true;
        SQLiteRadioButton.Location = new System.Drawing.Point( 78, 64 );
        SQLiteRadioButton.Name = "SQLiteRadioButton";
        SQLiteRadioButton.Result = null;
        SQLiteRadioButton.Size = new System.Drawing.Size( 125, 17 );
        SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        SQLiteRadioButton.StyleManager = null;
        SQLiteRadioButton.TabIndex = 0;
        SQLiteRadioButton.Tag = "SQLite";
        SQLiteRadioButton.Text = "  SQLite";
        SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
        SQLiteRadioButton.ThemeName = "Budget Execution";
        SQLiteRadioButton.ToolTip = ToolTip;
        // 
        // FilterTabPage
        // 
        FilterTabPage.Controls.Add( FilterHeader );
        FilterTabPage.Controls.Add( FourthTable );
        FilterTabPage.Controls.Add( ThirdTable );
        FilterTabPage.Controls.Add( SecondTable );
        FilterTabPage.Controls.Add( FirstTable );
        FilterTabPage.ForeColor = System.Drawing.Color.DarkGray;
        FilterTabPage.Image = null;
        FilterTabPage.ImageSize = new System.Drawing.Size( 22, 20 );
        FilterTabPage.Location = new System.Drawing.Point( 0, 29 );
        FilterTabPage.Name = "FilterTabPage";
        FilterTabPage.ShowCloseButton = true;
        FilterTabPage.Size = new System.Drawing.Size( 1328, 515 );
        FilterTabPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FilterTabPage.TabFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        FilterTabPage.TabForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FilterTabPage.TabIndex = 1;
        FilterTabPage.ThemesEnabled = false;
        // 
        // FilterHeader
        // 
        FilterHeader.BindingSource = null;
        FilterHeader.DataFilter = null;
        FilterHeader.Dock = System.Windows.Forms.DockStyle.Top;
        FilterHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FilterHeader.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FilterHeader.HoverText = null;
        FilterHeader.IsDerivedStyle = true;
        FilterHeader.Location = new System.Drawing.Point( 0, 0 );
        FilterHeader.Margin = new System.Windows.Forms.Padding( 3 );
        FilterHeader.Name = "FilterHeader";
        FilterHeader.Padding = new System.Windows.Forms.Padding( 1 );
        FilterHeader.Size = new System.Drawing.Size( 1328, 30 );
        FilterHeader.Style = MetroSet_UI.Enums.Style.Custom;
        FilterHeader.StyleManager = null;
        FilterHeader.TabIndex = 16;
        FilterHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        FilterHeader.ThemeAuthor = "Terry D. Eppler";
        FilterHeader.ThemeName = "Budget Execution";
        FilterHeader.ToolTip = null;
        // 
        // FourthTable
        // 
        FourthTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FourthTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        FourthTable.CaptionText = "Fourth Category";
        FourthTable.ColumnCount = 1;
        FourthTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        FourthTable.Controls.Add( FourthPanel, 0, 1 );
        FourthTable.Controls.Add( FourthComboBox, 0, 0 );
        FourthTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FourthTable.ForeColor = System.Drawing.Color.DarkGray;
        FourthTable.Location = new System.Drawing.Point( 1025, 73 );
        FourthTable.Name = "FourthTable";
        FourthTable.RowCount = 2;
        FourthTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.2857141F ) );
        FourthTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.71429F ) );
        FourthTable.Size = new System.Drawing.Size( 245, 366 );
        FourthTable.TabIndex = 12;
        // 
        // FourthPanel
        // 
        FourthPanel.BackColor = System.Drawing.Color.Transparent;
        FourthPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FourthPanel.BindingSource = null;
        FourthPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        FourthPanel.BorderThickness = 1;
        FourthPanel.Children = null;
        FourthPanel.Controls.Add( FourthListBox );
        FourthPanel.DataFilter = null;
        FourthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        FourthPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FourthPanel.ForeColor = System.Drawing.Color.Transparent;
        FourthPanel.HoverText = null;
        FourthPanel.IsDerivedStyle = true;
        FourthPanel.Location = new System.Drawing.Point( 3, 55 );
        FourthPanel.Name = "FourthPanel";
        FourthPanel.Padding = new System.Windows.Forms.Padding( 1 );
        FourthPanel.Size = new System.Drawing.Size( 239, 308 );
        FourthPanel.Style = MetroSet_UI.Enums.Style.Custom;
        FourthPanel.StyleManager = null;
        FourthPanel.TabIndex = 3;
        FourthPanel.ThemeAuthor = "Terry D. Eppler";
        FourthPanel.ThemeName = "BudgetExecution";
        FourthPanel.ToolTip = null;
        // 
        // FourthListBox
        // 
        FourthListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        FourthListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        FourthListBox.BindingSource = null;
        FourthListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        FourthListBox.DataFilter = null;
        FourthListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FourthListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FourthListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FourthListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        FourthListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
        FourthListBox.HoverText = null;
        FourthListBox.IsDerivedStyle = true;
        FourthListBox.ItemHeight = 28;
        FourthListBox.Location = new System.Drawing.Point( 20, 21 );
        FourthListBox.Margin = new System.Windows.Forms.Padding( 1 );
        FourthListBox.MultiSelect = false;
        FourthListBox.Name = "FourthListBox";
        FourthListBox.Padding = new System.Windows.Forms.Padding( 1 );
        FourthListBox.SelectedIndex = -1;
        FourthListBox.SelectedItem = null;
        FourthListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FourthListBox.SelectedItemColor = System.Drawing.Color.White;
        FourthListBox.SelectedText = null;
        FourthListBox.SelectedValue = null;
        FourthListBox.ShowBorder = false;
        FourthListBox.ShowScrollBar = false;
        FourthListBox.Size = new System.Drawing.Size( 197, 265 );
        FourthListBox.Style = MetroSet_UI.Enums.Style.Custom;
        FourthListBox.StyleManager = null;
        FourthListBox.TabIndex = 1;
        FourthListBox.ThemeAuthor = "Terry D. Eppler";
        FourthListBox.ThemeName = "BudgetExecution";
        FourthListBox.ToolTip = null;
        // 
        // FourthComboBox
        // 
        FourthComboBox.AllowDrop = true;
        FourthComboBox.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FourthComboBox.BackColor = System.Drawing.Color.Transparent;
        FourthComboBox.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FourthComboBox.BindingSource = null;
        FourthComboBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        FourthComboBox.CausesValidation = false;
        FourthComboBox.DataFilter = null;
        FourthComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
        FourthComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        FourthComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
        FourthComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        FourthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        FourthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        FourthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FourthComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FourthComboBox.FormattingEnabled = true;
        FourthComboBox.HoverText = "Select Third Category";
        FourthComboBox.IsDerivedStyle = true;
        FourthComboBox.ItemHeight = 24;
        FourthComboBox.Location = new System.Drawing.Point( 3, 19 );
        FourthComboBox.MaxDropDownItems = 60;
        FourthComboBox.Name = "FourthComboBox";
        FourthComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FourthComboBox.SelectedItemForeColor = System.Drawing.Color.White;
        FourthComboBox.Size = new System.Drawing.Size( 239, 30 );
        FourthComboBox.Style = MetroSet_UI.Enums.Style.Custom;
        FourthComboBox.StyleManager = null;
        FourthComboBox.TabIndex = 1;
        FourthComboBox.ThemeAuthor = "Terry D. Eppler";
        FourthComboBox.ThemeName = "BudgetExecution";
        FourthComboBox.ToolTip = null;
        // 
        // ThirdTable
        // 
        ThirdTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ThirdTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ThirdTable.CaptionText = "Third Category";
        ThirdTable.ColumnCount = 1;
        ThirdTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ThirdTable.Controls.Add( ThirdPanel, 0, 1 );
        ThirdTable.Controls.Add( ThirdComboBox, 0, 0 );
        ThirdTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ThirdTable.ForeColor = System.Drawing.Color.DarkGray;
        ThirdTable.Location = new System.Drawing.Point( 695, 73 );
        ThirdTable.Name = "ThirdTable";
        ThirdTable.RowCount = 2;
        ThirdTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.8571424F ) );
        ThirdTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.14286F ) );
        ThirdTable.Size = new System.Drawing.Size( 248, 366 );
        ThirdTable.TabIndex = 11;
        // 
        // SecondTable
        // 
        SecondTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SecondTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        SecondTable.CaptionText = "Second Category";
        SecondTable.ColumnCount = 1;
        SecondTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SecondTable.Controls.Add( SecondPanel, 0, 1 );
        SecondTable.Controls.Add( SecondComboBox, 0, 0 );
        SecondTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondTable.ForeColor = System.Drawing.Color.DarkGray;
        SecondTable.Location = new System.Drawing.Point( 364, 73 );
        SecondTable.Name = "SecondTable";
        SecondTable.RowCount = 2;
        SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.8571424F ) );
        SecondTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.14286F ) );
        SecondTable.Size = new System.Drawing.Size( 248, 366 );
        SecondTable.TabIndex = 10;
        // 
        // SecondPanel
        // 
        SecondPanel.BackColor = System.Drawing.Color.Transparent;
        SecondPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SecondPanel.BindingSource = null;
        SecondPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        SecondPanel.BorderThickness = 1;
        SecondPanel.Children = null;
        SecondPanel.Controls.Add( SecondListBox );
        SecondPanel.DataFilter = null;
        SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        SecondPanel.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondPanel.ForeColor = System.Drawing.Color.Transparent;
        SecondPanel.HoverText = null;
        SecondPanel.IsDerivedStyle = true;
        SecondPanel.Location = new System.Drawing.Point( 3, 56 );
        SecondPanel.Name = "SecondPanel";
        SecondPanel.Padding = new System.Windows.Forms.Padding( 1 );
        SecondPanel.Size = new System.Drawing.Size( 242, 307 );
        SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
        SecondPanel.StyleManager = null;
        SecondPanel.TabIndex = 2;
        SecondPanel.ThemeAuthor = "Terry D. Eppler";
        SecondPanel.ThemeName = "BudgetExecution";
        SecondPanel.ToolTip = null;
        // 
        // SecondListBox
        // 
        SecondListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        SecondListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        SecondListBox.BindingSource = null;
        SecondListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        SecondListBox.DataFilter = null;
        SecondListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SecondListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SecondListBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        SecondListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
        SecondListBox.HoverText = null;
        SecondListBox.IsDerivedStyle = true;
        SecondListBox.ItemHeight = 28;
        SecondListBox.Location = new System.Drawing.Point( 17, 19 );
        SecondListBox.Margin = new System.Windows.Forms.Padding( 1 );
        SecondListBox.MultiSelect = false;
        SecondListBox.Name = "SecondListBox";
        SecondListBox.Padding = new System.Windows.Forms.Padding( 1 );
        SecondListBox.SelectedIndex = -1;
        SecondListBox.SelectedItem = null;
        SecondListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SecondListBox.SelectedItemColor = System.Drawing.Color.White;
        SecondListBox.SelectedText = null;
        SecondListBox.SelectedValue = null;
        SecondListBox.ShowBorder = false;
        SecondListBox.ShowScrollBar = false;
        SecondListBox.Size = new System.Drawing.Size( 203, 264 );
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
        SecondComboBox.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SecondComboBox.BackColor = System.Drawing.Color.Transparent;
        SecondComboBox.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SecondComboBox.BindingSource = BindingSource;
        SecondComboBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        SecondComboBox.CausesValidation = false;
        SecondComboBox.DataFilter = null;
        SecondComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
        SecondComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        SecondComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
        SecondComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        SecondComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        SecondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        SecondComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SecondComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondComboBox.FormattingEnabled = true;
        SecondComboBox.HoverText = "Select Second Category";
        SecondComboBox.IsDerivedStyle = true;
        SecondComboBox.ItemHeight = 24;
        SecondComboBox.Location = new System.Drawing.Point( 3, 19 );
        SecondComboBox.MaxDropDownItems = 60;
        SecondComboBox.Name = "SecondComboBox";
        SecondComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SecondComboBox.SelectedItemForeColor = System.Drawing.Color.White;
        SecondComboBox.Size = new System.Drawing.Size( 242, 30 );
        SecondComboBox.Style = MetroSet_UI.Enums.Style.Custom;
        SecondComboBox.StyleManager = null;
        SecondComboBox.TabIndex = 1;
        SecondComboBox.ThemeAuthor = "Terry D. Eppler";
        SecondComboBox.ThemeName = "BudgetExecution";
        SecondComboBox.ToolTip = null;
        // 
        // FirstTable
        // 
        FirstTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        FirstTable.CaptionText = "First Category";
        FirstTable.ColumnCount = 1;
        FirstTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        FirstTable.Controls.Add( FirstPanel, 0, 1 );
        FirstTable.Controls.Add( FirstComboBox, 0, 0 );
        FirstTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstTable.ForeColor = System.Drawing.Color.DarkGray;
        FirstTable.Location = new System.Drawing.Point( 52, 73 );
        FirstTable.Name = "FirstTable";
        FirstTable.RowCount = 2;
        FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.5714283F ) );
        FirstTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.42857F ) );
        FirstTable.Size = new System.Drawing.Size( 248, 366 );
        FirstTable.TabIndex = 9;
        // 
        // GroupTabPage
        // 
        GroupTabPage.Controls.Add( GroupHeader );
        GroupTabPage.Controls.Add( SqlTable );
        GroupTabPage.Controls.Add( NumericTable );
        GroupTabPage.Controls.Add( FieldTable );
        GroupTabPage.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        GroupTabPage.Image = null;
        GroupTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
        GroupTabPage.Location = new System.Drawing.Point( 0, 29 );
        GroupTabPage.Name = "GroupTabPage";
        GroupTabPage.ShowCloseButton = true;
        GroupTabPage.Size = new System.Drawing.Size( 1328, 515 );
        GroupTabPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        GroupTabPage.TabFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        GroupTabPage.TabForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        GroupTabPage.TabIndex = 4;
        GroupTabPage.ThemesEnabled = false;
        // 
        // GroupHeader
        // 
        GroupHeader.BindingSource = null;
        GroupHeader.DataFilter = null;
        GroupHeader.Dock = System.Windows.Forms.DockStyle.Top;
        GroupHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        GroupHeader.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        GroupHeader.HoverText = null;
        GroupHeader.IsDerivedStyle = true;
        GroupHeader.Location = new System.Drawing.Point( 0, 0 );
        GroupHeader.Margin = new System.Windows.Forms.Padding( 3 );
        GroupHeader.Name = "GroupHeader";
        GroupHeader.Padding = new System.Windows.Forms.Padding( 1 );
        GroupHeader.Size = new System.Drawing.Size( 1328, 30 );
        GroupHeader.Style = MetroSet_UI.Enums.Style.Custom;
        GroupHeader.StyleManager = null;
        GroupHeader.TabIndex = 17;
        GroupHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        GroupHeader.ThemeAuthor = "Terry D. Eppler";
        GroupHeader.ThemeName = "Budget Execution";
        GroupHeader.ToolTip = null;
        // 
        // SqlTable
        // 
        SqlTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SqlTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        SqlTable.CaptionText = "SQL Query";
        SqlTable.ColumnCount = 1;
        SqlTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SqlTable.Controls.Add( SqlPanel, 0, 1 );
        SqlTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlTable.ForeColor = System.Drawing.Color.DarkGray;
        SqlTable.Location = new System.Drawing.Point( 829, 73 );
        SqlTable.Name = "SqlTable";
        SqlTable.RowCount = 2;
        SqlTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.77358484F ) );
        SqlTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.22642F ) );
        SqlTable.Size = new System.Drawing.Size( 402, 387 );
        SqlTable.TabIndex = 2;
        // 
        // SqlPanel
        // 
        SqlPanel.BackColor = System.Drawing.Color.Transparent;
        SqlPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SqlPanel.BindingSource = null;
        SqlPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        SqlPanel.BorderThickness = 1;
        SqlPanel.Children = null;
        SqlPanel.Controls.Add( SqlTextBox );
        SqlPanel.DataFilter = null;
        SqlPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlPanel.ForeColor = System.Drawing.Color.Transparent;
        SqlPanel.HoverText = null;
        SqlPanel.IsDerivedStyle = true;
        SqlPanel.Location = new System.Drawing.Point( 3, 33 );
        SqlPanel.Name = "SqlPanel";
        SqlPanel.Padding = new System.Windows.Forms.Padding( 1 );
        SqlPanel.Size = new System.Drawing.Size( 396, 351 );
        SqlPanel.Style = MetroSet_UI.Enums.Style.Custom;
        SqlPanel.StyleManager = null;
        SqlPanel.TabIndex = 0;
        SqlPanel.ThemeAuthor = "Terry D. Eppler";
        SqlPanel.ThemeName = "Budget Execution";
        SqlPanel.ToolTip = null;
        // 
        // SqlTextBox
        // 
        SqlTextBox.AutoCompleteCustomSource = null;
        SqlTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
        SqlTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
        SqlTextBox.BindingSource = null;
        SqlTextBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        SqlTextBox.DataFilter = null;
        SqlTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
        SqlTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        SqlTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
        SqlTextBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlTextBox.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlTextBox.HoverText = null;
        SqlTextBox.Image = null;
        SqlTextBox.IsDerivedStyle = true;
        SqlTextBox.Lines = null;
        SqlTextBox.Location = new System.Drawing.Point( 29, 28 );
        SqlTextBox.MaxLength = 32767;
        SqlTextBox.Multiline = true;
        SqlTextBox.Name = "SqlTextBox";
        SqlTextBox.ReadOnly = false;
        SqlTextBox.SelectionLength = 0;
        SqlTextBox.Size = new System.Drawing.Size( 341, 290 );
        SqlTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        SqlTextBox.StyleManager = null;
        SqlTextBox.TabIndex = 0;
        SqlTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        SqlTextBox.ThemeAuthor = "Terry D. Eppler";
        SqlTextBox.ThemeName = "Budget Execution";
        SqlTextBox.ToolTip = ToolTip;
        SqlTextBox.UseSystemPasswordChar = false;
        SqlTextBox.WatermarkText = "";
        // 
        // NumericTable
        // 
        NumericTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        NumericTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        NumericTable.CaptionText = "Numerics";
        NumericTable.ColumnCount = 1;
        NumericTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        NumericTable.Controls.Add( NumericPanel, 0, 1 );
        NumericTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        NumericTable.ForeColor = System.Drawing.Color.DarkGray;
        NumericTable.Location = new System.Drawing.Point( 479, 73 );
        NumericTable.Name = "NumericTable";
        NumericTable.RowCount = 2;
        NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.51351357F ) );
        NumericTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.48649F ) );
        NumericTable.Size = new System.Drawing.Size( 275, 386 );
        NumericTable.TabIndex = 1;
        // 
        // NumericPanel
        // 
        NumericPanel.BackColor = System.Drawing.Color.Transparent;
        NumericPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        NumericPanel.BindingSource = null;
        NumericPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        NumericPanel.BorderThickness = 1;
        NumericPanel.Children = null;
        NumericPanel.Controls.Add( NumericListBox );
        NumericPanel.DataFilter = null;
        NumericPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        NumericPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        NumericPanel.ForeColor = System.Drawing.Color.Transparent;
        NumericPanel.HoverText = null;
        NumericPanel.IsDerivedStyle = true;
        NumericPanel.Location = new System.Drawing.Point( 3, 32 );
        NumericPanel.Name = "NumericPanel";
        NumericPanel.Padding = new System.Windows.Forms.Padding( 1 );
        NumericPanel.Size = new System.Drawing.Size( 269, 351 );
        NumericPanel.Style = MetroSet_UI.Enums.Style.Custom;
        NumericPanel.StyleManager = null;
        NumericPanel.TabIndex = 0;
        NumericPanel.ThemeAuthor = "Terry D. Eppler";
        NumericPanel.ThemeName = "Budget Execution";
        NumericPanel.ToolTip = null;
        // 
        // NumericListBox
        // 
        NumericListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        NumericListBox.BindingSource = null;
        NumericListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        NumericListBox.DataFilter = null;
        NumericListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        NumericListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        NumericListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        NumericListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        NumericListBox.HoveredItemColor = System.Drawing.Color.White;
        NumericListBox.HoverText = null;
        NumericListBox.IsDerivedStyle = true;
        NumericListBox.ItemHeight = 28;
        NumericListBox.Location = new System.Drawing.Point( 25, 29 );
        NumericListBox.Margin = new System.Windows.Forms.Padding( 1 );
        NumericListBox.MultiSelect = true;
        NumericListBox.Name = "NumericListBox";
        NumericListBox.Padding = new System.Windows.Forms.Padding( 1 );
        NumericListBox.SelectedIndex = -1;
        NumericListBox.SelectedItem = null;
        NumericListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        NumericListBox.SelectedItemColor = System.Drawing.Color.White;
        NumericListBox.SelectedText = null;
        NumericListBox.SelectedValue = null;
        NumericListBox.ShowBorder = false;
        NumericListBox.ShowScrollBar = false;
        NumericListBox.Size = new System.Drawing.Size( 215, 286 );
        NumericListBox.Style = MetroSet_UI.Enums.Style.Custom;
        NumericListBox.StyleManager = null;
        NumericListBox.TabIndex = 0;
        NumericListBox.ThemeAuthor = "Terry D. Eppler";
        NumericListBox.ThemeName = "Budget Execution";
        NumericListBox.ToolTip = null;
        // 
        // FieldTable
        // 
        FieldTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FieldTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        FieldTable.CaptionText = "Fields";
        FieldTable.ColumnCount = 1;
        FieldTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        FieldTable.Controls.Add( FieldPanel, 0, 1 );
        FieldTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FieldTable.ForeColor = System.Drawing.Color.DarkGray;
        FieldTable.Location = new System.Drawing.Point( 124, 73 );
        FieldTable.Name = "FieldTable";
        FieldTable.RowCount = 2;
        FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.24324322F ) );
        FieldTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.75676F ) );
        FieldTable.Size = new System.Drawing.Size( 275, 386 );
        FieldTable.TabIndex = 0;
        // 
        // FieldPanel
        // 
        FieldPanel.BackColor = System.Drawing.Color.Transparent;
        FieldPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FieldPanel.BindingSource = null;
        FieldPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        FieldPanel.BorderThickness = 1;
        FieldPanel.Children = null;
        FieldPanel.Controls.Add( FieldListBox );
        FieldPanel.DataFilter = null;
        FieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        FieldPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FieldPanel.ForeColor = System.Drawing.Color.Transparent;
        FieldPanel.HoverText = null;
        FieldPanel.IsDerivedStyle = true;
        FieldPanel.Location = new System.Drawing.Point( 3, 31 );
        FieldPanel.Name = "FieldPanel";
        FieldPanel.Padding = new System.Windows.Forms.Padding( 1 );
        FieldPanel.Size = new System.Drawing.Size( 269, 352 );
        FieldPanel.Style = MetroSet_UI.Enums.Style.Custom;
        FieldPanel.StyleManager = null;
        FieldPanel.TabIndex = 0;
        FieldPanel.ThemeAuthor = "Terry D. Eppler";
        FieldPanel.ThemeName = "Budget Execution";
        FieldPanel.ToolTip = null;
        // 
        // FieldListBox
        // 
        FieldListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        FieldListBox.BindingSource = null;
        FieldListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        FieldListBox.DataFilter = null;
        FieldListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FieldListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FieldListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FieldListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        FieldListBox.HoveredItemColor = System.Drawing.Color.White;
        FieldListBox.HoverText = null;
        FieldListBox.IsDerivedStyle = true;
        FieldListBox.ItemHeight = 28;
        FieldListBox.Location = new System.Drawing.Point( 31, 30 );
        FieldListBox.Margin = new System.Windows.Forms.Padding( 1 );
        FieldListBox.MultiSelect = true;
        FieldListBox.Name = "FieldListBox";
        FieldListBox.Padding = new System.Windows.Forms.Padding( 1 );
        FieldListBox.SelectedIndex = -1;
        FieldListBox.SelectedItem = null;
        FieldListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FieldListBox.SelectedItemColor = System.Drawing.Color.White;
        FieldListBox.SelectedText = null;
        FieldListBox.SelectedValue = null;
        FieldListBox.ShowBorder = false;
        FieldListBox.ShowScrollBar = false;
        FieldListBox.Size = new System.Drawing.Size( 203, 286 );
        FieldListBox.Style = MetroSet_UI.Enums.Style.Custom;
        FieldListBox.StyleManager = null;
        FieldListBox.TabIndex = 0;
        FieldListBox.ThemeAuthor = "Terry D. Eppler";
        FieldListBox.ThemeName = "Budget Execution";
        FieldListBox.ToolTip = null;
        // 
        // CalendarTabPage
        // 
        CalendarTabPage.Controls.Add( TimeSpanPanel );
        CalendarTabPage.Controls.Add( TimeSpanHeader );
        CalendarTabPage.Controls.Add( StartDatePanel );
        CalendarTabPage.Controls.Add( EndDatePanel );
        CalendarTabPage.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CalendarTabPage.Image = null;
        CalendarTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
        CalendarTabPage.Location = new System.Drawing.Point( 0, 29 );
        CalendarTabPage.Name = "CalendarTabPage";
        CalendarTabPage.ShowCloseButton = true;
        CalendarTabPage.Size = new System.Drawing.Size( 1328, 515 );
        CalendarTabPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CalendarTabPage.TabFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        CalendarTabPage.TabForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CalendarTabPage.TabIndex = 3;
        CalendarTabPage.ThemesEnabled = false;
        // 
        // TimeSpanPanel
        // 
        TimeSpanPanel.BackColor = System.Drawing.Color.Transparent;
        TimeSpanPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TimeSpanPanel.BindingSource = null;
        TimeSpanPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        TimeSpanPanel.BorderThickness = 1;
        TimeSpanPanel.Children = null;
        TimeSpanPanel.Controls.Add( TimeSpanTable );
        TimeSpanPanel.DataFilter = null;
        TimeSpanPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TimeSpanPanel.ForeColor = System.Drawing.Color.Transparent;
        TimeSpanPanel.HoverText = null;
        TimeSpanPanel.IsDerivedStyle = true;
        TimeSpanPanel.Location = new System.Drawing.Point( 897, 51 );
        TimeSpanPanel.Name = "TimeSpanPanel";
        TimeSpanPanel.Padding = new System.Windows.Forms.Padding( 1 );
        TimeSpanPanel.Size = new System.Drawing.Size( 408, 364 );
        TimeSpanPanel.Style = MetroSet_UI.Enums.Style.Custom;
        TimeSpanPanel.StyleManager = null;
        TimeSpanPanel.TabIndex = 21;
        TimeSpanPanel.ThemeAuthor = "Terry D. Eppler";
        TimeSpanPanel.ThemeName = "Budget Execution";
        TimeSpanPanel.ToolTip = null;
        // 
        // TimeSpanTable
        // 
        TimeSpanTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TimeSpanTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        TimeSpanTable.CaptionText = "Time Span Information";
        TimeSpanTable.ColumnCount = 1;
        TimeSpanTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        TimeSpanTable.Controls.Add( TimeSpanLabel, 0, 0 );
        TimeSpanTable.Controls.Add( FirstLabel, 0, 2 );
        TimeSpanTable.Controls.Add( SecondLabel, 0, 3 );
        TimeSpanTable.Controls.Add( ThirdLabel, 0, 4 );
        TimeSpanTable.Controls.Add( FourthLabel, 0, 5 );
        TimeSpanTable.Controls.Add( FifthLable, 0, 6 );
        TimeSpanTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TimeSpanTable.ForeColor = System.Drawing.Color.DarkGray;
        TimeSpanTable.Location = new System.Drawing.Point( 25, 23 );
        TimeSpanTable.Name = "TimeSpanTable";
        TimeSpanTable.RowCount = 8;
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 46.5753441F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 53.4246559F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 39F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 38F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 40F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 38F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 36F ) );
        TimeSpanTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 45F ) );
        TimeSpanTable.Size = new System.Drawing.Size( 360, 319 );
        TimeSpanTable.TabIndex = 0;
        // 
        // TimeSpanLabel
        // 
        TimeSpanLabel.BindingSource = BindingSource;
        TimeSpanLabel.DataFilter = null;
        TimeSpanLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        TimeSpanLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        TimeSpanLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TimeSpanLabel.HoverText = null;
        TimeSpanLabel.IsDerivedStyle = true;
        TimeSpanLabel.Location = new System.Drawing.Point( 3, 19 );
        TimeSpanLabel.Margin = new System.Windows.Forms.Padding( 3 );
        TimeSpanLabel.Name = "TimeSpanLabel";
        TimeSpanLabel.Padding = new System.Windows.Forms.Padding( 1 );
        TimeSpanLabel.Size = new System.Drawing.Size( 354, 25 );
        TimeSpanLabel.Style = MetroSet_UI.Enums.Style.Custom;
        TimeSpanLabel.StyleManager = null;
        TimeSpanLabel.TabIndex = 0;
        TimeSpanLabel.Text = "Label";
        TimeSpanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        TimeSpanLabel.ThemeAuthor = "Terry D. Eppler";
        TimeSpanLabel.ThemeName = "Budget Execution";
        TimeSpanLabel.ToolTip = null;
        // 
        // FirstLabel
        // 
        FirstLabel.BindingSource = BindingSource;
        FirstLabel.DataFilter = null;
        FirstLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        FirstLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FirstLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstLabel.HoverText = null;
        FirstLabel.IsDerivedStyle = true;
        FirstLabel.Location = new System.Drawing.Point( 3, 85 );
        FirstLabel.Margin = new System.Windows.Forms.Padding( 3 );
        FirstLabel.Name = "FirstLabel";
        FirstLabel.Padding = new System.Windows.Forms.Padding( 1 );
        FirstLabel.Size = new System.Drawing.Size( 354, 33 );
        FirstLabel.Style = MetroSet_UI.Enums.Style.Custom;
        FirstLabel.StyleManager = null;
        FirstLabel.TabIndex = 1;
        FirstLabel.Text = "Label";
        FirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        FirstLabel.ThemeAuthor = "Terry D. Eppler";
        FirstLabel.ThemeName = "Budget Execution";
        FirstLabel.ToolTip = null;
        // 
        // SecondLabel
        // 
        SecondLabel.BindingSource = BindingSource;
        SecondLabel.DataFilter = null;
        SecondLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        SecondLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SecondLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondLabel.HoverText = null;
        SecondLabel.IsDerivedStyle = true;
        SecondLabel.Location = new System.Drawing.Point( 3, 124 );
        SecondLabel.Margin = new System.Windows.Forms.Padding( 3 );
        SecondLabel.Name = "SecondLabel";
        SecondLabel.Padding = new System.Windows.Forms.Padding( 1 );
        SecondLabel.Size = new System.Drawing.Size( 354, 32 );
        SecondLabel.Style = MetroSet_UI.Enums.Style.Custom;
        SecondLabel.StyleManager = null;
        SecondLabel.TabIndex = 2;
        SecondLabel.Text = "Label";
        SecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        SecondLabel.ThemeAuthor = "Terry D. Eppler";
        SecondLabel.ThemeName = "Budget Execution";
        SecondLabel.ToolTip = null;
        // 
        // ThirdLabel
        // 
        ThirdLabel.BindingSource = BindingSource;
        ThirdLabel.DataFilter = null;
        ThirdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        ThirdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ThirdLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ThirdLabel.HoverText = null;
        ThirdLabel.IsDerivedStyle = true;
        ThirdLabel.Location = new System.Drawing.Point( 3, 162 );
        ThirdLabel.Margin = new System.Windows.Forms.Padding( 3 );
        ThirdLabel.Name = "ThirdLabel";
        ThirdLabel.Padding = new System.Windows.Forms.Padding( 1 );
        ThirdLabel.Size = new System.Drawing.Size( 354, 34 );
        ThirdLabel.Style = MetroSet_UI.Enums.Style.Custom;
        ThirdLabel.StyleManager = null;
        ThirdLabel.TabIndex = 3;
        ThirdLabel.Text = "Label";
        ThirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ThirdLabel.ThemeAuthor = "Terry D. Eppler";
        ThirdLabel.ThemeName = "Budget Execution";
        ThirdLabel.ToolTip = null;
        // 
        // FourthLabel
        // 
        FourthLabel.BindingSource = BindingSource;
        FourthLabel.DataFilter = null;
        FourthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        FourthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FourthLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FourthLabel.HoverText = null;
        FourthLabel.IsDerivedStyle = true;
        FourthLabel.Location = new System.Drawing.Point( 3, 202 );
        FourthLabel.Margin = new System.Windows.Forms.Padding( 3 );
        FourthLabel.Name = "FourthLabel";
        FourthLabel.Padding = new System.Windows.Forms.Padding( 1 );
        FourthLabel.Size = new System.Drawing.Size( 354, 32 );
        FourthLabel.Style = MetroSet_UI.Enums.Style.Custom;
        FourthLabel.StyleManager = null;
        FourthLabel.TabIndex = 4;
        FourthLabel.Text = "Label";
        FourthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        FourthLabel.ThemeAuthor = "Terry D. Eppler";
        FourthLabel.ThemeName = "Budget Execution";
        FourthLabel.ToolTip = null;
        // 
        // FifthLable
        // 
        FifthLable.BindingSource = BindingSource;
        FifthLable.DataFilter = null;
        FifthLable.Dock = System.Windows.Forms.DockStyle.Fill;
        FifthLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FifthLable.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FifthLable.HoverText = null;
        FifthLable.IsDerivedStyle = true;
        FifthLable.Location = new System.Drawing.Point( 3, 240 );
        FifthLable.Margin = new System.Windows.Forms.Padding( 3 );
        FifthLable.Name = "FifthLable";
        FifthLable.Padding = new System.Windows.Forms.Padding( 1 );
        FifthLable.Size = new System.Drawing.Size( 354, 30 );
        FifthLable.Style = MetroSet_UI.Enums.Style.Custom;
        FifthLable.StyleManager = null;
        FifthLable.TabIndex = 5;
        FifthLable.Text = "Label";
        FifthLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        FifthLable.ThemeAuthor = "Terry D. Eppler";
        FifthLable.ThemeName = "Budget Execution";
        FifthLable.ToolTip = null;
        // 
        // TimeSpanHeader
        // 
        TimeSpanHeader.BindingSource = null;
        TimeSpanHeader.DataFilter = null;
        TimeSpanHeader.Dock = System.Windows.Forms.DockStyle.Top;
        TimeSpanHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        TimeSpanHeader.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TimeSpanHeader.HoverText = null;
        TimeSpanHeader.IsDerivedStyle = true;
        TimeSpanHeader.Location = new System.Drawing.Point( 0, 0 );
        TimeSpanHeader.Margin = new System.Windows.Forms.Padding( 3 );
        TimeSpanHeader.Name = "TimeSpanHeader";
        TimeSpanHeader.Padding = new System.Windows.Forms.Padding( 1 );
        TimeSpanHeader.Size = new System.Drawing.Size( 1328, 30 );
        TimeSpanHeader.Style = MetroSet_UI.Enums.Style.Custom;
        TimeSpanHeader.StyleManager = null;
        TimeSpanHeader.TabIndex = 18;
        TimeSpanHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        TimeSpanHeader.ThemeAuthor = "Terry D. Eppler";
        TimeSpanHeader.ThemeName = "Budget Execution";
        TimeSpanHeader.ToolTip = null;
        // 
        // StartDatePanel
        // 
        StartDatePanel.BackColor = System.Drawing.Color.Transparent;
        StartDatePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        StartDatePanel.BindingSource = null;
        StartDatePanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        StartDatePanel.BorderThickness = 1;
        StartDatePanel.Children = null;
        StartDatePanel.Controls.Add( FirstCalendarTable );
        StartDatePanel.DataFilter = null;
        StartDatePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        StartDatePanel.ForeColor = System.Drawing.Color.Transparent;
        StartDatePanel.HoverText = null;
        StartDatePanel.IsDerivedStyle = true;
        StartDatePanel.Location = new System.Drawing.Point( 28, 51 );
        StartDatePanel.Name = "StartDatePanel";
        StartDatePanel.Padding = new System.Windows.Forms.Padding( 1 );
        StartDatePanel.Size = new System.Drawing.Size( 391, 362 );
        StartDatePanel.Style = MetroSet_UI.Enums.Style.Custom;
        StartDatePanel.StyleManager = null;
        StartDatePanel.TabIndex = 19;
        StartDatePanel.ThemeAuthor = "Terry D. Eppler";
        StartDatePanel.ThemeName = "Budget Execution";
        StartDatePanel.ToolTip = null;
        // 
        // FirstCalendarTable
        // 
        FirstCalendarTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        FirstCalendarTable.CaptionText = "Start Date";
        FirstCalendarTable.ColumnCount = 1;
        FirstCalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        FirstCalendarTable.Controls.Add( FirstCalendar, 0, 1 );
        FirstCalendarTable.Controls.Add( FirstCalendarLabel, 0, 0 );
        FirstCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendarTable.ForeColor = System.Drawing.Color.DarkGray;
        FirstCalendarTable.Location = new System.Drawing.Point( 20, 23 );
        FirstCalendarTable.Name = "FirstCalendarTable";
        FirstCalendarTable.RowCount = 2;
        FirstCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 12.8526649F ) );
        FirstCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 87.14734F ) );
        FirstCalendarTable.Size = new System.Drawing.Size( 348, 319 );
        FirstCalendarTable.TabIndex = 16;
        // 
        // FirstCalendar
        // 
        FirstCalendar.CanOverrideStyle = true;
        FirstCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
        FirstCalendar.Location = new System.Drawing.Point( 3, 57 );
        FirstCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
        FirstCalendar.Name = "FirstCalendar";
        FirstCalendar.ShowToolTip = true;
        FirstCalendar.Size = new System.Drawing.Size( 315, 259 );
        FirstCalendar.Style.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
        FirstCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
        FirstCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
        FirstCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
        FirstCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
        FirstCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
        FirstCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
        FirstCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        FirstCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        FirstCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        FirstCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
        FirstCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
        FirstCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
        FirstCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
        FirstCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
        FirstCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
        FirstCalendar.TabIndex = 1;
        // 
        // FirstCalendarLabel
        // 
        FirstCalendarLabel.BindingSource = null;
        FirstCalendarLabel.DataFilter = null;
        FirstCalendarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        FirstCalendarLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        FirstCalendarLabel.HoverText = null;
        FirstCalendarLabel.IsDerivedStyle = true;
        FirstCalendarLabel.Location = new System.Drawing.Point( 3, 19 );
        FirstCalendarLabel.Margin = new System.Windows.Forms.Padding( 3 );
        FirstCalendarLabel.Name = "FirstCalendarLabel";
        FirstCalendarLabel.Padding = new System.Windows.Forms.Padding( 1 );
        FirstCalendarLabel.Size = new System.Drawing.Size( 317, 22 );
        FirstCalendarLabel.Style = MetroSet_UI.Enums.Style.Custom;
        FirstCalendarLabel.StyleManager = null;
        FirstCalendarLabel.TabIndex = 1;
        FirstCalendarLabel.Text = "Label";
        FirstCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        FirstCalendarLabel.ThemeAuthor = "Terry D. Eppler";
        FirstCalendarLabel.ThemeName = "Budget Execution";
        FirstCalendarLabel.ToolTip = null;
        // 
        // EndDatePanel
        // 
        EndDatePanel.BackColor = System.Drawing.Color.Transparent;
        EndDatePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EndDatePanel.BindingSource = null;
        EndDatePanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        EndDatePanel.BorderThickness = 1;
        EndDatePanel.Children = null;
        EndDatePanel.Controls.Add( SecondCalendarTable );
        EndDatePanel.DataFilter = null;
        EndDatePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EndDatePanel.ForeColor = System.Drawing.Color.Transparent;
        EndDatePanel.HoverText = null;
        EndDatePanel.IsDerivedStyle = true;
        EndDatePanel.Location = new System.Drawing.Point( 463, 51 );
        EndDatePanel.Name = "EndDatePanel";
        EndDatePanel.Padding = new System.Windows.Forms.Padding( 1 );
        EndDatePanel.Size = new System.Drawing.Size( 391, 362 );
        EndDatePanel.Style = MetroSet_UI.Enums.Style.Custom;
        EndDatePanel.StyleManager = null;
        EndDatePanel.TabIndex = 20;
        EndDatePanel.ThemeAuthor = "Terry D. Eppler";
        EndDatePanel.ThemeName = "Budget Execution";
        EndDatePanel.ToolTip = null;
        // 
        // SecondCalendarTable
        // 
        SecondCalendarTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SecondCalendarTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        SecondCalendarTable.CaptionText = "End Date";
        SecondCalendarTable.ColumnCount = 1;
        SecondCalendarTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SecondCalendarTable.Controls.Add( SeondCalendar, 0, 1 );
        SecondCalendarTable.Controls.Add( SecondCalendarLabel, 0, 0 );
        SecondCalendarTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondCalendarTable.ForeColor = System.Drawing.Color.DarkGray;
        SecondCalendarTable.Location = new System.Drawing.Point( 21, 23 );
        SecondCalendarTable.Name = "SecondCalendarTable";
        SecondCalendarTable.RowCount = 2;
        SecondCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.9717865F ) );
        SecondCalendarTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.02821F ) );
        SecondCalendarTable.Size = new System.Drawing.Size( 348, 319 );
        SecondCalendarTable.TabIndex = 15;
        // 
        // SeondCalendar
        // 
        SeondCalendar.CanOverrideStyle = true;
        SeondCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
        SeondCalendar.Location = new System.Drawing.Point( 3, 52 );
        SeondCalendar.MinimumSize = new System.Drawing.Size( 196, 196 );
        SeondCalendar.Name = "SeondCalendar";
        SeondCalendar.ShowToolTip = true;
        SeondCalendar.Size = new System.Drawing.Size( 315, 263 );
        SeondCalendar.Style.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.BlackoutDatesFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.CellFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Cell.CellForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
        SeondCalendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
        SeondCalendar.Style.Cell.SelectedCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
        SeondCalendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
        SeondCalendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.TodayFont = new System.Drawing.Font( "Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Cell.TodayForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.TrailingCellFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
        SeondCalendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Cell.WeekNumberFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Footer.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
        SeondCalendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
        SeondCalendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SeondCalendar.Style.Header.DayNamesFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Header.DayNamesForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Header.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        SeondCalendar.Style.Header.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SeondCalendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
        SeondCalendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
        SeondCalendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
        SeondCalendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
        SeondCalendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
        SeondCalendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
        SeondCalendar.TabIndex = 3;
        // 
        // SecondCalendarLabel
        // 
        SecondCalendarLabel.BindingSource = null;
        SecondCalendarLabel.DataFilter = null;
        SecondCalendarLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        SecondCalendarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SecondCalendarLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SecondCalendarLabel.HoverText = null;
        SecondCalendarLabel.IsDerivedStyle = true;
        SecondCalendarLabel.Location = new System.Drawing.Point( 3, 19 );
        SecondCalendarLabel.Margin = new System.Windows.Forms.Padding( 3 );
        SecondCalendarLabel.Name = "SecondCalendarLabel";
        SecondCalendarLabel.Padding = new System.Windows.Forms.Padding( 1 );
        SecondCalendarLabel.Size = new System.Drawing.Size( 342, 27 );
        SecondCalendarLabel.Style = MetroSet_UI.Enums.Style.Custom;
        SecondCalendarLabel.StyleManager = null;
        SecondCalendarLabel.TabIndex = 2;
        SecondCalendarLabel.Text = "Label";
        SecondCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        SecondCalendarLabel.ThemeAuthor = "Terry D. Eppler";
        SecondCalendarLabel.ThemeName = "Budget Execution";
        SecondCalendarLabel.ToolTip = null;
        // 
        // SqlTabPage
        // 
        SqlTabPage.Controls.Add( EditorTable );
        SqlTabPage.Controls.Add( SqlCommandTable );
        SqlTabPage.ForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SqlTabPage.Image = null;
        SqlTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
        SqlTabPage.Location = new System.Drawing.Point( 0, 29 );
        SqlTabPage.Name = "SqlTabPage";
        SqlTabPage.ShowCloseButton = true;
        SqlTabPage.Size = new System.Drawing.Size( 1328, 515 );
        SqlTabPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SqlTabPage.TabForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SqlTabPage.TabIndex = 5;
        SqlTabPage.Text = " ";
        SqlTabPage.ThemesEnabled = false;
        // 
        // EditorTable
        // 
        EditorTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EditorTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        EditorTable.CaptionText = "SQL Text Editor";
        EditorTable.ColumnCount = 1;
        EditorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        EditorTable.Controls.Add( EditorPanel, 0, 1 );
        EditorTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EditorTable.ForeColor = System.Drawing.Color.DarkGray;
        EditorTable.Location = new System.Drawing.Point( 42, 3 );
        EditorTable.Name = "EditorTable";
        EditorTable.RowCount = 2;
        EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.15264177F ) );
        EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.84736F ) );
        EditorTable.Size = new System.Drawing.Size( 887, 509 );
        EditorTable.TabIndex = 7;
        // 
        // EditorPanel
        // 
        EditorPanel.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        EditorPanel.BackColor = System.Drawing.Color.Transparent;
        EditorPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EditorPanel.BindingSource = null;
        EditorPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        EditorPanel.BorderThickness = 1;
        EditorPanel.Children = null;
        EditorPanel.Controls.Add( SqlEditor );
        EditorPanel.DataFilter = null;
        EditorPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EditorPanel.ForeColor = System.Drawing.Color.Transparent;
        EditorPanel.HoverText = null;
        EditorPanel.IsDerivedStyle = true;
        EditorPanel.Location = new System.Drawing.Point( 3, 29 );
        EditorPanel.Name = "EditorPanel";
        EditorPanel.Padding = new System.Windows.Forms.Padding( 1 );
        EditorPanel.Size = new System.Drawing.Size( 881, 477 );
        EditorPanel.Style = MetroSet_UI.Enums.Style.Custom;
        EditorPanel.StyleManager = null;
        EditorPanel.TabIndex = 0;
        EditorPanel.ThemeAuthor = "Terry D. Eppler";
        EditorPanel.ThemeName = "BudgetExecution";
        EditorPanel.ToolTip = null;
        // 
        // SqlEditor
        // 
        SqlEditor.AllowZoom = false;
        SqlEditor.AlwaysShowScrollers = true;
        SqlEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        SqlEditor.BackColor = System.Drawing.SystemColors.ControlLight;
        SqlEditor.BookmarkTooltipBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        SqlEditor.CanOverrideStyle = true;
        SqlEditor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(   255  ,   238  ,   98   );
        SqlEditor.CodeSnipptSize = new System.Drawing.Size( 100, 100 );
        SqlEditor.ColumnGuidesMeasuringFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlEditor.Configurator = config1;
        SqlEditor.ContextChoiceBackColor = System.Drawing.SystemColors.ControlLight;
        SqlEditor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(   233  ,   166  ,   50   );
        SqlEditor.ContextPromptBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlEditor.ContextTooltipBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlEditor.CurrentLineHighlightColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlEditor.EndOfLineBackColor = System.Drawing.SystemColors.ControlLight;
        SqlEditor.EndOfLineForeColor = System.Drawing.SystemColors.ControlLight;
        SqlEditor.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlEditor.ForeColor = System.Drawing.Color.Black;
        SqlEditor.HighlightCurrentLine = true;
        SqlEditor.IndentationBlockBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlEditor.IndentBlockHighlightingColor = System.Drawing.SystemColors.ActiveCaption;
        SqlEditor.IndentLineColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SqlEditor.IndicatorMarginBackColor = System.Drawing.SystemColors.ControlLight;
        SqlEditor.LineNumbersColor = System.Drawing.Color.Black;
        SqlEditor.LineNumbersFont = new System.Drawing.Font( "Hack", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        SqlEditor.Location = new System.Drawing.Point( 17, 14 );
        SqlEditor.Name = "SqlEditor";
        SqlEditor.RenderRightToLeft = false;
        SqlEditor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
        SqlEditor.ScrollPosition = new System.Drawing.Point( 0, 0 );
        SqlEditor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
        SqlEditor.SelectionMarginBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
        SqlEditor.SelectionTextColor = System.Drawing.Color.White;
        SqlEditor.ShowEndOfLine = false;
        SqlEditor.Size = new System.Drawing.Size( 851, 448 );
        SqlEditor.StatusBarSettings.CoordsPanel.Width = 150;
        SqlEditor.StatusBarSettings.EncodingPanel.Width = 100;
        SqlEditor.StatusBarSettings.FileNamePanel.Width = 100;
        SqlEditor.StatusBarSettings.InsertPanel.Width = 33;
        SqlEditor.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
        SqlEditor.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
        SqlEditor.StatusBarSettings.StatusPanel.Width = 70;
        SqlEditor.StatusBarSettings.TextPanel.Width = 214;
        SqlEditor.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Office2016Black;
        SqlEditor.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black;
        SqlEditor.TabIndex = 0;
        SqlEditor.TabSize = 4;
        SqlEditor.Text = "";
        SqlEditor.TextAreaWidth = 400;
        SqlEditor.ThemeName = "Office2016Black";
        SqlEditor.UserMarginTextColor = System.Drawing.Color.DimGray;
        SqlEditor.UseXPStyle = false;
        SqlEditor.UseXPStyleBorder = true;
        SqlEditor.VisualColumn = 1;
        SqlEditor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
        SqlEditor.WordWrap = true;
        SqlEditor.WordWrapColumn = 80;
        SqlEditor.ZoomFactor = 1F;
        // 
        // SqlCommandTable
        // 
        SqlCommandTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        SqlCommandTable.ColumnCount = 1;
        SqlCommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        SqlCommandTable.Controls.Add( SqlStatementTable, 0, 2 );
        SqlCommandTable.Controls.Add( CommandTable, 0, 0 );
        SqlCommandTable.Location = new System.Drawing.Point( 948, 3 );
        SqlCommandTable.Name = "SqlCommandTable";
        SqlCommandTable.RowCount = 3;
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 28F ) );
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 375F ) );
        SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
        SqlCommandTable.Size = new System.Drawing.Size( 352, 509 );
        SqlCommandTable.TabIndex = 6;
        // 
        // SqlStatementTable
        // 
        SqlStatementTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SqlStatementTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        SqlStatementTable.CaptionText = "SQL Statements";
        SqlStatementTable.ColumnCount = 1;
        SqlStatementTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SqlStatementTable.Controls.Add( TextPanel, 0, 1 );
        SqlStatementTable.Dock = System.Windows.Forms.DockStyle.Fill;
        SqlStatementTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SqlStatementTable.ForeColor = System.Drawing.Color.DarkGray;
        SqlStatementTable.Location = new System.Drawing.Point( 3, 137 );
        SqlStatementTable.Name = "SqlStatementTable";
        SqlStatementTable.RowCount = 2;
        SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.58422947F ) );
        SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.41577F ) );
        SqlStatementTable.Size = new System.Drawing.Size( 346, 369 );
        SqlStatementTable.TabIndex = 1;
        // 
        // TextPanel
        // 
        TextPanel.BackColor = System.Drawing.Color.Transparent;
        TextPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TextPanel.BindingSource = null;
        TextPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        TextPanel.BorderThickness = 1;
        TextPanel.Children = null;
        TextPanel.Controls.Add( CommandQueryListBox );
        TextPanel.DataFilter = null;
        TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        TextPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TextPanel.ForeColor = System.Drawing.Color.Transparent;
        TextPanel.HoverText = null;
        TextPanel.IsDerivedStyle = true;
        TextPanel.Location = new System.Drawing.Point( 3, 31 );
        TextPanel.Name = "TextPanel";
        TextPanel.Padding = new System.Windows.Forms.Padding( 1 );
        TextPanel.Size = new System.Drawing.Size( 340, 335 );
        TextPanel.Style = MetroSet_UI.Enums.Style.Custom;
        TextPanel.StyleManager = null;
        TextPanel.TabIndex = 1;
        TextPanel.ThemeAuthor = "Terry D. Eppler";
        TextPanel.ThemeName = "Budget Execution";
        TextPanel.ToolTip = null;
        // 
        // CommandQueryListBox
        // 
        CommandQueryListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        CommandQueryListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        CommandQueryListBox.BindingSource = null;
        CommandQueryListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        CommandQueryListBox.DataFilter = null;
        CommandQueryListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CommandQueryListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CommandQueryListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CommandQueryListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        CommandQueryListBox.HoveredItemColor = System.Drawing.Color.White;
        CommandQueryListBox.HoverText = null;
        CommandQueryListBox.IsDerivedStyle = true;
        CommandQueryListBox.ItemHeight = 28;
        CommandQueryListBox.Location = new System.Drawing.Point( 15, 23 );
        CommandQueryListBox.Margin = new System.Windows.Forms.Padding( 1 );
        CommandQueryListBox.MultiSelect = true;
        CommandQueryListBox.Name = "CommandQueryListBox";
        CommandQueryListBox.Padding = new System.Windows.Forms.Padding( 1 );
        CommandQueryListBox.SelectedIndex = -1;
        CommandQueryListBox.SelectedItem = null;
        CommandQueryListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CommandQueryListBox.SelectedItemColor = System.Drawing.Color.White;
        CommandQueryListBox.SelectedText = null;
        CommandQueryListBox.SelectedValue = null;
        CommandQueryListBox.ShowBorder = false;
        CommandQueryListBox.ShowScrollBar = false;
        CommandQueryListBox.Size = new System.Drawing.Size( 308, 291 );
        CommandQueryListBox.Style = MetroSet_UI.Enums.Style.Custom;
        CommandQueryListBox.StyleManager = null;
        CommandQueryListBox.TabIndex = 0;
        CommandQueryListBox.ThemeAuthor = "Terry D. Eppler";
        CommandQueryListBox.ThemeName = "Budget Execution";
        CommandQueryListBox.ToolTip = null;
        // 
        // CommandTable
        // 
        CommandTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CommandTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        CommandTable.CaptionText = "Commands";
        CommandTable.ColumnCount = 1;
        CommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        CommandTable.Controls.Add( CommandPanel, 0, 1 );
        CommandTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CommandTable.ForeColor = System.Drawing.Color.DarkGray;
        CommandTable.Location = new System.Drawing.Point( 3, 3 );
        CommandTable.Name = "CommandTable";
        CommandTable.RowCount = 2;
        CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90F ) );
        CommandTable.Size = new System.Drawing.Size( 346, 96 );
        CommandTable.TabIndex = 1;
        // 
        // CommandPanel
        // 
        CommandPanel.BackColor = System.Drawing.Color.Transparent;
        CommandPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CommandPanel.BindingSource = null;
        CommandPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        CommandPanel.BorderThickness = 1;
        CommandPanel.Children = null;
        CommandPanel.Controls.Add( CommandQueryComboBox );
        CommandPanel.DataFilter = null;
        CommandPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CommandPanel.ForeColor = System.Drawing.Color.Transparent;
        CommandPanel.HoverText = null;
        CommandPanel.IsDerivedStyle = true;
        CommandPanel.Location = new System.Drawing.Point( 3, 27 );
        CommandPanel.Name = "CommandPanel";
        CommandPanel.Padding = new System.Windows.Forms.Padding( 1 );
        CommandPanel.Size = new System.Drawing.Size( 340, 66 );
        CommandPanel.Style = MetroSet_UI.Enums.Style.Custom;
        CommandPanel.StyleManager = null;
        CommandPanel.TabIndex = 2;
        CommandPanel.ThemeAuthor = "Terry D. Eppler";
        CommandPanel.ThemeName = "Budget Execution";
        CommandPanel.ToolTip = null;
        // 
        // CommandQueryComboBox
        // 
        CommandQueryComboBox.AllowDrop = true;
        CommandQueryComboBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
        CommandQueryComboBox.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CommandQueryComboBox.BackColor = System.Drawing.Color.Transparent;
        CommandQueryComboBox.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        CommandQueryComboBox.BindingSource = null;
        CommandQueryComboBox.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
        CommandQueryComboBox.CausesValidation = false;
        CommandQueryComboBox.DataFilter = null;
        CommandQueryComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
        CommandQueryComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        CommandQueryComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
        CommandQueryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        CommandQueryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        CommandQueryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        CommandQueryComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CommandQueryComboBox.FormattingEnabled = true;
        CommandQueryComboBox.HoverText = null;
        CommandQueryComboBox.IsDerivedStyle = true;
        CommandQueryComboBox.ItemHeight = 24;
        CommandQueryComboBox.Location = new System.Drawing.Point( 29, 23 );
        CommandQueryComboBox.Name = "CommandQueryComboBox";
        CommandQueryComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CommandQueryComboBox.SelectedItemForeColor = System.Drawing.Color.White;
        CommandQueryComboBox.Size = new System.Drawing.Size( 286, 30 );
        CommandQueryComboBox.Style = MetroSet_UI.Enums.Style.Custom;
        CommandQueryComboBox.StyleManager = null;
        CommandQueryComboBox.TabIndex = 0;
        CommandQueryComboBox.ThemeAuthor = "Terry D. Eppler";
        CommandQueryComboBox.ThemeName = "Budget Execution";
        CommandQueryComboBox.ToolTip = null;
        // 
        // ContextMenu
        // 
        ContextMenu.AutoSize = false;
        ContextMenu.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
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
        // CloseButton
        // 
        CloseButton.BindingSource = null;
        CloseButton.DataFilter = null;
        CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
        CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
        CloseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CloseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        CloseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        CloseButton.HoverText = "Close Window";
        CloseButton.HoverTextColor = System.Drawing.Color.White;
        CloseButton.IsDerivedStyle = true;
        CloseButton.Location = new System.Drawing.Point( 1108, 550 );
        CloseButton.Name = "CloseButton";
        CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        CloseButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        CloseButton.NormalTextColor = System.Drawing.Color.DarkGray;
        CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
        CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.PressTextColor = System.Drawing.Color.White;
        CloseButton.Size = new System.Drawing.Size( 90, 30 );
        CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
        CloseButton.StyleManager = null;
        CloseButton.TabIndex = 15;
        CloseButton.Text = "Close";
        CloseButton.ThemeAuthor = "Terry D. Eppler";
        CloseButton.ThemeName = "Budget Execution";
        CloseButton.ToolTip = ToolTip;
        // 
        // SelectButton
        // 
        SelectButton.BindingSource = null;
        SelectButton.DataFilter = null;
        SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
        SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
        SelectButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SelectButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        SelectButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        SelectButton.HoverText = "Choose Selected";
        SelectButton.HoverTextColor = System.Drawing.Color.White;
        SelectButton.IsDerivedStyle = true;
        SelectButton.Location = new System.Drawing.Point( 789, 550 );
        SelectButton.Name = "SelectButton";
        SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        SelectButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        SelectButton.NormalTextColor = System.Drawing.Color.DarkGray;
        SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
        SelectButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SelectButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SelectButton.PressTextColor = System.Drawing.Color.White;
        SelectButton.Size = new System.Drawing.Size( 90, 30 );
        SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
        SelectButton.StyleManager = null;
        SelectButton.TabIndex = 16;
        SelectButton.Text = "Select";
        SelectButton.ThemeAuthor = "Terry D. Eppler";
        SelectButton.ThemeName = "Budget Execution";
        SelectButton.ToolTip = null;
        // 
        // GroupButton
        // 
        GroupButton.BindingSource = null;
        GroupButton.DataFilter = null;
        GroupButton.DisabledBackColor = System.Drawing.Color.Transparent;
        GroupButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        GroupButton.DisabledForeColor = System.Drawing.Color.Transparent;
        GroupButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        GroupButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        GroupButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        GroupButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        GroupButton.HoverText = "Group Selections";
        GroupButton.HoverTextColor = System.Drawing.Color.White;
        GroupButton.IsDerivedStyle = true;
        GroupButton.Location = new System.Drawing.Point( 429, 550 );
        GroupButton.Name = "GroupButton";
        GroupButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        GroupButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        GroupButton.NormalTextColor = System.Drawing.Color.DarkGray;
        GroupButton.Padding = new System.Windows.Forms.Padding( 1 );
        GroupButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        GroupButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        GroupButton.PressTextColor = System.Drawing.Color.White;
        GroupButton.Size = new System.Drawing.Size( 90, 30 );
        GroupButton.Style = MetroSet_UI.Enums.Style.Custom;
        GroupButton.StyleManager = null;
        GroupButton.TabIndex = 17;
        GroupButton.Text = "Group";
        GroupButton.ThemeAuthor = "Terry D. Eppler";
        GroupButton.ThemeName = "Budget Execution";
        GroupButton.ToolTip = null;
        // 
        // ClearButton
        // 
        ClearButton.BindingSource = null;
        ClearButton.DataFilter = null;
        ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
        ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
        ClearButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ClearButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        ClearButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        ClearButton.HoverText = "Clear Selections";
        ClearButton.HoverTextColor = System.Drawing.Color.White;
        ClearButton.IsDerivedStyle = true;
        ClearButton.Location = new System.Drawing.Point( 115, 550 );
        ClearButton.Name = "ClearButton";
        ClearButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        ClearButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        ClearButton.NormalTextColor = System.Drawing.Color.DarkGray;
        ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
        ClearButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClearButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClearButton.PressTextColor = System.Drawing.Color.White;
        ClearButton.Size = new System.Drawing.Size( 90, 30 );
        ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
        ClearButton.StyleManager = null;
        ClearButton.TabIndex = 18;
        ClearButton.Text = "Clear";
        ClearButton.ThemeAuthor = "Terry D. Eppler";
        ClearButton.ThemeName = "Budget Execution";
        ClearButton.ToolTip = null;
        // 
        // FilterDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
        CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClientSize = new System.Drawing.Size( 1328, 638 );
        Controls.Add( ClearButton );
        Controls.Add( GroupButton );
        Controls.Add( SelectButton );
        Controls.Add( CloseButton );
        Controls.Add( TabControl );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.LightGray;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size( 1340, 674 );
        MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size( 1340, 674 );
        Name = "FilterDialog";
        ShowIcon = false;
        ShowMaximizeBox = false;
        ShowMinimizeBox = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        FirstPanel.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        ThirdPanel.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) TabControl  ).EndInit( );
        TabControl.ResumeLayout( false );
        TableTabPage.ResumeLayout( false );
        MaintenanceTable.ResumeLayout( false );
        MaintenancePanel.ResumeLayout( false );
        ReferenceTable.ResumeLayout( false );
        ReferencePanel.ResumeLayout( false );
        SourceTable.ResumeLayout( false );
        TablePanel.ResumeLayout( false );
        ProviderTable.ResumeLayout( false );
        ProviderPanel.ResumeLayout( false );
        FilterTabPage.ResumeLayout( false );
        FourthTable.ResumeLayout( false );
        FourthPanel.ResumeLayout( false );
        ThirdTable.ResumeLayout( false );
        SecondTable.ResumeLayout( false );
        SecondPanel.ResumeLayout( false );
        FirstTable.ResumeLayout( false );
        GroupTabPage.ResumeLayout( false );
        SqlTable.ResumeLayout( false );
        SqlPanel.ResumeLayout( false );
        NumericTable.ResumeLayout( false );
        NumericPanel.ResumeLayout( false );
        FieldTable.ResumeLayout( false );
        FieldPanel.ResumeLayout( false );
        CalendarTabPage.ResumeLayout( false );
        TimeSpanPanel.ResumeLayout( false );
        TimeSpanTable.ResumeLayout( false );
        StartDatePanel.ResumeLayout( false );
        FirstCalendarTable.ResumeLayout( false );
        EndDatePanel.ResumeLayout( false );
        SecondCalendarTable.ResumeLayout( false );
        SqlTabPage.ResumeLayout( false );
        EditorTable.ResumeLayout( false );
        EditorPanel.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).EndInit( );
        SqlCommandTable.ResumeLayout( false );
        SqlStatementTable.ResumeLayout( false );
        TextPanel.ResumeLayout( false );
        CommandTable.ResumeLayout( false );
        CommandPanel.ResumeLayout( false );
        ResumeLayout( false );
    }

    #endregion
    public ComboBox FirstComboBox;
    public Layout FirstPanel;
    public ListBox FirstListBox;
    public ComboBox ThirdComboBox;
    public Layout ThirdPanel;
    public ListBox ThirdListBox;
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    public TabControl TabControl;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv TableTabPage;
    public Layout ProviderPanel;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv FilterTabPage;
    public RadioButton AccessRadioButton;
    public RadioButton SqlServerRadioButton;
    public RadioButton SQLiteRadioButton;
    public RadioButton SqlCeRadioButton;
    public Label FirstCalendarLabel;
    public Label SecondCalendarLabel;
    public Syncfusion.WinForms.Input.SfCalendar FirstCalendar;
    public Syncfusion.WinForms.Input.SfCalendar SeondCalendar;
    public Layout TablePanel;
    public Label TableLabel1;
    public ComboBox FourthComboBox;
    public ComboBox SecondComboBox;
    public Layout SecondPanel;
    public ListBox SecondListBox;
    public ListBox TableListBox;
    public Layout ReferencePanel;
    public ListBox ReferenceListBox;
    public Layout FourthPanel;
    public ListBox FourthListBox;
    public Layout MaintenancePanel;
    public ListBox MaintenanceListBox;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv GroupTabPage;
    public HeaderPanel NumericTable;
    public Layout NumericPanel;
    public ListBox NumericListBox;
    public HeaderPanel FieldTable;
    public Layout FieldPanel;
    public ListBox FieldListBox;
    public ContextMenu ContextMenu;
    public HeaderPanel SqlTable;
    public Layout SqlPanel;
    public TextBox SqlTextBox;
    public HeaderPanel MaintenanceTable;
    public HeaderPanel ReferenceTable;
    public HeaderPanel SourceTable;
    public HeaderPanel ProviderTable;
    public HeaderPanel FourthTable;
    public HeaderPanel ThirdTable;
    public HeaderPanel SecondTable;
    public HeaderPanel FirstTable;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv CalendarTabPage;
    public Label SourceHeader;
    public Label GroupHeader;
    public Label FilterHeader;
    public HeaderPanel FirstCalendarTable;
    public HeaderPanel SecondCalendarTable;
    public Label TimeSpanHeader;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv SqlTabPage;
    public HeaderPanel EditorTable;
    public Layout EditorPanel;
    public Editor SqlEditor;
    public System.Windows.Forms.TableLayoutPanel SqlCommandTable;
    public RadioButton SqlEditorAccessRadioButton;
    public RadioButton SqlEditorSQLiteRadioButton;
    public HeaderPanel CommandTable;
    public Layout CommandPanel;
    public ComboBox CommandQueryComboBox;
    public HeaderPanel SqlStatementTable;
    public Layout TextPanel;
    public ListBox CommandQueryListBox;
    public Layout EndDatePanel;
    public Layout StartDatePanel;
    public Layout TimeSpanPanel;
    public HeaderPanel TimeSpanTable;
    public Label TimeSpanLabel;
    public Label FirstLabel;
    public Label SecondLabel;
    public Label ThirdLabel;
    public Label FourthLabel;
    public Label FifthLable;
    public Button CloseButton;
    public Button SelectButton;
    public Button GroupButton;
    public Button ClearButton;
}