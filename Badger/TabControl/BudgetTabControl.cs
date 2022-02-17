// <copyright file = "BudgetTabControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class BudgetTabControl : TabControlBase
    {
        public BudgetTabControl()
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9  );
            ForeColor = Color.LightSteelBlue;
            Enabled = true;
            Visible = true;
        }
    }
}
