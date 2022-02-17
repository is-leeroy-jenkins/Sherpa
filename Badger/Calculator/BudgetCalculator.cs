// <copyright file = "BudgetCalculator.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
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
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public override Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public override NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

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
        /// Initializes a new instance of the
        /// <see cref="BudgetCalculator" />
        /// class.
        /// </summary>
        public BudgetCalculator()
        {
            Size = new Size( 350, 350 );
            Location = new Point( 1, 1 );
            BorderStyle = Border3DStyle.Adjust;
            BackColor = Color.FromArgb( 10, 10, 10 );
            ForeColor = Color.White;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ButtonStyle = ButtonAppearance.Office2010;
            FlatStyle = FlatStyle.System;
            Value = new CalculatorValue( 0.0 );
            ShowDisplayArea = true;
            DisplayTextAlign = HorizontalAlignment.Center;
            MetroColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.BorderThickness = 0;
            ThemeStyle.BorderColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.ForeColor = Color.White;
            ThemeStyle.Font = new Font( "Roboto", 11 );
            ThemeStyle.TextBoxBackColor = Color.FromArgb( 45, 45, 45 );
            CanOverrideStyle = true;
            UseVerticalAndHorizontalSpacing = true;
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
            Size = size;
            Location = location;
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
        /// Sets the calculation value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetCalculationValue( double value )
        {
            if( value != default )
            {
                try
                {
                    Value = new CalculatorValue( value );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the calculation value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetCalculationValue( string value )
        {
            if( Verify.IsInput( value ) )
            {
                try
                {
                    Result = new CalculatorValue( value );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
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