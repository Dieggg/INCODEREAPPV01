﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SalidaProducto", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class SalidaProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int NumSalidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkuField;
        
        private int CantidadSalidaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int NumSalida {
            get {
                return this.NumSalidaField;
            }
            set {
                if ((this.NumSalidaField.Equals(value) != true)) {
                    this.NumSalidaField = value;
                    this.RaisePropertyChanged("NumSalida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Sku {
            get {
                return this.SkuField;
            }
            set {
                if ((object.ReferenceEquals(this.SkuField, value) != true)) {
                    this.SkuField = value;
                    this.RaisePropertyChanged("Sku");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int CantidadSalida {
            get {
                return this.CantidadSalidaField;
            }
            set {
                if ((this.CantidadSalidaField.Equals(value) != true)) {
                    this.CantidadSalidaField = value;
                    this.RaisePropertyChanged("CantidadSalida");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSalidaProductosSoap")]
    public interface WebServiceSalidaProductosSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CapaGUI.ServiceReference.HelloWorldResponse HelloWorld(CapaGUI.ServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.HelloWorldResponse> HelloWorldAsync(CapaGUI.ServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento sku del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultaStock", ReplyAction="*")]
        CapaGUI.ServiceReference.ConsultaStockResponse ConsultaStock(CapaGUI.ServiceReference.ConsultaStockRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultaStock", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.ConsultaStockResponse> ConsultaStockAsync(CapaGUI.ServiceReference.ConsultaStockRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento sku del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizaStock", ReplyAction="*")]
        CapaGUI.ServiceReference.ActualizaStockResponse ActualizaStock(CapaGUI.ServiceReference.ActualizaStockRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizaStock", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.ActualizaStockResponse> ActualizaStockAsync(CapaGUI.ServiceReference.ActualizaStockRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento salidaProducto del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistraSalida", ReplyAction="*")]
        CapaGUI.ServiceReference.RegistraSalidaResponse RegistraSalida(CapaGUI.ServiceReference.RegistraSalidaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RegistraSalida", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.RegistraSalidaResponse> RegistraSalidaAsync(CapaGUI.ServiceReference.RegistraSalidaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultaID", ReplyAction="*")]
        int ConsultaID(int numSalida);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultaID", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ConsultaIDAsync(int numSalida);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CapaGUI.ServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CapaGUI.ServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaStockRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaStock", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.ConsultaStockRequestBody Body;
        
        public ConsultaStockRequest() {
        }
        
        public ConsultaStockRequest(CapaGUI.ServiceReference.ConsultaStockRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsultaStockRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sku;
        
        public ConsultaStockRequestBody() {
        }
        
        public ConsultaStockRequestBody(string sku) {
            this.sku = sku;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaStockResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaStockResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.ConsultaStockResponseBody Body;
        
        public ConsultaStockResponse() {
        }
        
        public ConsultaStockResponse(CapaGUI.ServiceReference.ConsultaStockResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConsultaStockResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ConsultaStockResult;
        
        public ConsultaStockResponseBody() {
        }
        
        public ConsultaStockResponseBody(int ConsultaStockResult) {
            this.ConsultaStockResult = ConsultaStockResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizaStockRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizaStock", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.ActualizaStockRequestBody Body;
        
        public ActualizaStockRequest() {
        }
        
        public ActualizaStockRequest(CapaGUI.ServiceReference.ActualizaStockRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ActualizaStockRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sku;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int nuevaCantidad;
        
        public ActualizaStockRequestBody() {
        }
        
        public ActualizaStockRequestBody(string sku, int nuevaCantidad) {
            this.sku = sku;
            this.nuevaCantidad = nuevaCantidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ActualizaStockResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ActualizaStockResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.ActualizaStockResponseBody Body;
        
        public ActualizaStockResponse() {
        }
        
        public ActualizaStockResponse(CapaGUI.ServiceReference.ActualizaStockResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ActualizaStockResponseBody {
        
        public ActualizaStockResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistraSalidaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistraSalida", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.RegistraSalidaRequestBody Body;
        
        public RegistraSalidaRequest() {
        }
        
        public RegistraSalidaRequest(CapaGUI.ServiceReference.RegistraSalidaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistraSalidaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceReference.SalidaProducto salidaProducto;
        
        public RegistraSalidaRequestBody() {
        }
        
        public RegistraSalidaRequestBody(CapaGUI.ServiceReference.SalidaProducto salidaProducto) {
            this.salidaProducto = salidaProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegistraSalidaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegistraSalidaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReference.RegistraSalidaResponseBody Body;
        
        public RegistraSalidaResponse() {
        }
        
        public RegistraSalidaResponse(CapaGUI.ServiceReference.RegistraSalidaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class RegistraSalidaResponseBody {
        
        public RegistraSalidaResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSalidaProductosSoapChannel : CapaGUI.ServiceReference.WebServiceSalidaProductosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSalidaProductosSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceReference.WebServiceSalidaProductosSoap>, CapaGUI.ServiceReference.WebServiceSalidaProductosSoap {
        
        public WebServiceSalidaProductosSoapClient() {
        }
        
        public WebServiceSalidaProductosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSalidaProductosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSalidaProductosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSalidaProductosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReference.HelloWorldResponse CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.HelloWorld(CapaGUI.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CapaGUI.ServiceReference.HelloWorldRequest inValue = new CapaGUI.ServiceReference.HelloWorldRequest();
            inValue.Body = new CapaGUI.ServiceReference.HelloWorldRequestBody();
            CapaGUI.ServiceReference.HelloWorldResponse retVal = ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.HelloWorldResponse> CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.HelloWorldAsync(CapaGUI.ServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReference.HelloWorldResponse> HelloWorldAsync() {
            CapaGUI.ServiceReference.HelloWorldRequest inValue = new CapaGUI.ServiceReference.HelloWorldRequest();
            inValue.Body = new CapaGUI.ServiceReference.HelloWorldRequestBody();
            return ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReference.ConsultaStockResponse CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.ConsultaStock(CapaGUI.ServiceReference.ConsultaStockRequest request) {
            return base.Channel.ConsultaStock(request);
        }
        
        public int ConsultaStock(string sku) {
            CapaGUI.ServiceReference.ConsultaStockRequest inValue = new CapaGUI.ServiceReference.ConsultaStockRequest();
            inValue.Body = new CapaGUI.ServiceReference.ConsultaStockRequestBody();
            inValue.Body.sku = sku;
            CapaGUI.ServiceReference.ConsultaStockResponse retVal = ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).ConsultaStock(inValue);
            return retVal.Body.ConsultaStockResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.ConsultaStockResponse> CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.ConsultaStockAsync(CapaGUI.ServiceReference.ConsultaStockRequest request) {
            return base.Channel.ConsultaStockAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReference.ConsultaStockResponse> ConsultaStockAsync(string sku) {
            CapaGUI.ServiceReference.ConsultaStockRequest inValue = new CapaGUI.ServiceReference.ConsultaStockRequest();
            inValue.Body = new CapaGUI.ServiceReference.ConsultaStockRequestBody();
            inValue.Body.sku = sku;
            return ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).ConsultaStockAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReference.ActualizaStockResponse CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.ActualizaStock(CapaGUI.ServiceReference.ActualizaStockRequest request) {
            return base.Channel.ActualizaStock(request);
        }
        
        public void ActualizaStock(string sku, int nuevaCantidad) {
            CapaGUI.ServiceReference.ActualizaStockRequest inValue = new CapaGUI.ServiceReference.ActualizaStockRequest();
            inValue.Body = new CapaGUI.ServiceReference.ActualizaStockRequestBody();
            inValue.Body.sku = sku;
            inValue.Body.nuevaCantidad = nuevaCantidad;
            CapaGUI.ServiceReference.ActualizaStockResponse retVal = ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).ActualizaStock(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.ActualizaStockResponse> CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.ActualizaStockAsync(CapaGUI.ServiceReference.ActualizaStockRequest request) {
            return base.Channel.ActualizaStockAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReference.ActualizaStockResponse> ActualizaStockAsync(string sku, int nuevaCantidad) {
            CapaGUI.ServiceReference.ActualizaStockRequest inValue = new CapaGUI.ServiceReference.ActualizaStockRequest();
            inValue.Body = new CapaGUI.ServiceReference.ActualizaStockRequestBody();
            inValue.Body.sku = sku;
            inValue.Body.nuevaCantidad = nuevaCantidad;
            return ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).ActualizaStockAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReference.RegistraSalidaResponse CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.RegistraSalida(CapaGUI.ServiceReference.RegistraSalidaRequest request) {
            return base.Channel.RegistraSalida(request);
        }
        
        public void RegistraSalida(CapaGUI.ServiceReference.SalidaProducto salidaProducto) {
            CapaGUI.ServiceReference.RegistraSalidaRequest inValue = new CapaGUI.ServiceReference.RegistraSalidaRequest();
            inValue.Body = new CapaGUI.ServiceReference.RegistraSalidaRequestBody();
            inValue.Body.salidaProducto = salidaProducto;
            CapaGUI.ServiceReference.RegistraSalidaResponse retVal = ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).RegistraSalida(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReference.RegistraSalidaResponse> CapaGUI.ServiceReference.WebServiceSalidaProductosSoap.RegistraSalidaAsync(CapaGUI.ServiceReference.RegistraSalidaRequest request) {
            return base.Channel.RegistraSalidaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReference.RegistraSalidaResponse> RegistraSalidaAsync(CapaGUI.ServiceReference.SalidaProducto salidaProducto) {
            CapaGUI.ServiceReference.RegistraSalidaRequest inValue = new CapaGUI.ServiceReference.RegistraSalidaRequest();
            inValue.Body = new CapaGUI.ServiceReference.RegistraSalidaRequestBody();
            inValue.Body.salidaProducto = salidaProducto;
            return ((CapaGUI.ServiceReference.WebServiceSalidaProductosSoap)(this)).RegistraSalidaAsync(inValue);
        }
        
        public int ConsultaID(int numSalida) {
            return base.Channel.ConsultaID(numSalida);
        }
        
        public System.Threading.Tasks.Task<int> ConsultaIDAsync(int numSalida) {
            return base.Channel.ConsultaIDAsync(numSalida);
        }
    }
}
