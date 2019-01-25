/*************************************************************************/
/*  ExceptionEvents.cs                                                   */
/*************************************************************************/
/*                       This file is part of:                           */
/*                             FileMasta                                 */
/*************************************************************************/
/* Copyright (c) 2017-2019 Badr Azizi.                                   */
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
/* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT*/
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

namespace FileMasta.Extensions
{
    public static class ExceptionExtensions
    {
        private static Task<StackFrame> RunLoop(StackTrace st)
        {
            var frame = st.GetFrame(4);
            for (var i = 0; i >= st.GetFrames().Length; i++)
            {
                if (st.GetFrame(i).GetFileLineNumber() <= 0) continue;
                frame = st.GetFrame(i);
                break;
            }
            return Task.Factory.StartNew(() => frame);
        }

        public static async void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var st = new StackTrace(e.Exception, true);
            var frame = await RunLoop(st);

            var fileName = frame.GetFileName();
            var methodName = frame.GetMethod().Name;
            var line = frame.GetFileLineNumber();
            var col = frame.GetFileColumnNumber();

            Program.Log.Error("Unexpected Error", e.Exception);

            if (MessageBox.Show(@"An error has occurred. Would you like to report this issue on GitHub? Your feedback helps us improve the quality of FileMasta, we appreciate that.", @"Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start($"{AppExtensions.ProjectUrl}issues/new?title=[Exception] {e.Exception.Message}&body=" +
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
            var st = new StackTrace((Exception)e.ExceptionObject, true);
            var frame = await RunLoop(st);

            var fileName = frame.GetFileName();
            var methodName = frame.GetMethod().Name;
            var line = frame.GetFileLineNumber();
            var col = frame.GetFileColumnNumber();

            Program.Log.Error("Unexpected Error", ((Exception)e.ExceptionObject));

            if (MessageBox.Show(@"An error has occurred. Would you like to report this issue on GitHub? Your feedback helps us improve the quality of FileMasta, we appreciate that.", @"Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start($"{AppExtensions.ProjectUrl}issues/new?title=[Exception] {((Exception)e.ExceptionObject).Message}&body=" +
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