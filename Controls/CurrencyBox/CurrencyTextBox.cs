//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                CurrencyTextBox.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="CurrencyTextBox.cs" company="Terry D. Eppler">
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
//    CurrencyTextBox.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.CurrencyBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class CurrencyTextBox : CurrencyEdit
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CurrencyTextBox"/>
        /// class.
        /// </summary>
        /// <remarks>
        /// The CurrencyEdit class also creates the controls that it hosts such as the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.CurrencyTextBox"/>
        /// control and the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.PopupCalculator"/>
        /// control.
        /// </remarks>
        public CurrencyTextBox( )
        {
            // Basic Properties
            TextBox.Size = new Size( 180, 23 );
            Margin = new Padding( 3 );
            Padding = new Padding( 0 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Enabled = true;
            Visible = true;
            FlatStyle = FlatStyle.Flat;
            Border3DStyle = Border3DStyle.Flat;
            FlatBorderColor = Color.FromArgb( 45, 45, 45 );
            PopupCalculatorAlignment = CalculatorPopupAlignment.Right;
            ShowCalculator = true;
            TextAlign = HorizontalAlignment.Center;
            ButtonStyle = ButtonAppearance.Office2010;
            UseVisualStyle = false;
            MetroColor = Color.FromArgb( 45, 45, 45 );
            CalculatorLayoutType = CalculatorLayoutTypes.Financial;

            // TextBox Properties
            TextBox.Size = new Size( 180, 23 );
            TextBox.Style = TextBoxExt.theme.Office2016Black;
            TextBox.CurrencyDecimalDigits = 2;
            TextBox.NegativeColor = Color.Red;
            TextBox.PositiveColor = Color.FromArgb( 106, 189, 252 );
            TextBox.BackGroundColor = Color.FromArgb( 45, 45, 45 );
            TextBox.Border3DStyle = Border3DStyle.Flat;
            TextBox.BorderColor = Color.FromArgb( 45, 45, 45 );
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Office2010ColorScheme = Office2010Theme.Black;
            TextBox.CurrencyDecimalSeparator = ".";
            TextBox.CurrencyGroupSeparator = ",";
            TextBox.FocusBorderColor = Color.FromArgb( 0, 120, 212 );
            TransferFromCalculator = true;
            TransferToCalculator = true;

            // TextBox ThemeStyle Properties
            ThemeStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.BorderColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.DisabledBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.HoverBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.FocusedBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.PressedBorderColor = Color.FromArgb( 0, 120, 212 );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}