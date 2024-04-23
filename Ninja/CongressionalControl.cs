// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CongressionalControl.cs" company="Terry D. Eppler">
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
//   CongressionalControl.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class CongressionalControl : BudgetUnit
    {
        private string _programAreaCode;
        
        private string _programAreaName;
        
        private string _programProjectCode;

        private string _programProjectName;
        
        private string _subProjectCode;
        
        private string _subProjectName;
        
        private bool _reprogrammingRestriction;
        
        private bool _increaseRestriction;

        private bool _decreaseRestriction;
        
        private bool _memoRequirement;

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
                return _subProjectName;
            }
            private set
            {
                _subProjectName = value;
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
                return _subProjectName;
            }
            private set
            {
                _subProjectName = value;
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
                return _subProjectName;
            }
            private set
            {
                _subProjectName = value;
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
                return _subProjectName;
            }
            private set
            {
                _subProjectName = value;
            }
        }

        /// <summary>
        /// Gets or sets the sub project code.
        /// </summary>
        /// <value>
        /// The sub project code.
        /// </value>
        public string SubProjectCode
        {
            get
            {
                return _subProjectName;
            }
            private set
            {
                _subProjectName = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the sub project.
        /// </summary>
        /// <value>
        /// The name of the sub project.
        /// </value>
        public string SubProjectName
        {
            get
            {
                return _subProjectName;
            }
            private set
            {
                _subProjectName = value;
            }
        }

        /// <summary>
        /// Gets or sets the reprogramming restriction.
        /// </summary>
        /// <value>
        /// The reprogramming restriction.
        /// </value>
        public bool ReprogrammingRestriction
        {
            get
            {
                return _memoRequirement;
            }
            private set
            {
                _memoRequirement = value;
            }
        }

        /// <summary>
        /// Gets or sets the increase restriction.
        /// </summary>
        /// <value>
        /// The increase restriction.
        /// </value>
        public bool IncreaseRestriction
        {
            get
            {
                return _memoRequirement;
            }
            private set
            {
                _memoRequirement = value;
            }
        }

        /// <summary>
        /// Gets or sets the decrease restriction.
        /// </summary>
        /// <value>
        /// The decrease restriction.
        /// </value>
        public bool DecreaseRestriction
        {
            get
            {
                return _memoRequirement;
            }
            private set
            {
                _memoRequirement = value;
            }
        }

        /// <summary>
        /// Gets or sets the memo requirement.
        /// </summary>
        /// <value>
        /// The memo requirement.
        /// </value>
        public bool MemoRequirement
        {
            get
            {
                return _memoRequirement;
            }
            private set
            {
                _memoRequirement = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CongressionalControl" />
        /// class.
        /// </summary>
        public CongressionalControl( ) 
            : base( )
        {
            _source = Source.CongressionalControls;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CongressionalControl" />
        /// class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CongressionalControl( IQuery query )
            : base( query )
        {
            _record = new DataBuilder( query ).Record;
            _map = _record.ToDictionary( );
            _id = int.Parse( _record["CongressionalControlsId" ]?.ToString( ) ?? "0" );
            _fundCode = _record["FundCode" ]?.ToString( );
            _fundName = _record["FundName" ]?.ToString( );
            _programProjectCode = _record["ProgramProjectCode" ]?.ToString( );
            _programProjectName = _record["ProgramProjectName" ]?.ToString( );
            _subProjectCode = _record["SubProjectCode" ]?.ToString( );
            _subProjectName = _record["SubProjectName" ]?.ToString( );
            _programAreaCode = _record["ProgramAreaCode" ]?.ToString( );
            _programAreaName = _record["ProgramAreaName" ]?.ToString( );
            _increaseRestriction = bool.Parse( _record["IncreaseRestriction" ]?.ToString( ) );
            _decreaseRestriction = bool.Parse( _record["DecreaseRestriction" ]?.ToString( ) );
            _memoRequirement = bool.Parse( _record[ "MemoRequirement" ]?.ToString( ) );
            _reprogrammingRestriction = 
                bool.Parse( _record[ "ReprogrammingRestriction" ]?.ToString( ) );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CongressionalControl" />
        /// class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CongressionalControl( IDataModel builder )
            : base( builder )
        {
            _record = builder.Record;
            _map = _record.ToDictionary( );
            _id = int.Parse( _record[ "CongressionalControlsId" ]?.ToString( ) ?? "0" );
            _fundCode = _record[ "FundCode" ]?.ToString( );
            _fundName = _record[ "FundName" ]?.ToString( );
            _programProjectCode = _record[ "ProgramProjectCode" ]?.ToString( );
            _programProjectName = _record[ "ProgramProjectName" ]?.ToString( );
            _subProjectCode = _record[ "SubProjectCode" ]?.ToString( );
            _subProjectName = _record[ "SubProjectName" ]?.ToString( );
            _programAreaCode = _record[ "ProgramAreaCode" ]?.ToString( );
            _programAreaName = _record[ "ProgramAreaName" ]?.ToString( );
            _increaseRestriction = bool.Parse( _record[ "IncreaseRestriction" ]?.ToString( ) );
            _decreaseRestriction = bool.Parse( _record[ "DecreaseRestriction" ]?.ToString( ) );
            _memoRequirement = bool.Parse( _record[ "MemoRequirement" ]?.ToString( ) );
            _reprogrammingRestriction =
                bool.Parse( _record[ "ReprogrammingRestriction" ]?.ToString( ) );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CongressionalControl" />
        /// class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CongressionalControl( DataRow dataRow )
            : base( dataRow )
        {
            _record = dataRow;
            _map = dataRow.ToDictionary( );
            _id = int.Parse( dataRow[ "CongressionalControlsId" ]?.ToString( ) ?? "0" );
            _fundCode = dataRow[ "FundCode" ]?.ToString( );
            _fundName = dataRow[ "FundName" ]?.ToString( );
            _programProjectCode = dataRow[ "ProgramProjectCode" ]?.ToString( );
            _programProjectName = dataRow[ "ProgramProjectName" ]?.ToString( );
            _subProjectCode = dataRow[ "SubProjectCode" ]?.ToString( );
            _subProjectName = dataRow[ "SubProjectName" ]?.ToString( );
            _programAreaCode = dataRow[ "ProgramAreaCode" ]?.ToString( );
            _programAreaName = dataRow[ "ProgramAreaName" ]?.ToString( );
            _increaseRestriction = bool.Parse( dataRow[ "IncreaseRestriction" ]?.ToString( ) );
            _decreaseRestriction = bool.Parse( dataRow[ "DecreaseRestriction" ]?.ToString( ) );
            _memoRequirement = bool.Parse( dataRow[ "MemoRequirement" ]?.ToString( ) );
            _reprogrammingRestriction =
                bool.Parse( dataRow[ "ReprogrammingRestriction" ]?.ToString( ) );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CongressionalControl" />
        /// class.
        /// </summary>
        /// <param name="control">The control.</param>
        public CongressionalControl( CongressionalControl control ) 
            : base( )
        {
            _id = control.ID;
            _fundCode = control.FundCode;
            _fundName = control.FundName;
            _programProjectCode = control.ProgramProjectCode;
            _programProjectName = control.ProgramProjectName;
            _subProjectCode = control.SubProjectCode;
            _subProjectName = control.SubProjectName;
            _programAreaCode = control.ProgramAreaCode;
            _programAreaName = control.ProgramAreaName;
            _reprogrammingRestriction = control.ReprogrammingRestriction;
            _increaseRestriction = control.IncreaseRestriction;
            _decreaseRestriction = control.DecreaseRestriction;
            _memoRequirement = control.MemoRequirement;
        }
    }
}