// <copyright file = "BarLabel.cs" company = "Terry D. Eppler">
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
    public class BudgetToolStripLabel : ToolStripLabelBase, IToolStripLabel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetToolStripLabel"/>
        /// class.
        /// </summary>
        public BudgetToolStripLabel()
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            Size = new Size( 150, 23 );
            ForeColor = Color.White;
            BackColor = Color.FromArgb( 45, 45, 45 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            Visible = true;
            Enabled = true;
            Tag = Name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStripLabel"/> class.
        /// </summary>
        /// <param name="text">The text to display
        /// on the <see cref="T:System.Windows.Forms.ToolStripLabel" />.</param>
        public BudgetToolStripLabel( string text )
            : this()
        {
            Text = text;
            MouseHover += OnMouseHover;
        }
        
        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "color" > The color. </param>
        public void SetText( string text, Color color )
        {
            try
            {
                ForeColor = color;
                Text = text;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "color" > The color. </param>
        /// <param name = "font" > The font. </param>
        public void SetText( string text, Color color, Font font )
        {
            try
            {
                Font = font;
                ForeColor = color;
                Text = text;
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
        /// <param name="e">The
        /// <see cref="EventArgs" /> instance
        /// containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is BudgetToolStripLabel _label
                && Verify.IsInput( _label?.HoverText ) )
            {
                try
                {
                    if( Verify.IsInput( HoverText ) )
                    {
                        var _text = _label?.HoverText;
                        var _ = new ToolTip( this, _text );
                    }
                    else
                    {
                        if( Verify.IsInput( Tag?.ToString() ) )
                        {
                            var _ = new ToolTip( _label, Tag?.ToString()?.SplitPascal() );
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