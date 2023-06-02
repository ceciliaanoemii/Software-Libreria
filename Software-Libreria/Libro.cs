using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Libreria
{
    internal class Libro
    {
        private string idLibro { get; set; }
        private string titulo { get; set; }
        private string autor { get; set; }
        private string editorial { get; set; }
        private double precio { get; set; }

        public Libro(string titulo, string autor, string editorial, double precio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.precio = precio;
        }
    }
}
