using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Mutex_Practise
{
    internal class FileWriter
    {
        private static Mutex mutex = new Mutex();
        private string path = "data.txt";

        public void Write(string text)
        {
            mutex.WaitOne();
            try
            {
                File.AppendAllText(path, text + "\n");
                Console.WriteLine("Записано: " + text);
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
