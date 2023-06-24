// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="MonthlyActual.cs" company="Terry D. Eppler">
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
//   MonthlyActual.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.Actual"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class MonthlyActual : Actual 
    {
        /// <summary> Gets or sets the balance. </summary>
        /// <value> The balance. </value>
        public double NetOutlays { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        public double GrossOutlays { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MonthlyActual"/>
        /// class.
        /// </summary>
        public MonthlyActual( )
        {
            Source = Source.MonthlyActuals;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MonthlyActual"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public MonthlyActual( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
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
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            GrossOutlays = double.Parse( Record[ "GrossOutlays" ].ToString( ) ?? "0" );
            NetOutlays = double.Parse( Record[ "NetOutlays" ].ToString( ) ?? "0" );
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
        /// <see cref="MonthlyActual"/>
        /// class.
        /// </summary>
        /// <param name="builder"> </param>
        public MonthlyActual( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
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
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            GrossOutlays = double.Parse( Record[ "GrossOutlays" ].ToString( ) ?? "0" );
            NetOutlays = double.Parse( Record[ "NetOutlays" ].ToString( ) ?? "0" );
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
        /// <see cref="MonthlyActual"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public MonthlyActual( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.MonthlyActuals;
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
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            GrossOutlays = double.Parse( Record[ "GrossOutlays" ].ToString( ) ?? "0" );
            NetOutlays = double.Parse( Record[ "NetOutlays" ].ToString( ) ?? "0" );
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
        /// <see cref="MonthlyActual"/>
        /// class.
        /// </summary>
        /// <param name="actual"> The actual. </param>
        public MonthlyActual( MonthlyActual actual )
        {
            Source = Source.MonthlyActuals;
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
            Obligations = actual.Obligations;
            GrossOutlays = actual.GrossOutlays;
            NetOutlays = actual.NetOutlays;
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