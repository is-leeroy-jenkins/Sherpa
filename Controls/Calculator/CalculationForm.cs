// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CalculationForm.cs" company="Terry D. Eppler">
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
//   CalculationForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "PossibleNullReferenceException" )]
    public partial class CalculationForm : MetroForm
    {
        /// <summary> Gets or sets the initial value. </summary>
        /// <value> The initial value. </value>
        public double InitialValue { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalculationForm"/>
        /// class.
        /// </summary>
        public CalculationForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Size = new Size( 373, 451 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionFont = new Font( "Roboto", 10 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.Red;
            ShowMouseOver = true;
            MinimizeBox = false;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            // Calculator Configuration
            Calculator.Font = new Font( "Roboto", 10 );
            Calculator.Dock = DockStyle.Fill;
            Calculator.BorderStyle = Border3DStyle.Adjust;
            Calculator.HorizontalSpacing = 10;
            Calculator.VerticalSpacing = 10;
            Calculator.UseVerticalAndHorizontalSpacing = true;
            Calculator.ShowDisplayArea = false;
            Calculator.BackColor = Color.FromArgb( 20, 20, 20 );

            // Label Configuration
            ValueLabel.Font = new Font( "Roboto", 14 );
            ValueLabel.Dock = DockStyle.Top;
            ValueLabel.BackColor = Color.Transparent;
            ValueLabel.ForeColor = Color.White;
            ValueLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CalculationForm"/>
        /// class.
        /// </summary>
        /// <param name="initial"> The initial. </param>
        public CalculationForm( double initial )
            : this( )
        {
            InitialValue = initial;
            Calculator.Value = new CalculatorValue( InitialValue );
            ValueLabel.Text = Calculator.Value.ToString( );
        }

        /// <summary> Called when [calculation value changed]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="CalculatorValueCalculatedEventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCalculationValueChanged( object sender, CalculatorValueCalculatedEventArgs e )
        {
            if( sender != null )
            {
                try
                {
                    ValueLabel.Text = Calculator.Value.ToString( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Calculator.ValueCalculated += OnCalculationValueChanged;
                Calculator.BorderStyle = Border3DStyle.Adjust;
                Calculator.BackColor = Color.FromArgb( 20, 20, 20 );
                CloseButton.HoverText = "Exit Calculator";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [close button click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}