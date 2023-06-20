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
    public partial class LibrosDisponibles : Form
    {
        List<VentanaLibros> Lista_libros;
        public LibrosDisponibles(List<VentanaLibros> Lista_Libros)
        {
            InitializeComponent();
            Lista_libros = Lista_Libros;
        }

        public void MostrarLibro()
        {

            foreach (var item in Lista_libros)
            {
                int i = dataGridLibro.Rows.Add();
                dataGridLibro.Rows[i].Cells[0].Value = item.getIdLibro();

                dataGridLibro.Rows[i].Cells[1].Value = item.getTitulo();

                dataGridLibro.Rows[i].Cells[2].Value = item.getAutor();

                dataGridLibro.Rows[i].Cells[3].Value = item.getEditorial();

                dataGridLibro.Rows[i].Cells[4].Value = item.getPrecio();

                dataGridLibro.Rows[i].Cells[5].Value = Image.FromFile("images/image - " + item.getIdLibro() + ".jpg");
            }
        }

        private void LibrosDisponibles_Load(object sender, EventArgs e)
        {
            MostrarLibro();
        }

        private void dataGridLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*0
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<VentanaLibros> datos = Lista_libros.FindAll(busqueda());
        }

        public bool busqueda()
        {

            if (txtBusqueda.Text == '')
            {
                
            }
        }*/
    }
}
