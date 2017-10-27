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

        public List<string> ListProducts()
        {
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
                        ProductData productData = new ProductData()
                        {
                            NumeroProduto = p.NumeroProduto,
                            NomeProduto = p.NomeProduto,
                            DescricaoProduto = p.DescricaoProduto,
                            EstoqueProduto = p.EstoqueProduto
                        };
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


        public ProductData GetNumeroProduto(string NumeroProduto)
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


        public void SetNumeroProduto(string NumeroProduto)
        {
            ProductData productData = null;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
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
                        DescricaoProduto = matchingProduct.DescricaoProduto,
                        EstoqueProduto = matchingProduct.EstoqueProduto
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


        public void SetNomeProduto(string NomeProduto)
        {
            ProductData productData = null;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                    p => String.Compare(p.NomeProduto, NomeProduto) == 0);
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
        }

        public ProductData GetDescricaoProduto(string DescricaoProduto)
        {
            ProductData productData = null;
            List<string> productsList = new List<string>();
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                    p => String.Compare(p.DescricaoProduto, DescricaoProduto) == 0);
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
            // Return the product
            return productData;
        }

        public void SetDescricaoProduto(string DescricaoProduto)
        {
            ProductData productData = null;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                    p => String.Compare(p.DescricaoProduto, DescricaoProduto) == 0);
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
        }

        public ProductData GetEstoqueProduto(int EstoqueProduto)
        {
            ProductData productData = null;
            List<string> productsList = new List<string>();
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                    p => Int16.Equals(p.EstoqueProduto, EstoqueProduto));
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
            // Return the product
            return productData;
        }
        public void SetEstoqueProduto(int EstoqueProduto)
        {
            ProductData productData = null;
            try
            {
                // Connect to the ProductsModel database
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    // Find the first product that matches the specified product code
                    ProdutoEstoque matchingProduct = database.ProdutoE.First(
                    p => Int16.Equals(p.EstoqueProduto, EstoqueProduto));
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
        }
    }
}



