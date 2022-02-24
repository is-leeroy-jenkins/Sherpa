// <copyright file = "PayrollActivity.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public class PayrollActivity : Obligation
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; } =  Source.PayrollActivity;

        /// <summary>
        /// Gets the allocation percentage.
        /// </summary>
        /// <value>
        /// The allocation percentage.
        /// </value>
        public IAmount AllocationPercentage { get; set; }

        /// <summary>
        /// Gets the hours.
        /// </summary>
        /// <value>
        /// The hours.
        /// </value>
        public IAmount Hours { get; set; }

        /// <summary>
        /// Gets the annual base paid.
        /// </summary>
        /// <value>
        /// The annual base paid.
        /// </value>
        public IAmount AnnualBasePaid { get; set; }

        /// <summary>
        /// Gets the annual base hours.
        /// </summary>
        /// <value>
        /// The annual base hours.
        /// </value>
        public IAmount AnnualBaseHours { get; set; }

        /// <summary>
        /// Gets the cumulative benefits.
        /// </summary>
        /// <value>
        /// The cumulative benefits.
        /// </value>
        public IAmount CumulativeBenefits { get;  set; }

        /// <summary>
        /// Gets the annual other hours.
        /// </summary>
        /// <value>
        /// The annual other hours.
        /// </value>
        public IAmount AnnualOtherHours { get;  set; }

        /// <summary>
        /// Gets the annual other paid.
        /// </summary>
        /// <value>
        /// The annual other paid.
        /// </value>
        public IAmount AnnualOtherPaid { get; set; }

        /// <summary>
        /// Gets the annual overtime paid.
        /// </summary>
        /// <value>
        /// The annual overtime paid.
        /// </value>
        public IAmount AnnualOvertimePaid { get; set; }

        /// <summary>
        /// Gets the annual overtime hours.
        /// </summary>
        /// <value>
        /// The annual overtime hours.
        /// </value>
        public IAmount AnnualOvertimeHours { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollActivity"/> class.
        /// </summary>
        /// <inheritdoc/>
        public PayrollActivity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollActivity"/> class.
        /// </summary>
        /// <param name = "query" >
        /// </param>
        public PayrollActivity( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.PayrollActivityId );
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
            Amount = new Amount( Record, Numeric.Amount );
            Hours = new Amount( Record, Numeric.Hours );
            AllocationPercentage = new Amount( Record, Numeric.OvertimePaid );
            AnnualBaseHours = new Amount( Record, Numeric.AnnualBaseHours );
            AnnualBasePaid = new Amount( Record, Numeric.BasePaid );
            CumulativeBenefits = new Amount( Record, Numeric.CumulativeBenefits );
            AnnualOtherHours = new Amount( Record, Numeric.BaseHours );
            AnnualOtherPaid = new Amount( Record, Numeric.AnnualOtherPaid );
            AnnualOvertimeHours = new Amount( Record, Numeric.Benefits );
            AnnualOvertimePaid = new Amount( Record, Numeric.Benefits );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollActivity"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public PayrollActivity( IBuilder builder )
            : base( builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.PayrollActivityId );
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
            Amount = new Amount( Record, Numeric.Amount );
            Hours = new Amount( Record, Numeric.Hours );
            AllocationPercentage = new Amount( Record, Numeric.OvertimePaid );
            AnnualBaseHours = new Amount( Record, Numeric.AnnualBaseHours );
            AnnualBasePaid = new Amount( Record, Numeric.BasePaid );
            CumulativeBenefits = new Amount( Record, Numeric.CumulativeBenefits );
            AnnualOtherHours = new Amount( Record, Numeric.BaseHours );
            AnnualOtherPaid = new Amount( Record, Numeric.AnnualOtherPaid );
            AnnualOvertimeHours = new Amount( Record, Numeric.Benefits );
            AnnualOvertimePaid = new Amount( Record, Numeric.Benefits );
            Type = OutlayType.Obligation;
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "PayrollActivity"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dr.
        /// </param>
        public PayrollActivity( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.PayrollActivityId );
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
            Amount = new Amount( Record, Numeric.Amount );
            Hours = new Amount( Record, Numeric.Hours );
            AllocationPercentage = new Amount( Record, Numeric.OvertimePaid );
            AnnualBaseHours = new Amount( Record, Numeric.AnnualBaseHours );
            AnnualBasePaid = new Amount( Record, Numeric.BasePaid );
            CumulativeBenefits = new Amount( Record, Numeric.CumulativeBenefits );
            AnnualOtherHours = new Amount( Record, Numeric.BaseHours );
            AnnualOtherPaid = new Amount( Record, Numeric.AnnualOtherPaid );
            AnnualOvertimeHours = new Amount( Record, Numeric.Benefits );
            AnnualOvertimePaid = new Amount( Record, Numeric.Benefits );
            Type = OutlayType.Obligation;
            Data = Record?.ToDictionary();
        }
    }
}
