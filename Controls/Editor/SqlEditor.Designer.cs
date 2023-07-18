// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="SqlEditor.Designer.cs" company="Terry D. Eppler">
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   SqlEditor.Designer.cs
// </summary>
// ******************************************************************************************

using System;

namespace BudgetExecution
{

    partial class SqlEditor
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
            var config2 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
            var dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle( );
            var dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new Picture( );
            Title = new Label( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            CloseButton = new Button( );
            SaveButton = new Button( );
            ClearButton = new Button( );
            ExecuteButton = new Button( );
            BrowseButton = new Button( );
            ToolTip = new SmallTip( );
            TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv( );
            EditorPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            EditorTable = new HeaderPanel( );
            EditorPanel = new Layout( );
            Editor = new Editor( );
            SqlCommandTable = new System.Windows.Forms.TableLayoutPanel( );
            ProviderTable = new HeaderPanel( );
            SecondPanel = new Layout( );
            SqlServerRadioButton = new RadioButton( );
            AccessRadioButton = new RadioButton( );
            SQLiteRadioButton = new RadioButton( );
            SqlCeRadioButton = new RadioButton( );
            CommandTable = new HeaderPanel( );
            CommandPanel = new Layout( );
            CommandComboBox = new ComboBox( );
            SqlStatementTable = new HeaderPanel( );
            TextPanel = new Layout( );
            QueryListBox = new ListBox( );
            ContextMenu = new ContextMenu( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            GridPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv( );
            DataGridPanel = new Layout( );
            DataGrid = new DataGrid( );
            DataGridTable = new HeaderPanel( );
            HeaderTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            ButtonTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) TabControl  ).BeginInit( );
            TabControl.SuspendLayout( );
            EditorPage.SuspendLayout( );
            EditorTable.SuspendLayout( );
            EditorPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) Editor  ).BeginInit( );
            SqlCommandTable.SuspendLayout( );
            ProviderTable.SuspendLayout( );
            SecondPanel.SuspendLayout( );
            CommandTable.SuspendLayout( );
            CommandPanel.SuspendLayout( );
            SqlStatementTable.SuspendLayout( );
            TextPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            GridPage.SuspendLayout( );
            DataGridPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) DataGrid  ).BeginInit( );
            DataGridTable.SuspendLayout( );
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
            HeaderTable.Size = new System.Drawing.Size( 1338, 32 );
            HeaderTable.TabIndex = 0;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Properties.Resources.EPA;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 41, 22 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 50, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 1285, 26 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 1;
            Title.Text = "Title";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 10;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 10F ) );
            ButtonTable.Controls.Add( CloseButton, 9, 0 );
            ButtonTable.Controls.Add( SaveButton, 7, 0 );
            ButtonTable.Controls.Add( ClearButton, 5, 0 );
            ButtonTable.Controls.Add( ExecuteButton, 3, 0 );
            ButtonTable.Controls.Add( BrowseButton, 1, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 656 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ButtonTable.Size = new System.Drawing.Size( 1338, 36 );
            ButtonTable.TabIndex = 12;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            CloseButton.HoverText = "Close Editor";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 1200, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 100, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 12;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // SaveButton
            // 
            SaveButton.BindingSource = null;
            SaveButton.DataFilter = null;
            SaveButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SaveButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SaveButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SaveButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            SaveButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            SaveButton.HoverText = "Save Changes";
            SaveButton.HoverTextColor = System.Drawing.Color.White;
            SaveButton.IsDerivedStyle = true;
            SaveButton.Location = new System.Drawing.Point( 934, 3 );
            SaveButton.Name = "SaveButton";
            SaveButton.NormalBorderColor = System.Drawing.Color.Transparent;
            SaveButton.NormalColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
            SaveButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.PressTextColor = System.Drawing.Color.White;
            SaveButton.Size = new System.Drawing.Size( 100, 30 );
            SaveButton.Style = MetroSet_UI.Enums.Style.Custom;
            SaveButton.StyleManager = null;
            SaveButton.TabIndex = 15;
            SaveButton.Text = "Save";
            SaveButton.ThemeAuthor = "Terry D. Eppler";
            SaveButton.ThemeName = "Budget Execution";
            SaveButton.ToolTip = null;
            // 
            // ClearButton
            // 
            ClearButton.BindingSource = null;
            ClearButton.DataFilter = null;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ClearButton.HoverText = "Reset Changes";
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 668, 3 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ClearButton.NormalColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 100, 30 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Budget Execution";
            ClearButton.ToolTip = null;
            // 
            // ExecuteButton
            // 
            ExecuteButton.BindingSource = null;
            ExecuteButton.DataFilter = null;
            ExecuteButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ExecuteButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ExecuteButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ExecuteButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ExecuteButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExecuteButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ExecuteButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ExecuteButton.HoverText = "Execute Query";
            ExecuteButton.HoverTextColor = System.Drawing.Color.White;
            ExecuteButton.IsDerivedStyle = true;
            ExecuteButton.Location = new System.Drawing.Point( 402, 3 );
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ExecuteButton.NormalColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
            ExecuteButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ExecuteButton.Padding = new System.Windows.Forms.Padding( 1 );
            ExecuteButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExecuteButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExecuteButton.PressTextColor = System.Drawing.Color.White;
            ExecuteButton.Size = new System.Drawing.Size( 100, 30 );
            ExecuteButton.Style = MetroSet_UI.Enums.Style.Custom;
            ExecuteButton.StyleManager = null;
            ExecuteButton.TabIndex = 13;
            ExecuteButton.Text = "Execute";
            ExecuteButton.ThemeAuthor = "Terry D. Eppler";
            ExecuteButton.ThemeName = "Budget Execution";
            ExecuteButton.ToolTip = null;
            // 
            // BrowseButton
            // 
            BrowseButton.BindingSource = null;
            BrowseButton.DataFilter = null;
            BrowseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            BrowseButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BrowseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            BrowseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            BrowseButton.HoverText = "Browse for file";
            BrowseButton.HoverTextColor = System.Drawing.Color.White;
            BrowseButton.IsDerivedStyle = true;
            BrowseButton.Location = new System.Drawing.Point( 136, 3 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            BrowseButton.NormalColor = System.Drawing.Color.FromArgb(   27  ,   27  ,   27   );
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 100, 30 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 16;
            BrowseButton.Text = "Browse";
            BrowseButton.ThemeAuthor = "Terry D. Eppler";
            BrowseButton.ThemeName = "Budget Execution";
            BrowseButton.ToolTip = ToolTip;
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
            // TabControl
            // 
            TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ActiveTabFont = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TabControl.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.BeforeTouchSize = new System.Drawing.Size( 971, 607 );
            TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TabControl.BorderWidth = 1;
            TabControl.CanOverrideStyle = true;
            TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.Controls.Add( EditorPage );
            TabControl.Controls.Add( GridPage );
            TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.FocusOnTabClick = false;
            TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ItemSize = new System.Drawing.Size( 158, 23 );
            TabControl.Location = new System.Drawing.Point( 0, 32 );
            TabControl.Margin = new System.Windows.Forms.Padding( 1 );
            TabControl.Name = "TabControl";
            TabControl.Size = new System.Drawing.Size( 971, 607 );
            TabControl.TabIndex = 13;
            TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.TabStyle = typeof( Syncfusion.Windows.Forms.Tools.TabRendererMetro );
            TabControl.ThemeName = "TabRendererMetro";
            TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(   22  ,   39  ,   70   );
            TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(   22  ,   39  ,   70   );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(   22  ,   39  ,   70   );
            TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            // 
            // EditorPage
            // 
            EditorPage.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            EditorPage.Controls.Add( EditorTable );
            EditorPage.Image = null;
            EditorPage.ImageSize = new System.Drawing.Size( 14, 14 );
            EditorPage.Location = new System.Drawing.Point( 0, 22 );
            EditorPage.Margin = new System.Windows.Forms.Padding( 1 );
            EditorPage.Name = "EditorPage";
            EditorPage.Padding = new System.Windows.Forms.Padding( 1 );
            EditorPage.ShowCloseButton = true;
            EditorPage.Size = new System.Drawing.Size( 971, 585 );
            EditorPage.TabBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            EditorPage.TabForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            EditorPage.TabIndex = 8;
            EditorPage.ThemesEnabled = false;
            // 
            // EditorTable
            // 
            EditorTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            EditorTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            EditorTable.CaptionText = "SQL Editor";
            EditorTable.ColumnCount = 1;
            EditorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            EditorTable.Controls.Add( EditorPanel, 0, 1 );
            EditorTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            EditorTable.ForeColor = System.Drawing.Color.DarkGray;
            EditorTable.Location = new System.Drawing.Point( 30, 4 );
            EditorTable.Name = "EditorTable";
            EditorTable.RowCount = 2;
            EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.15264177F ) );
            EditorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.84736F ) );
            EditorTable.Size = new System.Drawing.Size( 919, 561 );
            EditorTable.TabIndex = 5;
            // 
            // EditorPanel
            // 
            EditorPanel.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            EditorPanel.BackColor = System.Drawing.Color.Transparent;
            EditorPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            EditorPanel.BindingSource = null;
            EditorPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            EditorPanel.BorderThickness = 1;
            EditorPanel.Children = null;
            EditorPanel.Controls.Add( Editor );
            EditorPanel.DataFilter = null;
            EditorPanel.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Editor.BackColor = System.Drawing.SystemColors.ControlLight;
            Editor.BookmarkTooltipBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Editor.CanOverrideStyle = true;
            Editor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(   255  ,   238  ,   98   );
            Editor.CodeSnipptSize = new System.Drawing.Size( 100, 100 );
            Editor.ColumnGuidesMeasuringFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Editor.Configurator = config2;
            Editor.ContextChoiceBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(   233  ,   166  ,   50   );
            Editor.ContextPromptBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.ContextTooltipBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.CurrentLineHighlightColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.EndOfLineBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.EndOfLineForeColor = System.Drawing.SystemColors.ControlLight;
            Editor.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Editor.ForeColor = System.Drawing.Color.Black;
            Editor.HighlightCurrentLine = true;
            Editor.IndentationBlockBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.IndentBlockHighlightingColor = System.Drawing.SystemColors.ActiveCaption;
            Editor.IndentLineColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.IndicatorMarginBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.LineNumbersColor = System.Drawing.Color.Black;
            Editor.LineNumbersFont = new System.Drawing.Font( "Hack", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point );
            Editor.Location = new System.Drawing.Point( 17, 14 );
            Editor.Name = "Editor";
            Editor.RenderRightToLeft = false;
            Editor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
            Editor.ScrollPosition = new System.Drawing.Point( 0, 0 );
            Editor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            Editor.SelectionMarginBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            Editor.SelectionTextColor = System.Drawing.Color.White;
            Editor.ShowEndOfLine = false;
            Editor.Size = new System.Drawing.Size( 880, 494 );
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
            // SqlCommandTable
            // 
            SqlCommandTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SqlCommandTable.ColumnCount = 1;
            SqlCommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            SqlCommandTable.Controls.Add( ProviderTable, 0, 0 );
            SqlCommandTable.Controls.Add( CommandTable, 0, 1 );
            SqlCommandTable.Controls.Add( SqlStatementTable, 0, 2 );
            SqlCommandTable.Location = new System.Drawing.Point( 975, 58 );
            SqlCommandTable.Name = "SqlCommandTable";
            SqlCommandTable.RowCount = 3;
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 123F ) );
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 326F ) );
            SqlCommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            SqlCommandTable.Size = new System.Drawing.Size( 352, 561 );
            SqlCommandTable.TabIndex = 4;
            // 
            // ProviderTable
            // 
            ProviderTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            ProviderTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            ProviderTable.CaptionText = "Databases";
            ProviderTable.ColumnCount = 1;
            ProviderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ProviderTable.Controls.Add( SecondPanel, 0, 1 );
            ProviderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ProviderTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ProviderTable.ForeColor = System.Drawing.Color.DarkGray;
            ProviderTable.Location = new System.Drawing.Point( 3, 3 );
            ProviderTable.Name = "ProviderTable";
            ProviderTable.RowCount = 2;
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 9.523809F ) );
            ProviderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 90.47619F ) );
            ProviderTable.Size = new System.Drawing.Size( 346, 106 );
            ProviderTable.TabIndex = 5;
            // 
            // SecondPanel
            // 
            SecondPanel.BackColor = System.Drawing.Color.Transparent;
            SecondPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SecondPanel.BindingSource = null;
            SecondPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            SecondPanel.BorderThickness = 1;
            SecondPanel.Children = null;
            SecondPanel.Controls.Add( SqlServerRadioButton );
            SecondPanel.Controls.Add( AccessRadioButton );
            SecondPanel.Controls.Add( SQLiteRadioButton );
            SecondPanel.Controls.Add( SqlCeRadioButton );
            SecondPanel.DataFilter = null;
            SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SecondPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SecondPanel.ForeColor = System.Drawing.Color.Transparent;
            SecondPanel.HoverText = null;
            SecondPanel.IsDerivedStyle = true;
            SecondPanel.Location = new System.Drawing.Point( 3, 27 );
            SecondPanel.Name = "SecondPanel";
            SecondPanel.Padding = new System.Windows.Forms.Padding( 1 );
            SecondPanel.Size = new System.Drawing.Size( 340, 76 );
            SecondPanel.Style = MetroSet_UI.Enums.Style.Custom;
            SecondPanel.StyleManager = null;
            SecondPanel.TabIndex = 3;
            SecondPanel.ThemeAuthor = "Terry D. Eppler";
            SecondPanel.ThemeName = "Budget Execution";
            SecondPanel.ToolTip = null;
            // 
            // SqlServerRadioButton
            // 
            SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqlServerRadioButton.Checked = false;
            SqlServerRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SqlServerRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            AccessRadioButton.Checked = false;
            AccessRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            AccessRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SQLiteRadioButton.Checked = false;
            SQLiteRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SQLiteRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SqlCeRadioButton.Checked = false;
            SqlCeRadioButton.CheckSignColor = System.Drawing.Color.LimeGreen;
            SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SqlCeRadioButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            CommandTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CommandTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            CommandTable.CaptionText = "Commands";
            CommandTable.ColumnCount = 1;
            CommandTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            CommandTable.Controls.Add( CommandPanel, 0, 1 );
            CommandTable.Dock = System.Windows.Forms.DockStyle.Fill;
            CommandTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CommandTable.ForeColor = System.Drawing.Color.DarkGray;
            CommandTable.Location = new System.Drawing.Point( 3, 115 );
            CommandTable.Name = "CommandTable";
            CommandTable.RowCount = 2;
            CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 7.03125F ) );
            CommandTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 92.96875F ) );
            CommandTable.Size = new System.Drawing.Size( 346, 117 );
            CommandTable.TabIndex = 1;
            // 
            // CommandPanel
            // 
            CommandPanel.BackColor = System.Drawing.Color.Transparent;
            CommandPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CommandPanel.BindingSource = null;
            CommandPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            CommandPanel.BorderThickness = 1;
            CommandPanel.Children = null;
            CommandPanel.Controls.Add( CommandComboBox );
            CommandPanel.DataFilter = null;
            CommandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CommandPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CommandPanel.ForeColor = System.Drawing.Color.Transparent;
            CommandPanel.HoverText = null;
            CommandPanel.IsDerivedStyle = true;
            CommandPanel.Location = new System.Drawing.Point( 3, 26 );
            CommandPanel.Name = "CommandPanel";
            CommandPanel.Padding = new System.Windows.Forms.Padding( 1 );
            CommandPanel.Size = new System.Drawing.Size( 340, 88 );
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
            CommandComboBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            CommandComboBox.ArrowColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CommandComboBox.BackColor = System.Drawing.Color.Transparent;
            CommandComboBox.BackgroundColor = System.Drawing.Color.FromArgb(   30  ,   30  ,   30   );
            CommandComboBox.BindingSource = null;
            CommandComboBox.BorderColor = System.Drawing.Color.FromArgb(   64  ,   64  ,   64   );
            CommandComboBox.CausesValidation = false;
            CommandComboBox.DataFilter = null;
            CommandComboBox.DisabledBackColor = System.Drawing.Color.Transparent;
            CommandComboBox.DisabledBorderColor = System.Drawing.Color.Transparent;
            CommandComboBox.DisabledForeColor = System.Drawing.Color.Transparent;
            CommandComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            CommandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CommandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CommandComboBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CommandComboBox.FormattingEnabled = true;
            CommandComboBox.HoverText = null;
            CommandComboBox.IsDerivedStyle = true;
            CommandComboBox.ItemHeight = 24;
            CommandComboBox.Location = new System.Drawing.Point( 32, 28 );
            CommandComboBox.Name = "CommandComboBox";
            CommandComboBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CommandComboBox.SelectedItemForeColor = System.Drawing.Color.White;
            CommandComboBox.Size = new System.Drawing.Size( 284, 30 );
            CommandComboBox.Style = MetroSet_UI.Enums.Style.Custom;
            CommandComboBox.StyleManager = null;
            CommandComboBox.TabIndex = 0;
            CommandComboBox.ThemeAuthor = "Terry D. Eppler";
            CommandComboBox.ThemeName = "Budget Execution";
            CommandComboBox.ToolTip = null;
            // 
            // SqlStatementTable
            // 
            SqlStatementTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            SqlStatementTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            SqlStatementTable.CaptionText = "SQL Statements";
            SqlStatementTable.ColumnCount = 1;
            SqlStatementTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            SqlStatementTable.Controls.Add( TextPanel, 0, 1 );
            SqlStatementTable.Dock = System.Windows.Forms.DockStyle.Fill;
            SqlStatementTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SqlStatementTable.ForeColor = System.Drawing.Color.DarkGray;
            SqlStatementTable.Location = new System.Drawing.Point( 3, 238 );
            SqlStatementTable.Name = "SqlStatementTable";
            SqlStatementTable.RowCount = 2;
            SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 2.631579F ) );
            SqlStatementTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 97.36842F ) );
            SqlStatementTable.Size = new System.Drawing.Size( 346, 320 );
            SqlStatementTable.TabIndex = 1;
            // 
            // TextPanel
            // 
            TextPanel.BackColor = System.Drawing.Color.Transparent;
            TextPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TextPanel.BindingSource = null;
            TextPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            TextPanel.BorderThickness = 1;
            TextPanel.Children = null;
            TextPanel.Controls.Add( QueryListBox );
            TextPanel.DataFilter = null;
            TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TextPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TextPanel.ForeColor = System.Drawing.Color.Transparent;
            TextPanel.HoverText = null;
            TextPanel.IsDerivedStyle = true;
            TextPanel.Location = new System.Drawing.Point( 3, 27 );
            TextPanel.Name = "TextPanel";
            TextPanel.Padding = new System.Windows.Forms.Padding( 1 );
            TextPanel.Size = new System.Drawing.Size( 340, 290 );
            TextPanel.Style = MetroSet_UI.Enums.Style.Custom;
            TextPanel.StyleManager = null;
            TextPanel.TabIndex = 1;
            TextPanel.ThemeAuthor = "Terry D. Eppler";
            TextPanel.ThemeName = "Budget Execution";
            TextPanel.ToolTip = null;
            // 
            // QueryListBox
            // 
            QueryListBox.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            QueryListBox.BackColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            QueryListBox.BindingSource = null;
            QueryListBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
            QueryListBox.DataFilter = null;
            QueryListBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            QueryListBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            QueryListBox.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            QueryListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            QueryListBox.HoveredItemColor = System.Drawing.Color.White;
            QueryListBox.HoverText = null;
            QueryListBox.IsDerivedStyle = true;
            QueryListBox.ItemHeight = 28;
            QueryListBox.Location = new System.Drawing.Point( 32, 17 );
            QueryListBox.Margin = new System.Windows.Forms.Padding( 1 );
            QueryListBox.MultiSelect = true;
            QueryListBox.Name = "QueryListBox";
            QueryListBox.Padding = new System.Windows.Forms.Padding( 1 );
            QueryListBox.SelectedIndex = -1;
            QueryListBox.SelectedItem = null;
            QueryListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            QueryListBox.SelectedItemColor = System.Drawing.Color.White;
            QueryListBox.SelectedText = null;
            QueryListBox.SelectedValue = null;
            QueryListBox.ShowBorder = false;
            QueryListBox.ShowScrollBar = false;
            QueryListBox.Size = new System.Drawing.Size( 284, 256 );
            QueryListBox.Style = MetroSet_UI.Enums.Style.Custom;
            QueryListBox.StyleManager = null;
            QueryListBox.TabIndex = 0;
            QueryListBox.ThemeAuthor = "Terry D. Eppler";
            QueryListBox.ThemeName = "Budget Execution";
            QueryListBox.ToolTip = null;
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
            ContextMenu.ThemeAuthor = "Terry Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // GridPage
            // 
            GridPage.Controls.Add( DataGridTable );
            GridPage.Image = null;
            GridPage.ImageSize = new System.Drawing.Size( 16, 16 );
            GridPage.Location = new System.Drawing.Point( 0, 22 );
            GridPage.Name = "GridPage";
            GridPage.ShowCloseButton = true;
            GridPage.Size = new System.Drawing.Size( 971, 585 );
            GridPage.TabIndex = 9;
            GridPage.Text = "tabPageAdv1";
            GridPage.ThemesEnabled = false;
            // 
            // DataGridPanel
            // 
            DataGridPanel.BackColor = System.Drawing.Color.Transparent;
            DataGridPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            DataGridPanel.BindingSource = null;
            DataGridPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            DataGridPanel.BorderThickness = 1;
            DataGridPanel.Children = null;
            DataGridPanel.Controls.Add( DataGrid );
            DataGridPanel.DataFilter = null;
            DataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            DataGridPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(   50  ,   50  ,   50   );
            dataGridViewCellStyle6.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(   26  ,   79  ,   125   );
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            DataGrid.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right  ;
            DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            DataGrid.BindingSource = null;
            DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(   26  ,   79  ,   125   );
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.DataFilter = null;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            dataGridViewCellStyle8.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(   26  ,   79  ,   125   );
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            DataGrid.EnableHeadersVisualStyles = false;
            DataGrid.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DataGrid.GridColor = System.Drawing.Color.FromArgb(   141  ,   139  ,   138   );
            DataGrid.HoverText = null;
            DataGrid.Location = new System.Drawing.Point( 22, 19 );
            DataGrid.MultiSelect = false;
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(   50  ,   50  ,   50   );
            dataGridViewCellStyle9.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(   45  ,   45  ,   45   );
            dataGridViewCellStyle10.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(   26  ,   79  ,   125   );
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new System.Drawing.Size( 856, 492 );
            DataGrid.TabIndex = 0;
            DataGrid.ToolTip = null;
            // 
            // DataGridTable
            // 
            DataGridTable.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            DataGridTable.CaptionStyle = CBComponents.HeaderTableLayoutPanel.HighlightCaptionStyle.NavisionAxaptaStyle;
            DataGridTable.CaptionText = "Data Grid";
            DataGridTable.ColumnCount = 1;
            DataGridTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            DataGridTable.Controls.Add( DataGridPanel, 0, 1 );
            DataGridTable.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            DataGridTable.ForeColor = System.Drawing.Color.DarkGray;
            DataGridTable.Location = new System.Drawing.Point( 31, 3 );
            DataGridTable.Name = "DataGridTable";
            DataGridTable.RowCount = 2;
            DataGridTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 1.4678899F ) );
            DataGridTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 98.53211F ) );
            DataGridTable.Size = new System.Drawing.Size( 908, 561 );
            DataGridTable.TabIndex = 39;
            // 
            // SqlEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarHeight = 5;
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1338, 692 );
            Controls.Add( SqlCommandTable );
            Controls.Add( ButtonTable );
            Controls.Add( TabControl );
            Controls.Add( HeaderTable );
            Name = "SqlEditor";
            Text = "SqlEditor";
            HeaderTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            ButtonTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) TabControl  ).EndInit( );
            TabControl.ResumeLayout( false );
            EditorPage.ResumeLayout( false );
            EditorTable.ResumeLayout( false );
            EditorPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) Editor  ).EndInit( );
            SqlCommandTable.ResumeLayout( false );
            ProviderTable.ResumeLayout( false );
            SecondPanel.ResumeLayout( false );
            CommandTable.ResumeLayout( false );
            CommandPanel.ResumeLayout( false );
            SqlStatementTable.ResumeLayout( false );
            TextPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            GridPage.ResumeLayout( false );
            DataGridPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) DataGrid  ).EndInit( );
            DataGridTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        public Picture PictureBox;
        private Label Title;
        public System.Windows.Forms.TableLayoutPanel ButtonTable;
        public Button CloseButton;
        public Button ExecuteButton;
        public Button ClearButton;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv EditorPage;
        private HeaderPanel EditorTable;
        public Layout EditorPanel;
        public Editor Editor;
        public System.Windows.Forms.TableLayoutPanel SqlCommandTable;
        public HeaderPanel ProviderTable;
        public Layout SecondPanel;
        public RadioButton SqlServerRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SQLiteRadioButton;
        public RadioButton SqlCeRadioButton;
        public HeaderPanel CommandTable;
        public Layout CommandPanel;
        public ComboBox CommandComboBox;
        public HeaderPanel SqlStatementTable;
        public Layout TextPanel;
        public ListBox QueryListBox;
        public ContextMenu ContextMenu;
        public System.Windows.Forms.BindingSource BindingSource;
        public SmallTip ToolTip;
        public Button SaveButton;
        public Button BrowseButton;
        public Layout DataGridPanel;
        public DataGrid DataGrid;
        private HeaderPanel DataGridTable;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv GridPage;
    }
}