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
            btnAddClient.Enabled = false;
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

        /*  private void controlBotones()
          {
              if (txtdni.Text.Trim() != string.Empty && txtdni.Text.All(Char.IsNumber))
              {
                  btnAddClient.Enabled = true;
                  errorProvider1.SetError(txtdni, "");
              }
              else
              {
                  if (!txtdni.Text.All(Char.IsLetter))
                  {
                      errorProvider1.SetError(txtdni, "El DNI sólo debe contener números");
                  }
                  else
                  {
                      errorProvider1.SetError(txtdni, "Debe introducir un número de Documento");
                  }
                  btnAddClient.Enabled = false;
                  txtdni.Focus();
              } 

          } */

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            /*  if (txtdni.Text == "" && txtnombre.Text == "")
              {
                  btnAddClient.Enabled = false;
              }
              else if (txtdni.Text == "" && txtnombre.Text != "")
              {
                  btnAddClient.Enabled = false;
              }
              else if (txtdni.Text != "" && txtnombre.Text != "")
              {
                  btnAddClient.Enabled = true;
              }*/
            if (System.Text.RegularExpressions.Regex.IsMatch(txtdni.Text, "[^0-9]"))
            {
                // Si se ingresan caracteres que no son números en txtdni, deshabilita el botón btnAddClient
                btnAddClient.Enabled = false;
            }
            else if (string.IsNullOrEmpty(txtdni.Text) && string.IsNullOrEmpty(txtnombre.Text))
            {
                // Verifica si tanto txtdni como txtnombre están vacíos
                btnAddClient.Enabled = false;
            }
            else if (string.IsNullOrEmpty(txtdni.Text) && !string.IsNullOrEmpty(txtnombre.Text))
            {
                // Verifica si txtdni está vacío pero txtnombre no
                btnAddClient.Enabled = false;
            }
            else
            {
                // Si txtdni no está vacío y txtnombre no está vacío, habilita el botón btnAddClient
                btnAddClient.Enabled = true;
            }


        }



        private void borrarMensajeError()
        {
            errorProvider1.SetError(txtdni, "");
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtcelular, "");
        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtdni.Text, "[^0-9]"))
            {
                // Si se ingresan caracteres que no son números en txtdni, deshabilita el botón btnAddClient
                btnAddClient.Enabled = false;
            }
            else if (string.IsNullOrEmpty(txtdni.Text) && string.IsNullOrEmpty(txtnombre.Text))
            {
                // Verifica si tanto txtdni como txtnombre están vacíos
                btnAddClient.Enabled = false;
            }
            else if (string.IsNullOrEmpty(txtdni.Text) && !string.IsNullOrEmpty(txtnombre.Text))
            {
                // Verifica si txtdni está vacío pero txtnombre no
                btnAddClient.Enabled = false;
            }
            else
            {
                // Si txtdni no está vacío y txtnombre no está vacío, habilita el botón btnAddClient
                btnAddClient.Enabled = true;
            }

        }



        /*  private void txtnombre_Validating(object sender, CancelEventArgs e)
          {

          }*/
    }
}
