// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using OfficeOpenXml;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetFactory : ExcelBudget
    {
        /// <summary>
        /// The budget
        /// </summary>
        public ExcelBudget Budget { get; }

        /// <summary>
        /// The allocation
        /// </summary>
        public IAllocation Allocation { get; set; }

        /// <summary>
        /// The authority
        /// </summary>
        public IAuthority Authority { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFactory"/> class.
        /// </summary>
        /// <param name="excelBudget">The excelBudget.</param>
        public BudgetFactory( ExcelBudget excelBudget )
        {
            Budget = excelBudget;
            Worksheet = Budget.GetWorkSheet();
            Allocation = Budget.GetAllocation();
            Authority = Allocation.GetAuthority();
        }

        /// <summary>
        /// Gets the epm workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetEpmWorksheet()
        {
            var _funds = Allocation?.GetFunds();
            var _supplementals = Allocation?.GetAwards();
            var _enumerable = Allocation?.GetData();
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _header = _grid.GetFrom().Row  - 1;
            var _start = _grid.GetFrom().Row;
            var _fund = new Fund( $"{FundCode.B}" );
            Budget?.SetWorksheetProperties( _grid.GetWorksheet() );
            Budget?.SetBudgetHeaderFormat( _grid, _fund, Allocation?.GetBudgetFiscalYear() );
            
            try
            {
                var _lookup = _enumerable
                    ?.Where( f => f.Field<string>( $"{Field.FundCode}" ).StartsWith( $"{FundCode.B}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.ToLookup( f => f.Field<string>( $"{Field.AccountCode}" ), f => f );

                if( _lookup != null )
                {
                    foreach( var kvp in _lookup )
                    {
                        Budget?.SetAllocationTableFormat( _grid, _fund );
                        Budget?.PopulateAccountRows( _grid, _lookup, kvp );
                        _start++;
                    }
                }

                var _end = _start;

                var _select = _supplementals?.Where( a => a.GetFundCode().Equals( $"{FundCode.B}" ) )
                    ?.Select( a => a );

                if( _select?.Any() ?? false )
                {
                    Budget?.SetAwardsHeaderFormat( _grid );
                    Budget?.SetAwardRowsFormat( _grid, _fund );
                }

                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the stag workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetStagWorksheet()
        {
            var _enumerable = Allocation?.GetData();
            var _funds = Allocation?.GetFunds();

            try
            {
                var _lookup = _enumerable
                    ?.Where( f =>
                        f.Field<string>( $"{Field.FundCode}" ).StartsWith( $"{FundCode.E}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the lust workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetLustWorksheet()
        {
            var _enumerable = Allocation.GetData();
            var awards = Allocation.GetAwards();
            var funds = Allocation.GetFunds();

            try
            {
                var code = _enumerable?.Where( f => f.Field<string>( $"{Field.FundCode}" ).Equals( $"{FundCode.F}" ) )
                    .Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    .ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the oil workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetOilWorksheet()
        {
            var _enumerable = Allocation?.GetData();
            var _supplementals = Allocation?.GetAwards();
            var _funds = Allocation?.GetFunds();
            var _fund = new Fund( $"{FundCode.H}" );

            try
            {
                var _lookup = _enumerable?.Where( f => f.Field<string>( $"{Field.FundCode}" ).Equals( $"{FundCode.H}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the deep water horizon workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetDeepWaterHorizonWorksheet()
        {
            var _enumerable = Allocation.GetData();
            var _list = Allocation.GetFunds();
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _row = _grid.GetFrom().Row;
            var _first = _row - 1;
            var _fund = new Fund( $"{FundCode.ZL}" );
            Budget?.SetWorksheetProperties( _grid.GetWorksheet() );
            Budget?.SetBudgetHeaderFormat( _grid, _fund, Allocation?.GetBudgetFiscalYear() );

            try
            {
                var _lookup = _enumerable?.Where( f => f.Field<string>( $"{Field.FundCode}" ).StartsWith( $"{FundCode.ZL}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.Select( f => f )
                    ?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                if( _lookup != null )
                {
                    foreach( var kvp in _lookup )
                    {
                        Budget?.SetAllocationTableFormat( _grid, _fund );
                        Budget?.PopulateAccountRows( _grid, _lookup, kvp );
                        _row++;
                    }
                }

                Budget?.SetSummaryFormat( _grid );
                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the superfund workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetSuperfundWorksheet()
        {
            var _enumerable = Allocation.GetData();
            var _supplementals = Allocation.GetAwards();
            var _funds = Allocation.GetFunds();
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _first = _grid?.GetFrom().Row;
            var _header = _first - 1;
            var _fund = new Fund( $"{FundCode.T}" );
            Budget?.SetWorksheetProperties( _grid.GetWorksheet() );
            Budget?.SetBudgetHeaderFormat( _grid, _fund, Allocation.GetBudgetFiscalYear() );

            try
            {
                var _lookup = _enumerable
                    ?.Where( p => p.Field<string>( $"{Field.AhCode}" ).Equals( "06" ) )
                    ?.Where( p => p.Field<string>( $"{Field.FundCode}" ).Equals( $"{FundCode.T}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                if( _lookup != null )
                {
                    foreach( var kvv in _lookup )
                    {
                        Budget?.SetAllocationTableFormat( _grid, _fund );
                        Budget?.PopulateAccountRows( _grid, _lookup, kvv );
                        _first++;
                    }
                }

                var _last = _first;
                Budget?.SetSummaryFormat( _grid );
                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the s f6 a workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetSF6AWorksheet()
        {
            var _rows = Allocation?.GetData();
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _first = _grid.GetFrom().Row;
            var _header = _first - 1;
            var _fund = new Fund( $"{FundCode.T}" );
            var _enumerable = Allocation?.GetBuilder()?.GetData();
            Budget?.SetWorksheetProperties( _grid.GetWorksheet() );
            Budget?.SetBudgetHeaderFormat( _grid, _fund, Allocation?.GetBudgetFiscalYear() );

            try
            {
                var _lookup = _rows
                    ?.Where( p => p.Field<string>( $"{Field.AhCode}" ).Equals( "6A" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.ToLookup( p => p.Field<string>( $"{Field.OrgCode}" ), p => p );

                if( _lookup != null )
                {
                    foreach( var kvp in _lookup )
                    {
                        var _dictionary = new Dictionary<string, object>
                        {
                            [ $"{Field.AhCode}" ] = "6A"
                        };

                        var _builder = new ConnectionBuilder( Source.AllowanceHolders, Provider.SQLite );
                        var _statement = new SqlStatement( _builder, _dictionary, SQL.SELECT );
                        var _query = new Query( _builder, _statement );
                        Budget?.SetAllocationTableFormat( _grid, _fund, new AllowanceHolder( _query ) );
                        Budget?.PopulateAccountRows( _grid, _lookup, kvp );
                        _first++;
                    }
                }

                Budget?.SetSummaryFormat( _grid );
                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the special accounts workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetSpecialAccountsWorksheet()
        {
            var _enumerable = Allocation?.GetData();
            var _funds = Allocation?.GetFunds();
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _first = _grid.GetFrom().Row;
            var _header = _first - 1;
            var _fund = new Fund( $"{FundCode.TR}" );
            Budget?.SetWorksheetProperties( _grid.GetWorksheet() );
            Budget?.SetBudgetHeaderFormat( _grid, _fund, Allocation?.GetBudgetFiscalYear() );

            try
            {
                var _rows = _enumerable
                    ?.Where( p => p.Field<string>( $"{Field.FundCode}" ).Contains( $"{FundCode.TR}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.Select( p => p )
                    ?.ToArray();

                for( var i = 0; i < _rows?.Length; i++ )
                {
                    var _lookup = _enumerable
                        ?.Where( p => p.Field<string>( $"{Field.FundCode}" ).StartsWith( $"{FundCode.TR}" ) )
                        ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                        ?.Select( p => p )
                        ?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                    foreach( var kvp in _lookup )
                    {
                        Budget?.SetAllocationTableFormat( _grid, _fund );
                        Budget?.PopulateAccountRows( _grid, _lookup, kvp );
                        _first++;
                    }

                    var _last = _first;
                    Budget?.SetSummaryFormat( _grid );
                }

                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the superfund supplement workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetSuperfundSupplementWorksheet()
        {
            var _rows = Allocation?.GetData();
            var _enumerable = Allocation?.GetFunds();
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _first = _grid.GetFrom().Row;
            var _header = _first - 1;
            var _fund = new Fund( $"{FundCode.TS3}" );
            Budget?.SetWorksheetProperties( _grid?.GetWorksheet() );
            Budget?.SetBudgetHeaderFormat( _grid, _fund, Allocation?.GetBudgetFiscalYear() );

            try
            {
                var _lookup = _rows
                    ?.Where( f => f.Field<string>( $"{Field.FundCode}" ).Equals( $"{FundCode.TS3}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                if( _lookup != null )
                {
                    foreach( var kvp in _lookup )
                    {
                        Budget?.SetNonSiteHeaderFormat( _grid, _fund );
                        Budget?.PopulateAccountRows( _grid, _lookup, kvp );
                        _first++;
                    }
                }

                Budget?.SetSummaryFormat( _grid );
                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }

        /// <summary>
        /// Gets the lust supplemental workSheet.
        /// </summary>
        /// <returns></returns>
        public ExcelWorksheet GetLustSupplementalWorksheet()
        {
            var _enumerable = Allocation?.GetData();
            var _funds = Allocation?.GetFunds();
            var _fund = new Fund( $"{FundCode.FS3}" );
            var _grid = new Grid( Worksheet, ( 10, 2 ) );
            var _first = _grid?.GetFrom().Row;
            var _header = _first - 1;
            Budget?.SetWorksheetProperties( _grid.GetWorksheet() );

            try
            {
                var _rows = _enumerable
                    ?.Where( f => f.Field<string>( $"{Field.FundCode}" ).Equals( $"{FundCode.FS3}" ) )
                    ?.Where( f => f.Field<string>( $"{Field.BocCode}" ) != $"{BOC.FTE}" )
                    ?.Select( f => f )
                    ?.ToArray();

                var _lookup = _rows?.ToLookup( p => p.Field<string>( $"{Field.AccountCode}" ), p => p );

                if( _lookup != null )
                {
                    foreach( var group in _lookup )
                    {
                        Budget?.SetNonSiteHeaderFormat( _grid, _fund );
                        Budget?.PopulateAccountRows( _grid, _lookup, group );
                        _first++;
                    }
                }

                Budget?.SetSummaryFormat( _grid );
                return Worksheet;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelWorksheet );
            }
        }
    }
}