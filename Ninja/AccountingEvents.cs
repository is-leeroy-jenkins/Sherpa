// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AccountingEvent.cs" company="Terry D. Eppler">
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
//   AccountingEvent.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.DataUnit"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class AccountingEvent : DataUnit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccountingEvent"/>
        /// class.
        /// </summary>
        public AccountingEvent( )
        {
            Source = Source.AccountingEvents;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public AccountingEvent( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public AccountingEvent( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = Record.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public AccountingEvent( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = int.Parse( Record[ "AccountingEventsId" ].ToString( ) ?? "0" );
            Code = Record[ "Code" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Data = dataRow.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccountingEvent"/>
        /// class.
        /// </summary>
        /// <param name="accountingEvent"> The accounting event. </param>
        public AccountingEvent( AccountingEvent accountingEvent )
        {
            ID = accountingEvent.ID;
            Code = accountingEvent.Code;
            Name = accountingEvent.Name;
        }
    }
}