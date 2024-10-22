﻿// ****************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 15-03-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        19-03-2024
// ****************************************************************************************
// <copyright file="SqlStatement.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for analysts in the
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
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
//     EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//     OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
//     AND NON-INFRINGEMENT.  IN NO EVENT SHALL THE AUTHORS
//     OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//     TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//  SqlStatement.cs
// </summary>
// ****************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:Sherpa.SqlBase"/>
    /// <seealso cref="T:Sherpa.ISqlStatement"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class SqlStatement : SqlBase, ISqlStatement
    {
        /// <inheritdoc />
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
            private protected set
            {
                _source = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider
        {
            get
            {
                return _provider;
            }
            private protected set
            {
                _provider = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public Command CommandType
        {
            get
            {
                return _commandType;
            }
            private protected set
            {
                _commandType = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension
        {
            get
            {
                return _extension;
            }
            private protected set
            {
                _extension = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the criteria.
        /// </summary>
        /// <value>
        /// The criteria.
        /// </value>
        public IDictionary<string, object> Criteria
        {
            get
            {
                return _criteria;
            }
            private protected set
            {
                _criteria = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the updates.
        /// </summary>
        /// <value>
        /// The updates.
        /// </value>
        public IDictionary<string, object> Updates
        {
            get
            {
                return _updates;
            }
            private protected set
            {
                _updates = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields
        {
            get
            {
                return _fields;
            }
            private protected set
            {
                _fields = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics
        {
            get
            {
                return _numerics;
            }
            private protected set
            {
                _numerics = value;
            }
        }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        /// <value>
        /// The groups.
        /// </value>
        public IList<string> Groups
        {
            get
            {
                return _groups;
            }
            private protected set
            {
                _groups = value;
            }
        }

        /// <inheritdoc />
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
            private protected set
            {
                _tableName = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the database path.
        /// </summary>
        /// <value>
        /// The database path.
        /// </value>
        public string DbPath
        {
            get
            {
                return _dbPath;
            }
            private protected set
            {
                _dbPath = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        {
            get
            {
                return _fileName;
            }
            private protected set
            {
                _fileName = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value>
        /// The command text.
        /// </value>
        public string CommandText
        {
            get
            {
                return _commandText;
            }
            private protected set
            {
                _commandText = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        public SqlStatement( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, Command commandType = Command.SELECTALL )
            : base( source, provider, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public SqlStatement( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, string sqlText, Command commandType )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> </param>
        /// <param name="commandType"> </param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> where,
            Command commandType = Command.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, Command commandType = Command.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        /// <param name="where"> The arguments. </param>
        public SqlStatement( Source source, Provider provider, Command commandType,
            IDictionary<string, object> where )
            : base( source, provider, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, Command commandType = Command.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The columns. </param>
        /// <param name="numerics"> The aggregates. </param>
        /// <param name="having"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            Command commandType = Command.SELECT )
            : base( source, provider, fields, numerics, having,
                commandType )
        {
        }

        /// <summary> Converts to string. </summary>
        /// <returns>
        /// A
        /// <see cref="System.String"/>
        /// that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( CommandText )
                    ? CommandText
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }
    }
}