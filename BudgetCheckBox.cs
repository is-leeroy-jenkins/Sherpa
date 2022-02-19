// <copyright file = "BudgetCheckBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class BudgetCheckBox : CheckBoxBase
    {
        public BudgetCheckBox()
        {
            Size = new Size( 125, 25 );
            BackColor = Color.FromArgb( 10, 10, 10 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            ForeColor = Color.LightSteelBlue;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
        }
    }
}
