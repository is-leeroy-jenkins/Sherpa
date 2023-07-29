namespace BudgetExecution
{
    using Syncfusion.Windows.Forms.Maps;
    using System;
    using System.Drawing;

    public class MapControl : Maps
    {
        public MapControl( )
        {
            // Control Properties
            Size = new Size( 400, 250 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            Font = new Font( "Roboto", 9 );
            MapItemFont = new Font( "Roboto", 8 );
            ThemeStyle.Font = new Font( "Roboto", 8 );
        }
    }
}
