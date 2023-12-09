// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetDocument.cs" company="Terry D. Eppler">
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
//   BudgetDocument.cs
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
    /// <seealso cref="T:BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetDocuments : BudgetUnit
    {
        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or sets the document number.
        /// </summary>
        /// <value>
        /// The document number.
        /// </value>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or sets the document date.
        /// </summary>
        /// <value>
        /// The document date.
        /// </value>
        public DateOnly DocumentDate { get; set; }

        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public double Budgeted { get; set; }

        /// <summary>
        /// Gets or sets the posted.
        /// </summary>
        /// <value>
        /// The posted.
        /// </value>
        public double Posted { get; set; }

        /// <summary>
        /// Gets or sets the carryover out.
        /// </summary>
        /// <value>
        /// The carryover out.
        /// </value>
        public double CarryoverOut { get; set; }

        /// <summary>
        /// Gets or sets the carryover in.
        /// </summary>
        /// <value>
        /// The carryover in.
        /// </value>
        public double CarryoverIn { get; set; }

        /// <summary>
        /// Gets or sets the recoveries.
        /// </summary>
        /// <value>
        /// The recoveries.
        /// </value>
        public double Recoveries { get; set; }

        /// <summary>
        /// Gets or sets the reimbursements.
        /// </summary>
        /// <value>
        /// The reimbursements.
        /// </value>
        public double Reimbursements { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetDocuments"/> class.
        /// </summary>
        public BudgetDocuments( )
        {
            Source = Source.BudgetDocuments;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetDocuments" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetDocuments( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            DocumentType = Record[ nameof( DocumentType ) ].ToString( );
            DocumentNumber = Record[ nameof( DocumentNumber ) ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ nameof( DocumentDate ) ].ToString( ) ?? "" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ nameof( CarryoverOut ) ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ nameof( CarryoverIn ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetDocuments" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetDocuments( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            DocumentType = Record[ nameof( DocumentType ) ].ToString( );
            DocumentNumber = Record[ nameof( DocumentNumber ) ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ nameof( DocumentDate ) ].ToString( ) ?? "" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ nameof( CarryoverOut ) ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ nameof( CarryoverIn ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetDocuments" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetDocuments( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            DocumentType = dataRow[ nameof( DocumentType ) ].ToString( );
            DocumentDate = DateOnly.Parse( dataRow[ nameof( DocumentDate ) ].ToString( ) ?? "" );
            Budgeted = double.Parse( dataRow[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( dataRow[ nameof( Posted ) ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( dataRow[ nameof( CarryoverOut ) ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( dataRow[ nameof( CarryoverIn ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = dataRow[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = dataRow[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = dataRow[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetDocuments"/> class.
        /// </summary>
        /// <param name="budgetDocument">The budget document.</param>
        public BudgetDocuments( BudgetDocuments budgetDocument )
        {
            Record = budgetDocument.Record;
            Data = budgetDocument.Data;
            BudgetLevel = budgetDocument.BudgetLevel;
            BFY = budgetDocument.BFY;
            EFY = budgetDocument.EFY;
            FundCode = budgetDocument.FundCode;
            FundName = budgetDocument.FundName;
            DocumentType = budgetDocument.DocumentType;
            DocumentDate = budgetDocument.DocumentDate;
            Budgeted = budgetDocument.Budgeted;
            Posted = budgetDocument.Posted;
            CarryoverOut = budgetDocument.CarryoverOut;
            CarryoverIn = budgetDocument.CarryoverIn;
            Recoveries = budgetDocument.Recoveries;
            Reimbursements = budgetDocument.Reimbursements;
            TreasuryAccountCode = budgetDocument.TreasuryAccountCode;
            TreasuryAccountName = budgetDocument.TreasuryAccountName;
            BudgetAccountCode = budgetDocument.BudgetAccountCode;
            BudgetAccountName = budgetDocument.BudgetAccountName;
        }
    }
}