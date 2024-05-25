// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace Sherpa;

partial class WebSelector
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebSelector));
            Header = new BudgetExecution.Label();
            Carousel = new BudgetExecution.Carousel();
            CloseButton = new BudgetExecution.Button();
            ToolTip = new BudgetExecution.SmallTip();
            ImageList = new BudgetExecution.ImageList();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BindingSource = null;
            Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Header.HoverText = null;
            Header.IsDerivedStyle = true;
            Header.Location = new System.Drawing.Point(251, 1);
            Header.Margin = new System.Windows.Forms.Padding(3);
            Header.Name = "Header";
            Header.Padding = new System.Windows.Forms.Padding(1);
            Header.Size = new System.Drawing.Size(686, 64);
            Header.Style = MetroSet_UI.Enums.Style.Custom;
            Header.StyleManager = null;
            Header.TabIndex = 3;
            Header.Text = "Header";
            Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Header.ThemeAuthor = "Terry D. Eppler";
            Header.ThemeName = "BudgetExecution";
            Header.ToolTip = null;
            // 
            // Carousel
            // 
            Carousel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            Carousel.CanOverrideStyle = true;
            Carousel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Carousel.ForeColor = System.Drawing.Color.LightGray;
            Carousel.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            Carousel.Images = null;
            Carousel.ImageshadeColor = System.Drawing.Color.Black;
            Carousel.ImageSize = new System.Drawing.Size(250, 250);
            Carousel.ImageSlides = true;
            Carousel.Location = new System.Drawing.Point(85, 71);
            Carousel.Name = "Carousel";
            Carousel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            Carousel.PadX = 0;
            Carousel.PadY = 0;
            Carousel.Perspective = 4F;
            Carousel.RotateAlways = false;
            Carousel.ShowImagePreview = true;
            Carousel.ShowImageShadow = true;
            Carousel.Size = new System.Drawing.Size(1029, 400);
            Carousel.TabIndex = 2;
            Carousel.ThemeName = "Metro";
            Carousel.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            Carousel.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Carousel.ThemeStyle.ForeColor = System.Drawing.Color.White;
            Carousel.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.SteelBlue;
            Carousel.ThemeStyle.HoverImageBorderThickness = 2;
            Carousel.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            Carousel.TouchTransitionSpeed = 1F;
            Carousel.UseOriginalImageinPreview = true;
            Carousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            CloseButton.HoverText = "Return to Main Menu";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point(1036, 510);
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.Transparent;
            CloseButton.Padding = new System.Windows.Forms.Padding(1);
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size(140, 40);
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "BudgetExecution";
            CloseButton.ToolTip = null;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
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
            // WebSelector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            ClientSize = new System.Drawing.Size(1188, 562);
            Controls.Add(CloseButton);
            Controls.Add(Header);
            Controls.Add(Carousel);
            Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MaximumSize = new System.Drawing.Size(1200, 600);
            MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            MinimumSize = new System.Drawing.Size(1200, 600);
            Name = "WebSelector";
            ShowIcon = false;
            Text = " ";
            ResumeLayout(false);

    }

    #endregion

    public Label Header;
    public Carousel Carousel;
    public Button CloseButton;
    public SmallTip ToolTip;
    public ImageList ImageList;
}