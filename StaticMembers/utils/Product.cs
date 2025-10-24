using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers.utils
{
    internal class Product
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public void SetPreco(double preco)
        {
            this.Preco = preco;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            this.Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public string DadosDoProduto()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
