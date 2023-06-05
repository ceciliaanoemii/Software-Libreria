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
        private List<Venta> ventas { get; set; }
        private List<Cliente> clientes { get; set; }
        public Vendedor(string nombre, int edad, string dni, string direccion, string telefono, string user, string constrasenia) : base(nombre, edad, dni, direccion, telefono)
        {
            this.usuario = user;
            this.contrasenia = constrasenia;
            this.ventas = new List<Venta>();
            this.clientes = new List<Cliente>();
        }

        public Cliente BuscarCliente(string dni)
        {
            int index = 0;
            Cliente ClienteEncontrado = null;

            while (index < this.clientes.Count)
            {
                if (clientes[index].DNI == dni)
                {
                    ClienteEncontrado = clientes[index];
                }
                index++;
            }

            return ClienteEncontrado; // Si no se encuentra el cliente, se devuelve null
        }

        public void AgregarCliente(Cliente cliente)
        {
            Cliente nuevoCliente;
            Cliente ClienteEncontrado = BuscarCliente(cliente.DNI);
            if(ClienteEncontrado != null)
            {
                Console.WriteLine("El cliente ya existe en la base de datos");
            }
            nuevoCliente = new Cliente(cliente.Nombre,cliente.Edad,cliente.DNI,cliente.Direccion, cliente.Telefono);
            this.clientes.Add(nuevoCliente);
        }

        public void EliminarCliente(string dni)
        {
            Cliente ClienteEncontrado = BuscarCliente(dni);
            if (ClienteEncontrado == null)
            {
                Console.WriteLine("El cliente no existe en la base de datos para ser eliminado");       
            }
            else
            {
                this.clientes.Remove(ClienteEncontrado);
                Console.WriteLine("Cliente elimanado exitosamente");
            }
        }

    }
}
