// <copyright file = "BudgetFiscalYear.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.FiscalYear" />
    /// <seealso cref="BudgetExecution.IBudgetFiscalYear" />
    /// <seealso cref="BudgetExecution.ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class BudgetFiscalYear : FiscalYear, IBudgetFiscalYear, ISource
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; } = Source.FiscalYears;

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public HolidayFactory Holidays { get; set; }

        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public IElement Availability { get; set; }

        /// <summary>
        /// Gets or sets the federal holidays.
        /// </summary>
        /// <value>
        /// The federal holidays.
        /// </value>
        public IDictionary<Holiday, DateTime> FederalHolidays { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        public BudgetFiscalYear()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="bfy">The bfy.</param>
        public BudgetFiscalYear( string bfy )
        {
            InputYear = new Element( Field.BFY, bfy );
            Record = new DataBuilder( Source, SetArgs( bfy ) )?.GetRecord();
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetFiscalYear( IQuery query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public BudgetFiscalYear( IBuilder dataBuilder )
        {
            Record = dataBuilder?.GetRecord();
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="fy">The fy.</param>
        public BudgetFiscalYear( BFY fy )
        {
            Record = new DataBuilder( Source, Provider.SQLite, SetArgs( fy ) )?.GetRecord();
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetFiscalYear( DataRow dataRow )
        {
            Record = dataRow;
            InputYear = new Element( Record, CurrentYear.ToString() );
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns></returns>
        public IDictionary<Field, DateTime> GetFederalHolidays()
        {
            try
            {
                var _dictionary = new Dictionary<Field, DateTime>();
                var _factory = new HolidayFactory( Record );
                _dictionary.Add( Field.NewYears, DateTime.Parse( _factory?.NewYearsDay?.Value?.ToString() ) );
                _dictionary.Add( Field.MartinLutherKing, DateTime.Parse( _factory?.MartinLutherKingDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Memorial, DateTime.Parse( _factory?.MemorialDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Presidents, DateTime.Parse( _factory?.PresidentsDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Veterans, DateTime.Parse( _factory?.VeteransDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Labor, DateTime.Parse( _factory?.LaborDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Independence, DateTime.Parse( _factory?.IndependenceDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Columbus, DateTime.Parse( _factory?.ColumbusDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Thanksgiving, DateTime.Parse( _factory?.ThanksgivingDay?.Value?.ToString() ) );
                _dictionary.Add( Field.Christmas, DateTime.Parse( _factory?.ChristmasDay?.Value?.ToString() ) );

                return _dictionary?.Any() == true
                    ? _dictionary
                    : default( Dictionary<Field, DateTime> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<Field, DateTime> );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            try
            {
                return Verify.IsInput( FirstYear?.Value?.ToString() )
                    ? FirstYear?.Value?.ToString()
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the budget fiscal year.
        /// </summary>
        /// <returns></returns>
        public IBudgetFiscalYear GetBudgetFiscalYear()
        {
            try
            {
                return MemberwiseClone() as BudgetFiscalYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IBudgetFiscalYear );
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns></returns>
        public Source GetSource()
        {
            try
            {
                return Validate.IsSource( Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Source );
            }
        }
    }
}
