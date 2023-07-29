namespace BudgetExecution 
{
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.PivotChart;
    using System;
    using System.Drawing;

    public class PivotChart : Syncfusion.Windows.Forms.PivotChart.PivotChart

    {
        public PivotChart( )
        {
            // Control Properties
            Size = new Size( 550, 350 );
            Skins = Skins.Office2016Black;
            ShowPivotTableFieldList = false;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ChartTypes = PivotChartTypes.Column;
        }
    }
}
