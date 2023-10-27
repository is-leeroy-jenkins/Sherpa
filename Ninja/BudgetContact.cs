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
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.DataUnit"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InheritdocConsiderUsage" ) ]
    public class BudgetContact : DataUnit
    {
        /// <summary> Gets or sets the first name. </summary>
        /// <value> The first name. </value>
        public string FirstName { get; set; }

        /// <summary> Gets or sets the last name. </summary>
        /// <value> The last name. </value>
        public string LastName { get; set; }

        /// <summary> Gets or sets the full name. </summary>
        /// <value> The full name. </value>
        public string FullName { get; set; }

        /// <summary> Gets or sets the email address. </summary>
        /// <value> The email address. </value>
        public string EmailAddress { get; set; }

        /// <summary> Gets or sets the rpio. </summary>
        /// <value> The rpio. </value>
        public string RPIO { get; set; }

        /// <summary> Gets or sets the section. </summary>
        /// <value> The section. </value>
        public string Section { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetContact"/>
        /// class.
        /// </summary>
        public BudgetContact( )
        {
            Source = Source.BudgetContacts;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetContact"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public BudgetContact( IQuery query )
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

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetContact"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public BudgetContact( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ContactsId" ].ToString( ) ?? "0" );
            FirstName = Record[ "FirstName" ].ToString( );
            LastName = Record[ "LastName" ].ToString( );
            FullName = Record[ "FullName" ].ToString( );
            RPIO = Record[ "RPIO" ].ToString( );
            EmailAddress = Record[ "EmailAddress" ].ToString( );
            Section = Record[ "Section" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetContact"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public BudgetContact( DataRow dataRow )
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