// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    public partial class GuidanceDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( GuidanceDialog ) );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            ListBox = new ListBox( );
            Picture = new Picture( );
            Title = new Label( );
            ToolTip = new SmallTip( );
            OpenFileDialog = new System.Windows.Forms.OpenFileDialog( );
            HeaderTable = new System.Windows.Forms.TableLayoutPanel( );
            PathLabel = new Label( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            ClearButton = new Button( );
            BrowseButton = new Button( );
            SelectButton = new Button( );
            MenuButton = new Button( );
            CloseButton = new Button( );
            ListBoxPanel = new BackPanel( );
            Timer = new System.Windows.Forms.Timer( components );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)Picture ).BeginInit( );
            HeaderTable.SuspendLayout( );
            ButtonTable.SuspendLayout( );
            ListBoxPanel.SuspendLayout( );
            SuspendLayout( );
            // 
            // ListBox
            // 
            ListBox.Anchor =    System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Bottom   |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right ;
            ListBox.BackColor = System.Drawing.Color.FromArgb( 30, 30, 30 );
            ListBox.BindingSource = BindingSource;
            ListBox.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ListBox.DataFilter = null;
            ListBox.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ListBox.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ListBox.Font = new System.Drawing.Font( "Roboto", 8F );
            ListBox.HoveredItemBackColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            ListBox.HoveredItemColor = System.Drawing.Color.White;
            ListBox.HoverText = null;
            ListBox.IsDerivedStyle = true;
            ListBox.ItemHeight = 28;
            ListBox.Location = new System.Drawing.Point( 24, 19 );
            ListBox.Margin = new System.Windows.Forms.Padding( 1 );
            ListBox.MultiSelect = false;
            ListBox.Name = "ListBox";
            ListBox.Padding = new System.Windows.Forms.Padding( 1 );
            ListBox.SelectedIndex = -1;
            ListBox.SelectedItem = null;
            ListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ListBox.SelectedItemColor = System.Drawing.Color.White;
            ListBox.SelectedText = null;
            ListBox.SelectedValue = null;
            ListBox.ShowBorder = false;
            ListBox.ShowScrollBar = true;
            ListBox.Size = new System.Drawing.Size( 425, 279 );
            ListBox.Style = MetroSet_UI.Enums.Style.Custom;
            ListBox.StyleManager = null;
            ListBox.TabIndex = 0;
            ListBox.ThemeAuthor = "Terry D. Eppler";
            ListBox.ThemeName = "Budget Execution";
            ListBox.ToolTip = null;
            // 
            // Picture
            // 
            Picture.BackColor = System.Drawing.Color.Transparent;
            Picture.BindingSource = null;
            Picture.DataFilter = null;
            Picture.HoverText = null;
            Picture.Image = Resources.Images.GuidanceTile;
            Picture.ImageList = null;
            Picture.Location = new System.Drawing.Point( 3, 3 );
            Picture.Name = "Picture";
            Picture.Padding = new System.Windows.Forms.Padding( 1 );
            Picture.Size = new System.Drawing.Size( 29, 22 );
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Picture.TabIndex = 4;
            Picture.TabStop = false;
            Picture.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Fill;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 56, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 497, 28 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 5;
            Title.Text = "Guidance";
            Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Budget Execution";
            Title.ToolTip = ToolTip;
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
            // OpenFileDialog
            // 
            OpenFileDialog.Title = "Search for Document";
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 3;
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 79.4117661F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20.5882359F ) );
            HeaderTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 502F ) );
            HeaderTable.Controls.Add( Picture, 0, 0 );
            HeaderTable.Controls.Add( Title, 2, 0 );
            HeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderTable.Location = new System.Drawing.Point( 0, 0 );
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 1;
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            HeaderTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            HeaderTable.Size = new System.Drawing.Size( 556, 34 );
            HeaderTable.TabIndex = 8;
            // 
            // PathLabel
            // 
            PathLabel.BindingSource = null;
            PathLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PathLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            PathLabel.HoverText = null;
            PathLabel.IsDerivedStyle = true;
            PathLabel.Location = new System.Drawing.Point( 54, 376 );
            PathLabel.Margin = new System.Windows.Forms.Padding( 3 );
            PathLabel.Name = "PathLabel";
            PathLabel.Padding = new System.Windows.Forms.Padding( 1 );
            PathLabel.Size = new System.Drawing.Size( 470, 31 );
            PathLabel.Style = MetroSet_UI.Enums.Style.Custom;
            PathLabel.StyleManager = null;
            PathLabel.TabIndex = 10;
            PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            PathLabel.ThemeAuthor = "Terry D. Eppler";
            PathLabel.ThemeName = "Budget Execution";
            PathLabel.ToolTip = null;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 5;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 20F ) );
            ButtonTable.Controls.Add( ClearButton, 0, 0 );
            ButtonTable.Controls.Add( BrowseButton, 1, 0 );
            ButtonTable.Controls.Add( SelectButton, 2, 0 );
            ButtonTable.Controls.Add( MenuButton, 3, 0 );
            ButtonTable.Controls.Add( CloseButton, 4, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 435 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ButtonTable.Size = new System.Drawing.Size( 556, 36 );
            ButtonTable.TabIndex = 11;
            // 
            // ClearButton
            // 
            ClearButton.BindingSource = null;
            ClearButton.DataFilter = null;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8F );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            ClearButton.HoverText = null;
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 3, 3 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ClearButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 90, 30 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 0;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Budget Execution";
            ClearButton.ToolTip = null;
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
            BrowseButton.Location = new System.Drawing.Point( 114, 3 );
            BrowseButton.Name = "BrowseButton";
            BrowseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            BrowseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            BrowseButton.Padding = new System.Windows.Forms.Padding( 1 );
            BrowseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BrowseButton.PressTextColor = System.Drawing.Color.White;
            BrowseButton.Size = new System.Drawing.Size( 90, 30 );
            BrowseButton.Style = MetroSet_UI.Enums.Style.Custom;
            BrowseButton.StyleManager = null;
            BrowseButton.TabIndex = 1;
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
            SelectButton.Location = new System.Drawing.Point( 225, 3 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 90, 30 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 4;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Budget Execution";
            SelectButton.ToolTip = null;
            // 
            // MenuButton
            // 
            MenuButton.BindingSource = null;
            MenuButton.DataFilter = null;
            MenuButton.DisabledBackColor = System.Drawing.Color.Transparent;
            MenuButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            MenuButton.DisabledForeColor = System.Drawing.Color.Transparent;
            MenuButton.Font = new System.Drawing.Font( "Roboto", 8F );
            MenuButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            MenuButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            MenuButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            MenuButton.HoverText = "Back To Main Menu";
            MenuButton.HoverTextColor = System.Drawing.Color.White;
            MenuButton.IsDerivedStyle = true;
            MenuButton.Location = new System.Drawing.Point( 336, 3 );
            MenuButton.Name = "MenuButton";
            MenuButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            MenuButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            MenuButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            MenuButton.Padding = new System.Windows.Forms.Padding( 1 );
            MenuButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            MenuButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            MenuButton.PressTextColor = System.Drawing.Color.White;
            MenuButton.Size = new System.Drawing.Size( 90, 30 );
            MenuButton.Style = MetroSet_UI.Enums.Style.Custom;
            MenuButton.StyleManager = null;
            MenuButton.TabIndex = 2;
            MenuButton.Text = "Menu";
            MenuButton.ThemeAuthor = "Terry D. Eppler";
            MenuButton.ThemeName = "Budget Execution";
            MenuButton.ToolTip = null;
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
            CloseButton.Location = new System.Drawing.Point( 447, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // ListBoxPanel
            // 
            ListBoxPanel.BackColor = System.Drawing.Color.Transparent;
            ListBoxPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ListBoxPanel.BindingSource = null;
            ListBoxPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            ListBoxPanel.BorderThickness = 1;
            ListBoxPanel.Children = null;
            ListBoxPanel.Controls.Add( ListBox );
            ListBoxPanel.DataFilter = null;
            ListBoxPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            ListBoxPanel.ForeColor = System.Drawing.Color.Transparent;
            ListBoxPanel.HoverText = null;
            ListBoxPanel.IsDerivedStyle = true;
            ListBoxPanel.Location = new System.Drawing.Point( 54, 57 );
            ListBoxPanel.Name = "ListBoxPanel";
            ListBoxPanel.Padding = new System.Windows.Forms.Padding( 1 );
            ListBoxPanel.Size = new System.Drawing.Size( 470, 313 );
            ListBoxPanel.Style = MetroSet_UI.Enums.Style.Custom;
            ListBoxPanel.StyleManager = null;
            ListBoxPanel.TabIndex = 12;
            ListBoxPanel.ThemeAuthor = "Terry D. Eppler";
            ListBoxPanel.ThemeName = "Budget Execution";
            ListBoxPanel.ToolTip = null;
            // 
            // GuidanceDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Bold );
            CaptionForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClientSize = new System.Drawing.Size( 556, 471 );
            ControlBox = false;
            Controls.Add( ListBoxPanel );
            Controls.Add( ButtonTable );
            Controls.Add( PathLabel );
            Controls.Add( HeaderTable );
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.LightGray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
            MaximizeBox = false;
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 526, 455 );
            Name = "GuidanceDialog";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)Picture ).EndInit( );
            HeaderTable.ResumeLayout( false );
            ButtonTable.ResumeLayout( false );
            ListBoxPanel.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.BindingSource BindingSource;

        public SmallTip ToolTip;
        public System.Windows.Forms.OpenFileDialog OpenFileDialog;
        public Picture Picture;
        public System.Windows.Forms.TableLayoutPanel HeaderTable;
        public Label PathLabel;
        public Label Title;
        public System.Windows.Forms.TableLayoutPanel ButtonTable;
        public Button ClearButton;
        public Button BrowseButton;
        public Button MenuButton;
        public Button CloseButton;
        public ListBox ListBox;
        public BackPanel ListBoxPanel;
        public Button SelectButton;
        public System.Windows.Forms.Timer Timer;
    }
}
