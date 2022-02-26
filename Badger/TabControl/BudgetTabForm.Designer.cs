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
            this.TabControl = new BudgetExecution.BudgetTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.TabControl.ActiveTabFont = new System.Drawing.Font("Roboto", 8F);
            this.TabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1188, 664);
            this.TabControl.BindingSource = null;
            this.TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControl.DataFilter = null;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Field = BudgetExecution.Field.RpioActivityCode;
            this.TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl.Font = new System.Drawing.Font("Roboto", 9F);
            this.TabControl.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TabControl.HotTrack = true;
            this.TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(1188, 664);
            this.TabControl.TabIndex = 0;
            this.TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.SteelBlue;
            this.TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.SteelBlue;
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveFont = new System.Drawing.Font("Roboto", 8F);
            this.TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            this.TabControl.ThemeStyle.TabStyle.DisabledActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.DisabledActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.HoverActiveBorderColor = System.Drawing.Color.SteelBlue;
            this.TabControl.ThemeStyle.TabStyle.HoverActiveCloseButtonForeColor = System.Drawing.Color.White;
            this.TabControl.ThemeStyle.TabStyle.HoverInactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.HoverInactiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.InactiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.ThemeStyle.TabStyle.InactiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TabControl.UserMoveTabs = true;
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
            this.CaptionForeColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 664);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "BudgetTabForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BudgetTabControl TabControl;
    }
}