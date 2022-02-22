// <copyright file = "BadgerMain.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BadgerMain : FormBase
    {
        public BadgerMain()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = Color.FromArgb( 15, 15, 15 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Size = new Size( 1200, 800 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 15, 15, 15 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            MetroColor = Color.FromArgb( 15, 15, 15 );
            FormBorderStyle = FormBorderStyle.Sizable;
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = string.Empty;
            TestButton.BackColor = Color.Black;
        }
    }
}
