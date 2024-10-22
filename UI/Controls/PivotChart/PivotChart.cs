﻿//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                PivotChart.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="PivotChart.cs" company="Terry D. Eppler">
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
//    PivotChart.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.PivotChart;

    /// <inheritdoc/>
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.PivotChart.PivotChart"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class PivotChart : Syncfusion.Windows.Forms.PivotChart.PivotChart
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.PivotChart"/>
        /// class.
        /// </summary>
        public PivotChart( )
        {
            // Control Properties
            Size = new Size( 550, 350 );
            ShowPivotTableFieldList = false;
            AllowDrillDown = true;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            ChartTypes = PivotChartTypes.Column;
            PrimaryXAxis.Title.Color = Color.FromArgb( 0, 120, 212 );
            PrimaryXAxis.Title.Font = new Font( "Roboto", 9 );
            PrimaryYAxis.Title.Color = Color.FromArgb( 0, 120, 212 );
            PrimaryYAxis.Title.Font = new Font( "Roboto", 9 );
            AxisFieldSection.Visible = true;
            LegendFieldSection.Visible = false;
            ValueFieldSection.Visible = true;
            FilterFieldSection.Visible = true;
            AxisFieldSection.ItemBackColor = Color.FromArgb( 50, 93, 129 );
            AxisFieldSection.ItemForeColor = Color.White;
            AxisFieldSection.BackInterior = Color.FromArgb( 45, 45, 45 );
            CustomPalette = new[ ]
            {
                Color.FromArgb( 0, 120, 212 ),
                Color.SlateGray,
                Color.Yellow,
                Color.LimeGreen,
                Color.Maroon
            };
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}