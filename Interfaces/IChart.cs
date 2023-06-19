// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IChart.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   IChart.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary> </summary>
    public interface IChart
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        string HoverText { get; set; }

        /// <summary> Gets or sets the field. </summary>
        /// <value> The field. </value>
        Field Field { get; set; }

        /// <summary> Gets or sets the numeric. </summary>
        /// <value> The numeric. </value>
        Numeric Numeric { get; set; }

        /// <summary> Gets or sets the stat. </summary>
        /// <value> The stat. </value>
        STAT Stat { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        Source Source { get; set; }

        /// <summary> Gets or sets the data values. </summary>
        /// <value> The data values. </value>
        IDictionary<string, double> DataValues { get; set; }

        /// <summary> Gets or sets the data source. </summary>
        /// <value> The data source. </value>
        object DataSource { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Sets the points. </summary>
        void SetPoints( );

        /// <summary> Sets the primary axis titleInfo. </summary>
        /// <param name = "text" > The titleInfo. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > The color. </param>
        void SetPrimaryAxisTitle( string text, Font font, Color color );
    }
}