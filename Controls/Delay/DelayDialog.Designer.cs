﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class DelayDialog
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
        var resources = new System.ComponentModel.ComponentResourceManager( typeof( DelayDialog ) );
        PictureBox = new System.Windows.Forms.PictureBox( );
        BindingSource = new System.Windows.Forms.BindingSource( components );
        Timer = new System.Windows.Forms.Timer( components );
        ImageList = new System.Windows.Forms.ImageList( components );
        ( (System.ComponentModel.ISupportInitialize)PictureBox ).BeginInit( );
        ( (System.ComponentModel.ISupportInitialize)BindingSource ).BeginInit( );
        SuspendLayout( );
        // 
        // PictureBox
        // 
        PictureBox.BackColor = System.Drawing.Color.Transparent;
        PictureBox.Location = new System.Drawing.Point( 397, 111 );
        PictureBox.Name = "PictureBox";
        PictureBox.Size = new System.Drawing.Size( 549, 348 );
        PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        PictureBox.TabIndex = 0;
        PictureBox.TabStop = false;
        // 
        // ImageList
        // 
        ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
        ImageList.ImageSize = new System.Drawing.Size( 16, 16 );
        ImageList.TransparentColor = System.Drawing.Color.Transparent;
        // 
        // DelayDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Black;
        BorderColor = System.Drawing.Color.Black;
        CaptionBarColor = System.Drawing.Color.Black;
        CaptionBarHeight = 5;
        CaptionButtonColor = System.Drawing.Color.Black;
        CaptionButtonHoverColor = System.Drawing.Color.Black;
        CaptionFont = new System.Drawing.Font( "Roboto", 9F );
        CaptionForeColor = System.Drawing.Color.Black;
        ClientSize = new System.Drawing.Size( 1328, 637 );
        Controls.Add( PictureBox );
        DoubleBuffered = true;
        Font = new System.Drawing.Font( "Roboto", 9F );
        ForeColor = System.Drawing.Color.Black;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Icon = (System.Drawing.Icon)resources.GetObject( "$this.Icon" );
        Margin = new System.Windows.Forms.Padding( 4, 3, 4, 3 );
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size( 1340, 648 );
        MetroColor = System.Drawing.Color.Black;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size( 1340, 648 );
        Name = "DelayDialog";
        ShowIcon = false;
        ShowMaximizeBox = false;
        ShowMinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        ( (System.ComponentModel.ISupportInitialize)PictureBox ).EndInit( );
        ( (System.ComponentModel.ISupportInitialize)BindingSource ).EndInit( );
        ResumeLayout( false );
    }

    #endregion
    public System.Windows.Forms.BindingSource BindingSource;
    public System.Windows.Forms.Timer Timer;
    public System.Windows.Forms.ImageList ImageList;
    public System.Windows.Forms.PictureBox PictureBox;
}