
namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;


    partial class FileDialog 
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
            var resources = new ComponentResourceManager( typeof( FileDialog ) );
            TextBoxLayout = new TableLayoutPanel( );
            CheckBoxLayout = new TableLayoutPanel( );
            LibraryRadioButton = new RadioButton( );
            PowerPointRadioButton = new RadioButton( );
            ExecutableRadioButton = new RadioButton( );
            TextRadioButton = new RadioButton( );
            SqlCeRadioButton = new RadioButton( );
            ExcelRadioButton = new RadioButton( );
            CsvRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SQLiteRadioButton = new RadioButton( );
            SqlServerRadioButton = new RadioButton( );
            WordRadioButton = new RadioButton( );
            PdfRadioButton = new RadioButton( );
            FileList = new ListBox( );
            BindingSource = new BindingSource( components );
            ToolTip = new SmallTip( );
            FoundLabel = new Label( );
            TopTablePanel = new TableLayoutPanel( );
            PictureBox = new Picture( );
            Title = new Label( );
            MessageLabel = new Label( );
            CloseButton = new Button( );
            BrowseButton = new Button( );
            SelectButton = new Button( );
            Timer = new System.Windows.Forms.Timer( components );
            ButtonTable = new TableLayoutPanel( );
            OpenDialog = new OpenDialog( );
            TextBoxLayout.SuspendLayout( );
            CheckBoxLayout.SuspendLayout( );
            ( (ISupportInitialize)BindingSource ).BeginInit( );
            TopTablePanel.SuspendLayout( );
            ( (ISupportInitialize)PictureBox ).BeginInit( );
            ButtonTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // TextBoxLayout
            // 
            TextBoxLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TextBoxLayout.BackColor = System.Drawing.Color.Transparent;
            TextBoxLayout.ColumnCount = 3;
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 12.55012F ) );
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 70.99126F ) );
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 16.4723F ) );
            TextBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 20F ) );
            TextBoxLayout.Controls.Add( CheckBoxLayout, 2, 0 );
            TextBoxLayout.Controls.Add( FileList, 1, 0 );
            TextBoxLayout.Controls.Add( FoundLabel, 0, 0 );
            TextBoxLayout.Dock = DockStyle.Top;
            TextBoxLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            TextBoxLayout.Location = new System.Drawing.Point( 0, 64 );
            TextBoxLayout.Margin = new Padding( 5 );
            TextBoxLayout.Name = "TextBoxLayout";
            TextBoxLayout.Padding = new Padding( 1 );
            TextBoxLayout.RowCount = 1;
            TextBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 100F ) );
            TextBoxLayout.Size = new System.Drawing.Size( 688, 291 );
            TextBoxLayout.TabIndex = 5;
            // 
            // CheckBoxLayout
            // 
            CheckBoxLayout.BackColor = System.Drawing.Color.Transparent;
            CheckBoxLayout.ColumnCount = 1;
            CheckBoxLayout.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            CheckBoxLayout.Controls.Add( LibraryRadioButton, 0, 11 );
            CheckBoxLayout.Controls.Add( PowerPointRadioButton, 0, 8 );
            CheckBoxLayout.Controls.Add( ExecutableRadioButton, 0, 10 );
            CheckBoxLayout.Controls.Add( TextRadioButton, 0, 7 );
            CheckBoxLayout.Controls.Add( SqlCeRadioButton, 0, 9 );
            CheckBoxLayout.Controls.Add( ExcelRadioButton, 0, 6 );
            CheckBoxLayout.Controls.Add( CsvRadioButton, 0, 5 );
            CheckBoxLayout.Controls.Add( AccessRadioButton, 0, 4 );
            CheckBoxLayout.Controls.Add( SQLiteRadioButton, 0, 3 );
            CheckBoxLayout.Controls.Add( SqlServerRadioButton, 0, 2 );
            CheckBoxLayout.Controls.Add( WordRadioButton, 0, 1 );
            CheckBoxLayout.Controls.Add( PdfRadioButton, 0, 0 );
            CheckBoxLayout.Dock = DockStyle.Fill;
            CheckBoxLayout.Location = new System.Drawing.Point( 576, 4 );
            CheckBoxLayout.Name = "CheckBoxLayout";
            CheckBoxLayout.RowCount = 12;
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333765F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333266F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333267F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333765F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.333765F ) );
            CheckBoxLayout.RowStyles.Add( new RowStyle( SizeType.Percent, 8.332569F ) );
            CheckBoxLayout.Size = new System.Drawing.Size( 108, 283 );
            CheckBoxLayout.TabIndex = 2;
            // 
            // LibraryRadioButton
            // 
            LibraryRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LibraryRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            LibraryRadioButton.Checked = false;
            LibraryRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            LibraryRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            LibraryRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            LibraryRadioButton.Dock = DockStyle.Fill;
            LibraryRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            LibraryRadioButton.Group = 0;
            LibraryRadioButton.HoverText = "Library Files";
            LibraryRadioButton.IsDerivedStyle = true;
            LibraryRadioButton.Location = new System.Drawing.Point( 3, 256 );
            LibraryRadioButton.Name = "LibraryRadioButton";
            LibraryRadioButton.Result = null;
            LibraryRadioButton.Size = new System.Drawing.Size( 102, 17 );
            LibraryRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            LibraryRadioButton.StyleManager = null;
            LibraryRadioButton.TabIndex = 15;
            LibraryRadioButton.Tag = ".dll";
            LibraryRadioButton.Text = "  DLL Files";
            LibraryRadioButton.ThemeAuthor = "Terry D. Eppler";
            LibraryRadioButton.ThemeName = "Budget Execution";
            LibraryRadioButton.ToolTip = null;
            // 
            // PowerPointRadioButton
            // 
            PowerPointRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            PowerPointRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            PowerPointRadioButton.Checked = false;
            PowerPointRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            PowerPointRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            PowerPointRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            PowerPointRadioButton.Dock = DockStyle.Fill;
            PowerPointRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            PowerPointRadioButton.Group = 0;
            PowerPointRadioButton.HoverText = "Power Point Files";
            PowerPointRadioButton.IsDerivedStyle = true;
            PowerPointRadioButton.Location = new System.Drawing.Point( 3, 187 );
            PowerPointRadioButton.Name = "PowerPointRadioButton";
            PowerPointRadioButton.Result = null;
            PowerPointRadioButton.Size = new System.Drawing.Size( 102, 17 );
            PowerPointRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            PowerPointRadioButton.StyleManager = null;
            PowerPointRadioButton.TabIndex = 21;
            PowerPointRadioButton.Tag = ".pptx";
            PowerPointRadioButton.Text = "  Power Point";
            PowerPointRadioButton.ThemeAuthor = "Terry D. Eppler";
            PowerPointRadioButton.ThemeName = "Budget Execution";
            PowerPointRadioButton.ToolTip = null;
            // 
            // ExecutableRadioButton
            // 
            ExecutableRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ExecutableRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ExecutableRadioButton.Checked = false;
            ExecutableRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            ExecutableRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            ExecutableRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            ExecutableRadioButton.Dock = DockStyle.Fill;
            ExecutableRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            ExecutableRadioButton.Group = 0;
            ExecutableRadioButton.HoverText = "Executable Files";
            ExecutableRadioButton.IsDerivedStyle = true;
            ExecutableRadioButton.Location = new System.Drawing.Point( 3, 233 );
            ExecutableRadioButton.Name = "ExecutableRadioButton";
            ExecutableRadioButton.Result = null;
            ExecutableRadioButton.Size = new System.Drawing.Size( 102, 17 );
            ExecutableRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            ExecutableRadioButton.StyleManager = null;
            ExecutableRadioButton.TabIndex = 14;
            ExecutableRadioButton.Tag = ".exe";
            ExecutableRadioButton.Text = "  EXE Files";
            ExecutableRadioButton.ThemeAuthor = "Terry D. Eppler";
            ExecutableRadioButton.ThemeName = "Budget Execution";
            ExecutableRadioButton.ToolTip = null;
            // 
            // TextRadioButton
            // 
            TextRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TextRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TextRadioButton.Checked = false;
            TextRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            TextRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            TextRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            TextRadioButton.Dock = DockStyle.Fill;
            TextRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            TextRadioButton.Group = 0;
            TextRadioButton.HoverText = "Text Files";
            TextRadioButton.IsDerivedStyle = true;
            TextRadioButton.Location = new System.Drawing.Point( 3, 164 );
            TextRadioButton.Name = "TextRadioButton";
            TextRadioButton.Result = null;
            TextRadioButton.Size = new System.Drawing.Size( 102, 17 );
            TextRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            TextRadioButton.StyleManager = null;
            TextRadioButton.TabIndex = 20;
            TextRadioButton.Tag = ".txt";
            TextRadioButton.Text = "  Text Files";
            TextRadioButton.ThemeAuthor = "Terry D. Eppler";
            TextRadioButton.ThemeName = "Budget Execution";
            TextRadioButton.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            SqlCeRadioButton.Dock = DockStyle.Fill;
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlCeRadioButton.Group = 0;
            SqlCeRadioButton.HoverText = "SQL Compact Files";
            SqlCeRadioButton.IsDerivedStyle = true;
            SqlCeRadioButton.Location = new System.Drawing.Point( 3, 210 );
            SqlCeRadioButton.Name = "SqlCeRadioButton";
            SqlCeRadioButton.Result = null;
            SqlCeRadioButton.Size = new System.Drawing.Size( 102, 17 );
            SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlCeRadioButton.StyleManager = null;
            SqlCeRadioButton.TabIndex = 13;
            SqlCeRadioButton.Tag = ".sdf";
            SqlCeRadioButton.Text = "  SQL Compact";
            SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlCeRadioButton.ThemeName = "Budget Execution";
            SqlCeRadioButton.ToolTip = null;
            // 
            // ExcelRadioButton
            // 
            ExcelRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ExcelRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ExcelRadioButton.Checked = false;
            ExcelRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            ExcelRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            ExcelRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            ExcelRadioButton.Dock = DockStyle.Fill;
            ExcelRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            ExcelRadioButton.Group = 0;
            ExcelRadioButton.HoverText = "Excel Workbooks";
            ExcelRadioButton.IsDerivedStyle = true;
            ExcelRadioButton.Location = new System.Drawing.Point( 3, 141 );
            ExcelRadioButton.Name = "ExcelRadioButton";
            ExcelRadioButton.Result = null;
            ExcelRadioButton.Size = new System.Drawing.Size( 102, 17 );
            ExcelRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            ExcelRadioButton.StyleManager = null;
            ExcelRadioButton.TabIndex = 19;
            ExcelRadioButton.Tag = ".xlsx";
            ExcelRadioButton.Text = "  Excel Files";
            ExcelRadioButton.ThemeAuthor = "Terry D. Eppler";
            ExcelRadioButton.ThemeName = "Budget Execution";
            ExcelRadioButton.ToolTip = null;
            // 
            // CsvRadioButton
            // 
            CsvRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CsvRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CsvRadioButton.Checked = false;
            CsvRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            CsvRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            CsvRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            CsvRadioButton.Dock = DockStyle.Fill;
            CsvRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            CsvRadioButton.Group = 0;
            CsvRadioButton.HoverText = "CSV Files";
            CsvRadioButton.IsDerivedStyle = true;
            CsvRadioButton.Location = new System.Drawing.Point( 3, 118 );
            CsvRadioButton.Name = "CsvRadioButton";
            CsvRadioButton.Result = null;
            CsvRadioButton.Size = new System.Drawing.Size( 102, 17 );
            CsvRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            CsvRadioButton.StyleManager = null;
            CsvRadioButton.TabIndex = 18;
            CsvRadioButton.Tag = ".csv";
            CsvRadioButton.Text = "  CSV Files";
            CsvRadioButton.ThemeAuthor = "Terry D. Eppler";
            CsvRadioButton.ThemeName = "Budget Execution";
            CsvRadioButton.ToolTip = null;
            // 
            // AccessRadioButton
            // 
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            AccessRadioButton.Dock = DockStyle.Fill;
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            AccessRadioButton.Group = 0;
            AccessRadioButton.HoverText = "Access DB Files";
            AccessRadioButton.IsDerivedStyle = true;
            AccessRadioButton.Location = new System.Drawing.Point( 3, 95 );
            AccessRadioButton.Name = "AccessRadioButton";
            AccessRadioButton.Result = null;
            AccessRadioButton.Size = new System.Drawing.Size( 102, 17 );
            AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            AccessRadioButton.StyleManager = null;
            AccessRadioButton.TabIndex = 17;
            AccessRadioButton.Tag = ".accdb";
            AccessRadioButton.Text = "  MS Access";
            AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
            AccessRadioButton.ThemeName = "Budget Execution";
            AccessRadioButton.ToolTip = null;
            // 
            // SQLiteRadioButton
            // 
            SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SQLiteRadioButton.Checked = false;
            SQLiteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            SQLiteRadioButton.Dock = DockStyle.Fill;
            SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SQLiteRadioButton.Group = 0;
            SQLiteRadioButton.HoverText = "SQLite DB Files";
            SQLiteRadioButton.IsDerivedStyle = true;
            SQLiteRadioButton.Location = new System.Drawing.Point( 3, 72 );
            SQLiteRadioButton.Name = "SQLiteRadioButton";
            SQLiteRadioButton.Result = null;
            SQLiteRadioButton.Size = new System.Drawing.Size( 102, 17 );
            SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SQLiteRadioButton.StyleManager = null;
            SQLiteRadioButton.TabIndex = 16;
            SQLiteRadioButton.Tag = ".db";
            SQLiteRadioButton.Text = "  SQLite";
            SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
            SQLiteRadioButton.ThemeName = "Budget Execution";
            SQLiteRadioButton.ToolTip = null;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            SqlServerRadioButton.Dock = DockStyle.Fill;
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlServerRadioButton.Group = 0;
            SqlServerRadioButton.HoverText = "SQL Server DB Files";
            SqlServerRadioButton.IsDerivedStyle = true;
            SqlServerRadioButton.Location = new System.Drawing.Point( 3, 49 );
            SqlServerRadioButton.Name = "SqlServerRadioButton";
            SqlServerRadioButton.Result = null;
            SqlServerRadioButton.Size = new System.Drawing.Size( 102, 17 );
            SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlServerRadioButton.StyleManager = null;
            SqlServerRadioButton.TabIndex = 15;
            SqlServerRadioButton.Tag = ".mdf";
            SqlServerRadioButton.Text = "  SQL Server";
            SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlServerRadioButton.ThemeName = "Budget Execution";
            SqlServerRadioButton.ToolTip = null;
            // 
            // WordRadioButton
            // 
            WordRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            WordRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            WordRadioButton.Checked = false;
            WordRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            WordRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            WordRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            WordRadioButton.Dock = DockStyle.Fill;
            WordRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            WordRadioButton.Group = 0;
            WordRadioButton.HoverText = "Word Documents";
            WordRadioButton.IsDerivedStyle = true;
            WordRadioButton.Location = new System.Drawing.Point( 3, 26 );
            WordRadioButton.Name = "WordRadioButton";
            WordRadioButton.Result = null;
            WordRadioButton.Size = new System.Drawing.Size( 102, 17 );
            WordRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            WordRadioButton.StyleManager = null;
            WordRadioButton.TabIndex = 14;
            WordRadioButton.Tag = ".docx";
            WordRadioButton.Text = "  Word";
            WordRadioButton.ThemeAuthor = "Terry D. Eppler";
            WordRadioButton.ThemeName = "Budget Execution";
            WordRadioButton.ToolTip = null;
            // 
            // PdfRadioButton
            // 
            PdfRadioButton.BackgroundColor = System.Drawing.Color.Transparent;
            PdfRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            PdfRadioButton.Checked = false;
            PdfRadioButton.CheckSignColor = System.Drawing.Color.FromArgb( 0, 192, 0 );
            PdfRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            PdfRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 205, 205, 205 );
            PdfRadioButton.Dock = DockStyle.Fill;
            PdfRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            PdfRadioButton.Group = 0;
            PdfRadioButton.HoverText = "PDF Documents";
            PdfRadioButton.IsDerivedStyle = true;
            PdfRadioButton.Location = new System.Drawing.Point( 3, 3 );
            PdfRadioButton.Name = "PdfRadioButton";
            PdfRadioButton.Result = null;
            PdfRadioButton.Size = new System.Drawing.Size( 102, 17 );
            PdfRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            PdfRadioButton.StyleManager = null;
            PdfRadioButton.TabIndex = 13;
            PdfRadioButton.Tag = ".pdf";
            PdfRadioButton.Text = "  PDF";
            PdfRadioButton.ThemeAuthor = "Terry D. Eppler";
            PdfRadioButton.ThemeName = "Budget Execution";
            PdfRadioButton.ToolTip = null;
            // 
            // FileList
            // 
            FileList.BackColor = System.Drawing.Color.FromArgb( 35, 35, 35 );
            FileList.BindingSource = BindingSource;
            FileList.BorderColor = System.Drawing.Color.Gray;
            FileList.DataFilter = null;
            FileList.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FileList.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FileList.Dock = DockStyle.Fill;
            FileList.Font = new System.Drawing.Font( "Roboto", 8.25F );
            FileList.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            FileList.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            FileList.HoverText = null;
            FileList.IsDerivedStyle = true;
            FileList.ItemHeight = 30;
            FileList.Location = new System.Drawing.Point( 88, 2 );
            FileList.Margin = new Padding( 1 );
            FileList.MultiSelect = false;
            FileList.Name = "FileList";
            FileList.Padding = new Padding( 1 );
            FileList.SelectedIndex = -1;
            FileList.SelectedItem = null;
            FileList.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FileList.SelectedItemColor = System.Drawing.Color.White;
            FileList.SelectedText = null;
            FileList.SelectedValue = null;
            FileList.ShowBorder = false;
            FileList.ShowScrollBar = false;
            FileList.Size = new System.Drawing.Size( 484, 287 );
            FileList.Style = MetroSet_UI.Enums.Style.Custom;
            FileList.StyleManager = null;
            FileList.TabIndex = 3;
            FileList.ThemeAuthor = "Terry D. Eppler";
            FileList.ThemeName = "BudgetExecution";
            FileList.ToolTip = ToolTip;
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
            // FoundLabel
            // 
            FoundLabel.BindingSource = null;
            FoundLabel.FlatStyle = FlatStyle.Flat;
            FoundLabel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            FoundLabel.HoverText = null;
            FoundLabel.IsDerivedStyle = true;
            FoundLabel.Location = new System.Drawing.Point( 4, 4 );
            FoundLabel.Margin = new Padding( 3 );
            FoundLabel.Name = "FoundLabel";
            FoundLabel.Padding = new Padding( 1 );
            FoundLabel.Size = new System.Drawing.Size( 79, 23 );
            FoundLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FoundLabel.StyleManager = null;
            FoundLabel.TabIndex = 4;
            FoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            FoundLabel.ThemeAuthor = "Terry D. Eppler";
            FoundLabel.ThemeName = "BudgetExecution";
            FoundLabel.ToolTip = null;
            // 
            // TopTablePanel
            // 
            TopTablePanel.BackColor = System.Drawing.Color.Transparent;
            TopTablePanel.ColumnCount = 2;
            TopTablePanel.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.668605F ) );
            TopTablePanel.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.3314F ) );
            TopTablePanel.Controls.Add( PictureBox, 0, 0 );
            TopTablePanel.Controls.Add( Title, 1, 0 );
            TopTablePanel.Dock = DockStyle.Top;
            TopTablePanel.Location = new System.Drawing.Point( 0, 0 );
            TopTablePanel.Name = "TopTablePanel";
            TopTablePanel.RowCount = 2;
            TopTablePanel.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            TopTablePanel.RowStyles.Add( new RowStyle( SizeType.Absolute, 37F ) );
            TopTablePanel.Size = new System.Drawing.Size( 688, 64 );
            TopTablePanel.TabIndex = 9;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = BindingSource;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 1, 1 );
            PictureBox.Margin = new Padding( 1 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 18, 18 );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = ToolTip;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = DockStyle.Top;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 42, 3 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new System.Drawing.Size( 643, 21 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 0;
            Title.Text = "File Search";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "BudgetExecution";
            Title.ToolTip = null;
            // 
            // MessageLabel
            // 
            MessageLabel.BindingSource = null;
            MessageLabel.FlatStyle = FlatStyle.Flat;
            MessageLabel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            MessageLabel.HoverText = null;
            MessageLabel.IsDerivedStyle = true;
            MessageLabel.Location = new System.Drawing.Point( 90, 363 );
            MessageLabel.Margin = new Padding( 3 );
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Padding = new Padding( 1 );
            MessageLabel.Size = new System.Drawing.Size( 488, 23 );
            MessageLabel.Style = MetroSet_UI.Enums.Style.Custom;
            MessageLabel.StyleManager = null;
            MessageLabel.TabIndex = 12;
            MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MessageLabel.ThemeAuthor = "Terry D. Eppler";
            MessageLabel.ThemeName = "BudgetExecution";
            MessageLabel.ToolTip = null;
            // 
            // CloseButton
            // 
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
            CloseButton.Location = new System.Drawing.Point( 570, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 101, 29 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 14;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // BrowseButton
            // 
            BrowseButton.BindingSource = null;
            BrowseButton.DataFilter = null;
            BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 8F );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            BrowseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            BrowseButton.HoverText = null;
            BrowseButton.HoverTextColor = System.Drawing.Color.White;
            BrowseButton.IsDerivedStyle = true;
            BrowseButton.Location = new System.Drawing.Point( 47, 3 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.Padding = new Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 110, 29 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 15;
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
            SelectButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SelectButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            SelectButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            SelectButton.HoverText = null;
            SelectButton.HoverTextColor = System.Drawing.Color.White;
            SelectButton.IsDerivedStyle = true;
            SelectButton.Location = new System.Drawing.Point( 289, 3 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 110, 29 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 16;
            SelectButton.Text = "Ok";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Budget Execution";
            SelectButton.ToolTip = null;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 7;
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 22F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 242F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 208F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 73F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 107F ) );
            ButtonTable.ColumnStyles.Add( new ColumnStyle( SizeType.Absolute, 14F ) );
            ButtonTable.Controls.Add( CloseButton, 5, 0 );
            ButtonTable.Controls.Add( SelectButton, 3, 0 );
            ButtonTable.Controls.Add( BrowseButton, 2, 0 );
            ButtonTable.Dock = DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 404 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 688, 35 );
            ButtonTable.TabIndex = 17;
            // 
            // OpenDialog
            // 
            OpenDialog.Filter = null;
            // 
            // FileDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 688, 439 );
            ControlBox = false;
            Controls.Add( ButtonTable );
            Controls.Add( MessageLabel );
            Controls.Add( TextBoxLayout );
            Controls.Add( TopTablePanel );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            Name = "FileDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            TextBoxLayout.ResumeLayout( false );
            CheckBoxLayout.ResumeLayout( false );
            ( (ISupportInitialize)BindingSource ).EndInit( );
            TopTablePanel.ResumeLayout( false );
            ( (ISupportInitialize)PictureBox ).EndInit( );
            ButtonTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        public TableLayoutPanel TextBoxLayout;
        public TableLayoutPanel CheckBoxLayout;
        public SmallTip ToolTip;
        public TableLayoutPanel TopTablePanel;
        public Label Title;
        public BindingSource BindingSource;
        public Picture PictureBox;
        public ListBox FileList;
        public Label FoundLabel;
        public Label MessageLabel;
        public RadioButton LibraryRadioButton;
        public RadioButton PowerPointRadioButton;
        public RadioButton ExecutableRadioButton;
        public RadioButton TextRadioButton;
        public RadioButton SqlCeRadioButton;
        public RadioButton ExcelRadioButton;
        public RadioButton CsvRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SQLiteRadioButton;
        public RadioButton SqlServerRadioButton;
        public RadioButton WordRadioButton;
        public RadioButton PdfRadioButton;
        public Button CloseButton;
        public Button BrowseButton;
        public Button SelectButton;
        public System.Windows.Forms.Timer Timer;
        public TableLayoutPanel ButtonTable;
        public OpenDialog OpenDialog;
    }

}
