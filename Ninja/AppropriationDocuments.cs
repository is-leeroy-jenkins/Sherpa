// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AppropriationDocument.cs" company="Terry D. Eppler">
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
//   AppropriationDocument.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class AppropriationDocuments : BudgetUnit
    {
        /// <summary>
        /// Gets or sets the last document date.
        /// </summary>
        /// <value>
        /// The last document date.
        /// </value>
        public DateOnly LastDocumentDate { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <inheritdoc />
        public override Source Source { get; set; }

        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override Provider Provider { get; set; }

        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override DataRow Record { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the fund.
        /// </summary>
        /// <value>
        /// The fund.
        /// </value>
        public string Fund { get; set; }

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
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        public string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the budgeting controls.
        /// </summary>
        /// <value>
        /// The budgeting controls.
        /// </value>
        public string BudgetingControls { get; set; }

        /// <summary>
        /// Gets or sets the posting controls.
        /// </summary>
        /// <value>
        /// The posting controls.
        /// </value>
        public string PostingControls { get; set; }

        /// <summary>
        /// Gets or sets the pre commitment controls.
        /// </summary>
        /// <value>
        /// The pre commitment controls.
        /// </value>
        public string PreCommitmentControls { get; set; }

        /// <summary>
        /// Gets or sets the commitment controls.
        /// </summary>
        /// <value>
        /// The commitment controls.
        /// </value>
        public string CommitmentControls { get; set; }

        /// <summary>
        /// Gets or sets the obligation controls.
        /// </summary>
        /// <value>
        /// The obligation controls.
        /// </value>
        public string ObligationControls { get; set; }

        /// <summary>
        /// Gets or sets the accrual controls.
        /// </summary>
        /// <value>
        /// The accrual controls.
        /// </value>
        public string AccrualControls { get; set; }

        /// <summary>
        /// Gets or sets the expenditure controls.
        /// </summary>
        /// <value>
        /// The expenditure controls.
        /// </value>
        public string ExpenditureControls { get; set; }

        /// <summary>
        /// Gets or sets the expense controls.
        /// </summary>
        /// <value>
        /// The expense controls.
        /// </value>
        public string ExpenseControls { get; set; }

        /// <summary>
        /// Gets or sets the reimbursement controls.
        /// </summary>
        /// <value>
        /// The reimbursement controls.
        /// </value>
        public string ReimbursementControls { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable agreement controls.
        /// </summary>
        /// <value>
        /// The reimbursable agreement controls.
        /// </value>
        public string ReimbursableAgreementControls { get; set; }

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
        /// Initializes a new instance of the <see cref="AppropriationDocuments"/> class.
        /// </summary>
        public AppropriationDocuments( )
        {
            Source = Source.AppropriationDocuments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocuments"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AppropriationDocuments( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            ID = int.Parse( Record[ "AppropriationDocumentsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Fund = Record[ nameof( Fund ) ].ToString( );
            FundCode = Record[ nameof( FundName ) ].ToString( );
            DocumentType = Record[ nameof( DocumentType ) ].ToString( );
            DocumentNumber = Record[ nameof( DocumentNumber ) ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ nameof( DocumentDate ) ].ToString( ) ?? "" );
            LastDocumentDate = DateOnly.Parse( Record[ nameof( LastDocumentDate ) ].ToString( ) ?? "" );
            BudgetingControls = Record[ nameof( BudgetingControls ) ].ToString( );
            PostingControls = Record[ nameof( PostingControls ) ].ToString( );
            PreCommitmentControls = Record[ nameof( PreCommitmentControls ) ].ToString( );
            CommitmentControls = Record[ nameof( CommitmentControls ) ].ToString( );
            ObligationControls = Record[ nameof( ObligationControls ) ].ToString( );
            AccrualControls = Record[ nameof( AccrualControls ) ].ToString( );
            ExpenseControls = Record[ nameof( ExpenseControls ) ].ToString( );
            ExpenditureControls = Record[ nameof( ExpenditureControls ) ].ToString( );
            ReimbursementControls = Record[ nameof( ReimbursementControls ) ].ToString( );
            ReimbursableAgreementControls = Record[ "ReimbursementAgreementControls" ].ToString( );
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocuments"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AppropriationDocuments( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "AppropriationDocumentsId" ].ToString( ) ?? "0" );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Fund = Record[ nameof( Fund ) ].ToString( );
            FundCode = Record[ nameof( FundName ) ].ToString( );
            DocumentType = Record[ nameof( DocumentType ) ].ToString( );
            DocumentNumber = Record[ nameof( DocumentNumber ) ].ToString( );
            DocumentDate = DateOnly.Parse( Record[ nameof( DocumentDate ) ].ToString( ) ?? "" );
            LastDocumentDate = DateOnly.Parse( Record[ nameof( LastDocumentDate ) ].ToString( ) ?? "" );
            BudgetingControls = Record[ nameof( BudgetingControls ) ].ToString( );
            PostingControls = Record[ nameof( PostingControls ) ].ToString( );
            PreCommitmentControls = Record[ nameof( PreCommitmentControls ) ].ToString( );
            CommitmentControls = Record[ nameof( CommitmentControls ) ].ToString( );
            ObligationControls = Record[ nameof( ObligationControls ) ].ToString( );
            AccrualControls = Record[ nameof( AccrualControls ) ].ToString( );
            ExpenseControls = Record[ nameof( ExpenseControls ) ].ToString( );
            ExpenditureControls = Record[ nameof( ExpenditureControls ) ].ToString( );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocuments"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AppropriationDocuments( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "AppropriationDocumentsId" ].ToString( ) ?? "0" );
            BudgetLevel = dataRow[ nameof( BudgetLevel ) ].ToString( );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            Fund = dataRow[ nameof( Fund ) ].ToString( );
            FundCode = dataRow[ nameof( FundName ) ].ToString( );
            DocumentType = dataRow[ nameof( DocumentType ) ].ToString( );
            DocumentNumber = dataRow[ nameof( DocumentNumber ) ].ToString( );
            DocumentDate = DateOnly.Parse( dataRow[ nameof( DocumentDate ) ].ToString( ) ?? "" );
            LastDocumentDate = DateOnly.Parse( dataRow[ nameof( LastDocumentDate ) ].ToString( ) ?? "" );
            BudgetingControls = dataRow[ nameof( BudgetingControls ) ].ToString( );
            PostingControls = dataRow[ nameof( PostingControls ) ].ToString( );
            PreCommitmentControls = dataRow[ nameof( PreCommitmentControls ) ].ToString( );
            CommitmentControls = dataRow[ nameof( CommitmentControls ) ].ToString( );
            ObligationControls = dataRow[ nameof( ObligationControls ) ].ToString( );
            AccrualControls = dataRow[ nameof( AccrualControls ) ].ToString( );
            ExpenseControls = dataRow[ nameof( ExpenseControls ) ].ToString( );
            ExpenditureControls = dataRow[ nameof( ExpenditureControls ) ].ToString( );
            Budgeted = double.Parse( dataRow[ nameof( Budgeted ) ].ToString( ) );
            Posted = double.Parse( dataRow[ nameof( Posted ) ].ToString( ) );
            CarryoverOut = double.Parse( dataRow[ nameof( CarryoverOut ) ].ToString( ) );
            CarryoverIn = double.Parse( dataRow[ nameof( CarryoverIn ) ].ToString( ) );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = dataRow[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = dataRow[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = dataRow[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppropriationDocuments"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        public AppropriationDocuments( AppropriationDocuments document )
        {
            ID = document.ID;
            BFY = document.BFY;
            EFY = document.EFY;
            Fund = document.Fund;
            FundCode = document.FundCode;
            DocumentType = document.DocumentType;
            DocumentNumber = document.DocumentNumber;
            DocumentDate = document.DocumentDate;
            BudgetingControls = document.BudgetingControls;
            PostingControls = document.PostingControls;
            PreCommitmentControls = document.PreCommitmentControls;
            CommitmentControls = document.CommitmentControls;
            ObligationControls = document.ObligationControls;
            AccrualControls = document.AccrualControls;
            ExpenditureControls = document.ExpenditureControls;
            Budgeted = document.Budgeted;
            Posted = document.Posted;
            CarryoverOut = document.CarryoverOut;
            CarryoverIn = document.CarryoverIn;
            Recoveries = document.Recoveries;
            Reimbursements = document.Reimbursements;
            TreasuryAccountCode = document.TreasuryAccountCode;
            TreasuryAccountName = document.TreasuryAccountName;
            BudgetAccountCode = document.BudgetAccountCode;
            BudgetAccountName = document.BudgetAccountName;
        }
    }
}