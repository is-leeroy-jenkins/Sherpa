// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="PRC.cs" company="Terry D. Eppler">
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
//   PRC.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.BudgetUnit" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public abstract class PRC : BudgetAccount
    {
        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public string ActivityCode
        {
            get
            {
                return _activityCoede;
            }
            private protected set
            {
                _activityCoede = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the activity.
        /// </summary>
        /// <value>
        /// The name of the activity.
        /// </value>
        public string ActivityName
        {
            get
            {
                return _activityName;
            }
            private protected set
            {
                _activityName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public string NpmCode
        {
            get
            {
                return _npmCode;
            }
            private protected set
            {
                _npmCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the NPM.
        /// </summary>
        /// <value>
        /// The name of the NPM.
        /// </value>
        public string NpmName
        {
            get
            {
                return _npmName;
            }
            private protected set
            {
                _npmName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the goal code.
        /// </summary>
        /// <value>
        /// The goal code.
        /// </value>
        public string GoalCode
        {
            get
            {
                return _goalCode;
            }
            private protected set
            {
                _goalCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the goal.
        /// </summary>
        /// <value>
        /// The name of the goal.
        /// </value>
        public string GoalName
        {
            get
            {
                return _goalName;
            }
            private protected set
            {
                _goalName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the objective code.
        /// </summary>
        /// <value>
        /// The objective code.
        /// </value>
        public string ObjectiveCode
        {
            get
            {
                return _objectiveCode;
            }
            private protected set
            {
                _objectiveCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the objective.
        /// </summary>
        /// <value>
        /// The name of the objective.
        /// </value>
        public string ObjectiveName
        {
            get
            {
                return _objectiveName;
            }
            private protected set
            {
                _objectiveName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public string ProgramProjectCode
        {
            get
            {
                return _programProjectCode;
            }
            private protected set
            {
                _programProjectCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the program project.
        /// </summary>
        /// <value>
        /// The name of the program project.
        /// </value>
        public string ProgramProjectName
        {
            get
            {
                return _programProjectName;
            }
            private protected set
            {
                _programProjectName = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public string ProgramAreaCode
        {
            get
            {
                return _programAreaCode;
            }
            private protected set
            {
                _programAreaCode = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the name of the program area.
        /// </summary>
        /// <value>
        /// The name of the program area.
        /// </value>
        public string ProgramAreaName
        {
            get
            {
                return _programAreaName;
            }
            private protected set
            {
                _programAreaName = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.PRC" /> class.
        /// </summary>
        protected PRC( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.PRC" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        protected PRC( IQuery query ) : base( query )
        {
            _record = new DataBuilder( query ).Record;
            _data = _record.ToDictionary( );
            _bfy = _record[ "BFY" ].ToString( );
            _efy = _record[ "EFY" ].ToString( );
            _fundCode = _record[ "FundCode" ].ToString( );
            _fundName = _record[ "FundName" ].ToString( );
            _rpioCode = _record[ "RpioCode" ].ToString( );
            _rpioName = _record[ "RpioName" ].ToString( );
            _ahCode = _record[ "AhCode" ].ToString( );
            _ahName = _record[ "AhName" ].ToString( );
            _orgCode = _record[ "OrgCode" ].ToString( );
            _orgName = _record[ "OrgName" ].ToString( );
            _accountCode = _record[ "AccountCode" ].ToString( );
            _bocCode = _record[ "BocCode" ].ToString( );
            _bocName = _record[ "BocName" ].ToString( );
            _programProjectCode = _record[ "ProgramProjectCode" ].ToString( );
            _programProjectName = _record[ "ProgramProjectName" ].ToString( );
            _programAreaCode = _record[ "ProgramAreaCode" ].ToString( );
            _programAreaName = _record[ "ProgramAreaName" ].ToString( );
            _npmCode = _record[ "NpmCode" ].ToString( );
            _npmName = _record[ "NpmName" ].ToString( );
            _goalCode = _record[ "GoalCode" ].ToString( );
            _goalName = _record[ "GoalName" ].ToString( );
            _objectiveCode = _record[ "ObjectiveCode" ].ToString( );
            _objectiveName = _record[ "ObjectiveName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.PRC" /> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        protected PRC( IDataModel dataBuilder )
        {
            _record = dataBuilder.Record;
            _data = _record.ToDictionary( );
            _bfy = _record[ "BFY" ].ToString( );
            _efy = _record[ "EFY" ].ToString( );
            _fundCode = _record[ "FundCode" ].ToString( );
            _fundName = _record[ "FundName" ].ToString( );
            _rpioCode = _record[ "RpioCode" ].ToString( );
            _rpioName = _record[ "RpioName" ].ToString( );
            _ahCode = _record[ "AhCode" ].ToString( );
            _ahName = _record[ "AhName" ].ToString( );
            _orgCode = _record[ "OrgCode" ].ToString( );
            _orgName = _record[ "OrgName" ].ToString( );
            _accountCode = _record[ "AccountCode" ].ToString( );
            _bocCode = _record[ "BocCode" ].ToString( );
            _bocName = _record[ "BocName" ].ToString( );
            _programProjectCode = _record[ "ProgramProjectCode" ].ToString( );
            _programProjectName = _record[ "ProgramProjectName" ].ToString( );
            _programAreaCode = _record[ "ProgramAreaCode" ].ToString( );
            _programAreaName = _record[ "ProgramAreaName" ].ToString( );
            _npmCode = _record[ "NpmCode" ].ToString( );
            _npmName = _record[ "NpmName" ].ToString( );
            _goalCode = _record[ "GoalCode" ].ToString( );
            _goalName = _record[ "GoalName" ].ToString( );
            _objectiveCode = _record[ "ObjectiveCode" ].ToString( );
            _objectiveName = _record[ "ObjectiveName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.PRC" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        protected PRC( DataRow dataRow )
        {
            _record = dataRow;
            _data = dataRow.ToDictionary( );
            _bfy = dataRow[ "BFY" ].ToString( );
            _efy = dataRow[ "EFY" ].ToString( );
            _fundCode = dataRow[ "FundCode" ].ToString( );
            _fundName = dataRow[ "FundName" ].ToString( );
            _rpioCode = dataRow[ "RpioCode" ].ToString( );
            _rpioName = dataRow[ "RpioName" ].ToString( );
            _ahCode = dataRow[ "AhCode" ].ToString( );
            _ahName = dataRow[ "AhName" ].ToString( );
            _orgCode = dataRow[ "OrgCode" ].ToString( );
            _orgName = dataRow[ "OrgName" ].ToString( );
            _accountCode = dataRow[ "AccountCode" ].ToString( );
            _bocCode = dataRow[ "BocCode" ].ToString( );
            _bocName = dataRow[ "BocName" ].ToString( );
            _programProjectCode = dataRow[ "ProgramProjectCode" ].ToString( );
            _programProjectName = dataRow[ "ProgramProjectName" ].ToString( );
            _programAreaCode = dataRow[ "ProgramAreaCode" ].ToString( );
            _programAreaName = dataRow[ "ProgramAreaName" ].ToString( );
            _npmCode = dataRow[ "NpmCode" ].ToString( );
            _npmName = dataRow[ "NpmName" ].ToString( );
            _goalCode = dataRow[ "GoalCode" ].ToString( );
            _goalName = dataRow[ "GoalName" ].ToString( );
            _objectiveCode = dataRow[ "ObjectiveCode" ].ToString( );
            _objectiveName = dataRow[ "ObjectiveName" ].ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.PRC" /> class.
        /// </summary>
        /// <param name="map">The map.</param>
        protected PRC( IDictionary<string, object> map )
        {
            _record = new DataBuilder( _source, map )?.Record;
            _data = _record.ToDictionary( );
            _bfy = _record[ "BFY" ].ToString( );
            _efy = _record[ "EFY" ].ToString( );
            _fundCode = _record[ "FundCode" ].ToString( );
            _fundName = _record[ "FundName" ].ToString( );
            _rpioCode = _record[ "RpioCode" ].ToString( );
            _rpioName = _record[ "RpioName" ].ToString( );
            _ahCode = _record[ "AhCode" ].ToString( );
            _ahName = _record[ "AhName" ].ToString( );
            _orgCode = _record[ "OrgCode" ].ToString( );
            _orgName = _record[ "OrgName" ].ToString( );
            _accountCode = _record[ "AccountCode" ].ToString( );
            _bocCode = _record[ "BocCode" ].ToString( );
            _bocName = _record[ "BocName" ].ToString( );
            _programProjectCode = _record[ "ProgramProjectCode" ].ToString( );
            _programProjectName = _record[ "ProgramProjectName" ].ToString( );
            _programAreaCode = _record[ "ProgramAreaCode" ].ToString( );
            _programAreaName = _record[ "ProgramAreaName" ].ToString( );
            _npmCode = _record[ "NpmCode" ].ToString( );
            _npmName = _record[ "NpmName" ].ToString( );
            _goalCode = _record[ "GoalCode" ].ToString( );
            _goalName = _record[ "GoalName" ].ToString( );
            _objectiveCode = _record[ "ObjectiveCode" ].ToString( );
            _objectiveName = _record[ "ObjectiveName" ].ToString( );
        }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public virtual string GetField( DataRow dataRow, string field )
        {
            if( ( dataRow != null )
               && !string.IsNullOrEmpty( field ) )
            {
                try
                {
                    return dataRow[ field ].ToString( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public virtual double GetAmount( DataRow dataRow, string numeric )
        {
            if( ( dataRow != null )
               && !string.IsNullOrEmpty( numeric ) )
            {
                try
                {
                    return double.Parse( dataRow[ numeric ]?.ToString( ) ?? string.Empty );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( double );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Record.ItemArray != null
                    ? Record.ToDictionary( )
                    : default( IDictionary<string, object> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}