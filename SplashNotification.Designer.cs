namespace BudgetExecution
{
    public partial class SplashNotification
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SplashNotification ) );
            Message = new RichTextBox( );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new Picture( );
            Title = new Label( );
            Timer = new System.Windows.Forms.Timer( components );
            Layout = new Layout( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            Layout.SuspendLayout( );
            SuspendLayout( );
            // 
            // Message
            // 
            Message.AutoWordSelection = false;
            Message.BindingSource = null;
            Message.BorderColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            Message.DataFilter = null;
            Message.DisabledBackColor = System.Drawing.Color.FromArgb(   204  ,   204  ,   204   );
            Message.DisabledBorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
            Message.DisabledForeColor = System.Drawing.Color.FromArgb(   136  ,   136  ,   136   );
            Message.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Lines = null;
            Message.Location = new System.Drawing.Point( 78, 57 );
            Message.MaxLength = 32767;
            Message.Name = "Message";
            Message.Padding = new System.Windows.Forms.Padding( 1 );
            Message.ReadOnly = false;
            Message.Size = new System.Drawing.Size( 528, 148 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 0;
            Message.Text = "Message goes here";
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Budget Execution";
            Message.ToolTip = null;
            Message.WordWrap = true;
            // 
            // Header
            // 
            Header.ColumnCount = 2;
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 5.172414F ) );
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 94.82758F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Controls.Add( Title, 1, 0 );
            Header.Location = new System.Drawing.Point( 4, 4 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 642, 31 );
            Header.TabIndex = 2;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.SplashNotification;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 26, 25 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 36, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 598, 25 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Notification";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // Layout
            // 
            Layout.BackColor = System.Drawing.Color.Transparent;
            Layout.BackgroundColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            Layout.BindingSource = null;
            Layout.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Layout.BorderThickness = 1;
            Layout.Children = null;
            Layout.Controls.Add( Message );
            Layout.Controls.Add( Header );
            Layout.DataFilter = null;
            Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            Layout.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Layout.ForeColor = System.Drawing.Color.Transparent;
            Layout.HoverText = null;
            Layout.IsDerivedStyle = true;
            Layout.Location = new System.Drawing.Point( 0, 0 );
            Layout.Margin = new System.Windows.Forms.Padding( 0 );
            Layout.Name = "Layout";
            Layout.Padding = new System.Windows.Forms.Padding( 1 );
            Layout.Size = new System.Drawing.Size( 650, 250 );
            Layout.Style = MetroSet_UI.Enums.Style.Custom;
            Layout.StyleManager = null;
            Layout.TabIndex = 3;
            Layout.ThemeAuthor = "Terry D. Eppler";
            Layout.ThemeName = "Budget Execution";
            Layout.ToolTip = null;
            // 
            // SplashNotification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            BorderColor = System.Drawing.Color.Transparent;
            CaptionBarColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 650, 250 );
            Controls.Add( Layout );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 650, 250 );
            MetroColor = System.Drawing.Color.FromArgb(   3  ,   3  ,   3   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 650, 250 );
            Name = "SplashNotification";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "SplashNotification";
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            Layout.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public RichTextBox Message;
        public System.Windows.Forms.TableLayoutPanel Header;
        private Picture PictureBox;
        private Label Title;
        public System.Windows.Forms.Timer Timer;
        public Layout Layout;
    }
}