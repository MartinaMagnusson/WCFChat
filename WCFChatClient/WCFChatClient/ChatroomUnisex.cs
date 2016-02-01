using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFChatClient.ChatService;

namespace WCFChatClient
{
    public partial class ChatroomUnisex : Form
    {
        CurrentUser _currentUser;
        int roomID = 2;
        public ChatroomUnisex(CurrentUser user)
        {
            InitializeComponent();
            textBoxChat.Text = GlobalMethods.PopulateChatWithMessages(roomID, "Unisex");
            _currentUser = user;
        }

        private void pictureBoxSend_Click(object sender, EventArgs e)
        {
            var message = textBoxMessage.Text;
            var userID = int.Parse(_currentUser.ID);
            try
            {
                if (message != null && message != "")
                {
                    GlobalMethods.SubmitUserMessage("Unisex", _currentUser.UserName, message, userID, roomID);
                    var userMessage = GlobalMethods.GetUserMessages("Unisex", roomID);
                    textBoxChat.Text = "";
                    foreach (var item in userMessage)
                    {
                        textBoxChat.Text += string.Format("{0}: {1} ({2}) \r\n", item.Submitter, item.Message, item.TimeStamp.ToShortTimeString());
                    }
                    textBoxMessage.Text = "";
                }
            }
            catch (FaultException ex)
            {
                MessageBox.Show("Service error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client error: " + ex.Message);
            }
        }

        private void pictureBoxBin_Click(object sender, EventArgs e)
        {
            var deleteMessages = new DeleteMessages(_currentUser, 2);
            deleteMessages.ShowDialog();
        }
    }
}
