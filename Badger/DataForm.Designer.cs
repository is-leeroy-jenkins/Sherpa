// // <copyright file = "TestForm3.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{

    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.budgetToolStrip1 = new BudgetExecution.BudgetToolStrip();
            this.SuspendLayout();
            // 
            // budgetToolStrip1
            // 
            this.budgetToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetToolStrip1.BindingSource = null;
            this.budgetToolStrip1.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.budgetToolStrip1.CanOverrideStyle = true;
            this.budgetToolStrip1.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.budgetToolStrip1.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold);
            this.budgetToolStrip1.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.budgetToolStrip1.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.budgetToolStrip1.DataFilter = null;
            this.budgetToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.budgetToolStrip1.Field = BudgetExecution.Field.RpioActivityCode;
            this.budgetToolStrip1.Font = new System.Drawing.Font("Roboto", 9F);
            this.budgetToolStrip1.ForeColor = System.Drawing.Color.Black;
            this.budgetToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.budgetToolStrip1.Image = null;
            this.budgetToolStrip1.ImagePath = null;
            this.budgetToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.budgetToolStrip1.ImageSize = new System.Drawing.Size(20, 20);
            this.budgetToolStrip1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.budgetToolStrip1.Location = new System.Drawing.Point(0, 576);
            this.budgetToolStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.budgetToolStrip1.Name = "budgetToolStrip1";
            this.budgetToolStrip1.Numeric = BudgetExecution.Numeric.NS;
            this.budgetToolStrip1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.budgetToolStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.budgetToolStrip1.ShowCaption = true;
            this.budgetToolStrip1.ShowLauncher = true;
            this.budgetToolStrip1.Size = new System.Drawing.Size(1058, 41);
            this.budgetToolStrip1.TabIndex = 0;
            this.budgetToolStrip1.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.budgetToolStrip1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetToolStrip1.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.budgetToolStrip1.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.budgetToolStrip1.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.budgetToolStrip1.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.budgetToolStrip1.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.budgetToolStrip1.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            this.budgetToolStrip1.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            // 
            // DataForm
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
            this.Controls.Add(this.budgetToolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "DataForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BudgetToolStrip budgetToolStrip1;
    }
}