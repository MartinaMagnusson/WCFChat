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
        public static string PopulateChatWithMessages(int roomId, string endpoint)
        {
            var _chatClient = new ChatService.ChatClient(endpoint);
            var userMessages = _chatClient.GetChatFromDatabase(roomId);

            string result = "";
            foreach (var message in userMessages)
            {
                result += string.Format("{0}: {1} ({2}) \r\n", message.Submitter, message.Message, message.TimeStamp.ToShortTimeString());
            }
            return result;
        }
        public static void SubmitUserMessage(string endpoint, string userName, string message, int userID, int roomID)
        {
            var _chatClient = new ChatClient(endpoint);
            var userMessage = new UserMessage();
            userMessage.Message = message;
            userMessage.UserID = userID;
            userMessage.RoomID = roomID;
            userMessage.Submitter = userName;
            userMessage.TimeStamp = DateTime.Now;
            _chatClient.SubmitUserMessage(userMessage);
        }
        public static UserMessage[] GetUserMessages(string endpoint)
        {
            var _chatClient = new ChatClient(endpoint);
            var message = _chatClient.GetChats();
            return message;
        }
    }
}
