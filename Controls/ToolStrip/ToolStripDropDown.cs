//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                ToolStripDropDown.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="ToolStripDropDown.cs" company="Terry D. Eppler">
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
//    ToolStripDropDown.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ToolStripDropDownBase"/>
    /// <seealso cref="T:BudgetExecution.IToolStripComboBox"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ToolStripDropDown : ToolStripDropDownBase
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx"/>
        /// class.
        /// </summary>
        public ToolStripDropDown( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            Size = new Size( 150, 24 );
            DropDownStyle = ComboBoxStyle.DropDownList;
            AllowDrop = true;
            MaxDropDownItems = 100;
            BackColor = Color.FromArgb( 40, 40, 40 );
            ForeColor = Color.FromArgb( 0, 120, 212 );
            Font = new Font( "Roboto", 8 );
            ToolTipText = "Make Selection";
            HoverText = ToolTipText;
            Visible = true;
            Enabled = true;
            Style = ToolStripExStyle.Office2016Black;
            ToolTip = new SmallTip( this, ToolTipText );
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx"/>
        /// class.
        /// </summary>
        /// <param name="data"> The data. </param>
        public ToolStripDropDown( IEnumerable<object> data )
            : this( )
        {
            BindingSource.DataSource = data?.ToList( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx"/>
        /// class.
        /// </summary>
        /// <param name="data"> The data. </param>
        /// <param name="filter"> The filter. </param>
        public ToolStripDropDown( IEnumerable<object> data, string filter )
            : this( data )
        {
            BindingSource.Filter = filter;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx"/>
        /// class.
        /// </summary>
        /// <param name="data"> The data. </param>
        /// <param name="filter"> The filter. </param>
        public ToolStripDropDown( IEnumerable<DataRow> data, string filter )
            : this( )
        {
            BindingSource.DataSource = data?.ToList( );
            BindingSource.DataMember = filter;
        }

        /// <inheritdoc/>
        /// <summary> Sets the data source. </summary>
        /// <param name="bindingSource"> The binding source. </param>
        public void SetDataSource( BindingSource bindingSource )
        {
            if( bindingSource?.DataSource != null )
            {
                try
                {
                    BindingSource.DataSource = bindingSource.DataSource;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <inheritdoc/>
        /// <summary> Called when [mouse over]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="T:System.EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _comboBox = sender as ToolStripDropDown;
                if( !string.IsNullOrEmpty( _comboBox?.HoverText ) )
                {
                    var _text = _comboBox?.HoverText;
                    var _ = new SmallTip( _comboBox, _text );
                }
                else
                {
                    if( !string.IsNullOrEmpty( _comboBox?.Tag?.ToString( ) ) )
                    {
                        var _text = _comboBox?.Tag?.ToString( )?.SplitPascal( );
                        var _ = new SmallTip( _comboBox, _text );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc/>
        /// <summary> Called when [item selected]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="T:System.EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnItemSelected( object sender, EventArgs e )
        {
            if( ( sender != null )
               && ( e != null ) )
            {
                try
                {
                    var _message = new Message( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Gets the selected item. </summary>
        /// <returns> </returns>
        public object GetSelectedItem( )
        {
            if( Selected && ( SelectedIndex > -1 ) )
            {
                try
                {
                    return ComboBox.Items[ SelectedIndex ];
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return null;
                }
            }

            return null;
        }

        /// <summary> Gets the selected item. </summary>
        /// <returns> </returns>
        public void AddItem( object item )
        {
            if( item != null )
            {
                try
                {
                    ComboBox.Items.Add( item );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Called when [mouse leave]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}