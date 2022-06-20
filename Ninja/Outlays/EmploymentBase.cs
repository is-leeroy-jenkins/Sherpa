// <copyright file = "EmploymentBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "IEmploymentInfo"/>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public abstract class EmploymentBase : IEmploymentInfo
    {
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
        public IElement HumanResourceOrganizationCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the human resource organization.
        /// </summary>
        /// <value>
        /// The name of the human resource organization.
        /// </value>
        public IElement HumanResourceOrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the appointment authority.
        /// </summary>
        /// <value>
        /// The appointment authority.
        /// </value>
        public IElement AppointmentAuthority { get; set; }

        /// <summary>
        /// Gets or sets the type of the appointment.
        /// </summary>
        /// <value>
        /// The type of the appointment.
        /// </value>
        public IElement AppointmentType { get; set; }

        /// <summary>
        /// Gets or sets the bargaining unit.
        /// </summary>
        /// <value>
        /// The bargaining unit.
        /// </value>
        public IElement BargainingUnit { get; set; }

        /// <summary>
        /// Gets or sets the retirement plan.
        /// </summary>
        /// <value>
        /// The retirement plan.
        /// </value>
        public IElement RetirementPlan { get; set; }

        /// <summary>
        /// Gets or sets the hire date.
        /// </summary>
        /// <value>
        /// The hire date.
        /// </value>
        public ITime HireDate { get; set; }

        /// <summary>
        /// Gets or sets the service date.
        /// </summary>
        /// <value>
        /// The service date.
        /// </value>
        public ITime ServiceDate { get; set; }

        /// <summary>
        /// Gets or sets the grade entry date.
        /// </summary>
        /// <value>
        /// The grade entry date.
        /// </value>
        public ITime GradeEntryDate { get; set; }

        /// <summary>
        /// Gets or sets the step entry date.
        /// </summary>
        /// <value>
        /// The step entry date.
        /// </value>
        public ITime StepEntryDate { get; set; }

        /// <summary>
        /// Gets or sets the WIGI due date.
        /// </summary>
        /// <value>
        /// The WIGI due date.
        /// </value>
        public ITime WigiDueDate { get; set; }

        /// <summary>
        /// Gets the employee number.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetEmployeeNumber()
        {
            try
            {
                return Verify.IsInput( EmployeeNumber.Value )
                    ? EmployeeNumber
                    : default( IElement );
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
        public IElement GetFirstName()
        {
            try
            {
                return Verify.IsInput( FirstName.Value )
                    ? FirstName
                    : default( IElement );
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
        public IElement GetLastName()
        {
            try
            {
                return Verify.IsInput( LastName.Value )
                    ? LastName
                    : default( IElement );
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
        public IElement GetHrOrgCode()
        {
            try
            {
                return Verify.IsInput( HumanResourceOrganizationCode.Value )
                    ? HumanResourceOrganizationCode
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the name of the human resource organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetHrOrgName()
        {
            try
            {
                return Verify.IsElement( HumanResourceOrganizationName )
                    ? HumanResourceOrganizationName
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the hire date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetHireDate()
        {
            try
            {
                return Verify.IsTime( HireDate )
                    ? HireDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the service date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetServiceDate()
        {
            try
            {
                return Verify.IsInput( ServiceDate?.Value?.ToString( ) )
                    ? ServiceDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the grade entry date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetGradeEntryDate()
        {
            try
            {
                return Verify.IsInput( GradeEntryDate?.Value?.ToString( ) )
                    ? GradeEntryDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the step entry date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetStepEntryDate()
        {
            try
            {
                return Verify.IsInput( StepEntryDate?.Value?.ToString( ) )
                    ? StepEntryDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the WIGI due date.
        /// </summary>
        /// <returns>
        /// </returns>
        public ITime GetWigiDueDate()
        {
            try
            {
                return Verify.IsInput( WigiDueDate?.Value?.ToString( ) )
                    ? WigiDueDate
                    : default( ITime );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITime );
            }
        }

        /// <summary>
        /// Gets the appointment authority.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetAppointmentAuthority()
        {
            try
            {
                return Verify.IsInput( AppointmentAuthority.Value )
                    ? AppointmentAuthority
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the type of the appointment.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetAppointmentType()
        {
            try
            {
                return Verify.IsInput( AppointmentType.Value )
                    ? AppointmentType
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the bargaining unit.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetBargainingUnit()
        {
            try
            {
                return Verify.IsInput( BargainingUnit.Value )
                    ? BargainingUnit
                    : default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the retirement plan.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetRetirementPlan()
        {
            try
            {
                return Verify.IsInput( RetirementPlan.Value )
                    ? RetirementPlan
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
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
