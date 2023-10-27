//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ChartBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ChartBase.cs" company="Terry D. Eppler">
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
//    ChartBase.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:System.Windows.Forms.DataVisualization.Charting.Chart"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class ChartBase : System.Windows.Forms.DataVisualization.Charting.Chart
    {
        /// <summary> Sets the chart palette colors. </summary>
        protected void InitializePalette( )
        {
            try
            {
                var _blue = Color.FromArgb( 0, 120, 212 );
                var _lightBlue = Color.FromArgb( 180, 0, 120, 202 );
                var _maroon = Color.Maroon;
                var _red = Color.FromArgb( 255, 65, 84 );
                var _green = Color.FromArgb( 0, 64, 0 );
                var _darkGreen = Color.FromArgb( 150, 0, 64, 0 );
                var _palette = new[ ]
                {
                    _blue,
                    _lightBlue,
                    _maroon,
                    _red,
                    _green,
                    _darkGreen
                };

                PaletteCustomColors = _palette;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}