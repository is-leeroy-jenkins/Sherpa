// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Actual.cs" company="Terry D. Eppler">
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
//   Actual.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.PRC"/>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class Actual : PRC
    {
        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        public virtual string AppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the appropriation. </summary>
        /// <value> The name of the appropriation. </value>
        public virtual string AppropriationName { get; set; }

        /// <summary> Gets or sets the sub appropriation code. </summary>
        /// <value> The sub appropriation code. </value>
        public virtual string SubAppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the sub appropriation. </summary>
        /// <value> The name of the sub appropriation. </value>
        public virtual string SubAppropriationName { get; set; }

        /// <summary> Gets or sets the commitments. </summary>
        /// <value> The commitments. </value>
        public virtual double Commitments { get; set; }

        /// <summary> Gets or sets the obligations. </summary>
        /// <value> The obligations. </value>
        public virtual double Obligations { get; set; }

        /// <summary> Gets or sets the balance. </summary>
        /// <value> The balance. </value>
        public virtual double Balance { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Actual"/>
        /// class.
        /// </summary>
        public Actual( )
        {
            Source = Source.Actuals;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Actual"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Actual( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ActualsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            SubAppropriationName = Record[ "SubAppropriationName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ActivityCode = Record[ "ActivityCode" ].ToString( );
            ActivityName = Record[ "ActivityName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            Commitments = double.Parse( Record[ "Commitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ "Balance" ].ToString( ) ?? "0" );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
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
        /// <see cref="Actual"/>
        /// class.
        /// </summary>
        /// <param name="builder"> </param>
        public Actual( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ActualsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            SubAppropriationCode = Record[ "SubAppropriationCode" ].ToString( );
            SubAppropriationName = Record[ "SubAppropriationName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ActivityCode = Record[ "ActivityCode" ].ToString( );
            ActivityName = Record[ "ActivityName" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            Commitments = double.Parse( Record[ "Commitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            Balance = double.Parse( Record[ "Balance" ].ToString( ) ?? "0" );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
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
        /// <see cref="Actual"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Actual( DataRow dataRow )
            : this( )
        {
            Source = Source.Actuals;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ActualsId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            AppropriationCode = dataRow[ "AppropriationCode" ].ToString( );
            AppropriationName = dataRow[ "AppropriationName" ].ToString( );
            SubAppropriationCode = dataRow[ "SubAppropriationCode" ].ToString( );
            SubAppropriationName = dataRow[ "SubAppropriationName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            ActivityCode = dataRow[ "ActivityCode" ].ToString( );
            ActivityName = dataRow[ "ActivityName" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            Commitments = double.Parse( Record[ "Commitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0" );
            Balance = double.Parse( dataRow[ "Balance" ].ToString( ) ?? "0" );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Actual"/>
        /// class.
        /// </summary>
        /// <param name="actual"> The actual. </param>
        public Actual( Actual actual )
        {
            Source = Source.Actuals;
            ID = actual.ID;
            BFY = actual.BFY;
            EFY = actual.EFY;
            FundCode = actual.FundCode;
            FundName = actual.FundName;
            RpioCode = actual.RpioCode;
            RpioName = actual.RpioName;
            AhCode = actual.AhCode;
            AhName = actual.AhName;
            AppropriationCode = actual.AppropriationCode;
            AppropriationName = actual.AppropriationName;
            SubAppropriationCode = actual.SubAppropriationCode;
            SubAppropriationName = actual.SubAppropriationName;
            OrgCode = actual.OrgCode;
            OrgName = actual.OrgName;
            AccountCode = actual.AccountCode;
            BocCode = actual.BocCode;
            BocName = actual.BocName;
            ActivityCode = actual.ActivityCode;
            ActivityName = actual.ActivityName;
            ProgramProjectCode = actual.ProgramProjectCode;
            ProgramProjectName = actual.ProgramProjectName;
            Commitments = actual.Commitments;
            Obligations = actual.Obligations;
            Balance = actual.Balance;
            ProgramAreaCode = actual.ProgramAreaCode;
            ProgramAreaName = actual.ProgramAreaName;
            GoalCode = actual.GoalCode;
            GoalName = actual.GoalName;
            ObjectiveCode = actual.ObjectiveCode;
            ObjectiveName = actual.ObjectiveName;
            TreasuryAccountCode = actual.TreasuryAccountCode;
            TreasuryAccountName = actual.TreasuryAccountName;
            BudgetAccountCode = actual.BudgetAccountCode;
            BudgetAccountName = actual.BudgetAccountName;
        }
    }
}