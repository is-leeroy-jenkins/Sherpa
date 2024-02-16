//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                IAsyncModel.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="IAsyncModel.cs" company="Terry D. Eppler">
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
//    IAsyncModel.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public interface IAsyncModel
    {
        /// <inheritdoc/>
        /// <summary>
        /// Gets the data elements.
        /// </summary>
        /// <value>
        /// The data elements.
        /// </value>
        Task<IDictionary<string, IEnumerable<string>>> DataElements { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        bool IsBusy { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the source.
        /// </summary>
        Source Source { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        Provider Provider { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        IBudgetConnection Connection { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        ISqlStatement SqlStatement { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        IQuery Query { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        Task<DataRow> Record { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        Task<DataTable> DataTable { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the data columns.
        /// </summary>
        /// <value>
        /// The data columns.
        /// </value>
        Task<IEnumerable<DataColumn>> DataColumns { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        Task<IEnumerable<string>> ColumnNames { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        Task<IList<int>> Keys { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        Task<IList<string>> Fields { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the dates.
        /// </summary>
        /// <value>
        /// The dates.
        /// </value>
        Task<IList<string>> Dates { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        Task<IList<string>> Numerics { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        Task<IDictionary<string, object>> Map { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        Task<DataSet> DataSet { get; set; }

        /// <summary> Gets the values asynchronous. </summary>
        /// <param name="dataRows"> The data rows. </param>
        /// <param name="columnName"> The name. </param>
        /// <param name="columnValue"> The value. </param>
        /// <returns> </returns>
        Task<IEnumerable<string>> GetValuesAsync( IEnumerable<DataRow> dataRows,
            string columnName, string columnValue );

        /// <summary> Gets the values. </summary>
        /// <param name="dataRows"> The data rows. </param>
        /// <param name="columnName"> The column. </param>
        /// <returns> </returns>
        IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string columnName );

        /// <summary>
        /// Creates the series asynchronous.
        /// </summary>
        /// <returns>
        /// Task
        /// </returns>
        Task<IDictionary<string, IEnumerable<string>>> GetSeriesAsync( );

        /// <summary>
        /// Begins the initialize.
        /// </summary>
        void BeginInit( );

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        void EndInit( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the data table asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<DataTable> GetDataTableAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the record asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<DataRow> GetRecordAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        DataTable GetDataTable( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the data set asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<DataSet> GetDataSetAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        void SetColumnCaptions( DataTable dataTable );

        /// <inheritdoc />
        /// <summary>
        /// Gets the fields asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IList<string>> GetFieldsAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the numerics asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IList<string>> GetNumericsAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the dates asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IList<string>> GetDatesAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the primary keys asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<IList<int>> GetPrimaryKeysAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the query asynchronous.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns>
        /// </returns>
        Task<IQuery> GetQueryAsync( SqlStatement sqlStatement );

        /// <inheritdoc />
        /// <summary>
        /// Gets the ordinals asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IEnumerable<int>> GetOrdinalsAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the map asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IDictionary<string, object>> GetMapAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the schema asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IDictionary<string, Type>> GetSchemaAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the columns asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IEnumerable<DataColumn>> GetColumnsAsync( );

        /// <inheritdoc />
        /// <summary>
        /// Gets the names asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<IEnumerable<string>> GetNamesAsync( );
    }
}