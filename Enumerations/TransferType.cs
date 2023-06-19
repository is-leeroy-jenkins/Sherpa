// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="TransferType.cs" company="Terry D. Eppler">
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
//   TransferType.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;

    /// <summary> Defines the IsTransfer </summary>
    public enum TransferType
    {
        /// <summary> The ns </summary>
        Ns = 0,

        /// <summary> Defines the Admin </summary>
        Admin = 1,

        /// <summary> Defines the BOC </summary>
        BOC = 2,

        /// <summary> Defines the FromHQ </summary>
        FromHq = 3,

        /// <summary> Defines the ToHQ </summary>
        ToHq = 4,

        /// <summary> Defines the FromRpio </summary>
        FromRpio = 5,

        /// <summary> Defines the ToRpio </summary>
        ToRpio = 6,

        /// <summary> Defines the Recertification </summary>
        Recertification = 7,

        /// <summary> Defines the ToDivision </summary>
        ToDivision = 8,

        /// <summary> Defines the FromDivsion </summary>
        FromDivsion = 9,

        /// <summary> Defines the SubAllowance </summary>
        SubAllowance = 10
    }
}