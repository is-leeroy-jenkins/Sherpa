// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-29-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ThrowIf.cs" company="Terry D. Eppler">
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
//   ThrowIf.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net.Mail;
    using System.Windows.Forms;
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using System.Drawing;
    using Microsoft.Office.Interop.Excel;
    using OfficeOpenXml;
    using Action = System.Action;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertTypeCheckPatternToNullCheck" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InternalOrPrivateMemberNotDocumented" ) ]
    public static class ThrowIf
    {
        /// <summary>
        /// Determines whether the specified string argument is null or empty.
        /// </summary>
        /// <param name="argument"> The string argument. </param>
        /// <param name="paramName"> The name of the string argument. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NullOrEmpty( string argument, string paramName )
        {
            if( string.IsNullOrEmpty( argument ) )
            {
                var _message = @$"The string '{paramName}' is null or empty!";
                throw new ArgumentNullException( _message );
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void Null( object argument, string paramName )
        {
            switch( argument )
            {
                case string _args:
                {
                    if( string.IsNullOrEmpty( _args ) )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Action _action:
                {
                    if( _action == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Query _query:
                {
                    if( _query == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataBuilder _dataBuilder:
                {
                    if( _dataBuilder == null )
                    {
                        var _message = @$"The  '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataModel _dataModel:
                {
                    if( _dataModel == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Form _form:
                {
                    if( _form == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Control _control:
                {
                    if( _control == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case EventArgs _eventArgs:
                {
                    if( _eventArgs == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataConfig _dataConfig:
                {
                    if( _dataConfig == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case SqlConfig _sqlConfig:
                {
                    if( _sqlConfig == null )
                    {
                        var _message = @$"The SqlConfig '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataUnit _dataUnit:
                {
                    if( _dataUnit == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Folder _folder:
                {
                    if( _folder == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataPath _path:
                {
                    if( _path == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataFile _file:
                {
                    if( _file == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case SqlStatement _sqlStatement:
                {
                    if( _sqlStatement == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataAdapter _adapter:
                {
                    if( _adapter == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataRow _row:
                {
                    var _items = _row?.ItemArray;
                    if( ( _items.Length == 0 ) 
                       || ( _items == null ) )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case OutlookConfig _outlookConfig:
                {
                    if( _outlookConfig == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case EmailContent _emailContent:
                {
                    if( _emailContent == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case MailMessage _mailMessage:
                {
                    if( _mailMessage == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Worksheet _worksheet:
                {
                    if( _worksheet == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case ExcelPackage _package:
                {
                    if( _package == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case SpreadsheetDocument _sheet:
                {
                    if( _sheet == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case OpenXmlElement _sheet:
                {
                    if( _sheet == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Grid _grid:
                {
                    if( _grid == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                default:
                {
                    if( argument == null )
                    {
                        var _message = @$"The '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoItems( IDictionary<string, object> argument, string paramName )
        {
            if( argument.Any( ) != true )
            {
                var _message = @$"The Dictionary<string, object> '{paramName}' is null or empty!";
                throw new ArgumentNullException( _message );
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NullOrEmpty( Color argument, string paramName )
        {
            if( argument.IsEmpty )
            {
                var _message = @$"The color '{paramName}' is empty or uninitialized!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> NoData throws exception if 'argument' has no elements. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName">
        /// Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoData( object argument, string paramName )
        {
            switch( argument )
            {
                case IListSource _listSource:
                {
                    if( _listSource?.ContainsListCollection == true )
                    {
                        var _message = @$"The IListSource '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }
                    
                    break;
                }
                case IEnumerable<string> _list:
                {
                    if( _list?.Any( ) == true )
                    {
                        var _message = @$"The IEnumerable<string> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }
                    
                    break;
                }
                case IEnumerable<DataRow> _rows:
                {
                    if( _rows?.Any( ) == true )
                    {
                        var _message = @$"The IEnumerable<DataRow> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }
                    
                    break;
                }
                case ICollection _collection:
                {
                    if( _collection?.IsEmpty( ) == true )
                    {
                        var _message = @$"The ICollection '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }
                    
                    break;
                }
                case IDictionary<string, object> _dict:
                {
                    if( _dict?.Any( ) != null )
                    {
                        var _message = @$"The IDictionary<string, object> '{paramName}' is empty!";
                        throw new ArgumentException( _message );
                    }
                    
                    break;
                }
            }
        }

        /// <summary> Noes the data. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoData( IListSource argument, string paramName )
        {
            var _list = argument?.GetList( );
            if( _list?.IsEmpty( ) == true )
            {
                var _message = @$"The data source '{paramName}' is empty!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Nulls the specified argument. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NotExists( string argument, string paramName )
        {
            if( !File.Exists( argument ) )
            {
                var _message = @$"The FileInfo '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
            else if( !new FileInfo( argument ).Exists )
            {
                var _message = @$"The DirectoryInfo '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
            else if( !Directory.Exists( argument ) )
            {
                var _message = @$"The Directory '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
            else if( !new DirectoryInfo( argument ).Exists )
            {
                var _message = @$"The DirectoryInfo '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary>
        /// Determines whether the specified argument is negative.
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> The argument's name. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
        public static void Negative( object argument, string paramName )
        {
            switch( argument )
            {
                case int negative:
                {
                    if( negative <= 0 )
                    {
                        var _message = @$"The integer {paramName} is negative!";
                        throw new ArgumentOutOfRangeException( paramName, _message );
                    }

                    break;
                }
                case double number:
                {
                    if( number <= 0 )
                    {
                        var _message = @$"The double {paramName} is negative!";
                        throw new ArgumentOutOfRangeException( paramName, _message );
                    }

                    break;
                }
                case decimal cash:
                {
                    if( cash <= 0 )
                    {
                        var _message = @$"The decimal {paramName} is negative!";
                        throw new ArgumentOutOfRangeException( paramName, _message );
                    }

                    break;
                }
            }
        }
    }
}