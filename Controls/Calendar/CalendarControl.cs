//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                CalendarControl.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="CalendarControl.cs" company="Terry D. Eppler">
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
//    CalendarControl.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms.Tools;

    public partial class CalendarControl : UserControl
    {
        /// <summary> Gets or sets the selected date. </summary>
        /// <value> The selected date. </value>
        public DateTime SelectedDate { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CalendarControl"/>
        /// class.
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

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CalendarControl"/>
        /// class.
        /// </summary>
        /// <param name="dateTime"> The date time. </param>
        public CalendarControl( DateTime dateTime )
            : this( )
        {
            Calendar.SelectedDates = new[ ]
            {
                dateTime
            };

            SelectedDate = Calendar.SelectedDates[ 0 ];
        }

        /// <summary> Called when [selected date changed]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSelectedDateChanged( object sender, EventArgs e )
        {
            if( sender is MonthCalendarAdv _calendar
               && ( _calendar.SelectedDates.Length > 0 ) )
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

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}