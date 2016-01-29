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
        public void SaveToDatabase(UserMessage userMessage, User user, int roomId)
        {
            var query = @"INSERT INTO [dbo].[UserMessages] ([Message] ,[Posted] ,[Room_ID] ,[User_ID])
                          VALUES (@Message ,@TimeStamp ,@RoomID ,@UserID)";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                var cmd = new SqlCommand(query, connection);
                try
                {
                        cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = userMessage.Message;
                        cmd.Parameters.Add("@TimeStamp", SqlDbType.Date).Value = userMessage.TimeStamp;
                    cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomId;  
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = user.ID;

                    connection.Open();
                        cmd.ExecuteNonQuery();
                    connection.Close();
                    }
                catch (Exception)
                {
                    throw;
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
                    SqlCommand msgCounterCmd = new SqlCommand("SELECT * FROM [ChatDatabase].[dbo].[UserMessages]",connection);
                    using (SqlDataReader reader = msgCounterCmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            MessageCounter++;
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




        public void RegisterUser(User user, string key)
        {

            //Amend to a fault exception;
            if (CheckIfUserExists(user.UserName))
                throw new Exception();


                #region query

            //Unfinished Insert Command,
            //Using required
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

        private bool CheckIfUserExists(string username)
        {
            var result = "";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                connection.Open();
                #region query
                var cmd = new SqlCommand(@"SELECT [Username]
                            FROM[ChatDatabase].[dbo].[Users]
                             Where Username = '@userName'; ");
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
            if (result != "")
                return true;
        }

        public User LogInUser(string userName, string key)
            {
                connection.Open();
                #region query
                var cmd = new SqlCommand(@"SELECT [Username],[Password]
                            FROM[ChatDatabase].[dbo].[Users]
                             Where Username = @Username; ", connection);
                cmd.Parameters.Add(new SqlParameter("@Username", userName));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                loggedInUsers.Insert(0, userName);
                #endregion
            }

            //dealing with build error.
            throw new Exception();
            }

        public void LogOutUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
