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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(textBoxUsername.Text) || !String.IsNullOrEmpty(textBoxPassword.Text)) 
            {
                this.Hide();
                ChatroomOptions chatroomOptions = new ChatroomOptions();
                chatroomOptions.Show();
            }
            else if(String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Username or password Requiered.");
            }
            
        }
    }
}
