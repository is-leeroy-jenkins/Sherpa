// <copyright file = "Message.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms;

    public partial class Message : MetroForm
    {
        /// <summary>
        /// Gets the stack.
        /// </summary>
        /// <value>
        /// The stack.
        /// </value>
        public string Stack { get; set; }

        /// <summary>
        /// Gets the target.
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        public string Target { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        public Message()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = ColorConfig.FormBackColorDark;
            BorderThickness = BorderConfig.Thin;
            BorderColor = ColorConfig.BorderColorBlue;
            Size = SizeConfig.FormSizeNormal;
            Font = FontConfig.FontSizeSmall;
            CaptionBarColor = ColorConfig.FormBackColorDark;
            CaptionBarHeight = SizeConfig.CaptionSizeNormal;
            CaptionButtonColor = ColorConfig.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = ColorConfig.CaptionButtonHoverColor;
            CaptionAlign = AlignConfig.HorizontalLeft;
            CaptionFont = FontConfig.FontSizeMedium;
            MetroColor = ColorConfig.FormBackColorDark;
            FormBorderStyle = BorderConfig.Sizeable;
            Icon = new Icon( @"C:\Users\terry\source\repos\BudgetExecution\Etc\epa.ico", 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Message"/> class.
        /// </summary>
        /// <param name = "message" >
        /// The message.
        /// </param>
        public Message( string message )
            : this()
        {
            TextBox.Text = message;
            Info.Text = "Message";
        }

        /// <summary>
        /// Called when [ok button clicked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnOkButtonClicked( object sender, EventArgs e )
        {
            if( IsDisposed == false )
            {
                Dispose();
            }

            Close();
        }

        /// <summary>
        /// Called when [stack button clicked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnStackButtonClicked( object sender, EventArgs e )
        {
            Info.Text = "Call Stack: \n\n" + Stack;
        }

        /// <summary>
        /// Called when [target button clicked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnTargetButtonClicked( object sender, EventArgs e )
        {
            Info.Text = "Target SuperfundSite: \n\n" + Target;
        }

        /// <summary>
        /// Called when [closing].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnClosing( object sender, EventArgs e )
        {
            if( !IsDisposed )
            {
                Dispose();
            }
        }

        /// <summary>
        /// Handles the Load event of the Message control.
        /// </summary>
        /// <param name = "sender" >
        /// The source of the event.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
        }
    }
}