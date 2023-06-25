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
            DialogResult l = MessageBox.Show("Desea salir de la Aplicación?", "Registro Cliente ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (l == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            btnAddClient.Enabled = true;
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

        private void controlBotones()
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

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
