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
    public partial class RegistroDeVenta : Form
    {
        double precio = 0;
        List<VentanaLibros> Lista_libros;
        VentanaLibros libro_seleccionado = new VentanaLibros("", "", "", "", 0);
        double subtotal = 0;
        double total = 0;
        double total_final = 0;
        public RegistroDeVenta(List<VentanaLibros> Lista_Libros)
        {
            InitializeComponent();
            Lista_libros = Lista_Libros;
        }

        private void RegistroDeVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("D");
            lblPrecio.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");
            lblDescuento.Text = (0).ToString("C");
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarLibro()
        {

            int i = dataGridLibro.Rows.Count - 1;

            dataGridLibro.Rows.Add();

            dataGridLibro.Rows[i].Cells[0].Value = txtCantidad.Text;

            dataGridLibro.Rows[i].Cells[1].Value = libro_seleccionado.getTitulo();

            dataGridLibro.Rows[i].Cells[2].Value = libro_seleccionado.getPrecio().ToString("C");

            dataGridLibro.Rows[i].Cells[3].Value = (Convert.ToInt32(txtCantidad.Text) * libro_seleccionado.getPrecio()).ToString("C");

            subtotal = (Convert.ToInt32(txtCantidad.Text) * libro_seleccionado.getPrecio());

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (libro_seleccionado.getTitulo() == "")
                MessageBox.Show("Debe seleccionar un producto...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar cantidad...!!!");
            else
            {
                //procesar calculos
                double descuento = 0;

                total_final = total_final + subtotal;

                if (total_final > 15000)
                {
                    descuento = 0.15 * total_final;
                    total = total_final - descuento;
                }
                else
                {
                    total = total_final;
                }
                lblDescuento.Text = descuento.ToString("C");
                lblTotal.Text = total.ToString("C");
                MostrarLibro();

                lblPrecio.Text = (0).ToString("C");

                labelTitulo.Text = "";
                txtCantidad.Text = "";
                textIdLibro.Text = "";

                libro_seleccionado = new VentanaLibros("", "", "", "", 0);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridLibro.Text = "(Seleccione Producto)";
            comboSeleccionTipoPago.Text = "(Seleccione Tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");
            dataGridLibro.Focus();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (textIdLibro.Text.Trim() != string.Empty)
            {
                VentanaLibros libro_aux = Lista_libros.Find(libro => libro.getIdLibro().Equals(textIdLibro.Text));
                labelTitulo.Text = libro_aux.getTitulo();
                lblPrecio.Text = libro_aux.getPrecio().ToString("C");
                libro_seleccionado = libro_aux;
            }
        }


        // if (comboSeleccionTipoPago.SelectedIndex == -1)
        //  MessageBox.Show("Debe seleccionar un tipo de pago...!!!");

    }
}
