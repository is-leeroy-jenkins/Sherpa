// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Document.cs" company="Terry D. Eppler">
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
//   Document.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class Document : DataUnit
    {
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the system.
        /// </summary>
        /// <value>
        /// The system.
        /// </value>
        public string System { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Document" /> class.
        /// </summary>
        public Document( )
        {
            Source = Source.Documents;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Document" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public Document( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Map = Record.ToDictionary( );
            ID = int.Parse( Record[ "DocumentsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            System = Record[ "System" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Document" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public Document( IDataModel builder )
        {
            Record = builder.Record;
            Map = Record.ToDictionary( );
            ID = int.Parse( Record[ "DocumentsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            System = Record[ "System" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Document" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public Document( DataRow dataRow )
        {
            Record = dataRow;
            Map = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "DocumentsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            System = Record[ "System" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Document" /> class.
        /// </summary>
        /// <param name="doc">The document.</param>
        public Document( Document doc )
        {
            ID = doc.ID;
            Code = doc.Code;
            Name = doc.Name;
            System = doc.System;
            Category = doc.Category;
        }
    }
}