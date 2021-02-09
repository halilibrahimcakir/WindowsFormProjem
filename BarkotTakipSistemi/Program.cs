using BarkotTakipSistemi.ADMİN_OPERATİON;
using BarkotTakipSistemi.CASE_OPERATİON;
using BarkotTakipSistemi.PRODUCT_OPERATION;
using BarkotTakipSistemi.SALES_OPERATİON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkotTakipSistemi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

    }
}
