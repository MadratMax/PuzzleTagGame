using System;
using System.Windows.Forms;

namespace PuzzleTag
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
            AppSettingsValidator.CheckSettingsAndContinue();
            Application.Run(new PuzzleTag());
        }
    }
}
