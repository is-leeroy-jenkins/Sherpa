// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//
namespace BudgetExecution
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
            Image = new Picture( );
            CalculatorPanel = new BackPanel( );
            Calculator = new Syncfusion.Windows.Forms.Tools.CalculatorControl( );
            CloseButton = new Button( );
            CalculatorTable = new System.Windows.Forms.TableLayoutPanel( );
            ButtonTable = new System.Windows.Forms.TableLayoutPanel( );
            Timer = new System.Windows.Forms.Timer( components );
            TopPanel.SuspendLayout( );
            TopTable.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)Image ).BeginInit( );
            CalculatorPanel.SuspendLayout( );
            CalculatorTable.SuspendLayout( );
            ButtonTable.SuspendLayout( );
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
            TopPanel.ThemeName = "Budget Execution";
            TopPanel.ToolTip = null;
            // 
            // TopTable
            // 
            TopTable.ColumnCount = 2;
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TopTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 299F ) );
            TopTable.Controls.Add( ValueLabel, 1, 0 );
            TopTable.Controls.Add( Image, 0, 0 );
            TopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            TopTable.Location = new System.Drawing.Point( 1, 1 );
            TopTable.Name = "TopTable";
            TopTable.RowCount = 1;
            TopTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
            TopTable.Size = new System.Drawing.Size( 353, 35 );
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
            ValueLabel.Location = new System.Drawing.Point( 57, 3 );
            ValueLabel.Margin = new System.Windows.Forms.Padding( 3 );
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Padding = new System.Windows.Forms.Padding( 1 );
            ValueLabel.Size = new System.Drawing.Size( 293, 29 );
            ValueLabel.Style = MetroSet_UI.Enums.Style.Custom;
            ValueLabel.StyleManager = null;
            ValueLabel.TabIndex = 0;
            ValueLabel.Text = "0.0";
            ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ValueLabel.ThemeAuthor = "Terry D. Eppler";
            ValueLabel.ThemeName = "Budget Execution";
            ValueLabel.ToolTip = null;
            // 
            // Image
            // 
            Image.BackColor = System.Drawing.Color.Transparent;
            Image.BindingSource = null;
            Image.DataFilter = null;
            Image.HoverText = null;
            Image.Image = Resources.Images.FormImages.Main;
            Image.ImageList = null;
            Image.Location = new System.Drawing.Point( 3, 3 );
            Image.Name = "Image";
            Image.Padding = new System.Windows.Forms.Padding( 1 );
            Image.Size = new System.Drawing.Size( 48, 26 );
            Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Image.TabIndex = 0;
            Image.TabStop = false;
            Image.ToolTip = null;
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
            CalculatorPanel.Size = new System.Drawing.Size( 355, 344 );
            CalculatorPanel.Style = MetroSet_UI.Enums.Style.Custom;
            CalculatorPanel.StyleManager = null;
            CalculatorPanel.TabIndex = 1;
            CalculatorPanel.ThemeAuthor = "Terry D. Eppler";
            CalculatorPanel.ThemeName = "Budget Execution";
            CalculatorPanel.ToolTip = null;
            // 
            // Calculator
            // 
            Calculator.AccessibleDescription = "Calculator control";
            Calculator.AccessibleName = "Calculator Control";
            Calculator.BeforeTouchSize = new System.Drawing.Size( 353, 342 );
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
            Calculator.Size = new System.Drawing.Size( 353, 342 );
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
            CloseButton.Font = new System.Drawing.Font( "Roboto", 8F );
            CloseButton.ForeColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.HoverBorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.HoverColor = System.Drawing.Color.FromArgb( 17, 53, 84 );
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 259, 3 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.Transparent;
            CloseButton.NormalColor = System.Drawing.Color.Transparent;
            CloseButton.NormalTextColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
            CloseButton.Padding = new System.Windows.Forms.Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 93, 25 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
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
            CalculatorTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute, 46F ) );
            CalculatorTable.Size = new System.Drawing.Size( 361, 440 );
            CalculatorTable.TabIndex = 3;
            // 
            // ButtonTable
            // 
            ButtonTable.ColumnCount = 2;
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 72.39436F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 27.6056347F ) );
            ButtonTable.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Absolute, 20F ) );
            ButtonTable.Controls.Add( CloseButton, 1, 0 );
            ButtonTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonTable.Location = new System.Drawing.Point( 3, 406 );
            ButtonTable.Name = "ButtonTable";
            ButtonTable.RowCount = 1;
            ButtonTable.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 100F ) );
            ButtonTable.Size = new System.Drawing.Size( 355, 31 );
            ButtonTable.TabIndex = 1;
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
            ( (System.ComponentModel.ISupportInitialize)Image ).EndInit( );
            CalculatorPanel.ResumeLayout( false );
            CalculatorTable.ResumeLayout( false );
            ButtonTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        private BackPanel TopPanel;
        private Picture Image;
        private Label ValueLabel;
        private BackPanel CalculatorPanel;
        public Syncfusion.Windows.Forms.Tools.CalculatorControl Calculator;
        public Button CloseButton;
        private System.Windows.Forms.TableLayoutPanel CalculatorTable;
        private System.Windows.Forms.TableLayoutPanel TopTable;
        private System.Windows.Forms.TableLayoutPanel ButtonTable;
        public System.Windows.Forms.Timer Timer;
    }
}

