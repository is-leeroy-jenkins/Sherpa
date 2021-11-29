// // <copyright file = "BindingData.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref = "BudgetExecution.BindingBase"/>
    public class BindingData : BindingBase
    {
        /// <summary> Gets or sets the numeric. </summary>
        /// <value> The numeric. </value>
        public Numeric Numeric { get; set; }
        
        /// <summary> Sets the field. </summary>
        /// <param name = "field" > The field. </param>
        public void SetField( Field field )
        {
            try
            {
                Field = FormConfig.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <param name = "bindingsource" > The bindingsource. </param>
        public void SetDataSource<T1>( T1 bindingsource ) where T1 : IBindingList
        {
            try
            {
                if( bindingsource is BindingSource _binder
                    && _binder?.DataSource != null )
                {
                    try
                    {
                        DataSource = _binder.DataSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <typeparam name = "T2" > The type of the 2. </typeparam>
        /// <param name = "bindinglist" > The bindingsource. </param>
        /// <param name = "dict" > The dictionary. </param>
        public void SetDataSource<T1, T2>( T1 bindinglist, T2 dict )
            where T1 : IBindingList where T2 : IDictionary<string, object>
        {
            try
            {
                if( dict?.Any() == true
                    && bindinglist is BindingSource _list )
                {
                    try
                    {
                        var _filter = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            if( Verify.Input( _kvp.Key )
                                && _kvp.Value != null )
                            {
                                _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                            }
                        }

                        if( _filter?.Length > 0
                            && _list?.DataSource != null )
                        {
                            DataSource = _list?.DataSource;
                            Filter = _filter?.TrimEnd( " AND".ToCharArray() );
                        }
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <param name = "data" > The data. </param>
        public void SetDataSource( IEnumerable<object> data )
        {
            if( Verify.Input( data ) )
            {
                try
                {
                    DataSource = data?.ToList();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "dict" > The dictionary. </param>
        public void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.Sequence( data )
                && Verify.Map( dict ) )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        if( Verify.Input( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    DataSource = data?.ToList();
                    Filter = _filter?.TrimEnd( " AND".ToCharArray() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <typeparam name = "T2" > The type of the 2. </typeparam>
        /// <typeparam name = "T3" > The type of the 3. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "field" > The field. </param>
        /// <param name = "filter" > The dictionary. </param>
        public void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow> where T2 : struct
        {
            if( Verify.Sequence( data )
                && Verify.Field( field ) )
            {
                try
                {
                    if( Verify.Input( filter ) )
                    {
                        DataSource = data.ToList();
                        DataMember = field.ToString();
                        Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        DataSource = data.ToList();
                        DataMember = field.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "field" > The field. </param>
        public void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.Sequence( data ) )
            {
                try
                {
                    if( Verify.Ref( field ) )
                    {
                        DataSource = data.ToList();
                        DataMember = field?.ToString();
                    }
                    else
                    {
                        DataSource = data.ToList();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the bindings. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <typeparam name = "T2" > The type of the 2. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "dict" > The dictionary. </param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow> where T2 : IDictionary<string, object>
        {
            if( Verify.Sequence( data )
                && Verify.Map( dict ) )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        if( Verify.Input( _kvp.Key )
                            && Verify.Ref( _kvp.Value ) )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    DataSource = data?.ToList();
                    Filter = _filter?.TrimEnd( " AND".ToCharArray() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary> Sets the binding source. </summary>
        /// <typeparam name = "T1" > The type of the 1. </typeparam>
        /// <typeparam name = "T2" > The type of the 2. </typeparam>
        /// <param name = "data" > The data. </param>
        /// <param name = "field" > The field. </param>
        /// <param name = "filter" > The filter. </param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow> where T2 : struct
        {
            if( Verify.Sequence( data )
                && Verify.Field( field ) )
            {
                try
                {
                    if( Verify.Ref( filter?.ToString() ) )
                    {
                        DataSource = data.ToList();
                        DataMember = field.ToString();
                        Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        DataSource = data?.ToList();
                        DataMember = field.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}