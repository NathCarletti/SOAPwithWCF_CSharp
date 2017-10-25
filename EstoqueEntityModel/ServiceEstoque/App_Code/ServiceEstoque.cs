using System;
using System.Collections.Generic;
using System.ServiceModel.Activation;
using EstoqueEntityModel;
using EstoqueEntityModel.Migrations;
namespace Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    using System.ServiceModel.Activation;
    // WCF service that implements the service contract // This implementation performs minimal error checking and exception handling
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceEstoque : IServiceEstoque
    {
        public ProductData GetProduct(string NumeroProduto)
        {
            throw new NotImplementedException();
        }

        public List<string> ListProducts()
        {
            // Create a list of products
            List<string> productsList = new List<string>();
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Fetch the products in the database
                    List<ProdutoEstoque> products = (from p in database.ProdutoE select p).ToList();
                    foreach (ProdutoEstoque p in products)
                    {
                        productsList.Add(p.NumeroProduto);
                    }
                }

            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the list of products
            return productsList;
        }
    }
}


