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
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Reprogramming : Transfer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        public Reprogramming( )
        {
            Source = Source.Transfers;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Reprogramming( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) ?? string.Empty );
            Quarter = Record[ "Quarter" ].ToString( );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = Record[ "ControlNumber" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Subline = Record[ "Subline" ].ToString( );
            Purpose = Record[ "Purpose" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Reprogramming( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            BudgetLevel = Record[ "BudgetLevel" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            FromTo = Record[ "FromTo" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = Record[ "ResourceType" ].ToString( );
            ProcessedDate = DateOnly.Parse( Record[ "ProcessedDate" ].ToString( ) ?? string.Empty );
            Quarter = Record[ "Quarter" ].ToString( );
            ReprogrammingNumber = Record[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = Record[ "ControlNumber" ].ToString( );
            Line = Record[ "Line" ].ToString( );
            Subline = Record[ "Subline" ].ToString( );
            Purpose = Record[ "Purpose" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Reprogramming( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ReprogrammingId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            Efy = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            BudgetLevel = dataRow[ "BudgetLevel" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            FromTo = dataRow[ "FromTo" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            ResourceType = dataRow[ "ResourceType" ].ToString( );
            ProcessedDate =
                DateOnly.Parse( dataRow[ "ProcessedDate" ].ToString( ) ?? string.Empty );

            Quarter = dataRow[ "Quarter" ].ToString( );
            ReprogrammingNumber = dataRow[ "ReprogrammingNumber" ].ToString( );
            ControlNumber = dataRow[ "ControlNumber" ].ToString( );
            Line = dataRow[ "Line" ].ToString( );
            Subline = dataRow[ "Subline" ].ToString( );
            Purpose = dataRow[ "Purpose" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
        }

        /// <summary> </summary>
        /// <param name="reprogramming"> </param>
        public Reprogramming( Reprogramming reprogramming )
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