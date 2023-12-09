// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CarryoverApportionment.cs" company="Terry D. Eppler">
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
//   CarryoverApportionment.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class CarryoverApportionments : BudgetUnit
    {
        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the budget account.
        /// </summary>
        /// <value>
        /// The budget account.
        /// </value>
        public string BudgetAccount { get; set; }

        /// <summary>
        /// Gets or sets the treasury account.
        /// </summary>
        /// <value>
        /// The treasury account.
        /// </value>
        public string TreasuryAccount { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the line.
        /// </summary>
        /// <value>
        /// The name of the line.
        /// </value>
        public string LineName { get; set; }

        /// <summary>
        /// Gets or sets the type of the authority.
        /// </summary>
        /// <value>
        /// The type of the authority.
        /// </value>
        public string AuthorityType { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public double Request { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        public double Balance { get; set; }

        /// <summary>
        /// Gets or sets the deobligations.
        /// </summary>
        /// <value>
        /// The deobligations.
        /// </value>
        public double Deobligations { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the line split.
        /// </summary>
        /// <value>
        /// The line split.
        /// </value>
        public string LineSplit { get; set; }

        /// <summary>
        /// Gets or sets the apportionment account code.
        /// </summary>
        /// <value>
        /// The apportionment account code.
        /// </value>
        public string ApportionmentAccountCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarryoverApportionments"/> class.
        /// </summary>
        public CarryoverApportionments( )
        {
            Source = Source.CarryoverApportionments;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CarryoverApportionments" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CarryoverApportionments( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverApportionmentsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Group = Record[ nameof( Group ) ].ToString( );
            Description = Record[ nameof( Description ) ].ToString( );
            LineName = Record[ nameof( LineName ) ].ToString( );
            LineNumber = Record[ nameof( LineNumber ) ].ToString( );
            AuthorityType = Record[ nameof( AuthorityType ) ].ToString( );
            Request = double.Parse( Record[ nameof( Request ) ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ nameof( Balance ) ].ToString( ) ?? "0" );
            Deobligations = double.Parse( Record[ nameof( Deobligations ) ].ToString( ) ?? "0" );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            LineSplit = Record[ nameof( LineSplit ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CarryoverApportionments" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CarryoverApportionments( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverApportionmentsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Group = Record[ nameof( Group ) ].ToString( );
            Description = Record[ nameof( Description ) ].ToString( );
            LineName = Record[ nameof( LineName ) ].ToString( );
            LineNumber = Record[ nameof( LineNumber ) ].ToString( );
            AuthorityType = Record[ nameof( AuthorityType ) ].ToString( );
            Request = double.Parse( Record[ nameof( Request ) ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ nameof( Balance ) ].ToString( ) ?? "0" );
            Deobligations = double.Parse( Record[ nameof( Deobligations ) ].ToString( ) ?? "0" );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            LineSplit = Record[ nameof( LineSplit ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CarryoverApportionments" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CarryoverApportionments( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverApportionmentsId" ].ToString( ) ?? "0" );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            Group = dataRow[ nameof( Group ) ].ToString( );
            Description = dataRow[ nameof( Description ) ].ToString( );
            LineName = dataRow[ nameof( LineName ) ].ToString( );
            LineNumber = dataRow[ nameof( LineNumber ) ].ToString( );
            AuthorityType = dataRow[ nameof( AuthorityType ) ].ToString( );
            Request = double.Parse( dataRow[ nameof( Request ) ].ToString( ) ?? "0" );
            Balance = double.Parse( dataRow[ nameof( Balance ) ].ToString( ) ?? "0" );
            Deobligations = double.Parse( dataRow[ nameof( Deobligations ) ].ToString( ) ?? "0" );
            Amount = double.Parse( dataRow[ nameof( Amount ) ].ToString( ) ?? "0" );
            LineSplit = dataRow[ nameof( LineSplit ) ].ToString( );
            ApportionmentAccountCode = dataRow[ nameof( ApportionmentAccountCode ) ].ToString( );
            TreasuryAccountCode = dataRow[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = dataRow[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = dataRow[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = dataRow[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CarryoverApportionments" /> class.
        /// </summary>
        /// <param name="carryover">The carryover.</param>
        public CarryoverApportionments( CarryoverApportionments carryover )
            : this( )
        {
            ID = carryover.ID;
            BFY = carryover.BFY;
            EFY = carryover.EFY;
            Group = carryover.Group;
            Description = carryover.Description;
            LineName = carryover.LineName;
            LineNumber = carryover.LineNumber;
            AuthorityType = carryover.AuthorityType;
            Request = carryover.Request;
            Balance = carryover.Balance;
            Deobligations = carryover.Deobligations;
            Amount = carryover.Amount;
            LineSplit = carryover.LineSplit;
            ApportionmentAccountCode = carryover.ApportionmentAccountCode;
            TreasuryAccountCode = carryover.TreasuryAccountCode;
            TreasuryAccountName = carryover.TreasuryAccountName;
            BudgetAccountCode = carryover.BudgetAccountCode;
            BudgetAccountName = carryover.BudgetAccountName;
        }
    }
}