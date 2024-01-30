// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-17-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-17-2024
// ******************************************************************************************
// <copyright file="DataDimension.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   DataDimension.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class DataDimension
    {
        /// <summary>
        /// The records
        /// </summary>
        private protected int _records;

        /// <summary>
        /// The columns
        /// </summary>
        private protected int _columns;

        /// <summary>
        /// The dates
        /// </summary>
        private protected IList<string> _dates;

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        private protected IList<string> _fields;

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        private protected IList<string> _numerics;

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        private protected IDictionary<string, double> _values;

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        private protected DataTable _dataTable;

        /// <summary>
        /// Throws if null numeric.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        private protected void ThrowIfNullNumeric( string numeric )
        {
            try
            {
                ThrowIf.NullOrEmpty( numeric, nameof( numeric ) );
                if( _numerics?.Contains( numeric ) == false )
                {
                    var _message = $"{numeric} is not in Data Columns!";
                    throw new ArgumentOutOfRangeException( numeric, _message );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Throws if null field.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        private protected void ThrowIfNullField( string field )
        {
            try
            {
                ThrowIf.NullOrEmpty( field, nameof( field ) );
                if( _fields?.Contains( field ) == false )
                {
                    var _message = $"{field} is not in Data Columns!";
                    throw new ArgumentOutOfRangeException( field, _message );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Throws if null date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        private protected void ThrowIfNullDate( string date )
        {
            try
            {
                ThrowIf.NullOrEmpty( date, nameof( date ) );
                if( _dates?.Contains( date ) == false )
                {
                    var _message = $"{date} is not in Data Columns!";
                    throw new ArgumentOutOfRangeException( date, _message );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Throws if null criteria.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        private protected void ThrowIfNullCriteria( IDictionary<string, object> where )
        {
            try
            {
                ThrowIf.Null( where, nameof( where ) );
                var _keys = where.Keys.ToList( );
                foreach( var _column in _keys )
                {
                    if( _keys?.Contains( _column ) == false )
                    {
                        var _message = $"{_column} is not in Data Columns!";
                        throw new ArgumentOutOfRangeException( _column, _message );
                    }
                }
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
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}