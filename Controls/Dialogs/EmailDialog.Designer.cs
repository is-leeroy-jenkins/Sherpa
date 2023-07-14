// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class EmailDialog
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
        var textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem9 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem10 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem11 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem12 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( EmailDialog ) );
        ThirdTile = new Tile( );
        FirstTile = new Tile( );
        SecondTile = new Tile( );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        EmailTable = new HeaderPanel( );
        TabControl = new TabControl( );
        InboxTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        EmailPanel = new Layout( );
        EmailListBox = new ListBox( );
        SentTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        SentPanel = new Layout( );
        SentListBox = new ListBox( );
        DeletedTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
        DeletePanel = new Layout( );
        DeletedItemsListBox = new ListBox( );
        TileTable = new HeaderPanel( );
        TilePanel = new Layout( );
        RadioButtonTable = new System.Windows.Forms.TableLayoutPanel( );
        DeletedRadioButton = new RadioButton( );
        SentRadioButton = new RadioButton( );
        InboxRadioButton = new RadioButton( );
        ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
        CloseButton = new Button( );
        ClearButton = new Button( );
        EditorTable = new HeaderPanel( );
        SqlEditor = new Editor( );
        TitleTable = new System.Windows.Forms.TableLayoutPanel( );
        PictureBox = new System.Windows.Forms.PictureBox( );
        Title = new Label( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        EmailTable.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) TabControl  ).BeginInit( );
        TabControl.SuspendLayout( );
        InboxTab.SuspendLayout( );
        EmailPanel.SuspendLayout( );
        SentTab.SuspendLayout( );
        SentPanel.SuspendLayout( );
        DeletedTab.SuspendLayout( );
        DeletePanel.SuspendLayout( );
        TileTable.SuspendLayout( );
        TilePanel.SuspendLayout( );
        RadioButtonTable.SuspendLayout( );
        ButtonTable.SuspendLayout( );
        EditorTable.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).BeginInit( );
        TitleTable.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
        SuspendLayout( );
        // 
        // ThirdTile
        // 
        ThirdTile.Anchor = System.Windows.Forms.AnchorStyles.None;
        ThirdTile.BackColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
        textItem1.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem1.HubTile = ThirdTile;
        textItem1.TextColor = System.Drawing.Color.DarkGray;
        ThirdTile.Banner = textItem1;
        ThirdTile.BannerColor = System.Drawing.Color.Transparent;
        ThirdTile.BannerHeight = 26;
        ThirdTile.BindingSource = null;
        textItem2.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem2.HubTile = ThirdTile;
        textItem2.TextColor = System.Drawing.Color.DarkGray;
        ThirdTile.Body = textItem2;
        ThirdTile.DataFilter = null;
        ThirdTile.EnableSelectionMarker = false;
        ThirdTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem3.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem3.HubTile = ThirdTile;
        textItem3.TextColor = System.Drawing.Color.DarkGray;
        ThirdTile.Footer = textItem3;
        ThirdTile.ForeColor = System.Drawing.Color.LightSteelBlue;
        ThirdTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        ThirdTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        ThirdTile.HoverText = null;
        ThirdTile.Location = new System.Drawing.Point( 40, 159 );
        ThirdTile.Margin = new System.Windows.Forms.Padding( 1 );
        ThirdTile.MinimumSize = new System.Drawing.Size( 100, 50 );
        ThirdTile.Name = "ThirdTile";
        ThirdTile.ShowBanner = true;
        ThirdTile.ShowBannerIcon = true;
        ThirdTile.Size = new System.Drawing.Size( 168, 50 );
        ThirdTile.TabIndex = 1;
        textItem4.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem4.HubTile = ThirdTile;
        textItem4.TextColor = System.Drawing.Color.DarkGray;
        ThirdTile.Title = textItem4;
        ThirdTile.ToolTip = null;
        ThirdTile.TurnLiveTileOn = true;
        // 
        // FirstTile
        // 
        FirstTile.Anchor = System.Windows.Forms.AnchorStyles.None;
        FirstTile.BackColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
        textItem5.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem5.HubTile = FirstTile;
        textItem5.TextColor = System.Drawing.Color.DarkGray;
        FirstTile.Banner = textItem5;
        FirstTile.BannerColor = System.Drawing.Color.Transparent;
        FirstTile.BannerHeight = 26;
        FirstTile.BindingSource = null;
        textItem6.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem6.HubTile = FirstTile;
        textItem6.TextColor = System.Drawing.Color.DarkGray;
        FirstTile.Body = textItem6;
        FirstTile.DataFilter = null;
        FirstTile.EnableSelectionMarker = false;
        FirstTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem7.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem7.HubTile = FirstTile;
        textItem7.TextColor = System.Drawing.Color.DarkGray;
        FirstTile.Footer = textItem7;
        FirstTile.ForeColor = System.Drawing.Color.LightSteelBlue;
        FirstTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        FirstTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        FirstTile.HoverText = null;
        FirstTile.Location = new System.Drawing.Point( 40, 21 );
        FirstTile.Margin = new System.Windows.Forms.Padding( 1 );
        FirstTile.MinimumSize = new System.Drawing.Size( 100, 50 );
        FirstTile.Name = "FirstTile";
        FirstTile.ShowBanner = true;
        FirstTile.ShowBannerIcon = true;
        FirstTile.Size = new System.Drawing.Size( 168, 50 );
        FirstTile.TabIndex = 2;
        textItem8.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem8.HubTile = FirstTile;
        textItem8.TextColor = System.Drawing.Color.DarkGray;
        FirstTile.Title = textItem8;
        FirstTile.ToolTip = null;
        FirstTile.TurnLiveTileOn = true;
        // 
        // SecondTile
        // 
        SecondTile.Anchor = System.Windows.Forms.AnchorStyles.None;
        SecondTile.BackColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
        textItem9.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem9.HubTile = SecondTile;
        textItem9.TextColor = System.Drawing.Color.DarkGray;
        SecondTile.Banner = textItem9;
        SecondTile.BannerColor = System.Drawing.Color.Transparent;
        SecondTile.BannerHeight = 26;
        SecondTile.BindingSource = null;
        textItem10.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem10.HubTile = SecondTile;
        textItem10.TextColor = System.Drawing.Color.DarkGray;
        SecondTile.Body = textItem10;
        SecondTile.DataFilter = null;
        SecondTile.EnableSelectionMarker = false;
        SecondTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem11.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem11.HubTile = SecondTile;
        textItem11.TextColor = System.Drawing.Color.DarkGray;
        SecondTile.Footer = textItem11;
        SecondTile.ForeColor = System.Drawing.Color.LightSteelBlue;
        SecondTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        SecondTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        SecondTile.HoverText = null;
        SecondTile.Location = new System.Drawing.Point( 40, 85 );
        SecondTile.Margin = new System.Windows.Forms.Padding( 1 );
        SecondTile.MinimumSize = new System.Drawing.Size( 100, 50 );
        SecondTile.Name = "SecondTile";
        SecondTile.ShowBanner = true;
        SecondTile.ShowBannerIcon = true;
        SecondTile.Size = new System.Drawing.Size( 168, 50 );
        SecondTile.TabIndex = 0;
        textItem12.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem12.HubTile = SecondTile;
        textItem12.TextColor = System.Drawing.Color.DarkGray;
        SecondTile.Title = textItem12;
        SecondTile.ToolTip = null;
        SecondTile.TurnLiveTileOn = true;
        // 
        // EmailTable
        // 
        EmailTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EmailTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        EmailTable.CaptionText = "";
        EmailTable.ColumnCount = 1;
        EmailTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        EmailTable.Controls.Add( TabControl, 0, 1 );
        EmailTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EmailTable.ForeColor = System.Drawing.Color.DarkGray;
        EmailTable.Location = new System.Drawing.Point( 12, 48 );
        EmailTable.Name = "EmailTable";
        EmailTable.RowCount = 2;
        EmailTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.137255F ) );
        EmailTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.86275F ) );
        EmailTable.Size = new System.Drawing.Size( 685, 271 );
        EmailTable.TabIndex = 0;
        // 
        // TabControl
        // 
        TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TabControl.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.BeforeTouchSize = new System.Drawing.Size( 679, 257 );
        TabControl.BindingSource = null;
        TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
        TabControl.BorderWidth = 1;
        TabControl.CanOverrideStyle = true;
        TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.Controls.Add( InboxTab );
        TabControl.Controls.Add( SentTab );
        TabControl.Controls.Add( DeletedTab );
        TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        TabControl.FocusOnTabClick = false;
        TabControl.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TabControl.ForeColor = System.Drawing.Color.LightGray;
        TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ItemSize = new System.Drawing.Size( 100, 30 );
        TabControl.Location = new System.Drawing.Point( 3, 11 );
        TabControl.Name = "TabControl";
        TabControl.Size = new System.Drawing.Size( 679, 257 );
        TabControl.TabIndex = 0;
        TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
        TabControl.ThemeName = "TabRendererMetro";
        TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.DarkGray;
        TabControl.ThemeStyle.TabStyle.SeparatorColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TabControl.ToolTip = null;
        // 
        // InboxTab
        // 
        InboxTab.Controls.Add( EmailPanel );
        InboxTab.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        InboxTab.Image = null;
        InboxTab.ImageSize = new System.Drawing.Size( 16, 16 );
        InboxTab.Location = new System.Drawing.Point( 0, 29 );
        InboxTab.Name = "InboxTab";
        InboxTab.ShowCloseButton = true;
        InboxTab.Size = new System.Drawing.Size( 679, 228 );
        InboxTab.TabFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        InboxTab.TabIndex = 1;
        InboxTab.Text = "Email ";
        InboxTab.ThemesEnabled = false;
        // 
        // EmailPanel
        // 
        EmailPanel.BackColor = System.Drawing.Color.Transparent;
        EmailPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EmailPanel.BindingSource = null;
        EmailPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        EmailPanel.BorderThickness = 1;
        EmailPanel.Children = null;
        EmailPanel.Controls.Add( EmailListBox );
        EmailPanel.DataFilter = null;
        EmailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        EmailPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EmailPanel.ForeColor = System.Drawing.Color.Transparent;
        EmailPanel.HoverText = null;
        EmailPanel.IsDerivedStyle = true;
        EmailPanel.Location = new System.Drawing.Point( 0, 0 );
        EmailPanel.Name = "EmailPanel";
        EmailPanel.Padding = new System.Windows.Forms.Padding( 1 );
        EmailPanel.Size = new System.Drawing.Size( 679, 228 );
        EmailPanel.Style = MetroSet_UI.Enums.Style.Custom;
        EmailPanel.StyleManager = null;
        EmailPanel.TabIndex = 0;
        EmailPanel.ThemeAuthor = "Terry D. Eppler";
        EmailPanel.ThemeName = "Budget Execution";
        EmailPanel.ToolTip = null;
        // 
        // EmailListBox
        // 
        EmailListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        EmailListBox.BindingSource = null;
        EmailListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        EmailListBox.DataFilter = null;
        EmailListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EmailListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EmailListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EmailListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        EmailListBox.HoveredItemColor = System.Drawing.Color.White;
        EmailListBox.HoverText = null;
        EmailListBox.IsDerivedStyle = true;
        EmailListBox.ItemHeight = 18;
        EmailListBox.Location = new System.Drawing.Point( 16, 22 );
        EmailListBox.Margin = new System.Windows.Forms.Padding( 1 );
        EmailListBox.MultiSelect = true;
        EmailListBox.Name = "EmailListBox";
        EmailListBox.Padding = new System.Windows.Forms.Padding( 1 );
        EmailListBox.SelectedIndex = -1;
        EmailListBox.SelectedItem = null;
        EmailListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        EmailListBox.SelectedItemColor = System.Drawing.Color.White;
        EmailListBox.SelectedText = null;
        EmailListBox.SelectedValue = null;
        EmailListBox.ShowBorder = false;
        EmailListBox.ShowScrollBar = false;
        EmailListBox.Size = new System.Drawing.Size( 644, 188 );
        EmailListBox.Style = MetroSet_UI.Enums.Style.Custom;
        EmailListBox.StyleManager = null;
        EmailListBox.TabIndex = 0;
        EmailListBox.ThemeAuthor = "Terry D. Eppler";
        EmailListBox.ThemeName = "Budget Execution";
        EmailListBox.ToolTip = null;
        // 
        // SentTab
        // 
        SentTab.Controls.Add( SentPanel );
        SentTab.Image = null;
        SentTab.ImageSize = new System.Drawing.Size( 16, 16 );
        SentTab.Location = new System.Drawing.Point( 0, 29 );
        SentTab.Name = "SentTab";
        SentTab.ShowCloseButton = true;
        SentTab.Size = new System.Drawing.Size( 679, 228 );
        SentTab.TabIndex = 3;
        SentTab.Text = "Sent ";
        SentTab.ThemesEnabled = false;
        // 
        // SentPanel
        // 
        SentPanel.BackColor = System.Drawing.Color.Transparent;
        SentPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SentPanel.BindingSource = null;
        SentPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        SentPanel.BorderThickness = 1;
        SentPanel.Children = null;
        SentPanel.Controls.Add( SentListBox );
        SentPanel.DataFilter = null;
        SentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        SentPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SentPanel.ForeColor = System.Drawing.Color.Transparent;
        SentPanel.HoverText = null;
        SentPanel.IsDerivedStyle = true;
        SentPanel.Location = new System.Drawing.Point( 0, 0 );
        SentPanel.Name = "SentPanel";
        SentPanel.Padding = new System.Windows.Forms.Padding( 1 );
        SentPanel.Size = new System.Drawing.Size( 679, 228 );
        SentPanel.Style = MetroSet_UI.Enums.Style.Custom;
        SentPanel.StyleManager = null;
        SentPanel.TabIndex = 1;
        SentPanel.ThemeAuthor = "Terry D. Eppler";
        SentPanel.ThemeName = "Budget Execution";
        SentPanel.ToolTip = null;
        // 
        // SentListBox
        // 
        SentListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        SentListBox.BindingSource = null;
        SentListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        SentListBox.DataFilter = null;
        SentListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SentListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        SentListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SentListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        SentListBox.HoveredItemColor = System.Drawing.Color.White;
        SentListBox.HoverText = null;
        SentListBox.IsDerivedStyle = true;
        SentListBox.ItemHeight = 18;
        SentListBox.Location = new System.Drawing.Point( 16, 13 );
        SentListBox.Margin = new System.Windows.Forms.Padding( 1 );
        SentListBox.MultiSelect = true;
        SentListBox.Name = "SentListBox";
        SentListBox.Padding = new System.Windows.Forms.Padding( 1 );
        SentListBox.SelectedIndex = -1;
        SentListBox.SelectedItem = null;
        SentListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SentListBox.SelectedItemColor = System.Drawing.Color.White;
        SentListBox.SelectedText = null;
        SentListBox.SelectedValue = null;
        SentListBox.ShowBorder = false;
        SentListBox.ShowScrollBar = false;
        SentListBox.Size = new System.Drawing.Size( 639, 197 );
        SentListBox.Style = MetroSet_UI.Enums.Style.Custom;
        SentListBox.StyleManager = null;
        SentListBox.TabIndex = 0;
        SentListBox.ThemeAuthor = "Terry D. Eppler";
        SentListBox.ThemeName = "Budget Execution";
        SentListBox.ToolTip = null;
        // 
        // DeletedTab
        // 
        DeletedTab.Controls.Add( DeletePanel );
        DeletedTab.Image = null;
        DeletedTab.ImageSize = new System.Drawing.Size( 16, 16 );
        DeletedTab.Location = new System.Drawing.Point( 0, 29 );
        DeletedTab.Name = "DeletedTab";
        DeletedTab.ShowCloseButton = true;
        DeletedTab.Size = new System.Drawing.Size( 679, 228 );
        DeletedTab.TabIndex = 2;
        DeletedTab.Text = "Trash";
        DeletedTab.ThemesEnabled = false;
        // 
        // DeletePanel
        // 
        DeletePanel.BackColor = System.Drawing.Color.Transparent;
        DeletePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        DeletePanel.BindingSource = null;
        DeletePanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        DeletePanel.BorderThickness = 1;
        DeletePanel.Children = null;
        DeletePanel.Controls.Add( DeletedItemsListBox );
        DeletePanel.DataFilter = null;
        DeletePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        DeletePanel.ForeColor = System.Drawing.Color.Transparent;
        DeletePanel.HoverText = null;
        DeletePanel.IsDerivedStyle = true;
        DeletePanel.Location = new System.Drawing.Point( 3, 3 );
        DeletePanel.Name = "DeletePanel";
        DeletePanel.Padding = new System.Windows.Forms.Padding( 1 );
        DeletePanel.Size = new System.Drawing.Size( 667, 207 );
        DeletePanel.Style = MetroSet_UI.Enums.Style.Custom;
        DeletePanel.StyleManager = null;
        DeletePanel.TabIndex = 2;
        DeletePanel.ThemeAuthor = "Terry D. Eppler";
        DeletePanel.ThemeName = "Budget Execution";
        DeletePanel.ToolTip = null;
        // 
        // DeletedItemsListBox
        // 
        DeletedItemsListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        DeletedItemsListBox.BindingSource = null;
        DeletedItemsListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        DeletedItemsListBox.DataFilter = null;
        DeletedItemsListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        DeletedItemsListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        DeletedItemsListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        DeletedItemsListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        DeletedItemsListBox.HoveredItemColor = System.Drawing.Color.White;
        DeletedItemsListBox.HoverText = null;
        DeletedItemsListBox.IsDerivedStyle = true;
        DeletedItemsListBox.ItemHeight = 18;
        DeletedItemsListBox.Location = new System.Drawing.Point( 16, 13 );
        DeletedItemsListBox.Margin = new System.Windows.Forms.Padding( 1 );
        DeletedItemsListBox.MultiSelect = true;
        DeletedItemsListBox.Name = "DeletedItemsListBox";
        DeletedItemsListBox.Padding = new System.Windows.Forms.Padding( 1 );
        DeletedItemsListBox.SelectedIndex = -1;
        DeletedItemsListBox.SelectedItem = null;
        DeletedItemsListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        DeletedItemsListBox.SelectedItemColor = System.Drawing.Color.White;
        DeletedItemsListBox.SelectedText = null;
        DeletedItemsListBox.SelectedValue = null;
        DeletedItemsListBox.ShowBorder = false;
        DeletedItemsListBox.ShowScrollBar = false;
        DeletedItemsListBox.Size = new System.Drawing.Size( 639, 184 );
        DeletedItemsListBox.Style = MetroSet_UI.Enums.Style.Custom;
        DeletedItemsListBox.StyleManager = null;
        DeletedItemsListBox.TabIndex = 0;
        DeletedItemsListBox.ThemeAuthor = "Terry D. Eppler";
        DeletedItemsListBox.ThemeName = "Budget Execution";
        DeletedItemsListBox.ToolTip = null;
        // 
        // TileTable
        // 
        TileTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TileTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        TileTable.CaptionText = "";
        TileTable.ColumnCount = 1;
        TileTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        TileTable.Controls.Add( TilePanel, 0, 1 );
        TileTable.Controls.Add( RadioButtonTable, 0, 0 );
        TileTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TileTable.ForeColor = System.Drawing.Color.DarkGray;
        TileTable.Location = new System.Drawing.Point( 703, 48 );
        TileTable.Name = "TileTable";
        TileTable.RowCount = 2;
        TileTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 14.0221405F ) );
        TileTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 85.97786F ) );
        TileTable.Size = new System.Drawing.Size( 254, 271 );
        TileTable.TabIndex = 1;
        // 
        // TilePanel
        // 
        TilePanel.BackColor = System.Drawing.Color.Transparent;
        TilePanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        TilePanel.BindingSource = null;
        TilePanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        TilePanel.BorderThickness = 1;
        TilePanel.Children = null;
        TilePanel.Controls.Add( FirstTile );
        TilePanel.Controls.Add( ThirdTile );
        TilePanel.Controls.Add( SecondTile );
        TilePanel.DataFilter = null;
        TilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        TilePanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        TilePanel.ForeColor = System.Drawing.Color.Transparent;
        TilePanel.HoverText = null;
        TilePanel.IsDerivedStyle = true;
        TilePanel.Location = new System.Drawing.Point( 3, 41 );
        TilePanel.Name = "TilePanel";
        TilePanel.Padding = new System.Windows.Forms.Padding( 1 );
        TilePanel.Size = new System.Drawing.Size( 248, 227 );
        TilePanel.Style = MetroSet_UI.Enums.Style.Custom;
        TilePanel.StyleManager = null;
        TilePanel.TabIndex = 0;
        TilePanel.ThemeAuthor = "Terry D. Eppler";
        TilePanel.ThemeName = "Budget Execution";
        TilePanel.ToolTip = null;
        // 
        // RadioButtonTable
        // 
        RadioButtonTable.ColumnCount = 3;
        RadioButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        RadioButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        RadioButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 86F ) );
        RadioButtonTable.Controls.Add( DeletedRadioButton, 2, 0 );
        RadioButtonTable.Controls.Add( SentRadioButton, 1, 0 );
        RadioButtonTable.Controls.Add( InboxRadioButton, 0, 0 );
        RadioButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
        RadioButtonTable.Location = new System.Drawing.Point( 3, 3 );
        RadioButtonTable.Name = "RadioButtonTable";
        RadioButtonTable.RowCount = 1;
        RadioButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        RadioButtonTable.Size = new System.Drawing.Size( 248, 32 );
        RadioButtonTable.TabIndex = 1;
        // 
        // DeletedRadioButton
        // 
        DeletedRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        DeletedRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        DeletedRadioButton.Checked = false;
        DeletedRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        DeletedRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        DeletedRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        DeletedRadioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        DeletedRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        DeletedRadioButton.Group = 0;
        DeletedRadioButton.HoverText = null;
        DeletedRadioButton.IsDerivedStyle = true;
        DeletedRadioButton.Location = new System.Drawing.Point( 165, 12 );
        DeletedRadioButton.Name = "DeletedRadioButton";
        DeletedRadioButton.Result = null;
        DeletedRadioButton.Size = new System.Drawing.Size( 80, 17 );
        DeletedRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        DeletedRadioButton.StyleManager = null;
        DeletedRadioButton.TabIndex = 2;
        DeletedRadioButton.Text = "Deleted";
        DeletedRadioButton.ThemeAuthor = "Terry D. Eppler";
        DeletedRadioButton.ThemeName = "Budget Execution";
        DeletedRadioButton.ToolTip = null;
        // 
        // SentRadioButton
        // 
        SentRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        SentRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SentRadioButton.Checked = false;
        SentRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        SentRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        SentRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        SentRadioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        SentRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SentRadioButton.Group = 0;
        SentRadioButton.HoverText = null;
        SentRadioButton.IsDerivedStyle = true;
        SentRadioButton.Location = new System.Drawing.Point( 84, 12 );
        SentRadioButton.Name = "SentRadioButton";
        SentRadioButton.Result = null;
        SentRadioButton.Size = new System.Drawing.Size( 75, 17 );
        SentRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        SentRadioButton.StyleManager = null;
        SentRadioButton.TabIndex = 1;
        SentRadioButton.Text = "Sent";
        SentRadioButton.ThemeAuthor = "Terry D. Eppler";
        SentRadioButton.ThemeName = "Budget Execution";
        SentRadioButton.ToolTip = null;
        // 
        // InboxRadioButton
        // 
        InboxRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
        InboxRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        InboxRadioButton.Checked = false;
        InboxRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
        InboxRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        InboxRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   205  ,   205  ,   205   );
        InboxRadioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        InboxRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        InboxRadioButton.Group = 0;
        InboxRadioButton.HoverText = null;
        InboxRadioButton.IsDerivedStyle = true;
        InboxRadioButton.Location = new System.Drawing.Point( 3, 12 );
        InboxRadioButton.Name = "InboxRadioButton";
        InboxRadioButton.Result = null;
        InboxRadioButton.Size = new System.Drawing.Size( 75, 17 );
        InboxRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
        InboxRadioButton.StyleManager = null;
        InboxRadioButton.TabIndex = 0;
        InboxRadioButton.Text = "Inbox";
        InboxRadioButton.ThemeAuthor = "Terry D. Eppler";
        InboxRadioButton.ThemeName = "Budget Execution";
        InboxRadioButton.ToolTip = null;
        // 
        // ButtonTable
        // 
        ButtonTable.ColumnCount = 10;
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        ButtonTable.Controls.Add( CloseButton, 9, 0 );
        ButtonTable.Controls.Add( ClearButton, 7, 0 );
        ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
        ButtonTable.Location = new System.Drawing.Point( 0, 695 );
        ButtonTable.Name = "ButtonTable";
        ButtonTable.RowCount = 1;
        ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        ButtonTable.Size = new System.Drawing.Size( 969, 36 );
        ButtonTable.TabIndex = 2;
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
        CloseButton.HoverText = null;
        CloseButton.HoverTextColor = System.Drawing.Color.White;
        CloseButton.IsDerivedStyle = true;
        CloseButton.Location = new System.Drawing.Point( 867, 3 );
        CloseButton.Name = "CloseButton";
        CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
        CloseButton.NormalColor = System.Drawing.Color.Transparent;
        CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
        CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.PressTextColor = System.Drawing.Color.White;
        CloseButton.Size = new System.Drawing.Size( 90, 30 );
        CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
        CloseButton.StyleManager = null;
        CloseButton.TabIndex = 3;
        CloseButton.Text = "Close";
        CloseButton.ThemeAuthor = "Terry D. Eppler";
        CloseButton.ThemeName = "Budget Execution";
        CloseButton.ToolTip = null;
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
        ClearButton.HoverText = null;
        ClearButton.HoverTextColor = System.Drawing.Color.White;
        ClearButton.IsDerivedStyle = true;
        ClearButton.Location = new System.Drawing.Point( 675, 3 );
        ClearButton.Name = "ClearButton";
        ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
        ClearButton.NormalColor = System.Drawing.Color.Transparent;
        ClearButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
        ClearButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClearButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClearButton.PressTextColor = System.Drawing.Color.White;
        ClearButton.Size = new System.Drawing.Size( 90, 30 );
        ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
        ClearButton.StyleManager = null;
        ClearButton.TabIndex = 4;
        ClearButton.Text = "Clear";
        ClearButton.ThemeAuthor = "Terry D. Eppler";
        ClearButton.ThemeName = "Budget Execution";
        ClearButton.ToolTip = null;
        // 
        // EditorTable
        // 
        EditorTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        EditorTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        EditorTable.CaptionText = "Text Editor";
        EditorTable.ColumnCount = 1;
        EditorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        EditorTable.Controls.Add( SqlEditor, 0, 1 );
        EditorTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        EditorTable.ForeColor = System.Drawing.Color.DarkGray;
        EditorTable.Location = new System.Drawing.Point( 12, 334 );
        EditorTable.Name = "EditorTable";
        EditorTable.RowCount = 2;
        EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.3738873F ) );
        EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.6261139F ) );
        EditorTable.Size = new System.Drawing.Size( 945, 353 );
        EditorTable.TabIndex = 3;
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
        SqlEditor.Dock = System.Windows.Forms.DockStyle.Fill;
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
        SqlEditor.Location = new System.Drawing.Point( 3, 27 );
        SqlEditor.Name = "SqlEditor";
        SqlEditor.RenderRightToLeft = false;
        SqlEditor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
        SqlEditor.ScrollPosition = new System.Drawing.Point( 0, 0 );
        SqlEditor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
        SqlEditor.SelectionMarginBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
        SqlEditor.SelectionTextColor = System.Drawing.Color.White;
        SqlEditor.ShowEndOfLine = false;
        SqlEditor.Size = new System.Drawing.Size( 939, 323 );
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
        SqlEditor.TabIndex = 1;
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
        // TitleTable
        // 
        TitleTable.ColumnCount = 2;
        TitleTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 4.127967F ) );
        TitleTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 95.87203F ) );
        TitleTable.Controls.Add( PictureBox, 0, 0 );
        TitleTable.Controls.Add( Title, 1, 0 );
        TitleTable.Dock = System.Windows.Forms.DockStyle.Top;
        TitleTable.Location = new System.Drawing.Point( 0, 0 );
        TitleTable.Name = "TitleTable";
        TitleTable.RowCount = 1;
        TitleTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        TitleTable.Size = new System.Drawing.Size( 969, 27 );
        TitleTable.TabIndex = 4;
        // 
        // PictureBox
        // 
        PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        PictureBox.Location = new System.Drawing.Point( 3, 3 );
        PictureBox.Name = "PictureBox";
        PictureBox.Size = new System.Drawing.Size( 34, 21 );
        PictureBox.TabIndex = 0;
        PictureBox.TabStop = false;
        // 
        // Title
        // 
        Title.BindingSource = null;
        Title.DataFilter = null;
        Title.Dock = System.Windows.Forms.DockStyle.Fill;
        Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        Title.HoverText = null;
        Title.IsDerivedStyle = true;
        Title.Location = new System.Drawing.Point( 43, 3 );
        Title.Margin = new System.Windows.Forms.Padding( 3 );
        Title.Name = "Title";
        Title.Padding = new System.Windows.Forms.Padding( 1 );
        Title.Size = new System.Drawing.Size( 923, 21 );
        Title.Style = MetroSet_UI.Enums.Style.Custom;
        Title.StyleManager = null;
        Title.TabIndex = 1;
        Title.Text = "Title";
        Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        Title.ThemeAuthor = "Terry D. Eppler";
        Title.ThemeName = "Budget Execution";
        Title.ToolTip = null;
        // 
        // EmailDialog
        // 
        BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionBarHeight = 5;
        CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClientSize = new System.Drawing.Size( 969, 731 );
        Controls.Add( TitleTable );
        Controls.Add( EditorTable );
        Controls.Add( ButtonTable );
        Controls.Add( TileTable );
        Controls.Add( EmailTable );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.LightGray;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
        MaximumSize = new System.Drawing.Size( 981, 742 );
        MetroColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        MinimumSize = new System.Drawing.Size( 981, 742 );
        Name = "EmailDialog";
        ShowIcon = false;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        EmailTable.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) TabControl  ).EndInit( );
        TabControl.ResumeLayout( false );
        InboxTab.ResumeLayout( false );
        EmailPanel.ResumeLayout( false );
        SentTab.ResumeLayout( false );
        SentPanel.ResumeLayout( false );
        DeletedTab.ResumeLayout( false );
        DeletePanel.ResumeLayout( false );
        TileTable.ResumeLayout( false );
        TilePanel.ResumeLayout( false );
        RadioButtonTable.ResumeLayout( false );
        ButtonTable.ResumeLayout( false );
        EditorTable.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).EndInit( );
        TitleTable.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private DataGrid DataGrid;
    private HeaderPanel EmailTable;
    private Button button2;
    private Layout layout1;
    private ListBox EmailListBox;
    private Layout layout2;
    private Tile tile2;
    public Editor SqlEditor;
    public Button CloseButton;
    public Button ClearButton;
    public Layout TilePanel;
    public HeaderPanel TileTable;
    public Layout EmailPanel;
    public HeaderPanel EditorTable;
    private TabControl tabControl1;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv InboxTab;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv SentTab;
    public Syncfusion.Windows.Forms.Tools.TabPageAdv DeletedTab;
    public TabControl TabControl;
    public Layout SentPanel;
    public ListBox SentListBox;
    public Layout DeletePanel;
    public ListBox DeletedItemsListBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    public RadioButton DeletedRadioButton;
    public RadioButton SentRadioButton;
    public RadioButton InboxRadioButton;
    public System.Windows.Forms.TableLayoutPanel ButtonTable;
    public System.Windows.Forms.TableLayoutPanel RadioButtonTable;
    public Tile SecondTile;
    public Tile FirstTile;
    public Tile ThirdTile;
    public System.Windows.Forms.TableLayoutPanel TitleTable;
    public System.Windows.Forms.PictureBox PictureBox;
    public Label Title;
}