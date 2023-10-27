//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ToolStripDropDownBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ToolStripDropDownBase.cs" company="Terry D. Eppler">
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
//    ToolStripDropDownBase.cs
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

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public abstract class ToolStripDropDownBase : ToolStripComboBoxEx
    {
        /// <summary> Gets or sets the binding source. </summary>
        /// <value> The binding source. </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary> Gets or sets the hover text. </summary>
        /// <value> The hover text. </value>
        public virtual string HoverText { get; set; }

        /// <summary> Gets or sets the data filter. </summary>
        /// <value> The data filter. </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ToolStripDropDownBase"/>
        /// class.
        /// </summary>
        protected ToolStripDropDownBase( )
        {
        }

        /// <summary> Sets the font. </summary>
        /// <param name="font"> The font. </param>
        public virtual void SetFont( Font font )
        {
            try
            {
                Font = font ?? new Font( "Roboto", 8 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the color of the fore. </summary>
        /// <param name="color"> The color. </param>
        public virtual void SetForeColor( Color color )
        {
            try
            {
                ForeColor = color != Color.Empty
                    ? color
                    : Color.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the color of the back. </summary>
        /// <param name="color"> The color. </param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = color != Color.Empty
                    ? color
                    : Color.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the field. </summary>
        /// <param name="field"> The field. </param>
        public virtual void SetField( Field field )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the hover text. </summary>
        /// <param name="item"> The item. </param>
        public virtual void SetHoverText( ToolStripItem item )
        {
            try
            {
                var _text = item?.Tag?.ToString( );
                HoverText = !string.IsNullOrEmpty( _text )
                    ? _text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the hover text. </summary>
        /// <param name="text"> The text. </param>
        public virtual void SetHoverText( string text )
        {
            try
            {
                HoverText = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}