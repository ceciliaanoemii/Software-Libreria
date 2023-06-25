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
        string contrasenia = "Admin1";
        string usuario = "Admin";

        public Register()
        {
            InitializeComponent();
        }
        private void controlBotones()
        {
            if (controlUsuario() && controlContrasenia())
            {
                btnIngresar.Enabled = true;
                MessageBox.Show("Usuario correcto, puede ingresar");
            }
        }
        private bool controlUsuario()
        {
            if (txtUsuario.Text.Trim() != string.Empty && txtUsuario.Text.All(Char.IsLetter) && txtUsuario.Text == usuario)
            {
                errorProvider1.SetError(txtUsuario, "");
                return true;
            }
            else
            {
                if (!txtUsuario.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(txtUsuario, "El nombre sólo debe contener letras sin espacios");
                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "Debe introducir su nombre");
                }
                txtUsuario.Focus();
                return false;
            }
        }
        private bool controlContrasenia()
        {
            if (txtContrasenia.Text.Trim() != string.Empty && txtContrasenia.Text.Equals(contrasenia))
            {
                errorProvider2.SetError(txtContrasenia, "");
                return true;

            }
            else
            {
                if (!txtContrasenia.Text.All(Char.IsLetter))
                {
                    errorProvider2.SetError(txtContrasenia, "Los datos son incorrectos");

                }
                else
                {
                    errorProvider2.SetError(txtContrasenia, "Debe introducir su contraseña");
                }
                txtContrasenia.Focus();
                return false;

            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            controlUsuario();

        }
        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (WindowDashboard winDashboard = new WindowDashboard(txtUsuario.Text, txtContrasenia.Text))
                winDashboard.ShowDialog();
        }

    }
}
