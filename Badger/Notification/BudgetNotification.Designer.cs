namespace BudgetExecution
{
    partial class BudgetNotification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetNotification));
            this.Title = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NotifyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Title.Location = new System.Drawing.Point(111, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(325, 26);
            this.Title.TabIndex = 0;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Message
            // 
            this.Message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Message.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Message.Location = new System.Drawing.Point(48, 59);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(388, 123);
            this.Message.TabIndex = 1;
            this.Message.Text = "Notification body";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Image = ((System.Drawing.Image)(resources.GetObject("NotifyIcon.Image")));
            this.NotifyIcon.Location = new System.Drawing.Point(1, 3);
            this.NotifyIcon.Name = "NotifyIcon";
            this.NotifyIcon.Size = new System.Drawing.Size(63, 23);
            this.NotifyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotifyIcon.TabIndex = 2;
            this.NotifyIcon.TabStop = false;
            // 
            // BudgetNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.BorderThickness = 2;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionBarHeight = 2;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(448, 205);
            this.ControlBox = false;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NotifyIcon);
            this.Controls.Add(this.Message);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Name = "BudgetNotification";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Notification";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.NotifyIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Message;
        public System.Windows.Forms.PictureBox NotifyIcon;
        private System.Windows.Forms.Timer Timer;
    }
}