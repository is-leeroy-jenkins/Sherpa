// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AppropriationAvailableBalance.cs" company="Terry D. Eppler">
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
//   AppropriationAvailableBalance.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class AppropriationAvailableBalances : PRC
    {
        /// <summary>
        /// Gets or sets the authority.
        /// </summary>
        /// <value>
        /// The authority.
        /// </value>
        public double Authority { get; set; }

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
        /// Gets or sets the used.
        /// </summary>
        /// <value>
        /// The used.
        /// </value>
        public double Used { get; set; }

        /// <summary>
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public double Available { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AppropriationAvailableBalances" /> class.
        /// </summary>
        public AppropriationAvailableBalances( )
        {
            Source = Source.AppropriationAvailableBalances;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AppropriationAvailableBalances" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AppropriationAvailableBalances( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            Authority = double.Parse( Record[ nameof( Authority ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ nameof( Carryover ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? "0" );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AppropriationAvailableBalances" /> class.
        /// </summary>
        /// <param name="builder"></param>
        public AppropriationAvailableBalances( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            Authority = double.Parse( Record[ nameof( Authority ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Carryover = double.Parse( Record[ nameof( Carryover ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? "0" );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AppropriationAvailableBalances" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AppropriationAvailableBalances( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            BudgetAccountCode = dataRow[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = dataRow[ nameof( BudgetAccountName ) ].ToString( );
            TreasuryAccountCode = dataRow[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = dataRow[ nameof( TreasuryAccountName ) ].ToString( );
            Authority = double.Parse( dataRow[ nameof( Authority ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( dataRow[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Carryover = double.Parse( dataRow[ nameof( Carryover ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( dataRow[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( dataRow[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Used = double.Parse( dataRow[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( dataRow[ nameof( Available ) ].ToString( ) ?? "0" );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AppropriationAvailableBalances" /> class.
        /// </summary>
        /// <param name="balance">The balance.</param>
        public AppropriationAvailableBalances( AppropriationAvailableBalances balance )
        {
            ID = balance.ID;
            BFY = balance.BFY;
            EFY = balance.EFY;
            FundCode = balance.FundCode;
            FundName = balance.FundName;
            BudgetAccountCode = balance.BudgetAccountCode;
            BudgetAccountName = balance.BudgetAccountName;
            TreasuryAccountCode = balance.TreasuryAccountCode;
            TreasuryAccountName = balance.TreasuryAccountName;
            Authority = balance.Authority;
            Budgeted = balance.Budgeted;
            Carryover = balance.Carryover;
            Reimbursements = balance.Reimbursements;
            Recoveries = balance.Recoveries;
            Used = balance.Used;
            Available = balance.Available;
        }
    }
}