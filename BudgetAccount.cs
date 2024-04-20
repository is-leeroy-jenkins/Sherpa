// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 04-20-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        04-20-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Budget Execution is a small Federal Budget, Finance, and Accounting data management
//    application for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   BudgetAccount.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class BudgetAccount : BudgetUnit
    {
        /// <summary>
        /// The budget level
        /// </summary>
        private protected string _budgetLevel;
        
        /// <summary>
        /// The rpio code
        /// </summary>
        private protected string _rpioCode;
        
        /// <summary>
        /// The rpio name
        /// </summary>
        private protected string _rpioName;
        
        /// <summary>
        /// The ah code
        /// </summary>
        private protected string _ahCode;
        
        /// <summary>
        /// The ah name
        /// </summary>
        private protected string _ahName;
        
        /// <summary>
        /// The org code
        /// </summary>
        private protected string _orgCode;
        
        /// <summary>
        /// The org name
        /// </summary>
        private protected string _orgName;
        
        /// <summary>
        /// The account code
        /// </summary>
        private protected string _accountCode;
        
        /// <summary>
        /// The boc code
        /// </summary>
        private protected string _bocCode;
        
        /// <summary>
        /// The boc name
        /// </summary>
        private protected string _bocName;
        
        /// <summary>
        /// The rc code
        /// </summary>
        private protected string _rcCode;
        
        /// <summary>
        /// The rc name
        /// </summary>
        private protected string _rcName;
        
        /// <summary>
        /// The activity coede
        /// </summary>
        private protected string _activityCoede;
        
        /// <summary>
        /// The activity name
        /// </summary>
        private protected string _activityName;
        
        /// <summary>
        /// The NPM code
        /// </summary>
        private protected string _npmCode;
        
        /// <summary>
        /// The NPM name
        /// </summary>
        private protected string _npmName;
        
        /// <summary>
        /// The goal code
        /// </summary>
        private protected string _goalCode;
        
        /// <summary>
        /// The goal name
        /// </summary>
        private protected string _goalName;
        
        /// <summary>
        /// The objective code
        /// </summary>
        private protected string _objectiveCode;
        
        /// <summary>
        /// The objective name
        /// </summary>
        private protected string _objectiveName;
        
        /// <summary>
        /// The program project code
        /// </summary>
        private protected string _programProjectCode;
        
        /// <summary>
        /// The program project name
        /// </summary>
        private protected string _programProjectName;
        
        /// <summary>
        /// The program area code
        /// </summary>
        private protected string _programAreaCode;
        
        /// <summary>
        /// The program area name
        /// </summary>
        private protected string _programAreaName;
        
        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public string BudgetLevel
        {
            get
            {
                return _budgetLevel;
            }
            private protected set
            {
                _budgetLevel = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public string RpioCode
        {
            get
            {
                return _rpioCode;
            }
            private protected set
            {
                _rpioCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the rpio.
        /// </summary>
        /// <value>
        /// The name of the rpio.
        /// </value>
        public string RpioName
        {
            get
            {
                return _rpioName;
            }
            private protected set
            {
                _rpioName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public string AhCode
        {
            get
            {
                return _ahCode;
            }
            private protected set
            {
                _ahCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the ah.
        /// </summary>
        /// <value>
        /// The name of the ah.
        /// </value>
        public string AhName
        {
            get
            {
                return _ahName;
            }
            private protected set
            {
                _ahCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public string OrgCode
        {
            get
            {
                return _orgCode;
            }
            private protected set
            {
                _orgCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the org.
        /// </summary>
        /// <value>
        /// The name of the org.
        /// </value>
        public string OrgName
        {
            get
            {
                return _orgName;
            }
            private protected set
            {
                _orgName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public string AccountCode
        {
            get
            {
                return _accountCode;
            }
            private protected set
            {
                _accountCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public string BocCode
        {
            get
            {
                return _bocCode;
            }
            private protected set
            {
                _bocCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the boc.
        /// </summary>
        /// <value>
        /// The name of the boc.
        /// </value>
        public string BocName
        {
            get
            {
                return _bocName;
            }
            private protected set
            {
                _bocName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public string RcCode
        {
            get
            {
                return _rcCode;
            }
            private protected set
            {
                _rcCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the rc.
        /// </summary>
        /// <value>
        /// The name of the rc.
        /// </value>
        public string RcName
        {
            get
            {
                return _rcName;
            }
            private protected set
            {
                _rcName = value;
            }
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetAccount" /> class.
        /// </summary>
        protected BudgetAccount( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetAccount"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <inheritdoc />
        protected BudgetAccount( IQuery query )
        {
            _budgetLevel = _record[ "BudgetLevel" ].ToString( );
            _rpioCode = _record[ "RpioCode" ].ToString( );
            _rpioName = _record[ "RpioName" ].ToString( ); 
            _orgCode = _record[ "OrgCode" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetAccount"/> class.
        /// </summary>
        /// <param name="dataBuilder">The query.</param>
        /// <inheritdoc />
        protected BudgetAccount( IDataModel dataBuilder )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetAccount"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <inheritdoc />
        protected BudgetAccount( DataRow dataRow )
        {
        }
    }
}