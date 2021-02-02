#region 6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            System.Threading.Thread.Sleep(20);
            int counter = 0;
            for (int i = 1; i < 1000000000; i++)
            {                
                if(i % RecursiveSum(i)==0) counter++;
            }
            Console.WriteLine(counter);
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Время выполнения программы:{finish - start}");
            Console.ReadKey();
        }
        static long RecursiveSum(long a)
        {
            if (a == 0) return 0;
            else return RecursiveSum(a / 10) + a % 10;
        }
    }
}
