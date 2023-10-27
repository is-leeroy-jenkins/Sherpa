//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ToolStripLabel.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ToolStripLabel.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    ToolStripLabel.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ToolStripLabel : ToolStripLabelBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripLabel"/>
        /// class.
        /// </summary>
        public ToolStripLabel( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            Size = new Size( 150, 23 );
            ForeColor = Color.Black;
            BackColor = Color.FromArgb( 45, 45, 45 );
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            Tag = Name;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripLabel"/>
        /// class.
        /// </summary>
        /// <param name="text">
        /// The text to display on the
        /// <see/>
        /// .
        /// </param>
        public ToolStripLabel( string text )
            : this( )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripLabel"/>
        /// class.
        /// </summary>
        /// <param name="text"> The text. </param>
        /// <param name="hoverText"> The hover text. </param>
        public ToolStripLabel( string text, string hoverText = "" )
            : this( text )
        {
            HoverText = hoverText;
            MouseHover += OnMouseHover;
        }

        /// <summary> Sets the text. </summary>
        /// <param name="text"> The text. </param>
        /// <param name="color"> The color. </param>
        public void SetText( string text, Color color )
        {
            try
            {
                ForeColor = color != Color.Empty
                    ? color
                    : Color.Empty;

                Text = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the text. </summary>
        /// <param name="text"> The text. </param>
        /// <param name="font"> The font. </param>
        /// <param name="color"> The color. </param>
        public void SetText( string text, Color color, Font font )
        {
            try
            {
                Font = font ?? new Font( "Roboto", 9 );
                ForeColor = color != Color.Empty
                    ? color
                    : Color.Empty;

                Text = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the text. </summary>
        /// <param name="text"> The text. </param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [mouse hover]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is ToolStripLabel _label
               && !string.IsNullOrEmpty( _label?.HoverText ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _text = _label?.HoverText;
                        var _ = new SmallTip( this, _text );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new SmallTip( _label, _text );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}