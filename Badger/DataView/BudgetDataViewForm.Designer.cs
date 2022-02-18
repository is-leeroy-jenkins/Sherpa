// <copyright file = "BudgetDataViewForm.Designer.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{

    partial class BudgetDataViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetDataViewForm));
            this.budgetDataView1 = new BudgetExecution.BudgetDataView();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetDataView1
            // 
            this.budgetDataView1.AccessibleName = "Table";
            this.budgetDataView1.AllowDeleting = true;
            this.budgetDataView1.AllowDraggingColumns = true;
            this.budgetDataView1.AllowFiltering = true;
            this.budgetDataView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.budgetDataView1.BindingSource = null;
            this.budgetDataView1.CopyOption = Syncfusion.WinForms.DataGrid.Enums.CopyOptions.IncludeHeaders;
            this.budgetDataView1.DataFilter = null;
            this.budgetDataView1.Field = BudgetExecution.Field.NS;
            this.budgetDataView1.FilterPopupMode = Syncfusion.WinForms.GridCommon.FilterPopupMode.AdvancedFilter;
            this.budgetDataView1.HoverText = null;
            this.budgetDataView1.Location = new System.Drawing.Point(195, 88);
            this.budgetDataView1.Name = "budgetDataView1";
            this.budgetDataView1.Numeric = BudgetExecution.Numeric.NS;
            this.budgetDataView1.Setting = null;
            this.budgetDataView1.ShowBusyIndicator = true;
            this.budgetDataView1.ShowGroupDropArea = true;
            this.budgetDataView1.ShowHeaderToolTip = true;
            this.budgetDataView1.ShowPreviewRow = true;
            this.budgetDataView1.ShowRowHeader = true;
            this.budgetDataView1.ShowToolTip = true;
            this.budgetDataView1.Size = new System.Drawing.Size(950, 550);
            this.budgetDataView1.TabIndex = 0;
            this.budgetDataView1.Text = "budgetDataView1";
            // 
            // BudgetDataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 764);
            this.Controls.Add(this.budgetDataView1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name = "BudgetDataViewForm";
            this.ShowIcon = false;
            this.Text = "Budget Execution";
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BudgetDataView budgetDataView1;
    }
}