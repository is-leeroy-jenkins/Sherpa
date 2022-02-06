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
            Size = BudgetSize.GetSize( 350, 350 );
            Location = BudgetControl.GetLocation();
            BorderStyle = Border3DStyle.Adjust;
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.White;
            Margin = BudgetControl.Margin;
            Padding = BudgetControl.Padding;
            Font = BudgetFont.FontSizeSmall;
            Anchor = BudgetControl.GetAnchorStyle();
            Dock = DockStyle.None;
            ButtonStyle = ButtonAppearance.Office2010;
            FlatStyle = FlatStyle.System;
            Value = new CalculatorValue( 0.0 );
            ShowDisplayArea = true;
            DisplayTextAlign = HorizontalAlignment.Center;
            MetroColor = BudgetColor.FormDark;
            ThemeStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.BorderThickness = 0;
            ThemeStyle.BorderColor = BudgetColor.FormDark;
            ThemeStyle.ForeColor = BudgetColor.White;
            ThemeStyle.Font = BudgetFont.FontSizeMedium;
            ThemeStyle.TextBoxBackColor = BudgetColor.ControlInteriorDark;
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