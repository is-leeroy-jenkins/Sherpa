// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="PivotGrid.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   PivotGrid.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.PivotAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl" />
    public class PivotGrid : PivotGridControl
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PivotGrid"/> class.
        /// </summary>
        public PivotGrid( )
        {
            GridVisualStyles = GridVisualStyles.Custom;
            CanOverrideStyle = true;
            CanApplyTheme = true;
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            Size = new Size( 900, 500 );
            ShowCalculationsAsColumns = true;
            ShowSubTotals = true;

            // Dialog Style Properties
            ThemeStyle.ComputationInfoDialogStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ComputationInfoDialogStyle.ForeColor = Color.DarkGray;
            ThemeStyle.ComputationInfoDialogStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // Edit Menu Style Properties
            ThemeStyle.EditMenuStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.EditMenuStyle.ForeColor = Color.LightGray;
            ThemeStyle.EditMenuStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // Header Cell Style Properties
            ThemeStyle.HeaderCellStyle.HoverBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.HeaderCellStyle.HoverTextColor = Color.White;
            ThemeStyle.HeaderCellStyle.PressedBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HeaderCellStyle.PressedTextColor = Color.LightGray;

            // Value Cell Style Properties
            ThemeStyle.ValueCellStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ValueCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ValueCellStyle.TextColor = Color.LightGray;

            // Summary Cell Style Properties
            ThemeStyle.SummaryCellStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.SummaryCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.SummaryCellStyle.TextColor = Color.LightGray;

            // Expander Style Properties

            // Filter DropDown Style Properties
            ThemeStyle.FilterDropDownStyle.ForeColor = Color.LightGray;
            ThemeStyle.FilterDropDownStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.FilterDropDownStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // GroupBar Item Style Properties
            ThemeStyle.GroupBarItemStyle.ForeColor = Color.LightGray;
            ThemeStyle.GroupBarItemStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.GroupBarItemStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.GroupBarItemStyle.SortIconColor = Color.FromArgb( 0, 120, 212 );

            // GroupBar Style Properties
            ThemeStyle.GroupBarStyle.FilterAreaBackColor = Color.FromArgb( 55, 55, 55 );
            ThemeStyle.GroupBarStyle.BackColor = Color.FromArgb( 45, 45, 45 );

            // PivotValueChooser Style Properties
            ThemeStyle.PivotValueChooserStyle.ForeColor = Color.LightGray;
            ThemeStyle.PivotValueChooserStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.PivotValueChooserStyle.BorderColor = Color.FromArgb( 0, 120, 212 );
        }
    }
}