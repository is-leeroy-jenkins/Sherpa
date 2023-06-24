// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StatusOfJobsActFunds.cs" company="Terry D. Eppler">
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
//   StatusOfJobsActFunds.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class StatusOfJobsActFunds : StatusOfFunds
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfJobsActFunds"/>
        /// class.
        /// </summary>
        public StatusOfJobsActFunds( )
        {
            Source = Source.StatusOfJobsActFunds;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfJobsActFunds"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StatusOfJobsActFunds( IQuery query )
            : base( query )
        {
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) );
            Used = double.Parse( Record[ "Used" ].ToString( ) );
            Available = double.Parse( Record[ "Available" ].ToString( ) );
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

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfJobsActFunds"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The builder. </param>
        public StatusOfJobsActFunds( IDataModel dataBuilder )
            : base( dataBuilder )
        {
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) );
            Used = double.Parse( Record[ "Used" ].ToString( ) );
            Available = double.Parse( Record[ "Available" ].ToString( ) );
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

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfJobsActFunds"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StatusOfJobsActFunds( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = Record.ToDictionary( );
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
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString( ) );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) );
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

        public StatusOfJobsActFunds( IDictionary<string, object> map )
            : base( map )
        {
            Record = new DataBuilder( Source, map )?.Record;
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) );
            Used = double.Parse( Record[ "Used" ].ToString( ) );
            Available = double.Parse( Record[ "Available" ].ToString( ) );
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

        public StatusOfJobsActFunds( StatusOfJobsActFunds allocation )
            : this( )
        {
            ID = allocation.ID;
            BudgetLevel = allocation.BudgetLevel;
            BFY = allocation.BFY;
            EFY = allocation.EFY;
            FundCode = allocation.FundCode;
            FundName = allocation.FundName;
            RpioCode = allocation.RpioCode;
            RpioName = allocation.RpioName;
            AhCode = allocation.AhCode;
            AhName = allocation.AhName;
            OrgCode = allocation.OrgCode;
            OrgName = allocation.OrgName;
            AccountCode = allocation.AccountCode;
            BocCode = allocation.BocCode;
            BocName = allocation.BocName;
            Amount = allocation.Amount;
            ProgramProjectCode = allocation.ProgramProjectCode;
            ProgramProjectName = allocation.ProgramProjectName;
            ProgramAreaCode = allocation.ProgramAreaCode;
            ProgramAreaName = allocation.ProgramAreaName;
            NpmCode = allocation.NpmCode;
            NpmName = allocation.NpmName;
            TreasuryAccountCode = allocation.TreasuryAccountCode;
            TreasuryAccountName = allocation.TreasuryAccountName;
            BudgetAccountCode = allocation.BudgetAccountCode;
            BudgetAccountName = allocation.BudgetAccountName;
        }
    }
}