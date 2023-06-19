// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ProgramFinancingSchedule.cs" company="Terry D. Eppler">
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
//   ProgramFinancingSchedule.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ProgramFinancingSchedule
    {
        public int ID { get; set; }

        public string ReportYear { get; set; }

        public string TreasuryAgencyCode { get; set; }

        public string TreasuryAccountCode { get; set; }

        public string LedgerAccountCode { get; set; }

        public string SectionNumber { get; set; }

        public string SectionName { get; set; }

        public string LineNumber { get; set; }

        public string LineDescription { get; set; }

        public string OmbAgencyCode { get; set; }

        public string OmbFundCode { get; set; }

        public string OmbAccountTitle { get; set; }

        public string AgencySequence { get; set; }

        public string AccountSequence { get; set; }

        public string FundName { get; set; }

        public double OriginalAmount { get; set; }

        public double BudgetAmount { get; set; }

        public double AgencyAmount { get; set; }

        public double Amount { get; set; }

        public string AgencyName { get; set; }

        public Source Source { get; set; }

        public DataRow Record { get; set; }

        public IDictionary<string, object> Data { get; set; }

        public ProgramFinancingSchedule( )
        {
        }

        public ProgramFinancingSchedule( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        public ProgramFinancingSchedule( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        public ProgramFinancingSchedule( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}