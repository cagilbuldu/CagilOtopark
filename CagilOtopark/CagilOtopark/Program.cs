using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CagilOtopark
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(anaSayfa);
        }
    }
}
