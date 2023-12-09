// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CarryoverRequest.cs" company="Terry D. Eppler">
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
//   CarryoverRequest.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.AdministrativeRequest"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CarryoverRequest : AdministrativeRequests
    {
        /// <summary> Gets or sets the original request date. </summary>
        /// <value> The original request date. </value>
        public DateOnly OriginalRequestDate { get; set; }

        /// <summary> Gets or sets the last activity date. </summary>
        /// <value> The last activity date. </value>
        public DateOnly LastActivityDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CarryoverRequest"/>
        /// class.
        /// </summary>
        public CarryoverRequest( )
        {
            Source = Source.CarryoverRequests;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public CarryoverRequest( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = Record[ nameof( Analyst ) ].ToString( );
            DocumentTitle = Record[ nameof( DocumentTitle ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            BudgetFormulationSystem = Record[ nameof( BudgetFormulationSystem ) ].ToString( );
            Comments = Record[ nameof( Comments ) ].ToString( );
            OriginalRequestDate =
                DateOnly.Parse( Record[ nameof( OriginalRequestDate ) ].ToString( ) ?? "" );

            LastActivityDate = DateOnly.Parse( Record[ nameof( LastActivityDate ) ].ToString( ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public CarryoverRequest( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = Record[ nameof( Analyst ) ].ToString( );
            DocumentTitle = Record[ nameof( DocumentTitle ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            Status = Record[ nameof( Status ) ].ToString( );
            BudgetFormulationSystem = Record[ nameof( BudgetFormulationSystem ) ].ToString( );
            Comments = Record[ nameof( Comments ) ].ToString( );
            OriginalRequestDate =
                DateOnly.Parse( Record[ nameof( OriginalRequestDate ) ].ToString( ) ?? "" );

            LastActivityDate = DateOnly.Parse( Record[ nameof( LastActivityDate ) ].ToString( ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public CarryoverRequest( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CarryoverRequestsId" ].ToString( ) ?? "0" );
            Analyst = dataRow[ nameof( Analyst ) ].ToString( );
            DocumentTitle = dataRow[ nameof( DocumentTitle ) ].ToString( );
            Amount = double.Parse( dataRow[ nameof( Amount ) ].ToString( ) ?? "0" );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            Status = dataRow[ nameof( Status ) ].ToString( );
            BudgetFormulationSystem = dataRow[ nameof( BudgetFormulationSystem ) ].ToString( );
            Comments = dataRow[ nameof( Comments ) ].ToString( );
            OriginalRequestDate =
                DateOnly.Parse( dataRow[ nameof( OriginalRequestDate ) ].ToString( ) ?? "" );

            LastActivityDate = DateOnly.Parse( dataRow[ nameof( LastActivityDate ) ].ToString( ) ?? "" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CarryoverRequest"/>
        /// class.
        /// </summary>
        /// <param name="request"> The request. </param>
        public CarryoverRequest( CarryoverRequest request )
        {
            ID = request.ID;
            Analyst = request.Analyst;
            DocumentTitle = request.DocumentTitle;
            Amount = request.Amount;
            FundCode = request.FundCode;
            Status = request.Status;
            BudgetFormulationSystem = request.BudgetFormulationSystem;
            Comments = request.Comments;
            OriginalRequestDate = request.OriginalRequestDate;
            LastActivityDate = request.LastActivityDate;
        }
    }
}