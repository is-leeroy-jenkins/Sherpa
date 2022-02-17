// <copyright file = "BudgetTabControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    public class BudgetTabControl : TabControlBase
    {
        public BudgetTabControl()
        {
            BackColor = Color.FromArgb( 10, 10, 10 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
        }
    }
}
