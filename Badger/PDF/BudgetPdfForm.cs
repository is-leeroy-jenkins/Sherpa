// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroForm" />
    public partial class BudgetPdfForm : FormBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetPdfForm"/> class.
        /// </summary>
        public BudgetPdfForm()
        {
            InitializeComponent();

            // Form Properties
            Size = new Size( 1000, 700 );
            BackColor = Color.FromArgb( 18, 18, 18 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 18, 18, 18 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            MetroColor = Color.FromArgb( 18, 18, 18 );
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 16, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = "Budget Execution";
            StartPosition = FormStartPosition.CenterScreen;

            // Event-Wiring
            Load += OpenFundsControlManual;
        }

        /// <summary>
        /// Opens the funds control manual.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OpenFundsControlManual( object sender, EventArgs e )
        {
            var _path = @"C:\Users\terry\source\repos\BudgetExecution\"
                + @"Etc\doc\RMDS\FundsControlManual.pdf";

            if( File.Exists( _path ) 
               && Path.GetExtension( _path ).Contains( ".pdf" )  )
            {
                DocumentViewer.Load( _path );
            }
        }
    }
}
