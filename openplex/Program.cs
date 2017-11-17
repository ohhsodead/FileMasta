using System;
using System.Diagnostics;
using System.Windows.Forms;
using UnhandledExceptions;

namespace OpenTheatre
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Debugger.IsAttached)
            {
                Run();
                return;
            }

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ExceptionsEvents.ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += ExceptionsEvents.CurrentDomainUnhandledException;

            Run();
        }

        static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOpenTheatre());
        }
    }
}
