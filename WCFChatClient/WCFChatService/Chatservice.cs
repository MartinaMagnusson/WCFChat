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
        List<UserMessage> _currentChats = new List<UserMessage>();
        List<UserMessage> _databaseChats = new List<UserMessage>();



        public List<UserMessage> GetChats()
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
        public void SubmitChatt(UserMessage post)
        {
            post.ID = Guid.NewGuid().ToString();
            _currentChats.Add(post);
        }
        public void SaveToDatabase()
        {

        }
        public List<UserMessage> GetChatFromDatabase(int roomID)
        {
            
            var date = new DateTime();
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
  WHERE [dbo].[UserMessages].Room_ID = @ID",connection);
                    SqlParameter idParam = new SqlParameter();
                    idParam.ParameterName = "@ID";
                    idParam.Value = roomID;
                    cmd.Parameters.Add(idParam);
                    #endregion

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var chat = new UserMessage();
                            DateTime.TryParse((string)reader["Posted"], out date);


                            chat.ID = reader["MessageID"].ToString();
                            chat.Submitter = (string)reader["Username"];
                            chat.Message = (string)reader["Message"];
                            chat.TimeStamp = date;


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
