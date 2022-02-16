// <copyright file = "BudgetCalculatorForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class BudgetCalculatorForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        public BudgetCalculator Calculator { get; set; } = new BudgetCalculator();

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetCalculatorForm"/> class.
        /// </summary>
        public BudgetCalculatorForm()
        {
            InitializeComponent();

            // Form Properties
            Size = BudgetSize.GetSize( 400, 400 );
            BackColor = BudgetColor.FormDark;
            BorderThickness = BudgetBorder.Thin;
            BorderColor = BudgetColor.SteelBlue;
            Font = BudgetFont.FontSizeSmall;
            CaptionBarColor = BudgetColor.FormDark;
            CaptionBarHeight = BudgetSize.CaptionSize;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.White;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            MetroColor = BudgetColor.FormDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 16, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetSetting.Padding;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add( Calculator );
            Calculator.Dock = DockStyle.Fill;
        }
    }
}
