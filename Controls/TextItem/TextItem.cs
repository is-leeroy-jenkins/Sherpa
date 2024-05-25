//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                TextItem.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="TextItem.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    TextItem.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Drawing;

    /// <summary> </summary>
    public class TextItem
    {
        /// <summary> Gets or sets the header text. </summary>
        /// <value> The header text. </value>
        public string HeaderText { get; set; }

        /// <summary> Gets or sets the header font. </summary>
        /// <value> The header font. </value>
        public Font HeaderFont { get; set; }

        /// <summary> Gets or sets the header alignment. </summary>
        /// <value> The header alignment. </value>
        public ContentAlignment HeaderAlignment { get; set; }

        /// <summary> Gets or sets the color of the header fore. </summary>
        /// <value> The color of the header fore. </value>
        public Color HeaderForeColor { get; set; }

        /// <summary> Gets or sets the color of the header back. </summary>
        /// <value> The color of the header back. </value>
        public Color HeaderBackColor { get; set; }

        /// <summary> Gets or sets the body text. </summary>
        /// <value> The body text. </value>
        public string BodyText { get; set; }

        /// <summary> Gets or sets the body font. </summary>
        /// <value> The body font. </value>
        public Font BodyFont { get; set; }

        /// <summary> Gets or sets the body alignment. </summary>
        /// <value> The body alignment. </value>
        public ContentAlignment BodyAlignment { get; set; }

        /// <summary> Gets or sets the color of the body fore. </summary>
        /// <value> The color of the body fore. </value>
        public Color BodyForeColor { get; set; }

        /// <summary> Gets or sets the color of the body back. </summary>
        /// <value> The color of the body back. </value>
        public Color BodyBackColor { get; set; }

        /// <summary> Gets or sets the footer text. </summary>
        /// <value> The footer text. </value>
        public string FooterText { get; set; }

        /// <summary> Gets or sets the footer font. </summary>
        /// <value> The footer font. </value>
        public Font FooterFont { get; set; }

        /// <summary> Gets or sets the footer alignment. </summary>
        /// <value> The footer alignment. </value>
        public ContentAlignment FooterAlignment { get; set; }

        /// <summary> Gets or sets the color of the footer fore. </summary>
        /// <value> The color of the footer fore. </value>
        public Color FooterForeColor { get; set; }

        /// <summary> Gets or sets the color of the footer back. </summary>
        /// <value> The color of the footer back. </value>
        public Color FooterBackColor { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TextItem"/>
        /// class.
        /// </summary>
        public TextItem( )
        {
            HeaderFont = new Font( "Roboto", 10, FontStyle.Regular );
            HeaderAlignment = ContentAlignment.TopLeft;
            HeaderForeColor = Color.FromArgb( 0, 120, 212 );
            BodyFont = new Font( "Roboto", 9, FontStyle.Regular );
            BodyAlignment = ContentAlignment.MiddleLeft;
            BodyForeColor = Color.LightSteelBlue;
            FooterFont = new Font( "Roboto", 8, FontStyle.Regular );
            FooterAlignment = ContentAlignment.BottomLeft;
            FooterForeColor = Color.LightSteelBlue;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TextItem"/>
        /// class.
        /// </summary>
        /// <param name="bodyText"> The body text. </param>
        public TextItem( string bodyText )
            : this( )
        {
            HeaderText = string.Empty;
            BodyText = bodyText;
            FooterText = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TextItem"/>
        /// class.
        /// </summary>
        /// <param name="headerText"> The header text. </param>
        /// <param name="bodyText"> The body text. </param>
        public TextItem( string headerText, string bodyText )
            : this( )
        {
            HeaderText = headerText;
            BodyText = bodyText;
            FooterText = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TextItem"/>
        /// class.
        /// </summary>
        /// <param name="headerText"> The header text. </param>
        /// <param name="bodyText"> The body text. </param>
        /// <param name="footerText"> The footer text. </param>
        public TextItem( string headerText, string bodyText, string footerText )
            : this( )
        {
            HeaderText = headerText;
            BodyText = bodyText;
            FooterText = footerText;
        }
    }
}