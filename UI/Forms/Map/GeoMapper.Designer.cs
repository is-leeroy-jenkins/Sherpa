namespace Sherpa
{
    partial class GeoMapper
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GeoMapper ) );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            ControlBox = new ControlBox( );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ToolStrip = new ToolStrip( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            Separator1 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            NavigationLabel = new ToolStripLabel( );
            Separator2 = new ToolSeparator( );
            LeftButton = new ToolStripButton( );
            ToolTip = new SmallTip( );
            Separator3 = new ToolSeparator( );
            RightButton = new ToolStripButton( );
            RightSeparator = new ToolSeparator( );
            TextBox = new ToolStripTextBox( );
            Separator23 = new ToolSeparator( );
            LookupButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            UpButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            DownButton = new ToolStripButton( );
            Separator6 = new ToolSeparator( );
            MinusButton = new ToolStripButton( );
            MinusSeparator = new ToolSeparator( );
            PlusButton = new ToolStripButton( );
            PlusSeparator = new ToolSeparator( );
            DataSpacer = new ToolStripLabel( );
            DataLabel = new ToolStripLabel( );
            Separator7 = new ToolSeparator( );
            FilterButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            Separator9 = new ToolSeparator( );
            FileSysSpacer = new ToolStripLabel( );
            FileSysLabel = new ToolStripLabel( );
            Separator10 = new ToolSeparator( );
            BrowseButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            SaveButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            ApplicationSpacer = new ToolStripLabel( );
            Separator13 = new ToolSeparator( );
            CloseButton = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            Separator15 = new ToolSeparator( );
            MenuLabel = new ToolStripLabel( );
            Separator22 = new ToolSeparator( );
            Timer = new System.Windows.Forms.Timer( components );
            Map = new GMap.NET.WindowsForms.GMapControl( );
            MapTable = new System.Windows.Forms.TableLayoutPanel( );
            MapPanel = new BackPanel( );
            ContextMenu = new ContextMenu( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ToolStripTable.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            MapTable.SuspendLayout( );
            MapPanel.SuspendLayout( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 3;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 7.91666651F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 92.0833359F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 133F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Controls.Add( ControlBox, 2, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 1, 1 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1326, 32 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.Location = new System.Drawing.Point( 1, 1 );
            PictureBox.Margin = new System.Windows.Forms.Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 20, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 97, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1092, 26 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Geo Map";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Sherpa";
            Title.ToolTip = null;
            // 
            // ControlBox
            // 
            ControlBox.CloseHoverBackColor = System.Drawing.Color.Maroon;
            ControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            ControlBox.CloseNormalForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ControlBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            ControlBox.Font = new System.Drawing.Font( "Roboto", 9F );
            ControlBox.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ControlBox.IsDerivedStyle = true;
            ControlBox.Location = new System.Drawing.Point( 1225, 1 );
            ControlBox.Margin = new System.Windows.Forms.Padding( 1 );
            ControlBox.MaximizeBox = true;
            ControlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ControlBox.MaximizeHoverForeColor = System.Drawing.Color.White;
            ControlBox.MaximizeNormalForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ControlBox.MinimizeBox = true;
            ControlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ControlBox.MinimizeHoverForeColor = System.Drawing.Color.White;
            ControlBox.MinimizeNormalForeColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ControlBox.Name = "ControlBox";
            ControlBox.Padding = new System.Windows.Forms.Padding( 1 );
            ControlBox.Size = new System.Drawing.Size( 100, 25 );
            ControlBox.Style = MetroSet_UI.Enums.Style.Custom;
            ControlBox.StyleManager = null;
            ControlBox.TabIndex = 2;
            ControlBox.ThemeAuthor = "Terry D. Eppler";
            ControlBox.ThemeName = "DarkControls";
            // 
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 1;
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Controls.Add( ToolStrip, 0, 0 );
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point( 1, 682 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1326, 45 );
            ToolStripTable.TabIndex = 1;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton = null;
            ToolStrip.AddColumnButton = null;
            ToolStrip.AddTableButton = null;
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            ToolStrip.CalculatorButton = null;
            ToolStrip.CanOverrideStyle = true;
            ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F );
            ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            ToolStrip.ChartButton = null;
            ToolStrip.DataFilter = null;
            ToolStrip.DeleteButton = null;
            ToolStrip.DeleteColumnButton = null;
            ToolStrip.DeleteRecordButton = null;
            ToolStrip.DeleteTableButton = null;
            ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            ToolStrip.DropDown = null;
            ToolStrip.EditButton = null;
            ToolStrip.EditColumnButton = null;
            ToolStrip.EditRecordButton = null;
            ToolStrip.EditSqlButton = null;
            ToolStrip.ExcelButton = null;
            ToolStrip.FilterDataButton = null;
            ToolStrip.FirstButton = null;
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F );
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, StatusLabel, NavigationLabel, Separator2, LeftButton, Separator3, RightButton, RightSeparator, TextBox, Separator23, LookupButton, Separator4, UpButton, Separator5, DownButton, Separator6, MinusButton, MinusSeparator, PlusButton, PlusSeparator, DataSpacer, DataLabel, Separator7, FilterButton, Separator8, RefreshButton, Separator9, FileSysSpacer, FileSysLabel, Separator10, BrowseButton, Separator11, SaveButton, Separator12, ApplicationSpacer, Separator13, CloseButton, Separator14, MenuButton, Separator15, MenuLabel, Separator22 } );
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 1, 1 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            ToolStrip.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStrip.PreviousButton = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SaveButton = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1324, 43 );
            ToolStrip.TabIndex = 0;
            ToolStrip.TextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb( 28, 28, 28 );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 25 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.Transparent;
            StatusLabel.BindingSource = null;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 66, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date And Time";
            StatusLabel.ToolTip = null;
            // 
            // NavigationLabel
            // 
            NavigationLabel.BackColor = System.Drawing.Color.Transparent;
            NavigationLabel.BindingSource = null;
            NavigationLabel.DataFilter = null;
            NavigationLabel.Field = Field.AccountCode;
            NavigationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            NavigationLabel.ForeColor = System.Drawing.Color.Black;
            NavigationLabel.HoverText = null;
            NavigationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            NavigationLabel.Name = "NavigationLabel";
            NavigationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            NavigationLabel.Size = new System.Drawing.Size( 79, 25 );
            NavigationLabel.Tag = "";
            NavigationLabel.Text = "              Navigation:";
            NavigationLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LeftButton
            // 
            LeftButton.AutoToolTip = false;
            LeftButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            LeftButton.BindingSource = BindingSource;
            LeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LeftButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LeftButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            LeftButton.HoverText = "Left";
            LeftButton.Image = Resources.Images.ToolStripImages.LeftButton;
            LeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LeftButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LeftButton.Name = "LeftButton";
            LeftButton.Padding = new System.Windows.Forms.Padding( 1 );
            LeftButton.Size = new System.Drawing.Size( 23, 25 );
            LeftButton.Text = "toolStripButton1";
            LeftButton.ToolTip = ToolTip;
            LeftButton.ToolType = ToolType.FirstButton;
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
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 25 );
            // 
            // RightButton
            // 
            RightButton.AutoToolTip = false;
            RightButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            RightButton.BindingSource = BindingSource;
            RightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RightButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RightButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RightButton.HoverText = "Right";
            RightButton.Image = Resources.Images.ToolStripImages.RightButton;
            RightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RightButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RightButton.Name = "RightButton";
            RightButton.Padding = new System.Windows.Forms.Padding( 1 );
            RightButton.Size = new System.Drawing.Size( 23, 25 );
            RightButton.Text = "toolStripButton2";
            RightButton.ToolTip = null;
            RightButton.ToolType = ToolType.PreviousButton;
            // 
            // RightSeparator
            // 
            RightSeparator.ForeColor = System.Drawing.Color.Black;
            RightSeparator.Margin = new System.Windows.Forms.Padding( 5, 1, 1, 1 );
            RightSeparator.Name = "RightSeparator";
            RightSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            RightSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // TextBox
            // 
            TextBox.BackColor = System.Drawing.Color.FromArgb( 10, 10, 10 );
            TextBox.BindingSource = BindingSource;
            TextBox.Field = Field.AccountCode;
            TextBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            TextBox.HoverText = "Search Web";
            TextBox.Margin = new System.Windows.Forms.Padding( 1 );
            TextBox.Name = "TextBox";
            TextBox.Padding = new System.Windows.Forms.Padding( 1 );
            TextBox.Size = new System.Drawing.Size( 160, 25 );
            TextBox.Tag = "";
            TextBox.Text = "Enter Location";
            TextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            TextBox.ToolTip = ToolTip;
            // 
            // Separator23
            // 
            Separator23.ForeColor = System.Drawing.Color.Black;
            Separator23.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator23.Name = "Separator23";
            Separator23.Padding = new System.Windows.Forms.Padding( 1 );
            Separator23.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip = false;
            LookupButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            LookupButton.BindingSource = BindingSource;
            LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LookupButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LookupButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            LookupButton.HoverText = "Begin Search";
            LookupButton.Image = Resources.Images.ToolStripImages.WebGoButton;
            LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LookupButton.Margin = new System.Windows.Forms.Padding( 1 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new System.Windows.Forms.Padding( 1 );
            LookupButton.Size = new System.Drawing.Size( 23, 25 );
            LookupButton.ToolTip = ToolTip;
            LookupButton.ToolType = ToolType.NS;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 25 );
            // 
            // UpButton
            // 
            UpButton.AutoToolTip = false;
            UpButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            UpButton.BindingSource = BindingSource;
            UpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            UpButton.Font = new System.Drawing.Font( "Roboto", 9F );
            UpButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            UpButton.HoverText = "Next Location";
            UpButton.Image = Resources.Images.ToolStripImages.UpButton;
            UpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            UpButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            UpButton.Name = "UpButton";
            UpButton.Padding = new System.Windows.Forms.Padding( 1 );
            UpButton.Size = new System.Drawing.Size( 23, 25 );
            UpButton.Text = "toolStripButton3";
            UpButton.ToolTip = ToolTip;
            UpButton.ToolType = ToolType.NextButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 25 );
            // 
            // DownButton
            // 
            DownButton.AutoToolTip = false;
            DownButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            DownButton.BindingSource = BindingSource;
            DownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            DownButton.Font = new System.Drawing.Font( "Roboto", 9F );
            DownButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DownButton.HoverText = "Down";
            DownButton.Image = Resources.Images.ToolStripImages.DownButton;
            DownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            DownButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            DownButton.Name = "DownButton";
            DownButton.Padding = new System.Windows.Forms.Padding( 1 );
            DownButton.Size = new System.Drawing.Size( 23, 25 );
            DownButton.Text = "toolStripButton4";
            DownButton.ToolTip = ToolTip;
            DownButton.ToolType = ToolType.LastButton;
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MinusButton
            // 
            MinusButton.AutoToolTip = false;
            MinusButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            MinusButton.BindingSource = null;
            MinusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MinusButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MinusButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            MinusButton.HoverText = null;
            MinusButton.Image = Resources.Images.ToolStripImages.MinusButton;
            MinusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MinusButton.Margin = new System.Windows.Forms.Padding( 3 );
            MinusButton.Name = "MinusButton";
            MinusButton.Padding = new System.Windows.Forms.Padding( 1 );
            MinusButton.Size = new System.Drawing.Size( 23, 21 );
            MinusButton.Text = "toolStripButton1";
            MinusButton.ToolTip = null;
            MinusButton.ToolType = ToolType.NS;
            // 
            // MinusSeparator
            // 
            MinusSeparator.ForeColor = System.Drawing.Color.Black;
            MinusSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            MinusSeparator.Name = "MinusSeparator";
            MinusSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            MinusSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // PlusButton
            // 
            PlusButton.AutoToolTip = false;
            PlusButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            PlusButton.BindingSource = null;
            PlusButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PlusButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PlusButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            PlusButton.HoverText = null;
            PlusButton.Image = Resources.Images.ToolStripImages.PlusButton;
            PlusButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PlusButton.Margin = new System.Windows.Forms.Padding( 3 );
            PlusButton.Name = "PlusButton";
            PlusButton.Padding = new System.Windows.Forms.Padding( 1 );
            PlusButton.Size = new System.Drawing.Size( 23, 21 );
            PlusButton.Text = "toolStripButton2";
            PlusButton.ToolTip = null;
            PlusButton.ToolType = ToolType.NS;
            // 
            // PlusSeparator
            // 
            PlusSeparator.ForeColor = System.Drawing.Color.Black;
            PlusSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            PlusSeparator.Name = "PlusSeparator";
            PlusSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            PlusSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // DataSpacer
            // 
            DataSpacer.BackColor = System.Drawing.Color.Transparent;
            DataSpacer.BindingSource = null;
            DataSpacer.DataFilter = null;
            DataSpacer.Field = Field.AccountCode;
            DataSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F );
            DataSpacer.ForeColor = System.Drawing.Color.Transparent;
            DataSpacer.HoverText = null;
            DataSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            DataSpacer.Name = "DataSpacer";
            DataSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            DataSpacer.Size = new System.Drawing.Size( 67, 25 );
            DataSpacer.Tag = "";
            DataSpacer.Text = "toolStripLabel1";
            DataSpacer.ToolTip = null;
            // 
            // DataLabel
            // 
            DataLabel.BackColor = System.Drawing.Color.Transparent;
            DataLabel.BindingSource = null;
            DataLabel.DataFilter = null;
            DataLabel.Field = Field.AccountCode;
            DataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            DataLabel.ForeColor = System.Drawing.Color.Black;
            DataLabel.HoverText = null;
            DataLabel.Margin = new System.Windows.Forms.Padding( 1 );
            DataLabel.Name = "DataLabel";
            DataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            DataLabel.Size = new System.Drawing.Size( 44, 25 );
            DataLabel.Tag = "";
            DataLabel.Text = "        Data:";
            DataLabel.ToolTip = null;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FilterButton
            // 
            FilterButton.AutoToolTip = false;
            FilterButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FilterButton.BindingSource = BindingSource;
            FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FilterButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FilterButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FilterButton.HoverText = "Filter Locations";
            FilterButton.Image = Resources.Images.ToolStripImages.FilterButton;
            FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FilterButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FilterButton.Name = "FilterButton";
            FilterButton.Padding = new System.Windows.Forms.Padding( 1 );
            FilterButton.Size = new System.Drawing.Size( 23, 25 );
            FilterButton.Text = "toolStripButton4";
            FilterButton.ToolTip = null;
            FilterButton.ToolType = ToolType.FilterButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 25 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            RefreshButton.BindingSource = BindingSource;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            RefreshButton.HoverText = "Reset Map";
            RefreshButton.Image = Resources.Images.ToolStripImages.WebRefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 1 );
            RefreshButton.Size = new System.Drawing.Size( 23, 25 );
            RefreshButton.Text = "toolStripButton5";
            RefreshButton.ToolTip = ToolTip;
            RefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FileSysSpacer
            // 
            FileSysSpacer.BackColor = System.Drawing.Color.Transparent;
            FileSysSpacer.BindingSource = null;
            FileSysSpacer.DataFilter = null;
            FileSysSpacer.Field = Field.AccountCode;
            FileSysSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F );
            FileSysSpacer.ForeColor = System.Drawing.Color.Transparent;
            FileSysSpacer.HoverText = null;
            FileSysSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            FileSysSpacer.Name = "FileSysSpacer";
            FileSysSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            FileSysSpacer.Size = new System.Drawing.Size( 67, 25 );
            FileSysSpacer.Tag = "";
            FileSysSpacer.Text = "toolStripLabel4";
            FileSysSpacer.ToolTip = null;
            // 
            // FileSysLabel
            // 
            FileSysLabel.BackColor = System.Drawing.Color.Transparent;
            FileSysLabel.BindingSource = null;
            FileSysLabel.DataFilter = null;
            FileSysLabel.Field = Field.AccountCode;
            FileSysLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            FileSysLabel.ForeColor = System.Drawing.Color.Black;
            FileSysLabel.HoverText = null;
            FileSysLabel.Margin = new System.Windows.Forms.Padding( 1 );
            FileSysLabel.Name = "FileSysLabel";
            FileSysLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FileSysLabel.Size = new System.Drawing.Size( 57, 25 );
            FileSysLabel.Tag = "";
            FileSysLabel.Text = "         File Sys:";
            FileSysLabel.ToolTip = null;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 25 );
            // 
            // BrowseButton
            // 
            BrowseButton.AutoToolTip = false;
            BrowseButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            BrowseButton.BindingSource = BindingSource;
            BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.HoverText = "Browse System Files";
            BrowseButton.Image = Resources.Images.ToolStripImages.BrowseButton;
            BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BrowseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.Size = new System.Drawing.Size( 23, 25 );
            BrowseButton.Text = "toolStripButton6";
            BrowseButton.ToolTip = ToolTip;
            BrowseButton.ToolType = ToolType.BrowseButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SaveButton
            // 
            SaveButton.AutoToolTip = false;
            SaveButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            SaveButton.BindingSource = BindingSource;
            SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SaveButton.HoverText = "Save Changes";
            SaveButton.Image = Resources.Images.ToolStripImages.SaveButton;
            SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.Size = new System.Drawing.Size( 23, 25 );
            SaveButton.Text = "toolStripButton7";
            SaveButton.ToolTip = ToolTip;
            SaveButton.ToolType = ToolType.SaveButton;
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ApplicationSpacer
            // 
            ApplicationSpacer.BackColor = System.Drawing.Color.Transparent;
            ApplicationSpacer.BindingSource = null;
            ApplicationSpacer.DataFilter = null;
            ApplicationSpacer.Field = Field.AccountCode;
            ApplicationSpacer.Font = new System.Drawing.Font( "Roboto", 6.75F );
            ApplicationSpacer.ForeColor = System.Drawing.Color.Transparent;
            ApplicationSpacer.HoverText = null;
            ApplicationSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationSpacer.Name = "ApplicationSpacer";
            ApplicationSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationSpacer.Size = new System.Drawing.Size( 67, 25 );
            ApplicationSpacer.Tag = "";
            ApplicationSpacer.Text = "toolStripLabel6";
            ApplicationSpacer.ToolTip = null;
            // 
            // Separator13
            // 
            Separator13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 25 );
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            CloseButton.BindingSource = BindingSource;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.HoverText = null;
            CloseButton.Image = Resources.Images.ToolStripImages.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 25 );
            CloseButton.Text = "toolStripButton8";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.CloseButton;
            // 
            // Separator14
            // 
            Separator14.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding( 1 );
            Separator14.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            MenuButton.BindingSource = BindingSource;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            MenuButton.HoverText = "Return to Menu";
            MenuButton.Image = Resources.Images.ToolStripImages.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 25 );
            MenuButton.Text = "toolStripButton9";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // Separator15
            // 
            Separator15.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator15.ForeColor = System.Drawing.Color.Black;
            Separator15.Margin = new System.Windows.Forms.Padding( 3, 1, 3, 1 );
            Separator15.Name = "Separator15";
            Separator15.Padding = new System.Windows.Forms.Padding( 1 );
            Separator15.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuLabel
            // 
            MenuLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuLabel.BackColor = System.Drawing.Color.Transparent;
            MenuLabel.BindingSource = null;
            MenuLabel.DataFilter = null;
            MenuLabel.Field = Field.AccountCode;
            MenuLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            MenuLabel.ForeColor = System.Drawing.Color.Black;
            MenuLabel.HoverText = "Close Application";
            MenuLabel.Margin = new System.Windows.Forms.Padding( 1 );
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Padding = new System.Windows.Forms.Padding( 1 );
            MenuLabel.Size = new System.Drawing.Size( 38, 25 );
            MenuLabel.Tag = "";
            MenuLabel.Text = "   Menu:";
            MenuLabel.ToolTip = null;
            // 
            // Separator22
            // 
            Separator22.ForeColor = System.Drawing.Color.Black;
            Separator22.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator22.Name = "Separator22";
            Separator22.Padding = new System.Windows.Forms.Padding( 1 );
            Separator22.Size = new System.Drawing.Size( 6, 25 );
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // Map
            // 
            Map.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Map.Bearing = 0F;
            Map.CanDragMap = true;
            Map.Dock = System.Windows.Forms.DockStyle.Fill;
            Map.EmptyTileColor = System.Drawing.Color.Navy;
            Map.GrayScaleMode = false;
            Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            Map.LevelsKeepInMemory = 5;
            Map.Location = new System.Drawing.Point( 1, 1 );
            Map.MarkersEnabled = true;
            Map.MaxZoom = 2;
            Map.MinZoom = 2;
            Map.MouseWheelZoomEnabled = true;
            Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            Map.Name = "Map";
            Map.NegativeMode = false;
            Map.Padding = new System.Windows.Forms.Padding( 1 );
            Map.PolygonsEnabled = true;
            Map.RetryLoadTile = 0;
            Map.RoutesEnabled = true;
            Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb( 33, 65, 105, 225 );
            Map.ShowTileGridLines = false;
            Map.Size = new System.Drawing.Size( 1159, 561 );
            Map.TabIndex = 2;
            Map.Zoom = 0D;
            // 
            // MapTable
            // 
            MapTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            MapTable.ColumnCount = 3;
            MapTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 6.26506042F ) );
            MapTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 93.73494F ) );
            MapTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 80F ) );
            MapTable.Controls.Add( MapPanel, 1, 1 );
            MapTable.Dock = System.Windows.Forms.DockStyle.Fill;
            MapTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            MapTable.Location = new System.Drawing.Point( 1, 33 );
            MapTable.Margin = new System.Windows.Forms.Padding( 1 );
            MapTable.Name = "MapTable";
            MapTable.RowCount = 3;
            MapTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.58899665F ) );
            MapTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.411F ) );
            MapTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 64F ) );
            MapTable.Size = new System.Drawing.Size( 1326, 649 );
            MapTable.TabIndex = 3;
            // 
            // MapPanel
            // 
            MapPanel.BackColor = System.Drawing.Color.Transparent;
            MapPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MapPanel.BindingSource = null;
            MapPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            MapPanel.BorderThickness = 1;
            MapPanel.Children = null;
            MapPanel.Controls.Add( Map );
            MapPanel.DataFilter = null;
            MapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MapPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            MapPanel.ForeColor = System.Drawing.Color.Transparent;
            MapPanel.HoverText = null;
            MapPanel.IsDerivedStyle = true;
            MapPanel.Location = new System.Drawing.Point( 81, 18 );
            MapPanel.Name = "MapPanel";
            MapPanel.Padding = new System.Windows.Forms.Padding( 1 );
            MapPanel.Size = new System.Drawing.Size( 1161, 563 );
            MapPanel.Style = MetroSet_UI.Enums.Style.Custom;
            MapPanel.StyleManager = null;
            MapPanel.TabIndex = 3;
            MapPanel.ThemeAuthor = "Terry D. Eppler";
            MapPanel.ThemeName = "Sherpa";
            MapPanel.ToolTip = null;
            // 
            // ContextMenu
            // 
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 10, 10, 10 );
            ContextMenu.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.ShowCheckMargin = true;
            ContextMenu.Size = new System.Drawing.Size( 180, 454 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Dark;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "MetroLite";
            // 
            // GeoMapper
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 9.75F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1328, 728 );
            Controls.Add( MapTable );
            Controls.Add( ToolStripTable );
            Controls.Add( HeaderTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 8.25F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1330, 730 );
            Name = "GeoMapper";
            Padding = new System.Windows.Forms.Padding( 1 );
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            MapTable.ResumeLayout( false );
            MapPanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.PictureBox PictureBox;
        private Label Title;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
        public ToolStrip ToolStrip;
        public ToolSeparator Separator15;
        public ToolStripLabel DataLabel;
        public ToolStripLabel FileSysSpacer;
        public ToolStripLabel FileSysLabel;
        public ToolStripLabel ApplicationSpacer;
        public ToolStripLabel MenuLabel;
        public ToolSeparator Separator1;
        public ToolStripLabel NavigationLabel;
        public ToolStripButton LeftButton;
        public ToolStripButton RightButton;
        public ToolStripButton UpButton;
        public ToolSeparator Separator5;
        public ToolSeparator Separator6;
        public ToolStripLabel StatusLabel;
        public ToolSeparator Separator2;
        public ToolSeparator Separator4;
        public ToolSeparator Separator3;
        public ToolStripButton DownButton;
        public ToolStripLabel DataSpacer;
        public ToolSeparator Separator7;
        public ToolStripButton FilterButton;
        public ToolSeparator Separator8;
        public ToolStripButton RefreshButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton SaveButton;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator11;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolStripButton CloseButton;
        public ToolStripButton MenuButton;
        public ToolSeparator Separator14;
        public ToolStripTextBox TextBox;
        public ToolSeparator Separator23;
        public ToolStripButton LookupButton;
        private ToolSeparator Separator22;
        public System.Windows.Forms.TableLayoutPanel MapTable;
        public GMap.NET.WindowsForms.GMapControl Map;
        private BackPanel MapPanel;
        public ToolSeparator RightSeparator;
        private ControlBox ControlBox;
        public ContextMenu ContextMenu;
        private ToolStripButton MinusButton;
        private ToolSeparator MinusSeparator;
        private ToolStripButton PlusButton;
        private ToolSeparator PlusSeparator;
    }
}