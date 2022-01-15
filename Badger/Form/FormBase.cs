// <copyright file = "FormBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;

    public partial class FormBase : MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FormBase"/> class.
        /// </summary>
        public FormBase()
        {
            InitializeComponent();
            Size = SizeConfig.FormSizeNormal;
            BorderColor = ColorConfig.BorderColorBlue;
        }
    }
}
