using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAOMATVIDEO.HTN
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
            Application.Run(new fLogin());
            Application.Run(new BaoMatVideo());
            Application.Run(new fAccountProfile());
            Application.Run(new fEncDecVideo());
            Application.Run(new EncDecLinkVideo());
        }
    }
}
