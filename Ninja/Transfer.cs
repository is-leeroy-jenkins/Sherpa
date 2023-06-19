// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Transfer.cs" company="Terry D. Eppler">
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
//   Transfer.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class Transfer
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public virtual int ID { get; set; }

        /// <summary> Gets or sets the budget level. </summary>
        /// <value> The budget level. </value>
        public virtual string BudgetLevel { get; set; }

        /// <summary> Gets or sets the document prefix. </summary>
        /// <value> The document prefix. </value>
        public virtual string DocPrefix { get; set; }

        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        public virtual string DocType { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public virtual string BFY { get; set; }

        /// <summary> Gets or sets the Ending Fiscal Year </summary>
        public virtual string Efy { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public virtual string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public virtual string RpioName { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public virtual string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public virtual string FundName { get; set; }

        /// <summary> Gets or sets the reprogramming number. </summary>
        /// <value> The reprogramming number. </value>
        public virtual string ReprogrammingNumber { get; set; }

        /// <summary> Gets or sets the control number. </summary>
        /// <value> The control number. </value>
        public virtual string ControlNumber { get; set; }

        /// <summary> Gets or sets the processed date. </summary>
        /// <value> The processed date. </value>
        public virtual DateOnly ProcessedDate { get; set; }

        /// <summary> Gets or sets the quarter. </summary>
        /// <value> The quarter. </value>
        public virtual string Quarter { get; set; }

        /// <summary> Gets or sets the line. </summary>
        /// <value> The line. </value>
        public virtual string Line { get; set; }

        /// <summary> Gets or sets the subline. </summary>
        /// <value> The subline. </value>
        public virtual string Subline { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        public virtual string AhCode { get; set; }

        /// <summary> Gets or sets the name of the ah. </summary>
        /// <value> The name of the ah. </value>
        public virtual string AhName { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        public virtual string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        public virtual string OrgName { get; set; }

        /// <summary> Gets or sets the rc code. </summary>
        /// <value> The rc code. </value>
        public virtual string RcCode { get; set; }

        /// <summary> Gets or sets the name of the rc. </summary>
        /// <value> The name of the rc. </value>
        public virtual string RcName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        public virtual string AccountCode { get; set; }

        /// <summary> Gets or sets the program area code. </summary>
        /// <value> The program area code. </value>
        public virtual string ProgramAreaCode { get; set; }

        /// <summary> Gets or sets the name of the program area. </summary>
        /// <value> The name of the program area. </value>
        public virtual string ProgramAreaName { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        public virtual string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        public virtual string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets from to. </summary>
        /// <value> From to. </value>
        public virtual string FromTo { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        public virtual string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        public virtual string BocName { get; set; }

        /// <summary> Gets or sets the NPM code. </summary>
        /// <value> The NPM code. </value>
        public virtual string NpmCode { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        public virtual double Amount { get; set; }

        /// <summary> Gets or sets the type of the resource. </summary>
        /// <value> The type of the resource. </value>
        public virtual string ResourceType { get; set; }

        /// <summary> Gets or sets the purpose. </summary>
        /// <value> The purpose. </value>
        public virtual string Purpose { get; set; }

        /// <summary> Gets or sets the extended purpose. </summary>
        /// <value> The extended purpose. </value>
        public virtual string ExtendedPurpose { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public virtual Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public virtual Provider Provider { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        public virtual DataRow Record { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        public virtual IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        protected Transfer( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        protected Transfer( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        protected Transfer( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Transfer"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        protected Transfer( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}