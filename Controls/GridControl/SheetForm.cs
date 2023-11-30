//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                SheetForm.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SheetForm.cs" company="Terry D. Eppler">
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
//    SheetForm.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using Timer = System.Windows.Forms.Timer;

    /// <summary> SheetForm Class </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public partial class SheetForm : MetroForm
    {
        /// <summary> Gets or sets the time. </summary>
        /// <value> The time. </value>
        public int Time { get; set; }

        /// <summary> Gets or sets the seconds. </summary>
        /// <value> The seconds. </value>
        public int Seconds { get; set; }

        /// <summary> Gets or sets the data table. </summary>
        /// <value> The data table. </value>
        public DataTable DataTable { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SheetForm"/>
        /// class.
        /// </summary>
        public SheetForm( )
        {
            InitializeComponent( );
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            Title.ForeColor = Color.FromArgb( 106, 189, 252 );
            SizeGripStyle = SizeGripStyle.Hide;
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Timer Properties
            Time = 0;
            Seconds = 5;

            // Event Wiring
            Load += OnLoad;
            MenuButton.Click += OnMenuButtonClicked;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SheetForm"/>
        /// class.
        /// </summary>
        /// <param name="dataTable"> The data table. </param>
        public SheetForm( DataTable dataTable )
            : this( )
        {
            DataTable = dataTable;
            DataSheet.ColCount = dataTable.Columns.Count;
            DataSheet.RowCount = dataTable.Rows.Count;
        }

        /// <summary> Displays the control to the user. </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = 10;
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

        /// <summary> Sets the tool strip properties. </summary>
        private void InitToolStrip( )
        {
            try
            {
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.Office12Mode = true;
                ToolStrip.ShowCaption = false;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
                ToolStripTextBox.Font = new Font( "Roboto", 8 );
                ToolStripTextBox.ForeColor = Color.White;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fades the in. </summary>
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

        /// <summary> Fades the out and close. </summary>
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

        /// <summary> Notifies this instance. </summary>
        private void Notify( )
        {
            try
            {
                var _message = "THIS IS NOT YET IMPLEMENTED!!";
                var _notify = new Notification( _message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Opens the main form. </summary>
        private void OpenMainForm( )
        {
            try
            {
                if( Owner?.Visible == false )
                {
                    var _form = (MainForm) Program.Windows[ "MainForm" ];
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

        /// <summary> Populates the headers. </summary>
        private void PopulateHeaders( )
        {
            if( DataTable?.Rows?.Count > 0 )
            {
                try
                {
                    for( var _c = 1; _c <= ( DataTable.Columns.Count - 1 ); _c++ )
                    {
                        var _name = DataTable.Columns[ _c ].ColumnName;
                        DataSheet.Model[ 0, _c ].CellValue = _name?.SplitPascal( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Populates the cells. </summary>
        /// <param name="dataTable"> The data table. </param>
        private void PopulateCells( )
        {
            if( DataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _rows = DataTable.Rows.Count - 1;
                    var _columns = DataTable.Columns.Count - 1;
                    for( var _r = 1; _r <= _rows; _r++ )
                    {
                        for( var _c = 1; _c <= _columns; _c++ )
                        {
                            DataSheet.Model[ _r, _c ].CellValue = $"{DataTable.Rows[ _r ][ _c ]}";
                        }
                    }

                    ToolStripTextBox.Text = $"Rows: {_rows} Columns: {_columns}";
                    ToolStripLabel.Text = "Data Source:  " + DataTable.TableName?.SplitPascal( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitToolStrip( );
                Text = string.Empty;
                ToolStrip.Visible = true;
                if( DataTable != null )
                {
                    BindingSource.DataSource = DataTable;
                    ToolStrip.BindingSource = BindingSource;
                    PopulateHeaders( );
                    PopulateCells( );
                }
                else
                {
                }

                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [exit button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [main menu button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMenuButtonClicked( object sender, EventArgs e )
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

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}