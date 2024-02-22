namespace BudgetExecution
{
    public partial class SplashMessage
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SplashMessage ) );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new Picture( );
            Title = new System.Windows.Forms.Label( );
            Timer = new System.Windows.Forms.Timer( components );
            BackPanel = new BackPanel( );
            Message = new Label( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            BackPanel.SuspendLayout( );
            SuspendLayout( );
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
            Header.Size = new System.Drawing.Size( 669, 31 );
            Header.TabIndex = 2;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.DialogImages.SplashNotification;
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
            Title.AutoSize = true;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            Title.ForeColor = System.Drawing.Color.White;
            Title.Location = new System.Drawing.Point( 37, 0 );
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size( 629, 31 );
            Title.TabIndex = 1;
            Title.Text = "Notification";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = System.Drawing.Color.Transparent;
            BackPanel.BackgroundColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            BackPanel.BindingSource = null;
            BackPanel.BorderColor = System.Drawing.Color.FromArgb(   106  ,   189  ,   252   );
            BackPanel.BorderThickness = 1;
            BackPanel.Children = null;
            BackPanel.Controls.Add( Message );
            BackPanel.Controls.Add( Header );
            BackPanel.DataFilter = null;
            BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            BackPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackPanel.ForeColor = System.Drawing.Color.Transparent;
            BackPanel.HoverText = null;
            BackPanel.IsDerivedStyle = true;
            BackPanel.Location = new System.Drawing.Point( 0, 0 );
            BackPanel.Margin = new System.Windows.Forms.Padding( 0 );
            BackPanel.Name = "BackPanel";
            BackPanel.Padding = new System.Windows.Forms.Padding( 1 );
            BackPanel.Size = new System.Drawing.Size( 735, 371 );
            BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BackPanel.StyleManager = null;
            BackPanel.TabIndex = 3;
            BackPanel.ThemeAuthor = "Terry D. Eppler";
            BackPanel.ThemeName = "Budget Execution";
            BackPanel.ToolTip = null;
            // 
            // Message
            // 
            Message.BindingSource = null;
            Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Message.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Message.HoverText = null;
            Message.IsDerivedStyle = true;
            Message.Location = new System.Drawing.Point( 152, 92 );
            Message.Margin = new System.Windows.Forms.Padding( 3 );
            Message.Name = "Message";
            Message.Padding = new System.Windows.Forms.Padding( 1 );
            Message.Size = new System.Drawing.Size( 433, 148 );
            Message.Style = MetroSet_UI.Enums.Style.Custom;
            Message.StyleManager = null;
            Message.TabIndex = 3;
            Message.Text = "label1";
            Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Message.ThemeAuthor = "Terry D. Eppler";
            Message.ThemeName = "Budget Execution";
            Message.ToolTip = null;
            // 
            // SplashMessage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            BorderColor = System.Drawing.Color.Transparent;
            CaptionBarColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 735, 371 );
            Controls.Add( BackPanel );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 735, 371 );
            MetroColor = System.Drawing.Color.FromArgb(   0  ,   73  ,   112   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 735, 371 );
            Name = "SplashMessage";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "SplashNotification";
            Header.ResumeLayout( false );
            Header.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            BackPanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel Header;
        public Picture PictureBox;
        public System.Windows.Forms.Timer Timer;
        public BackPanel BackPanel;
        public System.Windows.Forms.Label Title;
        public Label Message;
    }
}