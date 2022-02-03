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

    public partial class BadgerMain : FormBase
    {
        public BadgerMain()
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
            Icon = new Icon( BudgetForm.BudgetExecutionIcon, 32, 33 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
            MinimumSize = BudgetSize.FormSizeMinimum;
            MaximumSize = BudgetSize.FormSizeMaximum;
            TestButton.BackColor = BudgetColor.ForeColorBlack;
        }
    }
}
