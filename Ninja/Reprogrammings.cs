// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Reprogramming.cs" company="Terry D. Eppler">
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
//   Reprogramming.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.Transfer" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class Reprogrammings : Transfer
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Reprogrammings" /> class.
        /// </summary>
        public Reprogrammings( )
        {
            Source = Source.Transfers;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Reprogrammings" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Reprogrammings( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            FromTo = Record[ nameof( FromTo ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            ResourceType = Record[ nameof( ResourceType ) ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ nameof( ProcessedDate ) ].ToString( ) ?? string.Empty );
            Quarter = Record[ nameof( Quarter ) ].ToString( );
            ReprogrammingNumber = Record[ nameof( ReprogrammingNumber ) ].ToString( );
            ControlNumber = Record[ nameof( ControlNumber ) ].ToString( );
            Line = Record[ nameof( Line ) ].ToString( );
            Subline = Record[ nameof( Subline ) ].ToString( );
            Purpose = Record[ nameof( Purpose ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Reprogrammings" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Reprogrammings( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            FromTo = Record[ nameof( FromTo ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            ResourceType = Record[ nameof( ResourceType ) ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ nameof( ProcessedDate ) ].ToString( ) ?? string.Empty );
            Quarter = Record[ nameof( Quarter ) ].ToString( );
            ReprogrammingNumber = Record[ nameof( ReprogrammingNumber ) ].ToString( );
            ControlNumber = Record[ nameof( ControlNumber ) ].ToString( );
            Line = Record[ nameof( Line ) ].ToString( );
            Subline = Record[ nameof( Subline ) ].ToString( );
            Purpose = Record[ nameof( Purpose ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Reprogrammings"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Reprogrammings( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            Efy = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            BudgetLevel = dataRow[ nameof( BudgetLevel ) ].ToString( );
            RpioCode = dataRow[ nameof( RpioCode ) ].ToString( );
            RpioName = dataRow[ nameof( RpioName ) ].ToString( );
            AhCode = dataRow[ nameof( AhCode ) ].ToString( );
            AhName = dataRow[ nameof( AhName ) ].ToString( );
            OrgCode = dataRow[ nameof( OrgCode ) ].ToString( );
            OrgName = dataRow[ nameof( OrgName ) ].ToString( );
            AccountCode = dataRow[ nameof( AccountCode ) ].ToString( );
            ProgramProjectCode = dataRow[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = dataRow[ nameof( ProgramProjectName ) ].ToString( );
            FromTo = dataRow[ nameof( FromTo ) ].ToString( );
            Amount = double.Parse( dataRow[ nameof( Amount ) ].ToString( ) ?? "0" );
            ResourceType = dataRow[ nameof( ResourceType ) ].ToString( );
            ProcessedDate =
                DateOnly.Parse( dataRow[ nameof( ProcessedDate ) ].ToString( ) ?? string.Empty );

            Quarter = dataRow[ nameof( Quarter ) ].ToString( );
            ReprogrammingNumber = dataRow[ nameof( ReprogrammingNumber ) ].ToString( );
            ControlNumber = dataRow[ nameof( ControlNumber ) ].ToString( );
            Line = dataRow[ nameof( Line ) ].ToString( );
            Subline = dataRow[ nameof( Subline ) ].ToString( );
            Purpose = dataRow[ nameof( Purpose ) ].ToString( );
            BocCode = dataRow[ nameof( BocCode ) ].ToString( );
            BocName = dataRow[ nameof( BocName ) ].ToString( );
            ProgramAreaCode = dataRow[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = dataRow[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = dataRow[ nameof( NpmCode ) ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Reprogrammings" /> class.
        /// </summary>
        /// <param name="reprogramming">The reprogramming.</param>
        public Reprogrammings( Reprogrammings reprogramming )
        {
            ID = reprogramming.ID;
            BFY = reprogramming.BFY;
            Efy = reprogramming.Efy;
            FundCode = reprogramming.FundCode;
            FundName = reprogramming.FundName;
            BudgetLevel = reprogramming.BudgetLevel;
            RpioCode = reprogramming.RpioCode;
            RpioName = reprogramming.RpioName;
            AhCode = reprogramming.AhCode;
            AhName = reprogramming.AhName;
            OrgCode = reprogramming.OrgCode;
            OrgName = reprogramming.OrgName;
            AccountCode = reprogramming.AccountCode;
            ProgramProjectCode = reprogramming.ProgramAreaCode;
            ProgramProjectName = reprogramming.ProgramProjectName;
            ProgramAreaCode = reprogramming.ProgramAreaCode;
            ProgramAreaName = reprogramming.ProgramAreaName;
            FromTo = reprogramming.FromTo;
            Amount = reprogramming.Amount;
            ResourceType = reprogramming.ResourceType;
            ProcessedDate = reprogramming.ProcessedDate;
            Quarter = reprogramming.Quarter;
            ReprogrammingNumber = reprogramming.ReprogrammingNumber;
            ControlNumber = reprogramming.ControlNumber;
            Line = reprogramming.Line;
            Subline = reprogramming.Subline;
            Purpose = reprogramming.Purpose;
            BocCode = reprogramming.BocCode;
            BocName = reprogramming.BocName;
            NpmCode = reprogramming.NpmCode;
        }
    }
}