// <copyright file = "StringExtensions.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class StringExtensions
    {
        /// <summary>
        /// The SplitPascal
        /// </summary>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        /// <param name = "text" >
        /// The text.
        /// </param>
        /// <returns>
        /// </returns>
        public static string SplitPascal( this string text )
        {
            try
            {
                return string.IsNullOrEmpty( text ) || text.Length < 5
                    ? text
                    : Regex.Replace( text, "([A-Z])", " $1", RegexOptions.Compiled ).Trim();
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// The ToProperCase
        /// </summary>
        /// <param name = "text" >
        /// The text <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        [ SuppressMessage( "ReSharper", "UnusedMethodReturnValue.Global" ) ]
        public static string ToProperCase( this string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    var _culture = Thread.CurrentThread.CurrentCulture;
                    var _info = _culture.TextInfo;

                    return !string.IsNullOrEmpty( _info.ToTitleCase( text ) )
                        ? _info.ToTitleCase( text )
                        : default( string );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// The IfNullThen
        /// </summary>
        /// <param name = "text" >
        /// The text <see cref = "string"/>
        /// </param>
        /// <param name = "alt" >
        /// The alt <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        public static string IfNullThen( this string text, string alt )
        {
            try
            {
                return text ?? alt ?? string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// The ToEnum
        /// </summary>
        /// <typeparam name = "T" >
        /// </typeparam>
        /// <param name = "text" >
        /// The text <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see cref = "T"/>
        /// </returns>
        public static T ToEnum<T>( this string text ) where T : struct
        {
            try
            {
                return (T)Enum.Parse( typeof( T ), text, true );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( T );
            }
        }

        /// <summary>
        /// The Right
        /// </summary>
        /// <param name = "text" >
        /// The text <see cref = "string"/>
        /// </param>
        /// <param name = "length" >
        /// The length <see cref = "int"/>
        /// </param>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        public static string Last( this string text, int length )
        {
            try
            {
                return text?.Length > length
                    ? text.Substring( text.Length - length )
                    : text;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// The Left
        /// </summary>
        /// <param name = "text" >
        /// The text <see cref = "string"/>
        /// </param>
        /// <param name = "length" >
        /// The length <see cref = "int"/>
        /// </param>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        public static string First( this string text, int length )
        {
            try
            {
                return text?.Length > length
                    ? text.Substring( 0, length )
                    : text;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// The FirstToUpper
        /// </summary>
        /// <param name = "text" >
        /// The theString <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see cref = "string"/>
        /// </returns>
        public static string FirstToUpper( this string text )
        {
            try
            {
                if( !string.IsNullOrEmpty( text ) )
                {
                    var letters = text.ToCharArray();
                    letters[ 0 ] = char.ToUpper( letters[ 0 ] );
                    return new string( letters );
                }
                else
                {
                    return default( string );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// The ToDateTime
        /// </summary>
        /// <param name = "text" >
        /// The text <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see/>
        /// </returns>
        public static DateTime ToDateTime( this string text )
        {
            try
            {
                return DateTime.Parse( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DateTime );
            }
        }

        /// <summary>
        /// The ToStream
        /// </summary>
        /// <param name = "text" >
        /// The source <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see cref = "MemoryStream"/>
        /// </returns>
        public static MemoryStream GetMemoryStream( this string text )
        {
            try
            {
                var bytes = Encoding.UTF8.GetBytes( text );
                return new MemoryStream( bytes );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( MemoryStream );
            }
        }

        /// <summary>
        /// The WordCount
        /// </summary>
        /// <param name = "text" >
        /// The input <see cref = "string"/>
        /// </param>
        /// <returns>
        /// The <see cref = "int"/>
        /// </returns>
        public static int WordCount( this string text )
        {
            var count = 0;

            try
            {
                // Exclude whitespaces, Tabs and line breaks
                var re = new Regex( @"[^\text]+" );
                var matches = re.Matches( text );
                count = matches.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return count;
            }

            return count;
        }

        /// <summary>
        /// Read a text file and obtain it'text contents.
        /// </summary>
        /// <param name = "text" >
        /// The complete file path to write to.
        /// </param>
        /// <returns>
        /// String containing the content of the file.
        /// </returns>
        public static StreamReader GetStreamReader( this string text )
        {
            try
            {
                return !string.IsNullOrEmpty( text )
                    ? new StreamReader( text )
                    : default( StreamReader );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( StreamReader );
            }
        }

        /// <summary>
        /// Writes out a text to a file.
        /// </summary>
        /// <param name = "text" >
        /// The complete file path to write to.
        /// </param>
        /// <param name = "file" >
        /// A String containing text to be written to the file.
        /// </param>
        public static void WriteToFile( this string text, string file )
        {
            if( !string.IsNullOrEmpty( text )
                && !string.IsNullOrEmpty( file ) )
            {
                try
                {
                    using var _writer = new StreamWriter( text, false );
                    _writer.Write( file );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Send an email using the supplied string.
        /// </summary>
        /// <param name = "body" >
        /// String that will be used i the body of the email.
        /// </param>
        /// <param name = "subject" >
        /// Subject of the email.
        /// </param>
        /// <param name = "sender" >
        /// The email address from which the message was sent.
        /// </param>
        /// <param name = "recipient" >
        /// The receiver of the email.
        /// </param>
        /// <param name = "server" >
        /// The server from which the email will be sent.
        /// </param>
        /// <returns>
        /// A boolean value indicating the success of the email send.
        /// </returns>
        public static bool Email( this string body, string subject, string sender,
            string recipient, string server )
        {
            try
            {
                var _message = new MailMessage();
                _message.To.Add( recipient );
                var _address = new MailAddress( sender );
                _message.From = _address;
                _message.Subject = subject;
                _message.Body = body;
                var _client = new SmtpClient( server );
                var _credentials = new NetworkCredential();
                _client.Credentials = _credentials;
                _client.Send( _message );
                return true;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// remove white space, not line end Useful when parsing user input such phone,
        /// price int.Parse("1 000 000".RemoveSpaces(),.....
        /// </summary>
        /// <param name = "text" >
        /// </param>
        public static string RemoveSpaces( this string text )
        {
            if( !string.IsNullOrEmpty( text )
                && text.Contains( " " ) )
            {
                try
                {
                    return text.Replace( " ", "" );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return text;
                }
            }

            return text;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
