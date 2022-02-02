// <copyright file = "Error.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Configuration;
    using System.Windows.Forms;

    public partial class Error : ErrorBase
    {
        /// <summary>
        /// The application setting
        /// </summary>
        public override NameValueCollection AppSetting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public override Exception Exception { get; set; }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="Error"/> class.
        /// </summary>
        public Error()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = ColorConfig.FormBackColorDark;
            BorderThickness = BorderConfig.Thin;
            BorderColor = ColorConfig.BorderColorRed;
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
            Icon = new Icon( AppSetting[ "BudgetExecutionIcon" ], 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = ControlConfig.Padding;
            Text = string.Empty;
            Size = new Size( 812, 486 );

            // TextBox Properties
            TextBox.BackColor =  ColorConfig.FormBackColorDark;
            TextBox.Parent = Panel;
            TextBox.Dock = DockStyle.Fill;

            Panel.BackColor = ColorConfig.FormBackColorDark;
            Panel.Parent = this;
            Panel.Location = new Point( 61, 48 );
            Panel.Controls.Add( TextBox );

            Controls.Add( Panel );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public Error( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
            Text = ext.ToLogString( "" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Error( string message )
        {
            InitializeComponent();
            TextBox.Text = message;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public override void SetText()
        {
            var _logString = Exception.ToLogString( "" );
            TextBox.Text = _logString;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public override void SetText( Exception ex )
        {
            var _logString = ex.ToLogString( "" );
            TextBox.Text = _logString;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public override void SetText( string msg = "" )
        {
            TextBox.Text = msg;
        }
    }
}