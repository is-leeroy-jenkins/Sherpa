// // <copyright file = "BudgetControlBox.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Drawing;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Interactivity;

    public class BudgetControlBox : VisualControlBox
    {
        public BudgetControlBox()
        {
            Size = new Size( 96, 25 );
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BackColor = BudgetColor.Transparent;
            Font = BudgetFont.FontSizeSmall;

            // Close button back color properties 
            CloseButton.BackColor = BudgetColor.Transparent;
            CloseButton.BackColorState.Enabled = BudgetColor.Transparent;
            CloseButton.BackColorState.Disabled = BudgetColor.Transparent;
            CloseButton.BackColorState.Hover = BudgetColor.Maroon;
            CloseButton.BackColorState.Pressed = BudgetColor.Maroon;

            // Close button fore color properties 
            CloseButton.ForeColorState.Enabled = BudgetColor.DarkGray;
            CloseButton.ForeColorState.Hover = BudgetColor.White;
            CloseButton.ForeColorState.Disabled = BudgetColor.Transparent;
            CloseButton.ForeColorState.Pressed = BudgetColor.White;

            // Minimize button back color properties
            MinimizeButton.BackColorState.Enabled = BudgetColor.Transparent;
            MinimizeButton.BackColorState.Disabled = BudgetColor.Transparent;
            MinimizeButton.BackColorState.Hover = BudgetColor.SteelBlue;
            MinimizeButton.BackColorState.Pressed = BudgetColor.SteelBlue;

            // Minimize button fore color properties
            MinimizeButton.ForeColorState.Enabled = BudgetColor.DarkGray;
            MinimizeButton.ForeColorState.Disabled = BudgetColor.Transparent;
            MinimizeButton.ForeColorState.Hover = BudgetColor.White;
            MinimizeButton.ForeColorState.Pressed = BudgetColor.White;

            // Maximize button back color properties
            MaximizeButton.BackColorState.Enabled = BudgetColor.Transparent;
            MaximizeButton.BackColorState.Disabled = BudgetColor.Transparent;
            MaximizeButton.BackColorState.Hover = BudgetColor.SteelBlue;
            MaximizeButton.BackColorState.Pressed = BudgetColor.SteelBlue;

            // Maximize button fore color properties
            MaximizeButton.ForeColorState.Enabled = BudgetColor.DarkGray;
            MaximizeButton.ForeColorState.Disabled = BudgetColor.Transparent;
            MaximizeButton.ForeColorState.Hover = BudgetColor.White;
            MaximizeButton.ForeColorState.Pressed = BudgetColor.White;

            // Help button back color properties
            HelpButton.BackColorState.Enabled = BudgetColor.Transparent;
            HelpButton.BackColorState.Disabled = BudgetColor.Transparent;
            HelpButton.BackColorState.Hover = BudgetColor.SteelBlue;
            HelpButton.BackColorState.Pressed = BudgetColor.SteelBlue;

            // Help button fore color properties
            HelpButton.ForeColorState.Enabled = BudgetColor.DarkGray;
            HelpButton.ForeColorState.Disabled = BudgetColor.Transparent;
            HelpButton.ForeColorState.Hover = BudgetColor.White;
            HelpButton.ForeColorState.Pressed = BudgetColor.White;
        }
    }
}
