﻿using System;
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
    public partial class WindowDashboard : Form
    {
        string nombre_vendedor;
        List<VentanaLibros> lista_libros = new List<VentanaLibros>();
        public WindowDashboard(string usuario, string contrasenia)
        {
            InitializeComponent();
            libros_precargados();
            nombre_vendedor = usuario;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowDashboard_Load(object sender, EventArgs e)
        {
            label1.Text += nombre_vendedor;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            
            using (VentanaLibros ventanaLibros = new VentanaLibros(lista_libros))
                ventanaLibros.ShowDialog();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            using (RegistroDeVenta VentanaVenta = new RegistroDeVenta(lista_libros))
                VentanaVenta.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnClients_Click(object sender, EventArgs e)
        {
            using (VentanaCliente ventanaClientes = new VentanaCliente())
                ventanaClientes.ShowDialog();
        }

    }
}
