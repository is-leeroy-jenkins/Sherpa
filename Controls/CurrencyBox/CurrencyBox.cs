//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                CurrencyBox.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="CurrencyBox.cs" company="Terry D. Eppler">
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
//    CurrencyBox.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.CurrencyBase" />
    [ SuppressMessage("ReSharper", "MemberCanBeInternal") ]
    [ SuppressMessage("ReSharper", "ClassNeverInstantiated.Global") ]
    public class CurrencyBox : CurrencyEdit
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CurrencyBox" />
        /// class.
        /// </summary>
        /// <remarks>
        /// The CurrencyEdit class also creates the controls that it hosts such as the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.CurrencyTextBox" />
        /// control and the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.PopupCalculator" />
        /// control.
        /// </remarks>
        public CurrencyBox( )
        {
            // Basic Properties
            TextBox.Size = new Size( 180, 32 );
            Margin = new Padding( 1 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.White;
            Enabled = true;
            Visible = true;
            Border3DStyle = Border3DStyle.Adjust;
            FlatBorderColor = Color.FromArgb( 50, 93, 129 );
            PopupCalculatorAlignment = CalculatorPopupAlignment.Right;
            ShowCalculator = true;
            CanOverrideStyle = true;
            TextAlign = HorizontalAlignment.Center;
            ButtonStyle = ButtonAppearance.Office2016Black;
            UseVisualStyle = true;
            MetroColor = Color.FromArgb( 40, 40, 40 );

            // TextBox Properties
            TextBox.Size = new Size( 180, 32 );
            TextBox.Style = TextBoxExt.theme.Office2016Black;
            TextBox.CurrencyDecimalDigits = 2;
            TextBox.NegativeColor = Color.Red;
            TextBox.PositiveColor = Color.White;
            TextBox.BackGroundColor = Color.FromArgb( 40, 40, 40 );
            TextBox.Border3DStyle = Border3DStyle.Adjust;
            TextBox.BorderColor = Color.FromArgb( 50, 93, 129 );
            TextBox.BorderStyle = BorderStyle.FixedSingle;
            TextBox.CurrencyDecimalSeparator = ".";
            TextBox.CurrencyGroupSeparator = ",";
            TextBox.FocusBorderColor = Color.FromArgb( 0, 120, 212 );
            TransferFromCalculator = true;
            TransferToCalculator = true;

            // TextBox ThemeStyle Properties
            ThemeStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.BorderColor = Color.FromArgb( 50, 93, 129 );
            ThemeStyle.DisabledBackColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.HoverBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.FocusedBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.PressedBorderColor = Color.FromArgb( 0, 120, 212 );
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnMouseOver( object sender, EventArgs e )
        {
            var _currencyTextBox = sender as CurrencyBox;
            try
            {
                if( _currencyTextBox != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _hoverText = _currencyTextBox?.HoverText;
                        var _ = new SmallTip( _currencyTextBox, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new SmallTip( _currencyTextBox, _text );
                        }
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            var _currencyTextBox = sender as CurrencyBox;
            try
            {
                if( _currencyTextBox != null )
                {
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
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