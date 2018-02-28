using System;
using System.ComponentModel;

namespace FileMasta.Asynchronous
{
    public static class BackGroundWorker
    {
        /// <summary>
        /// the actual method invoked here
        /// </summary>
        /// <typeparam name="T">a generic return type</typeparam>
        /// <param name="bgw">the BackgroundWorker</param>
        /// <param name="work">method passed as argument</param>
        /// <param name="completedWork">the return value</param>
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

        /// <summary>
        /// start a returned type method in backgroundworker
        /// </summary>
        /// <typeparam name="T">a generic return type</typeparam>
        /// <param name="work">method passed as argument</param>
        /// <param name="completedWork">the return value</param>
        public static void RunWorkAsync<T>(Func<T> work, Action<T> completedWork = null)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.StartWorker<T>(work, completedWork);

            worker.RunWorkerAsync();
        }

        /// <summary>
        /// the actual method invoked here
        /// </summary>
        /// <param name="bgw">the BackgroundWorker</param>
        /// <param name="work">method passed as argument</param>
        private static void StartWorker(this BackgroundWorker bgw, Action work)
        {
            bgw.DoWork += new DoWorkEventHandler(delegate (object obj, DoWorkEventArgs args)
            {
                args.Result = work.DynamicInvoke();
            });
        }

        /// <summary>
        /// start a void method in backgroundworker 
        /// </summary>
        /// <param name="work">Method passed as argument</param>
        /// <param name="completed">the completed work event handler</param>
        public static void RunWorkAsync(Action work, RunWorkerCompletedEventHandler completed = null)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.StartWorker(work);
            if (completed != null) { worker.RunWorkerCompleted += completed; }
            worker.RunWorkerAsync();
        }
    }
}