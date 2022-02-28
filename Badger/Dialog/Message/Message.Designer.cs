
namespace BudgetExecution
{
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.OpenButton = new BudgetExecution.BudgetButton();
            this.CloseButton = new BudgetExecution.BudgetButton();
            this.HeaderLabel = new BudgetExecution.BudgetLabel();
            this.budgetRichTextBox1 = new BudgetExecution.BudgetRichTextBox();
            this.PictureBox = new BudgetExecution.BudgetPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OpenButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OpenButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.OpenButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.OpenButton.BindingSource = null;
            this.OpenButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OpenButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.OpenButton.Border.HoverVisible = true;
            this.OpenButton.Border.Rounding = 6;
            this.OpenButton.Border.Thickness = 1;
            this.OpenButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.OpenButton.Border.Visible = true;
            this.OpenButton.DataFilter = null;
            this.OpenButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OpenButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.OpenButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.OpenButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenButton.HoverText = null;
            this.OpenButton.Image = null;
            this.OpenButton.Images = null;
            this.OpenButton.Location = new System.Drawing.Point(41, 235);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(142, 54);
            this.OpenButton.TabIndex = 6;
            this.OpenButton.Text = "Open";
            this.OpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.OpenButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.OpenButton.TextStyle.Enabled = System.Drawing.Color.WhiteSmoke;
            this.OpenButton.TextStyle.Hover = System.Drawing.Color.White;
            this.OpenButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.OpenButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.OpenButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.OpenButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.OpenButton.ToolTip = null;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CloseButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.CloseButton.BindingSource = null;
            this.CloseButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.CloseButton.Border.HoverVisible = true;
            this.CloseButton.Border.Rounding = 6;
            this.CloseButton.Border.Thickness = 1;
            this.CloseButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CloseButton.Border.Visible = true;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.HoverText = null;
            this.CloseButton.Image = null;
            this.CloseButton.Images = null;
            this.CloseButton.Location = new System.Drawing.Point(398, 235);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(142, 54);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.CloseButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CloseButton.TextStyle.Enabled = System.Drawing.Color.WhiteSmoke;
            this.CloseButton.TextStyle.Hover = System.Drawing.Color.White;
            this.CloseButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.CloseButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CloseButton.ToolTip = null;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLabel.BindingSource = null;
            this.HeaderLabel.DataFilter = null;
            this.HeaderLabel.Field = BudgetExecution.Field.RpioActivityCode;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.HeaderLabel.HoverText = null;
            this.HeaderLabel.Location = new System.Drawing.Point(41, 9);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(1);
            this.HeaderLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Numeric = BudgetExecution.Numeric.NS;
            this.HeaderLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.HeaderLabel.Outline = false;
            this.HeaderLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.HeaderLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.HeaderLabel.ReflectionColor = System.Drawing.SystemColors.GrayText;
            this.HeaderLabel.ReflectionSpacing = 0;
            this.HeaderLabel.ShadowColor = System.Drawing.Color.Black;
            this.HeaderLabel.ShadowDirection = 315;
            this.HeaderLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.HeaderLabel.ShadowOpacity = 100;
            this.HeaderLabel.Size = new System.Drawing.Size(499, 22);
            this.HeaderLabel.TabIndex = 9;
            this.HeaderLabel.Text = "Budget Execution";
            this.HeaderLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.HeaderLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HeaderLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.HeaderLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.HeaderLabel.ToolTip = null;
            // 
            // budgetRichTextBox1
            // 
            this.budgetRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetRichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetRichTextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetRichTextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.budgetRichTextBox1.BindingSource = null;
            this.budgetRichTextBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.budgetRichTextBox1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.budgetRichTextBox1.Border.HoverVisible = false;
            this.budgetRichTextBox1.Border.Rounding = 6;
            this.budgetRichTextBox1.Border.Thickness = 1;
            this.budgetRichTextBox1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.budgetRichTextBox1.Border.Visible = true;
            this.budgetRichTextBox1.DataFilter = null;
            this.budgetRichTextBox1.Field = BudgetExecution.Field.RpioActivityCode;
            this.budgetRichTextBox1.Font = new System.Drawing.Font("Roboto", 9F);
            this.budgetRichTextBox1.ForeColor = System.Drawing.Color.White;
            this.budgetRichTextBox1.HoverText = null;
            this.budgetRichTextBox1.Location = new System.Drawing.Point(41, 75);
            this.budgetRichTextBox1.MaxLength = 2147483647;
            this.budgetRichTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.budgetRichTextBox1.Name = "budgetRichTextBox1";
            this.budgetRichTextBox1.Numeric = BudgetExecution.Numeric.NS;
            this.budgetRichTextBox1.ReadOnly = false;
            this.budgetRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.budgetRichTextBox1.ShowSelectionMargin = false;
            this.budgetRichTextBox1.Size = new System.Drawing.Size(499, 122);
            this.budgetRichTextBox1.TabIndex = 11;
            this.budgetRichTextBox1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.budgetRichTextBox1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.budgetRichTextBox1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.budgetRichTextBox1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.budgetRichTextBox1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.budgetRichTextBox1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.budgetRichTextBox1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.budgetRichTextBox1.ToolTip = null;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.BudgetImage = null;
            this.PictureBox.BudgetImageList = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(-1, -1);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Numeric = BudgetExecution.Numeric.NS;
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(24, 21);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 12;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionBarHeight = 3;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(576, 298);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.budgetRichTextBox1);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.CloseButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Message";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion
            public BudgetButton CloseButton;
            public BudgetButton OpenButton;
            public BudgetLabel HeaderLabel;
        private BudgetRichTextBox budgetRichTextBox1;
        private BudgetPictureBox PictureBox;
    }
    
}
