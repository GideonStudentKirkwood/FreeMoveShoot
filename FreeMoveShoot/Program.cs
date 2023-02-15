using ShooterDataObjects;
using System.Windows.Forms;

namespace FreeMoveShoot
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppData.DataPath = Application.StartupPath + "\\" + AppData.DataFolder;
            

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}