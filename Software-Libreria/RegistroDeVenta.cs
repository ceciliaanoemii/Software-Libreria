using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public RegistroDeVenta(List<VentanaLibros> lista_libros)
        {
            InitializeComponent();
            Lista_libros = lista_libros;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                ListViewItem fila = new ListViewItem(libro);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());


                listVenta.Items.Add(fila);
                btnCancelar_Click(sender, e);


            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            comboSeleccionLibro.Text = "(Seleccione Producto)";
            comboSeleccionTipoPago.Text = "(Seleccione Tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            comboSeleccionLibro.Focus();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)


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
    }
}
