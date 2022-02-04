// // <copyright file = "BudgetProgressBar.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetProgressBar : ProgressBarBase
    {
        public BudgetProgressBar()
        {
            // Basic Properties
            Size = BudgetSize.GetSize( 400, 23 );
            ProgressStyle = ProgressBarStyles.Metro;
            Font = new Font( "Robot", 10  );
            Maximum = 100;
            Anchor = AnchorStyles.Left & AnchorStyles.Top;
            BackColor = BudgetColor.FormDark;
            BackgroundStyle = ProgressBarBackgroundStyles.Gradient;
            ProgressOrientation = Orientation.Horizontal;
            BorderStyle = BorderStyle.FixedSingle;
            BorderColor = Color.SteelBlue;
            FontColor = BudgetColor.White;
            ProgressFallbackStyle = ProgressBarStyles.Metro;
            SegmentWidth = 12;
            Step = 10;
            TextAlignment = TextAlignment.Center;
            TextOrientation = Orientation.Horizontal;
            TextStyle = ProgressBarTextStyles.Percentage;
            ThemeName = "Metro";
            Text = string.Empty;
        }
    }
}
