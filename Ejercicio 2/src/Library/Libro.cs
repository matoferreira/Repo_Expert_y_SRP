using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

/* A continuación podemos ver como no se cumple el Principio SRP
Esto se debe a que, para cumplirlo, cada clase debe tener una única responsabilidad,
una única razón de cambio.
La clase Libro tiene dos responsabilidades, la primera es ser el constructor de los libros,
la segunda es almacenar los libros en un sector de la biblioteca.
Si nosotros quisieramos cambiar la forma en la que se almacenan los libros ahora, tendríamos que modificar la
clase Libro, de igual manera si necesitaramos cambiar la forma en la que se crean los libros.
Para cumplir con este principio es necesario crear una clase nueva cuya responsabilidad sea la de Almacenar los libros.
*/
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
