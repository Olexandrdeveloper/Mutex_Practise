using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutex_Practise
{
    internal class ArrayOperations
    {
        private int[] array;
        private object locker = new object();

        public ArrayOperations(int[] array)
        {
            this.array = array;
        }

        public void AddTo(int value)
        {
            Monitor.Enter(locker);
            try
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = array[i] + value;

                Console.WriteLine("Додано " + value + " до елементів");
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }

        public void MultiplyTo(int value)
        {
            Monitor.Enter(locker);
            try
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = array[i] * value;

                Console.WriteLine("Помножено елементи на " + value);
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }

        public void Print()
        {
            foreach (int num in array)
                Console.Write(num + " ");

            Console.WriteLine();
        }
    }
}
