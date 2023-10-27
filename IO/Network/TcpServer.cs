//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                TcpServer.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="TcpServer.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    TcpServer.cs
//  </summary>
//  ******************************************************************************************

using System;

namespace BudgetExecution.IO.Network
{
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "ConvertConstructorToMemberInitializers" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class TcpServer
    {
        /// <summary> Gets or sets the count. </summary>
        /// <value> The count. </value>
        public int Bytes { get; set; }

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

        /// <summary> Gets or sets the remote end point. </summary>
        /// <value> The remote end point. </value>
        public IPEndPoint Remote { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="TcpServer"/>
        /// class.
        /// </summary>
        public TcpServer( )
        {
            Buffer = new byte[ 1024 ];
            Local = new IPEndPoint( IPAddress.Any, 9050 );
            Server = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
        }

        /// <summary> Connects this instance. </summary>
        public void Connect( )
        {
            Client = Server.Accept( );
            Remote = Client.RemoteEndPoint as IPEndPoint;
            var _message = "Welcome to my test server";
            Buffer = Encoding.ASCII.GetBytes( _message );
            Client.Send( Buffer, Buffer.Length, SocketFlags.None );
            while( true )
            {
                Buffer = new byte[ 1024 ];
                Bytes = Client.Receive( Buffer );
                if( Bytes == 0 )
                {
                    break;
                }

                Console.WriteLine( Encoding.ASCII.GetString( Buffer, 0, Bytes ) );
                Client.Send( Buffer, Bytes, SocketFlags.None );
            }

            Server.Bind( Local );
            Server.Listen( 10 );
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