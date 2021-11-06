﻿// <copyright file = "PayrollObligation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public class PayrollObligation : Obligation
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; } =  Source.PayrollObligations;

        /// <summary>
        /// Gets the allocation percentage.
        /// </summary>
        /// <value>
        /// The allocation percentage.
        /// </value>
        private readonly IAmount _allocationPercentage;

        /// <summary>
        /// Gets the hours.
        /// </summary>
        /// <value>
        /// The hours.
        /// </value>
        private readonly IAmount _hours;

        /// <summary>
        /// Gets the annual base paid.
        /// </summary>
        /// <value>
        /// The annual base paid.
        /// </value>
        private readonly IAmount _annualBasePaid;

        /// <summary>
        /// Gets the annual base hours.
        /// </summary>
        /// <value>
        /// The annual base hours.
        /// </value>
        private readonly IAmount _annualBaseHours;

        /// <summary>
        /// Gets the cumulative benefits.
        /// </summary>
        /// <value>
        /// The cumulative benefits.
        /// </value>
        private readonly IAmount _cumulativeBenefits;

        /// <summary>
        /// Gets the annual other hours.
        /// </summary>
        /// <value>
        /// The annual other hours.
        /// </value>
        private readonly IAmount _annualOtherHours;

        /// <summary>
        /// Gets the annual other paid.
        /// </summary>
        /// <value>
        /// The annual other paid.
        /// </value>
        private readonly IAmount _annualOtherPaid;

        /// <summary>
        /// Gets the annual overtime paid.
        /// </summary>
        /// <value>
        /// The annual overtime paid.
        /// </value>
        private readonly IAmount _annualOvertimePaid;

        /// <summary>
        /// Gets the annual overtime hours.
        /// </summary>
        /// <value>
        /// The annual overtime hours.
        /// </value>
        private readonly IAmount _annualOvertimeHours;
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollObligation"/> class.
        /// </summary>
        /// <inheritdoc/>
        public PayrollObligation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollObligation"/> class.
        /// </summary>
        /// <param name = "query" >
        /// </param>
        public PayrollObligation( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.PayrollObligationId );
            RpioCode = new Element( Record, Field.RpioCode );
            FundCode = new Element( Record, Field.FundCode );
            AhCode = new Element( Record, Field.AhCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            HrOrgCode = new Element( Record, Field.HrOrgCode );
            WorkCode = new Element( Record, Field.WorkCode );
            FocCode = new Element( Record, Field.FocCode );
            PayPeriod = new Element( Record, Field.PayPeriod );
            _amount = new Amount( Record, Numeric.Amount );
            _hours = new Amount( Record, Numeric.Hours );
            _allocationPercentage = new Amount( Record, Numeric.AllocationPercentage );
            _annualBaseHours = new Amount( Record, Numeric.AnnualBaseHours );
            _annualBasePaid = new Amount( Record, Numeric.AnnualBasePaid );
            _cumulativeBenefits = new Amount( Record, Numeric.CumulativeBenefits );
            _annualOtherHours = new Amount( Record, Numeric.AnnualOtherHours );
            _annualOtherPaid = new Amount( Record, Numeric.AnnualOtherPaid );
            _annualOvertimeHours = new Amount( Record, Numeric.AnnualOvertimePaid );
            _annualOvertimePaid = new Amount( Record, Numeric.AnnualOvertimePaid );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollObligation"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public PayrollObligation( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.PayrollObligationId );
            RpioCode = new Element( Record, Field.RpioCode );
            FundCode = new Element( Record, Field.FundCode );
            AhCode = new Element( Record, Field.AhCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            HrOrgCode = new Element( Record, Field.HrOrgCode );
            WorkCode = new Element( Record, Field.WorkCode );
            FocCode = new Element( Record, Field.FocCode );
            PayPeriod = new Element( Record, Field.PayPeriod );
            _amount = new Amount( Record, Numeric.Amount );
            _hours = new Amount( Record, Numeric.Hours );
            _allocationPercentage = new Amount( Record, Numeric.AllocationPercentage );
            _annualBaseHours = new Amount( Record, Numeric.AnnualBaseHours );
            _annualBasePaid = new Amount( Record, Numeric.AnnualBasePaid );
            _cumulativeBenefits = new Amount( Record, Numeric.CumulativeBenefits );
            _annualOtherHours = new Amount( Record, Numeric.AnnualOtherHours );
            _annualOtherPaid = new Amount( Record, Numeric.AnnualOtherPaid );
            _annualOvertimeHours = new Amount( Record, Numeric.AnnualOvertimePaid );
            _annualOvertimePaid = new Amount( Record, Numeric.AnnualOvertimePaid );
            Type = OutlayType.Obligation;
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollObligation"/> class.
        /// </summary>
        /// <param name = "datarow" >
        /// The dr.
        /// </param>
        public PayrollObligation( DataRow datarow )
        {
            Record = datarow;
            ID = new Key( Record, PrimaryKey.PayrollObligationId );
            RpioCode = new Element( Record, Field.RpioCode );
            FundCode = new Element( Record, Field.FundCode );
            AhCode = new Element( Record, Field.AhCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            HrOrgCode = new Element( Record, Field.HrOrgCode );
            WorkCode = new Element( Record, Field.WorkCode );
            FocCode = new Element( Record, Field.FocCode );
            PayPeriod = new Element( Record, Field.PayPeriod );
            _amount = new Amount( Record, Numeric.Amount );
            _hours = new Amount( Record, Numeric.Hours );
            _allocationPercentage = new Amount( Record, Numeric.AllocationPercentage );
            _annualBaseHours = new Amount( Record, Numeric.AnnualBaseHours );
            _annualBasePaid = new Amount( Record, Numeric.AnnualBasePaid );
            _cumulativeBenefits = new Amount( Record, Numeric.CumulativeBenefits );
            _annualOtherHours = new Amount( Record, Numeric.AnnualOtherHours );
            _annualOtherPaid = new Amount( Record, Numeric.AnnualOtherPaid );
            _annualOvertimeHours = new Amount( Record, Numeric.AnnualOvertimePaid );
            _annualOvertimePaid = new Amount( Record, Numeric.AnnualOvertimePaid );
            Type = OutlayType.Obligation;
            Data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Gets the human resource organization code.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IElement GetHrOrgCode()
        {
            try
            {
                return Verify.Input( HrOrgCode?.GetValue() )
                    ? HrOrgCode
                    : default( IElement );
            }
            catch( SystemException ex )
            {
                Fail( ex );
                return default( IElement );
            }
        }

        /// <summary>
        /// Gets the annual base paid.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAnnualBasePaid()
        {
            try
            {
                return _annualBasePaid?.GetFunding() > -1.0
                    ? _annualBasePaid
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the annual base hours.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAnnualBaseHours()
        {
            try
            {
                return _annualBaseHours.GetFunding() > -1.0
                    ? _annualBaseHours
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the cumulative benefits.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetCumulativeBenefits()
        {
            try
            {
                return _cumulativeBenefits.GetFunding() > -1.0
                    ? _cumulativeBenefits
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the annual other hours.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAnnualOtherHours()
        {
            try
            {
                return _annualOtherHours?.GetFunding() > -1.0
                    ? _annualOtherHours
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the annual other paid.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAnnualOtherPaid()
        {
            try
            {
                return _annualOtherPaid?.GetFunding() > -1.0
                    ? _annualOtherPaid
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the annual overtime hours.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAnnualOvertimeHours()
        {
            try
            {
                return _annualOvertimeHours?.GetFunding() > -1.0
                    ? _annualOvertimeHours
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the annual overtime paid.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAnnualOvertimePaid()
        {
            try
            {
                return _annualOvertimePaid?.GetFunding() > -1.0
                    ? _annualOvertimePaid
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the allocation percentage.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetAllocationPercentage()
        {
            try
            {
                return _allocationPercentage?.GetFunding() > -0.001
                    ? _allocationPercentage
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the hours.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetHours()
        {
            try
            {
                return _hours?.GetFunding() > -1.0
                    ? _hours
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IAmount GetAmount()
        {
            try
            {
                return _amount?.GetFunding() > -1
                    ? _amount
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }
    }
}
