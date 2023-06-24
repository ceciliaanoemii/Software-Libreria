using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Windows.Forms.Design;

namespace Software_Libreria
{
    public partial class RegistroDeVenta : Form
    {
        double precio = 0;

        public RegistroDeVenta()
        {
            InitializeComponent();
        }

        private void RegistroDeVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("D");
            lblPrecio.Text = (0).ToString("C");
        }

        private void txtSeleccionLibro_TextChanged(object sender, EventArgs e)
        {
            string libro = comboSeleccionLibro.Text;
            if (libro.Equals("Harry Potter - Las reliquias de la muerte")) precio = 3000;
            if (libro.Equals("El señor de los anillos - Las dos torres")) precio = 4000;
            if (libro.Equals("Agatha Christie - Asesinato en Mesopotamia")) precio = 2000;

            lblPrecio.Text = precio.ToString("C");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (comboSeleccionLibro.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto...!!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar cantidad...!!!");
            else if (comboSeleccionTipoPago.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de pago...!!!");
            else
            {
                //capturando datos
                string libro = comboSeleccionLibro.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = comboSeleccionTipoPago.Text;

                //procesar calculos
                double subtotal = cantidad * precio;
                double descuento = 0;
                double recargo = 0;

                if (tipo.Equals("Efectivo"))
                    descuento = 0.15 * subtotal;
                else if (tipo.Equals("Tarjeta"))
                    descuento = 0.10 * subtotal;
                else
                    recargo = 0.10 * subtotal;

                double precioFinal = subtotal - descuento + recargo;

                //impresión de resultados
                ListViewItem Unafila = new ListViewItem(libro);
                Unafila.SubItems.Add(cantidad.ToString());
                Unafila.SubItems.Add(precio.ToString());
                Unafila.SubItems.Add(tipo);
                Unafila.SubItems.Add(descuento.ToString());
                Unafila.SubItems.Add(recargo.ToString());
                Unafila.SubItems.Add(precioFinal.ToString());


                listVenta.Items.Add(Unafila);
                btnCancelar_Click(sender, e);


            }

        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            comboSeleccionLibro.Text = "(Seleccione Producto)";
            comboSeleccionTipoPago.Text = "(Seleccione Tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            comboSeleccionLibro.Focus();
        }

        private void btnGenFac_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss")) + ".pdf";
            savefile.ShowDialog();


            FileStream fs = new FileStream(savefile.FileName, FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //titulo y autor
            doc.AddAuthor("Tu libreria");
            doc.AddTitle("Pdf Gernerado");

            // fuente

            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // encabezado
            doc.Add(new Paragraph("Titulo del Documento"));
            doc.Add(Chunk.NEWLINE);

            // encabezado columna

            PdfPTable tblEjemplo = new PdfPTable(3);
            tblEjemplo.WidthPercentage = 80;

            //Titulo Columnas
            PdfPCell clnombre = new PdfPCell(new Phrase("Nombre Libro", standarFont));
            clnombre.BorderWidth = 0;
            clnombre.BorderWidthBottom = 0.75f;

            PdfPCell cltotal = new PdfPCell(new Phrase("Cantidad", standarFont));
            clnombre.BorderWidth = 0;
            clnombre.BorderWidthBottom = 0.75f;

            PdfPCell clcantidad = new PdfPCell(new Phrase("Total", standarFont));
            clnombre.BorderWidth = 0;
            clnombre.BorderWidthBottom = 0.75f;


            tblEjemplo.AddCell(clnombre);
            tblEjemplo.AddCell(cltotal);
            tblEjemplo.AddCell(clcantidad);

            doc.Add(tblEjemplo);

            doc.Close();
            pw.Close();

            MessageBox.Show("Documento creado con exito");










        }


    }
}
