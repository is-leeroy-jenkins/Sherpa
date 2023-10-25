//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                MainAccounts.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="MainAccounts.cs" company="Terry D. Eppler">
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
//    MainAccounts.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class MainAccounts
    {
        /// <summary>
        /// Gets or sets the main accounts identifier.
        /// </summary>
        /// <value>
        /// The main accounts identifier.
        /// </value>
        public int MainAccountsId { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sub function code.
        /// </summary>
        /// <value>
        /// The sub function code.
        /// </value>
        public string SubFunctionCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the sub function.
        /// </summary>
        /// <value>
        /// The name of the sub function.
        /// </value>
        public string SubFunctionName { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the treasury account.
        /// </summary>
        /// <value>
        /// The name of the treasury account.
        /// </value>
        public string TreasuryAccountName { get; set; }

        /// <summary>
        /// Gets or sets the budget enforcement act category.
        /// </summary>
        /// <value>
        /// The budget enforcement act category.
        /// </value>
        public string BudgetEnforcementActCategory { get; set; }

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
        /// Initializes a new instance of the <see cref="MainAccounts"/> class.
        /// </summary>
        public MainAccounts( )
        {
            Source = Source.MainAccounts;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.MainAccounts" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public MainAccounts( IQuery query )
            : this( )
        {
            Provider = query.Provider;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            MainAccountsId = int.Parse( Record[ "MainAccountsId" ].ToString( ) ?? string.Empty );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            BudgetEnforcementActCategory = Record[ "BudgetEnforcementActCategory" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.MainAccounts" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public MainAccounts( IDataModel builder )
            : this( )
        {
            Provider = builder.Provider;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            MainAccountsId = int.Parse( Record[ "MainAccountsId" ].ToString( ) ?? string.Empty );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            BudgetEnforcementActCategory = Record[ "BudgetEnforcementActCategory" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.MainAccounts" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MainAccounts( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            MainAccountsId = int.Parse( Record[ "MainAccountsId" ].ToString( ) ?? string.Empty );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            BudgetEnforcementActCategory = Record[ "BudgetEnforcementActCategory" ].ToString( );
        }
    }
}