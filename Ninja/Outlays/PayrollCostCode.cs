// <copyright file = "WorkCodeBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "IPayrollCostData"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class PayrollCostCode
    {
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the work code identifier.
        /// </summary>
        /// <value>
        /// The work code identifier.
        /// </value>
        public IKey ID { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public IElement ShortName { get; set; }

        /// <summary>
        /// Gets or sets the notifications.
        /// </summary>
        /// <value>
        /// The notifications.
        /// </value>
        public IElement Notification { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public IElement Status { get; set; }

        /// <summary>
        /// Gets or sets the pay period.
        /// </summary>
        /// <value>
        /// The pay period.
        /// </value>
        public IElement PayPeriod { get; set; }

        /// <summary>
        /// Gets or sets the bbfy.
        /// </summary>
        /// <value>
        /// The bbfy.
        /// </value>
        public IElement BFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public IElement FundCode { get; set; }

        /// <summary>
        /// Gets or sets the foc code.
        /// </summary>
        /// <value>
        /// The foc code.
        /// </value>
        public IElement FocCode { get; set; }

        /// <summary>
        /// Gets or sets the approval date.
        /// </summary>
        /// <value>
        /// The approval date.
        /// </value>
        public DateTime ApprovalDate { get; set; }

        /// <summary>
        /// Gets or sets the cost org code.
        /// </summary>
        /// <value>
        /// The cost org code.
        /// </value>
        public IElement CostOrgCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the cost org.
        /// </summary>
        /// <value>
        /// The name of the cost org.
        /// </value>
        public IElement CostOrgName { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public IElement RcCode { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public IElement AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the project code.
        /// </summary>
        /// <value>
        /// The project code.
        /// </value>
        public IElement ProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the project code.
        /// </summary>
        /// <value>
        /// The name of the project code.
        /// </value>
        public IElement ProjectCodeName { get; set; }

        /// <summary>
        /// Gets the approval date.
        /// </summary>
        /// <returns>
        /// </returns>
        public DateTime GetApprovalDate()
        {
            try
            {
                return ApprovalDate != default( DateTime )
                    ? ApprovalDate
                    : default( DateTime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DateTime );
            }
        }

        /// <summary>
        /// Gets the project code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetProjectCode()
        {
            if( Verify.IsInput( ProjectCode?.Value?.ToString() ) )
            {
                try
                {
                    return ProjectCode;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return Element.Default;
                }
            }

            return Element.Default;
        }

        /// <summary>
        /// Gets the name of the project code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetProjectCodeName()
        {
            if( Verify.IsInput( ProjectCodeName?.Value?.ToString() ) )
            {
                try
                {
                    return ProjectCodeName;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return Element.Default;
                }
            }

            return Element.Default;
        }
        
        /// <summary>
        /// Gets the work code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetWorkCode()
        {
            try
            {
                var _element = ( (IProgram)this );

                return Verify.IsElement( _element )
                    ? _element
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the name of the work code.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetWorkCodeName()
        {
            try
            {
                return Verify.IsInput( Name )
                    ? Name
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the short name.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetShortName()
        {
            try
            {
                return Verify.IsInput( ShortName.Value )
                    ? ShortName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetStatus()
        {
            try
            {
                return Verify.IsInput( Status.Value )
                    ? Status
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the notifications.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetNotifications()
        {
            try
            {
                return Verify.IsElement( Notification )
                    ? Notification
                    : default( IElement );
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
        public IElement GetPayPeriod()
        {
            try
            {
                return Verify.IsElement( PayPeriod )
                    ? PayPeriod
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
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
