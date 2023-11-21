//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                GraphBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="GraphBase.cs" company="Terry D. Eppler">
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
//    GraphBase.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Chart.ChartControl"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public abstract class GraphBase : ChartControl
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Sets the area properties.
        /// </summary>
        private protected void SetAreaProperties( )
        {
            try
            {
                var _black = Color.FromArgb( 20, 20, 20 );
                var _gray = Color.FromArgb( 65, 65, 65 );
                var _transparent = Color.Transparent;
                var _blue = Color.FromArgb( 0, 120, 212 );
                var _darkBlue = Color.FromArgb( 24, 47, 66 );

                // General Area Properties

                // Horizontal Axis Properties

                // Vertical Axis Properties
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the title properties. </summary>
        private protected void SetTitleProperties( )
        {
            try
            {
                Titles[ 0 ].Font = new Font( "Roboto", 10, FontStyle.Bold );
                Titles[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                Titles[ 0 ].ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the legend. </summary>
        /// <param name="font"> The font. </param>
        /// <param name="size"> The size. </param>
        /// <param name="backColor"> Color of the back. </param>
        private protected void SetLegend( Font font, Size size, Color backColor )
        {
            try
            {
                ShowLegend = true;
                Legend.Font = font;
                Legend.ItemsSize = size;
                Legend.VisibleCheckBox = true;
                Legend.BackInterior = new BrushInfo( backColor );
                Legend.ItemsAlignment = StringAlignment.Center;
                Legend.ItemsTextAligment = VerticalAlignment.Center;
                Legend.Orientation = ChartOrientation.Vertical;
                Legend.FloatingAutoSize = true;
                Legend.ShowSymbol = true;
                Legend.ShowItemsShadow = true;
                Legend.ShowBorder = false;
                Legend.Visible = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the legend properties. </summary>
        /// <param name="i"> The i. </param>
        /// <param name="enabled">
        /// if set to
        /// <c> true </c>
        /// [enabled].
        /// </param>
        private protected void SetLegendProperties( int i = 0, bool enabled = false )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the series properties. </summary>
        /// <param name="i"> The i. </param>
        private protected void SetSeriesProperties( int i = 0 )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the chart palette colors. </summary>
        private protected void SetPaletteColors( )
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
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}