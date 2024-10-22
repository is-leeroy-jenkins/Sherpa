﻿namespace Sherpa
{
    partial class FolderDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( FolderDialog ) );
            TextBoxLayout = new System.Windows.Forms.TableLayoutPanel( );
            FileList = new ListBox( );
            FoundLabel = new Label( );
            TopTablePanel = new System.Windows.Forms.TableLayoutPanel( );
            PictureBox = new Picture( );
            Title = new Label( );
            StatusLabel = new Label( );
            ToolTip = new SmallTip( );
            SelectButton = new Button( );
            FindButton = new Button( );
            CloseButton = new Button( );
            FolderBrowser = new System.Windows.Forms.FolderBrowserDialog( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            Timer = new System.Windows.Forms.Timer( components );
            MessageLabel = new Label( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            ClearButton = new Button( );
            TextBoxLayout.SuspendLayout( );
            TopTablePanel.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            ButtonTable.SuspendLayout( );
            SuspendLayout( );
            // 
            // TextBoxLayout
            // 
            TextBoxLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            TextBoxLayout.BackColor = System.Drawing.Color.Transparent;
            TextBoxLayout.ColumnCount = 3;
            TextBoxLayout.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 12.55012F ) );
            TextBoxLayout.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 73.76093F ) );
            TextBoxLayout.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 13.7026243F ) );
            TextBoxLayout.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            TextBoxLayout.Controls.Add( FileList, 1, 0 );
            TextBoxLayout.Controls.Add( FoundLabel, 0, 0 );
            TextBoxLayout.Dock = System.Windows.Forms.DockStyle.Top;
            TextBoxLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            TextBoxLayout.Location = new System.Drawing.Point( 0, 62 );
            TextBoxLayout.Margin = new System.Windows.Forms.Padding( 5 );
            TextBoxLayout.Name = "TextBoxLayout";
            TextBoxLayout.Padding = new System.Windows.Forms.Padding( 1 );
            TextBoxLayout.RowCount = 1;
            TextBoxLayout.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            TextBoxLayout.Size = new System.Drawing.Size( 688, 291 );
            TextBoxLayout.TabIndex = 10;
            // 
            // FileList
            // 
            FileList.BackColor = System.Drawing.Color.FromArgb( 35, 35, 35 );
            FileList.BindingSource = null;
            FileList.BorderColor = System.Drawing.Color.FromArgb( 64, 64, 64 );
            FileList.DataFilter = null;
            FileList.DisabledBackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FileList.DisabledForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            FileList.Font = new System.Drawing.Font( "Roboto", 8.25F );
            FileList.HoveredItemBackColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            FileList.HoveredItemColor = System.Drawing.Color.LightSteelBlue;
            FileList.HoverText = null;
            FileList.IsDerivedStyle = true;
            FileList.ItemHeight = 30;
            FileList.Location = new System.Drawing.Point( 88, 2 );
            FileList.Margin = new System.Windows.Forms.Padding( 1 );
            FileList.MultiSelect = false;
            FileList.Name = "FileList";
            FileList.Padding = new System.Windows.Forms.Padding( 1 );
            FileList.SelectedIndex = -1;
            FileList.SelectedItem = null;
            FileList.SelectedItemBackColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FileList.SelectedItemColor = System.Drawing.Color.White;
            FileList.SelectedText = null;
            FileList.SelectedValue = null;
            FileList.ShowBorder = false;
            FileList.ShowScrollBar = false;
            FileList.Size = new System.Drawing.Size( 503, 287 );
            FileList.Style = MetroSet_UI.Enums.Style.Custom;
            FileList.StyleManager = null;
            FileList.TabIndex = 3;
            FileList.ThemeAuthor = "Terry D. Eppler";
            FileList.ThemeName = "Sherpa";
            FileList.ToolTip = null;
            // 
            // FoundLabel
            // 
            FoundLabel.BindingSource = null;
            FoundLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FoundLabel.Font = new System.Drawing.Font( "Roboto", 8.25F );
            FoundLabel.HoverText = null;
            FoundLabel.IsDerivedStyle = true;
            FoundLabel.Location = new System.Drawing.Point( 4, 4 );
            FoundLabel.Margin = new System.Windows.Forms.Padding( 3 );
            FoundLabel.Name = "FoundLabel";
            FoundLabel.Padding = new System.Windows.Forms.Padding( 1 );
            FoundLabel.Size = new System.Drawing.Size( 79, 23 );
            FoundLabel.Style = MetroSet_UI.Enums.Style.Custom;
            FoundLabel.StyleManager = null;
            FoundLabel.TabIndex = 4;
            FoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            FoundLabel.ThemeAuthor = "Terry D. Eppler";
            FoundLabel.ThemeName = "Sherpa";
            FoundLabel.ToolTip = null;
            // 
            // TopTablePanel
            // 
            TopTablePanel.BackColor = System.Drawing.Color.Transparent;
            TopTablePanel.ColumnCount = 3;
            TopTablePanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 5.668605F ) );
            TopTablePanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 94.3314F ) );
            TopTablePanel.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 120F ) );
            TopTablePanel.Controls.Add( PictureBox, 0, 0 );
            TopTablePanel.Controls.Add( Title, 1, 0 );
            TopTablePanel.Controls.Add( StatusLabel, 2, 0 );
            TopTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopTablePanel.Location = new System.Drawing.Point( 0, 0 );
            TopTablePanel.Name = "TopTablePanel";
            TopTablePanel.RowCount = 1;
            TopTablePanel.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TopTablePanel.Size = new System.Drawing.Size( 688, 62 );
            TopTablePanel.TabIndex = 11;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.FormImages.Application;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new System.Windows.Forms.Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 26, 20 );
            PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.Dock = System.Windows.Forms.DockStyle.Top;
            Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 35, 3 );
            Title.Margin = new System.Windows.Forms.Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new System.Windows.Forms.Padding( 1 );
            Title.Size = new System.Drawing.Size( 529, 22 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 0;
            Title.Text = "Directory Search";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "Sherpa";
            Title.ToolTip = null;
            // 
            // StatusLabel
            // 
            StatusLabel.BindingSource = null;
            StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            StatusLabel.HoverText = null;
            StatusLabel.IsDerivedStyle = true;
            StatusLabel.Location = new System.Drawing.Point( 570, 3 );
            StatusLabel.Margin = new System.Windows.Forms.Padding( 3 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 115, 23 );
            StatusLabel.Style = MetroSet_UI.Enums.Style.Custom;
            StatusLabel.StyleManager = null;
            StatusLabel.TabIndex = 2;
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StatusLabel.ThemeAuthor = "Terry D. Eppler";
            StatusLabel.ThemeName = "Sherpa";
            StatusLabel.ToolTip = ToolTip;
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
            SelectButton.Location = new System.Drawing.Point( 395, 3 );
            SelectButton.Name = "SelectButton";
            SelectButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            SelectButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            SelectButton.Padding = new System.Windows.Forms.Padding( 1 );
            SelectButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            SelectButton.PressTextColor = System.Drawing.Color.White;
            SelectButton.Size = new System.Drawing.Size( 90, 29 );
            SelectButton.Style = MetroSet_UI.Enums.Style.Custom;
            SelectButton.StyleManager = null;
            SelectButton.TabIndex = 19;
            SelectButton.Text = "Select";
            SelectButton.ThemeAuthor = "Terry D. Eppler";
            SelectButton.ThemeName = "Sherpa";
            SelectButton.ToolTip = null;
            // 
            // FindButton
            // 
            FindButton.BindingSource = null;
            FindButton.DataFilter = null;
            FindButton.DisabledBackColor = System.Drawing.Color.Transparent;
            FindButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            FindButton.DisabledForeColor = System.Drawing.Color.Transparent;
            FindButton.Font = new System.Drawing.Font( "Roboto", 8F );
            FindButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FindButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            FindButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            FindButton.HoverText = null;
            FindButton.HoverTextColor = System.Drawing.Color.White;
            FindButton.IsDerivedStyle = true;
            FindButton.Location = new System.Drawing.Point( 34, 3 );
            FindButton.Name = "FindButton";
            FindButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            FindButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            FindButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            FindButton.Padding = new System.Windows.Forms.Padding( 1 );
            FindButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FindButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            FindButton.PressTextColor = System.Drawing.Color.White;
            FindButton.Size = new System.Drawing.Size( 90, 29 );
            FindButton.Style = MetroSet_UI.Enums.Style.Custom;
            FindButton.StyleManager = null;
            FindButton.TabIndex = 18;
            FindButton.Text = "Browse";
            FindButton.ThemeAuthor = "Terry D. Eppler";
            FindButton.ThemeName = "Sherpa";
            FindButton.ToolTip = null;
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
            CloseButton.Location = new System.Drawing.Point( 577, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 29 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 17;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Sherpa";
            CloseButton.ToolTip = null;
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // MessageLabel
            // 
            MessageLabel.BindingSource = null;
            MessageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MessageLabel.Font = new System.Drawing.Font( "Roboto", 8F );
            MessageLabel.HoverText = null;
            MessageLabel.IsDerivedStyle = true;
            MessageLabel.Location = new System.Drawing.Point( 88, 359 );
            MessageLabel.Margin = new System.Windows.Forms.Padding( 3 );
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Padding = new System.Windows.Forms.Padding( 1 );
            MessageLabel.Size = new System.Drawing.Size( 503, 23 );
            MessageLabel.Style = MetroSet_UI.Enums.Style.Custom;
            MessageLabel.StyleManager = null;
            MessageLabel.TabIndex = 20;
            MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            MessageLabel.ThemeAuthor = "Terry D. Eppler";
            MessageLabel.ThemeName = "Sherpa";
            MessageLabel.ToolTip = null;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 7;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 18.2242985F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 81.7757F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 35F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 185F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 127F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 55F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 113F ) );
            ButtonTable.Controls.Add( ClearButton, 3, 0 );
            ButtonTable.Controls.Add( FindButton, 1, 0 );
            ButtonTable.Controls.Add( CloseButton, 6, 0 );
            ButtonTable.Controls.Add( SelectButton, 4, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 0, 431 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            ButtonTable.Size = new System.Drawing.Size( 688, 35 );
            ButtonTable.TabIndex = 21;
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
            ClearButton.Location = new System.Drawing.Point( 210, 3 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ClearButton.NormalColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 90, 29 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 22;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Sherpa";
            ClearButton.ToolTip = null;
            // 
            // FolderDialog
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
            ClientSize = new System.Drawing.Size( 688, 466 );
            Controls.Add( ButtonTable );
            Controls.Add( MessageLabel );
            Controls.Add( TextBoxLayout );
            Controls.Add( TopTablePanel );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            ForeColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Name = "FolderDialog";
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            Text = " ";
            TextBoxLayout.ResumeLayout( false );
            TopTablePanel.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ButtonTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel TextBoxLayout;
        public ListBox FileList;
        public Label FoundLabel;
        public System.Windows.Forms.TableLayoutPanel TopTablePanel;
        public Picture PictureBox;
        public Label Title;
        public Button SelectButton;
        public Button FindButton;
        public Button CloseButton;
        public System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        public SmallTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.Timer Timer;
        public Label MessageLabel;
        public System.Windows.Forms.TableLayoutPanel ButtonTable;
        public Button ClearButton;
        public Label StatusLabel;
    }
}