//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                EditBase.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="EditBase.cs" company="Terry D. Eppler">
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
//    EditBase.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertTypeCheckPatternToNullCheck" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public partial class EditBase : MetroForm
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public ToolType Tool { get; set; }

        /// <summary>
        /// Gets or sets the active tab.
        /// </summary>
        /// <value>
        /// The active tab.
        /// </value>
        public TabPageAdv ActiveTab { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IList<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the numeric fields.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the dates.
        /// </summary>
        /// <value>
        /// The dates.
        /// </value>
        public IList<DateTime> Dates { get; set; }

        /// <summary>
        /// Gets or sets the selected column.
        /// </summary>
        /// <value>
        /// The selected column.
        /// </value>
        public string SelectedColumn { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> Filter { get; set; }

        /// <summary>
        /// Gets or sets the panels.
        /// </summary>
        /// <value>
        /// The panels.
        /// </value>
        public IDictionary<string, BackPanel> Panels { get; set; }

        /// <summary>
        /// Gets or sets the list boxes.
        /// </summary>
        /// <value>
        /// The list boxes.
        /// </value>
        public IDictionary<string, ListBox> ListBoxes { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public IEnumerable<Label> Labels { get; set; }

        /// <summary>
        /// Gets or sets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        public IDictionary<string, TabPageAdv> TabPages { get; set; }

        /// <summary>
        /// Gets or sets the radio buttons.
        /// </summary>
        /// <value>
        /// The radio buttons.
        /// </value>
        public IDictionary<string, RadioButton> RadioButtons { get; set; }

        /// <summary>
        /// Gets or sets the combo boxes.
        /// </summary>
        /// <value>
        /// The combo boxes.
        /// </value>
        public IDictionary<string, ComboBox> ComboBoxes { get; set; }

        /// <summary>
        /// Gets or sets the text boxes.
        /// </summary>
        /// <value>
        /// The text boxes.
        /// </value>
        public IEnumerable<TextBox> TextBoxes { get; set; }

        /// <summary>
        /// Gets or sets the data types.
        /// </summary>
        /// <value>
        /// The data types.
        /// </value>
        public IEnumerable<string> DataTypes { get; set; }

        /// <summary>
        /// Gets or sets the state of the view.
        /// </summary>
        /// <value>
        /// The state of the view.
        /// </value>
        public DataArgs DataArgs { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.EditBase"/>
        /// class.
        /// </summary>
        protected EditBase( )
        {
        }

        /// <summary>
        /// Gets the data types.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <returns>
        /// IEnumerable
        /// </returns>
        private protected IEnumerable<string> GetDataTypes( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    var _query = "SELECT DISTINCT SchemaTypes.TypeName"
                        + " FROM SchemaTypes"
                        + $" WHERE SchemaTypes.Database = '{provider}'";

                    var _model = new DataBuilder( Source.SchemaTypes, Provider.Access, _query );
                    var _data = _model.DataTable.GetUniqueColumnValues( "TypeName" );
                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns>
        /// IEnumerable
        /// </returns>
        private protected IEnumerable<Control> GetControls( )
        {
            var _list = new List<Control>( );
            var _queue = new Queue( );
            try
            {
                _queue.Enqueue( Controls );
                while( _queue.Count > 0 )
                {
                    var _collection = (Control.ControlCollection)_queue.Dequeue( );
                    if( _collection?.Count > 0 )
                    {
                        foreach( Control _control in _collection )
                        {
                            _list.Add( _control );
                            _queue.Enqueue( _control.Controls );
                        }
                    }
                }

                return _list?.Any( ) == true
                    ? _list.ToArray( )
                    : default( Control[ ] );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Control[ ] );
            }
        }

        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        private protected void SendNotification( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                var _notification = new Notification( text );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        private protected void SendMessage( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                var _message = new SplashMessage( text );
                _message.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private protected IDictionary<string, TabPageAdv> GetTabPages( )
        {
            try
            {
                var _tabPages = new Dictionary<string, TabPageAdv>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( TabPageAdv ) )
                    {
                        _tabPages.Add( _control.Name, _control as TabPageAdv );
                    }
                }

                return _tabPages?.Any( ) == true
                    ? _tabPages
                    : default( IDictionary<string, TabPageAdv> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, TabPageAdv> );
            }
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private protected IDictionary<string, RadioButton> GetRadioButtons( )
        {
            try
            {
                var _radioButtons = new Dictionary<string, RadioButton>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( RadioButton ) )
                    {
                        _radioButtons.Add( _control.Name, _control as RadioButton );
                    }
                }

                return _radioButtons?.Any( ) == true
                    ? _radioButtons
                    : default( IDictionary<string, RadioButton> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, RadioButton> );
            }
        }

        /// <summary>
        /// Gets the combo boxes.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private protected IDictionary<string, ComboBox> GetComboBoxes( )
        {
            try
            {
                var _comboBoxes = new Dictionary<string, ComboBox>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( ComboBox ) )
                    {
                        _comboBoxes.Add( _control.Name, _control as ComboBox );
                    }
                }

                return _comboBoxes?.Any( ) == true
                    ? _comboBoxes
                    : default( IDictionary<string, ComboBox> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, ComboBox> );
            }
        }

        /// <summary>
        /// Gets the panels.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private protected IDictionary<string, BackPanel> GetPanels( )
        {
            try
            {
                var _panels = new Dictionary<string, BackPanel>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control.GetType( ) == typeof( BackPanel ) )
                    {
                        _panels.Add( _control.Name, _control as BackPanel );
                    }
                }

                return _panels?.Any( ) == true
                    ? _panels
                    : default( IDictionary<string, BackPanel> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, BackPanel> );
            }
        }

        /// <summary>
        /// Gets the list boxes.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private protected IDictionary<string, ListBox> GetListBoxes( )
        {
            try
            {
                var _listBoxes = new Dictionary<string, ListBox>( );
                foreach( var _control in GetControls( ) )
                {
                    if( _control is ListBox _listBox )
                    {
                        _listBoxes.Add( _listBox.Name, _listBox );
                    }
                }

                return _listBoxes?.Any( ) == true
                    ? _listBoxes
                    : default( IDictionary<string, ListBox> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, ListBox> );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}