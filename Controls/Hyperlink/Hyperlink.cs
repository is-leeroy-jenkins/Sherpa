//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                Hyperlink.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Hyperlink.cs" company="Terry D. Eppler">
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
//    Hyperlink.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using System.Diagnostics.CodeAnalysis;
    using MetroSet_UI.Enums;

    /// <summary> </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetLink"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class Hyperlink : MetroSetLink
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Hyperlink"/>
        /// class.
        /// </summary>
        public Hyperlink( )
        {
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            LinkColor = Color.FromArgb( 0, 120, 212 );
            LinkBehavior = LinkBehavior.AlwaysUnderline;
            Size = new Size( 100, 30 );
            TextAlign = ContentAlignment.MiddleLeft;
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Hyperlink"/>
        /// class.
        /// </summary>
        /// <param name="text"> The text displayed by the control. </param>
        public Hyperlink( string text )
            : this( )
        {
            Text = text;
        }
    }
}