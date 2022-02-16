// <copyright file = "BudgetCalendar.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
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
            Size = BudgetSize.GetSize( 497, 350 );
            Location = BudgetSetting.GetLocation();
            Font = BudgetFont.FontSizeSmall;
            Margin = BudgetSetting.Margin;
            ForeColor = BudgetColor.LightGray;
            Anchor = BudgetSetting.GetAnchorStyle();
            HighlightTodayCell = true;
            NumberOfWeeksInView = 5;
            FirstDayOfWeek = DayOfWeek.Sunday;
            ShowWeekNumbers = false;
            ShowToday = true;
            Style.BorderColor = BudgetColor.FormDark;
            Style.Cell.BlackoutDatesForeColor = BudgetColor.FormDark;
            ShowFooter = false;

            // Basic Cell Properties
            Style.Cell.CellFont = BudgetFont.FontSizeSmall;
            Style.Cell.CellBackColor = BudgetColor.FormDark;
            Style.Cell.CellForeColor = BudgetColor.SteelBlue;
            Style.Cell.CellHoverBorderColor = BudgetColor.SteelBlue;

            // SelectedCell Properties
            Style.Cell.SelectedCellFont = new Font( "Roboto", 9, FontStyle.Bold  );
            Style.Cell.SelectedCellBackColor = BudgetColor.SteelBlue;
            Style.Cell.SelectedCellForeColor = BudgetColor.White;
            Style.Cell.SelectedCellHoverBorderColor = BudgetColor.SteelBlue;

            // TodayCell Properties
            Style.Cell.SelectedCellFont = new Font( "Roboto", 9, FontStyle.Bold );
            Style.Cell.SelectedCellBackColor = BudgetColor.SteelBlue;
            Style.Cell.SelectedCellForeColor = BudgetColor.White;
            Style.Cell.SelectedCellHoverBorderColor = BudgetColor.SteelBlue;

            //TrailingCell Properties
            Style.Cell.TrailingCellFont = new Font( "Roboto", 9, FontStyle.Regular );
            Style.Cell.TrailingCellBackColor = BudgetColor.FormDark;
            Style.Cell.TrailingCellForeColor = BudgetColor.FormDark;

            // TodayCell Properties
            Style.Cell.TodayFont = new Font( "Roboto", 10, FontStyle.Bold );
            Style.Cell.TodayBackColor = BudgetColor.SteelBlue;
            Style.Cell.TodayForeColor = BudgetColor.White;
            Style.Cell.TodayHoverBorderColor = BudgetColor.SteelBlue;

            // Header Properties
            Style.Header.BackColor = BudgetColor.FormDark;
            Style.Header.ForeColor = BudgetColor.SteelBlue;
            Style.Header.Font = new Font( "Roboto", 14, FontStyle.Bold );
            Style.Header.DayNamesBackColor = BudgetColor.FormDark;
            Style.Header.DayNamesFont = new Font( "Roboto", 10, FontStyle.Bold );
            Style.Header.DayNamesForeColor = BudgetColor.SteelBlue;
            Style.Header.HoverForeColor = BudgetColor.White;
            Style.Header.NavigationButtonDisabledForeColor = BudgetColor.FormDark;
            Style.Header.NavigationButtonHoverForeColor = BudgetColor.White;
            Style.Header.NavigationButtonForeColor = BudgetColor.SteelBlue;
            Style.HorizontalSplitterColor = BudgetColor.WindowFrame;
            Style.VerticalSplitterColor = BudgetColor.WindowFrame;
            
            Visible = true;
            Enabled = true;
        }
    }
}
