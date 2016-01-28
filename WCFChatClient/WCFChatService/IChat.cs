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
        void SubmitChatt(Chat post);

        [OperationContract]
        List<Chat> GetChats();
        [OperationContract]
        void RemoveChatt(int id);
        [OperationContract]
        void SaveToDatabase();
        [OperationContract]
        List<Chat> GetChatFromDatabase(int roomID);


    }

    

    [DataContract]
    public class Chat
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

}
