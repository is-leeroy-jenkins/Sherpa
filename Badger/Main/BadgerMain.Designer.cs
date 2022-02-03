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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgerMain));
            this.picturePanel1 = new BudgetExecution.BudgetPicture();
            this.TestButton = new BudgetExecution.BudgetButton();
            this.LoadingBoxBase = new BudgetExecution.BudgetPicture();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBoxBase)).BeginInit();
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
            // TestButton
            // 
            this.TestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TestButton.BackColor = System.Drawing.Color.Transparent;
            this.TestButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TestButton.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TestButton.BindingSource = null;
            this.TestButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestButton.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TestButton.Border.HoverVisible = true;
            this.TestButton.Border.Rounding = 6;
            this.TestButton.Border.Thickness = 1;
            this.TestButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TestButton.Border.Visible = true;
            this.TestButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TestButton.Field = BudgetExecution.Field.NS;
            this.TestButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.TestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TestButton.HoverText = null;
            this.TestButton.Image = null;
            this.TestButton.Images = null;
            this.TestButton.Location = new System.Drawing.Point(1047, 544);
            this.TestButton.Margin = new System.Windows.Forms.Padding(0);
            this.TestButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(119, 51);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "Test";
            this.TestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TestButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TestButton.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TestButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.TestButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TestButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TestButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TestButton.ToolTip = null;
            // 
            // LoadingPanel
            // 
            this.LoadingBoxBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingBoxBase.BackColor = System.Drawing.Color.Transparent;
            this.LoadingBoxBase.BindingSource = null;
            this.LoadingBoxBase.DataFilter = null;
            this.LoadingBoxBase.Field = BudgetExecution.Field.NS;
            this.LoadingBoxBase.HoverText = null;
            this.LoadingBoxBase.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPanel.Image")));
            this.LoadingBoxBase.ImageList = null;
            this.LoadingBoxBase.Location = new System.Drawing.Point(400, 115);
            this.LoadingBoxBase.Name = "LoadingBoxBase";
            this.LoadingBoxBase.Padding = new System.Windows.Forms.Padding(1);
            this.LoadingBoxBase.Size = new System.Drawing.Size(410, 304);
            this.LoadingBoxBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingBoxBase.TabIndex = 0;
            this.LoadingBoxBase.TabStop = false;
            this.LoadingBoxBase.ToolTip = null;
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
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBoxBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxBase picturePanel1;
        private BudgetButton TestButton;
        public PictureBoxBase LoadingBoxBase;
    }
}