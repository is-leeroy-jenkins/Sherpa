namespace Sherpa
{
    partial class CalendarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            Calendar = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv( );
            ( (System.ComponentModel.ISupportInitialize) Calendar  ).BeginInit( );
            SuspendLayout( );
            // 
            // Calendar
            // 
            Calendar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            Calendar.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Calendar.BottomHeight = 23;
            Calendar.Culture = new System.Globalization.CultureInfo( "" );
            Calendar.DayNamesColor = System.Drawing.Color.FromArgb(   240  ,   240  ,   240   );
            Calendar.DayNamesFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Calendar.DaysColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            Calendar.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Calendar.GridBackColor = System.Drawing.Color.FromArgb(   54  ,   54  ,   54   );
            Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            Calendar.HeaderHeight = 34;
            Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(   68  ,   68  ,   68   );
            Calendar.HeadForeColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            Calendar.HighlightColor = System.Drawing.Color.Black;
            Calendar.InactiveMonthColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            Calendar.Iso8601CalenderFormat = false;
            Calendar.Location = new System.Drawing.Point( 0, 0 );
            Calendar.MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            Calendar.Name = "Calendar";
            // 
            // 
            // 
            Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            Calendar.NoneButton.AutoSize = true;
            Calendar.NoneButton.BackColor = System.Drawing.Color.FromArgb(   22  ,   165  ,   220   );
            Calendar.NoneButton.ForeColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            Calendar.NoneButton.KeepFocusRectangle = false;
            Calendar.NoneButton.Location = new System.Drawing.Point( 91, 0 );
            Calendar.NoneButton.MetroColor = System.Drawing.Color.FromArgb(   68  ,   68  ,   68   );
            Calendar.NoneButton.Size = new System.Drawing.Size( 91, 23 );
            Calendar.NoneButton.Text = "None";
            Calendar.NoneButton.ThemeName = "Metro";
            Calendar.NoneButton.UseVisualStyle = true;
            Calendar.ScrollButtonSize = new System.Drawing.Size( 24, 24 );
            Calendar.Size = new System.Drawing.Size( 182, 300 );
            Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016Black;
            Calendar.TabIndex = 0;
            // 
            // 
            // 
            Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            Calendar.TodayButton.AutoSize = true;
            Calendar.TodayButton.BackColor = System.Drawing.Color.FromArgb(   22  ,   165  ,   220   );
            Calendar.TodayButton.ForeColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            Calendar.TodayButton.KeepFocusRectangle = false;
            Calendar.TodayButton.Location = new System.Drawing.Point( 0, 0 );
            Calendar.TodayButton.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            Calendar.TodayButton.MetroColor = System.Drawing.Color.FromArgb(   68  ,   68  ,   68   );
            Calendar.TodayButton.Size = new System.Drawing.Size( 91, 23 );
            Calendar.TodayButton.Text = "Today";
            Calendar.TodayButton.ThemeName = "Metro";
            Calendar.TodayButton.UseVisualStyle = true;
            Calendar.WeekFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            // 
            // CalendarControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            Controls.Add( Calendar );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            Name = "CalendarControl";
            Size = new System.Drawing.Size( 350, 300 );
            ( (System.ComponentModel.ISupportInitialize) Calendar  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.MonthCalendarAdv Calendar;
    }
}
