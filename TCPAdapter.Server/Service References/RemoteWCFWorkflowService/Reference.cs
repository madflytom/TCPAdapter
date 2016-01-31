﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCPAdapter.Server.RemoteWCFWorkflowService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteWCFWorkflowService.IService")]
    public interface IService {
        
        // CODEGEN: Generating message contract since the operation GetData is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        TCPAdapter.Server.RemoteWCFWorkflowService.GetDataResponse GetData(TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<TCPAdapter.Server.RemoteWCFWorkflowService.GetDataResponse> GetDataAsync(TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public System.Nullable<int> @int;
        
        public GetDataRequest() {
        }
        
        public GetDataRequest(System.Nullable<int> @int) {
            this.@int = @int;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/2003/10/Serialization/", Order=0)]
        public string @string;
        
        public GetDataResponse() {
        }
        
        public GetDataResponse(string @string) {
            this.@string = @string;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TCPAdapter.Server.RemoteWCFWorkflowService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<TCPAdapter.Server.RemoteWCFWorkflowService.IService>, TCPAdapter.Server.RemoteWCFWorkflowService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TCPAdapter.Server.RemoteWCFWorkflowService.GetDataResponse TCPAdapter.Server.RemoteWCFWorkflowService.IService.GetData(TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest request) {
            return base.Channel.GetData(request);
        }
        
        public string GetData(System.Nullable<int> @int) {
            TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest inValue = new TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest();
            inValue.@int = @int;
            TCPAdapter.Server.RemoteWCFWorkflowService.GetDataResponse retVal = ((TCPAdapter.Server.RemoteWCFWorkflowService.IService)(this)).GetData(inValue);
            return retVal.@string;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TCPAdapter.Server.RemoteWCFWorkflowService.GetDataResponse> TCPAdapter.Server.RemoteWCFWorkflowService.IService.GetDataAsync(TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest request) {
            return base.Channel.GetDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<TCPAdapter.Server.RemoteWCFWorkflowService.GetDataResponse> GetDataAsync(System.Nullable<int> @int) {
            TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest inValue = new TCPAdapter.Server.RemoteWCFWorkflowService.GetDataRequest();
            inValue.@int = @int;
            return ((TCPAdapter.Server.RemoteWCFWorkflowService.IService)(this)).GetDataAsync(inValue);
        }
    }
}
