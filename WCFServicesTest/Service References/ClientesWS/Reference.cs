﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServicesTest.ClientesWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoElectronicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Celular {
            get {
                return this.CelularField;
            }
            set {
                if ((this.CelularField.Equals(value) != true)) {
                    this.CelularField = value;
                    this.RaisePropertyChanged("Celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contraseña {
            get {
                return this.ContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseñaField, value) != true)) {
                    this.ContraseñaField = value;
                    this.RaisePropertyChanged("Contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorreoElectronico {
            get {
                return this.CorreoElectronicoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoElectronicoField, value) != true)) {
                    this.CorreoElectronicoField = value;
                    this.RaisePropertyChanged("CorreoElectronico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dni {
            get {
                return this.DniField;
            }
            set {
                if ((this.DniField.Equals(value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
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
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientesWS.IClientes")]
    public interface IClientes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/CrearCliente", ReplyAction="http://tempuri.org/IClientes/CrearClienteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCFServicesTest.ClientesWS.RepetidoException), Action="http://tempuri.org/IClientes/CrearClienteRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/WCFServices.Errores")]
        WCFServicesTest.ClientesWS.Cliente CrearCliente(WCFServicesTest.ClientesWS.Cliente clienteACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/CrearCliente", ReplyAction="http://tempuri.org/IClientes/CrearClienteResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente> CrearClienteAsync(WCFServicesTest.ClientesWS.Cliente clienteACrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ObtenerCliente", ReplyAction="http://tempuri.org/IClientes/ObtenerClienteResponse")]
        WCFServicesTest.ClientesWS.Cliente ObtenerCliente(string CorreoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ObtenerCliente", ReplyAction="http://tempuri.org/IClientes/ObtenerClienteResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente> ObtenerClienteAsync(string CorreoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ModficarCliente", ReplyAction="http://tempuri.org/IClientes/ModficarClienteResponse")]
        WCFServicesTest.ClientesWS.Cliente ModficarCliente(WCFServicesTest.ClientesWS.Cliente clienteAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ModficarCliente", ReplyAction="http://tempuri.org/IClientes/ModficarClienteResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente> ModficarClienteAsync(WCFServicesTest.ClientesWS.Cliente clienteAModificar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/EliminarCliente", ReplyAction="http://tempuri.org/IClientes/EliminarClienteResponse")]
        void EliminarCliente(string CorreoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/EliminarCliente", ReplyAction="http://tempuri.org/IClientes/EliminarClienteResponse")]
        System.Threading.Tasks.Task EliminarClienteAsync(string CorreoElectronico);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ListarCliente", ReplyAction="http://tempuri.org/IClientes/ListarClienteResponse")]
        WCFServicesTest.ClientesWS.Cliente[] ListarCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/ListarCliente", ReplyAction="http://tempuri.org/IClientes/ListarClienteResponse")]
        System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente[]> ListarClienteAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientesChannel : WCFServicesTest.ClientesWS.IClientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesClient : System.ServiceModel.ClientBase<WCFServicesTest.ClientesWS.IClientes>, WCFServicesTest.ClientesWS.IClientes {
        
        public ClientesClient() {
        }
        
        public ClientesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFServicesTest.ClientesWS.Cliente CrearCliente(WCFServicesTest.ClientesWS.Cliente clienteACrear) {
            return base.Channel.CrearCliente(clienteACrear);
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente> CrearClienteAsync(WCFServicesTest.ClientesWS.Cliente clienteACrear) {
            return base.Channel.CrearClienteAsync(clienteACrear);
        }
        
        public WCFServicesTest.ClientesWS.Cliente ObtenerCliente(string CorreoElectronico) {
            return base.Channel.ObtenerCliente(CorreoElectronico);
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente> ObtenerClienteAsync(string CorreoElectronico) {
            return base.Channel.ObtenerClienteAsync(CorreoElectronico);
        }
        
        public WCFServicesTest.ClientesWS.Cliente ModficarCliente(WCFServicesTest.ClientesWS.Cliente clienteAModificar) {
            return base.Channel.ModficarCliente(clienteAModificar);
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente> ModficarClienteAsync(WCFServicesTest.ClientesWS.Cliente clienteAModificar) {
            return base.Channel.ModficarClienteAsync(clienteAModificar);
        }
        
        public void EliminarCliente(string CorreoElectronico) {
            base.Channel.EliminarCliente(CorreoElectronico);
        }
        
        public System.Threading.Tasks.Task EliminarClienteAsync(string CorreoElectronico) {
            return base.Channel.EliminarClienteAsync(CorreoElectronico);
        }
        
        public WCFServicesTest.ClientesWS.Cliente[] ListarCliente() {
            return base.Channel.ListarCliente();
        }
        
        public System.Threading.Tasks.Task<WCFServicesTest.ClientesWS.Cliente[]> ListarClienteAsync() {
            return base.Channel.ListarClienteAsync();
        }
    }
}
