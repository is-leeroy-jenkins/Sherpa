// <copyright file = "SuperfundSite.cs" company = "Terry D. Eppler">
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
    public class SuperfundSite : SiteData
    {
        /// <summary>
        /// The source
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; } = Source.SiteActivity;

        /// <summary>
        /// Initializes a new instance of the <see cref = "SuperfundSite"/> class.
        /// </summary>
        /// <inheritdoc/>
        public SuperfundSite()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SuperfundSite"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public SuperfundSite( IQuery query )
            : base( query )
        {
            Record = new Builder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.SuperfundSitesId );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            FocCode = new Element( Record, Field.FocCode );
            DCN = new Element( Record, Field.DocumentControlNumber );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.CongressionalDistrict );
            StateCode = new Element( Record, Field.State );
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
        /// Initializes a new instance of the <see cref = "SuperfundSite"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public SuperfundSite( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.SuperfundSitesId );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            FocCode = new Element( Record, Field.FocCode );
            DCN = new Element( Record, Field.DocumentControlNumber );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.CongressionalDistrict );
            StateCode = new Element( Record, Field.State );
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
        /// Initializes a new instance of the <see cref = "SuperfundSite"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dr.
        /// </param>
        public SuperfundSite( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.SuperfundSitesId );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            FocCode = new Element( Record, Field.FocCode );
            DCN = new Element( Record, Field.DocumentControlNumber );
            EpaSiteId = new Element( Record, Field.EpaSiteId );
            SiteName = new Element( Record, Field.SiteName );
            SiteProjectCode = new Element( Record, Field.SiteProjectCode );
            SiteProjectName = new Element( Record, Field.SiteProjectName );
            City = new Element( Record, Field.City );
            District = new Element( Record, Field.CongressionalDistrict );
            StateCode = new Element( Record, Field.State );
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
