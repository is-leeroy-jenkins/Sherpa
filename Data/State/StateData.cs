﻿//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                StateData.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="StateData.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    StateData.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class StateData : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        private protected string _selectedTable;

        /// <summary>
        /// 
        /// </summary>
        private protected string _sqlQuery;

        /// <summary>
        /// 
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// 
        /// </summary>
        private protected Provider _provider;

        /// <summary>
        /// 
        /// </summary>
        private protected IDictionary<string, object> _filter;

        /// <summary>
        /// 
        /// </summary>
        private protected IList<string> _selectedFields;

        /// <summary>
        /// 
        /// </summary>
        private protected IList<string> _selectedColumns;

        /// <summary>
        /// 
        /// </summary>
        private protected IList<string> _selectedNumerics;

        /// <summary>
        /// 
        /// </summary>
        private protected IList<DateTime> _selectedDates;
    }
}