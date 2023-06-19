using System.Windows.Forms;

namespace Software_Libreria
{
    public partial class WindowLogin : Form
    {
        public WindowLogin()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled = false;
        }

        private void controlBotones()
        {
            if (nombreUsuario.Text.Trim() != string.Empty && nombreUsuario.Text.All(Char.IsLetter))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(nombreUsuario, "");
            }
            else
            {
                if (!nombreUsuario.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(nombreUsuario, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombreUsuario, "Debe introducir su nombre");
                }
                btnIngresar.Enabled = false;
                nombreUsuario.Focus();
            }

        }
        private void nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void Contrasenia_TextChanged(object sender, EventArgs e)
        {

        }
        //*función ir a el otro formulario*//
        private void Ingresar_Click(object sender, EventArgs e)
        {
            using (WindowDashboard winDashboard = new WindowDashboard(nombreUsuario.Text, contrasenia.Text))
                winDashboard.ShowDialog();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (WindowDashboard winDashboard = new WindowDashboard(nombreUsuario.Text, contrasenia.Text))
                winDashboard.ShowDialog();
        }
    }
}