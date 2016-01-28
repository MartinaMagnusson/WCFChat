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
            this.pictureBoxChatUnisex.Location = new System.Drawing.Point(133, 34);
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
            this.labelUnisex.Location = new System.Drawing.Point(130, 126);
            this.labelUnisex.Name = "labelUnisex";
            this.labelUnisex.Size = new System.Drawing.Size(39, 13);
            this.labelUnisex.TabIndex = 11;
            this.labelUnisex.Text = "Unisex";
            // 
            // ChatOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 152);
            this.Controls.Add(this.labelUnisex);
            this.Controls.Add(this.labelWomen);
            this.Controls.Add(this.labelMen);
            this.Controls.Add(this.pictureBoxChatUnisex);
            this.Controls.Add(this.pictureBoxChatWoman);
            this.Controls.Add(this.pictureBoxChatMan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
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
    }
}

