/*************************************************************************/
/*  BackGroundWorker.cs                                                  */
/*************************************************************************/
/*                       This file is part of:                           */
/*                            OpenPlex                                   */
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
using System.ComponentModel;

namespace OpenPlex
{
    public static class BackGroundWorker
    {
        private static void StartWorker<T>(this BackgroundWorker bgw, Func<T> work, Action<T> completedWork = null)
        {
            bgw.DoWork += new DoWorkEventHandler(delegate (object obj, DoWorkEventArgs args)
            {
                args.Result = work.Invoke();
            });
            if (completedWork != null)
            {
                bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate (object obj, RunWorkerCompletedEventArgs args)
                {
                    completedWork.Invoke((T)args.Result);
                });
            }
        }

        public static void RunWorkAsync<T>(Func<T> work, Action<T> completedWork = null)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.StartWorker<T>(work, completedWork);

            worker.RunWorkerAsync();
        }
    }
}
