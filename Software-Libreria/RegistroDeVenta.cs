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
            string libro = txtSeleccionLibro.Text;
            if (libro.Equals("Harry Potter - Las reliquias de la muerte")) precio = 3000;
            if (libro.Equals("El señor de los anillos - Las dos torres")) precio = 4000;
            if (libro.Equals("Agatha Christie - Asesinato en Mesopotamia")) precio = 2000;

            lblPrecio.Text = precio.ToString("C");

        }
    }
}
