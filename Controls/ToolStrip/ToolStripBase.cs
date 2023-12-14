//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ToolStripBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ToolStripBase.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    ToolStripBase.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.ToolStripEx" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public abstract class ToolStripBase : ToolStripEx
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the separators.
        /// </summary>
        /// <value>
        /// The separators.
        /// </value>
        public virtual IEnumerable<ToolSeparator> Separators { get; set; }

        /// <summary>
        /// Gets or sets the drop down.
        /// </summary>
        /// <value>
        /// The drop down.
        /// </value>
        public virtual ToolStripDropDown DropDown { get; set; }

        /// <summary>
        /// Gets or sets the text box.
        /// </summary>
        /// <value>
        /// The text box.
        /// </value>
        public virtual ToolStripTextBox TextBox { get; set; }

        /// <summary>
        /// Gets or sets the first button.
        /// </summary>
        /// <value>
        /// The first button.
        /// </value>
        public virtual ToolStripButton FirstButton { get; set; }

        /// <summary>
        /// Gets or sets the previous button.
        /// </summary>
        /// <value>
        /// The previous button.
        /// </value>
        public virtual ToolStripButton PreviousButton { get; set; }

        /// <summary>
        /// Gets or sets the next button.
        /// </summary>
        /// <value>
        /// The next button.
        /// </value>
        public virtual ToolStripButton NextButton { get; set; }

        /// <summary>
        /// Gets or sets the last button.
        /// </summary>
        /// <value>
        /// The last button.
        /// </value>
        public virtual ToolStripButton LastButton { get; set; }

        /// <summary>
        /// Gets or sets the add button.
        /// </summary>
        /// <value>
        /// The add button.
        /// </value>
        public virtual ToolStripButton AddButton { get; set; }

        /// <summary>
        /// Gets or sets the delete button.
        /// </summary>
        /// <value>
        /// The delete button.
        /// </value>
        public virtual ToolStripButton DeleteButton { get; set; }

        /// <summary>
        /// Gets or sets the edit button.
        /// </summary>
        /// <value>
        /// The edit button.
        /// </value>
        public virtual ToolStripButton EditButton { get; set; }

        /// <summary>
        /// Gets or sets the edit column button.
        /// </summary>
        /// <value>
        /// The edit column button.
        /// </value>
        public virtual ToolStripButton EditColumnButton { get; set; }

        /// <summary>
        /// Gets or sets the edit record button.
        /// </summary>
        /// <value>
        /// The edit record button.
        /// </value>
        public virtual ToolStripButton EditRecordButton { get; set; }

        /// <summary>
        /// Gets or sets the edit SQL button.
        /// </summary>
        /// <value>
        /// The edit SQL button.
        /// </value>
        public virtual ToolStripButton EditSqlButton { get; set; }

        /// <summary>
        /// Gets or sets the add table button.
        /// </summary>
        /// <value>
        /// The add table button.
        /// </value>
        public virtual ToolStripButton AddTableButton { get; set; }

        /// <summary>
        /// Gets or sets the filter data button.
        /// </summary>
        /// <value>
        /// The filter data button.
        /// </value>
        public virtual ToolStripButton FilterDataButton { get; set; }

        /// <summary>
        /// Gets or sets the add column button.
        /// </summary>
        /// <value>
        /// The add column button.
        /// </value>
        public virtual ToolStripButton AddColumnButton { get; set; }

        /// <summary>
        /// Gets or sets the delete table button.
        /// </summary>
        /// <value>
        /// The delete table button.
        /// </value>
        public virtual ToolStripButton DeleteTableButton { get; set; }

        /// <summary>
        /// Gets or sets the delete column button.
        /// </summary>
        /// <value>
        /// The delete column button.
        /// </value>
        public virtual ToolStripButton DeleteColumnButton { get; set; }

        /// <summary>
        /// Gets or sets the delete record button.
        /// </summary>
        /// <value>
        /// The delete record button.
        /// </value>
        public virtual ToolStripButton DeleteRecordButton { get; set; }

        /// <summary>
        /// Gets or sets the save button.
        /// </summary>
        /// <value>
        /// The save button.
        /// </value>
        public virtual ToolStripButton SaveButton { get; set; }

        /// <summary>
        /// Gets or sets the refresh button.
        /// </summary>
        /// <value>
        /// The refresh button.
        /// </value>
        public virtual ToolStripButton RefreshButton { get; set; }

        /// <summary>
        /// Gets or sets the excel button.
        /// </summary>
        /// <value>
        /// The excel button.
        /// </value>
        public virtual ToolStripButton ExcelButton { get; set; }

        /// <summary>
        /// Gets or sets the calculator button.
        /// </summary>
        /// <value>
        /// The calculator button.
        /// </value>
        public virtual ToolStripButton CalculatorButton { get; set; }

        /// <summary>
        /// Gets or sets the chart button.
        /// </summary>
        /// <value>
        /// The chart button.
        /// </value>
        public virtual ToolStripButton ChartButton { get; set; }

        /// <summary>
        /// Gets or sets the home button.
        /// </summary>
        /// <value>
        /// The home button.
        /// </value>
        public virtual ToolStripButton HomeButton { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ToolStripBase" /> class.
        /// </summary>
        protected ToolStripBase( )
        {
        }

        /// <summary>
        /// Adds the text box.
        /// </summary>
        public virtual void AddTextBox( )
        {
            try
            {
                var _textBox = new ToolStripTextBox( );
                Items?.Add( _textBox );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the ComboBox.
        /// </summary>
        public virtual void AddComboBox( )
        {
            try
            {
                var _comboBox = new ToolStripComboBoxEx( );
                Items?.Add( _comboBox );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the drop down item.
        /// </summary>
        /// <param name="item">The item.</param>
        public virtual void AddDropDownItem( object item )
        {
            if( item != null )
            {
                try
                {
                    DropDown?.ComboBox?.Items.Add( item );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Resets the drop down list.
        /// </summary>
        /// <param name="items">The items.</param>
        public virtual void ResetDropDownList( IEnumerable<object> items )
        {
            try
            {
                DropDown?.ComboBox.Items?.Clear( );
                if( items?.Count( ) > 0 )
                {
                    foreach( var _item in items )
                    {
                        DropDown?.ComboBox?.Items?.Add( _item );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Adds the separator.
        /// </summary>
        public virtual void AddSeparator( )
        {
            try
            {
                var _separator = new ToolSeparator( );
                Items?.Add( _separator );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}