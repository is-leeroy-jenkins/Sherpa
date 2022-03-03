// <copyright file = "BarComboBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class BudgetToolStripComboBox : ToolStripComboBoxBase, IToolStripComboBox
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStripComboBox"/> class.
        /// </summary>
        public BudgetToolStripComboBox()
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            Size = new Size( 175, 23 );
            DropDownStyle = ComboBoxStyle.DropDownList;
            MaxDropDownItems = 100;
            DroppedDown = true;
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.White;
            Font = new Font( "Roboto", 9 );
            Field = Field.NS;
            Tag = "Make Selection";
            ToolTipText = Tag.ToString();
            HoverText = Tag.ToString();
            Text = string.Empty;
            Visible = true;
            Enabled = true;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStripComboBox"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public BudgetToolStripComboBox( IEnumerable<object> data )
            : this()
        {
            BindingSource.DataSource = data?.ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStripComboBox"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        public BudgetToolStripComboBox( IEnumerable<object> data, string filter )
            : this( data )
        {
            BindingSource.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStripComboBox"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="filter">The filter.</param>
        public BudgetToolStripComboBox( IEnumerable<DataRow> data, string filter )
            : this()
        {
            BindingSource.DataSource = data.ToList();
            BindingSource.DataMember = filter;
        }

        /// <summary>
        /// Gets the selected item.
        /// </summary>
        /// <returns></returns>
        public object GetSelectedItem()
        {
            if( Selected 
                && SelectedIndex > -1 )
            {
                try
                {
                    return Items[ SelectedIndex ];
                }
                catch ( Exception ex )
                {
                    Fail( ex  );
                    return null;
                }
            }

            return null;
        }

        /// <summary> Sets the data source. </summary>
        /// <param name = "bindingSource" > The bindingsource. </param>
        public void SetDataSource( BindingSource bindingSource )
        {
            if( bindingSource?.DataSource != null )
            {
                try
                {
                    BindingSource.DataSource = bindingSource.DataSource;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary> Called when [mouse over]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as BudgetToolStripComboBox;

                if( _button != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var tip = new ToolTip( _button );
                    ToolTip = tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString() ) )
                    {
                        var tool = new ToolTip( _button );
                        ToolTip = tool;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll();
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Called when [item selected]. </summary>
        /// <param name = "sender" > The sender. </param>
        /// <param name = "e" >
        /// The
        /// <see cref = "EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnItemSelected( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var _message = new Message( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}