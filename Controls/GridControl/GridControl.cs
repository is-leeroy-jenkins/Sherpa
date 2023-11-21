//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                GridControl.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="GridControl.cs" company="Terry D. Eppler">
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
//    GridControl.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Grid.GridControl"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class GridControl : Syncfusion.Windows.Forms.Grid.GridControl
    {
        /// <summary> The grid information </summary>
        public readonly GridStyleInfo GridStyle = new GridStyleInfo ( );

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.GridControl"/>
        /// class.
        /// </summary>
        public GridControl( )
        {
            // Control Properties
            Font = new Font( "Roboto", 9 );
            Size = new Size( 750, 350 );
            ThemesEnabled = true;
            CanApplyTheme = true;
            GridVisualStyles = GridVisualStyles.Office2016DarkGray;
            CanOverrideStyle = true;
            DefaultColWidth = 150;
            DefaultRowHeight = 22;
            RowCount = 100;
            ColCount = 50;
            DefaultGridBorderStyle = GridBorderStyle.Dotted;
            GridLineColor = Color.FromArgb( 120, 120, 120 );
            ColorStyles = ColorStyles.Office2016DarkGray;
            ForeColor = Color.FromArgb( 106, 189, 252 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            Office2016ScrollBars = true;
            SizeGripStyle = SizeGripStyle.Hide;
            GridStyle.BackColor = Color.FromArgb( 60, 60, 60 );
            GridStyle.Interior 
                = new Syncfusion.Drawing.BrushInfo( Syncfusion.Drawing.GradientStyle.None, ForeColor,
                    Color.FromArgb( 60, 60, 60 ) );

            RangeStyles[ 0 ].StyleInfo = GridStyle;
            BaseStylesMap[ "Row Header" ].StyleInfo.HorizontalAlignment =
                GridHorizontalAlignment.Center;
        }
    }
}