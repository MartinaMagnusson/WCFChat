using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFChatService.Entities
{
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
}
