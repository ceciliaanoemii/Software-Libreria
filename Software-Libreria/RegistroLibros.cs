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
    public partial class RegistroLibros : Form
    {
        public RegistroLibros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void slregistrar_Click(object sender, EventArgs e)
        {
           
        }
       

        private void tslsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int n = dgvRegistrosTotales.Rows.Add();
            dgvRegistrosTotales.Rows[n].Cells[0].Value = txtidlibro.Text;

            dgvRegistrosTotales.Rows[n].Cells[1].Value = txttitulo.Text;

            dgvRegistrosTotales.Rows[n].Cells[2].Value = txtautor.Text;

            dgvRegistrosTotales.Rows[n].Cells[3].Value = txtEditorial.Text;

            dgvRegistrosTotales.Rows[n].Cells[4].Value = txtprecio.Text;

            txtidlibro.Text = " ";
            txttitulo.Text = " ";
            txtautor.Text = " ";
            txtEditorial.Text = " ";
            txtprecio.Text = " ";

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult l = MessageBox.Show("Desea salir de la Aplicación?", "Registro Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (l == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
