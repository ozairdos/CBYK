using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroServiceClienteAPP
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

            frmIdentificador FrmIdentificador = new frmIdentificador();
            DialogResult resultado = FrmIdentificador.ShowDialog();
            if (resultado == DialogResult.Yes)
                Application.Run(new frmMicroService());

        }
    }
}
