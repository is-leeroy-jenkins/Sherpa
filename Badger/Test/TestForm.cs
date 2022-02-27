// <copyright file = "TestForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

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
        public BudgetButton BudgetButton { get; set; } = new BudgetButton();

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public string CurrentDirectory { get; } = Environment.CurrentDirectory;

        public TestForm()
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
            var _firstRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\FirstRecord.png";
            var _previousRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\PreviousRecord.png";
            var _nextRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\NextRecord.png";
            var _lastRecord = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\LastRecord.png";
            var _edit = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\Edit.png";
            var _add = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\Add.png";
            var _delete = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\Delete.png";
            var _refresh = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\RefreshData.png";
            var _save = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\Save.png";
            var _print = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\Save.png";
            var _excelFile = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\ExcelFile.png";
            var _calculator = @"C:\Users\terry\source\repos\BudgetExecution\Badger\Images\ToolBar\png\Calculator.png";
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
            ToolButton7.Image = Image.FromFile( _delete );
            ToolButton7.HoverText = "Delete Record";
            ToolButton8.Image = Image.FromFile( _refresh );
            ToolButton8.HoverText = "Refresh Data";
            ToolButton9.Image = Image.FromFile( _save );
            ToolButton9.HoverText = "Refresh Data";
            ToolButton10.Image = Image.FromFile( _excelFile );
            ToolButton10.HoverText = "Save Changes";
            CalculatorToolStripButton.Image = Image.FromFile( _calculator );
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
