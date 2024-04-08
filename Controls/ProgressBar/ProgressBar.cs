

using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace BudgetExecution 
{
    using System;
    using Syncfusion.Windows.Forms.Tools;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.ProgressBarAdv" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class ProgressBar : ProgressBarAdv
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgressBar" /> class.
        /// </summary>
        public ProgressBar( )
        {
            Font = new Font( "Roboto", 9, FontStyle.Bold );
            Border3DStyle = Border3DStyle.Flat;
            BorderStyle = BorderStyle.None;
            Size = new Size( 200, 18 );
            ForeColor = Color.FromArgb( 25, 75, 115 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            BorderColor = Color.FromArgb( 20, 20, 20 );
            FontColor = Color.White;
            ProgressOrientation = Orientation.Horizontal;
            BackgroundStyle = ProgressBarBackgroundStyles.MultipleGradient;
            ProgressStyle = ProgressBarStyles.Metro;
            TextAlignment = TextAlignment.Center;
            TextOrientation = Orientation.Horizontal;
            TextStyle = ProgressBarTextStyles.Percentage;
            Maximum = 100;
            Minimum = 0;
            SegmentWidth = 12;
            Step = 10;
            Value = 50;
            ForeSegments = false;
            BackSegments = false;
        }
    }
}
