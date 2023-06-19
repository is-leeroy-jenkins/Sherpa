// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ObjectClassOutlay.cs" company="Terry D. Eppler">
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
//   ObjectClassOutlay.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ObjectClassOutlay
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the report year.
        /// </summary>
        /// <value>
        /// The report year.
        /// </value>
        public string ReportYear { get; set; }

        /// <summary>
        /// Gets or sets the treasury agency code.
        /// </summary>
        /// <value>
        /// The treasury agency code.
        /// </value>
        public string TreasuryAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury bureau code.
        /// </summary>
        /// <value>
        /// The treasury bureau code.
        /// </value>
        public string TreasuryBureauCode { get; set; }

        /// <summary>
        /// Gets or sets the budget agency code.
        /// </summary>
        /// <value>
        /// The budget agency code.
        /// </value>
        public string BudgetAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget agency.
        /// </summary>
        /// <value>
        /// The name of the budget agency.
        /// </value>
        public string BudgetAgencyName { get; set; }

        /// <summary>
        /// Gets or sets the budget bureau code.
        /// </summary>
        /// <value>
        /// The budget bureau code.
        /// </value>
        public string BudgetBureauCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget bureau.
        /// </summary>
        /// <value>
        /// The name of the budget bureau.
        /// </value>
        public string BudgetBureauName { get; set; }

        /// <summary>
        /// Gets or sets the budget account code.
        /// </summary>
        /// <value>
        /// The budget account code.
        /// </value>
        public string BudgetAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the budget account.
        /// </summary>
        /// <value>
        /// The name of the budget account.
        /// </value>
        public string BudgetAccountName { get; set; }

        /// <summary>
        /// Gets or sets the direct reimbursable.
        /// </summary>
        /// <value>
        /// The direct reimbursable.
        /// </value>
        public string DirectReimbursable { get; set; }

        /// <summary>
        /// Gets or sets the direct reimbursable title.
        /// </summary>
        /// <value>
        /// The direct reimbursable title.
        /// </value>
        public string DirectReimbursableTitle { get; set; }

        /// <summary>
        /// Gets or sets the object class group number.
        /// </summary>
        /// <value>
        /// The object class group number.
        /// </value>
        public string ObjectClassGroupNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the object class group.
        /// </summary>
        /// <value>
        /// The name of the object class group.
        /// </value>
        public string ObjectClassGroupName { get; set; }

        /// <summary>
        /// Gets or sets the finance object class.
        /// </summary>
        /// <value>
        /// The finance object class.
        /// </value>
        public string FinanceObjectClass { get; set; }

        /// <summary>
        /// Gets or sets the prior year.
        /// </summary>
        /// <value>
        /// The prior year.
        /// </value>
        public double PriorYear { get; set; }

        /// <summary>
        /// Gets or sets the current year.
        /// </summary>
        /// <value>
        /// The current year.
        /// </value>
        public double CurrentYear { get; set; }

        /// <summary>
        /// Gets or sets the budget year.
        /// </summary>
        /// <value>
        /// The budget year.
        /// </value>
        public double BudgetYear { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        public ObjectClassOutlay( )
        {
            Source = Source.ObjectClassOutlays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ObjectClassOutlay( IQuery query )
        {
            Source = query.Source;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ObjectClassOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = Record[ "ReportYear" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgencyCode" ].ToString( );
            TreasuryBureauCode = Record[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = Record[ "BudgetAgencyCode" ].ToString( );
            BudgetBureauCode = Record[ "BudgetBureauCode" ].ToString( );
            BudgetBureauName = Record[ "BudgetBureauName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            DirectReimbursable = Record[ "DirectReimbursable" ].ToString( );
            ObjectClassGroupNumber = Record[ "ObjectClassGroupNumber" ].ToString( );
            ObjectClassGroupName = Record[ "ObjectClassGroupName" ].ToString( );
            FinanceObjectClass = Record[ "FinanceObjectClass" ].ToString( );
            PriorYear = double.Parse( Record[ "PriorYear" ].ToString( ) ?? "0" );
            CurrentYear = double.Parse( Record[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = double.Parse( Record[ "BudgetYear" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ObjectClassOutlay( IDataModel builder )
        {
            Source = builder.Source;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ObjectClassOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = Record[ "ReportYear" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgencyCode" ].ToString( );
            TreasuryBureauCode = Record[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = Record[ "BudgetAgencyCode" ].ToString( );
            BudgetBureauCode = Record[ "BudgetBureauCode" ].ToString( );
            BudgetBureauName = Record[ "BudgetBureauName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            DirectReimbursable = Record[ "DirectReimbursable" ].ToString( );
            ObjectClassGroupNumber = Record[ "ObjectClassGroupNumber" ].ToString( );
            ObjectClassGroupName = Record[ "ObjectClassGroupName" ].ToString( );
            FinanceObjectClass = Record[ "FinanceObjectClass" ].ToString( );
            PriorYear = double.Parse( Record[ "PriorYear" ].ToString( ) ?? "0" );
            CurrentYear = double.Parse( Record[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = double.Parse( Record[ "BudgetYear" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectClassOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public ObjectClassOutlay( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "ObjectClassOutlaysId" ].ToString( ) ?? "0" );
            ReportYear = dataRow[ "ReportYear" ].ToString( );
            TreasuryAgencyCode = dataRow[ "TreasuryAgencyCode" ].ToString( );
            TreasuryBureauCode = dataRow[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = dataRow[ "BudgetAgencyCode" ].ToString( );
            BudgetBureauCode = dataRow[ "BudgetBureauCode" ].ToString( );
            BudgetBureauName = dataRow[ "BudgetBureauName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            DirectReimbursable = dataRow[ "DirectReimbursable" ].ToString( );
            ObjectClassGroupNumber = dataRow[ "ObjectClassGroupNumber" ].ToString( );
            ObjectClassGroupName = dataRow[ "ObjectClassGroupName" ].ToString( );
            FinanceObjectClass = dataRow[ "FinanceObjectClass" ].ToString( );
            PriorYear = double.Parse( dataRow[ "PriorYear" ].ToString( ) ?? "0" );
            CurrentYear = double.Parse( dataRow[ "CurrentYear" ].ToString( ) ?? "0" );
            BudgetYear = double.Parse( dataRow[ "BudgetYear" ].ToString( ) ?? "0" );
        }
    }
}