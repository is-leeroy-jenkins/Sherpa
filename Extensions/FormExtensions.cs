
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
            using var g = control.CreateGraphics( );
            var _length = g.MeasureString( control.Text, control.Font ).Width;
            control.Width = (int)Math.Ceiling( _length );
        }

        /// <summary> Gets the controls. </summary>
        /// <returns> </returns>
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
