﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaGUI.ServiceReferenceGuias {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Compra", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Compra : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private int IdGuiaField;
        
        private int IdProductoField;
        
        private int NumeroUnidadesField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdGuia {
            get {
                return this.IdGuiaField;
            }
            set {
                if ((this.IdGuiaField.Equals(value) != true)) {
                    this.IdGuiaField = value;
                    this.RaisePropertyChanged("IdGuia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IdProducto {
            get {
                return this.IdProductoField;
            }
            set {
                if ((this.IdProductoField.Equals(value) != true)) {
                    this.IdProductoField = value;
                    this.RaisePropertyChanged("IdProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int NumeroUnidades {
            get {
                return this.NumeroUnidadesField;
            }
            set {
                if ((this.NumeroUnidadesField.Equals(value) != true)) {
                    this.NumeroUnidadesField = value;
                    this.RaisePropertyChanged("NumeroUnidades");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GuiaRecepcion", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class GuiaRecepcion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IDField;
        
        private int IDProveedorField;
        
        private System.DateTime FechaField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IDProveedor {
            get {
                return this.IDProveedorField;
            }
            set {
                if ((this.IDProveedorField.Equals(value) != true)) {
                    this.IDProveedorField = value;
                    this.RaisePropertyChanged("IDProveedor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceGuias.WebServiceGuiasSoap")]
    public interface WebServiceGuiasSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        CapaGUI.ServiceReferenceGuias.HelloWorldResponse HelloWorld(CapaGUI.ServiceReferenceGuias.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.HelloWorldResponse> HelloWorldAsync(CapaGUI.ServiceReferenceGuias.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento compra del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCompra", ReplyAction="*")]
        CapaGUI.ServiceReferenceGuias.AgregarCompraResponse AgregarCompra(CapaGUI.ServiceReferenceGuias.AgregarCompraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCompra", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.AgregarCompraResponse> AgregarCompraAsync(CapaGUI.ServiceReferenceGuias.AgregarCompraRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento guia del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarGuia", ReplyAction="*")]
        CapaGUI.ServiceReferenceGuias.AgregarGuiaResponse AgregarGuia(CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarGuia", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.AgregarGuiaResponse> AgregarGuiaAsync(CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento guia del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarGuiaCompleta", ReplyAction="*")]
        CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponse CargarGuiaCompleta(CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CargarGuiaCompleta", ReplyAction="*")]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponse> CargarGuiaCompletaAsync(CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CapaGUI.ServiceReferenceGuias.HelloWorldRequestBody Body) {
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
        public CapaGUI.ServiceReferenceGuias.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CapaGUI.ServiceReferenceGuias.HelloWorldResponseBody Body) {
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
    public partial class AgregarCompraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCompra", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.AgregarCompraRequestBody Body;
        
        public AgregarCompraRequest() {
        }
        
        public AgregarCompraRequest(CapaGUI.ServiceReferenceGuias.AgregarCompraRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarCompraRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceReferenceGuias.Compra compra;
        
        public AgregarCompraRequestBody() {
        }
        
        public AgregarCompraRequestBody(CapaGUI.ServiceReferenceGuias.Compra compra) {
            this.compra = compra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarCompraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarCompraResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.AgregarCompraResponseBody Body;
        
        public AgregarCompraResponse() {
        }
        
        public AgregarCompraResponse(CapaGUI.ServiceReferenceGuias.AgregarCompraResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AgregarCompraResponseBody {
        
        public AgregarCompraResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarGuiaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarGuia", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.AgregarGuiaRequestBody Body;
        
        public AgregarGuiaRequest() {
        }
        
        public AgregarGuiaRequest(CapaGUI.ServiceReferenceGuias.AgregarGuiaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarGuiaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia;
        
        public AgregarGuiaRequestBody() {
        }
        
        public AgregarGuiaRequestBody(CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia) {
            this.guia = guia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarGuiaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarGuiaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.AgregarGuiaResponseBody Body;
        
        public AgregarGuiaResponse() {
        }
        
        public AgregarGuiaResponse(CapaGUI.ServiceReferenceGuias.AgregarGuiaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AgregarGuiaResponseBody {
        
        public AgregarGuiaResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CargarGuiaCompletaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CargarGuiaCompleta", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequestBody Body;
        
        public CargarGuiaCompletaRequest() {
        }
        
        public CargarGuiaCompletaRequest(CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CargarGuiaCompletaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public CapaGUI.ServiceReferenceGuias.Compra[] compras;
        
        public CargarGuiaCompletaRequestBody() {
        }
        
        public CargarGuiaCompletaRequestBody(CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia, CapaGUI.ServiceReferenceGuias.Compra[] compras) {
            this.guia = guia;
            this.compras = compras;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CargarGuiaCompletaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CargarGuiaCompletaResponse", Namespace="http://tempuri.org/", Order=0)]
        public CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponseBody Body;
        
        public CargarGuiaCompletaResponse() {
        }
        
        public CargarGuiaCompletaResponse(CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CargarGuiaCompletaResponseBody {
        
        public CargarGuiaCompletaResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceGuiasSoapChannel : CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceGuiasSoapClient : System.ServiceModel.ClientBase<CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap>, CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap {
        
        public WebServiceGuiasSoapClient() {
        }
        
        public WebServiceGuiasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceGuiasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceGuiasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceGuiasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReferenceGuias.HelloWorldResponse CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.HelloWorld(CapaGUI.ServiceReferenceGuias.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CapaGUI.ServiceReferenceGuias.HelloWorldRequest inValue = new CapaGUI.ServiceReferenceGuias.HelloWorldRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.HelloWorldRequestBody();
            CapaGUI.ServiceReferenceGuias.HelloWorldResponse retVal = ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.HelloWorldResponse> CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.HelloWorldAsync(CapaGUI.ServiceReferenceGuias.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.HelloWorldResponse> HelloWorldAsync() {
            CapaGUI.ServiceReferenceGuias.HelloWorldRequest inValue = new CapaGUI.ServiceReferenceGuias.HelloWorldRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.HelloWorldRequestBody();
            return ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReferenceGuias.AgregarCompraResponse CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.AgregarCompra(CapaGUI.ServiceReferenceGuias.AgregarCompraRequest request) {
            return base.Channel.AgregarCompra(request);
        }
        
        public void AgregarCompra(CapaGUI.ServiceReferenceGuias.Compra compra) {
            CapaGUI.ServiceReferenceGuias.AgregarCompraRequest inValue = new CapaGUI.ServiceReferenceGuias.AgregarCompraRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.AgregarCompraRequestBody();
            inValue.Body.compra = compra;
            CapaGUI.ServiceReferenceGuias.AgregarCompraResponse retVal = ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).AgregarCompra(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.AgregarCompraResponse> CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.AgregarCompraAsync(CapaGUI.ServiceReferenceGuias.AgregarCompraRequest request) {
            return base.Channel.AgregarCompraAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.AgregarCompraResponse> AgregarCompraAsync(CapaGUI.ServiceReferenceGuias.Compra compra) {
            CapaGUI.ServiceReferenceGuias.AgregarCompraRequest inValue = new CapaGUI.ServiceReferenceGuias.AgregarCompraRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.AgregarCompraRequestBody();
            inValue.Body.compra = compra;
            return ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).AgregarCompraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReferenceGuias.AgregarGuiaResponse CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.AgregarGuia(CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest request) {
            return base.Channel.AgregarGuia(request);
        }
        
        public void AgregarGuia(CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia) {
            CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest inValue = new CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.AgregarGuiaRequestBody();
            inValue.Body.guia = guia;
            CapaGUI.ServiceReferenceGuias.AgregarGuiaResponse retVal = ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).AgregarGuia(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.AgregarGuiaResponse> CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.AgregarGuiaAsync(CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest request) {
            return base.Channel.AgregarGuiaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.AgregarGuiaResponse> AgregarGuiaAsync(CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia) {
            CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest inValue = new CapaGUI.ServiceReferenceGuias.AgregarGuiaRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.AgregarGuiaRequestBody();
            inValue.Body.guia = guia;
            return ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).AgregarGuiaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponse CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.CargarGuiaCompleta(CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest request) {
            return base.Channel.CargarGuiaCompleta(request);
        }
        
        public void CargarGuiaCompleta(CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia, CapaGUI.ServiceReferenceGuias.Compra[] compras) {
            CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest inValue = new CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequestBody();
            inValue.Body.guia = guia;
            inValue.Body.compras = compras;
            CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponse retVal = ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).CargarGuiaCompleta(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponse> CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap.CargarGuiaCompletaAsync(CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest request) {
            return base.Channel.CargarGuiaCompletaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaResponse> CargarGuiaCompletaAsync(CapaGUI.ServiceReferenceGuias.GuiaRecepcion guia, CapaGUI.ServiceReferenceGuias.Compra[] compras) {
            CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest inValue = new CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequest();
            inValue.Body = new CapaGUI.ServiceReferenceGuias.CargarGuiaCompletaRequestBody();
            inValue.Body.guia = guia;
            inValue.Body.compras = compras;
            return ((CapaGUI.ServiceReferenceGuias.WebServiceGuiasSoap)(this)).CargarGuiaCompletaAsync(inValue);
        }
    }
}