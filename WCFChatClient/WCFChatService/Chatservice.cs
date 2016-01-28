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
        List<Chat> _currentChats = new List<Chat>();
        List<Chat> _databaseChats = new List<Chat>();



        public List<Chat> GetChats()
        {
            try
            {
                return _currentChats;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void RemoveChatt(int id)
        {
            _currentChats.Remove(_currentChats.Find(s => s.ID.Equals(id)));
        }
        public void SubmitChatt(Chat post)
        {
            post.ID = Guid.NewGuid().ToString();
            _currentChats.Add(post);
        }
        public void SaveToDatabase()
        {

        }
        public List<Chat> GetChatFromDatabase(int roomID)
        {
            var chat = new Chat();
            
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    #region query
                    SqlCommand cmd = new SqlCommand(@"SELECT [MessageID]
      ,[Message]
      ,[Posted]
      ,[Room_ID]
      ,[User_ID]
	  ,[Username]
  FROM [dbo].[UserMessages]
  INNER JOIN [dbo].[Users]
  ON [dbo].[UserMessages].[User_ID] = [dbo].[Users].[UserID]
  WHERE [dbo].[UserMessages].Room_ID = @ID");
                    SqlParameter idParam = new SqlParameter();
                    idParam.ParameterName = "@ID";
                    idParam.Value = roomID;
                    cmd.Parameters.Add(idParam);
                    #endregion

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            chat.ID = (string)reader["MessageID"];
                            chat.Submitter = (string)reader["Username"];
                            chat.TimeStamp = (DateTime)reader["Posted"];
                            chat.Message = (string)reader["Message"];
                            _databaseChats.Add(chat);
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return _databaseChats;
        }


    }
}
