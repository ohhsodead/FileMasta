using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using ExceptionHandler;

namespace WebCrunch
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
                Properties.Settings.Default.Reset();
                Run();
                return;
            }


            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ExceptionEvents.ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += ExceptionEvents.CurrentDomainUnhandledException;

            Run();
        }

        static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        private static void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }

        private static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.ExceptionObject.ToString());
        }

    }
}
