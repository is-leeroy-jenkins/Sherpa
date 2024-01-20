namespace BudgetExecution
{
    using System;
    using System.Runtime.InteropServices;

    public abstract class MailManager
    {
        /// <summary>
        /// The host name
        /// </summary>
        private protected string _hostName;

        /// <summary>
        /// Releases the COM object.
        /// </summary>
        /// <param name="obj">The object.</param>
        private protected void ReleaseComObject( object obj )
        {
            try
            {
                if( obj != null )
                {
                    Marshal.ReleaseComObject( obj );
                    obj = null;
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
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
