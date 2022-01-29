// <copyright file = "BudgetGridControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ControlBase" />
    public partial class BudgetGridControl : ControlBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGridControl"/> class.
        /// </summary>
        public BudgetGridControl()
        {
            InitializeComponent();
            AutoScaleDimensions = new SizeF(96F, 96F);
            ForeColor = Color.LightGray;
            Name = "BudgetGridControl";
            Size = new Size( 813, 405 );
        }
    }
}