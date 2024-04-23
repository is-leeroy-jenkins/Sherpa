//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                Defacto.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Defacto.cs" company="Terry D. Eppler">
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
//    Defacto.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class Defacto : StatusOfFunds
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Defacto"/>
        /// class.
        /// </summary>
        public Defacto( )
        {
            Source = Source.Defactos;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Defacto"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Defacto( IQuery query )
            : base( query )
        {
            Source = Source.Defactos;
            Record = new DataBuilder( query ).Record;
            Map = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
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

            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? string.Empty );
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
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Defacto"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Defacto( IDataModel builder )
            : base( builder )
        {
            Source = Source.Defactos;
            Record = builder.Record;
            Map = Record.ToDictionary( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
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

            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? string.Empty );
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
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Defacto"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Defacto( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.Defactos;
            Record = dataRow;
            Map = dataRow.ToDictionary( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString( );
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
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? string.Empty );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? string.Empty );

            UnliquidatedObligations = double.Parse( dataRow[ "ULO" ].ToString( ) ?? string.Empty );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString( ) ?? string.Empty );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) ?? string.Empty );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? string.Empty );
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

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Defacto"/>
        /// class.
        /// </summary>
        /// <param name="defacto"> The defacto. </param>
        public Defacto( Defacto defacto )
        {
            ID = defacto.ID;
            BudgetLevel = defacto.BudgetLevel;
            BFY = defacto.BFY;
            EFY = defacto.EFY;
            FundCode = defacto.FundCode;
            FundName = defacto.FundName;
            RpioCode = defacto.RpioCode;
            RpioName = defacto.RpioName;
            AhCode = defacto.AhCode;
            AhName = defacto.AhName;
            OrgCode = defacto.OrgCode;
            OrgName = defacto.OrgName;
            AccountCode = defacto.AccountCode;
            BocCode = defacto.BocCode;
            BocName = defacto.BocName;
            Available = defacto.Available;
            ProgramProjectCode = defacto.ProgramProjectCode;
            ProgramProjectName = defacto.ProgramProjectName;
            ProgramAreaCode = defacto.ProgramAreaCode;
            ProgramAreaName = defacto.ProgramAreaName;
            NpmCode = defacto.NpmCode;
            NpmName = defacto.NpmName;
            TreasuryAccountCode = defacto.TreasuryAccountCode;
            TreasuryAccountName = defacto.TreasuryAccountName;
            BudgetAccountCode = defacto.BudgetAccountCode;
            BudgetAccountName = defacto.BudgetAccountName;
        }
    }
}