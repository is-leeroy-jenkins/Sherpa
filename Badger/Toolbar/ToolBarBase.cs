// <copyright file = "ToolBarBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms.Tools;
    
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ToolbarBase : ToolStripEx
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the setting.
        /// </summary>
        /// <value>
        /// The setting.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;
        
        /// <summary>
        /// The image path
        /// </summary>
        public string ImagePath { get; set; } 

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingSource.</param>
        public virtual void SetDataSource<T1>( T1 bindingSource ) 
            where T1 : IBindingList
        {
            try
            {
                if( bindingSource is BindingSource _binder
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
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindingList">The bindingSource.</param>
        /// <param name="dict">The dictionary.</param>
        public virtual void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList 
            where T2 : IDictionary<string, object>
        {
            try
            {
                if( Verify.IsBindable( bindingList )
                    && Verify.IsMap( dict ) )
                {
                    try
                    {
                        var _list = bindingList as BindingSource;
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
        /// <param name="data">The data.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data ) 
            where T1 : IEnumerable<T1>
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
        public virtual void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
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
        public virtual void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<T1> 
            where T2 : struct
        {
            if( Verify.IsSequence( data )
                && Validate.IsField( field ) )
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
        public virtual void SetDataSource<T1>( IEnumerable<T1> data, object field = null ) 
            where T1 : IEnumerable<T1>
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
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<T1> 
            where T2 : IDictionary<string, object>
        {
            if( Verify.IsSequence( data )
                && Verify.IsMap( dict ) )
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
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<T1> 
            where T2 : struct
        {
            if( Verify.IsSequence( data )
                && Validate.IsField( field ) )
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
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public virtual void SetField( Field field )
        {
            try
            {
                Field = BudgetForm.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <param name = "imageName" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        public virtual BarButton CreateButton( string imageName )
        {
            if( Verify.IsInput( imageName ) )
            {
                try
                {
                    var _image = new BudgetImage( imageName, ImageSource.ToolBarImages, ImageSizer.Small );
                    var _button = new BarButton( _image );
                    Items?.Add( _button );

                    return Items?.Count > 0
                        ? _button
                        : default( BarButton );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BarButton );
                }
            }

            return default( BarButton );
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual BarLabel CreateLabel()
        {
            try
            {
                var _label = new BarLabel();
                Items?.Add( _label );

                return ( _label?.BindingSource != null && Items?.Count > 0 )
                    ? _label
                    : default( BarLabel );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BarLabel );
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual BarComboBox CreateComboBox()
        {
            try
            {
                var _comboBox = new BarComboBox();
                Items?.Add( _comboBox );

                return ( Items?.Count > 0 )
                    ? _comboBox
                    : default( BarComboBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BarComboBox );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual BarTextBox CreateTextBox()
        {
            try
            {
                var _textBox = new BarTextBox();
                Items?.Add( _textBox );

                return ( Items?.Count > 0 )
                    ? _textBox
                    : default( BarTextBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BarTextBox );
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