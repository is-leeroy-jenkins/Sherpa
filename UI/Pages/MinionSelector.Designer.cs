// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace Sherpa;

partial class MinionSelector
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
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( MinionSelector ) );
        Header = new Label( );
        CloseButton = new Button( );
        ToolTip = new SmallTip( );
        ImageList = new ImageList( );
        Carousel = new Carousel( );
        SelectorTable = new System.Windows.Forms.TableLayoutPanel( );
        SelectionPanel = new BackPanel( );
        Timer = new System.Windows.Forms.Timer( components );
        SelectorTable.SuspendLayout( );
        SelectionPanel.SuspendLayout( );
        SuspendLayout( );
        // 
        // Header
        // 
        Header.BindingSource = null;
        Header.Dock = System.Windows.Forms.DockStyle.Top;
        Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Header.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        Header.HoverText = null;
        Header.IsDerivedStyle = true;
        Header.Location = new System.Drawing.Point( 3, 3 );
        Header.Margin = new System.Windows.Forms.Padding( 3 );
        Header.Name = "Header";
        Header.Padding = new System.Windows.Forms.Padding( 1 );
        Header.Size = new System.Drawing.Size( 886, 25 );
        Header.Style = MetroSet_UI.Enums.Style.Custom;
        Header.StyleManager = null;
        Header.TabIndex = 3;
        Header.Text = "Header";
        Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        Header.ThemeAuthor = "Terry D. Eppler";
        Header.ThemeName = "Sherpa";
        Header.ToolTip = null;
        // 
        // CloseButton
        // 
        CloseButton.DataFilter = null;
        CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
        CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
        CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
        CloseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
        CloseButton.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
        CloseButton.HoverText = "Return to Main Menu";
        CloseButton.HoverTextColor = System.Drawing.Color.White;
        CloseButton.IsDerivedStyle = true;
        CloseButton.Location = new System.Drawing.Point( 1020, 494 );
        CloseButton.Name = "CloseButton";
        CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
        CloseButton.NormalColor = System.Drawing.Color.Transparent;
        CloseButton.NormalTextColor = System.Drawing.Color.Transparent;
        CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
        CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        CloseButton.PressTextColor = System.Drawing.Color.White;
        CloseButton.Size = new System.Drawing.Size( 140, 40 );
        CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
        CloseButton.StyleManager = null;
        CloseButton.TabIndex = 7;
        CloseButton.Text = "Close";
        CloseButton.ThemeAuthor = "Terry D. Eppler";
        CloseButton.ThemeName = "Sherpa";
        CloseButton.ToolTip = ToolTip;
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
        // ImageList
        // 
        ImageList.FileNames = null;
        ImageList.FilePaths = null;
        ImageList.HoverText = null;
        ImageList.Image = null;
        // 
        // Carousel
        // 
        Carousel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        Carousel.CanOverrideStyle = true;
        Carousel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        Carousel.ForeColor = System.Drawing.Color.White;
        Carousel.HighlightColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        Carousel.Images = null;
        Carousel.ImageshadeColor = System.Drawing.Color.Black;
        Carousel.ImageSize = new System.Drawing.Size( 250, 250 );
        Carousel.ImageSlides = true;
        Carousel.Location = new System.Drawing.Point( 95, 66 );
        Carousel.Name = "Carousel";
        Carousel.PadX = 0;
        Carousel.PadY = 0;
        Carousel.Perspective = 4F;
        Carousel.RotateAlways = false;
        Carousel.ShowImagePreview = true;
        Carousel.ShowImageShadow = true;
        Carousel.Size = new System.Drawing.Size( 736, 258 );
        Carousel.TabIndex = 8;
        Carousel.ThemeName = "Metro";
        Carousel.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
        Carousel.ThemeStyle.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        Carousel.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        Carousel.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        Carousel.ThemeStyle.HoverImageBorderThickness = 3;
        Carousel.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb( 18, 18, 18 );
        Carousel.TouchTransitionSpeed = 1F;
        Carousel.UseOriginalImageinPreview = true;
        Carousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
        // 
        // SelectorTable
        // 
        SelectorTable.ColumnCount = 1;
        SelectorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        SelectorTable.Controls.Add( SelectionPanel, 0, 1 );
        SelectorTable.Controls.Add( Header, 0, 0 );
        SelectorTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
        SelectorTable.Location = new System.Drawing.Point( 147, 12 );
        SelectorTable.Name = "SelectorTable";
        SelectorTable.RowCount = 2;
        SelectorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 13.27434F ) );
        SelectorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 86.72566F ) );
        SelectorTable.Size = new System.Drawing.Size( 892, 463 );
        SelectorTable.TabIndex = 9;
        // 
        // SelectionPanel
        // 
        SelectionPanel.BackColor = System.Drawing.Color.Transparent;
        SelectionPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        SelectionPanel.BindingSource = null;
        SelectionPanel.BorderColor = System.Drawing.Color.Transparent;
        SelectionPanel.BorderThickness = 1;
        SelectionPanel.Children = null;
        SelectionPanel.Controls.Add( Carousel );
        SelectionPanel.DataFilter = null;
        SelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        SelectionPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        SelectionPanel.ForeColor = System.Drawing.Color.Transparent;
        SelectionPanel.HoverText = null;
        SelectionPanel.IsDerivedStyle = true;
        SelectionPanel.Location = new System.Drawing.Point( 3, 64 );
        SelectionPanel.Name = "SelectionPanel";
        SelectionPanel.Padding = new System.Windows.Forms.Padding( 1 );
        SelectionPanel.Size = new System.Drawing.Size( 886, 396 );
        SelectionPanel.Style = MetroSet_UI.Enums.Style.Custom;
        SelectionPanel.StyleManager = null;
        SelectionPanel.TabIndex = 10;
        SelectionPanel.ThemeAuthor = "Terry D. Eppler";
        SelectionPanel.ThemeName = "Sherpa";
        SelectionPanel.ToolTip = null;
        // 
        // Timer
        // 
        Timer.Interval = 500;
        // 
        // MinionSelector
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        BorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        ClientSize = new System.Drawing.Size( 1188, 562 );
        Controls.Add( SelectorTable );
        Controls.Add( CloseButton );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.LightGray;
        Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
        MaximumSize = new System.Drawing.Size( 1200, 600 );
        MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        MinimumSize = new System.Drawing.Size( 1200, 600 );
        Name = "MinionSelector";
        ShowIcon = false;
        Text = " ";
        SelectorTable.ResumeLayout( false );
        SelectionPanel.ResumeLayout( false );
        ResumeLayout( false );
    }

    #endregion

    /// <summary>
    /// The header
    /// </summary>
    public Label Header;
    /// <summary>
    /// The close button
    /// </summary>
    public Button CloseButton;
    /// <summary>
    /// The tool tip
    /// </summary>
    public SmallTip ToolTip;
    /// <summary>
    /// The image list
    /// </summary>
    public ImageList ImageList;
    /// <summary>
    /// The carousel
    /// </summary>
    private Carousel Carousel;
    /// <summary>
    /// The selector table
    /// </summary>
    private System.Windows.Forms.TableLayoutPanel SelectorTable;
    /// <summary>
    /// The selection panel
    /// </summary>
    private BackPanel SelectionPanel;
    /// <summary>
    /// The timer
    /// </summary>
    public System.Windows.Forms.Timer Timer;
}