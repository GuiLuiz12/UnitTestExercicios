using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Ex4;

namespace Calculos.Test
{
    public class Ex4UnitTest
    {
        [Fact]
        public void AdicionarProdutoNaoExistente()
        {
            var inventario = new Inventario();
            var nomeProduto = "Caneta";
            var quantidade = 10;

            inventario.AdicionarProduto(nomeProduto, quantidade);
            var quantidadeObtida = inventario.ObterQuantidade(nomeProduto);

            Assert.Equal(quantidade, quantidadeObtida);
        }

        [Fact]
        public void AdicionarProdutoExistente()
        {
            var inventario = new Inventario();
            var nomeProduto = "Caneta";
            var quantidadeInicial = 10;
            var quantidadeAdicional = 5;
            var quantidadeEsperada = 15;

            inventario.AdicionarProduto(nomeProduto, quantidadeInicial);
            inventario.AdicionarProduto(nomeProduto, quantidadeAdicional);
            var quantidadeObtida = inventario.ObterQuantidade(nomeProduto);

            Assert.Equal(quantidadeEsperada, quantidadeObtida);
        }

        [Fact]
        public void ObterQuantidadeComExistente()
        {
            var inventario = new Inventario();
            var nomeProduto = "Caneta";
            var quantidade = 10;

            inventario.AdicionarProduto(nomeProduto, quantidade);
            var quantidadeObtida = inventario.ObterQuantidade(nomeProduto);

            Assert.Equal(quantidade, quantidadeObtida);
        }
    }
}

