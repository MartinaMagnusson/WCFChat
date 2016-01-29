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
            var _chatClient = new ChatClient();
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
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
