
namespace BudgetExecution
{
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

        partial class BudgetFileBrowser
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
                    components.Dispose();
                }

                base.Dispose( disposing );
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetFileBrowser));
            this.BottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.CheckBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SqlCeCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.PowerPointCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.ExcelCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.CsvCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.AccessCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.SqliteCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.SqlServerCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.PdfCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.WordCheckBox = new VisualPlus.Toolkit.Controls.Interactivity.VisualCheckBox();
            this.Dialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenButton = new BudgetExecution.BudgetButton();
            this.CloseButton = new BudgetExecution.BudgetButton();
            this.BottomTable.SuspendLayout();
            this.TextBoxLayout.SuspendLayout();
            this.CheckBoxLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomTable
            // 
            this.BottomTable.BackColor = System.Drawing.Color.Transparent;
            this.BottomTable.ColumnCount = 3;
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.1938F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8062F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BottomTable.Controls.Add(this.CloseButton, 2, 0);
            this.BottomTable.Controls.Add(this.OpenButton, 0, 0);
            this.BottomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.BottomTable.Location = new System.Drawing.Point(1, 436);
            this.BottomTable.Name = "BottomTable";
            this.BottomTable.RowCount = 2;
            this.BottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.BottomTable.Size = new System.Drawing.Size(686, 81);
            this.BottomTable.TabIndex = 3;
            // 
            // TextBoxLayout
            // 
            this.TextBoxLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.TextBoxLayout.ColumnCount = 4;
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.46559F));
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82578F));
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70863F));
            this.TextBoxLayout.Controls.Add(this.TextBox, 1, 0);
            this.TextBoxLayout.Controls.Add(this.CheckBoxLayout, 3, 0);
            this.TextBoxLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TextBoxLayout.Location = new System.Drawing.Point(1, 56);
            this.TextBoxLayout.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxLayout.Name = "TextBoxLayout";
            this.TextBoxLayout.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxLayout.RowCount = 1;
            this.TextBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextBoxLayout.Size = new System.Drawing.Size(686, 320);
            this.TextBoxLayout.TabIndex = 5;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TextBox.Border.HoverVisible = false;
            this.TextBox.Border.Rounding = 6;
            this.TextBox.Border.Thickness = 1;
            this.TextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.Border.Visible = true;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TextBox.Location = new System.Drawing.Point(102, 6);
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = false;
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.TextBox.ShowSelectionMargin = false;
            this.TextBox.Size = new System.Drawing.Size(449, 308);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // CheckBoxLayout
            // 
            this.CheckBoxLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.CheckBoxLayout.ColumnCount = 1;
            this.CheckBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CheckBoxLayout.Controls.Add(this.SqlCeCheckBox, 0, 8);
            this.CheckBoxLayout.Controls.Add(this.PowerPointCheckBox, 0, 7);
            this.CheckBoxLayout.Controls.Add(this.ExcelCheckBox, 0, 6);
            this.CheckBoxLayout.Controls.Add(this.CsvCheckBox, 0, 5);
            this.CheckBoxLayout.Controls.Add(this.AccessCheckBox, 0, 4);
            this.CheckBoxLayout.Controls.Add(this.SqliteCheckBox, 0, 3);
            this.CheckBoxLayout.Controls.Add(this.SqlServerCheckBox, 0, 2);
            this.CheckBoxLayout.Controls.Add(this.PdfCheckBox, 0, 0);
            this.CheckBoxLayout.Controls.Add(this.WordCheckBox, 0, 1);
            this.CheckBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxLayout.Location = new System.Drawing.Point(575, 4);
            this.CheckBoxLayout.Name = "CheckBoxLayout";
            this.CheckBoxLayout.RowCount = 9;
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.67728F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CheckBoxLayout.Size = new System.Drawing.Size(107, 312);
            this.CheckBoxLayout.TabIndex = 2;
            // 
            // SqlCeCheckBox
            // 
            this.SqlCeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SqlCeCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlCeCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.SqlCeCheckBox.Border.HoverVisible = true;
            this.SqlCeCheckBox.Border.Rounding = 3;
            this.SqlCeCheckBox.Border.Thickness = 1;
            this.SqlCeCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlCeCheckBox.Border.Visible = true;
            this.SqlCeCheckBox.Box = new System.Drawing.Size(14, 14);
            this.SqlCeCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SqlCeCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SqlCeCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.SqlCeCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.SqlCeCheckBox.BoxSpacing = 2;
            this.SqlCeCheckBox.CheckStyle.AutoSize = true;
            this.SqlCeCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.SqlCeCheckBox.CheckStyle.Character = '✔';
            this.SqlCeCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.SqlCeCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlCeCheckBox.CheckStyle.Image = null;
            this.SqlCeCheckBox.CheckStyle.ShapeRounding = 3;
            this.SqlCeCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlCeCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.SqlCeCheckBox.CheckStyle.Thickness = 2F;
            this.SqlCeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SqlCeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlCeCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SqlCeCheckBox.IsBoxLarger = false;
            this.SqlCeCheckBox.Location = new System.Drawing.Point(5, 279);
            this.SqlCeCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.SqlCeCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SqlCeCheckBox.Name = "SqlCeCheckBox";
            this.SqlCeCheckBox.Size = new System.Drawing.Size(97, 28);
            this.SqlCeCheckBox.TabIndex = 13;
            this.SqlCeCheckBox.Text = "  SQL CE";
            this.SqlCeCheckBox.TextSize = new System.Drawing.Size(51, 16);
            this.SqlCeCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SqlCeCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlCeCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlCeCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlCeCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SqlCeCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SqlCeCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PowerPointCheckBox
            // 
            this.PowerPointCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PowerPointCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PowerPointCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.PowerPointCheckBox.Border.HoverVisible = true;
            this.PowerPointCheckBox.Border.Rounding = 3;
            this.PowerPointCheckBox.Border.Thickness = 1;
            this.PowerPointCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PowerPointCheckBox.Border.Visible = true;
            this.PowerPointCheckBox.Box = new System.Drawing.Size(14, 14);
            this.PowerPointCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PowerPointCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PowerPointCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.PowerPointCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.PowerPointCheckBox.BoxSpacing = 2;
            this.PowerPointCheckBox.CheckStyle.AutoSize = true;
            this.PowerPointCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.PowerPointCheckBox.CheckStyle.Character = '✔';
            this.PowerPointCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.PowerPointCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerPointCheckBox.CheckStyle.Image = null;
            this.PowerPointCheckBox.CheckStyle.ShapeRounding = 3;
            this.PowerPointCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PowerPointCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.PowerPointCheckBox.CheckStyle.Thickness = 2F;
            this.PowerPointCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerPointCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PowerPointCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PowerPointCheckBox.IsBoxLarger = false;
            this.PowerPointCheckBox.Location = new System.Drawing.Point(5, 245);
            this.PowerPointCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.PowerPointCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.PowerPointCheckBox.Name = "PowerPointCheckBox";
            this.PowerPointCheckBox.Size = new System.Drawing.Size(97, 24);
            this.PowerPointCheckBox.TabIndex = 12;
            this.PowerPointCheckBox.Text = "  Power Point ";
            this.PowerPointCheckBox.TextSize = new System.Drawing.Size(77, 16);
            this.PowerPointCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.PowerPointCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PowerPointCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PowerPointCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PowerPointCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.PowerPointCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.PowerPointCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // ExcelCheckBox
            // 
            this.ExcelCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExcelCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExcelCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ExcelCheckBox.Border.HoverVisible = true;
            this.ExcelCheckBox.Border.Rounding = 3;
            this.ExcelCheckBox.Border.Thickness = 1;
            this.ExcelCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ExcelCheckBox.Border.Visible = true;
            this.ExcelCheckBox.Box = new System.Drawing.Size(14, 14);
            this.ExcelCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ExcelCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExcelCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.ExcelCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.ExcelCheckBox.BoxSpacing = 2;
            this.ExcelCheckBox.CheckStyle.AutoSize = true;
            this.ExcelCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.ExcelCheckBox.CheckStyle.Character = '✔';
            this.ExcelCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.ExcelCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelCheckBox.CheckStyle.Image = null;
            this.ExcelCheckBox.CheckStyle.ShapeRounding = 3;
            this.ExcelCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ExcelCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.ExcelCheckBox.CheckStyle.Thickness = 2F;
            this.ExcelCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcelCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcelCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelCheckBox.IsBoxLarger = false;
            this.ExcelCheckBox.Location = new System.Drawing.Point(5, 211);
            this.ExcelCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ExcelCheckBox.Name = "ExcelCheckBox";
            this.ExcelCheckBox.Size = new System.Drawing.Size(97, 24);
            this.ExcelCheckBox.TabIndex = 11;
            this.ExcelCheckBox.Text = "  Excel";
            this.ExcelCheckBox.TextSize = new System.Drawing.Size(39, 16);
            this.ExcelCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ExcelCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcelCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcelCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcelCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ExcelCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ExcelCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // CsvCheckBox
            // 
            this.CsvCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CsvCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CsvCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.CsvCheckBox.Border.HoverVisible = true;
            this.CsvCheckBox.Border.Rounding = 3;
            this.CsvCheckBox.Border.Thickness = 1;
            this.CsvCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.Border.Visible = true;
            this.CsvCheckBox.Box = new System.Drawing.Size(14, 14);
            this.CsvCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.CsvCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CsvCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.CsvCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.CsvCheckBox.BoxSpacing = 2;
            this.CsvCheckBox.CheckStyle.AutoSize = true;
            this.CsvCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.CsvCheckBox.CheckStyle.Character = '✔';
            this.CsvCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.CsvCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsvCheckBox.CheckStyle.Image = null;
            this.CsvCheckBox.CheckStyle.ShapeRounding = 3;
            this.CsvCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.CsvCheckBox.CheckStyle.Thickness = 2F;
            this.CsvCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CsvCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CsvCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CsvCheckBox.IsBoxLarger = false;
            this.CsvCheckBox.Location = new System.Drawing.Point(5, 177);
            this.CsvCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.CsvCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CsvCheckBox.Name = "CsvCheckBox";
            this.CsvCheckBox.Size = new System.Drawing.Size(97, 24);
            this.CsvCheckBox.TabIndex = 10;
            this.CsvCheckBox.Text = "  CSV ";
            this.CsvCheckBox.TextSize = new System.Drawing.Size(33, 16);
            this.CsvCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.CsvCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CsvCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CsvCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // AccessCheckBox
            // 
            this.AccessCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.AccessCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AccessCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.AccessCheckBox.Border.HoverVisible = true;
            this.AccessCheckBox.Border.Rounding = 3;
            this.AccessCheckBox.Border.Thickness = 1;
            this.AccessCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.AccessCheckBox.Border.Visible = true;
            this.AccessCheckBox.Box = new System.Drawing.Size(14, 14);
            this.AccessCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.AccessCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AccessCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.AccessCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.AccessCheckBox.BoxSpacing = 2;
            this.AccessCheckBox.CheckStyle.AutoSize = true;
            this.AccessCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.AccessCheckBox.CheckStyle.Character = '✔';
            this.AccessCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.AccessCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessCheckBox.CheckStyle.Image = null;
            this.AccessCheckBox.CheckStyle.ShapeRounding = 3;
            this.AccessCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.AccessCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.AccessCheckBox.CheckStyle.Thickness = 2F;
            this.AccessCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccessCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccessCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AccessCheckBox.IsBoxLarger = false;
            this.AccessCheckBox.Location = new System.Drawing.Point(5, 143);
            this.AccessCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.AccessCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AccessCheckBox.Name = "AccessCheckBox";
            this.AccessCheckBox.Size = new System.Drawing.Size(97, 24);
            this.AccessCheckBox.TabIndex = 9;
            this.AccessCheckBox.Text = "  Access ";
            this.AccessCheckBox.TextSize = new System.Drawing.Size(50, 16);
            this.AccessCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.AccessCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccessCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccessCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccessCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AccessCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AccessCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // SqliteCheckBox
            // 
            this.SqliteCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SqliteCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqliteCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.SqliteCheckBox.Border.HoverVisible = true;
            this.SqliteCheckBox.Border.Rounding = 3;
            this.SqliteCheckBox.Border.Thickness = 1;
            this.SqliteCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqliteCheckBox.Border.Visible = true;
            this.SqliteCheckBox.Box = new System.Drawing.Size(14, 14);
            this.SqliteCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SqliteCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SqliteCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.SqliteCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.SqliteCheckBox.BoxSpacing = 2;
            this.SqliteCheckBox.CheckStyle.AutoSize = true;
            this.SqliteCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.SqliteCheckBox.CheckStyle.Character = '✔';
            this.SqliteCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.SqliteCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqliteCheckBox.CheckStyle.Image = null;
            this.SqliteCheckBox.CheckStyle.ShapeRounding = 3;
            this.SqliteCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqliteCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.SqliteCheckBox.CheckStyle.Thickness = 2F;
            this.SqliteCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SqliteCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqliteCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SqliteCheckBox.IsBoxLarger = false;
            this.SqliteCheckBox.Location = new System.Drawing.Point(5, 109);
            this.SqliteCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.SqliteCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SqliteCheckBox.Name = "SqliteCheckBox";
            this.SqliteCheckBox.Size = new System.Drawing.Size(97, 24);
            this.SqliteCheckBox.TabIndex = 6;
            this.SqliteCheckBox.Text = "  SQLite ";
            this.SqliteCheckBox.TextSize = new System.Drawing.Size(46, 16);
            this.SqliteCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SqliteCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqliteCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqliteCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqliteCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SqliteCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SqliteCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // SqlServerCheckBox
            // 
            this.SqlServerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SqlServerCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlServerCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.SqlServerCheckBox.Border.HoverVisible = true;
            this.SqlServerCheckBox.Border.Rounding = 3;
            this.SqlServerCheckBox.Border.Thickness = 1;
            this.SqlServerCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlServerCheckBox.Border.Visible = true;
            this.SqlServerCheckBox.Box = new System.Drawing.Size(14, 14);
            this.SqlServerCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.SqlServerCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SqlServerCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.SqlServerCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.SqlServerCheckBox.BoxSpacing = 4;
            this.SqlServerCheckBox.CheckStyle.AutoSize = true;
            this.SqlServerCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.SqlServerCheckBox.CheckStyle.Character = '✔';
            this.SqlServerCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.SqlServerCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlServerCheckBox.CheckStyle.Image = null;
            this.SqlServerCheckBox.CheckStyle.ShapeRounding = 3;
            this.SqlServerCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlServerCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.SqlServerCheckBox.CheckStyle.Thickness = 2F;
            this.SqlServerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SqlServerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlServerCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SqlServerCheckBox.IsBoxLarger = false;
            this.SqlServerCheckBox.Location = new System.Drawing.Point(5, 75);
            this.SqlServerCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.SqlServerCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SqlServerCheckBox.Name = "SqlServerCheckBox";
            this.SqlServerCheckBox.Size = new System.Drawing.Size(97, 24);
            this.SqlServerCheckBox.TabIndex = 4;
            this.SqlServerCheckBox.Text = "  SQL  Server";
            this.SqlServerCheckBox.TextSize = new System.Drawing.Size(73, 16);
            this.SqlServerCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SqlServerCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlServerCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlServerCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlServerCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SqlServerCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SqlServerCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PdfCheckBox
            // 
            this.PdfCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PdfCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PdfCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.PdfCheckBox.Border.HoverVisible = true;
            this.PdfCheckBox.Border.Rounding = 3;
            this.PdfCheckBox.Border.Thickness = 1;
            this.PdfCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PdfCheckBox.Border.Visible = true;
            this.PdfCheckBox.Box = new System.Drawing.Size(14, 14);
            this.PdfCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.PdfCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PdfCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.PdfCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.PdfCheckBox.BoxSpacing = 2;
            this.PdfCheckBox.CheckStyle.AutoSize = true;
            this.PdfCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.PdfCheckBox.CheckStyle.Character = '✔';
            this.PdfCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.PdfCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfCheckBox.CheckStyle.Image = null;
            this.PdfCheckBox.CheckStyle.ShapeRounding = 3;
            this.PdfCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PdfCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.PdfCheckBox.CheckStyle.Thickness = 2F;
            this.PdfCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PdfCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdfCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PdfCheckBox.IsBoxLarger = false;
            this.PdfCheckBox.Location = new System.Drawing.Point(5, 5);
            this.PdfCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.PdfCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.PdfCheckBox.Name = "PdfCheckBox";
            this.PdfCheckBox.Size = new System.Drawing.Size(97, 26);
            this.PdfCheckBox.TabIndex = 3;
            this.PdfCheckBox.Text = "  PDF";
            this.PdfCheckBox.TextSize = new System.Drawing.Size(33, 16);
            this.PdfCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.PdfCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PdfCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PdfCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PdfCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.PdfCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.PdfCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // WordCheckBox
            // 
            this.WordCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.WordCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.WordCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.WordCheckBox.Border.HoverVisible = true;
            this.WordCheckBox.Border.Rounding = 3;
            this.WordCheckBox.Border.Thickness = 1;
            this.WordCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.WordCheckBox.Border.Visible = true;
            this.WordCheckBox.Box = new System.Drawing.Size(14, 14);
            this.WordCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.WordCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WordCheckBox.BoxColorState.Hover = System.Drawing.Color.SteelBlue;
            this.WordCheckBox.BoxColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.WordCheckBox.BoxSpacing = 2;
            this.WordCheckBox.CheckStyle.AutoSize = true;
            this.WordCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.WordCheckBox.CheckStyle.Character = '✔';
            this.WordCheckBox.CheckStyle.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
            this.WordCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCheckBox.CheckStyle.Image = null;
            this.WordCheckBox.CheckStyle.ShapeRounding = 3;
            this.WordCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.WordCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.WordCheckBox.CheckStyle.Thickness = 2F;
            this.WordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordCheckBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.WordCheckBox.IsBoxLarger = false;
            this.WordCheckBox.Location = new System.Drawing.Point(5, 41);
            this.WordCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.WordCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.WordCheckBox.Name = "WordCheckBox";
            this.WordCheckBox.Size = new System.Drawing.Size(97, 24);
            this.WordCheckBox.TabIndex = 5;
            this.WordCheckBox.Text = "  Word";
            this.WordCheckBox.TextSize = new System.Drawing.Size(39, 16);
            this.WordCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.WordCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.WordCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.WordCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // Dialog
            // 
            this.Dialog.Filter = "Document FIles | *.PDF | *.DOCX | *.DOC ";
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OpenButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.OpenButton.BindingSource = null;
            this.OpenButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.OpenButton.Border.HoverVisible = true;
            this.OpenButton.Border.Rounding = 6;
            this.OpenButton.Border.Thickness = 1;
            this.OpenButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.OpenButton.Border.Visible = true;
            this.OpenButton.DataFilter = null;
            this.OpenButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OpenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenButton.Field = BudgetExecution.Field.NS;
            this.OpenButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.OpenButton.ForeColor = System.Drawing.Color.LightGray;
            this.OpenButton.HoverText = null;
            this.OpenButton.Image = null;
            this.OpenButton.Images = null;
            this.OpenButton.Location = new System.Drawing.Point(0, 0);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(291, 72);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "Open";
            this.OpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.OpenButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OpenButton.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.OpenButton.TextStyle.Hover = System.Drawing.Color.White;
            this.OpenButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.OpenButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.OpenButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.OpenButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.OpenButton.ToolTip = null;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.CloseButton.BindingSource = null;
            this.CloseButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.CloseButton.Border.HoverVisible = true;
            this.CloseButton.Border.Rounding = 6;
            this.CloseButton.Border.Thickness = 1;
            this.CloseButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CloseButton.Border.Visible = true;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseButton.Field = BudgetExecution.Field.NS;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.LightGray;
            this.CloseButton.HoverText = null;
            this.CloseButton.Image = null;
            this.CloseButton.Images = null;
            this.CloseButton.Location = new System.Drawing.Point(387, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(299, 72);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.CloseButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.TextStyle.Enabled = System.Drawing.Color.LightGray;
            this.CloseButton.TextStyle.Hover = System.Drawing.Color.White;
            this.CloseButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.CloseButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CloseButton.ToolTip = null;
            // 
            // BudgetFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(688, 518);
            this.Controls.Add(this.TextBoxLayout);
            this.Controls.Add(this.BottomTable);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BudgetFileBrowser";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.BottomTable.ResumeLayout(false);
            this.TextBoxLayout.ResumeLayout(false);
            this.CheckBoxLayout.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            public TableLayoutPanel TextBoxLayout;

            public VisualRichTextBox TextBox;
            public TableLayoutPanel CheckBoxLayout;
            public VisualCheckBox SqlServerCheckBox;
            public VisualCheckBox PdfCheckBox;
            public VisualCheckBox WordCheckBox;
            public OpenFileDialog Dialog;
            public VisualCheckBox ExcelCheckBox;
            public VisualCheckBox CsvCheckBox;
            public VisualCheckBox AccessCheckBox;
            public VisualCheckBox SqliteCheckBox;
            public VisualCheckBox SqlCeCheckBox;
            public VisualCheckBox PowerPointCheckBox;
        public TableLayoutPanel BottomTable;
        private BudgetButton OpenButton;
        private BudgetButton CloseButton;
    }
    
}
