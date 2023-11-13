
namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
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
