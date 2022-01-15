// <copyright file = "BadgerMain.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    public partial class BadgerMain : FormBase
    {
        public BadgerMain()
        {
            InitializeComponent();
            Size = SizeConfig.FormSizeNormal;
            BorderColor = ColorConfig.BorderColorBlue;
        }
    }
}
