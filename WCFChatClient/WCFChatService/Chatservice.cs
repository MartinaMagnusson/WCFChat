using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WCFChatService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChat
    {
        List<UserMessage> _currentUserMessages = new List<UserMessage>();
        List<string> loggedInUsers = new List<string>();
        int MessageCounter;

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

        public void RemoveUserMessage(int id)
        {
            _currentUserMessages.Remove(_currentUserMessages.Find(s => s.ID.Equals(id)));
        }
        public void SubmitUserMessage(UserMessage post)
        {
            MessageCounter++;
            post.ID = MessageCounter;
            _currentUserMessages.Add(post);
        }
        public void SaveToDatabase()
        {
            var query = @"INSERT INTO [dbo].[UserMessages] ([Message] ,[Posted] ,[Room_ID] ,[User_ID])
                          VALUES (@Message ,@TimeStamp ,@RoomID ,@UserID)";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    foreach (var userMessage in _currentUserMessages)
                    {
                        var cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = userMessage.Message;
                        cmd.Parameters.Add("@TimeStamp", SqlDbType.Date).Value = userMessage.TimeStamp;
                        cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = userMessage.RoomID;
                        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = userMessage.UserID;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            }
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
                    SqlCommand cmd = new SqlCommand(@"SELECT TOP 20 [MessageID]
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


                            chat.ID = (int)reader["MessageID"];
                            chat.Submitter = (string)reader["Username"];
                            chat.Message = (string)reader["Message"];
                            chat.TimeStamp = date;


                            _databaseUserMessages.Add(chat);
                        }

                    }
                    SqlCommand msgCounterCmd = new SqlCommand("SELECT * FROM [ChatDatabase].[dbo].[UserMessages]", connection);
                    using (SqlDataReader reader = msgCounterCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageCounter++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            }
            return _databaseUserMessages;
        }
        public void RegisterUser(User user)
        {

            if (CheckIfUserExists(user.UserName))
                throw new FaultException("Username unavailable");

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                connection.Open();
                #region query

                var cmd = new SqlCommand(@"INSERT INTO [dbo].[Users]
           ([Password]
           ,[Gender]
           ,[Username])
            VALUES
           (@Password,
           @Gender,
           @Username)", connection);
                cmd.Parameters.Add(new SqlParameter("Password", user.Password));
                cmd.Parameters.Add(new SqlParameter("Gender", user.Gender));
                cmd.Parameters.Add(new SqlParameter("Username", user.UserName));
                cmd.ExecuteNonQuery();
                #endregion
            }
        }

        private bool CheckIfUserExists(string username)
        {
            var result = "";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    #region query
                    var cmd = new SqlCommand(@"SELECT [Username]
                            FROM[ChatDatabase].[dbo].[Users]
                             WHERE Username = @userName", connection);
                    cmd.Parameters.Add(new SqlParameter("@userName", username));
                    #endregion
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = (string)reader["Username"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }

            }
            if (result != "")
                return true;
            else
                return false;
        }

        public CurrentUser LogInUser(string userName, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                try
                {
                    #region query
                    var sqlCommand = new SqlCommand(@"SELECT [UserID], [Gender], [Username], [Password]
                            FROM [Users]
                            WHERE Username = @username AND Password = @password", connection);
                    sqlCommand.Parameters.Add(new SqlParameter("@username", userName));
                    sqlCommand.Parameters.Add(new SqlParameter("@password", password));
                    #endregion
                    connection.Open();
                    var reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["Username"].ToString() != "" && reader["Password"].ToString() != "")
                        {
                            loggedInUsers.Add(userName.ToUpper());
                            return new CurrentUser()
                            {
                                UserName = reader["Username"].ToString(),
                                ID = reader["UserID"].ToString(),
                                Gender = reader["Gender"].ToString()
                            };
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            }
        }
        public void LogOutUser(string userName)
        {
            loggedInUsers.Remove(userName.ToUpper());
        }

        public List<string> GetOnlineUsers()
        {
            return loggedInUsers;
        }
    }
}
