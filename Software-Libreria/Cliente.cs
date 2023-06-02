using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Libreria
{
    internal class Cliente : Persona
    {
        public Cliente(string id, string nombre, int edad, string dni, string direccion, string telefono) : base(id, nombre, edad, dni, direccion, telefono)
        {
        }
    }
}
