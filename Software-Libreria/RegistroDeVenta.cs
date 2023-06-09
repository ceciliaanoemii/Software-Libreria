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

        public RegistroDeVenta()
        {
            InitializeComponent();
        }
        private void RegistroDeVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("D");
            lblPrecio.Text = (0).ToString("C");
        }

        private void txtSeleccionLibro_TextChanged(object sender, EventArgs e)
        {
            string libro = comboSeleccionLibro.Text;
            if (libro.Equals("Harry Potter - Las reliquias de la muerte")) precio = 3000;
            if (libro.Equals("El señor de los anillos - Las dos torres")) precio = 4000;
            if (libro.Equals("Agatha Christie - Asesinato en Mesopotamia")) precio = 2000;

            lblPrecio.Text = precio.ToString("C");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (comboSeleccionLibro.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar cantidad...!!!");
            else if (comboSeleccionTipoPago.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de pago...!!!");
            else
            {
                //capturando datos
                string libro = comboSeleccionLibro.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = comboSeleccionTipoPago.Text;

                //procesar calculos
                double subtotal = cantidad * precio;
                double descuento = 0;
                double recargo = 0;

                if (tipo.Equals("Efectivo"))
                    descuento = 0.15 * subtotal;
                else if (tipo.Equals("Tarjeta"))
                    descuento = 0.10 * subtotal;
                else
                    recargo = 0.10 * subtotal;

                double precioFinal = subtotal - descuento + recargo;

                //impresión de resultados
                ListViewItem fila = new ListViewItem(libro);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());


                listVenta.Items.Add(fila);
                btnCancelar_Click(sender, e);


            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            comboSeleccionLibro.Text = "(Seleccione Producto)";
            comboSeleccionTipoPago.Text = "(Seleccione Tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            comboSeleccionLibro.Focus();
        }
    }
}
