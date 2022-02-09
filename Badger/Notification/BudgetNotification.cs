// <copyright file = "BudgetNotification.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetNotification : SplashPanel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetNotification"/> class.
        /// </summary>
        /// <remarks>
        /// The default value for the <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" /> is set to
        /// The splash panel has animation turned and by default will appear in the
        /// middle of the screen.
        /// </remarks>
        public BudgetNotification()
        {
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Font = BudgetFont.FontSizeSmall;
            BorderStyle = Border3DStyle.Flat;
            BackgroundColor = new BrushInfo( GradientStyle.PathRectangle, BudgetColor.FormDark, BudgetColor.ControlInteriorDark );
            ShowAnimation = true;
            AnimationSpeed = 10;
            AnimationSteps = 3;
            AnimationDirection = AnimationDirection.RightToLeft;
            DesktopAlignment = SplashAlignment.RightBottom;
            DiscreetLocation = new Point( 0, 0 );
            Location = new Point( 16, 16 );
            SuspendAutoCloseWhenMouseOver = false;
            TabIndex = 0;
            TimerInterval = 5000;
            CloseOnClick = true;
            MarqueePosition = MarqueePosition.BottomRight;
            MarqueeDirection = SplashPanelMarqueeDirection.RightToLeft;
            SlideStyle = SlideStyle.FadeIn;
            Text = string.Empty;
        }
    }
}
