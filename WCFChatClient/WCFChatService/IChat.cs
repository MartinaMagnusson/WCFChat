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
        List<UserMessage> GetChats();
        [OperationContract]
        void RemoveChatt(int id);
        [OperationContract]
        void SaveToDatabase(UserMessage userMessage, User user, int roomId);
        [OperationContract]
        List<UserMessage> GetChatFromDatabase(int roomID);
        [OperationContract]
        void RegisterUser(User user,string key);
        [OperationContract]
        User LogInUser(string userName,string key);
        [OperationContract]
        void LogOutUser(string userName);
    }

    

    [DataContract]
    public class UserMessage
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Submitter { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public DateTime TimeStamp { get; set; }

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

}
