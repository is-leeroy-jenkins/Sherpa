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

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.FiscalYear"/>
    /// <seealso cref="BudgetExecution.BudgetFiscalYear"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    public class BudgetFiscalYears : FiscalYear 
    {
        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public string Availability { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public HolidayFactory Holidays { get; set; }

        /// <summary>
        /// Gets or sets the federal holidays.
        /// </summary>
        /// <value>
        /// The federal holidays.
        /// </value>
        public IDictionary<Holiday, DateOnly> FederalHolidays { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        public BudgetFiscalYears( )
        {
            Source = Source.FiscalYears;
            CurrentDate = DateTime.Today;
            CurrentYear = DateTime.Now.Year;
            CurrentMonth = DateTime.Now.Month;
            CurrentDay = DateTime.Now.Day;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        /// <param name="bfy"> The bfy. </param>
        public BudgetFiscalYears( string bfy )
            : this( )
        {
            InputYear = bfy;
            Record = new DataBuilder( Source, SetArgs( bfy ) )?.Record;
            ID = int.Parse( Record[ "FiscalYearId" ].ToString( ) );
            FirstYear = Record[ "FirstYear" ].ToString( );
            LastYear = Record[ "LastYEar" ].ToString( );
            Availability = Record[ "Availability" ].ToString( );
            WorkDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            ExpiringYear = Record[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public BudgetFiscalYears( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "FiscalYearId" ].ToString( ) );
            FirstYear = Record[ "FirstYear" ].ToString( );
            LastYear = Record[ "LastYEar" ].ToString( );
            Availability = Record[ "Availability" ].ToString( );
            WorkDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            ExpiringYear = Record[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The data builder. </param>
        public BudgetFiscalYears( IDataModel dataBuilder )
            : this( )
        {
            Record = dataBuilder.Record;
            ID = int.Parse( Record[ "FiscalYearsId" ].ToString( ) );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FirstYear = Record[ "FirstYear" ].ToString( );
            LastYear = Record[ "LastYEar" ].ToString( );
            Availability = Record?[ "Availability" ].ToString( );
            WorkDays = double.Parse( Record[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( Record[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( Record[ "WeekEnds" ].ToString( ) );
            ExpiringYear = Record[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( Record[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public BudgetFiscalYears( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            InputYear = dataRow[ "BFY" ].ToString( );
            ID = int.Parse( dataRow[ "FiscalYearsId" ].ToString( ) );
            BFY = dataRow[ "BFY" ].ToString( );
            Efy = dataRow[ "EFY" ].ToString( );
            FirstYear = dataRow[ "FirstYear" ].ToString( );
            LastYear = dataRow[ "LastYEar" ].ToString( );
            Availability = dataRow[ "Availability" ].ToString( );
            WorkDays = double.Parse( dataRow[ "WorkDays" ].ToString( ) );
            WeekDays = double.Parse( dataRow[ "WeekDays" ].ToString( ) );
            WeekEnds = double.Parse( dataRow[ "WeekEnds" ].ToString( ) );
            ExpiringYear = dataRow[ "ExpiringYear" ].ToString( );
            StartDate = DateOnly.Parse( dataRow[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( dataRow[ "EndDate" ].ToString( ) );
            CancellationDate = DateOnly.Parse( dataRow[ "CancellationDate" ].ToString( ) );
            Holidays = new HolidayFactory( dataRow );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetFiscalYears"/>
        /// class.
        /// </summary>
        /// <param name="fiscalYear"> The fiscal year. </param>
        public BudgetFiscalYears( BudgetFiscalYears fiscalYear )
            : this( )
        {
            ID = fiscalYear.ID;
            BFY = fiscalYear.BFY;
            Efy = fiscalYear.Efy;
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

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns> </returns>
        public IDictionary<Holiday, DateOnly> GetFederalHolidays( )
        {
            try
            {
                var _holidays = new Dictionary<Holiday, DateOnly>( );
                var _day = new HolidayFactory( Record );
                _holidays.Add( Holiday.NewYears, _day.ChristmasDay );
                _holidays.Add( Holiday.MartinLutherKing, _day.MartinLutherKingDay );
                _holidays.Add( Holiday.Memorial, _day.MemorialDay );
                _holidays.Add( Holiday.Washington, _day.PresidentsDay );
                _holidays.Add( Holiday.Veterans, _day.VeteransDay );
                _holidays.Add( Holiday.Labor, _day.LaborDay );
                _holidays.Add( Holiday.Juneteenth, _day.JuneteenthDay );
                _holidays.Add( Holiday.Independence, _day.IndependenceDay );
                _holidays.Add( Holiday.Columbus, _day.ColumbusDay );
                _holidays.Add( Holiday.Thanksgiving, _day.ThanksgivingDay );
                _holidays.Add( Holiday.Christmas, _day.ChristmasDay );
                return ( _holidays?.Any( ) == true )
                    ? _holidays
                    : default( IDictionary<Holiday, DateOnly> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<Holiday, DateOnly> );
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <returns> </returns>
        public int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) )
                    : -1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }

        /// <summary> Gets the identifier. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <param name="primaryKey"> The primary key. </param>
        /// <returns> </returns>
        public int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            try
            {
                return Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) && ( dataRow != null )
                    ? int.Parse( dataRow[ $"{primaryKey}" ].ToString( ) )
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
                return Record?.ItemArray?.Length > 0
                    ? Record.ToDictionary( )
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
                return !string.IsNullOrEmpty( FirstYear )
                    ? FirstYear
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