using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
namespace Products
{
    // Data contract describing the details of a product passed to client applications
    [DataContract]
    public class ProductData
    {
        [DataMember]
        public string NumeroProduto;
        [DataMember]
        public string NomeProduto;
        [DataMember]
        public string DescricaoProduto;
        [DataMember]
        public int EstoqueProduto;
    }
}
namespace Products
{
    [ServiceContract]
    public interface IServiceEstoque
    {
        // Get all products
        [OperationContract]
        List<string> ListProducts();
        // Get the details of a single product
        [OperationContract]
        ProductData GetProduct(string NumeroProduto);
        // Get the current stock for a product
    }
}
