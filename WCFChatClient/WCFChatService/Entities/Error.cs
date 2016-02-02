using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFChatService.Entities
{
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
        public string Messages { get; set; }
        [DataMember]
        public string ErrorType { get; set; }
    }
}
