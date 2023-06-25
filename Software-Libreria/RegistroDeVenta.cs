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
        List<VentanaLibros> Lista_libros;
        List<Ejemplar_libro> Lista_Ejemplares = new List<Ejemplar_libro>();
        VentanaLibros libro_seleccionado = new VentanaLibros("", "", "", "", 0);
        List<VentanaCliente> lista_clientes;
        VentanaCliente cliente_cli;

        double subtotal = 0;
        double total = 0;
        double total_final = 0;
        public RegistroDeVenta(List<VentanaLibros> Lista_Libros, List<VentanaCliente> lista_clientes)
        {
            InitializeComponent();
            Lista_libros = Lista_Libros;
            this.lista_clientes = lista_clientes;
        }

        private void RegistroDeVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("D");
            lblPrecio.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");
            lblDescuento.Text = (0).ToString("C");
            //venta venta_actual = new venta(); Esto se ejecuta al generar la factura
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

                Ejemplar_libro filaEjemplar = new Ejemplar_libro(libro_seleccionado.getIdLibro(), libro_seleccionado.getTitulo(), libro_seleccionado.getPrecio(), Convert.ToInt32(txtCantidad.Text));

                Lista_Ejemplares.Add(filaEjemplar);


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
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            lblTotal.Text = (0).ToString("C");
            dataGridLibro.Focus();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (textIdLibro.Text.Trim() != string.Empty)
            {
                VentanaLibros libro_aux = Lista_libros.Find

                (libro => libro.getIdLibro().Equals(textIdLibro.Text));
                labelTitulo.Text = libro_aux.getTitulo();
                lblPrecio.Text = libro_aux.getPrecio().ToString("C");
                libro_seleccionado = libro_aux;
            }
        }

        public Venta llenarFactura() {

            Venta venta = new Venta(DateTime.Now.ToString("ddMMyyyyHHmmss"), Lista_Ejemplares, DateTime.Today.Date.ToString("D"),total_final, total);
            return venta;
        }


        //Exportamos PDF
        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            llenarFactura();
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
            doc.Add(new Paragraph("Factura número: " + llenarFactura().getId()));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Fecha: " + DateTime.Today.Date.ToString("D")));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Datos Cliente: " + cliente_cli.getNombre()));
            doc.Add(Chunk.NEWLINE);

            //Encabezado Columnas
            PdfPTable tblFactura = new PdfPTable(4);
            tblFactura.WidthPercentage = 100;

            //configuro titulo de columnas
            PdfPCell colNombre = new PdfPCell(new Phrase("Nombre Libro", standarFont));
            colNombre.BorderWidth = 1;
            colNombre.BorderWidthBottom = 0.75f;

            PdfPCell colCantidad = new PdfPCell(new Phrase("Cantidad", standarFont));
            colNombre.BorderWidth = 1;
            colNombre.BorderWidthBottom = 0.75f;

            PdfPCell colPrecio = new PdfPCell(new Phrase("Precio", standarFont));
            colNombre.BorderWidth = 1;
            colNombre.BorderWidthBottom = 0.75f;

            PdfPCell colImporte = new PdfPCell(new Phrase("Importe", standarFont));
            colNombre.BorderWidth = 1;
            colNombre.BorderWidthBottom = 0.75f;

            tblFactura.AddCell(colNombre);
            tblFactura.AddCell(colCantidad);
            tblFactura.AddCell(colPrecio);
            tblFactura.AddCell(colImporte);




            //Agregando datos

            foreach (var libro in Lista_Ejemplares)
            {
                colNombre = new PdfPCell(new Phrase(libro.getTitulo(), standarFont));
                colNombre.BorderWidth = 1;
                colNombre.BorderWidthBottom = 0.75f;

                colCantidad = new PdfPCell(new Phrase(libro.getCantidad().ToString(), standarFont));
                colNombre.BorderWidth = 1;
                colNombre.BorderWidthBottom = 0.75f;

                colPrecio = new PdfPCell(new Phrase(libro.getPrecio().ToString("C"), standarFont));
                colNombre.BorderWidth = 1;
                colNombre.BorderWidthBottom = 0.75f;


                colImporte = new PdfPCell(new Phrase((libro.getPrecio()*libro.getCantidad()).ToString("C"), standarFont));
                colNombre.BorderWidth = 1;
                colNombre.BorderWidthBottom = 0.75f;

                tblFactura.AddCell(colNombre);
                tblFactura.AddCell(colCantidad);
                tblFactura.AddCell(colPrecio);
                tblFactura.AddCell(colImporte);

            }

            doc.Add(tblFactura);
            
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Descuento: " + (llenarFactura().getTotal()-llenarFactura().getDescuento()).ToString("C")));
           
            string col_total = (llenarFactura().getDescuento().ToString("C"));
            doc.Add(new Paragraph("Total: " + col_total));

            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("! Gracias por elegirnos !\nLibrería Mayorista NEWBIE-CODERS\nDirección: Cecilia Grierson 55"));

            doc.Close();
            pw.Close();

            MessageBox.Show("Documento generado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btnSelecCliente_Click_1(object sender, EventArgs e)
        {
            if (txtDniCliente.Text.Trim() != string.Empty)
            {
                cliente_cli = lista_clientes.Find(cliente => cliente.getDni().Equals(txtDniCliente.Text));

                if (cliente_cli == null)
                {
                    using (RegistroCliente ventanaRegisCli = new RegistroCliente(lista_clientes))
                        ventanaRegisCli.ShowDialog();
                }
                else
                {
                    lblNombreCliente.Text = cliente_cli.getNombre();
                }
            }
        }
    }
    public class Venta
    {
        private string id;
        public List<Ejemplar_libro> ejemplares;
        private string fecha;
        private double total;
        private double descuento;

        public Venta(string id, List<Ejemplar_libro> ejemplares, string fecha, double total, double descuento)
        {
            this.id = id;
            this.ejemplares = ejemplares;
            this.fecha = fecha;
            this.total = total;
            this.descuento = descuento;
        }

        public string getId() { return id; }
        public List<Ejemplar_libro> getEjemplares() { return ejemplares; }
        public string getFecha() { return fecha; }
        public double getTotal() { return total; }
        public double getDescuento() { return descuento; }

    }

    public class Ejemplar_libro
    {
        private string id;
        private string titulo;
        private double precio;
        private int cantidad;

        public Ejemplar_libro(string i, string t, double p, int c)
        {
            this.id = i;
            this.titulo = t;
            this.precio = p;
            this.cantidad = c;
        }

        public string getId() { return id; }
        public string getTitulo() { return titulo; }
        public double getPrecio() { return precio; }
        public int getCantidad() { return cantidad; }
       

    }
}
