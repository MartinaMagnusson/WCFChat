using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace WCFChatService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChat
    {
        List<UserMessage> _currentUserMessages = new List<UserMessage>();

        public List<UserMessage> GetChats()
        {
            try
            {
                return _currentUserMessages;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void RemoveChatt(int id)
        {
            _currentUserMessages.Remove(_currentUserMessages.Find(s => s.ID.Equals(id)));
        }
        public void SubmitChatt(UserMessage post)
        {
            post.ID = Guid.NewGuid().ToString();
            _currentUserMessages.Add(post);
        }
        public void SaveToDatabase()
        {

        }
        public List<UserMessage> GetChatFromDatabase(int roomID)
        {
            List<UserMessage> _databaseUserMessages = new List<UserMessage>();
            var date = new DateTime();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
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
                                                    WHERE [dbo].[UserMessages].Room_ID = @ID", connection);
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


                            _databaseUserMessages.Add(chat);
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return _databaseUserMessages;
        }




        public void RegisterUser(string userName, string password, string gender)
        {
            throw new NotImplementedException();
        }

        public User LogInUser(string userName, string key)
        {
            throw new NotImplementedException();
        }

        public void LogOutUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
