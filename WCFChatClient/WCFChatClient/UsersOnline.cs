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
    public partial class UsersOnline : Form
    {
        public UsersOnline()
        {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            textBoxCurrentOnline.Text = "";
            var client = new ChatService.ChatClient();
            var onlineUsers = client.GetOnlineUsers();
            foreach (var user in onlineUsers)
            {
                string stringUser = "";
                for (int i = 0; i < user.Length; i++)
                {
                    if (i == 0)
                        stringUser += user[i].ToString().ToUpper();
                    else
                        stringUser += user[i].ToString().ToLower();
                }

                textBoxCurrentOnline.Text += stringUser + "\r\n";
            }
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            PopulateList();
        }
    }
}
