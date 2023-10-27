//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ImageListBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ImageListBase.cs" company="Terry D. Eppler">
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
//    ImageListBase.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.ImageListAdv"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ImageListBase : ImageListAdv
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the data filter. </summary>
        /// <value> The data filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Res the size images. </summary>
        /// <param name="width"> The width. </param>
        /// <param name="height"> The height. </param>
        public virtual void ReSizeImages( int width, int height )
        {
            if( ( width > 0 )
               && ( height > 0 ) )
            {
                try
                {
                    ImageSize = new Size( width, height );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}