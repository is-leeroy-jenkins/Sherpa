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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.visualCheckBox1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.SuspendLayout();
            // 
            // visualCheckBox1
            // 
            this.visualCheckBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualCheckBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualCheckBox1.Border.HoverVisible = true;
            this.visualCheckBox1.Border.Rounding = 3;
            this.visualCheckBox1.Border.Thickness = 1;
            this.visualCheckBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox1.Border.Visible = true;
            this.visualCheckBox1.Box = new System.Drawing.Size(14, 14);
            this.visualCheckBox1.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualCheckBox1.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualCheckBox1.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualCheckBox1.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.visualCheckBox1.BoxSpacing = 4;
            this.visualCheckBox1.CheckStyle.AutoSize = true;
            this.visualCheckBox1.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.visualCheckBox1.CheckStyle.Character = '✔';
            this.visualCheckBox1.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.visualCheckBox1.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualCheckBox1.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.visualCheckBox1.CheckStyle.ShapeRounding = 3;
            this.visualCheckBox1.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualCheckBox1.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.visualCheckBox1.CheckStyle.Thickness = 2F;
            this.visualCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualCheckBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualCheckBox1.IsBoxLarger = false;
            this.visualCheckBox1.Location = new System.Drawing.Point(672, 365);
            this.visualCheckBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualCheckBox1.Name = "visualCheckBox1";
            this.visualCheckBox1.Size = new System.Drawing.Size(125, 25);
            this.visualCheckBox1.TabIndex = 0;
            this.visualCheckBox1.Text = "visualCheckBox1";
            this.visualCheckBox1.TextSize = new System.Drawing.Size(98, 16);
            this.visualCheckBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualCheckBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualCheckBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualCheckBox1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 618);
            this.Controls.Add(this.visualCheckBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            this.ResumeLayout(false);

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox visualCheckBox1;
    }
}