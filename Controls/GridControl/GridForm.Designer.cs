namespace BudgetExecution
{
    partial class GridForm
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
            var gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle( );
            var gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle( );
            var gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle( );
            var gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle( );
            var gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GridForm ) );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            ToolStrip = new ToolStrip( );
            CloseButton = new ToolStripButton( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            Separator1 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            Separator2 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            ToolStripLabel = new ToolStripLabel( );
            Separator3 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            ToolStripTextBox = new ToolStripTextBox( );
            Separator6 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator7 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            MenuSeparator = new ToolSeparator( );
            Separator8 = new ToolSeparator( );
            ApplicationLabel = new ToolStripLabel( );
            Timer = new System.Windows.Forms.Timer( components );
            DataSheet = new GridControl( );
            ContextMenu = new ContextMenu( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)DataSheet ).BeginInit( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 3.2884903F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 96.71151F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1338, 24 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.Image = Resources.Images.budget;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 22, 18 );
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
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 47, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1288, 18 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // ToolStrip
            // 
            ToolStrip.AddButton = null;
            ToolStrip.AddColumnButton = null;
            ToolStrip.AddTableButton = null;
            ToolStrip.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.BindingSource = null;
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
            ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { CloseButton, Separator1, MenuButton, Separator2, StatusLabel, ToolStripLabel, Separator3, FirstButton, Separator4, PreviousButton, Separator5, ToolStripTextBox, Separator6, NextButton, Separator7, LastButton, MenuSeparator, Separator8, ApplicationLabel } );
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 696 );
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
            ToolStrip.Size = new System.Drawing.Size( 1338, 43 );
            ToolStrip.TabIndex = 1;
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
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = BindingSource;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Filter = null;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = "Close Window";
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 25 );
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.Ns;
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
            // Separator1
            // 
            Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BindingSource = BindingSource;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Filter = null;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = "Main Menu";
            MenuButton.Image = Resources.Images.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 25 );
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 25 );
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = System.Drawing.Color.Transparent;
            StatusLabel.BindingSource = null;
            StatusLabel.DataFilter = null;
            StatusLabel.Field = Field.AccountCode;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            StatusLabel.ForeColor = System.Drawing.Color.Black;
            StatusLabel.HoverText = null;
            StatusLabel.Margin = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 65, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "Date and Time";
            StatusLabel.ToolTip = null;
            // 
            // ToolStripLabel
            // 
            ToolStripLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ToolStripLabel.BindingSource = BindingSource;
            ToolStripLabel.DataFilter = null;
            ToolStripLabel.Field = Field.AccountCode;
            ToolStripLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ToolStripLabel.ForeColor = System.Drawing.Color.Black;
            ToolStripLabel.HoverText = null;
            ToolStripLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStripLabel.Name = "ToolStripLabel";
            ToolStripLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStripLabel.Size = new System.Drawing.Size( 83, 25 );
            ToolStripLabel.Tag = "";
            ToolStripLabel.Text = "                Navigation:";
            ToolStripLabel.ToolTip = ToolTip;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.Transparent;
            FirstButton.BindingSource = BindingSource;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Filter = null;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = "First Record";
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 1 );
            FirstButton.Size = new System.Drawing.Size( 23, 25 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = ToolTip;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 25 );
            // 
            // PreviousButton
            // 
            PreviousButton.AutoToolTip = false;
            PreviousButton.BackColor = System.Drawing.Color.Transparent;
            PreviousButton.BindingSource = BindingSource;
            PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PreviousButton.Field = Field.AccountCode;
            PreviousButton.Filter = null;
            PreviousButton.Font = new System.Drawing.Font( "Roboto", 9F );
            PreviousButton.ForeColor = System.Drawing.Color.LightGray;
            PreviousButton.HoverText = "Previous Record";
            PreviousButton.Image = Resources.Images.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 1 );
            PreviousButton.Size = new System.Drawing.Size( 23, 25 );
            PreviousButton.Text = "toolStripButton2";
            PreviousButton.ToolTip = ToolTip;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ToolStripTextBox
            // 
            ToolStripTextBox.BackColor = System.Drawing.Color.Black;
            ToolStripTextBox.BindingSource = BindingSource;
            ToolStripTextBox.Field = Field.AccountCode;
            ToolStripTextBox.Font = new System.Drawing.Font( "Roboto", 9F );
            ToolStripTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            ToolStripTextBox.HoverText = "";
            ToolStripTextBox.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox.Name = "ToolStripTextBox";
            ToolStripTextBox.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox.Size = new System.Drawing.Size( 240, 25 );
            ToolStripTextBox.Tag = "";
            ToolStripTextBox.ToolTip = ToolTip;
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.BindingSource = BindingSource;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Filter = null;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = "Next Record";
            NextButton.Image = Resources.Images.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 1 );
            NextButton.Size = new System.Drawing.Size( 23, 25 );
            NextButton.Text = "toolStripButton1";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.Transparent;
            LastButton.BindingSource = BindingSource;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Filter = null;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = "Last Record";
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 1 );
            LastButton.Size = new System.Drawing.Size( 23, 25 );
            LastButton.Text = "toolStripButton2";
            LastButton.ToolTip = ToolTip;
            LastButton.ToolType = ToolType.LastButton;
            // 
            // MenuSeparator
            // 
            MenuSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuSeparator.ForeColor = System.Drawing.Color.Black;
            MenuSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            MenuSeparator.Name = "MenuSeparator";
            MenuSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            MenuSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ApplicationLabel
            // 
            ApplicationLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ApplicationLabel.BackColor = System.Drawing.Color.Transparent;
            ApplicationLabel.BindingSource = null;
            ApplicationLabel.DataFilter = null;
            ApplicationLabel.Field = Field.AccountCode;
            ApplicationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ApplicationLabel.ForeColor = System.Drawing.Color.Black;
            ApplicationLabel.HoverText = null;
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 72, 25 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "         Application:";
            ApplicationLabel.ToolTip = null;
            // 
            // DataSheet
            // 
            DataSheet.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb( 130, 80, 80, 80 );
            DataSheet.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle1.StyleInfo.Font.Italic = false;
            gridBaseStyle1.StyleInfo.Font.Size = 9F;
            gridBaseStyle1.StyleInfo.Font.Strikeout = false;
            gridBaseStyle1.StyleInfo.Font.Underline = false;
            gridBaseStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle3.Name = "Row Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.Font.Bold = true;
            gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle3.StyleInfo.Font.Italic = false;
            gridBaseStyle3.StyleInfo.Font.Size = 9F;
            gridBaseStyle3.StyleInfo.Font.Strikeout = false;
            gridBaseStyle3.StyleInfo.Font.Underline = false;
            gridBaseStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Column Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.Font.Bold = true;
            gridBaseStyle4.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle4.StyleInfo.Font.Italic = false;
            gridBaseStyle4.StyleInfo.Font.Size = 9F;
            gridBaseStyle4.StyleInfo.Font.Strikeout = false;
            gridBaseStyle4.StyleInfo.Font.Underline = false;
            gridBaseStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            DataSheet.BaseStylesMap.AddRange( new Syncfusion.Windows.Forms.Grid.GridBaseStyle[ ] { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4 } );
            DataSheet.CanOverrideStyle = true;
            DataSheet.ColCount = 50;
            DataSheet.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2016Black;
            DataSheet.DefaultColWidth = 150;
            DataSheet.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            DataSheet.DefaultRowHeight = 28;
            DataSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            DataSheet.Font = new System.Drawing.Font( "Roboto", 9F );
            DataSheet.ForeColor = System.Drawing.Color.White;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Roboto";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            DataSheet.GridCells.AddRange( new Syncfusion.Windows.Forms.Grid.GridCellInfo[ ] { gridCellInfo1 } );
            DataSheet.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2016;
            DataSheet.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016Black;
            DataSheet.Location = new System.Drawing.Point( 0, 24 );
            DataSheet.Name = "DataSheet";
            DataSheet.Office2016ScrollBars = true;
            DataSheet.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Black;
            DataSheet.Properties.GridLineColor = System.Drawing.Color.FromArgb( 68, 68, 68 );
            DataSheet.RowCount = 100;
            DataSheet.RowHeightEntries.AddRange( new Syncfusion.Windows.Forms.Grid.GridRowHeight[ ] { new Syncfusion.Windows.Forms.Grid.GridRowHeight( 0, 32 ) } );
            DataSheet.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            DataSheet.Size = new System.Drawing.Size( 1338, 672 );
            DataSheet.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            DataSheet.SmartSizeBox = false;
            DataSheet.TabIndex = 2;
            DataSheet.Text = "gridControl1";
            DataSheet.ThemeName = "Office2016Black";
            DataSheet.ThemesEnabled = true;
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb( 255, 255, 255 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb( 210, 210, 210 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb( 114, 114, 114 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb( 94, 94, 94 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb( 150, 150, 150 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb( 171, 171, 171 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb( 255, 255, 255 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb( 210, 210, 210 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb( 171, 171, 171 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb( 197, 197, 197 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb( 150, 150, 150 );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb( 197, 197, 197 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb( 255, 255, 255 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb( 210, 210, 210 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb( 114, 114, 114 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb( 94, 94, 94 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb( 150, 150, 150 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb( 171, 171, 171 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb( 255, 255, 255 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb( 210, 210, 210 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb( 225, 225, 225 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb( 171, 171, 171 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb( 197, 197, 197 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb( 150, 150, 150 );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb( 197, 197, 197 );
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
            // GridForm
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
            ClientSize = new System.Drawing.Size( 1338, 739 );
            ControlBox = false;
            Controls.Add( DataSheet );
            Controls.Add( ToolStrip );
            Controls.Add( HeaderTable );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "GridForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = " ";
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)DataSheet ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion
        public System.Windows.Forms.PictureBox PictureBox;
        public ToolStrip ToolStrip;
        public System.Windows.Forms.Timer Timer;
        public SmallTip ToolTip;
        public ToolStripButton CloseButton;
        private ToolSeparator Separator1;
        public ToolStripButton MenuButton;
        private ToolSeparator Separator2;
        public System.Windows.Forms.BindingSource BindingSource;
        public Label Title;
        public ToolStripLabel ToolStripLabel;
        public ToolSeparator Separator3;
        public ToolStripButton FirstButton;
        public ToolSeparator Separator4;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator5;
        public ToolStripTextBox ToolStripTextBox;
        public ToolSeparator Separator6;
        public ToolStripButton NextButton;
        public ToolSeparator Separator7;
        public ToolStripButton LastButton;
        public ToolSeparator Separator8;
        public GridControl DataSheet;
        public ToolStripLabel StatusLabel;
        public ToolSeparator MenuSeparator;
        public ToolStripLabel ApplicationLabel;
        public ContextMenu ContextMenu;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
    }
}