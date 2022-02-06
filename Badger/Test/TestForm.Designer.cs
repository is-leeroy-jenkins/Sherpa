// // <copyright file = "TestForm.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
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
            this.Button = new BudgetExecution.BudgetButton();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.Button.BindingSource = null;
            this.Button.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.Button.Border.HoverVisible = true;
            this.Button.Border.Rounding = 6;
            this.Button.Border.Thickness = 1;
            this.Button.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.Button.Border.Visible = true;
            this.Button.DataFilter = null;
            this.Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button.Field = BudgetExecution.Field.NS;
            this.Button.Font = new System.Drawing.Font("Roboto", 10F);
            this.Button.ForeColor = System.Drawing.Color.LightGray;
            this.Button.HoverText = null;
            this.Button.Image = null;
            this.Button.Images = null;
            this.Button.Location = new System.Drawing.Point(1239, 715);
            this.Button.Margin = new System.Windows.Forms.Padding(0);
            this.Button.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(140, 40);
            this.Button.TabIndex = 0;
            this.Button.Text = "budgetButton1";
            this.Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Button.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.Button.TextStyle.Hover = System.Drawing.Color.White;
            this.Button.TextStyle.Pressed = System.Drawing.Color.White;
            this.Button.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Button.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Button.ToolTip = null;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 764);
            this.Controls.Add(this.Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        public BudgetButton Button;
    }
}