// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-14-2023
// ******************************************************************************************
// <copyright file="MetricBase.cs" company="Terry D. Eppler">
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
//   MetricBase.cs
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
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class Measure : Dimension
    {
        /// <summary>
        /// Counts the values.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public int CountValues( string numeric )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                var _select = _dataTable?.AsEnumerable( )
                    ?.Select( p => p.Field<double>( numeric ) );

                return _select?.Any( ) == true
                    ? _select.Count( )
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary>
        /// Counts the values.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public int CountValues( string numeric, IDictionary<string, object> where )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                ThrowIfNullCriteria( where );
                var _select = _dataTable?.Filter( where )
                    ?.Select( p => p.Field<double>( numeric ) );
                return _select?.Any( ) == true
                    ? _select.Count( )
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateTotal( string numeric )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                var _select = _dataTable?.AsEnumerable( )
                    ?.Select( p => p.Field<double>( numeric ) )
                    ?.Sum( );

                return _select > 0
                    ? double.Parse( _select?.ToString( "N1" ) )
                    : 0.0d;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0.0d;
            }
        }

        /// <summary>
        /// Calculates the total.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateTotal( string numeric, IDictionary<string, object> where )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                ThrowIfNullCriteria( where );
                var _select = _dataTable?.Filter( where )
                    ?.Select( p => p.Field<double>( numeric ) )
                    ?.Sum( );

                return _select > 0
                    ? double.Parse( _select?.ToString( "N1" ) )
                    : 0.0d;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0.0d;
            }
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateAverage( string numeric )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                var _query = _dataTable.AsEnumerable( )
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

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateAverage( string numeric, IDictionary<string, object> where )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                ThrowIfNullCriteria( where );
                var _query = _dataTable?.Filter( where )
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

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculatePercentage( string numeric )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                var _select = _dataTable?.AsEnumerable( )
                    ?.Select( p => p.Field<double>( numeric ) )
                    ?.Sum( );

                return _select > 0
                    ? double.Parse( _select?.ToString( "N1" ) )
                    : 0.0d;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0.0d;
            }
        }

        /// <summary>
        /// Calculates the percentage.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculatePercentage( string numeric, IDictionary<string, object> where )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                ThrowIfNullCriteria( where );
                var _select = _dataTable?.Filter( where )
                    ?.Select( p => p.Field<double>( numeric ) )
                    ?.Sum( );

                return _select > 0
                    ? double.Parse( _select?.ToString( "N1" ) )
                    : 0.0d;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0.0d;
            }
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateDeviation( string numeric )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                var _query = _dataTable?.AsEnumerable( )
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

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public double CalculateDeviation( string numeric, IDictionary<string, object> where )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                ThrowIfNullCriteria( where );
                var _query = _dataTable?.Filter( where )
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

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name="numeric">
        /// The numeric.
        /// </param>
        /// <returns></returns>
        public double CalculateVariance( string numeric )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                var _query = _dataTable?.AsEnumerable( )
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

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name="numeric">
        /// The numeric.
        /// </param>
        /// <param name="where">
        /// The where.
        /// </param>
        /// <returns></returns>
        public double CalculateVariance( string numeric, IDictionary<string, object> where )
        {
            try
            {
                ThrowIfNullNumeric( numeric );
                ThrowIfNullCriteria( where );
                var _query = _dataTable?.Filter( where )
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

        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetNumericColumns( )
        {
            try
            {
                var _columns = new List<string>( );
                foreach( DataColumn _dataColumn in _dataTable.Columns )
                {
                    if( ( !_dataColumn.ColumnName.EndsWith( "Id" )
                           && ( _dataColumn.Ordinal > 0 )
                           && ( _dataColumn.DataType == typeof( double ) ) )
                       || ( _dataColumn.DataType == typeof( short ) )
                       || ( _dataColumn.DataType == typeof( long ) )
                       || ( _dataColumn.DataType == typeof( decimal ) )
                       || ( _dataColumn.DataType == typeof( float ) ) )
                    {
                        _columns.Add( _dataColumn.ColumnName );
                    }
                }

                return _columns?.Any( ) == true
                    ? _columns
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
        private protected IList<string> GetDateColumns( )
        {
            try
            {
                var _columns = new List<string>( );
                foreach( DataColumn _dataColumn in _dataTable.Columns )
                {
                    if( ( _dataColumn.Ordinal > 0 )
                       && ( ( _dataColumn.DataType == typeof( DateTime ) )
                           || ( _dataColumn.DataType == typeof( DateOnly ) )
                           || ( _dataColumn.DataType == typeof( DateTimeOffset ) )
                           || _dataColumn.ColumnName.EndsWith( "Day" )
                           || _dataColumn.ColumnName.EndsWith( "Date" ) ) )
                    {
                        _columns.Add( _dataColumn.ColumnName );
                    }
                }

                return _columns?.Any( ) == true
                    ? _columns
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }
    }
}