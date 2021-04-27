using System;
using Libros;

namespace Almacenador
{
    public class CAlmacenador
    {
        public static void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            libro.SectorBiblioteca = sector;
            libro.EstanteBiblioteca = estante;
        }
    }
}
