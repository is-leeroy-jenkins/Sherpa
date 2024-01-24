// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 12-04-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-04-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    BudgetExecution is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ColorPanel.cs.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Tools;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class ColorPanel : GradientPanel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        public IEnumerable<Control> Children { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ColorPanel"/> class.
        /// </summary>
        public ColorPanel( )
        {
            BorderColor = Color.FromArgb( 77, 77, 77 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            BackgroundColor = new BrushInfo( GradientStyle.PathRectangle,
                Color.FromArgb( 55, 55, 55 ), Color.FromArgb( 20, 20, 20 ) );

            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            Border3DStyle = Border3DStyle.Flat;
            BorderSides = Border3DSide.All;
            BorderStyle = BorderStyle.FixedSingle;
            BorderSingle = ButtonBorderStyle.Solid;
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderColor = Color.FromArgb( 77, 77, 77 );
            ThemeStyle.BorderThickness = 1;
            ThemeStyle.DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Control> GetControls( )
        {
            var _list = new List<Control>( );
            var _queue = new Queue( );
            try
            {
                _queue.Enqueue( Controls );
                while( _queue.Count > 0 )
                {
                    var _collection = (ControlCollection)_queue.Dequeue( );
                    if( _collection?.Count > 0 )
                    {
                        foreach( Control _control in _collection )
                        {
                            _list.Add( _control );
                            _queue.Enqueue( _control.Controls );
                        }
                    }
                }

                return _list?.Any( ) == true
                    ? _list.ToArray( )
                    : default( Control[ ] );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Control[ ] );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}