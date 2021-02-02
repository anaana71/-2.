#region 2. Написать метод подсчета количества цифр числа.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Данное число состоит из {Method(number)} цифр");
        }
        static int Method(int number)
        {
            int counter = 1;

            while(number/10>1)
            {
                counter++;
                number /= 10;
            }
            return counter;
        }
    }
}
