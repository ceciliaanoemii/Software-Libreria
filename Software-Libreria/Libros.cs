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

        public void libros_precargados()
        {
            var libro1 = new VentanaLibros("1", "Harry Potter", "J. K. Rowling", "Salamandra", 9000);

            lista_libros.Add(libro1);
            libro1 = new VentanaLibros("2", "El señor de los Anillo", "Tolkien", "Salamandra", 7000);
            lista_libros.Add(libro1);
            libro1 = new VentanaLibros("3", "Crónica de una muerte anunciada", "Gabriel Garcia Marquez", "Columbia", 10000);
            lista_libros.Add(libro1);
            libro1 = new VentanaLibros("4", "Ensayo de la Ceguera", "Jose Saramago", "Universal", 6000);
            lista_libros.Add(libro1);
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
            libros_precargados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (var item in lista_libros)
            {
                prueba.Text = item.getTitulo();
            }
        }

        private void btnLibrosDisponibles_Click(object sender, EventArgs e)
        {
            LibrosDisponibles ventanaLibrosDisponibles = new LibrosDisponibles(lista_libros);
            ventanaLibrosDisponibles.ShowDialog();
        }
    }
}
