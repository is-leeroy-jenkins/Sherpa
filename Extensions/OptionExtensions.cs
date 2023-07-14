// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-23-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-23-2023
// ******************************************************************************************
// <copyright file="OptionExtensions.cs" company="Terry D. Eppler">
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
//   OptionExtensions.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public static class OptionExtensions
    {
        /// <summary>
        /// Firsts the or none.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <returns></returns>
        public static Option<T> FirstOrNone<T>( this IEnumerable<T> enumerable )
        {
            return enumerable.Select( x => (Option<T>)new Some<T>( x ) ).FirstOrDefault( );
        }

        /// <summary>
        /// Firsts the or none.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public static Option<T> FirstOrNone<T>( this IEnumerable<T> enumerable,
            Func<T, bool> predicate )
        {
            return enumerable.Where( predicate ).FirstOrNone( );
        }

        /// <summary>
        /// Selects the optional.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public static IEnumerable<TResult> SelectOptional<T, TResult>( this IEnumerable<T> enumerable, 
            Func<T, Option<TResult>> map )
        {
            return (IEnumerable<TResult>)enumerable.Select( map )
                .OfType<Some<TResult>>( )
                .Select( s => s.IsSome );
        }
    }
}