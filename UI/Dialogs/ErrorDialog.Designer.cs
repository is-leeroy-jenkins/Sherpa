namespace Sherpa
{


    partial class ErrorDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ErrorDialog ) );
            Picture = new Picture( );
            Title = new Label( );
            ToolTip = new SmallTip( );
            TextBox = new RichTextBox( );
            CloseButton = new Button( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            StatusLabel = new Label( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize)Picture ).BeginInit( );
            HeaderTable.SuspendLayout( );
            ButtonTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            SuspendLayout( );
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.BindingSource = null;
            Picture.DataFilter = null;
            Picture.HoverText = null;
            Picture.Image = Resources.Images.DialogImages.Error;
            Picture.ImageList = null;
            Picture.Location = new System.Drawing.Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new System.Windows.Forms.Padding( 1 );
            Picture.Size = new System.Drawing.Size( 20, 18 );
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 14;
            Picture.TabStop = false;
            Picture.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 133, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 402, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 13;
            Title.Text = "There has been error!";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Sherpa";
            Title.ToolTip = null;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
            ToolTip.BindingSource = null;
            ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            ToolTip.ForeColor = System.Drawing.Color.White;
            ToolTip.InitialDelay = 500;
            ToolTip.IsDerivedStyle = true;
            ToolTip.Name = null;
            ToolTip.OwnerDraw = true;
            ToolTip.ReshowDelay = 100;
            ToolTip.Style = MetroSet_UI.Enums.Style.Custom;
            ToolTip.StyleManager = null;
            ToolTip.ThemeAuthor = "Terry D. Eppler";
            ToolTip.ThemeName = "Sherpa";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // TextBox
            // 
            TextBox.AutoWordSelection = false;
            TextBox.BindingSource = null;
            TextBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TextBox.DataFilter = null;
            TextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            TextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            TextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            TextBox.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            TextBox.HoverColor = System.Drawing.Color.Maroon;
            TextBox.HoverText = null;
            TextBox.IsDerivedStyle = true;
            TextBox.Lines = null;
            TextBox.Location = new System.Drawing.Point( 89, 91 );
            TextBox.MaxLength = 32767;
            TextBox.Name = "TextBox";
            TextBox.Padding = new System.Windows.Forms.Padding( 1 );
            TextBox.ReadOnly = false;
            TextBox.Size = new System.Drawing.Size( 544, 230 );
            TextBox.Style = MetroSet_UI.Enums.Style.Custom;
            TextBox.StyleManager = null;
            TextBox.TabIndex = 0;
            TextBox.Text = "TextBox";
            TextBox.ThemeAuthor = "Terry D. Eppler";
            TextBox.ThemeName = "Sherpa";
            TextBox.ToolTip = ToolTip;
            TextBox.WordWrap = true;
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
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 593, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.Red;
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 26 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 15;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Sherpa";
            CloseButton.ToolTip = null;
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 3;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 24.1635685F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 75.83643F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 149F ) );
            HeaderTable.Controls.Add( Picture, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Controls.Add( StatusLabel, 2, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 688, 29 );
            HeaderTable.TabIndex = 16;
            // 
            // StatusLabel
            // 
            StatusLabel.BindingSource = null;
            StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            StatusLabel.HoverText = null;
            StatusLabel.IsDerivedStyle = true;
            StatusLabel.Location = new System.Drawing.Point( 541, 3 );
            StatusLabel.Margin = new System.Windows.Forms.Padding( 3 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 144, 23 );
            StatusLabel.Style = MetroSet_UI.Enums.Style.Custom;
            StatusLabel.StyleManager = null;
            StatusLabel.TabIndex = 15;
            StatusLabel.Text = "Date Time";
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StatusLabel.ThemeAuthor = "Terry D. Eppler";
            StatusLabel.ThemeName = "Sherpa";
            StatusLabel.ToolTip = ToolTip;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 7;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 120F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 119F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 43F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 98F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 97F ) );
            ButtonTable.Controls.Add( CloseButton, 6, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 407 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 688, 32 );
            ButtonTable.TabIndex = 17;
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // ErrorDialog
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.Maroon;
            BorderThickness = 2;
            CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9F );
            CaptionForeColor = System.Drawing.Color.Red;
            ClientSize = new System.Drawing.Size( 688, 439 );
            ControlBox = false;
            Controls.Add( ButtonTable );
            Controls.Add( HeaderTable );
            Controls.Add( TextBox );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 700, 450 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 700, 450 );
            Name = "ErrorDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "ErrorDialog";
            ( (System.ComponentModel.ISupportInitialize)Picture ).EndInit( );
            HeaderTable.ResumeLayout( false );
            ButtonTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public RichTextBox TextBox;
        public BackPanel BackPanel;
        public SmallTip ToolTip;
        public Label Title;
        public Picture Picture;
        public Button CloseButton;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        public Label StatusLabel;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
    }
}