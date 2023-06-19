// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IDataModel.cs" company="Terry D. Eppler">
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
//   IDataModel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary> </summary>
    public interface IDataModel
    {
        /// <summary> The program elements </summary>
        IDictionary<string, IEnumerable<string>> DataElements { get; }

        /// <summary> The source </summary>
        Source Source { get; set; }

        /// <summary> The provider </summary>
        Provider Provider { get; set; }

        /// <summary> The connection builder </summary>
        IConnectionFactory ConnectionFactory { get; set; }

        /// <summary> The arguments </summary>
        IDictionary<string, object> Map { get; set; }

        /// <summary> The SQL statement </summary>
        ISqlStatement SqlStatement { get; set; }

        /// <summary> The query </summary>
        IQuery Query { get; set; }

        /// <summary> The record </summary>
        DataRow Record { get; set; }

        /// <summary> The Data table </summary>
        DataTable DataTable { get; set; }

        /// <summary> Gets or sets the columns. </summary>
        /// <value> The columns. </value>
        IEnumerable<DataColumn> DataColumns { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        string TableName { get; set; }

        /// <summary> Gets or sets the Data set. </summary>
        /// <value> The Data set. </value>
        DataSet DataSet { get; set; }

        /// <summary> Gets or sets the name of the data set. </summary>
        /// <value> The name of the data set. </value>
        string DataSetName { get; set; }

        /// <summary> Filters the data. </summary>
        /// <param name = "where" > The dictionary. </param>
        /// <returns> </returns>
        IEnumerable<DataRow> FilterData( IDictionary<string, object> where );

        /// <summary> Gets the column ordinals. </summary>
        /// <returns> </returns>
        IEnumerable<int> GetOrdinals( );

        /// <summary> Gets the columns. </summary>
        /// <returns> </returns>
        IEnumerable<DataColumn> GetDataColumns( );

        /// <summary> Gets the Data. </summary>
        /// <returns> </returns>
        IEnumerable<DataRow> GetData( );

        /// <summary> Gets the column schema. </summary>
        /// <returns> </returns>
        DataColumnCollection GetTableSchema( );
    }
}