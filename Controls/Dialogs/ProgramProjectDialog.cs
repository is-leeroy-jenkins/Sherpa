// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-13-2023
// ******************************************************************************************
// <copyright file="ProgramProjectDialog.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ProgramProjectDialog.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Linq;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    [SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public partial class ProgramProjectDialog : MetroForm
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public Provider Provider { get; set; }

        /// <summary> Gets or sets the data model. </summary>
        /// <value> The data model. </value>
        public DataBuilder DataModel { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <summary> Gets or sets the form filter. </summary>
        /// <value> The form filter. </value>
        public IDictionary<string, object> FormFilter { get; set; }

        /// <summary> Gets or sets the selected value. </summary>
        /// <value> The selected value. </value>
        public string SelectedValue { get; set; }

        /// <summary> Gets or sets the SQL query. </summary>
        /// <value> The SQL query. </value>
        public string SqlQuery { get; set; }

        /// <summary> Gets or sets the selected program. </summary>
        /// <value> The selected program. </value>
        public string SelectedProgram { get; set; }

        /// <summary> Gets or sets the current. </summary>
        /// <value> The current. </value>
        public DataRow Current { get; set; }

        /// <summary> Gets or sets the program codes. </summary>
        /// <value> The program codes. </value>
        public IEnumerable<string> ProgramCodes { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramProjectDialog"/>
        /// class.
        /// </summary>
        public ProgramProjectDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1066, 614 );
            MaximumSize = new Size( 1066, 614 );
            MinimumSize = new Size( 1066, 614 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;

            // Bind DataSource
            Source = Source.ProgramProjectDescriptions;
            Provider = Provider.Access;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            SearchButton.Click += OnSearchButtonClicked;
            ComboBox.SelectedValueChanged += OnComboBoxSelectionChanged;
            MouseClick += OnRightClick;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ProgramProjectDialog"/>
        /// class.
        /// </summary>
        /// <param name="code" > The code. </param>
        public ProgramProjectDialog( string code )
            : this( )
        {
            SelectedProgram = code;
        }

        /// <summary> Clears the header text. </summary>
        private void ClearHeaderText( )
        {
            try
            {
                Header.Text = "Program Project Descriptions";
                ProgramAreaTable.CaptionText = "Program Area - ";
                ProgramProjectTable.CaptionText = "Program Project - ";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

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

        /// <summary> Populates the ComboBox items. </summary>
        private void PopulateComboBoxItems( )
        {
            try
            {
                ComboBox.Items.Clear( );
                DataModel = new DataBuilder( Source, Provider );
                var _codes = DataModel.DataElements["ProgramTitle"];
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

        private void BindData( )
        {
            try
            {
                Header.Text = Current["ProgramTitle"].ToString( );
                ProgramAreaTable.CaptionText = "Program Area - " + Current["ProgramAreaCode"];
                ProgramProjectTable.CaptionText = "Program Project - " + Current["Code"];
                StatutoryAuthorityTextBox.Text = Current["Laws"].ToString( );
                ProgramAreaNameTextBox.Text = Current["ProgramAreaName"].ToString( );
                ProgramProjectNameTextBox.Text = Current["Name"].ToString( );
                ProgramDescriptionTextBox.Text = Current["Description"].ToString( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                FormFilter = new Dictionary<string, object>( );
                if( !string.IsNullOrEmpty( SelectedProgram ) )
                {
                    FormFilter.Add( "Code", SelectedProgram );
                    DataModel = new DataBuilder( Source, Provider, FormFilter );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    Header.ForeColor = Color.FromArgb( 0, 120, 212 );
                    BindingSource.Filter = FormFilter.ToCriteria( );
                    Current = BindingSource.GetCurrentDataRow( );
                    DescriptionTable.CaptionText = "Program Description";
                    ComboBox.Visible = false;
                    BindData( );
                }
                else
                {
                    DataModel = new DataBuilder( Source, Provider );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    Header.ForeColor = Color.FromArgb( 0, 120, 212 );
                    Header.Text = "Program Title";
                    DescriptionTable.CaptionText = "Program Description";
                    PopulateComboBoxItems( );
                    ClearHeaderText( );
                    ClearProgramText( );
                    ComboBox.Visible = true;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnCloseButtonClicked( object sender, EventArgs e )
        {
            Close( );
        }

        /// <summary> Called when [search button clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnSearchButtonClicked( object sender, EventArgs e )
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
        public void OnComboBoxSelectionChanged( object sender, EventArgs e )
        {
            if( sender is ComboBox _comboBox )
            {
                try
                {
                    if( FormFilter.Count > 0 )
                    {
                        FormFilter.Clear( );
                    }

                    var _selection = _comboBox.SelectedItem.ToString( );
                    SelectedProgram = _selection?.Substring( 0, 2 );
                    FormFilter.Add( "Code", SelectedProgram );
                    DataModel = new DataBuilder( Source, Provider, FormFilter );
                    DataTable = DataModel.DataTable;
                    BindingSource.DataSource = DataTable;
                    Current = BindingSource.GetCurrentDataRow( );
                    if( Current != null )
                    {
                        BindData( );
                    }
                    else
                    {
                        ClearHeaderText( );
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

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
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
        
        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex" > The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}