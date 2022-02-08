// <copyright file = "BudgetPivotGrid.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Syncfusion.Windows.Forms;

    public class BudgetPivotGrid : PivotGridBase
    {
        public BudgetPivotGrid()
        {
            GridVisualStyles = GridVisualStyles.Office2016Black;
            Font = BudgetFont.FontSizeSmall;
            ForeColor = BudgetColor.LightGray;
            Size = BudgetSize.GetSize( 400, 300 );
            ShowCalculationsAsColumns = true;
            ShowSubTotals = true;

            // Dialog Style Properties
            ThemeStyle.ComputationInfoDialogStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.ComputationInfoDialogStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.ComputationInfoDialogStyle.BorderColor = BudgetColor.SteelBlue;

            // Edit Menu Style Properties
            ThemeStyle.EditMenuStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.EditMenuStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.EditMenuStyle.BorderColor = BudgetColor.SteelBlue;

            // Header Cell Style Properties
            ThemeStyle.HeaderCellStyle.HoverBackColor = BudgetColor.HoverDark;
            ThemeStyle.HeaderCellStyle.HoverTextColor = BudgetColor.LightGray;
            ThemeStyle.HeaderCellStyle.PressedBackColor = BudgetColor.SteelBlue;
            ThemeStyle.HeaderCellStyle.PressedTextColor = BudgetColor.White;

            // Value Cell Style Properties
            ThemeStyle.ValueCellStyle.Font = BudgetFont.FontSizeSmall;
            ThemeStyle.ValueCellStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.ValueCellStyle.TextColor = BudgetColor.LightGray;

            // Summary Cell Style Properties
            ThemeStyle.SummaryCellStyle.Font = new Font( "Roboto", 9, FontStyle.Bold );
            ThemeStyle.SummaryCellStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.SummaryCellStyle.TextColor = BudgetColor.White;

            // Expander Style Properties

            // Filter DropDown Style Properties
            ThemeStyle.FilterDropDownStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.FilterDropDownStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.FilterDropDownStyle.BorderColor = BudgetColor.WindowFrame;

            // Group Bar Item Style Properties
            ThemeStyle.GroupBarItemStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.GroupBarItemStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.GroupBarItemStyle.Font = BudgetFont.FontSizeSmall;
            ThemeStyle.GroupBarItemStyle.SortIconColor = BudgetColor.SteelBlue;

            // Group Bar Style Properties
            ThemeStyle.GroupBarStyle.FilterAreaBackColor = BudgetColor.ControlInteriorDark;
            ThemeStyle.GroupBarStyle.BackColor = BudgetColor.FormDark;

            // PivotValueChoserStyle Properties
            ThemeStyle.PivotValueChooserStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.PivotValueChooserStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.PivotValueChooserStyle.BorderColor = BudgetColor.WindowFrame;
        }
    }
}
