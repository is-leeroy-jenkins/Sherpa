// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StatusOfSuperfundSites.cs" company="Terry D. Eppler">
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
//   StatusOfSuperfundSites.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class StatusOfSuperfundSites
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> </summary>
        public string FiscalYear { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public string EFY { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public string RpioName { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public string FundName { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        public string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        public string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the state. </summary>
        /// <value> The state. </value>
        public string StateCode { get; set; }

        /// <summary> </summary>
        public string StateName { get; set; }

        /// <summary> Gets or sets the city. </summary>
        /// <value> The city. </value>
        public string City { get; set; }

        /// <summary> Gets or sets the congressional district. </summary>
        /// <value> The congressional district. </value>
        public string StreetAddress { get; set; }

        /// <summary> Gets or sets the type of the project. </summary>
        /// <value> The type of the project. </value>
        public string ZipCode { get; set; }

        /// <summary> Gets or sets the Obligations. </summary>
        /// <value> The Obligations. </value>
        public double Obligations { get; set; }

        /// <summary> Gets or sets the Deobligations. </summary>
        /// <value> The Deobligations. </value>
        public double Deobligations { get; set; }

        /// <summary> Gets or sets the Expenditures. </summary>
        /// <value> The Expenditures. </value>
        public double Expenditures { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSuperfundSites"/>
        /// class.
        /// </summary>
        public StatusOfSuperfundSites( )
        {
            Source = Source.StatusOfSuperfundSites;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSuperfundSites"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StatusOfSuperfundSites( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfSuperfundSitesId" ].ToString(  ) );
            FiscalYear = Record[ "FiscalYear" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            EFY = Record[ "EFY" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString(  );
            RpioName = Record[ "RpioName" ].ToString(  );
            FundCode = Record[ "FundCode" ].ToString(  );
            FundName = Record[ "FundName" ].ToString(  );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString(  );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString(  );
            StateCode = Record[ "StateCode" ].ToString(  );
            StateName = Record[ "StateName" ].ToString(  );
            City = Record[ "City" ].ToString(  );
            StreetAddress = Record[ "StreetAddress" ].ToString(  );
            ZipCode = Record[ "ZipCode" ].ToString(  );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) );
            Deobligations = double.Parse( Record[ "Deobligations" ].ToString(  ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSuperfundSites"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public StatusOfSuperfundSites( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfSuperfundSitesId" ].ToString(  ) );
            FiscalYear = Record[ "FiscalYear" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            EFY = Record[ "EFY" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString(  );
            RpioName = Record[ "RpioName" ].ToString(  );
            FundCode = Record[ "FundCode" ].ToString(  );
            FundName = Record[ "FundName" ].ToString(  );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString(  );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString(  );
            StateCode = Record[ "StateCode" ].ToString(  );
            StateName = Record[ "StateName" ].ToString(  );
            City = Record[ "City" ].ToString(  );
            StreetAddress = Record[ "StreetAddress" ].ToString(  );
            ZipCode = Record[ "ZipCode" ].ToString(  );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) );
            Deobligations = double.Parse( Record[ "Deobligations" ].ToString(  ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSuperfundSites"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StatusOfSuperfundSites( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfSuperfundSitesId" ].ToString(  ) );
            FiscalYear = Record[ "FiscalYear" ].ToString(  );
            BFY = Record[ "BFY" ].ToString(  );
            EFY = Record[ "EFY" ].ToString(  );
            RpioCode = Record[ "RpioCode" ].ToString(  );
            RpioName = Record[ "RpioName" ].ToString(  );
            FundCode = Record[ "FundCode" ].ToString(  );
            FundName = Record[ "FundName" ].ToString(  );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString(  );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString(  );
            StateCode = Record[ "StateCode" ].ToString(  );
            StateName = Record[ "StateName" ].ToString(  );
            City = Record[ "City" ].ToString(  );
            StreetAddress = Record[ "StreetAddress" ].ToString(  );
            ZipCode = Record[ "ZipCode" ].ToString(  );
            Obligations = double.Parse( Record[ "Obligations" ].ToString(  ) );
            Deobligations = double.Parse( Record[ "Deobligations" ].ToString(  ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString(  ) );
        }

        /// <summary> </summary>
        /// <param name="site"> </param>
        public StatusOfSuperfundSites( StatusOfSuperfundSites site )
        {
            ID = site.ID;
            FiscalYear = site.FiscalYear;
            BFY = site.BFY;
            EFY = site.EFY;
            RpioCode = site.RpioCode;
            RpioName = site.RpioName;
            FundCode = site.FundCode;
            FundName = site.FundName;
            ProgramProjectCode = site.ProgramProjectCode;
            ProgramProjectName = site.ProgramProjectName;
            StateCode = site.StateCode;
            StateName = site.StateName;
            City = site.City;
            StreetAddress = site.StreetAddress;
            ZipCode = site.ZipCode;
            Obligations = site.Obligations;
            Deobligations = site.Deobligations;
            Expenditures = site.Expenditures;
        }
    }
}