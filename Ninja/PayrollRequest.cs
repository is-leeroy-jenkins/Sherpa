// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="PayrollRequest.cs" company="Terry D. Eppler">
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
//   PayrollRequest.cs
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
    /// <seealso cref="BudgetExecution.AdministrativeRequests" />
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class PayrollRequest : AdministrativeRequests
    {
        /// <summary>
        /// Gets or sets the original request date.
        /// </summary>
        /// <value>
        /// The original request date.
        /// </value>
        public virtual DateOnly OriginalRequestDate { get; set; }

        /// <summary>
        /// Gets or sets the last activity date.
        /// </summary>
        /// <value>
        /// The last activity date.
        /// </value>
        public virtual DateOnly LastActivityDate { get; set; }

        public PayrollRequest( )
        {
            Source = Source.PayrollRequests;
        }
        
        public PayrollRequest( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString( );
            DocumentTitle = Record[ "DocumentTitle" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            FundCode = Record[ "FundCode" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString( );
            Comments = Record[ "Comments" ].ToString( );
            OriginalRequestDate = DateOnly.Parse( Record[ "OriginalRequestDate" ].ToString( ) ?? "" );
            LastActivityDate = DateOnly.Parse( Record[ "LastActivityDate" ].ToString( ) ?? "" );
        }
        
        public PayrollRequest( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = Record[ "Analyst" ].ToString( );
            DocumentTitle = Record[ "DocumentTitle" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            FundCode = Record[ "FundCode" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            BudgetFormulationSystem = Record[ "BudgetFormulationSystem" ].ToString( );
            Comments = Record[ "Comments" ].ToString( );
            OriginalRequestDate = DateOnly.Parse( Record[ "OriginalRequestDate" ].ToString( ) ?? "" );
            LastActivityDate = DateOnly.Parse( Record[ "LastActivityDate" ].ToString( ) ?? "" );
        }
        
        public PayrollRequest( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = dataRow[ "Analyst" ].ToString( );
            DocumentTitle = dataRow[ "DocumentTitle" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            FundCode = dataRow[ "FundCode" ].ToString( );
            Status = dataRow[ "Status" ].ToString( );
            BudgetFormulationSystem = dataRow[ "BudgetFormulationSystem" ].ToString( );
            Comments = dataRow[ "Comments" ].ToString( );
            OriginalRequestDate = DateOnly.Parse( dataRow[ "OriginalRequestDate" ].ToString( ) ?? "" );
            LastActivityDate = DateOnly.Parse( dataRow[ "LastActivityDate" ].ToString( ) ?? "" );
        }

        public PayrollRequest( PayrollRequest request )
        {
            ID = request.ID;
            Analyst = request.Analyst;
            DocumentTitle = request.DocumentTitle;
            Amount = request.Amount;
            FundCode = request.FundCode;
            Status = request.Status;
            BudgetFormulationSystem = request.BudgetFormulationSystem;
            Comments = request.Comments;
            OriginalRequestDate = request.OriginalRequestDate;
            LastActivityDate = request.LastActivityDate;
        }
    }
}