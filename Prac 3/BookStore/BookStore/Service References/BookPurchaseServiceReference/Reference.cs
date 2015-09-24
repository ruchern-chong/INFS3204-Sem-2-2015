﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.BookPurchaseServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookPurchaseServiceReference.IBookPurchaseService")]
    public interface IBookPurchaseService {
        
        // CODEGEN: Generating message contract since the wrapper name (BookPurchaseResponse) of message BookPurchaseResponse does not match the default value (PurchaseBook)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookPurchaseService/PurchaseBook", ReplyAction="http://tempuri.org/IBookPurchaseService/PurchaseBookResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IBookPurchaseService/PurchaseBookExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        BookStore.BookPurchaseServiceReference.BookPurchaseInfo PurchaseBook(BookStore.BookPurchaseServiceReference.BookPurchaseResponse request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookPurchaseService/PurchaseBook", ReplyAction="http://tempuri.org/IBookPurchaseService/PurchaseBookResponse")]
        System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseInfo> PurchaseBookAsync(BookStore.BookPurchaseServiceReference.BookPurchaseResponse request);
        
        // CODEGEN: Generating message contract since the operation BookPurchaseInfo is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookPurchaseService/BookPurchaseInfo", ReplyAction="http://tempuri.org/IBookPurchaseService/BookPurchaseInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IBookPurchaseService/BookPurchaseInfoExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        BookStore.BookPurchaseServiceReference.BookPurchaseInfo BookPurchaseInfo(BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookPurchaseService/BookPurchaseInfo", ReplyAction="http://tempuri.org/IBookPurchaseService/BookPurchaseInfoResponse")]
        System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseInfo> BookPurchaseInfoAsync(BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BookPurchaseResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BookPurchaseResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string response;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool result;
        
        public BookPurchaseResponse() {
        }
        
        public BookPurchaseResponse(string response, bool result) {
            this.response = response;
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BookPurchaseInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BookPurchaseInfo {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public float budget;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public System.Collections.Generic.Dictionary<int, int> items;
        
        public BookPurchaseInfo() {
        }
        
        public BookPurchaseInfo(float budget, System.Collections.Generic.Dictionary<int, int> items) {
            this.budget = budget;
            this.items = items;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BookPurchaseInfoRequest {
        
        public BookPurchaseInfoRequest() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookPurchaseServiceChannel : BookStore.BookPurchaseServiceReference.IBookPurchaseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookPurchaseServiceClient : System.ServiceModel.ClientBase<BookStore.BookPurchaseServiceReference.IBookPurchaseService>, BookStore.BookPurchaseServiceReference.IBookPurchaseService {
        
        public BookPurchaseServiceClient() {
        }
        
        public BookPurchaseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookPurchaseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookPurchaseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookPurchaseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BookStore.BookPurchaseServiceReference.BookPurchaseInfo BookStore.BookPurchaseServiceReference.IBookPurchaseService.PurchaseBook(BookStore.BookPurchaseServiceReference.BookPurchaseResponse request) {
            return base.Channel.PurchaseBook(request);
        }
        
        public float PurchaseBook(string response, bool result, out System.Collections.Generic.Dictionary<int, int> items) {
            BookStore.BookPurchaseServiceReference.BookPurchaseResponse inValue = new BookStore.BookPurchaseServiceReference.BookPurchaseResponse();
            inValue.response = response;
            inValue.result = result;
            BookStore.BookPurchaseServiceReference.BookPurchaseInfo retVal = ((BookStore.BookPurchaseServiceReference.IBookPurchaseService)(this)).PurchaseBook(inValue);
            items = retVal.items;
            return retVal.budget;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseInfo> BookStore.BookPurchaseServiceReference.IBookPurchaseService.PurchaseBookAsync(BookStore.BookPurchaseServiceReference.BookPurchaseResponse request) {
            return base.Channel.PurchaseBookAsync(request);
        }
        
        public System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseInfo> PurchaseBookAsync(string response, bool result) {
            BookStore.BookPurchaseServiceReference.BookPurchaseResponse inValue = new BookStore.BookPurchaseServiceReference.BookPurchaseResponse();
            inValue.response = response;
            inValue.result = result;
            return ((BookStore.BookPurchaseServiceReference.IBookPurchaseService)(this)).PurchaseBookAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BookStore.BookPurchaseServiceReference.BookPurchaseInfo BookStore.BookPurchaseServiceReference.IBookPurchaseService.BookPurchaseInfo(BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest request) {
            return base.Channel.BookPurchaseInfo(request);
        }
        
        public float BookPurchaseInfo(out System.Collections.Generic.Dictionary<int, int> items) {
            BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest inValue = new BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest();
            BookStore.BookPurchaseServiceReference.BookPurchaseInfo retVal = ((BookStore.BookPurchaseServiceReference.IBookPurchaseService)(this)).BookPurchaseInfo(inValue);
            items = retVal.items;
            return retVal.budget;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseInfo> BookStore.BookPurchaseServiceReference.IBookPurchaseService.BookPurchaseInfoAsync(BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest request) {
            return base.Channel.BookPurchaseInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseInfo> BookPurchaseInfoAsync() {
            BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest inValue = new BookStore.BookPurchaseServiceReference.BookPurchaseInfoRequest();
            return ((BookStore.BookPurchaseServiceReference.IBookPurchaseService)(this)).BookPurchaseInfoAsync(inValue);
        }
    }
}
