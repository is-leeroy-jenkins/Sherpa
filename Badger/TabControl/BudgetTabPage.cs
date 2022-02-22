// <copyright file = "BudgetTabPage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class BudgetTabPage : TabPageBase
    {
        public BudgetTabPage()
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Font = new Font( "Roboto", 9  );
            ForeColor = Color.LightSteelBlue;
            BackColor = Color.FromArgb( 18, 18, 18 );
            TabBackColor = Color.FromArgb( 18, 18, 18 );
            BorderStyle = BorderStyle.None;
            TabFont = new Font( "Roboto", 8, FontStyle.Bold );
            TabForeColor = Color.White;
            Enabled = true;
            Visible = true;
        }
    }
}
