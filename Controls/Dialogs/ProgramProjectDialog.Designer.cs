// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class ProgramProjectDialog
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
        var captionImage1 = new Syncfusion.Windows.Forms.CaptionImage( );
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( ProgramProjectDialog ) );
        StatutoryAuthorityTextBox = new RichTextBox( );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        ToolTip = new SmallTip( );
        ProgramDescriptionTextBox = new RichTextBox( );
        ProgramAreaNameTextBox = new RichTextBox( );
        ProgramProjectNameTextBox = new RichTextBox( );
        DescriptionTable = new HeaderPanel( );
        StatuteTable = new HeaderPanel( );
        ProgramAreaTable = new HeaderPanel( );
        ProgramProjectTable = new HeaderPanel( );
        HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
        PictureBox = new System.Windows.Forms.PictureBox( );
        Header = new Label( );
        ComboBox = new ComboBox( );
        MenuButton = new Button( );
        CloseButton = new Button( );
        SearchButton = new Button( );
        Timer = new System.Windows.Forms.Timer( components );
        ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
        StatusLabel = new Label( );
        ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
        DescriptionTable.SuspendLayout( );
        StatuteTable.SuspendLayout( );
        ProgramAreaTable.SuspendLayout( );
        ProgramProjectTable.SuspendLayout( );
        HeaderTable.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
        ButtonTable.SuspendLayout( );
        SuspendLayout( );
        // 
        // StatutoryAuthorityTextBox
        // 
        StatutoryAuthorityTextBox.AutoWordSelection = false;
        StatutoryAuthorityTextBox.BindingSource = BindingSource;
        StatutoryAuthorityTextBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
        StatutoryAuthorityTextBox.DataFilter = null;
        StatutoryAuthorityTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
        StatutoryAuthorityTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
        StatutoryAuthorityTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
        StatutoryAuthorityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        StatutoryAuthorityTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F );
        StatutoryAuthorityTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        StatutoryAuthorityTextBox.HoverText = null;
        StatutoryAuthorityTextBox.IsDerivedStyle = true;
        StatutoryAuthorityTextBox.Lines = null;
        StatutoryAuthorityTextBox.Location = new System.Drawing.Point( 4, 21 );
        StatutoryAuthorityTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        StatutoryAuthorityTextBox.MaxLength = 32767;
        StatutoryAuthorityTextBox.Name = "StatutoryAuthorityTextBox";
        StatutoryAuthorityTextBox.Padding = new System.Windows.Forms.Padding( 4, 10, 4, 3 );
        StatutoryAuthorityTextBox.ReadOnly = false;
        StatutoryAuthorityTextBox.Size = new System.Drawing.Size( 506, 160 );
        StatutoryAuthorityTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        StatutoryAuthorityTextBox.StyleManager = null;
        StatutoryAuthorityTextBox.TabIndex = 1;
        StatutoryAuthorityTextBox.Tag = "Laws";
        StatutoryAuthorityTextBox.ThemeAuthor = "Terry D. Eppler";
        StatutoryAuthorityTextBox.ThemeName = "Budget Execution";
        StatutoryAuthorityTextBox.ToolTip = ToolTip;
        StatutoryAuthorityTextBox.WordWrap = true;
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
        // ProgramDescriptionTextBox
        // 
        ProgramDescriptionTextBox.AutoWordSelection = false;
        ProgramDescriptionTextBox.BindingSource = BindingSource;
        ProgramDescriptionTextBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
        ProgramDescriptionTextBox.DataFilter = null;
        ProgramDescriptionTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
        ProgramDescriptionTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
        ProgramDescriptionTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
        ProgramDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ProgramDescriptionTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F );
        ProgramDescriptionTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        ProgramDescriptionTextBox.HoverText = null;
        ProgramDescriptionTextBox.IsDerivedStyle = true;
        ProgramDescriptionTextBox.Lines = null;
        ProgramDescriptionTextBox.Location = new System.Drawing.Point( 4, 21 );
        ProgramDescriptionTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramDescriptionTextBox.MaxLength = 32767;
        ProgramDescriptionTextBox.Name = "ProgramDescriptionTextBox";
        ProgramDescriptionTextBox.Padding = new System.Windows.Forms.Padding( 4, 10, 4, 3 );
        ProgramDescriptionTextBox.ReadOnly = false;
        ProgramDescriptionTextBox.Size = new System.Drawing.Size( 984, 220 );
        ProgramDescriptionTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        ProgramDescriptionTextBox.StyleManager = null;
        ProgramDescriptionTextBox.TabIndex = 1;
        ProgramDescriptionTextBox.Tag = "Description";
        ProgramDescriptionTextBox.ThemeAuthor = "Terry D. Eppler";
        ProgramDescriptionTextBox.ThemeName = "Budget Execution";
        ProgramDescriptionTextBox.ToolTip = ToolTip;
        ProgramDescriptionTextBox.WordWrap = true;
        // 
        // ProgramAreaNameTextBox
        // 
        ProgramAreaNameTextBox.AutoWordSelection = false;
        ProgramAreaNameTextBox.BindingSource = BindingSource;
        ProgramAreaNameTextBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
        ProgramAreaNameTextBox.DataFilter = null;
        ProgramAreaNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
        ProgramAreaNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
        ProgramAreaNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
        ProgramAreaNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ProgramAreaNameTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F );
        ProgramAreaNameTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        ProgramAreaNameTextBox.HoverText = null;
        ProgramAreaNameTextBox.IsDerivedStyle = true;
        ProgramAreaNameTextBox.Lines = null;
        ProgramAreaNameTextBox.Location = new System.Drawing.Point( 4, 21 );
        ProgramAreaNameTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramAreaNameTextBox.MaxLength = 32767;
        ProgramAreaNameTextBox.Name = "ProgramAreaNameTextBox";
        ProgramAreaNameTextBox.Padding = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramAreaNameTextBox.ReadOnly = false;
        ProgramAreaNameTextBox.Size = new System.Drawing.Size( 444, 56 );
        ProgramAreaNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        ProgramAreaNameTextBox.StyleManager = null;
        ProgramAreaNameTextBox.TabIndex = 1;
        ProgramAreaNameTextBox.ThemeAuthor = "Terry D. Eppler";
        ProgramAreaNameTextBox.ThemeName = "Budget Execution";
        ProgramAreaNameTextBox.ToolTip = ToolTip;
        ProgramAreaNameTextBox.WordWrap = true;
        // 
        // ProgramProjectNameTextBox
        // 
        ProgramProjectNameTextBox.AutoWordSelection = false;
        ProgramProjectNameTextBox.BindingSource = BindingSource;
        ProgramProjectNameTextBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
        ProgramProjectNameTextBox.DataFilter = null;
        ProgramProjectNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
        ProgramProjectNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 155, 155, 155 );
        ProgramProjectNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 136, 136, 136 );
        ProgramProjectNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ProgramProjectNameTextBox.Font = new System.Drawing.Font( "Roboto", 9.75F );
        ProgramProjectNameTextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        ProgramProjectNameTextBox.HoverText = null;
        ProgramProjectNameTextBox.IsDerivedStyle = true;
        ProgramProjectNameTextBox.Lines = null;
        ProgramProjectNameTextBox.Location = new System.Drawing.Point( 4, 21 );
        ProgramProjectNameTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramProjectNameTextBox.MaxLength = 32767;
        ProgramProjectNameTextBox.Name = "ProgramProjectNameTextBox";
        ProgramProjectNameTextBox.Padding = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramProjectNameTextBox.ReadOnly = false;
        ProgramProjectNameTextBox.Size = new System.Drawing.Size( 444, 65 );
        ProgramProjectNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        ProgramProjectNameTextBox.StyleManager = null;
        ProgramProjectNameTextBox.TabIndex = 1;
        ProgramProjectNameTextBox.Tag = "Code";
        ProgramProjectNameTextBox.ThemeAuthor = "Terry D. Eppler";
        ProgramProjectNameTextBox.ThemeName = "Budget Execution";
        ProgramProjectNameTextBox.ToolTip = ToolTip;
        ProgramProjectNameTextBox.WordWrap = true;
        // 
        // DescriptionTable
        // 
        DescriptionTable.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
        DescriptionTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        DescriptionTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        DescriptionTable.CaptionText = "Program Description";
        DescriptionTable.ColumnCount = 1;
        DescriptionTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        DescriptionTable.Controls.Add( ProgramDescriptionTextBox, 0, 0 );
        DescriptionTable.Font = new System.Drawing.Font( "Roboto", 9.75F );
        DescriptionTable.ForeColor = System.Drawing.Color.DarkGray;
        DescriptionTable.Location = new System.Drawing.Point( 34, 291 );
        DescriptionTable.Name = "DescriptionTable";
        DescriptionTable.RowCount = 1;
        DescriptionTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        DescriptionTable.Size = new System.Drawing.Size( 992, 244 );
        DescriptionTable.TabIndex = 14;
        // 
        // StatuteTable
        // 
        StatuteTable.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
        StatuteTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        StatuteTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        StatuteTable.CaptionText = "Statutory Authority";
        StatuteTable.ColumnCount = 1;
        StatuteTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        StatuteTable.Controls.Add( StatutoryAuthorityTextBox, 0, 0 );
        StatuteTable.Font = new System.Drawing.Font( "Roboto", 9.75F );
        StatuteTable.ForeColor = System.Drawing.Color.DarkGray;
        StatuteTable.Location = new System.Drawing.Point( 34, 78 );
        StatuteTable.Name = "StatuteTable";
        StatuteTable.RowCount = 1;
        StatuteTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        StatuteTable.Size = new System.Drawing.Size( 514, 184 );
        StatuteTable.TabIndex = 15;
        // 
        // ProgramAreaTable
        // 
        ProgramAreaTable.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
        ProgramAreaTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        ProgramAreaTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ProgramAreaTable.CaptionText = "Program Area";
        ProgramAreaTable.ColumnCount = 1;
        ProgramAreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramAreaTable.Controls.Add( ProgramAreaNameTextBox, 0, 0 );
        ProgramAreaTable.Font = new System.Drawing.Font( "Roboto", 9.75F );
        ProgramAreaTable.ForeColor = System.Drawing.Color.DarkGray;
        ProgramAreaTable.Location = new System.Drawing.Point( 574, 78 );
        ProgramAreaTable.Name = "ProgramAreaTable";
        ProgramAreaTable.RowCount = 1;
        ProgramAreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramAreaTable.Size = new System.Drawing.Size( 452, 80 );
        ProgramAreaTable.TabIndex = 16;
        // 
        // ProgramProjectTable
        // 
        ProgramProjectTable.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
        ProgramProjectTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        ProgramProjectTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ProgramProjectTable.CaptionText = "Program Project";
        ProgramProjectTable.ColumnCount = 1;
        ProgramProjectTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramProjectTable.Controls.Add( ProgramProjectNameTextBox, 0, 0 );
        ProgramProjectTable.Font = new System.Drawing.Font( "Roboto", 9.75F );
        ProgramProjectTable.ForeColor = System.Drawing.Color.DarkGray;
        ProgramProjectTable.Location = new System.Drawing.Point( 574, 173 );
        ProgramProjectTable.Name = "ProgramProjectTable";
        ProgramProjectTable.RowCount = 1;
        ProgramProjectTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramProjectTable.Size = new System.Drawing.Size( 452, 89 );
        ProgramProjectTable.TabIndex = 17;
        // 
        // HeaderTable
        // 
        HeaderTable.ColumnCount = 2;
        HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.8463F ) );
        HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.1537F ) );
        HeaderTable.Controls.Add( PictureBox, 0, 0 );
        HeaderTable.Controls.Add( Header, 1, 0 );
        HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
        HeaderTable.Location = new System.Drawing.Point( 0, 0 );
        HeaderTable.Name = "HeaderTable";
        HeaderTable.RowCount = 1;
        HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        HeaderTable.Size = new System.Drawing.Size( 1054, 25 );
        HeaderTable.TabIndex = 18;
        // 
        // PictureBox
        // 
        PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        PictureBox.Image = Resources.Images.TileImages.AppropriationTile;
        PictureBox.Location = new System.Drawing.Point( 1, 1 );
        PictureBox.Margin = new System.Windows.Forms.Padding( 1 );
        PictureBox.Name = "PictureBox";
        PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
        PictureBox.Size = new System.Drawing.Size( 28, 23 );
        PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        PictureBox.TabIndex = 0;
        PictureBox.TabStop = false;
        // 
        // Header
        // 
        Header.BindingSource = null;
        Header.Dock = System.Windows.Forms.DockStyle.Fill;
        Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Header.Font = new System.Drawing.Font( "Roboto", 9.75F );
        Header.HoverText = null;
        Header.IsDerivedStyle = true;
        Header.Location = new System.Drawing.Point( 33, 3 );
        Header.Margin = new System.Windows.Forms.Padding( 3 );
        Header.Name = "Header";
        Header.Padding = new System.Windows.Forms.Padding( 1 );
        Header.Size = new System.Drawing.Size( 1018, 19 );
        Header.Style = MetroSet_UI.Enums.Style.Custom;
        Header.StyleManager = null;
        Header.TabIndex = 1;
        Header.Text = "label1";
        Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        Header.ThemeAuthor = "Terry D. Eppler";
        Header.ThemeName = "Budget Execution";
        Header.ToolTip = null;
        // 
        // ComboBox
        // 
        ComboBox.AllowDrop = true;
        ComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        ComboBox.BackColor = System.Drawing.Color.Transparent;
        ComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
        ComboBox.BindingSource = null;
        ComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
        ComboBox.CausesValidation = false;
        ComboBox.DataFilter = null;
        ComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
        ComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
        ComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
        ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        ComboBox.DropDownHeight = 100;
        ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        ComboBox.DropDownWidth = 80;
        ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ComboBox.Font = new System.Drawing.Font( "Roboto", 8F );
        ComboBox.FormattingEnabled = true;
        ComboBox.HoverText = null;
        ComboBox.IntegralHeight = false;
        ComboBox.IsDerivedStyle = true;
        ComboBox.ItemHeight = 24;
        ComboBox.Location = new System.Drawing.Point( 161, 31 );
        ComboBox.Name = "ComboBox";
        ComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        ComboBox.SelectedItemForeColor = System.Drawing.Color.White;
        ComboBox.Size = new System.Drawing.Size( 763, 30 );
        ComboBox.Style = MetroSet_UI.Enums.Style.Custom;
        ComboBox.StyleManager = null;
        ComboBox.TabIndex = 19;
        ComboBox.ThemeAuthor = "Terry D. Eppler";
        ComboBox.ThemeName = "Budget Execution";
        ComboBox.ToolTip = ToolTip;
        // 
        // MenuButton
        // 
        MenuButton.BindingSource = null;
        MenuButton.DataFilter = null;
        MenuButton.DisabledBackColor = System.Drawing.Color.Transparent;
        MenuButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        MenuButton.DisabledForeColor = System.Drawing.Color.Transparent;
        MenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
        MenuButton.Font = new System.Drawing.Font( "Roboto", 8F );
        MenuButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        MenuButton.HoverBorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        MenuButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
        MenuButton.HoverText = "Back To Menu";
        MenuButton.HoverTextColor = System.Drawing.Color.White;
        MenuButton.IsDerivedStyle = true;
        MenuButton.Location = new System.Drawing.Point( 570, 3 );
        MenuButton.Name = "MenuButton";
        MenuButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        MenuButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        MenuButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
        MenuButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        MenuButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        MenuButton.PressTextColor = System.Drawing.Color.White;
        MenuButton.Size = new System.Drawing.Size( 105, 29 );
        MenuButton.Style = MetroSet_UI.Enums.Style.Custom;
        MenuButton.StyleManager = null;
        MenuButton.TabIndex = 20;
        MenuButton.Text = "Main";
        MenuButton.ThemeAuthor = "Terry D. Eppler";
        MenuButton.ThemeName = "Budget Execution";
        MenuButton.ToolTip = ToolTip;
        // 
        // CloseButton
        // 
        CloseButton.BindingSource = null;
        CloseButton.DataFilter = null;
        CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
        CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
        CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
        CloseButton.Font = new System.Drawing.Font( "Roboto", 8F );
        CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
        CloseButton.HoverText = "Close Projects";
        CloseButton.HoverTextColor = System.Drawing.Color.White;
        CloseButton.IsDerivedStyle = true;
        CloseButton.Location = new System.Drawing.Point( 934, 3 );
        CloseButton.Name = "CloseButton";
        CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
        CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        CloseButton.PressTextColor = System.Drawing.Color.White;
        CloseButton.Size = new System.Drawing.Size( 96, 29 );
        CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
        CloseButton.StyleManager = null;
        CloseButton.TabIndex = 21;
        CloseButton.Text = "Close";
        CloseButton.ThemeAuthor = "Terry D. Eppler";
        CloseButton.ThemeName = "Budget Execution";
        CloseButton.ToolTip = ToolTip;
        // 
        // SearchButton
        // 
        SearchButton.BindingSource = null;
        SearchButton.DataFilter = null;
        SearchButton.DisabledBackColor = System.Drawing.Color.Transparent;
        SearchButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        SearchButton.DisabledForeColor = System.Drawing.Color.Transparent;
        SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
        SearchButton.Font = new System.Drawing.Font( "Roboto", 8F );
        SearchButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        SearchButton.HoverBorderColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        SearchButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
        SearchButton.HoverText = "Domain Search";
        SearchButton.HoverTextColor = System.Drawing.Color.White;
        SearchButton.IsDerivedStyle = true;
        SearchButton.Location = new System.Drawing.Point( 257, 3 );
        SearchButton.Name = "SearchButton";
        SearchButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        SearchButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        SearchButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        SearchButton.Padding = new System.Windows.Forms.Padding( 1 );
        SearchButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        SearchButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        SearchButton.PressTextColor = System.Drawing.Color.White;
        SearchButton.Size = new System.Drawing.Size( 101, 29 );
        SearchButton.Style = MetroSet_UI.Enums.Style.Custom;
        SearchButton.StyleManager = null;
        SearchButton.TabIndex = 22;
        SearchButton.Text = "Search";
        SearchButton.ThemeAuthor = "Terry D. Eppler";
        SearchButton.ThemeName = "Budget Execution";
        SearchButton.ToolTip = ToolTip;
        // 
        // Timer
        // 
        Timer.Enabled = true;
        Timer.Interval = 80;
        // 
        // ButtonTable
        // 
        ButtonTable.ColumnCount = 8;
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 61.4886742F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 38.5113258F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 107F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 206F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 111F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 253F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 102F ) );
        ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
        ButtonTable.Controls.Add( StatusLabel, 0, 0 );
        ButtonTable.Controls.Add( CloseButton, 6, 0 );
        ButtonTable.Controls.Add( MenuButton, 4, 0 );
        ButtonTable.Controls.Add( SearchButton, 2, 0 );
        ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
        ButtonTable.Location = new System.Drawing.Point( 0, 567 );
        ButtonTable.Name = "ButtonTable";
        ButtonTable.RowCount = 1;
        ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ButtonTable.Size = new System.Drawing.Size( 1054, 35 );
        ButtonTable.TabIndex = 24;
        // 
        // StatusLabel
        // 
        StatusLabel.BindingSource = BindingSource;
        StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
        StatusLabel.HoverText = null;
        StatusLabel.IsDerivedStyle = true;
        StatusLabel.Location = new System.Drawing.Point( 3, 3 );
        StatusLabel.Margin = new System.Windows.Forms.Padding( 3 );
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
        StatusLabel.Size = new System.Drawing.Size( 150, 29 );
        StatusLabel.Style = MetroSet_UI.Enums.Style.Custom;
        StatusLabel.StyleManager = null;
        StatusLabel.TabIndex = 0;
        StatusLabel.Text = "Date and Time";
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        StatusLabel.ThemeAuthor = "Terry D. Eppler";
        StatusLabel.ThemeName = "Budget Execution";
        StatusLabel.ToolTip = ToolTip;
        // 
        // ProgramProjectDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionBarHeight = 5;
        CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold );
        CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        captionImage1.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        captionImage1.Image = Resources.Images.FormImages.EPA;
        captionImage1.Location = new System.Drawing.Point( 5, 5 );
        captionImage1.Name = "CaptionImage1";
        captionImage1.Size = new System.Drawing.Size( 42, 16 );
        CaptionImages.Add( captionImage1 );
        ClientSize = new System.Drawing.Size( 1054, 602 );
        ControlBox = false;
        Controls.Add( ButtonTable );
        Controls.Add( ComboBox );
        Controls.Add( HeaderTable );
        Controls.Add( ProgramProjectTable );
        Controls.Add( ProgramAreaTable );
        Controls.Add( StatuteTable );
        Controls.Add( DescriptionTable );
        DoubleBuffered = true;
        Font = new System.Drawing.Font( "Roboto", 9F );
        ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
        Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size( 1066, 614 );
        MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size( 1066, 614 );
        Name = "ProgramProjectDialog";
        ShowIcon = false;
        ShowMaximizeBox = false;
        ShowMinimizeBox = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
        DescriptionTable.ResumeLayout( false );
        StatuteTable.ResumeLayout( false );
        ProgramAreaTable.ResumeLayout( false );
        ProgramProjectTable.ResumeLayout( false );
        HeaderTable.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
        ButtonTable.ResumeLayout( false );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public RichTextBox ProgramDescriptionTextBox;
    private HeaderPanel DescriptionTable;
    public HeaderPanel StatuteTable;
    private HeaderPanel ProgramAreaTable;
    private HeaderPanel ProgramProjectTable;
    public SmallTip ToolTip;
    public RichTextBox StatutoryAuthorityTextBox;
    public RichTextBox ProgramAreaNameTextBox;
    public RichTextBox ProgramProjectNameTextBox;
    public System.Windows.Forms.TableLayoutPanel HeaderTable;
    public System.Windows.Forms.PictureBox PictureBox;
    private Label Header;
    public Button MenuButton;
    public Button CloseButton;
    public Button SearchButton;
    public System.Windows.Forms.Timer Timer;
    private ContextMenu ContextMenu;
    public System.Windows.Forms.TableLayoutPanel ButtonTable;
    public Label StatusLabel;
    public ComboBox ComboBox;
}