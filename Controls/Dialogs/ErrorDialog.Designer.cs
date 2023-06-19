namespace BudgetExecution
{


    partial class ErrorDialog
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
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( ErrorDialog ) );
            Picture =  new Picture( ) ;
            HeaderLabel =  new Label( ) ;
            CloseButton =  new Button( ) ;
            ToolTip =  new SmallTip( ) ;
            TextBox =  new RichTextBox( ) ;
            ( (System.ComponentModel.ISupportInitialize) Picture  ).BeginInit( );
            SuspendLayout( );
            // 
            // Picture
            // 
            Picture.BackColor =  System.Drawing.Color.Transparent ;
            Picture.BindingSource =  null ;
            Picture.DataFilter =  null ;
            Picture.HoverText =  null ;
            Picture.Image =  Properties.Resources.Error ;
            Picture.ImageList =  null ;
            Picture.Location =  new System.Drawing.Point( 3, 3 ) ;
            Picture.Name =  "Picture" ;
            Picture.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            Picture.Size =  new System.Drawing.Size( 24, 24 ) ;
            Picture.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.StretchImage ;
            Picture.TabIndex =  14 ;
            Picture.TabStop =  false ;
            Picture.ToolTip =  null ;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor =     System.Windows.Forms.AnchorStyles.Top  |  System.Windows.Forms.AnchorStyles.Left   |  System.Windows.Forms.AnchorStyles.Right   ;
            HeaderLabel.BindingSource =  null ;
            HeaderLabel.DataFilter =  null ;
            HeaderLabel.FlatStyle =  System.Windows.Forms.FlatStyle.Flat ;
            HeaderLabel.Font =  new System.Drawing.Font( "Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            HeaderLabel.HoverText =  null ;
            HeaderLabel.ImageAlign =  System.Drawing.ContentAlignment.MiddleLeft ;
            HeaderLabel.IsDerivedStyle =  true ;
            HeaderLabel.Location =  new System.Drawing.Point( 85, 28 ) ;
            HeaderLabel.Margin =  new System.Windows.Forms.Padding( 3 ) ;
            HeaderLabel.Name =  "HeaderLabel" ;
            HeaderLabel.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            HeaderLabel.Size =  new System.Drawing.Size( 526, 23 ) ;
            HeaderLabel.Style =  MetroSet_UI.Enums.Style.Custom ;
            HeaderLabel.StyleManager =  null ;
            HeaderLabel.TabIndex =  13 ;
            HeaderLabel.Text =  "There has been error!" ;
            HeaderLabel.TextAlign =  System.Drawing.ContentAlignment.MiddleLeft ;
            HeaderLabel.ThemeAuthor =  "Terry D. Eppler" ;
            HeaderLabel.ThemeName =  "BudgetExecution" ;
            HeaderLabel.ToolTip =  null ;
            // 
            // CloseButton
            // 
            CloseButton.BindingSource =  null ;
            CloseButton.DataFilter =  null ;
            CloseButton.DisabledBackColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.DisabledForeColor =  System.Drawing.Color.Transparent ;
            CloseButton.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CloseButton.ForeColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.HoverBorderColor =  System.Drawing.Color.FromArgb(   50  ,   93  ,   129   ) ;
            CloseButton.HoverColor =  System.Drawing.Color.FromArgb(   17  ,   53  ,   84   ) ;
            CloseButton.HoverText =  null ;
            CloseButton.HoverTextColor =  System.Drawing.Color.White ;
            CloseButton.IsDerivedStyle =  true ;
            CloseButton.Location =  new System.Drawing.Point( 601, 404 ) ;
            CloseButton.Margin =  new System.Windows.Forms.Padding( 0 ) ;
            CloseButton.Name =  "CloseButton" ;
            CloseButton.NormalBorderColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalColor =  System.Drawing.Color.Transparent ;
            CloseButton.NormalTextColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            CloseButton.PressBorderColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressColor =  System.Drawing.Color.FromArgb(   0  ,   120  ,   212   ) ;
            CloseButton.PressTextColor =  System.Drawing.Color.White ;
            CloseButton.Size =  new System.Drawing.Size( 78, 26 ) ;
            CloseButton.Style =  MetroSet_UI.Enums.Style.Custom ;
            CloseButton.StyleManager =  null ;
            CloseButton.TabIndex =  9 ;
            CloseButton.Text =  "Close" ;
            CloseButton.ThemeAuthor =  "Terry D. Eppler" ;
            CloseButton.ThemeName =  "Budget Execution" ;
            CloseButton.ToolTip =  ToolTip ;
            // 
            // ToolTip
            // 
            ToolTip.AutoPopDelay =  5000 ;
            ToolTip.BackColor =  System.Drawing.Color.FromArgb(   5  ,   5  ,   5   ) ;
            ToolTip.BindingSource =  null ;
            ToolTip.BorderColor =  System.Drawing.SystemColors.Highlight ;
            ToolTip.ForeColor =  System.Drawing.Color.White ;
            ToolTip.InitialDelay =  500 ;
            ToolTip.IsDerivedStyle =  true ;
            ToolTip.Name =  null ;
            ToolTip.OwnerDraw =  true ;
            ToolTip.ReshowDelay =  100 ;
            ToolTip.Style =  MetroSet_UI.Enums.Style.Custom ;
            ToolTip.StyleManager =  null ;
            ToolTip.ThemeAuthor =  "Terry D. Eppler" ;
            ToolTip.ThemeName =  "Budget Execution" ;
            ToolTip.TipIcon =  System.Windows.Forms.ToolTipIcon.Info ;
            ToolTip.TipText =  null ;
            ToolTip.TipTitle =  null ;
            // 
            // TextBox
            // 
            TextBox.AutoWordSelection =  false ;
            TextBox.BindingSource =  null ;
            TextBox.BorderColor =  System.Drawing.Color.FromArgb(   65  ,   65  ,   65   ) ;
            TextBox.DataFilter =  null ;
            TextBox.DisabledBackColor =  System.Drawing.Color.Transparent ;
            TextBox.DisabledBorderColor =  System.Drawing.Color.Transparent ;
            TextBox.DisabledForeColor =  System.Drawing.Color.Transparent ;
            TextBox.Font =  new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            TextBox.HoverColor =  System.Drawing.Color.Maroon ;
            TextBox.HoverText =  null ;
            TextBox.IsDerivedStyle =  true ;
            TextBox.Lines =  null ;
            TextBox.Location =  new System.Drawing.Point( 85, 91 ) ;
            TextBox.MaxLength =  32767 ;
            TextBox.Name =  "TextBox" ;
            TextBox.Padding =  new System.Windows.Forms.Padding( 1 ) ;
            TextBox.ReadOnly =  false ;
            TextBox.Size =  new System.Drawing.Size( 526, 230 ) ;
            TextBox.Style =  MetroSet_UI.Enums.Style.Custom ;
            TextBox.StyleManager =  null ;
            TextBox.TabIndex =  0 ;
            TextBox.Text =  "TextBox" ;
            TextBox.ThemeAuthor =  "Terry D. Eppler" ;
            TextBox.ThemeName =  "Budget Execution" ;
            TextBox.ToolTip =  ToolTip ;
            TextBox.WordWrap =  true ;
            // 
            // ErrorDialog
            // 
            AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Inherit ;
            BackColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            BorderColor =  System.Drawing.Color.Maroon ;
            BorderThickness =  2 ;
            CaptionAlign =  System.Windows.Forms.HorizontalAlignment.Left ;
            CaptionBarColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionBarHeight =  5 ;
            CaptionButtonColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionButtonHoverColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            CaptionFont =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            CaptionForeColor =  System.Drawing.Color.Red ;
            ClientSize =  new System.Drawing.Size( 688, 439 ) ;
            Controls.Add( TextBox );
            Controls.Add( Picture );
            Controls.Add( HeaderLabel );
            Controls.Add( CloseButton );
            Font =  new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ) ;
            ForeColor =  System.Drawing.Color.LightGray ;
            FormBorderStyle =  System.Windows.Forms.FormBorderStyle.FixedSingle ;
            Icon =  (System.Drawing.Icon) resources.GetObject( "$this.Icon" )  ;
            MaximizeBox =  false ;
            MaximumSize =  new System.Drawing.Size( 700, 450 ) ;
            MetroColor =  System.Drawing.Color.FromArgb(   20  ,   20  ,   20   ) ;
            MinimizeBox =  false ;
            MinimumSize =  new System.Drawing.Size( 700, 450 ) ;
            Name =  "ErrorDialog" ;
            ShowIcon =  false ;
            ShowMaximizeBox =  false ;
            ShowMinimizeBox =  false ;
            Text =  "ErrorDialog" ;
            ( (System.ComponentModel.ISupportInitialize) Picture  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion

        public RichTextBox TextBox;
        public Layout BackPanel;
        public Button CloseButton;
        public SmallTip ToolTip;
        public Label HeaderLabel;
        public Picture Picture;
    }
}