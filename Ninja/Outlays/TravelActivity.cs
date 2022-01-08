// <copyright file = "TravelActivity.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "Obligation"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class TravelActivity : TravelData
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; } =  Source.TravelActivity;

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelActivity"/> class.
        /// </summary>
        /// <inheritdoc/>
        public TravelActivity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelActivity"/> class.
        /// </summary>
        /// <param name = "query" >
        /// </param>
        public TravelActivity( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.TravelObligationId );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            FocCode = new Element( Record, Field.FocCode );
            FocName = new Element( Record, Field.FocName );
            DCN = new Element( Record, Field.DocumentControlNumber );
            FirstName = new Element( Record, Field.FirstName );
            MiddleName = new Element( Record, Field.MiddleName );
            LastName = new Element( Record, Field.LastName );
            Email = new Element( Record, Field.Email );
            Destination = new Element( Record, Field.Destination );
            StartDate = new Time( Record, EventDate.StartDate );
            EndDate = new Time( Record, EventDate.EndDate );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary();
            Type = OutlayType.Obligation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelActivity"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public TravelActivity( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.TravelObligationId );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            FocCode = new Element( Record, Field.FocCode );
            FocName = new Element( Record, Field.FocName );
            DCN = new Element( Record, Field.DocumentControlNumber );
            FirstName = new Element( Record, Field.FirstName );
            MiddleName = new Element( Record, Field.MiddleName );
            LastName = new Element( Record, Field.LastName );
            Email = new Element( Record, Field.Email );
            Destination = new Element( Record, Field.Destination );
            StartDate = new Time( Record, EventDate.StartDate );
            EndDate = new Time( Record, EventDate.EndDate );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary();
            Type = OutlayType.Obligation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelActivity"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dr.
        /// </param>
        public TravelActivity( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.TravelObligationId );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            FocCode = new Element( Record, Field.FocCode );
            FocName = new Element( Record, Field.FocName );
            DCN = new Element( Record, Field.DocumentControlNumber );
            FirstName = new Element( Record, Field.FirstName );
            MiddleName = new Element( Record, Field.MiddleName );
            LastName = new Element( Record, Field.LastName );
            Email = new Element( Record, Field.Email );
            Destination = new Element( Record, Field.Destination );
            StartDate = new Time( Record, EventDate.StartDate );
            EndDate = new Time( Record, EventDate.EndDate );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary();
            Type = OutlayType.Obligation;
        }
        
        /// <summary>
        /// Gets the travel obligation identifier.
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
        /// Gets the bbfy.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetBBFY()
        {
            try
            {
                return Verify.IsElement( BFY )
                    ? BFY
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }
        
        /// <summary>
        /// Gets the travel obligation amount.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IAmount GetAmount()
        {
            try
            {
                return Amount?.Funding > -1.0
                    ? Amount
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }
    }
}
