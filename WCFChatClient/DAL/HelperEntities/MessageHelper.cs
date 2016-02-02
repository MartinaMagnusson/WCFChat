using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HelperEntities
{
    public class MessageHelper
    {
            public int ID { get; set; }

            public string Submitter { get; set; }

            public string Message { get; set; }

            public DateTime TimeStamp { get; set; }

            public int UserID { get; set; }

            public int RoomID { get; set; }
        
    }
}
