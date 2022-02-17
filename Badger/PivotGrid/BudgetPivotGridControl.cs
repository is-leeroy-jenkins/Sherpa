// <copyright file = "BudgetPivotGridControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public class BudgetPivotGridControl : PivotGridBase
    {
        public BudgetPivotGridControl()
        {
            GridVisualStyles = GridVisualStyles.Office2016Black;
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            Size = BudgetSize.GetSize( 400, 300 );
            ShowCalculationsAsColumns = true;
            ShowSubTotals = true;

            // Dialog Style Properties
            ThemeStyle.ComputationInfoDialogStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.ComputationInfoDialogStyle.ForeColor = Color.LightGray;
            ThemeStyle.ComputationInfoDialogStyle.BorderColor = Color.SteelBlue;

            // Edit Menu Style Properties
            ThemeStyle.EditMenuStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.EditMenuStyle.ForeColor = Color.LightGray;
            ThemeStyle.EditMenuStyle.BorderColor = Color.SteelBlue;

            // Header Cell Style Properties
            ThemeStyle.HeaderCellStyle.HoverBackColor = BudgetColor.HoverDark;
            ThemeStyle.HeaderCellStyle.HoverTextColor = Color.LightGray;
            ThemeStyle.HeaderCellStyle.PressedBackColor = Color.SteelBlue;
            ThemeStyle.HeaderCellStyle.PressedTextColor = Color.White;

            // Value Cell Style Properties
            ThemeStyle.ValueCellStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ValueCellStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.ValueCellStyle.TextColor = Color.LightGray;

            // Summary Cell Style Properties
            ThemeStyle.SummaryCellStyle.Font = new Font( "Roboto", 9, FontStyle.Bold );
            ThemeStyle.SummaryCellStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.SummaryCellStyle.TextColor = Color.White;

            // Expander Style Properties

            // Filter DropDown Style Properties
            ThemeStyle.FilterDropDownStyle.ForeColor = Color.LightGray;
            ThemeStyle.FilterDropDownStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.FilterDropDownStyle.BorderColor = BudgetColor.WindowFrame;

            // Group Bar Item Style Properties
            ThemeStyle.GroupBarItemStyle.ForeColor = Color.LightGray;
            ThemeStyle.GroupBarItemStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.GroupBarItemStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.GroupBarItemStyle.SortIconColor = Color.SteelBlue;

            // Group Bar Style Properties
            ThemeStyle.GroupBarStyle.FilterAreaBackColor = BudgetColor.ControlInteriorDark;
            ThemeStyle.GroupBarStyle.BackColor = Color.FromArgb( 10, 10, 10 );

            // PivotValueChoserStyle Properties
            ThemeStyle.PivotValueChooserStyle.ForeColor = Color.LightGray;
            ThemeStyle.PivotValueChooserStyle.BackColor = Color.FromArgb( 10, 10, 10 );
            ThemeStyle.PivotValueChooserStyle.BorderColor = BudgetColor.WindowFrame;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }
    }
}
