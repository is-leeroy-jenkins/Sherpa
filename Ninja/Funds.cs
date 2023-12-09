// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Fund.cs" company="Terry D. Eppler">
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
//   Fund.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Funds : FundSymbols
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Funds"/>
        /// class.
        /// </summary>
        public Funds( )
        {
            Source = Source.Funds;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Fund"/>
        /// class.
        /// </summary>
        /// <param name="fundCode"> The fundCode. </param>
        public Funds( FundCode fundCode )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( fundCode ) )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            ShortName = Record[ nameof( ShortName ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            StartDate = DateOnly.Parse( Record[ nameof( StartDate ) ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ nameof( EndDate ) ].ToString( ) );
            SubLevelPrefix = Record[ nameof( SubLevelPrefix ) ].ToString( );
            AllocationTransferAgency = Record[ nameof( AllocationTransferAgency ) ].ToString( );
            AgencyIdentifier = Record[ nameof( AgencyIdentifier ) ].ToString( );
            BeginningPeriodOfAvailability = Record[ nameof( BeginningPeriodOfAvailability ) ].ToString( );
            EndingPeriodOfAvailability = Record[ nameof( EndingPeriodOfAvailability ) ].ToString( );
            MultiYearIndicator = Record[ nameof( MultiYearIndicator ) ].ToString( );
            MainAccount = Record[ nameof( MainAccount ) ].ToString( );
            SubAccount = Record[ nameof( SubAccount ) ].ToString( );
            FundCategory = Record[ nameof( FundCategory ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            FundGroup = Record[ nameof( FundGroup ) ].ToString( );
            NoYear = Record[ nameof( NoYear ) ].ToString( );
            Carryover = Record[ nameof( Carryover ) ].ToString( );
            CancelledYearSpendingAccount = Record[ nameof( CancelledYearSpendingAccount ) ].ToString( );
            ApplyAtAllLevels = Record[ nameof( ApplyAtAllLevels ) ].ToString( );
            BatsFund = Record[ nameof( BatsFund ) ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ nameof( BatsEndDate ) ].ToString( ) );
            BatsOptionId = Record[ nameof( BatsOptionId ) ].ToString( );
            SecurityOrg = Record[ nameof( SecurityOrg ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Fund"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public Funds( string code )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            ShortName = Record[ nameof( ShortName ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            StartDate = DateOnly.Parse( Record[ nameof( StartDate ) ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ nameof( EndDate ) ].ToString( ) );
            SubLevelPrefix = Record[ nameof( SubLevelPrefix ) ].ToString( );
            AllocationTransferAgency = Record[ nameof( AllocationTransferAgency ) ].ToString( );
            AgencyIdentifier = Record[ nameof( AgencyIdentifier ) ].ToString( );
            BeginningPeriodOfAvailability = Record[ nameof( BeginningPeriodOfAvailability ) ].ToString( );
            EndingPeriodOfAvailability = Record[ nameof( EndingPeriodOfAvailability ) ].ToString( );
            MultiYearIndicator = Record[ nameof( MultiYearIndicator ) ].ToString( );
            MainAccount = Record[ nameof( MainAccount ) ].ToString( );
            SubAccount = Record[ nameof( SubAccount ) ].ToString( );
            FundCategory = Record[ nameof( FundCategory ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            FundGroup = Record[ nameof( FundGroup ) ].ToString( );
            NoYear = Record[ nameof( NoYear ) ].ToString( );
            Carryover = Record[ nameof( Carryover ) ].ToString( );
            CancelledYearSpendingAccount = Record[ nameof( CancelledYearSpendingAccount ) ].ToString( );
            ApplyAtAllLevels = Record[ nameof( ApplyAtAllLevels ) ].ToString( );
            BatsFund = Record[ nameof( BatsFund ) ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ nameof( BatsEndDate ) ].ToString( ) );
            BatsOptionId = Record[ nameof( BatsOptionId ) ].ToString( );
            SecurityOrg = Record[ nameof( SecurityOrg ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Fund"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Funds( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            ShortName = Record[ nameof( ShortName ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            StartDate = DateOnly.Parse( Record[ nameof( StartDate ) ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ nameof( EndDate ) ].ToString( ) );
            SubLevelPrefix = Record[ nameof( SubLevelPrefix ) ].ToString( );
            AllocationTransferAgency = Record[ nameof( AllocationTransferAgency ) ].ToString( );
            AgencyIdentifier = Record[ nameof( AgencyIdentifier ) ].ToString( );
            BeginningPeriodOfAvailability = Record[ nameof( BeginningPeriodOfAvailability ) ].ToString( );
            EndingPeriodOfAvailability = Record[ nameof( EndingPeriodOfAvailability ) ].ToString( );
            MultiYearIndicator = Record[ nameof( MultiYearIndicator ) ].ToString( );
            MainAccount = Record[ nameof( MainAccount ) ].ToString( );
            SubAccount = Record[ nameof( SubAccount ) ].ToString( );
            FundCategory = Record[ nameof( FundCategory ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            FundGroup = Record[ nameof( FundGroup ) ].ToString( );
            NoYear = Record[ nameof( NoYear ) ].ToString( );
            Carryover = Record[ nameof( Carryover ) ].ToString( );
            CancelledYearSpendingAccount = Record[ nameof( CancelledYearSpendingAccount ) ].ToString( );
            ApplyAtAllLevels = Record[ nameof( ApplyAtAllLevels ) ].ToString( );
            BatsFund = Record[ nameof( BatsFund ) ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ nameof( BatsEndDate ) ].ToString( ) );
            BatsOptionId = Record[ nameof( BatsOptionId ) ].ToString( );
            SecurityOrg = Record[ nameof( SecurityOrg ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Fund"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Funds( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            ShortName = Record[ nameof( ShortName ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            StartDate = DateOnly.Parse( Record[ nameof( StartDate ) ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ nameof( EndDate ) ].ToString( ) );
            SubLevelPrefix = Record[ nameof( SubLevelPrefix ) ].ToString( );
            AllocationTransferAgency = Record[ nameof( AllocationTransferAgency ) ].ToString( );
            AgencyIdentifier = Record[ nameof( AgencyIdentifier ) ].ToString( );
            BeginningPeriodOfAvailability = Record[ nameof( BeginningPeriodOfAvailability ) ].ToString( );
            EndingPeriodOfAvailability = Record[ nameof( EndingPeriodOfAvailability ) ].ToString( );
            MultiYearIndicator = Record[ nameof( MultiYearIndicator ) ].ToString( );
            MainAccount = Record[ nameof( MainAccount ) ].ToString( );
            SubAccount = Record[ nameof( SubAccount ) ].ToString( );
            FundCategory = Record[ nameof( FundCategory ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            FundGroup = Record[ nameof( FundGroup ) ].ToString( );
            NoYear = Record[ nameof( NoYear ) ].ToString( );
            Carryover = Record[ nameof( Carryover ) ].ToString( );
            CancelledYearSpendingAccount = Record[ nameof( CancelledYearSpendingAccount ) ].ToString( );
            ApplyAtAllLevels = Record[ nameof( ApplyAtAllLevels ) ].ToString( );
            BatsFund = Record[ nameof( BatsFund ) ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ nameof( BatsEndDate ) ].ToString( ) );
            BatsOptionId = Record[ nameof( BatsOptionId ) ].ToString( );
            SecurityOrg = Record[ nameof( SecurityOrg ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Fund"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The Data. </param>
        public Funds( DataRow dataRow )
            : this( )
        {
            Source = Source.Funds;
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            ShortName = Record[ nameof( ShortName ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            StartDate = DateOnly.Parse( Record[ nameof( StartDate ) ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ nameof( EndDate ) ].ToString( ) );
            SubLevelPrefix = Record[ nameof( SubLevelPrefix ) ].ToString( );
            AllocationTransferAgency = Record[ nameof( AllocationTransferAgency ) ].ToString( );
            AgencyIdentifier = Record[ nameof( AgencyIdentifier ) ].ToString( );
            BeginningPeriodOfAvailability = Record[ nameof( BeginningPeriodOfAvailability ) ].ToString( );
            EndingPeriodOfAvailability = Record[ nameof( EndingPeriodOfAvailability ) ].ToString( );
            MultiYearIndicator = Record[ nameof( MultiYearIndicator ) ].ToString( );
            MainAccount = Record[ nameof( MainAccount ) ].ToString( );
            SubAccount = Record[ nameof( SubAccount ) ].ToString( );
            FundCategory = Record[ nameof( FundCategory ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            FundGroup = Record[ nameof( FundGroup ) ].ToString( );
            NoYear = Record[ nameof( NoYear ) ].ToString( );
            Carryover = Record[ nameof( Carryover ) ].ToString( );
            CancelledYearSpendingAccount = Record[ nameof( CancelledYearSpendingAccount ) ].ToString( );
            ApplyAtAllLevels = Record[ nameof( ApplyAtAllLevels ) ].ToString( );
            BatsFund = Record[ nameof( BatsFund ) ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ nameof( BatsEndDate ) ].ToString( ) );
            BatsOptionId = Record[ nameof( BatsOptionId ) ].ToString( );
            SecurityOrg = Record[ nameof( SecurityOrg ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
            ApportionmentAccountCode = Record[ nameof( ApportionmentAccountCode ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Funds"/>
        /// class.
        /// </summary>
        /// <param name="fund"> The fund. </param>
        public Funds( Funds fund )
        {
            ID = fund.ID;
            BFY = fund.BFY;
            EFY = fund.EFY;
            Code = fund.Code;
            Name = fund.Name;
            ShortName = fund.ShortName;
            Status = fund.Status;
            StartDate = fund.StartDate;
            EndDate = fund.EndDate;
            SubLevelPrefix = fund.SubLevelPrefix;
            AllocationTransferAgency = fund.AllocationTransferAgency;
            AgencyIdentifier = fund.AgencyIdentifier;
            BeginningPeriodOfAvailability = fund.BeginningPeriodOfAvailability;
            EndingPeriodOfAvailability = fund.EndingPeriodOfAvailability;
            MultiYearIndicator = fund.MultiYearIndicator;
            MainAccount = fund.MainAccount;
            SubAccount = fund.SubAccount;
            FundCategory = fund.FundCategory;
            AppropriationCode = fund.AppropriationCode;
            SubAppropriationCode = fund.SubAppropriationCode;
            FundGroup = fund.FundCategory;
            NoYear = fund.NoYear;
            Carryover = fund.Carryover;
            CancelledYearSpendingAccount = fund.CancelledYearSpendingAccount;
            ApplyAtAllLevels = fund.ApplyAtAllLevels;
            BatsFund = fund.BatsFund;
            BatsEndDate = fund.BatsEndDate;
            BatsOptionId = fund.BatsOptionId;
            SecurityOrg = fund.SecurityOrg;
            TreasuryAccountCode = fund.TreasuryAccountCode;
            TreasuryAccountName = fund.TreasuryAccountName;
            BudgetAccountCode = fund.BudgetAccountCode;
            BudgetAccountName = fund.BudgetAccountName;
            ApportionmentAccountCode = fund.ApportionmentAccountCode;
        }
    }
}