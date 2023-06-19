// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CurrencyBox.cs" company="Terry D. Eppler">
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
//   CurrencyBox.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.CurrencyBase"/>
    public class CurrencyBox : CurrencyBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CurrencyBox"/>
        /// class.
        /// </summary>
        /// <remarks>
        /// The CurrencyEdit class also creates the controls that it hosts such as the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.CurrencyTextBox"/>
        /// control and the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.PopupCalculator"/>
        /// control.
        /// </remarks>
        public CurrencyBox( )
        {
            // Basic Properties
            Size = new Size( 140, 30 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.White;
            Enabled = true;
            Visible = true;
            Text = string.Empty;
            Border3DStyle = Border3DStyle.Flat;
            PopupCalculatorAlignment = CalculatorPopupAlignment.Right;
            FlatStyle = FlatStyle.Flat;
            ShowCalculator = true;
            TextAlign = HorizontalAlignment.Center;

            // TextBox Properties
            TextBox.CurrencyDecimalDigits = 2;
            TextBox.NegativeColor = Color.Red;
            TextBox.PositiveColor = Color.LightSteelBlue;
            TextBox.BackGroundColor = Color.FromArgb( 30, 30, 30 );
            TextBox.Border3DStyle = Border3DStyle.Flat;
            TextBox.ThemeStyle = CurrencyTextBoxVisualStyle.DefaultStyle;
            TextBox.BorderColor = Color.FromArgb( 65, 65, 65 );
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.CurrencyDecimalSeparator = ".";
            TextBox.CurrencyGroupSeparator = ",";
            TextBox.FocusBorderColor = Color.FromArgb( 0, 120, 212 );
            TransferFromCalculator = true;
            TransferToCalculator = true;

            // TextBox ThemeStyle Properties
            ThemeStyle.BackColor = Color.FromArgb( 30, 30, 30 );
            ThemeStyle.BorderColor = Color.FromArgb( 65, 65, 65 );
            ThemeStyle.DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.HoverBorderColor = Color.FromArgb( 50, 93, 129 );
            ThemeStyle.FocusedBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.PressedBorderColor = Color.FromArgb( 0, 120, 212 );
        }
    }
}