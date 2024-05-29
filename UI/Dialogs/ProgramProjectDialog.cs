// ******************************************************************************************
//     Assembly:             Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        11-22-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ProgramProjectDialog.cs.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public partial class ProgramProjectDialog : MetroForm
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private object _path;

        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <summary>
        /// 
        /// </summary>
        private int _time;

        /// <summary>
        /// 
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The source
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private protected Provider _provider;

        /// <summary>
        /// The ext
        /// </summary>
        private protected EXT _extension;

        /// <summary>
        /// The SQL command
        /// </summary>
        private protected string _sqlQuery;

        /// <summary>
        /// The selected table
        /// </summary>
        private protected string _selectedValue;

        /// <summary>
        /// The selected path
        /// </summary>
        private protected string _selectedProgram;

        /// <summary>
        /// The filter
        /// </summary>
        private protected IDictionary<string, object> _filter;

        /// <summary>
        /// The program codes
        /// </summary>
        private protected IList<string> _programCodes;

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
        /// The data arguments
        /// </summary>
        private protected DataArgs _dataArgs;
        
        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// </value>
        public bool IsBusy
        {
            get
            {
                return _busy;
            }
            private set
            {
                _busy = value;
            }
        }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
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
        /// Gets or sets the data model.
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
        /// Gets or sets the data table.
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
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
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
        /// Gets or sets the source.
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
        /// Gets or sets the provider.
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
        /// Gets or sets the extenstion.
        /// </summary>
        /// <value>
        /// The extenstion.
        /// </value>
        public EXT Extension
        {
            get
            {
                return _extension;
            }
            private protected set
            {
                _extension = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected value.
        /// </summary>
        /// <value>
        /// The selected value.
        /// </value>
        public string SelectedValue
        {
            get
            {
                return _selectedValue;
            }
            private protected set
            {
                _selectedValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected program.
        /// </summary>
        /// <value>
        /// The selected program.
        /// </value>
        public string SelectedProgram
        {
            get
            {
                return _selectedProgram;
            }
            private protected set
            {
                _selectedProgram = value;
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
        /// Gets or sets the program codes.
        /// </summary>
        /// <value>
        /// The program codes.
        /// </value>
        public IList<string> ProgramCodes { get; set; }
        
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ProgramProjectDialog"/>
        /// class.
        /// </summary>
        public ProgramProjectDialog( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
            Size = new Size( 1066, 614 );
            MaximumSize = new Size( 1066, 614 );
            MinimumSize = new Size( 1066, 614 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 106, 189, 252 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Normal;
            SizeGripStyle = SizeGripStyle.Auto;
            AutoScaleMode = AutoScaleMode.Font;
            ShowIcon = false;
            ShowInTaskbar = true;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Bind DataSource
            _source = Source.ProgramProjectDescriptions;
            _provider = Provider.Access;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Budget Attributes
            _filter = new Dictionary<string, object>( );
            _dataArgs = new DataArgs( );

            // Event Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.ProgramProjectDialog"/>
        /// class.
        /// </summary>
        /// <param name="code"> The code. </param>
        public ProgramProjectDialog( string code )
            : this( )
        {
            _selectedProgram = code;
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Header.ForeColor = Color.FromArgb( 106, 189, 252 );
                Header.Font = new Font( "Roboto", 10 );
                ProgramAreaTable.CaptionText = "Program Area - ";
                ProgramAreaTable.Font = new Font( "Roboto", 10 );
                ProgramProjectTable.CaptionText = "Program Project - ";
                ProgramProjectTable.Font = new Font( "Roboto", 10 );
                StatuteTable.Font = new Font( "Roboto", 10 );
                StatutoryAuthorityTextBox.Font = new Font( "Roboto", 10 );
                StatutoryAuthorityTextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                ProgramAreaNameTextBox.Font = new Font( "Roboto", 10 );
                ProgramAreaNameTextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
                ProgramProjectNameTextBox.Font = new Font( "Roboto", 10 );
                ProgramProjectNameTextBox.ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the delegates.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += UpdateStatus;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                SearchButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                MenuButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                CloseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                CloseButton.Click += OnCloseButtonClicked;
                SearchButton.Click += OnSearchButtonClicked;
                ComboBox.SelectedValueChanged += OnComboBoxSelectionChanged;
                MenuButton.Click += OnMenuButtonClick;
                Timer.Tick += OnTimerTick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
        {
            try
            {
                // Timer Properties
                Timer.Interval = 80;
                Timer.Tick += OnTimerTick;
                Timer.Enabled = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public void InvokeIf( Action action )
        {
            try
            {
                if( InvokeRequired )
                {
                    BeginInvoke( action );
                }
                else
                {
                    action.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Begins the initialize.
        /// </summary>
        private void BeginInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private void EndInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeInAsync( Form form, int interval = 10 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity < 1.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity += 0.02;
                }

                form.Opacity = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeOutAsync( Form form, int interval = 50 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity > 0.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity -= 0.01;
                }

                form.Opacity = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Captures the state.
        /// </summary>
        private void CaptureState( )
        {
            try
            {
                _dataArgs.Provider = _provider;
                _dataArgs.Source = _source;
                _dataArgs.Filter = _filter;
                _dataArgs.SqlQuery = _sqlQuery;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the combo boxes.
        /// </summary>
        private void ClearComboBoxes( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the list boxes.
        /// </summary>
        private void ClearListBoxes( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the header text.
        /// </summary>
        private void ClearLabels( )
        {
            try
            {
                DescriptionTable.CaptionText = "Program Description";
                StatutoryAuthorityTextBox.Text = string.Empty;
                ProgramAreaNameTextBox.Text = string.Empty;
                ProgramProjectNameTextBox.Text = string.Empty;
                ProgramDescriptionTextBox.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Clears the program text. </summary>
        private void ClearProgramText( )
        {
            try
            {
                DescriptionTable.CaptionText = "Program Description";
                StatutoryAuthorityTextBox.Text = string.Empty;
                ProgramAreaNameTextBox.Text = string.Empty;
                ProgramProjectNameTextBox.Text = string.Empty;
                ProgramDescriptionTextBox.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the ComboBox items.
        /// </summary>
        private void PopulateComboBoxItems( )
        {
            try
            {
                ComboBox.Items?.Clear( );
                _dataModel = new DataBuilder( _source, _provider );
                var _codes = _dataModel.DataElements[ "ProgramTitle" ];
                foreach( var _item in _codes )
                {
                    ComboBox.Items.Add( _item );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                var _form = (MainForm)Program.Windows[ nameof( MainForm ) ];
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.TopMost = true;
                _form.Visible = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the data.
        /// </summary>
        private void BindData( )
        {
            try
            {
                Header.Text = Current[ "ProgramTitle" ].ToString( );
                ProgramAreaTable.CaptionText = "Program Area - " + Current[ "ProgramAreaCode" ];
                ProgramProjectTable.CaptionText = "Program Project - " + Current[ "Code" ];
                StatutoryAuthorityTextBox.Text = Current[ "Laws" ].ToString( );
                ProgramAreaNameTextBox.Text = Current[ "ProgramAreaName" ].ToString( );
                ProgramProjectNameTextBox.Text = Current[ nameof( ProgramProjectDialog.Name ) ].ToString( );
                ProgramDescriptionTextBox.Text = Current[ "Description" ].ToString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _now = DateTime.Now;
                StatusLabel.Text = $"{_now.ToShortDateString( )} - {_now.ToLongTimeString( )}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                InitializeTimer( );
                InitializeLabels( );
                InitializeButtons( );
                _filter = new Dictionary<string, object>( );
                _dataArgs = new DataArgs( );
                if( !string.IsNullOrEmpty( _selectedProgram ) )
                {
                    _filter.Add( "Code", _selectedProgram );
                    _dataModel = new DataBuilder( _source, _provider, _filter );
                    _dataTable = _dataModel.DataTable;
                    BindingSource.DataSource = _dataTable;
                    BindingSource.Filter = Filter.ToCriteria( );
                    _current = BindingSource.GetCurrentRow( );
                    DescriptionTable.CaptionText = "Program Description";
                    ComboBox.Visible = false;
                    BindData( );
                }
                else
                {
                    Header.Text = "Program Title";
                    DescriptionTable.CaptionText = "Program Description";
                    PopulateComboBoxItems( );
                    ClearLabels( );
                    ClearProgramText( );
                    ComboBox.Visible = true;
                }

                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [menu button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMenuButtonClick( object sender, EventArgs e )
        {
            try
            {
                Close( );
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [search button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSearchButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _keywords = StatutoryAuthorityTextBox.Text;
                var _search = new GoogleSearch( _keywords );
                var _list = _search.GetResults( );
                ProgramDescriptionTextBox.Text = string.Empty;
                var _results = new StringBuilder( );
                foreach( var _item in _list )
                {
                    _results.Append( "Title : " );
                    _results.Append( _item.Title );
                    _results.Append( Environment.NewLine );
                    _results.Append( Environment.NewLine );
                    _results.Append( "Link : " );
                    _results.Append( _item.Link );
                    _results.Append( Environment.NewLine );
                    _results.Append( Environment.NewLine );
                }

                DescriptionTable.CaptionText = "Web Search Results";
                ProgramDescriptionTextBox.Text = _results.ToString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [ComboBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnComboBoxSelectionChanged( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    if( _filter?.Count > 0 )
                    {
                        _filter.Clear( );
                    }

                    var _selection = _comboBox.SelectedItem.ToString( );
                    _selectedProgram = _selection?.Substring( 0, 2 );
                    _filter?.Add( "Code", _selectedProgram );
                    _dataModel = new DataBuilder( _source, _provider, _filter );
                    _dataTable = _dataModel.DataTable;
                    BindingSource.DataSource = _dataTable;
                    _current = BindingSource.GetCurrentRow( );
                    if( _current != null )
                    {
                        BindData( );
                    }
                    else
                    {
                        ClearLabels( );
                        ClearProgramText( );
                    }

                    PopulateComboBoxItems( );
                    SearchButton.Focus( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            try
            {
                InvokeIf( _statusUpdate );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFormClosing( object sender, EventArgs e )
        {
            try
            {
                Opacity = 1;
                FadeOutAsync( this );
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
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}