namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Gauge;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class CircularGuage : RadialGauge
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> Filter { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CircularGuage" /> class.
        /// </summary>
        public CircularGuage( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            EnableCustomNeedles = false;
            FillColor = Color.FromArgb( 0, 120, 212 );
            FrameThickness = 12;
            FrameType = FrameType.FullCircle;
            GaugeArcColor = Color.FromArgb( 0, 120, 212 );
            GaugeLableColor = Color.White;
            GaugeValueColor = Color.White;
            GaugeLabel = string.Empty;
            GaugeLableFont = new Font( "Roboto", 8 );
            MajorTickMarkColor = Color.FromArgb( 0, 120, 212 );
            MaximumValue = 100;
            MinorTickMarkColor = Color.Gray;
            NeedleColor = Color.FromArgb( 0, 120, 212 );
            NeedleStyle = NeedleStyle.Advanced;
            ArcThickness = 2;
            ScaleLabelColor = Color.White;
            ShowTicks = true;
            OuterFrameGradientStartColor = Color.FromArgb( 20, 20, 20 );
            OuterFrameGradientEndColor = Color.FromArgb( 20, 20, 20 );
            InnerFrameGradientEndColor = Color.FromArgb( 20, 20, 20 );
            InnerFrameGradientStartColor = Color.FromArgb( 20, 20, 20 );
            BackgroundGradientStartColor = Color.FromArgb( 20, 20, 20 );
            BackgroundGradientEndColor = Color.FromArgb( 20, 20, 20 );
        }

        /// <summary>
        /// Get Error Dialog for exceptions.
        /// </summary>
        /// <param name="ex">
        /// The exception.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
