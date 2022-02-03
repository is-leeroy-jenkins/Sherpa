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
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Editors;

    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public partial class ErrorBase : MetroForm
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
        /// Gets or sets the icon path.
        /// </summary>
        /// <value>
        /// The icon path.
        /// </value>
        public virtual string IconPath { get; set; }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="Error"/> class.
        /// </summary>
        public ErrorBase()
        {
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
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
            IconPath = AppSetting[ "BudgetExecutionIcon" ];
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
        /// Sets the text.
        /// </summary>
        public virtual void SetText()
        {
            var _logString = Exception.ToLogString( "" );
            Text = _logString;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public virtual void SetText( Exception ex )
        {
            var _logString = ex.ToLogString( "" );
            Text = _logString;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public virtual void SetText( string msg = "" )
        {
            Text = msg;
        }
    }
}
