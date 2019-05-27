using FileMasta.Core.Extensions;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMasta.Extensions
{
    public static class ExceptionExtensions
    {
        private static Task<StackFrame> RunLoop(StackTrace st)
        {
            StackFrame frame = st.GetFrame(4);
            for (int i = 0; i >= st.GetFrames().Length; i++)
            {
                if (st.GetFrame(i).GetFileLineNumber() <= 0) continue;
                frame = st.GetFrame(i);
                break;
            }
            return Task.Factory.StartNew(() => frame);
        }

        public static async void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            StackTrace st = new StackTrace(e.Exception, true);
            StackFrame frame = await RunLoop(st);

            string fileName = frame.GetFileName();
            string methodName = frame.GetMethod().Name;
            int line = frame.GetFileLineNumber();
            int col = frame.GetFileColumnNumber();

            Program.Log.Error("Unexpected Error", e.Exception);

            if (MessageBox.Show(@"An error has occurred. Would you like to report this issue on GitHub? Your feedback helps us improve the quality of FileMasta, we appreciate that.", @"Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start($"{Configuration.ProjectUrl}issues/new?title=[Exception] {e.Exception.Message}&body=" +
                "*Please explain the problem, be clear and not vague.*%0A%0A" +
                "__Expected behavior__: %0A" +
                "__Actual behavior__: %0A" +
                "__Steps to reproduce the behavior__: %0A" +
                "%0A ----------------------- %0A" +
                "Version: " + Application.ProductVersion +
                "%0AFile Name: " + Path.GetFileName(fileName) +
                "%0AMethod Name: " + methodName +
                "%0ALine: " + line +
                "%0AColumn: " + col +
                "%0A ----------------------- %0A" +
                e.Exception);
            }
        }

        public static async void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            StackTrace st = new StackTrace((Exception)e.ExceptionObject, true);
            StackFrame frame = await RunLoop(st);

            string fileName = frame.GetFileName();
            string methodName = frame.GetMethod().Name;
            int line = frame.GetFileLineNumber();
            int col = frame.GetFileColumnNumber();

            Program.Log.Error("Unexpected Error", ((Exception)e.ExceptionObject));

            if (MessageBox.Show(@"An error has occurred. Would you like to report this issue on GitHub? Your feedback helps us improve the quality of FileMasta, we appreciate that.", @"Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start($"{Configuration.ProjectUrl}issues/new?title=[Exception] {((Exception)e.ExceptionObject).Message}&body=" +
                "*Please explain the problem, be clear and not vague.*%0A%0A" +
                "__Expected behavior__: %0A" +
                "__Actual behavior__: %0A" +
                "__Steps to reproduce the behavior__: %0A" +
                "%0A ----------------------- %0A" +
                "Version: " + Application.ProductVersion +
                "%0AFile Name: " + Path.GetFileName(fileName) +
                "%0AMethod Name: " + methodName +
                "%0ALine: " + line +
                "%0AColumn: " + col +
                "%0A ----------------------- %0A" +
                (Exception)e.ExceptionObject);
            }
        }
    }
}