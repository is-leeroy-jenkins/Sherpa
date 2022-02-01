// <copyright file = "ChartForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Configuration;
    using DocumentFormat.OpenXml.Spreadsheet;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public partial class ChartForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public NameValueCollection BudExConfig { get; set; }  = ConfigurationManager.AppSettings;

        public ChartForm()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = ColorConfig.FormBackColorDark;
            BorderThickness = BorderConfig.Thin;
            BorderColor = ColorConfig.BorderColorBlue;
            Size = SizeConfig.FormSizeNormal;
            Font = FontConfig.FontSizeSmall;
            CaptionBarColor = ColorConfig.FormBackColorDark;
            CaptionBarHeight = SizeConfig.CaptionSizeNormal;
            CaptionButtonColor = ColorConfig.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = ColorConfig.CaptionButtonHoverColor;
            CaptionAlign = AlignConfig.HorizontalLeft;
            CaptionFont = FontConfig.FontSizeMedium;
            MetroColor = ColorConfig.FormBackColorDark;
            FormBorderStyle = BorderConfig.Sizeable;
            Icon = new Icon( BudExConfig[ "BudgetExecutionIcon" ], 32, 30 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
            MinimumSize = SizeConfig.FormSizeMinimum;
            MaximumSize = SizeConfig.FormSizeMaximum;

            // Chart Property Values
            Chart.Size = SizeConfig.ChartSizeNormal;
            Chart.Name = "Chart";
            Chart.BackColor = ColorConfig.FormBackColorDark;
            Chart.ForeColor = ColorConfig.ForeColorLightGray;
            Chart.Font = FontConfig.FontSizeSmall;
            Chart.BorderAppearance.BaseColor = ColorConfig.ColorTransparent;
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
