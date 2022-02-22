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
            this.TestToolStip = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolSeparator1 = new BudgetExecution.ToolSeparator();
            this._budgetToolTextBox1 = new BudgetExecution.BudgetToolStripTextBox();
            this.toolSeparator2 = new BudgetExecution.ToolSeparator();
            this.barComboBox1 = new BudgetExecution.BudgetToolStripComboBox();
            this.TestToolStip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestToolStip
            // 
            this.TestToolStip.CanOverrideStyle = true;
            this.TestToolStip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TestToolStip.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestToolStip.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TestToolStip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TestToolStip.Image = null;
            this.TestToolStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSeparator1,
            this._budgetToolTextBox1,
            this.toolSeparator2,
            this.barComboBox1});
            this.TestToolStip.Location = new System.Drawing.Point(0, 571);
            this.TestToolStip.Name = "TestToolStip";
            this.TestToolStip.Office12Mode = false;
            this.TestToolStip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.TestToolStip.Size = new System.Drawing.Size(1058, 46);
            this.TestToolStip.TabIndex = 1;
            this.TestToolStip.Text = "Budget Execution";
            this.TestToolStip.ThemeName = "Office2016Black";
            this.TestToolStip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.CaptionForeColor = System.Drawing.Color.White;
            this.TestToolStip.ThemeStyle.CheckBoxStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.CheckBoxStyle.CheckedTickBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.CheckBoxStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.CheckBoxStyle.HoverTickBoxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TestToolStip.ThemeStyle.CheckBoxStyle.PressedBackColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.CheckBoxStyle.TickColor = System.Drawing.Color.Lime;
            this.TestToolStip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.DisabledArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.DropDownStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.DropDownStyle.DisabledItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.DropDownStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.CheckedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.HoverItemForeColor = System.Drawing.Color.LightSteelBlue;
            this.TestToolStip.ThemeStyle.GalleryStyle.HoverScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.HoverScrollBarBorderColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.GalleryStyle.HoverScrollButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.HoverScrollButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.ItemForeColor = System.Drawing.Color.LightSteelBlue;
            this.TestToolStip.ThemeStyle.GalleryStyle.PressedItemBackColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.GalleryStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.GalleryStyle.ScrollButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TestToolStip.ThemeStyle.HoverArrowColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.TestToolStip.ThemeStyle.ItemFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestToolStip.ThemeStyle.ItemForeColor = System.Drawing.Color.LightSteelBlue;
            this.TestToolStip.ThemeStyle.LauncherStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TestToolStip.ThemeStyle.LauncherStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.LauncherStyle.HoverForeColor = System.Drawing.Color.White;
            this.TestToolStip.ThemeStyle.PressedItemBackColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.SplitButtonStyle.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.TestToolStip.ThemeStyle.SplitButtonStyle.PressedBackColor = System.Drawing.Color.SteelBlue;
            this.TestToolStip.ThemeStyle.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TestToolStip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.toolSeparator1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // barTextBox1
            // 
            this._budgetToolTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this._budgetToolTextBox1.BindingSource = null;
            this._budgetToolTextBox1.Field = BudgetExecution.Field.NS;
            this._budgetToolTextBox1.Font = new System.Drawing.Font("Roboto", 9F);
            this._budgetToolTextBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this._budgetToolTextBox1.HoverText = "";
            this._budgetToolTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this._budgetToolTextBox1.Name = "_budgetToolTextBox1";
            this._budgetToolTextBox1.Size = new System.Drawing.Size(150, 22);
            this._budgetToolTextBox1.Tag = "";
            this._budgetToolTextBox1.ToolTip = null;
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // barComboBox1
            // 
            this.barComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.barComboBox1.BindingSource = null;
            this.barComboBox1.DropDownHeight = 200;
            this.barComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barComboBox1.Field = BudgetExecution.Field.NS;
            this.barComboBox1.Font = new System.Drawing.Font("Roboto", 9F);
            this.barComboBox1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.barComboBox1.HoverText = "Make Selection";
            this.barComboBox1.IntegralHeight = false;
            this.barComboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.barComboBox1.MaxDropDownItems = 30;
            this.barComboBox1.Name = "barComboBox1";
            this.barComboBox1.Size = new System.Drawing.Size(150, 22);
            this.barComboBox1.Tag = "Make Selection";
            this.barComboBox1.ToolTip = null;
            this.barComboBox1.ToolTipText = "Make Selection";
            // 
            // TestForm
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
            this.Controls.Add(this.TestToolStip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Execution";
            this.TestToolStip.ResumeLayout(false);
            this.TestToolStip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.ToolStripEx TestToolStip;
        private ToolSeparator toolSeparator1;
        private BudgetToolStripTextBox _budgetToolTextBox1;
        private ToolSeparator toolSeparator2;
        private BudgetToolStripComboBox barComboBox1;
    }
}