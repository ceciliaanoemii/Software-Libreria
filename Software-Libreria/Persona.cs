using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Libreria
{
    internal abstract class  Persona
    {
        private string id { get; set; }
        private string nombre { get; set; }
        private int edad { get; set; }
        private string dni{ get; set; }
        private string direccion { get; set; }
        private string telefono { get; set; }

        public Persona(string id, string nombre, int edad, string dni, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        
      
    }
}
