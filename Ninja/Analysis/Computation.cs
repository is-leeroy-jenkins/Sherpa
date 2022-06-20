// <copyright file = "Computation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public class Computation : Builder, IDataFilter
    {
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        private protected IEnumerable<DataRow> _dataRow;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Computation"/> class.
        /// </summary>
        public Computation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Computation"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public Computation( IDataAccess data )
        {
            _dataRow = data.GetData( );
        }

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "filter" >
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<DataRow> FilterData( Field field, string filter )
        {
            if( GetData( )?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && Verify.IsInput( filter ) )
            {
                try
                {
                    var _select = GetData( )
                        ?.Where( p => p.Field<string>( $"{field}" ).Equals( filter ) )
                        ?.Select( p => p );

                    return _select?.Any( ) == true
                        ? _select.ToArray( )
                        : default( DataRow[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }
    }
}
