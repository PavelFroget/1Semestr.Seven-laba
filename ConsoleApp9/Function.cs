using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    static class Function
    {
        public static void Funct()
        {
            int b = Parse.Parses("Введите число b для натурального логорифма:");
            int a = Parse.Parses("Введите число a для синуса:");
            double I = Calsulation(a, b);
            Game(I);
            Console.WriteLine("\n");
        }
        public static void Game(double I)
        {
            for (int num = 2; num > -1; num--)
            {
                double n = Parse.Parses("Чему равно значение функции?");
                if (n == I)
                {
                    Console.WriteLine("Правильный ответ");
                    num = -10;
                }
                else
                {
                    if (num > 0)
                    {
                        Console.WriteLine("Неправильный ответ, попробуйте ещё раз");
                        Console.WriteLine("У вас осталось попыток: " + num);
                    }
                    else
                    {
                        Console.WriteLine("У вас не осталось попыток");
                        Console.WriteLine("Правильный ответ: " + I);
                        num = -10;
                    }
                }
            }
        }
        private static double Calsulation(int a, int b)
        {
            const double PI = Math.PI;
            double z = Math.Log(Math.Pow(b, 5));
            double y = Math.Sin(Math.PI * a / 180) + 1;
            double f = PI * (z / y);
            double I = Math.Round(f);
            return I;
        }
        public static void Check()
        {
            int u = Parse.Parses("Введите число 1: ");
            int i = Parse.Parses("Введите число 2: ");
            Check0(i, u);

        }
        private static void Check0( int i, int u)
        {
            try
            {
                int result = u / i;
                Console.WriteLine("Ответ: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
            finally
            {
                Console.WriteLine("Конец проверки");
            }
        }
    }
}
