﻿// <copyright file = "BudgetSplash.cs" company = "Terry D. Eppler">
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
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
            Size = new Size( 300, 150 );
            BorderStyle = Border3DStyle.Flat;
            BorderType = SplashBorderType.None;

            BackgroundColor = new BrushInfo( GradientStyle.None, Color.FromArgb( 18, 18, 18 ), 
                Color.FromArgb( 18, 18, 18 ) );

            ShowAnimation = true;
            ShowAsTopMost = true;
            AnimationSpeed = 10;
            AnimationSteps = 3;
            AnimationDirection = AnimationDirection.Default;
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
        }

        public BudgetSplash( string message ) 
            : this()
        {
            Text = message;
        }

        /// <summary>
        /// Displays the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.SplashPanel" />
        /// Splash panel.
        /// </summary>
        public void ShowMessage()
        {
            if( !string.IsNullOrEmpty( Text ) )
            {
                try
                {
                    ShowSplash();
                }
                catch ( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
