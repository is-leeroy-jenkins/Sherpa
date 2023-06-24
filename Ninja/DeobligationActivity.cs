// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DeobligationActivity.cs" company="Terry D. Eppler">
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
//   DeobligationActivity.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class DeobligationActivity : Deobligation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DeobligationActivity"/>
        /// class.
        /// </summary>
        public DeobligationActivity( )
        {
            Source = Source.DeobligationActivity;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DeobligationActivity"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public DeobligationActivity( IQuery query )
            : base( query )
        {
            Source = Source.DeobligationActivity;
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
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
        /// <see cref="DeobligationActivity"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public DeobligationActivity( IDataModel builder )
            : base( builder.Query )
        {
            Source = Source.DeobligationActivity;
            Record = builder.Record;
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
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
        /// <see cref="DeobligationActivity"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public DeobligationActivity( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.DeobligationActivity;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
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
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0" );
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
    }
}