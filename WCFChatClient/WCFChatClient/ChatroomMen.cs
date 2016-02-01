using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFChatClient.ChatService;

namespace WCFChatClient
{
    public partial class ChatroomMen : Form
    {
        public ChatroomMen()
        {
            InitializeComponent();
            textBoxChatroomMen.Text = GlobalMethods.PopulateChatWithMessages(1, "Man");
        }

        private void pictureBoxBin_Click(object sender, EventArgs e)
        {
            var deleteMessages = new DeleteMessages();
            deleteMessages.ShowDialog();
        }
    }
}
