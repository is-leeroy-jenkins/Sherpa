// <copyright file = "TestForm.Designer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{

    partial class TestForm
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
                components.Dispose();
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
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.carousel1 = new Syncfusion.Windows.Forms.Tools.Carousel();
            this.SuspendLayout();
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText);
            this.splashPanel1.BeforeTouchSize = new System.Drawing.Size(300, 150);
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(100, 173);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(300, 150);
            this.splashPanel1.TabIndex = 0;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // carousel1
            // 
            this.carousel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.carousel1.CanOverrideStyle = true;
            this.carousel1.HighlightColor = System.Drawing.Color.SteelBlue;
            this.carousel1.ImageshadeColor = System.Drawing.Color.Black;
            this.carousel1.ImageSlides = true;
            this.carousel1.Location = new System.Drawing.Point(532, 173);
            this.carousel1.Name = "carousel1";
            this.carousel1.PadX = 0;
            this.carousel1.PadY = 0;
            this.carousel1.Perspective = 2F;
            this.carousel1.RotateAlways = false;
            this.carousel1.ShowImagePreview = true;
            this.carousel1.ShowImageShadow = true;
            this.carousel1.Size = new System.Drawing.Size(300, 150);
            this.carousel1.TabIndex = 1;
            this.carousel1.Text = "carousel1";
            this.carousel1.ThemeName = "Metro";
            this.carousel1.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carousel1.ThemeStyle.ForeColor = System.Drawing.Color.LightGray;
            this.carousel1.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.SteelBlue;
            this.carousel1.TouchTransitionSpeed = 1F;
            this.carousel1.UseOriginalImageinPreview = false;
            this.carousel1.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1058, 616);
            this.Controls.Add(this.carousel1);
            this.Controls.Add(this.splashPanel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
        private Syncfusion.Windows.Forms.Tools.Carousel carousel1;
    }
}