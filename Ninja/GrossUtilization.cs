﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="GrossUtilization.cs" company="Terry D. Eppler">
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
//   GrossUtilization.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class GrossUtilization : DataUnit 
    {
        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string Efy { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public string RpioName { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the ah.
        /// </summary>
        /// <value>
        /// The name of the ah.
        /// </value>
        public string AhName { get; set; }

        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public string OrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the org.
        /// </summary>
        /// <value>
        /// The name of the org.
        /// </value>
        public string OrgName { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public string ProgramProjectName { get; set; }

        /// <summary>
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public string BocCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the boc.
        /// </summary>
        /// <value>
        /// The name of the boc.
        /// </value>
        public string BocName { get; set; }

        /// <summary>
        /// Gets or sets the committed.
        /// </summary>
        /// <value>
        /// The committed.
        /// </value>
        public double Committed { get; set; }

        /// <summary>
        /// Gets or sets the obligated.
        /// </summary>
        /// <value>
        /// The obligated.
        /// </value>
        public double Obligated { get; set; }

        /// <summary>
        /// Gets or sets the unliquidated.
        /// </summary>
        /// <value>
        /// The unliquidated.
        /// </value>
        public double Unliquidated { get; set; }

        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public double Availability { get; set; }

        /// <summary>
        /// Gets or sets the outlaid.
        /// </summary>
        /// <value>
        /// The outlaid.
        /// </value>
        public double Outlaid { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrossUtilization"/> class.
        /// </summary>
        public GrossUtilization( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrossUtilization"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public GrossUtilization( IQuery query )
        {
            Source = query.Source;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Committed = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligated = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
            Unliquidated = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Outlaid = double.Parse( Record[ "Outlays" ].ToString( ) ?? "0" );
            Availability = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrossUtilization"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public GrossUtilization( IDataModel builder )
        {
            Source = builder.Source;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Committed = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligated = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
            Unliquidated = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Outlaid = double.Parse( Record[ "Outlays" ].ToString( ) ?? "0" );
            Availability = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrossUtilization"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public GrossUtilization( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            Efy = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            Committed = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligated = double.Parse( dataRow[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
            Unliquidated = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0" );
            Outlaid = double.Parse( dataRow[ "Outlays" ].ToString( ) ?? "0" );
            Availability = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrossUtilization"/> class.
        /// </summary>
        /// <param name="utilization">The utilization.</param>
        public GrossUtilization( GrossUtilization utilization )
        {
            ID = utilization.ID;
            BFY = utilization.BFY;
            Efy = utilization.Efy;
            FundCode = utilization.FundCode;
            FundName = utilization.FundName;
            RpioCode = utilization.RpioCode;
            RpioName = utilization.RpioName;
            AhCode = utilization.AhCode;
            AhName = utilization.AhName;
            OrgCode = utilization.OrgCode;
            OrgName = utilization.OrgName;
            AccountCode = utilization.AccountCode;
            ProgramProjectName = utilization.ProgramProjectName;
            BocCode = utilization.BocCode;
            BocName = utilization.BocName;
            Committed = utilization.Committed;
            Obligated = utilization.Obligated;
            Unliquidated = utilization.Unliquidated;
            Outlaid = utilization.Outlaid;
            Availability = utilization.Availability;
        }
    }
}