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

    /// <summary>
    /// 
    /// </summary>
    public interface IDataModel
    {
        /// <summary>
        /// Gets the data elements.
        /// </summary>
        /// <value>
        /// The data elements.
        /// </value>
        IDictionary<string, IEnumerable<string>> DataElements { get; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        IDictionary<string, object> Map { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        IQuery Query { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data columns.
        /// </summary>
        /// <value>
        /// The data columns.
        /// </value>
        IEnumerable<DataColumn> DataColumns { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        string TableName { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the name of the data set.
        /// </summary>
        /// <value>
        /// The name of the data set.
        /// </value>
        string DataSetName { get; set; }

        /// <summary>
        /// Gets the ordinals.
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> GetOrdinals( );

        /// <summary>
        /// Gets the data columns.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataColumn> GetDataColumns( );

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataRow> GetData( );
    }
}