using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 4.
    /// </summary>
    class Array
    {
        private int _n;
        private int[] array;
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        public Array(int n)
        {
            this._n = n;
        }
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Array()
        {
            this._n = 10;
        }
        public int Arraylength
        {
            get
            {
                return _n;
            }
            set
            {
                _n = value;
            }
        }
        /// <summary>
        /// Заполнение массива случайными элементами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        /// <param name="array">Массив.</param>
        /// <returns></returns>
        private int[] Array1(int _n)
        {
            array = new int[_n];
            Random rnd = new Random();
            for (int i = 0; i < _n; i++)
            {
                array[i] = rnd.Next(-10, 10);
            }
            return array;
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        /// <param name="array">Массив.</param>
        public void Sort()
        {
            array = Array1(_n);
            PrintSort(array);
            int[] array1 = CopyArray(array);
            Bubble(array);
            Insertion(array1);
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Вывод элементов массива.
        /// </summary>
        /// <param name="array">Массив.</param>
        public void PrintSort(int[] array)
        {
            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\r\n");
        }
        /// <summary>
        /// Копирование массива.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <returns></returns>
        private int[] CopyArray(int[] array)
        {
            int[] array1 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i];
            }
            return array1;
        }
        /// <summary>
        /// Сортировка "пузырьком".
        /// </summary>
        /// <param name="array">Массив.</param>
        public void Bubble(int[] array)
        {
            Console.WriteLine("1.Сортировка Пузырьком");
            var sw = new Stopwatch();
            sw.Start();
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            sw.Stop();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\r\n");
            Console.WriteLine($"Время работы сортировки:{sw.Elapsed}");
        }
        /// <summary>
        /// Сортировка "вставками".
        /// </summary>
        /// <param name="array">Массив.</param>
        public void Insertion(int[] array1)
        {
            Console.WriteLine("2.Сортировка Вставками");
            var sw = new Stopwatch();
            sw.Start();
            int index;
            int num;
            for (int i = 0; i < array1.Length; i++)
            {
                index = i;
                num = array1[i];
                while (index > 0 && num < array1[index - 1])
                {
                    array1[index] = array1[index - 1];
                    index--;

                }
                array1[index] = num;
            }
            sw.Stop();
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine("\r\n");
            Console.WriteLine($"Время работы сортировки:{sw.Elapsed}");

        }
    }
}
