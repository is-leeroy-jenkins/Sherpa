//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                GuidanceDialog.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="GuidanceDialog.cs" company="Terry D. Eppler">
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
//    GuidanceDialog.cs
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
    using Syncfusion.Windows.Forms;
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public partial class GuidanceDialog : MetroForm
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value> The time. </value>
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value> The seconds. </value>
        public int Seconds { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

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
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public string Prefix { get; set; }

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
        /// Gets or sets the extenstion.
        /// </summary>
        /// <value>
        /// The extenstion.
        /// </value>
        public EXT Extenstion { get; set; }

        /// <summary>
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath { get; set; }

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
        /// </value>
        public string SelectedItem { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.GuidanceDialog" /> class.
        /// </summary>
        public GuidanceDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 568, 483 );
            MaximumSize = new Size( 568, 483 );
            MinimumSize = new Size( 568, 483 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Label Properties
            PathLabel.Font = new Font( "Roboto", 8 );
            PathLabel.ForeColor = Color.FromArgb( 106, 189, 252 );

            // Picture Properties
            Picture.Size = new Size( 24, 22 );
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;

            // File Dialog Properties
            OpenFileDialog.Title = "Search for (*.pdf) Document";
            OpenFileDialog.CheckPathExists = true;
            OpenFileDialog.CheckFileExists = true;

            // Data Properties
            Source = Source.Resources;
            Provider = Provider.Access;
            Extenstion = EXT.PDF;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            MenuButton.Click += OnMainMenuButtonClicked;
            ClearButton.Click += OnClearButtonClick;
            BrowseButton.Click += OnBrowseButtonClick;
            SelectButton.Click += OnSelectButtonClick;
            ListBox.SelectedValueChanged += OnListBoxSelectedValueChanged;
        }

        /// <summary>
        /// Initializes the title.
        /// </summary>
        private void InitializeTitle( )
        {
            try
            {
                Title.Font = new Font( "Roboto", 12 );
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
                Title.Text = "Guidance Documents";
                Title.FlatStyle = FlatStyle.Flat;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        Time++;
                        if( Time == Seconds )
                        {
                            Timer.Stop( );
                        }
                    };
                }

                base.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in.
        /// </summary>
        private void FadeIn( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 1d )
                    {
                        _timer.Stop( );
                    }

                    Opacity += 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out and close.
        /// </summary>
        private void FadeOut( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 0d )
                    {
                        _timer.Stop( );
                        Close( );
                    }

                    Opacity -= 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        private void Notify( )
        {
            try
            {
                var _message = "THIS IS NOT YET IMPLEMENTED!";
                var _notification = new SplashMessage( _message );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        private void PopulateListBox( )
        {
            try
            {
                ListBox.Items?.Clear( );
                DataModel = new DataBuilder( Source, Provider );
                DataTable = DataModel.DataTable;
                BindingSource.DataSource = DataModel.DataTable;
                var _data = DataTable.AsEnumerable( );
                var _names = _data?.Where( r => r.Field<string>( "Type" ).Equals( "DOCUMENT" ) )
                    ?.Select( r => r.Field<string>( "Caption" ) )
                    ?.ToList( );

                foreach( var _name in _names )
                {
                    ListBox.Items?.Add( _name );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the header text.
        /// </summary>
        private void UpdateTitleText( )
        {
            try
            {
                Notify( );
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
                if( Owner?.Visible == false )
                {
                    var _form = (MainForm)Program.Windows[ "MainForm" ];
                    _form.Refresh( );
                    _form.Visible = true;
                }
                else
                {
                    var _mainForm = new MainForm( );
                    _mainForm.Show( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                SelectedItem = string.Empty;
                SelectedPath = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the ListBox.
        /// </summary>
        private void InitializeListBox( )
        {
            try
            {
                ListBox.ItemHeight = 42;
                ListBox.ShowScrollBar = true;
                ListBox.Font = new Font( "Roboto", 10 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeTitle( );
                InitializeListBox( );
                PopulateListBox( );
                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [browse button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnBrowseButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenFileDialog.ShowDialog( );
                OpenFileDialog.Filter = "PDF Files | *.pdf";
                SelectedPath = OpenFileDialog.SafeFileName;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [clear button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnClearButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( !string.IsNullOrEmpty( SelectedPath ) )
                {
                    SelectedPath = string.Empty;
                }

                ListBox.SelectedIndex = -1;
                Title.Text = "Guidance";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
                Close( );
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [ListView selected value changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnListBoxSelectedValueChanged( object sender )
        {
            if( sender is ListBox _listBox )
            {
                try
                {
                    Prefix = ConfigurationManager.AppSettings[ "PathPrefix" ];
                    SelectedItem = _listBox.SelectedValue.ToString( );
                    Title.Text = SelectedItem;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [select button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( string.IsNullOrEmpty( SelectedItem ) )
                {
                    var _message = "Select a document to view!";
                    var _notification = new SplashMessage( _message );
                    _notification.Show( );
                }
                else
                {
                    var _filter = new Dictionary<string, object>
                    {
                        {
                            "Caption", SelectedItem
                        }
                    };

                    var _data = new DataBuilder( Source, Provider, _filter ).Record;
                    var _path = _data[ "Location" ].ToString( );
                    SelectedPath = Prefix + _path;
                    Minion.RunEdge( SelectedPath );
                    OpenMainForm( );
                }
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
        private void OnCloseButtonClicked( object sender, EventArgs e )
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