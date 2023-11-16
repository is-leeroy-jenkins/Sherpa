// ************************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              15-11-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        15-11-2023
// ************************************************************************************************
// <copyright file="EmailValidator'.cs.cs" company="Terry D. Eppler">
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Eppler, Terry.cs
// </summary>
// ************************************************************************************************
namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public class EmailValidator : ValidationBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="index"></param>
        /// <param name="allowTopLevelDomains"></param>
        /// <param name="allowInternational"></param>
        /// <returns></returns>
        private static bool SkipDomain( string text, ref int index, bool allowTopLevelDomains,
            bool allowInternational )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text) );
                ThrowIf.Negative( index, nameof( index ) );
                if( !SkipSubDomain( text, ref index, allowInternational, out var type ) )
                {
                    return false;
                }

                if( ( index < text.Length )
                   && ( text[ index ] == '.' ) )
                {
                    do
                    {
                        index++;
                        if( index == text.Length )
                        {
                            return false;
                        }
                    
                        if( !SkipSubDomain( text, ref index, allowInternational, out type ) )
                        {
                            return false;
                        }
                    }
                    while( ( index < text.Length )
                          && ( text[ index ] == '.' ) );
                }
                else if( !allowTopLevelDomains )
                {
                    return false;
                }

                return type != SubDomainType.Numeric;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="index"></param>
        /// <param name="allowInternational"></param>
        /// <returns></returns>
        private static bool SkipQuoted( string text, ref int index, bool allowInternational )
        {
            var escaped = false;
            index++;
            while( index < text.Length )
            {
                if( IsControl( text[ index ] )
                   || ( ( text[ index ] >= 128 ) && !allowInternational ) )
                {
                    return false;
                }

                if( text[ index ] == '\\' )
                {
                    escaped = !escaped;
                }
                else if( !escaped )
                {
                    if( text[ index ] == '"' )
                    {
                        break;
                    }
                }
                else
                {
                    escaped = false;
                }

                index++;
            }

            if( ( index >= text.Length )
               || ( text[ index ] != '"' ) )
            {
                return false;
            }

            index++;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static bool SkipIPv4Literal( string text, ref int index )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                ThrowIf.Negative( index, nameof( index ) );
                var groups = 0;
                while( ( index < text.Length )
                      && ( groups < 4 ) )
                {
                    var startIndex = index;
                    var value = 0;
                    while( ( index < text.Length )
                          && IsDigit( text[ index ] ) )
                    {
                        value = value * 10 + ( text[ index ] - '0' );
                        index++;
                    }

                    if( ( index == startIndex )
                       || ( ( index - startIndex ) > 3 )
                       || ( value > 255 ) )
                    {
                        return false;
                    }

                    groups++;
                    if( ( groups < 4 )
                       && ( index < text.Length )
                       && ( text[ index ] == '.' ) )
                    {
                        index++;
                    }
                }

                return groups == 4;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsHexDigit( char c )
        {
            try
            {
                var _test = c.ToString( );
                ThrowIf.NullOrEmpty( _test, nameof( c ) );
                return ( ( c >= 'A' ) && ( c <= 'F' ) )
                    || ( ( c >= 'a' ) && ( c <= 'f' ) )
                    || ( ( c >= '0' ) && ( c <= '9' ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static bool SkipIPv6Literal( string text, ref int index )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                ThrowIf.Negative( index, nameof( index ) );
                var needGroup = false;
                var compact = false;
                var groups = 0;
                while( index < text.Length )
                {
                    var startIndex = index;
                    while( ( index < text.Length )
                          && IsHexDigit( text[ index ] ) )
                    {
                        index++;
                    }

                    if( index >= text.Length )
                    {
                        break;
                    }

                    if( ( index > startIndex )
                       && ( text[ index ] == '.' )
                       && ( compact || ( groups == 6 ) ) )
                    {
                        index = startIndex;
                        if( !SkipIPv4Literal( text, ref index ) )
                        {
                            return false;
                        }

                        return compact
                            ? groups <= 4
                            : groups == 6;
                    }

                    var count = index - startIndex;
                    if( count > 4 )
                    {
                        return false;
                    }

                    bool comp;
                    if( count > 0 )
                    {
                        needGroup = false;
                        comp = false;
                        groups++;
                        if( text[ index ] != ':' )
                        {
                            break;
                        }
                    }
                    else if( text[ index ] == ':' )
                    {
                        comp = true;
                    }
                    else
                    {
                        break;
                    }

                    startIndex = index;
                    while( ( index < text.Length )
                          && ( text[ index ] == ':' ) )
                    {
                        index++;
                    }

                    count = index - startIndex;
                    if( count > 2 )
                    {
                        return false;
                    }

                    if( count == 2 )
                    {
                        if( compact )
                        {
                            return false;
                        }

                        compact = true;
                    }
                    else if( comp )
                    {
                        return false;
                    }
                    else
                    {
                        needGroup = true;
                    }
                }

                return !needGroup
                    && ( compact
                        ? groups <= 6
                        : groups == 8 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="allowTopLevelDomains"></param>
        /// <param name="allowInternational"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool Validate( string email, bool allowTopLevelDomains = false,
            bool allowInternational = false )
        {
            try
            {
                ThrowIf.NullOrEmpty( email, nameof( email ) );
                var index = 0;
                if( email == null )
                {
                    throw new ArgumentNullException( nameof( email ) );
                }

                if( ( email.Length == 0 )
                   || ( Measure( email, 0, email.Length, allowInternational )
                       > MaxEmailAddressLength ) )
                {
                    return false;
                }

                if( email[ index ] == '"' )
                {
                    if( !SkipQuoted( email, ref index, allowInternational )
                       || ( index >= email.Length ) )
                    {
                        return false;
                    }
                }
                else
                {
                    if( !SkipAtom( email, ref index, allowInternational )
                       || ( index >= email.Length ) )
                    {
                        return false;
                    }

                    while( email[ index ] == '.' )
                    {
                        index++;
                        if( index >= email.Length )
                        {
                            return false;
                        }

                        if( !SkipAtom( email, ref index, allowInternational ) )
                        {
                            return false;
                        }

                        if( index >= email.Length )
                        {
                            return false;
                        }
                    }
                }

                var localPartLength = Measure( email, 0, index, allowInternational );
                if( ( ( index + 1 ) >= email.Length )
                   || ( localPartLength > MaxLocalPartLength )
                   || ( email[ index++ ] != '@' ) )
                {
                    return false;
                }

                if( email[ index ] != '[' )
                {
                    if( !SkipDomain( email, ref index, allowTopLevelDomains, allowInternational ) )
                    {
                        return false;
                    }

                    return index == email.Length;
                }

                index++;
                if( ( index + 7 ) >= email.Length )
                {
                    return false;
                }

                if( string.Compare( email, index, "IPv6:", 0, 5,
                       StringComparison.OrdinalIgnoreCase )
                   == 0 )
                {
                    index += "IPv6:".Length;
                    if( !SkipIPv6Literal( email, ref index ) )
                    {
                        return false;
                    }
                }
                else
                {
                    if( !SkipIPv4Literal( email, ref index ) )
                    {
                        return false;
                    }
                }

                if( ( index >= email.Length )
                   || ( email[ index++ ] != ']' ) )
                {
                    return false;
                }

                return index == email.Length;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }
    }
}