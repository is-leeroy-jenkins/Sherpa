// <copyright file = "ClockBase.cs" company = "Terry D. Eppler">
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
    /// <seealso cref="Clock" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public abstract class ClockBase : Clock, IClock
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Sets the color of the hour.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetHourColor( Color color )
        {
            if( color != null )
            {
                try
                {
                    if( ShowHourDesignator == false )
                    {
                        ShowHourDesignator = true;
                    }

                    HourHandColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the minute.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetMinuteColor( Color color )
        {
            if( color != null )
            {
                try
                {
                    if( ShowMinute == false )
                    {
                        ShowMinute = true;
                    }

                    MinuteColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the second.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetSecondColor( Color color )
        {
            if( color != null )
            {
                try
                {
                    if( ShowSecondHand == false )
                    {
                        ShowSecondHand = true;
                    }

                    SecondHandColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    if( ShowBorder == false )
                    {
                        ShowBorder = true;
                    }

                    BorderColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the clock frame.
        /// </summary>
        /// <param name="frame">The frame.</param>
        public virtual void SetClockFrame( ClockFrames frame = ClockFrames.RectangularFrame )
        {
            if( Enum.IsDefined( typeof( ClockFrames ), frame ) )
            {
                try
                {
                    if( ShowClockFrame == false )
                    {
                        ShowClockFrame = true;
                    }

                    ClockFrame = frame;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the clock style.
        /// </summary>
        /// <param name="style">The style.</param>
        public virtual void SetClockStyle( ClockVisualStyle style = ClockVisualStyle.OfficeBlack )
        {
            if( Enum.IsDefined( typeof( ClockVisualStyle ), style ) )
            {
                try
                {
                    VisualStyle = style;
                }
                catch( Exception e )
                {
                    Console.WriteLine( e );
                    throw;
                }
            }
        }

        /// <summary>
        /// Sets the time.
        /// </summary>
        public virtual void SetTime()
        {
            Now = DateTime.Now;
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            var _budgetClock = sender as BudgetClock;

            try
            {
                if( _budgetClock != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( Verify.IsInput( HoverText ) )
                    {
                        var _hoverText = _budgetClock?.HoverText;
                        var _ = new ToolTip( _budgetClock, _hoverText );
                    }
                    else
                    {
                        if( Verify.IsInput( Tag?.ToString() ) )
                        {
                            var _text = Tag?.ToString()?.SplitPascal();
                            var _ = new ToolTip( _budgetClock, _text );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.
        /// </param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            var _budgetClock = sender as BudgetClock;

            try
            {
                if( _budgetClock != null )
                {
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}