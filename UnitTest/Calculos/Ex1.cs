using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Ex1
    {
        public class Livro
        {
            public string Titulo { get; set; }
        }

        public class GerenciarLivros
        {
            private List<Livro> livros;

            public GerenciarLivros()
            {
                livros = new List<Livro>();
            }

            public void AdicionarLivro(Livro livro)
            {
                livros.Add(livro);
            }

            public List<Livro> ObterLivros()
            {
                return livros;
            }
        }
    }
}
