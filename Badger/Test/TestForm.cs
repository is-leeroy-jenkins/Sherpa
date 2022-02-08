// <copyright file = "TestForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class TestForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public NameValueCollection Setting { get;  set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the budget button.
        /// </summary>
        /// <value>
        /// The budget button.
        /// </value>
        public BudgetButton BudgetButton { get; set; } = new BudgetButton();

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public string CurrentDirectory { get; } = Environment.CurrentDirectory;

        public TestForm()
        {
            InitializeComponent();
            
            // Form Property Values
            BackColor = BudgetColor.FormDark;
            BorderThickness = BudgetBorder.Thin;
            BorderColor = BudgetColor.SteelBlue;
            Size = BudgetSize.FormSizeNormal;
            Font = BudgetFont.FontSizeSmall;
            CaptionBarColor = BudgetColor.FormDark;
            CaptionBarHeight = BudgetSize.CaptionSize;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.White;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            CaptionFont = BudgetFont.FontSizeMedium;
            MetroColor = BudgetColor.FormDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 32, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            // Test Button Properties
            BudgetButton.Text = "Test";
            BudgetButton.Location = new Point( 500, 500 );
            BudgetButton.HoverText = Setting[ "BudgetExecutionIcon" ];
            BudgetButton.Click += SetLabelText;
            BudgetButton.MouseLeave += ClearLabelText;

            Controls.Add( BudgetButton );
        }

        /// <summary>
        /// Sets the label text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void SetLabelText( object sender, EventArgs e )
        {
            if( sender is BudgetButton _button )
            {
                BudgetButton = _button;
                BudgetButton.ForeColor = BudgetColor.White;
                CaptionForeColor = BudgetColor.White;
                Text = Setting[ "BudgetExecutionIcon" ];

                var _form = new BudgetPdfForm();
                _form.ShowDialog();
            }
        }

        /// <summary>
        /// Clears the label text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void ClearLabelText( object sender, EventArgs e )
        {
            Text = string.Empty;
        }
    }
}
