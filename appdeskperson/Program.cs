using appdeskperson.PresentationLayer;
using System;
using System.Windows.Forms;

namespace appdeskperson
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDIParent());
            //Application.Run(new FrmPerson());
        }
    }
}