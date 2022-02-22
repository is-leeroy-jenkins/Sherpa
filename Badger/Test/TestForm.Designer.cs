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
            this.TestCheckBox = new BudgetExecution.BudgetCheckBox();
            this.SuspendLayout();
            // 
            // TestCheckBox
            // 
            this.TestCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TestCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TestCheckBox.Border.HoverVisible = true;
            this.TestCheckBox.Border.Rounding = 3;
            this.TestCheckBox.Border.Thickness = 1;
            this.TestCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TestCheckBox.Border.Visible = true;
            this.TestCheckBox.Box = new System.Drawing.Size(14, 14);
            this.TestCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TestCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TestCheckBox.BoxSpacing = 4;
            this.TestCheckBox.CheckStyle.AutoSize = true;
            this.TestCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.TestCheckBox.CheckStyle.Character = '✔';
            this.TestCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.TestCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.TestCheckBox.CheckStyle.ShapeRounding = 3;
            this.TestCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TestCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.TestCheckBox.CheckStyle.Thickness = 2F;
            this.TestCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestCheckBox.DataFilter = null;
            this.TestCheckBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TestCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TestCheckBox.HoverText = null;
            this.TestCheckBox.IsBoxLarger = false;
            this.TestCheckBox.Location = new System.Drawing.Point(740, 13);
            this.TestCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TestCheckBox.Name = "TestCheckBox";
            this.TestCheckBox.Size = new System.Drawing.Size(125, 25);
            this.TestCheckBox.TabIndex = 0;
            this.TestCheckBox.Text = "Test Check Box ";
            this.TestCheckBox.TextSize = new System.Drawing.Size(89, 16);
            this.TestCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TestCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TestCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TestCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TestCheckBox.ToolTip = null;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1058, 617);
            this.Controls.Add(this.TestCheckBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            this.ResumeLayout(false);

        }

        #endregion

        private BudgetCheckBox TestCheckBox;
    }
}