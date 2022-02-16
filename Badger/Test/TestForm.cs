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
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 62, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetSetting.Padding;
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            // Test Button Properties
            BudgetButton.Text = "Test";
            BudgetButton.Tag = "THIS IS A TEST";
            BudgetButton.Location = new Point( 500, 500 );
            BudgetButton.HoverText = System.IO.Path.GetFileNameWithoutExtension( Setting[ "BudgetExecutionIcon" ] );
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
                try
                {
                    BudgetButton = _button;
                    BudgetButton.ForeColor = BudgetColor.White;
                    CaptionForeColor = BudgetColor.White;
                    Text = Setting[ "BudgetExecutionIcon" ];
                    using var _form = new BudgetSelectionForm();
                    _form.ShowDialog( this );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
