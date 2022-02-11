// <copyright file = "InfoBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Components;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class InfoBase : VisualToolTip
    {
        /// <summary>
        /// Gets or sets the tip icon.
        /// </summary>
        /// <value>
        /// The tip icon.
        /// </value>
        public virtual ToolTipIcon TipIcon { get; set; } = ToolTipIcon.Info;

        /// <summary>
        /// Gets or sets the tip title.
        /// </summary>
        /// <value>
        /// The tip title.
        /// </value>
        public virtual string TipTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }
        
        /// <summary>
        /// Sets the animation.
        /// </summary>
        /// <param name="animate">if set to <c>true</c> [animate].</param>
        public virtual void SetAnimation( bool animate )
        {
            try
            {
                UseAnimation = animate;
                UseFading = animate;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the automatic delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public virtual void SetAutomaticDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    AutomaticDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the duration.
        /// </summary>
        /// <param name="time">The time.</param>
        public virtual void SetDuration( int time = 5000 )
        {
            if( time > 0 )
            {
                try
                {
                    AutoPopDelay = time;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the initial delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public virtual void SetInitialDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    InitialDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the reshow delay.
        /// </summary>
        /// <param name="reshow">The reshow.</param>
        public virtual void SetReshowDelay( int reshow = 100 )
        {
            if( reshow > 0 )
            {
                try
                {
                    ReshowDelay = reshow;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="control">The control.</param>
        public virtual void SetText( Control control )
        {
            if( Verify.IsInput( control?.Tag?.ToString() ) )
            {
                try
                {
                    RemoveAll();
                    var _caption = control?.Tag?.ToString();
                    Text = _caption;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="caption">The caption.</param>
        public virtual void SetText( Control control, string caption )
        {
            if( control != null
                && Verify.IsInput( caption ) )
            {
                try
                {
                    RemoveAll();
                    Text = caption;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="item">The item.</param>
        public virtual void SetText( ToolStripItem item )
        {
            if( item.GetCurrentParent() != null )
            {
                try
                {
                    RemoveAll();
                    var _caption = item?.Tag?.ToString();

                    if( Verify.IsInput( _caption ) )
                    {
                        Text = _caption;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="component">The component.</param>
        public virtual void SetText( Component component )
        {
            if( component != null
                && component is Control control )
            {
                try
                {
                    if( Verify.IsInput( control?.Tag?.ToString() ) )
                    {
                        Text = control?.Tag?.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="caption">The caption.</param>
        public virtual void SetText( Component component, string caption )
        {
            if( component != null
                && Verify.IsInput( caption ) )
            {
                try
                {
                    if( component is Control control )
                    {
                        RemoveAll();
                        SetToolTip( control, caption );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the information title text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetTitle( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    TipTitle = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
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
