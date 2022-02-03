// <copyright file = "BudgetCalendar.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;

    public class BudgetCalendar : CalendarBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetCalendar"/> class.
        /// </summary>
        public BudgetCalendar()
        {
            Size = BudgetSize.GetSize( 530, 375 );
            Location = BudgetControl.GetLocation();
            Font = BudgetFont.FontSizeSmall;
            Margin = BudgetControl.Margin;
            ForeColor = BudgetColor.ForeColorGray;
            BackColor = BudgetColor.FormDark;
            Dock = BudgetControl.GetDockStyle();
            Anchor = BudgetControl.GetAnchorStyle();
            Visible = true;
            Enabled = true;
            Style = VisualStyle.Office2010;
            Office2010Theme = Office2010Theme.Blue;
            Border3DStyle = Border3DStyle.Flat;
            BorderColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            FirstDayOfWeek = Day.Monday;
            BottomHeight = 30;
            DayNamesColor = BudgetColor.FormDark;
            DayNamesFont = new Font( "Roboto", 10, FontStyle.Bold );
            DaysFont = BudgetFont.FontSizeMedium;
            DaysColor = BudgetColor.FormDark;
            DaysHeaderInterior = new BrushInfo( SystemColors.ControlDark );
            HeadForeColor = Color.White;
            HeaderHeight = 40;
            HeadGradient = false;
            HeaderFont = new Font( "Roboto", 12, FontStyle.Bold );
            HeaderStartColor = Color.FromArgb( 70, 70, 70 );
        }
    }
}
