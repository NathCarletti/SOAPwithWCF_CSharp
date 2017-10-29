using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EstoqueCliente.ServiceEstoque;

namespace EstoqueCliente // óia aqui"""o.o Esse serviceEstoque... isso é referencia do service... ele pediu pra referenciar a library
    // vou te passar como mudar depois... mas seguinte, primeiro vc faz dessa forma mesmo pro segundo cliente.
    // Agora vc cria um cliente pra V2. O que muda é que na referencia, vc vai escolher o V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            ServiceEstoqueClient proxy = new ServiceEstoqueClient(
                "BasicHttpBinding_IServicoEstoque"); // Esse nome tbm vai mudar no segundo cliente... né kkkkrigadakk mas enfim
            // O nome disso muda no segundo cliente, fica "WS2007HttpBinding_IServicoEstoque", que é o que ta na apostila ta sz b

            Console.WriteLine("Test 1: List all products");
            List<ProductData> products = proxy.ListProducts().ToList();
            foreach (ProductData p in products)
            {
                Console.WriteLine("Numero: {0}", p.NumeroProduto);
                Console.WriteLine("Nome: {0}", p.NomeProduto);
                Console.WriteLine("Descricao: {0}", p.DescricaoProduto);
                Console.WriteLine("Estoque: {0}", p.EstoqueProduto);
                Console.WriteLine();
            }
            Console.WriteLine();
            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
