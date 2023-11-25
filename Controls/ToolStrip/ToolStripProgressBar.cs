//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ToolStripProgressBar.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ToolStripProgressBar.cs" company="Terry D. Eppler">
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
//    ToolStripProgressBar.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ToolStripProgressBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class ToolStripProgressBar : ToolStripProgressBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ToolStripProgressBar" />
        /// class.
        /// </summary>
        public ToolStripProgressBar( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            Size = new Size( 200, 22 );
            ForeColor = SystemColors.Highlight;
            BackColor = SystemColors.Control;
            Font = new Font( "Roboto", 9 );
            Visible = true;
            Enabled = true;
            Name = "ProgressBar";
            Maximum = 100;
            Minimum = 1;
            Tag = Name;
            ToolTipText = Tag.ToString( );
            HoverText = ToolTipText;
            Style = ProgressBarStyle.Blocks;
            Step = 10;
            MouseHover += OnMouseHover;
        }

        /// <summary>
        /// Increases the by.
        /// </summary>
        /// <param name="increment">The increment.</param>
        public void IncreaseBy( int increment )
        {
            if( increment > 0 )
            {
                try
                {
                    Increment( increment );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Progresses the by step.
        /// </summary>
        /// <param name="step">The step.</param>
        public void ProgressByStep( int step = 10 )
        {
            try
            {
                Step = step;
                PerformStep( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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
                HoverText = string.IsNullOrEmpty( text )
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
            if( sender is ToolStripProgressBar _progress
               && ( _progress != null ) )
            {
                try
                {
                    var _text = _progress?.HoverText;
                    if( !string.IsNullOrEmpty( _text ) )
                    {
                        var _ = new SmallTip( this, _text );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) )
                           && !string.IsNullOrEmpty( Tag.ToString( ) ) )
                        {
                            var _ = new SmallTip( _progress, Tag?.ToString( )?.SplitPascal( ) );
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