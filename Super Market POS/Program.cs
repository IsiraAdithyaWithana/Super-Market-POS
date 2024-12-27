using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market_POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=Mandinu;Database=POS System;Integrated Security=True;";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int userId = 0; 
            Application.Run(new Form1(connectionString));
        }
    }
}
