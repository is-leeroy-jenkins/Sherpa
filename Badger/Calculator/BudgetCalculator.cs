// <copyright file = "BudgetCalculator.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.CalculatorControl" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class BudgetCalculator : CalculatorBase, ICalculator
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        /// <remarks>
        /// The Value property is a shadow of the Calculator Engine's Value property.
        /// </remarks>
        public CalculatorValue Result { get; set; }

        /// <summary>
        /// Gets or sets the calculator text.
        /// </summary>
        /// <value>
        /// The calculator text.
        /// </value>
        public BudgetLabel Label { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolBase ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetCalculator" />
        /// class.
        /// </summary>
        public BudgetCalculator()
        {
            Size = BudgetSize.GetSize( 400, 400 );
            Location = BudgetControl.GetLocation();
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.White;
            Margin = BudgetControl.Margin;
            Padding = BudgetControl.Padding;
            Font = BudgetFont.FontSizeSmall;
            Anchor = BudgetControl.GetAnchorStyle();
            Dock = DockStyle.None;
            ButtonStyle = ButtonAppearance.Metro;
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetCalculator"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetCalculator( Size size, Point location )
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetCalculator" />
        /// class.
        /// </summary>
        /// <param name="value">The value.</param>
        public BudgetCalculator( string value )
            : this()
        {
            Result.SetValue( value );
        }
        
        /// <summary>
        /// Called when [equal button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        private void OnCalculate( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}