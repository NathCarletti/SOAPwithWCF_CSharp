﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstoqueClienteV2.ServiceEstoqueV2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductData", Namespace="http://schemas.datacontract.org/2004/07/Products")]
    [System.SerializableAttribute()]
    public partial class ProductData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
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
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="ServiceEstoqueV2.IServiceEstoque")]
    public interface IServiceEstoque {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/ListProducts", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/ListProductsResponse")]
        EstoqueClienteV2.ServiceEstoqueV2.ProductData[] ListProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/ListProducts", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/ListProductsResponse")]
        System.Threading.Tasks.Task<EstoqueClienteV2.ServiceEstoqueV2.ProductData[]> ListProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/IncluirProdutoResponse")]
        bool IncluirProduto(EstoqueClienteV2.ServiceEstoqueV2.ProductData productData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(EstoqueClienteV2.ServiceEstoqueV2.ProductData productData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverProdutoResponse")]
        bool RemoverProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/VerProdutoResponse")]
        EstoqueClienteV2.ServiceEstoqueV2.ProductData VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServiceEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServiceEstoque/VerProdutoResponse")]
        System.Threading.Tasks.Task<EstoqueClienteV2.ServiceEstoqueV2.ProductData> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceEstoqueChannel : EstoqueClienteV2.ServiceEstoqueV2.IServiceEstoque, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceEstoqueClient : System.ServiceModel.ClientBase<EstoqueClienteV2.ServiceEstoqueV2.IServiceEstoque>, EstoqueClienteV2.ServiceEstoqueV2.IServiceEstoque {
        
        public ServiceEstoqueClient() {
        }
        
        public ServiceEstoqueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceEstoqueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEstoqueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceEstoqueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EstoqueClienteV2.ServiceEstoqueV2.ProductData[] ListProducts() {
            return base.Channel.ListProducts();
        }
        
        public System.Threading.Tasks.Task<EstoqueClienteV2.ServiceEstoqueV2.ProductData[]> ListProductsAsync() {
            return base.Channel.ListProductsAsync();
        }
        
        public bool IncluirProduto(EstoqueClienteV2.ServiceEstoqueV2.ProductData productData) {
            return base.Channel.IncluirProduto(productData);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(EstoqueClienteV2.ServiceEstoqueV2.ProductData productData) {
            return base.Channel.IncluirProdutoAsync(productData);
        }
        
        public bool RemoverProduto(string NumeroProduto) {
            return base.Channel.RemoverProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto) {
            return base.Channel.RemoverProdutoAsync(NumeroProduto);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
        
        public bool AdicionarEstoque(string NumeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoque(NumeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string NumeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoqueAsync(NumeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, quantidade);
        }
        
        public EstoqueClienteV2.ServiceEstoqueV2.ProductData VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<EstoqueClienteV2.ServiceEstoqueV2.ProductData> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/02", ConfigurationName="ServiceEstoqueV2.IServicoEstoqueV2")]
    public interface IServicoEstoqueV2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        bool RemoverEstoque(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/02/IServicoEstoqueV2/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string numeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueV2Channel : EstoqueClienteV2.ServiceEstoqueV2.IServicoEstoqueV2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueV2Client : System.ServiceModel.ClientBase<EstoqueClienteV2.ServiceEstoqueV2.IServicoEstoqueV2>, EstoqueClienteV2.ServiceEstoqueV2.IServicoEstoqueV2 {
        
        public ServicoEstoqueV2Client() {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarEstoque(string numeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, int quantidade) {
            return base.Channel.AdicionarEstoqueAsync(numeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string numeroProduto, int quantidade) {
            return base.Channel.RemoverEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, int quantidade) {
            return base.Channel.RemoverEstoqueAsync(numeroProduto, quantidade);
        }
        
        public int ConsultarEstoque(string numeroProduto) {
            return base.Channel.ConsultarEstoque(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string numeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(numeroProduto);
        }
    }
}
