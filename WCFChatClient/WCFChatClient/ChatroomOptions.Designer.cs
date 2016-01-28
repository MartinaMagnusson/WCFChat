namespace WCFChatClient
{
    partial class ChatroomOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatroomOptions));
            this.pictureBoxChatMan = new System.Windows.Forms.PictureBox();
            this.pictureBoxChatWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxChatUnisex = new System.Windows.Forms.PictureBox();
            this.labelMen = new System.Windows.Forms.Label();
            this.labelWomen = new System.Windows.Forms.Label();
            this.labelUnisex = new System.Windows.Forms.Label();
            this.labelLoggedinas = new System.Windows.Forms.Label();
            this.buttonJoinChatroomMen = new System.Windows.Forms.Button();
            this.buttonJoinChatroomUnisex = new System.Windows.Forms.Button();
            this.buttonJoinChatroomWomen = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatUnisex)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChatMan
            // 
            this.pictureBoxChatMan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChatMan.Image")));
            this.pictureBoxChatMan.Location = new System.Drawing.Point(11, 34);
            this.pictureBoxChatMan.Name = "pictureBoxChatMan";
            this.pictureBoxChatMan.Size = new System.Drawing.Size(106, 105);
            this.pictureBoxChatMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChatMan.TabIndex = 6;
            this.pictureBoxChatMan.TabStop = false;
            // 
            // pictureBoxChatWoman
            // 
            this.pictureBoxChatWoman.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChatWoman.Image")));
            this.pictureBoxChatWoman.Location = new System.Drawing.Point(251, 34);
            this.pictureBoxChatWoman.Name = "pictureBoxChatWoman";
            this.pictureBoxChatWoman.Size = new System.Drawing.Size(106, 105);
            this.pictureBoxChatWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChatWoman.TabIndex = 7;
            this.pictureBoxChatWoman.TabStop = false;
            // 
            // pictureBoxChatUnisex
            // 
            this.pictureBoxChatUnisex.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChatUnisex.Image")));
            this.pictureBoxChatUnisex.Location = new System.Drawing.Point(131, 34);
            this.pictureBoxChatUnisex.Name = "pictureBoxChatUnisex";
            this.pictureBoxChatUnisex.Size = new System.Drawing.Size(106, 105);
            this.pictureBoxChatUnisex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChatUnisex.TabIndex = 8;
            this.pictureBoxChatUnisex.TabStop = false;
            // 
            // labelMen
            // 
            this.labelMen.AutoSize = true;
            this.labelMen.Location = new System.Drawing.Point(12, 126);
            this.labelMen.Name = "labelMen";
            this.labelMen.Size = new System.Drawing.Size(28, 13);
            this.labelMen.TabIndex = 9;
            this.labelMen.Text = "Men";
            // 
            // labelWomen
            // 
            this.labelWomen.AutoSize = true;
            this.labelWomen.Location = new System.Drawing.Point(248, 126);
            this.labelWomen.Name = "labelWomen";
            this.labelWomen.Size = new System.Drawing.Size(44, 13);
            this.labelWomen.TabIndex = 10;
            this.labelWomen.Text = "Women";
            // 
            // labelUnisex
            // 
            this.labelUnisex.AutoSize = true;
            this.labelUnisex.Location = new System.Drawing.Point(128, 126);
            this.labelUnisex.Name = "labelUnisex";
            this.labelUnisex.Size = new System.Drawing.Size(39, 13);
            this.labelUnisex.TabIndex = 11;
            this.labelUnisex.Text = "Unisex";
            // 
            // labelLoggedinas
            // 
            this.labelLoggedinas.AutoSize = true;
            this.labelLoggedinas.Location = new System.Drawing.Point(8, 10);
            this.labelLoggedinas.Name = "labelLoggedinas";
            this.labelLoggedinas.Size = new System.Drawing.Size(71, 13);
            this.labelLoggedinas.TabIndex = 12;
            this.labelLoggedinas.Text = "Logged in as:";
            // 
            // buttonJoinChatroomMen
            // 
            this.buttonJoinChatroomMen.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonJoinChatroomMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJoinChatroomMen.Location = new System.Drawing.Point(11, 145);
            this.buttonJoinChatroomMen.Name = "buttonJoinChatroomMen";
            this.buttonJoinChatroomMen.Size = new System.Drawing.Size(106, 31);
            this.buttonJoinChatroomMen.TabIndex = 13;
            this.buttonJoinChatroomMen.Text = "Join";
            this.buttonJoinChatroomMen.UseVisualStyleBackColor = false;
            this.buttonJoinChatroomMen.Click += new System.EventHandler(this.buttonJoinChatroomMen_Click);
            // 
            // buttonJoinChatroomUnisex
            // 
            this.buttonJoinChatroomUnisex.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonJoinChatroomUnisex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJoinChatroomUnisex.Location = new System.Drawing.Point(131, 145);
            this.buttonJoinChatroomUnisex.Name = "buttonJoinChatroomUnisex";
            this.buttonJoinChatroomUnisex.Size = new System.Drawing.Size(106, 31);
            this.buttonJoinChatroomUnisex.TabIndex = 14;
            this.buttonJoinChatroomUnisex.Text = "Join";
            this.buttonJoinChatroomUnisex.UseVisualStyleBackColor = false;
            this.buttonJoinChatroomUnisex.Click += new System.EventHandler(this.buttonJoinChatroomUnisex_Click);
            // 
            // buttonJoinChatroomWomen
            // 
            this.buttonJoinChatroomWomen.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonJoinChatroomWomen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJoinChatroomWomen.Location = new System.Drawing.Point(251, 145);
            this.buttonJoinChatroomWomen.Name = "buttonJoinChatroomWomen";
            this.buttonJoinChatroomWomen.Size = new System.Drawing.Size(106, 31);
            this.buttonJoinChatroomWomen.TabIndex = 15;
            this.buttonJoinChatroomWomen.Text = "Join";
            this.buttonJoinChatroomWomen.UseVisualStyleBackColor = false;
            this.buttonJoinChatroomWomen.Click += new System.EventHandler(this.buttonJoinChatroomWomen_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(283, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.ForeColor = System.Drawing.Color.Black;
            this.labelCurrentUser.Location = new System.Drawing.Point(75, 10);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(33, 13);
            this.labelCurrentUser.TabIndex = 17;
            this.labelCurrentUser.Text = "User";
            // 
            // ChatroomOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 185);
            this.Controls.Add(this.labelCurrentUser);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonJoinChatroomWomen);
            this.Controls.Add(this.buttonJoinChatroomUnisex);
            this.Controls.Add(this.buttonJoinChatroomMen);
            this.Controls.Add(this.labelLoggedinas);
            this.Controls.Add(this.labelUnisex);
            this.Controls.Add(this.labelWomen);
            this.Controls.Add(this.labelMen);
            this.Controls.Add(this.pictureBoxChatUnisex);
            this.Controls.Add(this.pictureBoxChatWoman);
            this.Controls.Add(this.pictureBoxChatMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatroomOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AreYouSure);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatUnisex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxChatMan;
        private System.Windows.Forms.PictureBox pictureBoxChatWoman;
        private System.Windows.Forms.PictureBox pictureBoxChatUnisex;
        private System.Windows.Forms.Label labelMen;
        private System.Windows.Forms.Label labelWomen;
        private System.Windows.Forms.Label labelUnisex;
        private System.Windows.Forms.Label labelLoggedinas;
        private System.Windows.Forms.Button buttonJoinChatroomMen;
        private System.Windows.Forms.Button buttonJoinChatroomUnisex;
        private System.Windows.Forms.Button buttonJoinChatroomWomen;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelCurrentUser;
    }
}

