// <copyright file = "BudgetTabPage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetTabPage : TabPageBase
    {
        public BudgetTabPage()
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9  );
            ForeColor = Color.LightSteelBlue;
            BorderStyle = BorderStyle.None;
            BackColor = Color.FromArgb( 10, 10, 10 );
            Enabled = true;
            Visible = true;
        }
    }
}
