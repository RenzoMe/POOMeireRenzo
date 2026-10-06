using System;
using System.Windows.Forms;
using POOMeireRenzo.View;

namespace POOMeireRenzo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConsultaPresupuestos());
        }
    }
}