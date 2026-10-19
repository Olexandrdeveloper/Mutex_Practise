using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutex_Practise
{
    internal class TaskQueue
    {
        private Semaphore sem;
        private int maxThreads;
        private int completedCount;
        private object locker = new object();

        public TaskQueue(int maxThreads)
        {
            this.maxThreads = maxThreads;
            this.sem = new Semaphore(maxThreads, maxThreads);
            this.completedCount = 0;
        }

        public void EnqueueTask(int taskId)
        {
            Thread t = new Thread(() =>
            {
                sem.WaitOne();

                Console.WriteLine("Завдання " + taskId + " почалося");
                Thread.Sleep(500);
                Console.WriteLine("Завдання " + taskId + " завершилося");

                lock (locker)
                {
                    completedCount++;
                }

                sem.Release();
            });

            t.Start();
            t.Join();
        }

        public int GetCompletedCount()
        {
            return completedCount;
        }
    }
}
