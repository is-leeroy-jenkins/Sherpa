// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IToolStrip.cs" company="Terry D. Eppler">
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
//   IToolStrip.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary> </summary>
    public interface IToolStrip
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Gets the buttons. </summary>
        /// <value> The buttons. </value>
        IDictionary<string, ToolStripButton> Buttons { get; }

        /// <summary> Gets or sets the size of the image. </summary>
        /// <value> The size of the image. </value>
        Size ImageSize { get; set; }

        /// <summary> Gets or sets the size of the image scaling. </summary>
        /// <value> The size of the image scaling. </value>
        Size ImageScalingSize { get; set; }

        /// <summary> Gets or sets the tool strip ComboBox. </summary>
        /// <value> The tool strip ComboBox. </value>
        ToolStripDropDown DropDown { get; set; }

        /// <summary> Gets or sets the tool strip text box. </summary>
        /// <value> The tool strip text box. </value>
        ToolStripTextBox TextBox { get; set; }
    }
}