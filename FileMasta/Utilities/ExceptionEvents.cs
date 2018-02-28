/*************************************************************************/
/*  ExceptionExtensions.cs                                               */
/*************************************************************************/
/*                       This file is part of:                           */
/*                             FileMasta                                 */
/*************************************************************************/
/* Copyright (c) 2017-2017 Badr Azizi.                                   */
/*                                                                       */
/* Permission is hereby granted, free of charge, to any person obtaining */
/* a copy of this software and associated documentation files (the       */
/* "Software"), to deal in the Software without restriction, including   */
/* without limitation the rights to use, copy, modify, merge, publish,   */
/* distribute, sublicense, and/or sell copies of the Software, and to    */
/* permit persons to whom the Software is furnished to do so, subject to */
/* the following conditions:                                             */
/*                                                                       */
/* The above copyright notice and this permission notice shall be        */
/* included in all copies or substantial portions of the Software.       */
/*                                                                       */
/* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,       */
/* EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF    */
/* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.*/
/* IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY  */
/* CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,  */
/* TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE     */
/* SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.                */
/*************************************************************************/

using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileMasta.GitHub;

namespace FileMasta.Utilities
{
    public static class ExceptionEvents
    {
        public static Task<StackFrame> RunLoop(StackTrace ST)
        {
            StackTrace st = ST;
            StackFrame frame = st.GetFrame(4);
            for (int i = 0; i < st.GetFrames().Length; i++)
            {
                if (st.GetFrame(i).GetFileLineNumber() > 0)
                {
                    frame = st.GetFrame(i);
                    break;
                }
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

            Program.log.Error("Unexpected Error", e.Exception);

            if (MessageBox.Show("An error has occurred. Would you like to report this issue on GitHub?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start($"{OpenLink.urlGitHub}issues/new?title=[Exception] {e.Exception.Message}&body=" +
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

            Program.log.Error("Unexpected Error", ((Exception)e.ExceptionObject));

            if (MessageBox.Show("An error has occurred. Would you like to report this issue on GitHub?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start($"{OpenLink.urlGitHub}issues/new?title=[Exception] {((Exception)e.ExceptionObject).Message}&body=" +
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