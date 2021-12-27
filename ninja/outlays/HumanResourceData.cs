// <copyright file = "HumanResourceData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="EmploymentBase" />
    /// <seealso cref="IHumanResourceData" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class HumanResourceData : EmploymentBase, IHumanResourceData, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source = Source.WorkforceData;
        
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Records { get; set; } 

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Args { get; set; } 

        /// <summary>
        /// Gets the workforce Data identifier.
        /// </summary>
        /// <value>
        /// The workforce Data identifier.
        /// </value>
        public IKey ID { get; set; } 

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public IElement Status { get; set; } 

        /// <summary>
        /// Gets the job title.
        /// </summary>
        /// <value>
        /// The job title.
        /// </value>
        public IElement JobTitle { get; set; } 

        /// <summary>
        /// Gets the occupational series.
        /// </summary>
        /// <value>
        /// The occupational series.
        /// </value>
        public IElement OccupationalSeries { get; set; } 

        /// <summary>
        /// Gets the grade.
        /// </summary>
        /// <value>
        /// The grade.
        /// </value>
        public IElement Grade { get; set; } 

        /// <summary>
        /// Gets the step.
        /// </summary>
        /// <value>
        /// The step.
        /// </value>
        public IElement Step { get; set; } 

        /// <summary>
        /// Gets the compensation rate.
        /// </summary>
        /// <value>
        /// The compensation rate.
        /// </value>
        public IAmount CompensationRate { get; set; } 

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceData"/> class.
        /// </summary>
        public HumanResourceData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceData"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public HumanResourceData( IQuery query )
        {
            Records = new DataBuilder( query )?.GetRecord();
            ID = new Key( Records, PrimaryKey.WorkforceDataId );
            EmployeeNumber = new Element( Records, Field.EmployeeNumber );
            FirstName = new Element( Records, Field.FirstName );
            LastName = new Element( Records, Field.LastName );
            Status = new Element( Records, Field.Status );
            JobTitle = new Element( Records, Field.JobTitle );
            OccupationalSeries = new Element( Records, Field.OccupationalSeries );
            HumanResourceOrganizationCode = new Element( Records, Field.HumanResourceOrganizationCode );
            HumanResourceOrganizationName = new Element( Records, Field.HumanResourceOrganizationName );
            Grade = new Element( Records, Field.Grade );
            Step = new Element( Records, Field.Step );
            AppointmentAuthority = new Element( Records, Field.AppointmentAuthority );
            AppointmentType = new Element( Records, Field.AppointmentType );
            BargainingUnit = new Element( Records, Field.BargainingUnit );
            RetirementPlan = new Element( Records, Field.RetirementPlan );
            HireDate = new Time( Records, EventDate.HireDate );
            ServiceDate = new Time( Records, EventDate.ServiceDate );
            WigiDueDate = new Time( Records, EventDate.WigiDueDate );
            GradeEntryDate = new Time( Records, EventDate.GradeEntryDate );
            StepEntryDate = new Time( Records, EventDate.StepEntryDate );
            CompensationRate = new Amount( Records, Numeric.CompensationRate );
            Args = Records.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceData"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public HumanResourceData( IBuilder builder )
        {
            Records = builder?.GetRecord();
            ID = new Key( Records, PrimaryKey.WorkforceDataId );
            EmployeeNumber = new Element( Records, Field.EmployeeNumber );
            FirstName = new Element( Records, Field.FirstName );
            LastName = new Element( Records, Field.LastName );
            Status = new Element( Records, Field.Status );
            JobTitle = new Element( Records, Field.JobTitle );
            OccupationalSeries = new Element( Records, Field.OccupationalSeries );
            HumanResourceOrganizationCode = new Element( Records, Field.HumanResourceOrganizationCode );
            HumanResourceOrganizationName = new Element( Records, Field.HumanResourceOrganizationName );
            Grade = new Element( Records, Field.Grade );
            Step = new Element( Records, Field.Step );
            AppointmentAuthority = new Element( Records, Field.AppointmentAuthority );
            AppointmentType = new Element( Records, Field.AppointmentType );
            BargainingUnit = new Element( Records, Field.BargainingUnit );
            RetirementPlan = new Element( Records, Field.RetirementPlan );
            HireDate = new Time( Records, EventDate.HireDate );
            ServiceDate = new Time( Records, EventDate.ServiceDate );
            WigiDueDate = new Time( Records, EventDate.WigiDueDate );
            GradeEntryDate = new Time( Records, EventDate.GradeEntryDate );
            StepEntryDate = new Time( Records, EventDate.StepEntryDate );
            CompensationRate = new Amount( Records, Numeric.CompensationRate );
            Args = Records.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceData"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public HumanResourceData( DataRow data )
            : this()
        {
            Records = data;
            ID = new Key( Records, PrimaryKey.WorkforceDataId );
            EmployeeNumber = new Element( Records, Field.EmployeeNumber );
            FirstName = new Element( Records, Field.FirstName );
            LastName = new Element( Records, Field.LastName );
            Status = new Element( Records, Field.Status );
            JobTitle = new Element( Records, Field.JobTitle );
            OccupationalSeries = new Element( Records, Field.OccupationalSeries );
            HumanResourceOrganizationCode = new Element( Records, Field.HumanResourceOrganizationCode );
            HumanResourceOrganizationName = new Element( Records, Field.HumanResourceOrganizationName );
            Grade = new Element( Records, Field.Grade );
            Step = new Element( Records, Field.Step );
            AppointmentAuthority = new Element( Records, Field.AppointmentAuthority );
            AppointmentType = new Element( Records, Field.AppointmentType );
            BargainingUnit = new Element( Records, Field.BargainingUnit );
            RetirementPlan = new Element( Records, Field.RetirementPlan );
            HireDate = new Time( Records, EventDate.HireDate );
            ServiceDate = new Time( Records, EventDate.ServiceDate );
            WigiDueDate = new Time( Records, EventDate.WigiDueDate );
            GradeEntryDate = new Time( Records, EventDate.GradeEntryDate );
            StepEntryDate = new Time( Records, EventDate.StepEntryDate );
            CompensationRate = new Amount( Records, Numeric.CompensationRate );
            Args = Records.ToDictionary();
        }
        
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref = "string"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if( Verify.IsElement( FirstName )
                && Verify.IsElement( LastName ) )
            {
                try
                {
                    return FirstName.Value + " " + LastName.Value;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
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
        /// Gets the workforce Data identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public IKey GetId()
        {
            try
            {
                return Verify.IsKey( ID )
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
        /// Gets the employee.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEmployee GetEmployee()
        {
            try
            {
                var args = new Dictionary<string, object>
                {
                    [ $"{Field.EmployeeNumber}" ] = EmployeeNumber
                };

                var connection = new ConnectionBuilder( Source.Employees, Provider.SQLite );
                var sqlstatement = new SqlStatement( connection, args, SQL.SELECT );
                using var query = new Query( connection, sqlstatement );
                return new Employee( query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Employee );
            }
        }

        /// <summary>
        /// Gets the human resource organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IHumanResourceOrganization GetHumanResourceOrganization()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.HumanResourceOrganizationCode}" ] = HumanResourceOrganizationCode
                };

                var _connection = new ConnectionBuilder( Source.HumanResourceOrganizations, Provider.SQLite );
                var _statement = new SqlStatement( _connection, _dictionary, SQL.SELECT );
                using var _query = new Query( _connection, _statement );
                return new HumanResourceOrganization( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( HumanResourceOrganization );
            }
        }

        /// <summary>
        /// Gets the job title.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetJobTitle()
        {
            try
            {
                return Verify.IsElement( JobTitle )
                    ? JobTitle
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the occupational series.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetOccupationalSeries()
        {
            try
            {
                return Verify.IsElement( OccupationalSeries )
                    ? OccupationalSeries
                    : Element.Default;
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
                return Verify.IsElement( Status )
                    ? Status
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the grade.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetGrade()
        {
            try
            {
                return Verify.IsElement( Grade )
                    ? Grade
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the step.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetStep()
        {
            try
            {
                return Verify.IsElement( Step )
                    ? Step
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the compensation.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAmount GetCompensation()
        {
            try
            {
                return CompensationRate.Funding > -1.0
                    ? CompensationRate
                    : default( IAmount );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAmount );
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource()
        {
            try
            {
                return Verify.IsSource( Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Source );
            }
        }
    }
}
