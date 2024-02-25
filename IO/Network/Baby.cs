namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;

    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class Baby
    {
        /// <summary>
        /// The bytes
        /// </summary>
        private protected int _bytes;

        /// <summary>
        /// The port
        /// </summary>
        private protected int _port;

        /// <summary>
        /// The data
        /// </summary>
        private protected byte[ ] _data;

        /// <summary>
        /// The message
        /// </summary>
        private protected string _message;

        /// <summary>
        /// The socket
        /// </summary>
        private protected Socket _socket;

        /// <summary>
        /// The ip address
        /// </summary>
        private protected IPAddress _ipAddress;

        /// <summary>
        /// The ip end point
        /// </summary>
        private protected IPEndPoint _ipEndPoint;

        /// <summary>
        /// The is connected
        /// </summary>
        private protected bool _isConnected;

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        private protected void SendNotification( string message )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                var _notify = new SplashMessage( message );
                _notify.Show( );
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
