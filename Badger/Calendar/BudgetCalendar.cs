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
            Size = new Size( 497, 350 );
            Location = new Point( 1, 1 );
            Font = new Font( "Roboto", 9 );
            Margin = new Padding( 3 );
            ForeColor = Color.LightGray;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            HighlightTodayCell = true;
            NumberOfWeeksInView = 5;
            FirstDayOfWeek = DayOfWeek.Sunday;
            ShowWeekNumbers = false;
            ShowToday = true;
            Style.BorderColor = Color.FromArgb( 10, 10, 10 );
            Style.Cell.BlackoutDatesForeColor = Color.FromArgb( 10, 10, 10 );
            ShowFooter = false;

            // Basic Cell Properties
            Style.Cell.CellFont = new Font( "Roboto", 9 );
            Style.Cell.CellBackColor = Color.FromArgb( 10, 10, 10 );
            Style.Cell.CellForeColor = Color.SteelBlue;
            Style.Cell.CellHoverBorderColor = Color.SteelBlue;

            // SelectedCell Properties
            Style.Cell.SelectedCellFont = new Font( "Roboto", 9, FontStyle.Bold  );
            Style.Cell.SelectedCellBackColor = Color.SteelBlue;
            Style.Cell.SelectedCellForeColor = Color.White;
            Style.Cell.SelectedCellHoverBorderColor = Color.SteelBlue;

            // TodayCell Properties
            Style.Cell.SelectedCellFont = new Font( "Roboto", 9, FontStyle.Bold );
            Style.Cell.SelectedCellBackColor = Color.SteelBlue;
            Style.Cell.SelectedCellForeColor = Color.White;
            Style.Cell.SelectedCellHoverBorderColor = Color.SteelBlue;

            //TrailingCell Properties
            Style.Cell.TrailingCellFont = new Font( "Roboto", 9, FontStyle.Regular );
            Style.Cell.TrailingCellBackColor = Color.FromArgb( 10, 10, 10 );
            Style.Cell.TrailingCellForeColor = Color.FromArgb( 10, 10, 10 );

            // TodayCell Properties
            Style.Cell.TodayFont = new Font( "Roboto", 10, FontStyle.Bold );
            Style.Cell.TodayBackColor = Color.SteelBlue;
            Style.Cell.TodayForeColor = Color.White;
            Style.Cell.TodayHoverBorderColor = Color.SteelBlue;

            // Header Properties
            Style.Header.BackColor = Color.FromArgb( 10, 10, 10 );
            Style.Header.ForeColor = Color.SteelBlue;
            Style.Header.Font = new Font( "Roboto", 14, FontStyle.Bold );
            Style.Header.DayNamesBackColor = Color.FromArgb( 10, 10, 10 );
            Style.Header.DayNamesFont = new Font( "Roboto", 10, FontStyle.Bold );
            Style.Header.DayNamesForeColor = Color.SteelBlue;
            Style.Header.HoverForeColor = Color.White;
            Style.Header.NavigationButtonDisabledForeColor = Color.FromArgb( 10, 10, 10 );
            Style.Header.NavigationButtonHoverForeColor = Color.White;
            Style.Header.NavigationButtonForeColor = Color.SteelBlue;
            Style.HorizontalSplitterColor = BudgetColor.WindowFrame;
            Style.VerticalSplitterColor = BudgetColor.WindowFrame;
            
            Visible = true;
            Enabled = true;
        }
    }
}
