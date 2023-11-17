using System.Data;
using System.Diagnostics.CodeAnalysis;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public abstract class ReportBase
    {
        /// <summary>
        /// Lists to data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        private protected DataTable ListToDataTable<T>( IEnumerable<T> data )
        {
            try
            {
                ThrowIf.NoData( data, nameof( data ) );
                var _table = new DataTable( );
                for( var _i = 0; _i < ( typeof( T )?.GetProperties( ) ).Length; _i++ )
                {
                    var _info = ( typeof( T )?.GetProperties( ) )[ _i ];
                    var _col = new DataColumn( _info.Name, GetNullableType( _info.PropertyType ) );
                    _table?.Columns?.Add( _col );
                }

                foreach( var _t in data )
                {
                    var _row = _table.NewRow( );
                    foreach( var _info in typeof( T ).GetProperties( ) )
                    {
                        _row[ _info.Name ] = !IsNullableType( _info.PropertyType )
                            ? _info.GetValue( _t, null )
                            : _info.GetValue( _t, null ) ?? DBNull.Value;
                    }

                    _table.Rows.Add( _row );
                }

                return _table;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the type of the nullable.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        private protected Type GetNullableType( Type type )
        {
            try
            {
                var _returnType = type;
                if( type.IsGenericType
                   && type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) )
                {
                    _returnType = Nullable.GetUnderlyingType( type );
                }

                return _returnType;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Type );
            }
        }

        /// <summary>
        /// Appends the text cell.
        /// </summary>
        /// <param name="cellReference">The cell reference.</param>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="excelRow">The excel row.</param>
        private protected void AppendTextCell( string cellReference, string cellValue,
            OpenXmlElement excelRow )
        {
            try
            {
                ThrowIf.NullOrEmpty( cellReference, nameof( cellReference ) );
                ThrowIf.NullOrEmpty( cellValue, nameof( cellValue ) );
                ThrowIf.Null( excelRow, nameof( excelRow ) );
                var _cell = new Cell
                {
                    CellReference = cellReference,
                    DataType = CellValues.String
                };

                var _cellValue = new CellValue
                {
                    Text = cellValue
                };

                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Appends the numeric cell.
        /// </summary>
        /// <param name="cellReference">The cell reference.</param>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="excelRow">The excel row.</param>
        private protected void AppendNumericCell( string cellReference, string cellValue,
            OpenXmlElement excelRow )
        {
            try
            {
                ThrowIf.NullOrEmpty( cellReference, nameof( cellReference ) );
                ThrowIf.NullOrEmpty( cellValue, nameof( cellValue ) );
                ThrowIf.Null( excelRow, nameof( excelRow ) );
                var _cell = new Cell
                {
                    CellReference = cellReference
                };

                var _cellValue = new CellValue
                {
                    Text = cellValue
                };

                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the name of the excel column.
        /// </summary>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns></returns>
        private protected string GetExcelColumnName( int columnIndex )
        {
            try
            {
                ThrowIf.Negative( columnIndex, nameof( columnIndex ) );
                if( columnIndex < 26 )
                {
                    return ( (char)( 'A' + columnIndex ) ).ToString( );
                }

                var _first = (char)( 'A' + columnIndex / 26 - 1 );
                var _second = (char)( 'A' + columnIndex % 26 );
                return $"{_first}{_second}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Determines whether [is nullable type] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if [is nullable type] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        private protected bool IsNullableType( Type type )
        {
            try
            {
                return type == typeof( string )
                    || type.IsArray
                    || ( type.IsGenericType
                        && type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
