// <copyright file = "FormBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Collections.Specialized;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public partial class FormBase : MetroForm
    {
        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public virtual NameValueCollection Settings { get;  set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public virtual string CurrentDirectory { get; } = Environment.CurrentDirectory;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FormBase"/> class.
        /// </summary>
        public FormBase()
        {
            InitializeComponent();
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
            Icon = new Icon( Settings[ "BudgetExecutionIcon" ], 16, 16 );
            ShowIcon = true;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
        }
    }
}
