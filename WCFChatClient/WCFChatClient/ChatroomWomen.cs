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
    public partial class ChatroomWomen : Form
    {
        public ChatroomWomen()
        {
            InitializeComponent();
            textBoxChat.Text = GlobalMethods.PopulateChatWithMessages(3, "Woman");
        }

        private void pictureBoxBin_Click(object sender, EventArgs e)
        {
            var deleteMessages = new DeleteMessages();
            deleteMessages.ShowDialog();
        }
    }
}
