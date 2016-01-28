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
        public void SubmitUserMessage(UserMessage post)
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




        public void RegisterUser(User user, string key)
        {

            //Amend to a fault exception;
            if (CheckIfUserExists(user.Username))
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
           @Username)");

            cmd.Parameters.Add(new SqlParameter("Password",key));
            cmd.Parameters.Add(new SqlParameter("Gender",user.Gender));
            cmd.Parameters.Add(new SqlParameter("Username",user.Username));

            #endregion

        }

        private bool CheckIfUserExists(string username)
        {
            //Partial Sql command
            var cmd = new SqlCommand(@"SELECT [UserID]
                            ,[Password]
                            ,[Gender]
                            ,[Username]
                            FROM[ChatDatabase].[dbo].[Users]
                             Where Username = '@userName'; ");
            cmd.Parameters.Add(new SqlParameter("@userName",username));

            //Defaulting true until method is finished.
            return true;
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
