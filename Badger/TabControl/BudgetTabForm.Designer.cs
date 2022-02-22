// // <copyright file = "BudgetTabForm.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{

    partial class BudgetTabForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetTabForm));
            this.budgetTabControl1 = new BudgetExecution.BudgetTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.budgetTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetTabControl1
            // 
            this.budgetTabControl1.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.budgetTabControl1.ActiveTabFont = new System.Drawing.Font("Roboto", 8F);
            this.budgetTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.BeforeTouchSize = new System.Drawing.Size(1188, 664);
            this.budgetTabControl1.BindingSource = null;
            this.budgetTabControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.budgetTabControl1.DataFilter = null;
            this.budgetTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.budgetTabControl1.Field = BudgetExecution.Field.NS;
            this.budgetTabControl1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.budgetTabControl1.Font = new System.Drawing.Font("Roboto", 9F);
            this.budgetTabControl1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.budgetTabControl1.HotTrack = true;
            this.budgetTabControl1.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.Location = new System.Drawing.Point(0, 0);
            this.budgetTabControl1.Name = "budgetTabControl1";
            this.budgetTabControl1.Size = new System.Drawing.Size(1188, 664);
            this.budgetTabControl1.TabIndex = 0;
            this.budgetTabControl1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.budgetTabControl1.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.SteelBlue;
            this.budgetTabControl1.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.SteelBlue;
            this.budgetTabControl1.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Roboto", 8F);
            this.budgetTabControl1.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            this.budgetTabControl1.ThemeStyle.TabStyle.DisabledActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.DisabledActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.HoverActiveBorderColor = System.Drawing.Color.SteelBlue;
            this.budgetTabControl1.ThemeStyle.TabStyle.HoverActiveCloseButtonForeColor = System.Drawing.Color.White;
            this.budgetTabControl1.ThemeStyle.TabStyle.HoverInactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.HoverInactiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.InactiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.ThemeStyle.TabStyle.InactiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetTabControl1.UserMoveTabs = true;
            // 
            // BudgetTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 664);
            this.Controls.Add(this.budgetTabControl1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "BudgetTabForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.budgetTabControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BudgetTabControl budgetTabControl1;
    }
}