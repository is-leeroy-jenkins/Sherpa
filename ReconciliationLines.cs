// ***********************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              20-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        20-10-2023
// ***********************************************************************************************
// <copyright file="ReconciliationLines.cs.cs" company="Terry D. Eppler">
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
//   Eppler, Terry.cs
// </summary>
// ***********************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ReconciliationLines
    {
        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ReconciliationLines( )
        {
            Source = Source.ReconciliationLines;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        public ReconciliationLines( IQuery query ) 
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReconciliationLinesId" ].ToString( ) );
            Number = Record[ "Number" ].ToString(  );
            Name = Record[ "Name" ].ToString(  );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataBuilder"></param>
        public ReconciliationLines( IDataModel dataBuilder )
            : this( )
        {
            Record = dataBuilder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReconciliationLinesId" ].ToString( ) );
            Number = Record[ "Number" ].ToString(  );
            Name = Record[ "Name" ].ToString(  );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        public ReconciliationLines( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReconciliationLinesId" ].ToString( ) );
            Number = Record[ "Number" ].ToString(  );
            Name = Record[ "Name" ].ToString(  );
        }
    }
}