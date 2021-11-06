// <copyright file = "Purchase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "Obligation"/>
    /// <seealso cref = "Obligation"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Purchase : Obligation
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        private const Source _source = Source.Purchases;

        /// <summary>
        /// Gets the purchase identifier.
        /// </summary>
        /// <value>
        /// The purchase identifier.
        /// </value>
        private protected readonly IKey _iD;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Purchase"/> class.
        /// </summary>
        /// <inheritdoc/>
        public Purchase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Purchase"/> class.
        /// </summary>
        /// <param name = "query" >
        /// </param>
        public Purchase( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            _iD = new Key( Record, PrimaryKey.PurchaseId );
            _npmCode = new Element( Record, Field.NpmCode );
            _documentType = new Element( Record, Field.DocumentType );
            _purchaseRequest = new Element( Record, Field.PurchaseRequest );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _dcn = new Element( Record, Field.DCN );
            _obligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            _agreementNumber = new Element( Record, Field.ReimbursableAgreementNumber );
            _grantNumber = new Element( Record, Field.GrantNumber );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _siteProjectCode = new Element( Record, Field.SiteProjectCode );
            _system = new Element( Record, Field.System );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _transactionNumber = new Element( Record, Field.TransactionNumber );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _expenditures = new Amount( Record, Numeric.Expenditures );
            _data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Purchase"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Purchase( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            _iD = new Key( Record, PrimaryKey.PurchaseId );
            _npmCode = new Element( Record, Field.NpmCode );
            _documentType = new Element( Record, Field.DocumentType );
            _purchaseRequest = new Element( Record, Field.PurchaseRequest );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _dcn = new Element( Record, Field.DCN );
            _obligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            _agreementNumber = new Element( Record, Field.ReimbursableAgreementNumber );
            _grantNumber = new Element( Record, Field.GrantNumber );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _siteProjectCode = new Element( Record, Field.SiteProjectCode );
            _system = new Element( Record, Field.System );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _transactionNumber = new Element( Record, Field.TransactionNumber );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _expenditures = new Amount( Record, Numeric.Expenditures );
            _data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Purchase"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Purchase( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            _iD = new Key( Record, PrimaryKey.PurchaseId );
            _npmCode = new Element( Record, Field.NpmCode );
            _documentType = new Element( Record, Field.DocumentType );
            _purchaseRequest = new Element( Record, Field.PurchaseRequest );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _dcn = new Element( Record, Field.DCN );
            _obligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            _agreementNumber = new Element( Record, Field.ReimbursableAgreementNumber );
            _grantNumber = new Element( Record, Field.GrantNumber );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _siteProjectCode = new Element( Record, Field.SiteProjectCode );
            _system = new Element( Record, Field.System );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _transactionNumber = new Element( Record, Field.TransactionNumber );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _expenditures = new Amount( Record, Numeric.Expenditures );
            _data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Gets the purchase identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IKey GetId()
        {
            try
            {
                return Verify.Key( _iD )
                    ? _iD
                    : default( IKey );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IKey );
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IDictionary<string, object> ToDictionary()
        {
            try
            {
                return Verify.Map( _data )
                    ? _data
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}
