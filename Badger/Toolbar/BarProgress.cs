// <copyright file = "BarProgress.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class BarProgress : BarProgressBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BarLabel"/>
        /// class.
        /// </summary>
        public BarProgress()
        {
            Margin = new Padding( 10, 5, 10, 0 );
            Size = new Size( 100, 33 );
            ForeColor = SystemColors.Highlight;
            BackColor = SystemColors.Control;
            Font = BudgetFont.FontSizeSmall;
            Style = ProgressBarStyle.Blocks;
            Visible = true;
            Enabled = true;
            Name = "Progress";
            Tag = Name;
            ToolTipText = Tag.ToString();
            HoverText = ToolTipText;
            MouseHover += OnMouseHover;
        }
        
        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = BudgetForm.GetField( field );
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
        public void SetTag( object tag )
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
        public void SetHoverText( string text )
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
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is BarProgress progress
                && Verify.IsInput( progress?.HoverText ) )
            {
                try
                {
                    if( Verify.IsInput( HoverText ) )
                    {
                        var text = progress?.HoverText;
                        var _ = new ToolTip( this, text );
                    }
                    else
                    {
                        if( Verify.IsInput( Tag?.ToString() ) )
                        {
                            var _ = new ToolTip( progress, Tag?.ToString()?.SplitPascal() );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}