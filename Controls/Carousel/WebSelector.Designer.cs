// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebSelector));
            this.Header = new BudgetExecution.Label();
            this.Carousel = new BudgetExecution.Carousel();
            this.CloseButton = new BudgetExecution.Button();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.SmallTip();
            this.ImageList = new BudgetExecution.ImageList();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BindingSource = null;
            this.Header.DataFilter = null;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.HoverText = null;
            this.Header.IsDerivedStyle = true;
            this.Header.Location = new System.Drawing.Point(251, 1);
            this.Header.Margin = new System.Windows.Forms.Padding(3);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(686, 64);
            this.Header.Style = MetroSet_UI.Enums.Style.Custom;
            this.Header.StyleManager = null;
            this.Header.TabIndex = 3;
            this.Header.Text = "Header";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.ThemeAuthor = "Terry D. Eppler";
            this.Header.ThemeName = "BudgetExecution";
            this.Header.ToolTip = null;
            // 
            // Carousel
            // 
            this.Carousel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Carousel.BindingSource = null;
            this.Carousel.CanOverrideStyle = true;
            this.Carousel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Carousel.ForeColor = System.Drawing.Color.LightGray;
            this.Carousel.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Carousel.Images = null;
            this.Carousel.ImageshadeColor = System.Drawing.Color.Black;
            this.Carousel.ImageSize = new System.Drawing.Size(250, 250);
            this.Carousel.ImageSlides = true;
            this.Carousel.Location = new System.Drawing.Point(85, 71);
            this.Carousel.Name = "Carousel";
            this.Carousel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Carousel.PadX = 0;
            this.Carousel.PadY = 0;
            this.Carousel.Perspective = 4F;
            this.Carousel.RotateAlways = false;
            this.Carousel.ShowImagePreview = true;
            this.Carousel.ShowImageShadow = true;
            this.Carousel.Size = new System.Drawing.Size(1029, 400);
            this.Carousel.TabIndex = 2;
            this.Carousel.ThemeName = "Metro";
            this.Carousel.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.Carousel.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Carousel.ThemeStyle.ForeColor = System.Drawing.Color.White;
            this.Carousel.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.SteelBlue;
            this.Carousel.ThemeStyle.HoverImageBorderThickness = 2;
            this.Carousel.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Carousel.TouchTransitionSpeed = 1F;
            this.Carousel.UseOriginalImageinPreview = true;
            this.Carousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // CloseButton
            // 
            this.CloseButton.BindingSource = null;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CloseButton.HoverText = "Return to Main Menu";
            this.CloseButton.HoverTextColor = System.Drawing.Color.White;
            this.CloseButton.IsDerivedStyle = true;
            this.CloseButton.Location = new System.Drawing.Point(1036, 510);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalColor = System.Drawing.Color.Transparent;
            this.CloseButton.NormalTextColor = System.Drawing.Color.Transparent;
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.PressTextColor = System.Drawing.Color.White;
            this.CloseButton.Size = new System.Drawing.Size(140, 40);
            this.CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            this.CloseButton.StyleManager = null;
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.ThemeAuthor = "Terry D. Eppler";
            this.CloseButton.ThemeName = "BudgetExecution";
            this.CloseButton.ToolTip = null;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.IsDerivedStyle = true;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // ImageList
            // 
            this.ImageList.BindingSource = null;
            this.ImageList.DataFilter = null;
            this.ImageList.FileNames = null;
            this.ImageList.FilePaths = null;
            this.ImageList.HoverText = null;
            this.ImageList.Image = null;
            this.ImageList.ImageSource = BudgetExecution.ImageDirectory.Ns;
            this.ImageList.ToolTip = null;
            // 
            // WebSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1188, 562);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Carousel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "WebSelector";
            this.ShowIcon = false;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    public Label Header;
    public Carousel Carousel;
    public Button CloseButton;
    public SmallTip ToolTip;
    public System.Windows.Forms.BindingSource BindingSource;
    public ImageList ImageList;
}