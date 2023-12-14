//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                DataArgs.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DataArgs.cs" company="Terry D. Eppler">
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
//    DataArgs.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.StateData" />
    /// <seealso cref="T:BudgetExecution.IStateTransfer" />
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( " ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class DataArgs : StateData, IStateTransfer
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public override string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the selected fields.
        /// </summary>
        /// <value>
        /// The selected fields.
        /// </value>
        public IList<string> SelectedFields { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the selected numerics.
        /// </summary>
        /// <value>
        /// The selected numerics.
        /// </value>
        public IList<string> SelectedNumerics { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the selected dates.
        /// </summary>
        /// <value>
        /// The selected dates.
        /// </value>
        public IList<DateTime> SelectedDates { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public override string SqlQuery { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        /// <inheritdoc />
        public override Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        /// <inheritdoc />
        public override Source Source { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public override IDictionary<string, object> Filter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataArgs"/> class.
        /// </summary>
        public DataArgs( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataArgs"/> class.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public DataArgs( DataArgs args )
        {
            Source = args.Source;
            Provider = args.Provider;
            Filter = args.Filter;
            SelectedTable = args.SelectedTable;
            SqlQuery = args.SqlQuery;
            SelectedColumns = args.SelectedColumns;
            SelectedFields = args.SelectedFields;
            SelectedNumerics = args.SelectedNumerics;
            SelectedDates = args.SelectedDates;
        }

        /// <summary>
        /// Deconstructs the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="table"> </param>
        /// <param name="filter">The filter.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="dates">The dates.</param>
        public void Deconstruct( out Source source, out Provider provider, out string table,
            out IDictionary<string, object> filter, out IList<string> columns, 
            out IList<string> fields, out IList<string> numerics, out IList<DateTime> dates )
        {
            source = Source;
            provider = Provider;
            table = SelectedTable;
            filter = Filter;
            columns = SelectedColumns;
            fields = SelectedFields;
            numerics = SelectedNumerics;
            dates = SelectedDates;
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear( )
        {
            try
            {
                Source = default( Source );
                Provider = default( Provider );
                SelectedTable = string.Empty;
                Filter = default( IDictionary<string, object> );
                SqlQuery = string.Empty;
                SelectedColumns = default( IList<string> );
                SelectedFields = default( IList<string> );
                SelectedNumerics = default( IList<string> );
                SelectedDates = default( IList<DateTime> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}