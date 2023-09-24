// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-29-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ThrowIf.cs" company="Terry D. Eppler">
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
//   ThrowIf.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.CodeDom;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class ThrowIf
    {
        /// <summary>
        /// Determines whether the specified string
        /// argument is null or empty.
        /// </summary>
        /// <param name="argument">
        /// The string argument.
        /// </param>
        /// <param name = "paramName" >
        /// The name of the string argument.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// </exception>
        public static void NullOrEmpty( string argument, string paramName )
        {
            if( string.IsNullOrEmpty( argument )
               && !string.IsNullOrEmpty( paramName ) )
            {
                var _message = @$"string {paramName} can't be null or empty!";
                throw new ArgumentNullException( paramName, _message );
            }
        }

        /// <summary>
        /// Nulls the specified argument.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static void NullOrEmpty( object argument, string paramName )
        {
            if( !string.IsNullOrEmpty( paramName ) )
            {
                switch( argument )
                {
                    case string _args when string.IsNullOrEmpty( _args ):

                    {
                        var _message = @$"string {paramName} can't be null or empty!";
                        throw new ArgumentNullException( _message );
                    }
                    case IListSource _listSource when _listSource == null:

                    {
                        throw new ArgumentNullException( paramName );
                    }
                    case IEnumerable<DataRow> _list when _list == null:

                    {
                        throw new ArgumentNullException( paramName );
                    }
                    case ICollection _collection when _collection == null:
                    {
                        throw new ArgumentNullException( paramName );
                    }
                    case IList<string> _stringList when _stringList == null:
                    {
                        throw new ArgumentNullException( paramName );
                    }
                }
            }
        }

        /// <summary>
        /// Determines whether the specified argument is negative.
        /// </summary>
        /// <param name="argument">
        /// The argument.
        /// </param>
        /// <param name = "paramName" >
        /// The argument's name.
        /// </param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        public static void Negative( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"{paramName} can't be less than zero!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument">
        /// The argument.</param>
        /// <param name="paramName">
        /// Name of the parameter.
        /// </param>
        /// <returns>
        /// Throws Out of Range Exception
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">paramName, _message</exception>
        public static void NegativeOrZero( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"{paramName} can't be less than zero!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }
    }
}