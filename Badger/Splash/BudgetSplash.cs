// <copyright file = "BudgetSplash.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetSplash : SplashBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSplash"/> class.
        /// </summary>
        /// <remarks>
        /// The default value for the
        /// <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" />
        /// is set to
        /// The splash panel has animation turned and by default will appear in the
        /// middle of the screen.
        /// </remarks>
        public BudgetSplash()
        {
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Font = BudgetFont.FontSizeSmall;
            Size = new Size( 300, 150 );
            BorderStyle = Border3DStyle.Flat;

            BackgroundColor = new BrushInfo( GradientStyle.None, BudgetColor.FormDark, 
                BudgetColor.FormDark );

            ShowAnimation = true;
            AnimationSpeed = 10;
            AnimationSteps = 3;
            AnimationDirection = AnimationDirection.RightToLeft;
            DesktopAlignment = SplashAlignment.Center;
            DiscreetLocation = new Point( 0, 0 );
            Location = new Point( 16, 16 );
            SuspendAutoCloseWhenMouseOver = false;
            TabIndex = 0;
            TimerInterval = 5000;
            CloseOnClick = true;
            MarqueePosition = MarqueePosition.BottomRight;
            MarqueeDirection = SplashPanelMarqueeDirection.RightToLeft;
            SlideStyle = SlideStyle.FadeIn;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }

        public BudgetSplash( string message ) 
            : this()
        {
            Text = message;
        }
    }
}
