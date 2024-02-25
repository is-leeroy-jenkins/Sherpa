//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                Account.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Account.cs" company="Terry D. Eppler">
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
//    Account.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.PRC" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class Account : PRC
    {
        /// <summary>
        /// Gets or sets the agency activity.
        /// </summary>
        /// <value> The agency activity. </value>
        public string AgencyActivity { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Account"/>
        /// class.
        /// </summary>
        public Account( )
        {
            Source = Source.Accounts;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Account"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Account( IQuery query )
            : base( query )
        {
            Source = Source.Accounts;
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString( ) );
            NpmCode = Record[ "NpmCode" ].ToString( );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ActivityCode = Record[ "ActivityCode" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ActivityCode = Record[ "ActivityCode" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Account"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The data builder. </param>
        public Account( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Source = Source.Accounts;
            Record = dataBuilder?.Record;
            ID = int.Parse( Record?[ "AccountsId" ]?.ToString( ) );
            GoalCode = Record?[ "GoalCode" ].ToString( );
            GoalName = Record?[ "GoalName" ].ToString( );
            ObjectiveCode = Record?[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record?[ "ObjectiveName" ].ToString( );
            NpmCode = Record?[ "NpmCode" ].ToString( );
            NpmName = Record?[ "NpmName" ].ToString( );
            ProgramProjectCode = Record?[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record?[ "ProgramProjectName" ].ToString( );
            ActivityCode = Record?[ "ActivityCode" ].ToString( );
            ActivityName = Record?[ "ActivityName" ].ToString( );
            ProgramAreaCode = Record?[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record?[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Account"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Account( DataRow dataRow )
        {
            Source = Source.Accounts;
            Record = dataRow;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString( ) );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
            NpmName = dataRow[ "NpmName" ].ToString( );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ActivityCode = dataRow[ "ActivityCode" ].ToString( );
            ActivityName = dataRow[ "ActivityName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Account"/>
        /// class.
        /// </summary>
        /// <param name="code">
        /// The code.
        /// </param>
        public Account( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = int.Parse( Record[ "AccountsId" ]?.ToString( ) );
            GoalCode = Record?[ "GoalCode" ].ToString( );
            GoalName = Record?[ "GoalName" ].ToString( );
            ObjectiveCode = Record?[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record?[ "ObjectiveName" ].ToString( );
            NpmCode = Record?[ "NpmCode" ].ToString( );
            NpmName = Record?[ "NpmName" ].ToString( );
            ProgramProjectCode = Record?[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record?[ "ProgramProjectName" ].ToString( );
            ActivityCode = Record?[ "ActivityCode" ].ToString( );
            ActivityName = Record?[ "ActivityName" ].ToString( );
            ProgramAreaCode = Record?[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record?[ "ProgramAreaName" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Account"/>
        /// class.
        /// </summary>
        /// <param name="account"> The account. </param>
        public Account( Account account )
        {
            ID = account.ID;
            GoalCode = account.GoalCode;
            GoalName = account.GoalName;
            ObjectiveCode = account.ObjectiveCode;
            ObjectiveName = account.ObjectiveName;
            NpmCode = account.NpmCode;
            NpmName = account.NpmName;
            ProgramProjectCode = account.ProgramProjectCode;
            ProgramProjectName = account.ProgramProjectName;
            ActivityCode = account.ActivityCode;
            ActivityName = account.ActivityName;
            ProgramAreaCode = account.ProgramProjectCode;
            ProgramAreaName = account.ProgramAreaName;
        }

        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        public Account GetAccount( )
        {
            try
            {
                return (Account)MemberwiseClone( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Account );
            }
        }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <param name="code">
        /// The code.
        /// </param>
        /// <returns> </returns>
        private protected IDictionary<string, object> GetArgs( string code )
        {
            try
            {
                ThrowIf.Null( code, nameof( code ) );
                return new Dictionary<string, object>
                {
                    [ "Code" ] = code
                };
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}