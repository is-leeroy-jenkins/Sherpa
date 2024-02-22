namespace BudgetExecution
{
    partial class SplashForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SplashForm ) );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            Timer = new System.Windows.Forms.Timer( components );
            CloseButton = new Button( );
            ContextMenu = new ContextMenu( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            SuspendLayout( );
            // 
            // Header
            // 
            Header.ColumnCount = 2;
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 3.2884903F ) );
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 96.71151F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Controls.Add( Title, 1, 0 );
            Header.Dock = System.Windows.Forms.DockStyle.Top;
            Header.Location = new System.Drawing.Point( 0, 0 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 1338, 30 );
            Header.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 24, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 47, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1288, 24 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // CloseButton
            // 
            CloseButton.Anchor =  System.Windows.Forms.AnchorStyles.Bottom  |  System.Windows.Forms.AnchorStyles.Right ;
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
            CloseButton.Location = new System.Drawing.Point( 1245, 706 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.DarkGray;
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // ContextMenu
            // 
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.DropShadowEnabled = false;
            ContextMenu.Font = new System.Drawing.Font( "Roboto", 9F );
            ContextMenu.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ContextMenu.MetroColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.Name = "ContextMenu";
            ContextMenu.Size = new System.Drawing.Size( 126, 180 );
            ContextMenu.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Office2016Black;
            ContextMenu.ThemeName = "Office2016Black";
            ContextMenu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 77, 77, 77 );
            ContextMenu.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ContextMenu.ThemeStyle.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ContextMenu.ThemeStyle.HoverBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ContextMenu.ThemeStyle.HoverForeColor = System.Drawing.Color.White;
            ContextMenu.ThemeStyle.PressedBackColor = System.Drawing.Color.FromArgb( 204, 204, 204 );
            ContextMenu.ThemeStyle.PressedForeColor = System.Drawing.Color.Black;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto Condensed", 11.25F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( CloseButton );
            Controls.Add( Header );
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1340, 740 );
            Name = "SplashForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Header;
        public System.Windows.Forms.PictureBox PictureBox;
        public Label Title;
        public System.Windows.Forms.Timer Timer;
        public Button CloseButton;
        public ContextMenu ContextMenu;
    }
}