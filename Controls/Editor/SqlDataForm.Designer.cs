// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="SqlDataForm.Designer.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the 
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  $CURRENT_YEAR$  Terry Eppler
//
//    Permission is hereby granted, free of charge, to any person obtaining a copy 
//    of this software and associated documentation files (the “Software”), 
//    to deal in the Software without restriction, 
//    including without limitation the rights to use, 
//    copy, modify, merge, publish, distribute, sublicense, 
//    and/or sell copies of the Software, 
//    and to permit persons to whom the Software is furnished to do so, 
//    subject to the following conditions:
//    
//    The above copyright notice and this permission notice shall be included in all 
//    copies or substantial portions of the Software.
//    
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. 
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
//    DEALINGS IN THE SOFTWARE.
//
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   SqlDataForm.Designer.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;

    partial class SqlDataForm
    {

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
        public void InitializeComponent( )
        {
            components = new System.ComponentModel.Container( );
            var config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
            var dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( SqlDataForm ) );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new Picture( );
            Title = new Label( );
            ToolTip = new SmallTip( );
            TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv( );
            SqlTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            EditorTable = new HeaderPanel( );
            EditorPanel = new BackPanel( );
            Editor = new Editor( );
            LookupTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            ColumnTable = new HeaderPanel( );
            ColumnPanel = new BackPanel( );
            ColumnListBox = new ListBox( );
            ValueTable = new HeaderPanel( );
            ValuePanel = new BackPanel( );
            ValueListBox = new ListBox( );
            SourceTable = new HeaderPanel( );
            TablePanel = new BackPanel( );
            TableListBox = new ListBox( );
            DataTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            DataGridTable = new HeaderPanel( );
            DataGridPanel = new BackPanel( );
            DataGrid = new DataGrid( );
            SchemaTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            SchemaHeaderPanel = new HeaderPanel( );
            SchemaTable = new HeaderPanel( );
            SchemaPanel = new BackPanel( );
            DeleteColumnButton = new Button( );
            AddColumnButton = new Button( );
            SelectDataTypeLabel = new Label( );
            AddColumnLabel = new Label( );
            AddColumnTextBox = new TextBox( );
            DataTypeComboBox = new ComboBox( );
            headerPanel1 = new HeaderPanel( );
            LayoutPanel = new BackPanel( );
            AddTableLabel = new Label( );
            DeleteTableButton = new Button( );
            AddTableButton = new Button( );
            SelectTableLabel = new Label( );
            TableNameComboBox = new ComboBox( );
            AddTableTextBox = new TextBox( );
            BusyTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            BusyHeaderPanel = new HeaderPanel( );
            BusyPanel = new BackPanel( );
            Loader = new System.Windows.Forms.PictureBox( );
            SqlCommandTable = new System.Windows.Forms.TableLayoutPanel( );
            ProviderTable = new HeaderPanel( );
            SecondPanel = new BackPanel( );
            SqlServerRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SQLiteRadioButton = new RadioButton( );
            SqlCeRadioButton = new RadioButton( );
            CommandTable = new HeaderPanel( );
            CommandPanel = new BackPanel( );
            CommandComboBox = new ComboBox( );
            SqlStatementTable = new HeaderPanel( );
            TextPanel = new BackPanel( );
            QueryListBox = new ListBox( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ToolStrip = new ToolStrip( );
            CloseButton = new ToolStripButton( );
            Separator1 = new ToolSeparator( );
            StatusLabel = new ToolStripLabel( );
            NavigationSpaceLabel = new ToolStripLabel( );
            Separator2 = new ToolSeparator( );
            FirstButton = new ToolStripButton( );
            Separator3 = new ToolSeparator( );
            PreviousButton = new ToolStripButton( );
            Separator4 = new ToolSeparator( );
            NextButton = new ToolStripButton( );
            Separator5 = new ToolSeparator( );
            LastButton = new ToolStripButton( );
            Separator6 = new ToolSeparator( );
            DataLabel = new ToolStripLabel( );
            Separator7 = new ToolSeparator( );
            GoButton = new ToolStripButton( );
            Separator8 = new ToolSeparator( );
            RefreshButton = new ToolStripButton( );
            Separator9 = new ToolSeparator( );
            EditSqlButton = new ToolStripButton( );
            Separator11 = new ToolSeparator( );
            EditDataButton = new ToolStripButton( );
            Separator12 = new ToolSeparator( );
            TableButton = new ToolStripButton( );
            TableSeparator = new ToolSeparator( );
            LookupButton = new ToolStripButton( );
            Separator13 = new ToolSeparator( );
            SaveButton = new ToolStripButton( );
            Separator14 = new ToolSeparator( );
            FileSystemLabel = new ToolStripLabel( );
            Separator15 = new ToolSeparator( );
            ClientButton = new ToolStripButton( );
            ClientSeparator = new ToolSeparator( );
            BrowserButton = new ToolStripButton( );
            Separator16 = new ToolSeparator( );
            Separator17 = new ToolSeparator( );
            MainMenuButton = new ToolStripButton( );
            Separator33 = new ToolSeparator( );
            ApplicationLabel = new ToolStripLabel( );
            FirstSeparator = new ToolSeparator( );
            SqlEditorButton = new ToolStripButton( );
            Separator10 = new ToolSeparator( );
            Timer = new System.Windows.Forms.Timer( components );
            ToolStripTable = new System.Windows.Forms.TableLayoutPanel( );
            ContextMenu = new ContextMenu( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).BeginInit( );
            TabControl.SuspendLayout( );
            SqlTabPage.SuspendLayout( );
            EditorTable.SuspendLayout( );
            EditorPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Editor ).BeginInit( );
            LookupTabPage.SuspendLayout( );
            ColumnTable.SuspendLayout( );
            ColumnPanel.SuspendLayout( );
            ValueTable.SuspendLayout( );
            ValuePanel.SuspendLayout( );
            SourceTable.SuspendLayout( );
            TablePanel.SuspendLayout( );
            DataTabPage.SuspendLayout( );
            DataGridTable.SuspendLayout( );
            DataGridPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)DataGrid ).BeginInit( );
            SchemaTabPage.SuspendLayout( );
            SchemaHeaderPanel.SuspendLayout( );
            SchemaTable.SuspendLayout( );
            SchemaPanel.SuspendLayout( );
            headerPanel1.SuspendLayout( );
            LayoutPanel.SuspendLayout( );
            BusyTabPage.SuspendLayout( );
            BusyHeaderPanel.SuspendLayout( );
            BusyPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Loader ).BeginInit( );
            SqlCommandTable.SuspendLayout( );
            ProviderTable.SuspendLayout( );
            SecondPanel.SuspendLayout( );
            CommandTable.SuspendLayout( );
            CommandPanel.SuspendLayout( );
            SqlStatementTable.SuspendLayout( );
            TextPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ToolStrip.SuspendLayout( );
            ToolStripTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 2;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 3.51270556F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 96.4873F ) );
            HeaderTable.Controls.Add( PictureBox, 0, 0 );
            HeaderTable.Controls.Add( Title, 1, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.Size = new System.Drawing.Size( 1333, 32 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.budget;
            PictureBox.ImageList = null;
            PictureBox.InitialImage = Resources.Images.SqlEditorTile;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 24, 18 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 49, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1281, 26 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
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
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 9F );
            TabControl.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 951, 587 );
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.BorderWidth = 1;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.Controls.Add( SqlTabPage );
            TabControl.Controls.Add( LookupTabPage );
            TabControl.Controls.Add( DataTabPage );
            TabControl.Controls.Add( SchemaTabPage );
            TabControl.Controls.Add( BusyTabPage );
            TabControl.FixedSingleBorderColor = System.Drawing.Color.Transparent;
            TabControl.FocusOnTabClick = false;
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ItemSize = new System.Drawing.Size( 158, 5 );
            TabControl.Location = new System.Drawing.Point( 0, 32 );
            TabControl.Margin = new System.Windows.Forms.Padding( 1 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 951, 587 );
            TabControl.TabIndex = 13;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb( 22, 39, 70 );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            // 
            // SqlTabPage
            // 
            SqlTabPage.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlTabPage.Controls.Add( EditorTable );
            SqlTabPage.Image = null;
            SqlTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            SqlTabPage.Location = new System.Drawing.Point( 0, 4 );
            SqlTabPage.Margin = new System.Windows.Forms.Padding( 1 );
            SqlTabPage.Name = "SqlTabPage";
            SqlTabPage.Padding = new System.Windows.Forms.Padding( 1 );
            SqlTabPage.ShowCloseButton = true;
            SqlTabPage.Size = new System.Drawing.Size( 951, 583 );
            SqlTabPage.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlTabPage.TabForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlTabPage.TabIndex = 8;
            SqlTabPage.ThemesEnabled = false;
            // 
            // EditorTable
            // 
            EditorTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            EditorTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            EditorTable.CaptionText = "SQL Editor";
            EditorTable.ColumnCount = 1;
            EditorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            EditorTable.Controls.Add( EditorPanel, 0, 1 );
            EditorTable.Font = new System.Drawing.Font( "Roboto", 9F );
            EditorTable.ForeColor = System.Drawing.Color.DarkGray;
            EditorTable.Location = new System.Drawing.Point( 32, 22 );
            EditorTable.Name = "EditorTable";
            EditorTable.RowCount = 2;
            EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.15264177F ) );
            EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.84736F ) );
            EditorTable.Size = new System.Drawing.Size( 919, 561 );
            EditorTable.TabIndex = 5;
            // 
            // EditorPanel
            // 
            EditorPanel.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            EditorPanel.BackColor = System.Drawing.Color.Transparent;
            EditorPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            EditorPanel.BindingSource = null;
            EditorPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            EditorPanel.BorderThickness = 1;
            EditorPanel.Children = null;
            EditorPanel.Controls.Add( Editor );
            EditorPanel.DataFilter = null;
            EditorPanel.Font = new System.Drawing.Font( "Roboto", 11F );
            EditorPanel.ForeColor = System.Drawing.Color.Transparent;
            EditorPanel.HoverText = null;
            EditorPanel.IsDerivedStyle = true;
            EditorPanel.Location = new System.Drawing.Point( 3, 30 );
            EditorPanel.Name = "EditorPanel";
            EditorPanel.Padding = new System.Windows.Forms.Padding( 1 );
            EditorPanel.Size = new System.Drawing.Size( 913, 528 );
            EditorPanel.Style = MetroSet_UI.Enums.Style.Custom;
            EditorPanel.StyleManager = null;
            EditorPanel.TabIndex = 0;
            EditorPanel.ThemeAuthor = "Terry D. Eppler";
            EditorPanel.ThemeName = "BudgetExecution";
            EditorPanel.ToolTip = null;
            // 
            // Editor
            // 
            Editor.AllowZoom = false;
            Editor.AlwaysShowScrollers = true;
            Editor.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Editor.BackColor = System.Drawing.SystemColors.ControlLight;
            Editor.BookmarkTooltipBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            Editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Editor.CanOverrideStyle = true;
            Editor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb( 255, 238, 98 );
            Editor.CodeSnipptSize = new System.Drawing.Size( 100, 100 );
            Editor.ColumnGuidesMeasuringFont = new System.Drawing.Font( "Roboto", 8F );
            Editor.Configurator = config1;
            Editor.ContextChoiceBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb( 233, 166, 50 );
            Editor.ContextPromptBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            Editor.ContextTooltipBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            Editor.CurrentLineHighlightColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            Editor.EndOfLineBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.EndOfLineForeColor = System.Drawing.SystemColors.ControlLight;
            Editor.Font = new System.Drawing.Font( "Roboto", 9.75F );
            Editor.ForeColor = System.Drawing.Color.Black;
            Editor.HighlightCurrentLine = true;
            Editor.IndentationBlockBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            Editor.IndentBlockHighlightingColor = System.Drawing.SystemColors.ActiveCaption;
            Editor.IndentLineColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            Editor.IndicatorMarginBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.LineNumbersColor = System.Drawing.Color.Black;
            Editor.LineNumbersFont = new System.Drawing.Font( "Hack", 8F, System.Drawing.FontStyle.Bold );
            Editor.Location = new System.Drawing.Point( 17, 15 );
            Editor.Name = "Editor";
            Editor.RenderRightToLeft = false;
            Editor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
            Editor.ScrollPosition = new System.Drawing.Point( 0, 0 );
            Editor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            Editor.SelectionMarginBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            Editor.SelectionTextColor = System.Drawing.Color.White;
            Editor.ShowEndOfLine = false;
            Editor.Size = new System.Drawing.Size( 880, 496 );
            Editor.StatusBarSettings.CoordsPanel.Width = 150;
            Editor.StatusBarSettings.EncodingPanel.Width = 100;
            Editor.StatusBarSettings.FileNamePanel.Width = 100;
            Editor.StatusBarSettings.InsertPanel.Width = 33;
            Editor.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            Editor.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            Editor.StatusBarSettings.StatusPanel.Width = 70;
            Editor.StatusBarSettings.TextPanel.Width = 214;
            Editor.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Office2016Black;
            Editor.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Black;
            Editor.TabIndex = 0;
            Editor.TabSize = 4;
            Editor.Text = "";
            Editor.TextAreaWidth = 400;
            Editor.ThemeName = "Office2016Black";
            Editor.UserMarginTextColor = System.Drawing.Color.DimGray;
            Editor.UseXPStyle = false;
            Editor.UseXPStyleBorder = true;
            Editor.VisualColumn = 1;
            Editor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            Editor.WordWrap = true;
            Editor.WordWrapColumn = 80;
            Editor.ZoomFactor = 1F;
            // 
            // LookupTabPage
            // 
            LookupTabPage.Controls.Add( ColumnTable );
            LookupTabPage.Controls.Add( ValueTable );
            LookupTabPage.Controls.Add( SourceTable );
            LookupTabPage.Image = null;
            LookupTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            LookupTabPage.Location = new System.Drawing.Point( 0, 4 );
            LookupTabPage.Name = "LookupTabPage";
            LookupTabPage.ShowCloseButton = true;
            LookupTabPage.Size = new System.Drawing.Size( 951, 583 );
            LookupTabPage.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LookupTabPage.TabForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            LookupTabPage.TabIndex = 10;
            LookupTabPage.ThemesEnabled = false;
            // 
            // ColumnTable
            // 
            ColumnTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ColumnTable.CaptionText = "Columns";
            ColumnTable.ColumnCount = 1;
            ColumnTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ColumnTable.Controls.Add( ColumnPanel, 0, 1 );
            ColumnTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ColumnTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ColumnTable.Location = new System.Drawing.Point( 487, 19 );
            ColumnTable.Name = "ColumnTable";
            ColumnTable.RowCount = 2;
            ColumnTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 8.465609F ) );
            ColumnTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 91.53439F ) );
            ColumnTable.Size = new System.Drawing.Size( 412, 232 );
            ColumnTable.TabIndex = 20;
            // 
            // ColumnPanel
            // 
            ColumnPanel.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ColumnPanel.BackColor = System.Drawing.Color.Transparent;
            ColumnPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnPanel.BindingSource = null;
            ColumnPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ColumnPanel.BorderThickness = 1;
            ColumnPanel.Children = null;
            ColumnPanel.Controls.Add( ColumnListBox );
            ColumnPanel.DataFilter = null;
            ColumnPanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ColumnPanel.ForeColor = System.Drawing.Color.Transparent;
            ColumnPanel.HoverText = null;
            ColumnPanel.IsDerivedStyle = true;
            ColumnPanel.Location = new System.Drawing.Point( 3, 37 );
            ColumnPanel.Name = "ColumnPanel";
            ColumnPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ColumnPanel.Size = new System.Drawing.Size( 406, 192 );
            ColumnPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ColumnPanel.StyleManager = null;
            ColumnPanel.TabIndex = 8;
            ColumnPanel.ThemeAuthor = "Terry D. Eppler";
            ColumnPanel.ThemeName = "BudgetExecution";
            ColumnPanel.ToolTip = null;
            // 
            // ColumnListBox
            // 
            ColumnListBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ColumnListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ColumnListBox.BindingSource = null;
            ColumnListBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            ColumnListBox.DataFilter = null;
            ColumnListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ColumnListBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ColumnListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ColumnListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ColumnListBox.HoverText = null;
            ColumnListBox.IsDerivedStyle = true;
            ColumnListBox.ItemHeight = 30;
            ColumnListBox.Location = new System.Drawing.Point( 16, 13 );
            ColumnListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ColumnListBox.MultiSelect = false;
            ColumnListBox.Name = "ColumnListBox";
            ColumnListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ColumnListBox.SelectedIndex = -1;
            ColumnListBox.SelectedItem = null;
            ColumnListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ColumnListBox.SelectedItemColor = System.Drawing.Color.White;
            ColumnListBox.SelectedText = null;
            ColumnListBox.SelectedValue = null;
            ColumnListBox.ShowBorder = false;
            ColumnListBox.ShowScrollBar = false;
            ColumnListBox.Size = new System.Drawing.Size( 377, 164 );
            ColumnListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ColumnListBox.StyleManager = null;
            ColumnListBox.TabIndex = 2;
            ColumnListBox.Text = "listBox1";
            ColumnListBox.ThemeAuthor = "Terry D. Eppler";
            ColumnListBox.ThemeName = "BudgetExecution";
            ColumnListBox.ToolTip = ToolTip;
            // 
            // ValueTable
            // 
            ValueTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValueTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ValueTable.CaptionText = "Values ";
            ValueTable.ColumnCount = 1;
            ValueTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ValueTable.Controls.Add( ValuePanel, 0, 1 );
            ValueTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ValueTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ValueTable.Location = new System.Drawing.Point( 490, 257 );
            ValueTable.Name = "ValueTable";
            ValueTable.RowCount = 2;
            ValueTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.90879488F ) );
            ValueTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.0912F ) );
            ValueTable.Size = new System.Drawing.Size( 412, 323 );
            ValueTable.TabIndex = 18;
            // 
            // ValuePanel
            // 
            ValuePanel.BackColor = System.Drawing.Color.Transparent;
            ValuePanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValuePanel.BindingSource = null;
            ValuePanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ValuePanel.BorderThickness = 1;
            ValuePanel.Children = null;
            ValuePanel.Controls.Add( ValueListBox );
            ValuePanel.DataFilter = null;
            ValuePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ValuePanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ValuePanel.ForeColor = System.Drawing.Color.Transparent;
            ValuePanel.HoverText = null;
            ValuePanel.IsDerivedStyle = true;
            ValuePanel.Location = new System.Drawing.Point( 3, 31 );
            ValuePanel.Name = "ValuePanel";
            ValuePanel.Padding = new System.Windows.Forms.Padding( 1 );
            ValuePanel.Size = new System.Drawing.Size( 406, 289 );
            ValuePanel.Style = MetroSet_UI.Enums.Style.Custom;
            ValuePanel.StyleManager = null;
            ValuePanel.TabIndex = 9;
            ValuePanel.ThemeAuthor = "Terry D. Eppler";
            ValuePanel.ThemeName = "BudgetExecution";
            ValuePanel.ToolTip = null;
            // 
            // ValueListBox
            // 
            ValueListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ValueListBox.BindingSource = null;
            ValueListBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            ValueListBox.DataFilter = null;
            ValueListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValueListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ValueListBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            ValueListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ValueListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            ValueListBox.HoverText = null;
            ValueListBox.IsDerivedStyle = true;
            ValueListBox.ItemHeight = 30;
            ValueListBox.Location = new System.Drawing.Point( 15, 13 );
            ValueListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ValueListBox.MultiSelect = false;
            ValueListBox.Name = "ValueListBox";
            ValueListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ValueListBox.SelectedIndex = -1;
            ValueListBox.SelectedItem = null;
            ValueListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ValueListBox.SelectedItemColor = System.Drawing.Color.White;
            ValueListBox.SelectedText = null;
            ValueListBox.SelectedValue = null;
            ValueListBox.ShowBorder = false;
            ValueListBox.ShowScrollBar = false;
            ValueListBox.Size = new System.Drawing.Size( 375, 256 );
            ValueListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ValueListBox.StyleManager = null;
            ValueListBox.TabIndex = 2;
            ValueListBox.Text = "listBox1";
            ValueListBox.ThemeAuthor = "Terry D. Eppler";
            ValueListBox.ThemeName = "BudgetExecution";
            ValueListBox.ToolTip = ToolTip;
            // 
            // SourceTable
            // 
            SourceTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SourceTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SourceTable.CaptionText = "Tables";
            SourceTable.ColumnCount = 1;
            SourceTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SourceTable.Controls.Add( TablePanel, 0, 1 );
            SourceTable.Font = new System.Drawing.Font( "Roboto", 9F );
            SourceTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SourceTable.Location = new System.Drawing.Point( 50, 19 );
            SourceTable.Name = "SourceTable";
            SourceTable.RowCount = 2;
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 4.21545649F ) );
            SourceTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 95.7845459F ) );
            SourceTable.Size = new System.Drawing.Size( 412, 561 );
            SourceTable.TabIndex = 17;
            // 
            // TablePanel
            // 
            TablePanel.BackColor = System.Drawing.Color.Transparent;
            TablePanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TablePanel.BindingSource = null;
            TablePanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TablePanel.BorderThickness = 1;
            TablePanel.Children = null;
            TablePanel.Controls.Add( TableListBox );
            TablePanel.DataFilter = null;
            TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TablePanel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TablePanel.ForeColor = System.Drawing.Color.Transparent;
            TablePanel.HoverText = null;
            TablePanel.IsDerivedStyle = true;
            TablePanel.Location = new System.Drawing.Point( 3, 41 );
            TablePanel.Name = "TablePanel";
            TablePanel.Padding = new System.Windows.Forms.Padding( 1 );
            TablePanel.Size = new System.Drawing.Size( 406, 517 );
            TablePanel.Style = MetroSet_UI.Enums.Style.Custom;
            TablePanel.StyleManager = null;
            TablePanel.TabIndex = 7;
            TablePanel.ThemeAuthor = "Terry D. Eppler";
            TablePanel.ThemeName = "BudgetExecution";
            TablePanel.ToolTip = null;
            // 
            // TableListBox
            // 
            TableListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            TableListBox.BindingSource = null;
            TableListBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TableListBox.DataFilter = null;
            TableListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TableListBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TableListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            TableListBox.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            TableListBox.HoverText = null;
            TableListBox.IsDerivedStyle = true;
            TableListBox.ItemHeight = 30;
            TableListBox.Location = new System.Drawing.Point( 15, 15 );
            TableListBox.Margin = new System.Windows.Forms.Padding( 1 );
            TableListBox.MultiSelect = false;
            TableListBox.Name = "TableListBox";
            TableListBox.Padding = new System.Windows.Forms.Padding( 1 );
            TableListBox.SelectedIndex = -1;
            TableListBox.SelectedItem = null;
            TableListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableListBox.SelectedItemColor = System.Drawing.Color.White;
            TableListBox.SelectedText = null;
            TableListBox.SelectedValue = null;
            TableListBox.ShowBorder = false;
            TableListBox.ShowScrollBar = false;
            TableListBox.Size = new System.Drawing.Size( 375, 482 );
            TableListBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableListBox.StyleManager = null;
            TableListBox.TabIndex = 1;
            TableListBox.Text = "Tables";
            TableListBox.ThemeAuthor = "Terry D. Eppler";
            TableListBox.ThemeName = "BudgetExecution";
            TableListBox.ToolTip = ToolTip;
            // 
            // DataTabPage
            // 
            DataTabPage.Controls.Add( DataGridTable );
            DataTabPage.Image = null;
            DataTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            DataTabPage.Location = new System.Drawing.Point( 0, 4 );
            DataTabPage.Name = "DataTabPage";
            DataTabPage.ShowCloseButton = true;
            DataTabPage.Size = new System.Drawing.Size( 951, 583 );
            DataTabPage.TabIndex = 9;
            DataTabPage.ThemesEnabled = false;
            // 
            // DataGridTable
            // 
            DataGridTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataGridTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            DataGridTable.CaptionText = "Data Grid";
            DataGridTable.ColumnCount = 1;
            DataGridTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            DataGridTable.Controls.Add( DataGridPanel, 0, 1 );
            DataGridTable.Font = new System.Drawing.Font( "Roboto", 9F );
            DataGridTable.ForeColor = System.Drawing.Color.DarkGray;
            DataGridTable.Location = new System.Drawing.Point( 38, 22 );
            DataGridTable.Name = "DataGridTable";
            DataGridTable.RowCount = 2;
            DataGridTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.4678899F ) );
            DataGridTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.53211F ) );
            DataGridTable.Size = new System.Drawing.Size( 908, 561 );
            DataGridTable.TabIndex = 39;
            // 
            // DataGridPanel
            // 
            DataGridPanel.BackColor = System.Drawing.Color.Transparent;
            DataGridPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            DataGridPanel.BindingSource = null;
            DataGridPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            DataGridPanel.BorderThickness = 1;
            DataGridPanel.Children = null;
            DataGridPanel.Controls.Add( DataGrid );
            DataGridPanel.DataFilter = null;
            DataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DataGridPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            DataGridPanel.ForeColor = System.Drawing.Color.Transparent;
            DataGridPanel.HoverText = null;
            DataGridPanel.IsDerivedStyle = true;
            DataGridPanel.Location = new System.Drawing.Point( 3, 27 );
            DataGridPanel.Name = "DataGridPanel";
            DataGridPanel.Padding = new System.Windows.Forms.Padding( 1 );
            DataGridPanel.Size = new System.Drawing.Size( 902, 531 );
            DataGridPanel.Style = MetroSet_UI.Enums.Style.Custom;
            DataGridPanel.StyleManager = null;
            DataGridPanel.TabIndex = 47;
            DataGridPanel.ThemeAuthor = "Terry D. Eppler";
            DataGridPanel.ThemeName = "Budget Execution";
            DataGridPanel.ToolTip = null;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb( 50, 50, 50 );
            dataGridViewCellStyle1.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            DataGrid.BackgroundColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            DataGrid.BindingSource = null;
            DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font( "Roboto", 9F );
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.DataFilter = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            dataGridViewCellStyle3.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.EnableHeadersVisualStyles = false;
            DataGrid.Font = new System.Drawing.Font( "Roboto", 8F );
            DataGrid.GridColor = System.Drawing.Color.FromArgb( 141, 139, 138 );
            DataGrid.HoverText = null;
            DataGrid.Location = new System.Drawing.Point( 11, 19 );
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb( 50, 50, 50 );
            dataGridViewCellStyle4.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            dataGridViewCellStyle5.Font = new System.Drawing.Font( "Roboto", 8F );
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb( 26, 79, 125 );
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new System.Drawing.Size( 880, 496 );
            DataGrid.TabIndex = 0;
            DataGrid.ToolTip = null;
            // 
            // SchemaTabPage
            // 
            SchemaTabPage.Controls.Add( SchemaHeaderPanel );
            SchemaTabPage.Image = null;
            SchemaTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            SchemaTabPage.Location = new System.Drawing.Point( 0, 4 );
            SchemaTabPage.Name = "SchemaTabPage";
            SchemaTabPage.ShowCloseButton = true;
            SchemaTabPage.Size = new System.Drawing.Size( 951, 583 );
            SchemaTabPage.TabIndex = 11;
            SchemaTabPage.ThemesEnabled = false;
            // 
            // SchemaHeaderPanel
            // 
            SchemaHeaderPanel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SchemaHeaderPanel.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SchemaHeaderPanel.CaptionText = "Schema";
            SchemaHeaderPanel.ColumnCount = 3;
            SchemaHeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SchemaHeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 450F ) );
            SchemaHeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 193F ) );
            SchemaHeaderPanel.Controls.Add( SchemaTable, 1, 2 );
            SchemaHeaderPanel.Controls.Add( headerPanel1, 1, 3 );
            SchemaHeaderPanel.Font = new System.Drawing.Font( "Roboto", 9F );
            SchemaHeaderPanel.ForeColor = System.Drawing.Color.DarkGray;
            SchemaHeaderPanel.Location = new System.Drawing.Point( 27, 7 );
            SchemaHeaderPanel.Name = "SchemaHeaderPanel";
            SchemaHeaderPanel.RowCount = 5;
            SchemaHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 3.27868843F ) );
            SchemaHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 96.72131F ) );
            SchemaHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 220F ) );
            SchemaHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 206F ) );
            SchemaHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 12F ) );
            SchemaHeaderPanel.Size = new System.Drawing.Size( 880, 496 );
            SchemaHeaderPanel.TabIndex = 17;
            // 
            // SchemaTable
            // 
            SchemaTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SchemaTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SchemaTable.CaptionText = "Column";
            SchemaTable.ColumnCount = 1;
            SchemaTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SchemaTable.Controls.Add( SchemaPanel, 0, 1 );
            SchemaTable.Font = new System.Drawing.Font( "Roboto", 9F );
            SchemaTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SchemaTable.Location = new System.Drawing.Point( 240, 60 );
            SchemaTable.Name = "SchemaTable";
            SchemaTable.RowCount = 2;
            SchemaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 5.15021467F ) );
            SchemaTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 94.8497849F ) );
            SchemaTable.Size = new System.Drawing.Size( 426, 214 );
            SchemaTable.TabIndex = 16;
            // 
            // SchemaPanel
            // 
            SchemaPanel.BackColor = System.Drawing.Color.Transparent;
            SchemaPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SchemaPanel.BindingSource = null;
            SchemaPanel.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            SchemaPanel.BorderThickness = 1;
            SchemaPanel.Children = null;
            SchemaPanel.Controls.Add( DeleteColumnButton );
            SchemaPanel.Controls.Add( AddColumnButton );
            SchemaPanel.Controls.Add( SelectDataTypeLabel );
            SchemaPanel.Controls.Add( AddColumnLabel );
            SchemaPanel.Controls.Add( AddColumnTextBox );
            SchemaPanel.Controls.Add( DataTypeComboBox );
            SchemaPanel.DataFilter = null;
            SchemaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SchemaPanel.Font = new System.Drawing.Font( "Roboto", 9F );
            SchemaPanel.ForeColor = System.Drawing.Color.Transparent;
            SchemaPanel.HoverText = null;
            SchemaPanel.IsDerivedStyle = true;
            SchemaPanel.Location = new System.Drawing.Point( 3, 29 );
            SchemaPanel.Name = "SchemaPanel";
            SchemaPanel.Padding = new System.Windows.Forms.Padding( 1 );
            SchemaPanel.Size = new System.Drawing.Size( 420, 182 );
            SchemaPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SchemaPanel.StyleManager = null;
            SchemaPanel.TabIndex = 11;
            SchemaPanel.ThemeAuthor = "Terry D. Eppler";
            SchemaPanel.ThemeName = "BudgetExecution";
            SchemaPanel.ToolTip = null;
            // 
            // DeleteColumnButton
            // 
            DeleteColumnButton.BackColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.BindingSource = null;
            DeleteColumnButton.DataFilter = null;
            DeleteColumnButton.DisabledBackColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.DisabledForeColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DeleteColumnButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DeleteColumnButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            DeleteColumnButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            DeleteColumnButton.HoverText = "Delete Data Column";
            DeleteColumnButton.HoverTextColor = System.Drawing.Color.White;
            DeleteColumnButton.IsDerivedStyle = true;
            DeleteColumnButton.Location = new System.Drawing.Point( 305, 37 );
            DeleteColumnButton.Margin = new System.Windows.Forms.Padding( 0 );
            DeleteColumnButton.Name = "DeleteColumnButton";
            DeleteColumnButton.NormalBorderColor = System.Drawing.Color.Transparent;
            DeleteColumnButton.NormalColor = System.Drawing.Color.FromArgb( 27, 27, 27 );
            DeleteColumnButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            DeleteColumnButton.Padding = new System.Windows.Forms.Padding( 1 );
            DeleteColumnButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteColumnButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteColumnButton.PressTextColor = System.Drawing.Color.White;
            DeleteColumnButton.Size = new System.Drawing.Size( 78, 26 );
            DeleteColumnButton.Style = MetroSet_UI.Enums.Style.Custom;
            DeleteColumnButton.StyleManager = null;
            DeleteColumnButton.TabIndex = 19;
            DeleteColumnButton.Text = "Delete";
            DeleteColumnButton.ThemeAuthor = "Terry D. Eppler";
            DeleteColumnButton.ThemeName = "BudgetExecution";
            DeleteColumnButton.ToolTip = null;
            // 
            // AddColumnButton
            // 
            AddColumnButton.BackColor = System.Drawing.Color.Transparent;
            AddColumnButton.BindingSource = null;
            AddColumnButton.DataFilter = null;
            AddColumnButton.DisabledBackColor = System.Drawing.Color.Transparent;
            AddColumnButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddColumnButton.DisabledForeColor = System.Drawing.Color.Transparent;
            AddColumnButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddColumnButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AddColumnButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddColumnButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            AddColumnButton.HoverText = "Add Data Column";
            AddColumnButton.HoverTextColor = System.Drawing.Color.White;
            AddColumnButton.IsDerivedStyle = true;
            AddColumnButton.Location = new System.Drawing.Point( 305, 116 );
            AddColumnButton.Margin = new System.Windows.Forms.Padding( 0 );
            AddColumnButton.Name = "AddColumnButton";
            AddColumnButton.NormalBorderColor = System.Drawing.Color.Transparent;
            AddColumnButton.NormalColor = System.Drawing.Color.FromArgb( 27, 27, 27 );
            AddColumnButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AddColumnButton.Padding = new System.Windows.Forms.Padding( 1 );
            AddColumnButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddColumnButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddColumnButton.PressTextColor = System.Drawing.Color.White;
            AddColumnButton.Size = new System.Drawing.Size( 78, 26 );
            AddColumnButton.Style = MetroSet_UI.Enums.Style.Custom;
            AddColumnButton.StyleManager = null;
            AddColumnButton.TabIndex = 18;
            AddColumnButton.Text = "Add";
            AddColumnButton.ThemeAuthor = "Terry D. Eppler";
            AddColumnButton.ThemeName = "BudgetExecution";
            AddColumnButton.ToolTip = null;
            // 
            // SelectDataTypeLabel
            // 
            SelectDataTypeLabel.BindingSource = null;
            SelectDataTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SelectDataTypeLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            SelectDataTypeLabel.HoverText = null;
            SelectDataTypeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectDataTypeLabel.IsDerivedStyle = true;
            SelectDataTypeLabel.Location = new System.Drawing.Point( 26, 7 );
            SelectDataTypeLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SelectDataTypeLabel.Name = "SelectDataTypeLabel";
            SelectDataTypeLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SelectDataTypeLabel.Size = new System.Drawing.Size( 233, 24 );
            SelectDataTypeLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SelectDataTypeLabel.StyleManager = null;
            SelectDataTypeLabel.TabIndex = 13;
            SelectDataTypeLabel.Text = "Select Data Type";
            SelectDataTypeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectDataTypeLabel.ThemeAuthor = "Terry D. Eppler";
            SelectDataTypeLabel.ThemeName = "Budget Execution";
            SelectDataTypeLabel.ToolTip = null;
            // 
            // AddColumnLabel
            // 
            AddColumnLabel.BindingSource = null;
            AddColumnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddColumnLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            AddColumnLabel.HoverText = null;
            AddColumnLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddColumnLabel.IsDerivedStyle = true;
            AddColumnLabel.Location = new System.Drawing.Point( 26, 83 );
            AddColumnLabel.Margin = new System.Windows.Forms.Padding( 3 );
            AddColumnLabel.Name = "AddColumnLabel";
            AddColumnLabel.Padding = new System.Windows.Forms.Padding( 1 );
            AddColumnLabel.Size = new System.Drawing.Size( 202, 23 );
            AddColumnLabel.Style = MetroSet_UI.Enums.Style.Custom;
            AddColumnLabel.StyleManager = null;
            AddColumnLabel.TabIndex = 12;
            AddColumnLabel.Text = "Enter New Column Name";
            AddColumnLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddColumnLabel.ThemeAuthor = "Terry D. Eppler";
            AddColumnLabel.ThemeName = "Budget Execution";
            AddColumnLabel.ToolTip = null;
            // 
            // AddColumnTextBox
            // 
            AddColumnTextBox.AutoCompleteCustomSource = null;
            AddColumnTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            AddColumnTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            AddColumnTextBox.BindingSource = null;
            AddColumnTextBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            AddColumnTextBox.DataFilter = null;
            AddColumnTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            AddColumnTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddColumnTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            AddColumnTextBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddColumnTextBox.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddColumnTextBox.HoverText = "Enter Column Name";
            AddColumnTextBox.Image = null;
            AddColumnTextBox.IsDerivedStyle = true;
            AddColumnTextBox.Lines = null;
            AddColumnTextBox.Location = new System.Drawing.Point( 26, 112 );
            AddColumnTextBox.MaxLength = 32767;
            AddColumnTextBox.Multiline = false;
            AddColumnTextBox.Name = "AddColumnTextBox";
            AddColumnTextBox.ReadOnly = false;
            AddColumnTextBox.SelectionLength = 0;
            AddColumnTextBox.Size = new System.Drawing.Size( 232, 30 );
            AddColumnTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            AddColumnTextBox.StyleManager = null;
            AddColumnTextBox.TabIndex = 6;
            AddColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            AddColumnTextBox.ThemeAuthor = "Terry D. Eppler";
            AddColumnTextBox.ThemeName = "BudgetExecution";
            AddColumnTextBox.ToolTip = ToolTip;
            AddColumnTextBox.UseSystemPasswordChar = false;
            AddColumnTextBox.WatermarkText = "";
            // 
            // DataTypeComboBox
            // 
            DataTypeComboBox.AllowDrop = true;
            DataTypeComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DataTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            DataTypeComboBox.BindingSource = null;
            DataTypeComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            DataTypeComboBox.CausesValidation = false;
            DataTypeComboBox.DataFilter = null;
            DataTypeComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            DataTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            DataTypeComboBox.DropDownHeight = 100;
            DataTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DataTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DataTypeComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DataTypeComboBox.FormattingEnabled = true;
            DataTypeComboBox.HoverText = null;
            DataTypeComboBox.IntegralHeight = false;
            DataTypeComboBox.IsDerivedStyle = true;
            DataTypeComboBox.ItemHeight = 24;
            DataTypeComboBox.Location = new System.Drawing.Point( 26, 37 );
            DataTypeComboBox.Name = "DataTypeComboBox";
            DataTypeComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DataTypeComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            DataTypeComboBox.Size = new System.Drawing.Size( 232, 30 );
            DataTypeComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            DataTypeComboBox.StyleManager = null;
            DataTypeComboBox.TabIndex = 11;
            DataTypeComboBox.ThemeAuthor = "Terry D. Eppler";
            DataTypeComboBox.ThemeName = "BudgetExecution";
            DataTypeComboBox.ToolTip = ToolTip;
            // 
            // headerPanel1
            // 
            headerPanel1.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            headerPanel1.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            headerPanel1.CaptionText = "Table";
            headerPanel1.ColumnCount = 1;
            headerPanel1.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            headerPanel1.Controls.Add( LayoutPanel, 0, 1 );
            headerPanel1.Font = new System.Drawing.Font( "Roboto", 9F );
            headerPanel1.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            headerPanel1.Location = new System.Drawing.Point( 240, 280 );
            headerPanel1.Name = "headerPanel1";
            headerPanel1.RowCount = 2;
            headerPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 6.179775F ) );
            headerPanel1.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 93.82022F ) );
            headerPanel1.Size = new System.Drawing.Size( 426, 200 );
            headerPanel1.TabIndex = 15;
            // 
            // LayoutPanel
            // 
            LayoutPanel.BackColor = System.Drawing.Color.Transparent;
            LayoutPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            LayoutPanel.BindingSource = null;
            LayoutPanel.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            LayoutPanel.BorderThickness = 1;
            LayoutPanel.Children = null;
            LayoutPanel.Controls.Add( AddTableLabel );
            LayoutPanel.Controls.Add( DeleteTableButton );
            LayoutPanel.Controls.Add( AddTableButton );
            LayoutPanel.Controls.Add( SelectTableLabel );
            LayoutPanel.Controls.Add( TableNameComboBox );
            LayoutPanel.Controls.Add( AddTableTextBox );
            LayoutPanel.DataFilter = null;
            LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            LayoutPanel.Font = new System.Drawing.Font( "Roboto", 9F );
            LayoutPanel.ForeColor = System.Drawing.Color.Transparent;
            LayoutPanel.HoverText = null;
            LayoutPanel.IsDerivedStyle = true;
            LayoutPanel.Location = new System.Drawing.Point( 3, 30 );
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Padding = new System.Windows.Forms.Padding( 1 );
            LayoutPanel.Size = new System.Drawing.Size( 420, 167 );
            LayoutPanel.Style = MetroSet_UI.Enums.Style.Custom;
            LayoutPanel.StyleManager = null;
            LayoutPanel.TabIndex = 10;
            LayoutPanel.ThemeAuthor = "Terry D. Eppler";
            LayoutPanel.ThemeName = "BudgetExecution";
            LayoutPanel.ToolTip = null;
            // 
            // AddTableLabel
            // 
            AddTableLabel.BindingSource = null;
            AddTableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddTableLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            AddTableLabel.HoverText = null;
            AddTableLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddTableLabel.IsDerivedStyle = true;
            AddTableLabel.Location = new System.Drawing.Point( 26, 83 );
            AddTableLabel.Margin = new System.Windows.Forms.Padding( 3 );
            AddTableLabel.Name = "AddTableLabel";
            AddTableLabel.Padding = new System.Windows.Forms.Padding( 1 );
            AddTableLabel.Size = new System.Drawing.Size( 202, 23 );
            AddTableLabel.Style = MetroSet_UI.Enums.Style.Custom;
            AddTableLabel.StyleManager = null;
            AddTableLabel.TabIndex = 18;
            AddTableLabel.Text = "Enter New Table Name";
            AddTableLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            AddTableLabel.ThemeAuthor = "Terry D. Eppler";
            AddTableLabel.ThemeName = "Budget Execution";
            AddTableLabel.ToolTip = null;
            // 
            // DeleteTableButton
            // 
            DeleteTableButton.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            DeleteTableButton.BackColor = System.Drawing.Color.Transparent;
            DeleteTableButton.BindingSource = null;
            DeleteTableButton.DataFilter = null;
            DeleteTableButton.DisabledBackColor = System.Drawing.Color.Transparent;
            DeleteTableButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            DeleteTableButton.DisabledForeColor = System.Drawing.Color.Transparent;
            DeleteTableButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            DeleteTableButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            DeleteTableButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            DeleteTableButton.HoverText = "Delete Data Table";
            DeleteTableButton.HoverTextColor = System.Drawing.Color.White;
            DeleteTableButton.IsDerivedStyle = true;
            DeleteTableButton.Location = new System.Drawing.Point( 287, 35 );
            DeleteTableButton.Margin = new System.Windows.Forms.Padding( 0 );
            DeleteTableButton.Name = "DeleteTableButton";
            DeleteTableButton.NormalBorderColor = System.Drawing.Color.Transparent;
            DeleteTableButton.NormalColor = System.Drawing.Color.Transparent;
            DeleteTableButton.NormalTextColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.Padding = new System.Windows.Forms.Padding( 1 );
            DeleteTableButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            DeleteTableButton.PressTextColor = System.Drawing.Color.White;
            DeleteTableButton.Size = new System.Drawing.Size( 0, 0 );
            DeleteTableButton.Style = MetroSet_UI.Enums.Style.Custom;
            DeleteTableButton.StyleManager = null;
            DeleteTableButton.TabIndex = 17;
            DeleteTableButton.Text = "Delete";
            DeleteTableButton.ThemeAuthor = "Terry D. Eppler";
            DeleteTableButton.ThemeName = "BudgetExecution";
            DeleteTableButton.ToolTip = null;
            // 
            // AddTableButton
            // 
            AddTableButton.BackColor = System.Drawing.Color.Transparent;
            AddTableButton.BindingSource = null;
            AddTableButton.DataFilter = null;
            AddTableButton.DisabledBackColor = System.Drawing.Color.Transparent;
            AddTableButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddTableButton.DisabledForeColor = System.Drawing.Color.Transparent;
            AddTableButton.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddTableButton.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AddTableButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddTableButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            AddTableButton.HoverText = "Add Data Table";
            AddTableButton.HoverTextColor = System.Drawing.Color.White;
            AddTableButton.IsDerivedStyle = true;
            AddTableButton.Location = new System.Drawing.Point( 305, 116 );
            AddTableButton.Margin = new System.Windows.Forms.Padding( 0 );
            AddTableButton.Name = "AddTableButton";
            AddTableButton.NormalBorderColor = System.Drawing.Color.Transparent;
            AddTableButton.NormalColor = System.Drawing.Color.FromArgb( 27, 27, 27 );
            AddTableButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            AddTableButton.Padding = new System.Windows.Forms.Padding( 1 );
            AddTableButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddTableButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AddTableButton.PressTextColor = System.Drawing.Color.White;
            AddTableButton.Size = new System.Drawing.Size( 96, 26 );
            AddTableButton.Style = MetroSet_UI.Enums.Style.Custom;
            AddTableButton.StyleManager = null;
            AddTableButton.TabIndex = 15;
            AddTableButton.Text = "Add/Rename";
            AddTableButton.ThemeAuthor = "Terry D. Eppler";
            AddTableButton.ThemeName = "BudgetExecution";
            AddTableButton.ToolTip = null;
            // 
            // SelectTableLabel
            // 
            SelectTableLabel.BindingSource = null;
            SelectTableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SelectTableLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            SelectTableLabel.HoverText = null;
            SelectTableLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectTableLabel.IsDerivedStyle = true;
            SelectTableLabel.Location = new System.Drawing.Point( 25, 7 );
            SelectTableLabel.Margin = new System.Windows.Forms.Padding( 3 );
            SelectTableLabel.Name = "SelectTableLabel";
            SelectTableLabel.Padding = new System.Windows.Forms.Padding( 1 );
            SelectTableLabel.Size = new System.Drawing.Size( 233, 24 );
            SelectTableLabel.Style = MetroSet_UI.Enums.Style.Custom;
            SelectTableLabel.StyleManager = null;
            SelectTableLabel.TabIndex = 14;
            SelectTableLabel.Text = "Select Data Table";
            SelectTableLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            SelectTableLabel.ThemeAuthor = "Terry D. Eppler";
            SelectTableLabel.ThemeName = "Budget Execution";
            SelectTableLabel.ToolTip = null;
            // 
            // TableNameComboBox
            // 
            TableNameComboBox.AllowDrop = true;
            TableNameComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableNameComboBox.BackColor = System.Drawing.Color.Transparent;
            TableNameComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            TableNameComboBox.BindingSource = null;
            TableNameComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            TableNameComboBox.CausesValidation = false;
            TableNameComboBox.DataFilter = null;
            TableNameComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            TableNameComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            TableNameComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            TableNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            TableNameComboBox.DropDownHeight = 100;
            TableNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            TableNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TableNameComboBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            TableNameComboBox.FormattingEnabled = true;
            TableNameComboBox.HoverText = null;
            TableNameComboBox.IntegralHeight = false;
            TableNameComboBox.IsDerivedStyle = true;
            TableNameComboBox.ItemHeight = 24;
            TableNameComboBox.Location = new System.Drawing.Point( 26, 37 );
            TableNameComboBox.Name = "TableNameComboBox";
            TableNameComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            TableNameComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            TableNameComboBox.Size = new System.Drawing.Size( 232, 30 );
            TableNameComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            TableNameComboBox.StyleManager = null;
            TableNameComboBox.TabIndex = 12;
            TableNameComboBox.ThemeAuthor = "Terry D. Eppler";
            TableNameComboBox.ThemeName = "BudgetExecution";
            TableNameComboBox.ToolTip = ToolTip;
            // 
            // AddTableTextBox
            // 
            AddTableTextBox.AutoCompleteCustomSource = null;
            AddTableTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            AddTableTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            AddTableTextBox.BindingSource = null;
            AddTableTextBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            AddTableTextBox.DataFilter = null;
            AddTableTextBox.DisabledBackColor = System.Drawing.Color.Transparent;
            AddTableTextBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            AddTableTextBox.DisabledForeColor = System.Drawing.Color.Transparent;
            AddTableTextBox.Font = new System.Drawing.Font( "Roboto", 8.25F );
            AddTableTextBox.HoverColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            AddTableTextBox.HoverText = "New Column Name";
            AddTableTextBox.Image = null;
            AddTableTextBox.IsDerivedStyle = true;
            AddTableTextBox.Lines = null;
            AddTableTextBox.Location = new System.Drawing.Point( 26, 112 );
            AddTableTextBox.MaxLength = 32767;
            AddTableTextBox.Multiline = false;
            AddTableTextBox.Name = "AddTableTextBox";
            AddTableTextBox.ReadOnly = false;
            AddTableTextBox.SelectionLength = 0;
            AddTableTextBox.Size = new System.Drawing.Size( 232, 30 );
            AddTableTextBox.Style = MetroSet_UI.Enums.Style.Custom;
            AddTableTextBox.StyleManager = null;
            AddTableTextBox.TabIndex = 7;
            AddTableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            AddTableTextBox.ThemeAuthor = "Terry D. Eppler";
            AddTableTextBox.ThemeName = "Budget Execution";
            AddTableTextBox.ToolTip = ToolTip;
            AddTableTextBox.UseSystemPasswordChar = false;
            AddTableTextBox.WatermarkText = "";
            // 
            // BusyTabPage
            // 
            BusyTabPage.Controls.Add( BusyHeaderPanel );
            BusyTabPage.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BusyTabPage.Image = null;
            BusyTabPage.ImageSize = new System.Drawing.Size( 16, 16 );
            BusyTabPage.Location = new System.Drawing.Point( 0, 4 );
            BusyTabPage.Name = "BusyTabPage";
            BusyTabPage.ShowCloseButton = false;
            BusyTabPage.Size = new System.Drawing.Size( 951, 583 );
            BusyTabPage.TabBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BusyTabPage.TabForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BusyTabPage.TabIndex = 12;
            BusyTabPage.ThemesEnabled = false;
            // 
            // BusyHeaderPanel
            // 
            BusyHeaderPanel.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BusyHeaderPanel.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            BusyHeaderPanel.CaptionText = "Busy...";
            BusyHeaderPanel.ColumnCount = 1;
            BusyHeaderPanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            BusyHeaderPanel.Controls.Add( BusyPanel, 0, 1 );
            BusyHeaderPanel.Font = new System.Drawing.Font( "Roboto", 9F );
            BusyHeaderPanel.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BusyHeaderPanel.Location = new System.Drawing.Point( 21, 4 );
            BusyHeaderPanel.Name = "BusyHeaderPanel";
            BusyHeaderPanel.RowCount = 2;
            BusyHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.4678899F ) );
            BusyHeaderPanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.53211F ) );
            BusyHeaderPanel.Size = new System.Drawing.Size( 908, 561 );
            BusyHeaderPanel.TabIndex = 40;
            // 
            // BusyPanel
            // 
            BusyPanel.BackColor = System.Drawing.Color.Transparent;
            BusyPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BusyPanel.BindingSource = null;
            BusyPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            BusyPanel.BorderThickness = 1;
            BusyPanel.Children = null;
            BusyPanel.Controls.Add( Loader );
            BusyPanel.DataFilter = null;
            BusyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            BusyPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            BusyPanel.ForeColor = System.Drawing.Color.Transparent;
            BusyPanel.HoverText = null;
            BusyPanel.IsDerivedStyle = true;
            BusyPanel.Location = new System.Drawing.Point( 3, 27 );
            BusyPanel.Name = "BusyPanel";
            BusyPanel.Padding = new System.Windows.Forms.Padding( 1 );
            BusyPanel.Size = new System.Drawing.Size( 902, 531 );
            BusyPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BusyPanel.StyleManager = null;
            BusyPanel.TabIndex = 47;
            BusyPanel.ThemeAuthor = "Terry D. Eppler";
            BusyPanel.ThemeName = "Budget Execution";
            BusyPanel.ToolTip = ToolTip;
            // 
            // Loader
            // 
            Loader.Image = Resources.Images.Loading;
            Loader.Location = new System.Drawing.Point( 43, 25 );
            Loader.Name = "Loader";
            Loader.Size = new System.Drawing.Size( 820, 489 );
            Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Loader.TabIndex = 0;
            Loader.TabStop = false;
            // 
            // SqlCommandTable
            // 
            SqlCommandTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SqlCommandTable.ColumnCount = 1;
            SqlCommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            SqlCommandTable.Controls.Add( ProviderTable, 0, 0 );
            SqlCommandTable.Controls.Add( CommandTable, 0, 1 );
            SqlCommandTable.Controls.Add( SqlStatementTable, 0, 2 );
            SqlCommandTable.Location = new System.Drawing.Point( 952, 58 );
            SqlCommandTable.Name = "SqlCommandTable";
            SqlCommandTable.RowCount = 3;
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 123F ) );
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 326F ) );
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            SqlCommandTable.Size = new System.Drawing.Size( 358, 561 );
            SqlCommandTable.TabIndex = 4;
            // 
            // ProviderTable
            // 
            ProviderTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ProviderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ProviderTable.CaptionText = "Databases";
            ProviderTable.ColumnCount = 1;
            ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ProviderTable.Controls.Add( SecondPanel, 0, 1 );
            ProviderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ProviderTable.Font = new System.Drawing.Font( "Roboto", 9F );
            ProviderTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ProviderTable.Location = new System.Drawing.Point( 3, 3 );
            ProviderTable.Name = "ProviderTable";
            ProviderTable.RowCount = 2;
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 9.523809F ) );
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90.47619F ) );
            ProviderTable.Size = new System.Drawing.Size( 352, 106 );
            ProviderTable.TabIndex = 5;
            // 
            // SecondPanel
            // 
            SecondPanel.BackColor = System.Drawing.Color.Transparent;
            SecondPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SecondPanel.BindingSource = null;
            SecondPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            SecondPanel.BorderThickness = 1;
            SecondPanel.Children = null;
            SecondPanel.Controls.Add( SqlServerRadioButton );
            SecondPanel.Controls.Add( AccessRadioButton );
            SecondPanel.Controls.Add( SQLiteRadioButton );
            SecondPanel.Controls.Add( SqlCeRadioButton );
            SecondPanel.DataFilter = null;
            SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            SecondPanel.ForeColor = System.Drawing.Color.Transparent;
            SecondPanel.HoverText = null;
            SecondPanel.IsDerivedStyle = true;
            SecondPanel.Location = new System.Drawing.Point( 3, 27 );
            SecondPanel.Name = "SecondPanel";
            SecondPanel.Padding = new System.Windows.Forms.Padding( 1 );
            SecondPanel.Size = new System.Drawing.Size( 346, 76 );
            SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondPanel.StyleManager = null;
            SecondPanel.TabIndex = 3;
            SecondPanel.ThemeAuthor = "Terry D. Eppler";
            SecondPanel.ThemeName = "Budget Execution";
            SecondPanel.ToolTip = null;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlServerRadioButton.Group = 0;
            SqlServerRadioButton.HoverText = null;
            SqlServerRadioButton.IsDerivedStyle = true;
            SqlServerRadioButton.Location = new System.Drawing.Point( 255, 29 );
            SqlServerRadioButton.Name = "SqlServerRadioButton";
            SqlServerRadioButton.Padding = new System.Windows.Forms.Padding( 3 );
            SqlServerRadioButton.Result = null;
            SqlServerRadioButton.Size = new System.Drawing.Size( 81, 17 );
            SqlServerRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlServerRadioButton.StyleManager = null;
            SqlServerRadioButton.TabIndex = 2;
            SqlServerRadioButton.Tag = "SqlServer";
            SqlServerRadioButton.Text = "SQL Server";
            SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlServerRadioButton.ThemeName = "Budget Execution";
            SqlServerRadioButton.ToolTip = null;
            // 
            // AccessRadioButton
            // 
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            AccessRadioButton.Group = 0;
            AccessRadioButton.HoverText = null;
            AccessRadioButton.IsDerivedStyle = true;
            AccessRadioButton.Location = new System.Drawing.Point( 14, 29 );
            AccessRadioButton.Name = "AccessRadioButton";
            AccessRadioButton.Padding = new System.Windows.Forms.Padding( 3 );
            AccessRadioButton.Result = null;
            AccessRadioButton.Size = new System.Drawing.Size( 64, 17 );
            AccessRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            AccessRadioButton.StyleManager = null;
            AccessRadioButton.TabIndex = 0;
            AccessRadioButton.Tag = "Access";
            AccessRadioButton.Text = "Access";
            AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
            AccessRadioButton.ThemeName = "Budget Execution";
            AccessRadioButton.ToolTip = null;
            // 
            // SQLiteRadioButton
            // 
            SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SQLiteRadioButton.Checked = false;
            SQLiteRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SQLiteRadioButton.Group = 0;
            SQLiteRadioButton.HoverText = null;
            SQLiteRadioButton.IsDerivedStyle = true;
            SQLiteRadioButton.Location = new System.Drawing.Point( 84, 29 );
            SQLiteRadioButton.Name = "SQLiteRadioButton";
            SQLiteRadioButton.Padding = new System.Windows.Forms.Padding( 3 );
            SQLiteRadioButton.Result = null;
            SQLiteRadioButton.Size = new System.Drawing.Size( 64, 17 );
            SQLiteRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SQLiteRadioButton.StyleManager = null;
            SQLiteRadioButton.TabIndex = 1;
            SQLiteRadioButton.Tag = "SQLite";
            SQLiteRadioButton.Text = "SQLite";
            SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
            SQLiteRadioButton.ThemeName = "Budget Execution";
            SQLiteRadioButton.ToolTip = null;
            // 
            // SqlCeRadioButton
            // 
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F );
            SqlCeRadioButton.Group = 0;
            SqlCeRadioButton.HoverText = null;
            SqlCeRadioButton.IsDerivedStyle = true;
            SqlCeRadioButton.Location = new System.Drawing.Point( 154, 29 );
            SqlCeRadioButton.Name = "SqlCeRadioButton";
            SqlCeRadioButton.Padding = new System.Windows.Forms.Padding( 3 );
            SqlCeRadioButton.Result = null;
            SqlCeRadioButton.Size = new System.Drawing.Size( 95, 17 );
            SqlCeRadioButton.Style = MetroSet_UI.Enums.Style.Custom;
            SqlCeRadioButton.StyleManager = null;
            SqlCeRadioButton.TabIndex = 1;
            SqlCeRadioButton.Tag = "SqlCe";
            SqlCeRadioButton.Text = "SQL Compact";
            SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
            SqlCeRadioButton.ThemeName = "Budget Execution";
            SqlCeRadioButton.ToolTip = null;
            // 
            // CommandTable
            // 
            CommandTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CommandTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            CommandTable.CaptionText = "Commands";
            CommandTable.ColumnCount = 1;
            CommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            CommandTable.Controls.Add( CommandPanel, 0, 1 );
            CommandTable.Dock = System.Windows.Forms.DockStyle.Fill;
            CommandTable.Font = new System.Drawing.Font( "Roboto", 9F );
            CommandTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CommandTable.Location = new System.Drawing.Point( 3, 115 );
            CommandTable.Name = "CommandTable";
            CommandTable.RowCount = 2;
            CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 7.03125F ) );
            CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 92.96875F ) );
            CommandTable.Size = new System.Drawing.Size( 352, 117 );
            CommandTable.TabIndex = 1;
            // 
            // CommandPanel
            // 
            CommandPanel.BackColor = System.Drawing.Color.Transparent;
            CommandPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CommandPanel.BindingSource = null;
            CommandPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            CommandPanel.BorderThickness = 1;
            CommandPanel.Children = null;
            CommandPanel.Controls.Add( CommandComboBox );
            CommandPanel.DataFilter = null;
            CommandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CommandPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            CommandPanel.ForeColor = System.Drawing.Color.Transparent;
            CommandPanel.HoverText = null;
            CommandPanel.IsDerivedStyle = true;
            CommandPanel.Location = new System.Drawing.Point( 3, 26 );
            CommandPanel.Name = "CommandPanel";
            CommandPanel.Padding = new System.Windows.Forms.Padding( 1 );
            CommandPanel.Size = new System.Drawing.Size( 346, 88 );
            CommandPanel.Style = MetroSet_UI.Enums.Style.Custom;
            CommandPanel.StyleManager = null;
            CommandPanel.TabIndex = 2;
            CommandPanel.ThemeAuthor = "Terry D. Eppler";
            CommandPanel.ThemeName = "Budget Execution";
            CommandPanel.ToolTip = null;
            // 
            // CommandComboBox
            // 
            CommandComboBox.AllowDrop = true;
            CommandComboBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            CommandComboBox.ArrowColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CommandComboBox.BackColor = System.Drawing.Color.Transparent;
            CommandComboBox.BackgroundColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            CommandComboBox.BindingSource = null;
            CommandComboBox.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            CommandComboBox.CausesValidation = false;
            CommandComboBox.DataFilter = null;
            CommandComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            CommandComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            CommandComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            CommandComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            CommandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CommandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CommandComboBox.Font = new System.Drawing.Font( "Roboto", 8F );
            CommandComboBox.FormattingEnabled = true;
            CommandComboBox.HoverText = null;
            CommandComboBox.IsDerivedStyle = true;
            CommandComboBox.ItemHeight = 24;
            CommandComboBox.Location = new System.Drawing.Point( 32, 28 );
            CommandComboBox.Name = "CommandComboBox";
            CommandComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CommandComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            CommandComboBox.Size = new System.Drawing.Size( 290, 30 );
            CommandComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            CommandComboBox.StyleManager = null;
            CommandComboBox.TabIndex = 0;
            CommandComboBox.ThemeAuthor = "Terry D. Eppler";
            CommandComboBox.ThemeName = "Budget Execution";
            CommandComboBox.ToolTip = null;
            // 
            // SqlStatementTable
            // 
            SqlStatementTable.BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            SqlStatementTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SqlStatementTable.CaptionText = "SQL Statements";
            SqlStatementTable.ColumnCount = 1;
            SqlStatementTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SqlStatementTable.Controls.Add( TextPanel, 0, 1 );
            SqlStatementTable.Dock = System.Windows.Forms.DockStyle.Fill;
            SqlStatementTable.Font = new System.Drawing.Font( "Roboto", 9F );
            SqlStatementTable.ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SqlStatementTable.Location = new System.Drawing.Point( 3, 238 );
            SqlStatementTable.Name = "SqlStatementTable";
            SqlStatementTable.RowCount = 2;
            SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.631579F ) );
            SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.36842F ) );
            SqlStatementTable.Size = new System.Drawing.Size( 352, 320 );
            SqlStatementTable.TabIndex = 1;
            // 
            // TextPanel
            // 
            TextPanel.BackColor = System.Drawing.Color.Transparent;
            TextPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TextPanel.BindingSource = null;
            TextPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            TextPanel.BorderThickness = 1;
            TextPanel.Children = null;
            TextPanel.Controls.Add( QueryListBox );
            TextPanel.DataFilter = null;
            TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TextPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            TextPanel.ForeColor = System.Drawing.Color.Transparent;
            TextPanel.HoverText = null;
            TextPanel.IsDerivedStyle = true;
            TextPanel.Location = new System.Drawing.Point( 3, 27 );
            TextPanel.Name = "TextPanel";
            TextPanel.Padding = new System.Windows.Forms.Padding( 1 );
            TextPanel.Size = new System.Drawing.Size( 346, 290 );
            TextPanel.Style = MetroSet_UI.Enums.Style.Custom;
            TextPanel.StyleManager = null;
            TextPanel.TabIndex = 1;
            TextPanel.ThemeAuthor = "Terry D. Eppler";
            TextPanel.ThemeName = "Budget Execution";
            TextPanel.ToolTip = null;
            // 
            // QueryListBox
            // 
            QueryListBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            QueryListBox.BackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            QueryListBox.BindingSource = null;
            QueryListBox.BorderColor = System.Drawing.Color.FromArgb( 55, 55, 55 );
            QueryListBox.DataFilter = null;
            QueryListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            QueryListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            QueryListBox.Font = new System.Drawing.Font( "Roboto", 8F );
            QueryListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            QueryListBox.HoveredItemColor = System.Drawing.Color.White;
            QueryListBox.HoverText = null;
            QueryListBox.IsDerivedStyle = true;
            QueryListBox.ItemHeight = 28;
            QueryListBox.Location = new System.Drawing.Point( 25, 17 );
            QueryListBox.Margin = new System.Windows.Forms.Padding( 1 );
            QueryListBox.MultiSelect = true;
            QueryListBox.Name = "QueryListBox";
            QueryListBox.Padding = new System.Windows.Forms.Padding( 1 );
            QueryListBox.SelectedIndex = -1;
            QueryListBox.SelectedItem = null;
            QueryListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            QueryListBox.SelectedItemColor = System.Drawing.Color.White;
            QueryListBox.SelectedText = null;
            QueryListBox.SelectedValue = null;
            QueryListBox.ShowBorder = false;
            QueryListBox.ShowScrollBar = false;
            QueryListBox.Size = new System.Drawing.Size( 297, 256 );
            QueryListBox.Style = MetroSet_UI.Enums.Style.Custom;
            QueryListBox.StyleManager = null;
            QueryListBox.TabIndex = 0;
            QueryListBox.ThemeAuthor = "Terry D. Eppler";
            QueryListBox.ThemeName = "Budget Execution";
            QueryListBox.ToolTip = null;
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
            ToolStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] { CloseButton, Separator1, StatusLabel, NavigationSpaceLabel, Separator2, FirstButton, Separator3, PreviousButton, Separator4, NextButton, Separator5, LastButton, Separator6, DataLabel, Separator7, GoButton, Separator8, RefreshButton, Separator9, EditSqlButton, Separator11, EditDataButton, Separator12, TableButton, TableSeparator, LookupButton, Separator13, SaveButton, Separator14, FileSystemLabel, Separator15, ClientButton, ClientSeparator, BrowserButton, Separator16, Separator17, MainMenuButton, Separator33, ApplicationLabel } );
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
            ToolStrip.Size = new System.Drawing.Size( 1331, 43 );
            ToolStrip.TabIndex = 14;
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
            CloseButton.HoverText = "Close Application";
            CloseButton.Image = Resources.Images.WebCloseButton;
            CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            CloseButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            CloseButton.Name = "CloseButton";
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.Size = new System.Drawing.Size( 23, 25 );
            CloseButton.Text = "toolStripButton1";
            CloseButton.ToolTip = ToolTip;
            CloseButton.ToolType = ToolType.ExitButton;
            // 
            // Separator1
            // 
            Separator1.ForeColor = System.Drawing.Color.Black;
            Separator1.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
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
            StatusLabel.Size = new System.Drawing.Size( 82, 25 );
            StatusLabel.Tag = "";
            StatusLabel.Text = "        Date And Time";
            StatusLabel.ToolTip = null;
            // 
            // NavigationSpaceLabel
            // 
            NavigationSpaceLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            NavigationSpaceLabel.BindingSource = null;
            NavigationSpaceLabel.DataFilter = null;
            NavigationSpaceLabel.Field = Field.AccountCode;
            NavigationSpaceLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            NavigationSpaceLabel.ForeColor = System.Drawing.Color.Black;
            NavigationSpaceLabel.HoverText = null;
            NavigationSpaceLabel.Margin = new System.Windows.Forms.Padding( 1 );
            NavigationSpaceLabel.Name = "NavigationSpaceLabel";
            NavigationSpaceLabel.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NavigationSpaceLabel.Size = new System.Drawing.Size( 91, 25 );
            NavigationSpaceLabel.Tag = "";
            NavigationSpaceLabel.Text = "                 Navigation";
            NavigationSpaceLabel.ToolTip = null;
            // 
            // Separator2
            // 
            Separator2.ForeColor = System.Drawing.Color.Black;
            Separator2.Margin = new System.Windows.Forms.Padding( 1 );
            Separator2.Name = "Separator2";
            Separator2.Padding = new System.Windows.Forms.Padding( 1 );
            Separator2.Size = new System.Drawing.Size( 6, 25 );
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
            FirstButton.HoverText = "Move First";
            FirstButton.Image = Resources.Images.FirstButton;
            FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            FirstButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Name = "FirstButton";
            FirstButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstButton.Size = new System.Drawing.Size( 30, 25 );
            FirstButton.Text = "toolStripButton1";
            FirstButton.ToolTip = ToolTip;
            FirstButton.ToolType = ToolType.FirstButton;
            // 
            // Separator3
            // 
            Separator3.ForeColor = System.Drawing.Color.Black;
            Separator3.Margin = new System.Windows.Forms.Padding( 1 );
            Separator3.Name = "Separator3";
            Separator3.Padding = new System.Windows.Forms.Padding( 1 );
            Separator3.Size = new System.Drawing.Size( 6, 25 );
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
            PreviousButton.HoverText = "Move Previous";
            PreviousButton.Image = Resources.Images.WebPreviousButton;
            PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            PreviousButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            PreviousButton.Size = new System.Drawing.Size( 30, 25 );
            PreviousButton.Text = "toolStripButton1";
            PreviousButton.ToolTip = ToolTip;
            PreviousButton.ToolType = ToolType.PreviousButton;
            // 
            // Separator4
            // 
            Separator4.ForeColor = System.Drawing.Color.Black;
            Separator4.Margin = new System.Windows.Forms.Padding( 1 );
            Separator4.Name = "Separator4";
            Separator4.Padding = new System.Windows.Forms.Padding( 1 );
            Separator4.Size = new System.Drawing.Size( 6, 25 );
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
            NextButton.HoverText = "Move Next";
            NextButton.Image = Resources.Images.WebNextButton;
            NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            NextButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Name = "NextButton";
            NextButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            NextButton.Size = new System.Drawing.Size( 30, 25 );
            NextButton.Text = "toolStripButton1";
            NextButton.ToolTip = ToolTip;
            NextButton.ToolType = ToolType.NextButton;
            // 
            // Separator5
            // 
            Separator5.ForeColor = System.Drawing.Color.Black;
            Separator5.Margin = new System.Windows.Forms.Padding( 1 );
            Separator5.Name = "Separator5";
            Separator5.Padding = new System.Windows.Forms.Padding( 1 );
            Separator5.Size = new System.Drawing.Size( 6, 25 );
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
            LastButton.HoverText = "Move Last";
            LastButton.Image = Resources.Images.LastButton;
            LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LastButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Name = "LastButton";
            LastButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LastButton.Size = new System.Drawing.Size( 30, 25 );
            LastButton.Text = "toolStripButton1";
            LastButton.ToolTip = null;
            LastButton.ToolType = ToolType.LastButton;
            // 
            // Separator6
            // 
            Separator6.ForeColor = System.Drawing.Color.Black;
            Separator6.Margin = new System.Windows.Forms.Padding( 1 );
            Separator6.Name = "Separator6";
            Separator6.Padding = new System.Windows.Forms.Padding( 1 );
            Separator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // DataLabel
            // 
            DataLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            DataLabel.BindingSource = null;
            DataLabel.DataFilter = null;
            DataLabel.Field = Field.AccountCode;
            DataLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            DataLabel.ForeColor = System.Drawing.Color.Black;
            DataLabel.HoverText = null;
            DataLabel.Margin = new System.Windows.Forms.Padding( 1 );
            DataLabel.Name = "DataLabel";
            DataLabel.Padding = new System.Windows.Forms.Padding( 1 );
            DataLabel.Size = new System.Drawing.Size( 76, 25 );
            DataLabel.Tag = "";
            DataLabel.Text = "                        Data ";
            DataLabel.ToolTip = null;
            // 
            // Separator7
            // 
            Separator7.ForeColor = System.Drawing.Color.Black;
            Separator7.Margin = new System.Windows.Forms.Padding( 1 );
            Separator7.Name = "Separator7";
            Separator7.Padding = new System.Windows.Forms.Padding( 1 );
            Separator7.Size = new System.Drawing.Size( 6, 25 );
            // 
            // GoButton
            // 
            GoButton.AutoToolTip = false;
            GoButton.BackColor = System.Drawing.Color.Transparent;
            GoButton.BindingSource = BindingSource;
            GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            GoButton.Field = Field.AccountCode;
            GoButton.Filter = null;
            GoButton.Font = new System.Drawing.Font( "Roboto", 9F );
            GoButton.ForeColor = System.Drawing.Color.LightGray;
            GoButton.HoverText = "Execute Query";
            GoButton.Image = Resources.Images.GoButton;
            GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            GoButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            GoButton.Name = "GoButton";
            GoButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            GoButton.Size = new System.Drawing.Size( 30, 25 );
            GoButton.Text = "toolStripButton1";
            GoButton.ToolTip = ToolTip;
            GoButton.ToolType = ToolType.GoButton;
            // 
            // Separator8
            // 
            Separator8.ForeColor = System.Drawing.Color.Black;
            Separator8.Margin = new System.Windows.Forms.Padding( 1 );
            Separator8.Name = "Separator8";
            Separator8.Padding = new System.Windows.Forms.Padding( 1 );
            Separator8.Size = new System.Drawing.Size( 6, 25 );
            // 
            // RefreshButton
            // 
            RefreshButton.AutoToolTip = false;
            RefreshButton.BackColor = System.Drawing.Color.Transparent;
            RefreshButton.BindingSource = BindingSource;
            RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            RefreshButton.Field = Field.AccountCode;
            RefreshButton.Filter = null;
            RefreshButton.Font = new System.Drawing.Font( "Roboto", 9F );
            RefreshButton.ForeColor = System.Drawing.Color.LightGray;
            RefreshButton.HoverText = "Refresh Data";
            RefreshButton.Image = Resources.Images.RefreshButton;
            RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            RefreshButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            RefreshButton.Size = new System.Drawing.Size( 30, 25 );
            RefreshButton.Text = "toolStripButton1";
            RefreshButton.ToolTip = ToolTip;
            RefreshButton.ToolType = ToolType.RefreshButton;
            // 
            // Separator9
            // 
            Separator9.ForeColor = System.Drawing.Color.Black;
            Separator9.Margin = new System.Windows.Forms.Padding( 1 );
            Separator9.Name = "Separator9";
            Separator9.Padding = new System.Windows.Forms.Padding( 1 );
            Separator9.Size = new System.Drawing.Size( 6, 25 );
            // 
            // EditSqlButton
            // 
            EditSqlButton.AutoToolTip = false;
            EditSqlButton.BackColor = System.Drawing.Color.Transparent;
            EditSqlButton.BindingSource = BindingSource;
            EditSqlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            EditSqlButton.Field = Field.AccountCode;
            EditSqlButton.Filter = null;
            EditSqlButton.Font = new System.Drawing.Font( "Roboto", 9F );
            EditSqlButton.ForeColor = System.Drawing.Color.LightGray;
            EditSqlButton.HoverText = "SQL Ecitor";
            EditSqlButton.Image = Resources.Images.EditSqlButton;
            EditSqlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditSqlButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            EditSqlButton.Name = "EditSqlButton";
            EditSqlButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            EditSqlButton.Size = new System.Drawing.Size( 30, 25 );
            EditSqlButton.Text = "toolStripButton1";
            EditSqlButton.ToolTip = ToolTip;
            EditSqlButton.ToolType = ToolType.EditSqlButton;
            // 
            // Separator11
            // 
            Separator11.ForeColor = System.Drawing.Color.Black;
            Separator11.Margin = new System.Windows.Forms.Padding( 1 );
            Separator11.Name = "Separator11";
            Separator11.Padding = new System.Windows.Forms.Padding( 1 );
            Separator11.Size = new System.Drawing.Size( 6, 25 );
            // 
            // EditDataButton
            // 
            EditDataButton.AutoToolTip = false;
            EditDataButton.BackColor = System.Drawing.Color.Transparent;
            EditDataButton.BindingSource = BindingSource;
            EditDataButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            EditDataButton.Field = Field.AccountCode;
            EditDataButton.Filter = null;
            EditDataButton.Font = new System.Drawing.Font( "Roboto", 9F );
            EditDataButton.ForeColor = System.Drawing.Color.LightGray;
            EditDataButton.HoverText = "Edit Data";
            EditDataButton.Image = Resources.Images.EditButton;
            EditDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditDataButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            EditDataButton.Name = "EditDataButton";
            EditDataButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            EditDataButton.Size = new System.Drawing.Size( 30, 25 );
            EditDataButton.Text = "toolStripButton1";
            EditDataButton.ToolTip = ToolTip;
            EditDataButton.ToolType = ToolType.ExcelButton;
            // 
            // Separator12
            // 
            Separator12.ForeColor = System.Drawing.Color.Black;
            Separator12.Margin = new System.Windows.Forms.Padding( 1 );
            Separator12.Name = "Separator12";
            Separator12.Padding = new System.Windows.Forms.Padding( 1 );
            Separator12.Size = new System.Drawing.Size( 6, 25 );
            // 
            // TableButton
            // 
            TableButton.AutoToolTip = false;
            TableButton.BackColor = System.Drawing.Color.Transparent;
            TableButton.BindingSource = BindingSource;
            TableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            TableButton.Field = Field.AccountCode;
            TableButton.Filter = null;
            TableButton.Font = new System.Drawing.Font( "Roboto", 9F );
            TableButton.ForeColor = System.Drawing.Color.LightGray;
            TableButton.HoverText = "View Data Table";
            TableButton.Image = Resources.Images.TableButton;
            TableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            TableButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            TableButton.Name = "TableButton";
            TableButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            TableButton.Size = new System.Drawing.Size( 30, 25 );
            TableButton.Text = "toolStripButton1";
            TableButton.ToolTip = ToolTip;
            TableButton.ToolType = ToolType.TableButton;
            // 
            // TableSeparator
            // 
            TableSeparator.ForeColor = System.Drawing.Color.Black;
            TableSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            TableSeparator.Name = "TableSeparator";
            TableSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            TableSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // LookupButton
            // 
            LookupButton.AutoToolTip = false;
            LookupButton.BackColor = System.Drawing.Color.Transparent;
            LookupButton.BindingSource = BindingSource;
            LookupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LookupButton.Field = Field.AccountCode;
            LookupButton.Filter = null;
            LookupButton.Font = new System.Drawing.Font( "Roboto", 9F );
            LookupButton.ForeColor = System.Drawing.Color.LightGray;
            LookupButton.HoverText = "Reset Data Source";
            LookupButton.Image = Resources.Images.DataSearchButton;
            LookupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            LookupButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LookupButton.Name = "LookupButton";
            LookupButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            LookupButton.Size = new System.Drawing.Size( 30, 25 );
            LookupButton.Text = "toolStripButton1";
            LookupButton.ToolTip = ToolTip;
            LookupButton.ToolType = ToolType.LookupButton;
            // 
            // Separator13
            // 
            Separator13.ForeColor = System.Drawing.Color.Black;
            Separator13.Margin = new System.Windows.Forms.Padding( 1 );
            Separator13.Name = "Separator13";
            Separator13.Padding = new System.Windows.Forms.Padding( 1 );
            Separator13.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SaveButton
            // 
            SaveButton.AutoToolTip = false;
            SaveButton.BackColor = System.Drawing.Color.Transparent;
            SaveButton.BindingSource = BindingSource;
            SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveButton.Field = Field.AccountCode;
            SaveButton.Filter = null;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SaveButton.ForeColor = System.Drawing.Color.LightGray;
            SaveButton.HoverText = "Save Changes";
            SaveButton.Image = Resources.Images.SaveButton;
            SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Name = "SaveButton";
            SaveButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            SaveButton.Size = new System.Drawing.Size( 30, 25 );
            SaveButton.Text = "toolStripButton1";
            SaveButton.ToolTip = ToolTip;
            SaveButton.ToolType = ToolType.SaveButton;
            // 
            // Separator14
            // 
            Separator14.ForeColor = System.Drawing.Color.Black;
            Separator14.Margin = new System.Windows.Forms.Padding( 1 );
            Separator14.Name = "Separator14";
            Separator14.Padding = new System.Windows.Forms.Padding( 1 );
            Separator14.Size = new System.Drawing.Size( 6, 25 );
            // 
            // FileSystemLabel
            // 
            FileSystemLabel.BackColor = System.Drawing.Color.FromArgb( 45, 45, 45 );
            FileSystemLabel.BindingSource = null;
            FileSystemLabel.DataFilter = null;
            FileSystemLabel.Field = Field.AccountCode;
            FileSystemLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            FileSystemLabel.ForeColor = System.Drawing.Color.Black;
            FileSystemLabel.HoverText = null;
            FileSystemLabel.Margin = new System.Windows.Forms.Padding( 1 );
            FileSystemLabel.Name = "FileSystemLabel";
            FileSystemLabel.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FileSystemLabel.Size = new System.Drawing.Size( 87, 25 );
            FileSystemLabel.Tag = "";
            FileSystemLabel.Text = "                    File Sys:";
            FileSystemLabel.ToolTip = null;
            // 
            // Separator15
            // 
            Separator15.ForeColor = System.Drawing.Color.Black;
            Separator15.Margin = new System.Windows.Forms.Padding( 1 );
            Separator15.Name = "Separator15";
            Separator15.Padding = new System.Windows.Forms.Padding( 1 );
            Separator15.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ClientButton
            // 
            ClientButton.AutoToolTip = false;
            ClientButton.BackColor = System.Drawing.Color.Transparent;
            ClientButton.BindingSource = BindingSource;
            ClientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ClientButton.Field = Field.AccountCode;
            ClientButton.Filter = null;
            ClientButton.Font = new System.Drawing.Font( "Roboto", 9F );
            ClientButton.ForeColor = System.Drawing.Color.LightGray;
            ClientButton.HoverText = "External Client";
            ClientButton.Image = Resources.Images.ClientButton;
            ClientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ClientButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ClientButton.Name = "ClientButton";
            ClientButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            ClientButton.Size = new System.Drawing.Size( 30, 25 );
            ClientButton.Text = "toolStripButton1";
            ClientButton.ToolTip = ToolTip;
            ClientButton.ToolType = ToolType.NS;
            // 
            // ClientSeparator
            // 
            ClientSeparator.ForeColor = System.Drawing.Color.Black;
            ClientSeparator.Margin = new System.Windows.Forms.Padding( 1 );
            ClientSeparator.Name = "ClientSeparator";
            ClientSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            ClientSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // BrowserButton
            // 
            BrowserButton.AutoToolTip = false;
            BrowserButton.BackColor = System.Drawing.Color.Transparent;
            BrowserButton.BindingSource = BindingSource;
            BrowserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BrowserButton.Field = Field.AccountCode;
            BrowserButton.Filter = null;
            BrowserButton.Font = new System.Drawing.Font( "Roboto", 9F );
            BrowserButton.ForeColor = System.Drawing.Color.LightGray;
            BrowserButton.HoverText = "Browse File System";
            BrowserButton.Image = Resources.Images.BrowseButton;
            BrowserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            BrowserButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowserButton.Name = "BrowserButton";
            BrowserButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            BrowserButton.Size = new System.Drawing.Size( 30, 25 );
            BrowserButton.Text = "toolStripButton1";
            BrowserButton.ToolTip = ToolTip;
            BrowserButton.ToolType = ToolType.BrowseButton;
            // 
            // Separator16
            // 
            Separator16.ForeColor = System.Drawing.Color.Black;
            Separator16.Margin = new System.Windows.Forms.Padding( 1 );
            Separator16.Name = "Separator16";
            Separator16.Padding = new System.Windows.Forms.Padding( 1 );
            Separator16.Size = new System.Drawing.Size( 6, 25 );
            // 
            // Separator17
            // 
            Separator17.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator17.ForeColor = System.Drawing.Color.Black;
            Separator17.Margin = new System.Windows.Forms.Padding( 1 );
            Separator17.Name = "Separator17";
            Separator17.Padding = new System.Windows.Forms.Padding( 1 );
            Separator17.Size = new System.Drawing.Size( 6, 25 );
            // 
            // MainMenuButton
            // 
            MainMenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MainMenuButton.AutoToolTip = false;
            MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            MainMenuButton.BindingSource = BindingSource;
            MainMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MainMenuButton.Field = Field.AccountCode;
            MainMenuButton.Filter = null;
            MainMenuButton.Font = new System.Drawing.Font( "Roboto", 9F );
            MainMenuButton.ForeColor = System.Drawing.Color.LightGray;
            MainMenuButton.HoverText = "Main Menu";
            MainMenuButton.Image = Resources.Images.WebMenuButton;
            MainMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            MainMenuButton.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MainMenuButton.Name = "MainMenuButton";
            MainMenuButton.Padding = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            MainMenuButton.Size = new System.Drawing.Size( 30, 25 );
            MainMenuButton.Text = "toolStripButton1";
            MainMenuButton.ToolTip = ToolTip;
            MainMenuButton.ToolType = ToolType.MenuButton;
            // 
            // Separator33
            // 
            Separator33.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            Separator33.ForeColor = System.Drawing.Color.Black;
            Separator33.Margin = new System.Windows.Forms.Padding( 1 );
            Separator33.Name = "Separator33";
            Separator33.Padding = new System.Windows.Forms.Padding( 1 );
            Separator33.Size = new System.Drawing.Size( 6, 25 );
            // 
            // ApplicationLabel
            // 
            ApplicationLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            ApplicationLabel.BackColor = System.Drawing.Color.Transparent;
            ApplicationLabel.BindingSource = null;
            ApplicationLabel.DataFilter = null;
            ApplicationLabel.Field = Field.AccountCode;
            ApplicationLabel.Font = new System.Drawing.Font( "Roboto", 6.75F );
            ApplicationLabel.ForeColor = System.Drawing.Color.Black;
            ApplicationLabel.HoverText = null;
            ApplicationLabel.Margin = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Name = "ApplicationLabel";
            ApplicationLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ApplicationLabel.Size = new System.Drawing.Size( 37, 25 );
            ApplicationLabel.Tag = "";
            ApplicationLabel.Text = "      App:";
            ApplicationLabel.ToolTip = null;
            // 
            // FirstSeparator
            // 
            FirstSeparator.ForeColor = System.Drawing.Color.Black;
            FirstSeparator.Margin = new System.Windows.Forms.Padding( 5, 1, 5, 1 );
            FirstSeparator.Name = "FirstSeparator";
            FirstSeparator.Padding = new System.Windows.Forms.Padding( 1 );
            FirstSeparator.Size = new System.Drawing.Size( 6, 25 );
            // 
            // SqlEditorButton
            // 
            SqlEditorButton.AutoToolTip = false;
            SqlEditorButton.BackColor = System.Drawing.Color.Transparent;
            SqlEditorButton.BindingSource = null;
            SqlEditorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SqlEditorButton.Field = Field.AccountCode;
            SqlEditorButton.Filter = null;
            SqlEditorButton.Font = new System.Drawing.Font( "Roboto", 9F );
            SqlEditorButton.ForeColor = System.Drawing.Color.LightGray;
            SqlEditorButton.HoverText = "SQL Editor";
            SqlEditorButton.Image = Resources.Images.EditSqlButton;
            SqlEditorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SqlEditorButton.Margin = new System.Windows.Forms.Padding( 3 );
            SqlEditorButton.Name = "SqlEditorButton";
            SqlEditorButton.Padding = new System.Windows.Forms.Padding( 1 );
            SqlEditorButton.Size = new System.Drawing.Size( 23, 24 );
            SqlEditorButton.Text = "toolStripButton1";
            SqlEditorButton.ToolTip = ToolTip;
            SqlEditorButton.ToolType = ToolType.EditButton;
            // 
            // Separator10
            // 
            Separator10.ForeColor = System.Drawing.Color.Black;
            Separator10.Margin = new System.Windows.Forms.Padding( 1 );
            Separator10.Name = "Separator10";
            Separator10.Padding = new System.Windows.Forms.Padding( 1 );
            Separator10.Size = new System.Drawing.Size( 6, 28 );
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 500;
            // 
            // ToolStripTable
            // 
            ToolStripTable.ColumnCount = 1;
            ToolStripTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Controls.Add( ToolStrip, 0, 0 );
            ToolStripTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ToolStripTable.Location = new System.Drawing.Point( 0, 689 );
            ToolStripTable.Name = "ToolStripTable";
            ToolStripTable.RowCount = 1;
            ToolStripTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ToolStripTable.Size = new System.Drawing.Size( 1333, 45 );
            ToolStripTable.TabIndex = 18;
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
            // SqlDataForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClientSize = new System.Drawing.Size( 1333, 734 );
            ControlBox = false;
            Controls.Add( ToolStripTable );
            Controls.Add( SqlCommandTable );
            Controls.Add( TabControl );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1340, 740 );
            Name = "SqlDataForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SqlEditor";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)TabControl ).EndInit( );
            TabControl.ResumeLayout( false );
            SqlTabPage.ResumeLayout( false );
            EditorTable.ResumeLayout( false );
            EditorPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)Editor ).EndInit( );
            LookupTabPage.ResumeLayout( false );
            ColumnTable.ResumeLayout( false );
            ColumnPanel.ResumeLayout( false );
            ValueTable.ResumeLayout( false );
            ValuePanel.ResumeLayout( false );
            SourceTable.ResumeLayout( false );
            TablePanel.ResumeLayout( false );
            DataTabPage.ResumeLayout( false );
            DataGridTable.ResumeLayout( false );
            DataGridPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)DataGrid ).EndInit( );
            SchemaTabPage.ResumeLayout( false );
            SchemaHeaderPanel.ResumeLayout( false );
            SchemaTable.ResumeLayout( false );
            SchemaPanel.ResumeLayout( false );
            headerPanel1.ResumeLayout( false );
            LayoutPanel.ResumeLayout( false );
            BusyTabPage.ResumeLayout( false );
            BusyHeaderPanel.ResumeLayout( false );
            BusyPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)Loader ).EndInit( );
            SqlCommandTable.ResumeLayout( false );
            ProviderTable.ResumeLayout( false );
            SecondPanel.ResumeLayout( false );
            CommandTable.ResumeLayout( false );
            CommandPanel.ResumeLayout( false );
            SqlStatementTable.ResumeLayout( false );
            TextPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ToolStrip.ResumeLayout( false );
            ToolStrip.PerformLayout( );
            ToolStripTable.ResumeLayout( false );
            ToolStripTable.PerformLayout( );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        public Picture PictureBox;
        public Label Title;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv SqlTabPage;
        public HeaderPanel EditorTable;
        public BackPanel EditorPanel;
        public Editor Editor;
        public System.Windows.Forms.TableLayoutPanel SqlCommandTable;
        public HeaderPanel ProviderTable;
        public BackPanel SecondPanel;
        public RadioButton SqlServerRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SQLiteRadioButton;
        public RadioButton SqlCeRadioButton;
        public HeaderPanel CommandTable;
        public BackPanel CommandPanel;
        public ComboBox CommandComboBox;
        public HeaderPanel SqlStatementTable;
        public BackPanel TextPanel;
        public ListBox QueryListBox;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        public BackPanel DataGridPanel;
        public DataGrid DataGrid;
        public HeaderPanel DataGridTable;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv DataTabPage;
        public ToolStrip ToolStrip;
        public ToolStripButton FirstButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolStripButton LastButton;
        public ToolSeparator Separator6;
        public ToolStripButton GoButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton SaveButton;
        public ToolStripButton BrowserButton;
        public ToolStripButton MainMenuButton;
        public ToolStripButton CloseButton;
        public ToolSeparator Separator1;
        public ToolStripLabel NavigationSpaceLabel;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public ToolSeparator Separator5;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolSeparator Separator7;
        public ToolSeparator Separator11;
        public ToolSeparator Separator10;
        public ToolSeparator Separator13;
        public ToolSeparator Separator14;
        public ToolSeparator Separator17;
        public ToolStripButton SchemaButton;
        public ToolStripButton LookupButton;
        public ToolStripLabel FileSystemLabel;
        public ToolSeparator Separator16;
        public ToolStripLabel DataLabel;
        public ToolStripButton EditDataButton;
        public ToolSeparator Separator15;
        public ToolSeparator Separator12;
        public ToolStripButton DatabaseButton;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv LookupTabPage;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv SchemaTabPage;
        public HeaderPanel ColumnTable;
        public BackPanel ColumnPanel;
        public ListBox ColumnListBox;
        public HeaderPanel ValueTable;
        public BackPanel ValuePanel;
        public ListBox ValueListBox;
        public HeaderPanel SourceTable;
        public BackPanel TablePanel;
        public ListBox TableListBox;
        public HeaderPanel SchemaTable;
        public BackPanel SchemaPanel;
        public Button DeleteColumnButton;
        public Button AddColumnButton;
        public Label SelectDataTypeLabel;
        public Label AddColumnLabel;
        public TextBox AddColumnTextBox;
        public ComboBox DataTypeComboBox;
        public HeaderPanel headerPanel1;
        public BackPanel LayoutPanel;
        public Label AddTableLabel;
        public Button DeleteTableButton;
        public Button AddTableButton;
        public Label SelectTableLabel;
        public ComboBox TableNameComboBox;
        public TextBox AddTableTextBox;
        private System.ComponentModel.IContainer components;
        public ToolStripButton SqlEditorButton;
        public ToolStripButton EditSqlButton;
        public ToolStripButton TableButton;
        public ToolSeparator TableSeparator;
        public ToolStripButton ClientButton;
        public ToolSeparator ClientSeparator;
        public System.Windows.Forms.Timer Timer;
        public ToolSeparator FirstSeparator;
        public ToolSeparator Separator33;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv BusyTabPage;
        public HeaderPanel BusyHeaderPanel;
        public BackPanel BusyPanel;
        private HeaderPanel SchemaHeaderPanel;
        public System.Windows.Forms.PictureBox Loader;
        public System.Windows.Forms.TableLayoutPanel ToolStripTable;
        public ToolStripLabel StatusLabel;
        public ToolStripLabel ApplicationLabel;
        public ContextMenu ContextMenu;
    }
}