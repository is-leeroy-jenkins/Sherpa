﻿// ******************************************************************************************
//     Assembly:             Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        03-23-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Sherpa is a small Federal Budget, Finance, and Accounting data management
//    application for analysts with the US Environmental Protection Agency (US EPA).
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   BindingSourceExtensions.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UseNullPropagation" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToReturnStatement" ) ]
    public static class BindingSourceExtensions
    {
        /// <summary>
        /// The GetCurrentDataRow
        /// </summary>
        /// <param name="bindingSource">The bindingSource
        /// <see cref="BindingSource" /></param>
        /// <returns>
        /// The
        /// <see cref="DataRow" />
        /// </returns>
        public static DataRow GetCurrentRow( this BindingSource bindingSource )
        {
            try
            {
                if( bindingSource.Current != null )
                {
                    return ( (DataRowView)bindingSource?.Current )?.Row;
                }
                else
                {
                    return default( DataRow );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataRow );
            }
        }

        /// <summary>
        /// Gets the rows.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <returns></returns>
        public static IList<DataRow> GetDataRows( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                try
                {
                    var _table = (DataTable)bindingSource.DataSource;
                    var _list = new List<DataRow>( );
                    foreach( DataRow _row in _table.Rows )
                    {
                        _list.Add( _row );
                    }

                    return ( _list?.Any( ) == true )
                        ? _list
                        : default( IList<DataRow> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<DataRow> );
                }
            }

            return default( IList<DataRow> );
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <returns>
        ///  DataTable
        /// </returns>
        public static DataTable GetDataTable( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                try
                {
                    var _table = (DataTable)bindingSource.DataSource;
                    return _table?.Rows.Count > 0
                        ? _table
                        : default( DataTable );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}