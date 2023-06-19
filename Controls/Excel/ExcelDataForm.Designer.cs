namespace BudgetExecution
{


    partial class ExcelDataForm
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
            var spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste( );
            var formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ExcelDataForm ) );
            Ribbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon( );
            Spreadsheet = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolStrip = new ToolStrip( );
            MenuButton = new ToolStripButton( );
            ToolTip = new SmallTip( );
            Separator1 = new ToolSeparator( );
            Label2 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            Separator2 = new ToolSeparator( );
            ToolStripTextBox = new ToolStripTextBox( );
            Separator3 = new ToolSeparator( );
            Label3 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            FunctionLabel = new ToolStripLabel( );
            Separator5 = new ToolSeparator( );
            TableButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            UploadButton = new ToolStripButton( );
            Separator6 = new ToolSeparator( );
            ChartButton = new ToolStripButton( );
            Separator7 = new ToolSeparator( );
            FilterSpacer = new ToolStripLabel( );
            FilterLabel = new ToolStripLabel( );
            DataSourceSeparator = new ToolSeparator( );
            LookupButton = new ToolStripButton( );
            FilterSeparator = new ToolSeparator( );
            RemoveFiltersButton = new ToolStripButton( );
            SqlSeparator = new ToolSeparator( );
            LastLabel = new ToolStripLabel( );
            ApplicationLabel = new ToolStripLabel( );
            BackButtonSeparator = new ToolSeparator( );
            BackButton = new ToolStripButton( );
            Separator10 = new ToolSeparator( );
            Label4 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            Label6 = new Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt( );
            Separator9 = new ToolSeparator( );
            Separator11 = new ToolSeparator( );
            ContextMenu = new ContextMenu( );
            HeaderPanel = new System.Windows.Forms.TableLayoutPanel( );
            Header = new Label( );
            PictureBox = new System.Windows.Forms.PictureBox( );
            LabelSeparator = new ToolSeparator( );
            ( (System.ComponentModel.ISupportInitialize) Ribbon  ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            ToolStrip.SuspendLayout( );
            HeaderPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            SuspendLayout( );
            // 
            // Ribbon
            // 
            Ribbon.CaptionFont = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            Ribbon.Font = new System.Drawing.Font( "Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Ribbon.HideMenuButtonToolTip = true;
            Ribbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            Ribbon.Location = new System.Drawing.Point( 0, 36 );
            Ribbon.MenuButtonFont = new System.Drawing.Font( "Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Ribbon.MenuButtonText = "FILE";
            Ribbon.MenuButtonWidth = 56;
            Ribbon.MenuColor = System.Drawing.Color.FromArgb(   54  ,   54  ,   54   );
            Ribbon.Name = "Ribbon";
            Ribbon.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            Ribbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            Ribbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // 
            // 
            Ribbon.OfficeMenu.Name = "OfficeMenu";
            Ribbon.OfficeMenu.ShowItemToolTips = true;
            Ribbon.OfficeMenu.Size = new System.Drawing.Size( 12, 65 );
            Ribbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Ribbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            Ribbon.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010;
            Ribbon.ShowQuickItemsDropDownButton = false;
            Ribbon.ShowRibbonDisplayOptionButton = false;
            Ribbon.Size = new System.Drawing.Size( 1338, 148 );
            Ribbon.Spreadsheet = Spreadsheet;
            Ribbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            Ribbon.SystemText.RenameDisplayLabelText = "&Display Name:";
            Ribbon.TabIndex = 0;
            Ribbon.Text = "spreadsheetRibbon1";
            Ribbon.ThemeName = "Default";
            Ribbon.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(   171  ,   171  ,   171   );
            Ribbon.TitleColor = System.Drawing.Color.White;
            Ribbon.TitleFont = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            // 
            // Spreadsheet
            // 
            Spreadsheet.AllowCellContextMenu = true;
            Spreadsheet.AllowExtendRowColumnCount = true;
            Spreadsheet.AllowFiltering = false;
            Spreadsheet.AllowFormulaRangeSelection = true;
            Spreadsheet.AllowTabItemContextMenu = true;
            Spreadsheet.AllowZooming = true;
            Spreadsheet.BaseThemeName = "";
            Spreadsheet.CanOverrideStyle = true;
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            Spreadsheet.CopyPaste = spreadsheetCopyPaste1;
            Spreadsheet.DefaultColumnCount = 50;
            Spreadsheet.DefaultRowCount = 100;
            Spreadsheet.DisplayAlerts = true;
            Spreadsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            Spreadsheet.FileName = "Book1";
            Spreadsheet.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Spreadsheet.ForeColor = System.Drawing.Color.Black;
            Spreadsheet.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            Spreadsheet.FormulaRangeSelectionController = formulaRangeSelectionController1;
            Spreadsheet.IsCustomTabItemContextMenuEnabled = false;
            Spreadsheet.Location = new System.Drawing.Point( 0, 184 );
            Spreadsheet.Name = "Spreadsheet";
            Spreadsheet.Padding = new System.Windows.Forms.Padding( 1 );
            Spreadsheet.SelectedTabIndex = 0;
            Spreadsheet.SelectedTabItem = null;
            Spreadsheet.ShowBusyIndicator = true;
            Spreadsheet.Size = new System.Drawing.Size( 1338, 509 );
            Spreadsheet.TabIndex = 1;
            Spreadsheet.TabItemContextMenu = null;
            Spreadsheet.Text = "Spreadsheet";
            Spreadsheet.ThemeName = "Default";
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
            ToolStrip.CaptionFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            ToolStrip.HomeButton = MenuButton;
            ToolStrip.Image = null;
            ToolStrip.ImageDirectory = null;
            ToolStrip.ImageSize = new System.Drawing.Size( 16, 16 );
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { Separator1, Label2, Separator2, ToolStripTextBox, Separator3, Label3, FunctionLabel, Separator5, TableButton, Separator4, UploadButton, Separator6, ChartButton, Separator7, FilterSpacer, FilterLabel, DataSourceSeparator, LookupButton, FilterSeparator, RemoveFiltersButton, SqlSeparator, LastLabel, ApplicationLabel, BackButtonSeparator, BackButton, Separator10, MenuButton } );
            ToolStrip.Label = null;
            ToolStrip.LastButton = null;
            ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            ToolStrip.Location = new System.Drawing.Point( 0, 693 );
            ToolStrip.Margin = new System.Windows.Forms.Padding( 1, 1, 1, 3 );
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
            ToolStrip.Stretch = true;
            ToolStrip.TabIndex = 2;
            ToolStrip.TextBox = null;
            ToolStrip.ThemeName = "Office2016DarkGray";
            ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.Transparent;
            ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(   28  ,   28  ,   28   );
            ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            ToolStrip.ThemeStyle.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // MenuButton
            // 
            MenuButton.AutoToolTip = false;
            MenuButton.BackColor = System.Drawing.Color.Transparent;
            MenuButton.BindingSource = BindingSource;
            MenuButton.DataFilter = null;
            MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MenuButton.Field = Field.AccountCode;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            MenuButton.ForeColor = System.Drawing.Color.LightGray;
            MenuButton.HoverText = "Main Menu";
            MenuButton.Image = Properties.Resources.HomeButton;
            MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MenuButton.Margin = new System.Windows.Forms.Padding( 1 );
            MenuButton.Name = "MenuButton";
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.Size = new System.Drawing.Size( 23, 28 );
            MenuButton.Text = "toolStripButton10";
            MenuButton.ToolTip = ToolTip;
            MenuButton.ToolType = ToolType.MenuButton;
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
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 1 );
            Separator1.Name = "Separator1";
            Separator1.Padding = new System.Windows.Forms.Padding( 1 );
            Separator1.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Label2
            // 
            Label2.BackColor = System.Drawing.Color.Transparent;
            Label2.ForeColor = System.Drawing.Color.Transparent;
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size( 106, 27 );
            Label2.Text = "toolStripLabelExt1";
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ToolStripTextBox
            // 
            ToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ToolStripTextBox.BindingSource = null;
            ToolStripTextBox.Field = Field.AccountCode;
            ToolStripTextBox.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ToolStripTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            ToolStripTextBox.HoverText = "";
            ToolStripTextBox.Margin = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox.Name = "ToolStripTextBox";
            ToolStripTextBox.Padding = new System.Windows.Forms.Padding( 1 );
            ToolStripTextBox.Size = new System.Drawing.Size( 180, 28 );
            ToolStripTextBox.Tag = "";
            ToolStripTextBox.ToolTip = ToolTip;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Label3
            // 
            Label3.BackColor = System.Drawing.Color.Transparent;
            Label3.ForeColor = System.Drawing.Color.Transparent;
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size( 131, 27 );
            Label3.Text = "this is to provide space";
            // 
            // FunctionLabel
            // 
            FunctionLabel.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            FunctionLabel.BindingSource = null;
            FunctionLabel.DataFilter = null;
            FunctionLabel.Field = Field.AccountCode;
            FunctionLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FunctionLabel.ForeColor = System.Drawing.Color.Black;
            FunctionLabel.HoverText = null;
            FunctionLabel.Margin = new System.Windows.Forms.Padding( 1 );
            FunctionLabel.Name = "FunctionLabel";
            FunctionLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FunctionLabel.Size = new System.Drawing.Size( 71, 28 );
            FunctionLabel.Tag = "";
            FunctionLabel.Text = "    Functions:       ";
            FunctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            FunctionLabel.ToolTip = null;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 28 );
            // 
            // TableButton
            // 
            TableButton.AutoToolTip = false;
            TableButton.BackColor = System.Drawing.Color.Transparent;
            TableButton.BindingSource = BindingSource;
            TableButton.DataFilter = null;
            TableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            TableButton.Field = Field.AccountCode;
            TableButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TableButton.ForeColor = System.Drawing.Color.LightGray;
            TableButton.HoverText = "View Data Table";
            TableButton.Image = Properties.Resources.TableButton;
            TableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            TableButton.Margin = new System.Windows.Forms.Padding( 3 );
            TableButton.Name = "TableButton";
            TableButton.Padding = new System.Windows.Forms.Padding( 1 );
            TableButton.Size = new System.Drawing.Size( 23, 24 );
            TableButton.Text = "toolStripButton1";
            TableButton.ToolTip = ToolTip;
            TableButton.ToolType = ToolType.TableButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 28 );
            // 
            // UploadButton
            // 
            UploadButton.AutoToolTip = false;
            UploadButton.BackColor = System.Drawing.Color.Transparent;
            UploadButton.BindingSource = BindingSource;
            UploadButton.DataFilter = null;
            UploadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            UploadButton.Field = Field.AccountCode;
            UploadButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            UploadButton.ForeColor = System.Drawing.Color.LightGray;
            UploadButton.HoverText = "Upload Local File";
            UploadButton.Image = Properties.Resources.UploadButton;
            UploadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            UploadButton.Margin = new System.Windows.Forms.Padding( 1 );
            UploadButton.Name = "UploadButton";
            UploadButton.Padding = new System.Windows.Forms.Padding( 1 );
            UploadButton.Size = new System.Drawing.Size( 23, 28 );
            UploadButton.Text = "toolStripButton2";
            UploadButton.ToolTip = ToolTip;
            UploadButton.ToolType = ToolType.UploadButton;
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ChartButton
            // 
            ChartButton.AutoToolTip = false;
            ChartButton.BackColor = System.Drawing.Color.Transparent;
            ChartButton.BindingSource = BindingSource;
            ChartButton.DataFilter = null;
            ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ChartButton.Field = Field.AccountCode;
            ChartButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ChartButton.ForeColor = System.Drawing.Color.LightGray;
            ChartButton.HoverText = "Visualizations";
            ChartButton.Image = Properties.Resources.ChartButton;
            ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ChartButton.Margin = new System.Windows.Forms.Padding( 1 );
            ChartButton.Name = "ChartButton";
            ChartButton.Padding = new System.Windows.Forms.Padding( 1 );
            ChartButton.Size = new System.Drawing.Size( 23, 28 );
            ChartButton.Text = "toolStripButton7";
            ChartButton.ToolTip = ToolTip;
            ChartButton.ToolType = ToolType.ChartButton;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 28 );
            // 
            // FilterSpacer
            // 
            FilterSpacer.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            FilterSpacer.BindingSource = null;
            FilterSpacer.DataFilter = null;
            FilterSpacer.Field = Field.AccountCode;
            FilterSpacer.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FilterSpacer.ForeColor = System.Drawing.Color.Transparent;
            FilterSpacer.HoverText = null;
            FilterSpacer.Margin = new System.Windows.Forms.Padding( 1 );
            FilterSpacer.Name = "FilterSpacer";
            FilterSpacer.Padding = new System.Windows.Forms.Padding( 1 );
            FilterSpacer.Size = new System.Drawing.Size( 85, 28 );
            FilterSpacer.Tag = "";
            FilterSpacer.Text = "toolStripLabel1";
            FilterSpacer.ToolTip = null;
            // 
            // FilterLabel
            // 
            FilterLabel.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            FilterLabel.BindingSource = null;
            FilterLabel.DataFilter = null;
            FilterLabel.Field = Field.AccountCode;
            FilterLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FilterLabel.ForeColor = System.Drawing.Color.Black;
            FilterLabel.HoverText = null;
            FilterLabel.Margin = new System.Windows.Forms.Padding( 1 );
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FilterLabel.Size = new System.Drawing.Size( 44, 28 );
            FilterLabel.Tag = "";
            FilterLabel.Text = "     Filters:";
            FilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            FilterLabel.ToolTip = ToolTip;
            // 
            // DataSourceSeparator
            // 
            DataSourceSeparator.ForeColor = System.Drawing.Color.Black;
            DataSourceSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            DataSourceSeparator.Name = "DataSourceSeparator";
            DataSourceSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            DataSourceSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip = false;
            LookupButton.BackColor = System.Drawing.Color.Transparent;
            LookupButton.BindingSource = BindingSource;
            LookupButton.DataFilter = null;
            LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LookupButton.Field = Field.AccountCode;
            LookupButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LookupButton.ForeColor = System.Drawing.Color.LightGray;
            LookupButton.HoverText = "Select Data Source";
            LookupButton.Image = Properties.Resources.DataSearchButton;
            LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LookupButton.Margin = new System.Windows.Forms.Padding( 3 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new System.Windows.Forms.Padding( 1 );
            LookupButton.Size = new System.Drawing.Size( 23, 24 );
            LookupButton.Text = "toolStripButton1";
            LookupButton.ToolTip = ToolTip;
            LookupButton.ToolType = ToolType.LookupButton;
            // 
            // FilterSeparator
            // 
            FilterSeparator.ForeColor = System.Drawing.Color.Black;
            FilterSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            FilterSeparator.Name = "FilterSeparator";
            FilterSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            FilterSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // RemoveFiltersButton
            // 
            RemoveFiltersButton.AutoToolTip = false;
            RemoveFiltersButton.BackColor = System.Drawing.Color.Transparent;
            RemoveFiltersButton.BindingSource = BindingSource;
            RemoveFiltersButton.DataFilter = null;
            RemoveFiltersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RemoveFiltersButton.Field = Field.AccountCode;
            RemoveFiltersButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            RemoveFiltersButton.ForeColor = System.Drawing.Color.LightGray;
            RemoveFiltersButton.HoverText = "Filter Data Source";
            RemoveFiltersButton.Image = Properties.Resources.FilterButton;
            RemoveFiltersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RemoveFiltersButton.Margin = new System.Windows.Forms.Padding( 3 );
            RemoveFiltersButton.Name = "RemoveFiltersButton";
            RemoveFiltersButton.Padding = new System.Windows.Forms.Padding( 1 );
            RemoveFiltersButton.Size = new System.Drawing.Size( 23, 24 );
            RemoveFiltersButton.Text = "toolStripButton1";
            RemoveFiltersButton.ToolTip = ToolTip;
            RemoveFiltersButton.ToolType = ToolType.RemoveFiltersButton;
            // 
            // SqlSeparator
            // 
            SqlSeparator.ForeColor = System.Drawing.Color.Black;
            SqlSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            SqlSeparator.Name = "SqlSeparator";
            SqlSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            SqlSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // LastLabel
            // 
            LastLabel.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            LastLabel.BindingSource = null;
            LastLabel.DataFilter = null;
            LastLabel.Field = Field.AccountCode;
            LastLabel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            LastLabel.ForeColor = System.Drawing.Color.Transparent;
            LastLabel.HoverText = null;
            LastLabel.Margin = new System.Windows.Forms.Padding( 1 );
            LastLabel.Name = "LastLabel";
            LastLabel.Padding = new System.Windows.Forms.Padding( 1 );
            LastLabel.Size = new System.Drawing.Size( 283, 28 );
            LastLabel.Tag = "";
            LastLabel.Text = "this is a label to provide this is a label to provide space";
            LastLabel.ToolTip = null;
            // 
            // ApplicationLabel
            // 
            ApplicationLabel.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            ApplicationLabel.BindingSource = null;
            ApplicationLabel.DataFilter = null;
            ApplicationLabel.Field = Field.AccountCode;
            ApplicationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ApplicationLabel.ForeColor = System.Drawing.Color.Black;
            ApplicationLabel.HoverText = null;
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 70, 28 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "    Application:    ";
            ApplicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ApplicationLabel.ToolTip = null;
            // 
            // BackButtonSeparator
            // 
            BackButtonSeparator.ForeColor = System.Drawing.Color.Black;
            BackButtonSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            BackButtonSeparator.Name = "BackButtonSeparator";
            BackButtonSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            BackButtonSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // BackButton
            // 
            BackButton.AutoToolTip = false;
            BackButton.BackColor = System.Drawing.Color.Transparent;
            BackButton.BindingSource = BindingSource;
            BackButton.DataFilter = null;
            BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BackButton.Field = Field.AccountCode;
            BackButton.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackButton.ForeColor = System.Drawing.Color.LightGray;
            BackButton.HoverText = null;
            BackButton.Image = Properties.Resources.BackButton;
            BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BackButton.Margin = new System.Windows.Forms.Padding( 3 );
            BackButton.Name = "BackButton";
            BackButton.Padding = new System.Windows.Forms.Padding( 1 );
            BackButton.Size = new System.Drawing.Size( 23, 24 );
            BackButton.ToolTip = ToolTip;
            BackButton.ToolType = ToolType.BackButton;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Label4
            // 
            Label4.BackColor = System.Drawing.Color.Transparent;
            Label4.ForeColor = System.Drawing.Color.Transparent;
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size( 170, 25 );
            Label4.Text = "this is a label to provide space";
            Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            Label6.BackColor = System.Drawing.Color.Transparent;
            Label6.ForeColor = System.Drawing.Color.Transparent;
            Label6.Name = "Label6";
            Label6.Size = new System.Drawing.Size( 123, 27 );
            Label6.Text = "this is a spacer this is a spacer to provide more space";
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ContextMenu
            // 
            ContextMenu.AutoSize = false;
            ContextMenu.BackColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            ContextMenu.ForeColor = System.Drawing.Color.White;
            ContextMenu.IsDerivedStyle = false;
            ContextMenu.Name = "ContextMenu";
            ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            ContextMenu.Size = new System.Drawing.Size( 156, 264 );
            ContextMenu.Style = MetroSet_UI.Enums.Style.Custom;
            ContextMenu.StyleManager = null;
            ContextMenu.ThemeAuthor = "Terry D. Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // HeaderPanel
            // 
            HeaderPanel.ColumnCount = 2;
            HeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 1277F ) );
            HeaderPanel.Controls.Add( Header, 1, 0 );
            HeaderPanel.Controls.Add( PictureBox, 0, 0 );
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point( 0, 0 );
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RowCount = 1;
            HeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderPanel.Size = new System.Drawing.Size( 1338, 36 );
            HeaderPanel.TabIndex = 3;
            // 
            // Header
            // 
            Header.BindingSource = null;
            Header.DataFilter = null;
            Header.Dock = System.Windows.Forms.DockStyle.Fill;
            Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Header.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            Header.HoverText = null;
            Header.IsDerivedStyle = true;
            Header.Location = new System.Drawing.Point( 64, 3 );
            Header.Margin = new System.Windows.Forms.Padding( 3 );
            Header.Name = "Header";
            Header.Padding = new System.Windows.Forms.Padding( 1 );
            Header.Size = new System.Drawing.Size( 1271, 30 );
            Header.Style = MetroSet_UI.Enums.Style.Custom;
            Header.StyleManager = null;
            Header.TabIndex = 1;
            Header.Text = "Budget Execution";
            Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Header.ThemeAuthor = "Terry D. Eppler";
            Header.ThemeName = "Budget Execution";
            Header.ToolTip = null;
            // 
            // PictureBox
            // 
            PictureBox.Image = Properties.Resources.EPA;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new System.Drawing.Size( 40, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // LabelSeparator
            // 
            LabelSeparator.ForeColor = System.Drawing.Color.Black;
            LabelSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            LabelSeparator.Name = "LabelSeparator";
            LabelSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            LabelSeparator.Size = new System.Drawing.Size( 6, 28 );
            // 
            // ExcelDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BorderThickness = 2;
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1338, 739 );
            Controls.Add( Spreadsheet );
            Controls.Add( ToolStrip );
            Controls.Add( Ribbon );
            Controls.Add( HeaderPanel );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "ExcelDataForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize) Ribbon  ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            HeaderPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            ResumeLayout( false );
            PerformLayout( );
        }

        #endregion

        public Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon Ribbon;
        public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet Spreadsheet;
        public System.Windows.Forms.BindingSource BindingSource;
        public ToolStripTextBox ToolStripTextBox;
        public ToolStripDropDown DropDown;
        public ToolStripButton AddButton;
        public ToolStripButton DeleteButton;
        public ToolStripButton EditButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton ChartButton;
        public ToolStripButton MenuButton;
        public SmallTip ToolTip;
        public ToolStripButton RefreshDataButton;
        public ToolSeparator Separator6;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label2;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label3;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label4;
        public Syncfusion.Windows.Forms.Spreadsheet.ToolStripLabelExt Label6;
        public ContextMenu ContextMenu;
        public ToolStripButton UploadButton;
        public ToolStripButton DeleteDatabaseButton;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator1;
        public ToolSeparator Separator4;
        public ToolSeparator Separator7;
        public ToolStripButton RemoveFiltersButton;
        public ToolSeparator FilterSeparator;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolStripButton TableButton;
        public ToolSeparator Separator5;
        public ToolSeparator Separator11;
        public System.Windows.Forms.TableLayoutPanel HeaderPanel;
        public System.Windows.Forms.PictureBox PictureBox;
        public Label Header;
        public ToolStripButton LookupButton;
        public ToolSeparator DataSourceSeparator;
        public ToolSeparator LabelSeparator;
        public ToolStripButton GroupButton;
        public ToolStripButton SqlButton;
        public ToolSeparator SqlSeparator;
        public ToolStripLabel LastLabel;
        public ToolStripLabel FunctionLabel;
        public ToolStrip ToolStrip;
        public ToolStripLabel FilterSpacer;
        public ToolStripLabel ApplicationLabel;
        public ToolStripLabel FilterLabel;
        public ToolSeparator BackButtonSeparator;
        public ToolStripButton BackButton;
    }
}