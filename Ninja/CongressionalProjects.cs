// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CongressionalProjects.cs" company="Terry D. Eppler">
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
//   CongressionalProjects.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CongressionalProjects
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        public DataRow Record { get; set; }

        /// <summary> </summary>
        public string BFY { get; set; }

        /// <summary> </summary>
        public string EFY { get; set; }

        /// <summary> </summary>
        public string FundCode { get; set; }

        /// <summary> </summary>
        public string FundName { get; set; }

        /// <summary> </summary>
        public string RpioCode { get; set; }

        /// <summary> </summary>
        public string RpioName { get; set; }

        /// <summary> </summary>
        public string StateCode { get; set; }

        /// <summary> </summary>
        public string StateName { get; set; }

        /// <summary> </summary>
        public string ProjectName { get; set; }

        /// <summary> </summary>
        public double Amount { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CongressionalProjects"/>
        /// class.
        /// </summary>
        public CongressionalProjects( )
        {
            Source = Source.CongressionalProjects;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CongressionalProjects"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public CongressionalProjects( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalProjectsId" ].ToString( ) );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            StateCode = Record[ "StateCode" ].ToString( );
            StateName = Record[ "StateName" ].ToString( );
            ProjectName = Record[ "ProjectName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CongressionalProjects"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public CongressionalProjects( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalProjectsId" ].ToString( ) );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            StateCode = Record[ "StateCode" ].ToString( );
            StateName = Record[ "StateName" ].ToString( );
            ProjectName = Record[ "ProjectName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CongressionalProjects"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public CongressionalProjects( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "CongressionalProjectsId" ].ToString( ) );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            StateCode = Record[ "StateCode" ].ToString( );
            StateName = Record[ "StateName" ].ToString( );
            ProjectName = Record[ "ProjectName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
        }

        /// <summary> </summary>
        /// <param name="project"> </param>
        public CongressionalProjects( CongressionalProjects project )
        {
            ID = project.ID;
            BFY = project.BFY;
            EFY = project.EFY;
            RpioCode = project.RpioCode;
            RpioName = project.RpioName;
            StateCode = project.StateCode;
            StateName = project.StateName;
            ProjectName = project.ProjectName;
            Amount = project.Amount;
        }
    }
}