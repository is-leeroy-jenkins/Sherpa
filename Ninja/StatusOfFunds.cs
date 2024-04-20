// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StatusOfFunds.cs" company="Terry D. Eppler">
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
//   StatusOfFunds.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.PRC" />
    /// <seealso cref="T:BudgetExecution.IStatusOfFunds" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class StatusOfFunds : PRC 
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public virtual double Amount { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the budgeted.
        /// </summary>
        /// <value>
        /// The budgeted.
        /// </value>
        public virtual double Budgeted { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the posted.
        /// </summary>
        /// <value>
        /// The posted.
        /// </value>
        public virtual double Posted { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the open commitments.
        /// </summary>
        /// <value>
        /// The open commitments.
        /// </value>
        public virtual double OpenCommitments { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the unliquidated obligations.
        /// </summary>
        /// <value>
        /// The unliquidated obligations.
        /// </value>
        public virtual double UnliquidatedObligations { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the expenditures.
        /// </summary>
        /// <value>
        /// The expenditures.
        /// </value>
        public virtual double Expenditures { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the obligations.
        /// </summary>
        /// <value>
        /// The obligations.
        /// </value>
        public virtual double Obligations { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the used.
        /// </summary>
        /// <value>
        /// The used.
        /// </value>
        public virtual double Used { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public virtual double Available { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds" /> class.
        /// </summary>
        public StatusOfFunds( )
        {
            Source = Source.StatusOfFunds;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public StatusOfFunds( IQuery query )
            : base( query )
        {
            Source = query.Source;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) ?? "0" );
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0.0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0.0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0.0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0.0" );

            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0.0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0.0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0.0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0.0" );
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
        /// <see cref="T:BudgetExecution.StatusOfFunds" /> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public StatusOfFunds( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Source = dataBuilder.Source;
            Record = dataBuilder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) ?? "0" );
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0.0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0.0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0.0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0.0" );

            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0.0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0.0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0.0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0.0" );
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
        /// <see cref="T:BudgetExecution.StatusOfFunds" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public StatusOfFunds( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.StatusOfFunds;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "StatusOfFundsId" ].ToString( ) ?? "0" );
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
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0.0" );
            Budgeted = double.Parse( dataRow[ "Budgeted" ].ToString( ) ?? "0.0" );
            Posted = double.Parse( dataRow[ "Posted" ].ToString( ) ?? "0.0" );
            OpenCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0.0" );
            UnliquidatedObligations =
                double.Parse( dataRow[ "UnliquidatedObligations" ].ToString( ) ?? "0.0" );

            Obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0.0" );
            Expenditures = double.Parse( dataRow[ "Expenditures" ].ToString( ) ?? "0" );
            Used = double.Parse( dataRow[ "Used" ].ToString( ) ?? "0.0" );
            Available = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0.0" );
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds" /> class.
        /// </summary>
        /// <param name="map">The map.</param>
        public StatusOfFunds( IDictionary<string, object> map )
            : base( map )
        {
            Record = new DataBuilder( Source, map )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) ?? "0" );
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
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0.0" );
            Budgeted = double.Parse( Record[ "Budgeted" ].ToString( ) ?? "0.0" );
            Posted = double.Parse( Record[ "Posted" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0.0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0.0" );

            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0.0" );
            Expenditures = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0.0" );
            Used = double.Parse( Record[ "Used" ].ToString( ) ?? "0.0" );
            Available = double.Parse( Record[ "Available" ].ToString( ) ?? "0.0" );
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
        /// <see cref="T:BudgetExecution.StatusOfFunds" /> class.
        /// </summary>
        /// <param name="status">The status.</param>
        public StatusOfFunds( StatusOfFunds status )
        {
            ID = status.ID;
            BudgetLevel = status.BudgetLevel;
            BFY = status.BFY;
            EFY = status.EFY;
            FundCode = status.FundCode;
            FundName = status.FundName;
            RpioCode = status.RpioCode;
            RpioName = status.RpioName;
            AhCode = status.AhCode;
            AhName = status.AhName;
            OrgCode = status.OrgCode;
            OrgName = status.OrgName;
            AccountCode = status.AccountCode;
            BocCode = status.BocCode;
            BocName = status.BocName;
            Amount = status.Amount;
            Budgeted = status.Budgeted;
            Posted = status.Posted;
            OpenCommitments = status.OpenCommitments;
            UnliquidatedObligations = status.UnliquidatedObligations;
            Obligations = status.Obligations;
            Expenditures = status.Expenditures;
            Used = status.Used;
            Available = status.Available;
            ProgramProjectCode = status.ProgramProjectCode;
            ProgramProjectName = status.ProgramProjectName;
            ProgramAreaCode = status.ProgramAreaCode;
            ProgramAreaName = status.ProgramAreaName;
            NpmCode = status.NpmCode;
            NpmName = status.NpmName;
            TreasuryAccountCode = status.TreasuryAccountCode;
            TreasuryAccountName = status.TreasuryAccountName;
            BudgetAccountCode = status.BudgetAccountCode;
            BudgetAccountName = status.BudgetAccountName;
        }
    }
}