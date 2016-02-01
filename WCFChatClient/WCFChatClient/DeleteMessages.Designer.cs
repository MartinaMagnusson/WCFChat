namespace WCFChatClient
{
    partial class DeleteMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMessages));
            this.buttonDeleteMessages = new System.Windows.Forms.Button();
            this.textBoxMessageID = new System.Windows.Forms.TextBox();
            this.labelMessageID = new System.Windows.Forms.Label();
            this.listBoxDeleteMessages = new System.Windows.Forms.ListBox();
            this.buttonAddForDeletion = new System.Windows.Forms.Button();
            this.labelMyMessages = new System.Windows.Forms.Label();
            this.labelMessagesForDeletion = new System.Windows.Forms.Label();
            this.textBoxMyMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDeleteMessages
            // 
            this.buttonDeleteMessages.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMessages.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteMessages.Location = new System.Drawing.Point(405, 279);
            this.buttonDeleteMessages.Name = "buttonDeleteMessages";
            this.buttonDeleteMessages.Size = new System.Drawing.Size(113, 31);
            this.buttonDeleteMessages.TabIndex = 1;
            this.buttonDeleteMessages.Text = "Delete Messages";
            this.buttonDeleteMessages.UseVisualStyleBackColor = false;
            this.buttonDeleteMessages.Click += new System.EventHandler(this.buttonDeleteMessages_Click);
            // 
            // textBoxMessageID
            // 
            this.textBoxMessageID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessageID.Location = new System.Drawing.Point(77, 285);
            this.textBoxMessageID.Name = "textBoxMessageID";
            this.textBoxMessageID.Size = new System.Drawing.Size(65, 20);
            this.textBoxMessageID.TabIndex = 2;
            // 
            // labelMessageID
            // 
            this.labelMessageID.AutoSize = true;
            this.labelMessageID.Location = new System.Drawing.Point(12, 288);
            this.labelMessageID.Name = "labelMessageID";
            this.labelMessageID.Size = new System.Drawing.Size(64, 13);
            this.labelMessageID.TabIndex = 3;
            this.labelMessageID.Text = "Message ID";
            // 
            // listBoxDeleteMessages
            // 
            this.listBoxDeleteMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDeleteMessages.FormattingEnabled = true;
            this.listBoxDeleteMessages.Location = new System.Drawing.Point(405, 24);
            this.listBoxDeleteMessages.Name = "listBoxDeleteMessages";
            this.listBoxDeleteMessages.Size = new System.Drawing.Size(113, 249);
            this.listBoxDeleteMessages.TabIndex = 4;
            // 
            // buttonAddForDeletion
            // 
            this.buttonAddForDeletion.BackColor = System.Drawing.Color.Silver;
            this.buttonAddForDeletion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddForDeletion.ForeColor = System.Drawing.Color.Black;
            this.buttonAddForDeletion.Location = new System.Drawing.Point(148, 279);
            this.buttonAddForDeletion.Name = "buttonAddForDeletion";
            this.buttonAddForDeletion.Size = new System.Drawing.Size(113, 31);
            this.buttonAddForDeletion.TabIndex = 5;
            this.buttonAddForDeletion.Text = "Add For Deletion";
            this.buttonAddForDeletion.UseVisualStyleBackColor = false;
            this.buttonAddForDeletion.Click += new System.EventHandler(this.buttonAddForDeletion_Click);
            // 
            // labelMyMessages
            // 
            this.labelMyMessages.AutoSize = true;
            this.labelMyMessages.Location = new System.Drawing.Point(9, 8);
            this.labelMyMessages.Name = "labelMyMessages";
            this.labelMyMessages.Size = new System.Drawing.Size(72, 13);
            this.labelMyMessages.TabIndex = 6;
            this.labelMyMessages.Text = "My Messages";
            // 
            // labelMessagesForDeletion
            // 
            this.labelMessagesForDeletion.AutoSize = true;
            this.labelMessagesForDeletion.Location = new System.Drawing.Point(402, 8);
            this.labelMessagesForDeletion.Name = "labelMessagesForDeletion";
            this.labelMessagesForDeletion.Size = new System.Drawing.Size(112, 13);
            this.labelMessagesForDeletion.TabIndex = 7;
            this.labelMessagesForDeletion.Text = "Messages for Deletion";
            // 
            // textBoxMyMessages
            // 
            this.textBoxMyMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMyMessages.Location = new System.Drawing.Point(12, 24);
            this.textBoxMyMessages.Multiline = true;
            this.textBoxMyMessages.Name = "textBoxMyMessages";
            this.textBoxMyMessages.ReadOnly = true;
            this.textBoxMyMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMyMessages.Size = new System.Drawing.Size(387, 249);
            this.textBoxMyMessages.TabIndex = 8;
            // 
            // DeleteMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 321);
            this.Controls.Add(this.textBoxMyMessages);
            this.Controls.Add(this.labelMessagesForDeletion);
            this.Controls.Add(this.labelMyMessages);
            this.Controls.Add(this.buttonAddForDeletion);
            this.Controls.Add(this.listBoxDeleteMessages);
            this.Controls.Add(this.labelMessageID);
            this.Controls.Add(this.textBoxMessageID);
            this.Controls.Add(this.buttonDeleteMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteMessages";
            this.Text = "Delete Messages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteMessages;
        private System.Windows.Forms.TextBox textBoxMessageID;
        private System.Windows.Forms.Label labelMessageID;
        private System.Windows.Forms.ListBox listBoxDeleteMessages;
        private System.Windows.Forms.Button buttonAddForDeletion;
        private System.Windows.Forms.Label labelMyMessages;
        private System.Windows.Forms.Label labelMessagesForDeletion;
        private System.Windows.Forms.TextBox textBoxMyMessages;
    }
}