﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Service1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Equation", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Equation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LeftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LeftSideField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RightSideField;
        
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
        public int Left {
            get {
                return this.LeftField;
            }
            set {
                if ((this.LeftField.Equals(value) != true)) {
                    this.LeftField = value;
                    this.RaisePropertyChanged("Left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LeftSide {
            get {
                return this.LeftSideField;
            }
            set {
                if ((object.ReferenceEquals(this.LeftSideField, value) != true)) {
                    this.LeftSideField = value;
                    this.RaisePropertyChanged("LeftSide");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation {
            get {
                return this.OperationField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationField, value) != true)) {
                    this.OperationField = value;
                    this.RaisePropertyChanged("Operation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Right {
            get {
                return this.RightField;
            }
            set {
                if ((this.RightField.Equals(value) != true)) {
                    this.RightField = value;
                    this.RaisePropertyChanged("Right");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RightSide {
            get {
                return this.RightSideField;
            }
            set {
                if ((object.ReferenceEquals(this.RightSideField, value) != true)) {
                    this.RightSideField = value;
                    this.RaisePropertyChanged("RightSide");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieCategory", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class MovieCategory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Stock", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Stock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stockCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stockNameField;
        
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
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string stockCode {
            get {
                return this.stockCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.stockCodeField, value) != true)) {
                    this.stockCodeField = value;
                    this.RaisePropertyChanged("stockCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string stockName {
            get {
                return this.stockNameField;
            }
            set {
                if ((object.ReferenceEquals(this.stockNameField, value) != true)) {
                    this.stockNameField = value;
                    this.RaisePropertyChanged("stockName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMovies", ReplyAction="http://tempuri.org/IService1/GetAllMoviesResponse")]
        WebApplication1.Service1.Movie[] GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMovies", ReplyAction="http://tempuri.org/IService1/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.Movie[]> GetAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Welcome", ReplyAction="http://tempuri.org/IService1/WelcomeResponse")]
        string Welcome(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Welcome", ReplyAction="http://tempuri.org/IService1/WelcomeResponse")]
        System.Threading.Tasks.Task<string> WelcomeAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WebApplication1.Service1.CompositeType GetDataUsingDataContract(WebApplication1.Service1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.CompositeType> GetDataUsingDataContractAsync(WebApplication1.Service1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateEquation", ReplyAction="http://tempuri.org/IService1/GenerateEquationResponse")]
        WebApplication1.Service1.Equation GenerateEquation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GenerateEquation", ReplyAction="http://tempuri.org/IService1/GenerateEquationResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.Equation> GenerateEquationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMovieCategories", ReplyAction="http://tempuri.org/IService1/GetAllMovieCategoriesResponse")]
        WebApplication1.Service1.MovieCategory[] GetAllMovieCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllMovieCategories", ReplyAction="http://tempuri.org/IService1/GetAllMovieCategoriesResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.MovieCategory[]> GetAllMovieCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMoviesByCategoryId", ReplyAction="http://tempuri.org/IService1/GetMoviesByCategoryIdResponse")]
        WebApplication1.Service1.Movie[] GetMoviesByCategoryId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMoviesByCategoryId", ReplyAction="http://tempuri.org/IService1/GetMoviesByCategoryIdResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.Movie[]> GetMoviesByCategoryIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStocks", ReplyAction="http://tempuri.org/IService1/GetAllStocksResponse")]
        WebApplication1.Service1.Stock[] GetAllStocks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStocks", ReplyAction="http://tempuri.org/IService1/GetAllStocksResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.Stock[]> GetAllStocksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStockByCode", ReplyAction="http://tempuri.org/IService1/GetStockByCodeResponse")]
        WebApplication1.Service1.Stock[] GetStockByCode(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStockByCode", ReplyAction="http://tempuri.org/IService1/GetStockByCodeResponse")]
        System.Threading.Tasks.Task<WebApplication1.Service1.Stock[]> GetStockByCodeAsync(string code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.Service1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.Service1.IService1>, WebApplication1.Service1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication1.Service1.Movie[] GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.Movie[]> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
        
        public string Welcome(string userName) {
            return base.Channel.Welcome(userName);
        }
        
        public System.Threading.Tasks.Task<string> WelcomeAsync(string userName) {
            return base.Channel.WelcomeAsync(userName);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WebApplication1.Service1.CompositeType GetDataUsingDataContract(WebApplication1.Service1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.CompositeType> GetDataUsingDataContractAsync(WebApplication1.Service1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WebApplication1.Service1.Equation GenerateEquation() {
            return base.Channel.GenerateEquation();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.Equation> GenerateEquationAsync() {
            return base.Channel.GenerateEquationAsync();
        }
        
        public WebApplication1.Service1.MovieCategory[] GetAllMovieCategories() {
            return base.Channel.GetAllMovieCategories();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.MovieCategory[]> GetAllMovieCategoriesAsync() {
            return base.Channel.GetAllMovieCategoriesAsync();
        }
        
        public WebApplication1.Service1.Movie[] GetMoviesByCategoryId(int id) {
            return base.Channel.GetMoviesByCategoryId(id);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.Movie[]> GetMoviesByCategoryIdAsync(int id) {
            return base.Channel.GetMoviesByCategoryIdAsync(id);
        }
        
        public WebApplication1.Service1.Stock[] GetAllStocks() {
            return base.Channel.GetAllStocks();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.Stock[]> GetAllStocksAsync() {
            return base.Channel.GetAllStocksAsync();
        }
        
        public WebApplication1.Service1.Stock[] GetStockByCode(string code) {
            return base.Channel.GetStockByCode(code);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.Service1.Stock[]> GetStockByCodeAsync(string code) {
            return base.Channel.GetStockByCodeAsync(code);
        }
    }
}
