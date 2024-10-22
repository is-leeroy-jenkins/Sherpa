﻿// ******************************************************************************************
//     Assembly:             Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        03-23-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Sherpa is a small Federal Budget, Finance, and Accounting data management
//    application for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   TimeSpanExtensions.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// The average days in a year
        /// </summary>
        public const double AvgDaysInAYear = 365.2425d;

        /// <summary>
        /// The average days in a month
        /// </summary>
        public const double AvgDaysInAMonth = 30.436875d;

        /// <summary>
        /// Gets the years.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetYears( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays / AvgDaysInAYear );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the total years.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetTotalYears( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / AvgDaysInAYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0D;
            }
        }

        /// <summary>
        /// Gets the months.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetMonths( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % AvgDaysInAYear / AvgDaysInAMonth );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the total months.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetTotalMonths( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / AvgDaysInAMonth;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0D;
            }
        }

        /// <summary>
        /// Gets the weeks.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetWeeks( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % AvgDaysInAYear % AvgDaysInAMonth / 7d );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the total weeks.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetTotalWeeks( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.TotalDays / 7d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0D;
            }
        }

        /// <summary>
        /// Gets the days.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static int GetDays( this TimeSpan timeSpan )
        {
            try
            {
                return (int)( timeSpan.TotalDays % 7d );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the microseconds.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetMicroseconds( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.Ticks / 10d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0D;
            }
        }

        /// <summary>
        /// Gets the nanoseconds.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <returns></returns>
        public static double GetNanoseconds( this TimeSpan timeSpan )
        {
            try
            {
                return timeSpan.Ticks / 100d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0D;
            }
        }

        /// <summary>
        /// Rounds the specified rounding interval.
        /// </summary>
        /// <param name="timeSpan">The time span.</param>
        /// <param name="interval">The rounding interval.</param>
        /// <param name="rounding">The rounding type.</param>
        /// <returns></returns>
        public static TimeSpan Round( this TimeSpan timeSpan, TimeSpan interval,
            MidpointRounding rounding = MidpointRounding.ToEven )
        {
            try
            {
                var _time = Math.Round( timeSpan.Ticks / (double)interval.Ticks, rounding );
                return new TimeSpan( Convert.ToInt64( Math.Round( _time ) * interval.Ticks ) );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( TimeSpan );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}