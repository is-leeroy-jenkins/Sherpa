namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.PivotAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.PivotAnalysis.PivotGridControl" />
    public class PivotGrid : PivotGridControl
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.PivotGrid" /> class.
        /// </summary>
        public PivotGrid( )
        {
            GridVisualStyles = GridVisualStyles.Office2016Black;
            CanOverrideStyle = true;
            CanApplyTheme = true;
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Size = new Size( 900, 500 );
            ShowCalculationsAsColumns = true;
            ShowSubTotals = true;

            // Dialog Style Properties
            ThemeStyle.ComputationInfoDialogStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ComputationInfoDialogStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.ComputationInfoDialogStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // Edit Menu Style Properties
            ThemeStyle.EditMenuStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.EditMenuStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.EditMenuStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // Header Cell Style Properties
            ThemeStyle.HeaderCellStyle.HoverBackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.HeaderCellStyle.HoverTextColor = Color.White;
            ThemeStyle.HeaderCellStyle.PressedBackColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HeaderCellStyle.PressedTextColor = Color.FromArgb( 106, 189, 252 );

            // Value Cell Style Properties
            ThemeStyle.ValueCellStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ValueCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.ValueCellStyle.TextColor = Color.FromArgb( 106, 189, 252 );

            // Summary Cell Style Properties
            ThemeStyle.SummaryCellStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.SummaryCellStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.SummaryCellStyle.TextColor = Color.FromArgb( 106, 189, 252 );

            // Expander Style Properties

            // Filter DropDown Style Properties
            ThemeStyle.FilterDropDownStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.FilterDropDownStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.FilterDropDownStyle.BorderColor = Color.FromArgb( 0, 120, 212 );

            // GroupBar Item Style Properties
            ThemeStyle.GroupBarItemStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.GroupBarItemStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.GroupBarItemStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.GroupBarItemStyle.SortIconColor = Color.FromArgb( 0, 120, 212 );

            // GroupBar Style Properties
            ThemeStyle.GroupBarStyle.FilterAreaBackColor = Color.FromArgb( 55, 55, 55 );
            ThemeStyle.GroupBarStyle.BackColor = Color.FromArgb( 45, 45, 45 );

            // PivotValueChooser Style Properties
            ThemeStyle.PivotValueChooserStyle.ForeColor = Color.FromArgb( 106, 189, 252 );
            ThemeStyle.PivotValueChooserStyle.BackColor = Color.FromArgb( 45, 45, 45 );
            ThemeStyle.PivotValueChooserStyle.BorderColor = Color.FromArgb( 0, 120, 212 );
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
