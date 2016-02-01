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
    public partial class ChatroomMen : Form
    {
        CurrentUser _currentUser;
        int roomID = 1;
        public ChatroomMen(CurrentUser user)
        {
            InitializeComponent();
            textBoxChatroomMen.Text = GlobalMethods.PopulateChatWithMessages(1, "Man");
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
                    GlobalMethods.SubmitUserMessage(_currentUser.UserName, message, userID, roomID);
                    var userMessage = GlobalMethods.GetUserMessages().Last();
                    textBoxChatroomMen.Text += string.Format("{0}: {1} ({2}) \r\n", userMessage.Submitter, userMessage.Message, userMessage.TimeStamp.ToShortTimeString());
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
    }
}
