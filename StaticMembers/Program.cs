using System;
using StaticMembers.utils;

namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Product p = new Product("TV", 500.00, 10);

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