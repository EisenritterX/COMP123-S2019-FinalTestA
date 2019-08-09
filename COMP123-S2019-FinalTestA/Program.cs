using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_FinalTestA.Views;

namespace COMP123_S2019_FinalTestA
{
    static class Program
    {
        // This is temporary
        public static MasterForm masterForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            masterForm = new MasterForm();

            Application.Run(masterForm);
        }
    }
}
