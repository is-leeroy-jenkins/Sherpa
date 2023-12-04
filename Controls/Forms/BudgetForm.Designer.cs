namespace BudgetExecution
{
    partial class BudgetForm
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
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            CloseButton = new Button( );
            Timer = new System.Windows.Forms.Timer( components );
            toolStripMenuItemExt1 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt2 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt3 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt4 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt5 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt6 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt7 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            currencyEdit1 = new Syncfusion.Windows.Forms.Tools.CurrencyEdit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)currencyEdit1 ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)currencyEdit1.TextBox ).BeginInit( );
            SuspendLayout( );
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
            ToolTip.ThemeName = "Budget Execution";
            ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
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
            Header.TabIndex = 1;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.EPA;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 38, 20 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 8F );
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
            CloseButton.Location = new System.Drawing.Point( 1245, 707 );
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
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // toolStripMenuItemExt1
            // 
            toolStripMenuItemExt1.Name = "toolStripMenuItemExt1";
            toolStripMenuItemExt1.Size = new System.Drawing.Size( 196, 22 );
            toolStripMenuItemExt1.Text = "toolStripMenuItemExt1";
            // 
            // toolStripMenuItemExt2
            // 
            toolStripMenuItemExt2.Name = "toolStripMenuItemExt2";
            toolStripMenuItemExt2.Size = new System.Drawing.Size( 198, 22 );
            toolStripMenuItemExt2.Text = "toolStripMenuItemExt2";
            // 
            // toolStripMenuItemExt3
            // 
            toolStripMenuItemExt3.Name = "toolStripMenuItemExt3";
            toolStripMenuItemExt3.Size = new System.Drawing.Size( 198, 22 );
            toolStripMenuItemExt3.Text = "toolStripMenuItemExt3";
            // 
            // toolStripMenuItemExt4
            // 
            toolStripMenuItemExt4.Name = "toolStripMenuItemExt4";
            toolStripMenuItemExt4.Size = new System.Drawing.Size( 198, 22 );
            toolStripMenuItemExt4.Text = "toolStripMenuItemExt4";
            // 
            // toolStripMenuItemExt5
            // 
            toolStripMenuItemExt5.Name = "toolStripMenuItemExt5";
            toolStripMenuItemExt5.Size = new System.Drawing.Size( 198, 22 );
            toolStripMenuItemExt5.Text = "toolStripMenuItemExt5";
            // 
            // toolStripMenuItemExt6
            // 
            toolStripMenuItemExt6.Name = "toolStripMenuItemExt6";
            toolStripMenuItemExt6.Size = new System.Drawing.Size( 198, 22 );
            toolStripMenuItemExt6.Text = "toolStripMenuItemExt6";
            // 
            // toolStripMenuItemExt7
            // 
            toolStripMenuItemExt7.Name = "toolStripMenuItemExt7";
            toolStripMenuItemExt7.Size = new System.Drawing.Size( 198, 22 );
            toolStripMenuItemExt7.Text = "toolStripMenuItemExt7";
            // 
            // currencyEdit1
            // 
            currencyEdit1.BackColor = System.Drawing.Color.FromArgb( 68, 68, 68 );
            currencyEdit1.BeforeTouchSize = new System.Drawing.Size( 171, 23 );
            currencyEdit1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            currencyEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2016Black;
            currencyEdit1.FlatBorderColor = System.Drawing.Color.FromArgb( 77, 77, 77 );
            currencyEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            currencyEdit1.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            currencyEdit1.Location = new System.Drawing.Point( 625, 421 );
            currencyEdit1.MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            currencyEdit1.Name = "currencyEdit1";
            currencyEdit1.SelectionStart = 2;
            currencyEdit1.Size = new System.Drawing.Size( 171, 23 );
            currencyEdit1.TabIndex = 3;
            // 
            // 
            // 
            currencyEdit1.TextBox.BackGroundColor = System.Drawing.Color.FromArgb( 68, 68, 68 );
            currencyEdit1.TextBox.BeforeTouchSize = new System.Drawing.Size( 100, 23 );
            currencyEdit1.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            currencyEdit1.TextBox.DecimalValue = new decimal( new int[ ] { 100, 0, 0, 131072 } );
            currencyEdit1.TextBox.ForeColor = System.Drawing.Color.FromArgb( 218, 218, 218 );
            currencyEdit1.TextBox.Location = new System.Drawing.Point( 2, 4 );
            currencyEdit1.TextBox.Name = "";
            currencyEdit1.TextBox.Size = new System.Drawing.Size( 143, 15 );
            currencyEdit1.TextBox.TabIndex = 0;
            currencyEdit1.TextBox.Text = "$1.00";
            currencyEdit1.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            currencyEdit1.ThemeName = "Office2016Black";
            currencyEdit1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            currencyEdit1.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb( 77, 77, 77 );
            currencyEdit1.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            currencyEdit1.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            currencyEdit1.UseVisualStyle = true;
            // 
            // BudgetForm
            // 
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( currencyEdit1 );
            Controls.Add( CloseButton );
            Controls.Add( Header );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "BudgetForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)currencyEdit1.TextBox ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)currencyEdit1 ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.TableLayoutPanel Header;
        public System.Windows.Forms.PictureBox PictureBox;
        public Label Title;
        public Button CloseButton;
        public System.Windows.Forms.Timer Timer;
        public Syncfusion.Windows.Forms.Tools.ProgressBarAdv progressBarAdv1;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt1;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt2;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt3;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt4;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt5;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt6;
        private Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt toolStripMenuItemExt7;
        private Syncfusion.Windows.Forms.Tools.CurrencyEdit currencyEdit1;
    }
}