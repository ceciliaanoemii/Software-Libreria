namespace Software_Libreria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Cliente cliente1 = new Cliente("Lucia", 48, "12456789", "Calle1", "08004564");
            Cliente cliente2 = new Cliente("Argel", 48, "78", "Calle2", "15487931");
            Cliente cliente3 = new Cliente("Angel", 56, "36985214", "Calle3", "114698204");
            Cliente cliente4 = new Cliente("Cecilia", 25, "1456987", "Calle4", "11453210");

            Console.WriteLine(cliente3);
        }
    }
}