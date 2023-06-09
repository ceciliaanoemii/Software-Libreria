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

        public List<Cliente> BuscarCliente(string dni)
        {
            List<Cliente> clientesEncontrados = clientes.FindAll(cliente => cliente.DNI.Equals(dni));
            return clientesEncontrados;
        }

        public void AgregarCliente(Cliente cliente)
        {
            List<Cliente> clientesEncontrados = BuscarCliente(cliente.Nombre);

            if (clientesEncontrados.Count == 0)
            {
                clientes.Add(cliente);

                MessageBox.Show
                ("Cliente agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show
                ("El cliente ya existe en la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
