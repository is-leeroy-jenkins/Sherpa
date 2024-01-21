// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-16-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="EmailContent.cs" company="Terry D. Eppler">
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
//   EmailContent.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class EmailContent : EmailSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is HTML.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is HTML; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool IsHtml
        {
            get
            {
                return _isHtml;
            }
            private set
            {
                _isHtml = value;
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
        /// Gets or sets the attachment.
        /// </summary>
        /// <value>
        /// The attachment.
        /// </value>
        public string Attachment
        {
            get
            {
                return _attachment;
            }
            private set
            {
                _attachment = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EmailContent"/>
        /// class.
        /// </summary>
        public EmailContent( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EmailContent"/> class.
        /// </summary>
        /// <param name="message"> The content. </param>
        /// <param name="filePath"> Name of the attachment. </param>
        /// <param name="isHtml"> if set to <c> true </c> [is HTML]. </param>
        public EmailContent( string message, string filePath, bool isHtml = true )
        {
            _message = message;
            _isHtml = isHtml;
            _attachment = filePath;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="EmailContent"/> class.
        /// </summary>
        /// <param name="content">The email.</param>
        public EmailContent( EmailContent content )
        {
            _message = content.Message;
            _isHtml = content.IsHtml;
            _attachment = content.Attachment;
        }

        /// <summary> Deconstructs the specified is HTML. </summary>
        /// <param name="isHtml">
        /// if set to
        /// <c> true </c>
        /// [is HTML].
        /// </param>
        /// <param name="message">
        /// The content.
        /// </param>
        /// <param name="filePath">
        /// </param>
        public void Deconstruct( out string message, out string filePath, out bool isHtml )
        {
            isHtml = _isHtml;
            message = _message;
            filePath = _attachment;
        }

        /// <summary> Converts to string. </summary>
        /// <returns>
        /// A
        /// <see cref="System.String"/>
        /// that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( _message )
                    ? _message
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }
    }
}