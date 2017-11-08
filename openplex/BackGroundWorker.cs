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
