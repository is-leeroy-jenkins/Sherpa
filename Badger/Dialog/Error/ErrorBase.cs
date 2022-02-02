// <copyright file = "Error.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract partial class ErrorBase : MetroForm
    {
        /// <summary>
        /// The application setting
        /// </summary>
        public virtual NameValueCollection AppSetting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public virtual Exception Exception { get; set; }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="Error"/> class.
        /// </summary>
        public ErrorBase()
        {
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
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public ErrorBase( Exception ext )
        {
            Exception = ext;
            Text = "Error!";
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public ErrorBase( string message )
        {
            Text = message;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public abstract void SetText();

        /// <summary>
        /// Sets the text.
        /// </summary>
        public abstract void SetText( Exception ex );

        /// <summary>
        /// Sets the text.
        /// </summary>
        public abstract  void SetText( string msg = "" );
    }
}
