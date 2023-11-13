// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-16-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="OutlookManager.cs" company="Terry D. Eppler">
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
//   OutlookManager.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using Microsoft.Office.Interop.Outlook;
    using Attachment = System.Net.Mail.Attachment;
    using Exception = System.Exception;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class OutlookManager
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
            HostName = hostName;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/> class.
        /// </summary>
        /// <param name="outlook">The outlook.</param>
        public OutlookManager( OutlookManager outlook )
        {
            HostName = outlook.HostName;
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="content">The content.</param>
        public void SendEmail( OutlookConfig config, EmailContent content )
        {
            try
            {
                ThrowIf.Null( config, nameof( config ) );
                ThrowIf.Null( content, nameof( content ) );
                var _message = CreateMessage( config, content );
                SendEmail( _message, config );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="config">The configuration.</param>
        private void SendEmail( MailMessage message, OutlookConfig config )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                ThrowIf.Null( config, nameof( config ) );
                var _smtpClient = new SmtpClient( );
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new NetworkCredential( config.UserName, config.Password );
                _smtpClient.Host = HostName;
                _smtpClient.Port = 25;
                _smtpClient.EnableSsl = true;
                _smtpClient.Send( message );
            }
            catch( Exception _ex )
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
                foreach ( MailItem _item in _items )
                {
                    var _stringBuilder = new StringBuilder( );
                    _stringBuilder.AppendLine( "From: " + _item.SenderEmailAddress );
                    _stringBuilder.AppendLine( "To: " + _item.To );
                    _stringBuilder.AppendLine( "CC: " + _item.CC );
                    _stringBuilder.AppendLine( "" );
                    _stringBuilder.AppendLine( "Subject: " + _item.Subject );
                    _stringBuilder.AppendLine( _item.Body );
                    Marshal.ReleaseComObject( _item );
                }
            }
            catch( Exception _ex )
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
        /// <param name="config">The configuration.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public MailMessage CreateMessage( OutlookConfig config, EmailContent content )
        {
            try
            {
                ThrowIf.Null( config, "config" );
                ThrowIf.Null( content, "content" );
                var _message = new MailMessage( );
                for( var _i = 0; _i < config.Recipient.Count; _i++ )
                {
                    var _to = config.Recipient[ _i ];
                    if( !string.IsNullOrEmpty( _to ) )
                    {
                        _message.To.Add( _to );
                    }
                }

                for( var _h = 0; _h < config.CarbonCopy.Count; _h++ )
                {
                    var _cc = config.CarbonCopy[ _h ];
                    if( !string.IsNullOrEmpty( _cc ) )
                    {
                        _message.CC.Add( _cc );
                    }
                }

                _message.From = new MailAddress( config.Sender, config.DisplayName, Encoding.UTF8 );
                _message.IsBodyHtml = content.IsHtml;
                _message.Body = content.Message;
                _message.Priority = config.Priority;
                _message.Subject = config.Subject;
                _message.BodyEncoding = Encoding.UTF8;
                _message.SubjectEncoding = Encoding.UTF8;
                if( content.Attachment != null )
                {
                    var _data = new Attachment( content.Attachment,
                        MediaTypeNames.Application.Zip );

                    _message.Attachments.Add( _data );
                }

                return _message;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( MailMessage );
            }
        }

        /// <summary>
        /// Releases the COM object.
        /// </summary>
        /// <param name="obj">The object.</param>
        private static void ReleaseComObject( object obj )
        {
            if( obj != null )
            {
                Marshal.ReleaseComObject( obj );
                obj = null;
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