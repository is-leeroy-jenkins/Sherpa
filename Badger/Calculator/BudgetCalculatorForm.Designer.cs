// <copyright file = "BudgetCalculatorForm.Designer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{

    partial class BudgetCalculatorForm
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
            this.CalculatorControl = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.SuspendLayout();
            // 
            // CalculatorControl
            // 
            this.CalculatorControl.AccessibleDescription = "Calculator control";
            this.CalculatorControl.AccessibleName = "Calculator Control";
            this.CalculatorControl.BeforeTouchSize = new System.Drawing.Size(388, 379);
            this.CalculatorControl.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.CalculatorControl.Culture = new System.Globalization.CultureInfo("en-US");
            this.CalculatorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculatorControl.DoubleValue = 0D;
            this.CalculatorControl.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculatorControl.Location = new System.Drawing.Point(0, 0);
            this.CalculatorControl.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CalculatorControl.Name = "CalculatorControl";
            this.CalculatorControl.Size = new System.Drawing.Size(388, 379);
            this.CalculatorControl.TabIndex = 0;
            this.CalculatorControl.Text = "calculatorControl1";
            this.CalculatorControl.ThemeName = "Metro";
            this.CalculatorControl.UseVerticalAndHorizontalSpacing = true;
            this.CalculatorControl.UseVisualStyle = true;
            // 
            // BudgetCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionBarHeight = 15;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(388, 379);
            this.Controls.Add(this.CalculatorControl);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "BudgetCalculatorForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.CalculatorControl CalculatorControl;
    }
}