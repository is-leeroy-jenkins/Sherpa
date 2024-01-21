// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-16-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="EmailConfig.cs" company="Terry D. Eppler">
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
//   EmailConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Net.Mail;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    public class EmailConfig : EmailSettings
    {
        /// <summary>
        /// Gets or sets the recipient.
        /// </summary>
        /// <value>
        /// The recipient.
        /// </value>
        public IList<string> Recipients
        {
            get
            {
                return _recipients;
            }
            private set
            {
                _recipients = value;
            }
        }

        /// <summary>
        /// Gets or sets the carbon copy.
        /// </summary>
        /// <value>
        /// The carbon copy.
        /// </value>
        public IList<string> Copies
        {
            get
            {
                return _copies;
            }
            private set
            {
                _copies = value;
            }
        }

        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        /// <value>
        /// The sender.
        /// </value>
        public string Sender
        {
            get
            {
                return _sender;
            }
            private set
            {
                _sender = value;
            }
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName
        {
            get
            {
                return _displayName;
            }
            private set
            {
                _displayName = value;
            }
        }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public string Subject
        {
            get
            {
                return _subject;
            }
            private set
            {
                _subject = value;
            }
        }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        public MailPriority Priority
        {
            get
            {
                return _priority;
            }
            private set
            {
                _priority = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName
        {
            get
            {
                return _userName;
            }
            private set
            {
                _userName = value;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get
            {
                return _password;
            }
            private set
            {
                _password = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EmailConfig"/> class.
        /// </summary>
        public EmailConfig( )
        {
            _recipients = new List<string>( );
            _copies = new List<string>( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailConfig"/> class.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="secret">The pass.</param>
        /// <param name="recipients">The recipient.</param>
        /// <param name="copies">The copies.</param>
        /// <param name="priority"> </param>
        public EmailConfig( string sender, string subject, string userName, 
            string secret, IList<string> recipients, IList<string> copies, 
            MailPriority priority = MailPriority.Normal )
        {
            _sender = sender;
            _subject = subject;
            _userName = userName;
            _password = secret;
            _priority = priority;
            _recipients = recipients;
            _copies = copies;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EmailConfig"/> class.
        /// </summary>
        /// <param name="settings">The configuration.</param>
        public EmailConfig( EmailConfig settings )
        {
            _sender = settings.Sender;
            _subject = settings.Subject;
            _userName = settings.UserName;
            _password = settings.Password;
            _priority = settings.Priority;
            _recipients = settings.Recipients;
            _copies = settings.Copies;
        }

        /// <summary>
        /// Deconstructs the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="userName">Name of the user.</param>
        /// <param name="pass">The pass.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="recipient">The recipient.</param>
        /// <param name="copies">The copies.</param>
        public void Deconstruct( out string sender, out string subject, 
            out string userName, out string pass, out MailPriority priority, 
            out IList<string> recipient, out IList<string> copies )
        {
            sender = _sender;
            subject = _subject;
            userName = _userName;
            pass = _password;
            priority = _priority;
            recipient = _recipients;
            copies = _copies;
        }
    }
}
