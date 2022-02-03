// <copyright file = "ControlBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract partial class ControlBase : ControlData, IDataControl
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ControlBase"/> class.
        /// </summary>
        public ControlBase()
        {
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.ForeColorGray;
            BorderStyle = BorderStyle.FixedSingle;
            DoubleBuffered = true;
            AutoScaleMode = AutoScaleMode.Dpi;
            Padding = BudgetControl.Padding;
            Margin = BudgetControl.Margin;
            Font = BudgetFont.FontSizeSmall;
        }
        
        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="control">The control.</param>
        public virtual void SetParent( Control control )
        {
            try
            {
                Parent = BudgetControl.GetParent( control );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void SetSize( int width, int height )
        {
            try
            {
                Size = BudgetControl.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void SetLocation( int x = 1, int y = 1 )
        {
            try
            {
                Location = BudgetControl.GetLocation( x, y );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="size">The size.</param>
        /// <param name="style">The style.</param>
        public virtual void SetFont( string family = "Roboto", int size = 8, FontStyle style = FontStyle.Regular )
        {
            try
            {
                Font = BudgetFont.GetFont( family, size, style );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = BudgetColor.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetForeColor( Color color )
        {
            try
            {
                ForeColor = BudgetColor.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    Text = BudgetControl.GetText( text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public virtual void SetAnchorStyle( AnchorStyles anchor )
        {
            try
            {
                Anchor = BudgetControl.GetAnchorStyle( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public virtual void SetDockStyle( DockStyle dock )
        {
            try
            {
                Dock = BudgetControl.GetDockStyle( dock );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public virtual void SetTag( object tag )
        {
            try
            {
                Tag = BudgetControl.GetTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetHoverText( string text )
        {
            try
            {
                HoverText = BudgetControl.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            if( sender is Control control
                && Verify.IsInput( control?.Tag?.ToString() ) )
            {
                try
                {
                    var _ = BudgetControl.GetToolTip( control, control?.Tag?.ToString() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
            else if( Verify.IsInput( HoverText ) )
            {
                try
                {
                    var _ = BudgetControl.GetToolTip( this, HoverText );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}