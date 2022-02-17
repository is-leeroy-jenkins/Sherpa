// <copyright file = "ToolTip.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.ComponentModel;
    using System.Windows.Forms;
    using MetroSet_UI.Design;
    using MetroSet_UI.Enums;

    public class ToolTip : TipBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolTip"/> class.
        /// </summary>
        public ToolTip()
        {
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Style = Style.Custom;
            BackColor = Color.FromArgb( 10, 10, 10 );
            BorderColor = Color.SteelBlue;
            ForeColor = Color.LightSteelBlue;
            UseAnimation = true;
            UseFading = true;
            AutomaticDelay = 500;
            InitialDelay = 500;
            AutoPopDelay = 5000;
            ReshowDelay = 100;
            TipTitle = "Budget Execution";
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        public ToolTip( Control control, string text )
            : this()
        {
            SetToolTipText( control, text );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        public ToolTip( Component component, string text )
            : this()
        {
            SetToolTipText( component, text );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="toolItem">The toolItem.</param>
        public ToolTip( ToolStripItem toolItem )
            : this()
        {
            SetToolTipText( toolItem );
        }
    }
}
