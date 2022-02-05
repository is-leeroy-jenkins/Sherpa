// // <copyright file = "BudgetNavigation.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{

    partial class BudgetNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetNavigation));
            this.NavigationMenu = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.SuspendLayout();
            // 
            // NavigationMenu
            // 
            this.NavigationMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationMenu.DrawerHeight = 750;
            this.NavigationMenu.DrawerWidth = 1200;
            this.NavigationMenu.Location = new System.Drawing.Point(0, 0);
            this.NavigationMenu.Name = "NavigationMenu";
            this.NavigationMenu.Position = Syncfusion.Windows.Forms.Tools.SlidePosition.Right;
            this.NavigationMenu.Size = new System.Drawing.Size(1208, 764);
            this.NavigationMenu.Style = Syncfusion.Windows.Forms.Tools.NavigationDrawerStyle.Office2016Black;
            this.NavigationMenu.TabIndex = 0;
            this.NavigationMenu.Text = "Budget Execution";
            this.NavigationMenu.ThemeName = "Office2016Black";
            this.NavigationMenu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledFooterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledFooterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledFooterForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.DisabledPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.FooterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.FooterBorderColor = System.Drawing.Color.SteelBlue;
            this.NavigationMenu.ThemeStyle.FooterFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationMenu.ThemeStyle.HeaderFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationMenu.ThemeStyle.ItemStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.ItemStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.ItemStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.ItemStyle.DisabledSelectionMarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.ThemeStyle.ItemStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigationMenu.ThemeStyle.ItemStyle.SelectionMarkerThickness = 3;
            this.NavigationMenu.ThemeStyle.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NavigationMenu.Transition = Syncfusion.Windows.Forms.Tools.Transition.Push;
            // 
            // BudgetNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1208, 764);
            this.Controls.Add(this.NavigationMenu);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "BudgetNavigation";
            this.ShowIcon = false;
            this.Text = "Budget Execution";
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.NavigationDrawer NavigationMenu;
    }
}