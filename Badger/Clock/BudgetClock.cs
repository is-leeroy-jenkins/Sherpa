// <copyright file = "BudgetClock.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetClock : ClockBase
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public override Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public override NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetClock"/> class.
        /// </summary>
        public BudgetClock()
        {
            BackColor = BudgetColor.FormDark;
            BorderColor = BackColor;
            ForeColor = BudgetColor.ForeColorGray;
            Font = BudgetFont.FontSizeSmall;
            Margin = BudgetControl.Margin;
            Padding = BudgetControl.Padding;
            ClockShape = ClockShapes.Rectangle;
            ClockType = ClockTypes.Digital;
            DisplayDates = true;
            Now = DateTime.Now;
            ShowBorder = false;
            ShowClockFrame = false;
            ShowHourDesignator = true;
            ShowMinute = true;
            ShowSecondHand = true;
            HourHandColor = BudgetColor.ForeColorGray;
            MinuteColor = BudgetColor.ForeColorGray;
            SecondHandColor = BudgetColor.ForeColorGray;
            VisualStyle = ClockVisualStyle.None;
            Location = BudgetControl.GetLocation();
            Dock = BudgetControl.GetDockStyle();
            Anchor = BudgetControl.GetAnchorStyle();
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
            Size = BudgetSize.GetSize( size.Width, size.Height );
            Location = BudgetControl.GetLocation( location.X, location.Y );
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
            Parent = BudgetControl.GetParent( parent );
        }
    }
}
