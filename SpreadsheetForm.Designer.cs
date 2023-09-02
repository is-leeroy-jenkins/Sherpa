namespace BudgetExecution
{
    partial class SpreadsheetForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SpreadsheetForm ) );
            Header = new System.Windows.Forms.TableLayoutPanel( );
            pictureBox1 = new System.Windows.Forms.PictureBox( );
            Title = new Label( );
            ToolStrip = new ToolStrip( );
            CloseButton = new ToolStripButton( );
            Separator1 = new ToolSeparator( );
            MenuButton = new ToolStripButton( );
            Separator2 = new ToolSeparator( );
            Timer = new System.Windows.Forms.Timer( components );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolTip = new SmallTip( );
            DataSheet = new GridControl( );
            Header.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) pictureBox1  ).BeginInit( );
            ToolStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) DataSheet  ).BeginInit( );
            SuspendLayout( );
            // 
            // Header
            // 
            Header.ColumnCount = 2;
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 3.2884903F ) );
            Header.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 96.71151F ) );
            Header.Controls.Add( pictureBox1, 0, 0 );
            Header.Controls.Add( Title, 1, 0 );
            Header.Dock = System.Windows.Forms.DockStyle.Top;
            Header.Location = new System.Drawing.Point( 0, 0 );
            Header.Name = "Header";
            Header.RowCount = 1;
            Header.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            Header.Size = new System.Drawing.Size( 1338, 26 );
            Header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Images.EPA;
            pictureBox1.Location = new System.Drawing.Point( 3, 3 );
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size( 38, 20 );
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 47, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1288, 20 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip.HomeButton = null;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 0, 0 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { CloseButton, Separator1, MenuButton, Separator2 } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 693 );
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
            ToolStrip.Size = new System.Drawing.Size( 1338, 46 );
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "toolStrip1";
            ToolStrip.TextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(   28  ,   28  ,   28   );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // CloseButton
            // 
            CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            CloseButton.AutoToolTip = false;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            CloseButton.Field = Field.AccountCode;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.LightGray;
            CloseButton.HoverText = null;
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 24 );
            CloseButton.ToolTip = null;
            CloseButton.ToolType = ToolType.Ns;
            // 
            // Separator1
            // 
            Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 28 );
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
            MenuButton.Size = new System.Drawing.Size( 23, 24 );
            MenuButton.Text = "toolStripButton1";
            MenuButton.ToolTip = null;
            MenuButton.ToolType = ToolType.Ns;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb(   5  ,   5  ,   5   );
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
            // DataSheet
            // 
            DataSheet.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(   130  ,   80  ,   80  ,   80   );
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
            gridBaseStyle2.Name = "Column Header";
            gridBaseStyle2.StyleInfo.BaseStyle = "Header";
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle3.Name = "Row Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.Font.Bold = true;
            gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle3.StyleInfo.Font.Italic = false;
            gridBaseStyle3.StyleInfo.Font.Size = 9F;
            gridBaseStyle3.StyleInfo.Font.Strikeout = false;
            gridBaseStyle3.StyleInfo.Font.Underline = false;
            gridBaseStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.Name = "Standard";
            gridBaseStyle4.StyleInfo.Font.Facename = "Tahoma";
            DataSheet.BaseStylesMap.AddRange( new Syncfusion.Windows.Forms.Grid.GridBaseStyle[ ] { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4 } );
            DataSheet.ColCount = 50;
            DataSheet.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2016DarkGray;
            DataSheet.DefaultColWidth = 100;
            DataSheet.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            DataSheet.DefaultRowHeight = 28;
            DataSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            DataSheet.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DataSheet.ForeColor = System.Drawing.Color.LightGray;
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
            DataSheet.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016DarkGray;
            DataSheet.Location = new System.Drawing.Point( 0, 26 );
            DataSheet.Name = "DataSheet";
            DataSheet.Office2016ScrollBars = true;
            DataSheet.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.DarkGray;
            DataSheet.Properties.GridLineColor = System.Drawing.Color.FromArgb(   68  ,   68  ,   68   );
            DataSheet.RowCount = 100;
            DataSheet.RowHeightEntries.AddRange( new Syncfusion.Windows.Forms.Grid.GridRowHeight[ ] { new Syncfusion.Windows.Forms.Grid.GridRowHeight( 0, 32 ) } );
            DataSheet.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            DataSheet.Size = new System.Drawing.Size( 1338, 667 );
            DataSheet.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            DataSheet.SmartSizeBox = false;
            DataSheet.TabIndex = 2;
            DataSheet.Text = "gridControl1";
            DataSheet.ThemeName = "Office2016DarkGray";
            DataSheet.ThemesEnabled = true;
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(   210  ,   210  ,   210   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(   114  ,   114  ,   114   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(   94  ,   94  ,   94   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(   150  ,   150  ,   150   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(   171  ,   171  ,   171   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(   210  ,   210  ,   210   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(   171  ,   171  ,   171   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(   197  ,   197  ,   197   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(   150  ,   150  ,   150   );
            DataSheet.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(   197  ,   197  ,   197   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(   210  ,   210  ,   210   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(   114  ,   114  ,   114   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(   94  ,   94  ,   94   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(   150  ,   150  ,   150   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(   171  ,   171  ,   171   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(   255  ,   255  ,   255   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(   210  ,   210  ,   210   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(   225  ,   225  ,   225   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(   171  ,   171  ,   171   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(   197  ,   197  ,   197   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(   150  ,   150  ,   150   );
            DataSheet.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(   197  ,   197  ,   197   );
            // 
            // SpreadsheetForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            Controls.Add( DataSheet );
            Controls.Add( ToolStrip );
            Controls.Add( Header );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.White;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "SpreadsheetForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SpreadsheetForm";
            Header.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) pictureBox1  ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) DataSheet  ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Header;
        public System.Windows.Forms.PictureBox pictureBox1;
        public ToolStrip ToolStrip;
        public System.Windows.Forms.Timer Timer;
        public SmallTip ToolTip;
        public ToolStripButton CloseButton;
        private ToolSeparator Separator1;
        public ToolStripButton MenuButton;
        private ToolSeparator Separator2;
        public GridControl DataSheet;
        public System.Windows.Forms.BindingSource BindingSource;
        public Label Title;
    }
}