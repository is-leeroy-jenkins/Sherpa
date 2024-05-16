
namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class MessageDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container( );
            var resources = new ComponentResourceManager( typeof( MessageDialog ) );
            BindingSource = new BindingSource( components );
            ToolTip = new SmallTip( );
            Timer = new System.Windows.Forms.Timer( components );
            ButtonTable = new TableLayoutPanel( );
            CloseButton = new Button( );
            SelectButton = new Button( );
            BrowseButton = new Button( );
            SaveButton = new Button( );
            MessageTable = new TableLayoutPanel( );
            TextBox = new System.Windows.Forms.RichTextBox( );
            HeaderTable = new TableLayoutPanel( );
            PictureBox = new PictureBox( );
            Title = new Label( );
            StatusLabel = new Label( );
            OpenDialog = new OpenDialog( );
            SaveDialog = new SaveDialog( );
            ( (ISupportInitialize)BindingSource ).BeginInit( );
            ButtonTable.SuspendLayout( );
            MessageTable.SuspendLayout( );
            HeaderTable.SuspendLayout( );
            ( (ISupportInitialize)PictureBox ).BeginInit( );
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
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 8;
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 16.4075985F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 83.5924F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 50F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 154F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 39F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 156F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 109F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 20F ) );
            ButtonTable.Controls.Add( CloseButton, 6, 0 );
            ButtonTable.Controls.Add( SelectButton, 5, 0 );
            ButtonTable.Controls.Add( BrowseButton, 3, 0 );
            ButtonTable.Controls.Add( SaveButton, 1, 0 );
            ButtonTable.Dock = DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 352 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 688, 36 );
            ButtonTable.TabIndex = 18;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 561, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 103, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // SelectButton
            // 
            SelectButton.BindingSource = null;
            SelectButton.DataFilter = null;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SelectButton.HoverText = null;
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 405, 3 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 103, 30 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 1;
            SelectButton.Text = "Ok";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Budget Execution";
            SelectButton.ToolTip = null;
            // 
            // BrowseButton
            // 
            BrowseButton.BindingSource = null;
            BrowseButton.DataFilter = null;
            BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            BrowseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            BrowseButton.HoverText = null;
            BrowseButton.HoverTextColor = System.Drawing.Color.White;
            BrowseButton.IsDerivedStyle = true;
            BrowseButton.Location = new System.Drawing.Point( 212, 3 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.Padding = new Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 103, 30 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 2;
            BrowseButton.Text = "Browse";
            BrowseButton.ThemeAuthor = "Terry D. Eppler";
            BrowseButton.ThemeName = "Budget Execution";
            BrowseButton.ToolTip = null;
            // 
            // SaveButton
            // 
            SaveButton.BindingSource = null;
            SaveButton.DataFilter = null;
            SaveButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SaveButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SaveButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SaveButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SaveButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SaveButton.HoverText = null;
            SaveButton.HoverTextColor = System.Drawing.Color.White;
            SaveButton.IsDerivedStyle = true;
            SaveButton.Location = new System.Drawing.Point( 29, 3 );
            SaveButton.Name = "SaveButton";
            SaveButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SaveButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SaveButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SaveButton.Padding = new Padding( 1 );
            SaveButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SaveButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SaveButton.PressTextColor = System.Drawing.Color.White;
            SaveButton.Size = new System.Drawing.Size( 103, 30 );
            SaveButton.Style = MetroSet_UI.Enums.Style.Custom;
            SaveButton.StyleManager = null;
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.ThemeAuthor = "Terry D. Eppler";
            SaveButton.ThemeName = "Budget Execution";
            SaveButton.ToolTip = null;
            // 
            // MessageTable
            // 
            MessageTable.ColumnCount = 3;
            MessageTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 13.0217028F ) );
            MessageTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 86.9782944F ) );
            MessageTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 88F ) );
            MessageTable.Controls.Add( TextBox, 1, 1 );
            MessageTable.Dock = DockStyle.Fill;
            MessageTable.Location = new System.Drawing.Point( 0, 30 );
            MessageTable.Name = "MessageTable";
            MessageTable.RowCount = 3;
            MessageTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            MessageTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 231F ) );
            MessageTable.RowStyles.Add( new RowStyle( SizeType.Absolute, 59F ) );
            MessageTable.Size = new System.Drawing.Size( 688, 322 );
            MessageTable.TabIndex = 19;
            // 
            // TextBox
            // 
            TextBox.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Dock = DockStyle.Fill;
            TextBox.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            TextBox.Location = new System.Drawing.Point( 81, 35 );
            TextBox.Name = "TextBox";
            TextBox.Size = new System.Drawing.Size( 515, 225 );
            TextBox.TabIndex = 0;
            TextBox.Text = "";
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 3;
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 19.4174767F ) );
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 80.58253F ) );
            HeaderTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 157F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Controls.Add( StatusLabel, 2, 0 );
            HeaderTable.Dock = DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 688, 30 );
            HeaderTable.TabIndex = 20;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.Location = new System.Drawing.Point( 1, 1 );
            PictureBox.Margin = new Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 20, 18 );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = DockStyle.Fill;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 106, 3 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new System.Drawing.Size( 421, 24 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Budget Execution Message";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // StatusLabel
            // 
            StatusLabel.BindingSource = null;
            StatusLabel.Dock = DockStyle.Fill;
            StatusLabel.FlatStyle = FlatStyle.Flat;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            StatusLabel.HoverText = null;
            StatusLabel.IsDerivedStyle = true;
            StatusLabel.Location = new System.Drawing.Point( 533, 3 );
            StatusLabel.Margin = new Padding( 3 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 152, 24 );
            StatusLabel.Style = MetroSet_UI.Enums.Style.Custom;
            StatusLabel.StyleManager = null;
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Date Time";
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            StatusLabel.ThemeAuthor = "Terry D. Eppler";
            StatusLabel.ThemeName = "Budget Execution";
            StatusLabel.ToolTip = null;
            // 
            // OpenDialog
            // 
            OpenDialog.FileName = "openDialog1";
            OpenDialog.Filter = null;
            // 
            // SaveDialog
            // 
            SaveDialog.CheckFileExists = true;
            SaveDialog.Filter = null;
            // 
            // MessageDialog
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 3;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClientSize = new System.Drawing.Size( 688, 388 );
            ControlBox = false;
            Controls.Add( MessageTable );
            Controls.Add( HeaderTable );
            Controls.Add( ButtonTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 700, 400 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 700, 400 );
            Name = "MessageDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ( (ISupportInitialize)BindingSource ).EndInit( );
            ButtonTable.ResumeLayout( false );
            MessageTable.ResumeLayout( false );
            HeaderTable.ResumeLayout( false );
            ( (ISupportInitialize)PictureBox ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        /// <summary>
        /// The tool tip
        /// </summary>
        public SmallTip ToolTip;

        /// <summary>
        /// The binding source
        /// </summary>
        public BindingSource BindingSource;

        /// <summary>
        /// The timer
        /// </summary>
        public System.Windows.Forms.Timer Timer;

        /// <summary>
        /// The button table
        /// </summary>
        public TableLayoutPanel ButtonTable;

        /// <summary>
        /// The message table
        /// </summary>
        public TableLayoutPanel MessageTable;

        /// <summary>
        /// The text box
        /// </summary>
        public System.Windows.Forms.RichTextBox TextBox;

        /// <summary>
        /// The close button
        /// </summary>
        public Button CloseButton;

        /// <summary>
        /// The header table
        /// </summary>
        public TableLayoutPanel HeaderTable;

        /// <summary>
        /// The PictureBox
        /// </summary>
        public PictureBox PictureBox;

        /// <summary>
        /// The title
        /// </summary>
        public Label Title;

        /// <summary>
        /// The select button
        /// </summary>
        public Button SelectButton;

        /// <summary>
        /// The browse button
        /// </summary>
        public Button BrowseButton;

        /// <summary>
        /// The open dialog
        /// </summary>
        public OpenDialog OpenDialog;

        /// <summary>
        /// The save dialog
        /// </summary>
        public SaveDialog SaveDialog;

        /// <summary>
        /// The save button
        /// </summary>
        public Button SaveButton;
        public Label StatusLabel;
    }

}