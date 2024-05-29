namespace Sherpa
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
            NotifyIcon = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            Message = new Label( );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            Panel = new BackPanel( );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize)NotifyIcon ).BeginInit( );
            Header.SuspendLayout( );
            Panel.SuspendLayout( );
            SuspendLayout( );
            // 
            // NotifyIcon
            // 
            NotifyIcon.BackColor = System.Drawing.Color.Transparent;
            NotifyIcon.Image = Resources.Images.DialogImages.SplashNotification;
            NotifyIcon.Location = new System.Drawing.Point( 3, 3 );
            NotifyIcon.Name = "NotifyIcon";
            NotifyIcon.Size = new System.Drawing.Size( 24, 18 );
            NotifyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            NotifyIcon.TabIndex = 2;
            NotifyIcon.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
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
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Sherpa";
            Title.ToolTip = null;
            // 
            // Message
            // 
            Message.BindingSource = null;
            Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Message.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Location = new System.Drawing.Point( 43, 55 );
            Message.Margin = new System.Windows.Forms.Padding( 3 );
            Message.Name = "Message";
            Message.Padding = new System.Windows.Forms.Padding( 1 );
            Message.Size = new System.Drawing.Size( 326, 84 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 4;
            Message.Text = "label1";
            Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Sherpa";
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
            // Panel
            // 
            Panel.BackColor = System.Drawing.Color.Transparent;
            Panel.BackgroundColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            Panel.BindingSource = null;
            Panel.BorderColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            Panel.BorderThickness = 1;
            Panel.Children = null;
            Panel.Controls.Add( Header );
            Panel.DataFilter = null;
            Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Panel.ForeColor = System.Drawing.Color.Transparent;
            Panel.HoverText = null;
            Panel.IsDerivedStyle = true;
            Panel.Location = new System.Drawing.Point( 0, 0 );
            Panel.Name = "Panel";
            Panel.Padding = new System.Windows.Forms.Padding( 1 );
            Panel.Size = new System.Drawing.Size( 400, 190 );
            Panel.Style = MetroSet_UI.Enums.Style.Custom;
            Panel.StyleManager = null;
            Panel.TabIndex = 6;
            Panel.ThemeAuthor = "Terry D. Eppler";
            Panel.ThemeName = "Sherpa";
            Panel.ToolTip = null;
            // 
            // Notification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            BorderColor = System.Drawing.Color.Transparent;
            CaptionBarColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            ClientSize = new System.Drawing.Size( 400, 190 );
            ControlBox = false;
            Controls.Add( Message );
            Controls.Add( Panel );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InnerBorderVisibility = false;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 400, 190 );
            MetroColor = System.Drawing.Color.FromArgb( 0, 73, 112 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 400, 190 );
            Name = "Notification";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "Notification";
            TopMost = true;
            ( (System.ComponentModel.ISupportInitialize)NotifyIcon ).EndInit( );
            Header.ResumeLayout( false );
            Panel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.PictureBox NotifyIcon;
        public Label Title;
        public Label Message;
        public System.Windows.Forms.TableLayoutPanel Header;
        public BackPanel Panel;
        public System.Windows.Forms.Timer Timer;
    }
}