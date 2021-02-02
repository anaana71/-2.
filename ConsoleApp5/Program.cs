#region 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Какой у вас рост?");
            var height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("Какой у вас вес?");
            var weight = Convert.ToInt32(Console.ReadLine());            
            var index = Convert.ToDouble(weight / (height * height));
            if(index<24.9&&index>18.5)
            {
                Console.WriteLine("ИМТ в норме");
            }
            else if(index<18.5)
            {
                Console.WriteLine($"Вам следует набрать по меньшей мере {Calculations(index, height)-weight} кг");
            }
            else if(index>24.9)
            {
                Console.WriteLine($"Вам следует похудеть по меньшей мере на {weight-Calculations(index, height)} кг");
            }
            
            Console.ReadKey();
        }
        static int Calculations(double index, double height)
        {
            if (index < 18.5)
            {
                return (int)(18.5 * height * height);
            }
            else if (index > 24.9)
            {
                return (int)(24.9 * height * height);
            }
            else return 0;
        }
    }
}
