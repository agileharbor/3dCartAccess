﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeDCartAccess.ThreeDCartAdvancedService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://3dcart.com/", ConfigurationName="ThreeDCartAdvancedService.cartAPIAdvancedSoap")]
    public interface cartAPIAdvancedSoap {
        
        // CODEGEN: Generating message contract since element name storeUrl from namespace http://3dcart.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://3dcart.com/runQuery", ReplyAction="*")]
        ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponse runQuery(ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://3dcart.com/runQuery", ReplyAction="*")]
        System.Threading.Tasks.Task<ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponse> runQueryAsync(ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class runQueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="runQuery", Namespace="http://3dcart.com/", Order=0)]
        public ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequestBody Body;
        
        public runQueryRequest() {
        }
        
        public runQueryRequest(ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://3dcart.com/")]
    public partial class runQueryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string storeUrl;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string userKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string sqlStatement;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string callBackURL;
        
        public runQueryRequestBody() {
        }
        
        public runQueryRequestBody(string storeUrl, string userKey, string sqlStatement, string callBackURL) {
            this.storeUrl = storeUrl;
            this.userKey = userKey;
            this.sqlStatement = sqlStatement;
            this.callBackURL = callBackURL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class runQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="runQueryResponse", Namespace="http://3dcart.com/", Order=0)]
        public ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponseBody Body;
        
        public runQueryResponse() {
        }
        
        public runQueryResponse(ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://3dcart.com/")]
    public partial class runQueryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement runQueryResult;
        
        public runQueryResponseBody() {
        }
        
        public runQueryResponseBody(System.Xml.Linq.XElement runQueryResult) {
            this.runQueryResult = runQueryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface cartAPIAdvancedSoapChannel : ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class cartAPIAdvancedSoapClient : System.ServiceModel.ClientBase<ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap>, ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap {
        
        public cartAPIAdvancedSoapClient() {
        }
        
        public cartAPIAdvancedSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public cartAPIAdvancedSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public cartAPIAdvancedSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public cartAPIAdvancedSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponse ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap.runQuery(ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest request) {
            return base.Channel.runQuery(request);
        }
        
        public System.Xml.Linq.XElement runQuery(string storeUrl, string userKey, string sqlStatement, string callBackURL) {
            ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest inValue = new ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest();
            inValue.Body = new ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequestBody();
            inValue.Body.storeUrl = storeUrl;
            inValue.Body.userKey = userKey;
            inValue.Body.sqlStatement = sqlStatement;
            inValue.Body.callBackURL = callBackURL;
            ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponse retVal = ((ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap)(this)).runQuery(inValue);
            return retVal.Body.runQueryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponse> ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap.runQueryAsync(ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest request) {
            return base.Channel.runQueryAsync(request);
        }
        
        public System.Threading.Tasks.Task<ThreeDCartAccess.ThreeDCartAdvancedService.runQueryResponse> runQueryAsync(string storeUrl, string userKey, string sqlStatement, string callBackURL) {
            ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest inValue = new ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequest();
            inValue.Body = new ThreeDCartAccess.ThreeDCartAdvancedService.runQueryRequestBody();
            inValue.Body.storeUrl = storeUrl;
            inValue.Body.userKey = userKey;
            inValue.Body.sqlStatement = sqlStatement;
            inValue.Body.callBackURL = callBackURL;
            return ((ThreeDCartAccess.ThreeDCartAdvancedService.cartAPIAdvancedSoap)(this)).runQueryAsync(inValue);
        }
    }
}
