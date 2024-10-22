﻿//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                BudgetObjectClasses.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="BudgetObjectClasses.cs" company="Terry D. Eppler">
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
//    BudgetObjectClasses.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Sherpa.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "MissingBlankLines" ) ]
    [ SuppressMessage( "ReSharper", "MissingSpace" ) ]
    public class BudgetObjectClass : DataUnit
    {
        /// <summary>
        /// The category
        /// </summary>
        private BOC _category;

        /// <summary>
        /// The codes
        /// </summary>
        public readonly IEnumerable<string> Codes = new[ ]
        {
            "10",
            "17",
            "21",
            "28",
            "36",
            "37",
            "38",
            "41"
        };

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public BOC Category
        {
            get
            {
                return _category;
            }
            private set
            {
                _category = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClasses" /> class.
        /// </summary>
        public BudgetObjectClass( )
            : base( )
        {
            _source = Source.BudgetObjectClasses;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClasses" /> class.
        /// </summary>
        /// <param name="boc">The boc.</param>
        public BudgetObjectClass( BOC boc )
            : this( )
        {
            _record = new DataBuilder( _source, SetArgs( boc ) )?.Record;
            _id = int.Parse( _record[ "BudgetObjectClassesId" ]?.ToString( ) ?? "0.0" );
            _name = _record[ "BocName" ]?.ToString( );
            _code = _record[ "BocCode" ]?.ToString( );
            _category = boc;
            _map = _record?.ToDictionary( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClasses" /> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public BudgetObjectClass( string code )
            : this( )
        {
            _record = new DataBuilder( _source, SetArgs( code ) )?.Record;
            _id = int.Parse( _record[ "BudgetObjectClassesId" ]?.ToString( ) ?? "0" );
            _name = _record[ "BocName" ]?.ToString( );
            _code = _record[ "BocCode" ]?.ToString( );
            _map = _record?.ToDictionary( );
            if( !string.IsNullOrEmpty( _name ) )
            {
                _category = (BOC)Enum.Parse( typeof( BOC ), _name );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClasses" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetObjectClass( IQuery query )
            : base( query )
        {
            _record = new DataBuilder( query )?.Record;
            _id = int.Parse( _record[ "BudgetObjectClassesId" ]?.ToString( ) ?? "0" );
            _name = _record[ "BocName" ]?.ToString( );
            _code = _record[ "BocCode" ]?.ToString( );
            _map = _record?.ToDictionary( );
            if( !string.IsNullOrEmpty( _name ) )
            {
                _category = (BOC)Enum.Parse( typeof( BOC ), _name );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClasses" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetObjectClass( IDataModel builder )
            : base( builder )
        {
            _record = builder.Record;
            _id = int.Parse( _record[ "BudgetObjectClassesId" ]?.ToString( ) ?? "0" );
            _name = _record[ "BocName" ]?.ToString( );
            _code = _record[ "BocCode" ]?.ToString( );
            _map = _record?.ToDictionary( );
            if( !string.IsNullOrEmpty( _name ) )
            {
                _category = (BOC)Enum.Parse( typeof( BOC ), _name );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClasses" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetObjectClass( DataRow dataRow )
            : base( dataRow )
        {
            _record = dataRow;
            _id = int.Parse( dataRow[ "BudgetObjectClassesId" ].ToString( ) ?? "0" );
            _name = dataRow[ "BocName" ].ToString( );
            _code = dataRow[ "BocCode" ].ToString( );
            _map = dataRow?.ToDictionary( );
            if( !string.IsNullOrEmpty( _name ) )
            {
                _category = (BOC)Enum.Parse( typeof( BOC ), _name );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.BudgetObjectClass" /> class.
        /// </summary>
        /// <param name="boc">The boc.</param>
        public BudgetObjectClass( BudgetObjectClass boc )
            : this( )
        {
            _id = boc.ID;
            _code = boc.Code;
            _name = boc.Name;
            _category = boc.Category;
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Map?.Any( ) == true
                    ? Map
                    : default( IDictionary<string, object> );
            }
            catch( Exception _ex )
            {
                BudgetObjectClass.Fail( _ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <param name="prc">The PRC.</param>
        /// <returns></returns>
        public double GetAmount( IProgramResultsCode prc )
        {
            try
            {
                var _amount = prc.Amount;
                return _amount > -1
                    ? _amount
                    : 0;
            }
            catch( Exception _ex )
            {
                BudgetObjectClass.Fail( _ex );
                return -1D;
            }
        }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <returns></returns>
        public double GetAmount( )
        {
            try
            {
                return Value != null
                    ? double.Parse( Value?.ToString( ) ?? "0.0" )
                    : 0.0;
            }
            catch( Exception _ex )
            {
                BudgetObjectClass.Fail( _ex );
                return default( double );
            }
        }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <returns></returns>
        public BOC GetCategory( )
        {
            try
            {
                return !string.IsNullOrEmpty( Name ) && Enum.IsDefined( typeof( BOC ), Name )
                    ? (BOC)Enum.Parse( typeof( BOC ), Name )
                    : default( BOC );
            }
            catch( Exception _ex )
            {
                BudgetObjectClass.Fail( _ex );
                return default( BOC );
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
        private IDictionary<string, object> SetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code )
               && code.Length == 2
               && Codes.Contains( code ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ "Code" ] = code
                    };
                }
                catch( Exception _ex )
                {
                    BudgetObjectClass.Fail( _ex );
                    return default( IDictionary<string, object> );
                }
            }
            else if( !string.IsNullOrEmpty( code )
                    && code.Length > 2
                    && Enum.GetNames( typeof( BOC ) ).Contains( code ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ "Name" ] = code
                    };
                }
                catch( Exception _ex )
                {
                    BudgetObjectClass.Fail( _ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="boc">The boc.</param>
        /// <returns></returns>
        private IDictionary<string, object> SetArgs( BOC boc )
        {
            if( !string.IsNullOrEmpty( boc.ToString( ) )
               && boc.ToString( ).Length == 2
               && Codes.Contains( boc.ToString( ) ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ "Code" ] = boc.ToString( )
                    };
                }
                catch( Exception _ex )
                {
                    BudgetObjectClass.Fail( _ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}