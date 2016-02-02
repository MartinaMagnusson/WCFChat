using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
        List<UserMessage> GetUserMessagesByRoomAndUserId(int roomId, int userId);
    }



    [DataContract]
    public class UserMessage
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Submitter { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public DateTime TimeStamp { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int RoomID { get; set; }
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Gender { get; set; }
    }

    [DataContract]
    public class CurrentUser
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Gender { get; set; }
    }
    [DataContract]
    public class Error
    {
        [DataMember]
        public int RoomID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public DateTime Time { get; set; }
        [DataMember]
        public string ErrorType { get; set; }
        [DataMember]
        public string Messages { get; set; }
    }
}
