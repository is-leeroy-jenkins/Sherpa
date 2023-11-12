using System;
using System.Text;

namespace BudgetExecution.IO.Network
{
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ReplaceAutoPropertyWithComputedProperty" ) ]
    public class BabyClient
    {
        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public int Bytes { get; set; }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the buffer.
        /// </summary>
        /// <value>
        /// The buffer.
        /// </value>
        public byte[ ] Data { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the local.
        /// </summary>
        /// <value>
        /// The local.
        /// </value>
        public IPEndPoint EndPoint { get; set; }

        /// <summary>
        /// Gets or sets the local.
        /// </summary>
        /// <value>
        /// The local.
        /// </value>
        public IPAddress Address { get; set; }

        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public Socket Socket { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        public bool IsConnected { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BabyClient"/> class.
        /// </summary>
        public BabyClient( )
        {
            Bytes = 1024;
            Port = 9055;
            Data = new byte[ Bytes ];
            Address = IPAddress.Any;
            EndPoint = new IPEndPoint( Address, Port );
            Socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            IsConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BabyClient"/> class.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="portNumber">The port number.</param>
        /// <param name="bufferSize">Size of the buffer.</param>
        public BabyClient( string ipAddress, int portNumber = 9055, int bufferSize = 1024 )
        {
            Bytes = bufferSize;
            Port = portNumber;
            Data = new byte[ Bytes ];
            Address = IPAddress.Parse( ipAddress );
            EndPoint = new IPEndPoint( Address, portNumber );
            Socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            IsConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BabyClient"/> class.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="portNumber">The port.</param>
        /// <param name="bufferSize"> </param>
        public BabyClient( IPAddress ipAddress, int portNumber = 9055, int bufferSize = 1024 )
        {
            Bytes = bufferSize;
            Port = portNumber;
            Data = new byte[ bufferSize ];
            Address = ipAddress;
            EndPoint = new IPEndPoint( ipAddress, portNumber );
            Socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            IsConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BabyClient"/> class.
        /// </summary>
        /// <param name="ipEndPoint">The ip address.</param>
        /// <param name="bufferSize">Size of the buffer.</param>
        public BabyClient( IPEndPoint ipEndPoint, int bufferSize = 1024 )
        {
            Bytes = bufferSize;
            Port = ipEndPoint.Port;
            Data = new byte[ bufferSize ];
            Address = ipEndPoint.Address;
            EndPoint = ipEndPoint;
            Socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            IsConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BabyClient"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        public BabyClient( BabyClient client )
        {
            Bytes = client.Bytes;
            Port = client.Port;
            Data = client.Data;
            Address = client.Address;
            EndPoint = client.EndPoint;
            Socket = client.Socket;
            IsConnected = client.IsConnected;
        }

        /// <summary>
        /// Connects this instance.
        /// </summary>
        public void Connect( )
        {
            try
            {
                Message = "You look like a baby!";
                Data = Encoding.ASCII.GetBytes( Message );
                Socket.Connect( EndPoint );
                IsConnected = Socket.Connected;
                Socket.Send( Data );
                Notify( Message );
            }
            catch( Exception _ex )
            {
                Socket?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        public void SendMessage( )
        {
            try
            {
                Message = "You look like a baby!";
                Data = Encoding.ASCII.GetBytes( Message );
                if( Socket.Connected && IsConnected )
                {
                    Socket.Send( Data );
                    Notify( Message );
                }
                else
                {
                    Socket.Connect( EndPoint );
                    IsConnected = Socket.Connected;
                    Socket.Send( Data );
                }
            }
            catch( Exception _ex )
            {
                Socket?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SendMessage( string message )
        {
            try
            {
                ThrowIf.NullOrEmpty( message, nameof( message ) );
                Message = message;
                Data = Encoding.ASCII.GetBytes( message );
                if( Socket.Connected && IsConnected )
                {
                    Socket.Send( Data );
                }
                else
                {
                    Socket.Connect( EndPoint );
                    IsConnected = Socket.Connected;
                    Socket.Send( Data );
                }
            }
            catch( Exception _ex )
            {
                Socket?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        private void Notify( string message )
        {
            try
            {
                ThrowIf.NullOrEmpty( message, nameof( message ) );
                var _notify = new SplashMessage( message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Socket?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary>
        /// Deconstructs the specified bytes.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <param name="port">The port.</param>
        /// <param name="data">The data.</param>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="endPoint">The end point.</param>
        /// <param name="socket">The socket.</param>
        /// <param name="message">The message.</param>
        public void Deconstruct( out int bytes, out int port, out byte[ ] data,
            out IPAddress ipAddress, out IPEndPoint endPoint, out Socket socket,
            out string message )
        {
            bytes = Bytes;
            port = Port;
            data = Data;
            ipAddress = Address;
            endPoint = EndPoint;
            socket = Socket;
            message = Message;
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