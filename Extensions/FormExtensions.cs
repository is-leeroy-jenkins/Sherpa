// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        03-23-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Budget Execution is a small Federal Budget, Finance, and Accounting data management
//    application for analysts with the US Environmental Protection Agency (US EPA).
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FormExtensions.cs
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

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public static class FormExtensions
    {
        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="control"> </param>
        /// <param name="action">The action.</param>
        public static void InvokeIfNeeded( this Control control, Action action )
        {
            try
            {
                ThrowIf.Null( action, nameof( action ) );
                if( control.InvokeRequired )
                {
                    control.BeginInvoke( action );
                }
                else
                {
                    action?.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="form">The form.</param>
        /// <param name="action">The action.</param>
        public static void InvokeIfNeeded( this Form form, Action action )
        {
            try
            {
                ThrowIf.Null( action, nameof( action ) );
                if( form.InvokeRequired )
                {
                    form.BeginInvoke( action );
                }
                else
                {
                    action?.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Resizes the control width to the content text
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static void ResizeToTextWidth( this Control control )
        {
            try
            {
                using var _graphics = control.CreateGraphics( );
                var _length = _graphics.MeasureString( control.Text, control.Font ).Width;
                control.Width = (int)Math.Ceiling( _length );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns>
        /// </returns>
        public static IEnumerable<Control> GetControls( this Form form )
        {
            var _list = new List<Control>( );
            var _queue = new Queue( );
            try
            {
                _queue.Enqueue( form.Controls );
                while( _queue.Count > 0 )
                {
                    var _collection = (Control.ControlCollection)_queue.Dequeue( );
                    if( _collection != null )
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
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}