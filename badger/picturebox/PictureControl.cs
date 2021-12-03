// <copyright file = "PictureControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;

    public partial class PictureControl : UserControl, IPictureBox
    {
        public PictureControl()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            PictureBox.SetHoverText( text );
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            PictureBox.SetField( field );
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            PictureBox.SetTag( tag );
        }

        /// <summary>
        /// Sets the image size mode.
        /// </summary>
        /// <param name="mode">The mode.</param>
        public void SetImageSizeMode( PictureBoxSizeMode mode = PictureBoxSizeMode.Normal )
        {
            PictureBox.SetImageSizeMode( mode );
        }
        
        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            PictureBox.OnMouseHover( sender, e );
        }
    }
}