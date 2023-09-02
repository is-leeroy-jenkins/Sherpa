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
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms.Grid.Grouping;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Grid.GridControl" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class GridControl : Syncfusion.Windows.Forms.Grid.GridControl
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.GridControl" /> class.
        /// </summary>
        public GridControl( )
        {
            // Control Properties
            Font = new Font( "Roboto", 9 );
            Size = new Size( 750, 350 );
            ThemesEnabled = true;
            GridVisualStyles = GridVisualStyles.Office2016DarkGray;
            DefaultColWidth = 100;
            DefaultRowHeight = 28;
            RowCount = 100;
            ColCount = 50;
            DefaultGridBorderStyle = GridBorderStyle.Dotted;
            ColorStyles = ColorStyles.Office2016DarkGray;
            ForeColor = Color.LightGray;
            Office2016ScrollBars = true;
            SizeGripStyle = SizeGripStyle.Hide;
            GridLineColor = Color.FromArgb( 106, 189, 252 );
        }
    }
}