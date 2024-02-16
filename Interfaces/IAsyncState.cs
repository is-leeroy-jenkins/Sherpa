//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                IAsyncState.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="IAsyncState.cs" company="Terry D. Eppler">
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
//    IAsyncState.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public interface IAsyncState : ISource, IProvider
    {
        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        public IBudgetConnection Connection { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public IQuery Query { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public Task<DataRow> Record { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public Task<DataTable> DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data columns.
        /// </summary>
        /// <value>
        /// The data columns.
        /// </value>
        public Task<IEnumerable<DataColumn>> DataColumns { get; set; }

        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public Task<IEnumerable<string>> ColumnNames { get; set; }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        public Task<IList<int>> Keys { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public Task<IList<string>> Fields { get; set; }

        /// <summary>
        /// Gets or sets the dates.
        /// </summary>
        /// <value>
        /// The dates.
        /// </value>
        public Task<IList<string>> Dates { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public Task<IList<string>> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        public Task<IDictionary<string, object>> Map { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        public Task<DataSet> DataSet { get; set; }

        /// <summary>
        /// Gets the data table asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<DataTable> GetDataTableAsync( );

        /// <summary>
        /// Gets the record asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<DataRow> GetRecordAsync( );

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable( );

        /// <summary>
        /// Gets the data set asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<DataSet> GetDataSetAsync( );

        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public void SetColumnCaptions( DataTable dataTable );

        /// <summary>
        /// Gets the fields asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<string>> GetFieldsAsync( );

        /// <summary>
        /// Gets the numerics asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<string>> GetNumericsAsync( );

        /// <summary>
        /// Gets the dates asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<string>> GetDatesAsync( );

        /// <summary>
        /// Gets the primary keys asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<int>> GetPrimaryKeysAsync( );
    }
}