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
            PictureBox = new Picture( );
            Title = new Label( );
            BackPanel = new Layout( );
            Message = new RichTextBox( );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            picture1 = new Picture( );
            label1 = new Label( );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            BackPanel.SuspendLayout( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) picture1  ).BeginInit( );
            SuspendLayout( );
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.SplashNotification;
            PictureBox.ImageList = null;
            PictureBox.InitialImage = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 22, 22 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 35, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 600, 25 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = System.Drawing.Color.Transparent;
            BackPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BackPanel.BindingSource = null;
            BackPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            BackPanel.BorderThickness = 1;
            BackPanel.Children = null;
            BackPanel.Controls.Add( Message );
            BackPanel.DataFilter = null;
            BackPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackPanel.ForeColor = System.Drawing.Color.Transparent;
            BackPanel.HoverText = null;
            BackPanel.IsDerivedStyle = true;
            BackPanel.Location = new System.Drawing.Point( 36, 49 );
            BackPanel.Name = "BackPanel";
            BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
            BackPanel.Size = new System.Drawing.Size( 573, 163 );
            BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BackPanel.StyleManager = null;
            BackPanel.TabIndex = 1;
            BackPanel.ThemeAuthor = "Terry D. Eppler";
            BackPanel.ThemeName = "Budget Execution";
            BackPanel.ToolTip = null;
            // 
            // Message
            // 
            Message.AutoWordSelection = false;
            Message.BindingSource = null;
            Message.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            Message.DataFilter = null;
            Message.DisabledBackColor = System.Drawing.Color.FromArgb(   204  ,   204  ,   204   );
            Message.DisabledBorderColor = System.Drawing.Color.FromArgb(   155  ,   155  ,   155   );
            Message.DisabledForeColor = System.Drawing.Color.FromArgb(   136  ,   136  ,   136   );
            Message.Dock = System.Windows.Forms.DockStyle.Fill;
            Message.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Lines = null;
            Message.Location = new System.Drawing.Point( 1, 1 );
            Message.MaxLength = 32767;
            Message.Name = "Message";
            Message.Padding = new System.Windows.Forms.Padding( 1 );
            Message.ReadOnly = false;
            Message.Size = new System.Drawing.Size( 571, 161 );
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
            Header.Controls.Add( picture1, 0, 0 );
            Header.Controls.Add( label1, 1, 0 );
            Header.Dock = System.Windows.Forms.DockStyle.Top;
            Header.Location = new System.Drawing.Point( 0, 0 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 638, 31 );
            Header.TabIndex = 2;
            // 
            // picture1
            // 
            picture1.BackColor = System.Drawing.Color.Transparent;
            picture1.BindingSource = null;
            picture1.DataFilter = null;
            picture1.HoverText = null;
            picture1.Image = Resources.Images.SplashNotification;
            picture1.ImageList = null;
            picture1.Location = new System.Drawing.Point( 3, 3 );
            picture1.Name = "picture1";
            picture1.Padding = new System.Windows.Forms.Padding( 1 );
            picture1.Size = new System.Drawing.Size( 27, 25 );
            picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 0;
            picture1.TabStop = false;
            picture1.ToolTip = null;
            // 
            // label1
            // 
            label1.BindingSource = null;
            label1.DataFilter = null;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            label1.HoverText = null;
            label1.IsDerivedStyle = true;
            label1.Location = new System.Drawing.Point( 36, 3 );
            label1.Margin = new System.Windows.Forms.Padding( 3 );
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding( 1 );
            label1.Size = new System.Drawing.Size( 599, 25 );
            label1.Style = MetroSet_UI.Enums.Style.Custom;
            label1.StyleManager = null;
            label1.TabIndex = 1;
            label1.Text = "Notification";
            label1.ThemeAuthor = "Terry D. Eppler";
            label1.ThemeName = "Budget Execution";
            label1.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Interval = 5000;
            // 
            // SplashNotification
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 638, 239 );
            Controls.Add( Header );
            Controls.Add( BackPanel );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 650, 250 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 650, 250 );
            Name = "SplashNotification";
            ShowIcon = false;
            Text = "SplashNotification";
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            BackPanel.ResumeLayout( false );
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) picture1  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public Picture PictureBox;
        private Label Title;
        public Layout BackPanel;
        public RichTextBox Message;
        public System.Windows.Forms.TableLayoutPanel Header;
        private Picture picture1;
        private Label label1;
        public System.Windows.Forms.Timer Timer;
    }
}