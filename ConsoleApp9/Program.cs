#region 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Loop(a, b, 0);
        }

        static void Loop(int a, int b, int sum)
        {
            sum+=a;
            Console.Write("{0,4} ", a);
            if (a < b)  Loop(a + 1, b, sum);                              
            
            else Console.WriteLine($"\n Сумма чисел от а до b: {sum}");
        }        
    }
}

