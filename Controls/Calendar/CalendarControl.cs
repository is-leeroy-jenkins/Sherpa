namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security.RightsManagement;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class CalendarControl : UserControl
    {
        /// <summary>
        /// Gets or sets the selected date.
        /// </summary>
        /// <value>
        /// The selected date.
        /// </value>
        public DateTime SelectedDate { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CalendarControl" /> class.
        /// </summary>
        public CalendarControl( )
        {
            InitializeComponent( );

            // Control Properties
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );
            Size = new Size( 350, 300 );

            // Calendar Properties
            Calendar.Style = VisualStyle.Office2016Black;
            Calendar.Font = new Font( "Roboto", 9 );
            Calendar.Dock = DockStyle.Fill;
            Calendar.BorderStyle = BorderStyle.FixedSingle;
            Calendar.Border3DStyle = Border3DStyle.Flat;
            Calendar.BorderColor = Color.FromArgb( 0, 120, 212 );
            Calendar.BorderSides = Border3DSide.All;
            Calendar.DaysFont = new Font( "Roboto", 9 );
            Calendar.DayNamesFont = new Font( "Roboto", 10 );
            Calendar.HeaderFont = new Font( "Roboto", 11, FontStyle.Bold );
            Calendar.HeadForeColor = Color.FromArgb( 106, 189, 252 );
            Calendar.GridLines = GridBorderStyle.None;
            Calendar.AllowMultipleSelection = false;
            Calendar.ClearSelectionOnNone = true;
            Calendar.SelectedDates = new[ ]
            {
                DateTime.Today
            };

            // Event Wiring
            Calendar.DateSelected += OnSelectedDateChanged;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CalendarControl" /> class.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public CalendarControl( DateTime dateTime ) 
            : this( )
        {
            Calendar.SelectedDates = new[ ]
            {
                dateTime
            };

            SelectedDate = Calendar.SelectedDates[ 0 ];
        }

        /// <summary>
        /// Called when [selected date changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectedDateChanged( object sender, EventArgs e )
        {
            if( sender is MonthCalendarAdv _calendar 
               && _calendar.SelectedDates.Length > 0 )
            {
                try
                {
                    SelectedDate = _calendar.SelectedDates[ 0 ];
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
