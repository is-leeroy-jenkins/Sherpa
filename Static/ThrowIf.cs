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
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net.Mail;
    using System.Windows.Forms;

    /// <summary> </summary>
    [SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
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
                case Action _action:
                {
                    if( _action == null )
                    {
                        var _message = @$"The Action '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Query _query:
                {
                    if( _query == null )
                    {
                        var _message = @$"The ChromiumWebBrowser '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataBuilder _dataBuilder:
                {
                    if( _dataBuilder == null )
                    {
                        var _message = @$"The DataBuilder '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case IDataModel _dataModel:
                {
                    if( _dataModel == null )
                    {
                        var _message = @$"The IDataModel '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Form _form:
                {
                    if( _form == null )
                    {
                        var _message = @$"The Form '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Control _control:
                {
                    if( _control == null )
                    {
                        var _message = @$"The Control '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case EventArgs _eventArgs:
                {
                    if( _eventArgs == null )
                    {
                        var _message = @$"The EventArgs '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataConfig _dataConfig:
                {
                    if( _dataConfig == null )
                    {
                        var _message = @$"The DataConfig '{paramName}' is null!";
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
                        var _message = @$"The DataUit '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case Folder _folder:
                {
                    if( _folder == null )
                    {
                        var _message = @$"The Folder '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataPath _path:
                {
                    if( _path == null )
                    {
                        var _message = @$"The DataPath '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case DataFile _file:
                {
                    if( _file == null )
                    {
                        var _message = @$"The DataFile '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case SqlStatement _sqlStatement:
                {
                    if( _sqlStatement == null )
                    {
                        var _message = @$"The SqlStatement '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case OutlookConfig _outlookConfig:
                {
                    if( _outlookConfig == null )
                    {
                        var _message = @$"The OutlookConfig '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case EmailContent _emailContent:
                {
                    if( _emailContent == null )
                    {
                        var _message = @$"The EmailContent '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case MailMessage _mailMessage:
                {
                    if( _mailMessage == null )
                    {
                        var _message = @$"The MailMessage '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                case object _args:
                {
                    if( _args == null )
                    {
                        var _message = @$"The object '{paramName}' is null!";
                        throw new ArgumentNullException( _message );
                    }

                    break;
                }
                default:
                {
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

        /// <summary> None throws exception if 'argument' has no elements. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoElements<T>( IEnumerable<T> argument, string paramName )
        {
            if( argument.Any( ) != true )
            {
                var _message = @$"The enumerable '{paramName}' is empty!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Noes the data. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NoData( IListSource argument, string paramName )
        {
            if( argument == null )
            {
                var _message = @$"The data source '{paramName}' is null!";
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
                var _message = @$"The File '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
            else if( !Directory.Exists( argument ) )
            {
                var _message = @$"The Directory '{paramName}' does not exist!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Throws exception if 'argument' </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <exception cref="System.ArgumentNullException"> </exception>
        public static void NotEnum( Enum argument, string paramName )
        {
            if( argument.GetType( ) != typeof( Enum ) )
            {
                var _message = @$"The Enum '{paramName}' is invalid!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> </summary>
        /// <param name="argument"> </param>
        /// <param name="paramName"> </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public static void NotDate( DateTime argument, string paramName )
        {
            if( argument.GetType( ) != typeof( DateTime ) )
            {
                var _message = @$"The DateTime '{paramName}' is invalid!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> </summary>
        /// <param name="argument"> </param>
        /// <param name="paramName"> </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public static void NotDateOnly( DateOnly argument, string paramName )
        {
            if( argument.GetType( ) != typeof( DateOnly ) )
            {
                var _message = @$"The DateOnly '{paramName}' is invalid!";
                throw new ArgumentException( _message );
            }
        }

        /// <summary> Determines whether the specified argument is negative. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> The argument's name. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
        public static void Negative( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The integer '{paramName}' is negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary> Determines whether the specified argument is negative. </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> The argument's name. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> </exception>
        public static void Negative( double argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The double '{paramName}' is negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <returns> Throws Out of Range Exception </returns>
        /// <exception cref="ArgumentOutOfRangeException"> </exception>
        public static void NegativeOrZero( int argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The integer '{paramName}' is zero or negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }

        /// <summary>
        /// Throws out of range exception if argument is less than zero
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="paramName"> Name of the parameter. </param>
        /// <returns> Throws Out of Range Exception </returns>
        /// <exception cref="ArgumentOutOfRangeException"> paramName, _message </exception>
        public static void NegativeOrZero( double argument, string paramName )
        {
            if( argument < 0 )
            {
                var _message = @$"The double '{paramName}' is zero or negative!";
                throw new ArgumentOutOfRangeException( paramName, _message );
            }
        }
    }
}