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
        var config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
        var textItem9 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem10 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem11 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem12 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( EmailDialog ) );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        headerPanel1 = new HeaderPanel( );
        headerPanel2 = new HeaderPanel( );
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel( );
        CloseButton = new Button( );
        ClearButton = new Button( );
        headerPanel3 = new HeaderPanel( );
        SqlEditor = new Editor( );
        listBox1 = new ListBox( );
        layout1 = new Layout( );
        layout2 = new Layout( );
        tile1 = new Tile( );
        tile2 = new Tile( );
        tile3 = new Tile( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        headerPanel1.SuspendLayout( );
        headerPanel2.SuspendLayout( );
        tableLayoutPanel1.SuspendLayout( );
        headerPanel3.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).BeginInit( );
        layout1.SuspendLayout( );
        layout2.SuspendLayout( );
        SuspendLayout( );
        // 
        // headerPanel1
        // 
        headerPanel1.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        headerPanel1.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        headerPanel1.ColumnCount = 1;
        headerPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        headerPanel1.Controls.Add( layout1, 0, 1 );
        headerPanel1.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        headerPanel1.ForeColor = System.Drawing.Color.DarkGray;
        headerPanel1.Location = new System.Drawing.Point( 35, 73 );
        headerPanel1.Name = "headerPanel1";
        headerPanel1.RowCount = 2;
        headerPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 8.580858F ) );
        headerPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 91.41914F ) );
        headerPanel1.Size = new System.Drawing.Size( 649, 246 );
        headerPanel1.TabIndex = 0;
        // 
        // headerPanel2
        // 
        headerPanel2.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        headerPanel2.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        headerPanel2.ColumnCount = 1;
        headerPanel2.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        headerPanel2.Controls.Add( layout2, 0, 1 );
        headerPanel2.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        headerPanel2.ForeColor = System.Drawing.Color.DarkGray;
        headerPanel2.Location = new System.Drawing.Point( 706, 73 );
        headerPanel2.Name = "headerPanel2";
        headerPanel2.RowCount = 2;
        headerPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.5485229F ) );
        headerPanel2.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.45148F ) );
        headerPanel2.Size = new System.Drawing.Size( 215, 246 );
        headerPanel2.TabIndex = 1;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 10;
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
        tableLayoutPanel1.Controls.Add( CloseButton, 9, 0 );
        tableLayoutPanel1.Controls.Add( ClearButton, 7, 0 );
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        tableLayoutPanel1.Location = new System.Drawing.Point( 0, 703 );
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
        tableLayoutPanel1.Size = new System.Drawing.Size( 969, 36 );
        tableLayoutPanel1.TabIndex = 2;
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
        // headerPanel3
        // 
        headerPanel3.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        headerPanel3.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        headerPanel3.ColumnCount = 1;
        headerPanel3.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        headerPanel3.Controls.Add( SqlEditor, 0, 1 );
        headerPanel3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        headerPanel3.ForeColor = System.Drawing.Color.DarkGray;
        headerPanel3.Location = new System.Drawing.Point( 35, 339 );
        headerPanel3.Name = "headerPanel3";
        headerPanel3.RowCount = 2;
        headerPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 6.079027F ) );
        headerPanel3.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 93.9209747F ) );
        headerPanel3.Size = new System.Drawing.Size( 889, 329 );
        headerPanel3.TabIndex = 3;
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
        SqlEditor.Location = new System.Drawing.Point( 3, 23 );
        SqlEditor.Name = "SqlEditor";
        SqlEditor.RenderRightToLeft = false;
        SqlEditor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
        SqlEditor.ScrollPosition = new System.Drawing.Point( 0, 0 );
        SqlEditor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
        SqlEditor.SelectionMarginBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
        SqlEditor.SelectionTextColor = System.Drawing.Color.White;
        SqlEditor.ShowEndOfLine = false;
        SqlEditor.Size = new System.Drawing.Size( 883, 303 );
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
        // listBox1
        // 
        listBox1.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        listBox1.BindingSource = null;
        listBox1.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
        listBox1.DataFilter = null;
        listBox1.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        listBox1.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        listBox1.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        listBox1.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        listBox1.HoveredItemColor = System.Drawing.Color.White;
        listBox1.HoverText = null;
        listBox1.IsDerivedStyle = true;
        listBox1.ItemHeight = 28;
        listBox1.Location = new System.Drawing.Point( 16, 13 );
        listBox1.Margin = new System.Windows.Forms.Padding( 1 );
        listBox1.MultiSelect = true;
        listBox1.Name = "listBox1";
        listBox1.Padding = new System.Windows.Forms.Padding( 1 );
        listBox1.SelectedIndex = -1;
        listBox1.SelectedItem = null;
        listBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        listBox1.SelectedItemColor = System.Drawing.Color.White;
        listBox1.SelectedText = null;
        listBox1.SelectedValue = null;
        listBox1.ShowBorder = false;
        listBox1.ShowScrollBar = false;
        listBox1.Size = new System.Drawing.Size( 609, 188 );
        listBox1.Style = MetroSet_UI.Enums.Style.Custom;
        listBox1.StyleManager = null;
        listBox1.TabIndex = 0;
        listBox1.ThemeAuthor = "Terry D. Eppler";
        listBox1.ThemeName = "Budget Execution";
        listBox1.ToolTip = null;
        // 
        // layout1
        // 
        layout1.BackColor = System.Drawing.Color.Transparent;
        layout1.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        layout1.BindingSource = null;
        layout1.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        layout1.BorderThickness = 1;
        layout1.Children = null;
        layout1.Controls.Add( listBox1 );
        layout1.DataFilter = null;
        layout1.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        layout1.ForeColor = System.Drawing.Color.Transparent;
        layout1.HoverText = null;
        layout1.IsDerivedStyle = true;
        layout1.Location = new System.Drawing.Point( 3, 24 );
        layout1.Name = "layout1";
        layout1.Padding = new System.Windows.Forms.Padding( 1 );
        layout1.Size = new System.Drawing.Size( 643, 219 );
        layout1.Style = MetroSet_UI.Enums.Style.Custom;
        layout1.StyleManager = null;
        layout1.TabIndex = 0;
        layout1.ThemeAuthor = "Terry D. Eppler";
        layout1.ThemeName = "Budget Execution";
        layout1.ToolTip = null;
        // 
        // layout2
        // 
        layout2.BackColor = System.Drawing.Color.Transparent;
        layout2.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        layout2.BindingSource = null;
        layout2.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        layout2.BorderThickness = 1;
        layout2.Children = null;
        layout2.Controls.Add( tile3 );
        layout2.Controls.Add( tile2 );
        layout2.Controls.Add( tile1 );
        layout2.DataFilter = null;
        layout2.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        layout2.ForeColor = System.Drawing.Color.Transparent;
        layout2.HoverText = null;
        layout2.IsDerivedStyle = true;
        layout2.Location = new System.Drawing.Point( 3, 28 );
        layout2.Name = "layout2";
        layout2.Padding = new System.Windows.Forms.Padding( 1 );
        layout2.Size = new System.Drawing.Size( 209, 215 );
        layout2.Style = MetroSet_UI.Enums.Style.Custom;
        layout2.StyleManager = null;
        layout2.TabIndex = 0;
        layout2.ThemeAuthor = "Terry D. Eppler";
        layout2.ThemeName = "Budget Execution";
        layout2.ToolTip = null;
        // 
        // tile1
        // 
        tile1.Anchor = System.Windows.Forms.AnchorStyles.None;
        tile1.BackColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
        textItem9.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem9.TextColor = System.Drawing.Color.DarkGray;
        tile1.Banner = textItem9;
        tile1.BannerColor = System.Drawing.Color.Transparent;
        tile1.BannerHeight = 26;
        tile1.BindingSource = null;
        textItem10.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem10.TextColor = System.Drawing.Color.DarkGray;
        tile1.Body = textItem10;
        tile1.DataFilter = null;
        tile1.EnableSelectionMarker = false;
        tile1.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem11.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem11.TextColor = System.Drawing.Color.DarkGray;
        tile1.Footer = textItem11;
        tile1.ForeColor = System.Drawing.Color.LightSteelBlue;
        tile1.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        tile1.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        tile1.HoverText = null;
        tile1.Location = new System.Drawing.Point( 20, 80 );
        tile1.Margin = new System.Windows.Forms.Padding( 1 );
        tile1.MinimumSize = new System.Drawing.Size( 100, 50 );
        tile1.Name = "tile1";
        tile1.ShowBanner = true;
        tile1.ShowBannerIcon = true;
        tile1.Size = new System.Drawing.Size( 168, 50 );
        tile1.TabIndex = 0;
        textItem12.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem12.TextColor = System.Drawing.Color.DarkGray;
        tile1.Title = textItem12;
        tile1.ToolTip = null;
        tile1.TurnLiveTileOn = true;
        // 
        // tile2
        // 
        tile2.Anchor = System.Windows.Forms.AnchorStyles.None;
        tile2.BackColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
        textItem5.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem5.HubTile = tile2;
        textItem5.TextColor = System.Drawing.Color.DarkGray;
        tile2.Banner = textItem5;
        tile2.BannerColor = System.Drawing.Color.Transparent;
        tile2.BannerHeight = 26;
        tile2.BindingSource = null;
        textItem6.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem6.HubTile = tile2;
        textItem6.TextColor = System.Drawing.Color.DarkGray;
        tile2.Body = textItem6;
        tile2.DataFilter = null;
        tile2.EnableSelectionMarker = false;
        tile2.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem7.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem7.HubTile = tile2;
        textItem7.TextColor = System.Drawing.Color.DarkGray;
        tile2.Footer = textItem7;
        tile2.ForeColor = System.Drawing.Color.LightSteelBlue;
        tile2.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        tile2.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        tile2.HoverText = null;
        tile2.Location = new System.Drawing.Point( 20, 147 );
        tile2.Margin = new System.Windows.Forms.Padding( 1 );
        tile2.MinimumSize = new System.Drawing.Size( 100, 50 );
        tile2.Name = "tile2";
        tile2.ShowBanner = true;
        tile2.ShowBannerIcon = true;
        tile2.Size = new System.Drawing.Size( 168, 50 );
        tile2.TabIndex = 1;
        textItem8.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem8.HubTile = tile2;
        textItem8.TextColor = System.Drawing.Color.DarkGray;
        tile2.Title = textItem8;
        tile2.ToolTip = null;
        tile2.TurnLiveTileOn = true;
        // 
        // tile3
        // 
        tile3.Anchor = System.Windows.Forms.AnchorStyles.None;
        tile3.BackColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
        textItem1.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem1.HubTile = tile3;
        textItem1.TextColor = System.Drawing.Color.DarkGray;
        tile3.Banner = textItem1;
        tile3.BannerColor = System.Drawing.Color.Transparent;
        tile3.BannerHeight = 26;
        tile3.BindingSource = null;
        textItem2.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem2.HubTile = tile3;
        textItem2.TextColor = System.Drawing.Color.DarkGray;
        tile3.Body = textItem2;
        tile3.DataFilter = null;
        tile3.EnableSelectionMarker = false;
        tile3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem3.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem3.HubTile = tile3;
        textItem3.TextColor = System.Drawing.Color.DarkGray;
        tile3.Footer = textItem3;
        tile3.ForeColor = System.Drawing.Color.LightSteelBlue;
        tile3.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        tile3.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        tile3.HoverText = null;
        tile3.Location = new System.Drawing.Point( 20, 15 );
        tile3.Margin = new System.Windows.Forms.Padding( 1 );
        tile3.MinimumSize = new System.Drawing.Size( 100, 50 );
        tile3.Name = "tile3";
        tile3.ShowBanner = true;
        tile3.ShowBannerIcon = true;
        tile3.Size = new System.Drawing.Size( 168, 50 );
        tile3.TabIndex = 2;
        textItem4.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        textItem4.HubTile = tile3;
        textItem4.TextColor = System.Drawing.Color.DarkGray;
        tile3.Title = textItem4;
        tile3.ToolTip = null;
        tile3.TurnLiveTileOn = true;
        // 
        // SchemaDialog
        // 
        BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionBarHeight = 5;
        CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClientSize = new System.Drawing.Size( 969, 739 );
        Controls.Add( headerPanel3 );
        Controls.Add( tableLayoutPanel1 );
        Controls.Add( headerPanel2 );
        Controls.Add( headerPanel1 );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.LightGray;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
        MaximumSize = new System.Drawing.Size( 1350, 750 );
        MetroColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        MinimumSize = new System.Drawing.Size( 100, 100 );
        Name = "EmailDialog";
        ShowIcon = false;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        headerPanel1.ResumeLayout( false );
        headerPanel2.ResumeLayout( false );
        tableLayoutPanel1.ResumeLayout( false );
        headerPanel3.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) SqlEditor  ).EndInit( );
        layout1.ResumeLayout( false );
        layout2.ResumeLayout( false );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private DataGrid DataGrid;
    private HeaderPanel headerPanel1;
    private HeaderPanel headerPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private Button button2;
    private HeaderPanel headerPanel3;
    private Layout layout1;
    private ListBox listBox1;
    private Layout layout2;
    private Tile tile3;
    private Tile tile2;
    private Tile tile1;
    public Editor SqlEditor;
    public Button CloseButton;
    public Button ClearButton;
}