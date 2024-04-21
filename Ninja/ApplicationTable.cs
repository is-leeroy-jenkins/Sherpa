// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ApplicationTable.cs" company="Terry D. Eppler">
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
//   ApplicationTable.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    public class ApplicationTable
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int _id;

        /// <summary>
        /// The table name
        /// </summary>
        private string _tableName;

        /// <summary>
        /// The model
        /// </summary>
        private string _model;

        /// <summary>
        /// The source
        /// </summary>
        private Source _source;

        /// <summary>
        /// The record
        /// </summary>
        private DataRow _record;

        /// <summary>
        /// The data
        /// </summary>
        private IDictionary<string, object> _data;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName
        {
            get
            {
                return _tableName;
            }
            private set
            {
                _tableName = value;
            }
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model
        {
            get
            {
                return _model;
            }
            private set
            {
                _model = value;
            }
        }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source
        {
            get
            {
                return _source;
            }
            private set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record
        {
            get
            {
                return _record;
            }
            private set
            {
                _record = value;
            }
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data
        {
            get
            {
                return _data;
            }
            private set
            {
                _data = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ApplicationTable" />
        /// class.
        /// </summary>
        public ApplicationTable( )
        {
            _source = Source.ApplicationTables;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ApplicationTable" />
        /// class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ApplicationTable( IQuery query )
        {
            _record = new DataBuilder( query ).Record;
            _data = _record.ToDictionary( );
            _id = int.Parse( _record[ "ApplicationTablesId" ].ToString( ) ?? "0" );
            _tableName = _record[ "TableName" ].ToString( );
            _model = _record[ "Model" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ApplicationTable" />
        /// class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ApplicationTable( IDataModel builder )
        {
            _record = builder.Record;
            _data = _record.ToDictionary( );
            _id = int.Parse( _record[ "ApplicationTablesId" ].ToString( ) ?? "0" );
            _tableName = _record[ "TableName" ].ToString( );
            _model = _record[ "Model" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ApplicationTable" />
        /// class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ApplicationTable( DataRow dataRow )
        {
            _record = dataRow;
            _data = dataRow.ToDictionary( );
            _id = int.Parse( dataRow[ "ApplicationTablesId" ].ToString( ) ?? "0" );
            _tableName = dataRow[ "TableName" ].ToString( );
            _model = dataRow[ "Model" ].ToString( );
        }
    }
}