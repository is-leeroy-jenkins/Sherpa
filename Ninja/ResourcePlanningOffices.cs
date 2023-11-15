﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ResourcePlanningOffice.cs" company="Terry D. Eppler">
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
//   ResourcePlanningOffice.cs
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
    /// <seealso cref="T:BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class ResourcePlanningOffices : DataUnit
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <inheritdoc />
        public override Source Source { get; set; } = Source.ResourcePlanningOffices;

        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override DataRow Record { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override int ID { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <inheritdoc />
        public override string Code { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        /// <inheritdoc />
        public override string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePlanningOffices"/> class.
        /// </summary>
        public ResourcePlanningOffices( )
        {
            Source = Source.ResourcePlanningOffices;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ResourcePlanningOffices" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ResourcePlanningOffices( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffices"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ResourcePlanningOffices( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record?[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ResourcePlanningOffices" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ResourcePlanningOffices( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <
        /// see cref="T:BudgetExecution.ResourcePlanningOffices" /> class.
        /// </summary>
        /// <param name="rpioCode">The rpio code.</param>
        public ResourcePlanningOffices( string rpioCode )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( rpioCode ) )?.Record;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffices"/> class.
        /// </summary>
        /// <param name="rpio">The rpio.</param>
        public ResourcePlanningOffices( ResourcePlanningOffices rpio )
        {
            ID = rpio.ID;
            Code = rpio.Code;
            Name = rpio.Name;
        }

        /// <summary>
        /// Gets the resource planning office.
        /// </summary>
        /// <returns></returns>
        public ResourcePlanningOffices GetResourcePlanningOffice( )
        {
            return MemberwiseClone( ) as ResourcePlanningOffices;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        public override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) ?? string.Empty )
                    : -1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        private IDictionary<string, object> SetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ $"{Field.Code}" ] = code
                    };
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