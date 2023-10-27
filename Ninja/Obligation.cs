// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Obligation.cs" company="Terry D. Eppler">
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
//   Obligation.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.StatusOfFunds"/>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    public class Obligation : StatusOfFunds
    {
        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        public virtual string DocumentType { get; set; }

        /// <summary> Gets or sets the document number. </summary>
        /// <value> The document number. </value>
        public virtual string DocumentNumber { get; set; }

        /// <summary> Gets or sets the document control number. </summary>
        /// <value> The document control number. </value>
        public virtual string DocumentControlNumber { get; set; }

        /// <summary> Gets or sets the reference document number. </summary>
        /// <value> The reference document number. </value>
        public virtual string ReferenceDocumentNumber { get; set; }

        /// <summary> Gets or sets the processed date. </summary>
        /// <value> The processed date. </value>
        public virtual DateOnly ProcessedDate { get; set; }

        /// <summary> Gets or sets the last activity date. </summary>
        /// <value> The last activity date. </value>
        public virtual DateOnly LastActivityDate { get; set; }

        /// <summary> Gets or sets the age. </summary>
        /// <value> The age. </value>
        public virtual int Age { get; set; }

        /// <summary> Gets or sets the foc code. </summary>
        /// <value> The foc code. </value>
        public virtual string FocCode { get; set; }

        /// <summary> Gets or sets the name of the foc. </summary>
        /// <value> The name of the foc. </value>
        public virtual string FocName { get; set; }

        /// <summary> Gets or sets the vendor code. </summary>
        /// <value> The vendor code. </value>
        public virtual string VendorCode { get; set; }

        /// <summary> Gets or sets the name of the vendor. </summary>
        /// <value> The name of the vendor. </value>
        public virtual string VendorName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Obligation"/>
        /// class.
        /// </summary>
        public Obligation( )
        {
            Source = Source.Obligations;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Obligation"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public Obligation( IQuery query )
            : base( query )
        {
            Source = Source.Obligations;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Amount = double.Parse( Record[ "Obligations" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Obligation"/>
        /// class.
        /// </summary>
        /// <param name="builder"> </param>
        public Obligation( IDataModel builder )
            : base( builder )
        {
            Source = Source.Obligations;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            AhCode = Record[ "AhCode" ].ToString( );
            AhName = Record[ "AhName" ].ToString( );
            OrgCode = Record[ "OrgCode" ].ToString( );
            OrgName = Record[ "OrgName" ].ToString( );
            AccountCode = Record[ "AccountCode" ].ToString( );
            BocCode = Record[ "BocCode" ].ToString( );
            BocName = Record[ "BocName" ].ToString( );
            Amount = double.Parse( Record[ "Obligations" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = Record[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = Record[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = Record[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = Record[ "ProgramAreaName" ].ToString( );
            NpmCode = Record[ "NpmCode" ].ToString( );
            NpmName = Record[ "NpmName" ].ToString( );
            GoalCode = Record[ "GoalCode" ].ToString( );
            GoalName = Record[ "GoalName" ].ToString( );
            ObjectiveCode = Record[ "ObjectiveCode" ].ToString( );
            ObjectiveName = Record[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Obligation"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public Obligation( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.Obligations;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            RpioCode = dataRow[ "RpioCode" ].ToString( );
            RpioName = dataRow[ "RpioName" ].ToString( );
            AhCode = dataRow[ "AhCode" ].ToString( );
            AhName = dataRow[ "AhName" ].ToString( );
            OrgCode = dataRow[ "OrgCode" ].ToString( );
            OrgName = dataRow[ "OrgName" ].ToString( );
            AccountCode = dataRow[ "AccountCode" ].ToString( );
            BocCode = dataRow[ "BocCode" ].ToString( );
            BocName = dataRow[ "BocName" ].ToString( );
            Amount = double.Parse( dataRow[ "Obligations" ].ToString( ) ?? string.Empty );
            ProgramProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            ProgramProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            ProgramAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            ProgramAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            NpmCode = dataRow[ "NpmCode" ].ToString( );
            NpmName = dataRow[ "NpmName" ].ToString( );
            GoalCode = dataRow[ "GoalCode" ].ToString( );
            GoalName = dataRow[ "GoalName" ].ToString( );
            ObjectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            ObjectiveName = dataRow[ "ObjectiveName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Obligation"/>
        /// class.
        /// </summary>
        /// <param name="obligation"> The obligation. </param>
        public Obligation( Obligation obligation )
        {
            BFY = obligation.BFY;
            EFY = obligation.EFY;
            FundCode = obligation.FundCode;
            FundName = obligation.FundName;
            RpioCode = obligation.RpioCode;
            RpioName = obligation.RpioName;
            AhCode = obligation.AhCode;
            AhName = obligation.AhName;
            OrgCode = obligation.OrgCode;
            OrgName = obligation.OrgName;
            AccountCode = obligation.AccountCode;
            BocCode = obligation.BocCode;
            BocName = obligation.BocName;
            Amount = obligation.Amount;
            Available = obligation.Available;
            ProgramProjectCode = obligation.ProgramProjectCode;
            ProgramProjectName = obligation.ProgramProjectName;
            ProgramAreaCode = obligation.ProgramAreaCode;
            ProgramAreaName = obligation.ProgramAreaName;
            NpmCode = obligation.NpmCode;
            NpmName = obligation.NpmName;
            GoalCode = obligation.GoalCode;
            GoalName = obligation.GoalName;
            ObjectiveCode = obligation.ObjectiveCode;
            ObjectiveName = obligation.ObjectiveName;
            TreasuryAccountCode = obligation.TreasuryAccountCode;
            TreasuryAccountName = obligation.TreasuryAccountName;
            BudgetAccountCode = obligation.BudgetAccountCode;
            BudgetAccountName = obligation.BudgetAccountName;
        }
    }
}