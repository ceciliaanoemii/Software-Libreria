namespace Software_Libreria
{
    public partial class Form1 : Form
    {

        Cliente cliente1;
        public Form1()

        {
            cliente1 = new Cliente("Lucia", 48, "12456789", "Calle1", "08004564");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("Lucia", 48, "12456789", "Calle1", "08004564");
            Cliente cliente2 = new Cliente("Argel", 48, "7854345", "Calle2", "15487931");
            Cliente cliente3 = new Cliente("Angel", 56, "36985214", "Calle3", "114698204");
            Cliente cliente4 = new Cliente("Cecilia", 25, "1456987", "Calle4", "11453210");

            Cliente cliente5 = new Cliente("Celeste", 25, "12456789", "Calle4", "11453210");

            Vendedor vendedor1 = new Vendedor("Pablo", 50, "45110145", "Calle1", "08004564", "pablo@ifts.com", "12345");
            vendedor1.AgregarCliente(cliente1);
            vendedor1.AgregarCliente(cliente2);
            vendedor1.AgregarCliente(cliente3);
            vendedor1.AgregarCliente(cliente4);
            vendedor1.AgregarCliente(cliente5);


            vendedor1.mostrarClientes();

           textBox1.Text = vendedor1.ToString();
        }
    }
}