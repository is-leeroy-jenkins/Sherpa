// <copyright file = "ToolTip.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using MetroSet_UI.Components;
    using MetroSet_UI.Design;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Components.MetroSetToolTip" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "IsExpressionAlwaysTrue" ) ]
    public class ToolTip : MetroSetToolTip
    {
        /// <summary>
        /// Gets or sets the tip icon.
        /// </summary>
        /// <value>
        /// The tip icon.
        /// </value>
        public ToolTipIcon TipIcon { get; set; } = ToolTipIcon.Info;

        /// <summary>
        /// Gets or sets the tip title.
        /// </summary>
        /// <value>
        /// The tip title.
        /// </value>
        public string TipTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        public ToolTip()
        {
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Style = Style.Custom;
            BackColor = ColorConfig.FormDarkBackColor;
            BorderColor = ColorConfig.BorderYellow;
            ForeColor = ColorConfig.ForeGray;
            UseAnimation = true;
            UseFading = true;
            AutomaticDelay = 500;
            InitialDelay = 500;
            AutoPopDelay = 5000;
            ReshowDelay = 100;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        public ToolTip( Control control, string text )
            : this()
        {
            SetToolTipText( control, text );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        public ToolTip( Component component, string text )
            : this()
        {
            SetToolTipText( component, text );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="toolitem">The toolitem.</param>
        public ToolTip( ToolStripItem toolitem )
            : this()
        {
            SetToolTipText( toolitem );
        }

        /// <summary>
        /// Sets the animation.
        /// </summary>
        /// <param name="animate">if set to <c>true</c> [animate].</param>
        public void SetAnimation( bool animate )
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
        public void SetAutomaticDelay( int delay = 500 )
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
        public void SetDuration( int time = 5000 )
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
        public void SetInitialDelay( int delay = 500 )
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
        public void SetReshowDelay( int reshow = 100 )
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
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            if( Validate.Field( field ) )
            {
                try
                {
                    Field = field;
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
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="control">The control.</param>
        public void SetToolTipText( Control control )
        {
            if( Verify.IsInput( control?.Tag?.ToString() ) )
            {
                try
                {
                    RemoveAll();
                    var caption = control.Tag.ToString();
                    SetToolTip( control, caption );
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
        public void SetToolTipText( Control control, string caption )
        {
            if( control != null
                && Verify.IsInput( caption ) )
            {
                try
                {
                    RemoveAll();
                    SetToolTip( control, caption );
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
        public void SetToolTipText( ToolStripItem item )
        {
            if( item.GetCurrentParent() != null
                && item is Component )
            {
                try
                {
                    Control parent = item.GetCurrentParent();
                    var caption = item?.Tag?.ToString();

                    if( Verify.IsInput( caption ) )
                    {
                        RemoveAll();
                        SetToolTipText( parent, caption );
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
        public void SetToolTipText( Component component )
        {
            if( component != null
                && component is Control control )
            {
                try
                {
                    if( Verify.IsInput( control?.Tag?.ToString() ) )
                    {
                        var caption = control.Tag.ToString();
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
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="caption">The caption.</param>
        public void SetToolTipText( Component component, string caption )
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