using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFChatService.Entities;

namespace WCFChatService
{
    [ServiceContract]
    public interface IChat
    {
        [OperationContract]
        void SubmitUserMessage(UserMessage post);

        [OperationContract]
        List<UserMessage> GetUserMessages(int roomID);
        [OperationContract]
        void RemoveUserMessage(UserMessage userMessage);
        [OperationContract]
        void SaveToDatabase();
        [OperationContract]
        List<UserMessage> GetChatFromDatabase(int roomID);
        [OperationContract]
        void RegisterUser(User user);
        [OperationContract]
        CurrentUser LogInUser(string userName, string password);
        [OperationContract]
        void LogOutUser(string userName);
        [OperationContract]
        List<string> GetOnlineUsers();
        [OperationContract]
        List<UserMessage> GetUserMessagesByRoomAndUserId(int roomId,int userId);
    }
}
