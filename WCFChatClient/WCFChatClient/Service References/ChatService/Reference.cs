﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFChatClient.ChatService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserMessage", Namespace="http://schemas.datacontract.org/2004/07/WCFChatService")]
    [System.SerializableAttribute()]
    public partial class UserMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubmitterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomID {
            get {
                return this.RoomIDField;
            }
            set {
                if ((this.RoomIDField.Equals(value) != true)) {
                    this.RoomIDField = value;
                    this.RaisePropertyChanged("RoomID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Submitter {
            get {
                return this.SubmitterField;
            }
            set {
                if ((object.ReferenceEquals(this.SubmitterField, value) != true)) {
                    this.SubmitterField = value;
                    this.RaisePropertyChanged("Submitter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/WCFChatService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CurrentUser", Namespace="http://schemas.datacontract.org/2004/07/WCFChatService")]
    [System.SerializableAttribute()]
    public partial class CurrentUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/WCFChatService")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorType {
            get {
                return this.ErrorTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTypeField, value) != true)) {
                    this.ErrorTypeField = value;
                    this.RaisePropertyChanged("ErrorType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Messages {
            get {
                return this.MessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagesField, value) != true)) {
                    this.MessagesField = value;
                    this.RaisePropertyChanged("Messages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoomID {
            get {
                return this.RoomIDField;
            }
            set {
                if ((this.RoomIDField.Equals(value) != true)) {
                    this.RoomIDField = value;
                    this.RaisePropertyChanged("RoomID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ChatService.IChat")]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SubmitUserMessage", ReplyAction="http://tempuri.org/IChat/SubmitUserMessageResponse")]
        void SubmitUserMessage(WCFChatClient.ChatService.UserMessage post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SubmitUserMessage", ReplyAction="http://tempuri.org/IChat/SubmitUserMessageResponse")]
        System.Threading.Tasks.Task SubmitUserMessageAsync(WCFChatClient.ChatService.UserMessage post);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetUserMessages", ReplyAction="http://tempuri.org/IChat/GetUserMessagesResponse")]
        WCFChatClient.ChatService.UserMessage[] GetUserMessages(int roomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetUserMessages", ReplyAction="http://tempuri.org/IChat/GetUserMessagesResponse")]
        System.Threading.Tasks.Task<WCFChatClient.ChatService.UserMessage[]> GetUserMessagesAsync(int roomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/RemoveUserMessage", ReplyAction="http://tempuri.org/IChat/RemoveUserMessageResponse")]
        void RemoveUserMessage(WCFChatClient.ChatService.UserMessage userMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/RemoveUserMessage", ReplyAction="http://tempuri.org/IChat/RemoveUserMessageResponse")]
        System.Threading.Tasks.Task RemoveUserMessageAsync(WCFChatClient.ChatService.UserMessage userMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SaveToDatabase", ReplyAction="http://tempuri.org/IChat/SaveToDatabaseResponse")]
        void SaveToDatabase();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/SaveToDatabase", ReplyAction="http://tempuri.org/IChat/SaveToDatabaseResponse")]
        System.Threading.Tasks.Task SaveToDatabaseAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetChatFromDatabase", ReplyAction="http://tempuri.org/IChat/GetChatFromDatabaseResponse")]
        WCFChatClient.ChatService.UserMessage[] GetChatFromDatabase(int roomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetChatFromDatabase", ReplyAction="http://tempuri.org/IChat/GetChatFromDatabaseResponse")]
        System.Threading.Tasks.Task<WCFChatClient.ChatService.UserMessage[]> GetChatFromDatabaseAsync(int roomID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/RegisterUser", ReplyAction="http://tempuri.org/IChat/RegisterUserResponse")]
        void RegisterUser(WCFChatClient.ChatService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/RegisterUser", ReplyAction="http://tempuri.org/IChat/RegisterUserResponse")]
        System.Threading.Tasks.Task RegisterUserAsync(WCFChatClient.ChatService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/LogInUser", ReplyAction="http://tempuri.org/IChat/LogInUserResponse")]
        WCFChatClient.ChatService.CurrentUser LogInUser(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/LogInUser", ReplyAction="http://tempuri.org/IChat/LogInUserResponse")]
        System.Threading.Tasks.Task<WCFChatClient.ChatService.CurrentUser> LogInUserAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/LogOutUser", ReplyAction="http://tempuri.org/IChat/LogOutUserResponse")]
        void LogOutUser(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/LogOutUser", ReplyAction="http://tempuri.org/IChat/LogOutUserResponse")]
        System.Threading.Tasks.Task LogOutUserAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetOnlineUsers", ReplyAction="http://tempuri.org/IChat/GetOnlineUsersResponse")]
        string[] GetOnlineUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetOnlineUsers", ReplyAction="http://tempuri.org/IChat/GetOnlineUsersResponse")]
        System.Threading.Tasks.Task<string[]> GetOnlineUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetUserMessagesByRoomAndUserId", ReplyAction="http://tempuri.org/IChat/GetUserMessagesByRoomAndUserIdResponse")]
        WCFChatClient.ChatService.UserMessage[] GetUserMessagesByRoomAndUserId(int roomId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/GetUserMessagesByRoomAndUserId", ReplyAction="http://tempuri.org/IChat/GetUserMessagesByRoomAndUserIdResponse")]
        System.Threading.Tasks.Task<WCFChatClient.ChatService.UserMessage[]> GetUserMessagesByRoomAndUserIdAsync(int roomId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ErrorMessages", ReplyAction="http://tempuri.org/IChat/ErrorMessagesResponse")]
        void ErrorMessages(WCFChatClient.ChatService.Error error);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IChat/ErrorMessages", ReplyAction="http://tempuri.org/IChat/ErrorMessagesResponse")]
        System.Threading.Tasks.Task ErrorMessagesAsync(WCFChatClient.ChatService.Error error);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : WCFChatClient.ChatService.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.ClientBase<WCFChatClient.ChatService.IChat>, WCFChatClient.ChatService.IChat {
        
        public ChatClient() {
        }
        
        public ChatClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ChatClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SubmitUserMessage(WCFChatClient.ChatService.UserMessage post) {
            base.Channel.SubmitUserMessage(post);
        }
        
        public System.Threading.Tasks.Task SubmitUserMessageAsync(WCFChatClient.ChatService.UserMessage post) {
            return base.Channel.SubmitUserMessageAsync(post);
        }
        
        public WCFChatClient.ChatService.UserMessage[] GetUserMessages(int roomID) {
            return base.Channel.GetUserMessages(roomID);
        }
        
        public System.Threading.Tasks.Task<WCFChatClient.ChatService.UserMessage[]> GetUserMessagesAsync(int roomID) {
            return base.Channel.GetUserMessagesAsync(roomID);
        }
        
        public void RemoveUserMessage(WCFChatClient.ChatService.UserMessage userMessage) {
            base.Channel.RemoveUserMessage(userMessage);
        }
        
        public System.Threading.Tasks.Task RemoveUserMessageAsync(WCFChatClient.ChatService.UserMessage userMessage) {
            return base.Channel.RemoveUserMessageAsync(userMessage);
        }
        
        public void SaveToDatabase() {
            base.Channel.SaveToDatabase();
        }
        
        public System.Threading.Tasks.Task SaveToDatabaseAsync() {
            return base.Channel.SaveToDatabaseAsync();
        }
        
        public WCFChatClient.ChatService.UserMessage[] GetChatFromDatabase(int roomID) {
            return base.Channel.GetChatFromDatabase(roomID);
        }
        
        public System.Threading.Tasks.Task<WCFChatClient.ChatService.UserMessage[]> GetChatFromDatabaseAsync(int roomID) {
            return base.Channel.GetChatFromDatabaseAsync(roomID);
        }
        
        public void RegisterUser(WCFChatClient.ChatService.User user) {
            base.Channel.RegisterUser(user);
        }
        
        public System.Threading.Tasks.Task RegisterUserAsync(WCFChatClient.ChatService.User user) {
            return base.Channel.RegisterUserAsync(user);
        }
        
        public WCFChatClient.ChatService.CurrentUser LogInUser(string userName, string password) {
            return base.Channel.LogInUser(userName, password);
        }
        
        public System.Threading.Tasks.Task<WCFChatClient.ChatService.CurrentUser> LogInUserAsync(string userName, string password) {
            return base.Channel.LogInUserAsync(userName, password);
        }
        
        public void LogOutUser(string userName) {
            base.Channel.LogOutUser(userName);
        }
        
        public System.Threading.Tasks.Task LogOutUserAsync(string userName) {
            return base.Channel.LogOutUserAsync(userName);
        }
        
        public string[] GetOnlineUsers() {
            return base.Channel.GetOnlineUsers();
        }
        
        public System.Threading.Tasks.Task<string[]> GetOnlineUsersAsync() {
            return base.Channel.GetOnlineUsersAsync();
        }
        
        public WCFChatClient.ChatService.UserMessage[] GetUserMessagesByRoomAndUserId(int roomId, int userId) {
            return base.Channel.GetUserMessagesByRoomAndUserId(roomId, userId);
        }
        
        public System.Threading.Tasks.Task<WCFChatClient.ChatService.UserMessage[]> GetUserMessagesByRoomAndUserIdAsync(int roomId, int userId) {
            return base.Channel.GetUserMessagesByRoomAndUserIdAsync(roomId, userId);
        }
        
        public void ErrorMessages(WCFChatClient.ChatService.Error error) {
            base.Channel.ErrorMessages(error);
        }
        
        public System.Threading.Tasks.Task ErrorMessagesAsync(WCFChatClient.ChatService.Error error) {
            return base.Channel.ErrorMessagesAsync(error);
        }
    }
}
