//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                Objectives.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Objectives.cs" company="Terry D. Eppler">
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
//    Objectives.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class Objectives : DataUnit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objectives"/>
        /// class.
        /// </summary>
        public Objectives( )
        {
            Source = Source.Objectives;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objectives"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Objectives( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record?[ "ObjectivesId" ].ToString( ) ?? string.Empty );
            Name = Record?[ nameof( Name ) ].ToString( );
            Code = Record?[ nameof( Code ) ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objectives"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public Objectives( IDataModel builder )
        {
            Record = builder?.Record;
            ID = int.Parse( Record?[ "ObjectivesId" ].ToString( ) ?? string.Empty );
            Name = Record?[ nameof( Name ) ].ToString( );
            Code = Record?[ nameof( Code ) ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Objectives" />
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public Objectives( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record?[ "ObjectivesId" ].ToString( ) ?? string.Empty );
            Name = dataRow[ nameof( Name ) ].ToString( );
            Code = dataRow[ nameof( Code ) ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objectives"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public Objectives( string code )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.Record;
            ID = int.Parse( Record?[ "ObjectivesId" ].ToString( ) ?? string.Empty );
            Name = Record?[ "Field.Name" ].ToString( );
            Code = Record?[ nameof( Code ) ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Objectives"/>
        /// class.
        /// </summary>
        /// <param name="objective"> The objective. </param>
        public Objectives( Objectives objective )
        {
            ID = objective.ID;
            Code = objective.Code;
            Name = objective.Name;
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
                    return new Dictionary<string, object>
                    {
                        [ $"{Field.Code}" ] = code
                    };
                }
                catch( Exception _ex )
                {
                    Objectives.Fail( _ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}