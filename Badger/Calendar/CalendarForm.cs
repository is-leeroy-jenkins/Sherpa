// <copyright file = "CalendarForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class CalendarForm : MetroForm
    {
        /// <summary>
        /// Gets the calendar.
        /// </summary>
        /// <value>
        /// The calendar.
        /// </value>
        public CalendarBase Calendar { get; } = new BudgetCalendar();

        public CalendarForm()
        {
            InitializeComponent();

            // Form properties
            BackColor = BudgetColor.FormBackColorDark;
            BorderThickness = BudgetBorder.Thin;
            BorderColor = BudgetColor.BorderColorBlue;
            Font = BudgetFont.FontSizeSmall;
            CaptionBarColor = BudgetColor.FormBackColorDark;
            CaptionBarHeight = BudgetSize.CaptionSizeNormal;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.CaptionButtonHoverColor;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            CaptionFont = BudgetFont.FontSizeMedium;
            MetroColor = BudgetColor.FormBackColorDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( @"C:\Users\terry\source\repos\BudgetExecution\Etc\epa.ico", 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
            MinimumSize = BudgetSize.FormSizeMinimum;
            MaximumSize = BudgetSize.FormSizeMaximum;
            Calendar.Dock = DockStyle.Fill;
            Size = new Size( Calendar.Size.Width + 5, Calendar.Size.Height + 5 );
            Controls.Add( Calendar );
        }
    }
}
