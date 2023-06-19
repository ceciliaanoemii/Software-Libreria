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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void controlBotones()
        {
            if (txtUsuario.Text.Trim() != string.Empty && txtUsuario.Text.All(Char.IsLetter))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(txtUsuario, "");
            }
            else
            {
                if (!txtUsuario.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(txtUsuario, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "Debe introducir su nombre");
                }
                btnIngresar.Enabled = false;
                txtUsuario.Focus();
            }

        }



        private void Register_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (WindowDashboard winDashboard = new WindowDashboard(txtUsuario.Text, txtContrasenia.Text))
                winDashboard.ShowDialog();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
