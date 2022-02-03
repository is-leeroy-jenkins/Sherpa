﻿// <copyright file = "Error.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Configuration;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

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
        /// Gets or sets the icon path.
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public override string IconPath { get; set; } 

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="Error"/> class.
        /// </summary>
        public Error()
        {
            InitializeComponent();

            // Form Property Values
            BackColor = BudgetColor.FormBackColorDark;
            BorderThickness = BudgetBorder.Thin;
            BorderColor = BudgetColor.BorderColorRed;
            Size = BudgetSize.FormSizeNormal;
            Font = BudgetFont.FontSizeSmall;
            CaptionBarColor = BudgetColor.FormBackColorDark;
            CaptionBarHeight = BudgetSize.CaptionSizeNormal;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.CaptionButtonHoverColor;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            CaptionFont = BudgetFont.FontSizeMedium;
            MetroColor = BudgetColor.FormBackColorDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( IconPath, 33, 32 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
            Size = new Size( 812, 486 );

            // TextBox Properties
            TextBox.BackColor =  BudgetColor.FormBackColorDark;
            TextBox.BackColorState.Enabled = BudgetColor.FormBackColorDark;
            TextBox.Border.Type = ShapeTypes.Rounded;
            TextBox.Border.Color = BudgetColor.BorderColorDark;
            TextBox.Border.HoverColor = BudgetColor.BorderColorRed;
            TextBox.Parent = Panel;
            TextBox.Dock = DockStyle.Fill;

            Panel.BackColor = BudgetColor.FormBackColorDark;
            Panel.BackColorState.Enabled = BudgetColor.FormBackColorDark;
            Panel.Border.Color = BudgetColor.BorderColorDark;
            Panel.Border.HoverColor = BudgetColor.BorderColorRed;
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