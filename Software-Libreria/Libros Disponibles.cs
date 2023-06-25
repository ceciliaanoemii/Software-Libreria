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

        public void MostrarLibro(List<VentanaLibros> l)
        {

            foreach (var item in l)
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
            MostrarLibro(Lista_libros);

        }

        private void dataGridLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<VentanaLibros> BuscarLibro()
        {
            if (txtBusqueda.Text.Trim() != string.Empty)
            {
                List<VentanaLibros> librosEncontrados = Lista_libros.FindAll(libro => libro.getIdLibro().Equals(txtBusqueda.Text));
                dataGridLibro.Rows.Clear();
                return librosEncontrados;
            }
            else
            {
                dataGridLibro.Rows.Clear();
                return Lista_libros;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarLibro(BuscarLibro());

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click_Click(object sender, EventArgs e)
        {
           
                if (dataGridLibro.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridLibro.SelectedRows[0].Index;
                    string libroId = dataGridLibro.Rows[selectedRowIndex].Cells[0].Value.ToString();

                    // Eliminar el libro de la lista
                    VentanaLibros libroEliminado = Lista_libros.Find(libro => libro.getIdLibro() == libroId);
                    Lista_libros.Remove(libroEliminado);

                    // Actualizar la visualización de libros
                    MostrarLibro(BuscarLibro());

                    // Mostrar alerta de libro eliminado
                    MessageBox.Show("Libro eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
