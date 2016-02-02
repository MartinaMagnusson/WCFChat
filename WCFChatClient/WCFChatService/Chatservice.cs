using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using WCFChatService.Entities;
using DAL;
using DAL.HelperEntities;

namespace WCFChatService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChat
    {
        Repository repo = new Repository();
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
           var listToSave = new List<MessageHelper>();
            foreach (var message in _MessagesBeingSavedToDatabase)
            {
                var convertedMessage = new MessageHelper()
                {
                    ID = message.ID,
                    Submitter = message.Submitter,
                    Message = message.Message,
                    TimeStamp = message.TimeStamp,
                    UserID = message.UserID,
                    RoomID = message.RoomID
                };
                listToSave.Add(convertedMessage);
            }
            repo.SaveMessagesToDatabase(listToSave);
        }
        public void RegisterUser(User user)
        {
            var convertedUser = new UserHelper()
            {
                ID = user.ID,
                Password = user.Password,
                Gender = user.Gender,
                UserName = user.UserName
            };
            repo.userRegistry(convertedUser);
        }

        public CurrentUser LogInUser(string userName, string password)
        {
            var convertedUser = repo.LogInUser(userName,password);

            if(convertedUser != null)
            loggedInUsers.Add(userName.ToUpper());
            return new CurrentUser()
            {
                ID = convertedUser.ID,
                UserName = convertedUser.UserName,
                Gender = convertedUser.Gender
            };
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
    }
}
