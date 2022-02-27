// // <copyright file = "TestForm3.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using static System.IO.Path;

    public partial class DataForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the budget button.
        /// </summary>
        /// <value>
        /// The budget button.
        /// </value>
        public BudgetButton BudgetButton { get; set; } = new BudgetButton();

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public string CurrentDirectory { get; } = Environment.CurrentDirectory;

        public DataForm()
        {
            InitializeComponent();

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
            BudgetButton.HoverText = GetFileNameWithoutExtension( Setting[ "BudgetExecutionIcon" ] );
            BudgetButton.Click += SetLabelText;
            BudgetButton.MouseLeave += ClearLabelText;
            Controls.Add( BudgetButton );
            ToolStip.Office12Mode = true;
            ToolStip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            ToolStip.LauncherStyle = LauncherStyle.Office12;
            ToolStip.Padding = new Padding( 0 );
            ToolStip.Margin = new Padding( 1, 1, 1, 1 );
            ToolStip.ForeColor = Color.Black;
            SetToolStripButtonImages();
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
                    using var _excel = new BudgetNotification( _title, Setting[ "BudgetExecutionIcon" ] );
                    _excel.ShowDialog( this );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        private void SetToolStripButtonImages()
        {
            var _firstRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\FirstButton.png";
            var _previousRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\PreviousButton.png";
            var _nextRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\NextButton.png";
            var _lastRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\LastButton.png";
            var _edit = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\EditButton.png";
            var _add = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\AddButton.png";
            var _delete = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\DeleteButton.png";
            var _refresh = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\RefreshButton.png";
            var _save = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\SaveButton.png";
            var _print = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\PrintButton.png";
            var _excelFile = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\ExcelButton.png";
            var _calculator = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\CalculatorButton.png";
            FirstRecordToolStripButton.Image = Image.FromFile( _firstRecord );
            FirstRecordToolStripButton.HoverText = "First Record";
            PreviousRecordToolStripButton.Image = Image.FromFile( _previousRecord );
            PreviousRecordToolStripButton.HoverText = "Previous Record";
            NextRecordToolStripButton.Image = Image.FromFile( _nextRecord );
            NextRecordToolStripButton.HoverText = "Next Record";
            LastRecordToolStripButton.Image = Image.FromFile( _lastRecord );
            LastRecordToolStripButton.HoverText = "Last Record";
            EditRecordToolStripButton.Image = Image.FromFile( _edit );
            EditRecordToolStripButton.HoverText = "Edit Record";
            AddRecordToolStripButton.Image = Image.FromFile( _add );
            AddRecordToolStripButton.HoverText = "Add Record";
            DeleteToolStripButton.Image = Image.FromFile( _delete );
            DeleteToolStripButton.HoverText = "Delete Record";
            RefreshToolStripButton.Image = Image.FromFile( _refresh );
            RefreshToolStripButton.HoverText = "Refresh Data";
            SaveToolStripButton.Image = Image.FromFile( _save );
            SaveToolStripButton.HoverText = "Refresh Data";
            PrintToolStripButton.Image = Image.FromFile( _print );
            PrintToolStripButton.HoverText = "Print Data";
            ExcelExportToolStripButton.Image = Image.FromFile( _excelFile );
            ExcelExportToolStripButton.HoverText = "Save Changes";
            CalculatorToolStripButton.Image = Image.FromFile( _calculator );
            CalculatorToolStripButton.HoverText = "Launch Calculator";
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
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
