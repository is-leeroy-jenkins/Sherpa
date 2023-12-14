// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="TextDialog.Designer.cs" company="Terry D. Eppler">
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
//   TextDialog.Designer.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    partial class TextDialog
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
            var config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( TextDialog ) );
            CloseButton = new Button( );
            SaveButton = new Button( );
            ClearButton = new Button( );
            FormTable = new System.Windows.Forms.TableLayoutPanel( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            TitleTable = new System.Windows.Forms.TableLayoutPanel( );
            Title = new Label( );
            PictureBox = new Picture( );
            EditorPanel = new BackPanel( );
            Editor = new Editor( );
            FormTable.SuspendLayout( );
            ButtonTable.SuspendLayout( );
            TitleTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).BeginInit( );
            EditorPanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize) Editor  ).BeginInit( );
            SuspendLayout( );
            // 
            // CloseButton
            // 
            CloseButton.Anchor =   System.Windows.Forms.AnchorStyles.Bottom  |  System.Windows.Forms.AnchorStyles.Right  ;
            CloseButton.BackColor = System.Drawing.Color.Transparent;
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            CloseButton.HoverText = "Close Window";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 542, 0 );
            CloseButton.Margin = new System.Windows.Forms.Padding( 0 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CloseButton.NormalTextColor = System.Drawing.Color.DarkGray;
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 28 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 12;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "BudgetExecution";
            CloseButton.ToolTip = null;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            SaveButton.BackColor = System.Drawing.Color.Transparent;
            SaveButton.BindingSource = null;
            SaveButton.DataFilter = null;
            SaveButton.DisabledBackColor = System.Drawing.Color.Transparent;
            SaveButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            SaveButton.DisabledForeColor = System.Drawing.Color.Transparent;
            SaveButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            SaveButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            SaveButton.HoverText = "Save Canges";
            SaveButton.HoverTextColor = System.Drawing.Color.White;
            SaveButton.IsDerivedStyle = true;
            SaveButton.Location = new System.Drawing.Point( 294, 0 );
            SaveButton.Margin = new System.Windows.Forms.Padding( 0 );
            SaveButton.Name = "SaveButton";
            SaveButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            SaveButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            SaveButton.NormalTextColor = System.Drawing.Color.DarkGray;
            SaveButton.Padding = new System.Windows.Forms.Padding( 1 );
            SaveButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            SaveButton.PressTextColor = System.Drawing.Color.White;
            SaveButton.Size = new System.Drawing.Size( 90, 28 );
            SaveButton.Style = MetroSet_UI.Enums.Style.Custom;
            SaveButton.StyleManager = null;
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.ThemeAuthor = "Terry D. Eppler";
            SaveButton.ThemeName = "BudgetExecution";
            SaveButton.ToolTip = null;
            // 
            // ClearButton
            // 
            ClearButton.Anchor =   System.Windows.Forms.AnchorStyles.Bottom  |  System.Windows.Forms.AnchorStyles.Left  ;
            ClearButton.BackColor = System.Drawing.Color.Transparent;
            ClearButton.BindingSource = null;
            ClearButton.DataFilter = null;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ClearButton.HoverText = "Clear Out";
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 0, 0 );
            ClearButton.Margin = new System.Windows.Forms.Padding( 0 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ClearButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            ClearButton.NormalTextColor = System.Drawing.Color.DarkGray;
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 90, 28 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 14;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "BudgetExecution";
            ClearButton.ToolTip = null;
            // 
            // FormTable
            // 
            FormTable.ColumnCount = 1;
            FormTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            FormTable.Controls.Add( ButtonTable, 0, 2 );
            FormTable.Controls.Add( TitleTable, 0, 0 );
            FormTable.Controls.Add( EditorPanel, 0, 1 );
            FormTable.Dock = System.Windows.Forms.DockStyle.Fill;
            FormTable.Location = new System.Drawing.Point( 0, 0 );
            FormTable.Name = "FormTable";
            FormTable.RowCount = 3;
            FormTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 17.0731716F ) );
            FormTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 82.92683F ) );
            FormTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 33F ) );
            FormTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 19F ) );
            FormTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 19F ) );
            FormTable.Size = new System.Drawing.Size( 638, 239 );
            FormTable.TabIndex = 15;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 5;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 49.74874F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50.251255F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 141F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 127F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 94F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            ButtonTable.Controls.Add( ClearButton, 0, 0 );
            ButtonTable.Controls.Add( CloseButton, 4, 0 );
            ButtonTable.Controls.Add( SaveButton, 2, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 3, 208 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ButtonTable.Size = new System.Drawing.Size( 632, 28 );
            ButtonTable.TabIndex = 1;
            // 
            // TitleTable
            // 
            TitleTable.ColumnCount = 2;
            TitleTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 6.01173F ) );
            TitleTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 93.988266F ) );
            TitleTable.Controls.Add( Title, 1, 0 );
            TitleTable.Controls.Add( PictureBox, 0, 0 );
            TitleTable.Dock = System.Windows.Forms.DockStyle.Top;
            TitleTable.Location = new System.Drawing.Point( 3, 3 );
            TitleTable.Name = "TitleTable";
            TitleTable.RowCount = 1;
            TitleTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TitleTable.Size = new System.Drawing.Size( 632, 29 );
            TitleTable.TabIndex = 0;
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
            Title.Location = new System.Drawing.Point( 40, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 589, 23 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 0;
            Title.Text = "Text Editor";
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = null;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.TextDialog;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 31, 23 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // EditorPanel
            // 
            EditorPanel.BackColor = System.Drawing.Color.Transparent;
            EditorPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            EditorPanel.BindingSource = null;
            EditorPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            EditorPanel.BorderThickness = 1;
            EditorPanel.Children = null;
            EditorPanel.Controls.Add( Editor );
            EditorPanel.DataFilter = null;
            EditorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            EditorPanel.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            EditorPanel.ForeColor = System.Drawing.Color.Transparent;
            EditorPanel.HoverText = null;
            EditorPanel.IsDerivedStyle = true;
            EditorPanel.Location = new System.Drawing.Point( 3, 38 );
            EditorPanel.Name = "EditorPanel";
            EditorPanel.Padding = new System.Windows.Forms.Padding( 1 );
            EditorPanel.Size = new System.Drawing.Size( 632, 164 );
            EditorPanel.Style = MetroSet_UI.Enums.Style.Custom;
            EditorPanel.StyleManager = null;
            EditorPanel.TabIndex = 2;
            EditorPanel.ThemeAuthor = "Terry D. Eppler";
            EditorPanel.ThemeName = "Budget Execution";
            EditorPanel.ToolTip = null;
            // 
            // Editor
            // 
            Editor.AllowZoom = false;
            Editor.AlwaysShowScrollers = true;
            Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Editor.BackColor = System.Drawing.SystemColors.ControlDark;
            Editor.BookmarkTooltipBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Editor.CanOverrideStyle = true;
            Editor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(   255  ,   238  ,   98   );
            Editor.CodeSnipptSize = new System.Drawing.Size( 100, 100 );
            Editor.ColumnGuidesMeasuringFont = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Editor.Configurator = config1;
            Editor.ContextChoiceBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(   233  ,   166  ,   50   );
            Editor.ContextPromptBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.ContextTooltipBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.CurrentLineHighlightColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            Editor.EndOfLineBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.EndOfLineForeColor = System.Drawing.SystemColors.ControlLight;
            Editor.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Editor.ForeColor = System.Drawing.Color.Black;
            Editor.HighlightCurrentLine = true;
            Editor.IndentationBlockBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.IndentBlockHighlightingColor = System.Drawing.SystemColors.ActiveCaption;
            Editor.IndentLineColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            Editor.IndicatorMarginBackColor = System.Drawing.SystemColors.ControlLight;
            Editor.LineNumbersColor = System.Drawing.Color.Black;
            Editor.LineNumbersFont = new System.Drawing.Font( "Hack", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Editor.Location = new System.Drawing.Point( 1, 1 );
            Editor.Name = "Editor";
            Editor.RenderRightToLeft = false;
            Editor.SaveOnClose = false;
            Editor.ScrollColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
            Editor.ScrollPosition = new System.Drawing.Point( 0, 0 );
            Editor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            Editor.SelectionMarginBackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            Editor.SelectionTextColor = System.Drawing.Color.White;
            Editor.ShowEndOfLine = false;
            Editor.Size = new System.Drawing.Size( 630, 162 );
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
            Editor.TabIndex = 1;
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
            Editor.WordWrapColumn = 25;
            Editor.WordWrapMode = Syncfusion.Windows.Forms.Edit.Enums.WordWrapMode.WordWrapMargin;
            Editor.ZoomFactor = 1F;
            // 
            // TextDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            ClientSize = new System.Drawing.Size( 638, 239 );
            ControlBox = false;
            Controls.Add( FormTable );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 650, 250 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 650, 250 );
            Name = "TextDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "TextDialog";
            TopMost = true;
            FormTable.ResumeLayout( false );
            ButtonTable.ResumeLayout( false );
            TitleTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) PictureBox  ).EndInit( );
            EditorPanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize) Editor  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public Button CloseButton;
        public Button SaveButton;
        public Button ClearButton;
        private System.Windows.Forms.TableLayoutPanel FormTable;
        public System.Windows.Forms.TableLayoutPanel TitleTable;
        public System.Windows.Forms.TableLayoutPanel ButtonTable;
        public BackPanel EditorPanel;
        public Label Title;
        public Picture PictureBox;
        public Editor Editor;
    }
}