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
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    Text = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the numeric.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        public void SetNumeric( Numeric numeric )
        {
            if( Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    Numeric = numeric;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        public void ShowPercentage( int value )
        {
            if( value > 0 )
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
