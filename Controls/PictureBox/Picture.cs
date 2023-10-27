//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                Picture.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Picture.cs" company="Terry D. Eppler">
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
//    Picture.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="System.Windows.Forms.PictureBox"/>
    public class Picture : PictureBox
    {
        /// <summary> Gets or sets the tool tip. </summary>
        /// <value> The tool tip. </value>
        public virtual SmallTip ToolTip { get; set; }

        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the filter. </summary>
        /// <value> The filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary> Gets or sets the image list. </summary>
        /// <value> The image list. </value>
        public ImageList ImageList { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture"/>
        /// class.
        /// </summary>
        public Picture( )
        {
            Size = new Size( 60, 40 );
            Anchor = AnchorStyles.Left | AnchorStyles.Top;
            Location = new Point( 1, 1 );
            BackColor = Color.Transparent;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture"/>
        /// class.
        /// </summary>
        /// <param name="size"> The size. </param>
        /// <param name="location"> The location. </param>
        public Picture( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture"/>
        /// class.
        /// </summary>
        /// <param name="image"> The image. </param>
        public Picture( Image image )
            : this( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture"/>
        /// class.
        /// </summary>
        /// <param name="path"> The path. </param>
        public Picture( string path )
            : this( )
        {
        }
    }
}