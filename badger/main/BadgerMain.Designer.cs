// <copyright file = "BadgerMain.Designer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{

    partial class BadgerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgerMain));
            this.picturePanel1 = new BudgetExecution.PicturePanel();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePanel1
            // 
            this.picturePanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picturePanel1.BackColor = System.Drawing.Color.Transparent;
            this.picturePanel1.BindingSource = null;
            this.picturePanel1.DataFilter = null;
            this.picturePanel1.Field = BudgetExecution.Field.NS;
            this.picturePanel1.HoverText = null;
            this.picturePanel1.Image = ((System.Drawing.Image)(resources.GetObject("picturePanel1.Image")));
            this.picturePanel1.ImageList = null;
            this.picturePanel1.Location = new System.Drawing.Point(346, 121);
            this.picturePanel1.Margin = new System.Windows.Forms.Padding(5);
            this.picturePanel1.Name = "picturePanel1";
            this.picturePanel1.Padding = new System.Windows.Forms.Padding(1);
            this.picturePanel1.Size = new System.Drawing.Size(490, 322);
            this.picturePanel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePanel1.TabIndex = 0;
            this.picturePanel1.TabStop = false;
            this.picturePanel1.ToolTip = null;
            // 
            // BadgerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1166, 595);
            this.Controls.Add(this.picturePanel1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "BadgerMain";
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PicturePanel picturePanel1;
    }
}