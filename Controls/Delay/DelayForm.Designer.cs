namespace BudgetExecution
{
    partial class DelayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources
        /// should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( DelayForm ) );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Worker = new System.ComponentModel.BackgroundWorker( );
            Timer = new System.Windows.Forms.Timer( components );
            CloseButton = new Button( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.Location = new System.Drawing.Point( 369, 214 );
            PictureBox.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 565, 335 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Worker
            // 
            Worker.WorkerReportsProgress = true;
            Worker.WorkerSupportsCancellation = true;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 5000;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 1384, 691 );
            CloseButton.Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Black;
            CloseButton.NormalColor = System.Drawing.Color.Black;
            CloseButton.NormalTextColor = System.Drawing.Color.Black;
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 163, 40 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 1;
            CloseButton.Text = "button1";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // DelayForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BorderColor = System.Drawing.Color.Black;
            CaptionBarColor = System.Drawing.Color.Black;
            CaptionBarHeight = 1;
            CaptionButtonColor = System.Drawing.Color.Black;
            CaptionButtonHoverColor = System.Drawing.Color.Black;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F );
            CaptionForeColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size( 1338, 743 );
            Controls.Add( CloseButton );
            Controls.Add( PictureBox );
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.Black;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.Black;
            MinimumSize = new System.Drawing.Size( 1340, 740 );
            Name = "DelayForm";
            ShowIcon = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DelayForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBox;
        public System.ComponentModel.BackgroundWorker Worker;
        public System.Windows.Forms.Timer Timer;
        private Button CloseButton;
    }
}