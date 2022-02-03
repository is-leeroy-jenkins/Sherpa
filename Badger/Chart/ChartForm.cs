// <copyright file = "ChartForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public partial class ChartForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the chart control.
        /// </summary>
        /// <value>
        /// The chart control.
        /// </value>
        public BudgetExecutionChart ExecutionChartControl { get; set; }
        
        public ChartForm()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = BudgetColor.FormBackColorDark;
            BorderThickness = BudgetBorder.Thin;
            BorderColor = BudgetColor.BorderColorBlue;
            Size = BudgetSize.FormSizeNormal;
            Font = BudgetFont.FontSizeSmall;
            CaptionBarColor = BudgetColor.FormBackColorDark;
            CaptionBarHeight = BudgetSize.CaptionSizeNormal;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.CaptionButtonHoverColor;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            CaptionFont = BudgetFont.FontSizeMedium;
            MetroColor = BudgetColor.FormBackColorDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( ExecutionChartControl.AppSetting[ "BudgetExecutionIcon" ], 32, 30 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
            MinimumSize = BudgetSize.FormSizeMinimum;
            MaximumSize = BudgetSize.FormSizeMaximum;

            // Chart Property Values
            Chart.Size = BudgetSize.ChartSizeNormal;
            Chart.Name = "Chart";
            Chart.BackColor = BudgetColor.FormBackColorDark;
            Chart.ForeColor = BudgetColor.ForeColorLightGray;
            Chart.Font = BudgetFont.FontSizeSmall;
            Chart.BorderAppearance.BaseColor = BudgetColor.ColorTransparent;
            Chart.RealMode3D = true;
            Chart.Series3D = true;
            Chart.Depth = 100;
            Chart.EnableMouseRotation = true;
            Chart.Rotation = 10;
            Chart.Tilt = 5;
            Chart.Palette = ChartColorPalette.Metro;
        }
    }
}
