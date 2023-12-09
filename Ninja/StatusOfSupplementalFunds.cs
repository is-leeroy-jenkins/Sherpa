//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                StatusOfSupplementalFunds.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="StatusOfSupplementalFunds.cs" company="Terry D. Eppler">
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
//    StatusOfSupplementalFunds.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class StatusOfSupplementalFunds : StatusOfFunds
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfSupplementalFunds" />
        /// class.
        /// </summary>
        public StatusOfSupplementalFunds( )
        {
            Source = Source.StatusOfSupplementalFunds;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfSupplementalFunds" />
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StatusOfSupplementalFunds( IQuery query )
            : base( query )
        {
            Source = Source.StatusOfSupplementalFunds;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? string.Empty );

            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfSupplementalFunds" />
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The builder. </param>
        public StatusOfSupplementalFunds( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Source = Source.StatusOfSupplementalFunds;
            Record = dataBuilder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? string.Empty );

            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfSupplementalFunds" />
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StatusOfSupplementalFunds( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.StatusOfSupplementalFunds;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( dataRow[ "UnliquidatedObligations" ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0" );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString( ) ?? "0" );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0" );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
            NpmName = dataRow[ "NpmName" ].ToString( );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="allocations"></param>
        public StatusOfSupplementalFunds( Allocations allocations )
        {
            ID = allocations.ID;
            BudgetLevel = allocations.BudgetLevel;
            BFY = allocations.BFY;
            EFY = allocations.EFY;
            FundCode = allocations.FundCode;
            FundName = allocations.FundName;
            RpioCode = allocations.RpioCode;
            RpioName = allocations.RpioName;
            AhCode = allocations.AhCode;
            AhName = allocations.AhName;
            OrgCode = allocations.OrgCode;
            OrgName = allocations.OrgName;
            AccountCode = allocations.AccountCode;
            BocCode = allocations.BocCode;
            BocName = allocations.BocName;
            Amount = allocations.Amount;
            ProgramProjectCode = allocations.ProgramProjectCode;
            ProgramProjectName = allocations.ProgramProjectName;
            ProgramAreaCode = allocations.ProgramAreaCode;
            ProgramAreaName = allocations.ProgramAreaName;
            NpmCode = allocations.NpmCode;
            NpmName = allocations.NpmName;
            TreasuryAccountCode = allocations.TreasuryAccountCode;
            TreasuryAccountName = allocations.TreasuryAccountName;
            BudgetAccountCode = allocations.BudgetAccountCode;
            BudgetAccountName = allocations.BudgetAccountName;
        }
    }
}