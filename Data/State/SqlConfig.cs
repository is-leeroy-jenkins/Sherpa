﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 06-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-11-2023
// ******************************************************************************************
// <copyright file="SqlConfig.cs" company="Terry D. Eppler">
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
//   SqlConfig.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using OpenTK.Platform.Windows;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class SqlConfig
    {
        /// <summary>
        /// 
        /// </summary>
        private protected Command _commandType;

        /// <summary>
        /// 
        /// </summary>
        private protected EXT _extension;

        /// <summary> Gets or sets the type of the command. </summary>
        /// <value> The type of the command. </value>
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

        /// <summary> Gets or sets the extension. </summary>
        /// <value> The extension. </value>
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

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlConfig"/>
        /// class.
        /// </summary>
        public SqlConfig( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlConfig"/>
        /// class.
        /// </summary>
        /// <param name="command"> The command. </param>
        /// <param name="extension"> The extension. </param>
        public SqlConfig( Command command, EXT extension )
        {
            _commandType = command;
            _extension = extension;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlConfig"/>
        /// class.
        /// </summary>
        /// <param name="sqlConfig"> The command. </param>
        public SqlConfig( SqlConfig sqlConfig )
        {
            _commandType = sqlConfig.CommandType;
            _extension = sqlConfig.Extension;
        }
        
        /// <summary> Deconstructs the specified command type. </summary>
        /// <param name="commandType"> Type of the command. </param>
        /// <param name="extension"> The extension. </param>
        public void Deconstruct( out Command commandType, out EXT extension )
        {
            commandType = _commandType;
            extension = _extension;
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
                return $"{_commandType}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}