using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp9
{
    internal class Program
    {
        static void String()
        {
            Console.WriteLine("Вариант 2\nВыберите из вариантов:");
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            if (s == "")
            {
                Word str = new Word();
                str.String2();
            }
            else
            {
                Word str = new Word(s);
                str.String2();
            }
            Console.WriteLine("Вариант 7 \nДаны три строки.Вывести их на экран по порядку увеличения символов в них (без пробелов)");
            Console.WriteLine("Введите строку1:");
            string str2 = Console.ReadLine();
            Console.WriteLine("Введите строку2:");
            string str3 = Console.ReadLine();
            Console.WriteLine("Введите строку3:");
            string str4 = Console.ReadLine();
            if (str2 == "" && str3 == "" && str4 == "")
            {
                WordTwo str = new WordTwo();
                str.String();
            }
            else
            {
                WordTwo str = new WordTwo(str2,str3,str4);
                str.String();
            }
        }
        static void Sort1()
        {
            int n = SParse("Введите длину массива: ");
            if (n == 0)
            {
                Array arr = new Array();
                arr.Sort();
            }
            else
            {
                Array arr = new Array(n);
                arr.Sort();
            }
        }
        static int SParse(string str)
        {
            int a = 0;
            bool twoNumber = false;
            Console.WriteLine(str);
            while (twoNumber == false)
            {
                twoNumber = int.TryParse(Console.ReadLine(), out a);
                if (twoNumber == false && a > 0)
                {
                    Console.WriteLine("Ошибка, попробуйте ещё раз");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Ошибка, длина массива не может быть отрицательной, попробуйте ещё раз");
                    twoNumber = false;
                }
                else if (twoNumber == false && a == 0) 
                {
                    twoNumber = true;
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 2");
            bool isExit = false;
            while (isExit == false)
            {
                int c = Parse.Parses("1.Отгадай ответ\n" + "2.Об авторе\n" + "3.Проверка деления числа на ноль\n" + "4.Сортировка\n" + "5.Крестки нолики(4*4)\n" + "6.Работа со строками\n" + "7.Выход\n");
                switch (c)
                {
                    case 1:
                        Function.Funct();
                        break;
                    case 2:
                        DLC.Print();
                        break;
                    case 3:
                        Function.Check();
                        break;
                    case 4:
                        Sort1();
                        break;
                    case 5:
                        Game play = new Game();
                        play.tic_tac_toe();
                        break;
                    case 6:
                        String();
                        break;
                    case 7:
                        isExit = DLC.Exit();
                        break;

                }
            }

        }
    }
}