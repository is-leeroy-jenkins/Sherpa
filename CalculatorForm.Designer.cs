// // <copyright file = "CalculatorForm.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{

    partial class CalculatorForm
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
            this.Calculator = new BudgetExecution.CalculationControl();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Calculator.BindingSource = null;
            this.Calculator.DataFilter = null;
            this.Calculator.Field = BudgetExecution.Field.NS;
            this.Calculator.Font = new System.Drawing.Font("Roboto", 8F);
            this.Calculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.Calculator.HoverText = null;
            this.Calculator.Location = new System.Drawing.Point(168, 24);
            this.Calculator.Margin = new System.Windows.Forms.Padding(5);
            this.Calculator.Name = "Calculator";
            this.Calculator.Numeric = BudgetExecution.Numeric.NS;
            this.Calculator.Padding = new System.Windows.Forms.Padding(5);
            this.Calculator.Size = new System.Drawing.Size(450, 450);
            this.Calculator.TabIndex = 0;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.Calculator);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CalculationControl Calculator;
    }
}