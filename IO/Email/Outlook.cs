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

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantAssignment" ) ]
    public class Outlook : EmailManager
    {
        /// <summary>
        /// Gets or sets the name of the host.
        /// </summary>
        /// <value>
        /// The name of the host.
        /// </value>
        public string HostName
        {
            get
            {
                return _hostName;
            }
            private set
            {
                _hostName = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Outlook"/> class.
        /// </summary>
        public Outlook( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Outlook"/> class.
        /// </summary>
        /// <param name="hostName">Name of the host.</param>
        public Outlook( string hostName )
        {
            _hostName = hostName;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Outlook"/> class.
        /// </summary>
        /// <param name="outlook">The outlook.</param>
        public Outlook( Outlook outlook )
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
        /// <param name="config">The configuration.</param>
        /// <param name="content">The content.</param>
        public void SendEmail( EmailConfig config, EmailContent content )
        {
            try
            {
                ThrowIf.Null( config, nameof( config ) );
                ThrowIf.Null( content, nameof( content ) );
                var _message = CreateMessage( config, content );
                Send( _message, config );
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
        private protected void Send( MailMessage message, EmailConfig configuration )
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
        /// <param name="emailSettings">The configuration.</param>
        /// <param name="emailContent">The content.</param>
        /// <returns></returns>
        public MailMessage CreateMessage( EmailConfig emailSettings, EmailContent emailContent )
        {
            try
            {
                ThrowIf.Null( emailSettings, nameof( emailSettings ) );
                ThrowIf.Null( emailContent, nameof( emailContent ) );
                var _message = new MailMessage( );
                for( var _i = 0; _i < emailSettings.Recipients.Count; _i++ )
                {
                    var _to = emailSettings.Recipients[ _i ];
                    if( !string.IsNullOrEmpty( _to ) )
                    {
                        _message.To.Add( _to );
                    }
                }

                for( var _h = 0; _h < emailSettings.Copies.Count; _h++ )
                {
                    var _cc = emailSettings.Copies[ _h ];
                    if( !string.IsNullOrEmpty( _cc ) )
                    {
                        _message.CC.Add( _cc );
                    }
                }

                _message.From = new MailAddress( emailSettings.Sender, 
                    emailSettings.DisplayName, Encoding.UTF8 );

                _message.IsBodyHtml = emailContent.IsHtml;
                _message.Body = emailContent.Message;
                _message.Priority = emailSettings.Priority;
                _message.Subject = emailSettings.Subject;
                _message.BodyEncoding = Encoding.UTF8;
                _message.SubjectEncoding = Encoding.UTF8;
                if( emailContent.Attachment != null )
                {
                    var _attachment = new System.Net.Mail.Attachment( emailContent.Attachment, 
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