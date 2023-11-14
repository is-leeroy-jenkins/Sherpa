// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetContact.cs" company="Terry D. Eppler">
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
//   BudgetContact.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InheritdocConsiderUsage" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetContacts : DataUnit
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the rpio.
        /// </summary>
        /// <value>
        /// The rpio.
        /// </value>
        public string RPIO { get; set; }

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        /// <value>
        /// The section.
        /// </value>
        public string Section { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetContacts"/> class.
        /// </summary>
        public BudgetContacts( )
        {
            Source = Source.BudgetContacts;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetContacts"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetContacts( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString( );
            LastName = Record[ "LastName" ].ToString( );
            FullName = Record[ "FullName" ].ToString( );
            RPIO = Record[ "RPIO" ].ToString( );
            EmailAddress = Record[ "EmailAddress" ].ToString( );
            Section = Record[ "Section" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetContacts"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetContacts( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = builder.Record.ToDictionary( );
            ID = int.Parse( builder.Record[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = builder.Record[ "FirstName" ].ToString( );
            LastName = builder.Record[ "LastName" ].ToString( );
            FullName = builder.Record[ "FullName" ].ToString( );
            RPIO = builder.Record[ "RPIO" ].ToString( );
            EmailAddress = builder.Record[ "EmailAddress" ].ToString( );
            Section = builder.Record[ "Section" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetContacts"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetContacts( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = dataRow[ "FirstName" ].ToString( );
            LastName = dataRow[ "LastName" ].ToString( );
            FullName = dataRow[ "FullName" ].ToString( );
            RPIO = dataRow[ "RPIO" ].ToString( );
            EmailAddress = dataRow[ "EmailAddress" ].ToString( );
            Section = dataRow[ "Section" ].ToString( );
        }
    }
}