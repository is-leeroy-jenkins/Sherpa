// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ProgramProjectDescription.cs" company="Terry D. Eppler">
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
//   ProgramProjectDescription.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class ProgramProjectDescriptions : DescriptionBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProjectDescriptions"/>
        /// class.
        /// </summary>
        public ProgramProjectDescriptions( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProjectDescriptions"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ProgramProjectDescriptions( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            Title = Record[ nameof( Title ) ].ToString( );
            Definition = Record[ nameof( Definition ) ].ToString( );
            Laws = Record[ nameof( Laws ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProjectDescriptions"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public ProgramProjectDescriptions( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ nameof( Code ) ].ToString( );
            Name = Record[ nameof( Name ) ].ToString( );
            Title = Record[ nameof( Title ) ].ToString( );
            Definition = Record[ nameof( Definition ) ].ToString( );
            Laws = Record[ nameof( Laws ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProjectDescriptions"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public ProgramProjectDescriptions( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ProgramProjectsId" ].ToString( ) );
            Code = dataRow[ nameof( Code ) ].ToString( );
            Name = dataRow[ nameof( Name ) ].ToString( );
            Title = dataRow[ nameof( Title ) ].ToString( );
            Definition = dataRow[ nameof( Definition ) ].ToString( );
            Laws = dataRow[ nameof( Laws ) ].ToString( );
            ProgramAreaCode = dataRow[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = dataRow[ nameof( ProgramAreaName ) ].ToString( );
            Data = dataRow?.ToDictionary( );
        }
    }
}