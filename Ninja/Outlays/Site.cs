// <copyright file = "Site.cs" company = "Terry D. Eppler">
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
        public new Source Source { get;  } = Source.SiteActivity;

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
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            FocCode = new Element( Record, Field.FocCode );
            DCN = new Element( Record, Field.DCN );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.District );
            County = new Element( Record, Field.County );
            StateCode = new Element( Record, Field.StateCode );
            StateName = new Element( Record, Field.StateName );
            StreetAddressLine1 = new Element( Record, Field.StreetAddressLine1 );
            StreetAddressLine2 = new Element( Record, Field.StreetAddressLine2 );
            ZipCode = new Element( Record, Field.ZipCode );
            OriginalActionDate = new Time( Record, EventDate.OriginalActionDate );
            LastActionDate = new Time( Record, EventDate.LastActionDate );
            Commitments = new Amount( Record, Numeric.Commitments );
            OpenCommitments = new Amount( Record, Numeric.OpenCommitments );
            Obligations = new Amount( Record, Numeric.Obligations );
            ULO = new Amount( Record, Numeric.ULO );
            Deobligations = new Amount( Record, Numeric.Deobligations );
            Expenditures = new Amount( Record, Numeric.Expenditures );
            Data = Record?.ToDictionary();
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
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            FocCode = new Element( Record, Field.FocCode );
            DCN = new Element( Record, Field.DCN );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.District );
            County = new Element( Record, Field.County );
            StateCode = new Element( Record, Field.StateCode );
            StateName = new Element( Record, Field.StateName );
            StreetAddressLine1 = new Element( Record, Field.StreetAddressLine1 );
            StreetAddressLine2 = new Element( Record, Field.StreetAddressLine2 );
            ZipCode = new Element( Record, Field.ZipCode );
            OriginalActionDate = new Time( Record, EventDate.OriginalActionDate );
            LastActionDate = new Time( Record, EventDate.LastActionDate );
            Commitments = new Amount( Record, Numeric.Commitments );
            OpenCommitments = new Amount( Record, Numeric.OpenCommitments );
            Obligations = new Amount( Record, Numeric.Obligations );
            ULO = new Amount( Record, Numeric.ULO );
            Deobligations = new Amount( Record, Numeric.Deobligations );
            Expenditures = new Amount( Record, Numeric.Expenditures );
            Data = Record?.ToDictionary();
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
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            FocCode = new Element( Record, Field.FocCode );
            DCN = new Element( Record, Field.DCN );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.District );
            County = new Element( Record, Field.County );
            StateCode = new Element( Record, Field.StateCode );
            StateName = new Element( Record, Field.StateName );
            StreetAddressLine1 = new Element( Record, Field.StreetAddressLine1 );
            StreetAddressLine2 = new Element( Record, Field.StreetAddressLine2 );
            ZipCode = new Element( Record, Field.ZipCode );
            OriginalActionDate = new Time( Record, EventDate.OriginalActionDate );
            LastActionDate = new Time( Record, EventDate.LastActionDate );
            Commitments = new Amount( Record, Numeric.Commitments );
            OpenCommitments = new Amount( Record, Numeric.OpenCommitments );
            Obligations = new Amount( Record, Numeric.Obligations );
            ULO = new Amount( Record, Numeric.ULO );
            Deobligations = new Amount( Record, Numeric.Deobligations );
            Expenditures = new Amount( Record, Numeric.Expenditures );
            Data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Gets the SuperfundSites identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IKey GetId()
        {
            try
            {
                return Verify.IsKey( ID )
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
                return Verify.IsInput( EpaSiteId?.Value?.ToString() )
                    ? EpaSiteId
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsInput( SiteName?.Value?.ToString() )
                    ? SiteName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsInput( SiteProjectName?.Value?.ToString() )
                    ? SiteProjectName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsInput( City?.Value?.ToString() )
                    ? City
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsInput( District?.Value?.ToString() )
                    ? District
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsInput( County?.Value?.ToString() )
                    ? County
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsElement( StateCode )
                    ? StateCode
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsElement( StateName )
                    ? StateName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsElement( StreetAddressLine1 )
                    ? StreetAddressLine1
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsElement( District )
                    ? District
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
                return Verify.IsTime( LastActionDate )
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
                return Verify.IsMap( Data )
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
