// // <copyright file = "BudgetClock.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetClock : ClockBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetClock"/> class.
        /// </summary>
        public BudgetClock()
        {
            BackColor = ColorConfig.FormBackColorDark;
            BorderColor = BackColor;
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            ClockShape = ClockShapes.Rectangle;
            ClockType = ClockTypes.Digital;
            DisplayDates = true;
            Now = DateTime.Now;
            ShowBorder = false;
            ShowClockFrame = false;
            ShowHourDesignator = true;
            ShowMinute = true;
            ShowSecondHand = true;
            HourHandColor = ColorConfig.ForeColorGray;
            MinuteColor = ColorConfig.ForeColorGray;
            SecondHandColor = ColorConfig.ForeColorGray;
            VisualStyle = ClockVisualStyle.None;
            Location = ControlConfig.GetLocation();
            Dock = ControlConfig.GetDockStyle();
            Anchor = ControlConfig.GetAnchorStyle();
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetClock" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetClock( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetClock" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public BudgetClock( Point location, Size size, Control parent )
            : this( size, location )
        {
            Parent = ControlConfig.GetParent( parent );
        }

    }
}
