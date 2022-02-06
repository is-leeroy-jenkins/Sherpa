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
            CaptionBarHeight = BudgetSize.CaptionSizeNormal;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.White;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            CaptionFont = BudgetFont.FontSizeMedium;
            MetroColor = BudgetColor.FormDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 16, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Button.HoverText = Setting[ "BudgetExecutionIcon" ];
            Button.Click += SetLabelText;
            Button.MouseLeave += ClearLabelText;
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
                Button = _button;
                Button.ForeColor = BudgetColor.White;
                CaptionForeColor = BudgetColor.White;
                Text = Setting[ "BudgetExecutionIcon" ];
                var _calculator = new CalculatorForm();
                _calculator.ShowDialog();
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
