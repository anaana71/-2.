#region Naumov

#endregion
#region 1. Написать метод, возвращающий минимальное из трех чисел.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            Console.WriteLine("Введите первое число");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            arr[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимальное число: {Method(arr)}");
        }

        static int Method(int[]arr)
        {
            int max = 0;

            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > max) max = arr[i];                
            }

            return max;
        }
    }
}
