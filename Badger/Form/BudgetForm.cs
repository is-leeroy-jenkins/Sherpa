// <copyright file = "BadgerMain.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;

    public partial class BudgetForm : FormBase
    {
        public BudgetForm()
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
            Icon = new Icon( FormConfig.BudgetExecutionIcon, 16, 16 );
            ShowIcon = true;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
            MinimumSize = SizeConfig.FormSizeMinimum;
            MaximumSize = SizeConfig.FormSizeMaximum;
        }
    }
}
