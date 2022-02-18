// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using Syncfusion.Windows.Forms;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BudgetExcelForm : MetroForm
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
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets the template path.
        /// </summary>
        /// <value>
        /// The template path.
        /// </value>
        public string TemplatePath { get; } = @"\Ninja\Template\Excel.xlsx";

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;
        
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetExcelForm"/> class.
        /// </summary>
        public BudgetExcelForm()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = Color.FromArgb( 10, 10, 10 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Size = new Size( 1200, 700 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 10, 10, 10 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            MetroColor = Color.FromArgb( 10, 10, 10 );
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 32, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
            FilePath = TemplatePath;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetExcelForm"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public BudgetExcelForm( string filePath ) 
            : this()
        {
            InitializeComponent();
            FilePath = filePath;
        }

        /// <summary>
        /// Called when [form load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnFormLoad( object sender, EventArgs e )
        {
            if( !string.IsNullOrEmpty( FilePath ) )
            {
                try
                {
                    Spreadsheet.Open( FilePath );
                }
                catch ( Exception ex )
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
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}