namespace Sherpa
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
        private void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( CarouselForm ) );
            Carousel = new Carousel( );
            ImageList = new ImageList( );
            Header = new Label( );
            Timer = new System.Windows.Forms.Timer( components );
            ToolTip = new SmallTip( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            SuspendLayout( );
            // 
            // Carousel
            // 
            Carousel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Carousel.CanOverrideStyle = true;
            Carousel.Font = new System.Drawing.Font( "Roboto", 9F );
            Carousel.ForeColor = System.Drawing.Color.White;
            Carousel.HighlightColor = System.Drawing.Color.SteelBlue;
            Carousel.Images = null;
            Carousel.ImageshadeColor = System.Drawing.Color.Black;
            Carousel.ImageSize = new System.Drawing.Size( 250, 250 );
            Carousel.ImageSlides = true;
            Carousel.Location = new System.Drawing.Point( 195, 166 );
            Carousel.Name = "Carousel";
            Carousel.Padding = new System.Windows.Forms.Padding( 0, 10, 0, 10 );
            Carousel.PadX = 0;
            Carousel.PadY = 0;
            Carousel.Perspective = 4F;
            Carousel.RotateAlways = false;
            Carousel.ShowImagePreview = true;
            Carousel.ShowImageShadow = true;
            Carousel.Size = new System.Drawing.Size( 1029, 429 );
            Carousel.TabIndex = 0;
            Carousel.ThemeName = "Metro";
            Carousel.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            Carousel.ThemeStyle.Font = new System.Drawing.Font( "Roboto", 9F );
            Carousel.ThemeStyle.ForeColor = System.Drawing.Color.White;
            Carousel.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.SteelBlue;
            Carousel.ThemeStyle.HoverImageBorderThickness = 2;
            Carousel.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb( 18, 18, 18 );
            Carousel.TouchTransitionSpeed = 1F;
            Carousel.UseOriginalImageinPreview = true;
            Carousel.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // ImageList
            // 
            ImageList.FileNames = null;
            ImageList.FilePaths = null;
            ImageList.HoverText = null;
            ImageList.Image = null;
            // 
            // Header
            // 
            Header.BindingSource = null;
            Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Header.Font = new System.Drawing.Font( "Roboto", 12F );
            Header.HoverText = null;
            Header.IsDerivedStyle = true;
            Header.Location = new System.Drawing.Point( 361, 96 );
            Header.Margin = new System.Windows.Forms.Padding( 3 );
            Header.Name = "Header";
            Header.Padding = new System.Windows.Forms.Padding( 1 );
            Header.Size = new System.Drawing.Size( 686, 64 );
            Header.Style = MetroSet_UI.Enums.Style.Custom;
            Header.StyleManager = null;
            Header.TabIndex = 1;
            Header.Text = "Header";
            Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Header.ThemeAuthor = "Terry D. Eppler";
            Header.ThemeName = "BudgetExecution";
            Header.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
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
            // CarouselForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1333, 733 );
            ControlBox = false;
            Controls.Add( Header );
            Controls.Add( Carousel );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimumSize = new System.Drawing.Size( 1340, 740 );
            Name = "CarouselForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public Carousel Carousel;
        public ImageList ImageList;
        public Label Header;
        public System.Windows.Forms.Timer Timer;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
    }
}