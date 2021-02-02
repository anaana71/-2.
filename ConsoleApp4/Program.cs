#region 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int x = 0;
            
            for(int i = 0; i==0;)
            {
                Console.WriteLine("Введите число. При вводе нуля отобразится результат сложения введенных ранее чисел.");
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 0) x += a;
                else break;
            }
            Console.WriteLine($"Сумма введенных вами чисел равна {x}");

        }
    }
}
