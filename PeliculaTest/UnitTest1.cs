using System;
using System.IO;
using Xunit;
using Pelicula;


namespace PeliculaTest
{

    public class UnitTest1
    {
        [Fact]
        public void GetSetPelicula()
        {
            var p1 = new Pelicula.Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);

            Assert.Equal("La La Land", p1.GetTitulo());
            Assert.Equal(2016 , p1.GetAño());
        }

        [Fact]
        public void ConstructorPelicula()
        {
            var p1 = new Pelicula.Pelicula();
            var p2 = new Pelicula.Pelicula("La La Land", 2016);

            Assert.NotNull(p1);
            Assert.NotNull(p2);
            
        }

        [Fact]
        public void ImprimePelicula()
        {
            
            using (StringWriter s = new StringWriter())
            {
                Console.SetOut(s);
                var p2 = new Pelicula.Pelicula("La La Land", 2016);
                p2.Imprime();

                var result = s.ToString().Trim();
                Assert.Equal("La La Land (2016)", result);
            }
        }

        [Fact]
        public void ImprimeActores()
        {

            Pelicula.Pelicula p1 = new Pelicula.Pelicula("La La Land", 2016);
            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));

            

            

            using (StringWriter s = new StringWriter())
            {
                Console.SetOut(s);
                
                p1.ImprimeActores();

                var result = s.ToString().Trim().Replace("\r","");
                Assert.Equal("Ryan Gosling (1980)\nEmma Stone (1988)", result );
            }
        }
    }
}
