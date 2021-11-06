﻿// <copyright file = "CostAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// </summary>
    /// <seealso cref = "Cost"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CostAccount : Cost, ICostAccount
    {
        /// <summary>
        /// The ProgramResultCodes
        /// </summary>
        private readonly IProgramResultsCode _prc;
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "CostAccount"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public CostAccount( DataRow dataRow )
        {
            Record = dataRow;
            _prc = new ProgramResultsCode( dataRow );
            ID = new Key( Record, PrimaryKey.PrcId );
            _npmCode = new Element( Record, Field.NpmCode );
            _programProjectCode = new Element( Record, Field.ProgramProjectCode );
            _programAreaCode = new Element( Record, Field.ProgramAreaCode );
            _focCode = new Element( Record, Field.FocCode );
            _focName = new Element( Record, Field.FocName );
            _documentType = new Element( Record, Field.DocumentType );
            _documentPrefix = new Element( Record, Field.DocumentPrefix );
            _dcn = new Element( Record, Field.DocumentType );
            _originalActionDate = new Time( Record, EventDate.OriginalActionDate );
            _obligatingDocumentNumber = new Element( Record, Field.ObligatingDocumentNumber );
            _system = new Element( Record, Field.System );
            _transactionNumber = new Element( Record, Field.TransactionNumber );
            _grantNumber = new Element( Record, Field.GrantNumber );
            _commitments = new Amount( Record, Numeric.Commitments );
            _openCommitments = new Amount( Record, Numeric.OpenCommitments );
            _obligations = new Amount( Record, Numeric.Obligations );
            _deobligations = new Amount( Record, Numeric.Deobligations );
            _ulo = new Amount( Record, Numeric.ULO );
            _balance = new Amount( Record, Numeric.Balance );
            _data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Gets the ProgramResultCodes identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IKey GetId()
        {
            try
            {
                return Verify.Key( ID )
                    ? ID
                    : default( IKey );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IKey );
            }
        }

        /// <summary>
        /// Gets the finance object class.
        /// </summary>
        /// <returns>
        /// </returns>
        public IFinanceObjectClass GetFinanceObjectClass()
        {
            try
            {
                var _code = _focCode?.GetValue();

                return Verify.Input( _code )
                    ? new FinanceObjectClass( _code )
                    : default( FinanceObjectClass );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IFinanceObjectClass );
            }
        }

        /// <summary>
        /// Gets the national program.
        /// </summary>
        /// <returns>
        /// </returns>
        public INationalProgram GetNationalProgram()
        {
            try
            {
                return Verify.Input( _npmCode?.GetValue() )
                    ? new NationalProgram( _npmCode?.GetValue() )
                    : default( NationalProgram );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( INationalProgram );
            }
        }

        /// <summary>
        /// Gets the program results code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramResultsCode GetProgramResultsCode()
        {
            try
            {
                return _prc?.GetAmount()?.GetFunding() > 0.0
                    ? _prc
                    : default( IProgramResultsCode );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IProgramResultsCode );
            }
        }

        /// <summary>
        /// Gets the program project.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramProject GetProgramProject()
        {
            try
            {
                return Verify.Input( _programProjectCode?.GetValue() )
                    ? new ProgramProject( _programProjectCode?.GetValue() )
                    : default( ProgramProject );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IProgramProject );
            }
        }

        /// <summary>
        /// Gets the program area.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramArea GetProgramArea()
        {
            try
            {
                return Verify.Input( _programAreaCode?.GetValue() )
                    ? new ProgramArea( _programAreaCode?.GetValue() )
                    : default( ProgramArea );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IProgramArea );
            }
        }
    }
}
