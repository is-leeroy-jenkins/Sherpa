﻿//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                ReconciliationLines.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ReconciliationLines.cs" company="Terry D. Eppler">
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
//    ReconciliationLines.cs
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class ReconciliationLine : DataUnit
    {
        /// <summary>
        /// The number
        /// </summary>
        private protected string _number;

        /// <summary>
        /// Gets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public string Number
        {
            get
            {
                return _number;
            }
            private protected set
            {
                _number = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ReconciliationLines" />
        /// class.
        /// </summary>
        public ReconciliationLine( )
        {
            _source = Source.ReconciliationLines;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ReconciliationLines"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ReconciliationLine( IQuery query )
            : base( query )
        {
            _record = new DataBuilder( query ).Record;
            _map = _record.ToDictionary( );
            _id = int.Parse( _record[ "ReconciliationLinesId" ]?.ToString( ) ?? "0" );
            _number = _record[ "Number" ]?.ToString( );
            _name = _record[ "Name" ]?.ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ReconciliationLines"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The data builder. </param>
        public ReconciliationLine( IDataModel builder )
            : base( builder )
        {
            _record = builder.Record;
            _map = _record.ToDictionary( );
            _id = int.Parse( _record[ "ReconciliationLinesId" ]?.ToString( ) ?? "0" );
            _number = _record[ "Number" ]?.ToString( );
            _name = _record[ "Name" ]?.ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ReconciliationLines"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public ReconciliationLine( DataRow dataRow )
            : base( dataRow )
        {
            _record = dataRow;
            _map = dataRow.ToDictionary( );
            _id = int.Parse( dataRow[ "ReconciliationLinesId" ]?.ToString( ) ?? "0" );
            _number = dataRow[ "Number" ]?.ToString( );
            _name = dataRow[ "Name" ]?.ToString( );
        }
    }
}