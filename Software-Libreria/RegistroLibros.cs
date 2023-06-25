using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Software_Libreria
{
    public partial class RegistroLibros : Form
    {

        private string path;
        List<VentanaLibros> listaLibros;
        public RegistroLibros(List<VentanaLibros> lista_libros)
        {
            InitializeComponent();
            listaLibros = lista_libros;
            txtautor.TextChanged += txtautor_TextChanged;
            txttitulo.TextChanged += txttitulo_TextChanged;
            txtEditorial.TextChanged += txtEditorial_TextChanged;
            txtprecio.TextChanged += txtprecio_TextChanged;
            txtidlibro.TextChanged += txtidlibro_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void slregistrar_Click(object sender, EventArgs e)
        {

        }


        private void tslsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void AgregarLibro(VentanaLibros libro)
        {
            listaLibros.Add(libro);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int n = dgvRegistrosTotales.Rows.Add();
            dgvRegistrosTotales.Rows[n].Cells[0].Value = txtidlibro.Text;

            dgvRegistrosTotales.Rows[n].Cells[1].Value = txttitulo.Text;

            dgvRegistrosTotales.Rows[n].Cells[2].Value = txtautor.Text;

            dgvRegistrosTotales.Rows[n].Cells[3].Value = txtEditorial.Text;

            dgvRegistrosTotales.Rows[n].Cells[4].Value = txtprecio.Text;

            double pre = double.Parse(txtprecio.Text);

            VentanaLibros libro = new VentanaLibros();
            libro.setTodo(txtidlibro.Text, txttitulo.Text, txtautor.Text, txtEditorial.Text, pre);
            AgregarLibro(libro);

            txtidlibro.Text = "";
            txttitulo.Text = "";
            txtautor.Text = "";
            txtEditorial.Text = "";
            txtprecio.Text = (0).ToString("C");
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult l = MessageBox.Show("Desea salir de la Aplicación?", "Registro Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (l == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void btnSeleccionPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                path = abrir.FileName;
                boxPicture.Image = Image.FromFile(abrir.FileName);

            }
        }
        private void btnCopiarPic_Click(object sender, EventArgs e)
        {
            string id = txtidlibro.Text;
            File.Copy(path, "images/image - " + id + ".jpg", true);
            MessageBox.Show("Imagen cargada exitosamente!");
        }
        private void controlBotones()
        {
            if (txtidlibro.Text.Trim() != string.Empty && txtidlibro.Text.All(Char.IsNumber))
            {
                btnRegistrar.Enabled = true;
                errorProvider1.SetError(txtidlibro, "");
            }
            else
            {
                if (!txtidlibro.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(txtidlibro, "El Id sólo debe contener números");
                }
                else
                {
                    errorProvider1.SetError(txtidlibro, "Debe introducir un número de Id");
                }
                btnRegistrar.Enabled = false;
                txtidlibro.Focus();
            }

        }

        private void txtidlibro_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void RegistroLibros_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ValidarCampos()
        {
            // Validar campo Id Libro
            bool idValido = !string.IsNullOrEmpty(txtidlibro.Text) && txtidlibro.Text.All(char.IsDigit);

            // Validar campo Autor
            bool autorValido = !string.IsNullOrEmpty(txtautor.Text) && txtautor.Text.All(char.IsLetter);

            // Validar campo Titulo
            bool tituloValido = !string.IsNullOrEmpty(txttitulo.Text);

            // Validar campo Editorial
            bool editorialValido = !string.IsNullOrEmpty(txtEditorial.Text) && txtEditorial.Text.All(char.IsLetter);

            // Validar campo Precio
            bool precioValido = !string.IsNullOrEmpty(txtprecio.Text) && double.TryParse(txtprecio.Text, out _);

            // Habilitar o deshabilitar el botón de registrar según las validaciones
            btnRegistrar.Enabled = idValido && autorValido && tituloValido && editorialValido && precioValido;
        }

        private void txtautor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txttitulo_TextChanged_1(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
