namespace BudgetExecution
{
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class CalendarControl : MonthCalendarAdv
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
            // Control Properties
            Style = VisualStyle.Office2016Black;
            BorderStyle = BorderStyle.FixedSingle;
            Border3DStyle = Border3DStyle.Adjust;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            ClearSelectionOnNone = true;
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 70, 70, 70 );
            GridBackColor = Color.FromArgb( 70, 70, 70 );
            DayNamesFont = new Font( "Roboto", 10 );
            DaysFont = new Font( "Roboto", 9 );
            GridLines = GridBorderStyle.Dotted;
            HeaderFont = new Font( "Roboto", 11 ); 
            WeekFont = new Font( "Roboto", 8 );

            // Wire Events
            DateSelected += OnDateSelected;
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
            SelectedDates = new[ ]
            {
                dateTime
            };
        }
        
        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnDateSelected( object sender, EventArgs e )
        {
            if( sender is MonthCalendarAdv _calendar )
            {
                try
                {
                    SelectedDate = _calendar.Value;
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
        /// <param name="_ex">The ex.</param>
        private void Fail( Exception _ex )
        {
            using var _error = new ErrorDialog( _ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
