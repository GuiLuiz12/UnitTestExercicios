using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {

        //principio AAA : Act, Arrange, e Assert
        //                Agir, Organizar e Provar

        [Fact]
        public void SomarDoisNumeros()
        {
            //Organizar (Arrange)
            var n1 = 3.3;
            var n2 = 2.2;
            var valorEsperado = 5.5;

            //Agir (Act)
            var soma = Calculo.Somar(n1, n2);

            //Provar (Assert)
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            var n1 = 3;
            var n2 = 4;
            var valorEsperado = 12;

            var multiplicacao = Calculo.Multiplicar(n1, n2);

            Assert.Equal(valorEsperado, multiplicacao);
        }

        [Fact]
        public void DividirDoisNumeros()
        {
            var n1 = 5;
            var n2 = 2;
            var valorEsperado = 2.5;

            var divisao = Calculo.Dividir(n1, n2);

            Assert.Equal(valorEsperado, divisao);
        }

        [Fact]
        public void SubtrairDoisNumeros()
        {
            var n1 = 10;
            var n2 = 7.5;
            var valorEsperado = 2.5;

            var subtracao = Calculo.Subtrair(n1, n2);

            Assert.Equal(valorEsperado, subtracao);
        }
    }
}
