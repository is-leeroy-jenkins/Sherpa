// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="PayrollCostCode.cs" company="Terry D. Eppler">
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
//   PayrollCostCode.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PayrollCostCode : DataUnit
    {
        /// <summary>
        /// Gets or sets the rpio.
        /// </summary>
        /// <value>
        /// The rpio.
        /// </value>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public string RcCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the division.
        /// </summary>
        /// <value>
        /// The name of the division.
        /// </value>
        public string DivisionName { get; set; }

        /// <summary>
        /// Gets or sets the work code.
        /// </summary>
        /// <value>
        /// The work code.
        /// </value>
        public string WorkCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the work code.
        /// </summary>
        /// <value>
        /// The name of the work code.
        /// </value>
        public string WorkCodeName { get; set; }

        /// <summary>
        /// Gets or sets the hr org code.
        /// </summary>
        /// <value>
        /// The hr org code.
        /// </value>
        public string HrOrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the hr org.
        /// </summary>
        /// <value>
        /// The name of the hr org.
        /// </value>
        public string HrOrgName { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        public PayrollCostCode( )
        {
            Source = Source.PayrollCostCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public PayrollCostCode( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PayrollCostCodesId" ].ToString( ) );
            RPIO = Record[ "RPIO" ].ToString(  );
            AhCode = Record[ "AhCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            RcCode = Record[ "RcCode" ].ToString(  );
            WorkCode = Record[ "WorkCode" ].ToString(  );
            WorkCodeName = Record[ "WorkCodeName" ].ToString(  );
            HrOrgCode = Record[ "HrOrgCode" ].ToString(  );
            HrOrgName = Record[ "HrOrgName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public PayrollCostCode( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PayrollCostCodesId" ].ToString( ) );
            RPIO = Record[ "RPIO" ].ToString(  );
            AhCode = Record[ "AhCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            RcCode = Record[ "RcCode" ].ToString(  );
            WorkCode = Record[ "WorkCode" ].ToString(  );
            WorkCodeName = Record[ "WorkCodeName" ].ToString(  );
            HrOrgCode = Record[ "HrOrgCode" ].ToString(  );
            HrOrgName = Record[ "HrOrgName" ].ToString(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollCostCode"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public PayrollCostCode( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "PayrollCostCodesId" ].ToString( ) );
            RPIO = Record[ "RPIO" ].ToString(  );
            AhCode = Record[ "AhCode" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            RcCode = Record[ "RcCode" ].ToString(  );
            WorkCode = Record[ "WorkCode" ].ToString(  );
            WorkCodeName = Record[ "WorkCodeName" ].ToString(  );
            HrOrgCode = Record[ "HrOrgCode" ].ToString(  );
            HrOrgName = Record[ "HrOrgName" ].ToString(  );
        }

        public PayrollCostCode( PayrollCostCode code )
        {
            ID = code.ID;
            RPIO = code.RPIO;
            AhCode = code.AhCode;
            BFY = code.BFY;
            RcCode = code.RcCode;
            WorkCode = code.WorkCode;
            WorkCodeName = code.WorkCodeName;
            HrOrgCode = code.HrOrgCode;
            HrOrgName = code.HrOrgName;
        }
    }
}