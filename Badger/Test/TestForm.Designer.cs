// // <copyright file = "TestForm.Designer.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
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
            this.components = new System.ComponentModel.Container();
            this.Button = new BudgetExecution.BudgetButton();
            this.sfCalendar1 = new Syncfusion.WinForms.Input.SfCalendar();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.Button.BindingSource = null;
            this.Button.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.Button.Border.HoverVisible = true;
            this.Button.Border.Rounding = 6;
            this.Button.Border.Thickness = 1;
            this.Button.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.Button.Border.Visible = true;
            this.Button.DataFilter = null;
            this.Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button.Field = BudgetExecution.Field.NS;
            this.Button.Font = new System.Drawing.Font("Roboto", 10F);
            this.Button.ForeColor = System.Drawing.Color.LightGray;
            this.Button.HoverText = null;
            this.Button.Image = null;
            this.Button.Images = null;
            this.Button.Location = new System.Drawing.Point(1239, 715);
            this.Button.Margin = new System.Windows.Forms.Padding(0);
            this.Button.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(140, 40);
            this.Button.TabIndex = 0;
            this.Button.Text = "budgetButton1";
            this.Button.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Button.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Button.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.Button.TextStyle.Hover = System.Drawing.Color.White;
            this.Button.TextStyle.Pressed = System.Drawing.Color.White;
            this.Button.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Button.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Button.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Button.ToolTip = null;
            // 
            // sfCalendar1
            // 
            this.sfCalendar1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.HighlightTodayCell = true;
            this.sfCalendar1.Location = new System.Drawing.Point(537, 279);
            this.sfCalendar1.MinimumSize = new System.Drawing.Size(196, 196);
            this.sfCalendar1.Name = "sfCalendar1";
            this.sfCalendar1.NumberOfWeeksInView = 5;
            this.sfCalendar1.ShowToolTip = true;
            this.sfCalendar1.Size = new System.Drawing.Size(497, 350);
            this.sfCalendar1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Cell.BlackoutDatesFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Cell.CellFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Cell.CellForeColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.CellHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.SelectedCellFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.TodayBackColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.TodayFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Cell.TrailingCellFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Cell.TrailingCellForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sfCalendar1.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Cell.WeekNumberFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Footer.ForeColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Footer.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Header.DayNamesFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Header.DayNamesForeColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Header.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCalendar1.Style.Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Header.HoverForeColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sfCalendar1.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            this.sfCalendar1.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            this.sfCalendar1.Style.HorizontalSplitterColor = System.Drawing.SystemColors.WindowFrame;
            this.sfCalendar1.Style.VerticalSplitterColor = System.Drawing.SystemColors.WindowFrame;
            this.sfCalendar1.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 764);
            this.Controls.Add(this.sfCalendar1);
            this.Controls.Add(this.Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        public BudgetButton Button;
        public Syncfusion.WinForms.Input.SfCalendar sfCalendar1;
    }
}