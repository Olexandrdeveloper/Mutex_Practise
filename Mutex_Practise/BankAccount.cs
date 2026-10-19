using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutex_Practise
{
    internal class BankAccount
    {
        private int money;
        private object locker = new object();

        public BankAccount(int startMoney)
        {
            money = startMoney;
        }

        public void Deposit(int amount)
        {
            lock (locker)
            {
                money = money + amount;
                Console.WriteLine("Поповнено: " + amount + " | Баланс: " + money);
            }
        }

        public void Withdraw(int amount)
        {
            lock (locker)
            {
                if (money >= amount)
                {
                    money = money - amount;
                    Console.WriteLine("Знято: " + amount + " | Баланс: " + money);
                }
                else
                {
                    Console.WriteLine("Недостатньо коштів для зняття: " + amount);
                }
            }
        }

        public int GetBalance()
        {
            return money;
        }
    }
}
