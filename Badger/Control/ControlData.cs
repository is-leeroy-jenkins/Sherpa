// <copyright file = "ControlData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public class ControlData : UserControl
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BudgetBinding BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ControlData" /> class.
        /// </summary>
        public ControlData()
        {
        }
        
        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">
        /// The field.
        /// </param>
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

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">
        /// </typeparam>
        /// <param name="bindingList">
        /// The bindingsource.
        /// </param>
        public void SetDataSource<T1>( T1 bindingList ) where T1 : IBindingList
        {
            try
            {
                if( bindingList is BindingSource _binder
                    && _binder?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = _binder.DataSource;
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

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the 2.
        /// </typeparam>
        /// <param name="bindinglist">
        /// The bindingsource.
        /// </param>
        /// <param name="dict">
        /// The dictionary.
        /// </param>
        public void SetDataSource<T1, T2>( T1 bindinglist, T2 dict )
            where T1 : IBindingList where T2 : IDictionary<string, object>
        {
            try
            {
                if( Verify.IsBindable( bindinglist )
                    && Verify.IsMap( dict ) )
                {
                    try
                    {
                        var _list = bindinglist as BindingSource;
                        var _filter = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            if( Verify.IsInput( _kvp.Key )
                                && Verify.IsRef( _kvp.Value ) )
                            {
                                _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                            }
                        }

                        if( _filter?.Length > 0
                            && _list?.DataSource != null )
                        {
                            BindingSource.DataSource = _list?.DataSource;
                            BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray() );
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

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="data">The data.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data ) where T1 : IEnumerable<T1>
        {
            if( Verify.IsSequence( data ) )
            {
                try
                {
                    BindingSource.DataSource = data?.ToList();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<T1>
        {
            if( Verify.IsSequence( data ) )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        if( Verify.IsInput( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList();
                    BindingSource.Filter = _filter.TrimEnd( " AND".ToCharArray() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        public void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<T1> where T2 : struct
        {
            if( Verify.IsSequence( data )
                && BudgetExecution.Verify.IsField( field ) )
            {
                try
                {
                    if( Verify.IsInput( filter?.ToString() ) )
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, object field = null ) where T1 : IEnumerable<T1>
        {
            if( Verify.IsInput( data ) )
            {
                try
                {
                    if( Verify.IsInput( field?.ToString() ) )
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field?.ToString();
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<T1> where T2 : IDictionary<string, object>
        {
            if( Verify.IsSequence( data )
                && Verify.IsMap( dict ) )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var kvp in dict )
                    {
                        if( Verify.IsInput( kvp.Key )
                            && kvp.Value != null )
                        {
                            _filter += $"{kvp.Key} = {kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList();
                    BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray() );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<T1> where T2 : struct
        {
            if( Verify.IsSequence( data )
                && BudgetExecution.Verify.IsField( field ) )
            {
                try
                {
                    if( Verify.IsInput( filter?.ToString() ) )
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList();
                        BindingSource.DataMember = field.ToString();
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();

            // 
            // ControlData
            // 
            BackColor = Color.FromArgb( 10, 10, 11 );

            Font = new Font( "Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point,
                0 );

            ForeColor = Color.LightGray;
            Name = "ControlData";
            ResumeLayout( false );
        }
    }
}