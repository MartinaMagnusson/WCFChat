using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFChatClient.ChatService;

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
        public static void SubmitUserMessage(string message, int userID, int roomID)
        {
            var _chatClient = new ChatClient();
            var userMessage = new UserMessage();
            userMessage.Message = message;
            userMessage.UserID = userID;    
            userMessage.RoomID = roomID;
            _chatClient.SubmitUserMessage(userMessage);
        }   
    }
}
