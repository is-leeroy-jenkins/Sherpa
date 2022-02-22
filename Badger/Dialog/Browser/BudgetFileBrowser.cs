// <copyright file = "FileBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class BudgetFileBrowser : FormBase
    {
        public BudgetFileBrowser()
        {
            InitializeComponent();
            Size = new Size( 812, 486 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is BudgetButton _button )
            {
                try
                {
                    Close();
                }
                catch ( Exception ex )
                {
                    Fail( ex );
                }
            }
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
