﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="RegionalOffice.cs" company="Terry D. Eppler">
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
//   RegionalOffice.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Sherpa.ResourcePlanningOffices" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class RegionalOffice : ResourcePlanningOffice
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.RegionalOffices" /> class.
        /// </summary>
        public RegionalOffice( )
        {
            _source = Source.RegionalOffices;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegionalOffice"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <inheritdoc />
        public RegionalOffice( IQuery query ) 
            : base( query )
        {
            _record = new DataBuilder( query ).Record;
            _name = _record?[ "Name" ].ToString( );
            _code = _record?[ "Code" ].ToString( );
            _map = _record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.RegionalOffices" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public RegionalOffice( IDataModel builder ) 
            : base( builder )
        {
            _record = builder.Record;
            _name = _record?[ "Name" ].ToString( );
            _code = _record?[ "Code" ].ToString( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="RegionalOffice"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <inheritdoc />
        public RegionalOffice( DataRow dataRow ) 
            : base( dataRow )
        {
            _record = dataRow;
            _name = dataRow[ "Name" ].ToString( );
            _code = dataRow[ "Code" ].ToString( );
            _map = dataRow.ToDictionary( );
        }
    }
}