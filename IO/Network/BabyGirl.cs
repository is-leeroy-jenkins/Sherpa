﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-20-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-20-2024
// ******************************************************************************************
// <copyright file="BabyGirl.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   BabyGirl.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "ConvertConstructorToMemberInitializers" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    public class BabyGirl : Baby
    {
        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public int Bytes
        {
            get
            {
                return _bytes;
            }
            private set
            {
                _bytes = value;
            }
        }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public int Port
        {
            get
            {
                return _port;
            }
            private set
            {
                _port = value;
            }
        }

        /// <summary>
        /// Gets or sets the buffer.
        /// </summary>
        /// <value>
        /// The buffer.
        /// </value>
        public byte[ ] Data
        {
            get
            {
                return _data;
            }
            private set
            {
                _data = value;
            }
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message
        {
            get
            {
                return _message;
            }
            private set
            {
                _message = value;
            }
        }

        /// <summary>
        /// Gets or sets the server.
        /// </summary>
        /// <value>
        /// The server.
        /// </value>
        public Socket Socket
        {
            get
            {
                return _socket;
            }
            private set
            {
                _socket = value;
            }
        }

        /// <summary>
        /// Gets or sets the local.
        /// </summary>
        /// <value>
        /// The local.
        /// </value>
        public IPAddress Address
        {
            get
            {
                return _ipAddress;
            }
            private set
            {
                _ipAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets the local.
        /// </summary>
        /// <value>
        /// The local.
        /// </value>
        public IPEndPoint EndPoint
        {
            get
            {
                return _ipEndPoint;
            }
            private set
            {
                _ipEndPoint = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether
        /// this instance is connected.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is connected;
        /// otherwise, <c>false</c>.
        /// </value>
        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
            private set
            {
                _isConnected = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BabyGirl"/> class.
        /// </summary>
        public BabyGirl( )
        {
            _bytes = 1024;
            _port = 5000;
            _data = new byte[ Bytes ];
            _ipAddress = IPAddress.Any;
            _ipEndPoint = new IPEndPoint( _ipAddress, Port );
            _socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            _isConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BabyGirl"/> class.
        /// </summary>
        /// <param name="address">The ip address.</param>
        /// <param name="port">The port.</param>
        /// <param name="size"> </param>
        public BabyGirl( IPAddress address, int port = 5000, int size = 1024 )
        {
            _bytes = size;
            _port = port;
            _data = new byte[ size ];
            _ipAddress = address;
            _ipEndPoint = new IPEndPoint( address, port );
            _socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            _isConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BabyGirl"/> class.
        /// </summary>
        /// <param name="address">The ip address.</param>
        /// <param name="port">The port number.</param>
        /// <param name="size">Size of the buffer.</param>
        public BabyGirl( string address, int port = 5000, int size = 1024 )
        {
            _bytes = size;
            _port = port;
            _data = new byte[ size ];
            _ipAddress = IPAddress.Parse( address );
            _ipEndPoint = new IPEndPoint( _ipAddress, port );
            _socket = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
            _isConnected = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BabyGirl"/> class.
        /// </summary>
        /// <param name="girl">The client.</param>
        public BabyGirl( BabyGirl girl )
        {
            _bytes = girl.Bytes;
            _port = girl.Port;
            _data = girl.Data;
            _ipAddress = girl.Address;
            _ipEndPoint = girl.EndPoint;
            _socket = girl.Socket;
            _isConnected = girl.IsConnected;
        }

        /// <summary>
        /// Connects this instance.
        /// </summary>
        public void Start( )
        {
            try
            {
                var _received = 0;
                _socket.Bind( _ipEndPoint );
                _socket.Listen( 10 );
                _message = "Welcome to the Baby Server!";
                SendNotification( _message );
                _data = Encoding.ASCII.GetBytes( _message );
                _socket.Send( _data, _data.Length, SocketFlags.None );
                while( true )
                {
                    var _client = _socket.Accept( );
                    _data = new byte[ _bytes ];
                    _client.Receive( _data, _bytes, SocketFlags.None );
                    if( _data.Length == 0 )
                    {
                        break;
                    }

                    _message = Encoding.ASCII.GetString( _data );
                    SendNotification( _message );
                }
            }
            catch( Exception _ex )
            {
                _socket?.Dispose( );
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
            bytes = _bytes;
            port = _port;
            data = _data;
            ipAddress = _ipAddress;
            endPoint = _ipEndPoint;
            socket = _socket;
            message = _message;
        }
    }
}