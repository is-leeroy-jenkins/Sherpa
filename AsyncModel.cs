// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="AsyncModel.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the 
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  $CURRENT_YEAR$  Terry Eppler
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
//   AsyncModel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AsyncModel : AsyncBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets the data elements.
        /// </summary>
        /// <value>
        /// The data elements.
        /// </value>
        public Task<IDictionary<string, IEnumerable<string>>> DataElements { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is busy; otherwise, <c>false</c>.
        /// </value>
        public bool IsBusy
        {
            get { return _busy; }
        }

        public AsyncModel( )
        {
        }

        public AsyncModel( Source source, Provider provider = Provider.Access )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, SQL.SELECTALL );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataElements = CreateSeries( DataTable );
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        public AsyncModel( Source source, Provider provider, IDictionary<string, object> where )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, where );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataElements = CreateSeries( DataTable );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> where, SQL commandType )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, fields, numerics, where,
                commandType );

            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( Source source, IDictionary<string, object> where )
        {
            Source = source;
            Provider = Provider.Access;
            ConnectionFactory = new ConnectionFactory( source, Provider.Access );
            SqlStatement = new SqlStatement( source, Provider.Access, where );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( Source source, Provider provider, string sqlText )
        {
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Keys = GetPrimaryKeysAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            ConnectionFactory = new ConnectionFactory( fullPath );
            Source = ConnectionFactory.Source;
            Provider = ConnectionFactory.Provider;
            SqlStatement = new SqlStatement( Source, Provider, sqlText, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        public AsyncModel( IQuery query )
        {
            Query = query;
            Source = query.Source;
            Provider = query.Provider;
            ConnectionFactory = query.ConnectionFactory;
            SqlStatement = query.SqlStatement;
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeries( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }
    }
}
