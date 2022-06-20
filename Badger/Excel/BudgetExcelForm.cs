// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BudgetExcelForm : FormBase
    {
        /// <summary>
        /// Gets the template path.
        /// </summary>
        /// <value>
        /// The template path.
        /// </value>
        public string TemplatePath { get; } = @"C:\Users\terry\source\repos\BudgetExecution\Ninja\Template\Excel.xlsx";

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string ExcelPath { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetExcelForm"/> class.
        /// </summary>
        public BudgetExcelForm()
        {
            InitializeComponent( );

            // Form Property Values
            BackColor = Color.FromArgb( 18, 18, 18 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Size = new Size( 1200, 700 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 18, 18, 18 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            MetroColor = Color.FromArgb( 18, 18, 18 );
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 32, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
            ExcelPath = TemplatePath;
            Load += OnFormLoad;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetExcelForm"/> class.
        /// </summary>
        /// <param name="excelPath">The file path.</param>
        public BudgetExcelForm( string excelPath )
            : this( )
        {
            InitializeComponent( );
            ExcelPath = excelPath;
        }

        /// <summary>
        /// Called when [form load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnFormLoad( object sender, EventArgs e )
        {
            if( !string.IsNullOrEmpty( ExcelPath ) )
            {
                try
                {
                    Spreadsheet?.Open( ExcelPath );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}