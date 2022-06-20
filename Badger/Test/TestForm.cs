// // <copyright file = "TestForm.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Collections.Specialized;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using static System.IO.Path;

    public partial class TestForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public NameValueCollection Setting { get;  set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the budget button.
        /// </summary>
        /// <value>
        /// The budget button.
        /// </value>
        public BudgetButton BudgetButton { get; set; } = new BudgetButton( );

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public string CurrentDirectory { get; } = Environment.CurrentDirectory;

        public TestForm()
        {
            InitializeComponent( );

            // Form Property Values
            BackColor = Color.FromArgb( 18, 18, 18 );
            BorderThickness = 1;
            BorderColor = Color.SteelBlue;
            Size = new Size( 1200, 700 );
            Font = new Font( "Roboto", 9 );
            CaptionBarColor = Color.FromArgb( 18, 18, 18 );
            CaptionBarHeight = 26;
            CaptionButtonColor = Color.FromArgb( 80, 80, 80 );
            CaptionButtonHoverColor = Color.White;
            CaptionAlign = HorizontalAlignment.Left;
            CaptionFont = new Font( "Roboto", 11 );
            MetroColor = Color.FromArgb( 18, 18, 18 );
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 62, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = new Padding( 1 );
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.CenterScreen;

            // Test Button Properties
            BudgetButton.Text = "Test";
            BudgetButton.Tag = "THIS IS A TEST";
            BudgetButton.Location = new Point( 500, 500 );

            BudgetButton.HoverText =
                GetFileNameWithoutExtension( Setting[ "BudgetExecutionIcon" ] );

            BudgetButton.Click += SetLabelText;
            BudgetButton.MouseLeave += ClearLabelText;
            Controls.Add( BudgetButton );
            ToolStip.Office12Mode = true;
            ToolStip.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            ToolStip.LauncherStyle = LauncherStyle.Office12;
            ToolStip.Padding = new Padding( 0 );
            ToolStip.ImageScalingSize = new Size( 20, 20 );
            ToolStip.Margin = new Padding( 1, 1, 1, 1 );
            ToolStip.ForeColor = Color.Black;
            ExcelButton.Click += OnExcelButtonClicked;
            SetToolStripButtonImages( );
        }

        /// <summary>
        /// Sets the label text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void SetLabelText( object sender, EventArgs e )
        {
            if( sender is BudgetButton _button )
            {
                try
                {
                    BudgetButton = _button;
                    BudgetButton.ForeColor = Color.White;
                    CaptionForeColor = Color.White;
                    var _title = "Budget Execution Notification";
                    Text = Setting[ "BudgetExecutionIcon" ];

                    using var _excel =
                        new BudgetNotification( _title, Setting[ "BudgetExecutionIcon" ] );

                    _excel.ShowDialog( this );
                }
                catch( Exception ex )
                {
                    TestForm.Fail( ex );
                }
            }
        }

        private void SetToolStripButtonImages()
        {
            var _firstRecord = Setting[ "ToolStripImages" ] + @"\FirstButton.png";
            var _previousRecord = Setting[ "ToolStripImages" ] + @"\PreviousButton.png";
            var _nextRecord = Setting[ "ToolStripImages" ] + @"\NextButton.png";
            var _lastRecord = Setting[ "ToolStripImages" ] + @"\LastButton.png";
            var _edit = Setting[ "ToolStripImages" ] + @"\EditButton.png";
            var _add = Setting[ "ToolStripImages" ] + @"\AddButton.png";
            var _delete = Setting[ "ToolStripImages" ] + @"\DeleteButton.png";
            var _refresh = Setting[ "ToolStripImages" ] + @"\RefreshButton.png";
            var _save = Setting[ "ToolStripImages" ] + @"\SaveButton.png";
            var _print = Setting[ "ToolStripImages" ] + @"\PrintButton.png";
            var _excelFile = Setting[ "ToolStripImages" ] + @"\ExcelButton.png";
            var _calculator = Setting[ "ToolStripImages" ] + @"\CalculatorButton.png";
            FirstButton.Image = Image.FromFile( _firstRecord );
            FirstButton.HoverText = "First Record";
            PreviousButton.Image = Image.FromFile( _previousRecord );
            PreviousButton.HoverText = "Previous Record";
            NextButton.Image = Image.FromFile( _nextRecord );
            NextButton.HoverText = "Next Record";
            LastButton.Image = Image.FromFile( _lastRecord );
            LastButton.HoverText = "Last Record";
            EditButton.Image = Image.FromFile( _edit );
            EditButton.HoverText = "Edit Record";
            AddButton.Image = Image.FromFile( _add );
            AddButton.HoverText = "Add Record";
            DeleteButton.Image = Image.FromFile( _delete );
            DeleteButton.HoverText = "Delete Record";
            RefreshButton.Image = Image.FromFile( _refresh );
            RefreshButton.HoverText = "Refresh Data";
            SaveButton.Image = Image.FromFile( _save );
            SaveButton.HoverText = "Save Data";
            ExcelButton.Image = Image.FromFile( _excelFile );
            ExcelButton.HoverText = "Export to Excel";
            CalculatorButton.Image = Image.FromFile( _calculator );
            CalculatorButton.HoverText = "Launch Calculator";
        }

        /// <summary>
        /// Clears the label text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void ClearLabelText( object sender, EventArgs e )
        {
            try
            {
                Text = string.Empty;
            }
            catch ( Exception ex )
            {
                TestForm.Fail( ex );
            }
        }

        public void OnExcelButtonClicked( object sender, EventArgs e )
        {
            try
            {
                using var _data = new DataForm( );
                _data.ShowDialog( );
            }
            catch ( Exception ex )
            {
                TestForm.Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}