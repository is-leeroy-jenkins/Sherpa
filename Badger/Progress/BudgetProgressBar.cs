// // <copyright file = "BudgetProgressBar.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
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
        /// Initializes a new instance of
        /// the <see cref="BudgetProgressBar"/> class.
        /// </summary>
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
            Value = 0;
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
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
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
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
            Value = start;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetProgressBar" />
        /// class.
        /// </summary>
        /// <param name="progressBar">The progressBar.</param>
        [SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
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
            Parent = BudgetControl.GetParent( parent );
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
