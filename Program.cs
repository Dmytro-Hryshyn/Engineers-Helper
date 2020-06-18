using Engineers_Helper.Forms.Geometry;
using System;
using System.Windows.Forms;

namespace Engineers_Helper
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
            Application.Run(new RectangleForm());
        }
    }
}
