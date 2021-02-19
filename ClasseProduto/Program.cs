using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            bool sairDoprograma = false;
            bool adicionarProduto = false;
            bool removerProduto = false;

            Console.Write("Digite adicionar ou remover: ");
            string resposta = Console.ReadLine();
            while (sairDoprograma != true)
            {
                if (resposta == "adicionar")
                {
                    adicionarProduto = true;
                    removerProduto = false;
                }
                else if (resposta == "remover")
                {
                    removerProduto = true;
                    adicionarProduto = false;
                }
                
                if (adicionarProduto == true)
                {   
                    Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.AdicionarProdutos(qte);
                    Console.WriteLine("Dados atualizados: " + p);
                }
                else if (removerProduto == true)
                {
                    Console.Write("Digite o número de produtos a ser removido do estoque: ");
                    int qte = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(qte);
                    Console.WriteLine();
                    Console.WriteLine("Dados atualizados: " + p);
                }
                Console.Write("O que voce deseja fazer digite adicionar, remover ou sair: ");
                resposta = Console.ReadLine();


            }
            Console.WriteLine("ATÉ A PROXIMA");
        }
    }
}