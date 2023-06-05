using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Libreria
{
    internal abstract class  Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        private string direccion;
        private string telefono;

        public Persona(string nombre, int edad, string dni, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


    }
}
