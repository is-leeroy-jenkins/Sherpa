// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Guidance.cs" company="Terry D. Eppler">
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
//   Guidance.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public enum Guidance
    {
        /// <summary> The funds control manual </summary>
        FundsControlManual,

        /// <summary> The boc manual </summary>
        ObjectClassManual,

        /// <summary> The cf R31 </summary>
        Cfr31,

        /// <summary> The omb a11 </summary>
        Omba11,

        /// <summary> The official travel </summary>
        OfficialTravel,

        /// <summary> The superfund introduction </summary>
        SuperfundIntroduction,

        /// <summary> The superfund general information </summary>
        SuperfundGeneralInformation,

        /// <summary> The superfund resource management </summary>
        SuperfundResourceManagement,

        /// <summary> The superfund cost recovery </summary>
        SuperfundCostRecovery,

        /// <summary> The superfund direct charging </summary>
        SuperfundDirectCharging,

        /// <summary> The superfund inter agency agreements </summary>
        SuperfundInterAgencyAgreements,

        /// <summary> The superfund personnel and support costs </summary>
        SuperfundPersonnelAndSupportCosts,

        /// <summary> The superfund site specific costs </summary>
        SuperfundSiteSpecificCosts,

        /// <summary> The superfund site special accounts </summary>
        SuperfundSiteSpecialAccounts,

        /// <summary> The superfund state contracts </summary>
        SuperfundStateContracts,

        /// <summary> The superfund cost share </summary>
        SuperfundCostShare
    }
}