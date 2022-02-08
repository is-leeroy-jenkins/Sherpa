// <copyright file = "BudgetNotification.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetNotification : SplashPanel
    {
        public BudgetNotification()
        {
            BackColor = BudgetColor.FormDark;
            Font = BudgetFont.FontSizeSmall;
        }
    }
}
