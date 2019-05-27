using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Net;
using FileMasta.Extensions;

namespace FileMasta
{
    internal static class Program
    {
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static readonly WebClient WebClient = new WebClient();
        private static Mutex _mutexInstance;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            _mutexInstance = new Mutex(true, "FileMasta", createdNew: out bool createdNew);

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
            Application.ThreadException += ExceptionExtensions.ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException += ExceptionExtensions.CurrentDomainUnhandledException;

            Run();
        }

        private static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}