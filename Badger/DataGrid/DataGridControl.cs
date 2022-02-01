// <copyright file = "DataGridControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ControlBase" />
    public partial class DataGridControl : ControlBase
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="DataGridControl"/> class.
        /// </summary>
        public DataGridControl()
        {
            InitializeComponent();
        }
    }
}