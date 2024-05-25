// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 12-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-10-2023
// ******************************************************************************************
// <copyright file="MetroTile.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    Contact at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   MetroTile.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MetroSet_UI.Controls.MetroSetTile" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class MetroTile : MetroSetTile
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MetroTile"/> class.
        /// </summary>
        public MetroTile( )
        {
            // Basic SeriesConfiguration
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Sherpa";
            Font = new Font( "Roboto", 8 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Margin = new Padding( 3 );
            Padding = new Padding( 0 );
            Size = new Size( 140, 60 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Visible = true;
            Enabled = true;

            // Normal Color Configuration
            NormalColor = Color.FromArgb( 47, 47, 47 );
            NormalBorderColor = Color.FromArgb( 47, 47, 47 );
            NormalTextColor = Color.FromArgb( 106, 189, 252 );

            // Hover Color Configuration
            HoverBorderColor = Color.FromArgb( 230, 230, 230 );
            HoverColor = Color.FromArgb( 65, 177, 225 );
            HoverTextColor = Color.White;

            // Disabled Color Configuration
            DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
            DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            DisabledForeColor = Color.FromArgb( 20, 20, 20 );

            // Pressed Color Configuration
            PressColor = Color.FromArgb( 65, 177, 225 );
            PressBorderColor = Color.FromArgb( 65, 177, 225 );
            PressTextColor = Color.White;
        }
    }
}