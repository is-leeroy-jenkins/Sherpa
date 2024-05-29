//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                TilePanel.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="TilePanel.cs" company="Terry D. Eppler">
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
//    TilePanel.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.TileLayout"/>
    public class TilePanel : TileLayout
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.TilePanel"/>
        /// class.
        /// </summary>
        public TilePanel( )
        {
            // Control Properties
            BackColor = Color.FromArgb( 20, 20, 20 );
            Font = new Font( "Roboto", 36 );
            BorderStyle = BorderStyle.None;
            Border3DStyle = Border3DStyle.Flat;
            Dock = DockStyle.None;
            Size = new Size( 300, 250 );
            ShowGroupTitle = true;
            ShowItemPreview = true;
            TitleFont = new Font( "Roboto", 16 );
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.BorderThickness = 1;
            ThemeStyle.DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="_ex"> The ex. </param>
        private void Fail( Exception _ex )
        {
            using var _error = new ErrorDialog( _ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}