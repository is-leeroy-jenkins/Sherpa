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

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Fund : FundSymbol 
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Fund"/>
        /// class.
        /// </summary>
        public Fund( )
        {
            Source = Source.Funds;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Fund"/>
        /// class.
        /// </summary>
        /// <param name="fundCode"> The fundCode. </param>
        public Fund( FundCode fundCode )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( fundCode ) )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Fund"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public Fund( string code )
            : this( )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Fund"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Fund( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Fund"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Fund( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Fund"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The Data. </param>
        public Fund( DataRow dataRow )
            : this( )
        {
            Source = Source.Funds;
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "FundsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            Status = Record[ "Status" ].ToString( );
            StartDate = DateOnly.Parse( Record[ "StartDate" ].ToString( ) );
            EndDate = DateOnly.Parse( Record[ "EndDate" ].ToString( ) );
            SubLevelPrefix = Record[ "SubLevelPrefix" ].ToString( );
            AllocationTransferAgency = Record[ "AllocationTransferAgency" ].ToString( );
            AgencyIdentifier = Record[ "AgencyIdentifier" ].ToString( );
            BeginningPeriodOfAvailability = Record[ "BeginningPeriodOfAvailability" ].ToString( );
            EndingPeriodOfAvailability = Record[ "EndingPeriodOfAvailability" ].ToString( );
            MultiYearIndicator = Record[ "MultiYearIndicator" ].ToString( );
            MainAccount = Record[ "MainAccount" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            FundCategory = Record[ "FundCategory" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            FundGroup = Record[ "FundGroup" ].ToString( );
            NoYear = Record[ "NoYear" ].ToString( );
            Carryover = Record[ "Carryover" ].ToString( );
            CancelledYearSpendingAccount = Record[ "CancelledYearSpendingAccount" ].ToString( );
            ApplyAtAllLevels = Record[ "ApplyAtAllLevels" ].ToString( );
            BatsFund = Record[ "BatsFund" ].ToString( );
            BatsEndDate = DateOnly.Parse( Record[ "BatsEndDate" ].ToString( ) );
            BatsOptionId = Record[ "BatsOptionId" ].ToString( );
            SecurityOrg = Record[ "SecurityOrg" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
        }

        public Fund( Fund fund )
        {
            ID = fund.ID;
            BFY = fund.BFY;
            Efy = fund.Efy;
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