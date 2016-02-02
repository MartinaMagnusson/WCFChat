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
    public partial class Login : Form
    {
        ChatService.ChatClient _chatClient;
        public Login()
        {
            try
            {
                InitializeComponent();
                _chatClient = new ChatService.ChatClient("Unisex");
            }
            catch (FaultException ex)
            {
                MessageBox.Show("Service error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Client error");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                try
                {
                    var user = _chatClient.LogInUser(textBoxUsername.Text, textBoxPassword.Text);

                    if (user != null)
                    {
                        this.Hide();
                        ChatroomOptions chatroomOptions = new ChatroomOptions(user);
                        chatroomOptions.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Incorrect.");
                    }
                }
                catch (FaultException ex)
                {
                    MessageBox.Show("Service error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Client error");
                }
               
            }
            else
            {
                MessageBox.Show("Username & password required.");
            }
        }
    }
}
