using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPartsSQL
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //KaanOrtak.Global.Arayuz_Tasarim(this);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
