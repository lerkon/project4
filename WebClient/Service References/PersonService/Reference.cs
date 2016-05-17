﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.PersonService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebClient.PersonService.Company companyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebClient.PersonService.Item[] itemsSoldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string loginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int zipCodeField;
        
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
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebClient.PersonService.Company company {
            get {
                return this.companyField;
            }
            set {
                if ((object.ReferenceEquals(this.companyField, value) != true)) {
                    this.companyField = value;
                    this.RaisePropertyChanged("company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebClient.PersonService.Item[] itemsSold {
            get {
                return this.itemsSoldField;
            }
            set {
                if ((object.ReferenceEquals(this.itemsSoldField, value) != true)) {
                    this.itemsSoldField = value;
                    this.RaisePropertyChanged("itemsSold");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string login {
            get {
                return this.loginField;
            }
            set {
                if ((object.ReferenceEquals(this.loginField, value) != true)) {
                    this.loginField = value;
                    this.RaisePropertyChanged("login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.phoneField, value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int zipCode {
            get {
                return this.zipCodeField;
            }
            set {
                if ((this.zipCodeField.Equals(value) != true)) {
                    this.zipCodeField = value;
                    this.RaisePropertyChanged("zipCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Company", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class Company : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string linkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string link {
            get {
                return this.linkField;
            }
            set {
                if ((object.ReferenceEquals(this.linkField, value) != true)) {
                    this.linkField = value;
                    this.RaisePropertyChanged("link");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime endAuctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[][] imgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] rowVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime startAuctionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stockRemainedField;
        
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
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.categoryField, value) != true)) {
                    this.categoryField = value;
                    this.RaisePropertyChanged("category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime endAuction {
            get {
                return this.endAuctionField;
            }
            set {
                if ((this.endAuctionField.Equals(value) != true)) {
                    this.endAuctionField = value;
                    this.RaisePropertyChanged("endAuction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[][] img {
            get {
                return this.imgField;
            }
            set {
                if ((object.ReferenceEquals(this.imgField, value) != true)) {
                    this.imgField = value;
                    this.RaisePropertyChanged("img");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] rowVersion {
            get {
                return this.rowVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.rowVersionField, value) != true)) {
                    this.rowVersionField = value;
                    this.RaisePropertyChanged("rowVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime startAuction {
            get {
                return this.startAuctionField;
            }
            set {
                if ((this.startAuctionField.Equals(value) != true)) {
                    this.startAuctionField = value;
                    this.RaisePropertyChanged("startAuction");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stock {
            get {
                return this.stockField;
            }
            set {
                if ((this.stockField.Equals(value) != true)) {
                    this.stockField = value;
                    this.RaisePropertyChanged("stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stockRemained {
            get {
                return this.stockRemainedField;
            }
            set {
                if ((this.stockRemainedField.Equals(value) != true)) {
                    this.stockRemainedField = value;
                    this.RaisePropertyChanged("stockRemained");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class PersonFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
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
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/login", ReplyAction="http://tempuri.org/IPersonService/loginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebClient.PersonService.PersonFault), Action="http://tempuri.org/IPersonService/loginPersonFaultFault", Name="PersonFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WebClient.PersonService.loginResponse login(WebClient.PersonService.loginRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/login", ReplyAction="http://tempuri.org/IPersonService/loginResponse")]
        System.Threading.Tasks.Task<WebClient.PersonService.loginResponse> loginAsync(WebClient.PersonService.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/setPerson", ReplyAction="http://tempuri.org/IPersonService/setPersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebClient.PersonService.PersonFault), Action="http://tempuri.org/IPersonService/setPersonPersonFaultFault", Name="PersonFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WebClient.PersonService.setPersonResponse setPerson(WebClient.PersonService.setPersonRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/setPerson", ReplyAction="http://tempuri.org/IPersonService/setPersonResponse")]
        System.Threading.Tasks.Task<WebClient.PersonService.setPersonResponse> setPersonAsync(WebClient.PersonService.setPersonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/updatePerson", ReplyAction="http://tempuri.org/IPersonService/updatePersonResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebClient.PersonService.PersonFault), Action="http://tempuri.org/IPersonService/updatePersonPersonFaultFault", Name="PersonFault", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
        WebClient.PersonService.updatePersonResponse updatePerson(WebClient.PersonService.updatePersonRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/updatePerson", ReplyAction="http://tempuri.org/IPersonService/updatePersonResponse")]
        System.Threading.Tasks.Task<WebClient.PersonService.updatePersonResponse> updatePersonAsync(WebClient.PersonService.updatePersonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string login;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public loginRequest() {
        }
        
        public loginRequest(string login, string password, string message) {
            this.login = login;
            this.password = password;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WebClient.PersonService.Person loginResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public loginResponse() {
        }
        
        public loginResponse(WebClient.PersonService.Person loginResult, string message) {
            this.loginResult = loginResult;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setPerson", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class setPersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WebClient.PersonService.Person person;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public setPersonRequest() {
        }
        
        public setPersonRequest(WebClient.PersonService.Person person, string message) {
            this.person = person;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setPersonResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class setPersonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WebClient.PersonService.Person setPersonResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public setPersonResponse() {
        }
        
        public setPersonResponse(WebClient.PersonService.Person setPersonResult, string message) {
            this.setPersonResult = setPersonResult;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updatePerson", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class updatePersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WebClient.PersonService.Person person;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public updatePersonRequest() {
        }
        
        public updatePersonRequest(WebClient.PersonService.Person person, string message) {
            this.person = person;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updatePersonResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class updatePersonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool updatePersonResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public updatePersonResponse() {
        }
        
        public updatePersonResponse(bool updatePersonResult, string message) {
            this.updatePersonResult = updatePersonResult;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : WebClient.PersonService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<WebClient.PersonService.IPersonService>, WebClient.PersonService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.PersonService.loginResponse WebClient.PersonService.IPersonService.login(WebClient.PersonService.loginRequest request) {
            return base.Channel.login(request);
        }
        
        public WebClient.PersonService.Person login(string login1, string password, ref string message) {
            WebClient.PersonService.loginRequest inValue = new WebClient.PersonService.loginRequest();
            inValue.login = login1;
            inValue.password = password;
            inValue.message = message;
            WebClient.PersonService.loginResponse retVal = ((WebClient.PersonService.IPersonService)(this)).login(inValue);
            message = retVal.message;
            return retVal.loginResult;
        }
        
        public System.Threading.Tasks.Task<WebClient.PersonService.loginResponse> loginAsync(WebClient.PersonService.loginRequest request) {
            return base.Channel.loginAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.PersonService.setPersonResponse WebClient.PersonService.IPersonService.setPerson(WebClient.PersonService.setPersonRequest request) {
            return base.Channel.setPerson(request);
        }
        
        public WebClient.PersonService.Person setPerson(WebClient.PersonService.Person person, ref string message) {
            WebClient.PersonService.setPersonRequest inValue = new WebClient.PersonService.setPersonRequest();
            inValue.person = person;
            inValue.message = message;
            WebClient.PersonService.setPersonResponse retVal = ((WebClient.PersonService.IPersonService)(this)).setPerson(inValue);
            message = retVal.message;
            return retVal.setPersonResult;
        }
        
        public System.Threading.Tasks.Task<WebClient.PersonService.setPersonResponse> setPersonAsync(WebClient.PersonService.setPersonRequest request) {
            return base.Channel.setPersonAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.PersonService.updatePersonResponse WebClient.PersonService.IPersonService.updatePerson(WebClient.PersonService.updatePersonRequest request) {
            return base.Channel.updatePerson(request);
        }
        
        public bool updatePerson(WebClient.PersonService.Person person, ref string message) {
            WebClient.PersonService.updatePersonRequest inValue = new WebClient.PersonService.updatePersonRequest();
            inValue.person = person;
            inValue.message = message;
            WebClient.PersonService.updatePersonResponse retVal = ((WebClient.PersonService.IPersonService)(this)).updatePerson(inValue);
            message = retVal.message;
            return retVal.updatePersonResult;
        }
        
        public System.Threading.Tasks.Task<WebClient.PersonService.updatePersonResponse> updatePersonAsync(WebClient.PersonService.updatePersonRequest request) {
            return base.Channel.updatePersonAsync(request);
        }
    }
}
