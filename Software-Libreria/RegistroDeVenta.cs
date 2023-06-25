using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;


namespace Software_Libreria
{
    public partial class RegistroDeVenta : Form
    {
        double precio = 0;
        List<VentanaLibros> Lista_libros;

        double subtotal = 0;
        double total = 0;
        double total_final = 0;
        VentanaLibros libro_seleccionado = new VentanaLibros("", "", "", "", 0);
        public RegistroDeVenta(List<VentanaLibros> Lista_Libros)
        {
            InitializeComponent();
            Lista_libros = Lista_Libros;
        }

        private void RegistroDeVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("D");
            lblPrecio.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");
            lblDescuento.Text = (0).ToString("C");
            //venta venta_actual = new venta();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MostrarLibro()
        {

            int i = dataGridLibro.Rows.Count - 1;

            dataGridLibro.Rows.Add();

            dataGridLibro.Rows[i].Cells[0].Value = txtCantidad.Text;

            dataGridLibro.Rows[i].Cells[1].Value = libro_seleccionado.getTitulo();

            dataGridLibro.Rows[i].Cells[2].Value = libro_seleccionado.getPrecio().ToString("C");

            dataGridLibro.Rows[i].Cells[3].Value = (Convert.ToInt32(txtCantidad.Text) * libro_seleccionado.getPrecio()).ToString("C");

            subtotal = (Convert.ToInt32(txtCantidad.Text) * libro_seleccionado.getPrecio());

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (libro_seleccionado.getTitulo() == "")
                MessageBox.Show("Debe seleccionar un producto...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar cantidad...!!!");
            else
            {
                //procesar calculos
                double descuento = 0;
                MostrarLibro();

                total_final = total_final + subtotal;

                if (total_final > 15000)
                {
                    descuento = 0.15 * total_final;
                    total = total_final - descuento;
                }
                else
                {
                    total = total_final;
                }
                lblDescuento.Text = descuento.ToString("C");
                lblTotal.Text = total.ToString("C");

                lblPrecio.Text = (0).ToString("C");

                labelTitulo.Text = "";
                txtCantidad.Text = "";
                textIdLibro.Text = "";

                libro_seleccionado = new VentanaLibros("", "", "", "", 0);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridLibro.Text = "(Seleccione Producto)";
            comboSeleccionTipoPago.Text = "(Seleccione Tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");
            dataGridLibro.Focus();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (textIdLibro.Text.Trim() != string.Empty)
            {
                VentanaLibros libro_aux = Lista_libros.Find(libro => libro.getIdLibro().Equals(textIdLibro.Text));
                labelTitulo.Text = libro_aux.getTitulo();
                lblPrecio.Text = libro_aux.getPrecio().ToString("C");
                libro_seleccionado = libro_aux;
            }
        }
        //Exportamos PDF
        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyy-HHmmss")) + ".pdf";
            savefile.ShowDialog();


            FileStream fs = new FileStream(savefile.FileName, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //titulo y autor
            doc.AddAuthor("Newbie-Coders");
            doc.AddTitle("Factura");

            // definir la fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Encabezado
            doc.Add(new Paragraph("Título factura"));
            doc.Add(new Paragraph(DateTime.Today.Date.ToString("D")));

            doc.Add(Chunk.NEWLINE);

            //Encabezado Columnas
            PdfPTable tblFactura = new PdfPTable(3);
            tblFactura.WidthPercentage = 100;

            //configuro titulo de columnas
            PdfPCell colNombre = new PdfPCell(new Phrase("Nombre Libro", standarFont));
            colNombre.BorderWidth = 0;
            colNombre.BorderWidthBottom = 0.75f;

            PdfPCell colCantidad = new PdfPCell(new Phrase("Cantidad", standarFont));
            colNombre.BorderWidth = 1;
            colNombre.BorderWidthBottom = 0.75f;

            PdfPCell colPrecio = new PdfPCell(new Phrase("Precio", standarFont));
            colNombre.BorderWidth = 1;
            colNombre.BorderWidthBottom = 0.75f;

            tblFactura.AddCell(colNombre);
            tblFactura.AddCell(colCantidad);
            tblFactura.AddCell(colPrecio);


            //Agregando datos

            foreach (var libro in Lista_libros)
            {
                colNombre = new PdfPCell(new Phrase(libro.getTitulo(), standarFont));
                colNombre.BorderWidth = 0;

                colCantidad = new PdfPCell(new Phrase(libro.getIdLibro(), standarFont));
                colNombre.BorderWidth = 0;

                colPrecio = new PdfPCell(new Phrase(libro.getPrecio().ToString(), standarFont));
                colPrecio.BorderWidth = 0;

                tblFactura.AddCell(colNombre);
                tblFactura.AddCell(colCantidad);
                tblFactura.AddCell(colPrecio);


            }
            doc.Add(tblFactura);

            doc.Close();
            pw.Close();

            MessageBox.Show("Documento generado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        // if (comboSeleccionTipoPago.SelectedIndex == -1)
        //  MessageBox.Show("Debe seleccionar un tipo de pago...!!!");

    }

    public class venta
    {
        private string id;
        List<ejemplar_libro> renglon;
        string fecha;
        VentanaCliente cliente_actual;

        venta (string id, List<ejemplar_libro> renglon)
        {
            this.id = id;
            this.renglon = renglon;
        }
    }

    public class ejemplar_libro
    {
        private string id;
        private string titulo;
        private string autor;
        private string editorial;
        private double precio;
        private int cantidad;

        ejemplar_libro(string i, string t, string a, string e, double p, int c)
        {
            this.id = i;
            this.titulo = t;
            this.autor = a;
            this.editorial = e;
            this.precio = p;
            this.cantidad = c;
        }
    }
}
