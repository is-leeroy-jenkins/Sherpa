
namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;

    partial class Message
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
            var resources = new ComponentResourceManager( typeof( Message ) );
            BindingSource = new BindingSource( components );
            ToolTip = new SmallTip( );
            Label = new Label( );
            PictureBox = new Picture( );
            Title = new Label( );
            BackPanel = new Layout( );
            TextBox = new RichTextBox( );
            TitleTable = new TableLayoutPanel( );
            CloseButton = new Button( );
            ( (ISupportInitialize) BindingSource  ).BeginInit( );
            ( (ISupportInitialize) PictureBox  ).BeginInit( );
            BackPanel.SuspendLayout( );
            TitleTable.SuspendLayout( );
            SuspendLayout( );
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
            ToolTip.TipIcon = ToolTipIcon.Info;
            ToolTip.TipText = null;
            ToolTip.TipTitle = null;
            // 
            // Label
            // 
            Label.Anchor =    AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right  ;
            Label.BindingSource = null;
            Label.DataFilter = null;
            Label.FlatStyle = FlatStyle.Flat;
            Label.Font = new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Label.HoverText = null;
            Label.IsDerivedStyle = true;
            Label.Location = new System.Drawing.Point( 86, 67 );
            Label.Margin = new Padding( 3 );
            Label.Name = "Label";
            Label.Padding = new Padding( 1 );
            Label.Size = new System.Drawing.Size( 526, 23 );
            Label.Style = MetroSet_UI.Enums.Style.Custom;
            Label.StyleManager = null;
            Label.TabIndex = 12;
            Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Label.ThemeAuthor = "Terry D. Eppler";
            Label.ThemeName = "BudgetExecution";
            Label.ToolTip = null;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = System.Drawing.Color.Transparent;
            PictureBox.BindingSource = null;
            PictureBox.DataFilter = null;
            PictureBox.HoverText = null;
            PictureBox.Image = Resources.Images.Message;
            PictureBox.ImageList = null;
            PictureBox.Location = new System.Drawing.Point( 3, 3 );
            PictureBox.Name = "PictureBox";
            PictureBox.Padding = new Padding( 1 );
            PictureBox.Size = new System.Drawing.Size( 20, 20 );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.TabIndex = 13;
            PictureBox.TabStop = false;
            PictureBox.ToolTip = null;
            // 
            // Title
            // 
            Title.BindingSource = null;
            Title.DataFilter = null;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            Title.HoverText = null;
            Title.IsDerivedStyle = true;
            Title.Location = new System.Drawing.Point( 43, 3 );
            Title.Margin = new Padding( 3 );
            Title.Name = "Title";
            Title.Padding = new Padding( 1 );
            Title.Size = new System.Drawing.Size( 586, 22 );
            Title.Style = MetroSet_UI.Enums.Style.Custom;
            Title.StyleManager = null;
            Title.TabIndex = 14;
            Title.Text = "Budget Execution Message";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Title.ThemeAuthor = "Terry D. Eppler";
            Title.ThemeName = "BudgetExecution";
            Title.ToolTip = null;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = System.Drawing.Color.Transparent;
            BackPanel.BackgroundColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BackPanel.BindingSource = null;
            BackPanel.BorderColor = System.Drawing.Color.FromArgb(   65  ,   65  ,   65   );
            BackPanel.BorderThickness = 1;
            BackPanel.Children = null;
            BackPanel.Controls.Add( TextBox );
            BackPanel.DataFilter = null;
            BackPanel.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            BackPanel.ForeColor = System.Drawing.Color.Transparent;
            BackPanel.HoverText = null;
            BackPanel.IsDerivedStyle = true;
            BackPanel.Location = new System.Drawing.Point( 70, 77 );
            BackPanel.Name = "BackPanel";
            BackPanel.Padding = new Padding( 1 );
            BackPanel.Size = new System.Drawing.Size( 542, 229 );
            BackPanel.Style = MetroSet_UI.Enums.Style.Custom;
            BackPanel.StyleManager = null;
            BackPanel.TabIndex = 15;
            BackPanel.ThemeAuthor = "Terry D. Eppler";
            BackPanel.ThemeName = "BudgetExecution";
            BackPanel.ToolTip = null;
            // 
            // TextBox
            // 
            TextBox.AutoWordSelection = false;
            TextBox.BindingSource = null;
            TextBox.BorderColor = System.Drawing.Color.FromArgb(   55  ,   55  ,   55   );
            TextBox.DataFilter = null;
            TextBox.DisabledBackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TextBox.DisabledForeColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            TextBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TextBox.HoverColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            TextBox.HoverText = null;
            TextBox.IsDerivedStyle = true;
            TextBox.Lines = null;
            TextBox.Location = new System.Drawing.Point( 33, 24 );
            TextBox.MaxLength = 32767;
            TextBox.Name = "TextBox";
            TextBox.Padding = new Padding( 1 );
            TextBox.ReadOnly = false;
            TextBox.Size = new System.Drawing.Size( 478, 175 );
            TextBox.Style = MetroSet_UI.Enums.Style.Custom;
            TextBox.StyleManager = null;
            TextBox.TabIndex = 0;
            TextBox.Text = " ";
            TextBox.ThemeAuthor = "Terry D. Eppler";
            TextBox.ThemeName = "Budget Execution";
            TextBox.ToolTip = ToolTip;
            TextBox.WordWrap = true;
            // 
            // TitleTable
            // 
            TitleTable.ColumnCount = 2;
            TitleTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 5.900621F ) );
            TitleTable.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 94.09938F ) );
            TitleTable.Controls.Add( PictureBox, 0, 0 );
            TitleTable.Controls.Add( Title, 1, 0 );
            TitleTable.Dock = DockStyle.Top;
            TitleTable.Location = new System.Drawing.Point( 0, 0 );
            TitleTable.Name = "TitleTable";
            TitleTable.RowCount = 1;
            TitleTable.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            TitleTable.Size = new System.Drawing.Size( 688, 28 );
            TitleTable.TabIndex = 16;
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
            CloseButton.HoverText = null;
            CloseButton.HoverTextColor = System.Drawing.Color.White;
            CloseButton.IsDerivedStyle = true;
            CloseButton.Location = new System.Drawing.Point( 586, 347 );
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CloseButton.NormalColor = System.Drawing.Color.FromArgb(   40  ,   40  ,   40   );
            CloseButton.NormalTextColor = System.Drawing.Color.DarkGray;
            CloseButton.Padding = new Padding( 1 );
            CloseButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CloseButton.PressTextColor = System.Drawing.Color.White;
            CloseButton.Size = new System.Drawing.Size( 90, 30 );
            CloseButton.Style = MetroSet_UI.Enums.Style.Custom;
            CloseButton.StyleManager = null;
            CloseButton.TabIndex = 17;
            CloseButton.Text = "Close";
            CloseButton.ThemeAuthor = "Terry D. Eppler";
            CloseButton.ThemeName = "Budget Execution";
            CloseButton.ToolTip = null;
            // 
            // Message
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 688, 389 );
            Controls.Add( CloseButton );
            Controls.Add( TitleTable );
            Controls.Add( BackPanel );
            Controls.Add( Label );
            DoubleBuffered = true;
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightSteelBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 700, 400 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 700, 400 );
            Name = "Message";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = SizeGripStyle.Hide;
            ( (ISupportInitialize) BindingSource  ).EndInit( );
            ( (ISupportInitialize) PictureBox  ).EndInit( );
            BackPanel.ResumeLayout( false );
            TitleTable.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion
        public SmallTip ToolTip;
        public Label Label;
        public Picture PictureBox;
        private Label Title;
        public BindingSource BindingSource;
        private Layout BackPanel;
        private RichTextBox TextBox;
        public TableLayoutPanel TitleTable;
        private Button CloseButton;
    }

}