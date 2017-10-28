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
    using System.Text;
    using System.ServiceModel.Activation;

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

    // WCF service that implements the service contract // This implementation performs minimal error checking and exception handling
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceEstoque : IServiceEstoque
    {

        public List<ProductData> ListProducts()
        {
            ProductData productData = null;
            List<ProductData> productsList = new List<ProductData>();
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Fetch the products in the database
                    List<ProdutoEstoque> products = (from p in database.ProdutoE select p).ToList();
                    foreach (ProdutoEstoque p in products)
                    {
                        productData = new ProductData()
                        {
                            NumeroProduto = p.NumeroProduto,
                            NomeProduto = p.NomeProduto,
                            DescricaoProduto = p.DescricaoProduto,
                            EstoqueProduto = p.EstoqueProduto
                        };
                        productsList.Add(productData);
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

        /*        public ProductData GetNumeroProduto(string NumeroProduto)
                {
                    ProductData productData = null;
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
                                productData = new ProductData()
                                {
                                    NumeroProduto = p.NumeroProduto,
                                    NomeProduto = p.NomeProduto,
                                    DescricaoProduto = p.DescricaoProduto,
                                    EstoqueProduto = p.EstoqueProduto
                                };
                                //productsList.Add(productData);
                            }
                        }

                    }
                    catch
                    {
                        // Ignore exceptions in this implementation
                    }
                    // Return the list of products
                    return productData;
                }




                public ProductData GetNomeProduto(string NomeProduto)
                {
                    ProductData productData = null;
                    List<string> productsList = new List<string>();
                    try
                    {
                        // Connect to the ProductsModel database
                        using (ProvedorEstoque database = new ProvedorEstoque())
                        {
                            ProdutoEstoque matchingProduct = database.ProdutoE.First(
                            p => String.Compare(p.NomeProduto, NomeProduto) == 0);
                            productData = new ProductData()
                            {
                                NumeroProduto = matchingProduct.NumeroProduto,
                                NomeProduto = matchingProduct.NomeProduto,
                               // DescricaoProduto = matchingProduct.DescricaoProduto,
                                //EstoqueProduto = matchingProduct.EstoqueProduto
                            };
                        }
                    }
                    catch
                    {
                        // Ignore exceptions in this implementation
                    }
                    // Return the product
                    return productData;
                }



                public void SetEstoqueProduto(string NumeroProduto)
                {
                    ProductData productData = null;
                    try
                    {
                        // Connect to the ProductsModel database
                        using (ProvedorEstoque database = new ProvedorEstoque())
                        {
                            // Find the first product that matches the specified product code
                            ProdutoEstoque matchingProduct = database.ProdutoE.First(
                            p => Int16.Equals(p.NumeroProduto, NumeroProduto));
                            productData = new ProductData()
                            {
                                NumeroProduto = matchingProduct.NumeroProduto,
                                NomeProduto = matchingProduct.NomeProduto,
                                DescricaoProduto = matchingProduct.DescricaoProduto,
                                EstoqueProduto = matchingProduct.EstoqueProduto
                            };

                        }
                    }
                    catch
                    {
                        // Ignore exceptions in this implementation
                    }
                }*/

        public bool IncluirProduto()
        {

            return true;
        }

        public bool RemoverProduto(string NumeroProduto) { return true; }

        public int ConsultarEstoque(string NumeroProduto)
        {
            int estoque = 0;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                    p => Int16.Equals(p.NumeroProduto, NumeroProduto));
                    estoque = matchingProduct.EstoqueProduto;
                }
            }
            catch
            {
                // Ignore exceptions in this implementation
            }
            // Return the product
            return estoque;
        }

        public bool AdicionarEstoque(string NumeroProduto, int quantidade)
        {
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the ProductID for the specified product
                    string productID = (from p in database.ProdutoE
                                     where String.Compare(p.NumeroProduto, NumeroProduto)==0
                                     select p.NumeroProduto).First();
                    ProdutoEstoque estoque = database.ProdutoE.First(pi => pi.NumeroProduto == productID);
                    estoque.EstoqueProduto = quantidade;
                    database.ProdutoE.Add(estoque);
                    // Save the change back to the database
                    database.SaveChanges();
                }
            }
            catch
            {
                // If an exception occurs, return false to indicate failure
                return false;
            }
            return true;
        }

        public bool RemoverEstoque(string NumeroProduto, int quantidade) { return true; }

        public ProductData VerProduto(string NumeroProduto)
        {
            ProductData productData = null;
            List<string> productsList = new List<string>();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                             p => String.Compare(p.NumeroProduto, NumeroProduto) == 0);
                        productData = new ProductData()
                        {
                            NumeroProduto = matchingProduct.NumeroProduto,
                            NomeProduto = matchingProduct.NomeProduto,
                            DescricaoProduto = matchingProduct.DescricaoProduto,
                            EstoqueProduto = matchingProduct.EstoqueProduto
                        };
                    }
                }
            catch
            {
                // Ignore exceptions in this implementation
            }
            return productData;
        }

    }
}



