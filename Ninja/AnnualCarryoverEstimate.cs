﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AnnualCarryoverEstimate.cs" company="Terry D. Eppler">
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
//   AnnualCarryoverEstimate.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:Sherpa.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class AnnualCarryoverEstimate : BudgetUnit
    {
        /// <summary>
        /// The rpio code
        /// </summary>
        private protected string _rpioCode;

        /// <summary>
        /// The rpio name
        /// </summary>
        private protected string _rpioName;

        /// <summary>
        /// The amount
        /// </summary>
        private protected double _amount;

        /// <summary>
        /// The open commitments
        /// </summary>
        private protected double _openCommitments;

        /// <summary>
        /// The obligations
        /// </summary>
        private protected double _obligations;

        /// <summary>
        /// The available
        /// </summary>
        private protected double _available;

        /// <summary>
        /// The estimate
        /// </summary>
        private protected double _estimate;
        
        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public string RpioCode
        {
            get
            {
                return _rpioCode;
            }
            private protected set
            {
                _rpioCode = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public string RpioName
        {
            get
            {
                return _rpioName;
            }
            private protected set
            {
                _rpioName = value;
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

        /// <summary>
        /// Gets or sets the open commitments.
        /// </summary>
        /// <value>
        /// The open commitments.
        /// </value>
        public double OpenCommitments
        {
            get
            {
                return _openCommitments;
            }
            private protected set
            {
                _openCommitments = value;
            }
        }

        /// <summary>
        /// Gets or sets the obligations.
        /// </summary>
        /// <value>
        /// The obligations.
        /// </value>
        public double Obligations
        {
            get
            {
                return _obligations;
            }
            private protected set
            {
                _obligations = value;
            }
        }

        /// <summary>
        /// Gets or sets the available.
        /// </summary>
        /// <value>
        /// The available.
        /// </value>
        public double Available
        {
            get
            {
                return _available;
            }
            private protected set
            {
                _available = value;
            }
        }

        /// <summary>
        /// Gets or sets the estimate.
        /// </summary>
        /// <value>
        /// The estimate.
        /// </value>
        public double Estimate
        {
            get
            {
                return _estimate;
            }
            private protected set
            {
                _estimate = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.AnnualCarryoverEstimate" />
        /// class.
        /// </summary>
        public AnnualCarryoverEstimate( )
        {
            _source = Source.AnnualCarryoverEstimates;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.AnnualCarryoverEstimates" />
        /// class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AnnualCarryoverEstimate( IQuery query )
            : base( query )
        {
            _record = new DataBuilder( query ).Record;
            _map = _record.ToDictionary( );
            _id = int.Parse( _record[ "AnnualCarryoverEstimatesId" ].ToString( ) ?? "0" );
            _bfy = _record[ "BFY" ].ToString( );
            _efy = _record[ "EFY" ].ToString( );
            _fundCode = _record[ "FundCode" ].ToString( );
            _fundName = _record[ "FundName" ].ToString( );
            _rpioCode = _record[ "RpioCode" ].ToString( );
            _rpioName = _record[ "RpioName" ].ToString( );
            _amount = double.Parse( _record[ "Amount" ].ToString( ) ?? "0" );
            _openCommitments = double.Parse( _record[ "OpenCommitments" ].ToString( ) ?? "0" );
            _obligations = double.Parse( _record[ "Obligations" ].ToString( ) ?? "0" );
            _available = double.Parse( _record[ "Available" ].ToString( ) ?? "0" );
            _estimate = double.Parse( _record[ "Estimate" ].ToString( ) ?? "0" );
            _treasuryAccountCode = _record[ "TreasuryAccountCode" ].ToString( );
            _treasuryAccountName = _record[ "TreasuryAccountName" ].ToString( );
            _budgetAccountCode = _record[ "BudgetAccountCode" ].ToString( );
            _budgetAccountName = _record[ "BudgetAccountName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.AnnualCarryoverEstimates" />
        /// class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public AnnualCarryoverEstimate( IDataModel builder )
            : base( builder )
        {
            _record = builder.Record;
            _map = _record.ToDictionary( );
            _id = int.Parse( _record[ "AnnualCarryoverEstimatesId" ].ToString( ) ?? "0" );
            _bfy = _record[ "BFY" ].ToString( );
            _efy = _record[ "EFY" ].ToString( );
            _fundCode = _record[ "FundCode" ].ToString( );
            _fundName = _record[ "FundName" ].ToString( );
            _rpioCode = _record[ "RpioCode" ].ToString( );
            _rpioName = _record[ "RpioName" ].ToString( );
            _amount = double.Parse( _record[ "Amount" ].ToString( ) ?? "0" );
            _openCommitments = double.Parse( _record[ "OpenCommitments" ].ToString( ) ?? "0" );
            _obligations = double.Parse( _record[ "Obligations" ].ToString( ) ?? "0" );
            _available = double.Parse( _record[ "Available" ].ToString( ) ?? "0" );
            _estimate = double.Parse( _record[ "Estimate" ].ToString( ) ?? "0" );
            _treasuryAccountCode = _record[ "TreasuryAccountCode" ].ToString( );
            _treasuryAccountName = _record[ "TreasuryAccountName" ].ToString( );
            _budgetAccountCode = _record[ "BudgetAccountCode" ].ToString( );
            _budgetAccountName = _record[ "BudgetAccountName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.AnnualCarryoverEstimates" />
        /// class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public AnnualCarryoverEstimate( DataRow dataRow )
            : base( dataRow )
        {
            _record = dataRow;
            _map = dataRow.ToDictionary( );
            _id = int.Parse( _record[ "AnnualCarryoverEstimatesId" ].ToString( ) ?? "0" );
            _bfy = dataRow[ "BFY" ].ToString( );
            _efy = dataRow[ "EFY" ].ToString( );
            _fundCode = dataRow[ "FundCode" ].ToString( );
            _fundName = dataRow[ "FundName" ].ToString( );
            _rpioCode = dataRow[ "RpioCode" ].ToString( );
            _rpioName = dataRow[ "RpioName" ].ToString( );
            _amount = double.Parse( dataRow[ "Amount" ].ToString( ) ?? "0" );
            _openCommitments = double.Parse( dataRow[ "OpenCommitments" ].ToString( ) ?? "0" );
            _obligations = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? "0" );
            _available = double.Parse( dataRow[ "Available" ].ToString( ) ?? "0" );
            _estimate = double.Parse( dataRow[ "Estimate" ].ToString( ) ?? "0" );
            _treasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            _treasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            _budgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            _budgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.AnnualCarryoverEstimates" />
        /// class.
        /// </summary>
        /// <param name="carryover">The carryover.</param>
        public AnnualCarryoverEstimate( AnnualCarryoverEstimate carryover )
            : base( )
        {
            _id = carryover.ID;
            _bfy = carryover.BFY;
            _efy = carryover.EFY;
            _fundCode = carryover.FundCode;
            _fundName = carryover.FundName;
            _rpioCode = carryover.RpioCode;
            _rpioName = carryover.RpioName;
            _amount = carryover.Amount;
            _openCommitments = carryover.OpenCommitments;
            _obligations = carryover.Obligations;
            _available = carryover.Available;
            _estimate = carryover.Estimate;
            _treasuryAccountCode = carryover.TreasuryAccountCode;
            _treasuryAccountName = carryover.TreasuryAccountName;
            _budgetAccountCode = carryover.BudgetAccountCode;
            _budgetAccountName = carryover.BudgetAccountName;
        }
    }
}