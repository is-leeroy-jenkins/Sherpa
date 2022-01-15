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
            this.LoadingPanel = new BudgetExecution.PicturePanel();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BackPanel.BackColorState.Enabled = System.Drawing.Color.Transparent;
            this.BackPanel.Border.Color = System.Drawing.Color.Transparent;
            this.BackPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackPanel.Border.HoverVisible = false;
            this.BackPanel.Border.Rounding = 6;
            this.BackPanel.Border.Thickness = 1;
            this.BackPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackPanel.Border.Visible = true;
            this.BackPanel.Controls.Add(this.LoadingPanel);
            this.BackPanel.Size = new System.Drawing.Size(1166, 595);
            this.BackPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.picturePanel1.Location = new System.Drawing.Point(360, 119);
            this.picturePanel1.Margin = new System.Windows.Forms.Padding(5);
            this.picturePanel1.Name = "picturePanel1";
            this.picturePanel1.Padding = new System.Windows.Forms.Padding(1);
            this.picturePanel1.Size = new System.Drawing.Size(410, 300);
            this.picturePanel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePanel1.TabIndex = 0;
            this.picturePanel1.TabStop = false;
            this.picturePanel1.ToolTip = null;
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingPanel.BindingSource = null;
            this.LoadingPanel.DataFilter = null;
            this.LoadingPanel.Field = BudgetExecution.Field.NS;
            this.LoadingPanel.HoverText = null;
            this.LoadingPanel.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPanel.Image")));
            this.LoadingPanel.ImageList = null;
            this.LoadingPanel.Location = new System.Drawing.Point(332, 109);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Padding = new System.Windows.Forms.Padding(1);
            this.LoadingPanel.Size = new System.Drawing.Size(553, 352);
            this.LoadingPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingPanel.TabIndex = 0;
            this.LoadingPanel.TabStop = false;
            this.LoadingPanel.ToolTip = null;
            // 
            // BadgerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1166, 595);
            this.Controls.Add(this.picturePanel1);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "BadgerMain";
            this.Controls.SetChildIndex(this.picturePanel1, 0);
            this.Controls.SetChildIndex(this.BackPanel, 0);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PicturePanel picturePanel1;
        public PicturePanel LoadingPanel;
    }
}