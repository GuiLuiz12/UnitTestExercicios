using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class Ex2UnitTest
    {

        [Fact]
        public void ValidacaoTrue()
        {            
            var email = "gui@email.com";
            var expected = true;

            var result = Ex2.ValidarEmail(email);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ValidacaoSemPonto()
        {
            var email = "gui@email";
            var expected = false;

            var result = Ex2.ValidarEmail(email);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ValidacaoSemArroba()
        {
            var email = "guiemail.com";
            var expected = false;

            var result = Ex2.ValidarEmail(email);

            Assert.Equal(expected, result);
        }
    }
}

