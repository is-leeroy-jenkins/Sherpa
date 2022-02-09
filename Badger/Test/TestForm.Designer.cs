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
            this.currencyEdit1 = new Syncfusion.Windows.Forms.Tools.CurrencyEdit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1.TextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // currencyEdit1
            // 
            this.currencyEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.BeforeTouchSize = new System.Drawing.Size(140, 28);
            this.currencyEdit1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.currencyEdit1.CalculatorLayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.WindowsStandard;
            this.currencyEdit1.FlatBorderColor = System.Drawing.Color.SteelBlue;
            this.currencyEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyEdit1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyEdit1.Location = new System.Drawing.Point(288, 175);
            this.currencyEdit1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.Name = "currencyEdit1";
            this.currencyEdit1.Size = new System.Drawing.Size(140, 28);
            this.currencyEdit1.TabIndex = 0;
            // 
            // 
            // 
            this.currencyEdit1.TextBox.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.TextBox.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.currencyEdit1.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currencyEdit1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currencyEdit1.TextBox.DecimalValue = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.currencyEdit1.TextBox.FocusBorderColor = System.Drawing.Color.SteelBlue;
            this.currencyEdit1.TextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.currencyEdit1.TextBox.Location = new System.Drawing.Point(3, 3);
            this.currencyEdit1.TextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.TextBox.Name = "";
            this.currencyEdit1.TextBox.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.currencyEdit1.TextBox.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.currencyEdit1.TextBox.PositiveColor = System.Drawing.Color.LightSteelBlue;
            this.currencyEdit1.TextBox.Size = new System.Drawing.Size(110, 22);
            this.currencyEdit1.TextBox.TabIndex = 0;
            this.currencyEdit1.TextBox.Text = "$1.00";
            this.currencyEdit1.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currencyEdit1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currencyEdit1.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.currencyEdit1.ThemeStyle.FocusedBorderColor = System.Drawing.Color.SteelBlue;
            this.currencyEdit1.ThemeStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.currencyEdit1.ThemeStyle.PressedBorderColor = System.Drawing.Color.SteelBlue;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1058, 616);
            this.Controls.Add(this.currencyEdit1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1.TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.CurrencyEdit currencyEdit1;
    }
}