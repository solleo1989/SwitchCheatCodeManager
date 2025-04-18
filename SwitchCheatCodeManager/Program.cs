using System;
using System.Windows.Forms;

namespace SwitchCheatCodeManager
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.PerMonitor);
            Application.Run(new WinForm.MainForm(
                new Helper.MainHelper(),
                new Helper.ActionHelper()
                )); ;
        }
    }
}
