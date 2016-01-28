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
        void SubmitChatt(UserMessage post);

        [OperationContract]
        List<UserMessage> GetChats();
        [OperationContract]
        void RemoveChatt(int id);
        [OperationContract]
        void SaveToDatabase(UserMessage userMessage, User user);
        [OperationContract]
        List<UserMessage> GetChatFromDatabase(int roomID);


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
