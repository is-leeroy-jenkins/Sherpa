//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                DateTimeExtensions.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DateTimeExtensions.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    DateTimeExtensions.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using static DateTimeExtensions;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class DateTimeExtensions
    {
        /// <summary> Verifies if the object is a startDate </summary>
        /// <param name="date"> The date. </param>
        /// <returns>
        /// The
        /// <see cref="bool"/>
        /// </returns>
        public static bool IsDate( this object date )
        {
            try
            {
                return DateTime.TryParse( date.ToString( ), out _ );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> Returns the weekdays between two dates. </summary>
        /// <param name="startDate"> The start time. </param>
        /// <param name="endDate"> The end time. </param>
        /// <returns> </returns>
        public static IEnumerable<DateTime> GetWeekdays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                var _weekdays = new List<DateTime>( );
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( _dateTime.IsWeekDay( ) )
                    {
                        _weekdays.Add( _dateTime );
                    }
                }

                return _weekdays?.Any( ) == true
                    ? _weekdays
                    : default( IEnumerable<DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<DateTime> );
            }
        }

        /// <summary>
        /// Gets the week ends until.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public static IEnumerable<DateTime> GetWeekends( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                var _weekends = new List<DateTime>( );
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( _dateTime.IsWeekEnd( ) )
                    {
                        _weekends.Add( _dateTime );
                    }
                }

                return _weekends?.Any( ) == true
                    ? _weekends
                    : default( IEnumerable<DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<DateTime> );
            }
        }

        /// <summary>
        /// Gets the holidays until.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public static IEnumerable<DateTime> GetHolidays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                var _holidays = new List<DateTime>( );
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( _dateTime.IsFederalHoliday( ) )
                    {
                        _holidays.Add( _dateTime );
                    }
                }

                return _holidays?.Any( ) == true
                    ? _holidays
                    : default( IEnumerable<DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<DateTime> );
            }
        }

        /// <summary>
        /// Gets the workdays
        /// </summary>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <returns>
        /// </returns>
        public static IEnumerable<DateTime> GetWorkdays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                var _workdays = new List<DateTime>( );
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( !_dateTime.IsFederalHoliday( )
                       && !_dateTime.IsWeekEnd( ) )
                    {
                        _workdays.Add( _dateTime );
                    }
                }

                return _workdays?.Any( ) == true
                    ? _workdays
                    : default( IEnumerable<DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<DateTime> );
            }
        }

        /// <summary> Checks to see if the startDate is a week day (Mon - Fri) </summary>
        /// <param name="dateTime"> The date. </param>
        /// <returns>
        /// The
        /// <see cref="bool"/>
        /// </returns>
        public static bool IsWeekDay( this DateTime dateTime )
        {
            try
            {
                return ( dateTime.DayOfWeek != DayOfWeek.Saturday )
                    && ( dateTime.DayOfWeek != DayOfWeek.Sunday );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> Checks to see if the startDate is Saturday or Sunday </summary>
        /// <returns>
        /// The
        /// <see cref="bool"/>
        /// </returns>
        public static bool IsWeekEnd( this DateTime dateTime )
        {
            try
            {
                return ( dateTime.DayOfWeek == DayOfWeek.Saturday )
                    || ( dateTime.DayOfWeek == DayOfWeek.Sunday );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> Determines whether the specified start date is between. </summary>
        /// <param name="dateTime"> The date time. </param>
        /// <param name="startDate"> The start date. </param>
        /// <param name="endDate"> The end date. </param>
        /// <param name="compareTime">
        /// if set to
        /// <c> true </c>
        /// [compare time].
        /// </param>
        /// <returns>
        /// <c> true </c>
        /// if the specified start date is between; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public static bool IsBetween( this DateTime dateTime, DateTime startDate, DateTime endDate,
            bool compareTime = false )
        {
            try
            {
                ThrowIf.NotDate( startDate, "startDate" );
                ThrowIf.NotDate( endDate, "endDate" );
                return compareTime
                    ? ( dateTime >= startDate ) && ( dateTime <= endDate )
                    : ( dateTime.Date >= startDate.Date ) && ( dateTime.Date <= endDate.Date );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Adds the workdays.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        public static DateTime AddWorkdays( this DateTime startDate, int days )
        {
            try
            {
                // start from a weekday        
                while( startDate.IsWeekEnd( ) )
                {
                    startDate = startDate.AddDays( 1.0 );
                }

                for( var _i = 0; _i < days; ++_i )
                {
                    startDate = startDate.AddDays( 1.0 );
                    while( startDate.IsWeekEnd( ) )
                    {
                        startDate = startDate.AddDays( 1.0 );
                    }
                }

                return startDate;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DateTime );
            }
        }

        /// <summary> Counts the number of weekdays between two dates. </summary>
        /// <param name="startDate"> The start time. </param>
        /// <param name="endDate"> The end time. </param>
        /// <returns> </returns>
        public static int CountWeekDays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( _dateTime.IsWeekDay( ) )
                    {
                        _days++;
                    }
                }

                return _days > 0
                    ? _days
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary> Counts the number of weekends between two dates. </summary>
        /// <param name="startDate"> The start time. </param>
        /// <param name="endDate"> The end time. </param>
        /// <returns> </returns>
        public static int CountWeekEnds( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _weekEnds = 0;
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( _dateTime.IsWeekEnd( ) )
                    {
                        _weekEnds++;
                    }
                }

                return _weekEnds > 0
                    ? _weekEnds
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary>
        /// Counts the workdays.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public static int CountWorkdays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( !_dateTime.IsFederalHoliday( )
                       && !_dateTime.IsWeekEnd( ) )
                    {
                        _days++;
                    }
                }

                return _days > 0
                    ? _days
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary>
        /// Counts the holidays.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public static int CountHolidays( this DateTime startDate, DateTime endDate )
        {
            try
            {
                ThrowIf.NotDate( endDate, "endDate" );
                var _timeSpan = endDate - startDate;
                var _days = 0;
                for( var _i = 0; _i < _timeSpan.Days; _i++ )
                {
                    var _dateTime = startDate.AddDays( _i );
                    if( _dateTime.IsFederalHoliday( ) )
                    {
                        _days++;
                    }
                }

                return _days > 0
                    ? _days
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary> The IsFederalHoliday </summary>
        /// <param name="dateTime">
        /// The startDate
        /// <see cref="DateTime"/>
        /// </param>
        /// <returns>
        /// The
        /// <see cref="bool"/>
        /// </returns>
        public static bool IsFederalHoliday( this DateTime dateTime )
        {
            // to ease typing
            var _nthDay = (int)Math.Ceiling( dateTime.Day / 7.0d );
            var _date = dateTime.DayOfWeek;
            var _thursday = _date == DayOfWeek.Thursday;
            var _friday = _date == DayOfWeek.Friday;
            var _monday = _date == DayOfWeek.Monday;
            var _weekend = ( _date == DayOfWeek.Saturday ) || ( _date == DayOfWeek.Sunday );
            switch( dateTime.Month )
            {
                // New Years Day (Jan 1, or preceding Friday/following Monday if weekend)
                case 12 when ( dateTime.Day == 31 ) && _friday:
                case 1 when ( dateTime.Day == 1 ) && !_weekend:
                case 1 when ( dateTime.Day == 2 ) && _monday:

                // MLK day (3rd monday in January)
                case 1 when _monday && ( _nthDay == 3 ):

                // President’s Day (3rd Monday in February)
                case 2 when _monday && ( _nthDay == 3 ):

                // MemorialDay Day (Last Monday in May)
                case 5 when _monday && ( dateTime.AddDays( 7 ).Month == 6 ):

                // Juneteenth (June 19)
                case 6 when ( dateTime.Day == 18 ) && _friday:
                case 6 when ( dateTime.Day == 19 ) && !_weekend:
                case 6 when ( dateTime.Day == 20 ) && _monday:

                // IndependenceDay Day (July 4, or preceding Friday/following Monday if weekend)
                case 7 when ( dateTime.Day == 3 ) && _friday:
                case 7 when ( dateTime.Day == 4 ) && !_weekend:
                case 7 when ( dateTime.Day == 5 ) && _monday:

                // LaborDay Day (1st Monday in September)
                case 9 when _monday && ( _nthDay == 1 ):

                // ColumbusDay Day (2nd Monday in October)
                case 10 when _monday && ( _nthDay == 2 ):

                // Veteran’s Day (November 11, or preceding Friday/following Monday if weekend))
                case 11 when ( dateTime.Day == 10 ) && _friday:
                case 11 when ( dateTime.Day == 11 ) && !_weekend:
                case 11 when ( dateTime.Day == 12 ) && _monday:

                // ThanksgivingDay Day (4th Thursday in November)
                case 11 when _thursday && ( _nthDay == 4 ):

                // ChristmasDay Day (December 25, or preceding Friday/following Monday if weekend))
                case 12 when ( dateTime.Day == 24 ) && _friday:
                case 12 when ( dateTime.Day == 25 ) && !_weekend:
                case 12 when ( dateTime.Day == 26 ) && _monday:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}