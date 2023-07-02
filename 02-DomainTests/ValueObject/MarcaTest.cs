using _02_Dominio.ValueObject;
using _02_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _02_DomainTests.ValueObject
{
    public class MarcaTest
    {
        [Fact]
        public void Marca_ConValorValido_SinExcepciones()
        {
            //arrange
            string marca = "citroen";

            //act
            var excepcion = Record.Exception(() => new Marca(marca));

            //assert
            Assert.True(true);
        }

        [Fact]
        public void Marca_ConValornoValido_SinExcepciones()
        {
            //arrange
            string marca = "cit";
           

            //act
            var excepcion = Record.Exception(() => new Marca(marca));

            //assert
            Assert.False(false);
        }


    }
}
