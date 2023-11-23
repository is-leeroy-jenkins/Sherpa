// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="TypeObject.cs" company="Terry D. Eppler">
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
//   TypeObject.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "CompareNonConstrainedGenericWithNull" ) ]
    public static class TypeExtensions
    {
        /// <summary> Converts to json. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="type"> The type. </param>
        /// <returns> </returns>
        public static string ToJson<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _encoding = Encoding.Default;
                    var _serializer = new DataContractJsonSerializer( typeof( T ) );
                    using var _stream = new MemoryStream( );
                    _serializer.WriteObject( _stream, type );
                    var _json = _encoding.GetString( _stream.ToArray( ) );
                    return _json;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary> Javas the script serialize. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="type"> The type. </param>
        /// <returns> </returns>
        public static string JavaScriptSerialize<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _encoding = Encoding.Default;
                    var _serializer = new DataContractJsonSerializer( typeof( T ) );
                    using var _stream = new MemoryStream( );
                    _serializer.WriteObject( _stream, type );
                    var _json = _encoding.GetString( _stream.ToArray( ) );
                    return _json;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary> XMLs the serialize. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="type"> The type. </param>
        /// <returns> </returns>
        public static string XmlSerialize<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _serializer = new XmlSerializer( type.GetType( ) );
                    using var _writer = new StringWriter( );
                    _serializer?.Serialize( _writer, type );
                    var _string = _writer?.GetStringBuilder( )?.ToString( );
                    using var _reader = new StringReader( _string );
                    return _reader?.ReadToEnd( ) ?? string.Empty;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}