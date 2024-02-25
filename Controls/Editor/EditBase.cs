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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public partial class EditBase : MetroForm
    {
        /// <summary>
        /// The source
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private protected Provider _provider;

        /// <summary>
        /// The selected columns
        /// </summary>
        private protected IList<string> _selectedColumns;

        /// <summary>
        /// The selected fields
        /// </summary>
        private protected IList<string> _selectedFields;

        /// <summary>
        /// The selected numerics
        /// </summary>
        private protected IList<string> _selectedNumerics;

        /// <summary>
        /// The selected table
        /// </summary>
        private protected string _selectedTable;

        /// <summary>
        /// The data model
        /// </summary>
        private protected DataBuilder _dataModel;

        /// <summary>
        /// The data table
        /// </summary>
        private protected DataTable _dataTable;

        /// <summary>
        /// The current
        /// </summary>
        private protected DataRow _current;

        /// <summary>
        /// The SQL command
        /// </summary>
        private protected string _sqlQuery;

        /// <summary>
        /// The yvalues
        /// </summary>
        private protected IList<string> _columns;

        /// <summary>
        /// The filter
        /// </summary>
        private protected IDictionary<string, object> _filter;

        /// <summary>
        /// The fields
        /// </summary>
        private protected IList<string> _fields;

        /// <summary>
        /// The data arguments
        /// </summary>
        private protected DataArgs _dataArgs;

        /// <summary>
        /// The numerics
        /// </summary>
        private protected IList<string> _numerics;

        /// <summary>
        /// The dates
        /// </summary>
        private protected IList<DateTime> _dates;

        /// <summary>
        /// The panels
        /// </summary>
        private protected IDictionary<string, BackPanel> _panels;

        /// <summary>
        /// The list boxes
        /// </summary>
        private protected IDictionary<string, ListBox> _listBoxes;

        /// <summary>
        /// The command type
        /// </summary>
        private protected SQL _commandType;

        /// <summary>
        /// The labels
        /// </summary>
        private protected IDictionary<string, Label> _labels;

        /// <summary>
        /// The tab pages
        /// </summary>
        private protected IDictionary<string, TabPageAdv> _tabPages;

        /// <summary>
        /// The radio buttons
        /// </summary>
        private protected IDictionary<string, RadioButton> _radioButtons;

        /// <summary>
        /// The combo boxes
        /// </summary>
        private protected IDictionary<string, ComboBox> _comboBoxes;

        /// <summary>
        /// The text boxes
        /// </summary>
        private protected IList<TextBox> _textBoxes;

        /// <summary>
        /// The data types
        /// </summary>
        private protected IList<string> _dataTypes;

        /// <summary>
        /// The tool
        /// </summary>
        private protected ToolType _toolType;

        /// <summary>
        /// The active tab
        /// </summary>
        private protected TabPageAdv _activeTab;

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType
        {
            get
            {
                return _commandType;
            }
            private protected set
            {
                _commandType = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public ToolType Tool
        {
            get
            {
                return _toolType;
            }
            private protected set
            {
                _toolType = value;
            }
        }

        /// <summary>
        /// Gets or sets the active tab.
        /// </summary>
        /// <value>
        /// The active tab.
        /// </value>
        public TabPageAdv ActiveTab
        {
            get
            {
                return _activeTab;
            }
            private protected set
            {
                _activeTab = value;
            }
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <value>
        /// The SQL command.
        /// </value>
        public string SqlQuery
        {
            get
            {
                return _sqlQuery;
            }
            private protected set
            {
                _sqlQuery = value;
            }
        }

        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IList<string> Columns
        {
            get
            {
                return _columns;
            }
            private protected set
            {
                _columns = value;
            }
        }

        /// <summary>
        /// Gets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable
        {
            get
            {
                return _selectedTable;
            }
            private protected set
            {
                _selectedTable = value;
            }
        }

        /// <summary>
        /// Gets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel
        {
            get
            {
                return _dataModel;
            }
            private protected set
            {
                _dataModel = value;
            }
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            private protected set
            {
                _dataTable = value;
            }
        }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current
        {
            get
            {
                return _current;
            }
            private protected set
            {
                _current = value;
            }
        }

        /// <summary>
        /// Gets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> Filter
        {
            get
            {
                return _filter;
            }
            private protected set
            {
                _filter = value;
            }
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields
        {
            get
            {
                return _fields;
            }
            private protected set
            {
                _fields = value;
            }
        }

        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics
        {
            get
            {
                return _numerics;
            }
            private protected set
            {
                _numerics = value;
            }
        }

        /// <summary>
        /// Gets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns
        {
            get
            {
                return _selectedColumns;
            }
            private protected set
            {
                _selectedColumns = value;
            }
        }

        /// <summary>
        /// Gets the selected fields.
        /// </summary>
        /// <value>
        /// The selected fields.
        /// </value>
        public IList<string> SelectedFields
        {
            get
            {
                return _selectedFields;
            }
            private protected set
            {
                _selectedFields = value;
            }
        }

        /// <summary>
        /// Gets the selected numerics.
        /// </summary>
        /// <value>
        /// The selected numerics.
        /// </value>
        public IList<string> SelectedNumerics
        {
            get
            {
                return _selectedNumerics;
            }
            private protected set
            {
                _selectedNumerics = value;
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source
        {
            get
            {
                return _source;
            }
            private protected set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider
        {
            get
            {
                return _provider;
            }
            private protected set
            {
                _provider = value;
            }
        }

        /// <summary>
        /// Gets or sets the dates.
        /// </summary>
        /// <value>
        /// The dates.
        /// </value>
        public IList<DateTime> Dates
        {
            get
            {
                return _dates;
            }
            private protected set
            {
                _dates = value;
            }
        }

        /// <summary>
        /// Gets or sets the panels.
        /// </summary>
        /// <value>
        /// The panels.
        /// </value>
        public IDictionary<string, BackPanel> Panels
        {
            get
            {
                return _panels;
            }
            private protected set
            {
                _panels = value;
            }
        }

        /// <summary>
        /// Gets or sets the list boxes.
        /// </summary>
        /// <value>
        /// The list boxes.
        /// </value>
        public IDictionary<string, ListBox> ListBoxes
        {
            get
            {
                return _listBoxes;
            }
            private protected set
            {
                _listBoxes = value;
            }
        }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public IDictionary<string, Label> Labels
        {
            get
            {
                return _labels;
            }
            private protected set
            {
                _labels = value;
            }
        }

        /// <summary>
        /// Gets or sets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        public IDictionary<string, TabPageAdv> TabPages
        {
            get
            {
                return _tabPages;
            }
            private protected set
            {
                _tabPages = value;
            }
        }

        /// <summary>
        /// Gets or sets the radio buttons.
        /// </summary>
        /// <value>
        /// The radio buttons.
        /// </value>
        public IDictionary<string, RadioButton> RadioButtons
        {
            get
            {
                return _radioButtons;
            }
            private protected set
            {
                _radioButtons = value;
            }
        }

        /// <summary>
        /// Gets or sets the combo boxes.
        /// </summary>
        /// <value>
        /// The combo boxes.
        /// </value>
        public IDictionary<string, ComboBox> ComboBoxes
        {
            get
            {
                return _comboBoxes;
            }
            private protected set
            {
                _comboBoxes = value;
            }
        }

        /// <summary>
        /// Gets or sets the text boxes.
        /// </summary>
        /// <value>
        /// The text boxes.
        /// </value>
        public IList<TextBox> TextBoxes
        {
            get
            {
                return _textBoxes;
            }
            private protected set
            {
                _textBoxes = value;
            }
        }

        /// <summary>
        /// Gets or sets the data types.
        /// </summary>
        /// <value>
        /// The data types.
        /// </value>
        public IList<string> DataTypes
        {
            get
            {
                return _dataTypes;
            }
            private protected set
            {
                _dataTypes = value;
            }
        }

        /// <summary>
        /// Gets the data arguments.
        /// </summary>
        /// <value>
        /// The data arguments.
        /// </value>
        public DataArgs DataArgs
        {
            get
            {
                return _dataArgs;
            }
            private protected set
            {
                _dataArgs = value;
            }
        }

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
        private protected IList<string> GetDataTypes( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    var _database = provider.ToString( );
                    var _model = new DataBuilder( Source.SchemaTypes, Provider.Access );
                    var _data = _model.DataTable;
                    var _list = _data.AsEnumerable( )
                        ?.Where( c => c.Field<string>( "Database" ).Equals( _database ) )
                        ?.Select( c => c.Field<string>( "TypeName" ) )
                        ?.ToList( );

                    return _list.Count > 0
                        ? _list
                        : default( IList<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
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
                ThrowIf.Null( text, nameof( text ) );
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
                ThrowIf.Null( text, nameof( text ) );
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
                _tabPages = new Dictionary<string, TabPageAdv>( );
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
                _radioButtons = new Dictionary<string, RadioButton>( );
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
                _comboBoxes = new Dictionary<string, ComboBox>( );
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
                _panels = new Dictionary<string, BackPanel>( );
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
                _listBoxes = new Dictionary<string, ListBox>( );
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