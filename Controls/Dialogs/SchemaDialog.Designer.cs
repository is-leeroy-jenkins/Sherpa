// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class SchemaDialog
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
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( SchemaDialog ) );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).BeginInit( );
        SuspendLayout( );
        // 
        // SchemaDialog
        // 
        BackColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        BorderColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        CaptionBarColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionBarHeight = 5;
        CaptionButtonColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionButtonHoverColor = System.Drawing.Color.FromArgb(   20  ,   20  ,   20   );
        CaptionFont = new System.Drawing.Font( "Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        CaptionForeColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        ClientSize = new System.Drawing.Size( 1338, 739 );
        Font = new System.Drawing.Font( "Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point );
        ForeColor = System.Drawing.Color.LightGray;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon) resources.GetObject( "$this.Icon" ) ;
        MaximumSize = new System.Drawing.Size( 1350, 750 );
        MetroColor = System.Drawing.Color.FromArgb(   0  ,   120  ,   212   );
        MinimumSize = new System.Drawing.Size( 1350, 750 );
        Name = "SchemaDialog";
        ShowIcon = false;
        ( (System.ComponentModel.ISupportInitialize) BindingSource  ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public SmallTip ToolTip;
    private DataGrid DataGrid;
}