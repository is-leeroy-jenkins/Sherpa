// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//
namespace Sherpa
{
    partial class CalculationForm
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( CalculationForm ) );
            TopPanel = new BackPanel( );
            TopTable = new System.Windows.Forms.TableLayoutPanel( );
            ValueLabel = new Label( );
            CalculatorButton = new Picture( );
            ToolTip = new SmallTip( );
            CalculatorPanel = new BackPanel( );
            Calculator = new Syncfusion.Windows.Forms.Tools.CalculatorControl( );
            CloseButton = new Button( );
            CalculatorTable = new System.Windows.Forms.TableLayoutPanel( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            ClearButton = new Button( );
            StatusLabel = new Label( );
            Timer = new System.Windows.Forms.Timer( components );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            TopPanel.SuspendLayout( );
            TopTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)CalculatorButton ).BeginInit( );
            CalculatorPanel.SuspendLayout( );
            CalculatorTable.SuspendLayout( );
            ButtonTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
            SuspendLayout( );
            // 
            // TopPanel
            // 
            TopPanel.BackColor = System.Drawing.Color.Transparent;
            TopPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            TopPanel.BindingSource = null;
            TopPanel.BorderColor = System.Drawing.Color.Transparent;
            TopPanel.BorderThickness = 1;
            TopPanel.Children = null;
            TopPanel.Controls.Add( TopTable );
            TopPanel.DataFilter = null;
            TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TopPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            TopPanel.ForeColor = System.Drawing.Color.Transparent;
            TopPanel.HoverText = null;
            TopPanel.IsDerivedStyle = true;
            TopPanel.Location = new System.Drawing.Point( 3, 3 );
            TopPanel.Name = "TopPanel";
            TopPanel.Padding = new System.Windows.Forms.Padding( 1 );
            TopPanel.Size = new System.Drawing.Size( 355, 37 );
            TopPanel.Style = MetroSet_UI.Enums.Style.Custom;
            TopPanel.StyleManager = null;
            TopPanel.TabIndex = 0;
            TopPanel.ThemeAuthor = "Terry D. Eppler";
            TopPanel.ThemeName = "Sherpa";
            TopPanel.ToolTip = null;
            // 
            // TopTable
            // 
            TopTable.ColumnCount = 2;
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 291F ) );
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            TopTable.Controls.Add( ValueLabel, 1, 0 );
            TopTable.Controls.Add( CalculatorButton, 0, 0 );
            TopTable.Dock = System.Windows.Forms.DockStyle.Top;
            TopTable.Location = new System.Drawing.Point( 1, 1 );
            TopTable.Name = "TopTable";
            TopTable.RowCount = 1;
            TopTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            TopTable.Size = new System.Drawing.Size( 353, 32 );
            TopTable.TabIndex = 4;
            // 
            // ValueLabel
            // 
            ValueLabel.BindingSource = null;
            ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            ValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ValueLabel.Font = new System.Drawing.Font( "Roboto", 12F );
            ValueLabel.HoverText = null;
            ValueLabel.IsDerivedStyle = true;
            ValueLabel.Location = new System.Drawing.Point( 65, 3 );
            ValueLabel.Margin = new System.Windows.Forms.Padding( 3 );
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ValueLabel.Size = new System.Drawing.Size( 285, 26 );
            ValueLabel.Style = MetroSet_UI.Enums.Style.Custom;
            ValueLabel.StyleManager = null;
            ValueLabel.TabIndex = 0;
            ValueLabel.Text = "0.0";
            ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ValueLabel.ThemeAuthor = "Terry D. Eppler";
            ValueLabel.ThemeName = "Sherpa";
            ValueLabel.ToolTip = null;
            // 
            // CalculatorButton
            // 
            CalculatorButton.BackColor = System.Drawing.Color.Transparent;
            CalculatorButton.BindingSource = null;
            CalculatorButton.DataFilter = null;
            CalculatorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            CalculatorButton.HoverText = "";
            CalculatorButton.Image = Resources.Images.FormImages.Main;
            CalculatorButton.ImageList = null;
            CalculatorButton.Location = new System.Drawing.Point( 3, 3 );
            CalculatorButton.Name = "CalculatorButton";
            CalculatorButton.Padding = new System.Windows.Forms.Padding( 1 );
            CalculatorButton.Size = new System.Drawing.Size( 56, 26 );
            CalculatorButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            CalculatorButton.TabIndex = 0;
            CalculatorButton.TabStop = false;
            CalculatorButton.ToolTip = ToolTip;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay = 5000;
            ToolTip.BackColor = System.Drawing.Color.FromArgb( 5, 5, 5 );
            ToolTip.BindingSource = null;
            ToolTip.BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
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
            // CalculatorPanel
            // 
            CalculatorPanel.BackColor = System.Drawing.Color.Transparent;
            CalculatorPanel.BackgroundColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CalculatorPanel.BindingSource = null;
            CalculatorPanel.BorderColor = System.Drawing.Color.FromArgb( 65, 65, 65 );
            CalculatorPanel.BorderThickness = 1;
            CalculatorPanel.Children = null;
            CalculatorPanel.Controls.Add( Calculator );
            CalculatorPanel.DataFilter = null;
            CalculatorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CalculatorPanel.Font = new System.Drawing.Font( "Roboto", 8F );
            CalculatorPanel.ForeColor = System.Drawing.Color.Transparent;
            CalculatorPanel.HoverText = null;
            CalculatorPanel.IsDerivedStyle = true;
            CalculatorPanel.Location = new System.Drawing.Point( 3, 46 );
            CalculatorPanel.Name = "CalculatorPanel";
            CalculatorPanel.Padding = new System.Windows.Forms.Padding( 1 );
            CalculatorPanel.Size = new System.Drawing.Size( 355, 349 );
            CalculatorPanel.Style = MetroSet_UI.Enums.Style.Custom;
            CalculatorPanel.StyleManager = null;
            CalculatorPanel.TabIndex = 1;
            CalculatorPanel.ThemeAuthor = "Terry D. Eppler";
            CalculatorPanel.ThemeName = "Sherpa";
            CalculatorPanel.ToolTip = null;
            // 
            // Calculator
            // 
            Calculator.AccessibleDescription = "Calculator control";
            Calculator.AccessibleName = "Calculator Control";
            Calculator.BeforeTouchSize = new System.Drawing.Size( 353, 347 );
            Calculator.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            Calculator.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            Calculator.Culture = new System.Globalization.CultureInfo( "en-US" );
            Calculator.Dock = System.Windows.Forms.DockStyle.Fill;
            Calculator.DoubleValue = 0D;
            Calculator.Font = new System.Drawing.Font( "Roboto", 8F );
            Calculator.ForeColor = System.Drawing.Color.White;
            Calculator.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial;
            Calculator.Location = new System.Drawing.Point( 1, 1 );
            Calculator.MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Calculator.Name = "Calculator";
            Calculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Calculator.ShowDisplayArea = false;
            Calculator.Size = new System.Drawing.Size( 353, 347 );
            Calculator.TabIndex = 0;
            Calculator.ThemeName = "Metro";
            Calculator.UseVerticalAndHorizontalSpacing = true;
            Calculator.UseVisualStyle = true;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource = null;
            CloseButton.DataFilter = null;
            CloseButton.DisabledBackColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            CloseButton.DisabledForeColor = System.Drawing.Color.Transparent;
            CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = "Close Calculator";
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 254, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 89, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Sherpa";
            CloseButton.ToolTip = ToolTip;
            // 
            // CalculatorTable
            // 
            CalculatorTable.ColumnCount = 1;
            CalculatorTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            CalculatorTable.Controls.Add( ButtonTable, 0, 2 );
            CalculatorTable.Controls.Add( CalculatorPanel, 0, 1 );
            CalculatorTable.Controls.Add( TopPanel, 0, 0 );
            CalculatorTable.Dock = System.Windows.Forms.DockStyle.Fill;
            CalculatorTable.Location = new System.Drawing.Point( 0, 0 );
            CalculatorTable.Name = "CalculatorTable";
            CalculatorTable.RowCount = 3;
            CalculatorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 10.9414759F ) );
            CalculatorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 89.0585251F ) );
            CalculatorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 41F ) );
            CalculatorTable.Size = new System.Drawing.Size( 361, 440 );
            CalculatorTable.TabIndex = 3;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 8;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 8.510638F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 91.4893646F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 8F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 93F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 22F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 95F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 8F ) );
            ButtonTable.Controls.Add( ClearButton, 4, 0 );
            ButtonTable.Controls.Add( CloseButton, 6, 0 );
            ButtonTable.Controls.Add( StatusLabel, 1, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ButtonTable.Location = new System.Drawing.Point( 3, 401 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            ButtonTable.Size = new System.Drawing.Size( 355, 36 );
            ButtonTable.TabIndex = 1;
            // 
            // ClearButton
            // 
            ClearButton.BindingSource = null;
            ClearButton.DataFilter = null;
            ClearButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ClearButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            ClearButton.Font = new System.Drawing.Font( "Roboto", 8F );
            ClearButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            ClearButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            ClearButton.HoverText = "Reset Calculation";
            ClearButton.HoverTextColor = System.Drawing.Color.White;
            ClearButton.IsDerivedStyle = true;
            ClearButton.Location = new System.Drawing.Point( 139, 3 );
            ClearButton.Name = "ClearButton";
            ClearButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ClearButton.NormalColor = System.Drawing.Color.Transparent;
            ClearButton.NormalTextColor = System.Drawing.Color.FromArgb( 106, 189, 252 );
            ClearButton.Padding = new System.Windows.Forms.Padding( 1 );
            ClearButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            ClearButton.PressTextColor = System.Drawing.Color.White;
            ClearButton.Size = new System.Drawing.Size( 87, 30 );
            ClearButton.Style = MetroSet_UI.Enums.Style.Custom;
            ClearButton.StyleManager = null;
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.ThemeAuthor = "Terry D. Eppler";
            ClearButton.ThemeName = "Sherpa";
            ClearButton.ToolTip = ToolTip;
            // 
            // StatusLabel
            // 
            StatusLabel.BindingSource = null;
            StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StatusLabel.Font = new System.Drawing.Font( "Roboto", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
            StatusLabel.HoverText = null;
            StatusLabel.IsDerivedStyle = true;
            StatusLabel.Location = new System.Drawing.Point( 10, 1 );
            StatusLabel.Margin = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Padding = new System.Windows.Forms.Padding( 1 );
            StatusLabel.Size = new System.Drawing.Size( 97, 34 );
            StatusLabel.Style = MetroSet_UI.Enums.Style.Custom;
            StatusLabel.StyleManager = null;
            StatusLabel.TabIndex = 1;
            StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            StatusLabel.ThemeAuthor = "Terry D. Eppler";
            StatusLabel.ThemeName = "Sherpa";
            StatusLabel.ToolTip = ToolTip;
            // 
            // Timer
            // 
            Timer.Interval = 80;
            // 
            // CalculationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            BorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            BorderThickness = 2;
            CaptionBarColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = System.Drawing.Color.Red;
            CaptionFont = new System.Drawing.Font( "Roboto", 11.25F );
            CaptionForeColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            ClientSize = new System.Drawing.Size( 361, 440 );
            Controls.Add( CalculatorTable );
            Font = new System.Drawing.Font( "Roboto", 9F );
            ForeColor = System.Drawing.Color.LightSteelBlue;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
            MetroColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
            Name = "CalculationForm";
            ShowIcon = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            TopPanel.ResumeLayout( false );
            TopTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)CalculatorButton ).EndInit( );
            CalculatorPanel.ResumeLayout( false );
            CalculatorTable.ResumeLayout( false );
            ButtonTable.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        /// <summary>
        /// The top panel
        /// </summary>
        private BackPanel TopPanel;
        /// <summary>
        /// The value label
        /// </summary>
        private Label ValueLabel;
        /// <summary>
        /// The calculator panel
        /// </summary>
        private BackPanel CalculatorPanel;
        /// <summary>
        /// The calculator
        /// </summary>
        public Syncfusion.Windows.Forms.Tools.CalculatorControl Calculator;
        /// <summary>
        /// The close button
        /// </summary>
        public Button CloseButton;
        /// <summary>
        /// The calculator table
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel CalculatorTable;
        /// <summary>
        /// The top table
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel TopTable;
        /// <summary>
        /// The button table
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        /// <summary>
        /// The timer
        /// </summary>
        public System.Windows.Forms.Timer Timer;
        public Button ClearButton;
        public System.Windows.Forms.PictureBox WindowsButton;
        public SmallTip ToolTip;
        public Label StatusLabel;
        public Picture CalculatorButton;
        public System.Windows.Forms.BindingSource BindingSource;
    }
}

