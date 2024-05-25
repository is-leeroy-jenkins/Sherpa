// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace Sherpa;

partial class Frame
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
        TextBox = new TextBox( );
        Label = new Label( );
        Table = new System.Windows.Forms.TableLayoutPanel( );
        Table.SuspendLayout( );
        SuspendLayout( );
        // 
        // TextBox
        // 
        TextBox.AutoCompleteCustomSource = null;
        TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
        TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
        TextBox.BindingSource = null;
        TextBox.BorderColor = System.Drawing.Color.FromArgb( 50, 93, 129 );
        TextBox.DataFilter = null;
        TextBox.DisabledBackColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        TextBox.DisabledBorderColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        TextBox.DisabledForeColor = System.Drawing.Color.FromArgb( 40, 40, 40 );
        TextBox.Dock = System.Windows.Forms.DockStyle.Top;
        TextBox.Font = new System.Drawing.Font( "Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0 );
        TextBox.HoverColor = System.Drawing.Color.FromArgb( 0, 120, 212 );
        TextBox.HoverText = null;
        TextBox.Image = null;
        TextBox.IsDerivedStyle = true;
        TextBox.Lines = null;
        TextBox.Location = new System.Drawing.Point( 3, 29 );
        TextBox.MaxLength = 32767;
        TextBox.Multiline = false;
        TextBox.Name = "TextBox";
        TextBox.ReadOnly = false;
        TextBox.SelectionLength = 0;
        TextBox.Size = new System.Drawing.Size( 118, 25 );
        TextBox.Style = MetroSet_UI.Enums.Style.Custom;
        TextBox.StyleManager = null;
        TextBox.TabIndex = 0;
        TextBox.Text = "textBox1";
        TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        TextBox.ThemeAuthor = "Terry D. Eppler";
        TextBox.ThemeName = "BudgetExecution";
        TextBox.ToolTip = null;
        TextBox.UseSystemPasswordChar = false;
        TextBox.WatermarkText = "";
        // 
        // Label
        // 
        Label.BindingSource = null;
        Label.Dock = System.Windows.Forms.DockStyle.Bottom;
        Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        Label.Font = new System.Drawing.Font( "Roboto", 9F );
        Label.HoverText = null;
        Label.IsDerivedStyle = true;
        Label.Location = new System.Drawing.Point( 3, 3 );
        Label.Margin = new System.Windows.Forms.Padding( 3 );
        Label.Name = "Label";
        Label.Padding = new System.Windows.Forms.Padding( 1 );
        Label.Size = new System.Drawing.Size( 118, 20 );
        Label.Style = MetroSet_UI.Enums.Style.Light;
        Label.StyleManager = null;
        Label.TabIndex = 1;
        Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        Label.ThemeAuthor = "Narwin";
        Label.ThemeName = "MetroLite";
        Label.ToolTip = null;
        // 
        // Table
        // 
        Table.BackColor = System.Drawing.Color.Transparent;
        Table.ColumnCount = 1;
        Table.ColumnStyles.Add( new System.Windows.Forms.ColumnStyle( System.Windows.Forms.SizeType.Percent, 50F ) );
        Table.Controls.Add( Label, 0, 0 );
        Table.Controls.Add( TextBox, 0, 1 );
        Table.Dock = System.Windows.Forms.DockStyle.Fill;
        Table.Font = new System.Drawing.Font( "Roboto", 9F );
        Table.ForeColor = System.Drawing.Color.LightGray;
        Table.Location = new System.Drawing.Point( 0, 0 );
        Table.Name = "Table";
        Table.RowCount = 2;
        Table.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 45.94595F ) );
        Table.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Percent, 54.05405F ) );
        Table.Size = new System.Drawing.Size( 124, 58 );
        Table.TabIndex = 2;
        // 
        // Frame
        // 
        AutoScaleDimensions = new System.Drawing.SizeF( 7F, 14F );
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb( 20, 20, 20 );
        Controls.Add( Table );
        Font = new System.Drawing.Font( "Roboto", 9F );
        ForeColor = System.Drawing.Color.LightGray;
        Name = "Frame";
        Size = new System.Drawing.Size( 124, 58 );
        Table.ResumeLayout( false );
        ResumeLayout( false );
    }

    #endregion

    public TextBox TextBox;
    public Label Label;
    public System.Windows.Forms.TableLayoutPanel Table;
}
