// <copyright file = "BadgerMain.Designer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    public partial class BudgetForm
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
            this.TestLabel = new BudgetExecution.BudgetLabel();
            this.TestButton = new BudgetExecution.BudgetButton();
            this.SuspendLayout();
            // 
            // TestLabel
            // 
            this.TestLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TestLabel.BackColor = System.Drawing.Color.Transparent;
            this.TestLabel.BindingSource = null;
            this.TestLabel.DataFilter = null;
            this.TestLabel.Field = BudgetExecution.Field.NS;
            this.TestLabel.Font = new System.Drawing.Font("Roboto", 8F);
            this.TestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TestLabel.Location = new System.Drawing.Point(298, 248);
            this.TestLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Numeric = BudgetExecution.Numeric.NS;
            this.TestLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TestLabel.Outline = false;
            this.TestLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.TestLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestLabel.ReflectionSpacing = 0;
            this.TestLabel.ShadowColor = System.Drawing.Color.Black;
            this.TestLabel.ShadowDirection = 315;
            this.TestLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.TestLabel.ShadowOpacity = 100;
            this.TestLabel.Size = new System.Drawing.Size(361, 23);
            this.TestLabel.TabIndex = 2;
            this.TestLabel.Text = "Test";
            this.TestLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TestLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TestLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TestLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TestLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TestLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TestLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TestLabel.ToolTip = null;
            // 
            // TestButton
            // 
            this.TestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TestButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TestButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TestButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TestButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.TestButton.BindingSource = null;
            this.TestButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TestButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
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
            this.TestButton.Location = new System.Drawing.Point(970, 432);
            this.TestButton.Margin = new System.Windows.Forms.Padding(0);
            this.TestButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(151, 68);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Test";
            this.TestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TestButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TestButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TestButton.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TestButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.TestButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TestButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TestButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TestButton.ToolTip = null;
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CaptionBarColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(1130, 509);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.TestLabel);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Black;
            this.Name = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion
        private BudgetLabel TestLabel;
        private BudgetButton TestButton;
    }
}