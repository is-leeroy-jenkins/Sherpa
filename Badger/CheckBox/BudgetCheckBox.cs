// <copyright file = "BudgetCheckBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using VisualPlus.Models;
    using Color = System.Drawing.Color;

    public class BudgetCheckBox : CheckBoxBase
    {
        public BudgetCheckBox()
        {
            Size = new Size( 125, 25 );
            Box = new Size( 14, 14 );
            BackColor = Color.FromArgb( 18, 18, 18 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            ForeColor = Color.White;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Cursor = Cursors.Hand;
            Border.Color = Color.FromArgb( 28, 28, 28 );
            Border.HoverColor = Color.SteelBlue;
            Border.HoverVisible = true;
            CheckState = CheckState.Unchecked;
            CheckStyle.Style = CheckStyle.CheckType.Checkmark;
            CheckStyle.CheckColor = Color.Lime;
            BoxColorState.Enabled = Color.FromArgb( 28, 28, 28 );
            BoxColorState.Hover = Color.FromArgb( 41, 41, 41 );
            BoxColorState.Disabled = Color.FromArgb( 18, 18, 18 );
            CheckStyle.AutoSize = true;
            CheckStyle.Bounds = new Rectangle( 0, 0, 125, 23 );
            CheckStyle.Style = CheckStyle.CheckType.Checkmark;
            BoxSpacing = 4;
            MouseHover += OnMouseOver;
        }
    }
}
