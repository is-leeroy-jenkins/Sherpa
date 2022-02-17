// <copyright file = "BadgerMain.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BadgerMain : FormBase
    {
        public BadgerMain()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = Color.FromArgb( 10, 10, 10 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Size = new Size( 1200, 700 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 10, 10, 10 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            MetroColor = Color.FromArgb( 10, 10, 10 );
            FormBorderStyle = FormBorderStyle.Sizable;
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = string.Empty;
            MinimumSize = BudgetSize.FormSizeMinimum;
            MaximumSize = BudgetSize.FormSizeMaximum;
            TestButton.BackColor = Color.Black;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }
    }
}
