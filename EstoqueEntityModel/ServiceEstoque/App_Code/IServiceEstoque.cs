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
        //[OperationContract]
        List<string> ListProducts();

        [OperationContract]
        ProductData GetNumeroProduto(string NumeroProduto);
        [OperationContract]
        void SetNumeroProduto(string NumeroProduto);

        [OperationContract]
        ProductData GetNomeProduto(string NomeProduto);
        [OperationContract]
        void SetNomeProduto(string NomeProduto);

        [OperationContract]
        ProductData GetDescricaoProduto(string DescricaoProduto);
        [OperationContract]
        void SetDescricaoProduto(string DescricaoProduto);

        [OperationContract]
        ProductData GetEstoqueProduto(int EstoqueProduto);
        [OperationContract]
        void SetEstoqueProduto(int EstoqueProduto);
    }
}
