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
    public partial class WindowDashboard : Form
    {
        string nombre_vendedor;
        string contrasenia_vendedor;
        public WindowDashboard(string usuario, string contrasenia)
        {
            InitializeComponent();
            nombre_vendedor = usuario;
            contrasenia_vendedor = contrasenia;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowDashboard_Load(object sender, EventArgs e)
        {
            label1.Text += nombre_vendedor;
        }
    }
}
