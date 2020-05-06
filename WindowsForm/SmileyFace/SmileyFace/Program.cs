using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Exécution de Partie 1: Emojis
            Application.Run(new Form1());

            //Exécution de Partie 2: GenericList<T>
            // Application.Run(new Form2());
        }
    }
}
