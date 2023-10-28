// ***********************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              19-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        19-10-2023
// ***********************************************************************************************
// <copyright file="Partition.cs.cs" company="Terry D. Eppler">
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
//   Eppler, Terry.cs
// </summary>
// ***********************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class Partitions
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the fiscal year.
        /// </summary>
        /// <value>
        /// The fiscal year.
        /// </value>
        public string FiscalYear { get; set; }

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
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the program.
        /// </summary>
        /// <value>
        /// The name of the program.
        /// </value>
        public string ProgramName { get; set; }

        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public string ProgramAreaName { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the main account.
        /// </summary>
        /// <value>
        /// The main account.
        /// </value>
        public string MainAccount { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Partitions"/> class.
        /// </summary>
        public Partitions( )
        {
            Source = Source.Partitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Partitions"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Partitions( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PartitionsId" ].ToString( ) ?? string.Empty );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            Type = Record[ "Type" ].ToString( );
            ProgramName = Record[ "ProgramName" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            MainAccount = Record[ "MainAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Partitions"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public Partitions( IDataModel dataBuilder )
            : this( )
        {
            Record = dataBuilder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PartitionsId" ].ToString( ) ?? string.Empty );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            Type = Record[ "Type" ].ToString( );
            ProgramName = Record[ "ProgramName" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            MainAccount = Record[ "MainAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Partitions"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Partitions( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PartitionsId" ].ToString( ) ?? string.Empty );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            Type = Record[ "Type" ].ToString( );
            ProgramName = Record[ "ProgramName" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            MainAccount = Record[ "MainAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
        }
    }
}