namespace BudgetExecution
{
    partial class PictureControl
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
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PictureBox = new BudgetExecution.PicturePanel();
            this.BudgetBinding = new BudgetExecution.BudgetBinding();
            this.ImageList = new BudgetExecution.ImageList();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.BackBase = new BudgetExecution.BudgetLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).BeginInit();
            this.BackBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.PictureBox.BindingSource = this.BudgetBinding;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Field = BudgetExecution.Field.NS;
            this.PictureBox.HoverText = null;
            this.PictureBox.ImageList = this.ImageList;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(101, 62);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = this.ToolTip;
            // 
            // BudgetBinding
            // 
            this.BudgetBinding.DataFilter = null;
            this.BudgetBinding.Numeric = BudgetExecution.Numeric.NS;
            // 
            // ImageList
            // 
            this.ImageList.BindingSouce = null;
            this.ImageList.BudgetImage = null;
            this.ImageList.BudgetImages = null;
            this.ImageList.Source = BudgetExecution.ImageSource.NS;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.Color.Blue;
            this.ToolTip.ForeColor = System.Drawing.Color.LightGray;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipTitle = "";
            // 
            // BackPanel
            // 
            this.BackBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackBase.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackBase.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackBase.BindingSource = null;
            this.BackBase.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.BackBase.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.BackBase.Border.HoverVisible = false;
            this.BackBase.Border.Rounding = 6;
            this.BackBase.Border.Thickness = 1;
            this.BackBase.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.BackBase.Border.Visible = true;
            this.BackBase.Children = null;
            this.BackBase.Controls.Add(this.PictureBox);
            this.BackBase.DataFilter = null;
            this.BackBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBase.Field = BudgetExecution.Field.NS;
            this.BackBase.ForeColor = System.Drawing.Color.LightGray;
            this.BackBase.Location = new System.Drawing.Point(0, 0);
            this.BackBase.Margin = new System.Windows.Forms.Padding(5);
            this.BackBase.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BackBase.Name = "BackBase";
            this.BackBase.Padding = new System.Windows.Forms.Padding(1);
            this.BackBase.Size = new System.Drawing.Size(101, 62);
            this.BackBase.TabIndex = 1;
            this.BackBase.Text = "layoutPanel1";
            this.BackBase.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.BackBase.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackBase.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackBase.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackBase.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BackBase.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.BackBase.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BackBase.ToolTip = null;
            // 
            // PictureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.Controls.Add(this.BackBase);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PictureControl";
            this.Size = new System.Drawing.Size(101, 62);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetBinding)).EndInit();
            this.BackBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public LayoutBase BackBase;
        public BudgetBinding BudgetBinding;
        private ImageList ImageList;
        public ToolTip ToolTip;
        public PicturePanel PictureBox;
    }
}
