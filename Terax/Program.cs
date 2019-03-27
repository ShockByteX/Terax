using System;
using System.Windows.Forms;
using Terax.GUI.Forms;

namespace Terax
{
    static class Program
    {
        #region EntryPoint
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        #endregion
    }
}