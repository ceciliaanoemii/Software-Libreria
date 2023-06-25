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
    public partial class VentanaLibros : Form
    {
        List<VentanaLibros> lista_libros;
        private string idLibro;
        private string titulo;
        private string autor;
        private string editorial;
        private double precio;

        public VentanaLibros(string l, string t, string a, string e, double p)
        {

            InitializeComponent();
            idLibro = l;
            titulo = t;
            autor = a;
            editorial = e;
            precio = p;
        }

        public VentanaLibros()
        {

            InitializeComponent();

        }
        public VentanaLibros(List<VentanaLibros> l)

        {


            InitializeComponent();
            lista_libros = l;

        }

        public void setTodo(string l, string t, string a, string e, double p)
        {
            idLibro = l;
            titulo = t;
            autor = a;
            editorial = e;
            precio = p;
        }

        public string getIdLibro()
        {
            return idLibro;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public string getAutor()
        {
            return autor;
        }
        public string getEditorial()
        {
            return editorial;
        }
        public double getPrecio()
        {
            return precio;
        }

        private void btnRegistraLibro_Click(object sender, EventArgs e)
        {
            RegistroLibros ventanaRegistroLibros = new RegistroLibros(lista_libros);
            ventanaRegistroLibros.ShowDialog();
        }

        private void VentanaLibros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnLibrosDisponibles_Click(object sender, EventArgs e)
        {
            LibrosDisponibles ventanaLibrosDisponibles = new LibrosDisponibles(lista_libros);
            ventanaLibrosDisponibles.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
