namespace BudgetExecution
{


    partial class MainForm
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
            var textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem5 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem6 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem7 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem8 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem9 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem10 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem11 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem12 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem13 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem14 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem15 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem16 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem17 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem18 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem19 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem20 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem21 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem22 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem23 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var textItem24 = new Syncfusion.Windows.Forms.Tools.TextItem( );
            var resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            DatabaseTile = new Tile( );
            ToolTip = new SmallTip( );
            ReportingTile = new Tile( );
            GuidanceTile = new Tile( );
            WebTile = new Tile( );
            UtilityTile = new Tile( );
            ClientTile = new Tile( );
            BindingSource = new System.Windows.Forms.BindingSource( components );
            TestButton = new Button( );
            ExitButton = new Button( );
            ContextMenu = new ContextMenu( );
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
            SuspendLayout( );
            // 
            // DatabaseTile
            // 
            DatabaseTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            DatabaseTile.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            textItem1.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem1.HubTile = DatabaseTile;
            textItem1.TextColor = System.Drawing.Color.DarkGray;
            DatabaseTile.Banner = textItem1;
            DatabaseTile.BannerColor = System.Drawing.Color.Transparent;
            DatabaseTile.BannerHeight = 30;
            DatabaseTile.BannerIcon = Properties.Resources.DataTile;
            DatabaseTile.BindingSource = null;
            textItem2.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem2.HubTile = DatabaseTile;
            textItem2.TextColor = System.Drawing.Color.DarkGray;
            DatabaseTile.Body = textItem2;
            DatabaseTile.DataFilter = null;
            DatabaseTile.EnableSelectionMarker = false;
            DatabaseTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem3.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem3.HubTile = DatabaseTile;
            textItem3.TextColor = System.Drawing.Color.DarkGray;
            DatabaseTile.Footer = textItem3;
            DatabaseTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            DatabaseTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            DatabaseTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            DatabaseTile.HoverText = null;
            DatabaseTile.Location = new System.Drawing.Point( 125, 104 );
            DatabaseTile.Margin = new System.Windows.Forms.Padding( 1 );
            DatabaseTile.MinimumSize = new System.Drawing.Size( 100, 100 );
            DatabaseTile.Name = "DatabaseTile";
            DatabaseTile.ShowBanner = true;
            DatabaseTile.ShowBannerIcon = true;
            DatabaseTile.Size = new System.Drawing.Size( 249, 140 );
            DatabaseTile.TabIndex = 0;
            textItem4.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem4.HubTile = DatabaseTile;
            textItem4.TextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            DatabaseTile.Title = textItem4;
            DatabaseTile.ToolTip = ToolTip;
            DatabaseTile.TurnLiveTileOn = true;
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
            // ReportingTile
            // 
            ReportingTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            ReportingTile.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            textItem5.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem5.HubTile = ReportingTile;
            textItem5.TextColor = System.Drawing.Color.DarkGray;
            ReportingTile.Banner = textItem5;
            ReportingTile.BannerColor = System.Drawing.Color.Transparent;
            ReportingTile.BannerHeight = 30;
            ReportingTile.BannerIcon = Properties.Resources.ChartTile;
            ReportingTile.BindingSource = null;
            textItem6.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem6.HubTile = ReportingTile;
            textItem6.TextColor = System.Drawing.Color.DarkGray;
            ReportingTile.Body = textItem6;
            ReportingTile.DataFilter = null;
            ReportingTile.EnableSelectionMarker = false;
            ReportingTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem7.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem7.HubTile = ReportingTile;
            textItem7.TextColor = System.Drawing.Color.DarkGray;
            ReportingTile.Footer = textItem7;
            ReportingTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            ReportingTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ReportingTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ReportingTile.HoverText = null;
            ReportingTile.Location = new System.Drawing.Point( 551, 95 );
            ReportingTile.Margin = new System.Windows.Forms.Padding( 1 );
            ReportingTile.MinimumSize = new System.Drawing.Size( 100, 100 );
            ReportingTile.Name = "ReportingTile";
            ReportingTile.ShowBanner = true;
            ReportingTile.ShowBannerIcon = true;
            ReportingTile.Size = new System.Drawing.Size( 249, 140 );
            ReportingTile.TabIndex = 1;
            textItem8.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem8.HubTile = ReportingTile;
            textItem8.TextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ReportingTile.Title = textItem8;
            ReportingTile.ToolTip = ToolTip;
            ReportingTile.TurnLiveTileOn = true;
            // 
            // GuidanceTile
            // 
            GuidanceTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            GuidanceTile.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            textItem9.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem9.HubTile = GuidanceTile;
            textItem9.TextColor = System.Drawing.Color.DarkGray;
            GuidanceTile.Banner = textItem9;
            GuidanceTile.BannerColor = System.Drawing.Color.Transparent;
            GuidanceTile.BannerHeight = 30;
            GuidanceTile.BannerIcon = Properties.Resources.GuidanceTile;
            GuidanceTile.BindingSource = null;
            textItem10.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem10.HubTile = GuidanceTile;
            textItem10.TextColor = System.Drawing.Color.DarkGray;
            GuidanceTile.Body = textItem10;
            GuidanceTile.DataFilter = null;
            GuidanceTile.EnableSelectionMarker = false;
            GuidanceTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem11.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem11.HubTile = GuidanceTile;
            textItem11.TextColor = System.Drawing.Color.DarkGray;
            GuidanceTile.Footer = textItem11;
            GuidanceTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            GuidanceTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            GuidanceTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            GuidanceTile.HoverText = null;
            GuidanceTile.Location = new System.Drawing.Point( 979, 95 );
            GuidanceTile.Margin = new System.Windows.Forms.Padding( 1 );
            GuidanceTile.MinimumSize = new System.Drawing.Size( 100, 100 );
            GuidanceTile.Name = "GuidanceTile";
            GuidanceTile.ShowBanner = true;
            GuidanceTile.ShowBannerIcon = true;
            GuidanceTile.Size = new System.Drawing.Size( 249, 140 );
            GuidanceTile.TabIndex = 2;
            textItem12.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem12.HubTile = GuidanceTile;
            textItem12.TextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            GuidanceTile.Title = textItem12;
            GuidanceTile.ToolTip = ToolTip;
            GuidanceTile.TurnLiveTileOn = true;
            // 
            // WebTile
            // 
            WebTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            WebTile.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            textItem13.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem13.HubTile = WebTile;
            textItem13.TextColor = System.Drawing.Color.DarkGray;
            WebTile.Banner = textItem13;
            WebTile.BannerColor = System.Drawing.Color.Transparent;
            WebTile.BannerHeight = 30;
            WebTile.BannerIcon = Properties.Resources.WebClientTIle;
            WebTile.BindingSource = null;
            textItem14.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem14.HubTile = WebTile;
            textItem14.TextColor = System.Drawing.Color.DarkGray;
            WebTile.Body = textItem14;
            WebTile.DataFilter = null;
            WebTile.EnableSelectionMarker = false;
            WebTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem15.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem15.HubTile = WebTile;
            textItem15.TextColor = System.Drawing.Color.DarkGray;
            WebTile.Footer = textItem15;
            WebTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            WebTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            WebTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            WebTile.HoverText = null;
            WebTile.Location = new System.Drawing.Point( 125, 443 );
            WebTile.Margin = new System.Windows.Forms.Padding( 1 );
            WebTile.MinimumSize = new System.Drawing.Size( 100, 100 );
            WebTile.Name = "WebTile";
            WebTile.ShowBanner = true;
            WebTile.ShowBannerIcon = true;
            WebTile.Size = new System.Drawing.Size( 249, 140 );
            WebTile.TabIndex = 3;
            textItem16.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem16.HubTile = WebTile;
            textItem16.TextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            WebTile.Title = textItem16;
            WebTile.ToolTip = ToolTip;
            WebTile.TurnLiveTileOn = true;
            // 
            // UtilityTile
            // 
            UtilityTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            UtilityTile.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            textItem17.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem17.HubTile = UtilityTile;
            textItem17.TextColor = System.Drawing.Color.DarkGray;
            UtilityTile.Banner = textItem17;
            UtilityTile.BannerColor = System.Drawing.Color.Transparent;
            UtilityTile.BannerHeight = 30;
            UtilityTile.BannerIcon = Properties.Resources.UtilityTile;
            UtilityTile.BindingSource = null;
            textItem18.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem18.HubTile = UtilityTile;
            textItem18.TextColor = System.Drawing.Color.DarkGray;
            UtilityTile.Body = textItem18;
            UtilityTile.DataFilter = null;
            UtilityTile.EnableSelectionMarker = false;
            UtilityTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem19.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem19.HubTile = UtilityTile;
            textItem19.TextColor = System.Drawing.Color.DarkGray;
            UtilityTile.Footer = textItem19;
            UtilityTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            UtilityTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            UtilityTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            UtilityTile.HoverText = null;
            UtilityTile.Location = new System.Drawing.Point( 551, 443 );
            UtilityTile.Margin = new System.Windows.Forms.Padding( 1 );
            UtilityTile.MinimumSize = new System.Drawing.Size( 100, 100 );
            UtilityTile.Name = "UtilityTile";
            UtilityTile.ShowBanner = true;
            UtilityTile.ShowBannerIcon = true;
            UtilityTile.Size = new System.Drawing.Size( 249, 140 );
            UtilityTile.TabIndex = 4;
            textItem20.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem20.HubTile = UtilityTile;
            textItem20.TextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            UtilityTile.Title = textItem20;
            UtilityTile.ToolTip = ToolTip;
            UtilityTile.TurnLiveTileOn = true;
            // 
            // ClientTile
            // 
            ClientTile.Anchor = System.Windows.Forms.AnchorStyles.None;
            ClientTile.BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            textItem21.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem21.HubTile = ClientTile;
            textItem21.TextColor = System.Drawing.Color.DarkGray;
            ClientTile.Banner = textItem21;
            ClientTile.BannerColor = System.Drawing.Color.Transparent;
            ClientTile.BannerHeight = 30;
            ClientTile.BannerIcon = Properties.Resources.SqlServerTile;
            ClientTile.BindingSource = null;
            textItem22.Font = new System.Drawing.Font( "Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem22.HubTile = ClientTile;
            textItem22.TextColor = System.Drawing.Color.DarkGray;
            ClientTile.Body = textItem22;
            ClientTile.DataFilter = null;
            ClientTile.EnableSelectionMarker = false;
            ClientTile.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem23.Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem23.HubTile = ClientTile;
            textItem23.TextColor = System.Drawing.Color.DarkGray;
            ClientTile.Footer = textItem23;
            ClientTile.ForeColor = System.Drawing.Color.LightSteelBlue;
            ClientTile.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ClientTile.HoveredBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ClientTile.HoverText = null;
            ClientTile.Location = new System.Drawing.Point( 979, 443 );
            ClientTile.Margin = new System.Windows.Forms.Padding( 1 );
            ClientTile.MinimumSize = new System.Drawing.Size( 100, 100 );
            ClientTile.Name = "ClientTile";
            ClientTile.ShowBanner = true;
            ClientTile.ShowBannerIcon = true;
            ClientTile.Size = new System.Drawing.Size( 249, 140 );
            ClientTile.TabIndex = 5;
            textItem24.Font = new System.Drawing.Font( "Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            textItem24.HubTile = ClientTile;
            textItem24.TextColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientTile.Title = textItem24;
            ClientTile.ToolTip = ToolTip;
            ClientTile.TurnLiveTileOn = true;
            // 
            // TestButton
            // 
            TestButton.BindingSource = null;
            TestButton.DataFilter = null;
            TestButton.DisabledBackColor = System.Drawing.Color.Transparent;
            TestButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            TestButton.DisabledForeColor = System.Drawing.Color.Transparent;
            TestButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            TestButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            TestButton.HoverBorderColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            TestButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            TestButton.HoverText = null;
            TestButton.HoverTextColor = System.Drawing.Color.LightSteelBlue;
            TestButton.IsDerivedStyle = true;
            TestButton.Location = new System.Drawing.Point( 1237, 12 );
            TestButton.Name = "TestButton";
            TestButton.NormalBorderColor = System.Drawing.Color.Transparent;
            TestButton.NormalColor = System.Drawing.Color.Transparent;
            TestButton.NormalTextColor = System.Drawing.Color.Transparent;
            TestButton.Padding = new System.Windows.Forms.Padding( 1 );
            TestButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            TestButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            TestButton.PressTextColor = System.Drawing.Color.White;
            TestButton.Size = new System.Drawing.Size( 78, 26 );
            TestButton.Style = MetroSet_UI.Enums.Style.Custom;
            TestButton.StyleManager = null;
            TestButton.TabIndex = 6;
            TestButton.Text = "Test";
            TestButton.ThemeAuthor = "Terry D. Eppler";
            TestButton.ThemeName = "BudgetExecution";
            TestButton.ToolTip = ToolTip;
            // 
            // ExitButton
            // 
            ExitButton.BindingSource = null;
            ExitButton.DataFilter = null;
            ExitButton.DisabledBackColor = System.Drawing.Color.Transparent;
            ExitButton.DisabledBorderColor = System.Drawing.Color.Transparent;
            ExitButton.DisabledForeColor = System.Drawing.Color.Transparent;
            ExitButton.Font = new System.Drawing.Font( "Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ExitButton.ForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExitButton.HoverBorderColor = System.Drawing.Color.FromArgb(   50  ,   93  ,   129   );
            ExitButton.HoverColor = System.Drawing.Color.FromArgb(   17  ,   53  ,   84   );
            ExitButton.HoverText = null;
            ExitButton.HoverTextColor = System.Drawing.Color.White;
            ExitButton.IsDerivedStyle = true;
            ExitButton.Location = new System.Drawing.Point( 1237, 700 );
            ExitButton.Name = "ExitButton";
            ExitButton.NormalBorderColor = System.Drawing.Color.Transparent;
            ExitButton.NormalColor = System.Drawing.Color.Transparent;
            ExitButton.NormalTextColor = System.Drawing.Color.Transparent;
            ExitButton.Padding = new System.Windows.Forms.Padding( 1 );
            ExitButton.PressBorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExitButton.PressColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ExitButton.PressTextColor = System.Drawing.Color.White;
            ExitButton.Size = new System.Drawing.Size( 78, 26 );
            ExitButton.Style = MetroSet_UI.Enums.Style.Custom;
            ExitButton.StyleManager = null;
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit ";
            ExitButton.ThemeAuthor = "Terry D. Eppler";
            ExitButton.ThemeName = "BudgetExecution";
            ExitButton.ToolTip = ToolTip;
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
            ContextMenu.ThemeAuthor = "Terry D. Eppler";
            ContextMenu.ThemeName = "Budget Execution";
            // 
            // MainForm
            // 
            BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionBarHeight = 5;
            CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
            ClientSize = new System.Drawing.Size( 1338, 738 );
            ControlBox = false;
            Controls.Add( ExitButton );
            Controls.Add( TestButton );
            Controls.Add( ClientTile );
            Controls.Add( UtilityTile );
            Controls.Add( WebTile );
            Controls.Add( GuidanceTile );
            Controls.Add( ReportingTile );
            Controls.Add( DatabaseTile );
            Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
            ForeColor = System.Drawing.Color.LightGray;
            Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size( 1350, 750 );
            MetroColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size( 1350, 750 );
            Name = "MainForm";
            ShowIcon = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
            ResumeLayout( false );
        }

        #endregion
        public System.Windows.Forms.BindingSource BindingSource;
        public Button ExitButton;
        public Button TestButton;
        public Tile ClientTile;
        public Tile UtilityTile;
        public Tile WebTile;
        public Tile GuidanceTile;
        public Tile ReportingTile;
        public Tile DatabaseTile;
        public ContextMenu ContextMenu;
        public SmallTip ToolTip;
    }
}