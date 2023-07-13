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
        CloseButton = new Button( );
        StatutoryAuthorityTextBox = new RichTextBox( );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        ProgramDescriptionTextBox = new RichTextBox( );
        ProgramAreaNameTextBox = new RichTextBox( );
        ProgramProjectNameTextBox = new RichTextBox( );
        SearchButton = new Button( );
        DescriptionTable = new HeaderPanel( );
        StatuteTable = new HeaderPanel( );
        ProgramAreaTable = new HeaderPanel( );
        ProgramProjectTable = new HeaderPanel( );
        ContextMenu = new ContextMenu( );
        ToolTip = new SmallTip( );
        HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
        pictureBox1 = new System.Windows.Forms.PictureBox( );
        Header = new Label( );
        ListBox = new ListBox( );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        DescriptionTable.SuspendLayout( );
        StatuteTable.SuspendLayout( );
        ProgramAreaTable.SuspendLayout( );
        ProgramProjectTable.SuspendLayout( );
        HeaderTable.SuspendLayout( );
        ( (System.ComponentModel.ISupportInitialize) pictureBox1  ).BeginInit( );
        SuspendLayout( );
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
        CloseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
        CloseButton.IsDerivedStyle = true;
        CloseButton.Location = new System.Drawing.Point( 799, 565 );
        CloseButton.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        CloseButton.Name = "CloseButton";
        CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
        CloseButton.NormalColor = System.Drawing.Color.Transparent;
        CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
        CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CloseButton.PressTextColor = System.Drawing.Color.White;
        CloseButton.Size = new System.Drawing.Size( 78, 26 );
        CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
        CloseButton.StyleManager = null;
        CloseButton.TabIndex = 0;
        CloseButton.Text = "Close";
        CloseButton.ThemeAuthor = "Terry D. Eppler";
        CloseButton.ThemeName = "Budget Execution";
        CloseButton.ToolTip = null;
        // 
        // StatutoryAuthorityTextBox
        // 
        StatutoryAuthorityTextBox.AutoWordSelection = false;
        StatutoryAuthorityTextBox.BindingSource = BindingSource;
        StatutoryAuthorityTextBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        StatutoryAuthorityTextBox.DataFilter = null;
        StatutoryAuthorityTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(   204  ,   204  ,   204   );
        StatutoryAuthorityTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
        StatutoryAuthorityTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(   136  ,   136  ,   136   );
        StatutoryAuthorityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        StatutoryAuthorityTextBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        StatutoryAuthorityTextBox.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        StatutoryAuthorityTextBox.HoverText = null;
        StatutoryAuthorityTextBox.IsDerivedStyle = true;
        StatutoryAuthorityTextBox.Lines = null;
        StatutoryAuthorityTextBox.Location = new System.Drawing.Point( 4, 19 );
        StatutoryAuthorityTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        StatutoryAuthorityTextBox.MaxLength = 32767;
        StatutoryAuthorityTextBox.Name = "StatutoryAuthorityTextBox";
        StatutoryAuthorityTextBox.Padding = new System.Windows.Forms.Padding( 4, 10, 4, 3 );
        StatutoryAuthorityTextBox.ReadOnly = false;
        StatutoryAuthorityTextBox.Size = new System.Drawing.Size( 416, 161 );
        StatutoryAuthorityTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        StatutoryAuthorityTextBox.StyleManager = null;
        StatutoryAuthorityTextBox.TabIndex = 1;
        StatutoryAuthorityTextBox.Tag = "Laws";
        StatutoryAuthorityTextBox.ThemeAuthor = "Terry D. Eppler";
        StatutoryAuthorityTextBox.ThemeName = "Budget Execution";
        StatutoryAuthorityTextBox.ToolTip = null;
        StatutoryAuthorityTextBox.WordWrap = true;
        // 
        // ProgramDescriptionTextBox
        // 
        ProgramDescriptionTextBox.AutoWordSelection = false;
        ProgramDescriptionTextBox.BindingSource = BindingSource;
        ProgramDescriptionTextBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        ProgramDescriptionTextBox.DataFilter = null;
        ProgramDescriptionTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(   204  ,   204  ,   204   );
        ProgramDescriptionTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
        ProgramDescriptionTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(   136  ,   136  ,   136   );
        ProgramDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ProgramDescriptionTextBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProgramDescriptionTextBox.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ProgramDescriptionTextBox.HoverText = null;
        ProgramDescriptionTextBox.IsDerivedStyle = true;
        ProgramDescriptionTextBox.Lines = null;
        ProgramDescriptionTextBox.Location = new System.Drawing.Point( 4, 19 );
        ProgramDescriptionTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramDescriptionTextBox.MaxLength = 32767;
        ProgramDescriptionTextBox.Name = "ProgramDescriptionTextBox";
        ProgramDescriptionTextBox.Padding = new System.Windows.Forms.Padding( 4, 10, 4, 3 );
        ProgramDescriptionTextBox.ReadOnly = false;
        ProgramDescriptionTextBox.Size = new System.Drawing.Size( 839, 227 );
        ProgramDescriptionTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        ProgramDescriptionTextBox.StyleManager = null;
        ProgramDescriptionTextBox.TabIndex = 1;
        ProgramDescriptionTextBox.Tag = "Description";
        ProgramDescriptionTextBox.ThemeAuthor = "Terry D. Eppler";
        ProgramDescriptionTextBox.ThemeName = "Budget Execution";
        ProgramDescriptionTextBox.ToolTip = null;
        ProgramDescriptionTextBox.WordWrap = true;
        // 
        // ProgramAreaNameTextBox
        // 
        ProgramAreaNameTextBox.AutoWordSelection = false;
        ProgramAreaNameTextBox.BindingSource = BindingSource;
        ProgramAreaNameTextBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        ProgramAreaNameTextBox.DataFilter = null;
        ProgramAreaNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(   204  ,   204  ,   204   );
        ProgramAreaNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
        ProgramAreaNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(   136  ,   136  ,   136   );
        ProgramAreaNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ProgramAreaNameTextBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProgramAreaNameTextBox.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ProgramAreaNameTextBox.HoverText = null;
        ProgramAreaNameTextBox.IsDerivedStyle = true;
        ProgramAreaNameTextBox.Lines = null;
        ProgramAreaNameTextBox.Location = new System.Drawing.Point( 4, 19 );
        ProgramAreaNameTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramAreaNameTextBox.MaxLength = 32767;
        ProgramAreaNameTextBox.Name = "ProgramAreaNameTextBox";
        ProgramAreaNameTextBox.Padding = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramAreaNameTextBox.ReadOnly = false;
        ProgramAreaNameTextBox.Size = new System.Drawing.Size( 398, 46 );
        ProgramAreaNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        ProgramAreaNameTextBox.StyleManager = null;
        ProgramAreaNameTextBox.TabIndex = 1;
        ProgramAreaNameTextBox.Text = "ProgramAreaName";
        ProgramAreaNameTextBox.ThemeAuthor = "Terry D. Eppler";
        ProgramAreaNameTextBox.ThemeName = "Budget Execution";
        ProgramAreaNameTextBox.ToolTip = null;
        ProgramAreaNameTextBox.WordWrap = true;
        // 
        // ProgramProjectNameTextBox
        // 
        ProgramProjectNameTextBox.AutoWordSelection = false;
        ProgramProjectNameTextBox.BindingSource = BindingSource;
        ProgramProjectNameTextBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        ProgramProjectNameTextBox.DataFilter = null;
        ProgramProjectNameTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(   204  ,   204  ,   204   );
        ProgramProjectNameTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
        ProgramProjectNameTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(   136  ,   136  ,   136   );
        ProgramProjectNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        ProgramProjectNameTextBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProgramProjectNameTextBox.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ProgramProjectNameTextBox.HoverText = null;
        ProgramProjectNameTextBox.IsDerivedStyle = true;
        ProgramProjectNameTextBox.Lines = null;
        ProgramProjectNameTextBox.Location = new System.Drawing.Point( 4, 19 );
        ProgramProjectNameTextBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramProjectNameTextBox.MaxLength = 32767;
        ProgramProjectNameTextBox.Name = "ProgramProjectNameTextBox";
        ProgramProjectNameTextBox.Padding = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        ProgramProjectNameTextBox.ReadOnly = false;
        ProgramProjectNameTextBox.Size = new System.Drawing.Size( 398, 52 );
        ProgramProjectNameTextBox.Style = MetroSet_UI.Enums.Style.Custom;
        ProgramProjectNameTextBox.StyleManager = null;
        ProgramProjectNameTextBox.TabIndex = 1;
        ProgramProjectNameTextBox.Tag = "Code";
        ProgramProjectNameTextBox.ThemeAuthor = "Terry D. Eppler";
        ProgramProjectNameTextBox.ThemeName = "Budget Execution";
        ProgramProjectNameTextBox.ToolTip = null;
        ProgramProjectNameTextBox.WordWrap = true;
        // 
        // SearchButton
        // 
        SearchButton.BindingSource = null;
        SearchButton.DataFilter = null;
        SearchButton.DisabledBackColor = System.Drawing.Color.Transparent;
        SearchButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        SearchButton.DisabledForeColor = System.Drawing.Color.Transparent;
        SearchButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SearchButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SearchButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
        SearchButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        SearchButton.HoverText = null;
        SearchButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
        SearchButton.IsDerivedStyle = true;
        SearchButton.Location = new System.Drawing.Point( 433, 565 );
        SearchButton.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        SearchButton.Name = "SearchButton";
        SearchButton.NormalBorderColor = System.Drawing.Color.Transparent;
        SearchButton.NormalColor = System.Drawing.Color.Transparent;
        SearchButton.NormalTextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SearchButton.Padding = new System.Windows.Forms.Padding( 1 );
        SearchButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SearchButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        SearchButton.PressTextColor = System.Drawing.Color.White;
        SearchButton.Size = new System.Drawing.Size( 78, 26 );
        SearchButton.Style = MetroSet_UI.Enums.Style.Custom;
        SearchButton.StyleManager = null;
        SearchButton.TabIndex = 13;
        SearchButton.Text = "Search";
        SearchButton.ThemeAuthor = "Terry D. Eppler";
        SearchButton.ThemeName = "Budget Execution";
        SearchButton.ToolTip = null;
        // 
        // DescriptionTable
        // 
        DescriptionTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        DescriptionTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        DescriptionTable.CaptionText = "Program Description";
        DescriptionTable.ColumnCount = 1;
        DescriptionTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        DescriptionTable.Controls.Add( ProgramDescriptionTextBox, 0, 0 );
        DescriptionTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        DescriptionTable.ForeColor = System.Drawing.Color.DarkGray;
        DescriptionTable.Location = new System.Drawing.Point( 30, 278 );
        DescriptionTable.Name = "DescriptionTable";
        DescriptionTable.RowCount = 1;
        DescriptionTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        DescriptionTable.Size = new System.Drawing.Size( 847, 249 );
        DescriptionTable.TabIndex = 14;
        // 
        // StatuteTable
        // 
        StatuteTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        StatuteTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        StatuteTable.CaptionText = "Statutory Authority";
        StatuteTable.ColumnCount = 1;
        StatuteTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        StatuteTable.Controls.Add( StatutoryAuthorityTextBox, 0, 0 );
        StatuteTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        StatuteTable.ForeColor = System.Drawing.Color.DarkGray;
        StatuteTable.Location = new System.Drawing.Point( 30, 78 );
        StatuteTable.Name = "StatuteTable";
        StatuteTable.RowCount = 1;
        StatuteTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        StatuteTable.Size = new System.Drawing.Size( 424, 183 );
        StatuteTable.TabIndex = 15;
        // 
        // ProgramAreaTable
        // 
        ProgramAreaTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ProgramAreaTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ProgramAreaTable.CaptionText = "Program Area";
        ProgramAreaTable.ColumnCount = 1;
        ProgramAreaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramAreaTable.Controls.Add( ProgramAreaNameTextBox, 0, 0 );
        ProgramAreaTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProgramAreaTable.ForeColor = System.Drawing.Color.DarkGray;
        ProgramAreaTable.Location = new System.Drawing.Point( 471, 78 );
        ProgramAreaTable.Name = "ProgramAreaTable";
        ProgramAreaTable.RowCount = 1;
        ProgramAreaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramAreaTable.Size = new System.Drawing.Size( 406, 68 );
        ProgramAreaTable.TabIndex = 16;
        // 
        // ProgramProjectTable
        // 
        ProgramProjectTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ProgramProjectTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
        ProgramProjectTable.CaptionText = "Program Project";
        ProgramProjectTable.ColumnCount = 1;
        ProgramProjectTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramProjectTable.Controls.Add( ProgramProjectNameTextBox, 0, 0 );
        ProgramProjectTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ProgramProjectTable.ForeColor = System.Drawing.Color.DarkGray;
        ProgramProjectTable.Location = new System.Drawing.Point( 475, 184 );
        ProgramProjectTable.Name = "ProgramProjectTable";
        ProgramProjectTable.RowCount = 1;
        ProgramProjectTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        ProgramProjectTable.Size = new System.Drawing.Size( 406, 74 );
        ProgramProjectTable.TabIndex = 17;
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
        // HeaderTable
        // 
        HeaderTable.ColumnCount = 2;
        HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 4.20899868F ) );
        HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 95.791F ) );
        HeaderTable.Controls.Add( pictureBox1, 0, 0 );
        HeaderTable.Controls.Add( Header, 1, 0 );
        HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
        HeaderTable.Location = new System.Drawing.Point( 0, 0 );
        HeaderTable.Name = "HeaderTable";
        HeaderTable.RowCount = 1;
        HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        HeaderTable.Size = new System.Drawing.Size( 896, 28 );
        HeaderTable.TabIndex = 18;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.AppropriationTile;
        pictureBox1.Location = new System.Drawing.Point( 3, 3 );
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size( 31, 22 );
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // Header
        // 
        Header.BindingSource = null;
        Header.DataFilter = null;
        Header.Dock = System.Windows.Forms.DockStyle.Fill;
        Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Header.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        Header.HoverText = null;
        Header.IsDerivedStyle = true;
        Header.Location = new System.Drawing.Point( 40, 3 );
        Header.Margin = new System.Windows.Forms.Padding( 3 );
        Header.Name = "Header";
        Header.Padding = new System.Windows.Forms.Padding( 1 );
        Header.Size = new System.Drawing.Size( 853, 22 );
        Header.Style = MetroSet_UI.Enums.Style.Custom;
        Header.StyleManager = null;
        Header.TabIndex = 1;
        Header.Text = "label1";
        Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        Header.ThemeAuthor = "Terry D. Eppler";
        Header.ThemeName = "Budget Execution";
        Header.ToolTip = null;
        // 
        // ListBox
        // 
        ListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
        ListBox.BindingSource = null;
        ListBox.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
        ListBox.DataFilter = null;
        ListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        ListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
        ListBox.HoveredItemColor = System.Drawing.Color.White;
        ListBox.HoverText = null;
        ListBox.IsDerivedStyle = true;
        ListBox.ItemHeight = 28;
        ListBox.Location = new System.Drawing.Point( 699, 29 );
        ListBox.Margin = new System.Windows.Forms.Padding( 1 );
        ListBox.MultiSelect = true;
        ListBox.Name = "ListBox";
        ListBox.Padding = new System.Windows.Forms.Padding( 1 );
        ListBox.SelectedIndex = -1;
        ListBox.SelectedItem = null;
        ListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ListBox.SelectedItemColor = System.Drawing.Color.White;
        ListBox.SelectedText = null;
        ListBox.SelectedValue = null;
        ListBox.ShowBorder = false;
        ListBox.ShowScrollBar = false;
        ListBox.Size = new System.Drawing.Size( 174, 45 );
        ListBox.Style = MetroSet_UI.Enums.Style.Custom;
        ListBox.StyleManager = null;
        ListBox.TabIndex = 20;
        ListBox.ThemeAuthor = "Terry D. Eppler";
        ListBox.ThemeName = "Budget Execution";
        ListBox.ToolTip = null;
        // 
        // ProgramProjectDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        BorderThickness = 2;
        CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionBarHeight = 5;
        CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        captionImage1.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        captionImage1.Image = Properties.Resources.EPA;
        captionImage1.Location = new System.Drawing.Point( 5, 5 );
        captionImage1.Name = "CaptionImage1";
        captionImage1.Size = new System.Drawing.Size( 42, 16 );
        CaptionImages.Add( captionImage1 );
        ClientSize = new System.Drawing.Size( 896, 603 );
        Controls.Add( ListBox );
        Controls.Add( HeaderTable );
        Controls.Add( ProgramProjectTable );
        Controls.Add( ProgramAreaTable );
        Controls.Add( StatuteTable );
        Controls.Add( DescriptionTable );
        Controls.Add( SearchButton );
        Controls.Add( CloseButton );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.LightGray;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
        Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        MaximumSize = new System.Drawing.Size( 908, 614 );
        MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        MinimumSize = new System.Drawing.Size( 908, 614 );
        Name = "ProgramProjectDialog";
        ShowIcon = false;
        SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        DescriptionTable.ResumeLayout( false );
        StatuteTable.ResumeLayout( false );
        ProgramAreaTable.ResumeLayout( false );
        ProgramProjectTable.ResumeLayout( false );
        HeaderTable.ResumeLayout( false );
        ( (System.ComponentModel.ISupportInitialize) pictureBox1  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public Button SearchButton;
    public RichTextBox ProgramDescriptionTextBox;
    public Button CloseButton;
    private HeaderPanel DescriptionTable;
    public HeaderPanel StatuteTable;
    private HeaderPanel ProgramAreaTable;
    private HeaderPanel ProgramProjectTable;
    public ContextMenu ContextMenu;
    public SmallTip ToolTip;
    public RichTextBox StatutoryAuthorityTextBox;
    public RichTextBox ProgramAreaNameTextBox;
    public RichTextBox ProgramProjectNameTextBox;
    public System.Windows.Forms.TableLayoutPanel HeaderTable;
    public System.Windows.Forms.PictureBox pictureBox1;
    private Label Header;
    private ListBox ListBox;
}