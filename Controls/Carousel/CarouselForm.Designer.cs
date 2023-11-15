namespace BudgetExecution
{
    partial class CarouselForm
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarouselForm));
            this.Carousel = new BudgetExecution.Selector();
            this.ImageList = new BudgetExecution.ImageList();
            this.Header = new BudgetExecution.Label();
            this.SuspendLayout();
            // 
            // Carousel
            // 
            this.Carousel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Carousel.BindingSource = null;
            this.Carousel.CanOverrideStyle = true;
            this.Carousel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Carousel.ForeColor = System.Drawing.Color.White;
            this.Carousel.HighlightColor = System.Drawing.Color.SteelBlue;
            this.Carousel.Images = null;
            this.Carousel.ImageshadeColor = System.Drawing.Color.Black;
            this.Carousel.ImageSize = new System.Drawing.Size(250, 250);
            this.Carousel.ImageSlides = true;
            this.Carousel.Location = new System.Drawing.Point(195, 166);
            this.Carousel.Name = "Carousel";
            this.Carousel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Carousel.PadX = 0;
            this.Carousel.PadY = 0;
            this.Carousel.Perspective = 4F;
            this.Carousel.RotateAlways = false;
            this.Carousel.ShowImagePreview = true;
            this.Carousel.ShowImageShadow = true;
            this.Carousel.Size = new System.Drawing.Size(1029, 429);
            this.Carousel.TabIndex = 0;
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
            // Header
            // 
            this.Header.BindingSource = null;
            this.Header.DataFilter = null;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.HoverText = null;
            this.Header.IsDerivedStyle = true;
            this.Header.Location = new System.Drawing.Point(361, 96);
            this.Header.Margin = new System.Windows.Forms.Padding(3);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(686, 64);
            this.Header.Style = MetroSet_UI.Enums.Style.Custom;
            this.Header.StyleManager = null;
            this.Header.TabIndex = 1;
            this.Header.Text = "Header";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.ThemeAuthor = "Terry D. Eppler";
            this.Header.ThemeName = "BudgetExecution";
            this.Header.ToolTip = null;
            // 
            // CarouselForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1388, 713);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Carousel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "CarouselForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public Selector Carousel;
        public ImageList ImageList;
        public Label Header;
    }
}