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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var _chatClient = new ChatClient("Unisex");
            var user = new User();
            try
            {
                if (textBoxUsername.Text != null && textBoxUsername.Text != "" && textBoxPassword.Text != null && textBoxPassword.Text != "" &&
                    (radioButtonMan.Checked || radioButtonWoman.Checked))
                {
                    user.UserName = textBoxUsername.Text;
                    user.Password = textBoxPassword.Text;
                    if (radioButtonMan.Checked)
                        user.Gender = radioButtonMan.Text;
                    if (radioButtonWoman.Checked)
                        user.Gender = radioButtonWoman.Text;
                    _chatClient.RegisterUser(user);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("All fields must be completed");
                }
            }
            catch (FaultException ex)
            {
                GlobalMethods.ErrorMessages("Unisex", "Service error", ex.Message);
                MessageBox.Show("Service error");
            }
            catch (Exception ex)
            {
                GlobalMethods.ErrorMessages("Unisex", "Client error", ex.Message);
                MessageBox.Show("Client error");
            }
        }
    }
}
