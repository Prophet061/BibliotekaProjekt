using System;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Czytelnicy());
=======
            Application.Run(new Bibliotekarze());
>>>>>>> 3bc40f5b5a22278cb9486a7819e0142f79b2bff4
        }
    }
}
