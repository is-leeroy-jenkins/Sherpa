// ************************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              13-11-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        16-11-2023
// ************************************************************************************************
// <copyright file="BabyBoy.cs.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Eppler, Terry.cs
// </summary>
// ************************************************************************************************

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;
    using System;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ReplaceAutoPropertyWithComputedProperty" ) ]
    public class BabyBoy
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
        /// <see cref="BabyBoy"/> class.
        /// </summary>
        public BabyBoy( )
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
        /// Initializes a new instance of the <see cref="BabyBoy"/> class.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="portNumber">The port number.</param>
        /// <param name="bufferSize">Size of the buffer.</param>
        public BabyBoy( string ipAddress, int portNumber = 9055, int bufferSize = 1024 )
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
        /// Initializes a new instance of the <see cref="BabyBoy"/> class.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <param name="portNumber">The port.</param>
        /// <param name="bufferSize"> </param>
        public BabyBoy( IPAddress ipAddress, int portNumber = 9055, int bufferSize = 1024 )
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
        /// Initializes a new instance of the <see cref="BabyBoy"/> class.
        /// </summary>
        /// <param name="ipEndPoint">The ip address.</param>
        /// <param name="bufferSize">Size of the buffer.</param>
        public BabyBoy( IPEndPoint ipEndPoint, int bufferSize = 1024 )
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
        /// <see cref="BabyBoy"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        public BabyBoy( BabyBoy client )
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