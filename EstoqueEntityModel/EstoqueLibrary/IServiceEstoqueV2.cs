using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


    // Data contract describing the details of a product passed to client applications
    
namespace Products
{
    [ServiceContract]
    public interface IServiceEstoqueV2
    {
        [OperationContract]
        int ConsultarEstoque(string NumeroProduto);

        [OperationContract]
        bool AdicionarEstoque(string NumeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(string NumeroProduto, int quantidade);

    }
}