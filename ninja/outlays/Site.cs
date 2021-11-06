// // <copyright file = "Site.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

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
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class Site : SiteData
    {
        /// <summary>
        /// The source
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        private const Source _source = Source.Sites;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Site"/> class.
        /// </summary>
        /// <inheritdoc/>
        public Site()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Site"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Site( IQuery query )
            : base( query )
        {
            Record = new Builder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.SiteId );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _focCode = new Element( Record, Field.FocCode );
            _dcn = new Element( Record, Field.DCN );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            _siteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.District );
            County = new Element( Record, Field.County );
            StateCode = new Element( Record, Field.StateCode );
            StateName = new Element( Record, Field.StateName );
            StreetAddressLine1 = new Element( Record, Field.StreetAddressLine1 );
            StreetAddressLine2 = new Element( Record, Field.StreetAddressLine2 );
            ZipCode = new Element( Record, Field.ZipCode );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            LastActionDate = new Time( Record, EventDate.LastActionDate );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _expenditures = new Amount( Record, Numeric.Expenditures );
            _data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Site"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Site( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.SiteId );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _focCode = new Element( Record, Field.FocCode );
            _dcn = new Element( Record, Field.DCN );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            _siteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.District );
            County = new Element( Record, Field.County );
            StateCode = new Element( Record, Field.StateCode );
            StateName = new Element( Record, Field.StateName );
            StreetAddressLine1 = new Element( Record, Field.StreetAddressLine1 );
            StreetAddressLine2 = new Element( Record, Field.StreetAddressLine2 );
            ZipCode = new Element( Record, Field.ZipCode );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            LastActionDate = new Time( Record, EventDate.LastActionDate );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _expenditures = new Amount( Record, Numeric.Expenditures );
            _data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Site"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dr.
        /// </param>
        public Site( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.SiteId );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _focCode = new Element( Record, Field.FocCode );
            _dcn = new Element( Record, Field.DCN );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            _siteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.District );
            County = new Element( Record, Field.County );
            StateCode = new Element( Record, Field.StateCode );
            StateName = new Element( Record, Field.StateName );
            StreetAddressLine1 = new Element( Record, Field.StreetAddressLine1 );
            StreetAddressLine2 = new Element( Record, Field.StreetAddressLine2 );
            ZipCode = new Element( Record, Field.ZipCode );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            LastActionDate = new Time( Record, EventDate.LastActionDate );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _expenditures = new Amount( Record, Numeric.Expenditures );
            _data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Gets the Superfund identifier.
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
        /// Gets the epa site identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetEpaSiteId()
        {
            try
            {
                return Verify.Input( EpaSiteId?.GetValue() )
                    ? EpaSiteId
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the name of the site.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetSiteName()
        {
            try
            {
                return Verify.Input( SiteName?.GetValue() )
                    ? SiteName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the name of the site project.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetSiteProjectName()
        {
            try
            {
                return Verify.Input( SiteProjectName?.GetValue() )
                    ? SiteProjectName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetCity()
        {
            try
            {
                return Verify.Input( City?.GetValue() )
                    ? City
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the congressional district.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetCongressionalDistrict()
        {
            try
            {
                return Verify.Input( District?.GetValue() )
                    ? District
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the county.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetCounty()
        {
            try
            {
                return Verify.Input( County?.GetValue() )
                    ? County
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the state code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetStateCode()
        {
            try
            {
                return Verify.Input( StateCode?.GetName() )
                    ? StateCode
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the name of the state.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetStateName()
        {
            try
            {
                return Verify.Input( StateName?.GetValue() )
                    ? StateName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the street address.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetStreetAddress()
        {
            try
            {
                return Verify.Input( StreetAddressLine1?.GetName() )
                    ? StreetAddressLine1
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the zip code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetZipCode()
        {
            try
            {
                return Verify.Input( District?.GetValue() )
                    ? District
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the last action date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetLastActionDate()
        {
            try
            {
                return Verify.Input( LastActionDate?.GetValue() )
                    ? LastActionDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
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
