// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetFiscalYear.cs" company="Terry D. Eppler">
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
//   BudgetFiscalYear.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.FiscalYear" />
    /// <seealso cref="!:BudgetExecution.IBudgetFiscalYear" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public class BudgetFiscalYears : FiscalYear
    {
        /// <summary>
        /// The source
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// The availability
        /// </summary>
        private protected string _availability;

        /// <summary>
        /// The record
        /// </summary>
        private protected DataRow _record;

        /// <summary>
        /// The holidays
        /// </summary>
        private protected HolidayFactory _holidays;

        /// <summary>
        /// The federal holidays
        /// </summary>
        private protected IDictionary<Holiday, DateOnly> _federalHolidays;
        
        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public string Availability
        {
            get
            {
                return _availability;
            }
            private protected set
            {
                _availability = value;
            }
        }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source
        {
            get
            {
                return _source;
            }
            private protected set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record
        {
            get
            {
                return _record;
            }
            private protected set
            {
                _record = value;
            }
        }

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public HolidayFactory Holidays
        {
            get
            {
                return _holidays;
            }
            private protected set
            {
                _holidays = value;
            }
        }

        /// <summary>
        /// Gets or sets the federal holidays.
        /// </summary>
        /// <value>
        /// The federal holidays.
        /// </value>
        public IDictionary<Holiday, DateOnly> FederalHolidays
        {
            get
            {
                return _federalHolidays;
            }
            private protected set
            {
                _federalHolidays = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        public BudgetFiscalYears( )
        {
            _source = Source.FiscalYears;
            _currentDate = DateOnly.FromDateTime( DateTime.Today );
            _currentYear = DateTime.Now.Year;
            _currentMonth = DateTime.Now.Month;
            _currentDay = DateTime.Now.Day;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetFiscalYears" />
        /// class.
        /// </summary>
        /// <param name="bfy"> The bfy. </param>
        public BudgetFiscalYears( string bfy )
            : this( )
        {
            _inputYear = bfy;
            _record = new DataBuilder( Source, SetArgs( bfy ) )?.Record;
            _id = int.Parse( Record[ "FiscalYearId" ].ToString( ) );
            _firstYear = Record[ "FirstYear" ].ToString( );
            _lastYear = Record[ "LastYEar" ].ToString( );
            _availability = Record[ "Availability" ].ToString( );
            _workDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            _weekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            _weekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            _expiringYear = Record[ "ExpiringYear" ].ToString( );
            _startDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            _endDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            _cancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            _holidays = new HolidayFactory( Record );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetFiscalYears" />
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public BudgetFiscalYears( IQuery query )
            : this( )
        {
            _record = new DataBuilder( query )?.Record;
            _id = int.Parse( Record[ "FiscalYearId" ].ToString( ) );
            _firstYear = Record[ "FirstYear" ].ToString( );
            _lastYear = Record[ "LastYEar" ].ToString( );
            _availability = Record[ "Availability" ].ToString( );
            _workDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            _weekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            _weekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            _expiringYear = Record[ "ExpiringYear" ].ToString( );
            _startDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            _endDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            _cancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            _holidays = new HolidayFactory( Record );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetFiscalYears" />
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The data builder. </param>
        public BudgetFiscalYears( IDataModel dataBuilder )
            : this( )
        {
            _record = dataBuilder.Record;
            _id = int.Parse( Record[ "FiscalYearsId" ].ToString( ) );
            _bfy = Record[ "BFY" ].ToString( );
            _efy = Record[ "EFY" ].ToString( );
            _firstYear = Record[ "FirstYear" ].ToString( );
            _lastYear = Record[ "LastYEar" ].ToString( );
            _availability = Record?[ "Availability" ].ToString( );
            _workDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            _weekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            _weekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            _expiringYear = Record[ "ExpiringYear" ].ToString( );
            _startDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            _endDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            _cancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            _holidays = new HolidayFactory( Record );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetFiscalYears" />
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public BudgetFiscalYears( DataRow dataRow )
            : this( )
        {
            _record = dataRow;
            _inputYear = dataRow[ "BFY" ].ToString( );
            _id = int.Parse( dataRow[ "FiscalYearsId" ].ToString( ) );
            _bfy = dataRow[ "BFY" ].ToString( );
            _efy = dataRow[ "EFY" ].ToString( );
            _firstYear = dataRow[ "FirstYear" ].ToString( );
            _lastYear = dataRow[ "LastYEar" ].ToString( );
            _availability = dataRow[ "Availability" ].ToString( );
            _workDays = double.Parse( dataRow[ "WorkDays" ].ToString( ) );
            _weekDays = double.Parse( dataRow[ "WeekDays" ].ToString( ) );
            _weekEnds = double.Parse( dataRow[ "WeekEnds" ].ToString( ) );
            _expiringYear = dataRow[ "ExpiringYear" ].ToString( );
            _startDate = DateOnly.Parse( dataRow[ "StartDate" ].ToString( ) );
            _endDate = DateOnly.Parse( dataRow[ "EndDate" ].ToString( ) );
            _cancellationDate = DateOnly.Parse( dataRow[ "CancellationDate" ].ToString( ) );
            _holidays = new HolidayFactory( dataRow );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetFiscalYears" />
        /// class.
        /// </summary>
        /// <param name="fiscalYear"> The fiscal year. </param>
        public BudgetFiscalYears( BudgetFiscalYears fiscalYear )
            : this( )
        {
            ID = fiscalYear.ID;
            BFY = fiscalYear.BFY;
            EFY = fiscalYear.EFY;
            FirstYear = fiscalYear.FirstYear;
            LastYear = fiscalYear.LastYear;
            WorkDays = fiscalYear.WorkDays;
            WeekDays = fiscalYear.WeekDays;
            WeekEnds = fiscalYear.WeekEnds;
            ExpiringYear = fiscalYear.ExpiringYear;
            StartDate = fiscalYear.StartDate;
            EndDate = fiscalYear.EndDate;
            CancellationDate = fiscalYear.CancellationDate;
        }

        /// <summary> Gets the federal holidays. </summary>
        /// <returns> </returns>
        public IDictionary<Holiday, DateOnly> GetFederalHolidays( )
        {
            try
            {
                var _map = new Dictionary<Holiday, DateOnly>( );
                var _day = new HolidayFactory( Record );
                _map.Add( Holiday.NewYears, _day.ChristmasDay );
                _map.Add( Holiday.MartinLutherKing, _day.MartinLutherKingDay );
                _map.Add( Holiday.Memorial, _day.MemorialDay );
                _map.Add( Holiday.Washington, _day.PresidentsDay );
                _map.Add( Holiday.Veterans, _day.VeteransDay );
                _map.Add( Holiday.Labor, _day.LaborDay );
                _map.Add( Holiday.Juneteenth, _day.JuneteenthDay );
                _map.Add( Holiday.Independence, _day.IndependenceDay );
                _map.Add( Holiday.Columbus, _day.ColumbusDay );
                _map.Add( Holiday.Thanksgiving, _day.ThanksgivingDay );
                _map.Add( Holiday.Christmas, _day.ChristmasDay );
                return ( _map?.Any( ) == true )
                    ? _map
                    : default( IDictionary<Holiday, DateOnly> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<Holiday, DateOnly> );
            }
        }

        /// <summary> Gets the identifier. </summary>
        /// <returns> </returns>
        public int GetId( )
        {
            try
            {
                return _record != null
                    ? int.Parse( _record[ 0 ].ToString( ) )
                    : -1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }
        
        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns> </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return _record?.ItemArray?.Length > 0
                    ? _record.ToDictionary( )
                    : default( IDictionary<string, object> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A
        /// <see cref="System.String"/>
        /// that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( _firstYear )
                    ? _firstYear
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the budget fiscal year.
        /// </summary>
        /// <returns> </returns>
        public BudgetFiscalYears GetBudgetFiscalYear( )
        {
            try
            {
                return MemberwiseClone( ) as BudgetFiscalYears;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( BudgetFiscalYears );
            }
        }
    }
}