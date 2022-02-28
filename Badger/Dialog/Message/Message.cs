// <copyright file = "FileBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Message : FormBase
    {
        public Message()
        {
            InitializeComponent();
            Size = new Size( 576, 300 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public Message( string text ) 
            : this()
        {
            Text = text;
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
