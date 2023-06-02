using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Libreria
{
    internal class Vendedor : Persona
    {
        private string usuario { get; set; }
        private string contrasenia { get; set; }
        private List<Venta> ventas;
        public Vendedor(string id, string nombre, int edad, string dni, string direccion, string telefono, string user, string constrasenia) : base(id, nombre, edad, dni, direccion, telefono)
        {
            this.usuario = user;
            this.contrasenia = constrasenia;
            this.ventas = new List<Venta>();
        }
    }
}
