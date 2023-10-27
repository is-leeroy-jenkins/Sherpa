using System;

namespace BudgetExecution.IO.Network
{
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class TcpClient
    {
        /// <summary> Gets or sets the count. </summary>
        /// <value> The count. </value>
        public int Bytes { get; set; }

        public string Input { get; set; }

        /// <summary> Gets or sets the buffer. </summary>
        /// <value> The buffer. </value>
        public byte[ ] Buffer { get; set; }

        /// <summary> Gets or sets the local end point. </summary>
        /// <value> The local end point. </value>
        public IPEndPoint Local { get; set; }

        /// <summary> Gets or sets the server. </summary>
        /// <value> The server. </value>
        public Socket Server { get; set; }

        /// <summary> Gets or sets the client. </summary>
        /// <value> The client. </value>
        public Socket Client { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TcpClient"/>
        /// class.
        /// </summary>
        public TcpClient( )
        {
            Buffer = new byte[ 1024 ];
            Local = new IPEndPoint( IPAddress.Any, 9050 );
            Server = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
        }

        /// <summary> Notifies this instance. </summary>
        private void Notify( )
        {
            try
            {
                var _message = "THIS IS NOT YET IMPLEMENTED!!";
                var _notify = new SplashMessage( _message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}