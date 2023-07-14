// ******************************************************************************************
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

    /// <summary> </summary>
    /// <seealso cref="IResourcePlanningOffice"/>
    /// <seealso cref="ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class ResourcePlanningOffice : DataUnit, IResourcePlanningOffice
    {
        /// <summary> The source </summary>
        public override Source Source { get; init; } = Source.ResourcePlanningOffices;

        /// <summary> Gets the dataRow. </summary>
        /// <value> The dataRow. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public override int ID { get; set; }

        /// <summary> Gets the code. </summary>
        public override string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public override string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        public ResourcePlanningOffice( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ResourcePlanningOffice( IQuery query )
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
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ResourcePlanningOffice( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record?[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public ResourcePlanningOffice( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResourcePlanningOffice"/>
        /// class.
        /// </summary>
        /// <param name="rpioCode"> The rpioCode. </param>
        public ResourcePlanningOffice( string rpioCode )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( rpioCode ) )?.Record;
            ID = int.Parse( Record[ "ResourcePlanningOfficesId" ].ToString( ) ?? string.Empty );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public ResourcePlanningOffice( IResourcePlanningOffice rpio )
        {
            ID = rpio.ID;
            Code = rpio.Code;
            Name = rpio.Name;
        }

        /// <summary> Gets the resource planning office. </summary>
        /// <returns> </returns>
        public IResourcePlanningOffice GetResourcePlanningOffice( )
        {
            return MemberwiseClone( ) as ResourcePlanningOffice;
        }

        /// <summary> Gets the identifier. </summary>
        /// <param name="dataRow"> The data row. </param>
        /// <returns> </returns>
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

        /// <summary> Sets the arguments. </summary>
        /// <param name="code"> The code. </param>
        /// <returns> </returns>
        private IDictionary<string, object> SetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{Field.Code}" ] = code };
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