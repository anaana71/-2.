#region 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            int counter = 3;
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Введите логин");
                login = Console.ReadLine();
                if (login != "root") Console.WriteLine("Пользователь не найден в системе. Повторите попытку");
                else break;
            }
            do
            {
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                if (password != "GeekBrains")
                {
                    counter--;
                    Console.WriteLine($"Введен некорректный пароль. Осталось {counter} попыток");
                }
                else
                {
                    Console.WriteLine("Авторизация успешна!");
                    break;
                }
            }
            while (counter != 0);
            if (counter == 0) Console.WriteLine("Слишком много попыток ввода. Попробуйте позже.");
            Console.ReadKey();
        }
    }
}
