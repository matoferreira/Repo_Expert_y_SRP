using System;
using Almacenador;
using Libros;

namespace Program
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            CAlmacenador.AlmacenarLibro(libro1,"A","7");
            CAlmacenador.AlmacenarLibro(libro2,"B","3");

        }
    }
}
