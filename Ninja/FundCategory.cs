// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="FundCategory.cs" company="Terry D. Eppler">
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
//   FundCategory.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.DataUnit"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class FundCategory : DataUnit
    {
        /// <summary> Gets or sets the short name. </summary>
        /// <value> The short name. </value>
        public string ShortName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FundCategory"/>
        /// class.
        /// </summary>
        public FundCategory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FundCategory"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public FundCategory( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FundCategory"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public FundCategory( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FundCategory"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public FundCategory( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FundCategory"/>
        /// class.
        /// </summary>
        /// <param name="fundCategory"> The fund category. </param>
        public FundCategory( FundCategory fundCategory )
        {
            ID = fundCategory.ID;
            Code = fundCategory.Code;
            Name = fundCategory.Name;
            ShortName = fundCategory.ShortName;
        }
    }
}