﻿using System;
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
        List<UserMessage> _MessagesBeingSavedToDatabase = new List<UserMessage>();
        List<UserMessage> _currentUserMessages = new List<UserMessage>();
        List<string> loggedInUsers = new List<string>();
        int MessageCounter;

        public List<UserMessage> GetUserMessages(int roomID)
        {
            var messages = new List<UserMessage>();
            try
            {
                foreach (var message in _currentUserMessages)
                {
                    if (message.RoomID == roomID)
                        messages.Add(message);
                }
                return messages;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

        }

        public void RemoveUserMessage(UserMessage userMessage)
        {
            try
            {
                _currentUserMessages.Remove(_currentUserMessages.Find(s => s.ID.Equals(userMessage.ID)));
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void SubmitUserMessage(UserMessage post)
        {
            try
            {
                MessageCounter++;
                post.ID = MessageCounter;
                _currentUserMessages.Add(post);
                _MessagesBeingSavedToDatabase.Add(post);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }

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
                    foreach (var userMessage in _MessagesBeingSavedToDatabase)
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

            if (_currentUserMessages.Count < 20)
            {
                var messageCountToRetrieve = 20 - _currentUserMessages.Count;
                var date = new DateTime();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        #region query
                        SqlCommand cmd = new SqlCommand(@"SELECT TOP (@amount) [MessageID]
      ,[Message]
      ,[Posted]
      ,[Room_ID]
      ,[User_ID]
	  ,[Username]
  FROM [dbo].[UserMessages]
  INNER JOIN [dbo].[Users]
  ON [dbo].[UserMessages].[User_ID] = [dbo].[Users].[UserID]
  WHERE [dbo].[UserMessages].Room_ID = @ID
  ORDER by MessageID desc", connection);
                        cmd.Parameters.Add(new SqlParameter("@ID", roomID));
                        cmd.Parameters.Add(new SqlParameter("@amount", messageCountToRetrieve));
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
                            _databaseUserMessages.Reverse();

                        }
                        #region CounterQuery
                        SqlCommand msgCounterCmd = new SqlCommand("SELECT * FROM [ChatDatabase].[dbo].[UserMessages]", connection);
                        using (SqlDataReader reader = msgCounterCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageCounter++;
                            }
                        }
                        #endregion
                    }
                    catch (SqlException ex)
                    {
                        throw new FaultException($"SQL error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        throw new FaultException(ex.Message);
                    }
                }
            }
            else
            {
                //Limits the amount of messages a new client receives, if the current session includes more then 20 messages there is no need to query database.
                return _currentUserMessages.Skip(_currentUserMessages.Count - 20).Take(20).ToList();
            }
            _currentUserMessages.Reverse();
            foreach (var message in _databaseUserMessages)
            {
                _currentUserMessages.Add(message);
            }
            _currentUserMessages.Reverse();

            return _currentUserMessages;
        }
        public void RegisterUser(User user)
        {

            if (CheckIfUserExists(user.UserName))
                throw new FaultException("Username unavailable");

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                try
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
                catch (SqlException ex)
                {
                    throw new FaultException($"SQL server error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    throw new FaultException($"Service error: {ex.Message}");

                }

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
                catch (SqlException ex)
                {
                    throw new FaultException($"SQL error: {ex.Message}");
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

        public List<UserMessage> GetUserMessagesByRoomAndUserId(int roomId, int userId)
        {
            var MessageList = new List<UserMessage>();
            try
            {
                foreach (var message in _currentUserMessages)
                {
                    if (message.RoomID == roomId && message.UserID == userId)
                    {
                        MessageList.Add(message);
                    }
                }

                //          var date = new DateTime();
                //          using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
                //          {
                //              try
                //              {
                //                  connection.Open();
                //                  #region query
                //                  SqlCommand cmd = new SqlCommand(@"SELECT [MessageID]
                //    ,[Message]
                //    ,[Posted]
                //    ,[Room_ID]
                //    ,[User_ID]
                // ,[Username]
                //FROM [ChatDatabase].[dbo].[UserMessages]
                //INNER JOIN [ChatDatabase].[dbo].[Users]
                //ON [dbo].[UserMessages].[User_ID] = [dbo].[Users].[UserID]
                //WHERE [ChatDatabase].[dbo].[UserMessages].Room_ID = @ID AND [ChatDatabase].[dbo].[UserMessages].[User_ID] = @UserId", connection);
                //                  cmd.Parameters.Add(new SqlParameter("@ID", roomId));
                //                  cmd.Parameters.Add(new SqlParameter("@UserId", userId));
                //                  #endregion

                //                  using (SqlDataReader reader = cmd.ExecuteReader())
                //                  {
                //                      while (reader.Read())
                //                      {
                //                          var chat = new UserMessage();
                //                          DateTime.TryParse((string)reader["Posted"], out date);


                //                          chat.ID = (int)reader["MessageID"];
                //                          chat.Submitter = (string)reader["Username"];
                //                          chat.Message = (string)reader["Message"];
                //                          chat.TimeStamp = date;


                //                          MessageList.Add(chat);
                //                      }

                //                  }


            }
            catch (SqlException ex)
            {
                throw new FaultException($"SQL error: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new FaultException($"{ex.Message}");
            }
            return MessageList;
        }
        public void ErrorMessages(Error error)
        {
            var query = @"INSERT INTO [dbo].[ErrorMessages] ([Room_ID] ,[UserName] ,[Time] ,[Messages] ,[Type])
                          VALUES (@RoomID ,@UserName ,@Time ,@Messages ,@Type)";
 
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChatDatabase"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@RoomID", SqlDbType.Int).Value = error.RoomID;
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = error.UserName;
                    cmd.Parameters.Add("@Time", SqlDbType.Date).Value = error.Time;
                    cmd.Parameters.Add("@Messages", SqlDbType.VarChar).Value = error.Messages;
                    cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = error.ErrorType;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new FaultException(ex.Message);
                }
            }
        }
    }
}
