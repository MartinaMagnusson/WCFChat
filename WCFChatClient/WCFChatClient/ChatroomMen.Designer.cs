namespace WCFChatClient
{
    partial class ChatroomMen
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatroomMen));
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBoxSend = new System.Windows.Forms.PictureBox();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.pictureBoxMessage = new System.Windows.Forms.PictureBox();
            this.labelChatID = new System.Windows.Forms.Label();
            this.textBoxChatroomMen = new System.Windows.Forms.TextBox();
            this.pictureBoxBin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Location = new System.Drawing.Point(50, 275);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(495, 32);
            this.textBoxMessage.TabIndex = 1;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefresh.Image")));
            this.pictureBoxRefresh.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 3;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(47, 259);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Message";
            // 
            // pictureBoxSend
            // 
            this.pictureBoxSend.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSend.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSend.Image")));
            this.pictureBoxSend.Location = new System.Drawing.Point(551, 275);
            this.pictureBoxSend.Name = "pictureBoxSend";
            this.pictureBoxSend.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSend.TabIndex = 5;
            this.pictureBoxSend.TabStop = false;
            this.pictureBoxSend.Click += new System.EventHandler(this.pictureBoxSend_Click);
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(46, 8);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(85, 17);
            this.checkBoxAutoRefresh.TabIndex = 6;
            this.checkBoxAutoRefresh.Text = "Auto Refresh";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            // 
            // pictureBoxMessage
            // 
            this.pictureBoxMessage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMessage.Image")));
            this.pictureBoxMessage.Location = new System.Drawing.Point(12, 275);
            this.pictureBoxMessage.Name = "pictureBoxMessage";
            this.pictureBoxMessage.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMessage.TabIndex = 18;
            this.pictureBoxMessage.TabStop = false;
            // 
            // labelChatID
            // 
            this.labelChatID.AutoSize = true;
            this.labelChatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatID.Location = new System.Drawing.Point(538, 3);
            this.labelChatID.Name = "labelChatID";
            this.labelChatID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelChatID.Size = new System.Drawing.Size(47, 12);
            this.labelChatID.TabIndex = 19;
            this.labelChatID.Text = "Chat ID: 1";
            // 
            // textBoxChatroomMen
            // 
            this.textBoxChatroomMen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChatroomMen.Location = new System.Drawing.Point(12, 32);
            this.textBoxChatroomMen.Multiline = true;
            this.textBoxChatroomMen.Name = "textBoxChatroomMen";
            this.textBoxChatroomMen.ReadOnly = true;
            this.textBoxChatroomMen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChatroomMen.Size = new System.Drawing.Size(571, 213);
            this.textBoxChatroomMen.TabIndex = 20;
            // 
            // pictureBoxBin
            // 
            this.pictureBoxBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBin.Image")));
            this.pictureBoxBin.Location = new System.Drawing.Point(504, 3);
            this.pictureBoxBin.Name = "pictureBoxBin";
            this.pictureBoxBin.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBin.TabIndex = 21;
            this.pictureBoxBin.TabStop = false;
            this.pictureBoxBin.Click += new System.EventHandler(this.pictureBoxBin_Click);
            // 
            // ChatroomMen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 318);
            this.Controls.Add(this.pictureBoxBin);
            this.Controls.Add(this.textBoxChatroomMen);
            this.Controls.Add(this.labelChatID);
            this.Controls.Add(this.pictureBoxMessage);
            this.Controls.Add(this.checkBoxAutoRefresh);
            this.Controls.Add(this.pictureBoxSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatroomMen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatroom - Men";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBoxSend;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.PictureBox pictureBoxMessage;
        private System.Windows.Forms.Label labelChatID;
        private System.Windows.Forms.TextBox textBoxChatroomMen;
        private System.Windows.Forms.PictureBox pictureBoxBin;
    }
}