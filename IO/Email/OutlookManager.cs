// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-16-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="EmailManager.cs" company="Terry D. Eppler">
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   EmailManager.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Runtime.InteropServices;
    using System.Text;
    using Microsoft.Office.Interop.Outlook;
    using System.Net.Mail;
    using Attachment = System.Net.Mail.Attachment;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantAssignment" ) ]
    public class OutlookManager : MailManager
    {
        /// <summary>
        /// Gets or sets the name of the host.
        /// </summary>
        /// <value>
        /// The name of the host.
        /// </value>
        public string HostName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/> class.
        /// </summary>
        public OutlookManager( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/> class.
        /// </summary>
        /// <param name="hostName">Name of the host.</param>
        public OutlookManager( string hostName )
        {
            _hostName = hostName;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/> class.
        /// </summary>
        /// <param name="outlook">The outlook.</param>
        public OutlookManager( OutlookManager outlook )
        {
            _hostName = outlook.HostName;
        }

        /// <summary>
        /// Deconstructs the specified host.
        /// </summary>
        /// <param name="hostName">The host.</param>
        public void Deconstruct( out string hostName )
        {
            hostName = _hostName;
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="content">The content.</param>
        public void SendEmail( EmailConfiguration configuration, EmailContent content )
        {
            try
            {
                ThrowIf.Null( configuration, nameof( configuration ) );
                ThrowIf.Null( content, nameof( content ) );
                var _message = CreateMessage( configuration, content );
                Send( _message, configuration );
            }
            catch( System.Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="configuration">The configuration.</param>
        private protected void Send( MailMessage message, EmailConfiguration configuration )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                ThrowIf.Null( configuration, nameof( configuration ) );
                var _client = new SmtpClient( );
                _client.UseDefaultCredentials = false;
                _client.Credentials = new NetworkCredential( configuration.UserName, 
                    configuration.Password );

                _client.Host = HostName;
                _client.Port = 25;
                _client.EnableSsl = true;
                _client.Send( message );
            }
            catch( System.Exception _ex )
            {
                Fail( _ex );
                message.Dispose( );
            }
        }

        /// <summary>
        /// Reads the email inbox items.
        /// </summary>
        public void ReadEmailInboxItems( )
        {
            Application _outlook = null;
            NameSpace _namespace = null;
            MAPIFolder _inbox = null;
            Items _items = null;
            try
            {
                _outlook = new Application( );
                _namespace = _outlook.GetNamespace( "MAPI" );
                _inbox = _namespace.GetDefaultFolder( OlDefaultFolders.olFolderInbox );
                _items = _inbox.Items;
                foreach( MailItem _item in _items )
                {
                    var _builder = new StringBuilder( );
                    _builder.AppendLine( "From: " + _item.SenderEmailAddress );
                    _builder.AppendLine( "To: " + _item.To );
                    _builder.AppendLine( "CC: " + _item.CC );
                    _builder.AppendLine( "" );
                    _builder.AppendLine( "Subject: " + _item.Subject );
                    _builder.AppendLine( _item.Body );
                    Marshal.ReleaseComObject( _item );
                }
            }
            catch( System.Exception _ex )
            {
                Fail( _ex );
            }
            finally
            {
                ReleaseComObject( _items );
                ReleaseComObject( _inbox );
                ReleaseComObject( _namespace );
                ReleaseComObject( _outlook );
            }
        }

        /// <summary>
        /// Creates the message.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public MailMessage CreateMessage( EmailConfiguration configuration, EmailContent content )
        {
            try
            {
                ThrowIf.Null( configuration, nameof( configuration ) );
                ThrowIf.Null( content, nameof( content ) );
                var _message = new MailMessage( );
                for( var _i = 0; _i < configuration.Recipients.Count; _i++ )
                {
                    var _to = configuration.Recipients[ _i ];
                    if( !string.IsNullOrEmpty( _to ) )
                    {
                        _message.To.Add( _to );
                    }
                }

                for( var _h = 0; _h < configuration.Copies.Count; _h++ )
                {
                    var _cc = configuration.Copies[ _h ];
                    if( !string.IsNullOrEmpty( _cc ) )
                    {
                        _message.CC.Add( _cc );
                    }
                }

                _message.From = new MailAddress( configuration.Sender, 
                    configuration.DisplayName, Encoding.UTF8 );

                _message.IsBodyHtml = content.IsHtml;
                _message.Body = content.Message;
                _message.Priority = configuration.Priority;
                _message.Subject = configuration.Subject;
                _message.BodyEncoding = Encoding.UTF8;
                _message.SubjectEncoding = Encoding.UTF8;
                if( content.Attachment != null )
                {
                    var _attachment = new Attachment( content.Attachment, 
                        MediaTypeNames.Application.Zip );

                    _message.Attachments.Add( _attachment );
                }

                return _message;
            }
            catch( System.Exception _ex )
            {
                Fail( _ex );
                return default( MailMessage );
            }
        }
    }
}