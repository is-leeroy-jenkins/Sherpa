// <copyright file = "BudgetPivotGridControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms;

    public class BudgetPivotGridControl : PivotGridBase
    {
        public BudgetPivotGridControl()
        {
            GridVisualStyles = GridVisualStyles.Office2016Black;
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightSteelBlue;
            Size = new Size( 400, 300 );
            ShowCalculationsAsColumns = true;
            ShowSubTotals = true;

            // Dialog Style Properties
            ThemeStyle.ComputationInfoDialogStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ComputationInfoDialogStyle.ForeColor = Color.LightSteelBlue;
            ThemeStyle.ComputationInfoDialogStyle.BorderColor = Color.SteelBlue;

            // Edit Menu Style Properties
            ThemeStyle.EditMenuStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.EditMenuStyle.ForeColor = Color.LightSteelBlue;
            ThemeStyle.EditMenuStyle.BorderColor = Color.SteelBlue;

            // Header Cell Style Properties
            ThemeStyle.HeaderCellStyle.HoverBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.HeaderCellStyle.HoverTextColor = Color.LightGray;
            ThemeStyle.HeaderCellStyle.PressedBackColor = Color.SteelBlue;
            ThemeStyle.HeaderCellStyle.PressedTextColor = Color.White;

            // Value Cell Style Properties
            ThemeStyle.ValueCellStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ValueCellStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ValueCellStyle.TextColor = Color.LightGray;

            // Summary Cell Style Properties
            ThemeStyle.SummaryCellStyle.Font = new Font( "Roboto", 9, FontStyle.Bold );
            ThemeStyle.SummaryCellStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.SummaryCellStyle.TextColor = Color.White;

            // Expander Style Properties

            // Filter DropDown Style Properties
            ThemeStyle.FilterDropDownStyle.ForeColor = Color.LightSteelBlue;
            ThemeStyle.FilterDropDownStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.FilterDropDownStyle.BorderColor = SystemColors.WindowFrame;

            // Group Bar Item Style Properties
            ThemeStyle.GroupBarItemStyle.ForeColor = Color.LightSteelBlue;
            ThemeStyle.GroupBarItemStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.GroupBarItemStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.GroupBarItemStyle.SortIconColor = Color.SteelBlue;

            // Group Bar Style Properties
            ThemeStyle.GroupBarStyle.FilterAreaBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.GroupBarStyle.BackColor = Color.FromArgb( 18, 18, 18 );

            // PivotValueChoserStyle Properties
            ThemeStyle.PivotValueChooserStyle.ForeColor = Color.LightSteelBlue;
            ThemeStyle.PivotValueChooserStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.PivotValueChooserStyle.BorderColor = SystemColors.WindowFrame;
        }
    }
}
