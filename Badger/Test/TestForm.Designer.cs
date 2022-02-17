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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.SteelBlue;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(252, 131);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.CanOverrideStyle = true;
            this.tabControlAdv1.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.Controls.Add(this.TabPage);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.SteelBlue;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.HotTrack = true;
            this.tabControlAdv1.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.Location = new System.Drawing.Point(199, 195);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(252, 131);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.ThemeName = "TabRendererMetro";
            this.tabControlAdv1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.ThemeStyle.BorderFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.tabControlAdv1.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // TabPage
            // 
            this.TabPage.Image = null;
            this.TabPage.ImageSize = new System.Drawing.Size(16, 16);
            this.TabPage.Location = new System.Drawing.Point(0, 22);
            this.TabPage.Name = "TabPage";
            this.TabPage.ShowCloseButton = false;
            this.TabPage.Size = new System.Drawing.Size(252, 109);
            this.TabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TabPage.TabForeColor = System.Drawing.Color.LightSteelBlue;
            this.TabPage.TabIndex = 1;
            this.TabPage.Text = "Tab One";
            this.TabPage.ThemesEnabled = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 618);
            this.Controls.Add(this.tabControlAdv1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TabPage;
    }
}