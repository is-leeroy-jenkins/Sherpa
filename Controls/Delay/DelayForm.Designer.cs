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
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.Image = Resources.Images.LoaderImages.Loading;
            PictureBox.Location = new System.Drawing.Point( 354, 203 );
            PictureBox.Margin = new System.Windows.Forms.Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 605, 381 );
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
            Timer.Interval = 500;
            // 
            // DelayForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.Black;
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.Black;
            CaptionButtonHoverColor = System.Drawing.Color.Black;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F );
            CaptionForeColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size( 1328, 729 );
            ControlBox = false;
            Controls.Add( PictureBox );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.Black;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.Black;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1330, 730 );
            Name = "DelayForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "DelayForm";
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBox;
        public System.ComponentModel.BackgroundWorker Worker;
        public System.Windows.Forms.Timer Timer;
        public ContextMenu ContextMenu;
        private Button CloseButton;
    }
}