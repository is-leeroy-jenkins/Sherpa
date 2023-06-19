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
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Runtime.InteropServices;
    using System.Text;
    using Microsoft.Office.Interop.Outlook;
    using Attachment = System.Net.Mail.Attachment;
    using Exception = System.Exception;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class OutlookManager
    {
        /// <summary> Gets or sets the name of the host. </summary>
        /// <value> The name of the host. </value>
        public string HostName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/>
        /// class.
        /// </summary>
        public OutlookManager( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/>
        /// class.
        /// </summary>
        /// <param name="hostName"> Name of the host. </param>
        public OutlookManager( string hostName )
        {
            HostName = hostName;
        }

        /// <summary> Sends the mail. </summary>
        /// <param name="config"> The configuration. </param>
        /// <param name="content"> The content. </param>
        public void SendMail( OutlookConfig config, EmailContent content )
        {
            if( ( config != null )
               && ( content != null ) )
            {
                try
                {
                    var _message = CreateMessage( config, content );
                    Send( _message, config );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        private void ReadInboxItems( )
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

        /// <summary> Constructs the email message. </summary>
        /// <param name="config"> The configuration. </param>
        /// <param name="content"> The content. </param>
        /// <returns> </returns>
        private MailMessage CreateMessage( OutlookConfig config, EmailContent content )
        {
            if( ( config != null )
               && ( content != null ) )
            {
                try
                {
                    var _message = new MailMessage( );
                    for( var _j = 0; _j < config.Os.Length; _j++ )
                    {
                        var _to = config.Os[ _j ];
                        if( !string.IsNullOrEmpty( _to ) )
                        {
                            _message.To.Add( _to );
                        }
                    }

                    for( var _i = 0; _i < config.CCs.Length; _i++ )
                    {
                        var _cc = config.CCs[ _i ];
                        if( !string.IsNullOrEmpty( _cc ) )
                        {
                            _message.CC.Add( _cc );
                        }
                    }

                    _message.From = new MailAddress( config.From, config.DisplayName, Encoding.UTF8 );
                    _message.IsBodyHtml = content.IsHtml;
                    _message.Body = content.Content;
                    _message.Priority = config.Priority;
                    _message.Subject = config.Subject;
                    _message.BodyEncoding = Encoding.UTF8;
                    _message.SubjectEncoding = Encoding.UTF8;
                    if( content.AttachFileName != null )
                    {
                        var _data = new Attachment( content.AttachFileName, MediaTypeNames.Application.Zip );
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

            return default( MailMessage );
        }

        /// <summary> Sends the specified message. </summary>
        /// <param name="message"> The message. </param>
        /// <param name="config"> The configuration. </param>
        private void Send( MailMessage message, OutlookConfig config )
        {
            if( ( message != null )
               && ( config != null ) )
            {
                try
                {
                    var _client = new SmtpClient( );
                    _client.UseDefaultCredentials = false;
                    _client.Credentials = new NetworkCredential( config.UserName, config.Password );
                    _client.Host = HostName;
                    _client.Port = 25;
                    _client.EnableSsl = true;
                    _client.Send( message );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    message.Dispose( );
                }
            }
        }

        private static void ReleaseComObject( object obj )
        {
            if ( obj != null )
            {
                Marshal.ReleaseComObject( obj );
                obj = null;
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}