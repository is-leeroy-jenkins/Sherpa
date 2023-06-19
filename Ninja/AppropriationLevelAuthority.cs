// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AppropriationLevelAuthority.cs" company="Terry D. Eppler">
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
//   AppropriationLevelAuthority.cs
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
    /// <seealso cref="BudgetExecution.PRC" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class AppropriationLevelAuthority : PRC 
    {
        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the carryover.
        /// </summary>
        /// <value>
        /// The carryover.
        /// </value>
        public double Carryover { get; set; }

        /// <summary>
        /// Gets or sets the reimbursements.
        /// </summary>
        /// <value>
        /// The reimbursements.
        /// </value>
        public double Reimbursements { get; set; }

        /// <summary>
        /// Gets or sets the recoveries.
        /// </summary>
        /// <value>
        /// The recoveries.
        /// </value>
        public double Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the authority.
        /// </summary>
        /// <value>
        /// The authority.
        /// </value>
        public double Authority { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationLevelAuthority"/> class.
        /// </summary>
        public AppropriationLevelAuthority( )
        {
            Source = Source.AppropriationLevelAuthority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationLevelAuthority"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AppropriationLevelAuthority( IQuery query )
        {
            Source = Source.AppropriationLevelAuthority;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationLevelAuthority"/> class.
        /// </summary>
        /// <param name="builder"></param>
        public AppropriationLevelAuthority( IDataModel builder )
        {
            Source = Source.AppropriationLevelAuthority;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( Record[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ "Recoveries" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationLevelAuthority"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AppropriationLevelAuthority( DataRow dataRow )
        {
            Source = Source.AppropriationLevelAuthority;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            Efy = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            Authority = double.Parse( dataRow[ "Authority" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? "0" );
            Carryover = double.Parse( dataRow[ "Carryover" ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( dataRow[ "Reimbursements" ].ToString( ) ?? "0" );
            Recoveries = double.Parse( dataRow[ "Recoveries" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationLevelAuthority"/> class.
        /// </summary>
        /// <param name="authority">The authority.</param>
        public AppropriationLevelAuthority( AppropriationLevelAuthority authority )
        {
            ID = authority.ID;
            BFY = authority.BFY;
            Efy = authority.Efy;
            FundCode = authority.FundCode;
            FundName = authority.FundName;
            TreasuryAccountCode = authority.TreasuryAccountCode;
            TreasuryAccountName = authority.TreasuryAccountName;
            BudgetAccountCode = authority.BudgetAccountCode;
            BudgetAccountName = authority.BudgetAccountName;
            Authority = authority.Authority;
            Budgeted = authority.Budgeted;
            Carryover = authority.Carryover;
            Reimbursements = authority.Reimbursements;
            Recoveries = authority.Recoveries;
        }
    }
}