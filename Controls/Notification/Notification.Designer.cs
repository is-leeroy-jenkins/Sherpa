namespace BudgetExecution
{
    partial class Notification
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( Notification ) );
            NotifyIcon = new System.Windows.Forms.PictureBox( );
            Timer = new System.Windows.Forms.Timer( components );
            Title = new Label( );
            Message = new Label( );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            Layout = new Layout( );
            ( (System.ComponentModel.ISupportInitialize) NotifyIcon  ).BeginInit( );
            Header.SuspendLayout( );
            Layout.SuspendLayout( );
            SuspendLayout( );
            // 
            // NotifyIcon
            // 
            NotifyIcon.BackColor = System.Drawing.Color.Transparent;
            NotifyIcon.Image = (System.Drawing.Image) resources.GetObject( "NotifyIcon.Image" ) ;
            NotifyIcon.Location = new System.Drawing.Point( 3, 3 );
            NotifyIcon.Name = "NotifyIcon";
            NotifyIcon.Size = new System.Drawing.Size( 27, 29 );
            NotifyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            NotifyIcon.TabIndex = 2;
            NotifyIcon.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 39, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 341, 29 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 3;
            Title.Text = "label1";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "BudgetExecution";
            Title.ToolTip = null;
            // 
            // Message
            // 
            Message.BindingSource = null;
            Message.DataFilter = null;
            Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Message.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Location = new System.Drawing.Point( 36, 47 );
            Message.Margin = new System.Windows.Forms.Padding( 3 );
            Message.Name = "Message";
            Message.Padding = new System.Windows.Forms.Padding( 1 );
            Message.Size = new System.Drawing.Size( 333, 115 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 4;
            Message.Text = "label1";
            Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "BudgetExecution";
            Message.ToolTip = null;
            // 
            // Header
            // 
            Header.ColumnCount = 2;
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 9.462915F ) );
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 90.53709F ) );
            Header.Controls.Add( Title, 1, 0 );
            Header.Controls.Add( NotifyIcon, 0, 0 );
            Header.Location = new System.Drawing.Point( 4, 4 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 383, 35 );
            Header.TabIndex = 5;
            // 
            // Layout
            // 
            Layout.BackColor = System.Drawing.Color.Transparent;
            Layout.BackgroundColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            Layout.BindingSource = null;
            Layout.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Layout.BorderThickness = 1;
            Layout.Children = null;
            Layout.Controls.Add( Header );
            Layout.DataFilter = null;
            Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            Layout.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Layout.ForeColor = System.Drawing.Color.Transparent;
            Layout.HoverText = null;
            Layout.IsDerivedStyle = true;
            Layout.Location = new System.Drawing.Point( 1, 1 );
            Layout.Name = "Layout";
            Layout.Padding = new System.Windows.Forms.Padding( 1 );
            Layout.Size = new System.Drawing.Size( 398, 183 );
            Layout.Style = MetroSet_UI.Enums.Style.Custom;
            Layout.StyleManager = null;
            Layout.TabIndex = 6;
            Layout.ThemeAuthor = "Terry D. Eppler";
            Layout.ThemeName = "Budget Execution";
            Layout.ToolTip = null;
            // 
            // Notification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            BorderColor = System.Drawing.Color.Transparent;
            CaptionBarColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ClientSize = new System.Drawing.Size( 400, 185 );
            ControlBox = false;
            Controls.Add( Message );
            Controls.Add( Layout );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximumSize = new System.Drawing.Size( 400, 190 );
            MetroColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            MinimumSize = new System.Drawing.Size( 400, 190 );
            Name = "Notification";
            Padding = new System.Windows.Forms.Padding( 1 );
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Notification";
            TopMost = true;
            ( (System.ComponentModel.ISupportInitialize) NotifyIcon  ).EndInit( );
            Header.ResumeLayout( false );
            Layout.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.PictureBox NotifyIcon;
        public System.Windows.Forms.Timer Timer;
        private Label Title;
        public Label Message;
        private System.Windows.Forms.TableLayoutPanel Header;
        public Layout Layout;
    }
}