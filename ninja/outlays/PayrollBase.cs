// <copyright file = "PayrollBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "IPayrollBase"/>
    /// <seealso cref = "IPerson"/>
    public abstract class PayrollBase : IPayrollBase, IPerson
    {
        /// <summary>
        /// Gets or sets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Gets or sets the payroll hours identifier.
        /// </summary>
        /// <value>
        /// The payroll hours identifier.
        /// </value>
        public IKey ID { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public IElement RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the calendar date.
        /// </summary>
        /// <value>
        /// The calendar date.
        /// </value>
        public ITime CalendarDate { get; set; }

        /// <summary>
        /// Gets or sets the pay period.
        /// </summary>
        /// <value>
        /// The pay period.
        /// </value>
        public IElement PayPeriod { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public ITime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public ITime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the employee number.
        /// </summary>
        /// <value>
        /// The employee number.
        /// </value>
        public IElement EmployeeNumber { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public IElement FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public IElement LastName { get; set; }

        /// <summary>
        /// Gets or sets the human resource organization code.
        /// </summary>
        /// <value>
        /// The human resource organization code.
        /// </value>
        public IElement HrOrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the human resource organization.
        /// </summary>
        /// <value>
        /// The name of the human resource organization.
        /// </value>
        public IElement HrOrgName { get; set; }

        /// <summary>
        /// Gets or sets the reporting code.
        /// </summary>
        /// <value>
        /// The reporting code.
        /// </value>
        public IElement ReportingCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the reporting code.
        /// </summary>
        /// <value>
        /// The name of the reporting code.
        /// </value>
        public IElement ReportingCodeName { get; set; }

        /// <summary>
        /// Gets or sets the work code.
        /// </summary>
        /// <value>
        /// The work code.
        /// </value>
        public IElement WorkCode { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        /// <value>
        /// The hours.
        /// </value>
        public IAmount Hours { get; set; }
        
        /// <summary>
        /// Gets the payroll hours identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IKey GetId()
        {
            try
            {
                return Verify.Key( ID )
                    ? ID
                    : Key.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Key.Default;
            }
        }

        /// <summary>
        /// Gets the resource planning office code.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetRpioCode()
        {
            try
            {
                return Verify.IsElement( RpioCode )
                    ? RpioCode
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the pay period.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetPayPeriod()
        {
            try
            {
                return Verify.IsElement( PayPeriod )
                    ? PayPeriod
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the calendar date.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual ITime GetCalendarDate()
        {
            try
            {
                return Verify.IsTime( CalendarDate )
                    ? CalendarDate
                    : Time.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Time.Default;
            }
        }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual ITime GetStartDate()
        {
            try
            {
                return Verify.IsTime( StartDate )
                    ? StartDate
                    : Time.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Time.Default;
            }
        }

        /// <summary>
        /// Gets the end date.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual ITime GetEndDate()
        {
            try
            {
                return Verify.IsTime( EndDate )
                    ? EndDate
                    : Time.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Time.Default;
            }
        }

        /// <summary>
        /// Gets the employee number.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetEmployeeNumber()
        {
            try
            {
                return Verify.IsElement( EmployeeNumber )
                    ? EmployeeNumber
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetFirstName()
        {
            try
            {
                return Verify.IsElement( FirstName )
                    ? FirstName
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetLastName()
        {
            try
            {
                return Verify.IsElement( LastName )
                    ? LastName
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the human resource organization code.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetHrOrgCode()
        {
            try
            {
                return Verify.IsElement( HrOrgCode )
                    ? HrOrgCode
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the name of the Human Resource Organization.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public virtual IElement GetHrOrgName()
        {
            try
            {
                return Verify.IsElement( HrOrgName )
                    ? HrOrgName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the work code.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetWorkCode()
        {
            try
            {
                return Verify.IsElement( WorkCode )
                    ? WorkCode
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the reporting code.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetReportingCode()
        {
            try
            {
                return Verify.IsElement( ReportingCode )
                    ? ReportingCode
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the reporting code description.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IElement GetReportingCodeName()
        {
            try
            {
                return Verify.IsElement( ReportingCodeName )
                    ? ReportingCodeName
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the hours.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IAmount GetHours()
        {
            try
            {
                return Verify.Amount( Hours )
                    ? Hours
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary()
        {
            try
            {
                return Verify.IsMap( Args )
                    ? Args
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
