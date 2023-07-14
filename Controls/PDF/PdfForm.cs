// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-09-2023
// ******************************************************************************************
// <copyright file="PdfForm.cs" company="Terry D. Eppler">
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
//   PdfForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Pdf.Parsing;
    using Syncfusion.Windows.Forms;
    using static System.IO.Path;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public partial class PdfForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the directory path.
        /// </summary>
        /// <value>
        /// The directory path.
        /// </value>
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the document.
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        public PdfLoadedDocument Document { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.PdfForm" /> class.
        /// </summary>
        public PdfForm( )
        {
            InitializeComponent( );

            // Basic Properties
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderThickness = 2;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            StartPosition = FormStartPosition.CenterScreen;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            ShowIcon = false;
            ShowInTaskbar = true;
            ShowMouseOver = false;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarHeight = 5;
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MaximizeBox = false;

            // Control Properties
            PictureBox.Size = new Size( 40, 18 );
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Event Wiring
            CloseButton.Click += OnCloseButtonClick;
            MenuButton.Click += OnMainMenuButtonClicked;
            BackButton.Click += OnBackButtonClicked;
            DataGridButton.Click += OnDataGridButtonClick;
            ChartButton.Click += OnChartButtonClick;
            ExcelButton.Click += OnExcelButtonClick;
            ListBox.SelectedValueChanged += OnListBoxItemSelected;
            DocViewer.DocumentLoaded += OnDocumentLoaded;
            Load += OnLoad;
            Shown += OnShown;
            Closing += OnClosing;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.PdfForm" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public PdfForm( string filePath )
            : this( )
        {
            FilePath = filePath;
            FileName = GetFileName( filePath );
        }

        /// <summary>
        /// Populates the items.
        /// </summary>
        private void PopulateListBoxItems( )
        {
            try
            {
                var _criteria = new Dictionary<string, object>( );
                _criteria.Add( "FileExtension", "PDF" );
                var _dataRows = DataTable.Filter( _criteria );
                foreach( var _row in _dataRows )
                {
                    var _name = _row[ "Caption" ].ToString( );
                    ListBox.Items.Add( _name );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the data.
        /// </summary>
        public void ClearData( )
        {
            try
            {
                if( BindingSource.DataSource != null )
                {
                    BindingSource.DataSource = null;
                }

                if( DataTable != null )
                {
                    DataTable = null;
                }

                ListBox.Items.Clear( );
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
                if( ( Owner != null )
                   && ( Owner.Visible == false )
                   && ( Owner.GetType( ) == typeof( MainForm ) ) )
                {
                    Owner.Visible = true;
                    Close( );
                }
                else if( ( Owner != null )
                        && ( Owner.Visible == false )
                        && ( Owner.GetType( ) != typeof( MainForm ) ) )
                {
                    var _mainForm = Program.Windows[ "MainForm" ];
                    _mainForm.Visible = true;
                    Owner.Close( );
                    Close( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the excel data form.
        /// </summary>
        private void OpenExcelDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "ExcelDataForm" ) )
                {
                    var _excelDataForm = (ExcelDataForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( ExcelDataForm ) )
                        ?.First( );

                    _excelDataForm.Owner = this;
                    _excelDataForm = new ExcelDataForm( BindingSource );
                    _excelDataForm.Visible = true;
                    Visible = false;
                }
                else if( !Program.Windows.ContainsKey( "ExcelDataForm" )
                        && Program.Windows.ContainsKey( "MainForm" ) )
                {
                    var _mainForm = (MainForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( MainForm ) )
                        ?.First( );

                    var _excelDataForm = new ExcelDataForm( BindingSource );
                    _excelDataForm.Owner = _mainForm;
                    _excelDataForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the data grid form.
        /// </summary>
        private void OpenDataGridForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "DataGridForm" ) )
                {
                    var _dataGridForm = (DataGridForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( DataGridForm ) )
                        ?.First( );

                    _dataGridForm.Owner = this;
                    _dataGridForm.ClearData( );
                    _dataGridForm.Refresh( );
                    _dataGridForm.Visible = true;
                    Visible = false;
                }
                else if( !Program.Windows.ContainsKey( "DataGridForm" )
                        && Program.Windows.ContainsKey( "MainForm" ) )
                {
                    var _mainForm = (MainForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( MainForm ) )
                        ?.First( );

                    var _dataGridForm = new DataGridForm( BindingSource );
                    _dataGridForm.Owner = _mainForm;
                    _dataGridForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the chart data form.
        /// </summary>
        private void OpenChartDataForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "ChartDataForm" ) )
                {
                    var _chartDataForm = (ChartDataForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( ChartDataForm ) )
                        ?.First( );

                    _chartDataForm.Owner = this;
                    _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.ClearData( );
                    _chartDataForm.Refresh( );
                    _chartDataForm.Visible = true;
                    Visible = false;
                }
                else if( !Program.Windows.ContainsKey( "ChartDataForm" )
                        && Program.Windows.ContainsKey( "MainForm" ) )
                {
                    var _mainForm = (MainForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( MainForm ) )
                        ?.First( );

                    var _chartDataForm = new ChartDataForm( BindingSource );
                    _chartDataForm.Owner = _mainForm;
                    _chartDataForm.Show( );
                    Visible = false;
                }
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                DirectoryPath = ConfigurationManager.AppSettings[ "Documents" ];
                var _path = DirectoryPath + @"\\ApplicationLandingDocument.pdf";
                HeaderLabel.ForeColor = Color.FromArgb( 0, 120, 212 );
                HeaderLabel.Text = "Budget Guidance";
                DataTable = new DataBuilder( Source.Resources, Provider.Access ).DataTable;
                Document = new PdfLoadedDocument( _path );
                DocViewer.Load( Document );
                PopulateListBoxItems( );
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnMainMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [data grid button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnDataGridButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenDataGridForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [excel button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnExcelButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenExcelDataForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [chart button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnChartButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenChartDataForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false ) )
                {
                    Owner.Refresh( );
                    Owner.Visible = true;
                    Close( );
                }
                else
                {
                    Close( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [back button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnBackButtonClicked( object sender, EventArgs e )
        {
            try
            {
                if( ( Owner != null )
                   && ( Owner.Visible == false ) )
                {
                    Owner.Visible = true;
                    Owner.Refresh( );
                    Visible = false;
                }
                else
                {
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                Program.Windows[ "PdfForm" ] = this;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClosing( object sender, EventArgs e )
        {
            try
            {
                if( Program.Windows.ContainsKey( "PdfForm" ) )
                {
                    Program.Windows.Remove( "PdfForm" );
                }

                ClearData( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [ListBox item selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox
               && ( DataTable != null ) )
            {
                try
                {
                    var _data = DataTable.AsEnumerable( );
                    var _caption = _listBox.SelectedValue?.ToString( );
                    var _file = _data?.Where( p => p.Field<string>( "Caption" ).Equals( _caption ) )
                        ?.Select( p => p.Field<string>( "Location" ) )
                        ?.Single( );

                    var _prefix = @"C:\Users\terry\source\repos\BudgetExecution\";
                    HeaderLabel.Text = _caption;
                    var _path = _prefix + _file;
                    Document = new PdfLoadedDocument( _path );
                    DocViewer.Load( Document );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnDocumentLoaded( object sender, EventArgs e )
        {
            try
            {
                if( DocViewer.IsDocumentLoaded )
                {
                    Cursor = Cursors.Default;
                    DocViewer.Cursor = Cursors.Default;
                }
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