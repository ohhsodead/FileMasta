using FileMasta.Utilities;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Net;

namespace FileMasta
{
    static class Program
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static WebClient _webClient = new WebClient();
        private static Mutex _MutexInstance = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _MutexInstance = new Mutex(true, "FileMasta", out bool createdNew);

            if (!createdNew)
            {
                Log.Warn("There is already an instance of FileMasta running");  
                return;
            }

            if (Debugger.IsAttached)
            {
                Properties.Settings.Default.Reset();
                Run();
                return;
            }

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ExceptionHandler.ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += ExceptionHandler.CurrentDomainUnhandledException;

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