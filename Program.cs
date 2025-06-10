using System;
using System.Windows.Forms;

namespace Library
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
            Windows.Init();
            Application.Run(Windows.UserAuth);
        }
    }
}
