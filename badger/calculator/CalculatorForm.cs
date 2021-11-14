// <copyright file = "CalculatorForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    public partial class CalculatorForm : MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorForm"/> class.
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
            Label.Text = Calculator.DoubleValue.ToString( "C" );
            Calculator.ValueCalculated += OnCalculate;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }

        /// <summary>
        /// Called when [calculate].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCalculate( object sender, EventArgs e )
        {
            try
            {
                var result = Calculator.DoubleValue;
                Label.Text = result.ToString( "c" );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}