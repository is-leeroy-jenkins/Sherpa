//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                ApportionmentData.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ApportionmentData.cs" company="Terry D. Eppler">
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
//    ApportionmentData.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class ApportionmentData : BudgetUnit
    {
        /// <summary>
        /// The apportionment account code
        /// </summary>
        private protected string _apportionmentAccountCode;

        /// <summary>
        /// The apportionment account name
        /// </summary>
        private protected string _apportionmentAccountName;

        /// <summary>
        /// The availability type
        /// </summary>
        private protected string _availabilityType;

        /// <summary>
        /// The approval date
        /// </summary>
        private protected DateOnly _approvalDate;

        /// <summary>
        /// The line number
        /// </summary>
        private protected string _lineNumber;

        /// <summary>
        /// The line name
        /// </summary>
        private protected string _lineName;

        /// <summary>
        /// The amount
        /// </summary>
        private protected double _amount;

        /// <summary>
        /// Gets or sets the apportionment account code.
        /// </summary>
        /// <value>
        /// The apportionment account code.
        /// </value>
        public string ApportionmentAccountCode
        {
            get
            {
                return _apportionmentAccountCode;
            }

            private protected set
            {
                _apportionmentAccountCode = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the apportionment account.
        /// </summary>
        /// <value>
        /// The name of the apportionment account.
        /// </value>
        public string ApportionmentAccountName
        {
            get
            {
                return _apportionmentAccountName;
            }

            private protected set
            {
                _apportionmentAccountName = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the availability.
        /// </summary>
        /// <value>
        /// The type of the availability.
        /// </value>
        public string AvailabilityType
        {
            get
            {
                return _availabilityType;
            }

            private protected set
            {
                _availabilityType = value;
            }
        }

        /// <summary>
        /// Gets or sets the approval date.
        /// </summary>
        /// <value>
        /// The approval date.
        /// </value>
        public DateOnly ApprovalDate
        {
            get
            {
                return _approvalDate;
            }

            private protected set
            {
                _approvalDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber
        {
            get
            {
                return _lineNumber;
            }

            private protected set
            {
                _lineNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the line.
        /// </summary>
        /// <value>
        /// The name of the line.
        /// </value>
        public string LineName
        {
            get
            {
                return _lineName;
            }

            private protected set
            {
                _lineName = value;
            }
        }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public double Amount
        {
            get
            {
                return _amount;
            }

            private protected set
            {
                _amount = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ApportionmentData" /> class.
        /// </summary>
        public ApportionmentData( ) 
            : base( )
        {
            Source = Source.ApportionmentData;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ApportionmentData" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ApportionmentData( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Map = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
            ApportionmentAccountName = Record[ "ApportionmentAccountName" ].ToString( );
            AvailabilityType = Record[ "AvailabilityType" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ApportionmentData" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ApportionmentData( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Map = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            ApportionmentAccountCode = Record[ "ApportionmentAccountCode" ].ToString( );
            ApportionmentAccountName = Record[ "ApportionmentAccountName" ].ToString( );
            AvailabilityType = Record[ "AvailabilityType" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineName = Record[ "LineName" ].ToString( );
            Amount = double.Parse( Record[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ApportionmentData" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ApportionmentData( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Map = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            ApportionmentAccountCode = dataRow[ "ApportionmentAccountCode" ].ToString( );
            ApportionmentAccountName = dataRow[ "ApportionmentAccountName" ].ToString( );
            AvailabilityType = dataRow[ "AvailabilityType" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            LineName = dataRow[ "LineName" ].ToString( );
            Amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ApportionmentData" /> class.
        /// </summary>
        /// <param name="omb">The omb.</param>
        public ApportionmentData( ApportionmentData omb )
        {
            ID = omb.ID;
            FiscalYear = omb.FiscalYear;
            BFY = omb.BFY;
            EFY = omb.EFY;
            BudgetAccountCode = omb.BudgetAccountCode;
            BudgetAccountName = omb.BudgetAccountName;
            TreasuryAccountCode = omb.TreasuryAccountCode;
            TreasuryAccountName = omb.TreasuryAccountName;
            ApportionmentAccountCode = omb.ApportionmentAccountCode;
            ApportionmentAccountName = omb.ApportionmentAccountName;
            AvailabilityType = omb.AvailabilityType;
            LineNumber = omb.LineNumber;
            LineName = omb.LineName;
            Amount = omb.Amount;
        }
    }
}