﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="UnliquidatedObligation.cs" company="Terry D. Eppler">
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
//   UnliquidatedObligation.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class UnliquidatedObligations : Obligations
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.UnliquidatedObligation" />
        /// class.
        /// </summary>
        public UnliquidatedObligations( )
        {
            Source = Source.UnliquidatedObligations;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.UnliquidatedObligation" />
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public UnliquidatedObligations( IQuery query )
            : base( query )
        {
            Source = Source.UnliquidatedObligations;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "UnliquidatedObligationsId" ].ToString( ) ?? string.Empty );
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
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
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.UnliquidatedObligations" />
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public UnliquidatedObligations( IDataModel builder )
            : base( builder )
        {
            Source = Source.UnliquidatedObligations;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "UnliquidatedObligationsId" ].ToString(  ) ?? string.Empty );
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
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
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnliquidatedObligations"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public UnliquidatedObligations( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.UnliquidatedObligations;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "UnliquidatedObligationsId" ].ToString(  ) );
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
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
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        public UnliquidatedObligations( UnliquidatedObligations ulo )
        {
            ID = ulo.ID;
            BudgetLevel = ulo.BudgetLevel;
            BFY = ulo.BFY;
            EFY = ulo.EFY;
            FundCode = ulo.FundCode;
            FundName = ulo.FundName;
            RpioCode = ulo.RpioCode;
            RpioName = ulo.RpioName;
            AhCode = ulo.AhCode;
            AhName = ulo.AhName;
            OrgCode = ulo.OrgCode;
            OrgName = ulo.OrgName;
            AccountCode = ulo.AccountCode;
            BocCode = ulo.BocCode;
            BocName = ulo.BocName;
            Amount = ulo.Amount;
            ProgramProjectCode = ulo.ProgramProjectCode;
            ProgramProjectName = ulo.ProgramProjectName;
            ProgramAreaCode = ulo.ProgramAreaCode;
            ProgramAreaName = ulo.ProgramAreaName;
            NpmCode = ulo.NpmCode;
            NpmName = ulo.NpmName;
            TreasuryAccountCode = ulo.TreasuryAccountCode;
            TreasuryAccountName = ulo.TreasuryAccountName;
            BudgetAccountCode = ulo.BudgetAccountCode;
            BudgetAccountName = ulo.BudgetAccountName;
        }
    }
}