// <copyright file = "IButton.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface IButton
    {
        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        /// <param name="format">The format.</param>
        void SetForeColor( Color format );

        /// <summary>
        /// Sets the state of the back color.
        /// </summary>
        /// <param name="color">The format.</param>
        void SetBackColorStyle( Color color );

        /// <summary>
        /// Sets the border configuration. Required Attributes: BorderColor, and HoverColor
        /// </summary>
        /// <param name="color">The format.</param>
        void SetBorderStyle( Color color );

        /// <summary>
        /// Sets the text style configuration. Required Attributes: PressedColor, DisabledColor,
        /// EnabledColor, and HoverColor
        /// </summary>
        /// <param name="color">The format.</param>
        void SetTextStyle( Color color );

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        void SetImage( Image image );

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnMouseOver( object sender, EventArgs e );

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnClick( object sender, EventArgs e );
    }
}