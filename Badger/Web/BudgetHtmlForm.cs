// <copyright file = "BudgetWebBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using Syncfusion.Windows.Forms;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BudgetHtmlForm : MetroForm
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
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual Numeric Numeric { get; set; }

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

        public BudgetHtmlForm()
        {
            InitializeComponent();

            // Form Properties
            Size = new Size( 1200, 800 );
            BackColor = Color.FromArgb( 15, 15, 15 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 15, 15, 15 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            CaptionBarHeight = 26;
            MetroColor = Color.FromArgb( 15, 15, 15 );
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 16, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            Text = string.Empty;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}