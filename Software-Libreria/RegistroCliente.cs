using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Libreria
{
    public partial class RegistroCliente : Form
    {
        private string path;
        List<VentanaCliente> listaCliente;
        public RegistroCliente(List<VentanaCliente> listaCl)
        {
            InitializeComponent();
            this.listaCliente = listaCl;
        }
        public void AgregarCliente(VentanaCliente cliente)
        {

            listaCliente.Add(cliente);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            // Suscribirse al evento TextChanged de los cuadros de texto
            txtdni.TextChanged += ValidarCampos;
            txtnombre.TextChanged += ValidarCampos;
            txtcelular.TextChanged += ValidarCampos;

            // Suscribirse al evento KeyPress para validar solo números
            txtdni.KeyPress += ValidarNumeros;
            txtcelular.KeyPress += ValidarNumeros;





            btnAddClient.Enabled = false;
        }

        private void ValidarCampos(object sender, EventArgs e)
        {
            // Verificar si todos los campos están llenos
            bool camposLlenos = !string.IsNullOrEmpty(txtdni.Text) &&
                                !string.IsNullOrEmpty(txtnombre.Text) &&
                                !string.IsNullOrEmpty(txtcelular.Text);

            // Habilitar o deshabilitar el botón según el estado de los campos
            btnAddClient.Enabled = camposLlenos;
        }

        private void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancelar el evento para evitar que se muestre el carácter en el cuadro de texto
                e.Handled = true;
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            int n = dgvClientes.Rows.Add();
            dgvClientes.Rows[n].Cells[0].Value = txtdni.Text;
            dgvClientes.Rows[n].Cells[1].Value = txtnombre.Text;
            dgvClientes.Rows[n].Cells[2].Value = txtcelular.Text;

            VentanaCliente clienteAux = new VentanaCliente();
            clienteAux.setTodo(txtdni.Text, txtnombre.Text, txtcelular.Text);
            AgregarCliente(clienteAux);

            txtdni.Text = "";
            txtnombre.Text = "";
            txtcelular.Text = "";
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {


        }



        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtdni, "");
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtcelular, "");
        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }



        /*  private void txtnombre_Validating(object sender, CancelEventArgs e)
          {

          }*/
    }
}
