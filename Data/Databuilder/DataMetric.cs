// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-06-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-01-2023
// ******************************************************************************************
// <copyright file="DataMetric.cs" company="Terry D. Eppler">
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
//   DataMetric.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using LinqStatistics;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Local" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Global" ) ]
    public class DataMetric : MetricBase
    {
        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="DataMetric"/> class.
        /// </summary>
        public DataMetric( )
        {
        }

        /// <summary>
        /// Initializes a new
        /// instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public DataMetric( DataTable dataTable )
        {
            DataTable = dataTable;
            Numerics = GetNumerics( );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public DataMetric( IEnumerable<DataRow> dataRow )
        {
            DataTable = dataRow.CopyToDataTable( );
            Numerics = GetNumerics( );
        }

        /// <summary>
        /// Counts the values.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public override int CountValues( string numeric )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) );

                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : -1;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return -1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Counts the values.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public override int CountValues( string numeric, IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) );

                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : -1;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return -1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public override double CalculateTotal( string numeric )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );

                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public override double CalculateTotal( string numeric, IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _select = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );

                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public override double CalculateAverage( string numeric )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Average( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public override double CalculateAverage( string numeric, IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Average( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public override double CalculatePercentage( string numeric )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _select = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );

                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public override double CalculatePercentage( string numeric,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _select = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Sum( );

                    return _select > 0
                        ? double.Parse( _select?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public override double CalculateDeviation( string numeric )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.StandardDeviation( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public override double CalculateDeviation( string numeric,
            IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.StandardDeviation( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public override double CalculateVariance( string numeric )
        {
            if( !string.IsNullOrEmpty( numeric )
               && Numerics.Contains( numeric ) )
            {
                try
                {
                    var _query = DataTable.AsEnumerable( )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Variance( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return 0.0d;
                }
            }

            return -1.0d;
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public override double CalculateVariance( string numeric,
            IDictionary<string, object> where )
        {
            if( string.IsNullOrEmpty( numeric )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _query = DataTable.Filter( where )
                        ?.Select( p => p.Field<double>( numeric ) )
                        ?.Variance( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return 0.0d;
                }
            }

            return -1.0d;
        }

        /// <summary>
        /// Gets the numeric columns.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IList<string> GetNumerics( )
        {
            try
            {
                var _numerics = new List<string>( );
                foreach( DataColumn _col in DataTable.Columns )
                {
                    if( ( !_col.ColumnName.EndsWith( "Id" ) && ( _col.Ordinal > 0 )
                           && ( _col.DataType == typeof( double ) ) )
                       || ( _col.DataType == typeof( short ) )
                       || ( _col.DataType == typeof( long ) )
                       || ( _col.DataType == typeof( decimal ) )
                       || ( _col.DataType == typeof( float ) ) )

                    {
                        _numerics.Add( _col.ColumnName );
                    }
                }

                return _numerics?.Any( ) == true
                    ? _numerics
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the dates.
        /// </summary>
        /// <returns></returns>
        private protected override IList<string> GetDates( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _dates = new List<string>( );
                    foreach( DataColumn _col in DataTable.Columns )
                    {
                        if( ( _col.Ordinal > 0 )
                           && ( ( _col.DataType == typeof( DateTime ) )
                               || ( _col.DataType == typeof( DateOnly ) )
                               || ( _col.DataType == typeof( DateTimeOffset ) )
                               || _col.ColumnName.EndsWith( "Day" )
                               || _col.ColumnName.EndsWith( "Date" ) ) )
                        {
                            _dates.Add( _col.ColumnName );
                        }
                    }

                    return _dates?.Any( ) == true
                        ? _dates
                        : default( IList<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }
    }
}