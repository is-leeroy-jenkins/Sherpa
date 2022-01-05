// <copyright file = "PrcConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "PrcBase"/>
    public abstract class PrcConfig : PrcBase
    {
        /// <summary>
        /// Gets the ProgramResultCodes identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public override IKey GetId()
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
        /// Gets the budget level.
        /// </summary>
        /// <returns>
        /// </returns>
        public IBudgetLevel GetBudgetLevel()
        {
            try
            {
                return Verify.IsElement( BudgetLevel )
                    ? new BudgetLevel( BudgetLevel.Value?.ToString() )
                    : default( BudgetLevel );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IBudgetLevel );
            }
        }

        /// <summary>
        /// Gets the budget fiscal year.
        /// </summary>
        /// <returns>
        /// </returns>
        public IBudgetFiscalYear GetBudgetFiscalYear()
        {
            try
            {
                return Verify.IsElement( BFY )
                    ? new BudgetFiscalYear( BFY?.Value?.ToString() )
                    : default( BudgetFiscalYear );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetFiscalYear );
            }
        }

        /// <summary>
        /// Gets the resource planning office.
        /// </summary>
        /// <returns>
        /// </returns>
        public IResourcePlanningOffice GetResourcePlanningOffice()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = RpioCode?.Value?.ToString()
                };

                var _connection = new ConnectionBuilder( Source.ResourcePlanningOffices );
                var _statement = new SqlStatement( _connection, _dictionary, SQL.SELECT );
                using var _query = new Query( _connection, _statement );
                return new ResourcePlanningOffice( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ResourcePlanningOffice );
            }
        }

        /// <summary>
        /// Gets the allowance holder.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAllowanceHolder GetAllowanceHolder()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = AhCode?.Value?.ToString()
                };

                var _builder = new ConnectionBuilder( Source.AllowanceHolders );
                var _statement = new SqlStatement( _builder, _dictionary, SQL.SELECT );
                using var _query = new Query( _builder, _statement );
                return new AllowanceHolder( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( AllowanceHolder );
            }
        }

        /// <summary>
        /// Gets the fund.
        /// </summary>
        /// <returns>
        /// </returns>
        public IFund GetFund()
        {
            try
            {
                return Verify.IsElement( FundCode )
                    ? new Fund( FundCode?.Value?.ToString() )
                    : default( Fund );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Fund );
            }
        }

        /// <summary>
        /// Gets the organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IOrganization GetOrganization()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = OrgCode?.Value?.ToString()
                };

                var _builder = new ConnectionBuilder( Source.Organizations );
                var _statement = new SqlStatement( _builder, _dictionary, SQL.SELECT );
                using var _query = new Query( _builder, _statement );
                return new Organization( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Organization );
            }
        }

        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAccount GetAccount()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = AccountCode?.Value?.ToString()
                };

                var _builder = new ConnectionBuilder( Source.Accounts );
                var _statement = new SqlStatement( _builder, _dictionary, SQL.SELECT );
                using var _query = new Query( _builder, _statement );
                return new Account( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Account );
            }
        }

        /// <summary>
        /// Gets the budget object class.
        /// </summary>
        /// <returns>
        /// </returns>
        public IBudgetObjectClass GetBudgetObjectClass()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = BocCode?.Value?.ToString()
                };

                var _builder = new ConnectionBuilder( Source.BudgetObjectClasses );
                var _statement = new SqlStatement( _builder, _dictionary, SQL.SELECT );
                using var _query = new Query( _builder, _statement );
                return new BudgetObjectClass( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetObjectClass );
            }
        }

        /// <summary>
        /// Gets the responsibility center.
        /// </summary>
        /// <returns>
        /// </returns>
        public IResponsibilityCenter GetResponsibilityCenter()
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = RcCode?.Value?.ToString()
                };

                var _builder = new ConnectionBuilder( Source.ResponsibilityCenters );
                var _statement = new SqlStatement( _builder, _dictionary, SQL.SELECT );
                using var _query = new Query( _builder, _statement );
                return new ResponsibilityCenter( _query );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ResponsibilityCenter );
            }
        }
    }
}
