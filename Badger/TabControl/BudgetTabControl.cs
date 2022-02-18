// <copyright file = "BudgetTabControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetTabControl : TabControlBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetTabControl"/> class.
        /// </summary>
        public BudgetTabControl()
        {
            Alignment = TabAlignment.Top;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Font = new Font( "Roboto", 9  );
            ForeColor = Color.LightSteelBlue;
            BackColor = Color.FromArgb( 10, 10, 10 );
            TabPanelBackColor = Color.FromArgb( 10, 10, 10 );
            BorderStyle = BorderStyle.None;
            BorderColor = Color.FromArgb( 10, 10, 10 );
            BorderVisible = false;
            ThemesEnabled = true;
            ActiveTabColor = Color.SteelBlue;
            ActiveTabFont = new Font( "Roboto", 8, FontStyle.Bold  );
            ActiveTabForeColor = Color.White;
            InActiveTabForeColor = Color.FromArgb( 10, 10, 10 );
            InactiveTabColor = Color.FromArgb( 10, 10, 10 );
            SeparatorColor = Color.FromArgb( 64, 64, 64 );
            TextAlignment = StringAlignment.Center;
            VerticalAlignment = TabVerticalAlignment.Default;
            ShowSeparator = true;
            LabelEdit = false;
            Multiline = false;
            MultilineText = false;
            HotTrack = true;
            Enabled = true;
            Visible = true;
            ShowTabCloseButton = false;
            TextLineAlignment = StringAlignment.Center;
            ThemeStyle = TabControlAdvVisualStyle.DefaultStyle;
            UserMoveTabs = true;
        }
    }
}
