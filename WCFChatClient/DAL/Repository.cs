using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.HelperEntities;

namespace DAL
{
    public class Repository
    {
        public void SaveMessagesToDatabase(List<MessageHelper> _MessagesBeingSavedToDatabase)
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
                    throw new Exception(ex.Message);
                }
            }
        }

        public void userRegistry(UserHelper user)
        {
            if (CheckIfUserExists(user.UserName))
                throw new Exception("Username unavailable");

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
                catch (Exception)
                {
                    throw new Exception($"Service error");
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
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
            if (result != "")
                return true;
            else
                return false;
        }
        public UserHelper LogInUser(string userName,string password)
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
                            return new UserHelper()
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
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
