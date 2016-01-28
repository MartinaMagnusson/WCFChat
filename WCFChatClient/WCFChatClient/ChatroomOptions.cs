using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFChatClient
{
    public partial class ChatroomOptions : Form
    {
        public ChatroomOptions()
        {
            InitializeComponent();
        }

        private void buttonJoinChatroomMen_Click(object sender, EventArgs e)
        {
            ChatroomMen chatroomMen = new ChatroomMen();
            chatroomMen.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

        private void AreYouSure(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close and logout?", "Close application?", MessageBoxButtons.YesNo);
            // Logik för vad man trycker på
        }
    }
}
