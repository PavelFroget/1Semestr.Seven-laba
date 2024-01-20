using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 6.
    /// </summary>
    internal class WordTwo
    {
        private string strc;
        private string stra;
        private string strb;
        private string str5 = "Как уже ветерок весенний";
        private string str6 = "Поселился в зеленом ростке";
        private string str7 = "Не успела отнять руки";
        /// <summary>
        /// Конструктор без параметра.
        /// </summary>
        /// <param name="strс">Строка.</param>
        /// <param name="stra">Строка.</param>
        /// <param name="strb">Строка.</param>
        public WordTwo()
        {
            this.strc = str5;
            this.stra = str6;
            this.strb = str7;
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="strс">Строка.</param>
        /// <param name="stra">Строка.</param>
        /// <param name="strb">Строка.</param>
        public WordTwo(string str2,string str3, string str4)
        {
            this.strc = str2;
            this.stra = str3;
            this.strb = str4;
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4.
        /// </summary>
        /// <param name="strс">Строка.</param>
        /// <param name="stra">Строка.</param>
        /// <param name="strb">Строка.</param>
        public void String()
        {
            Wordcomparison(strc,stra,strb);
        }
        /// <summary>
        /// Сортировка строк по количеству символов в них.
        /// </summary>
        /// <param name="strc">Строка.</param>
        /// <param name="stra">Строка.</param>
        /// <param name="strb">Строка.</param>
        private void Wordcomparison(string strc, string stra, string strb)
        {
            Console.WriteLine("Ваши строчки:");
            Console.Write("\n1 " + strc + "\n2 " + stra + "\n3 " + strb + "\n\r");
            Console.Write('\n');
            string str1 = strc.Replace(" ", "");
            string str2 = stra.Replace(" ", "");
            string str3 = strb.Replace(" ", "");
            string[] array = { str1, str2, str3 };
            string temp = "";
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].Length > array[j + 1].Length)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == str1)
                {
                    Console.Write("" + strc + " - количество символов: " + str1.Length + "\n");
                }
                else if (array[i] == str2)
                {
                    Console.Write("" + stra + " - количество символов: " + str2.Length + "\n");
                }
                else if (array[i] == str3)
                {
                    Console.Write("" + strb + " - количество символов: " + str3.Length + "\n");
                }
            }
            Console.WriteLine("\r\n");
        }
    }
}
