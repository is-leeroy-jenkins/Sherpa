// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IToolStripComboBox.cs" company="Terry D. Eppler">
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
//   IToolStripComboBox.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary> </summary>
    public interface IToolStripComboBox
    {
        /// <summary> Sets the data source. </summary>
        /// <param name = "bindingSource" > The bindingSource. </param>
        void SetDataSource( BindingSource bindingSource );

        /// <summary> Called when [mouse over]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnMouseHover( object sender, EventArgs e );

        /// <summary> Called when [item selected]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        void OnItemSelected( object sender, EventArgs e );

        /// <summary> Sets the font. </summary>
        /// <param name = "font" > The font. </param>
        void SetFont( Font font );

        /// <summary> Sets the color of the fore. </summary>
        /// <param name = "color" > The color. </param>
        void SetForeColor( Color color );

        /// <summary> Sets the color of the back. </summary>
        /// <param name = "color" > The color. </param>
        void SetBackColor( Color color );

        /// <summary> Sets the field. </summary>
        /// <param name = "field" > The field. </param>
        void SetField( Field field );

        /// <summary> Sets the hover text. </summary>
        /// <param name = "item" > The item. </param>
        void SetHoverText( ToolStripItem item );

        /// <summary> Sets the hover text. </summary>
        /// <param name = "text" > The text. </param>
        void SetHoverText( string text );
    }
}