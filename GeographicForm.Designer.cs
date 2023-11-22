namespace BudgetExecution
{
    partial class GeographicForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GeographicForm ) );
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel( );
            Map = new MapControl( );
            ToolStrip = new ToolStrip( );
            Separator1 = new ToolSeparator( );
            ToolStripLabel = new ToolStripLabel( );
            Separator2 = new ToolSeparator( );
            ProgressBar = new System.Windows.Forms.ToolStripProgressBar( );
            Separator3 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            PrevButton = new ToolStripButton( );
            NextButton = new ToolStripButton( );
            LastButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            Separator5 = new ToolSeparator( );
            Separator6 = new ToolSeparator( );
            Separator7 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            ToolStripTextBox1 = new ToolStripTextBox( );
            Separator9 = new ToolSeparator( );
            GoButton = new ToolStripButton( );
            Separator10 = new ToolSeparator( );
            ExitButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            Separator13 = new ToolSeparator( );
            Icon = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ContextMenu = new ContextMenu( );
            ToolTip = new SmallTip( );
            tableLayoutPanel1.SuspendLayout( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Icon ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            SuspendLayout( );
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 2.61584449F ) );
            tableLayoutPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 97.3841553F ) );
            tableLayoutPanel1.Controls.Add( Icon, 0, 0 );
            tableLayoutPanel1.Controls.Add( Title, 1, 0 );
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point( 0, 0 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            tableLayoutPanel1.Size = new System.Drawing.Size( 1338, 32 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Map
            // 
            Map.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Map.EnableZoomOnSelection = false;
            Map.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Map.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Map.Layers = (System.Collections.ObjectModel.ObservableCollection<Syncfusion.Windows.Forms.Maps.ShapeFileLayer>)resources.GetObject( "Map.Layers" );
            Map.Location = new System.Drawing.Point( 29, 45 );
            Map.MapItemFont = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Map.MapItemsShape = Syncfusion.Windows.Forms.Maps.MapItemShapes.Rectangle;
            Map.Margin = new System.Windows.Forms.Padding( 20, 21, 20, 21 );
            Map.Name = "Map";
            Map.OnSelectionChanged = null;
            Map.Size = new System.Drawing.Size( 1280, 672 );
            Map.TabIndex = 1;
            Map.Text = "mapControl1";
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
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            ToolStrip.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStrip.ForeColor = System.Drawing.Color.Black;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, ToolStripLabel, Separator2, ProgressBar, Separator3, FirstButton, Separator4, PrevButton, Separator5, NextButton, Separator6, LastButton, Separator7, RefreshButton, Separator8, ToolStripTextBox1, Separator9, GoButton, Separator10, ExitButton, Separator11, MenuButton, Separator12, Separator13 } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 737 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStrip.Name = "ToolStrip";
            ToolStrip.NextButton = null;
            ToolStrip.Office12Mode = false;
            ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            ToolStrip.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStrip.PreviousButton = null;
            ToolStrip.ProgressBar = null;
            ToolStrip.RefreshButton = null;
            ToolStrip.SaveButton = null;
            ToolStrip.SearchCriteriaLabel = null;
            ToolStrip.SearchEngineLabel = null;
            ToolStrip.Separators = null;
            ToolStrip.ShowCaption = true;
            ToolStrip.ShowLauncher = true;
            ToolStrip.Size = new System.Drawing.Size( 1338, 53 );
            ToolStrip.TabIndex = 2;
            ToolStrip.Text = "toolStrip1";
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
            Separator1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 35 );
            // 
            // ToolStripLabel
            // 
            ToolStripLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            ToolStripLabel.BindingSource = null;
            ToolStripLabel.DataFilter = null;
            ToolStripLabel.Field = Field.AccountCode;
            ToolStripLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStripLabel.ForeColor = System.Drawing.Color.Black;
            ToolStripLabel.HoverText = null;
            ToolStripLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStripLabel.Name = "ToolStripLabel";
            ToolStripLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStripLabel.Size = new System.Drawing.Size( 85, 35 );
            ToolStripLabel.Tag = "";
            ToolStripLabel.Text = "toolStripLabel1";
            ToolStripLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 35 );
            // 
            // ProgressBar
            // 
            ProgressBar.Margin = new System.Windows.Forms.Padding( 5, 2, 5, 1 );
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new System.Drawing.Size( 200, 34 );
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator3.Size = new System.Drawing.Size( 6, 35 );
            // 
            // FirstButton
            // 
            FirstButton.AutoToolTip = false;
            FirstButton.BackColor = System.Drawing.Color.Transparent;
            FirstButton.BindingSource = null;
            FirstButton.DataFilter = null;
            FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            FirstButton.Field = Field.AccountCode;
            FirstButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FirstButton.ForeColor = System.Drawing.Color.LightGray;
            FirstButton.HoverText = null;
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 3 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Size = new System.Drawing.Size( 30, 31 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = null;
            FirstButton.ToolType = ToolType.Ns;
            // 
            // PrevButton
            // 
            PrevButton.AutoToolTip = false;
            PrevButton.BackColor = System.Drawing.Color.Transparent;
            PrevButton.BindingSource = null;
            PrevButton.DataFilter = null;
            PrevButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            PrevButton.Field = Field.AccountCode;
            PrevButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            PrevButton.ForeColor = System.Drawing.Color.LightGray;
            PrevButton.HoverText = null;
            PrevButton.Image = Resources.Images.PreviousButton;
            PrevButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PrevButton.Margin = new System.Windows.Forms.Padding( 3 );
            PrevButton.Name = "PrevButton";
            PrevButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PrevButton.Size = new System.Drawing.Size( 30, 31 );
            PrevButton.Text = "toolStripButton2";
            PrevButton.ToolTip = null;
            PrevButton.ToolType = ToolType.Ns;
            // 
            // NextButton
            // 
            NextButton.AutoToolTip = false;
            NextButton.BackColor = System.Drawing.Color.Transparent;
            NextButton.BindingSource = null;
            NextButton.DataFilter = null;
            NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            NextButton.Field = Field.AccountCode;
            NextButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            NextButton.ForeColor = System.Drawing.Color.LightGray;
            NextButton.HoverText = null;
            NextButton.Image = Resources.Images.NextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 3 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Size = new System.Drawing.Size( 30, 31 );
            NextButton.Text = "toolStripButton3";
            NextButton.ToolTip = null;
            NextButton.ToolType = ToolType.Ns;
            // 
            // LastButton
            // 
            LastButton.AutoToolTip = false;
            LastButton.BackColor = System.Drawing.Color.Transparent;
            LastButton.BindingSource = null;
            LastButton.DataFilter = null;
            LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LastButton.Field = Field.AccountCode;
            LastButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LastButton.ForeColor = System.Drawing.Color.LightGray;
            LastButton.HoverText = null;
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 3 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Size = new System.Drawing.Size( 30, 31 );
            LastButton.Text = "toolStripButton4";
            LastButton.ToolTip = null;
            LastButton.ToolType = ToolType.Ns;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 35 );
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 35 );
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 35 );
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator7.Size = new System.Drawing.Size( 6, 35 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.Transparent;
            RefreshButton.BindingSource = null;
            RefreshButton.DataFilter = null;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Field = Field.AccountCode;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            RefreshButton.HoverText = null;
            RefreshButton.Image = Resources.Images.RefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 3 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Size = new System.Drawing.Size( 30, 31 );
            RefreshButton.Text = "toolStripButton1";
            RefreshButton.ToolTip = null;
            RefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator8.Size = new System.Drawing.Size( 6, 35 );
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ToolStripTextBox1.BindingSource = BindingSource;
            ToolStripTextBox1.Field = Field.AccountCode;
            ToolStripTextBox1.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStripTextBox1.ForeColor = System.Drawing.Color.FromArgb( 141, 139, 138 );
            ToolStripTextBox1.HoverText = "";
            ToolStripTextBox1.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox1.Name = "ToolStripTextBox1";
            ToolStripTextBox1.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox1.Size = new System.Drawing.Size( 298, 35 );
            ToolStripTextBox1.Tag = "";
            ToolStripTextBox1.ToolTip = ToolTip;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 35 );
            // 
            // GoButton
            // 
            GoButton.AutoToolTip = false;
            GoButton.BackColor = System.Drawing.Color.Transparent;
            GoButton.BindingSource = null;
            GoButton.DataFilter = null;
            GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            GoButton.Field = Field.AccountCode;
            GoButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            GoButton.ForeColor = System.Drawing.Color.LightGray;
            GoButton.HoverText = null;
            GoButton.Image = Resources.Images.GoButton;
            GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            GoButton.Margin = new System.Windows.Forms.Padding( 3 );
            GoButton.Name = "GoButton";
            GoButton.Padding = new System.Windows.Forms.Padding( 1 );
            GoButton.Size = new System.Drawing.Size( 23, 31 );
            GoButton.Text = "toolStripButton1";
            GoButton.ToolTip = null;
            GoButton.ToolType = ToolType.GoButton;
            // 
            // Separator10
            // 
            Separator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 35 );
            // 
            // ExitButton
            // 
            ExitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ExitButton.AutoToolTip = false;
            ExitButton.BackColor = System.Drawing.Color.Transparent;
            ExitButton.BindingSource = null;
            ExitButton.DataFilter = null;
            ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ExitButton.Field = Field.AccountCode;
            ExitButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ExitButton.ForeColor = System.Drawing.Color.LightGray;
            ExitButton.HoverText = null;
            ExitButton.Image = Resources.Images.WebCloseButton;
            ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ExitButton.Margin = new System.Windows.Forms.Padding( 3 );
            ExitButton.Name = "ExitButton";
            ExitButton.Padding = new System.Windows.Forms.Padding( 1 );
            ExitButton.Size = new System.Drawing.Size( 23, 31 );
            ExitButton.Text = "toolStripButton";
            ExitButton.ToolTip = null;
            ExitButton.ToolType = ToolType.MenuButton;
            // 
            // Separator11
            // 
            Separator11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 35 );
            // 
            // MenuButton
            // 
            MenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BindingSource = null;
            MenuButton.DataFilter = null;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = null;
            MenuButton.Image = Resources.Images.WebMenuButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 3 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 31 );
            MenuButton.Text = "toolStripButton2";
            MenuButton.ToolTip = null;
            MenuButton.ToolType = ToolType.Ns;
            // 
            // Separator12
            // 
            Separator12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 35 );
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 35 );
            // 
            // Icon
            // 
            Icon.Image = Resources.Images.App;
            Icon.Location = new System.Drawing.Point( 3, 3 );
            Icon.Name = "Icon";
            Icon.Size = new System.Drawing.Size( 27, 26 );
            Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Icon.TabIndex = 0;
            Icon.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 38, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1297, 26 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "label1";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 140, 220 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
            ToolTip.BindingSource = BindingSource;
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
            // GeographicForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 15F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 1338, 790 );
            ControlBox = false;
            Controls.Add( ToolStrip );
            Controls.Add( Map );
            Controls.Add( tableLayoutPanel1 );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.SystemColors.ActiveCaption;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 801 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 801 );
            Name = "GeographicForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GeographicForm";
            tableLayoutPanel1.ResumeLayout( false );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)Icon ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ToolStrip ToolStrip;
        public ToolSeparator Separator1;
        public ToolStripLabel ToolStripLabel;
        public ToolSeparator Separator2;
        public System.Windows.Forms.ToolStripProgressBar ProgressBar;
        public ToolSeparator Separator3;
        public ToolStripButton FirstButton;
        public ToolSeparator Separator4;
        public ToolStripButton PrevButton;
        public ToolSeparator Separator5;
        public ToolStripButton NextButton;
        public ToolSeparator Separator6;
        public ToolStripButton LastButton;
        public ToolSeparator Separator7;
        public ToolStripButton RefreshButton;
        public ToolSeparator Separator8;
        private ToolStripTextBox ToolStripTextBox1;
        public ToolSeparator Separator9;
        public ToolStripButton GoButton;
        public ToolSeparator Separator10;
        public ToolStripButton ExitButton;
        public ToolSeparator Separator11;
        public ToolStripButton MenuButton;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public MapControl Map;
        private System.Windows.Forms.PictureBox Icon;
        public System.Windows.Forms.BindingSource BindingSource;
        public ContextMenu ContextMenu;
        public SmallTip ToolTip;
        public Label Title;
    }
}