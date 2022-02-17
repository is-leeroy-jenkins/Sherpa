// <copyright file = "BudgetProgressBar.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ProgressBarBase" />
    public class BudgetProgressBar : ProgressBarBase
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
        /// Initializes a new instance of
        /// the <see cref="BudgetProgressBar"/> class.
        /// </summary>
        public BudgetProgressBar()
        {
            // Basic Properties
            Size = BudgetSize.LabelControl;
            ProgressStyle = ProgressBarStyles.Metro;
            Font = new Font( "Robot", 10  );
            Maximum = 100;
            Anchor = AnchorStyles.Left & AnchorStyles.Top;
            BackColor = Color.FromArgb( 10, 10, 10 );
            BackgroundStyle = ProgressBarBackgroundStyles.Gradient;
            ProgressOrientation = Orientation.Horizontal;
            BorderStyle = BorderStyle.FixedSingle;
            BorderColor = Color.SteelBlue;
            FontColor = Color.White;
            ProgressFallbackStyle = ProgressBarStyles.Metro;
            SegmentWidth = 12;
            Step = 10;
            TextAlignment = TextAlignment.Center;
            TextOrientation = Orientation.Horizontal;
            TextStyle = ProgressBarTextStyles.Percentage;
            ThemeName = "Metro";
            Text = string.Empty;
            Value = 0;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetProgressBar( Size size, Point location )
            : this()
        {
            Size = size;
            Location = BudgetSetting.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name = "start" > </param>
        public BudgetProgressBar( Size size, Point location, int start )
            : this( size, location )
        {
            Size = size;
            Location = BudgetSetting.GetLocation( location );
            Value = start;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="progressBar">The progressBar.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public BudgetProgressBar( BudgetProgressBar progressBar )
            : this( progressBar.Size, progressBar.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetProgressBar( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = BudgetSetting.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text.</param>
        public BudgetProgressBar( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="bindingSource">The bindingSource.</param>
        public BudgetProgressBar( Size size, Point location, Control parent,
            BudgetBinding bindingSource )
            : this( size, location, parent )
        {
            BindingSource = bindingSource;
        }
        
        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    var _ = new ToolTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Shows the percentage.
        /// </summary>
        /// <param name="value">The value.</param>
        public void UpdateValue( int value )
        {
            if( value > 0 
               && value < 100 )
            {
                try
                {
                    TextStyle = ProgressBarTextStyles.Percentage;
                    Value = value;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
