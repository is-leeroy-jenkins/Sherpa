﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 2-13-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-13-2024
// ******************************************************************************************
// <copyright file="ScrollFrame.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ScrollFrame.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.WinForms.Controls;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class ScrollFrame : SfScrollFrame
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ScrollFrame" /> class.
        /// </summary>
        public ScrollFrame( )
        {
            CanApplyTheme = true;
            CanOverrideStyle = false;

            // Horizontal ScrollBar
            Style.HorizontalScrollBar.ArrowButtonDisabledBackColor = Color.FromArgb( 20, 20, 20 );
            Style.HorizontalScrollBar.ArrowButtonDisabledBorderColor = Color.FromArgb( 20, 20, 20 );
            Style.HorizontalScrollBar.ArrowButtonDisabledForeColor = Color.FromArgb( 20, 20, 20 );

            // Vertical ScrollBar
            Style.VerticalScrollBar.ArrowButtonDisabledBackColor = Color.FromArgb( 20, 20, 20 );
            Style.VerticalScrollBar.ArrowButtonDisabledBorderColor = Color.FromArgb( 20, 20, 20 );
            Style.VerticalScrollBar.ArrowButtonDisabledForeColor = Color.FromArgb( 20, 20, 20 );
        }
    }
}