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
            NpmCode = new Element( Record, Field.NpmCode );
            DocPrefix = new Element( Record, Field.DocumentType );
            PurchaseRequest = new Element( Record, Field.PurchaseRequest );
            DocType = new Element( Record, Field.DocumentPrefix );
            DCN = new Element( Record, Field.DCN );
            ObligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            AgreementNumber = new Element( Record, Field.ReimbursableAgreementNumber );
            GrantNumber = new Element( Record, Field.GrantNumber );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            System = new Element( Record, Field.System );
            FocCode = new Element( Record, Field.FocCode );
            FocName = new Element( Record, Field.FocName );
            TransactionNumber = new Element( Record, Field.TransactionNumber );
            OriginalActionDate = new Time( Record, EventDate.OriginalActionDate );
            Commitments = new Amount( Record, Numeric.Commitments );
            OpenCommitments = new Amount( Record, Numeric.OpenCommitments );
            Obligations = new Amount( Record, Numeric.Obligations );
            ULO = new Amount( Record, Numeric.ULO );
            Deobligations = new Amount( Record, Numeric.Deobligations );
            Expenditures = new Amount( Record, Numeric.Expenditures );
            Data = Record?.ToDictionary();
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
            NpmCode = new Element( Record, Field.NpmCode );
            DocPrefix = new Element( Record, Field.DocumentType );
            PurchaseRequest = new Element( Record, Field.PurchaseRequest );
            DocType = new Element( Record, Field.DocumentPrefix );
            DCN = new Element( Record, Field.DCN );
            ObligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            AgreementNumber = new Element( Record, Field.ReimbursableAgreementNumber );
            GrantNumber = new Element( Record, Field.GrantNumber );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            System = new Element( Record, Field.System );
            FocCode = new Element( Record, Field.FocCode );
            FocName = new Element( Record, Field.FocName );
            TransactionNumber = new Element( Record, Field.TransactionNumber );
            OriginalActionDate = new Time( Record, EventDate.OriginalActionDate );
            Commitments = new Amount( Record, Numeric.Commitments );
            OpenCommitments = new Amount( Record, Numeric.OpenCommitments );
            Obligations = new Amount( Record, Numeric.Obligations );
            ULO = new Amount( Record, Numeric.ULO );
            Deobligations = new Amount( Record, Numeric.Deobligations );
            Expenditures = new Amount( Record, Numeric.Expenditures );
            Data = Record?.ToDictionary();
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
            NpmCode = new Element( Record, Field.NpmCode );
            DocPrefix = new Element( Record, Field.DocumentType );
            PurchaseRequest = new Element( Record, Field.PurchaseRequest );
            DocType = new Element( Record, Field.DocumentPrefix );
            DCN = new Element( Record, Field.DCN );
            ObligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            AgreementNumber = new Element( Record, Field.ReimbursableAgreementNumber );
            GrantNumber = new Element( Record, Field.GrantNumber );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            System = new Element( Record, Field.System );
            FocCode = new Element( Record, Field.FocCode );
            FocName = new Element( Record, Field.FocName );
            TransactionNumber = new Element( Record, Field.TransactionNumber );
            OriginalActionDate = new Time( Record, EventDate.OriginalActionDate );
            Commitments = new Amount( Record, Numeric.Commitments );
            OpenCommitments = new Amount( Record, Numeric.OpenCommitments );
            Obligations = new Amount( Record, Numeric.Obligations );
            ULO = new Amount( Record, Numeric.ULO );
            Deobligations = new Amount( Record, Numeric.Deobligations );
            Expenditures = new Amount( Record, Numeric.Expenditures );
            Data = Record?.ToDictionary();
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
                return Verify.Map( Data )
                    ? Data
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
