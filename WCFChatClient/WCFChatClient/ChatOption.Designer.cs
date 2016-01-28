namespace WCFChatClient
{
    partial class ChatOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatOption));
            this.pictureBoxChatMan = new System.Windows.Forms.PictureBox();
            this.pictureBoxChatWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxChatUnisex = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatUnisex)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxChatMan
            // 
            this.pictureBoxChatMan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChatMan.Image")));
            this.pictureBoxChatMan.Location = new System.Drawing.Point(11, 40);
            this.pictureBoxChatMan.Name = "pictureBoxChatMan";
            this.pictureBoxChatMan.Size = new System.Drawing.Size(106, 99);
            this.pictureBoxChatMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChatMan.TabIndex = 6;
            this.pictureBoxChatMan.TabStop = false;
            // 
            // pictureBoxChatWoman
            // 
            this.pictureBoxChatWoman.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChatWoman.Image")));
            this.pictureBoxChatWoman.Location = new System.Drawing.Point(251, 40);
            this.pictureBoxChatWoman.Name = "pictureBoxChatWoman";
            this.pictureBoxChatWoman.Size = new System.Drawing.Size(106, 99);
            this.pictureBoxChatWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChatWoman.TabIndex = 7;
            this.pictureBoxChatWoman.TabStop = false;
            // 
            // pictureBoxChatUnisex
            // 
            this.pictureBoxChatUnisex.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChatUnisex.Image")));
            this.pictureBoxChatUnisex.Location = new System.Drawing.Point(133, 40);
            this.pictureBoxChatUnisex.Name = "pictureBoxChatUnisex";
            this.pictureBoxChatUnisex.Size = new System.Drawing.Size(106, 99);
            this.pictureBoxChatUnisex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChatUnisex.TabIndex = 8;
            this.pictureBoxChatUnisex.TabStop = false;
            // 
            // ChatOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 162);
            this.Controls.Add(this.pictureBoxChatUnisex);
            this.Controls.Add(this.pictureBoxChatWoman);
            this.Controls.Add(this.pictureBoxChatMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChatUnisex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxChatMan;
        private System.Windows.Forms.PictureBox pictureBoxChatWoman;
        private System.Windows.Forms.PictureBox pictureBoxChatUnisex;
    }
}

