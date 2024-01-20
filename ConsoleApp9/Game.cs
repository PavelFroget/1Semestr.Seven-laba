using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 5.
    /// </summary>
    class Game
    {
        private int a = 4;
        private int x;
        private int y;
        private const int n = 1;
        private const int m = 2;
        /// <summary>
        /// Заполнение двухмерного массива нулями.
        /// </summary>
        /// <param name="a">Длины массива.</param>
        /// <param name="newArray">Двухмерный массив.</param>
        /// <returns></returns>
        private int[,] WArray()
        {
            Console.WriteLine();
            int[,] newArray = new int[a, a];
            return newArray;
        }
        /// <summary>
        /// Заполнение двухмерного массива нулями.
        /// </summary>
        /// <param name="newArray">Двухмерный массив.</param>
        /// <returns></returns>
        private int[,] CopyWArray(int[,] newArray)
        {
            Console.WriteLine();
            int[,] newArray1 = newArray;
            return newArray1;
        }
        /// <summary>
        /// Вывод игрового поля.
        /// </summary>
        /// <param name="newArray">Двухмерный массив.</param>
        /// <param name="x">Коориданты массива.</param>
        /// <param name="y">Координаты массива.</param>
        private void PrintGame(int[,] newArray)
        {
            Console.WriteLine("X: 1     2     3     4   Y:");
            for (y = 0; y < newArray.GetLength(0); y++)
            {
                Console.WriteLine("┼─────┼─────┼─────┼─────┼");
                for (x = 0; x < newArray.GetLength(1); x++)
                {
                    Console.Write("│  ");
                    if (newArray[x, y] == 0)
                    {
                        string n = new string(' ', 1);
                        Console.Write(n + "  ");
                    }
                    else if (newArray[x, y] != 0)
                    {
                        if (newArray[x, y] == 1)
                        {
                            Console.Write("X" + "  ");
                        }
                        else
                        {
                            Console.Write("O" + "  ");
                        }
                    }

                }
                Console.WriteLine("│" + (y+1));
            }
            Console.WriteLine("┼─────┼─────┼─────┼─────┼");
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 5.
        /// </summary>
        public void tic_tac_toe()
        {
            Console.WriteLine("Игроки по очереди ставят фигуры на свободные клетки поля.\r\nПервый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, выиг-рывает.\r\nПервый ход делает игрок, ставящий крестики.");
            int[,] newArray1 = WArray();
            PrintGame(newArray1);
            int[,] newArray2 = Players(newArray1);
            Console.WriteLine("Конец Игры!\n");
        }
        /// <summary>
        /// Условия выигрыша.
        /// </summary>
        /// <param name="newArray1">Двухмерный скопированный массив.</param>
        private int[,] Players(int[,] newArray1)
        {
            for (int i = 15; i > -1; --i)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Ход игрока 1");
                    Console.WriteLine("Введите координаты");
                    Player12(newArray1, n);
                    if (newArray1[0, 0] == 1 & newArray1[1, 0] == 1 & newArray1[2, 0] == 1 |
                        newArray1[0, 1] == 1 & newArray1[1, 1] == 1 & newArray1[2, 1] == 1 |
                        newArray1[0, 2] == 1 & newArray1[1, 2] == 1 & newArray1[2, 2] == 1 |
                        newArray1[0, 3] == 1 & newArray1[1, 3] == 1 & newArray1[2, 3] == 1 |
                        newArray1[1, 0] == 1 & newArray1[2, 0] == 1 & newArray1[3, 0] == 1 |
                        newArray1[1, 1] == 1 & newArray1[2, 1] == 1 & newArray1[2, 1] == 1 |
                        newArray1[1, 2] == 1 & newArray1[2, 2] == 1 & newArray1[3, 2] == 1 |
                        newArray1[2, 3] == 1 & newArray1[2, 3] == 1 & newArray1[3, 3] == 1 |
                        newArray1[0, 0] == 1 & newArray1[0, 1] == 1 & newArray1[0, 2] == 1 |
                        newArray1[1, 0] == 1 & newArray1[1, 1] == 1 & newArray1[1, 2] == 1 |
                        newArray1[2, 0] == 1 & newArray1[2, 1] == 1 & newArray1[2, 2] == 1 |
                        newArray1[3, 0] == 1 & newArray1[3, 1] == 1 & newArray1[3, 2] == 1 |
                        newArray1[0, 1] == 1 & newArray1[0, 2] == 1 & newArray1[0, 3] == 1 |
                        newArray1[1, 1] == 1 & newArray1[1, 2] == 1 & newArray1[1, 3] == 1 |
                        newArray1[2, 1] == 1 & newArray1[2, 2] == 1 & newArray1[2, 3] == 1 |
                        newArray1[3, 1] == 1 & newArray1[3, 2] == 1 & newArray1[3, 3] == 1 |
                        newArray1[0, 0] == 1 & newArray1[1, 1] == 1 & newArray1[2, 2] == 1 |
                        newArray1[0, 1] == 1 & newArray1[1, 2] == 1 & newArray1[2, 3] == 1 |
                        newArray1[1, 0] == 1 & newArray1[2, 1] == 1 & newArray1[3, 2] == 1 |
                        newArray1[1, 1] == 1 & newArray1[2, 2] == 1 & newArray1[3, 3] == 1 |
                        newArray1[3, 0] == 1 & newArray1[2, 1] == 1 & newArray1[1, 2] == 1 |
                        newArray1[2, 0] == 1 & newArray1[1, 1] == 1 & newArray1[0, 2] == 1 |
                        newArray1[3, 1] == 1 & newArray1[2, 2] == 1 & newArray1[1, 3] == 1 |
                        newArray1[2, 1] == 1 & newArray1[1, 2] == 1 & newArray1[0, 3] == 1)
                    {
                        Console.WriteLine("Победа игрока 1");
                        i = -10;
                    }
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Ход игрока 2");
                    Console.WriteLine("Введите координаты");
                    Player12(newArray1, m);
                    if (newArray1[0, 0] == 2 & newArray1[1, 0] == 2 & newArray1[2, 0] == 2 |
                        newArray1[0, 1] == 2 & newArray1[1, 1] == 2 & newArray1[2, 1] == 2 |
                        newArray1[0, 2] == 2 & newArray1[1, 2] == 2 & newArray1[2, 2] == 2 |
                        newArray1[0, 3] == 2 & newArray1[1, 3] == 2 & newArray1[2, 3] == 2 |
                        newArray1[1, 0] == 2 & newArray1[2, 0] == 2 & newArray1[3, 0] == 2 |
                        newArray1[1, 1] == 2 & newArray1[2, 1] == 2 & newArray1[2, 1] == 2 |
                        newArray1[1, 2] == 2 & newArray1[2, 2] == 2 & newArray1[3, 2] == 2 |
                        newArray1[2, 3] == 2 & newArray1[2, 3] == 2 & newArray1[3, 3] == 2 |
                        newArray1[0, 0] == 2 & newArray1[0, 1] == 2 & newArray1[0, 2] == 2 |
                        newArray1[1, 0] == 2 & newArray1[1, 1] == 2 & newArray1[1, 2] == 2 |
                        newArray1[2, 0] == 2 & newArray1[2, 1] == 2 & newArray1[2, 2] == 2 |
                        newArray1[3, 0] == 2 & newArray1[3, 1] == 2 & newArray1[3, 2] == 2 |
                        newArray1[0, 1] == 2 & newArray1[0, 2] == 2 & newArray1[0, 3] == 2 |
                        newArray1[1, 1] == 2 & newArray1[1, 2] == 2 & newArray1[1, 3] == 2 |
                        newArray1[2, 1] == 2 & newArray1[2, 2] == 2 & newArray1[2, 3] == 2 |
                        newArray1[3, 1] == 2 & newArray1[3, 2] == 2 & newArray1[3, 3] == 2 |
                        newArray1[0, 0] == 2 & newArray1[1, 1] == 2 & newArray1[2, 2] == 2 |
                        newArray1[0, 1] == 2 & newArray1[1, 2] == 2 & newArray1[2, 3] == 2 |
                        newArray1[1, 0] == 2 & newArray1[2, 1] == 2 & newArray1[3, 2] == 2 |
                        newArray1[1, 1] == 2 & newArray1[2, 2] == 2 & newArray1[3, 3] == 2 |
                        newArray1[3, 0] == 2 & newArray1[2, 1] == 2 & newArray1[1, 2] == 2 |
                        newArray1[2, 0] == 2 & newArray1[1, 1] == 2 & newArray1[0, 2] == 2 |
                        newArray1[3, 1] == 2 & newArray1[2, 2] == 2 & newArray1[1, 3] == 2 |
                        newArray1[2, 1] == 2 & newArray1[1, 2] == 2 & newArray1[0, 3] == 2)

                    {
                        Console.WriteLine("Победа игрока 2");
                        i = -10;
                    }
                }
                else if (i == 0)
                {
                    Console.WriteLine("Ничья");
                    i = -10;
                }
            }
            return newArray1;
        }
        /// <summary>
        /// Проверка координат и ячеек.
        /// </summary>
        /// <param name="newArray1">Двухмерный скопированный массив.</param>
        /// /// <param name="p">Переменная идущая в метода вывод.</param>
        private void Player12(int[,] newArray1, int p)
        {
            bool OExit = false;
            while (OExit == false)
            {
                int x1 = Parse.Parses("X:");
                x = x1 - 1;
                int y2 = Parse.Parses("Y:");
                y = y2 - 1;
                if (x > 3 | y > 3 | x < 0 | y < 0)
                {
                    Console.WriteLine("Ошибка, выход за границы поля");
                    Console.WriteLine("Попробуйте ещё раз");
                }
                else
                {
                    if (newArray1[x, y] == 1 | newArray1[x, y] == 2)
                    {
                        Console.WriteLine("Ошибка, ячейка уже занята");
                    }
                    else
                    {
                        newArray1[x, y] = p;
                        OExit = true;
                    }
                }

            }
            Console.WriteLine(' ');
            PrintGame(newArray1);

        }
    }
}
