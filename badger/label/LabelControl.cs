// <copyright file = "LabelControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System;

    public partial class LabelControl : ControlBase, ILabel
    {
        public LabelControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetOutlineColor( Color color )
        {
            Label.SetOutlineColor( color );
        }

        /// <summary>
        /// Sets the text alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetTextAlignment( StringAlignment alignment )
        {
            Label.SetTextAlignment( alignment );
        }

        /// <summary>
        /// Sets the line alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetLineAlignment( StringAlignment alignment )
        {
            Label.SetLineAlignment( alignment );
        }

        /// <summary>
        /// Sets the numeric.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        public void SetNumeric( Numeric numeric )
        {
            Label.SetNumeric( numeric );
        }
    }
}