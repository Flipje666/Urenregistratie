﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.UrenregistratieServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AppUser", Namespace="http://schemas.datacontract.org/2004/07/UrenregistratieService")]
    [System.SerializableAttribute()]
    public partial class AppUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.UrenregistratieServiceReference.Project ProjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UseridField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public Client.UrenregistratieServiceReference.Project Project {
            get {
                return this.ProjectField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectField, value) != true)) {
                    this.ProjectField = value;
                    this.RaisePropertyChanged("Project");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Userid {
            get {
                return this.UseridField;
            }
            set {
                if ((this.UseridField.Equals(value) != true)) {
                    this.UseridField = value;
                    this.RaisePropertyChanged("Userid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Project", Namespace="http://schemas.datacontract.org/2004/07/UrenregistratieService")]
    [System.SerializableAttribute()]
    public partial class Project : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProjectNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProjectidField;
        
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
        public string ProjectName {
            get {
                return this.ProjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectNameField, value) != true)) {
                    this.ProjectNameField = value;
                    this.RaisePropertyChanged("ProjectName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Projectid {
            get {
                return this.ProjectidField;
            }
            set {
                if ((this.ProjectidField.Equals(value) != true)) {
                    this.ProjectidField = value;
                    this.RaisePropertyChanged("Projectid");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Task", Namespace="http://schemas.datacontract.org/2004/07/UrenregistratieService")]
    [System.SerializableAttribute()]
    public partial class Task : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.UrenregistratieServiceReference.AppUser AppUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HoursField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TaskidField;
        
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
        public Client.UrenregistratieServiceReference.AppUser AppUser {
            get {
                return this.AppUserField;
            }
            set {
                if ((object.ReferenceEquals(this.AppUserField, value) != true)) {
                    this.AppUserField = value;
                    this.RaisePropertyChanged("AppUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Hours {
            get {
                return this.HoursField;
            }
            set {
                if ((this.HoursField.Equals(value) != true)) {
                    this.HoursField = value;
                    this.RaisePropertyChanged("Hours");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Taskid {
            get {
                return this.TaskidField;
            }
            set {
                if ((this.TaskidField.Equals(value) != true)) {
                    this.TaskidField = value;
                    this.RaisePropertyChanged("Taskid");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UrenregistratieServiceReference.IUrenregistratieService")]
    public interface IUrenregistratieService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/Register", ReplyAction="http://tempuri.org/IUrenregistratieService/RegisterResponse")]
        bool Register(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/Register", ReplyAction="http://tempuri.org/IUrenregistratieService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/Login", ReplyAction="http://tempuri.org/IUrenregistratieService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/Login", ReplyAction="http://tempuri.org/IUrenregistratieService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/GetUser", ReplyAction="http://tempuri.org/IUrenregistratieService/GetUserResponse")]
        Client.UrenregistratieServiceReference.AppUser GetUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/GetUser", ReplyAction="http://tempuri.org/IUrenregistratieService/GetUserResponse")]
        System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> GetUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/GetUserTasks", ReplyAction="http://tempuri.org/IUrenregistratieService/GetUserTasksResponse")]
        Client.UrenregistratieServiceReference.Task[] GetUserTasks(Client.UrenregistratieServiceReference.AppUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/GetUserTasks", ReplyAction="http://tempuri.org/IUrenregistratieService/GetUserTasksResponse")]
        System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.Task[]> GetUserTasksAsync(Client.UrenregistratieServiceReference.AppUser user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/SaveHours", ReplyAction="http://tempuri.org/IUrenregistratieService/SaveHoursResponse")]
        Client.UrenregistratieServiceReference.AppUser SaveHours(string task, int hours, Client.UrenregistratieServiceReference.AppUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/SaveHours", ReplyAction="http://tempuri.org/IUrenregistratieService/SaveHoursResponse")]
        System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> SaveHoursAsync(string task, int hours, Client.UrenregistratieServiceReference.AppUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/EditHours", ReplyAction="http://tempuri.org/IUrenregistratieService/EditHoursResponse")]
        Client.UrenregistratieServiceReference.AppUser EditHours(string task, int hours, Client.UrenregistratieServiceReference.AppUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/EditHours", ReplyAction="http://tempuri.org/IUrenregistratieService/EditHoursResponse")]
        System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> EditHoursAsync(string task, int hours, Client.UrenregistratieServiceReference.AppUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/DeleteHours", ReplyAction="http://tempuri.org/IUrenregistratieService/DeleteHoursResponse")]
        Client.UrenregistratieServiceReference.AppUser DeleteHours(string task, Client.UrenregistratieServiceReference.AppUser u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrenregistratieService/DeleteHours", ReplyAction="http://tempuri.org/IUrenregistratieService/DeleteHoursResponse")]
        System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> DeleteHoursAsync(string task, Client.UrenregistratieServiceReference.AppUser u);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUrenregistratieServiceChannel : Client.UrenregistratieServiceReference.IUrenregistratieService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UrenregistratieServiceClient : System.ServiceModel.ClientBase<Client.UrenregistratieServiceReference.IUrenregistratieService>, Client.UrenregistratieServiceReference.IUrenregistratieService {
        
        public UrenregistratieServiceClient() {
        }
        
        public UrenregistratieServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UrenregistratieServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UrenregistratieServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UrenregistratieServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Register(string username) {
            return base.Channel.Register(username);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string username) {
            return base.Channel.RegisterAsync(username);
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public Client.UrenregistratieServiceReference.AppUser GetUser(string username, string password) {
            return base.Channel.GetUser(username, password);
        }
        
        public System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> GetUserAsync(string username, string password) {
            return base.Channel.GetUserAsync(username, password);
        }
        
        public Client.UrenregistratieServiceReference.Task[] GetUserTasks(Client.UrenregistratieServiceReference.AppUser user) {
            return base.Channel.GetUserTasks(user);
        }
        
        public System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.Task[]> GetUserTasksAsync(Client.UrenregistratieServiceReference.AppUser user) {
            return base.Channel.GetUserTasksAsync(user);
        }
        
        public Client.UrenregistratieServiceReference.AppUser SaveHours(string task, int hours, Client.UrenregistratieServiceReference.AppUser u) {
            return base.Channel.SaveHours(task, hours, u);
        }
        
        public System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> SaveHoursAsync(string task, int hours, Client.UrenregistratieServiceReference.AppUser u) {
            return base.Channel.SaveHoursAsync(task, hours, u);
        }
        
        public Client.UrenregistratieServiceReference.AppUser EditHours(string task, int hours, Client.UrenregistratieServiceReference.AppUser u) {
            return base.Channel.EditHours(task, hours, u);
        }
        
        public System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> EditHoursAsync(string task, int hours, Client.UrenregistratieServiceReference.AppUser u) {
            return base.Channel.EditHoursAsync(task, hours, u);
        }
        
        public Client.UrenregistratieServiceReference.AppUser DeleteHours(string task, Client.UrenregistratieServiceReference.AppUser u) {
            return base.Channel.DeleteHours(task, u);
        }
        
        public System.Threading.Tasks.Task<Client.UrenregistratieServiceReference.AppUser> DeleteHoursAsync(string task, Client.UrenregistratieServiceReference.AppUser u) {
            return base.Channel.DeleteHoursAsync(task, u);
        }
    }
}
