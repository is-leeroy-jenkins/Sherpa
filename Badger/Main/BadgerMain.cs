// <copyright file = "BadgerMain.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    public partial class BadgerMain : FormBase
    {
        public BadgerMain()
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
            Icon = new Icon( @"C:\Users\terry\source\repos\BudgetExecution\Etc\epa.ico", 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
            MinimumSize = SizeConfig.FormSizeMinimum;
            MaximumSize = SizeConfig.FormSizeMaximum;
        }
    }
}
