// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="HolidayFactory.cs" company="Terry D. Eppler">
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
//   HolidayFactory.cs
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
    /// <seealso cref="BudgetExecution.FederalHoliday"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class HolidayFactory : FederalHoliday
    {
        /// <summary> Gets or sets the arguments. </summary>
        /// <value> The arguments. </value>
        public IDictionary<string, object> Args { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HolidayFactory"/>
        /// class.
        /// </summary>
        public HolidayFactory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HolidayFactory"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public HolidayFactory( DataRow dataRow )
        {
            Record = dataRow;
            NewYearsDay = DateOnly.Parse( dataRow[ "NewYears" ].ToString( ) );
            MartinLutherKingDay = DateOnly.Parse( dataRow[ "MartinLutherKing" ].ToString( ) );
            PresidentsDay = DateOnly.Parse( dataRow[ "PresidentsDay" ].ToString( ) );
            MemorialDay = DateOnly.Parse( dataRow[ "Memorial" ].ToString( ) );
            VeteransDay = DateOnly.Parse( dataRow[ "Veterans" ].ToString( ) );
            LaborDay = DateOnly.Parse( dataRow[ "Labor" ].ToString( ) );
            IndependenceDay = DateOnly.Parse( dataRow[ "Independence" ].ToString( ) );
            ColumbusDay = DateOnly.Parse( dataRow[ "Columbus" ].ToString( ) );
            ThanksgivingDay = DateOnly.Parse( dataRow[ "Thanksgiving" ].ToString( ) );
            ChristmasDay = DateOnly.Parse( dataRow[ "Christmas" ].ToString( ) );
            Args = Record?.ToDictionary( );
        }

        /// <summary> Gets the federal holidays. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public IDictionary<string, DateTime> GetFederalHolidays( IDictionary<string, string> dict )
        {
            try
            {
                var _holiday = new Dictionary<string, DateTime>( );
                foreach( var _kvp in dict )
                {
                    _holiday.Add( _kvp.Key, DateTime.Parse( _kvp.Value ) );
                }

                return _holiday.Any( )
                    ? _holiday
                    : default( Dictionary<string, DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, DateTime> );
            }
        }

        /// <summary> Gets the national holidays. </summary>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public IDictionary<string, DateTime> GetNationalHolidays( IDictionary<string, string> dict )
        {
            try
            {
                var _holiday = new Dictionary<string, DateTime>( );
                foreach( var _kvp in dict )
                {
                    _holiday.Add( _kvp.Key, DateTime.Parse( _kvp.Value ) );
                }

                return _holiday.Any( )
                    ? _holiday
                    : default( Dictionary<string, DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, DateTime> );
            }
        }

        /// <summary> Converts to dictionary. </summary>
        /// <returns> </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Args.Count > 0
                    ? Args
                    : default( IDictionary<string, object> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}