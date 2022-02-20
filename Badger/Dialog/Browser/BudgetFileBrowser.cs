// <copyright file = "FileBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BudgetFileBrowser : FormBase
    {
        public BudgetFileBrowser()
        {
            InitializeComponent();
            Size = new Size( 812, 486 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
