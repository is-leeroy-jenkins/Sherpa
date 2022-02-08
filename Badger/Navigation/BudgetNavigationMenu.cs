// // <copyright file = "BudgetNavigationMenu.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetNavigationMenu : NavigatorMenuBase
    {
        public BudgetNavigationMenu()
        {
            // Navigation Menu Properties
            Size = new Size( 75, 23 );
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Position = SlidePosition.Right;
            Style = NavigationDrawerStyle.Office2016Black;
            Font = BudgetFont.FontSizeSmall;
            AnimationDuration = 20;
            DrawerWidth = BudgetSize.CollectionControl.Width;
            Text = string.Empty;

            // Navigation Menu ThemeStyle
            ThemeStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.DisabledBackColor = BudgetColor.FormDark;
            ThemeStyle.DisabledFooterBackColor = BudgetColor.FormDark;
            ThemeStyle.DisabledFooterBorderColor = BudgetColor.FormDark;
            ThemeStyle.DisabledHeaderBackColor = BudgetColor.FormDark;
            ThemeStyle.DisabledPanelBackColor = BudgetColor.FormDark;

            // Navigation Header ThemeStyle
            ThemeStyle.HeaderBackColor = BudgetColor.FormDark;
            ThemeStyle.HeaderFont = BudgetFont.FontSizeMedium;
            ThemeStyle.HeaderForeColor = BudgetColor.LightGray;

            // Navigation Footer ThemeStyle
            ThemeStyle.FooterBackColor = BudgetColor.FormDark;
            ThemeStyle.FooterBorderColor = BudgetColor.WindowFrame;
            ThemeStyle.FooterBorderThickness = 2;
            ThemeStyle.FooterFont = new Font( "Roboto", 8, FontStyle.Regular );
            ThemeStyle.FooterForeColor = BudgetColor.LightGray;
            ThemeStyle.FooterHoverBackColor = BudgetColor.HoverDark;
            ThemeStyle.FooterHoverForeColor = BudgetColor.White;

            // Navigation ItemStyle
            ThemeStyle.ItemStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.ItemStyle.Font = BudgetFont.FontSizeSmall;
            ThemeStyle.ItemStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.ItemStyle.DisabledBackColor = BudgetColor.FormDark;
            ThemeStyle.ItemStyle.DisabledForeColor = BudgetColor.FormDark;
            ThemeStyle.ItemStyle.DisabledSelectionMarkerColor = BudgetColor.FormDark;
            ThemeStyle.ItemStyle.HoverBackColor = BudgetColor.HoverDark;
            ThemeStyle.ItemStyle.HoverForeColor = BudgetColor.White;
            ThemeStyle.ItemStyle.SelectedBackColor = BudgetColor.SteelBlue;
            ThemeStyle.ItemStyle.SelectedForeColor = BudgetColor.White;

            // Navigation Panel Properties
            ThemeStyle.PanelBackColor = BudgetColor.FormDark;
            ThemeStyle.DisabledPanelBackColor = BudgetColor.FormDark;
        }
    }
}
