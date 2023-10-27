// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ProgramProject.cs" company="Terry D. Eppler">
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
//   ProgramProject.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.DescriptionBase"/>
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class ProgramProject : DescriptionBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        public ProgramProject( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ProgramProject( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The dataBuilder. </param>
        public ProgramProject( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public ProgramProject( DataRow dataRow )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ProgramProject"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public ProgramProject( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "ProgramProjectsId" ].ToString( ) );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Title = Record[ "Title" ].ToString( );
            Definition = Record[ "Definition" ].ToString( );
            Laws = Record[ "Laws" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        public ProgramProject( ProgramProject project )
        {
            ID = project.ID;
            Code = project.Code;
            Name = project.Name;
            Title = project.Title;
            Definition = project.Definition;
            Laws = project.Laws;
            ProgramAreaCode = project.ProgramAreaCode;
            ProgramAreaName = project.ProgramAreaName;
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
        private IDictionary<string, object> GetArgs( string code )
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