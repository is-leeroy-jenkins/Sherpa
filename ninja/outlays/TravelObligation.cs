// <copyright file = "TravelObligation.cs" company = "Terry D. Eppler">
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
    public class TravelObligation : TravelData
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        private const Source _source = Source.TravelObligations;

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelObligation"/> class.
        /// </summary>
        /// <inheritdoc/>
        public TravelObligation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelObligation"/> class.
        /// </summary>
        /// <param name = "query" >
        /// </param>
        public TravelObligation( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.TravelObligationId );
            _programAreaCode = new Element( Record, Field.ProgramAreaCode );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _dcn = new Element( Record, Field.DCN );
            _firstName = new Element( Record, Field.FirstName );
            _middleName = new Element( Record, Field.MiddleName );
            _lastName = new Element( Record, Field.LastName );
            _email = new Element( Record, Field.Email );
            _destination = new Element( Record, Field.Destination );
            _startDate = new Time( Record, EventDate.StartDate );
            _endDate = new Time( Record, EventDate.EndDate );
            _amount = new Amount( Record, Numeric.Amount );
            _data = Record?.ToDictionary();
            _type = OutlayType.Obligation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelObligation"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public TravelObligation( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.TravelObligationId );
            _programAreaCode = new Element( Record, Field.ProgramAreaCode );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _dcn = new Element( Record, Field.DCN );
            _firstName = new Element( Record, Field.FirstName );
            _middleName = new Element( Record, Field.MiddleName );
            _lastName = new Element( Record, Field.LastName );
            _email = new Element( Record, Field.Email );
            _destination = new Element( Record, Field.Destination );
            _startDate = new Time( Record, EventDate.StartDate );
            _endDate = new Time( Record, EventDate.EndDate );
            _amount = new Amount( Record, Numeric.Amount );
            _data = Record?.ToDictionary();
            _type = OutlayType.Obligation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "TravelObligation"/> class.
        /// </summary>
        /// <param name = "datarow" >
        /// The dr.
        /// </param>
        public TravelObligation( DataRow datarow )
        {
            Record = datarow;
            ID = new Key( Record, PrimaryKey.TravelObligationId );
            _programAreaCode = new Element( Record, Field.ProgramAreaCode );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _dcn = new Element( Record, Field.DCN );
            _firstName = new Element( Record, Field.FirstName );
            _middleName = new Element( Record, Field.MiddleName );
            _lastName = new Element( Record, Field.LastName );
            _email = new Element( Record, Field.Email );
            _destination = new Element( Record, Field.Destination );
            _startDate = new Time( Record, EventDate.StartDate );
            _endDate = new Time( Record, EventDate.EndDate );
            _amount = new Amount( Record, Numeric.Amount );
            _data = Record?.ToDictionary();
            _type = OutlayType.Obligation;
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
        /// Gets the bbfy.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetBBFY()
        {
            try
            {
                return Verify.Input( BFY?.GetValue() )
                    ? BFY
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the destination.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetDestination()
        {
            try
            {
                return Verify.Input( _destination?.GetName() )
                    ? _destination
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetFirstName()
        {
            try
            {
                return Verify.Input( _firstName?.GetValue() )
                    ? _firstName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the name of the middle.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetMiddleName()
        {
            try
            {
                return Verify.Input( _middleName.GetValue() )
                    ? _middleName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetLastName()
        {
            try
            {
                return Verify.Input( _lastName?.GetValue() )
                    ? _lastName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the email address.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetEmailAddress()
        {
            try
            {
                return Verify.Input( _email?.GetValue() )
                    ? _email
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetStartDate()
        {
            try
            {
                return Verify.Input( _startDate?.GetValue() )
                    ? _startDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the end date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetEndDate()
        {
            try
            {
                return Verify.Input( _endDate?.GetValue() )
                    ? _endDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
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
                return _amount?.GetFunding() > -1.0
                    ? _amount
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
