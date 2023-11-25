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
        /// Initializes a new instance of the
        /// <see cref="PivotGrid"/> class.
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