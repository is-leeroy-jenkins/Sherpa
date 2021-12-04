// <copyright file = "IBudgetGrid.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    public interface IBudgetGrid
    {
        /// <summary>
        /// Sets the width of the column.
        /// </summary>
        /// <param name="columns">The columns.</param>
        void SetColumnWidth( GridBoundColumnsCollection columns );

        /// <summary>
        /// Sets the grid bound data columns.
        /// </summary>
        /// <param name="data">The data.</param>
        void SetGridBoundDataColumns( IEnumerable<DataRow> data );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetBindingSource( IEnumerable<DataRow> data, IDictionary<string, object> dict = null );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="dict">The dictionary.</param>
        void SetBindingSource( BindingSource bindingSource, IDictionary<string, object> dict = null );

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="gridColumns">The grid columns.</param>
        void PascalizeHeaders( IEnumerable<DataRow> data, GridBoundColumnsCollection gridColumns );

        /// <summary>
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        string GetFilterValues( IDictionary<string, object> dict );

        /// <summary>
        /// Gets the current row.
        /// </summary>
        /// <returns></returns>
        DataRow GetCurrentRow();

        /// <summary>
        /// Sets the grid panel.
        /// </summary>
        void SetGridPanel();

        /// <summary>
        /// Sets the tool bar.
        /// </summary>
        void SetToolBar();

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void OnRightClick( object sender, MouseEventArgs e );

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void OnCurrentChanged( object sender, EventArgs e );

        /// <summary>
        /// Models the on selection changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="GridSelectionChangedEventArgs"/> instance containing the event data.</param>
        void ModelOnSelectionChanged( object sender, GridSelectionChangedEventArgs e );

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        void SetField( Field field );

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="bindingsource">The bindingsource.</param>
        void SetDataSource<T1>( T1 bindingsource ) where T1 : IBindingList;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindinglist">The bindinglist.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1, T2>( T1 bindinglist, T2 dict )
            where T1 : IBindingList where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        void SetDataSource<T1>( IEnumerable<T1> data ) where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow> where T2 : struct;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, object field = null ) where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow> where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow> where T2 : struct;
    }
}