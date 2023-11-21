//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                SplashPanel.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SplashPanel.cs" company="Terry D. Eppler">
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
//    SplashPanel.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Drawing;
    using System.Threading;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.SplashPanel" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class SplashPanel : Syncfusion.Windows.Forms.Tools.SplashPanel
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SplashPanel" /> class.
        /// </summary>
        /// <remarks>
        /// The default value for the
        /// <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" /> is set to
        /// 5000 milliseconds.
        /// The splash panel has animation turned and by default will appear in the
        /// middle of the screen.
        /// </remarks>
        public SplashPanel( )
        {
            // Control Properties
            Size = new System.Drawing.Size( 200, 100 );
            Font = new System.Drawing.Font( "Roboto", 9 );
            BackgroundColor = new BrushInfo( Syncfusion.Drawing.GradientStyle.PathEllipse,
                System.Drawing.Color.FromArgb( 20, 20, 20 ), System.Drawing.Color.FromArgb( 70, 70, 70 ) );

            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
        }
    }
}