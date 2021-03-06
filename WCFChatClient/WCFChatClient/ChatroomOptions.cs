﻿using System;
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
    public partial class ChatroomOptions : Form
    {
        CurrentUser _currentUser;
        ChatService.ChatClient _client;
        Timer _timer;
        public ChatroomOptions(CurrentUser user)
        {
            InitializeComponent();
            this._currentUser = user;
            this._client = new ChatService.ChatClient("Unisex");
            SetComponentsToCorrectState(user);
            PopulateCurrentOnlineUsersCounter();

            _timer = new Timer();
            _timer.Interval = 3000;
            _timer.Tick += RefreshCounter;
            _timer.Start();
        }

        private void RefreshCounter(object sender, EventArgs e)
        {
            PopulateCurrentOnlineUsersCounter();

        }

        private void PopulateCurrentOnlineUsersCounter()
        {
            labelOnlineCounter.Text = _client.GetOnlineUsers().Count().ToString();
        }

        private void SetComponentsToCorrectState(CurrentUser user)
        {
            labelCurrentUser.Text = _currentUser.UserName;

            if (user.Gender != "Man")
            {
                buttonJoinChatroomMen.Enabled = false;
                buttonJoinChatroomMen.BackColor = Color.LightGray;
                pictureBoxChatMan.Enabled = false;
            }
            if (user.Gender != "Woman")
            {
                buttonJoinChatroomWomen.Enabled = false;
                buttonJoinChatroomWomen.BackColor = Color.LightGray;
                pictureBoxChatWoman.Enabled = false;
            }

        }

        private void buttonJoinChatroomMen_Click(object sender, EventArgs e)
        {
            ChatroomMen chatroomMen = new ChatroomMen(_currentUser);
            chatroomMen.ShowDialog();
        }


        private void buttonJoinChatroomUnisex_Click(object sender, EventArgs e)
        {
            ChatroomUnisex chatroomUnisex = new ChatroomUnisex(_currentUser);
            chatroomUnisex.ShowDialog();
        }

        private void buttonJoinChatroomWomen_Click(object sender, EventArgs e)
        {
            ChatroomWomen chatroomWomen = new ChatroomWomen(_currentUser);
            chatroomWomen.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            _client.LogOutUser(_currentUser.UserName);

            var login = new Login();
            login.Show();
        }

        private void pictureBoxUsersOnline_Click(object sender, EventArgs e)
        {
            var usersOnline = new UsersOnline();
            usersOnline.Show();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            PopulateCurrentOnlineUsersCounter();
        }

        private void AreYouSure(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close and logout?", "Close application?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                buttonLogout_Click(this, new EventArgs());
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
