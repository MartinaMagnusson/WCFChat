using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFChatService;

namespace WCFChatClient
{
    public static class GlobalMethods
    {
        public static string PopulateChatWithMessages(int roomId)
        {
            var _chatClient = new ChatService.ChatClient();
            var userMessages = _chatClient.GetChatFromDatabase(roomId);

            string result = "";
            foreach (var message in userMessages)
            {
                result += string.Format("{0}: {1} ({2}) \r\n", message.Submitter, message.Message, message.TimeStamp.ToShortTimeString());
            }
            return result;
        }

    }
}
