// <copyright file = "BudgetNavigationMenu.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetNavigationMenu : NavigatorMenuBase
    {
        public BudgetNavigationMenu()
        {
            // Navigation Menu Properties
            Size = new Size( 75, 23 );
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.White;
            Position = SlidePosition.Right;
            Style = NavigationDrawerStyle.Office2016Black;
            Font = new Font( "Roboto", 9 );
            AnimationDuration = 20;
            DrawerWidth = Size.Width;
            Text = string.Empty;
            Visible = true;
            Enabled = true;

            // Navigation Menu ThemeStyle
            ThemeStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledFooterBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledFooterBorderColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledHeaderBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledPanelBackColor = Color.FromArgb( 18, 18, 18 );

            // Navigation Header ThemeStyle
            ThemeStyle.HeaderBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.HeaderFont = new Font( "Roboto", 11 );
            ThemeStyle.HeaderForeColor = Color.LightSteelBlue;

            // Navigation Footer ThemeStyle
            ThemeStyle.FooterBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.FooterBorderColor = SystemColors.WindowFrame;
            ThemeStyle.FooterBorderThickness = 2;
            ThemeStyle.FooterFont = new Font( "Roboto", 8, FontStyle.Regular );
            ThemeStyle.FooterForeColor = Color.LightSteelBlue;
            ThemeStyle.FooterHoverBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.FooterHoverForeColor = Color.White;

            // Navigation ItemStyle
            ThemeStyle.ItemStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ItemStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ItemStyle.ForeColor = Color.White;
            ThemeStyle.ItemStyle.DisabledBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ItemStyle.DisabledForeColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ItemStyle.DisabledSelectionMarkerColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ItemStyle.HoverBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ItemStyle.HoverForeColor = Color.White;
            ThemeStyle.ItemStyle.SelectedBackColor = Color.SteelBlue;
            ThemeStyle.ItemStyle.SelectedForeColor = Color.White;

            // Navigation Panel Properties
            ThemeStyle.PanelBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledPanelBackColor = Color.FromArgb( 18, 18, 18 );
        }
    }
}
