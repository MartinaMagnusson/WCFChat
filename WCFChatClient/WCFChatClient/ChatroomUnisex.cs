﻿using System;
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
    public partial class ChatroomUnisex : Form
    {
        public ChatroomUnisex()
        {
            InitializeComponent();
            textBoxChat.Text = GlobalMethods.PopulateChatWithMessages(2);
        }
    }
}
