using System;
using StaticMembers.utils;

namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)

        {

                string nome;
                double preco;
                int quantidade;

                Console.WriteLine("Entre os dados do produto:");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Preço: ");
                preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade no estoque: ");
                quantidade = int.Parse(Console.ReadLine());
                Product p = new Product(nome, preco, quantidade);

                Console.WriteLine("Dados do produto: " + p.GetNome() + ", $" + p.GetPreco() + ", " + p.GetQuantidade() + " unidades, Total: $" + p.ValorTotalEmEstoque());
                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p.GetNome() + ", $" + p.GetPreco() + ", " + p.GetQuantidade() + " unidades, Total: $" + p.ValorTotalEmEstoque());
                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser removido do estoque: ");

                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("Dados atualizados: " + p.GetNome() + ", $" + p.GetPreco() + ", " + p.GetQuantidade() + " unidades, Total: $" + p.ValorTotalEmEstoque()); 
        }
    }
}