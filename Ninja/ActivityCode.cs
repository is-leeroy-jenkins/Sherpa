﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ActivityCode.cs" company="Terry D. Eppler">
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
//   ActivityCode.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Sherpa.DataUnit"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    public class ActivityCode : DataUnit
    {
        /// <summary>
        ///
        /// </summary>
        private string _description;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        {
            get
            {
                return _description;
            }
            private set
            {
                _description = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ActivityCode" />
        /// class.
        /// </summary>
        public ActivityCode( )
            : base( )
        {
            _source = Source.ActivityCodes;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ActivityCode" />
        /// class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ActivityCode( IQuery query )
            : base( query )
        {
            _record = new DataBuilder( query )?.Record;
            _id = int.Parse( _record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            _name = _record[ "ActivityName" ].ToString( );
            _code = _record[ "ActivityCode" ].ToString( );
            _map = _record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ActivityCode" />
        /// class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ActivityCode( IDataModel builder )
            : base( builder )
        {
            _record = builder.Record;
            _id = int.Parse( _record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            _name = _record[ "ActivityName" ].ToString( );
            _code = _record[ "ActivityCode" ].ToString( );
            _map = _record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ActivityCode" />
        /// class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ActivityCode( DataRow dataRow )
            : base( dataRow )
        {
            _record = dataRow;
            _id = int.Parse( _record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            _name = dataRow[ "ActivityName" ].ToString( );
            _code = dataRow[ "ActivityCode" ].ToString( );
            _map = dataRow?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ActivityCode" />
        /// class.
        /// </summary>
        /// <param name="code">The code.</param>
        public ActivityCode( string code )
            : this( )
        {
            _record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            _id = int.Parse( _record[ "ActivityCodesId" ].ToString( ) ?? "0" );
            _name = _record[ "ActivityName" ].ToString( );
            _code = _record[ "ActivityCode" ].ToString( );
            _map = _record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ActivityCode" />
        /// class.
        /// </summary>
        /// <param name="activityCode">The activity code.</param>
        public ActivityCode( ActivityCode activityCode )
            : this( )
        {
            _id = activityCode.ID;
            _code = activityCode.Code;
            _name = activityCode.Name;
        }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        private IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ "ActivityCode" ] = code };
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}