// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ILabel.cs" company="Terry D. Eppler">
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
//   ILabel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary> </summary>
    public interface ILabel
    {
        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        void SetText( string text );

        /// <summary> Sets the binding source. </summary>
        /// <param name = "bindingSource" > The binding source. </param>
        void SetDataSource<T1>( T1 bindingSource )
            where T1 : IBindingList;

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > </typeparam>
        /// <typeparam name = "T2" > The type of the 2. </typeparam>
        /// <param name = "bindingList" > The binding source. </param>
        /// <param name = "dict" > The dictionary. </param>
        void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>;

        /// <summary> Sets the binding source. </summary>
        /// <param name = "data" > The data. </param>
        void SetDataSource<T1>( IEnumerable<T1> data )
            where T1 : IEnumerable<T1>;

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "dict" > The dictionary. </param>
        void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<T1>;

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <typeparam name = "T2" > The type of the 2. </typeparam>
        /// <typeparam name = "T3" > The type of the 3. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "field" > The field. </param>
        /// <param name = "filter" > The dictionary. </param>
        void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<T1>
            where T2 : struct;

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "field" > The field. </param>
        void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<T1>;

        /// <summary> Sets the bindings. </summary>
        /// <param name = "data" > The data. </param>
        /// <param> The numeric. </param>
        /// <param name = "dict" > </param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<T1>
            where T2 : IDictionary<string, object>;

        /// <summary> Sets the binding source. </summary>
        /// <param name = "data" > The data. </param>
        /// <param name = "field" > The field. </param>
        /// <param name = "filter" > The filter. </param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<T1>
            where T2 : struct;
    }
}