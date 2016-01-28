using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace WCFChatService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChat
    {
        string connectionString = "Data Source=Badger;Initial Catalog=ChatDatabase;Integrated Security=True";
        List<Chat> _chats = new List<Chat>();



        public List<Chat> GetChats()
        {
            try
            {
                return _chats;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void RemoveChatt(int id)
        {
            _chats.Remove(_chats.Find(s => s.ID.Equals(id)));
        }
        public void SubmitChatt(Chat post)
        {
            post.ID = Guid.NewGuid().ToString();
            _chats.Add(post);
        }
        public void SaveToDatabase()
        {

        }
        public List<Chat> GetChatFromDatabase()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //SqlCommand cmd = new SqlCommand(@"SELECT [Message],[Posted],[RoomID],[UserId] FROM [dbo].");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            throw new Exception();
        }


    }
}
