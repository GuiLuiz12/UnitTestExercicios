using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Ex4
    {
        public class Produto
        {
            public string? Nome { get; set; }
            public int Quantidade { get; set; }
        }

        public class Inventario
        {
            private readonly List<Produto> _produtos;

            public Inventario()
            {
                _produtos = new List<Produto>();
            }

            public void AdicionarProduto(string nome, int quantidade)
            {
                var produtoExistente = _produtos.Find(p => p.Nome == nome);

                if (produtoExistente != null)
                {
                    produtoExistente.Quantidade += quantidade;
                }
                else
                {
                    _produtos.Add(new Produto { Nome = nome, Quantidade = quantidade });
                }
            }

            public int ObterQuantidade(string nome)
            {
                var produto = _produtos.Find(p => p.Nome == nome);
                return produto != null ? produto.Quantidade : 0;
            }
        }
    }
}
