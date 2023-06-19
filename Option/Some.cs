// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="Some.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the 
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  $CURRENT_YEAR$  Terry Eppler
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
//   Some.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="T:BudgetExecution.IOption`1" />
    public class Some<T> : IOption<T>
    {
        /// <summary>
        /// The data
        /// </summary>
        private readonly T _data;

        /// <summary>
        /// Initializes a new instance of the <see cref="Some{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private Some( T value )
        {
            _data = value;
        }

        /// <summary>
        /// Ofs the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static IOption<T> Of( T value )
        {
            return new Some<T>( value );
        }

        /// <inheritdoc />
        /// <summary>
        /// Matches the specified on some.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="some">The on some.</param>
        /// <param name="none">The on none.</param>
        /// <returns></returns>
        public TResult Match<TResult>( Func<T, TResult> some, Func<TResult> none )
        {
            return some( _data );
        }

        /// <inheritdoc />
        /// <summary>
        /// Binds the specified f.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The f.</param>
        /// <returns></returns>
        public IOption<TResult> Bind<TResult>( Func<T, IOption<TResult>> func )
        {
            return func( _data );
        }

        /// <inheritdoc />
        /// <summary>
        /// Maps the specified function.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="func">The function.</param>
        /// <returns></returns>
        public IOption<TResult> Map<TResult>( Func<T, TResult> func )
        {
            return new Some<TResult>( func( _data ) );
        }

        /// <inheritdoc />
        /// <summary>
        /// Ors the specified a default.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        /// T
        /// </returns>
        public T Or( T value )
        {
            return _data;
        }
    }
}
