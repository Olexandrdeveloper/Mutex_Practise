using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Mutex_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ====== TASK 1 ======
            //BankAccount acc = new BankAccount(1000);

            //Thread[] threads = new Thread[6];

            //threads[0] = new Thread(() => acc.Deposit(200));
            //threads[1] = new Thread(() => acc.Withdraw(150));
            //threads[2] = new Thread(() => acc.Deposit(500));
            //threads[3] = new Thread(() => acc.Withdraw(300));
            //threads[4] = new Thread(() => acc.Withdraw(800));
            //threads[5] = new Thread(() => acc.Deposit(100));

            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i].Start();
            //}

            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i].Join();
            //}

            //Console.WriteLine("\nКінцевий баланс: " + acc.GetBalance());




            //// ====== TASK 2 ======
            //int counter = 0;

            //Thread[] threads = new Thread[5];

            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i] = new Thread(() =>
            //    {
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            Interlocked.Increment(ref counter);
            //        }
            //    });
            //}

            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i].Start();
            //}

            //for (int i = 0; i < threads.Length; i++)
            //{
            //    threads[i].Join();
            //}

            //Console.WriteLine("Загальна кількість: " + counter);




            //// ====== TASK 3 ======
            //TaskQueue queue = new TaskQueue(2);

            //for (int i = 1; i <= 5; i++)
            //{
            //    queue.EnqueueTask(i);
            //}

            //Console.WriteLine("\nВсього виконано завдань: " + queue.GetCompletedCount());




            //// ====== TASK 4 ======
            //string path = "data.txt";
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}

            //FileWriter writer = new FileWriter();

            //Thread t1 = new Thread(() => writer.Write("Перший потік"));
            //Thread t2 = new Thread(() => writer.Write("Другий потік"));
            //Thread t3 = new Thread(() => writer.Write("Третій потік"));

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Console.WriteLine("\nВміст файлу:");
            //string content = File.ReadAllText(path);
            //Console.Write(content);




            //// ====== TASK 5 ======
            //int[] nums = { 1, 2, 3, 4, 5 };
            //ArrayOperations ops = new ArrayOperations(nums);

            //Thread t1 = new Thread(() => ops.AddTo(5));
            //Thread t2 = new Thread(() => ops.MultiplyTo(2));
            //Thread t3 = new Thread(() => ops.AddTo(10));

            //t1.Start();
            //t2.Start();
            //t3.Start();

            //t1.Join();
            //t2.Join();
            //t3.Join();

            //Console.Write("\nКінцевий масив: ");
            //ops.Print();
        }
    }
}
