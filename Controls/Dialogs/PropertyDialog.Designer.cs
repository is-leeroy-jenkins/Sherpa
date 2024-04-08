namespace BudgetExecution
{
    partial class PropertyDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( PropertyDialog ) );
            PropertyEditor = new Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor( components );
            PropertyTable = new System.Windows.Forms.TableLayoutPanel( );
            Title = new Label( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            BrowseButton = new Button( );
            SelectButton = new Button( );
            CloseButton = new Button( );
            Timer = new System.Windows.Forms.Timer( components );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            StatusLabel = new Label( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolTip = new SmallTip( );
            PropertyTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ButtonTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            HeaderTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // PropertyEditor
            // 
            PropertyEditor.Diagram = null;
            PropertyEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            PropertyEditor.Location = new System.Drawing.Point( 31, 30 );
            PropertyEditor.Name = "PropertyEditor";
            PropertyEditor.Size = new System.Drawing.Size( 338, 399 );
            PropertyEditor.TabIndex = 0;
            // 
            // PropertyTable
            // 
            PropertyTable.ColumnCount = 3;
            PropertyTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            PropertyTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 344F ) );
            PropertyTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 27F ) );
            PropertyTable.Controls.Add( HeaderTable, 1, 0 );
            PropertyTable.Controls.Add( PropertyEditor, 1, 1 );
            PropertyTable.Controls.Add( PictureBox, 0, 0 );
            PropertyTable.Controls.Add( ButtonTable, 1, 2 );
            PropertyTable.Dock = System.Windows.Forms.DockStyle.Fill;
            PropertyTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            PropertyTable.Location = new System.Drawing.Point( 0, 0 );
            PropertyTable.Name = "PropertyTable";
            PropertyTable.RowCount = 3;
            PropertyTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 6.25F ) );
            PropertyTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 93.75F ) );
            PropertyTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 39F ) );
            PropertyTable.Size = new System.Drawing.Size( 399, 472 );
            PropertyTable.TabIndex = 1;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 3, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 205, 15 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 0;
            Title.Text = "Property Configuration";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 18, 19 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 6;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 76.57658F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 23.4234238F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 8F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 106F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 28F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 91F ) );
            ButtonTable.Controls.Add( BrowseButton, 0, 0 );
            ButtonTable.Controls.Add( SelectButton, 3, 0 );
            ButtonTable.Controls.Add( CloseButton, 5, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ButtonTable.Location = new System.Drawing.Point( 31, 435 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 338, 34 );
            ButtonTable.TabIndex = 2;
            // 
            // BrowseButton
            // 
            BrowseButton.BindingSource = null;
            BrowseButton.DataFilter = null;
            BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            BrowseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            BrowseButton.HoverText = null;
            BrowseButton.HoverTextColor = System.Drawing.Color.White;
            BrowseButton.IsDerivedStyle = true;
            BrowseButton.Location = new System.Drawing.Point( 3, 3 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 74, 28 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 0;
            BrowseButton.Text = "Browse";
            BrowseButton.ThemeAuthor = "Terry D. Eppler";
            BrowseButton.ThemeName = "Budget Execution";
            BrowseButton.ToolTip = null;
            // 
            // SelectButton
            // 
            SelectButton.BindingSource = null;
            SelectButton.DataFilter = null;
            SelectButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SelectButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SelectButton.HoverText = null;
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 115, 3 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 79, 28 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 1;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Budget Execution";
            SelectButton.ToolTip = null;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 249, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 79, 28 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 80;
            // 
            // StatusLabel
            // 
            StatusLabel.BindingSource = null;
            StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            StatusLabel.HoverText = null;
            StatusLabel.IsDerivedStyle = true;
            StatusLabel.Location = new System.Drawing.Point( 214, 3 );
            StatusLabel.Margin = new System.Windows.Forms.Padding( 3 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 121, 15 );
            StatusLabel.Style = MetroSet_UI.Enums.Style.Custom;
            StatusLabel.StyleManager = null;
            StatusLabel.TabIndex = 3;
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            StatusLabel.ThemeAuthor = "Terry D. Eppler";
            StatusLabel.ThemeName = "Budget Execution";
            StatusLabel.ToolTip = null;
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 127F ) );
            HeaderTable.Controls.Add( Title, 0, 0 );
            HeaderTable.Controls.Add( StatusLabel, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            HeaderTable.Location = new System.Drawing.Point( 31, 3 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 338, 21 );
            HeaderTable.TabIndex = 2;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
            ToolTip.BindingSource = BindingSource;
            ToolTip.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
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
            // PropertyDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 399, 472 );
            ControlBox = false;
            Controls.Add( PropertyTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            Name = "PropertyDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PropertyConfiguration";
            PropertyTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ButtonTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            HeaderTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        public Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor PropertyEditor;
        private System.Windows.Forms.TableLayoutPanel PropertyTable;
        public Label Title;
        public System.Windows.Forms.PictureBox PictureBox;
        public System.Windows.Forms.TableLayoutPanel ButtonTable;
        private Button BrowseButton;
        private Button SelectButton;
        private Button CloseButton;
        public System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        public Label StatusLabel;
        public SmallTip ToolTip;
    }
}