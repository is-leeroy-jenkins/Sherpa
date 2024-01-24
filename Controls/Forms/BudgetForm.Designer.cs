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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( BudgetForm ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Style = new MetroSet_UI.Components.StyleManager( );
            Timer = new System.Windows.Forms.Timer( components );
            toolStripMenuItemExt1 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt2 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt3 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt4 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt5 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt6 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            toolStripMenuItemExt7 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripMenuItemExt( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            SuspendLayout( );
            // 
            // Header
            // 
            Header.ColumnCount = 3;
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.316891F ) );
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.6831055F ) );
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 151F ) );
            Header.Controls.Add( PictureBox, 0, 0 );
            Header.Dock = System.Windows.Forms.DockStyle.Top;
            Header.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Header.Location = new System.Drawing.Point( 0, 0 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 1338, 24 );
            Header.TabIndex = 1;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.budget;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 21, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Style
            // 
            Style.CustomTheme = "C:\\Users\\terry\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            Style.MetroForm = this;
            Style.Style = MetroSet_UI.Enums.Style.Custom;
            Style.ThemeAuthor = "Terry D. Eppler";
            Style.ThemeName = "Budget Execution";
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
            // BudgetForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( Header );
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
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
            ResumeLayout( false );
        }

        #endregion
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
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
        public System.Windows.Forms.TableLayoutPanel Header;
        public MetroSet_UI.Components.StyleManager Style;
    }
}