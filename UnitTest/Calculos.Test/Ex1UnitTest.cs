using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Ex1;

namespace Calculos.Test
{
    public class Ex1UnitTest
    {
        [Fact]
        public void AdicionarLivroLista()
        {
            var gerenciador = new GerenciarLivros();
            var livro = new Livro
            {
                Titulo = "O Alquimista",
            };

            gerenciador.AdicionarLivro(livro);
            var livros = gerenciador.ObterLivros();

            Assert.Contains(livro, livros);
        }
    }
}

