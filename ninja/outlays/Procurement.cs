// <copyright file = "Procurement.cs" company = "Terry D. Eppler">
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
    /// <seealso cref = "Commitment"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Procurement : ProcurementData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "Procurement"/> class.
        /// </summary>
        /// <inheritdoc/>
        public Procurement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Procurement"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Procurement( IQuery query )
            : base( query )
        {
            Record = new Builder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProcurementId );
            _title = new Element( Record, Field.Title );
            _requestedBy = new Element( Record, Field.RequestedBy );
            _description = new Element( Record, Field.Description );
            _createdBy = new Element( Record, Field.CreatedBy );
            _modifiedBy = new Element( Record, Field.ModifiedBy );
            _lastActionDate = new Time( Record, EventDate.LastActionDate );
            _processedDate = new Time( Record, EventDate.ProcessedDate );
            _closedDate = new Time( Record, EventDate.ClosedDate );
            _securityOrg = new Element( Record, Field.SecurityOrg );
            _vendorCode = new Element( Record, Field.VendorCode );
            _projectCode = new Element( Record, Field.ProjectCode );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _documentType = new Element( Record, Field.DocumentType );
            _documentDate = new Time( Record, EventDate.DocumentDate );
            _documentControlNumber = new Element( Record, Field.DocumentControlNumber );
            _ordered = new Amount( Record, Numeric.Ordered );
            _closed = new Amount( Record, Numeric.Closed );
            _expended = new Amount( Record, Numeric.Expended );
            _data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Procurement"/> class.
        /// </summary>
        /// <param name = "dataBuilder" >
        /// The builder.
        /// </param>
        public Procurement( IBuilder dataBuilder )
            : base( dataBuilder )
        {
            Record = dataBuilder.GetRecord();
            ID = new Key( Record, PrimaryKey.ProcurementId );
            _title = new Element( Record, Field.Title );
            _requestedBy = new Element( Record, Field.RequestedBy );
            _description = new Element( Record, Field.Description );
            _createdBy = new Element( Record, Field.CreatedBy );
            _modifiedBy = new Element( Record, Field.ModifiedBy );
            _lastActionDate = new Time( Record, EventDate.LastActionDate );
            _processedDate = new Time( Record, EventDate.ProcessedDate );
            _closedDate = new Time( Record, EventDate.ClosedDate );
            _securityOrg = new Element( Record, Field.SecurityOrg );
            _vendorCode = new Element( Record, Field.VendorCode );
            _projectCode = new Element( Record, Field.ProjectCode );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _documentType = new Element( Record, Field.DocumentType );
            _documentDate = new Time( Record, EventDate.DocumentDate );
            _documentControlNumber = new Element( Record, Field.DocumentControlNumber );
            _ordered = new Amount( Record, Numeric.Ordered );
            _closed = new Amount( Record, Numeric.Closed );
            _expended = new Amount( Record, Numeric.Expended );
            _data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Procurement"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The data.
        /// </param>
        public Procurement( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.ProcurementId );
            _title = new Element( Record, Field.Title );
            _requestedBy = new Element( Record, Field.RequestedBy );
            _description = new Element( Record, Field.Description );
            _createdBy = new Element( Record, Field.CreatedBy );
            _modifiedBy = new Element( Record, Field.ModifiedBy );
            _lastActionDate = new Time( Record, EventDate.LastActionDate );
            _processedDate = new Time( Record, EventDate.ProcessedDate );
            _closedDate = new Time( Record, EventDate.ClosedDate );
            _securityOrg = new Element( Record, Field.SecurityOrg );
            _vendorCode = new Element( Record, Field.VendorCode );
            _projectCode = new Element( Record, Field.ProjectCode );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _documentType = new Element( Record, Field.DocumentType );
            _documentDate = new Time( Record, EventDate.DocumentDate );
            _documentControlNumber = new Element( Record, Field.DocumentControlNumber );
            _ordered = new Amount( Record, Numeric.Ordered );
            _closed = new Amount( Record, Numeric.Closed );
            _expended = new Amount( Record, Numeric.Expended );
            _data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Gets the procurement identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IKey GetId()
        {
            try
            {
                return Verify.Key( ID )
                    ? ID
                    : default( IKey );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IKey );
            }
        }

        /// <summary>
        /// Gets the procument code.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IElement GetDocumentControlNumber()
        {
            try
            {
                return Verify.Input( _documentControlNumber.GetValue() )
                    ? _documentControlNumber
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the last activity date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetLastActivityDate()
        {
            try
            {
                return Verify.Input( _lastActionDate?.GetValue() )
                    ? _lastActionDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the closed date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetClosedDate()
        {
            try
            {
                return Verify.Input( _closedDate?.GetValue() )
                    ? _closedDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the security organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetSecurityOrganization()
        {
            try
            {
                return Verify.Input( _securityOrg?.GetValue() )
                    ? _securityOrg
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetDescription()
        {
            try
            {
                return Verify.Input( _description?.GetValue() )
                    ? _description
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the ordered.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetOrdered()
        {
            try
            {
                return _ordered.GetFunding() > -1
                    ? _ordered
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the closed.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetClosed()
        {
            try
            {
                return _closed.GetFunding() > -1
                    ? _closed
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the expended.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetExpended()
        {
            try
            {
                return _expended.GetFunding() > -1
                    ? _expended
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
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
