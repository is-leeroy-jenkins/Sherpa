// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ProgramResultsCode.cs" company="Terry D. Eppler">
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
//   ProgramResultsCode.cs
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
    /// Program Results Codes (PRCs) were established to account for and relate resources to the Agency's
    /// Strategic Plan goals and objectives, national program offices and responsibilities, and
    /// governmental functions. PRCs are created when the annual EPA Budget is submitted to Congress each
    /// February and then formally established in IFMS with the enactment of EPA's appropriation act. PRCs
    /// may be updated at any time.
    /// </summary>
    /// <seealso cref="T:BudgetExecution.IProgramResultsCode" />
    /// <seealso cref="T:BudgetExecution.IProgramResultsCode" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    public class ProgramResultsCodes : StatusOfFunds, IProgramResultsCode
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramResultsCode" />
        /// class.
        /// </summary>
        public ProgramResultsCodes( )
        {
            Source = Source.StatusOfFunds;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramResultsCode" />
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ProgramResultsCodes( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
            NpmName = Record[ nameof( NpmName ) ].ToString( );
            GoalCode = Record[ nameof( GoalCode ) ].ToString( );
            GoalName = Record[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = Record[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = Record[ nameof( ObjectiveName ) ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramResultsCode"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The builder. </param>
        public ProgramResultsCodes( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Record = dataBuilder.Record;
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
            NpmName = Record[ nameof( NpmName ) ].ToString( );
            GoalCode = Record[ nameof( GoalCode ) ].ToString( );
            GoalName = Record[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = Record[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = Record[ nameof( ObjectiveName ) ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramResultsCodes" />
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public ProgramResultsCodes( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( dataRow[ "StatusOfFundsId" ].ToString( ) );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            RpioCode = dataRow[ nameof( RpioCode ) ].ToString( );
            RpioName = dataRow[ nameof( RpioName ) ].ToString( );
            AhCode = dataRow[ nameof( AhCode ) ].ToString( );
            AhName = dataRow[ nameof( AhName ) ].ToString( );
            OrgCode = dataRow[ nameof( OrgCode ) ].ToString( );
            OrgName = dataRow[ nameof( OrgName ) ].ToString( );
            AccountCode = dataRow[ nameof( AccountCode ) ].ToString( );
            BocCode = dataRow[ nameof( BocCode ) ].ToString( );
            BocName = dataRow[ nameof( BocName ) ].ToString( );
            ProgramProjectCode = dataRow[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = dataRow[ nameof( ProgramProjectName ) ].ToString( );
            Amount = double.Parse( dataRow[ nameof( Amount ) ].ToString( ) );
            ProgramAreaCode = dataRow[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = dataRow[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = dataRow[ nameof( NpmCode ) ].ToString( );
            NpmName = dataRow[ nameof( NpmName ) ].ToString( );
            GoalCode = dataRow[ nameof( GoalCode ) ].ToString( );
            GoalName = dataRow[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = dataRow[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = dataRow[ nameof( ObjectiveName ) ].ToString( );
            Data = dataRow.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramResultsCodes" />
        /// class.
        /// </summary>
        /// <param name="dict"> </param>
        public ProgramResultsCodes( IDictionary<string, object> dict )
        {
            Record = new DataBuilder( Source, dict )?.Record;
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
            NpmName = Record[ nameof( NpmName ) ].ToString( );
            GoalCode = Record[ nameof( GoalCode ) ].ToString( );
            GoalName = Record[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = Record[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = Record[ nameof( ObjectiveName ) ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramResultsCodes" /> class.
        /// </summary>
        /// <param name="prc">The PRC.</param>
        public ProgramResultsCodes( ProgramResultsCodes prc )
        {
            ID = prc.ID;
            BFY = prc.BFY;
            EFY = prc.EFY;
            FundCode = prc.FundCode;
            FundName = prc.FundName;
            RpioCode = prc.RpioCode;
            RpioName = prc.RpioName;
            AhCode = prc.AhCode;
            AhName = prc.AhName;
            OrgCode = prc.OrgCode;
            OrgName = prc.OrgName;
            AccountCode = prc.AccountCode;
            BocCode = prc.BocCode;
            BocName = prc.BocName;
            ProgramProjectCode = prc.ProgramProjectCode;
            ProgramProjectName = prc.ProgramProjectName;
            ProgramAreaCode = prc.ProgramAreaCode;
            ProgramAreaName = prc.ProgramAreaName;
            Amount = prc.Amount;
            NpmCode = prc.NpmCode;
            NpmName = prc.NpmName;
            GoalCode = prc.GoalCode;
            GoalName = prc.GoalName;
            ObjectiveCode = prc.ObjectiveCode;
            ObjectiveName = prc.ObjectiveName;
        }
    }
}