namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FolderBrowser : Syncfusion.Windows.Forms.FolderBrowser
    {
        public FolderBrowser( )
        {
            Style = FolderBrowserStyles.RestrictToFilesystem;
            StartLocation = FolderBrowserFolder.Desktop;
        }
    }
}
