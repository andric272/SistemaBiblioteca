using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}